using Spire.CompoundFile.Doc;
using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Converters;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal class Class834 : IDisposable
{
    private Body body_0;
    private BodyRegionCollection bodyRegionCollection_0;
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_13;
    private bool bool_14;
    private bool bool_15;
    private bool bool_16;
    private bool bool_17;
    private bool bool_18;
    private bool bool_19;
    private bool bool_2;
    private bool bool_20;
    private bool bool_21;
    private bool bool_22;
    private bool bool_23;
    private bool bool_24;
    private bool bool_25;
    private bool bool_26;
    private bool bool_27;
    private bool bool_28;
    private bool bool_29;
    private bool bool_3;
    private bool bool_30;
    private bool bool_31;
    private bool bool_32;
    private bool bool_33;
    private bool bool_34;
    private bool bool_35;
    private bool bool_36;
    private bool bool_37;
    private bool bool_38;
    private bool bool_39;
    private bool bool_4;
    private bool bool_40;
    private bool bool_41;
    private bool bool_42;
    private bool bool_43;
    private bool bool_44;
    private bool bool_45;
    private bool bool_46;
    private bool bool_47;
    private bool bool_48;
    private bool bool_49;
    private bool bool_5;
    private bool bool_50;
    private bool bool_51;
    private bool bool_52;
    private bool bool_53;
    private bool bool_54;
    private bool bool_55;
    private bool bool_56;
    private bool bool_57;
    private bool bool_58;
    private bool bool_59;
    private bool bool_6;
    private bool bool_60;
    private bool bool_61;
    private bool bool_62;
    private bool bool_63;
    private bool bool_64;
    private bool bool_65;
    private bool bool_66;
    private bool bool_67;
    private bool bool_68;
    private bool bool_69;
    private bool bool_7;
    private bool bool_70;
    private bool bool_71;
    private bool bool_72;
    private bool bool_73;
    private bool bool_74;
    private bool bool_75;
    private bool bool_76;
    private bool bool_8;
    private bool bool_9;
    private byte[] byte_0;
    private CellFormat cellFormat_0;
    private CharacterFormat characterFormat_0;
    private Class12 class12_0;
    private Class43 class43_0;
    private Class51 class51_0;
    private Class564 class564_0;
    private Class835 class835_0;
    private Class835 class835_1;
    private Class835 class835_2;
    private Class835 class835_3;
    private Class836 class836_0;
    private Class836 class836_1;
    private Class837 class837_0;
    private Class838 class838_0;
    private Class839 class839_0;
    private Class839 class839_1;
    private Class840 class840_0;
    private Class841 class841_0;
    private Class842 class842_0;
    private Class843 class843_0;
    private Column column_0;
    private Decoder decoder_0;
    private Decoder decoder_1;
    private Dictionary<string, Class839> dictionary_0;
    private Dictionary<int, Class843> dictionary_1;
    private Dictionary<int, CellFormat> dictionary_2;
    private Dictionary<string, string> dictionary_3;
    private Dictionary<string, ListStyle> dictionary_4;
    private Dictionary<string, string> dictionary_5;
    private Dictionary<string, Style> dictionary_6;
    private Dictionary<string, object> dictionary_7;
    private Dictionary<int, string> dictionary_8;
    private Dictionary<int, Class842> dictionary_9;
    private DocOleObject docOleObject_0;
    private DocPicture docPicture_0;
    private Document document_0;
    private double double_0;
    private double double_1;
    private Encoding encoding_0;
    private float float_0;
    private Footnote footnote_0;
    private HeaderFooterType headerFooterType_0;
    private const int int_0 = 20;
    private const int int_1 = 50;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_18;
    private int int_19;
    private int int_2;
    private int int_20;
    private int int_21;
    private int int_22;
    private int int_23;
    private int int_24;
    private int int_25;
    private int int_26;
    private int int_27;
    private int int_28;
    private int int_29;
    private int int_3;
    private int int_30;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    private IParagraph iparagraph_0;
    private IPicture ipicture_0;
    private ISection isection_0;
    private ITable itable_0;
    private ITextRange itextRange_0;
    private LineBreakClear lineBreakClear_0;
    private List<Paragraph> list_0;
    private List<byte> list_1;
    private List<Class51> list_2;
    private ListFormat listFormat_0;
    private ListLevel listLevel_0;
    private ListStyle listStyle_0;
    private ListStyle listStyle_1;
    private object object_0;
    private Paddings paddings_0;
    private Paragraph paragraph_0;
    private ParagraphFormat paragraphFormat_0;
    private ParagraphFormat paragraphFormat_1;
    private PropertyType propertyType_0;
    private Regex regex_0;
    private Regex regex_1;
    private Regex regex_2;
    private RowFormat rowFormat_0;
    private RtfTableType rtfTableType_0;
    private RtfTokenType rtfTokenType_0;
    private ShapeGroup shapeGroup_0;
    private ShapeObject shapeObject_0;
    private Stack<string> stack_0;
    private Stack<Dictionary<string, Class839>> stack_1;
    private Stack<Class835> stack_10;
    private Stack<Class835> stack_11;
    private Stack<Dictionary<string, ListStyle>> stack_12;
    private Stack<Dictionary<string, string>> stack_13;
    private Stack<Dictionary<string, Style>> stack_14;
    private Stack<bool> stack_15;
    private Stack<Body> stack_16;
    private Stack<Table> stack_17;
    private Stack<Dictionary<int, Class842>> stack_18;
    private Stack<string> stack_19;
    private Stack<Dictionary<int, Class843>> stack_2;
    private Stack<Class835> stack_20;
    private Stack<RowFormat> stack_21;
    private Stack<RowFormat> stack_22;
    private Stack<string> stack_23;
    private Stack<Class840> stack_24;
    private Stack<string> stack_25;
    private Stack<Dictionary<string, object>> stack_26;
    private Stack<string> stack_27;
    private Stack<int> stack_28;
    private Stack<string> stack_29;
    private Stack<int> stack_3;
    private Stack<string> stack_30;
    private Stack<Body> stack_31;
    private Stack<IParagraph> stack_32;
    private Stack<bool> stack_33;
    private Stack<ShapeObject> stack_34;
    private Stack<string> stack_35;
    private Stack<bool> stack_36;
    private Stack<string> stack_37;
    private Stack<bool> stack_38;
    private Stack<bool> stack_39;
    private Stack<string> stack_4;
    private Stack<string> stack_40;
    private Stack<string> stack_41;
    private Stack<Paragraph> stack_42;
    private Stack<Body> stack_43;
    private Stack<Dictionary<int, CellFormat>> stack_44;
    private Stack<ITable> stack_45;
    private Stack<TableRow> stack_46;
    private Stack<TableCell> stack_47;
    private Stack<string> stack_48;
    private Stack<string> stack_49;
    private Stack<string> stack_5;
    private Stack<string> stack_50;
    private Stack<LineBreakClear> stack_51;
    private Stack<ParagraphFormat> stack_52;
    private Stack<Paddings> stack_53;
    private Stack<Struct26> stack_54;
    private Stack<string> stack_6;
    private Stack<string> stack_7;
    private Stack<Dictionary<int, CellFormat>> stack_8;
    private Stack<Dictionary<int, CellFormat>> stack_9;
    private const string string_0 = "{";
    private const string string_1 = "}";
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_13;
    private string string_14;
    private string string_15;
    private string string_16;
    private string string_17;
    private string string_18;
    private string string_19;
    private const string string_2 = @"\";
    private string string_20;
    private string string_21;
    private string string_22;
    private string string_23;
    private string string_24;
    private string string_25;
    private string string_26;
    private string string_27;
    private string[] string_28;
    private string string_29;
    private const string string_3 = " ";
    private string string_30;
    private string string_31;
    private const string string_4 = "\r";
    private const string string_5 = "\n";
    private const string string_6 = ";";
    private const string string_7 = "pict";
    private string string_8;
    private string string_9;
    private Struct26 struct26_0;
    private Style style_0;
    private TabJustification tabJustification_0;
    private TabLeader tabLeader_0;
    private TableCell tableCell_0;
    private TableRow tableRow_0;
    private TextBox textBox_0;

    public Class834(Document A_0, TextReader A_1)
    {
        this.regex_0 = new Regex(BookmarkStart.b("焩ଫ猭ᠯ椱гᬵķ嬹ᄻ堽Ŀ潁Ƀᭅ㍇硉ㅋ杍硏籑繓罕籗", 4));
        this.regex_1 = new Regex(BookmarkStart.b("琩瀫䨭ᬯᘱ", 4));
        this.regex_2 = new Regex(BookmarkStart.b("琩眫ḭᴯ଱申ᬵ縷嬹ᄻ堽ᴿ楁恃", 4));
        this.rtfTableType_0 = RtfTableType.None;
        this.dictionary_0 = new Dictionary<string, Class839>();
        this.dictionary_1 = new Dictionary<int, Class843>();
        this.stack_0 = new Stack<string>();
        this.stack_1 = new Stack<Dictionary<string, Class839>>();
        this.stack_2 = new Stack<Dictionary<int, Class843>>();
        this.dictionary_2 = new Dictionary<int, CellFormat>();
        this.int_6 = 1;
        this.list_0 = new List<Paragraph>();
        this.stack_3 = new Stack<int>();
        this.stack_4 = new Stack<string>();
        this.stack_5 = new Stack<string>();
        this.stack_6 = new Stack<string>();
        this.stack_7 = new Stack<string>();
        this.stack_8 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_9 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_10 = new Stack<Class835>();
        this.stack_11 = new Stack<Class835>();
        this.int_7 = -1;
        this.dictionary_4 = new Dictionary<string, ListStyle>();
        this.dictionary_5 = new Dictionary<string, string>();
        this.dictionary_6 = new Dictionary<string, Style>();
        this.stack_12 = new Stack<Dictionary<string, ListStyle>>();
        this.stack_13 = new Stack<Dictionary<string, string>>();
        this.stack_14 = new Stack<Dictionary<string, Style>>();
        this.string_18 = string.Empty;
        this.int_9 = -1;
        this.int_10 = -1;
        this.int_11 = -1;
        this.string_19 = string.Empty;
        this.string_20 = string.Empty;
        this.stack_16 = new Stack<Body>();
        this.stack_17 = new Stack<Table>();
        this.dictionary_9 = new Dictionary<int, Class842>();
        this.stack_18 = new Stack<Dictionary<int, Class842>>();
        this.stack_19 = new Stack<string>();
        this.stack_20 = new Stack<Class835>();
        this.stack_21 = new Stack<RowFormat>();
        this.stack_22 = new Stack<RowFormat>();
        this.stack_23 = new Stack<string>();
        this.class840_0 = new Class840();
        this.class841_0 = new Class841();
        this.stack_24 = new Stack<Class840>();
        this.stack_25 = new Stack<string>();
        this.stack_26 = new Stack<Dictionary<string, object>>();
        this.stack_27 = new Stack<string>();
        this.int_21 = -1;
        this.int_22 = 1;
        this.int_23 = 1;
        this.int_24 = 1;
        this.stack_28 = new Stack<int>();
        this.stack_29 = new Stack<string>();
        this.stack_30 = new Stack<string>();
        this.stack_31 = new Stack<Body>();
        this.stack_32 = new Stack<IParagraph>();
        this.stack_33 = new Stack<bool>();
        this.stack_34 = new Stack<ShapeObject>();
        this.stack_35 = new Stack<string>();
        this.class43_0 = new Class43();
        this.string_26 = string.Empty;
        this.string_27 = string.Empty;
        this.stack_36 = new Stack<bool>();
        this.list_1 = new List<byte>();
        this.stack_38 = new Stack<bool>();
        this.stack_39 = new Stack<bool>();
        this.string_28 = new string[] { 
            BookmarkStart.b("稩洫椭甯", 4), BookmarkStart.b("搩礫挭怯猱猳猵欷", 4), BookmarkStart.b("戩甫縭甯怱砳缵瘷焹", 4), BookmarkStart.b("朩椫簭眯眱爳缵紷瘹砻", 4), BookmarkStart.b("搩椫瘭搯", 4), BookmarkStart.b("搩椫瘭搯笱爳", 4), BookmarkStart.b("稩縫札縯昱瀳眵氷缹", 4), BookmarkStart.b("椩縫欭焯昱焳爵礷渹礻", 4), BookmarkStart.b("欩礫稭砯紱昳", 4), BookmarkStart.b("椩挫挭累眱稳戵欷", 4), BookmarkStart.b("愩椫眭术紱昳爵欷", 4), BookmarkStart.b("欩礫稭缯簱愳笵", 4), BookmarkStart.b("搩礫挭术紱昳爵欷", 4), BookmarkStart.b("挩戫栭缯", 4), BookmarkStart.b("欩礫稭缯昱焳渵氷", 4), BookmarkStart.b("礩洫砭甯瘱申戵紷", 4), 
            BookmarkStart.b("挩樫", 4), BookmarkStart.b("温洫稭甯", 4), BookmarkStart.b("氩挫簭累焱簳猵笷焹縻焽ᠿ", 4), BookmarkStart.b("氩挫簭累昱焳渵氷", 4), BookmarkStart.b("氩挫簭累瘱昳礵样縹猻椽฿", 4), BookmarkStart.b("礩甫挭爯紱砳", 4), BookmarkStart.b("挩戫洭簯朱瀳猵样猹缻樽ᔿ၁Ń", 4)
         };
        this.string_29 = string.Empty;
        this.stack_40 = new Stack<string>();
        this.bool_65 = true;
        this.stack_41 = new Stack<string>();
        this.stack_42 = new Stack<Paragraph>();
        this.stack_43 = new Stack<Body>();
        this.stack_44 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_45 = new Stack<ITable>();
        this.stack_46 = new Stack<TableRow>();
        this.stack_47 = new Stack<TableCell>();
        this.stack_48 = new Stack<string>();
        this.string_30 = string.Empty;
        this.stack_50 = new Stack<string>();
        this.string_31 = string.Empty;
        this.stack_51 = new Stack<LineBreakClear>();
        this.stack_52 = new Stack<ParagraphFormat>();
        this.list_2 = new List<Class51>();
        this.stack_53 = new Stack<Paddings>();
        this.stack_54 = new Stack<Struct26>();
        this.struct26_0 = new Struct26();
        Class1084 class2 = new Class1084(A_1);
        this.method_37(A_0, class2);
    }

    public Class834(Document A_0, Stream A_1, Encoding A_2)
    {
        this.regex_0 = new Regex(BookmarkStart.b("欯ᔱ椳ḵ挷ਹᄻܽℿ潁≃݅敇౉ᅋ㕍扏⽑絓繕癗灙畛穝", 10));
        this.regex_1 = new Regex(BookmarkStart.b("港渱倳ᴵ᰷", 10));
        this.regex_2 = new Regex(BookmarkStart.b("港椱гᬵķ笹ᄻ砽ℿ潁≃ᭅ捇湉", 10));
        this.rtfTableType_0 = RtfTableType.None;
        this.dictionary_0 = new Dictionary<string, Class839>();
        this.dictionary_1 = new Dictionary<int, Class843>();
        this.stack_0 = new Stack<string>();
        this.stack_1 = new Stack<Dictionary<string, Class839>>();
        this.stack_2 = new Stack<Dictionary<int, Class843>>();
        this.dictionary_2 = new Dictionary<int, CellFormat>();
        this.int_6 = 1;
        this.list_0 = new List<Paragraph>();
        this.stack_3 = new Stack<int>();
        this.stack_4 = new Stack<string>();
        this.stack_5 = new Stack<string>();
        this.stack_6 = new Stack<string>();
        this.stack_7 = new Stack<string>();
        this.stack_8 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_9 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_10 = new Stack<Class835>();
        this.stack_11 = new Stack<Class835>();
        this.int_7 = -1;
        this.dictionary_4 = new Dictionary<string, ListStyle>();
        this.dictionary_5 = new Dictionary<string, string>();
        this.dictionary_6 = new Dictionary<string, Style>();
        this.stack_12 = new Stack<Dictionary<string, ListStyle>>();
        this.stack_13 = new Stack<Dictionary<string, string>>();
        this.stack_14 = new Stack<Dictionary<string, Style>>();
        this.string_18 = string.Empty;
        this.int_9 = -1;
        this.int_10 = -1;
        this.int_11 = -1;
        this.string_19 = string.Empty;
        this.string_20 = string.Empty;
        this.stack_16 = new Stack<Body>();
        this.stack_17 = new Stack<Table>();
        this.dictionary_9 = new Dictionary<int, Class842>();
        this.stack_18 = new Stack<Dictionary<int, Class842>>();
        this.stack_19 = new Stack<string>();
        this.stack_20 = new Stack<Class835>();
        this.stack_21 = new Stack<RowFormat>();
        this.stack_22 = new Stack<RowFormat>();
        this.stack_23 = new Stack<string>();
        this.class840_0 = new Class840();
        this.class841_0 = new Class841();
        this.stack_24 = new Stack<Class840>();
        this.stack_25 = new Stack<string>();
        this.stack_26 = new Stack<Dictionary<string, object>>();
        this.stack_27 = new Stack<string>();
        this.int_21 = -1;
        this.int_22 = 1;
        this.int_23 = 1;
        this.int_24 = 1;
        this.stack_28 = new Stack<int>();
        this.stack_29 = new Stack<string>();
        this.stack_30 = new Stack<string>();
        this.stack_31 = new Stack<Body>();
        this.stack_32 = new Stack<IParagraph>();
        this.stack_33 = new Stack<bool>();
        this.stack_34 = new Stack<ShapeObject>();
        this.stack_35 = new Stack<string>();
        this.class43_0 = new Class43();
        this.string_26 = string.Empty;
        this.string_27 = string.Empty;
        this.stack_36 = new Stack<bool>();
        this.list_1 = new List<byte>();
        this.stack_38 = new Stack<bool>();
        this.stack_39 = new Stack<bool>();
        this.string_28 = new string[] { 
            BookmarkStart.b("怯猱猳猵", 10), BookmarkStart.b("縯朱礳昵礷紹礻洽", 10), BookmarkStart.b("砯欱搳猵樷瘹画瀽ି", 10), BookmarkStart.b("累眱昳焵紷簹画笽ిف", 10), BookmarkStart.b("縯眱氳戵", 10), BookmarkStart.b("縯眱氳戵焷簹", 10), BookmarkStart.b("怯怱紳砵氷縹紻樽Կ", 10), BookmarkStart.b("猯怱焳眵氷缹砻缽ᐿ݁", 10), BookmarkStart.b("焯朱怳縵眷根", 10), BookmarkStart.b("猯紱礳笵紷琹栻洽", 10), BookmarkStart.b("笯眱洳愵眷根砻洽", 10), BookmarkStart.b("焯朱怳礵瘷漹焻", 10), BookmarkStart.b("縯朱礳愵眷根砻洽", 10), BookmarkStart.b("礯簱爳礵", 10), BookmarkStart.b("焯朱怳礵氷缹搻樽", 10), BookmarkStart.b("振猱戳猵簷笹栻笽", 10), 
            BookmarkStart.b("礯琱", 10), BookmarkStart.b("琯猱怳猵", 10), BookmarkStart.b("瘯紱昳笵笷爹礻紽ିAୃṅ", 10), BookmarkStart.b("瘯紱昳笵氷缹搻樽", 10), BookmarkStart.b("瘯紱昳笵簷根猻渽пുፃࡅ", 10), BookmarkStart.b("振欱礳琵眷瘹", 10), BookmarkStart.b("礯簱眳稵洷縹礻渽िŁ၃ፅᩇཉ", 10)
         };
        this.string_29 = string.Empty;
        this.stack_40 = new Stack<string>();
        this.bool_65 = true;
        this.stack_41 = new Stack<string>();
        this.stack_42 = new Stack<Paragraph>();
        this.stack_43 = new Stack<Body>();
        this.stack_44 = new Stack<Dictionary<int, CellFormat>>();
        this.stack_45 = new Stack<ITable>();
        this.stack_46 = new Stack<TableRow>();
        this.stack_47 = new Stack<TableCell>();
        this.stack_48 = new Stack<string>();
        this.string_30 = string.Empty;
        this.stack_50 = new Stack<string>();
        this.string_31 = string.Empty;
        this.stack_51 = new Stack<LineBreakClear>();
        this.stack_52 = new Stack<ParagraphFormat>();
        this.list_2 = new List<Class51>();
        this.stack_53 = new Stack<Paddings>();
        this.stack_54 = new Stack<Struct26>();
        this.struct26_0 = new Struct26();
        long position = A_1.Position;
        if (A_2 == null)
        {
            A_2 = this.method_36(A_1);
        }
        A_1.Position = position;
        Class1084 class2 = new Class1084(A_1, A_2);
        this.method_37(A_0, class2);
    }

    internal string method_0()
    {
        return this.string_8;
    }

    internal string method_1()
    {
        return this.string_9;
    }

    protected ISection method_10()
    {
        if (this.isection_0 == null)
        {
            this.isection_0 = this.document_0.AddSection();
            this.method_38(this.isection_0);
            this.isection_0.PageSetup.EqualColumnWidth = true;
            this.body_0 = this.isection_0.Body;
        }
        return this.isection_0;
    }

    private string method_100(string A_0)
    {
        int num = 9;
        string str = string.Empty;
        int length = A_0.Length;
        str = this.method_136(A_0);
        if (string.IsNullOrEmpty(str) && (A_0 != BookmarkStart.b("ᰮ地", num)))
        {
            int num2 = int.Parse(A_0, NumberStyles.HexNumber);
            List<byte> list = new List<byte> {
                (byte) num2
            };
            str = this.method_135(list);
            list.Clear();
            list = null;
        }
        return str;
    }

    private void method_101(string A_0, string A_1, string A_2)
    {
        int num = 12;
        string key = A_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_161 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䈱匳䘵", num), 0);
                dictionary1.Add(BookmarkStart.b("嬱䐳儵䠷", num), 1);
                dictionary1.Add(BookmarkStart.b("嬱䀳圵䠷", num), 2);
                dictionary1.Add(BookmarkStart.b("帱崳", num), 3);
                dictionary1.Add(BookmarkStart.b("䀱崳", num), 4);
                dictionary1.Add(BookmarkStart.b("䄱嘳", num), 5);
                dictionary1.Add(BookmarkStart.b("䄱唳", num), 6);
                Class1160.dictionary_161 = dictionary1;
            }
            if (Class1160.dictionary_161.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.class51_0 = new Class51(this.document_0);
                        this.list_2.Add(this.class51_0);
                        return;

                    case 1:
                        this.class51_0.method_8(this.list_2.Count + 1);
                        return;

                    case 2:
                        this.class51_0.method_12(A_2 != BookmarkStart.b("ȱ", num));
                        return;

                    case 3:
                        this.class51_0.method_5().Left = this.method_165(A_2);
                        return;

                    case 4:
                        this.class51_0.method_5().Right = this.method_165(A_2);
                        return;

                    case 5:
                        this.class51_0.method_5().Top = this.method_165(A_2);
                        return;

                    case 6:
                        this.class51_0.method_5().Bottom = this.method_165(A_2);
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_102(string A_0, string A_1, string A_2)
    {
        int num = 0x10;
        string styleName = null;
        if ((this.bool_30 && !string.IsNullOrEmpty(A_0)) && (A_0[0] == '\''))
        {
            List<string> list = (List<string>) this.dictionary_7[BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num)];
            Match match = this.regex_0.Match(A_0);
            if (match.Success)
            {
                list.Add(match.Groups[1].Value);
                list.Add(match.Groups[2].Value);
            }
        }
        string key = A_1;
        if (key != null)
        {
            int num11;
            if (Class1160.dictionary_162 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻", num), 0);
                dictionary1.Add(BookmarkStart.b("娵䬷", num), 1);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻刽┿㑁⅃⩅", num), 2);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽☿ⵁ⡃⩅❇㵉", num), 3);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻儽㘿❁㙃㑅ⅇ⹉⥋㵍⑏㍑♓≕㥗⹙", num), 4);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻儽㘿❁㙃㑅ⅇ⹉⥋⡍㽏⁑㥓㝕ⱗ", num), 5);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽㌿㙁╃㑅㱇⭉㡋", num), 6);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽⸿⑁❃⡅", num), 7);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽⸿⑁❃", num), 8);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽⨿⅁", num), 9);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽⸿ⵁ㙃⍅㭇㹉ⵋ㱍⑏", num), 10);
                dictionary1.Add(BookmarkStart.b("娵儷吹", num), 11);
                dictionary1.Add(BookmarkStart.b("娵儷", num), 12);
                dictionary1.Add(BookmarkStart.b("倵儷", num), 13);
                dictionary1.Add(BookmarkStart.b("倵儷᜹", num), 14);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻圽␿潁", num), 15);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻圽␿", num), 0x10);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽⼿⹁⁃", num), 0x11);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽㌿㉁╃╅ⵇ", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䈵䀷", num), 0x13);
                dictionary1.Add(BookmarkStart.b("圵帷", num), 20);
                dictionary1.Add(BookmarkStart.b("䌵", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䌵ᔷ", num), 0x16);
                dictionary1.Add(BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num), 0x17);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻䴽⤿⽁㑃⩅ⵇ", num), 0x18);
                dictionary1.Add(BookmarkStart.b("娵儷䤹䠻嘽㤿⁁㙃⽅ⱇ", num), 0x19);
                Class1160.dictionary_162 = dictionary1;
            }
            if (Class1160.dictionary_162.TryGetValue(key, out num11))
            {
                int num3;
                char ch;
                switch (num11)
                {
                    case 0:
                    {
                        this.method_12(new ListStyle(this.document_0));
                        string str4 = Guid.NewGuid().ToString();
                        styleName = BookmarkStart.b("稵儷䤹䠻洽㐿㭁⡃⍅", num) + str4;
                        this.string_17 = styleName;
                        this.method_11().Name = styleName;
                        this.int_7 = -1;
                        return;
                    }
                    case 1:
                        if (this.method_21() == RtfTableType.ListOverrideTable)
                        {
                            for (int i = 0; i < this.document_0.ListStyles.Count; i++)
                            {
                                if (this.document_0.ListStyles[i].ListStyleId == this.string_16)
                                {
                                    string name = this.document_0.ListStyles[i].Name;
                                    if (!this.dictionary_5.ContainsKey(A_0))
                                    {
                                        this.dictionary_5.Add(A_0, name);
                                    }
                                }
                            }
                            if (this.method_34().ContainsKey(this.string_16))
                            {
                                string str2 = this.method_34()[this.string_16];
                                this.method_34().Remove(this.string_16);
                                this.method_34().Add(A_0, str2);
                            }
                        }
                        return;

                    case 2:
                        this.method_103();
                        return;

                    case 3:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 0:
                                this.method_13().FollowCharacter = FollowCharacterType.Tab;
                                return;

                            case 1:
                                this.method_13().FollowCharacter = FollowCharacterType.Space;
                                return;

                            case 2:
                                return;

                            case 3:
                                this.method_13().FollowCharacter = FollowCharacterType.Nothing;
                                return;
                        }
                        return;

                    case 4:
                        this.bool_75 = true;
                        return;

                    case 5:
                        this.bool_76 = true;
                        return;

                    case 6:
                        this.method_13().StartAt = Convert.ToInt32(A_2);
                        return;

                    case 7:
                    case 8:
                        num3 = Convert.ToInt32(A_2);
                        if (num3 != 0x17)
                        {
                            this.method_11().ListType = ListType.Numbered;
                            switch (num3)
                            {
                                case 0:
                                    this.method_13().PatternType = ListPatternType.Arabic;
                                    return;

                                case 1:
                                    this.method_13().PatternType = ListPatternType.UpRoman;
                                    return;

                                case 2:
                                    this.method_13().PatternType = ListPatternType.LowRoman;
                                    return;

                                case 3:
                                    this.method_13().PatternType = ListPatternType.UpLetter;
                                    return;

                                case 4:
                                    this.method_13().PatternType = ListPatternType.LowLetter;
                                    return;
                            }
                            this.method_13().PatternType = ListPatternType.Arabic;
                            return;
                        }
                        this.method_13().PatternType = ListPatternType.Bullet;
                        return;

                    case 9:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 0:
                                this.method_13().NumberAlignment = ListNumberAlignment.Left;
                                return;

                            case 1:
                                this.method_13().NumberAlignment = ListNumberAlignment.Center;
                                return;

                            case 2:
                                this.method_13().NumberAlignment = ListNumberAlignment.Right;
                                return;
                        }
                        return;

                    case 10:
                        num3 = Convert.ToInt32(A_2);
                        switch (num3)
                        {
                            case 1:
                                this.method_13().NoRestartByHigher = true;
                                return;

                            case 0:
                                this.method_13().NoRestartByHigher = false;
                                break;
                        }
                        return;

                    case 11:
                    case 12:
                    {
                        float num9 = this.method_165(A_2);
                        this.method_13().ParagraphFormat.LeftIndent = num9;
                        this.method_13().TextPosition = num9;
                        return;
                    }
                    case 13:
                    {
                        float num6 = this.method_165(A_2);
                        this.method_13().ParagraphFormat.FirstLineIndent = num6;
                        return;
                    }
                    case 14:
                    {
                        float num12 = this.method_165(A_2);
                        this.method_13().ParagraphFormat.FirstLineIndent = -num12;
                        return;
                    }
                    case 15:
                    case 0x10:
                    {
                        if (this.method_21() != RtfTableType.ListTable)
                        {
                            if (this.method_21() == RtfTableType.ListOverrideTable)
                            {
                                this.int_7 = -1;
                                this.string_16 = A_0;
                                this.int_8 = 0;
                                if ((this.dictionary_4 == null) || !this.dictionary_4.ContainsKey(this.string_16))
                                {
                                    return;
                                }
                                this.method_12(this.dictionary_4[this.string_16]);
                            }
                            return;
                        }
                        if (this.dictionary_4.ContainsKey(A_0))
                        {
                            this.dictionary_4[A_0] = this.method_11();
                            return;
                        }
                        styleName = BookmarkStart.b("砵䴷圹帻嬽㈿❁⁃᥅", num) + Guid.NewGuid().ToString();
                        ListStyle style = this.document_0.AddListStyle(this.method_11().ListType, styleName);
                        this.method_105(this.method_11(), style);
                        style.Name = styleName;
                        style.ListStyleId = A_0;
                        this.dictionary_4.Add(A_0, style.Clone() as ListStyle);
                        return;
                    }
                    case 0x11:
                        this.bool_50 = true;
                        return;

                    case 0x12:
                    {
                        float num4 = this.method_165(A_2);
                        if (this.bool_50)
                        {
                            this.method_13().TabSpaceAfter = num4;
                        }
                        return;
                    }
                    case 0x13:
                        this.method_13().TabSpaceAfter = this.method_165(A_2);
                        return;

                    case 20:
                        foreach (KeyValuePair<string, Class839> pair in this.dictionary_0)
                        {
                            string str5 = pair.Key;
                            if (this.method_166(str5)[1] == A_2)
                            {
                                this.method_16(pair.Value);
                                this.method_13().CharacterFormat.FontName = this.method_15().method_6();
                            }
                        }
                        return;

                    case 0x15:
                        num3 = 0x10000 + Convert.ToInt32(A_2);
                        ch = (char) num3;
                        if (this.method_13().PatternType != ListPatternType.Bullet)
                        {
                            List<string> list3;
                            int num8;
                            List<string> list2 = (List<string>) this.dictionary_7[BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num)];
                            (list3 = list2)[num8 = list2.Count - 1] = list3[num8] + ch.ToString();
                            return;
                        }
                        this.method_13().BulletCharacter = ch.ToString();
                        return;

                    case 0x16:
                    {
                        List<string> list5;
                        int num10;
                        num3 = 0x10000 - Convert.ToInt32(A_2);
                        ch = (char) num3;
                        if (this.method_13().PatternType == ListPatternType.Bullet)
                        {
                            this.method_13().BulletCharacter = ch.ToString();
                            return;
                        }
                        List<string> list4 = (List<string>) this.dictionary_7[BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num)];
                        (list5 = list4)[num10 = list4.Count - 1] = list5[num10] + ch.ToString();
                        return;
                    }
                    case 0x17:
                        this.bool_30 = true;
                        this.method_33()[BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num)] = new List<string>();
                        this.dictionary_7 = this.method_33();
                        return;

                    case 0x18:
                        if (A_2 == BookmarkStart.b("ܵ", num))
                        {
                            this.method_11().IsSimple = true;
                        }
                        return;

                    case 0x19:
                        this.method_11().IsHybrid = true;
                        return;
                }
            }
        }
        this.method_113(A_0, A_1, A_2);
    }

    private void method_103()
    {
        this.stack_27.Push(BookmarkStart.b("䬯", 10));
        this.bool_51 = true;
        this.int_7++;
        if (this.method_21() == RtfTableType.ListTable)
        {
            this.method_14(new ListLevel(this.method_11()));
            this.int_7 = this.method_11().Levels.method_5(this.method_13());
        }
        else if (this.method_21() == RtfTableType.ListOverrideTable)
        {
            this.method_14(this.method_11().Levels[this.int_7]);
        }
        this.bool_30 = false;
        this.bool_50 = false;
        this.iparagraph_0 = new Paragraph(this.document_0);
        this.method_139(this.method_7().Format);
        this.class835_0 = this.method_175();
    }

    private void method_104(CharacterFormat A_0, CharacterFormat A_1)
    {
        int num = 0x13;
        if ((A_0 != null) && (A_1 != null))
        {
            if (A_0.HasValue(190))
            {
                A_1.FontSize = A_0.FontSize;
            }
            if (A_0.HasValue(160))
            {
                A_1.method_55(A_0.TextColor);
            }
            if (A_0.HasValue(2) && (A_0.FontName != BookmarkStart.b("洸刺值娾㉀捂ୄ≆㹈歊Ὄ⁎㱐㉒㭔", num)))
            {
                A_1.FontName = A_0.FontName;
                if ((A_0.FontName == BookmarkStart.b("琸吺匼倾㕀㩂㕄≆楈ࡊ≌㵎≐㩒⍔㙖", num)) || (A_0.FontName == BookmarkStart.b("笸䤺䠼䰾⥀捂ᙄ⑆㭈≊㵌㭎煐ṒŔ", num)))
                {
                    A_1.Italic = true;
                }
            }
            if (A_0.HasValue(60))
            {
                A_1.Bold = A_0.Bold;
            }
            if (A_0.HasValue(70))
            {
                A_1.Italic = A_0.Italic;
            }
            if (A_0.HasValue(140) && (A_0.UnderlineStyle != UnderlineStyle.None))
            {
                A_1.UnderlineStyle = A_0.UnderlineStyle;
            }
            if (A_0.HasValue(20))
            {
                A_1.HighlightColor = A_0.HighlightColor;
            }
            if (A_0.HasValue(100))
            {
                A_1.IsShadow = A_0.IsShadow;
            }
            if (A_0.HasValue(150))
            {
                A_1.CharacterSpacing = A_0.CharacterSpacing;
            }
            if (A_0.HasValue(200))
            {
                A_1.Position = A_0.Position;
            }
            if (A_0.HasValue(300))
            {
                A_1.DoubleStrike = A_0.DoubleStrike;
            }
            if (A_0.HasValue(170))
            {
                A_1.Emboss = A_0.Emboss;
            }
            if (A_0.HasValue(180))
            {
                A_1.Engrave = A_0.Engrave;
            }
            if (A_0.HasValue(210))
            {
                A_1.SubSuperScript = A_0.SubSuperScript;
            }
            if (A_0.HasValue(9))
            {
                A_1.TextBackgroundColor = A_0.TextBackgroundColor;
            }
            if (A_0.HasValue(120))
            {
                A_1.AllCaps = A_0.AllCaps;
            }
            if (A_0.Bidi)
            {
                A_1.Bidi = true;
                A_1.FontNameBidi = A_0.FontNameBidi;
                A_1.FontSizeBidi = A_0.FontSizeBidi;
            }
            if (A_0.HasValue(250))
            {
                A_1.BoldBidi = A_0.BoldBidi;
            }
            if (A_0.HasValue(0x6d))
            {
                A_1.FieldVanish = A_0.FieldVanish;
            }
            if (A_0.HasValue(130))
            {
                A_1.Hidden = A_0.Hidden;
            }
            if (A_0.HasValue(110))
            {
                A_1.IsSmallCaps = A_0.IsSmallCaps;
            }
        }
    }

    private void method_105(ListStyle A_0, ListStyle A_1)
    {
        A_1.ListType = A_0.ListType;
        A_1.Name = A_0.Name;
        for (int i = 0; i < A_0.Levels.Count; i++)
        {
            A_1.Levels[i].ParagraphFormat.LeftIndent = A_0.Levels[i].ParagraphFormat.LeftIndent;
            A_1.Levels[i].ParagraphFormat.FirstLineIndent = A_0.Levels[i].ParagraphFormat.FirstLineIndent;
            A_1.Levels[i].CharacterFormat.FontName = A_0.Levels[i].CharacterFormat.FontName;
            if (A_0.Levels[i].BulletCharacter != null)
            {
                A_1.Levels[i].BulletCharacter = A_0.Levels[i].BulletCharacter;
            }
            FollowCharacterType followCharacter = A_0.Levels[i].FollowCharacter;
            A_1.Levels[i].FollowCharacter = A_0.Levels[i].FollowCharacter;
            if (A_0.Levels[i].NoLevelText)
            {
                A_1.Levels[i].NoLevelText = A_0.Levels[i].NoLevelText;
            }
            if (A_0.Levels[i].NoRestartByHigher)
            {
                A_1.Levels[i].NoRestartByHigher = A_0.Levels[i].NoRestartByHigher;
            }
            A_1.Levels[i].NumberAlignment = A_0.Levels[i].NumberAlignment;
            A_1.Levels[i].NumberPosition = A_0.Levels[i].NumberPosition;
            if (A_0.Levels[i].NumberPrefix != null)
            {
                A_1.Levels[i].NumberPrefix = A_0.Levels[i].NumberPrefix;
            }
            if (A_0.Levels[i].NumberSufix != null)
            {
                A_1.Levels[i].NumberSufix = A_0.Levels[i].NumberSufix;
            }
            ListPatternType patternType = A_0.Levels[i].PatternType;
            A_1.Levels[i].PatternType = A_0.Levels[i].PatternType;
            A_1.Levels[i].StartAt = A_0.Levels[i].StartAt;
            if (A_0.Levels[i].ParagraphFormat.Tabs.Count > 0)
            {
                A_1.Levels[i].TabSpaceAfter = A_0.Levels[i].TabSpaceAfter;
            }
            A_1.Levels[i].TextPosition = A_0.Levels[i].TextPosition;
        }
    }

    private void method_106(ListLevel A_0, ListLevel A_1)
    {
        A_1.BulletCharacter = A_0.BulletCharacter;
        A_1.FollowCharacter = A_0.FollowCharacter;
        A_1.IsEmptyPicture = A_0.IsEmptyPicture;
        A_1.IsLegalStyleNumbering = A_0.IsLegalStyleNumbering;
        A_1.LegacyIndent = A_0.LegacyIndent;
        A_1.LegacySpace = A_0.LegacySpace;
        A_1.LevelText = A_0.LevelText;
        A_1.NoLevelText = A_0.NoLevelText;
        A_1.NoPlaceholder = A_0.NoPlaceholder;
        A_1.NoRestartByHigher = A_0.NoRestartByHigher;
        A_1.NumberAlignment = A_0.NumberAlignment;
        A_1.NumberPosition = A_0.NumberPosition;
        A_1.NumberPrefix = A_0.NumberPrefix;
        A_1.NumberSufix = A_0.NumberSufix;
        A_1.ParaStyleName = A_0.ParaStyleName;
        A_1.PatternType = A_0.PatternType;
        A_1.PicBulletId = A_0.PicBulletId;
        A_1.StartAt = A_0.StartAt;
        A_1.TabSpaceAfter = A_0.TabSpaceAfter;
        A_1.TextPosition = A_0.TextPosition;
        A_1.UsePrevLevelPattern = A_0.UsePrevLevelPattern;
        A_1.Word6Legacy = A_0.Word6Legacy;
    }

    private void method_107(string A_0, string A_1, string A_2)
    {
        int num = 8;
        string key = A_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_163 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("席圯就䜳䈵夷䠹䠻䴽", num), 0);
                dictionary1.Add(BookmarkStart.b("席圯就䘳匵䬷丹崻䰽㐿", num), 1);
                dictionary1.Add(BookmarkStart.b("席圯就倳匵嬷", num), 2);
                dictionary1.Add(BookmarkStart.b("席圯就䄳唵䨷圹", num), 3);
                dictionary1.Add(BookmarkStart.b("席圯就堳唵䨷圹", num), 4);
                dictionary1.Add(BookmarkStart.b("席圯就䄳唵吷丹主", num), 5);
                dictionary1.Add(BookmarkStart.b("席圯就堳唵吷丹主", num), 6);
                Class1160.dictionary_163 = dictionary1;
            }
            if (Class1160.dictionary_163.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.method_10().PageSetup.PageStartingNumber = Convert.ToInt32(A_2);
                        return;

                    case 1:
                        this.method_10().PageSetup.RestartPageNumbering = true;
                        this.method_10().PageSetup.PageStartingNumber = 1;
                        return;

                    case 2:
                        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.Arabic;
                        return;

                    case 3:
                        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.RomanUpper;
                        return;

                    case 4:
                        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.RomanLower;
                        return;

                    case 5:
                        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.LetterUpper;
                        return;

                    case 6:
                        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.LetterLower;
                        return;
                }
            }
        }
        this.method_10().PageSetup.PageNumberStyle = PageNumberStyle.Arabic;
    }

    private void method_108(string A_0, string A_1, string A_2)
    {
        int num = 8;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("䈭夯就儳丵", num))
            {
                this.method_10().PageSetup.LineNumberingDistanceFromText = Convert.ToSingle(A_2);
            }
            else if (str == BookmarkStart.b("䈭夯就儳䔵䰷嬹主䨽㌿", num))
            {
                this.method_10().PageSetup.LineNumberingStartValue = Convert.ToInt32(A_2);
            }
            else if (str == BookmarkStart.b("䈭夯就儳䘵䠷嬹嬻嬽", num))
            {
                this.method_10().PageSetup.LineNumberingRestartMode = LineNumberingRestartMode.RestartPage;
            }
            else if (str == BookmarkStart.b("䈭夯就儳唵圷吹䠻", num))
            {
                this.method_10().PageSetup.LineNumberingRestartMode = LineNumberingRestartMode.Continuous;
            }
            else if (str == BookmarkStart.b("䈭夯就儳", num))
            {
                if (this.lineBreakClear_0 != LineBreakClear.None)
                {
                    this.method_7().method_29(BreakType.LineBreak, this.lineBreakClear_0);
                }
                else
                {
                    this.method_7().AppendBreak(BreakType.LineBreak);
                }
                this.method_169((this.method_7().LastItem as Break).TextRange.CharacterFormat, this.class835_0);
            }
        }
    }

    private void method_109(string A_0, string A_1, string A_2)
    {
        int num = 8;
        if ((A_1 != BookmarkStart.b("䠭", 8)) && (A_1 != BookmarkStart.b("伭嘯", num)))
        {
            if (A_1 == BookmarkStart.b("䠭匯娱唳䐵䬷弹䠻", num))
            {
                if (this.class839_1 != null)
                {
                    this.class839_1.method_1(RtfSpec.GetCodePage(Convert.ToInt32(A_2)));
                    this.method_110(this.class839_1.method_0());
                }
            }
            else if (A_0.StartsWith(BookmarkStart.b("भ", num)) && !this.bool_69)
            {
                this.class839_1.method_7(this.class839_1.method_6() + this.method_134(A_0));
            }
            else if (A_0.StartsWith(BookmarkStart.b("䠭儯帱䀳", num)))
            {
                this.bool_69 = true;
            }
        }
        else
        {
            this.class839_1 = new Class839();
            this.class839_1.method_5(A_0);
            this.class839_1.method_3(Convert.ToInt32(A_2));
            if (this.int_5 == this.class839_1.method_2())
            {
                this.class839_0 = this.class839_1;
            }
        }
    }

    protected ListStyle method_11()
    {
        return this.listStyle_0;
    }

    private void method_110(int A_0)
    {
        if ((this.encoding_0 == null) || (A_0 != this.encoding_0.CodePage))
        {
            switch (A_0)
            {
                case 0x2a:
                case 0x4e4:
                    this.encoding_0 = RtfSpec.AnsiEncoding;
                    break;

                default:
                    if ((A_0 > 0) || (this.encoding_0 == null))
                    {
                        this.encoding_0 = Encoding.GetEncoding(A_0);
                    }
                    break;
            }
            this.decoder_0 = null;
        }
        if ((this.decoder_0 == null) && (this.encoding_0 != null))
        {
            this.decoder_0 = this.encoding_0.GetDecoder();
        }
    }

    private void method_111(string A_0, string A_1, string A_2)
    {
        int num = 2;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("娧伩䠫", num))
            {
                this.class843_0.method_1(Convert.ToInt32(A_2));
            }
            else if (str == BookmarkStart.b("伧堩䤫䬭帯", num))
            {
                this.class843_0.method_3(Convert.ToInt32(A_2));
            }
            else if (str == BookmarkStart.b("䨧䘩夫䬭", num))
            {
                this.class843_0.method_5(Convert.ToInt32(A_2));
            }
        }
    }

    private void method_112(string A_0, string A_1)
    {
        int num = 0;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜥䘧天䔫", num))
            {
                this.method_110(0x4e4);
            }
            else if (str == BookmarkStart.b("䬥䤧䤩", num))
            {
                this.method_110(0x2710);
            }
            else if (str == BookmarkStart.b("嘥䬧", num))
            {
                this.method_110(0x1b5);
            }
            else if (str == BookmarkStart.b("嘥䬧䬩", num))
            {
                this.method_110(850);
            }
            else if (str == BookmarkStart.b("䜥䘧天䔫䴭䀯唱", num))
            {
                this.method_110(Convert.ToInt32(A_1));
                this.decoder_1 = this.decoder_0;
            }
        }
    }

    private void method_113(string A_0, string A_1, string A_2)
    {
        int num = 13;
        float num2 = 0f;
        if (this.int_28 < 4)
        {
            this.method_112(A_1, A_2);
        }
        if (this.bool_6 && !this.bool_59)
        {
            this.method_146(A_0, A_1, A_2);
        }
        else if ((((A_0 != BookmarkStart.b("䀲崴䜶", num)) && (A_0 != BookmarkStart.b("䀲崴䜶常䤺䴼", num))) && (this.bool_54 && !this.bool_59)) && ((!this.bool_15 && !this.bool_57) && !this.bool_56))
        {
            this.method_147(A_0, A_1, A_2);
        }
        else if (A_0.StartsWith(BookmarkStart.b("弲圴䔶", num)))
        {
            string str2 = A_2;
            if (str2 != null)
            {
                if (str2 == BookmarkStart.b("Ȳ", num))
                {
                    this.lineBreakClear_0 = LineBreakClear.Left;
                    return;
                }
                if (str2 == BookmarkStart.b("Ĳ", num))
                {
                    this.lineBreakClear_0 = LineBreakClear.Right;
                    return;
                }
                if (str2 == BookmarkStart.b("2", num))
                {
                    this.lineBreakClear_0 = LineBreakClear.All;
                    return;
                }
                if (str2 == BookmarkStart.b("̲", num))
                {
                }
            }
            this.lineBreakClear_0 = LineBreakClear.None;
        }
        else if (A_0.StartsWith(BookmarkStart.b("弲尴夶尸", num)))
        {
            this.method_108(A_0, A_1, A_2);
        }
        else if (A_0.StartsWith(BookmarkStart.b("䌲刴夶", num)))
        {
            this.method_107(A_0, A_1, A_2);
        }
        else if ((A_0.StartsWith(BookmarkStart.b("儲䜴匶䬸", num)) || A_0.StartsWith(BookmarkStart.b("䜲䜴唶䬸强似", num))) || (A_0.StartsWith(BookmarkStart.b("儲䜴䐶䤸", num)) || A_0.StartsWith(BookmarkStart.b("䌲刴唶䬸", num))))
        {
            this.method_156(A_0, A_1, A_2);
        }
        else if (A_0.StartsWith(BookmarkStart.b("䔲倴䔶䴸", num)))
        {
            this.method_151(A_0, A_1, A_2);
        }
        else if (this.bool_32)
        {
            if (this.string_8.StartsWith(BookmarkStart.b("䌲䜴堶䤸伺䐼伾⑀", num)))
            {
                this.propertyType_0 = (PropertyType) ((int) Convert.ToInt64(A_2));
            }
        }
        else if (A_0.StartsWith(BookmarkStart.b("䔲ऴሶ", num)))
        {
            this.bool_53 = true;
            this.stack_29.Push(BookmarkStart.b("䠲", num));
            this.class835_0.bool_7 = true;
            if (((this.string_9 != null) && this.string_9.StartsWith(BookmarkStart.b("ᐲ", num))) && this.bool_37)
            {
                this.bool_37 = false;
            }
            this.itextRange_0 = this.method_7().AppendText(this.string_8.Substring(1));
            this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
            this.bool_27 = false;
        }
        else
        {
            string key = A_1;
            if (key != null)
            {
                int num31;
                if (Class1160.dictionary_164 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1cb);
                    dictionary1.Add(BookmarkStart.b("倲崴䜶常唺", num), 0);
                    dictionary1.Add(BookmarkStart.b("䔲尴制丸夺嘼䰾ㅀ", num), 1);
                    dictionary1.Add(BookmarkStart.b("䀲圴嘶䨸帺夼倾⽀", num), 2);
                    dictionary1.Add(BookmarkStart.b("䀲", num), 3);
                    dictionary1.Add(BookmarkStart.b("倲䘴", num), 4);
                    dictionary1.Add(BookmarkStart.b("䜲䘴", num), 5);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶䨸", num), 6);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶圸吺", num), 7);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶䨸䌺", num), 8);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶䨸䤺", num), 9);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶丸", num), 10);
                    dictionary1.Add(BookmarkStart.b("倲娴嬶䰸嘺匼", num), 11);
                    dictionary1.Add(BookmarkStart.b("䔲尴制丸债吼儾╀", num), 12);
                    dictionary1.Add(BookmarkStart.b("䔲尴制丸䠺帼帾ⵀ♂", num), 13);
                    dictionary1.Add(BookmarkStart.b("䔲尴制丸䄺嘼", num), 14);
                    dictionary1.Add(BookmarkStart.b("唲吴吶倸唺娼伾", num), 15);
                    dictionary1.Add(BookmarkStart.b("弲嬴匶䨸堺䴼䰾㥀ⵂ", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䜲尴䌶唸帺䴼堾", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似䴾", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似匾", num), 20);
                    dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似夾", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似匾", num), 0x16);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似夾", num), 0x17);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似", num), 0x18);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似䴾", num), 0x19);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸唺刼䬾⑀", num), 0x1a);
                    dictionary1.Add(BookmarkStart.b("唲䄴夶堸场䤼", num), 0x1b);
                    dictionary1.Add(BookmarkStart.b("倲崴儶䴸唺", num), 0x1c);
                    dictionary1.Add(BookmarkStart.b("䌲吴䔶崸", num), 0x1d);
                    dictionary1.Add(BookmarkStart.b("䌲头嘶倸唺", num), 30);
                    dictionary1.Add(BookmarkStart.b("䌲吴䔶", num), 0x1f);
                    dictionary1.Add(BookmarkStart.b("䄲䄴嬶娸区", num), 0x20);
                    dictionary1.Add(BookmarkStart.b("弲䄴䔶娸区", num), 0x21);
                    dictionary1.Add(BookmarkStart.b("䀲崴嘶崸", num), 0x22);
                    dictionary1.Add(BookmarkStart.b("䀲吴", num), 0x23);
                    dictionary1.Add(BookmarkStart.b("䀲吴嘶䰸伺刼", num), 0x24);
                    dictionary1.Add(BookmarkStart.b("䀲圴", num), 0x25);
                    dictionary1.Add(BookmarkStart.b("䀲圴嘶䰸伺刼", num), 0x26);
                    dictionary1.Add(BookmarkStart.b("唲䘴", num), 0x27);
                    dictionary1.Add(BookmarkStart.b("䀲䀴䜶尸䤺", num), 40);
                    dictionary1.Add(BookmarkStart.b("䀲䀴唶", num), 0x29);
                    dictionary1.Add(BookmarkStart.b("䘲䔴", num), 0x2a);
                    dictionary1.Add(BookmarkStart.b("圲嬴", num), 0x2b);
                    dictionary1.Add(BookmarkStart.b("嘲䴴䜶圸强䤼䠾", num), 0x2c);
                    dictionary1.Add(BookmarkStart.b("嘲䴴䜶圸强", num), 0x2d);
                    dictionary1.Add(BookmarkStart.b("崲娴䐶䰸䬺堼䴾㉀㙂❄", num), 0x2e);
                    dictionary1.Add(BookmarkStart.b("䀲头", num), 0x2f);
                    dictionary1.Add(BookmarkStart.b("䀲头娶䰸场䤼", num), 0x30);
                    dictionary1.Add(BookmarkStart.b("唲", num), 0x31);
                    dictionary1.Add(BookmarkStart.b("倲匴", num), 50);
                    dictionary1.Add(BookmarkStart.b("倲崴嘶䬸䠺帼帾ⵀ♂㵄", num), 0x33);
                    dictionary1.Add(BookmarkStart.b("倲崴吶嬸䬺尼䬾", num), 0x34);
                    dictionary1.Add(BookmarkStart.b("弲吴夶常", num), 0x35);
                    dictionary1.Add(BookmarkStart.b("弲吴夶常唺䴼", num), 0x36);
                    dictionary1.Add(BookmarkStart.b("䘲ἴ", num), 0x37);
                    dictionary1.Add(BookmarkStart.b("䘲", num), 0x38);
                    dictionary1.Add(BookmarkStart.b("䘲ᠴ", num), 0x39);
                    dictionary1.Add(BookmarkStart.b("䘲嘴", num), 0x3a);
                    dictionary1.Add(BookmarkStart.b("䘲䔴䔶", num), 0x3b);
                    dictionary1.Add(BookmarkStart.b("䈲嘴", num), 60);
                    dictionary1.Add(BookmarkStart.b("䈲弴", num), 0x3d);
                    dictionary1.Add(BookmarkStart.b("䈲头", num), 0x3e);
                    dictionary1.Add(BookmarkStart.b("䈲䜴", num), 0x3f);
                    dictionary1.Add(BookmarkStart.b("䜲䴴", num), 0x40);
                    dictionary1.Add(BookmarkStart.b("䜲䐴吶", num), 0x41);
                    dictionary1.Add(BookmarkStart.b("䜲䐴䔶", num), 0x42);
                    dictionary1.Add(BookmarkStart.b("䜲䐴匶尸堺", num), 0x43);
                    dictionary1.Add(BookmarkStart.b("䜲圴", num), 0x44);
                    dictionary1.Add(BookmarkStart.b("䜲头娶崸吺䤼", num), 0x45);
                    dictionary1.Add(BookmarkStart.b("䜲头匶嘸伺", num), 70);
                    dictionary1.Add(BookmarkStart.b("䜲头制䠸", num), 0x47);
                    dictionary1.Add(BookmarkStart.b("䜲头弶䀸䬺唼", num), 0x48);
                    dictionary1.Add(BookmarkStart.b("䜲头䈶唸", num), 0x49);
                    dictionary1.Add(BookmarkStart.b("䜲头䌶儸", num), 0x4a);
                    dictionary1.Add(BookmarkStart.b("䜲吴唶", num), 0x4b);
                    dictionary1.Add(BookmarkStart.b("唲尴ᨶ", num), 0x4c);
                    dictionary1.Add(BookmarkStart.b("唲尴", num), 0x4d);
                    dictionary1.Add(BookmarkStart.b("倲䀴儶倸", num), 0x4e);
                    dictionary1.Add(BookmarkStart.b("弲尴", num), 0x4f);
                    dictionary1.Add(BookmarkStart.b("弲尴ᨶ", num), 80);
                    dictionary1.Add(BookmarkStart.b("倲䀴嬶倸", num), 0x51);
                    dictionary1.Add(BookmarkStart.b("䄲尴", num), 0x52);
                    dictionary1.Add(BookmarkStart.b("䄲尴ᨶ", num), 0x53);
                    dictionary1.Add(BookmarkStart.b("倲䀴䔶倸", num), 0x54);
                    dictionary1.Add(BookmarkStart.b("堲倴制䤸", num), 0x55);
                    dictionary1.Add(BookmarkStart.b("堲倴制䤸唺", num), 0x56);
                    dictionary1.Add(BookmarkStart.b("尲䀴䌶唸刺匼娾ⵀ♂㍄≆╈", num), 0x57);
                    dictionary1.Add(BookmarkStart.b("弲倴䄶尸场", num), 0x58);
                    dictionary1.Add(BookmarkStart.b("䌲吴倶尸夺弼", num), 0x59);
                    dictionary1.Add(BookmarkStart.b("倲娴夶䴸帺䔼䬾㑀≂⥄㑆㥈⩊⹌⩎", num), 90);
                    dictionary1.Add(BookmarkStart.b("䐲尴匶娸伺儼伾⁀ㅂ", num), 0x5b);
                    dictionary1.Add(BookmarkStart.b("崲娴䀶倸强帼䬾ⵀ㍂⑄㕆", num), 0x5c);
                    dictionary1.Add(BookmarkStart.b("䌲吴倶尸", num), 0x5d);
                    dictionary1.Add(BookmarkStart.b("䐲䜴嘶䤸娺似倾㑀ⵂ⅄", num), 0x5e);
                    dictionary1.Add(BookmarkStart.b("䀲崴嘶崸刺匼堾", num), 0x5f);
                    dictionary1.Add(BookmarkStart.b("儲刴吶䬸吺丼䰾", num), 0x60);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券堺似倾㉀あ", num), 0x61);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券强帼䴾⹀あ㙄", num), 0x62);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券夺夼嘾⁀⑂", num), 0x63);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券崺夼嘾⁀⑂", num), 100);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券区刼䴾⡀㥂", num), 0x65);
                    dictionary1.Add(BookmarkStart.b("儲刴匶券䴺堼䴾㕀", num), 0x66);
                    dictionary1.Add(BookmarkStart.b("儲刴匶娸䤺刼䰾㉀", num), 0x67);
                    dictionary1.Add(BookmarkStart.b("儲刴唶崸刺尼堾", num), 0x68);
                    dictionary1.Add(BookmarkStart.b("儲刴儶崸刺尼堾", num), 0x69);
                    dictionary1.Add(BookmarkStart.b("儲刴弶嘸䤺吼䔾", num), 0x6a);
                    dictionary1.Add(BookmarkStart.b("儲刴䄶尸䤺䤼", num), 0x6b);
                    dictionary1.Add(BookmarkStart.b("儲", num), 0x6c);
                    dictionary1.Add(BookmarkStart.b("娲", num), 0x6d);
                    dictionary1.Add(BookmarkStart.b("倲吴䜶䨸", num), 110);
                    dictionary1.Add(BookmarkStart.b("䀲嘴嘶䤸䠺", num), 0x6f);
                    dictionary1.Add(BookmarkStart.b("䘲头", num), 0x70);
                    dictionary1.Add(BookmarkStart.b("䘲头䌶儸", num), 0x71);
                    dictionary1.Add(BookmarkStart.b("䘲头吶", num), 0x72);
                    dictionary1.Add(BookmarkStart.b("䘲头夶嘸唺堼", num), 0x73);
                    dictionary1.Add(BookmarkStart.b("䘲头匶嬸", num), 0x74);
                    dictionary1.Add(BookmarkStart.b("䀲䄴䔶倸债堼", num), 0x75);
                    dictionary1.Add(BookmarkStart.b("䀲倴吶䴸强", num), 0x76);
                    dictionary1.Add(BookmarkStart.b("䀲圴尶圸吺匼娾", num), 0x77);
                    dictionary1.Add(BookmarkStart.b("䀲圴尶娸吺儼", num), 120);
                    dictionary1.Add(BookmarkStart.b("䀲圴尶䤸娺娼娾", num), 0x79);
                    dictionary1.Add(BookmarkStart.b("䀲圴尶尸䴺堼儾", num), 0x7a);
                    dictionary1.Add(BookmarkStart.b("䀲圴尶嘸强夼", num), 0x7b);
                    dictionary1.Add(BookmarkStart.b("䀲倴吶䴸", num), 0x7c);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常场丼䜾⽀", num), 0x7d);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常场", num), 0x7e);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常伺丼䜾⽀", num), 0x7f);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常伺", num), 0x80);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常䤺丼䜾⽀", num), 0x81);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常䤺", num), 130);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常夺丼䜾⽀", num), 0x83);
                    dictionary1.Add(BookmarkStart.b("帲吴䔶常夺", num), 0x84);
                    dictionary1.Add(BookmarkStart.b("吲䀴䌶䴸帺似", num), 0x85);
                    dictionary1.Add(BookmarkStart.b("吲䀴䌶䴸帺似伾㍀⽂", num), 0x86);
                    dictionary1.Add(BookmarkStart.b("䌲刴䀶䨸䌺匼", num), 0x87);
                    dictionary1.Add(BookmarkStart.b("䌲吴䜶尸䤺䨼", num), 0x88);
                    dictionary1.Add(BookmarkStart.b("䌲刴弶䨸䌺匼", num), 0x89);
                    dictionary1.Add(BookmarkStart.b("䌲吴䜶尸䤺唼", num), 0x8a);
                    dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似䘾", num), 0x8b);
                    dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似䘾", num), 140);
                    dictionary1.Add(BookmarkStart.b("圲倴儶䴸娺弼", num), 0x8d);
                    dictionary1.Add(BookmarkStart.b("䄲䐴䈶嘸伺堼", num), 0x8e);
                    dictionary1.Add(BookmarkStart.b("弲䐴䈶嘸伺堼", num), 0x8f);
                    dictionary1.Add(BookmarkStart.b("䄲儴唶唸䨺䠼倾㕀♂", num), 0x90);
                    dictionary1.Add(BookmarkStart.b("弲儴唶唸䨺䠼倾㕀♂", num), 0x91);
                    dictionary1.Add(BookmarkStart.b("崲娴䌶堸夺吼儾╀", num), 0x92);
                    dictionary1.Add(BookmarkStart.b("䐲䜴嘶䤸伺似䰾ㅀ", num), 0x93);
                    dictionary1.Add(BookmarkStart.b("䌲䜴吶嘸场弼匾", num), 0x94);
                    dictionary1.Add(BookmarkStart.b("崲娴制䄸伺似帾㉀㍂㝄⭆", num), 0x95);
                    dictionary1.Add(BookmarkStart.b("崲娴吶嘸场弼帾ⵀ", num), 150);
                    dictionary1.Add(BookmarkStart.b("倲䌴娶吸帺", num), 0x97);
                    dictionary1.Add(BookmarkStart.b("䀲䔴䔶䨸伺丼伾", num), 0x98);
                    dictionary1.Add(BookmarkStart.b("䀲䔴䔶䨸䠺䴼崾❀", num), 0x99);
                    dictionary1.Add(BookmarkStart.b("尲䄴唶唸䤺䠼匾", num), 0x9a);
                    dictionary1.Add(BookmarkStart.b("䀲䈴䜶嬸强似", num), 0x9b);
                    dictionary1.Add(BookmarkStart.b("儲䜴尶弸䤺值", num), 0x9c);
                    dictionary1.Add(BookmarkStart.b("䀲䔴䔶䨸场匼䰾ㅀ", num), 0x9d);
                    dictionary1.Add(BookmarkStart.b("䀲䀴唶弸吺匼䬾⍀㩂㙄⹆㍈⹊", num), 0x9e);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䈶圸堺尼䬾⑀╂⩄⥆㵈⍊⡌♎㙐㭒⅔", num), 0x9f);
                    dictionary1.Add(BookmarkStart.b("儲儴唶弸区夼䴾", num), 160);
                    dictionary1.Add(BookmarkStart.b("圲嬴䌶嬸场匼䰾⍀❂❄", num), 0xa1);
                    dictionary1.Add(BookmarkStart.b("尲头匶唸刺匼娾㙀ㅂ⑄㝆", num), 0xa2);
                    dictionary1.Add(BookmarkStart.b("䐲䔴崶䨸伺", num), 0xa3);
                    dictionary1.Add(BookmarkStart.b("䐲䔴䐶䤸", num), 0xa4);
                    dictionary1.Add(BookmarkStart.b("䀲䔴嬶䀸伺䨼儾⡀ⵂ⁄", num), 0xa5);
                    dictionary1.Add(BookmarkStart.b("唲䄴夶唸䈺䤼䠾⽀⩂⭄≆", num), 0xa6);
                    dictionary1.Add(BookmarkStart.b("䘲䘴制唸伺弼帾ⵀⵂ", num), 0xa7);
                    dictionary1.Add(BookmarkStart.b("刲头夶䴸夺儼嘾⽀❂", num), 0xa8);
                    dictionary1.Add(BookmarkStart.b("弲䰴䌶娸娺儼尾㕀⅂⥄うⵈ", num), 0xa9);
                    dictionary1.Add(BookmarkStart.b("弲䰴䌶䴸夺儼䴾㕀⑂㝄", num), 170);
                    dictionary1.Add(BookmarkStart.b("弲嬴唶䬸债似䨾ⵀ♂", num), 0xab);
                    dictionary1.Add(BookmarkStart.b("爲䔴䜶唸䈺缼䴾⩀ᅂい⭆ⱈ㡊", num), 0xac);
                    dictionary1.Add(BookmarkStart.b("䐲䜴䜶䤸为匼尾㕀", num), 0xad);
                    dictionary1.Add(BookmarkStart.b("䀲嬴嘶䤸伺刼堾㍀⩂⅄⹆❈⡊⡌⍎㵐", num), 0xae);
                    dictionary1.Add(BookmarkStart.b("刲䘴帶堸唺弼䴾⩀ㅂい⭆ⱈ", num), 0xaf);
                    dictionary1.Add(BookmarkStart.b("崲娴䐶䤸娺帼娾❀ⱂ㝄㉆╈", num), 0xb0);
                    dictionary1.Add(BookmarkStart.b("崲娴䈶唸伺似匾㉀㍂♄", num), 0xb1);
                    dictionary1.Add(BookmarkStart.b("帲䘴娶娸娺䴼", num), 0xb2);
                    dictionary1.Add(BookmarkStart.b("刲头嬶嘸䰺嬼嘾⑀⽂⅄≆❈⽊㹌⩎㵐", num), 0xb3);
                    dictionary1.Add(BookmarkStart.b("弲䰴䌶䤸䤺䤼刾⑀㝂", num), 180);
                    dictionary1.Add(BookmarkStart.b("弲䰴䌶尸䌺帼䬾㕀㍂", num), 0xb5);
                    dictionary1.Add(BookmarkStart.b("儲儴䔶䬸场丼䠾㉀⩂㵄", num), 0xb6);
                    dictionary1.Add(BookmarkStart.b("崲娴嬶圸区䤼帾╀⥂ㅄ╆╈", num), 0xb7);
                    dictionary1.Add(BookmarkStart.b("崲娴䌶伸娺䤼䜾⍀㭂", num), 0xb8);
                    dictionary1.Add(BookmarkStart.b("嘲䴴䜶䨸区似䬾⽀", num), 0xb9);
                    dictionary1.Add(BookmarkStart.b("嬲䄴娶堸为䤼䰾ㅀ", num), 0xba);
                    dictionary1.Add(BookmarkStart.b("䀲䔴䔶䨸伺丼刾", num), 0xbb);
                    dictionary1.Add(BookmarkStart.b("尲头匶堸䠺", num), 0xbc);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䈶圸堺堼䜾", num), 0xbd);
                    dictionary1.Add(BookmarkStart.b("崲娴䌶娸䴺尼䰾ㅀ", num), 190);
                    dictionary1.Add(BookmarkStart.b("崲娴䌶嬸䤺嘼尾⽀あㅄⅆ㭈⡊㥌ⵎ㵐", num), 0xbf);
                    dictionary1.Add(BookmarkStart.b("嬲䈴制唸帺䬼", num), 0xc0);
                    dictionary1.Add(BookmarkStart.b("崲娴帶圸强匼刾⍀ㅂㅄ㑆", num), 0xc1);
                    dictionary1.Add(BookmarkStart.b("崲娴唶䬸债䨼䴾ㅀ㝂❄⭆", num), 0xc2);
                    dictionary1.Add(BookmarkStart.b("崲娴嬶尸娺夼", num), 0xc3);
                    dictionary1.Add(BookmarkStart.b("崲娴嘶弸堺匼䰾㕀㝂❄⭆", num), 0xc4);
                    dictionary1.Add(BookmarkStart.b("娲嬴匶䬸场丼䠾⑀⽂⁄ㅆⱈ╊", num), 0xc5);
                    dictionary1.Add(BookmarkStart.b("䘲䘴制圸吺似刾㉀㝂㱄ⅆ♈㥊⅌♎≐❒", num), 0xc6);
                    dictionary1.Add(BookmarkStart.b("崲娴伶唸娺䤼䬾⹀㩂⁄⥆", num), 0xc7);
                    dictionary1.Add(BookmarkStart.b("崲倴䀶䴸夺儼䰾㕀㩂㝄㉆╈㡊", num), 200);
                    dictionary1.Add(BookmarkStart.b("唲倴嬶圸夺似娾ⵀ♂㍄", num), 0xc9);
                    dictionary1.Add(BookmarkStart.b("刲匴制唸帺䬼", num), 0xca);
                    dictionary1.Add(BookmarkStart.b("堲䜴夶䤸䤺丼儾⑀㝂", num), 0xcb);
                    dictionary1.Add(BookmarkStart.b("倲吴吶儸帺夼尾⹀⽂❄♆╈", num), 0xcc);
                    dictionary1.Add(BookmarkStart.b("䘲䄴帶圸场", num), 0xcd);
                    dictionary1.Add(BookmarkStart.b("崲娴倶䬸吺䨼帾㑀㝂⩄ⅆ⁈㽊", num), 0xce);
                    dictionary1.Add(BookmarkStart.b("崲娴吶䄸䠺䴼䬾⁀⅂⥄≆", num), 0xcf);
                    dictionary1.Add(BookmarkStart.b("䀲䔴嬶䴸䬺娼伾⁀ㅂ", num), 0xd0);
                    dictionary1.Add(BookmarkStart.b("䀲䔴䔶䨸夺丼伾", num), 0xd1);
                    dictionary1.Add(BookmarkStart.b("唲娴䔶吸䠺唼帾╀♂", num), 210);
                    dictionary1.Add(BookmarkStart.b("崲娴崶券帺似儾ㅀ㙂⭄⑆㵈", num), 0xd3);
                    dictionary1.Add(BookmarkStart.b("夲倴伶䤸娺匼嬾", num), 0xd4);
                    dictionary1.Add(BookmarkStart.b("夲嘴堶吸䬺似娾㉀あ", num), 0xd5);
                    dictionary1.Add(BookmarkStart.b("嘲嬴匶堸䠺唼", num), 0xd6);
                    dictionary1.Add(BookmarkStart.b("嘲場匶堸䠺唼", num), 0xd7);
                    dictionary1.Add(BookmarkStart.b("嬲尴倶儸场吼堾⥀㝂", num), 0xd8);
                    dictionary1.Add(BookmarkStart.b("崲娴夶䨸区䴼伾⡀⁂ㅄ", num), 0xd9);
                    dictionary1.Add(BookmarkStart.b("䀲崴䜶䤸刺帼䬾", num), 0xda);
                    dictionary1.Add(BookmarkStart.b("䀲崴䜶常䤺䴼", num), 0xdb);
                    dictionary1.Add(BookmarkStart.b("䀲崴䜶", num), 220);
                    dictionary1.Add(BookmarkStart.b("䀲崴䜶䬸䠺儼䬾", num), 0xdd);
                    dictionary1.Add(BookmarkStart.b("尲圴崶尸堺䤼", num), 0xde);
                    dictionary1.Add(BookmarkStart.b("尲圴崶尸嘺弼", num), 0xdf);
                    dictionary1.Add(BookmarkStart.b("尲圴崶娸场尼䰾㉀", num), 0xe0);
                    dictionary1.Add(BookmarkStart.b("尲圴崶崸娺䤼帾", num), 0xe1);
                    dictionary1.Add(BookmarkStart.b("圲吴䌶堸崺吼娾ⵀ❂", num), 0xe2);
                    dictionary1.Add(BookmarkStart.b("䜲䴴儶倸帺儼嬾㕀♂㵄㍆", num), 0xe3);
                    dictionary1.Add(BookmarkStart.b("弲娴吶儸", num), 0xe4);
                    dictionary1.Add(BookmarkStart.b("嬲尴吶儸", num), 0xe5);
                    dictionary1.Add(BookmarkStart.b("圲圴吶儸", num), 230);
                    dictionary1.Add(BookmarkStart.b("䌲尴吶䴸", num), 0xe7);
                    dictionary1.Add(BookmarkStart.b("儲帴娶券䠺䤼帾㍀㝂", num), 0xe8);
                    dictionary1.Add(BookmarkStart.b("儲帴娶券帺匼嬾", num), 0xe9);
                    dictionary1.Add(BookmarkStart.b("䌲䜴堶䴸䠺䤼帾㍀㝂", num), 0xea);
                    dictionary1.Add(BookmarkStart.b("䌲䜴堶䴸帺匼嬾", num), 0xeb);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䌶尸䌺䤼", num), 0xec);
                    dictionary1.Add(BookmarkStart.b("弲尴䐶䴸伺堼䜾㕀", num), 0xed);
                    dictionary1.Add(BookmarkStart.b("弲䘴", num), 0xee);
                    dictionary1.Add(BookmarkStart.b("䄲䄴嬶䤸娺似", num), 0xef);
                    dictionary1.Add(BookmarkStart.b("弲䄴䔶䤸娺似", num), 240);
                    dictionary1.Add(BookmarkStart.b("弲尴夶", num), 0xf1);
                    dictionary1.Add(BookmarkStart.b("䄲尴夶", num), 0xf2);
                    dictionary1.Add(BookmarkStart.b("娲䔴倶䤸", num), 0xf3);
                    dictionary1.Add(BookmarkStart.b("娲头䄶唸", num), 0xf4);
                    dictionary1.Add(BookmarkStart.b("䌲嬴", num), 0xf5);
                    dictionary1.Add(BookmarkStart.b("儲䀴嬶唸帺䤼", num), 0xf6);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶伸场弼匾㕀", num), 0xf7);
                    dictionary1.Add(BookmarkStart.b("䌲嬴儶", num), 0xf8);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶伸场弼倾╀㩂", num), 0xf9);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶伸场", num), 250);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䐶䴸娺似䬾", num), 0xfb);
                    dictionary1.Add(BookmarkStart.b("䌲嬴匶尸堺", num), 0xfc);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶娸䤺值", num), 0xfd);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶娸䤺值", num), 0xfe);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶娸场䤼䴾", num), 0xff);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶娸场䤼䴾", num), 0x100);
                    dictionary1.Add(BookmarkStart.b("䌲嬴堶䬸强", num), 0x101);
                    dictionary1.Add(BookmarkStart.b("䌲嬴堶䬸强䤼", num), 0x102);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䌶䄸伺尼ᄾ", num), 0x103);
                    dictionary1.Add(BookmarkStart.b("䌲嬴帶圸强堼儾㕀", num), 260);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䐶䤸", num), 0x105);
                    dictionary1.Add(BookmarkStart.b("䌲嬴唶ጸ", num), 0x106);
                    dictionary1.Add(BookmarkStart.b("䌲嬴唶", num), 0x107);
                    dictionary1.Add(BookmarkStart.b("䌲嬴帶ጸ", num), 0x108);
                    dictionary1.Add(BookmarkStart.b("䌲嬴帶", num), 0x109);
                    dictionary1.Add(BookmarkStart.b("䌲嬴吶堸䬺丼ᔾ", num), 0x10a);
                    dictionary1.Add(BookmarkStart.b("䌲嬴吶堸䬺丼", num), 0x10b);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸ᄺ", num), 0x10c);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸", num), 0x10d);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强᜼", num), 270);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强", num), 0x10f);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强尼䰾⥀楂", num), 0x110);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强尼䰾⥀", num), 0x111);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸䰺尼䤾⑀楂", num), 0x112);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸䰺尼䤾⑀", num), 0x113);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强弼ᔾ", num), 0x114);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸强弼", num), 0x115);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸伺唼ᔾ", num), 0x116);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸伺唼", num), 0x117);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸唺刼儾⑀楂", num), 280);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䈶唸唺刼儾⑀", num), 0x119);
                    dictionary1.Add(BookmarkStart.b("䌲嬴儶䨸", num), 0x11a);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䘶娸", num), 0x11b);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䘶唸", num), 0x11c);
                    dictionary1.Add(BookmarkStart.b("䌲嬴䘶䬸", num), 0x11d);
                    dictionary1.Add(BookmarkStart.b("䌲嬴嬶伸场帼倾⽀㝂", num), 0x11e);
                    dictionary1.Add(BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄", num), 0x11f);
                    dictionary1.Add(BookmarkStart.b("䜲䜴堶丸强", num), 0x120);
                    dictionary1.Add(BookmarkStart.b("弲䄴䔶䬸吺䨼", num), 0x121);
                    dictionary1.Add(BookmarkStart.b("䄲娴䀶", num), 290);
                    dictionary1.Add(BookmarkStart.b("崲倴䐶䴸䤺刼䠾", num), 0x123);
                    dictionary1.Add(BookmarkStart.b("倲倴嬶唸䌺", num), 0x124);
                    dictionary1.Add(BookmarkStart.b("倲倴嬶唸", num), 0x125);
                    dictionary1.Add(BookmarkStart.b("崲倴䐶䴸堺堼匾ⵀ", num), 0x126);
                    dictionary1.Add(BookmarkStart.b("娲嬴䌶嬸场", num), 0x127);
                    dictionary1.Add(BookmarkStart.b("娲䄴嘶䤸", num), 0x128);
                    dictionary1.Add(BookmarkStart.b("弲吴䐶䴸䤺刼䠾", num), 0x129);
                    dictionary1.Add(BookmarkStart.b("䜲䜴嘶䰸伺刼夾⡀㝂", num), 0x12a);
                    dictionary1.Add(BookmarkStart.b("䜲吴䜶䬸伺儼", num), 0x12b);
                    dictionary1.Add(BookmarkStart.b("䜲䜴弶崸䤺", num), 300);
                    dictionary1.Add(BookmarkStart.b("䜲䜴尶尸帺䴼", num), 0x12d);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䔶儸", num), 0x12e);
                    dictionary1.Add(BookmarkStart.b("䜲䜴倶堸䬺唼", num), 0x12f);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼崾", num), 0x130);
                    dictionary1.Add(BookmarkStart.b("䜲圴嬶倸唺夼", num), 0x131);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼匾", num), 0x132);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼䴾", num), 0x133);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼䬾", num), 0x134);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼夾⍀", num), 0x135);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼夾㕀", num), 310);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼夾㍀", num), 0x137);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䜶堸强夼夾ⵀ", num), 0x138);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强弼", num), 0x139);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强儼", num), 0x13a);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强似", num), 0x13b);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强䤼", num), 0x13c);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强嬼崾", num), 0x13d);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强嬼䬾", num), 0x13e);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强嬼匾", num), 0x13f);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䐶䤸强嬼䴾", num), 320);
                    dictionary1.Add(BookmarkStart.b("䜲䜴嬶尸崺䤼", num), 0x141);
                    dictionary1.Add(BookmarkStart.b("䜲䜴嬶尸崺䤼ሾ", num), 0x142);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䘶娸", num), 0x143);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䘶唸", num), 0x144);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䘶䬸", num), 0x145);
                    dictionary1.Add(BookmarkStart.b("䜲䜴儶䴸䠺樼嘾╀㝂ⵄ", num), 0x146);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䀶游刺夼䬾⥀", num), 0x147);
                    dictionary1.Add(BookmarkStart.b("䜲䜴儶䴸䠺樼嘾╀㝂ⵄՆ", num), 0x148);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䀶游刺夼䬾⥀ł", num), 0x149);
                    dictionary1.Add(BookmarkStart.b("䜲䜴儶䴸䠺樼嘾╀㝂ⵄن", num), 330);
                    dictionary1.Add(BookmarkStart.b("䜲䜴䀶游刺夼䬾⥀ɂ", num), 0x14b);
                    dictionary1.Add(BookmarkStart.b("倲头然倸伺椼娾㥀㝂", num), 0x14c);
                    dictionary1.Add(BookmarkStart.b("倲头礶嘸氺似帾ㅀ", num), 0x14d);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强儼", num), 0x14e);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强䤼", num), 0x14f);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强弼", num), 0x150);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强似", num), 0x151);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强嬼匾", num), 0x152);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强嬼䬾", num), 0x153);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强嬼崾", num), 340);
                    dictionary1.Add(BookmarkStart.b("倲头䜶堸强嬼䴾", num), 0x155);
                    dictionary1.Add(BookmarkStart.b("倲头儶䴸䠺樼嘾╀㝂ⵄ", num), 0x156);
                    dictionary1.Add(BookmarkStart.b("倲头䀶游刺夼䬾⥀", num), 0x157);
                    dictionary1.Add(BookmarkStart.b("倲头䄶尸䤺䤼帾ⵀ㝂", num), 0x158);
                    dictionary1.Add(BookmarkStart.b("倲头䄶尸䤺䤼帾ⵀ⁂", num), 0x159);
                    dictionary1.Add(BookmarkStart.b("倲头䄶尸䤺䤼帾ⵀ⅂", num), 0x15a);
                    dictionary1.Add(BookmarkStart.b("倲头䌶䄸场似䬾⍀", num), 0x15b);
                    dictionary1.Add(BookmarkStart.b("倲头䌶䄸伺弼䴾ⵀ", num), 0x15c);
                    dictionary1.Add(BookmarkStart.b("倲头䌶䄸夺䤼匾㍀", num), 0x15d);
                    dictionary1.Add(BookmarkStart.b("倲头䌶䄸场似䬾⍀㕂", num), 350);
                    dictionary1.Add(BookmarkStart.b("倲头䌶䄸伺弼䴾ⵀ㕂", num), 0x15f);
                    dictionary1.Add(BookmarkStart.b("倲头唶䬸强似䬾", num), 0x160);
                    dictionary1.Add(BookmarkStart.b("倲头唶䬸强似䴾", num), 0x161);
                    dictionary1.Add(BookmarkStart.b("倲头唶䬸强似匾", num), 0x162);
                    dictionary1.Add(BookmarkStart.b("倲头唶䬸强似崾", num), 0x163);
                    dictionary1.Add(BookmarkStart.b("倲头吶嬸䬺尼䬾", num), 0x164);
                    dictionary1.Add(BookmarkStart.b("倲头䐶儸强匼堾㍀≂㉄", num), 0x165);
                    dictionary1.Add(BookmarkStart.b("倲头䐶儸强匼堾", num), 0x166);
                    dictionary1.Add(BookmarkStart.b("倲头唶常区刼䴾⡀㥂", num), 0x167);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾⥀ⱂ㝄⹆㍈", num), 360);
                    dictionary1.Add(BookmarkStart.b("倲头唶常䴺堼䴾㕀", num), 0x169);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾㝀♂㝄㍆", num), 0x16a);
                    dictionary1.Add(BookmarkStart.b("倲头唶常崺夼嘾⁀⑂", num), 0x16b);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾❀❂ⱄ♆⹈", num), 0x16c);
                    dictionary1.Add(BookmarkStart.b("倲头唶常夺夼嘾⁀⑂", num), 0x16d);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾⍀❂ⱄ♆⹈", num), 0x16e);
                    dictionary1.Add(BookmarkStart.b("倲头唶常堺似倾㉀あ", num), 0x16f);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾≀ㅂ⩄㑆㩈", num), 0x170);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强帼䴾⹀あ㙄", num), 0x171);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⁂㝄⡆㩈㡊", num), 370);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼圾⹀ㅂ", num), 0x173);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂ⵄ⡆㭈", num), 0x174);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼䤾⑀ㅂㅄ", num), 0x175);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂㍄≆㭈㽊", num), 0x176);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼夾╀⩂⑄⁆", num), 0x177);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂⍄⍆⁈⩊⩌", num), 0x178);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼崾╀⩂⑄⁆", num), 0x179);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂❄⍆⁈⩊⩌", num), 0x17a);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼尾㍀ⱂ㙄㑆", num), 0x17b);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂♄㕆♈㡊㹌", num), 380);
                    dictionary1.Add(BookmarkStart.b("倲头唶常强嘼嬾≀ㅂ⩄㑆㩈", num), 0x17d);
                    dictionary1.Add(BookmarkStart.b("䄲吴䀶娸场弼堾╀⡂⅄⑆㭈⑊㹌㱎", num), 0x17e);
                    dictionary1.Add(BookmarkStart.b("倲头䄶吸尺嬼", num), 0x17f);
                    dictionary1.Add(BookmarkStart.b("倲头䄶吸䤺娼", num), 0x180);
                    dictionary1.Add(BookmarkStart.b("倲头娶常崺", num), 0x181);
                    dictionary1.Add(BookmarkStart.b("倲头娶䬸尺", num), 0x182);
                    dictionary1.Add(BookmarkStart.b("唲尴制唸强", num), 0x183);
                    dictionary1.Add(BookmarkStart.b("唲匴䌶䀸䬺堼䬾㥀㝂", num), 0x184);
                    dictionary1.Add(BookmarkStart.b("唲头匶崸刺似䬾㡀", num), 0x185);
                    dictionary1.Add(BookmarkStart.b("唲头匶唸吺帼吾", num), 390);
                    dictionary1.Add(BookmarkStart.b("唲头匶倸唺丼䬾", num), 0x187);
                    dictionary1.Add(BookmarkStart.b("唲头匶䬸䠺儼䬾", num), 0x188);
                    dictionary1.Add(BookmarkStart.b("䔲", num), 0x189);
                    dictionary1.Add(BookmarkStart.b("唲匴䌶䀸䬺堼", num), 0x18a);
                    dictionary1.Add(BookmarkStart.b("唲匴䜶䬸吺䤼", num), 0x18b);
                    dictionary1.Add(BookmarkStart.b("唲匴䐶倸䄺堼", num), 0x18c);
                    dictionary1.Add(BookmarkStart.b("唲匴䔶尸堺尼匾≀", num), 0x18d);
                    dictionary1.Add(BookmarkStart.b("唲匴弶堸䠺儼嘾㉀㝂❄⡆ㅈ", num), 0x18e);
                    dictionary1.Add(BookmarkStart.b("唲匴娶堸䌺儼娾⽀", num), 0x18f);
                    dictionary1.Add(BookmarkStart.b("唲匴弶䤸䠺", num), 400);
                    dictionary1.Add(BookmarkStart.b("唲匴䔶尸䠺", num), 0x191);
                    dictionary1.Add(BookmarkStart.b("唲匴匶尸崺似娾㉀", num), 0x192);
                    dictionary1.Add(BookmarkStart.b("䌲崴娶䬸尺", num), 0x193);
                    dictionary1.Add(BookmarkStart.b("䌲崴䜶常", num), 0x194);
                    dictionary1.Add(BookmarkStart.b("䌲崴吶嘸场", num), 0x195);
                    dictionary1.Add(BookmarkStart.b("䌲䌴娶䬸尺", num), 0x196);
                    dictionary1.Add(BookmarkStart.b("䌲䌴䜶常", num), 0x197);
                    dictionary1.Add(BookmarkStart.b("䌲䌴䜶堸䤺尼", num), 0x198);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䄸䤺", num), 0x199);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䄸场", num), 410);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䄸堺", num), 0x19b);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䄸", num), 0x19c);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸刺儼", num), 0x19d);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸伺", num), 0x19e);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸堺", num), 0x19f);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸夺", num), 0x1a0);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸刺匼", num), 0x1a1);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸吺䠼䬾", num), 0x1a2);
                    dictionary1.Add(BookmarkStart.b("䌲娴䐶䀸", num), 0x1a3);
                    dictionary1.Add(BookmarkStart.b("刲圴䐶丸", num), 420);
                    dictionary1.Add(BookmarkStart.b("刲圴䐶儸", num), 0x1a5);
                    dictionary1.Add(BookmarkStart.b("刲圴䐶唸吺帼吾", num), 0x1a6);
                    dictionary1.Add(BookmarkStart.b("圲匴䔶吸伺䔼䬾㥀", num), 0x1a7);
                    dictionary1.Add(BookmarkStart.b("圲匴䔶吸伺䔼䬾㡀", num), 0x1a8);
                    dictionary1.Add(BookmarkStart.b("倲圴䜶堸伺", num), 0x1a9);
                    dictionary1.Add(BookmarkStart.b("䜲儴儶䬸嘺䤼䜾㕀ག⁄ⅆ㵈", num), 0x1aa);
                    dictionary1.Add(BookmarkStart.b("䜲儴儶䬸嘺䤼䜾㕀ᅂⱄ⁆ⅈ㽊", num), 0x1ab);
                    dictionary1.Add(BookmarkStart.b("䜲儴儶䬸嘺䤼䜾㕀ᝂ⩄㝆", num), 0x1ac);
                    dictionary1.Add(BookmarkStart.b("䜲儴儶䬸嘺䤼䜾㕀ł⩄㍆㵈⑊⁌", num), 0x1ad);
                    dictionary1.Add(BookmarkStart.b("䜲吴唶䨸唺刼倾㝀ㅂ⥄㝆", num), 430);
                    dictionary1.Add(BookmarkStart.b("䜲䔴弶娸吺儼", num), 0x1af);
                    dictionary1.Add(BookmarkStart.b("䜲䔴弶吸䤺娼", num), 0x1b0);
                    dictionary1.Add(BookmarkStart.b("䜲䔴弶䤸尺", num), 0x1b1);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸唺堼堾㥀", num), 0x1b2);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺", num), 0x1b3);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸唺堼堾㡀", num), 0x1b4);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺", num), 0x1b5);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺帼", num), 0x1b6);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺吼", num), 0x1b7);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺儼", num), 440);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺刼", num), 0x1b9);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䌺似", num), 0x1ba);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺弼", num), 0x1bb);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺帼", num), 0x1bc);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺吼匾", num), 0x1bd);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺吼儾", num), 0x1be);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺刼䨾㕀", num), 0x1bf);
                    dictionary1.Add(BookmarkStart.b("䜲䔴堶䨸䈺䤼", num), 0x1c0);
                    dictionary1.Add(BookmarkStart.b("䜲䔴䄶吸䤺娼", num), 0x1c1);
                    dictionary1.Add(BookmarkStart.b("䜲䔴䄶䤸尺", num), 450);
                    dictionary1.Add(BookmarkStart.b("䜲䔴䄶䤸娺似帾", num), 0x1c3);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶䴸夺儼", num), 0x1c4);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶倸䠺堼嬾", num), 0x1c5);
                    dictionary1.Add(BookmarkStart.b("圲倴嬶尸伺堼嬾", num), 0x1c6);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶堸为䤼圾", num), 0x1c7);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶堸为䤼圾╀♂⥄", num), 0x1c8);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶崸伺䤼刾", num), 0x1c9);
                    dictionary1.Add(BookmarkStart.b("䄲倴䄶崸伺䤼刾╀♂⥄", num), 0x1ca);
                    Class1160.dictionary_164 = dictionary1;
                }
                if (Class1160.dictionary_164.TryGetValue(key, out num31))
                {
                    string str;
                    switch (num31)
                    {
                        case 0:
                        {
                            Field field = this.method_7().AppendField("", FieldType.FieldPage);
                            field.IsNotField = true;
                            this.method_169(field.CharacterFormat, this.class835_0);
                            if ((((field.NextSibling != null) && (field.NextSibling.DocumentObjectType == DocumentObjectType.FieldMark)) && (((field.NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator) && (field.NextSibling.NextSibling != null))) && (field.NextSibling.NextSibling.DocumentObjectType == DocumentObjectType.TextRange))
                            {
                                this.method_169((field.NextSibling.NextSibling as TextRange).CharacterFormat, this.class835_0);
                            }
                            return;
                        }
                        case 1:
                            if (A_2 == BookmarkStart.b("Ȳ", num))
                            {
                                this.bool_62 = true;
                            }
                            return;

                        case 2:
                        {
                            int num18 = this.method_115(BookmarkStart.b("䀲圴嘶䨸帺夼倾⽀", num), this.string_8);
                            string str3 = this.method_116(num18, this.dictionary_6);
                            if (((this.method_21() == RtfTableType.StyleSheet) && (this.style_0 != null)) && (this.dictionary_6.ContainsKey(str3) && !(this.style_0 is Class13)))
                            {
                                this.style_0.ApplyBaseStyle(this.dictionary_6[str3].Name);
                            }
                            return;
                        }
                        case 3:
                            if (this.method_21() == RtfTableType.StyleSheet)
                            {
                                this.string_22 = this.string_8;
                                this.style_0 = new ParagraphStyle(this.document_0, false);
                                if (this.style_0.BaseStyle != null)
                                {
                                    this.style_0.method_6();
                                }
                                if (this.method_114(BookmarkStart.b("䀲", num), this.string_8))
                                {
                                    this.style_0.IsCustomStyle = true;
                                }
                                if (this.iparagraph_0 == null)
                                {
                                    this.iparagraph_0 = new Paragraph(this.document_0);
                                    this.method_139(this.method_7().Format);
                                }
                                else
                                {
                                    this.method_138(this.iparagraph_0.Format);
                                }
                                this.class835_0 = this.method_175();
                                this.string_25 = string.Empty;
                                return;
                            }
                            if (this.dictionary_6.ContainsKey(this.string_8))
                            {
                                this.method_7().ApplyStyle(this.dictionary_6[this.string_8].Name);
                            }
                            return;

                        case 4:
                            if (this.method_21() == RtfTableType.StyleSheet)
                            {
                                this.string_22 = this.string_8;
                                this.style_0 = new Class11(this.document_0);
                                this.class835_0 = this.method_175();
                                this.string_25 = string.Empty;
                            }
                            return;

                        case 5:
                            if (this.method_21() == RtfTableType.StyleSheet)
                            {
                                this.stack_38.Push(this.bool_19);
                                this.bool_19 = true;
                                this.string_22 = this.string_8;
                                this.style_0 = new Class13(this.document_0);
                                this.cellFormat_0 = new CellFormat();
                                this.cellFormat_0.Paddings.All = 0f;
                                this.rowFormat_0 = new RowFormat();
                                this.rowFormat_0.method_0(this.document_0);
                                this.rowFormat_0.Paddings.All = 0f;
                                this.class835_0 = this.method_175();
                                this.string_25 = string.Empty;
                            }
                            return;

                        case 6:
                        {
                            float num10 = this.method_118(Convert.ToInt32(A_2));
                            for (int i = 0; i < Convert.ToInt32(A_2); i++)
                            {
                                this.method_10().AddColumn(num10, 36f);
                            }
                            this.method_9(this.method_10().Columns[0]);
                            return;
                        }
                        case 7:
                            if (this.method_10().Columns.Count >= Convert.ToInt32(A_2))
                            {
                                this.method_9(this.method_10().Columns[Convert.ToInt32(A_2) - 1]);
                            }
                            return;

                        case 8:
                        case 9:
                            this.method_8().Space = this.method_165(A_2);
                            return;

                        case 10:
                            this.method_8().Width = this.method_165(A_2);
                            if (this.method_10().Columns.Count > 1)
                            {
                                this.method_10().PageSetup.EqualColumnWidth = false;
                            }
                            return;

                        case 11:
                        {
                            Break @break = new Break(this.document_0, BreakType.ColumnBreak);
                            this.method_58(@break);
                            return;
                        }
                        case 12:
                            switch (Convert.ToInt32(A_2))
                            {
                                case 0:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.None;
                                    return;

                                case 1:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.NormalLayout;
                                    return;

                                case 2:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.OutlineLayout;
                                    return;

                                case 3:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.PrintLayout;
                                    return;

                                case 4:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.WebLayout;
                                    return;

                                case 5:
                                    this.document_0.ViewSetup.DocumentViewType = DocumentViewType.OutlineLayout;
                                    return;
                            }
                            return;

                        case 13:
                            this.document_0.ViewSetup.ZoomPercent = Convert.ToInt32(A_2);
                            return;

                        case 14:
                            switch (Convert.ToInt32(A_2))
                            {
                                case 0:
                                    this.document_0.ViewSetup.ZoomType = ZoomType.None;
                                    return;

                                case 1:
                                    this.document_0.ViewSetup.ZoomType = ZoomType.FullPage;
                                    return;

                                case 2:
                                    this.document_0.ViewSetup.ZoomType = ZoomType.PageWidth;
                                    return;

                                case 3:
                                    this.document_0.ViewSetup.ZoomType = ZoomType.TextFit;
                                    return;
                            }
                            return;

                        case 15:
                            this.bool_31 = true;
                            this.method_10().PageSetup.DifferentOddAndEvenPagesHeaderFooter = true;
                            return;

                        case 0x10:
                            this.class836_0.pageOrientation_0 = PageOrientation.Landscape;
                            return;

                        case 0x11:
                            this.method_10().PageSetup.DifferentFirstPageHeaderFooter = true;
                            return;

                        case 0x12:
                        case 0x13:
                            this.bool_28 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.HeaderOdd;
                            this.body_0 = this.method_10().HeadersFooters.OddHeader;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 20:
                            this.bool_28 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.HeaderEven;
                            this.body_0 = this.method_10().HeadersFooters.EvenHeader;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 0x15:
                            this.bool_28 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.HeaderFirstPage;
                            this.body_0 = this.method_10().HeadersFooters.FirstPageHeader;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 0x16:
                            this.bool_29 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.FooterEven;
                            this.body_0 = this.method_10().HeadersFooters.EvenFooter;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 0x17:
                            this.bool_29 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.FooterFirstPage;
                            this.body_0 = this.method_10().HeadersFooters.FirstPageFooter;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 0x18:
                        case 0x19:
                            this.bool_29 = true;
                            this.bool_20 = false;
                            this.stack_7.Push(BookmarkStart.b("䠲", num));
                            this.headerFooterType_0 = HeaderFooterType.FooterOdd;
                            this.body_0 = this.method_10().HeadersFooters.OddFooter;
                            if (this.body_0.ChildObjects.Count != 0)
                            {
                                this.body_0.ChildObjects.Clear();
                            }
                            return;

                        case 0x1a:
                            this.bool_64 = true;
                            this.footnote_0 = new Footnote(this.document_0);
                            this.footnote_0.FootnoteType = FootnoteType.Footnote;
                            this.method_58(this.footnote_0);
                            this.method_169(this.footnote_0.MarkerCharacterFormat, this.class835_0);
                            if (!this.bool_65)
                            {
                                this.footnote_0.IsAutoNumbered = true;
                            }
                            else
                            {
                                this.footnote_0.IsAutoNumbered = false;
                            }
                            this.stack_41.Push(BookmarkStart.b("䠲", num));
                            this.stack_42.Push(this.method_7());
                            this.iparagraph_0 = null;
                            this.stack_43.Push(this.body_0);
                            this.body_0 = this.footnote_0.TextBody;
                            this.bool_65 = true;
                            this.int_29 = this.int_13;
                            this.int_30 = this.int_12;
                            this.bool_66 = this.bool_33;
                            this.bool_67 = this.bool_34;
                            this.int_13 = 0;
                            this.int_12 = 0;
                            this.bool_33 = false;
                            this.bool_34 = false;
                            this.stack_45.Push(this.itable_0);
                            this.stack_46.Push(this.tableRow_0);
                            this.stack_47.Push(this.tableCell_0);
                            this.itable_0 = null;
                            this.tableRow_0 = null;
                            this.tableCell_0 = null;
                            this.stack_44.Push(this.dictionary_2);
                            this.dictionary_2 = new Dictionary<int, CellFormat>();
                            return;

                        case 0x1b:
                            this.footnote_0.FootnoteType = FootnoteType.Endnote;
                            return;

                        case 0x1c:
                        {
                            if (!this.bool_64)
                            {
                                this.bool_65 = false;
                                return;
                            }
                            char ch2 = '\x0002';
                            this.itextRange_0 = this.method_7().AppendText(ch2.ToString());
                            this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            return;
                        }
                        case 0x1d:
                            if (!this.bool_43)
                            {
                                this.bool_40 = true;
                                this.method_126();
                                if (this.bool_17 || this.bool_19)
                                {
                                    if ((this.bool_19 || this.bool_33) && (this.iparagraph_0 != null))
                                    {
                                        this.method_138(this.iparagraph_0.Format);
                                        this.iparagraph_0.ApplyStyle(BookmarkStart.b("紲娴䔶吸娺儼", num));
                                    }
                                    return;
                                }
                                this.method_125();
                            }
                            return;

                        case 30:
                            if (!this.bool_17)
                            {
                                this.stack_19.Push(BookmarkStart.b("䌲头嘶倸唺", num));
                                this.stack_20.Push(this.class835_2);
                                this.class835_0 = this.method_175();
                                this.class835_2 = null;
                                this.bool_39 = true;
                            }
                            return;

                        case 0x1f:
                            this.method_123();
                            if (this.bool_41)
                            {
                                this.method_94(this.method_7().Format, this.class840_0.method_9());
                            }
                            return;

                        case 0x20:
                            this.class835_0.threeState_6 = ThreeState.True;
                            return;

                        case 0x21:
                            this.class835_0.threeState_6 = ThreeState.False;
                            return;

                        case 0x22:
                            this.class835_0.bool_6 = true;
                            return;

                        case 0x23:
                        {
                            float num29 = 0f;
                            if (A_2 != null)
                            {
                                num29 = this.method_165(A_2);
                            }
                            this.method_7().Format.AfterSpacing = num29;
                            return;
                        }
                        case 0x24:
                            if (Convert.ToInt32(A_2) == 1)
                            {
                                this.method_7().Format.AfterAutoSpacing = true;
                            }
                            return;

                        case 0x25:
                        {
                            float num30 = this.method_165(A_2);
                            this.method_7().Format.BeforeSpacing = num30;
                            return;
                        }
                        case 0x26:
                            if (Convert.ToInt32(A_2) == 1)
                            {
                                this.method_7().Format.BeforeAutoSpacing = true;
                            }
                            return;

                        case 0x27:
                        {
                            float num3 = 0f;
                            if (A_2 != null)
                            {
                                num3 = float.Parse(A_2) / 2f;
                            }
                            this.class835_0.float_0 = num3;
                            return;
                        }
                        case 40:
                            this.class835_0.subSuperScript_0 = SubSuperScript.SuperScript;
                            return;

                        case 0x29:
                            this.class835_0.subSuperScript_0 = SubSuperScript.SubScript;
                            return;

                        case 0x2a:
                        {
                            float num17 = 0f;
                            if (A_2 != null)
                            {
                                num17 = float.Parse(A_2, NumberStyles.Float, CultureInfo.InvariantCulture) / 2f;
                            }
                            if (num17 != 0f)
                            {
                                this.class835_0.float_8 = num17;
                                return;
                            }
                            if (this.class835_0.float_8 != float.MaxValue)
                            {
                                this.class835_0.float_8 = float.MaxValue;
                            }
                            return;
                        }
                        case 0x2b:
                        {
                            float num20 = 0f;
                            if (A_2 != null)
                            {
                                num20 = float.Parse(A_2, NumberStyles.Float, CultureInfo.InvariantCulture) / 2f;
                            }
                            if (num20 != 0f)
                            {
                                this.class835_0.float_8 = -num20;
                                return;
                            }
                            if (this.class835_0.float_8 != float.MaxValue)
                            {
                                this.class835_0.float_8 = float.MaxValue;
                            }
                            return;
                        }
                        case 0x2c:
                        {
                            float num21 = 0f;
                            if (A_2 != null)
                            {
                                num21 = float.Parse(A_2, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
                            }
                            this.class835_0.float_7 = num21;
                            return;
                        }
                        case 0x2d:
                        {
                            float num32 = 0f;
                            if (A_2 != null)
                            {
                                num32 = float.Parse(A_2, NumberStyles.Float, CultureInfo.InvariantCulture) / 4f;
                            }
                            if (num32 != 0f)
                            {
                                this.class835_0.float_7 = num32;
                            }
                            return;
                        }
                        case 0x2e:
                            this.class835_0.subSuperScript_0 = SubSuperScript.None;
                            return;

                        case 0x2f:
                        {
                            float num8 = this.method_165(A_2);
                            if (num8 >= 0f)
                            {
                                if (num8 == 0f)
                                {
                                    this.method_7().Format.LineSpacingRule = LineSpacingRule.AtLeast;
                                    this.method_7().Format.LineSpacing = 12f;
                                    return;
                                }
                                this.method_7().Format.LineSpacingRule = LineSpacingRule.AtLeast;
                                this.method_7().Format.LineSpacing = num8;
                                return;
                            }
                            this.method_7().Format.LineSpacingRule = LineSpacingRule.Exactly;
                            this.method_7().Format.LineSpacing = -num8;
                            return;
                        }
                        case 0x30:
                            this.bool_36 = true;
                            if (Convert.ToInt32(A_2) == 1)
                            {
                                this.method_7().Format.LineSpacingRule = LineSpacingRule.Multiple;
                            }
                            return;

                        case 0x31:
                            if (this.dictionary_0.ContainsKey(A_0))
                            {
                                this.method_16(this.dictionary_0[A_0]);
                                this.class835_0.string_0 = this.method_15().method_6();
                                this.class835_0.int_0 = this.method_15().method_0();
                            }
                            return;

                        case 50:
                        {
                            int num24 = Convert.ToInt32(A_2);
                            if (((num24 > -1) && (this.dictionary_1.Count > num24)) && this.dictionary_1.ContainsKey(num24))
                            {
                                this.method_18(this.dictionary_1[num24]);
                            }
                            this.method_178(this.method_17());
                            return;
                        }
                        case 0x33:
                            this.class835_0.short_0 = Convert.ToInt16(A_2);
                            return;

                        case 0x34:
                            if (this.class835_0 != null)
                            {
                                int num5 = Convert.ToInt32(A_2);
                                if (((num5 <= -1) || (this.dictionary_1.Count <= num5)) || !this.dictionary_1.ContainsKey(num5))
                                {
                                    if (num5 <= 0)
                                    {
                                        this.class835_0.bool_4 = false;
                                    }
                                    return;
                                }
                                this.class835_0.class843_1 = this.dictionary_1[num5];
                                this.class835_0.bool_4 = true;
                            }
                            return;

                        case 0x35:
                            if (this.class835_0 != null)
                            {
                                this.class835_0.int_1 = Convert.ToInt32(A_2);
                            }
                            return;

                        case 0x36:
                            if (this.class835_0 != null)
                            {
                                this.class835_0.int_2 = Convert.ToInt32(A_2);
                            }
                            return;

                        case 0x37:
                        case 0x38:
                            if (this.stack_28.Count > 0)
                            {
                                this.int_25 = this.stack_28.Peek();
                            }
                            if (this.bool_68)
                            {
                                this.int_25--;
                                this.bool_68 = false;
                            }
                            str = ((char) Convert.ToInt32(A_2)).ToString();
                            this.method_57(str);
                            return;

                        case 0x39:
                            if (this.stack_28.Count > 0)
                            {
                                this.int_25 = this.stack_28.Peek();
                            }
                            if (this.bool_68)
                            {
                                this.int_25--;
                                this.bool_68 = false;
                            }
                            str = ((char) (0x10000 - Convert.ToInt32(A_2))).ToString();
                            this.method_57(str);
                            return;

                        case 0x3a:
                            this.int_6 = Convert.ToInt32(A_2);
                            this.stack_28.Pop();
                            this.stack_28.Push(this.int_6);
                            return;

                        case 0x3b:
                            this.stack_39.Push(true);
                            return;

                        case 60:
                            this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Center;
                            return;

                        case 0x3d:
                            this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Justify;
                            return;

                        case 0x3e:
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Left;
                                return;
                            }
                            this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Right;
                            return;

                        case 0x3f:
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Right;
                                return;
                            }
                            this.method_7().Format.HorizontalAlignment = HorizontalAlignment.Left;
                            return;

                        case 0x40:
                            if (this.method_21() != RtfTableType.StyleSheet)
                            {
                                this.method_31().method_1(this.method_165(A_2));
                                this.dictionary_9.Add(++this.int_17, this.class842_0);
                                this.method_32(new Class842());
                            }
                            return;

                        case 0x41:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_3(TabJustification.Centered);
                            }
                            return;

                        case 0x42:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_3(TabJustification.Right);
                            }
                            return;

                        case 0x43:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_3(TabJustification.Decimal);
                            }
                            return;

                        case 0x44:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_3(TabJustification.Bar);
                                this.method_31().method_1(this.method_165(A_2));
                            }
                            return;

                        case 0x45:
                        case 70:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_5(TabLeader.Dotted);
                            }
                            return;

                        case 0x47:
                        case 0x48:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_5(TabLeader.Hyphenated);
                            }
                            return;

                        case 0x49:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_5(TabLeader.Single);
                            }
                            return;

                        case 0x4a:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_31().method_5(TabLeader.Heavy);
                            }
                            return;

                        case 0x4b:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.int_16++;
                                if ((this.dictionary_9.Count != 0) && (this.int_16 <= this.dictionary_9.Count))
                                {
                                    foreach (KeyValuePair<int, Class842> pair2 in this.dictionary_9)
                                    {
                                        if (pair2.Key == this.int_16)
                                        {
                                            float position = pair2.Value.method_0();
                                            TabJustification justification = pair2.Value.method_2();
                                            this.method_7().Format.Tabs.AddTab(position, justification, pair2.Value.method_4());
                                            this.itextRange_0 = this.method_7().AppendText(BookmarkStart.b("㨲", num));
                                            this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                                        }
                                    }
                                    return;
                                }
                                this.method_7().AppendText(BookmarkStart.b("㨲", num));
                            }
                            return;

                        case 0x4c:
                            num2 = this.method_165(A_2);
                            this.method_7().Format.FirstLineIndent = -num2;
                            return;

                        case 0x4d:
                            num2 = this.method_165(A_2);
                            this.method_7().Format.FirstLineIndent = num2;
                            return;

                        case 0x4e:
                        case 0x51:
                        case 0x54:
                        case 0x72:
                        case 0x152:
                        case 0x153:
                        case 340:
                        case 0x155:
                        case 0x1bd:
                            return;

                        case 0x4f:
                        {
                            float num16 = this.method_165(A_2);
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.LeftIndent = num16;
                                return;
                            }
                            this.method_7().Format.RightIndent = num16;
                            return;
                        }
                        case 80:
                            num2 = this.method_165(A_2);
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.LeftIndent = -num2;
                                return;
                            }
                            this.method_7().Format.RightIndent = -num2;
                            return;

                        case 0x52:
                        {
                            float num9 = this.method_165(A_2);
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.RightIndent = num9;
                                return;
                            }
                            this.method_7().Format.LeftIndent = num9;
                            return;
                        }
                        case 0x53:
                            num2 = this.method_165(A_2);
                            if (!this.method_7().Format.IsBidi)
                            {
                                this.method_7().Format.RightIndent = -num2;
                                return;
                            }
                            this.method_7().Format.LeftIndent = -num2;
                            return;

                        case 0x55:
                            this.method_7().Format.KeepLines = true;
                            return;

                        case 0x56:
                            this.method_7().Format.KeepFollow = true;
                            return;

                        case 0x57:
                        case 0x58:
                            this.method_152(A_0, A_1, A_2);
                            return;

                        case 0x59:
                            this.method_7().Format.PageBreakBefore = true;
                            return;

                        case 90:
                            this.method_7().Format.IsContextualSpacing = true;
                            return;

                        case 0x5b:
                            this.method_7().Format.IsWidowControl = true;
                            return;

                        case 0x5c:
                            this.method_7().Format.IsWidowControl = false;
                            return;

                        case 0x5d:
                            this.method_7().AppendBreak(BreakType.PageBreak);
                            return;

                        case 0x5e:
                            this.method_7().Format.WrapFrameAround = true;
                            return;

                        case 0x5f:
                            this.method_7().Format.TextureStyle = this.method_121(Convert.ToInt32(A_2));
                            return;

                        case 0x60:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureCross;
                            return;

                        case 0x61:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkCross;
                            return;

                        case 0x62:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkDiagonalCross;
                            return;

                        case 0x63:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkDiagonalDown;
                            return;

                        case 100:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkDiagonalUp;
                            return;

                        case 0x65:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkHorizontal;
                            return;

                        case 0x66:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDarkVertical;
                            return;

                        case 0x67:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDiagonalCross;
                            return;

                        case 0x68:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDiagonalDown;
                            return;

                        case 0x69:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureDiagonalUp;
                            return;

                        case 0x6a:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureHorizontal;
                            return;

                        case 0x6b:
                            this.method_7().Format.TextureStyle = TextureStyle.TextureVertical;
                            return;

                        case 0x6c:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_0 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_0 = ThreeState.False;
                            return;

                        case 0x6d:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_1 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_1 = ThreeState.False;
                            return;

                        case 110:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_4 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_4 = ThreeState.False;
                            return;

                        case 0x6f:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_5 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_5 = ThreeState.False;
                            return;

                        case 0x70:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_2 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_2 = ThreeState.False;
                            return;

                        case 0x71:
                            this.class835_0.threeState_2 = ThreeState.True;
                            this.class835_0.underlineStyle_0 = UnderlineStyle.Thick;
                            return;

                        case 0x73:
                            this.class835_0.threeState_2 = ThreeState.False;
                            return;

                        case 0x74:
                            this.class835_0.underlineStyle_0 = UnderlineStyle.Double;
                            return;

                        case 0x75:
                            if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                            {
                                this.class835_0.threeState_3 = ThreeState.True;
                                return;
                            }
                            this.class835_0.threeState_3 = ThreeState.False;
                            return;

                        case 0x76:
                            this.method_128();
                            return;

                        case 0x77:
                            this.method_10().BreakCode = SectionBreakType.NoBreak;
                            return;

                        case 120:
                            this.method_10().BreakCode = SectionBreakType.NewColumn;
                            return;

                        case 0x79:
                            this.method_10().BreakCode = SectionBreakType.NewPage;
                            return;

                        case 0x7a:
                            this.method_10().BreakCode = SectionBreakType.EvenPage;
                            return;

                        case 0x7b:
                            this.method_10().BreakCode = SectionBreakType.Oddpage;
                            return;

                        case 0x7c:
                            this.method_140();
                            this.method_162(this.method_7());
                            this.method_164(this.method_10());
                            this.method_145();
                            this.isection_0 = null;
                            return;

                        case 0x7d:
                        case 0x7e:
                            this.class836_0.method_3(new float?(this.method_165(A_2)));
                            return;

                        case 0x7f:
                        case 0x80:
                            this.class836_0.method_7(new float?(this.method_165(A_2)));
                            return;

                        case 0x81:
                        case 130:
                            this.class836_0.method_5(new float?(this.method_165(A_2)));
                            return;

                        case 0x83:
                        case 0x84:
                            this.class836_0.method_9(new float?(this.method_165(A_2)));
                            return;

                        case 0x85:
                            this.class836_0.method_1(new float?(this.method_165(A_2)));
                            return;

                        case 0x86:
                            this.class836_0.bool_4 = true;
                            return;

                        case 0x87:
                        case 0x88:
                            this.class836_0.sizeF_0.Width = this.method_165(A_2);
                            this.method_10().PageSetup.PageSize = this.class836_0.sizeF_0;
                            if (A_1 == BookmarkStart.b("䌲刴䀶䨸䌺匼", num))
                            {
                                this.class836_0.bool_3 = true;
                            }
                            return;

                        case 0x89:
                        case 0x8a:
                            this.class836_0.sizeF_0.Height = this.method_165(A_2);
                            this.method_10().PageSetup.PageSize = this.class836_0.sizeF_0;
                            if (A_1 == BookmarkStart.b("䌲刴弶䨸䌺匼", num))
                            {
                                this.class836_0.bool_3 = true;
                            }
                            return;

                        case 0x8b:
                            if (!this.bool_29 && !this.bool_28)
                            {
                                this.class836_0.float_0 = this.method_165(A_2);
                            }
                            return;

                        case 140:
                            if (!this.bool_29 && !this.bool_28)
                            {
                                this.class836_0.float_1 = this.method_165(A_2);
                            }
                            return;

                        case 0x8d:
                            this.class836_0.float_2 = this.method_165(A_2);
                            return;

                        case 0x8e:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(0x92);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0x8f:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(0x91);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0x90:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(0x94);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0x91:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(0x93);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0x92:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.NoTabForInd, true);
                            return;

                        case 0x93:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.WrapTrailSpaces, true);
                            return;

                        case 0x94:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.MapPrintTextColor, true);
                            return;

                        case 0x95:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.NoSpaceRaiseLower, true);
                            return;

                        case 150:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.NoColumnBalance, true);
                            return;

                        case 0x97:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ConvMailMergeEsc, true);
                            return;

                        case 0x98:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SuppressTopSpacing, true);
                            return;

                        case 0x99:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SuppressSpBfAfterPgBrk, true);
                            return;

                        case 0x9a:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.OrigWordTableRules, true);
                            return;

                        case 0x9b:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SwapBordersFacingPgs, true);
                            return;

                        case 0x9c:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ShowBreaksInFrames, true);
                            return;

                        case 0x9d:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ExtraAfter, true);
                            return;

                        case 0x9e:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SubOnSize, true);
                            return;

                        case 0x9f:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.TruncFontHeight, true);
                            return;

                        case 160:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.PrintBodyBeforeHdr, true);
                            return;

                        case 0xa1:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontBlnSbDbWid, false);
                            return;

                        case 0xa2:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.LineWrapLikeWord6, true);
                            return;

                        case 0xa3:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.WPJust, true);
                            return;

                        case 0xa4:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.WPSpace, true);
                            return;

                        case 0xa5:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SpLayoutLikeWW8, false);
                            return;

                        case 0xa6:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.FtnLayoutLikeWW8, false);
                            return;

                        case 0xa7:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ForgetLastTabAlign, false);
                            return;

                        case 0xa8:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.AlignTablesRowByRow, false);
                            return;

                        case 0xa9:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.LayoutRawTableWidth, false);
                            return;

                        case 170:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.LayoutTableRowsApart, false);
                            return;

                        case 0xab:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.UseWord97LineBreakingRules, false);
                            return;

                        case 0xac:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ApplyBreakingRules, true);
                            return;

                        case 0xad:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontWrapTextWithPunct, false);
                            return;

                        case 0xae:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontSnapToGridInCell, false);
                            return;

                        case 0xaf:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontUseAsianBreakRules, false);
                            return;

                        case 0xb0:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontMakeSpaceForUL, false);
                            return;

                        case 0xb1:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontULTrlSpc, false);
                            return;

                        case 0xb2:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.MWSmallCaps, true);
                            return;

                        case 0xb3:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontAllowFieldEndSelect, false);
                            return;

                        case 180:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.PrintMet, true);
                            return;

                        case 0xb5:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ExactOnTop, true);
                            return;

                        case 0xb6:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.WW6BorderRules, true);
                            return;

                        case 0xb7:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontAdjustLineHeightInTable, true);
                            return;

                        case 0xb8:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontVertAlignInTxbx, false);
                            return;

                        case 0xb9:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ExpShRtn, false);
                            return;

                        case 0xba:
                            this.method_7().Document.Settings.method_5().method_72(false);
                            return;

                        case 0xbb:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SuppressTopSpacingMac5, true);
                            return;

                        case 0xbc:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.UseAutospaceForFullWidthAlpha, true);
                            return;

                        case 0xbd:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.TruncDxaExpand, true);
                            return;

                        case 190:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontVertAlignCellWithSp, false);
                            return;

                        case 0xbf:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontBreakConstrainedForcedTables, false);
                            return;

                        case 0xc0:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.HangulWidthLikeWW11, false);
                            return;

                        case 0xc1:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontUseIndentAsNumberingTabStop, false);
                            return;

                        case 0xc2:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontBreakWrappedTables, false);
                            return;

                        case 0xc3:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.NoExtLeading, true);
                            return;

                        case 0xc4:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.DontAutofitConstrainedTables, false);
                            return;

                        case 0xc5:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.WW11IndentRules, false);
                            return;

                        case 0xc6:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.UseNormalStyleForList, false);
                            return;

                        case 0xc7:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.LeaveBackslashAlone, false);
                            return;

                        case 200:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.UseWord2002TableStyleRules, false);
                            return;

                        case 0xc9:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.FELineBreak11, false);
                            return;

                        case 0xca:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.AutofitLikeWW11, false);
                            return;

                        case 0xcb:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.Word11KerningPairs, false);
                            return;

                        case 0xcc:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.CachedColBalance, false);
                            return;

                        case 0xcd:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.UnderlineTabInNumList, false);
                            return;

                        case 0xce:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.GrowAutoFit, false);
                            return;

                        case 0xcf:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.AllowSpaceOfSameStyleInTable, false);
                            return;

                        case 0xd0:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.SplitPgBreakAndParaMark, false);
                            return;

                        case 0xd1:
                            this.method_7().Document.Settings.method_5().method_1(CompatibilityOptions.ExtraAfter, true);
                            return;

                        case 210:
                            this.method_7().Document.Settings.bool_41 = false;
                            return;

                        case 0xd3:
                            this.method_7().Document.Settings.bool_42 = false;
                            return;

                        case 0xd4:
                            this.method_7().Document.Settings.characterSpacing_0 = CharacterSpacing.doNotCompress;
                            return;

                        case 0xd5:
                            this.method_7().Document.Settings.characterSpacing_0 = CharacterSpacing.compressPunctuation;
                            return;

                        case 0xd6:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(150);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0xd7:
                            if ((!this.bool_41 && !this.bool_42) && !this.bool_43)
                            {
                                this.list_1.Add(0x97);
                                this.itextRange_0 = this.method_7().AppendText(this.method_135(this.list_1));
                                this.list_1.Clear();
                                this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                            }
                            return;

                        case 0xd8:
                        {
                            int num25 = Convert.ToInt32(A_2);
                            if (((num25 <= 0) || (this.dictionary_1.Count <= num25)) || !this.dictionary_1.ContainsKey(num25))
                            {
                                if (num25 <= 0)
                                {
                                    this.class835_0.bool_5 = false;
                                }
                                return;
                            }
                            this.method_18(this.dictionary_1[num25]);
                            this.class835_0.class843_2 = this.method_17();
                            this.class835_0.bool_5 = true;
                            return;
                        }
                        case 0xd9:
                            this.bool_15 = false;
                            if (!this.bool_6)
                            {
                                this.stack_5.Push(BookmarkStart.b("䠲", num));
                                this.bool_6 = true;
                                this.class837_0 = new Class837();
                            }
                            return;

                        case 0xda:
                            this.bool_15 = true;
                            if (!this.bool_6)
                            {
                                this.stack_5.Push(BookmarkStart.b("䠲", num));
                                this.bool_6 = true;
                                this.class837_0 = new Class837();
                            }
                            return;

                        case 0xdb:
                            this.stack_30.Push(BookmarkStart.b("䀲崴䜶常䤺䴼", num));
                            if (this.bool_58)
                            {
                                this.shapeObject_0 = new ShapeGroup(this.document_0);
                                this.shapeGroup_0.ChildObjects.Add(this.shapeObject_0);
                                this.stack_34.Push(this.shapeGroup_0);
                                this.shapeGroup_0 = this.shapeObject_0 as ShapeGroup;
                                return;
                            }
                            this.bool_54 = true;
                            this.bool_58 = true;
                            this.shapeObject_0 = new ShapeGroup(this.document_0);
                            this.shapeGroup_0 = this.shapeObject_0 as ShapeGroup;
                            this.method_58(this.shapeObject_0);
                            return;

                        case 220:
                            this.stack_30.Push(BookmarkStart.b("䀲崴䜶", num));
                            if (this.bool_54)
                            {
                                if ((this.shapeGroup_0 != null) && (this.shapeGroup_0.ShapeType == ShapeType.Group))
                                {
                                    if ((this.shapeGroup_0.CoordSizeWidth == 0x3e8) && (this.shapeGroup_0.CoordSizeHeight == 0x3e8))
                                    {
                                        this.shapeGroup_0.SetShapeAttribute(0x101f, this.int_26 - this.shapeGroup_0.CoordOriginX);
                                        if (this.shapeGroup_0.Width != 0.0)
                                        {
                                            int num35 = (int) Math.Round((double) (((double) this.shapeGroup_0.CoordSizeWidth) / (this.shapeGroup_0.Width * 20.0)));
                                            this.shapeGroup_0.NumLevel = (num35 > 0) ? num35 : 1;
                                        }
                                        this.shapeGroup_0.SetShapeAttribute(0x1020, this.int_27 - this.shapeObject_0.CoordOriginY);
                                    }
                                    this.stack_34.Push(this.shapeGroup_0);
                                    this.shapeObject_0 = new ShapeObject(this.document_0);
                                }
                                return;
                            }
                            this.bool_54 = true;
                            this.shapeObject_0 = new ShapeObject(this.document_0);
                            if (!this.bool_45)
                            {
                                this.method_58(this.shapeObject_0);
                            }
                            return;

                        case 0xdd:
                            this.bool_59 = true;
                            return;

                        case 0xde:
                            this.stack_48.Push(BookmarkStart.b("䠲", num));
                            this.bool_70 = true;
                            this.docOleObject_0 = new DocOleObject(this.document_0);
                            return;

                        case 0xdf:
                            this.docOleObject_0.method_86(OleLinkType.Embed);
                            return;

                        case 0xe0:
                            if (this.stack_49 == null)
                            {
                                this.stack_49 = new Stack<string>();
                            }
                            this.stack_49.Push(BookmarkStart.b("尲圴崶娸场尼䰾㉀", num));
                            this.bool_71 = true;
                            return;

                        case 0xe1:
                            this.class564_0.method_1(true);
                            this.class564_0.method_2(false);
                            this.bool_72 = true;
                            return;

                        case 0xe2:
                            this.stack_50.Push(BookmarkStart.b("圲吴䌶堸崺吼娾ⵀ❂", num));
                            this.bool_73 = true;
                            return;

                        case 0xe3:
                            this.bool_59 = true;
                            this.stack_35.Push(BookmarkStart.b("䜲䴴儶倸帺儼嬾㕀♂㵄㍆", num));
                            return;

                        case 0xe4:
                            this.class835_0.characterEncodingType_0 = CharacterEncodingType.LowANSI;
                            return;

                        case 0xe5:
                            this.class835_0.characterEncodingType_0 = CharacterEncodingType.HighANSI;
                            return;

                        case 230:
                            this.class835_0.characterEncodingType_0 = CharacterEncodingType.DoubleByte;
                            return;

                        case 0xe7:
                            if (!this.bool_6)
                            {
                                this.bool_15 = true;
                                this.stack_5.Push(BookmarkStart.b("䠲", num));
                                this.bool_6 = true;
                                this.class837_0 = new Class837();
                                if (this.shapeObject_0 == null)
                                {
                                    return;
                                }
                                this.method_170(this.shapeObject_0, this.class837_0);
                            }
                            return;

                        case 0xe8:
                            this.bool_23 = true;
                            this.bool_22 = true;
                            return;

                        case 0xe9:
                            this.bool_23 = true;
                            this.bool_27 = true;
                            return;

                        case 0xea:
                            this.bool_24 = true;
                            this.bool_25 = true;
                            return;

                        case 0xeb:
                            this.bool_24 = true;
                            this.bool_26 = true;
                            return;

                        case 0xec:
                        case 0xed:
                            this.method_122();
                            return;

                        case 0xee:
                            this.method_144(A_0, A_1, A_2, this.method_7().ListFormat);
                            this.bool_18 = true;
                            return;

                        case 0xef:
                            this.method_7().Format.IsBidi = true;
                            return;

                        case 240:
                            this.method_7().Format.IsBidi = false;
                            return;

                        case 0xf1:
                            this.method_7().Format.LeftIndent = this.method_165(A_2);
                            return;

                        case 0xf2:
                            this.method_7().Format.RightIndent = this.method_165(A_2);
                            return;

                        case 0xf3:
                        {
                            int num28 = int.Parse(A_2) - 1;
                            if ((num28 <= this.list_2.Count) && (this.list_2[num28] != null))
                            {
                                this.method_7().Format.DivId = this.list_2[num28].method_7();
                                this.document_0.WebSettings.method_5().method_6(this.list_2[num28]);
                            }
                            return;
                        }
                        case 0xf4:
                            if ((Convert.ToInt32(A_2) < 9) || (Convert.ToInt32(A_2) > 12))
                            {
                                this.method_7().ListFormat.ListLevelNumber = Convert.ToInt32(A_2);
                                return;
                            }
                            return;

                        case 0xf5:
                            this.int_21++;
                            if (this.int_21 >= 9)
                            {
                                this.int_21 = 0;
                            }
                            return;

                        case 0xf6:
                            if (((this.method_21() != RtfTableType.StyleSheet) && !this.bool_51) && !this.bool_17)
                            {
                                this.method_7().AppendSymbol(0xb7);
                            }
                            return;

                        case 0xf7:
                            this.bool_18 = true;
                            this.method_7().ListFormat.ApplyBulletStyle();
                            if (((this.method_13() != null) && (this.method_7().ListFormat != null)) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.BulletCharacter = this.method_13().BulletCharacter;
                                if (this.document_0.ViewSetup.DocumentViewType != DocumentViewType.WebLayout)
                                {
                                    return;
                                }
                                this.method_7().ListFormat.CurrentListLevel.Word6Legacy = true;
                            }
                            return;

                        case 0xf8:
                            foreach (KeyValuePair<string, Class839> pair in this.dictionary_0)
                            {
                                if (pair.Key == A_0)
                                {
                                    this.method_16(pair.Value);
                                    this.method_7().ListFormat.CurrentListLevel.CharacterFormat.FontName = this.method_15().method_6();
                                }
                            }
                            return;

                        case 0xf9:
                            this.bool_18 = true;
                            this.method_7().ListFormat.ApplyNumberedStyle();
                            this.method_7().ListFormat.CurrentListLevel.NumberSufix = null;
                            return;

                        case 250:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.ListLevelNumber = Convert.ToInt32(A_2);
                            }
                            return;

                        case 0xfb:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                int num36 = Convert.ToInt32(A_2);
                                this.method_7().ListFormat.CurrentListLevel.StartAt = num36;
                            }
                            return;

                        case 0xfc:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.Arabic;
                            }
                            return;

                        case 0xfd:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.LowRoman;
                            }
                            return;

                        case 0xfe:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.UpRoman;
                            }
                            return;

                        case 0xff:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.UpLetter;
                            }
                            return;

                        case 0x100:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.LowLetter;
                            }
                            return;

                        case 0x101:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.Ordinal;
                            }
                            return;

                        case 0x102:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.PatternType = ListPatternType.OrdinalText;
                            }
                            return;

                        case 0x103:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.NumberSufix = BookmarkStart.b("ᴲ", num);
                            }
                            return;

                        case 260:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.ParagraphFormat.LeftIndent = this.method_165(A_2);
                                this.method_7().ListFormat.CurrentListLevel.TextPosition = this.method_165(A_2);
                            }
                            return;

                        case 0x105:
                            if (((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null)) && ((this.method_21() == RtfTableType.ListTable) || (this.method_21() == RtfTableType.ListOverrideTable)))
                            {
                                this.method_7().ListFormat.CurrentListLevel.TabSpaceAfter = this.method_165(A_2);
                            }
                            return;

                        case 0x106:
                        case 0x107:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                if (Convert.ToInt32(A_2) != 0)
                                {
                                    this.method_7().ListFormat.CurrentListLevel.CharacterFormat.Bold = true;
                                    return;
                                }
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.Bold = false;
                            }
                            return;

                        case 0x108:
                        case 0x109:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                if (Convert.ToInt32(A_2) != 0)
                                {
                                    this.method_7().ListFormat.CurrentListLevel.CharacterFormat.Italic = true;
                                    return;
                                }
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.Italic = false;
                            }
                            return;

                        case 0x10a:
                        case 0x10b:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.AllCaps = true;
                            }
                            return;

                        case 0x10c:
                        case 0x10d:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                if (Convert.ToInt32(A_2) != 0)
                                {
                                    this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                                    return;
                                }
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.None;
                            }
                            return;

                        case 270:
                        case 0x10f:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Dotted;
                            }
                            return;

                        case 0x110:
                        case 0x111:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Dash;
                            }
                            return;

                        case 0x112:
                        case 0x113:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Wavy;
                            }
                            return;

                        case 0x114:
                        case 0x115:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Double;
                            }
                            return;

                        case 0x116:
                        case 0x117:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.Thick;
                            }
                            return;

                        case 280:
                        case 0x119:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.UnderlineStyle = UnderlineStyle.None;
                            }
                            return;

                        case 0x11a:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.CharacterFormat.FontSize = Convert.ToInt32(A_2) / 2;
                            }
                            return;

                        case 0x11b:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                            }
                            return;

                        case 0x11c:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;
                            }
                            return;

                        case 0x11d:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.CurrentListLevel.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Right;
                            }
                            return;

                        case 0x11e:
                            if ((this.method_7().ListFormat != null) && (this.method_7().ListFormat.CurrentListLevel != null))
                            {
                                this.method_7().ListFormat.ContinueListNumbering();
                                this.method_7().ListFormat.CurrentListLevel.NoLevelText = true;
                            }
                            return;

                        case 0x11f:
                            this.bool_45 = true;
                            this.stack_25.Push(BookmarkStart.b("䠲", num));
                            return;

                        case 0x120:
                            this.method_130();
                            if (this.iparagraph_0 != null)
                            {
                                this.iparagraph_0.ListFormat.RemoveList();
                            }
                            return;

                        case 0x121:
                            this.bool_19 = true;
                            return;

                        case 290:
                        case 0x123:
                            this.method_131();
                            return;

                        case 0x124:
                            this.method_133(A_0, A_1, A_2);
                            return;

                        case 0x125:
                        case 0x126:
                        {
                            IParagraph paragraph = this.method_7();
                            this.method_140();
                            this.method_162(this.method_7());
                            if (this.method_25() != null)
                            {
                                this.method_169(this.method_25().CharacterFormat, this.class835_0);
                            }
                            this.bool_34 = true;
                            this.iparagraph_0 = new Paragraph(this.document_0);
                            this.method_139(this.iparagraph_0.Format);
                            this.method_163(paragraph);
                            this.method_124(paragraph, this.iparagraph_0);
                            return;
                        }
                        case 0x127:
                            if (!this.bool_17)
                            {
                                if (string.IsNullOrEmpty(A_2) || !(A_2 == BookmarkStart.b("̲", num)))
                                {
                                    this.bool_33 = true;
                                    this.bool_19 = true;
                                    this.int_13 = 1;
                                    return;
                                }
                                this.bool_33 = false;
                                this.bool_19 = false;
                                this.int_13 = 0;
                            }
                            return;

                        case 0x128:
                            if (this.stack_16.Count != 0)
                            {
                                int count = this.stack_17.Count;
                            }
                            this.int_13 = Convert.ToInt32(A_2);
                            return;

                        case 0x129:
                            this.bool_21 = true;
                            return;

                        case 0x12a:
                            if (!string.IsNullOrEmpty(A_2) || !(A_2 == BookmarkStart.b("̲", num)))
                            {
                                this.method_29().LayoutType = LayoutType.AutoFit;
                                return;
                            }
                            this.method_29().LayoutType = LayoutType.Fixed;
                            return;

                        case 0x12b:
                            this.method_29().Bidi = true;
                            return;

                        case 300:
                            if (this.method_23() != null)
                            {
                                this.method_23().IsHeader = true;
                            }
                            return;

                        case 0x12d:
                            this.method_29().IsBreakAcrossPages = true;
                            return;

                        case 0x12e:
                            num2 = this.method_165(A_2);
                            this.method_29().Height = num2;
                            return;

                        case 0x12f:
                            num2 = this.method_165(A_2);
                            this.struct26_0.method_2(new float?(num2));
                            return;

                        case 0x130:
                            num2 = this.method_165(A_2);
                            this.method_35().Bottom = num2;
                            return;

                        case 0x131:
                            this.method_29().LeftIndent = this.method_165(A_2);
                            return;

                        case 0x132:
                            num2 = this.method_165(A_2);
                            this.method_35().Left = num2;
                            return;

                        case 0x133:
                            num2 = this.method_165(A_2);
                            this.method_35().Right = num2;
                            return;

                        case 0x134:
                            num2 = this.method_165(A_2);
                            this.method_35().Top = num2;
                            return;

                        case 0x135:
                            if (Convert.ToInt32(A_2) == 3)
                            {
                                this.struct26_0.method_6(true);
                            }
                            return;

                        case 310:
                            if (Convert.ToInt32(A_2) == 3)
                            {
                                this.struct26_0.method_4(true);
                            }
                            return;

                        case 0x137:
                            if (Convert.ToInt32(A_2) == 3)
                            {
                                this.struct26_0.method_8(true);
                            }
                            return;

                        case 0x138:
                            if (Convert.ToInt32(A_2) == 3)
                            {
                                this.struct26_0.method_10(true);
                            }
                            return;

                        case 0x139:
                            this.method_29().HasCellSpacing = true;
                            num2 = this.method_165(A_2);
                            this.method_29().CellSpacingEx = num2;
                            return;

                        case 0x13a:
                            this.method_29().HasCellSpacing = true;
                            num2 = this.method_165(A_2);
                            this.method_29().CellSpacingEx = num2;
                            return;

                        case 0x13b:
                            this.method_29().HasCellSpacing = true;
                            num2 = this.method_165(A_2);
                            this.method_29().CellSpacingEx = num2;
                            return;

                        case 0x13c:
                            this.method_29().HasCellSpacing = true;
                            num2 = this.method_165(A_2);
                            this.method_29().CellSpacingEx = num2;
                            return;

                        case 0x13d:
                            this.method_29().HasCellSpacing = true;
                            if (Convert.ToInt32(A_2) == 0)
                            {
                                this.method_29().CellSpacingEx = 0f;
                            }
                            return;

                        case 0x13e:
                            this.method_29().HasCellSpacing = true;
                            if (Convert.ToInt32(A_2) == 0)
                            {
                                this.method_29().CellSpacingEx = 0f;
                            }
                            return;

                        case 0x13f:
                            this.method_29().HasCellSpacing = true;
                            if (Convert.ToInt32(A_2) == 0)
                            {
                                this.method_29().CellSpacingEx = 0f;
                            }
                            return;

                        case 320:
                            this.method_29().HasCellSpacing = true;
                            if (Convert.ToInt32(A_2) == 0)
                            {
                                this.method_29().CellSpacingEx = 0f;
                            }
                            return;

                        case 0x141:
                            if (this.method_29() != null)
                            {
                                num2 = this.method_165(int.Parse(A_2).ToString());
                                this.int_20 = Convert.ToInt32(A_2);
                                this.method_29().LeftIndent = num2;
                            }
                            return;

                        case 0x142:
                            num2 = this.method_165(A_2);
                            this.int_20 = -Convert.ToInt32(A_2);
                            this.method_29().LeftIndent = -num2;
                            return;

                        case 0x143:
                            this.method_29().HorizontalAlignment = RowAlignment.Center;
                            return;

                        case 0x144:
                            this.method_29().HorizontalAlignment = RowAlignment.Left;
                            return;

                        case 0x145:
                            this.method_29().HorizontalAlignment = RowAlignment.Right;
                            return;

                        case 0x146:
                        {
                            WidthType tableWidthType = this.method_29().TableWidthType;
                            switch (Convert.ToInt32(A_2))
                            {
                                case 0:
                                    this.method_29().TablePreferredWidthInfo.method_52(FtsWidth.None);
                                    return;

                                case 1:
                                    this.method_29().IsAutoResized = true;
                                    this.method_29().TablePreferredWidthInfo.method_52(FtsWidth.Auto);
                                    return;

                                case 2:
                                    this.method_29().TablePreferredWidthInfo.method_52(FtsWidth.Percentage);
                                    if (this.method_29().TablePreferredWidthInfo.method_49() > 0f)
                                    {
                                        Class15 tablePreferredWidthInfo = this.method_29().TablePreferredWidthInfo;
                                        tablePreferredWidthInfo.method_50(tablePreferredWidthInfo.method_49() / 50f);
                                    }
                                    return;

                                case 3:
                                    this.method_29().TablePreferredWidthInfo.method_52(FtsWidth.Point);
                                    return;
                            }
                            return;
                        }
                        case 0x147:
                        {
                            float num7 = Convert.ToInt32(A_2);
                            switch (((FtsWidth) this.method_29().TablePreferredWidthInfo[2]))
                            {
                                case FtsWidth.Percentage:
                                    this.method_29().TablePreferredWidthInfo.method_50(num7 / 50f);
                                    return;

                                case FtsWidth.Point:
                                    this.method_29().TablePreferredWidthInfo.method_50(num7);
                                    return;
                            }
                            this.method_29().TablePreferredWidthInfo.method_50(num7);
                            return;
                        }
                        case 0x148:
                        {
                            FtsWidth width3 = this.method_29().GridBeforeWidth.method_51();
                            switch (Convert.ToInt32(A_2))
                            {
                                case 0:
                                    this.method_29().GridBeforeWidth.method_52(FtsWidth.None);
                                    break;

                                case 1:
                                    this.method_29().GridBeforeWidth.method_52(FtsWidth.Auto);
                                    break;

                                case 2:
                                    this.method_29().GridBeforeWidth.method_52(FtsWidth.Percentage);
                                    break;

                                case 3:
                                    this.method_29().GridBeforeWidth.method_52(FtsWidth.Point);
                                    break;
                            }
                            if (width3 == FtsWidth.Auto)
                            {
                                if ((this.method_29().GridBeforeWidth.method_51() == FtsWidth.Percentage) && (this.method_29().GridBeforeWidth.method_49() > 0f))
                                {
                                    this.method_29().GridBeforeWidth.method_50(this.method_29().GridBeforeWidth.method_49() / 50f);
                                    return;
                                }
                                if ((this.method_29().GridBeforeWidth.method_51() != FtsWidth.Auto) || (this.method_29().GridBeforeWidth.method_49() <= 0f))
                                {
                                    return;
                                }
                                this.method_29().GridBeforeWidth.method_50(0f);
                            }
                            return;
                        }
                        case 0x149:
                        {
                            float num33 = Convert.ToInt32(A_2);
                            switch (((FtsWidth) this.method_29().GridBeforeWidth[2]))
                            {
                                case FtsWidth.Percentage:
                                    this.method_29().GridBeforeWidth.method_50(num33 / 50f);
                                    return;

                                case FtsWidth.Point:
                                    this.method_29().GridBeforeWidth.method_50(num33);
                                    return;
                            }
                            this.method_29().GridBeforeWidth.method_50(num33);
                            return;
                        }
                        case 330:
                        {
                            FtsWidth width = this.method_29().GridAfterWidth.method_51();
                            switch (Convert.ToInt32(A_2))
                            {
                                case 0:
                                    this.method_29().GridAfterWidth.method_52(FtsWidth.None);
                                    break;

                                case 1:
                                    this.method_29().GridAfterWidth.method_52(FtsWidth.Auto);
                                    break;

                                case 2:
                                    this.method_29().GridAfterWidth.method_52(FtsWidth.Percentage);
                                    break;

                                case 3:
                                    this.method_29().GridAfterWidth.method_52(FtsWidth.Point);
                                    break;
                            }
                            if (width == FtsWidth.Auto)
                            {
                                if ((this.method_29().GridAfterWidth.method_51() == FtsWidth.Percentage) && (this.method_29().GridAfterWidth.method_49() > 0f))
                                {
                                    this.method_29().GridAfterWidth.method_50(this.method_29().GridAfterWidth.method_49() / 50f);
                                    return;
                                }
                                if ((this.method_29().GridAfterWidth.method_51() != FtsWidth.Auto) || (this.method_29().GridAfterWidth.method_49() <= 0f))
                                {
                                    return;
                                }
                                this.method_29().GridAfterWidth.method_50(0f);
                            }
                            return;
                        }
                        case 0x14b:
                        {
                            float num26 = Convert.ToInt32(A_2);
                            switch (((FtsWidth) this.method_29().GridAfterWidth[2]))
                            {
                                case FtsWidth.Percentage:
                                    this.method_29().GridAfterWidth.method_50(num26 / 50f);
                                    return;

                                case FtsWidth.Point:
                                    this.method_29().GridAfterWidth.method_50(num26);
                                    return;
                            }
                            this.method_29().GridAfterWidth.method_50(num26);
                            return;
                        }
                        case 0x14c:
                            this.method_27().FitText = true;
                            return;

                        case 0x14d:
                            this.method_27().TextWrap = false;
                            return;

                        case 0x14e:
                            this.method_27().SamePaddingsAsTable = false;
                            this.method_27().Paddings.Top = this.method_165(A_2);
                            return;

                        case 0x14f:
                            this.method_27().SamePaddingsAsTable = false;
                            this.method_27().Paddings.Left = this.method_165(A_2);
                            return;

                        case 0x150:
                            this.method_27().SamePaddingsAsTable = false;
                            this.method_27().Paddings.Bottom = this.method_165(A_2);
                            return;

                        case 0x151:
                            this.method_27().SamePaddingsAsTable = false;
                            this.method_27().Paddings.Right = this.method_165(A_2);
                            return;

                        case 0x156:
                            this.method_27().RtfCellWidthType = (WidthType) Convert.ToInt32(A_2);
                            return;

                        case 0x157:
                        {
                            float num13 = Convert.ToInt32(A_2);
                            this.method_27().RtfCellWidth = num13;
                            switch (this.method_27().RtfCellWidthType)
                            {
                                case WidthType.Percentage:
                                    this.method_27().CellScaling = num13 / 50f;
                                    this.method_27().IsRtfCellwidthCalc = true;
                                    return;

                                case WidthType.Twip:
                                    this.bool_38 = true;
                                    this.method_27().CellWidth = this.method_165(A_2);
                                    this.method_27().IsRtfCellwidthCalc = true;
                                    return;
                            }
                            return;
                        }
                        case 0x158:
                            this.method_27().VerticalAlignment = VerticalAlignment.Top;
                            return;

                        case 0x159:
                            this.method_27().VerticalAlignment = VerticalAlignment.Middle;
                            return;

                        case 0x15a:
                            this.method_27().VerticalAlignment = VerticalAlignment.Bottom;
                            return;

                        case 0x15b:
                            this.method_27().TextDirection = TextDirection.TopToBottom;
                            return;

                        case 0x15c:
                            this.method_27().TextDirection = TextDirection.RightToLeft;
                            return;

                        case 0x15d:
                            this.method_27().TextDirection = TextDirection.LeftToRight;
                            return;

                        case 350:
                            this.method_27().TextDirection = TextDirection.TopToBottomRotated;
                            return;

                        case 0x15f:
                            this.method_27().TextDirection = TextDirection.RightToLeftRotated;
                            return;

                        case 0x160:
                            this.bool_2 = true;
                            this.bool_3 = false;
                            this.bool_4 = false;
                            this.bool_5 = false;
                            this.bool_8 = false;
                            return;

                        case 0x161:
                            this.bool_5 = true;
                            this.bool_2 = false;
                            this.bool_3 = false;
                            this.bool_4 = false;
                            this.bool_8 = false;
                            return;

                        case 0x162:
                            this.bool_4 = true;
                            this.bool_5 = false;
                            this.bool_2 = false;
                            this.bool_3 = false;
                            this.bool_8 = false;
                            return;

                        case 0x163:
                            this.bool_3 = true;
                            this.bool_4 = false;
                            this.bool_5 = false;
                            this.bool_2 = false;
                            this.bool_8 = false;
                            return;

                        case 0x164:
                        {
                            int num4 = Convert.ToInt32(A_2);
                            if (((num4 > -1) && (this.dictionary_1.Count > num4)) && this.dictionary_1.ContainsKey(num4))
                            {
                                this.method_18(this.dictionary_1[num4]);
                                this.method_27().BackColor = this.method_17().method_9();
                            }
                            return;
                        }
                        case 0x165:
                        case 0x166:
                            this.method_27().TextureStyle = this.method_121(Convert.ToInt32(A_2));
                            return;

                        case 0x167:
                        case 360:
                            this.method_27().TextureStyle = TextureStyle.TextureHorizontal;
                            return;

                        case 0x169:
                        case 0x16a:
                            this.method_27().TextureStyle = TextureStyle.TextureVertical;
                            return;

                        case 0x16b:
                        case 0x16c:
                            this.method_27().TextureStyle = TextureStyle.TextureDiagonalDown;
                            return;

                        case 0x16d:
                        case 0x16e:
                            this.method_27().TextureStyle = TextureStyle.TextureDiagonalUp;
                            return;

                        case 0x16f:
                        case 0x170:
                            this.method_27().TextureStyle = TextureStyle.TextureCross;
                            return;

                        case 0x171:
                        case 370:
                            this.method_27().TextureStyle = TextureStyle.TextureDiagonalCross;
                            return;

                        case 0x173:
                        case 0x174:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkHorizontal;
                            return;

                        case 0x175:
                        case 0x176:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkVertical;
                            return;

                        case 0x177:
                        case 0x178:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkDiagonalDown;
                            return;

                        case 0x179:
                        case 0x17a:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkDiagonalUp;
                            return;

                        case 0x17b:
                        case 380:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkCross;
                            return;

                        case 0x17d:
                        case 0x17e:
                            this.method_27().TextureStyle = TextureStyle.TextureDarkDiagonalCross;
                            return;

                        case 0x17f:
                            this.method_27().VerticalMerge = CellMerge.Start;
                            return;

                        case 0x180:
                            this.method_27().VerticalMerge = CellMerge.Continue;
                            return;

                        case 0x181:
                            this.method_27().HorizontalMerge = CellMerge.Start;
                            return;

                        case 0x182:
                            this.method_27().HorizontalMerge = CellMerge.Continue;
                            return;

                        case 0x183:
                            if (this.bool_41)
                            {
                                if (this.bool_41)
                                {
                                    this.stack_23.Pop();
                                    this.stack_23.Push(BookmarkStart.b("唲尴制唸强", num));
                                    this.bool_48 = true;
                                    if (this.class841_0.method_0().Count > 0)
                                    {
                                        this.class840_0.method_4().Add(this.class841_0);
                                    }
                                    if (!this.bool_44)
                                    {
                                        this.stack_24.Push(this.class840_0);
                                    }
                                    this.class840_0 = this.class840_0.method_17();
                                    this.class840_0 = new Class840();
                                    this.class840_0.method_10(this.method_7().Format);
                                }
                                return;
                            }
                            this.stack_23.Push(BookmarkStart.b("唲尴制唸强", num));
                            this.class840_0 = new Class840();
                            this.bool_41 = true;
                            this.byte_0 = null;
                            return;

                        case 0x184:
                            if (this.class838_0 != null)
                            {
                                switch (Convert.ToInt32(A_2))
                                {
                                    case 1:
                                        this.class838_0.method_11(TextFormFieldType.NumberText);
                                        return;

                                    case 2:
                                        this.class838_0.method_11(TextFormFieldType.DateText);
                                        return;

                                    case 3:
                                        this.class838_0.method_11(TextFormFieldType.CurrentDate);
                                        return;

                                    case 4:
                                        this.class838_0.method_11(TextFormFieldType.CurrentTime);
                                        return;

                                    case 5:
                                        this.class838_0.method_11(TextFormFieldType.Calculation);
                                        return;
                                }
                            }
                            return;

                        case 0x185:
                            this.class840_0.method_16(true);
                            return;

                        case 390:
                            this.class840_0.method_14(true);
                            return;

                        case 0x187:
                            this.bool_42 = true;
                            this.string_23 = string.Empty;
                            this.stack_23.Pop();
                            this.stack_23.Push(BookmarkStart.b("唲头匶倸唺丼䬾", num));
                            return;

                        case 0x188:
                            this.stack_23.Pop();
                            this.stack_23.Push(BookmarkStart.b("唲头匶䬸䠺儼䬾", num));
                            if (!this.bool_48)
                            {
                                this.method_66(this.string_23.Trim());
                                this.bool_47 = true;
                            }
                            this.bool_43 = true;
                            this.bool_42 = false;
                            this.string_24 = string.Empty;
                            this.bool_44 = false;
                            this.class841_0 = new Class841();
                            return;

                        case 0x189:
                            if (string.IsNullOrEmpty(this.string_24) && string.IsNullOrEmpty(this.string_23))
                            {
                                if ((A_2 == null) || (Convert.ToInt32(A_2) != 0))
                                {
                                    this.class835_0.bool_7 = true;
                                    return;
                                }
                                this.class835_0.bool_7 = false;
                            }
                            return;

                        case 0x18a:
                            if (this.class838_0 != null)
                            {
                                switch (Convert.ToInt32(A_2))
                                {
                                    case 0:
                                        this.class838_0.method_31(FormFieldType.TextInput);
                                        return;

                                    case 1:
                                        this.class838_0.method_31(FormFieldType.CheckBox);
                                        return;

                                    case 2:
                                        this.class838_0.method_31(FormFieldType.DropDown);
                                        return;
                                }
                            }
                            return;

                        case 0x18b:
                            if ((this.class838_0 != null) && (A_2 == BookmarkStart.b("Ȳ", num)))
                            {
                                this.class838_0.method_17(false);
                            }
                            return;

                        case 0x18c:
                            if (this.class838_0 != null)
                            {
                                if ((A_2 == null) || ((A_2 != null) && (A_2 == BookmarkStart.b("Ȳ", num))))
                                {
                                    this.class838_0.method_13(CheckBoxSizeType.Exactly);
                                    return;
                                }
                                this.class838_0.method_13(CheckBoxSizeType.Auto);
                            }
                            return;

                        case 0x18d:
                            if (this.class838_0 != null)
                            {
                                if ((A_2 == null) || ((A_2 != null) && (A_2 == BookmarkStart.b("Ȳ", num))))
                                {
                                    this.class838_0.method_27(true);
                                    return;
                                }
                                this.class838_0.method_27(false);
                            }
                            return;

                        case 0x18e:
                            if (this.class838_0 != null)
                            {
                                if ((A_2 == null) || ((A_2 != null) && (A_2 == BookmarkStart.b("Ȳ", num))))
                                {
                                    this.class838_0.method_3(true);
                                    this.class838_0.dropDownCollection_0 = new DropDownCollection(this.document_0);
                                    return;
                                }
                                this.class838_0.method_3(false);
                            }
                            return;

                        case 0x18f:
                            if (((this.class838_0 != null) && (A_2 != null)) && (A_2 != string.Empty))
                            {
                                this.class838_0.method_5(Convert.ToInt32(A_2));
                            }
                            return;

                        case 400:
                            if (((this.class838_0 != null) && (A_2 != null)) && ((A_2 != string.Empty) && (this.class838_0.method_12() == CheckBoxSizeType.Exactly)))
                            {
                                this.class838_0.method_15(Convert.ToInt32(A_2) / 2);
                            }
                            return;

                        case 0x191:
                            if (((this.class838_0 != null) && (A_2 != null)) && (A_2 != string.Empty))
                            {
                                this.class838_0.int_2 = Convert.ToInt32(A_2);
                            }
                            return;

                        case 0x192:
                            if (((this.class838_0 != null) && (A_2 != null)) && (A_2 != string.Empty))
                            {
                                if (this.class838_0.method_30() != FormFieldType.CheckBox)
                                {
                                    this.class838_0.int_3 = Convert.ToInt32(A_2);
                                    return;
                                }
                                switch (Convert.ToInt32(A_2))
                                {
                                    case 0:
                                        this.class838_0.method_1(false);
                                        return;

                                    case 1:
                                        this.class838_0.method_1(true);
                                        return;
                                }
                            }
                            return;

                        case 0x193:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPos = 1;
                            }
                            return;

                        case 0x194:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPos = 2;
                            }
                            return;

                        case 0x195:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPos = 0;
                            }
                            return;

                        case 0x196:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPos = 0;
                            }
                            return;

                        case 0x197:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPos = 1;
                            }
                            return;

                        case 0x198:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPos = 2;
                            }
                            return;

                        case 0x199:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPosition = HorizontalPosition.Right;
                                this.method_7().Format.Remove(3);
                            }
                            return;

                        case 410:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPosition = HorizontalPosition.Left;
                                this.method_7().Format.Remove(3);
                            }
                            return;

                        case 0x19b:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalPosition = HorizontalPosition.Center;
                                this.method_7().Format.Remove(3);
                            }
                            return;

                        case 0x19c:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameX = (short) int.Parse(A_2);
                                this.method_7().Format.Remove(8);
                            }
                            return;

                        case 0x19d:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Inline;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x19e:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Top;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x19f:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Center;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x1a0:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Bottom;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x1a1:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Inside;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x1a2:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalPosition = VerticalPosition.Outside;
                                this.method_7().Format.Remove(4);
                            }
                            return;

                        case 0x1a3:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameY = (short) int.Parse(A_2);
                                this.method_7().Format.Remove(15);
                            }
                            return;

                        case 420:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameWidth = (short) int.Parse(A_2);
                            }
                            return;

                        case 0x1a5:
                            if (this.method_7() != null)
                            {
                                short num14 = short.Parse(A_2);
                                if (num14 >= 0)
                                {
                                    if (num14 == 0)
                                    {
                                        this.method_7().Format.FrameHeight = 0;
                                        this.method_7().Format.FrameHeightRule = FrameSizeRule.Auto;
                                        return;
                                    }
                                    this.method_7().Format.FrameHeight = (short) (num14 | 0x8000);
                                    this.method_7().Format.FrameHeightRule = FrameSizeRule.AtLeast;
                                    return;
                                }
                                this.method_7().Format.FrameHeight = -num14;
                                this.method_7().Format.FrameHeightRule = FrameSizeRule.Exact;
                            }
                            return;

                        case 0x1a6:
                            if ((this.method_7() != null) && (int.Parse(A_2) == 1))
                            {
                                this.method_7().Format.FrameAnchorLock = true;
                            }
                            return;

                        case 0x1a7:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameHorizontalDistanceFromText = (short) int.Parse(A_2);
                            }
                            return;

                        case 0x1a8:
                            if (this.method_7() != null)
                            {
                                this.method_7().Format.FrameVerticalDistanceFromText = (short) int.Parse(A_2);
                            }
                            return;

                        case 0x1a9:
                        {
                            int num15 = Convert.ToInt32(A_2);
                            if (((num15 > -1) && (this.dictionary_1.Count > num15)) && this.dictionary_1.ContainsKey(num15))
                            {
                                this.method_7().Format.BackColor = this.dictionary_1[num15].method_9();
                            }
                            return;
                        }
                        case 0x1aa:
                            this.method_29().Positioning.DistanceFromLeft = this.method_165(A_2);
                            return;

                        case 0x1ab:
                            this.method_29().Positioning.DistanceFromRight = this.method_165(A_2);
                            return;

                        case 0x1ac:
                            this.method_29().Positioning.DistanceFromTop = this.method_165(A_2);
                            return;

                        case 0x1ad:
                            this.method_29().Positioning.DistanceFromBottom = this.method_165(A_2);
                            return;

                        case 430:
                            this.method_29().Positioning.TableOverlap = A_2 != BookmarkStart.b("Ȳ", num);
                            return;

                        case 0x1af:
                            this.method_29().Positioning.HorizRelationTo = HorizontalRelation.Column;
                            return;

                        case 0x1b0:
                            this.method_29().Positioning.HorizRelationTo = HorizontalRelation.Margin;
                            return;

                        case 0x1b1:
                            this.method_29().Positioning.HorizRelationTo = HorizontalRelation.Page;
                            return;

                        case 0x1b2:
                        case 0x1b3:
                            this.method_29().Positioning.HorizPositionEx = this.method_165(A_2);
                            return;

                        case 0x1b4:
                        case 0x1b5:
                            this.method_29().Positioning.VertPositionEx = this.method_165(A_2);
                            return;

                        case 0x1b6:
                            this.method_29().Positioning.HorizPositionAbs = HorizontalPosition.Center;
                            this.method_29().HorizontalAlignment = RowAlignment.Center;
                            return;

                        case 0x1b7:
                            this.method_29().Positioning.HorizPositionAbs = HorizontalPosition.Inside;
                            return;

                        case 440:
                            this.method_29().Positioning.HorizPositionAbs = HorizontalPosition.Left;
                            return;

                        case 0x1b9:
                            this.method_29().Positioning.HorizPositionAbs = HorizontalPosition.Outside;
                            return;

                        case 0x1ba:
                            this.method_29().Positioning.HorizPositionAbs = HorizontalPosition.Right;
                            this.method_29().HorizontalAlignment = RowAlignment.Right;
                            return;

                        case 0x1bb:
                            this.method_29().Positioning.VertPositionAbs = VerticalPosition.Bottom;
                            return;

                        case 0x1bc:
                            this.method_29().Positioning.VertPositionAbs = VerticalPosition.Center;
                            return;

                        case 0x1be:
                            this.method_29().Positioning.VertPositionAbs = VerticalPosition.Inside;
                            return;

                        case 0x1bf:
                            this.method_29().Positioning.VertPositionAbs = VerticalPosition.Outside;
                            return;

                        case 0x1c0:
                            this.method_29().Positioning.VertPositionAbs = VerticalPosition.Top;
                            return;

                        case 0x1c1:
                            this.method_29().Positioning.VertRelationTo = VerticalRelation.Margin;
                            return;

                        case 450:
                            this.method_29().Positioning.VertRelationTo = VerticalRelation.Page;
                            return;

                        case 0x1c3:
                            this.method_29().Positioning.VertRelationTo = VerticalRelation.Paragraph;
                            return;

                        case 0x1c4:
                            if (this.stack_15 == null)
                            {
                                this.stack_15 = new Stack<bool>();
                            }
                            this.stack_15.Push(true);
                            return;

                        case 0x1c5:
                            if (!this.class835_0.bool_9)
                            {
                                this.class835_0.bool_8 = true;
                            }
                            return;

                        case 0x1c6:
                            if (!this.class835_0.bool_8)
                            {
                                this.class835_0.bool_9 = true;
                            }
                            return;

                        case 0x1c7:
                        case 0x1c8:
                            if (((A_1 == BookmarkStart.b("䄲倴䄶堸为䤼圾", num)) && this.class835_0.bool_8) || ((A_1 == BookmarkStart.b("䄲倴䄶堸为䤼圾╀♂⥄", num)) && this.class835_0.bool_9))
                            {
                                this.class835_0.string_1 = this.method_117(Convert.ToInt32(A_2));
                            }
                            return;

                        case 0x1c9:
                        case 0x1ca:
                            if (((A_1 == BookmarkStart.b("䄲倴䄶崸伺䤼刾", num)) && this.class835_0.bool_8) || ((A_1 == BookmarkStart.b("䄲倴䄶崸伺䤼刾╀♂⥄", num)) && this.class835_0.bool_9))
                            {
                                this.class835_0.dateTime_0 = Class1041.smethod_7(Convert.ToInt32(A_2));
                            }
                            return;
                    }
                }
            }
            this.method_119(A_0);
        }
    }

    private bool method_114(string A_0, string A_1)
    {
        return (this.method_115(A_0, A_1) > 15);
    }

    private int method_115(string A_0, string A_1)
    {
        if (!string.IsNullOrEmpty(A_0) && !string.IsNullOrEmpty(A_1))
        {
            int result = -1;
            int.TryParse(A_1.Replace(A_0, string.Empty), out result);
            return result;
        }
        return -1;
    }

    private string method_116(int A_0, Dictionary<string, Style> A_1)
    {
        string str3;
        if ((A_0 < 0) || (A_1 == null))
        {
            return string.Empty;
        }
        using (Dictionary<string, Style>.KeyCollection.Enumerator enumerator = A_1.Keys.GetEnumerator())
        {
            string current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                StringBuilder builder = new StringBuilder();
                foreach (char ch in current)
                {
                    if (char.IsNumber(ch))
                    {
                        builder.Append(ch);
                    }
                }
                if (builder.Length > 0)
                {
                    int result = -1;
                    int.TryParse(builder.ToString(), out result);
                    if ((result > -1) && (A_0 == result))
                    {
                        goto Label_008D;
                    }
                }
            }
            return string.Empty;
        Label_008D:
            str3 = current;
        }
        return str3;
    }

    private string method_117(int A_0)
    {
        if (((this.dictionary_8 != null) && (this.dictionary_8.Count != 0)) && this.dictionary_8.ContainsKey(A_0))
        {
            return this.dictionary_8[A_0];
        }
        return string.Empty;
    }

    private float method_118(int A_0)
    {
        float num = this.class836_0.method_2().HasValue ? this.class836_0.method_2().Value : 0f;
        float num2 = this.class836_0.method_4().HasValue ? this.class836_0.method_4().Value : 0f;
        float num3 = this.class836_0.method_0().HasValue ? this.class836_0.method_0().Value : 0f;
        float num4 = (this.class836_0.sizeF_0.Width - (num + num2)) - num3;
        float num5 = num4 - (0x24 * (A_0 - 1));
        return (num5 / ((float) A_0));
    }

    private void method_119(string A_0)
    {
        int num = 2;
        string str = null;
        if ((!this.bool_13 || this.bool_42) || ((this.bool_43 || this.bool_23) || ((this.stack_15 != null) && (this.stack_15.Count > 0))))
        {
            if (A_0.StartsWith(BookmarkStart.b("༧", num)) && !this.method_120())
            {
                if (this.bool_23 && (this.decoder_1 != null))
                {
                    this.decoder_0 = this.decoder_1;
                }
                else if (this.bool_23)
                {
                    this.decoder_0 = Encoding.Default.GetDecoder();
                }
                this.bool_37 = true;
                str = this.method_134(A_0);
            }
            else if (A_0.StartsWith(BookmarkStart.b("༧", num)) && (A_0.Length > 3))
            {
                str = A_0.Substring(3, A_0.Length - 3);
            }
            else if (A_0.StartsWith(BookmarkStart.b("༧ᤩ䨫", num)) && (A_0.Length > 3))
            {
                str = this.method_134(A_0);
            }
            else if (A_0.StartsWith(BookmarkStart.b("眧", num)))
            {
                str = A_0.Replace(BookmarkStart.b("眧", num), '\x001e'.ToString());
            }
            else if (A_0.StartsWith(BookmarkStart.b("嘧", num)))
            {
                str = A_0.Replace(BookmarkStart.b("嘧", num), '\x00a0'.ToString());
            }
            else if (A_0.StartsWith(BookmarkStart.b("ԧ", num)))
            {
                str = A_0;
            }
            else if (A_0.StartsWith(BookmarkStart.b("ሧ", num)))
            {
                str = A_0;
            }
            else if (A_0.StartsWith(BookmarkStart.b("䬧䈩䴫尭䈯䄱崳刵", num)))
            {
                string[] strArray = this.method_166(A_0);
                if ((strArray.Length == 2) && (strArray[1] != string.Empty))
                {
                    string[] strArray2 = A_0.Split(strArray[1].ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (strArray2.Length > 1)
                    {
                        str = strArray2[1];
                    }
                }
            }
        }
        if (str != null)
        {
            this.method_57(str);
        }
    }

    protected void method_12(ListStyle A_0)
    {
        this.listStyle_0 = A_0;
    }

    private bool method_120()
    {
        return ((this.int_25 > 0) && (--this.int_25 >= 0));
    }

    private TextureStyle method_121(int A_0)
    {
        int num = A_0;
        if (num <= 0x128e)
        {
            if (num > 0x8ca)
            {
                if (num > 0xdac)
                {
                    if (num > 0xfa0)
                    {
                        switch (num)
                        {
                            case 0x109a:
                                return TextureStyle.Texture42Pt5Percent;

                            case 0x1194:
                                return TextureStyle.Texture45Percent;

                            case 0x128e:
                                return TextureStyle.Texture47Pt5Percent;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xea6:
                                return TextureStyle.Texture37Pt5Percent;

                            case 0xfa0:
                                return TextureStyle.Texture40Percent;
                        }
                    }
                }
                else if (num > 0xabe)
                {
                    switch (num)
                    {
                        case 0xbb8:
                            return TextureStyle.Texture30Percent;

                        case 0xcb2:
                            return TextureStyle.Texture32Pt5Percent;

                        case 0xdac:
                            return TextureStyle.Texture35Percent;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x9c4:
                            return TextureStyle.Texture25Percent;

                        case 0xabe:
                            return TextureStyle.Texture27Pt5Percent;
                    }
                }
            }
            else if (num > 0x3e8)
            {
                if (num > 0x5dc)
                {
                    switch (num)
                    {
                        case 0x6d6:
                            return TextureStyle.Texture17Pt5Percent;

                        case 0x7d0:
                            return TextureStyle.Texture20Percent;

                        case 0x8ca:
                            return TextureStyle.Texture22Pt5Percent;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x4e2:
                            return TextureStyle.Texture12Pt5Percent;

                        case 0x5dc:
                            return TextureStyle.Texture15Percent;
                    }
                }
            }
            else if (num > 500)
            {
                if (num == 750)
                {
                    return TextureStyle.Texture7Pt5Percent;
                }
                if (num == 0x3e8)
                {
                    return TextureStyle.Texture10Percent;
                }
            }
            else
            {
                switch (num)
                {
                    case 250:
                        return TextureStyle.Texture2Pt5Percent;

                    case 500:
                        return TextureStyle.Texture5Percent;
                }
            }
        }
        else if (num <= 0x1c52)
        {
            if (num > 0x1770)
            {
                if (num > 0x1964)
                {
                    switch (num)
                    {
                        case 0x1a5e:
                            return TextureStyle.Texture67Pt5Percent;

                        case 0x1b58:
                            return TextureStyle.Texture70Percent;

                        case 0x1c52:
                            return TextureStyle.Texture72Pt5Percent;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x186a:
                            return TextureStyle.Texture62Pt5Percent;

                        case 0x1964:
                            return TextureStyle.Texture65Percent;
                    }
                }
            }
            else if (num > 0x1482)
            {
                switch (num)
                {
                    case 0x157c:
                        return TextureStyle.Texture55Percent;

                    case 0x1676:
                        return TextureStyle.Texture57Pt5Percent;

                    case 0x1770:
                        return TextureStyle.Texture60Percent;
                }
            }
            else
            {
                switch (num)
                {
                    case 0x1388:
                        return TextureStyle.Texture50Percent;

                    case 0x1482:
                        return TextureStyle.Texture52Pt5Percent;
                }
            }
        }
        else
        {
            switch (num)
            {
                case 0x1f40:
                    return TextureStyle.Texture80Percent;

                case 0x203a:
                    return TextureStyle.Texture82Pt5Percent;

                case 0x2134:
                    return TextureStyle.Texture85Percent;

                case 0x1d4c:
                    return TextureStyle.Texture75Percent;

                case 0x1e46:
                    return TextureStyle.Texture77Pt5Percent;

                case 0x222e:
                    return TextureStyle.Texture87Pt5Percent;

                case 0x2328:
                    return TextureStyle.Texture90Percent;

                case 0x2422:
                    return TextureStyle.Texture92Pt5Percent;

                case 0x251c:
                    return TextureStyle.Texture95Percent;

                case 0x2616:
                    return TextureStyle.Texture97Pt5Percent;
            }
        }
        return TextureStyle.TextureNone;
    }

    private void method_122()
    {
        int num = 12;
        this.stack_4.Push(BookmarkStart.b("䤱", 12));
        if (this.bool_18 && (this.string_9 == BookmarkStart.b("䈱唳䐵", num)))
        {
            this.method_7().ListFormat.ContinueListNumbering();
            this.method_94(this.paragraphFormat_0, this.method_7().Format);
        }
        this.paragraph_0 = this.method_7().Clone() as Paragraph;
        this.class835_3 = this.class835_0.method_0();
        this.class835_0 = new Class835();
        this.iparagraph_0 = new Paragraph(this.document_0);
        this.method_139(this.method_7().Format);
        this.characterFormat_0 = new CharacterFormat(this.document_0);
        this.paragraphFormat_1 = new ParagraphFormat(this.document_0);
        this.bool_17 = true;
    }

    private void method_123()
    {
        int num = 2;
        this.bool_63 = false;
        this.stack_40.Clear();
        if ((this.method_7().ListFormat.CurrentListStyle != null) && this.bool_18)
        {
            this.method_94(this.paragraphFormat_1, this.method_7().ListFormat.CurrentListLevel.ParagraphFormat);
            this.method_104(this.characterFormat_0, this.method_7().ListFormat.CurrentListLevel.CharacterFormat);
        }
        this.int_16 = 0;
        IParagraph paragraph = this.method_7();
        if ((!this.bool_13 && (this.string_9 != BookmarkStart.b("䘧䔩䈫䬭䌯䘱䀳圵娷嘹夻䴽", num))) || this.bool_54)
        {
            if (((this.bool_43 && !this.bool_6) && (!this.bool_60 && this.bool_41)) && !this.bool_54)
            {
                this.string_24 = this.string_24 + BookmarkStart.b("┧", num);
            }
            else
            {
                if (!this.bool_54 || !(this.body_0.Owner is TextBox))
                {
                    this.method_140();
                }
                this.method_162(this.method_7());
            }
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.iparagraph_0.Format);
            this.method_163(paragraph);
            this.method_124(paragraph, this.iparagraph_0);
            if (this.method_3() == BookmarkStart.b("唧", num))
            {
                Class843 class4 = ((this.class835_0 == null) || !this.class835_0.bool_3) ? new Class843() : this.class835_0.class843_0;
                Class843 class2 = ((this.class835_0 == null) || !this.class835_0.bool_4) ? new Class843() : this.class835_0.class843_1;
                Class843 class3 = ((this.class835_0 == null) || !this.class835_0.bool_5) ? new Class843() : this.class835_0.class843_2;
                this.method_137(this.class835_2, this.class835_0);
                if (!class4.method_8())
                {
                    this.class835_0.class843_0 = class4;
                }
                if (!class2.method_8())
                {
                    this.class835_0.class843_1 = class2;
                }
                if (!class3.method_8())
                {
                    this.class835_0.class843_2 = class3;
                }
            }
        }
    }

    private void method_124(IParagraph A_0, IParagraph A_1)
    {
        int num = 2;
        if ((A_0 != null) && (A_1 != null))
        {
            ParagraphFormat format = A_0.Format;
            if ((this.method_2() != BookmarkStart.b("唧", num)) && (A_0.StyleName != null))
            {
                A_1.ApplyStyle(A_0.StyleName);
            }
            if (this.method_2() == BookmarkStart.b("唧", num))
            {
                format = this.stack_52.Peek();
            }
            this.method_94(format, A_1.Format);
            A_1.Format.Tabs.Clear();
            if (((A_0.ListFormat.CurrentListStyle != null) && this.bool_18) && (this.method_2() != BookmarkStart.b("唧", num)))
            {
                A_1.ListFormat.method_26(A_0.ListFormat);
            }
        }
    }

    private void method_125()
    {
        if ((this.itable_0 != null) && !this.bool_33)
        {
            this.bool_74 = true;
        }
        this.bool_63 = true;
        this.bool_36 = false;
        this.int_17 = 0;
        this.int_16 = 0;
        this.dictionary_9.Clear();
        this.method_32(new Class842());
        this.bool_33 = false;
        this.bool_18 = false;
        if (this.method_7().Items.Count > 0)
        {
            ParagraphItemCollection items = new ParagraphItemCollection(this.document_0);
            this.method_7().Items.method_22(items);
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.method_7().Format);
            foreach (DocumentObject obj2 in items)
            {
                this.method_58(obj2);
            }
        }
        else
        {
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.method_7().Format);
        }
        this.method_138(this.iparagraph_0.Format);
        this.bool_2 = false;
        this.bool_3 = false;
        this.bool_4 = false;
        this.bool_5 = false;
        this.int_13 = 0;
    }

    private void method_126()
    {
        this.int_17 = 0;
        this.int_16 = 0;
        this.dictionary_9.Clear();
        this.method_32(new Class842());
    }

    private void method_127(bool A_0)
    {
        this.bool_36 = false;
        this.bool_33 = false;
        this.bool_18 = false;
        ParagraphFormat format = (ParagraphFormat) this.method_7().Format.method_23();
        if (this.method_7().Items.Count > 0)
        {
            ParagraphItemCollection items = new ParagraphItemCollection(this.document_0);
            this.method_7().Items.method_22(items);
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.method_7().Format);
            foreach (DocumentObject obj2 in items)
            {
                this.method_58(obj2);
            }
        }
        else
        {
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.method_7().Format);
        }
        if (A_0)
        {
            this.method_138(this.iparagraph_0.Format);
        }
        else
        {
            this.iparagraph_0.Format.method_21(format);
        }
        this.bool_2 = false;
        this.bool_3 = false;
        this.bool_4 = false;
        this.bool_5 = false;
        this.int_13 = 0;
    }

    private void method_128()
    {
        int num = 0x12;
        if (!this.bool_49)
        {
            this.bool_49 = true;
            this.class836_1 = new Class836();
            this.method_129(this.class836_0, this.class836_1);
        }
        if ((!this.bool_28 && !this.bool_29) && !this.bool_19)
        {
            if (this.string_9 == BookmarkStart.b("䬷弹弻䨽", num))
            {
                this.int_14++;
                ISection section = this.isection_0;
                this.isection_0 = new Section(this.document_0);
                this.method_39(this.isection_0, section);
                this.isection_0.PageSetup.EqualColumnWidth = true;
                this.body_0 = this.isection_0.Body;
                this.class836_0 = new Class836();
                if (this.bool_49)
                {
                    this.method_129(this.class836_1, this.class836_0);
                }
                this.method_145();
                this.method_9(null);
            }
            else
            {
                this.method_9(null);
                this.method_10().Columns.InnerList.Clear();
                this.method_10().BreakCode = SectionBreakType.NewPage;
            }
        }
    }

    private void method_129(Class836 A_0, Class836 A_1)
    {
        A_1.method_9(A_0.method_8());
        A_1.float_2 = A_0.float_2;
        A_1.bool_0 = A_0.bool_0;
        A_1.bool_1 = A_0.bool_1;
        A_1.float_1 = A_0.float_1;
        A_1.float_0 = A_0.float_0;
        A_1.bool_2 = A_0.bool_2;
        A_1.method_3(A_0.method_2());
        A_1.pageOrientation_0 = A_0.pageOrientation_0;
        A_1.sizeF_0 = A_0.sizeF_0;
        A_1.method_5(A_0.method_4());
        A_1.method_7(A_0.method_6());
        A_1.pageAlignment_0 = A_0.pageAlignment_0;
        A_1.method_1(A_0.method_0());
        A_1.bool_4 = A_0.bool_4;
    }

    protected ListLevel method_13()
    {
        return this.listLevel_0;
    }

    private void method_130()
    {
        this.bool_19 = true;
        this.int_10 = -1;
        this.int_11 = -1;
        this.method_28(new CellFormat());
        this.method_27().Paddings.All = 0f;
        this.stack_8.Clear();
        this.stack_21.Clear();
        this.dictionary_2 = new Dictionary<int, CellFormat>();
        this.stack_8.Push(this.dictionary_2);
        this.bool_38 = false;
        this.method_30(new RowFormat());
        this.method_29().method_0(this.document_0);
        this.method_29().LayoutType = LayoutType.Fixed;
        this.method_29().Paddings.Left = 0f;
        this.method_29().Paddings.Right = 0f;
        this.stack_21.Push(this.method_29());
        this.stack_53.Push(this.method_35());
        this.paddings_0 = null;
        this.stack_54.Push(this.struct26_0);
        this.struct26_0 = new Struct26();
    }

    private void method_131()
    {
        this.bool_19 = false;
        int num = 0;
        this.stack_9 = new Stack<Dictionary<int, CellFormat>>(this.stack_8.ToArray());
        this.stack_22 = new Stack<RowFormat>(this.stack_21.ToArray());
        this.dictionary_2 = this.stack_8.Pop();
        foreach (KeyValuePair<int, CellFormat> pair in this.dictionary_2)
        {
            if (this.itable_0 != null)
            {
                this.method_157(this.itable_0.LastRow.Cells[num], pair.Value);
                this.itable_0.LastRow.Cells[num].CellFormat.TwipCellWidth = (num == 0) ? this.itable_0.LastRow.Cells[num].CellFormat.Cellx : (this.itable_0.LastRow.Cells[num].CellFormat.Cellx - this.itable_0.LastRow.Cells[num - 1].CellFormat.Cellx);
            }
            num++;
        }
        this.method_132();
        if (this.stack_21.Count > 0)
        {
            this.method_30(this.stack_21.Pop());
        }
        if ((this.struct26_0.method_3() || this.struct26_0.method_5()) || (this.struct26_0.method_9() || this.struct26_0.method_7()))
        {
            this.itable_0.LastRow.HasTblPrEx = true;
            if (this.struct26_0.method_3())
            {
                this.method_29().Paddings.Top = this.method_35().Top;
            }
            if (this.struct26_0.method_5())
            {
                this.method_29().Paddings.Bottom = this.method_35().Bottom;
            }
            if (this.struct26_0.method_9())
            {
                this.method_29().Paddings.Left = this.method_35().Left;
            }
            else if (this.struct26_0.method_0())
            {
                this.method_29().Paddings.Left = this.struct26_0.method_1().Value;
            }
            if (this.struct26_0.method_7())
            {
                this.method_29().Paddings.Right = this.method_35().Right;
            }
            else if (this.struct26_0.method_0())
            {
                this.method_29().Paddings.Right = this.struct26_0.method_1().Value;
            }
        }
        if (this.itable_0 != null)
        {
            this.method_158(this.itable_0.LastRow, this.method_29());
            this.method_169(this.itable_0.LastRow.CharacterFormat, this.class835_0);
        }
        this.method_30(new RowFormat());
        if (this.stack_54.Count > 0)
        {
            this.struct26_0 = this.stack_54.Pop();
        }
        if (this.stack_53.Count > 0)
        {
            this.paddings_0 = this.stack_53.Pop();
        }
        this.method_29().LayoutType = LayoutType.Fixed;
        this.method_29().method_0(this.document_0);
        this.int_11 = -1;
        this.tableRow_0 = null;
        this.stack_8 = new Stack<Dictionary<int, CellFormat>>(this.stack_9.ToArray());
        this.stack_21 = new Stack<RowFormat>(this.stack_22.ToArray());
    }

    private void method_132()
    {
        for (int i = 0; i < this.itable_0.LastRow.Cells.Count; i++)
        {
            TableCell cell = (this.itable_0.LastRow.Cells[i].CellFormat.HorizontalMerge == CellMerge.Start) ? this.itable_0.LastRow.Cells[i] : null;
            if (cell != null)
            {
                if (i == 0)
                {
                    cell.CellFormat.CellWidth = ((float) cell.CellFormat.Cellx) / 20f;
                }
                if ((i != 0) && ((((float) (cell.CellFormat.Cellx - this.itable_0.LastRow.Cells[i - 1].CellFormat.Cellx)) / 20f) < cell.CellFormat.CellWidth))
                {
                    cell.CellFormat.CellWidth = ((float) (cell.CellFormat.Cellx - this.itable_0.LastRow.Cells[i - 1].CellFormat.Cellx)) / 20f;
                }
                for (int j = i + 1; j < this.itable_0.LastRow.Cells.Count; j++)
                {
                    if ((this.itable_0.LastRow.Cells[j].CellFormat.HorizontalMerge == CellMerge.Continue) && ((((float) (this.itable_0.LastRow.Cells[j].CellFormat.Cellx - this.itable_0.LastRow.Cells[j - 1].CellFormat.Cellx)) / 20f) < this.itable_0.LastRow.Cells[j].CellFormat.CellWidth))
                    {
                        this.itable_0.LastRow.Cells[j].CellFormat.CellWidth = ((float) (this.itable_0.LastRow.Cells[j].CellFormat.Cellx - this.itable_0.LastRow.Cells[j - 1].CellFormat.Cellx)) / 20f;
                    }
                }
            }
        }
    }

    private void method_133(string A_0, string A_1, string A_2)
    {
        this.int_19 = this.int_18;
        this.int_18 = Convert.ToInt32(A_2);
        this.method_27().Cellx = (short) this.int_18;
        this.int_11++;
        this.dictionary_2 = this.stack_8.Pop();
        if (!this.bool_38)
        {
            if (this.dictionary_2.Count > 0)
            {
                this.method_27().CellWidth = this.method_165((this.int_18 - this.int_19).ToString());
            }
            else
            {
                this.method_27().CellWidth = this.method_165((this.int_18 - this.int_20).ToString());
            }
        }
        if (!this.dictionary_2.ContainsKey(this.int_11))
        {
            this.dictionary_2.Add(this.int_11, this.method_27());
        }
        this.stack_8.Push(this.dictionary_2);
        this.method_28(new CellFormat());
        this.method_27().Paddings.All = 0f;
        this.bool_2 = false;
        this.bool_5 = false;
        this.bool_4 = false;
        this.bool_3 = false;
        this.bool_38 = false;
    }

    private string method_134(string A_0)
    {
        int num = 5;
        int num2 = 0;
        string str = "";
        int length = A_0.Length;
        string str2 = A_0.Substring(1, 2);
        str = this.method_136(str2);
        if (A_0.StartsWith(BookmarkStart.b("ప", 5)) && (str2.ToLower() != BookmarkStart.b("ᠪ䬬", num)))
        {
            num2 = int.Parse(str2, NumberStyles.HexNumber);
            this.list_1.Add((byte) num2);
            if ((((num2 >= 0x80) && (num2 < 0xff)) && ((this.list_1.Count == 1) && (length == 3))) && (this.method_2().StartsWith(BookmarkStart.b("眪ਬ", num)) && (int.Parse(this.method_2().Substring(2, 2), NumberStyles.HexNumber) < 0xff)))
            {
                return null;
            }
            str = this.method_135(this.list_1);
            this.list_1.Clear();
        }
        else if (this.string_9.StartsWith(BookmarkStart.b("帪", num)))
        {
            str = ((char) Convert.ToInt32(this.string_11)).ToString();
        }
        if (length > 3)
        {
            str = str + A_0.Substring(3, length - 3);
        }
        return str;
    }

    private string method_135(List<byte> A_0)
    {
        StringBuilder builder = new StringBuilder();
        long count = A_0.Count;
        if (count > 0L)
        {
            byte[] bytes = A_0.ToArray();
            char[] chars = new char[count];
            int byteIndex = 0;
            bool completed = false;
            while (!completed)
            {
                int num3;
                int num4;
                if (byteIndex >= bytes.Length)
                {
                    break;
                }
                this.decoder_0.Convert(bytes, byteIndex, bytes.Length - byteIndex, chars, 0, chars.Length, true, out num3, out num4, out completed);
                builder.Append(chars, 0, num4);
                byteIndex += num4;
            }
        }
        return builder.ToString();
    }

    private string method_136(string A_0)
    {
        int num = 6;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_165 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                dictionary1.Add(BookmarkStart.b("ᐫḭ", num), 0);
                dictionary1.Add(BookmarkStart.b("ᐫᴭ", num), 1);
                dictionary1.Add(BookmarkStart.b("ᐫᨭ", num), 2);
                dictionary1.Add(BookmarkStart.b("ᐫᬭ", num), 3);
                dictionary1.Add(BookmarkStart.b("ᐫᠭ", num), 4);
                dictionary1.Add(BookmarkStart.b("ᐫ᤭", num), 5);
                dictionary1.Add(BookmarkStart.b("ᐫᘭ", num), 6);
                dictionary1.Add(BookmarkStart.b("ᐫᜭ", num), 7);
                dictionary1.Add(BookmarkStart.b("ᐫ漭", num), 8);
                dictionary1.Add(BookmarkStart.b("ᐫ氭", num), 9);
                dictionary1.Add(BookmarkStart.b("ᐫ洭", num), 10);
                dictionary1.Add(BookmarkStart.b("ᐫ欭", num), 11);
                dictionary1.Add(BookmarkStart.b("ᔫἭ", num), 12);
                dictionary1.Add(BookmarkStart.b("ᔫᰭ", num), 13);
                dictionary1.Add(BookmarkStart.b("ᔫᴭ", num), 14);
                dictionary1.Add(BookmarkStart.b("ᔫᨭ", num), 15);
                dictionary1.Add(BookmarkStart.b("ᔫᬭ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("ᔫᠭ", num), 0x11);
                dictionary1.Add(BookmarkStart.b("ᔫ᤭", num), 0x12);
                dictionary1.Add(BookmarkStart.b("ᔫᜭ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("ᔫ漭", num), 20);
                dictionary1.Add(BookmarkStart.b("ᔫ氭", num), 0x15);
                dictionary1.Add(BookmarkStart.b("ᔫ洭", num), 0x16);
                dictionary1.Add(BookmarkStart.b("ᔫ欭", num), 0x17);
                dictionary1.Add(BookmarkStart.b("ᔫ栭", num), 0x18);
                dictionary1.Add(BookmarkStart.b("ḫḭ", num), 0x19);
                Class1160.dictionary_165 = dictionary1;
            }
            if (Class1160.dictionary_165.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BookmarkStart.b("耋", num);

                    case 1:
                        return BookmarkStart.b("븪", num);

                    case 2:
                        return BookmarkStart.b("㈋", num);

                    case 3:
                        return BookmarkStart.b("ȫ-ḯ", num);

                    case 4:
                        return BookmarkStart.b("ఋ", num);

                    case 5:
                        return BookmarkStart.b("ഋ", num);

                    case 6:
                        return BookmarkStart.b("", num);

                    case 7:
                        return BookmarkStart.b("ᰋ", num);

                    case 8:
                        return BookmarkStart.b("䰪", num);

                    case 9:
                        return BookmarkStart.b("ᔋ", num);

                    case 10:
                        return BookmarkStart.b("縪", num);

                    case 11:
                        return BookmarkStart.b("優", num);

                    case 12:
                        return BookmarkStart.b("㐋", num);

                    case 13:
                        return BookmarkStart.b("ଫ", num);

                    case 14:
                        return BookmarkStart.b("》", num);

                    case 15:
                        return BookmarkStart.b("ㄋ", num);

                    case 0x10:
                        return BookmarkStart.b("ซ", num);

                    case 0x11:
                        return BookmarkStart.b("㼋", num);

                    case 0x12:
                        return BookmarkStart.b("㠋", num);

                    case 0x13:
                        return BookmarkStart.b("ช", num);

                    case 20:
                        return BookmarkStart.b("䴪", num);

                    case 0x15:
                        return BookmarkStart.b("ᘋ", num);

                    case 0x16:
                        return BookmarkStart.b("缪", num);

                    case 0x17:
                        return BookmarkStart.b("刪", num);

                    case 0x18:
                        return BookmarkStart.b("吪", num);

                    case 0x19:
                        return BookmarkStart.b("ఫ", num);
                }
            }
        }
        return null;
    }

    private void method_137(Class835 A_0, Class835 A_1)
    {
        if ((A_0 != null) && (A_1 != null))
        {
            A_1.class843_1 = A_0.class843_1;
            A_1.bool_4 = A_0.bool_4;
            A_1.class843_2 = A_0.class843_2;
            A_1.bool_5 = A_0.bool_5;
            A_1.threeState_6 = A_0.threeState_6;
            A_1.threeState_0 = A_0.threeState_0;
            A_1.float_6 = A_0.float_6;
            A_1.bool_2 = A_0.bool_2;
            A_1.bool_1 = A_0.bool_1;
            A_1.class843_0 = A_0.class843_0;
            A_1.bool_3 = A_0.bool_3;
            A_1.string_0 = A_0.string_0;
            A_1.float_0 = A_0.float_0;
            A_1.threeState_1 = A_0.threeState_1;
            A_1.threeState_4 = A_0.threeState_4;
            A_1.threeState_5 = A_0.threeState_5;
            A_1.float_2 = A_0.float_2;
            A_1.float_1 = A_0.float_1;
            A_1.bool_0 = A_0.bool_0;
            A_1.float_4 = A_0.float_4;
            A_1.threeState_3 = A_0.threeState_3;
            A_1.builtinStyle_0 = A_0.builtinStyle_0;
            A_1.horizontalAlignment_0 = A_0.horizontalAlignment_0;
            A_1.float_3 = A_0.float_3;
            A_1.float_5 = A_0.float_5;
            A_1.threeState_2 = A_0.threeState_2;
            A_1.underlineStyle_0 = A_0.underlineStyle_0;
            A_1.bool_6 = A_0.bool_6;
            A_1.bool_7 = A_0.bool_7;
        }
    }

    private void method_138(ParagraphFormat A_0)
    {
        A_0.method_51();
        this.method_139(A_0);
    }

    private void method_139(ParagraphFormat A_0)
    {
        A_0.IsWidowControl = false;
    }

    protected void method_14(ListLevel A_0)
    {
        this.listLevel_0 = A_0;
    }

    private void method_140()
    {
        if (this.bool_33 && (this.int_13 == 0))
        {
            this.int_13 = 1;
        }
        Struct25 struct2 = new Struct25(this.bool_33, this.int_13, this.int_12);
        Body item = (this.body_0 != null) ? this.body_0 : this.method_10().Body;
        if (struct2.bool_0 && (struct2.prepareTableState_0 != PrepareTableState.LeaveTable))
        {
            if (this.tableRow_0 == null)
            {
                if (this.itable_0 != null)
                {
                    this.tableRow_0 = new TableRow(this.document_0);
                    this.itable_0.Rows.Add(this.tableRow_0);
                    this.tableCell_0 = this.tableRow_0.AddCell(false);
                    this.body_0 = this.tableCell_0;
                }
            }
            else if (((this.tableRow_0 != null) && (this.tableRow_0.Cells.Count > 0)) && !this.bool_34)
            {
                this.body_0 = this.tableRow_0.Cells.LastItem as TableCell;
            }
            else if (this.bool_34)
            {
                if (this.itable_0 != null)
                {
                    this.tableCell_0 = this.itable_0.LastRow.AddCell();
                }
                this.body_0 = this.tableCell_0;
            }
        }
        if (this.bool_34)
        {
            this.bool_34 = false;
        }
        switch (struct2.prepareTableState_0)
        {
            case PrepareTableState.EnterTable:
                if ((struct2.int_1 == 0) && !(item is TableCell))
                {
                    this.stack_16.Push(item);
                }
                this.method_143(struct2.int_0);
                return;

            case PrepareTableState.LeaveTable:
                this.method_142(struct2.int_0);
                return;
        }
    }

    private void method_141(bool A_0)
    {
        if (this.bool_33 && (this.int_13 == 0))
        {
            this.int_13 = 1;
        }
        Struct25 struct2 = new Struct25(this.bool_33, this.int_13, this.int_12, A_0);
        Body item = (this.body_0 != null) ? this.body_0 : this.method_10().Body;
        if (struct2.bool_0 && (struct2.prepareTableState_0 != PrepareTableState.LeaveTable))
        {
            if (this.tableRow_0 == null)
            {
                if (this.itable_0 == null)
                {
                    this.itable_0 = new Table(this.document_0);
                }
                this.tableRow_0 = new TableRow(this.document_0);
                this.itable_0.Rows.Add(this.tableRow_0);
                this.tableCell_0 = this.tableRow_0.AddCell(false);
                this.body_0 = this.tableCell_0;
            }
            else if (this.bool_34)
            {
                if (this.itable_0 != null)
                {
                    this.tableCell_0 = this.itable_0.LastRow.AddCell();
                }
                this.body_0 = this.tableCell_0;
            }
        }
        if (this.bool_34)
        {
            this.bool_34 = false;
        }
        switch (struct2.prepareTableState_0)
        {
            case PrepareTableState.EnterTable:
                if (struct2.int_1 == 0)
                {
                    this.stack_16.Push(item);
                }
                this.method_143(struct2.int_0);
                return;

            case PrepareTableState.LeaveTable:
                this.method_142(struct2.int_0);
                return;
        }
    }

    private void method_142(int A_0)
    {
        Table table = null;
        if ((this.stack_17.Count > 0) && (A_0 > 0))
        {
            table = this.stack_17.Pop();
        }
        if (A_0 == 0)
        {
            this.body_0 = (this.stack_16.Count > 0) ? this.stack_16.Pop() : this.isection_0.Body;
            if (this.itable_0 != null)
            {
                if (this.itable_0.FirstRow != null)
                {
                    this.itable_0.TableFormat.ImportContainer(this.itable_0.FirstRow.RowFormat);
                }
                this.body_0.Items.Add(this.itable_0);
                (this.itable_0 as Table).method_64();
            }
            this.itable_0 = null;
            this.tableRow_0 = null;
            this.int_12 = A_0;
        }
        else
        {
            Table entity = this.itable_0 as Table;
            this.itable_0 = table;
            if (this.itable_0 == null)
            {
                this.tableRow_0 = null;
                this.body_0 = this.isection_0.Body;
            }
            else
            {
                this.tableRow_0 = this.itable_0.LastRow;
                this.body_0 = this.itable_0.LastCell;
            }
            this.body_0.Items.Add(entity);
            if (entity != null)
            {
                entity.method_64();
            }
        }
    }

    private void method_143(int A_0)
    {
        do
        {
            if (this.itable_0 != null)
            {
                this.stack_17.Push(this.itable_0 as Table);
            }
            this.itable_0 = new Table(this.document_0);
            this.tableRow_0 = this.itable_0.AddRow(false, false);
            this.body_0 = this.tableRow_0.AddCell(false);
        }
        while (this.stack_17.Count < (A_0 - 1));
    }

    private void method_144(string A_0, string A_1, string A_2, ListFormat A_3)
    {
        string styleName = null;
        using (Dictionary<string, string>.Enumerator enumerator = this.dictionary_5.GetEnumerator())
        {
            KeyValuePair<string, string> current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Key == A_0)
                {
                    goto Label_0033;
                }
            }
            return;
        Label_0033:
            styleName = current.Value;
            A_3.ApplyStyle(styleName);
            A_3.ListLevelNumber = 0;
            if (this.method_34().ContainsKey(A_0))
            {
                A_3.LFOStyleName = this.method_34()[A_0];
            }
        }
    }

    private void method_145()
    {
        if (this.class836_0.method_8().HasValue && (this.class836_0.method_8().Value >= 0f))
        {
            this.method_10().PageSetup.Margins.Bottom = this.class836_0.method_8().Value;
        }
        if (this.class836_0.method_2().HasValue && (this.class836_0.method_2().Value >= 0f))
        {
            this.method_10().PageSetup.Margins.Left = this.class836_0.method_2().Value;
        }
        if (this.class836_0.method_4().HasValue && (this.class836_0.method_4().Value >= 0f))
        {
            this.method_10().PageSetup.Margins.Right = this.class836_0.method_4().Value;
        }
        if (this.class836_0.method_6().HasValue && (this.class836_0.method_6().Value >= 0f))
        {
            this.method_10().PageSetup.Margins.Top = this.class836_0.method_6().Value;
        }
        if (this.class836_0.method_0().HasValue && (this.class836_0.method_0().Value >= 0f))
        {
            this.method_10().PageSetup.Margins.Gutter = this.class836_0.method_0().Value;
        }
        this.method_10().PageSetup.GutterAtTop = this.class836_0.bool_4;
        if ((this.class836_0.sizeF_0.Width > 0f) && (this.class836_0.sizeF_0.Height > 0f))
        {
            this.method_10().PageSetup.PageSize = this.class836_0.sizeF_0;
        }
        this.method_10().PageSetup.HeaderDistance = this.class836_0.float_0;
        this.method_10().PageSetup.FooterDistance = this.class836_0.float_1;
        this.method_10().PageSetup.DefaultTabWidth = this.class836_0.float_2;
        this.method_10().PageSetup.VerticalAlignment = this.class836_0.pageAlignment_0;
        if ((this.class836_0.pageOrientation_0 == PageOrientation.Landscape) && (this.class836_0.sizeF_0.Width > this.class836_0.sizeF_0.Height))
        {
            this.method_10().PageSetup.Orientation = this.class836_0.pageOrientation_0;
        }
    }

    private void method_146(string A_0, string A_1, string A_2)
    {
        string str;
        int num = 0x12;
        if (this.bool_15 && ((str = A_1) != null))
        {
            int num4;
            if (Class1160.dictionary_166 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻䰽㌿⹁ぃ", num), 0);
                dictionary1.Add(BookmarkStart.b("嘷唹刻䴽⠿㉁㑃⽅⭇㹉", num), 1);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻丽⤿⅁ぃ", num), 2);
                dictionary1.Add(BookmarkStart.b("䠷匹弻䴽⌿⍁⡃⍅ぇ", num), 3);
                dictionary1.Add(BookmarkStart.b("䠷匹弻䴽⌿⍁⡃⍅ㅇ", num), 4);
                dictionary1.Add(BookmarkStart.b("䠷匹弻䤽✿ⵁ╃⩅", num), 5);
                dictionary1.Add(BookmarkStart.b("䠷匹弻嘽✿ⵁ╃⩅", num), 6);
                dictionary1.Add(BookmarkStart.b("䠷嘹弻崽㈿ⵁ㑃㉅", num), 7);
                dictionary1.Add(BookmarkStart.b("䠷嘹弻崽㈿ⵁ㑃⑅", num), 8);
                dictionary1.Add(BookmarkStart.b("䠷嘹弻崽㈿ⵁ㑃⩅", num), 9);
                dictionary1.Add(BookmarkStart.b("䠷嘹弻崽㈿ⵁ㑃㑅", num), 10);
                dictionary1.Add(BookmarkStart.b("䠷匹弻䤽", num), 11);
                dictionary1.Add(BookmarkStart.b("䠷匹弻嘽", num), 12);
                dictionary1.Add(BookmarkStart.b("娷嘹唻丽㐿⍁⍃", num), 13);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻䤽㈿", num), 14);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻䤽㈿⥁", num), 15);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻圽⸿ㅁぃ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㤿㉁╃㑅⥇", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㤿⽁╃㑅⽇⍉≋", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㤿㉁╃ⅅⵇ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㤿⭁⍃⡅❇㡉⥋", num), 20);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㠿㉁╃ⅅⵇ", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㠿⽁╃㑅⽇⍉≋", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㠿⅁⭃⩅㵇❉≋", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽㠿⭁⍃⡅❇㡉⥋", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻刽┿⑁ぃ", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻䨽⼿㉁", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻䰽⤿╁ⱃ㉅", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻尽⼿㙁ぃ⥅╇", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("䬷刹䰻堽∿⹁㍃㉅ぇ㹉", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("䠷唹伻䜽㐿", num), 30);
                dictionary1.Add(BookmarkStart.b("䠷唹伻䜽⌿", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("䠷唹伻䜽∿", num), 0x20);
                dictionary1.Add(BookmarkStart.b("伷堹儻尽⤿㙁㝃㙅ⅇ㉉⥋≍", num), 0x21);
                dictionary1.Add(BookmarkStart.b("伷堹儻丽ⰿ⍁⩃⍅㭇", num), 0x22);
                dictionary1.Add(BookmarkStart.b("伷堹儻䤽⤿♁ぃ⹅⩇㍉㡋⭍⍏", num), 0x23);
                Class1160.dictionary_166 = dictionary1;
            }
            if (Class1160.dictionary_166.TryGetValue(str, out num4))
            {
                switch (num4)
                {
                    case 0:
                        this.bool_15 = false;
                        return;

                    case 1:
                        this.bool_15 = false;
                        return;

                    case 2:
                        this.bool_15 = true;
                        return;

                    case 3:
                        this.class837_0.method_7(Convert.ToSingle(A_2));
                        return;

                    case 4:
                        this.class837_0.method_3(Convert.ToSingle(A_2));
                        return;

                    case 5:
                        this.class837_0.method_5(this.method_165(A_2));
                        return;

                    case 6:
                        this.class837_0.method_1(this.method_165(A_2));
                        return;

                    case 7:
                        this.class837_0.float_6 = this.method_165(A_2);
                        return;

                    case 8:
                        this.class837_0.float_7 = this.method_165(A_2);
                        return;

                    case 9:
                        this.class837_0.float_8 = this.method_165(A_2);
                        return;

                    case 10:
                        this.class837_0.float_9 = this.method_165(A_2);
                        return;

                    case 11:
                        this.class837_0.int_0 = Convert.ToInt32(A_2);
                        if (((this.method_10() == null) || (this.method_10().PageSetup == null)) || ((this.class837_0.method_4() != 0f) || (Convert.ToInt32(A_2) <= this.method_10().PageSetup.PageSize.Width)))
                        {
                            break;
                        }
                        this.class837_0.method_5(this.method_10().PageSetup.PageSize.Width);
                        return;

                    case 12:
                        this.class837_0.int_1 = Convert.ToInt32(A_2);
                        if (((this.method_10() == null) || (this.method_10().PageSetup == null)) || ((this.class837_0.method_0() != 0f) || (Convert.ToInt32(A_2) <= this.method_10().PageSetup.PageSize.Height)))
                        {
                            break;
                        }
                        this.class837_0.method_1(this.method_10().PageSetup.PageSize.Height);
                        return;

                    case 13:
                        this.class837_0.long_0 = long.Parse(A_2);
                        return;

                    case 14:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 1:
                                this.class837_0.textWrappingStyle_0 = TextWrappingStyle.TopAndBottom;
                                return;

                            case 2:
                                this.class837_0.textWrappingStyle_0 = TextWrappingStyle.Square;
                                return;

                            case 3:
                                this.class837_0.textWrappingStyle_0 = TextWrappingStyle.InFrontOfText;
                                return;

                            case 4:
                                this.class837_0.textWrappingStyle_0 = TextWrappingStyle.Tight;
                                return;

                            case 5:
                                this.class837_0.textWrappingStyle_0 = TextWrappingStyle.Through;
                                return;
                        }
                        return;

                    case 15:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 0:
                                this.class837_0.textWrappingType_0 = TextWrappingType.Both;
                                return;

                            case 1:
                                this.class837_0.textWrappingType_0 = TextWrappingType.Left;
                                return;

                            case 2:
                                this.class837_0.textWrappingType_0 = TextWrappingType.Right;
                                return;

                            case 3:
                                this.class837_0.textWrappingType_0 = TextWrappingType.Largest;
                                return;
                        }
                        return;

                    case 0x10:
                        this.bool_0 = false;
                        this.bool_1 = false;
                        return;

                    case 0x11:
                        this.class837_0.verticalOrigin_0 = VerticalOrigin.Paragraph;
                        this.bool_0 = true;
                        return;

                    case 0x12:
                        this.class837_0.verticalOrigin_0 = VerticalOrigin.Margin;
                        this.bool_0 = true;
                        return;

                    case 0x13:
                        this.class837_0.verticalOrigin_0 = VerticalOrigin.Page;
                        this.bool_0 = true;
                        return;

                    case 20:
                        if (this.bool_0)
                        {
                            break;
                        }
                        this.class837_0.verticalOrigin_0 = VerticalOrigin.Page;
                        return;

                    case 0x15:
                        this.class837_0.horizontalOrigin_0 = HorizontalOrigin.Page;
                        this.bool_1 = true;
                        return;

                    case 0x16:
                        this.class837_0.horizontalOrigin_0 = HorizontalOrigin.Margin;
                        this.bool_1 = true;
                        return;

                    case 0x17:
                        this.class837_0.horizontalOrigin_0 = HorizontalOrigin.Column;
                        this.bool_1 = true;
                        return;

                    case 0x18:
                        if (this.bool_1)
                        {
                            break;
                        }
                        this.class837_0.horizontalOrigin_0 = HorizontalOrigin.Page;
                        return;

                    case 0x19:
                        this.class837_0.float_4 = this.method_165(A_2);
                        return;

                    case 0x1a:
                        this.class837_0.float_5 = this.method_165(A_2);
                        return;

                    case 0x1b:
                        if (this.class837_0.float_4 != 0f)
                        {
                            break;
                        }
                        if ((this.method_10() == null) || (this.method_10().PageSetup == null))
                        {
                            this.class837_0.float_4 = this.method_165(A_2);
                            return;
                        }
                        this.class837_0.float_4 = this.method_165(A_2) - this.method_10().PageSetup.PageSize.Width;
                        return;

                    case 0x1c:
                        if (this.class837_0.float_5 != 0f)
                        {
                            break;
                        }
                        if ((this.method_10() == null) || (this.method_10().PageSetup == null))
                        {
                            this.class837_0.float_5 = this.method_165(A_2);
                            return;
                        }
                        this.class837_0.float_5 = this.method_165(A_2) - this.method_10().PageSetup.PageSize.Height;
                        return;

                    case 0x1d:
                        if (Convert.ToInt32(A_2) != 1)
                        {
                            this.class837_0.bool_0 = false;
                            return;
                        }
                        this.class837_0.bool_0 = true;
                        return;

                    case 30:
                        this.class837_0.shapeVerticalAlignment_0 = ShapeVerticalAlignment.Top;
                        return;

                    case 0x1f:
                        this.class837_0.shapeVerticalAlignment_0 = ShapeVerticalAlignment.Center;
                        return;

                    case 0x20:
                        this.class837_0.shapeVerticalAlignment_0 = ShapeVerticalAlignment.Bottom;
                        return;

                    case 0x21:
                        this.class837_0.int_2 = Convert.ToInt32(A_2);
                        return;

                    case 0x22:
                        this.class837_0.int_3 = 1;
                        return;

                    case 0x23:
                        this.class837_0.int_4 = Convert.ToInt32(A_2);
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_147(string A_0, string A_1, string A_2)
    {
        int num = 0;
        string key = A_1;
        if (key != null)
        {
            int num4;
            if (Class1160.dictionary_167 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                dictionary1.Add(BookmarkStart.b("唥䀧娩師崭尯䘱", num), 0);
                dictionary1.Add(BookmarkStart.b("唥䀧娩堫嘭䐯", num), 1);
                dictionary1.Add(BookmarkStart.b("唥䀧娩尫䜭匯䘱", num), 2);
                dictionary1.Add(BookmarkStart.b("唥䀧娩嬫尭", num), 3);
                dictionary1.Add(BookmarkStart.b("唥䀧娩嬫尭嬯", num), 4);
                dictionary1.Add(BookmarkStart.b("唥䀧娩䔫䀭䌯䘱", num), 5);
                dictionary1.Add(BookmarkStart.b("唥䀧娩䨫䘭启䀱", num), 6);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫圭䀯匱䘳圵", num), 7);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫圭崯匱䘳儵儷吹", num), 8);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫圭䀯匱匳匵", num), 9);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫圭夯唱娳夵䨷弹", num), 10);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫嘭䀯匱匳匵", num), 11);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫嘭崯匱䘳儵儷吹", num), 12);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫嘭匯崱堳䌵唷吹", num), 13);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫嘭夯唱娳夵䨷弹", num), 14);
                dictionary1.Add(BookmarkStart.b("唥䀧娩䀫䬭嘯䘱", num), 15);
                dictionary1.Add(BookmarkStart.b("唥䀧娩堫䄭䀯", num), 0x10);
                dictionary1.Add(BookmarkStart.b("唥䀧娩師䜭圯娱䀳", num), 0x11);
                dictionary1.Add(BookmarkStart.b("唥䀧娩丫䄭䐯䘱嬳嬵", num), 0x12);
                dictionary1.Add(BookmarkStart.b("唥䀧娩䨫䰭尯䔱䀳丵䰷", num), 0x13);
                dictionary1.Add(BookmarkStart.b("嘥䜧天唫娭", num), 20);
                dictionary1.Add(BookmarkStart.b("嘥䜧天唫䴭", num), 0x15);
                dictionary1.Add(BookmarkStart.b("嘥䜧天唫䰭", num), 0x16);
                dictionary1.Add(BookmarkStart.b("唥䘧", num), 0x17);
                dictionary1.Add(BookmarkStart.b("唥帧", num), 0x18);
                dictionary1.Add(BookmarkStart.b("唥堧", num), 0x19);
                Class1160.dictionary_167 = dictionary1;
            }
            if (Class1160.dictionary_167.TryGetValue(key, out num4))
            {
                switch (num4)
                {
                    case 0:
                        this.bool_59 = true;
                        return;

                    case 1:
                        this.bool_57 = true;
                        this.textBox_0 = this.shapeObject_0.InternerTextbox;
                        this.stack_31.Push(this.body_0);
                        this.body_0 = this.textBox_0.Body;
                        this.stack_32.Push(this.iparagraph_0);
                        this.stack_18.Push(this.method_96(this.dictionary_9));
                        this.dictionary_9.Clear();
                        this.iparagraph_0 = null;
                        this.stack_33.Push(this.bool_13);
                        this.bool_13 = false;
                        return;

                    case 2:
                        this.bool_15 = true;
                        return;

                    case 3:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 1:
                                this.shapeObject_0.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
                                return;

                            case 2:
                                this.shapeObject_0.TextWrappingStyle = TextWrappingStyle.Square;
                                return;

                            case 3:
                                this.shapeObject_0.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                return;

                            case 4:
                                this.shapeObject_0.TextWrappingStyle = TextWrappingStyle.Tight;
                                return;

                            case 5:
                                this.shapeObject_0.TextWrappingStyle = TextWrappingStyle.Through;
                                return;
                        }
                        return;

                    case 4:
                        switch (Convert.ToInt32(A_2))
                        {
                            case 0:
                                this.shapeObject_0.TextWrappingType = TextWrappingType.Both;
                                return;

                            case 1:
                                this.shapeObject_0.TextWrappingType = TextWrappingType.Left;
                                return;

                            case 2:
                                this.shapeObject_0.TextWrappingType = TextWrappingType.Right;
                                return;

                            case 3:
                                this.shapeObject_0.TextWrappingType = TextWrappingType.Largest;
                                return;
                        }
                        return;

                    case 5:
                        this.bool_0 = false;
                        this.bool_1 = false;
                        return;

                    case 6:
                        this.shapeObject_0.IsHeaderAutoShape = int.Parse(A_2) != 0;
                        return;

                    case 7:
                        this.shapeObject_0.VerticalOrigin = VerticalOrigin.Paragraph;
                        this.bool_0 = true;
                        return;

                    case 8:
                        this.shapeObject_0.VerticalOrigin = VerticalOrigin.Margin;
                        this.bool_0 = true;
                        return;

                    case 9:
                        this.shapeObject_0.VerticalOrigin = VerticalOrigin.Page;
                        this.bool_0 = true;
                        return;

                    case 10:
                        if (this.bool_0)
                        {
                            break;
                        }
                        this.shapeObject_0.VerticalOrigin = VerticalOrigin.Page;
                        return;

                    case 11:
                        this.shapeObject_0.HorizontalOrigin = HorizontalOrigin.Page;
                        this.bool_1 = true;
                        return;

                    case 12:
                        this.shapeObject_0.HorizontalOrigin = HorizontalOrigin.Margin;
                        this.bool_1 = true;
                        return;

                    case 13:
                        this.shapeObject_0.HorizontalOrigin = HorizontalOrigin.Column;
                        this.bool_1 = true;
                        return;

                    case 14:
                        if (this.bool_1)
                        {
                            break;
                        }
                        this.shapeObject_0.HorizontalOrigin = HorizontalOrigin.Page;
                        return;

                    case 15:
                        this.shapeObject_0.Left = this.method_165(A_2);
                        return;

                    case 0x10:
                        this.shapeObject_0.Top = this.method_165(A_2);
                        return;

                    case 0x11:
                        this.shapeObject_0.Width = this.method_165(A_2) - this.shapeObject_0.Left;
                        return;

                    case 0x12:
                        this.shapeObject_0.Height = this.method_165(A_2) - this.shapeObject_0.Top;
                        return;

                    case 0x13:
                        if (this.shapeObject_0.TextWrappingStyle != TextWrappingStyle.InFrontOfText)
                        {
                            break;
                        }
                        if (Convert.ToInt32(A_2) != 1)
                        {
                            this.shapeObject_0.BehindText = false;
                            return;
                        }
                        this.shapeObject_0.BehindText = true;
                        return;

                    case 20:
                        this.shapeObject_0.VerticalAlignment = ShapeVerticalAlignment.Top;
                        return;

                    case 0x15:
                        this.shapeObject_0.VerticalAlignment = ShapeVerticalAlignment.Center;
                        return;

                    case 0x16:
                        this.shapeObject_0.VerticalAlignment = ShapeVerticalAlignment.Bottom;
                        return;

                    case 0x17:
                        this.bool_55 = true;
                        return;

                    case 0x18:
                        this.bool_56 = true;
                        this.bool_55 = false;
                        return;

                    case 0x19:
                        this.stack_30.Pop();
                        this.stack_30.Push(BookmarkStart.b("唥堧", num));
                        this.bool_56 = false;
                        this.bool_55 = false;
                        this.string_26 = string.Empty;
                        this.string_27 = string.Empty;
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_148(string A_0, string A_1)
    {
        int num = 15;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_168 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x5c);
                dictionary1.Add(BookmarkStart.b("䄴伶弸场椼娾㥀㝂̈́⭆♈㱊", num), 0);
                dictionary1.Add(BookmarkStart.b("儴伶游䤺尼伾Հ⩂㙄㍆Ո⹊⭌㭎", num), 1);
                dictionary1.Add(BookmarkStart.b("儴丶游䤺尼伾Հ⩂㙄㍆ᵈ⑊㵌", num), 2);
                dictionary1.Add(BookmarkStart.b("儴伶游䤺尼伾Հ⩂㙄㍆ᭈ≊⩌❎═", num), 3);
                dictionary1.Add(BookmarkStart.b("儴丶游䤺尼伾Հ⩂㙄㍆ୈ⑊㥌㭎㹐㹒", num), 4);
                dictionary1.Add(BookmarkStart.b("刴䌶尸䌺䤼社ཀⱂ㝄⩆⡈❊⑌㕎㑐", num), 5);
                dictionary1.Add(BookmarkStart.b("匴瀶䴸帺䔼䬾", num), 6);
                dictionary1.Add(BookmarkStart.b("匴甶尸区吼儾╀݂⩄⑆㱈♊⡌ⅎ═", num), 7);
                dictionary1.Add(BookmarkStart.b("匴朶䨸帺䠼嬾⹀ੂ⭄⭆⁈╊⡌", num), 8);
                dictionary1.Add(BookmarkStart.b("匴帶唸场爼伾⁀⁂ⱄ㍆え", num), 9);
                dictionary1.Add(BookmarkStart.b("刴䌶尸䌺䤼社ፀ♂㍄≆㭈㡊⡌ᵎ㹐⑒♔", num), 10);
                dictionary1.Add(BookmarkStart.b("刴䌶尸䌺䤼社⹀ⵂㅄ", num), 11);
                dictionary1.Add(BookmarkStart.b("刴䌶尸䌺䤼氾⡀㥂⁄", num), 12);
                dictionary1.Add(BookmarkStart.b("刴䌶尸䌺䤼樾ཀੂلࡆൈ๊", num), 13);
                dictionary1.Add(BookmarkStart.b("䔴堶䨸区", num), 14);
                dictionary1.Add(BookmarkStart.b("䔴堶䨸䤺堼匾⥀", num), 15);
                dictionary1.Add(BookmarkStart.b("䔴堶䨸䴺", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䔴堶䨸䤺堼匾㝀", num), 0x11);
                dictionary1.Add(BookmarkStart.b("儴伶洸帺䔼䬾ീ♂⍄㍆", num), 0x12);
                dictionary1.Add(BookmarkStart.b("儴丶洸帺䔼䬾ᕀⱂ㕄", num), 0x13);
                dictionary1.Add(BookmarkStart.b("儴伶洸帺䔼䬾ፀ⩂≄⽆㵈", num), 20);
                dictionary1.Add(BookmarkStart.b("儴丶洸帺䔼䬾̀ⱂㅄ㍆♈♊", num), 0x15);
                dictionary1.Add(BookmarkStart.b("刴制嘸眺堼夾㕀", num), 0x16);
                dictionary1.Add(BookmarkStart.b("刴制嘸漺刼伾", num), 0x17);
                dictionary1.Add(BookmarkStart.b("刴制嘸椺吼堾⥀㝂", num), 0x18);
                dictionary1.Add(BookmarkStart.b("刴制嘸示刼䬾㕀ⱂ⡄", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䔴愶尸䤺䤼嘾≀⩂⁄㑆", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䔴搶尸尺值娾⽀㝂ౄ⥆⽈⑊", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("匴瘶䬸䤺刼䠾⥀♂⑄⍆㩈ъٌ", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾ᝀ≂⥄㉆ⱈ", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾獀ᕂ⑄⭆㱈⹊", num), 30);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾牀ᕂ⑄⭆㱈⹊", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾畀ᕂ⑄⭆㱈⹊", num), 0x20);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾瑀ᕂ⑄⭆㱈⹊", num), 0x21);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾着ᕂ⑄⭆㱈⹊", num), 0x22);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾癀ᕂ⑄⭆㱈⹊", num), 0x23);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾祀ᕂ⑄⭆㱈⹊", num), 0x24);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾础ᕂ⑄⭆㱈⹊", num), 0x25);
                dictionary1.Add(BookmarkStart.b("吴匶匸为丼䬾灀獂ፄ♆╈㹊⡌", num), 0x26);
                dictionary1.Add(BookmarkStart.b("头帶圸帺渼䬾⁀ㅂㅄن㭈㥊≌㡎㥐㙒㑔㍖", num), 0x27);
                dictionary1.Add(BookmarkStart.b("头帶圸帺砼儾╀ɂ㝄㕆♈㱊╌⩎ぐ㝒", num), 40);
                dictionary1.Add(BookmarkStart.b("嘴伶䨸伺䐼匾⑀", num), 0x29);
                dictionary1.Add(BookmarkStart.b("嘴伶券", num), 0x2a);
                dictionary1.Add(BookmarkStart.b("头帶圸帺渼䬾⁀ㅂㅄن㭈㥊≌㡎ِ㩒ㅔ⍖ㅘ", num), 0x2b);
                dictionary1.Add(BookmarkStart.b("头帶圸帺渼䬾⁀ㅂㅄن㭈㥊≌㡎ᵐ㙒㭔ざⵘ㍚", num), 0x2c);
                dictionary1.Add(BookmarkStart.b("头帶圸帺砼儾╀ɂ㝄㕆♈㱊ᩌ♎㕐❒㵔", num), 0x2d);
                dictionary1.Add(BookmarkStart.b("头帶圸帺砼儾╀ɂ㝄㕆♈㱊Ō⩎㽐㑒⅔㽖", num), 0x2e);
                dictionary1.Add(BookmarkStart.b("头帶圸帺樼嘾╀㝂ⵄ", num), 0x2f);
                dictionary1.Add(BookmarkStart.b("刴䔶嘸为䴼猾⑀╂ㅄ", num), 0x30);
                dictionary1.Add(BookmarkStart.b("刴䔶嘸为䴼款⹀㍂", num), 0x31);
                dictionary1.Add(BookmarkStart.b("刴䔶嘸为䴼派⡀⑂ⵄ㍆", num), 50);
                dictionary1.Add(BookmarkStart.b("刴䔶嘸为䴼紾⹀㝂ㅄ⡆⑈", num), 0x33);
                dictionary1.Add(BookmarkStart.b("䜴制唸眺堼夾㕀", num), 0x34);
                dictionary1.Add(BookmarkStart.b("䜴制唸漺刼伾", num), 0x35);
                dictionary1.Add(BookmarkStart.b("䜴制唸椺吼堾⥀㝂", num), 0x36);
                dictionary1.Add(BookmarkStart.b("䜴制唸示刼䬾㕀ⱂ⡄", num), 0x37);
                dictionary1.Add(BookmarkStart.b("吴夶娸区刼䴾ᕀ♂㵄㍆", num), 0x38);
                dictionary1.Add(BookmarkStart.b("䴴笶倸嘺刼", num), 0x39);
                dictionary1.Add(BookmarkStart.b("䰴笶倸嘺刼", num), 0x3a);
                dictionary1.Add(BookmarkStart.b("圴怶琸吺夼娾", num), 0x3b);
                dictionary1.Add(BookmarkStart.b("圴怶琸吺夼娾̀ᑂ", num), 60);
                dictionary1.Add(BookmarkStart.b("圴怶琸吺夼娾ᅀ㙂㝄≆ୈ᱊", num), 0x3d);
                dictionary1.Add(BookmarkStart.b("嘴ж紸縺䔼䬾㍀㙂⅄≆཈⑊㽌㡎ぐ⅒ㅔ", num), 0x3e);
                dictionary1.Add(BookmarkStart.b("嘴ж紸縺䔼䬾㍀㙂⅄≆ୈ⩊⹌⑎♐㉒❔㍖", num), 0x3f);
                dictionary1.Add(BookmarkStart.b("匴ж紸", num), 0x40);
                dictionary1.Add(BookmarkStart.b("嘴ж紸栺嘼娾㙀ɂ⭄⁆╈⹊", num), 0x41);
                dictionary1.Add(BookmarkStart.b("匴帶唸场椼䘾ㅀ♂", num), 0x42);
                dictionary1.Add(BookmarkStart.b("匴帶唸场缼匾⡀㍂", num), 0x43);
                dictionary1.Add(BookmarkStart.b("匴帶唸场縼倾ⵀⱂ㝄", num), 0x44);
                dictionary1.Add(BookmarkStart.b("匴帶唸场缼帾≀⡂ل⡆╈⑊㽌", num), 0x45);
                dictionary1.Add(BookmarkStart.b("匴帶唸场簼儾♀⽂⁄", num), 70);
                dictionary1.Add(BookmarkStart.b("匴帶唸场笼倾≀㙂㙄", num), 0x47);
                dictionary1.Add(BookmarkStart.b("匴然倸场儼娾╀", num), 0x48);
                dictionary1.Add(BookmarkStart.b("匴戶䨸帺渼圾⁀㍂⁄ن❈⡊╌⁎⍐", num), 0x49);
                dictionary1.Add(BookmarkStart.b("匴收尸堺刼匾⹀ㅂ̈́⹆╈❊ౌ㱎Ő㩒㙔⍖ⱘ⥚㡜", num), 0x4a);
                dictionary1.Add(BookmarkStart.b("头帶圸帺縼倾ⵀⱂ㝄", num), 0x4b);
                dictionary1.Add(BookmarkStart.b("匴笶倸唺堼", num), 0x4c);
                dictionary1.Add(BookmarkStart.b("儴弶常伺", num), 0x4d);
                dictionary1.Add(BookmarkStart.b("匴笶堸䈺刼䨾㕀ੂ⭄цⱈ❊⅌", num), 0x4e);
                dictionary1.Add(BookmarkStart.b("匴瘶唸场刼䠾เ㕂⁄㕆╈⩊㵌", num), 0x4f);
                dictionary1.Add(BookmarkStart.b("䘴弶堸䬺堼款㡀㍂⁄", num), 80);
                dictionary1.Add(BookmarkStart.b("匴收尸场笼匾⡀㍂ൄ", num), 0x51);
                dictionary1.Add(BookmarkStart.b("匴然唸刺䴼眾", num), 0x52);
                dictionary1.Add(BookmarkStart.b("匴收尸场笼匾⡀㍂ፄ", num), 0x53);
                dictionary1.Add(BookmarkStart.b("匴然唸刺䴼椾", num), 0x54);
                dictionary1.Add(BookmarkStart.b("匴縶䨸示䠼匾ⵀ♂ㅄ", num), 0x55);
                dictionary1.Add(BookmarkStart.b("䜴堶䴸娺䤼嘾⹀ⵂ", num), 0x56);
                dictionary1.Add(BookmarkStart.b("朴堶䴸娺䤼嘾⹀ⵂ", num), 0x57);
                dictionary1.Add(BookmarkStart.b("䈴䴶眸娺值娾", num), 0x58);
                dictionary1.Add(BookmarkStart.b("䔴怶䬸娺䴼漾⹀⽂㱄⁆♈╊ᭌ⩎⍐❒㱔㑖㱘⡚", num), 0x59);
                dictionary1.Add(BookmarkStart.b("匴然倸伺渼圾⁀㍂⁄ፆ♈Ὂ⡌㝎═", num), 90);
                dictionary1.Add(BookmarkStart.b("匴然倸伺椼娾㥀㝂ᅄ⡆ᩈ⍊ⱌ㽎㑐", num), 0x5b);
                Class1160.dictionary_168 = dictionary1;
            }
            if (Class1160.dictionary_168.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.shapeObject_0.SetShapeAttribute(0x88, int.Parse(A_1));
                        return;

                    case 1:
                        this.shapeObject_0.SetShapeAttribute(0x81, int.Parse(A_1));
                        return;

                    case 2:
                        this.shapeObject_0.SetShapeAttribute(130, int.Parse(A_1));
                        return;

                    case 3:
                        this.shapeObject_0.SetShapeAttribute(0x83, int.Parse(A_1));
                        return;

                    case 4:
                        this.shapeObject_0.SetShapeAttribute(0x84, int.Parse(A_1));
                        return;

                    case 5:
                        this.shapeObject_0.SetShapeAttribute(0xf8, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 6:
                        this.shapeObject_0.SetShapeAttribute(0x17d, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 7:
                        if (((this.shapeObject_0.TextWrappingStyle != TextWrappingStyle.Inline) && (this.shapeObject_0.TextWrappingStyle != TextWrappingStyle.InFrontOfText)) && ((this.shapeObject_0.TextWrappingStyle != TextWrappingStyle.Behind) && this.shapeObject_0.ShapePr.method_6(0x1001)))
                        {
                            break;
                        }
                        if (A_1 != BookmarkStart.b("Դ", num))
                        {
                            this.shapeObject_0.SetShapeAttribute(0x1001, TextWrappingStyle.Behind);
                        }
                        this.shapeObject_0.SetShapeAttribute(0x3ba, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 8:
                        this.shapeObject_0.SetShapeAttribute(0x53f, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 9:
                        this.shapeObject_0.SetShapeAttribute(0x182, int.Parse(A_1));
                        return;

                    case 10:
                        this.shapeObject_0.SetShapeAttribute(240, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 11:
                        this.shapeObject_0.SetShapeAttribute(0xc5, A_1);
                        return;

                    case 12:
                        this.shapeObject_0.SetShapeAttribute(0xc3, int.Parse(A_1));
                        return;

                    case 13:
                        this.shapeObject_0.SetShapeAttribute(0xc0, A_1);
                        return;

                    case 14:
                        this.shapeObject_0.HorizontalAlignment = (ShapeHorizontalAlignment) Enum.Parse(typeof(ShapeHorizontalAlignment), A_1);
                        return;

                    case 15:
                        this.shapeObject_0.HorizontalOrigin = (HorizontalOrigin) Enum.Parse(typeof(HorizontalOrigin), A_1);
                        return;

                    case 0x10:
                        this.shapeObject_0.VerticalAlignment = (ShapeVerticalAlignment) Enum.Parse(typeof(ShapeVerticalAlignment), A_1);
                        return;

                    case 0x11:
                        this.shapeObject_0.VerticalOrigin = (VerticalOrigin) Enum.Parse(typeof(VerticalOrigin), A_1);
                        return;

                    case 0x12:
                        this.shapeObject_0.SetShapeAttribute(0x81, int.Parse(A_1));
                        return;

                    case 0x13:
                        this.shapeObject_0.SetShapeAttribute(130, int.Parse(A_1));
                        return;

                    case 20:
                        this.shapeObject_0.SetShapeAttribute(0x83, int.Parse(A_1));
                        return;

                    case 0x15:
                        this.shapeObject_0.SetShapeAttribute(0x84, int.Parse(A_1));
                        return;

                    case 0x16:
                        this.shapeObject_0.CoordOriginX = int.Parse(A_1);
                        return;

                    case 0x17:
                        this.shapeObject_0.CoordOriginY = int.Parse(A_1);
                        return;

                    case 0x18:
                        this.shapeObject_0.SetShapeAttribute(0x101f, int.Parse(A_1) - this.shapeObject_0.CoordOriginX);
                        return;

                    case 0x19:
                        this.shapeObject_0.SetShapeAttribute(0x1020, int.Parse(A_1) - this.shapeObject_0.CoordOriginY);
                        return;

                    case 0x1a:
                        this.shapeObject_0.SetShapeAttribute(0x145, this.method_149(A_1));
                        return;

                    case 0x1b:
                        this.shapeObject_0.SetShapeAttribute(0x146, this.method_150(A_1));
                        return;

                    case 0x1c:
                        this.shapeObject_0.SetShapeAttribute(0x1fb, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 0x1d:
                        this.shapeObject_0.SetShapeAttribute(0x147, int.Parse(A_1));
                        return;

                    case 30:
                        this.shapeObject_0.SetShapeAttribute(0x148, int.Parse(A_1));
                        return;

                    case 0x1f:
                        this.shapeObject_0.SetShapeAttribute(0x149, int.Parse(A_1));
                        return;

                    case 0x20:
                        this.shapeObject_0.SetShapeAttribute(330, int.Parse(A_1));
                        return;

                    case 0x21:
                        this.shapeObject_0.SetShapeAttribute(0x14b, int.Parse(A_1));
                        return;

                    case 0x22:
                        this.shapeObject_0.SetShapeAttribute(0x14c, int.Parse(A_1));
                        return;

                    case 0x23:
                        this.shapeObject_0.SetShapeAttribute(0x14d, int.Parse(A_1));
                        return;

                    case 0x24:
                        this.shapeObject_0.SetShapeAttribute(0x14e, int.Parse(A_1));
                        return;

                    case 0x25:
                        this.shapeObject_0.SetShapeAttribute(0x14f, int.Parse(A_1));
                        return;

                    case 0x26:
                        this.shapeObject_0.SetShapeAttribute(0x150, int.Parse(A_1));
                        return;

                    case 0x27:
                        this.shapeObject_0.SetShapeAttribute(0x1d0, Enum.Parse(typeof(ArrowType), A_1));
                        return;

                    case 40:
                        this.shapeObject_0.SetShapeAttribute(0x1d1, Enum.Parse(typeof(ArrowType), A_1));
                        return;

                    case 0x29:
                        this.shapeObject_0.SetShapeAttribute(0x303, Enum.Parse(typeof(ConnectorType), A_1));
                        return;

                    case 0x2a:
                        this.shapeObject_0.SetShapeAttribute(0x158, Enum.Parse(typeof(ConnectionSiteType), A_1));
                        return;

                    case 0x2b:
                        this.shapeObject_0.SetShapeAttribute(0x1d2, Enum.Parse(typeof(StrokeArrowWidth), A_1));
                        return;

                    case 0x2c:
                        this.shapeObject_0.SetShapeAttribute(0x1d3, Enum.Parse(typeof(StrokeArrowLength), A_1));
                        return;

                    case 0x2d:
                        this.shapeObject_0.SetShapeAttribute(0x1d4, Enum.Parse(typeof(StrokeArrowWidth), A_1));
                        return;

                    case 0x2e:
                        this.shapeObject_0.SetShapeAttribute(0x1d5, Enum.Parse(typeof(StrokeArrowLength), A_1));
                        return;

                    case 0x2f:
                        this.shapeObject_0.SetShapeAttribute(0x1cb, int.Parse(A_1));
                        return;

                    case 0x30:
                        this.shapeObject_0.CoordOriginX = int.Parse(A_1);
                        return;

                    case 0x31:
                        this.shapeObject_0.CoordOriginY = int.Parse(A_1);
                        return;

                    case 50:
                        this.int_26 = int.Parse(A_1);
                        return;

                    case 0x33:
                        this.int_27 = int.Parse(A_1);
                        return;

                    case 0x34:
                        this.shapeObject_0.Left = int.Parse(A_1) / this.shapeGroup_0.NumLevel;
                        return;

                    case 0x35:
                        this.shapeObject_0.Top = int.Parse(A_1) / this.shapeGroup_0.NumLevel;
                        return;

                    case 0x36:
                        this.double_0 = double.Parse(A_1);
                        return;

                    case 0x37:
                        this.double_1 = double.Parse(A_1);
                        return;

                    case 0x38:
                        this.shapeObject_0.SetShapeAttribute(0x87, Enum.Parse(typeof(TextBoxAnchor), A_1));
                        return;

                    case 0x39:
                        this.shapeObject_0.LimoX = int.Parse(A_1);
                        return;

                    case 0x3a:
                        this.shapeObject_0.LimoY = int.Parse(A_1);
                        return;

                    case 0x3b:
                        this.shapeObject_0.BWMode = (BWMode) Enum.Parse(typeof(BWMode), A_1);
                        return;

                    case 60:
                        this.shapeObject_0.BWNormal = (BWMode) Enum.Parse(typeof(BWMode), A_1);
                        return;

                    case 0x3d:
                        this.shapeObject_0.BWPure = (BWMode) Enum.Parse(typeof(BWMode), A_1);
                        return;

                    case 0x3e:
                        this.shapeObject_0.SetShapeAttribute(0x284, int.Parse(A_1));
                        return;

                    case 0x3f:
                        this.shapeObject_0.SetShapeAttribute(0x285, int.Parse(A_1));
                        return;

                    case 0x40:
                        this.shapeObject_0.ExtrusionOn = A_1 != BookmarkStart.b("Դ", num);
                        return;

                    case 0x41:
                        this.shapeObject_0.SetShapeAttribute(720, int.Parse(A_1));
                        return;

                    case 0x42:
                        this.shapeObject_0.Fill.FillType = (FillType) Enum.Parse(typeof(FillType), A_1);
                        return;

                    case 0x43:
                        this.shapeObject_0.Fill.method_0(this.ipicture_0.ImageBytes);
                        return;

                    case 0x44:
                        this.shapeObject_0.FillColor = Class1006.smethod_27(uint.Parse(A_1));
                        return;

                    case 0x45:
                        this.shapeObject_0.Fill.Color2 = Class1006.smethod_27(uint.Parse(A_1));
                        return;

                    case 70:
                        this.shapeObject_0.Fill.Angle = double.Parse(A_1) / 65536.0;
                        return;

                    case 0x47:
                        this.shapeObject_0.Fill.Focus = int.Parse(A_1);
                        return;

                    case 0x48:
                        this.shapeObject_0.Filled = A_1 != BookmarkStart.b("Դ", num);
                        return;

                    case 0x49:
                        this.shapeObject_0.SetShapeAttribute(0x1ba, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 0x4a:
                        this.shapeObject_0.SetShapeAttribute(0x1f7, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 0x4b:
                        this.shapeObject_0.SetShapeAttribute(0x1c0, Class1006.smethod_27(uint.Parse(A_1)));
                        return;

                    case 0x4c:
                        this.shapeObject_0.SetShapeAttribute(0x1fc, A_1 != BookmarkStart.b("Դ", num));
                        return;

                    case 0x4d:
                        this.shapeObject_0.ZOrder = long.Parse(A_1);
                        return;

                    case 0x4e:
                        this.shapeObject_0.AllowInCell = A_1 != BookmarkStart.b("Դ", num);
                        return;

                    case 0x4f:
                        this.shapeObject_0.AllowOverlap = A_1 != BookmarkStart.b("Դ", num);
                        return;

                    case 80:
                        this.shapeObject_0.SetShapeAttribute(0x103b, int.Parse(A_1));
                        return;

                    case 0x51:
                    case 0x52:
                        this.shapeObject_0.SetShapeAttribute(0x338, int.Parse(A_1) != 0);
                        return;

                    case 0x53:
                    case 0x54:
                        this.shapeObject_0.SetShapeAttribute(0x339, int.Parse(A_1) != 0);
                        return;

                    case 0x55:
                        this.shapeObject_0.SetShapeAttribute(0x3b1, int.Parse(A_1) != 0);
                        return;

                    case 0x56:
                    case 0x57:
                        this.shapeObject_0.SetShapeAttribute(4, int.Parse(A_1));
                        return;

                    case 0x58:
                        this.shapeObject_0.SetShapeAttribute(0x380, A_1);
                        return;

                    case 0x59:
                        this.shapeObject_0.SetShapeAttribute(0x383, this.method_149(A_1));
                        return;

                    case 90:
                        this.shapeObject_0.SetShapeAttribute(190, int.Parse(A_1) != 0);
                        return;

                    case 0x5b:
                        this.shapeObject_0.SetShapeAttribute(0xbf, int.Parse(A_1) != 0);
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private Class891[] method_149(string A_0)
    {
        int num = 11;
        string[] strArray = A_0.Trim().Split(new char[] { ';' });
        Class891[] classArray = new Class891[int.Parse(strArray[1])];
        for (int i = 2; i < strArray.Length; i++)
        {
            string str = strArray[i];
            string[] strArray2 = str.Replace(BookmarkStart.b("ᤰ", num), string.Empty).Replace(BookmarkStart.b("ᠰ", num), string.Empty).Split(new char[] { ',' });
            classArray[i - 2] = new Class891(int.Parse(strArray2[0]), int.Parse(strArray2[1]));
        }
        return classArray;
    }

    public Class839 method_15()
    {
        return this.class839_1;
    }

    private Class679[] method_150(string A_0)
    {
        string[] strArray = A_0.Trim().Split(new char[] { ';' });
        int num = spr᜚.ᜆ(strArray[1]);
        Class679[] classArray = new Class679[num];
        for (int i = 0; i < num; i++)
        {
            int num3 = spr᜚.ᜆ(strArray[2 + i]);
            classArray[i] = Class781.smethod_3(num3);
        }
        return classArray;
    }

    private void method_151(string A_0, string A_1, string A_2)
    {
        int num = 12;
        string str = A_1;
        if (str != null)
        {
            if ((str == BookmarkStart.b("䐱儳䐵䰷嬹倻", num)) || (str == BookmarkStart.b("䐱儳䐵䰷嬹倻尽", num)))
            {
                this.class836_0.pageAlignment_0 = PageAlignment.Bottom;
            }
            else if (str == BookmarkStart.b("䐱儳䐵䰷嬹倻䨽", num))
            {
                this.class836_0.pageAlignment_0 = PageAlignment.Top;
            }
            else if (str == BookmarkStart.b("䐱儳䐵䰷嬹倻崽", num))
            {
                this.class836_0.pageAlignment_0 = PageAlignment.Middle;
            }
            else if (str == BookmarkStart.b("䐱儳䐵䰷嬹倻吽", num))
            {
                this.class836_0.pageAlignment_0 = PageAlignment.Justified;
            }
        }
    }

    private void method_152(string A_0, string A_1, string A_2)
    {
        switch (Convert.ToInt32(A_2))
        {
            case 1:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level1;
                return;

            case 2:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level2;
                return;

            case 3:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level3;
                return;

            case 4:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level4;
                return;

            case 5:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level5;
                return;

            case 6:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level6;
                return;

            case 7:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level7;
                return;

            case 8:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level8;
                return;

            case 9:
                this.method_7().Format.OutlineLevel = OutlineLevel.Level9;
                return;
        }
        this.method_7().Format.OutlineLevel = OutlineLevel.Body;
    }

    private BorderStyle method_153(string A_0)
    {
        int num = 1;
        BorderStyle none = BorderStyle.None;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_169 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(20);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮匰弲", num), 0);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬尮", num), 1);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮夰", num), 2);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䬮匰", num), 3);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䬮帰䜲", num), 4);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䬮倰䀲崴䐶吸", num), 5);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䬮倰䀲崴", num), 6);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䬮倰䀲崴匶崸", num), 7);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮弰䜲崴娶常", num), 8);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮弰䜲崴䐶常", num), 9);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮夰䜲嬴䐶常", num), 10);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮弰䜲崴䌶圸䠺娼", num), 11);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮夰䜲嬴娶常", num), 12);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮弰䜲崴䌶圸嘺娼", num), 13);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮弰䜲崴嬶常", num), 14);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬嬮夰䜲嬴嬶常", num), 15);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䨮尰儲娴䐶䨸", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䨮弰吲䜴嘶伸帺", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䄮帰崲倴", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䔦嬨伪弬䄮堰弲", num), 0x13);
                Class1160.dictionary_169 = dictionary1;
            }
            if (Class1160.dictionary_169.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BorderStyle.None;

                    case 1:
                        return BorderStyle.Single;

                    case 2:
                        return BorderStyle.Thick;

                    case 3:
                        return BorderStyle.Double;

                    case 4:
                        return BorderStyle.Dot;

                    case 5:
                        return BorderStyle.DashSmallGap;

                    case 6:
                        return BorderStyle.DashLargeGap;

                    case 7:
                        return BorderStyle.DotDotDash;

                    case 8:
                        return BorderStyle.ThickThinMediumGap;

                    case 9:
                        return BorderStyle.ThickThinSmallGap;

                    case 10:
                        return BorderStyle.ThinThickSmallGap;

                    case 11:
                        return BorderStyle.ThinThickThinSmallGap;

                    case 12:
                        return BorderStyle.ThinThickMediumGap;

                    case 13:
                        return BorderStyle.ThinThickThinMediumGap;

                    case 14:
                        return BorderStyle.ThickThinLargeGap;

                    case 15:
                        return BorderStyle.ThinThickLargeGap;

                    case 0x10:
                        return BorderStyle.Emboss3D;

                    case 0x11:
                        return BorderStyle.Engrave3D;

                    case 0x12:
                    case 0x13:
                        return BorderStyle.Cleared;
                }
            }
        }
        return none;
    }

    private void method_154(Border A_0, string A_1, string A_2)
    {
        int num = 12;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("倱䘳刵䨷䴹", num))
            {
                float num4 = this.method_165(A_2);
                A_0.LineWidth = num4;
                return;
            }
            if (str == BookmarkStart.b("倱䘳䔵䠷", num))
            {
                float num3 = this.method_165(A_2);
                A_0.Space = num3;
                return;
            }
            if (str == BookmarkStart.b("倱䘳刵䨷夹娻", num))
            {
                int key = Convert.ToInt32(A_2);
                if (((key > -1) && (this.dictionary_1.Count > key)) && this.dictionary_1.ContainsKey(key))
                {
                    this.method_18(this.dictionary_1[key]);
                }
                A_0.Color = this.method_17().method_9();
                return;
            }
        }
        A_0.BorderType = this.method_153(A_1);
    }

    private void method_155(string A_0, string A_1)
    {
        if (this.bool_19)
        {
            if (this.bool_3)
            {
                this.method_154(this.method_27().Borders.Bottom, A_0, A_1);
            }
            if (this.bool_4)
            {
                this.method_154(this.method_27().Borders.Left, A_0, A_1);
            }
            if (this.bool_2)
            {
                this.method_154(this.method_27().Borders.Top, A_0, A_1);
            }
            if (this.bool_5)
            {
                this.method_154(this.method_27().Borders.Right, A_0, A_1);
            }
            if (this.bool_7)
            {
                this.method_154(this.method_29().Borders.Horizontal, A_0, A_1);
            }
            if (this.bool_8)
            {
                this.method_154(this.method_29().Borders.Vertical, A_0, A_1);
            }
            if (this.bool_9)
            {
                this.method_154(this.method_29().Borders.Top, A_0, A_1);
            }
            if (this.bool_10)
            {
                this.method_154(this.method_29().Borders.Bottom, A_0, A_1);
            }
            if (this.bool_11)
            {
                this.method_154(this.method_29().Borders.Left, A_0, A_1);
            }
            if (this.bool_12)
            {
                this.method_154(this.method_29().Borders.Right, A_0, A_1);
            }
        }
        else if (this.bool_20)
        {
            if (this.bool_3)
            {
                this.method_154(this.method_10().PageSetup.Borders.Bottom, A_0, A_1);
            }
            if (this.bool_4)
            {
                this.method_154(this.method_10().PageSetup.Borders.Left, A_0, A_1);
            }
            if (this.bool_2)
            {
                this.method_154(this.method_10().PageSetup.Borders.Top, A_0, A_1);
            }
            if (this.bool_5)
            {
                this.method_154(this.method_10().PageSetup.Borders.Right, A_0, A_1);
            }
        }
        else
        {
            if (this.bool_3)
            {
                this.method_154(this.method_7().Format.Borders.Bottom, A_0, A_1);
            }
            if (this.bool_4)
            {
                this.method_154(this.method_7().Format.Borders.Left, A_0, A_1);
            }
            if (this.bool_2)
            {
                this.method_154(this.method_7().Format.Borders.Top, A_0, A_1);
            }
            if (this.bool_5)
            {
                this.method_154(this.method_7().Format.Borders.Right, A_0, A_1);
            }
        }
    }

    private void method_156(string A_0, string A_1, string A_2)
    {
        int num = 0x13;
        string key = A_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_170 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(40);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂㅄ", num), 0);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂ❄", num), 1);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂ⥄", num), 2);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂ㝄", num), 3);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂⵄ", num), 4);
                dictionary1.Add(BookmarkStart.b("䴸䤺弼䴾╀ㅂ㍄", num), 5);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀", num), 6);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾⍀", num), 7);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾ⵀ", num), 8);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㍀", num), 9);
                dictionary1.Add(BookmarkStart.b("嬸吺䔼", num), 10);
                dictionary1.Add(BookmarkStart.b("䤸尺弼䴾╀ㅂ⩄㝆㵈", num), 11);
                dictionary1.Add(BookmarkStart.b("䤸尺弼䴾╀ㅂㅄ", num), 12);
                dictionary1.Add(BookmarkStart.b("䤸尺弼䴾╀ㅂ⥄", num), 13);
                dictionary1.Add(BookmarkStart.b("䤸尺弼䴾╀ㅂ❄", num), 14);
                dictionary1.Add(BookmarkStart.b("䤸尺弼䴾╀ㅂ㝄", num), 15);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀⅂⥄", num), 0x10);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㉀", num), 0x11);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀⭂", num), 0x12);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾╀⅂", num), 0x13);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾╀ⱂㅄ", num), 20);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾╀≂㙄⽆㩈♊", num), 0x15);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾╀≂㙄⽆", num), 0x16);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾╀≂㙄⽆ⵈ⽊", num), 0x17);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆⑈ⱊ", num), 0x18);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆㩈ⱊ", num), 0x19);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀⭂ㅄ⥆㩈ⱊ", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆㵈╊㹌⡎", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀⭂ㅄ⥆⑈ⱊ", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆㵈╊⁌⡎", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆╈ⱊ", num), 30);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀⭂ㅄ⥆╈ⱊ", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㕀ⵂㅄ⽆㵈╊⅌⡎", num), 0x20);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾⑀⹂❄⡆㩈㡊", num), 0x21);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾⑀ⵂ≄㕆⡈㵊⡌", num), 0x22);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾⽀ⱂ⭄≆", num), 0x23);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾⽀⩂⥄", num), 0x24);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾㙀", num), 0x25);
                dictionary1.Add(BookmarkStart.b("嬸䤺丼伾", num), 0x26);
                dictionary1.Add(BookmarkStart.b("嬸䤺夼䴾≀╂", num), 0x27);
                Class1160.dictionary_170 = dictionary1;
            }
            if (Class1160.dictionary_170.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.bool_9 = true;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        return;

                    case 1:
                        this.bool_9 = false;
                        this.bool_10 = true;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        return;

                    case 2:
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = true;
                        this.bool_12 = false;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        return;

                    case 3:
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = true;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        return;

                    case 4:
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = true;
                        this.bool_8 = false;
                        return;

                    case 5:
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        this.bool_5 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_8 = true;
                        this.bool_7 = false;
                        return;

                    case 6:
                        this.bool_2 = true;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_5 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 7:
                        this.bool_3 = true;
                        this.bool_4 = false;
                        this.bool_5 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 8:
                        this.bool_4 = true;
                        this.bool_5 = false;
                        this.bool_2 = false;
                        this.bool_3 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 9:
                        this.bool_5 = true;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_2 = false;
                        this.bool_7 = false;
                        this.bool_8 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 10:
                        this.bool_2 = true;
                        this.bool_3 = true;
                        this.bool_4 = true;
                        this.bool_5 = true;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 11:
                        this.bool_20 = true;
                        if (!(A_2 == BookmarkStart.b("ĸ", num)))
                        {
                            if (A_2 == BookmarkStart.b("ਸऺ", num))
                            {
                                this.method_10().PageSetup.PageBorderOffsetFrom = PageBorderOffsetFrom.PageEdge;
                                this.method_10().PageSetup.IsFrontPageBorder = true;
                                return;
                            }
                            if (!(A_2 == BookmarkStart.b("സ଺", num)))
                            {
                                break;
                            }
                            this.method_10().PageSetup.PageBorderOffsetFrom = PageBorderOffsetFrom.PageEdge;
                            this.method_10().PageSetup.IsFrontPageBorder = false;
                            return;
                        }
                        this.method_10().PageSetup.PageBorderOffsetFrom = PageBorderOffsetFrom.Text;
                        this.method_10().PageSetup.IsFrontPageBorder = false;
                        return;

                    case 12:
                        this.bool_2 = true;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_5 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 13:
                        this.bool_2 = false;
                        this.bool_3 = false;
                        this.bool_4 = true;
                        this.bool_5 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 14:
                        this.bool_2 = false;
                        this.bool_3 = true;
                        this.bool_4 = false;
                        this.bool_5 = false;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 15:
                        this.bool_2 = false;
                        this.bool_3 = false;
                        this.bool_4 = false;
                        this.bool_5 = true;
                        this.bool_9 = false;
                        this.bool_10 = false;
                        this.bool_11 = false;
                        this.bool_12 = false;
                        return;

                    case 0x10:
                    case 0x11:
                    case 0x12:
                    case 0x13:
                    case 20:
                    case 0x15:
                    case 0x16:
                    case 0x17:
                    case 0x18:
                    case 0x19:
                    case 0x1a:
                    case 0x1b:
                    case 0x1c:
                    case 0x1d:
                    case 30:
                    case 0x1f:
                    case 0x20:
                    case 0x21:
                    case 0x22:
                    case 0x23:
                    case 0x24:
                    case 0x25:
                    case 0x26:
                    case 0x27:
                        this.method_155(A_1, A_2);
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_157(TableCell A_0, CellFormat A_1)
    {
        A_0.CellFormat.BackColor = A_1.BackColor;
        A_1.Borders.method_53(A_0.CellFormat.Borders);
        switch (A_1.RtfCellWidthType)
        {
            case WidthType.None:
            case WidthType.Auto:
                if ((this.method_29().LayoutType != LayoutType.Fixed) || (A_1.CellWidth <= 0f))
                {
                    A_0.Width = A_1.CellWidth;
                    A_0.WidthType = FtsWidth.Auto;
                }
                else
                {
                    A_0.Width = A_1.CellWidth;
                    A_0.WidthType = FtsWidth.Point;
                }
                goto Label_00ED;

            case WidthType.Percentage:
                if (!A_1.IsRtfCellwidthCalc)
                {
                    A_0.Scaling = A_1.RtfCellWidth / 50f;
                    break;
                }
                A_0.Scaling = A_1.CellScaling;
                break;

            case WidthType.Twip:
                if (!A_1.IsRtfCellwidthCalc)
                {
                    A_0.Width = A_1.RtfCellWidth / 20f;
                }
                else
                {
                    A_0.Width = A_1.CellWidth;
                }
                A_0.WidthType = FtsWidth.Point;
                goto Label_00ED;

            default:
                goto Label_00ED;
        }
        A_0.WidthType = FtsWidth.Percentage;
    Label_00ED:
        A_0.CellFormat.FitText = A_1.FitText;
        A_0.CellFormat.ForeColor = A_1.ForeColor;
        A_0.CellFormat.IsAutoResized = A_1.IsAutoResized;
        A_0.CellFormat.SamePaddingsAsTable = A_1.SamePaddingsAsTable;
        A_0.CellFormat.Paddings.Bottom = A_1.Paddings.Bottom;
        A_0.CellFormat.Paddings.Right = A_1.Paddings.Right;
        A_0.CellFormat.Paddings.Left = A_1.Paddings.Left;
        A_0.CellFormat.Paddings.Top = A_1.Paddings.Top;
        A_0.CellFormat.TextDirection = A_1.TextDirection;
        A_0.CellFormat.TextWrap = A_1.TextWrap;
        A_0.CellFormat.VerticalAlignment = A_1.VerticalAlignment;
        A_0.CellFormat.VerticalMerge = A_1.VerticalMerge;
        A_0.CellFormat.HorizontalMerge = A_1.HorizontalMerge;
        A_0.CellFormat.TextureStyle = A_1.TextureStyle;
        A_0.CellFormat.Cellx = A_1.Cellx;
    }

    private void method_158(TableRow A_0, RowFormat A_1)
    {
        this.method_159(A_0.RowFormat, A_1);
    }

    private void method_159(RowFormat A_0, RowFormat A_1)
    {
        if (A_1.HasValue(0x67))
        {
            A_0.IsAutoResized = A_1.IsAutoResized;
        }
        if (A_1.HasValue(0x6c))
        {
            A_0.BackColor = A_1.BackColor;
        }
        if (A_1.HasValue(0x111c))
        {
            A_0.Bidi = A_1.Bidi;
        }
        if (A_1.HasValue(0x10c2))
        {
            A_0.CellSpacingEx = A_1.CellSpacingEx;
        }
        A_0.HasCellSpacing = A_1.HasCellSpacing;
        if (A_1.HasValue(0xfaa))
        {
            A_0.HorizontalAlignment = A_1.HorizontalAlignment;
        }
        if (A_1.HasValue(0x1018))
        {
            A_0.Height = A_1.Height;
        }
        if (A_1.HasValue(0x67))
        {
            A_0.IsAutoResized = A_1.IsAutoResized;
        }
        if (A_1.HasValue(0x1108))
        {
            A_0.IsBreakAcrossPages = A_1.IsBreakAcrossPages;
        }
        A_0.LayoutType = A_1.LayoutType;
        if (A_1.HasValue(0x10f4))
        {
            A_0.LeftIndent = A_1.LeftIndent;
        }
        if (A_1.HasValue(110))
        {
            A_0.TextureStyle = A_1.TextureStyle;
        }
        A_0.method_53(A_1.WrapTextAround);
        if (A_1.HasValue(0x6b))
        {
            A_0.RowIndent = A_1.RowIndent;
        }
        A_0.Positioning.TableOverlap = A_1.Positioning.TableOverlap;
        A_0.Positioning.DistanceFromBottom = A_1.Positioning.DistanceFromBottom;
        A_0.Positioning.DistanceFromLeft = A_1.Positioning.DistanceFromLeft;
        A_0.Positioning.DistanceFromRight = A_1.Positioning.DistanceFromRight;
        A_0.Positioning.DistanceFromTop = A_1.Positioning.DistanceFromTop;
        A_0.Positioning.HorizPositionAbs = A_1.Positioning.HorizPositionAbs;
        A_0.Positioning.HorizPositionEx = A_1.Positioning.HorizPositionEx;
        A_0.Positioning.HorizRelationTo = A_1.Positioning.HorizRelationTo;
        A_0.Positioning.VertPositionAbs = A_1.Positioning.VertPositionAbs;
        A_0.Positioning.VertPositionEx = A_1.Positioning.VertPositionEx;
        A_0.Positioning.VertRelationTo = A_1.Positioning.VertRelationTo;
        A_0.LayoutType = A_1.LayoutType;
        this.method_160(A_0.Paddings, A_1.Paddings);
        this.method_161(A_0.Borders.Left, A_1.Borders.Left);
        this.method_161(A_0.Borders.Right, A_1.Borders.Right);
        this.method_161(A_0.Borders.Top, A_1.Borders.Top);
        this.method_161(A_0.Borders.Bottom, A_1.Borders.Bottom);
        this.method_161(A_0.Borders.Horizontal, A_1.Borders.Horizontal);
        this.method_161(A_0.Borders.Vertical, A_1.Borders.Vertical);
        A_0.GridAfterWidth = A_1.GridAfterWidth;
        A_0.GridBeforeWidth = A_1.GridBeforeWidth;
        A_0.TablePreferredWidthInfo = A_1.TablePreferredWidthInfo;
    }

    public void method_16(Class839 A_0)
    {
        this.class839_1 = A_0;
        if (this.class839_1.method_0() >= 0)
        {
            this.method_110(this.class839_1.method_0());
        }
    }

    private void method_160(Paddings A_0, Paddings A_1)
    {
        A_0.Left = A_1.Left;
        A_0.Right = A_1.Right;
        A_0.Top = A_1.Top;
        A_0.Bottom = A_1.Bottom;
    }

    private void method_161(Border A_0, Border A_1)
    {
        A_0.BorderType = A_1.BorderType;
        A_0.Color = A_1.Color;
        A_0.LineWidth = A_1.LineWidth;
    }

    private void method_162(IParagraph A_0)
    {
        if (this.dictionary_9.Count > 0)
        {
            foreach (KeyValuePair<int, Class842> pair in this.dictionary_9)
            {
                float introduced4 = pair.Value.method_0();
                TabJustification introduced5 = pair.Value.method_2();
                if (!A_0.Format.Tabs.method_7(introduced4, introduced5, pair.Value.method_4()))
                {
                    float position = pair.Value.method_0();
                    TabJustification justification = pair.Value.method_2();
                    A_0.Format.Tabs.AddTab(position, justification, pair.Value.method_4());
                }
            }
        }
        if (this.isection_0 == null)
        {
            this.method_10().PageSetup.EqualColumnWidth = true;
            this.body_0 = this.isection_0.Body;
        }
        if (this.body_0 == null)
        {
            this.body_0 = this.isection_0.Body;
        }
        this.body_0.Items.Add(A_0);
        this.int_12 = this.int_13;
        this.paragraphFormat_0 = A_0.Format;
        this.method_169(A_0.BreakCharacterFormat, this.class835_0);
        if (this.list_0.Count > 0)
        {
            foreach (Paragraph paragraph in this.list_0)
            {
                this.body_0.Items.Add(paragraph);
                this.method_169(paragraph.BreakCharacterFormat, this.class835_0);
            }
            this.list_0.Clear();
        }
        this.iparagraph_0 = null;
    }

    private void method_163(IParagraph A_0)
    {
        if ((A_0 != null) && this.bool_40)
        {
            this.bool_40 = false;
            if ((A_0.Format.HorizontalAlignment != HorizontalAlignment.Left) && !A_0.Format.HasKey(0x3fc))
            {
                A_0.Format.HorizontalAlignment = HorizontalAlignment.Left;
            }
            if ((A_0.Format.LeftIndent != 0f) && !A_0.Format.HasKey(0x488))
            {
                A_0.Format.LeftIndent = 0f;
            }
            if ((A_0.Format.RightIndent != 0f) && !A_0.Format.HasKey(0x47e))
            {
                A_0.Format.RightIndent = 0f;
            }
            if ((A_0.Format.FirstLineIndent != 0f) && !A_0.Format.HasKey(0x492))
            {
                A_0.Format.FirstLineIndent = 0f;
            }
            if ((A_0.Format.AfterSpacing != 0f) && !A_0.Format.HasKey(0x4c4))
            {
                A_0.Format.AfterSpacing = 0f;
            }
            if ((A_0.Format.BeforeSpacing != 0f) && !A_0.Format.HasKey(0x4b0))
            {
                A_0.Format.BeforeSpacing = 0f;
            }
            if (A_0.Format.AfterAutoSpacing && !A_0.Format.HasKey(0x4ce))
            {
                A_0.Format.AfterAutoSpacing = false;
            }
            if (A_0.Format.BeforeAutoSpacing && !A_0.Format.HasKey(0x4ba))
            {
                A_0.Format.BeforeAutoSpacing = false;
            }
            if (A_0.Format.KeepLines && !A_0.Format.HasKey(0x410))
            {
                A_0.Format.KeepLines = false;
            }
            if (A_0.Format.HasValue(0x677) && !A_0.Format.HasKey(0x677))
            {
                A_0.Format.LineSpacingRule = LineSpacingRule.Multiple;
                A_0.Format.LineSpacing = 12f;
            }
            else if (A_0.Format.HasValue(0x672) && !A_0.Format.HasKey(0x672))
            {
                A_0.Format.LineSpacingRule = LineSpacingRule.Multiple;
                A_0.Format.LineSpacing = 12f;
            }
        }
    }

    private void method_164(ISection A_0)
    {
        this.document_0.ChildObjects.Add(A_0);
        this.body_0 = this.document_0.LastSection.Body;
    }

    private float method_165(string A_0)
    {
        return Convert.ToSingle((float) (((float) Convert.ToInt32(A_0)) / 20f));
    }

    private string[] method_166(string A_0)
    {
        string[] strArray = new string[3];
        bool flag = false;
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (!char.IsDigit(c) && !this.method_167(A_0, i))
            {
                if (!flag)
                {
                    string[] strArray3;
                    (strArray3 = strArray)[0] = strArray3[0] + c;
                }
                else
                {
                    string[] strArray2;
                    (strArray2 = strArray)[2] = strArray2[2] + c;
                }
            }
            else
            {
                string[] strArray4;
                (strArray4 = strArray)[1] = strArray4[1] + c;
                flag = true;
            }
        }
        return strArray;
    }

    private bool method_167(string A_0, int A_1)
    {
        char ch = A_0[A_1];
        return (((ch == '-') && (A_1 < (A_0.Length - 1))) && char.IsDigit(A_0[A_1 + 1]));
    }

    private void method_168(IParagraph A_0)
    {
        A_0.BreakCharacterFormat.ClearFormatting();
        if (this.class835_0.float_0 > 0f)
        {
            A_0.BreakCharacterFormat.FontSize = this.class835_0.float_0;
        }
        if (this.class835_0.bool_3)
        {
            A_0.BreakCharacterFormat.method_55(Class843.smethod_0(this.class835_0.class843_0));
        }
        if (this.class835_0.string_0.Length > 0)
        {
            A_0.BreakCharacterFormat.FontName = this.class835_0.string_0;
        }
        if (this.class835_0.threeState_0 == ThreeState.True)
        {
            A_0.BreakCharacterFormat.Bold = true;
        }
        if (this.class835_0.threeState_1 == ThreeState.True)
        {
            A_0.BreakCharacterFormat.Italic = true;
        }
        if (this.class835_0.threeState_2 == ThreeState.True)
        {
            A_0.BreakCharacterFormat.UnderlineStyle = UnderlineStyle.Single;
        }
        if (this.class835_0.threeState_4 == ThreeState.True)
        {
            A_0.BreakCharacterFormat.AllCaps = true;
        }
        if (this.class835_0.threeState_5 == ThreeState.True)
        {
            A_0.BreakCharacterFormat.IsSmallCaps = true;
        }
        if (this.class835_0.bool_4)
        {
            A_0.BreakCharacterFormat.TextBackgroundColor = Class843.smethod_0(this.class835_0.class843_1);
        }
        if (this.class835_0.bool_5)
        {
            A_0.BreakCharacterFormat.HighlightColor = Class843.smethod_0(this.class835_0.class843_2);
        }
    }

    private void method_169(CharacterFormat A_0, Class835 A_1)
    {
        int num = 11;
        if (A_1.float_0 > 0f)
        {
            A_0.FontSize = A_1.float_0;
            if (A_1.threeState_6 == ThreeState.True)
            {
                A_0.FontSizeBidi = A_1.float_0;
            }
        }
        if (A_1.bool_3)
        {
            A_0.method_55(Class843.smethod_0(A_1.class843_0));
        }
        if (A_1.bool_4)
        {
            A_0.TextBackgroundColor = Class843.smethod_0(A_1.class843_1);
        }
        if (A_1.bool_5)
        {
            A_0.HighlightColor = Class843.smethod_0(A_1.class843_2);
        }
        if (!string.IsNullOrEmpty(A_1.string_0))
        {
            if (A_1.string_0.Contains(BookmarkStart.b("ᤰ", num)) && A_1.string_0.Contains(BookmarkStart.b("ᠰ", num)))
            {
                string[] strArray = A_1.string_0.Replace('(', '|').Replace(BookmarkStart.b("ᠰ", num), string.Empty).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray.Length > 1)
                {
                    A_0.FontName = strArray[0].Trim();
                    if (A_1.threeState_6 == ThreeState.True)
                    {
                        A_0.LocaleIdBi = this.method_174(strArray[1].Trim());
                    }
                    else
                    {
                        A_0.LocaleIdASCII = this.method_174(strArray[1].Trim());
                    }
                }
                else
                {
                    A_0.FontName = A_1.string_0;
                }
            }
            else
            {
                A_0.FontName = A_1.string_0;
            }
            if ((A_1.string_0 == BookmarkStart.b("簰尲嬴堶䴸䈺䴼娾慀B⩄㕆㩈≊㭌⹎", num)) || (A_1.string_0 == BookmarkStart.b("猰䄲䀴䐶儸ᬺ渼尾㍀⩂㕄㍆楈ي᥌", num)))
            {
                A_0.Italic = true;
            }
        }
        if (A_1.int_1 != -2147483648)
        {
            if (A_1.threeState_6 == ThreeState.True)
            {
                A_0.LocaleIdBi = (short) A_1.int_1;
            }
            else
            {
                A_0.LocaleIdASCII = (short) A_1.int_1;
            }
        }
        if (A_1.threeState_0 != ThreeState.Unknown)
        {
            if (A_1.threeState_0 == ThreeState.True)
            {
                A_0.Bold = true;
            }
            else
            {
                A_0.Bold = false;
            }
        }
        if (A_1.threeState_1 != ThreeState.Unknown)
        {
            if (A_1.threeState_1 == ThreeState.True)
            {
                A_0.Italic = true;
            }
            else
            {
                A_0.Italic = false;
            }
        }
        if (A_1.threeState_4 != ThreeState.Unknown)
        {
            if (A_1.threeState_4 == ThreeState.True)
            {
                A_0.AllCaps = true;
            }
            else
            {
                A_0.AllCaps = false;
            }
        }
        if (A_1.threeState_5 != ThreeState.Unknown)
        {
            if (A_1.threeState_5 == ThreeState.True)
            {
                A_0.IsSmallCaps = true;
            }
            else
            {
                A_0.IsSmallCaps = false;
            }
        }
        if (A_1.threeState_2 == ThreeState.True)
        {
            if (A_1.underlineStyle_0 != UnderlineStyle.None)
            {
                A_0.UnderlineStyle = A_1.underlineStyle_0;
            }
            else
            {
                A_0.UnderlineStyle = UnderlineStyle.Single;
            }
        }
        else
        {
            A_0.UnderlineStyle = UnderlineStyle.None;
        }
        if (A_1.threeState_3 != ThreeState.Unknown)
        {
            if (A_1.threeState_3 == ThreeState.True)
            {
                A_0.IsStrikeout = true;
            }
            else
            {
                A_0.IsStrikeout = false;
            }
        }
        if (A_1.threeState_6 != ThreeState.Unknown)
        {
            if (A_1.threeState_6 == ThreeState.True)
            {
                A_0.Bidi = true;
            }
            else
            {
                A_0.Bidi = false;
            }
        }
        if (A_1.bool_6 != A_0.IsShadow)
        {
            A_0.IsShadow = A_1.bool_6;
        }
        if (A_1.bool_7 != A_0.Hidden)
        {
            A_0.Hidden = true;
        }
        if (A_1.subSuperScript_0 != SubSuperScript.None)
        {
            A_0.SubSuperScript = A_1.subSuperScript_0;
        }
        if (A_1.float_7 != float.MaxValue)
        {
            A_0.CharacterSpacing = A_1.float_7;
        }
        if (A_1.float_8 != float.MaxValue)
        {
            A_0.Position = A_1.float_8;
        }
        A_0.TextScale = A_1.short_0;
        if (A_1.bool_8)
        {
            A_0.IsInsertRevision = A_1.bool_8;
            A_0.InsertRevision = new Class579(EditRevisionType.Insertion);
            A_0.InsertRevision.method_1(A_1.string_1);
            if (A_1.dateTime_0 != DateTime.MinValue)
            {
                A_0.InsertRevision.method_3(A_1.dateTime_0);
            }
        }
        else if (A_1.bool_9)
        {
            A_0.IsDeleteRevision = A_1.bool_9;
            A_0.DeleteRevision = new Class579(EditRevisionType.Deletion);
            A_0.DeleteRevision.method_1(A_1.string_1);
            if (A_1.dateTime_0 != DateTime.MinValue)
            {
                A_0.DeleteRevision.method_3(A_1.dateTime_0);
            }
        }
    }

    public Class843 method_17()
    {
        if (this.class843_0 == null)
        {
            this.class843_0 = new Class843();
        }
        return this.class843_0;
    }

    private void method_170(ShapeBase A_0, Class837 A_1)
    {
        A_1.method_5((float) A_0.Width);
        A_1.method_1((float) A_0.Height);
        A_1.method_3(100f);
        A_1.method_7(100f);
        A_1.verticalOrigin_0 = A_0.VerticalOrigin;
        A_1.horizontalOrigin_0 = A_0.HorizontalOrigin;
        A_1.shapeHorizontalAlignment_0 = A_0.HorizontalAlignment;
        A_1.shapeVerticalAlignment_0 = A_0.VerticalAlignment;
        A_1.float_5 = (this.shapeGroup_0 != null) ? ((float) (A_0.Top / 20.0)) : ((float) A_0.Top);
        A_1.float_4 = (this.shapeGroup_0 != null) ? ((float) ((A_0.Left / 20.0) + this.shapeGroup_0.Left)) : ((float) A_0.Left);
        A_1.textWrappingStyle_0 = (TextWrappingStyle) A_0.GetShapeAttribute(0x1001);
        A_1.bool_0 = A_0.BehindText;
        A_1.textWrappingType_0 = A_0.TextWrappingType;
        A_1.long_0 = A_0.ZOrder;
    }

    private void method_171(ShapeBase A_0, TextBoxFormat A_1)
    {
        if (this.shapeObject_0.TextBoxInernalMarginTop != float.MaxValue)
        {
            A_1.InternalMargin.Top = this.shapeObject_0.TextBoxInernalMarginTop;
        }
        if (this.shapeObject_0.TextBoxInernalMarginRight != float.MaxValue)
        {
            A_1.InternalMargin.Right = this.shapeObject_0.TextBoxInernalMarginRight;
        }
        if (this.shapeObject_0.TextBoxInernalMarginBottom != float.MaxValue)
        {
            A_1.InternalMargin.Bottom = this.shapeObject_0.TextBoxInernalMarginBottom;
        }
        if (this.shapeObject_0.TextBoxInernalMarginLeft != float.MaxValue)
        {
            A_1.InternalMargin.Left = this.shapeObject_0.TextBoxInernalMarginLeft;
        }
        A_1.Width = (float) A_0.Width;
        A_1.Height = (float) A_0.Height;
        A_1.VerticalAlignment = A_0.VerticalAlignment;
        A_1.HorizontalAlignment = A_0.HorizontalAlignment;
        A_1.HorizontalOrigin = A_0.HorizontalOrigin;
        A_1.VerticalOrigin = A_0.VerticalOrigin;
        A_1.VerticalPosition = (this.shapeGroup_0 != null) ? ((float) (A_0.Top / 20.0)) : ((float) A_0.Top);
        A_1.HorizontalPosition = (this.shapeGroup_0 != null) ? ((float) ((A_0.Left / 20.0) + this.shapeGroup_0.Left)) : ((float) A_0.Left);
        A_1.TextWrappingStyle = (TextWrappingStyle) A_0.GetShapeAttribute(0x1001);
        A_1.IsBelowText = A_0.BehindText;
        A_1.TextWrappingType = A_0.TextWrappingType;
        A_1.OrderIndex = A_0.ZOrder;
        A_1.LayoutFlowAlt = (A_0 as ShapeObject).method_72(A_0.LayoutFlow);
        A_1.NoLine = !((bool) this.shapeObject_0.GetShapeAttribute(0x1fc));
        A_1.LineColor = (Color) this.shapeObject_0.GetShapeAttribute(0x1c0);
        A_1.LineWidth = this.shapeObject_0.LineWidth;
        A_1.LineStyle = (TextBoxLineStyle) this.shapeObject_0.GetShapeAttribute(0x1cd);
        A_1.LineDashing = (LineDashing) this.shapeObject_0.GetShapeAttribute(0x1ce);
    }

    private VerticalOrigin method_172(RelativeVerticalPosition A_0)
    {
        switch (A_0)
        {
            case RelativeVerticalPosition.Margin:
                return VerticalOrigin.Margin;

            case RelativeVerticalPosition.Page:
                return VerticalOrigin.Page;

            case RelativeVerticalPosition.Paragraph:
                return VerticalOrigin.Paragraph;

            case RelativeVerticalPosition.Line:
                return VerticalOrigin.Line;

            case RelativeVerticalPosition.TopMargin:
                return VerticalOrigin.TopMarginArea;

            case RelativeVerticalPosition.BottomMargin:
                return VerticalOrigin.BottomMarginArea;

            case RelativeVerticalPosition.InsideMargin:
                return VerticalOrigin.InnerMarginArea;

            case RelativeVerticalPosition.OutsideMargin:
                return VerticalOrigin.OuterMarginArea;
        }
        return VerticalOrigin.Margin;
    }

    private HorizontalOrigin method_173(RelativeHorizontalPosition A_0)
    {
        switch (A_0)
        {
            case RelativeHorizontalPosition.Margin:
                return HorizontalOrigin.Margin;

            case RelativeHorizontalPosition.Page:
                return HorizontalOrigin.Page;

            case RelativeHorizontalPosition.Column:
                return HorizontalOrigin.Column;

            case RelativeHorizontalPosition.Character:
                return HorizontalOrigin.Character;

            case RelativeHorizontalPosition.LeftMargin:
                return HorizontalOrigin.LeftMarginArea;

            case RelativeHorizontalPosition.RightMargin:
                return HorizontalOrigin.RightMarginArea;

            case RelativeHorizontalPosition.InsideMargin:
                return HorizontalOrigin.InnerMarginArea;

            case RelativeHorizontalPosition.OutsideMargin:
                return HorizontalOrigin.OuterMarginArea;
        }
        return HorizontalOrigin.Margin;
    }

    private short method_174(string A_0)
    {
        int num = 8;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_171 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x20);
                dictionary1.Add(BookmarkStart.b("漭䈯匱嘳張嬷ᨹᄻḽጿ⍁ㅃ≅ⅇ橉ോ㱍ㅏけ㵓㝕", num), 0);
                dictionary1.Add(BookmarkStart.b("氭䔯帱匳圵䨷匹崻倽", num), 1);
                dictionary1.Add(BookmarkStart.b("洭儯䘱唳娵夷吹", num), 2);
                dictionary1.Add(BookmarkStart.b("洭堯嬱娳匵䬷弹᰻ጽ怿ᙁ╃⽅㽇⭉≋", num), 3);
                dictionary1.Add(BookmarkStart.b("洭䨯圱圳帵", num), 4);
                dictionary1.Add(BookmarkStart.b("樭儯就崳䔵倷", num), 5);
                dictionary1.Add(BookmarkStart.b("椭唯䀱夳圵嘷", num), 6);
                dictionary1.Add(BookmarkStart.b("椭䈯圱儳崵", num), 7);
                dictionary1.Add(BookmarkStart.b("欭帯唱堳張䬷刹᰻ጽ怿ᝁ⩃⽅㱇⽉⡋湍͏♑㕓≕㵗⥙", num), 8);
                dictionary1.Add(BookmarkStart.b("紭䀯匱娳張䬷刹᰻ጽ怿ᅁ㑃❅ⅇ⑉", num), 9);
                dictionary1.Add(BookmarkStart.b("栭夯就娳張䬷刹", num), 10);
                dictionary1.Add(BookmarkStart.b("栭䈯圱娳唵倷ᨹᄻḽؿぁ╃⡅⭇⽉", num), 11);
                dictionary1.Add(BookmarkStart.b("昭唯倱䘳匵伷", num), 12);
                dictionary1.Add(BookmarkStart.b("昭䔯就匳圵䨷匹崻倽", num), 13);
                dictionary1.Add(BookmarkStart.b("札匯圱堳圵嘷帹唻崽", num), 14);
                dictionary1.Add(BookmarkStart.b("札䐯匱堳張夷吹᰻ጽ怿ୁぃ❅⑇㍉汋", num), 15);
                dictionary1.Add(BookmarkStart.b("搭儯䈱唳堵崷䤹夻", num), 0x10);
                dictionary1.Add(BookmarkStart.b("攭弯䀱儳圵嘷", num), 0x11);
                dictionary1.Add(BookmarkStart.b("樭䔯䘱圳帵ᠷ᜹᰻瀽┿㙁ⱃ⍅㩇♉ⵋ⁍㑏⅑", num), 0x12);
                dictionary1.Add(BookmarkStart.b("怭弯䀱䌳匵強匹崻倽", num), 0x13);
                dictionary1.Add(BookmarkStart.b("縭弯帱崳䔵倷", num), 20);
                dictionary1.Add(BookmarkStart.b("縭弯䀱䀳䌵強伹夻䴽┿扁楃晅ੇ㡉ⵋ㑍㥏㹑", num), 0x15);
                dictionary1.Add(BookmarkStart.b("簭堯匱儳䈵圷᜹渻儽ⴿ⍁⩃⽅⭇", num), 0x16);
                dictionary1.Add(BookmarkStart.b("簭弯弱唳堵儷嬹刻", num), 0x17);
                dictionary1.Add(BookmarkStart.b("簭䔯䄱䜳張夷吹", num), 0x18);
                dictionary1.Add(BookmarkStart.b("洭䈯崱唳䈵儷嬹刻", num), 0x19);
                dictionary1.Add(BookmarkStart.b("紭尯崱䈳圵匷", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("漭尯倱唳堵儷嬹刻ḽ洿扁Ճ⩅⩇⭉≋❍ㅏ", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("紭䜯圱倳張䬷刹", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("稭堯匱崳", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("稭䔯䀱弳張䬷刹", num), 30);
                dictionary1.Add(BookmarkStart.b("笭䈯嘱䄳ᘵᔷᨹ氻弽⬿⭁㝃㉅⥇⑉", num), 0x1f);
                Class1160.dictionary_171 = dictionary1;
            }
            if (Class1160.dictionary_171.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return 0x401;

                    case 1:
                        return 0x402;

                    case 2:
                        return 0x403;

                    case 3:
                        return 0x404;

                    case 4:
                        return 0x405;

                    case 5:
                        return 0x406;

                    case 6:
                        return 0x407;

                    case 7:
                        return 0x408;

                    case 8:
                        return 0x409;

                    case 9:
                        return 0x40a;

                    case 10:
                        return 0x40b;

                    case 11:
                        return 0x40c;

                    case 12:
                        return 0x40d;

                    case 13:
                        return 0x40e;

                    case 14:
                        return 0x40f;

                    case 15:
                        return 0x410;

                    case 0x10:
                        return 0x411;

                    case 0x11:
                        return 0x412;

                    case 0x12:
                        return 0x413;

                    case 0x13:
                        return 0x414;

                    case 20:
                        return 0x415;

                    case 0x15:
                        return 0x416;

                    case 0x16:
                        return 0x417;

                    case 0x17:
                        return 0x418;

                    case 0x18:
                        return 0x419;

                    case 0x19:
                        return 0x41a;

                    case 0x1a:
                        return 0x41b;

                    case 0x1b:
                        return 0x41c;

                    case 0x1c:
                        return 0x41d;

                    case 0x1d:
                        return 0x41e;

                    case 30:
                        return 0x41f;

                    case 0x1f:
                        return 0x420;
                }
            }
        }
        return 0x409;
    }

    private Class835 method_175()
    {
        Class835 class2 = new Class835();
        if (this.class839_0 != null)
        {
            class2.string_0 = this.class839_0.method_6();
        }
        return class2;
    }

    private Class835 method_176()
    {
        Class835 class2 = this.method_175();
        if (this.class835_2 != null)
        {
            this.method_137(this.class835_2, class2);
        }
        return class2;
    }

    private void method_177(Class839 A_0)
    {
        this.class835_0.string_0 = A_0.method_6();
    }

    private void method_178(Class843 A_0)
    {
        this.class835_0.class843_0 = A_0;
        this.class835_0.bool_3 = true;
    }

    public void method_18(Class843 A_0)
    {
        this.class843_0 = A_0;
    }

    public ITable method_19()
    {
        return this.itable_0;
    }

    internal string method_2()
    {
        if (this.class564_0 != null)
        {
            this.string_29 = this.class564_0.method_8();
        }
        return this.string_29;
    }

    public void method_20(ITable A_0)
    {
        this.itable_0 = A_0;
    }

    public RtfTableType method_21()
    {
        return this.rtfTableType_0;
    }

    public void method_22(RtfTableType A_0)
    {
        this.rtfTableType_0 = A_0;
        if (this.class564_0 != null)
        {
            this.class564_0.method_4(A_0);
        }
    }

    public TableRow method_23()
    {
        return this.tableRow_0;
    }

    public void method_24(TableRow A_0)
    {
        this.tableRow_0 = A_0;
    }

    public TableCell method_25()
    {
        return this.tableCell_0;
    }

    public void method_26(TableCell A_0)
    {
        this.tableCell_0 = A_0;
    }

    public CellFormat method_27()
    {
        return this.cellFormat_0;
    }

    public void method_28(CellFormat A_0)
    {
        this.cellFormat_0 = A_0;
    }

    internal RowFormat method_29()
    {
        if (this.rowFormat_0 == null)
        {
            this.rowFormat_0 = new RowFormat();
            this.rowFormat_0.Paddings.All = 0f;
            this.rowFormat_0.LayoutType = LayoutType.Fixed;
            this.rowFormat_0.method_0(this.document_0);
        }
        return this.rowFormat_0;
    }

    internal string method_3()
    {
        if (this.class564_0 != null)
        {
            this.string_29 = this.class564_0.method_9();
        }
        return this.string_29;
    }

    internal void method_30(RowFormat A_0)
    {
        this.rowFormat_0 = A_0;
    }

    internal Class842 method_31()
    {
        if (this.class842_0 == null)
        {
            this.class842_0 = new Class842();
        }
        return this.class842_0;
    }

    internal void method_32(Class842 A_0)
    {
        this.class842_0 = A_0;
    }

    internal Dictionary<string, object> method_33()
    {
        if (this.stack_26.Count > 0)
        {
            return this.stack_26.Peek();
        }
        return new Dictionary<string, object>();
    }

    private Dictionary<string, string> method_34()
    {
        if (this.dictionary_3 == null)
        {
            this.dictionary_3 = new Dictionary<string, string>();
        }
        return this.dictionary_3;
    }

    private Paddings method_35()
    {
        if (this.paddings_0 == null)
        {
            this.paddings_0 = new Paddings();
        }
        return this.paddings_0;
    }

    private Encoding method_36(Stream A_0)
    {
        int num = 3;
        Encoding encoding = Encoding.GetEncoding(0x4e4);
        if (A_0 != null)
        {
            byte[] buffer = new byte[50];
            int count = (A_0.Length > 50L) ? 50 : ((int) A_0.Length);
            A_0.Read(buffer, 0, count);
            string str2 = Encoding.Default.GetString(buffer).ToLower();
            int index = str2.IndexOf(BookmarkStart.b("嬨弪䬬Ḯ", num));
            if (index > -1)
            {
                string str = str2.Substring(index + 5, 5);
                if (str.Contains(BookmarkStart.b("用", num)))
                {
                    if (str.StartsWith(BookmarkStart.b("䐨䨪丬", num)))
                    {
                        encoding = Encoding.GetEncoding(0x2710);
                    }
                    else if (str.StartsWith(BookmarkStart.b("夨䠪", num)))
                    {
                        encoding = Encoding.GetEncoding(0x1b5);
                    }
                    else if (str.StartsWith(BookmarkStart.b("夨䠪䰬", num)))
                    {
                        encoding = Encoding.GetEncoding(850);
                    }
                }
            }
            buffer = null;
            str2 = string.Empty;
        }
        return encoding;
    }

    private void method_37(Document A_0, Class1084 A_1)
    {
        this.class564_0 = new Class564(A_1);
        this.document_0 = A_0;
        this.method_40();
        this.class835_0 = this.method_175();
        this.class836_0 = new Class836();
        this.method_110(0x4e4);
        this.int_28 = 0;
        this.method_20(null);
        this.tableRow_0 = null;
        this.tableCell_0 = null;
        this.dictionary_8 = null;
    }

    private void method_38(ISection A_0)
    {
        if (A_0 != null)
        {
            A_0.PageSetup.Margins = new MarginsF(90f, 72f, 90f, 72f);
            A_0.PageSetup.HeaderDistance = 36f;
            A_0.PageSetup.FooterDistance = 36f;
            A_0.PageSetup.PageSize = new SizeF(612f, 792f);
        }
    }

    private void method_39(ISection A_0, ISection A_1)
    {
        if (A_1 == null)
        {
            this.method_38(A_0);
        }
        else if ((A_0 is Section) && (A_1 is Section))
        {
            A_0.PageSetup.Margins = A_1.PageSetup.Margins;
            A_0.PageSetup.HeaderDistance = A_1.PageSetup.HeaderDistance;
            A_0.PageSetup.FooterDistance = A_1.PageSetup.FooterDistance;
            A_0.PageSetup.PageSize = A_1.PageSetup.PageSize;
        }
    }

    public int method_4()
    {
        return this.int_13;
    }

    private void method_40()
    {
        this.document_0.Settings.method_5().method_150();
    }

    public void method_41()
    {
        int num = 14;
        this.document_0.bool_3 = true;
        this.document_0.Settings.bool_41 = true;
        this.document_0.Settings.characterSpacing_0 = CharacterSpacing.compressPunctuation;
        this.string_8 = this.class564_0.method_10();
        while ((this.stack_37 == null) || ((this.stack_37 != null) && (this.stack_37.Count > 0)))
        {
            if (this.class564_0.method_7().method_1() && ((!this.class564_0.method_7().method_1() || string.IsNullOrEmpty(this.string_8.Trim())) || (this.string_8.Contains(BookmarkStart.b("㐳", num)) || !(this.string_8 != this.string_12))))
            {
                break;
            }
            if (this.string_8 == BookmarkStart.b("伳", num))
            {
                this.rtfTokenType_0 = RtfTokenType.GroupStart;
                this.method_49();
            }
            else if (this.string_8 == BookmarkStart.b("䤳", num))
            {
                this.rtfTokenType_0 = RtfTokenType.GroupEnd;
                this.method_50();
            }
            else if (this.string_8 == BookmarkStart.b("༳", num))
            {
                if (this.bool_30)
                {
                    if (this.method_21() == RtfTableType.ListTable)
                    {
                        this.method_97();
                    }
                    else if (this.method_21() == RtfTableType.ListOverrideTable)
                    {
                        if (!this.method_34().ContainsKey(this.string_16))
                        {
                            this.class12_0 = new Class12(this.document_0);
                            this.method_166(this.string_16);
                            this.class12_0.Name = BookmarkStart.b("砳倵圷椹䠻䜽ⰿ❁ᭃ", num) + Guid.NewGuid();
                            this.method_34().Add(this.string_16, this.class12_0.Name);
                            this.document_0.ListOverrides.method_34(this.class12_0);
                            this.class12_0.method_25(this.document_0.ListStyles.ListStyleNames.Count);
                        }
                        else
                        {
                            this.class12_0 = this.document_0.ListOverrides.method_35(this.method_34()[this.string_16]);
                        }
                        this.class12_0.method_23().method_9(this.int_8, this.method_98());
                        this.int_8++;
                    }
                    this.bool_30 = false;
                }
                this.rtfTokenType_0 = RtfTokenType.Unknown;
                this.class564_0.method_6(RtfTokenType.Unknown);
                if (this.method_21() == RtfTableType.ColorTable)
                {
                    if (this.string_10 == BookmarkStart.b("嘳娵䴷弹", num))
                    {
                        this.method_44();
                    }
                    if (this.string_9 == BookmarkStart.b("圳夵吷唹主䨽∿⹁", num))
                    {
                        this.method_44();
                    }
                }
                else if (this.method_21() == RtfTableType.FontTable)
                {
                    this.method_43();
                }
                else if (this.method_21() == RtfTableType.StyleSheet)
                {
                    this.method_45();
                }
                else
                {
                    this.method_57(this.string_8);
                }
            }
            else if (this.string_8.StartsWith(BookmarkStart.b("栳", num)) && ((this.string_8 != BookmarkStart.b("栳䈵夷堹", num)) || !this.bool_41))
            {
                this.rtfTokenType_0 = RtfTokenType.ControlWord;
                this.method_47();
            }
            else if (((this.string_8 != BookmarkStart.b("㤳", num)) && (this.string_8 != BookmarkStart.b("㸳", num))) && (this.string_8 != string.Empty))
            {
                if (((this.string_12 == BookmarkStart.b("䐳圵䨷", num)) || (this.string_12 == BookmarkStart.b("䀳圵娷", num))) && (this.string_8.StartsWith(BookmarkStart.b("ᐳ", num)) && (this.string_8.Length > 1)))
                {
                    this.string_8 = this.string_8.Substring(1);
                }
                this.method_57(this.string_8);
            }
            else
            {
                this.rtfTokenType_0 = RtfTokenType.Unknown;
                this.class564_0.method_6(RtfTokenType.Text);
            }
            if (((this.string_8 != null) && (this.string_8 != BookmarkStart.b("㤳", num))) && (this.string_8 != BookmarkStart.b("㸳", num)))
            {
                this.string_12 = this.string_8;
            }
            if (((this.string_8 != null) && (this.rtfTokenType_0 == RtfTokenType.ControlWord)) && !string.IsNullOrEmpty(this.string_8))
            {
                this.string_9 = this.string_8;
            }
            this.string_8 = this.class564_0.method_10();
            if (this.string_8.Contains(BookmarkStart.b("栳倵圷䠹儻堽⤿❁⡃≅", num)))
            {
                this.class838_0 = new Class838();
            }
            if (!this.bool_59 && ((((this.string_8 == BookmarkStart.b("栳尵䠷弹嬻尽ⰿ⭁㑃", num)) || this.string_8.StartsWith(BookmarkStart.b("栳䄵唷弹䠻弽☿⭁⡃⍅", num))) || ((this.string_8 == BookmarkStart.b("栳吵吷匹䰻䬽⤿♁", num)) || this.string_8.StartsWith(BookmarkStart.b("栳䘵嘷崹帻刽⤿㉁", num)))) || (((this.string_8 == BookmarkStart.b("栳匵唷尹帻刽⤿㉁", num)) || (this.string_8 == BookmarkStart.b("栳嬵夷夹䰻圽⌿㙁", num))) || (this.string_8.StartsWith(BookmarkStart.b("栳刵儷堹唻䨽ⴿ⍁㑃", num)) || this.string_8.StartsWith(BookmarkStart.b("栳䄵娷匹䠻匽ℿ㉁", num))))))
            {
                this.class564_0.method_1(true);
                if ((this.string_8.StartsWith(BookmarkStart.b("栳刵儷堹唻䨽ⴿ⍁㑃", num)) || this.string_8.StartsWith(BookmarkStart.b("栳䄵娷匹䠻匽ℿ㉁", num))) && this.bool_6)
                {
                    this.class837_0.bool_1 = true;
                }
                if (this.string_8.StartsWith(BookmarkStart.b("栳刵儷堹唻䨽ⴿ⍁㑃", num)))
                {
                    this.class837_0.bool_2 = true;
                }
            }
            if ((this.string_8.StartsWith(BookmarkStart.b("栳䄵唷弹䠻弽☿⭁⡃⍅", num)) || (this.string_8 == BookmarkStart.b("栳匵唷尹帻刽⤿㉁", num))) && this.bool_6)
            {
                this.bool_46 = true;
            }
        }
        if (this.itable_0 != null)
        {
            this.method_142(0);
            this.bool_33 = false;
        }
        this.method_42();
        this.method_164(this.method_10());
        this.method_145();
        this.document_0.bool_3 = false;
    }

    private void method_42()
    {
        if ((this.iparagraph_0 != null) && (this.iparagraph_0.ChildObjects.Count > 0))
        {
            if ((this.body_0 != null) && !this.body_0.Paragraphs.Contains(this.iparagraph_0))
            {
                this.body_0.Paragraphs.Add(this.iparagraph_0);
            }
            else if (!this.method_10().Paragraphs.Contains(this.iparagraph_0))
            {
                this.method_10().Paragraphs.Add(this.iparagraph_0);
            }
        }
    }

    private void method_43()
    {
        bool flag = false;
        this.bool_69 = false;
        foreach (KeyValuePair<string, Class839> pair in this.dictionary_0)
        {
            if (pair.Key == this.class839_1.method_4())
            {
                flag = true;
            }
        }
        if ((!flag && (this.class839_1.method_6() != null)) && (this.class839_1.method_4() != null))
        {
            this.class839_1.method_7(this.class839_1.method_6().Trim());
            this.dictionary_0.Add(this.class839_1.method_4(), this.class839_1);
        }
    }

    private void method_44()
    {
        int count = this.dictionary_1.Count;
        this.dictionary_1.Add(count, this.class843_0);
        count++;
        this.class843_0 = new Class843();
    }

    private void method_45()
    {
        int num = 10;
        if ((this.string_25 == null) || ((this.string_25 != null) && (this.string_25.Length == 0)))
        {
            this.string_25 = BookmarkStart.b("振䘱䴳娵崷", num) + Guid.NewGuid().ToString();
        }
        if (this.style_0 != null)
        {
            this.style_0.Name = this.string_25.Trim();
            Style style = this.document_0.Styles.FindByName(this.style_0.Name);
            if (style == null)
            {
                if (this.style_0 is ParagraphStyle)
                {
                    ParagraphStyle style3;
                    style3 = (this.style_0.Name.ToLower() == BookmarkStart.b("帯崱䘳嬵夷嘹", num)) ? new ParagraphStyle(this.document_0, BuiltinStyle.Normal) : (style3 = this.document_0.AddParagraphStyle(this.style_0.Name));
                    if (style3.BaseStyle != null)
                    {
                        style3.method_6();
                    }
                    if (this.style_0.IsCustomStyle)
                    {
                        style3.IsCustomStyle = true;
                    }
                    this.method_94(this.iparagraph_0.Format, style3.ParagraphFormat);
                    this.method_169(style3.CharacterFormat, this.class835_0);
                    if (this.style_0.BaseStyle != null)
                    {
                        style3.ApplyBaseStyle(this.style_0.BaseStyle.Name);
                    }
                }
                else if (!(this.style_0 is Class13) && (this.style_0 is Class11))
                {
                    IStyle style2 = this.document_0.method_33(StyleType.CharacterStyle, this.style_0.Name);
                    if (this.style_0.IsCustomStyle)
                    {
                        (style2 as Class11).IsCustomStyle = true;
                    }
                    this.method_169((style2 as Class11).CharacterFormat, this.class835_0);
                    if (this.style_0.BaseStyle != null)
                    {
                        (style2 as Class11).ApplyBaseStyle(this.style_0.BaseStyle.Name);
                    }
                }
                if (!this.dictionary_6.ContainsKey(this.string_22))
                {
                    this.dictionary_6.Add(this.string_22, this.style_0);
                }
            }
            else
            {
                this.method_169(style.CharacterFormat, this.class835_0);
                if (style is ParagraphStyle)
                {
                    this.method_94(this.iparagraph_0.Format, (style as ParagraphStyle).ParagraphFormat);
                }
                if (!this.dictionary_6.ContainsKey(this.string_22))
                {
                    this.dictionary_6.Add(this.string_22, style);
                }
            }
        }
        this.string_25 = string.Empty;
        this.style_0 = null;
    }

    private bool method_46(string A_0)
    {
        bool flag;
        using (IEnumerator enumerator = this.document_0.Styles.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Style current = (Style) enumerator.Current;
                if (current.Name == A_0)
                {
                    goto Label_0038;
                }
            }
            return false;
        Label_0038:
            flag = true;
        }
        return flag;
    }

    private void method_47()
    {
        int num = 9;
        string str = string.Empty;
        this.bool_37 = false;
        this.class564_0.method_6(RtfTokenType.ControlWord);
        if (((this.method_21() == RtfTableType.None) && (this.string_8.Length > 1)) && ((this.string_8[1] == '\'') || (this.string_8[1] == '~')))
        {
            this.class564_0.method_6(RtfTokenType.Text);
            if (this.bool_52 && this.bool_13)
            {
                this.bool_13 = false;
            }
        }
        else
        {
            if (this.string_8.EndsWith(BookmarkStart.b("ီ", num)))
            {
                this.string_8 = this.string_8.TrimEnd(new char[] { '?' });
                if (this.string_8.StartsWith(BookmarkStart.b("献䐰", num)))
                {
                    this.bool_68 = true;
                }
            }
            else if (this.string_8.Contains(BookmarkStart.b("ီ", num)))
            {
                str = this.string_8.Substring(this.string_8.IndexOf(BookmarkStart.b("ီ", num)));
                this.string_8 = this.string_8.Substring(0, this.string_8.IndexOf(BookmarkStart.b("ီ", num)));
                if (this.string_8.StartsWith(BookmarkStart.b("献䐰", num)) && str.StartsWith(BookmarkStart.b("ီ", num)))
                {
                    this.bool_68 = true;
                    str = str.Substring(1);
                }
            }
            else if (this.string_8.Contains(BookmarkStart.b("༮", num)))
            {
                string[] strArray2 = this.string_8.Split(new char[] { ' ' }, StringSplitOptions.None);
                int startIndex = -1;
                if ((strArray2.Length == 2) && !string.IsNullOrEmpty(strArray2[1].Trim()))
                {
                    startIndex = strArray2[0].Length + 1;
                }
                else if (strArray2.Length > 2)
                {
                    if (!string.IsNullOrEmpty(strArray2[1].Trim()))
                    {
                        startIndex = strArray2[0].Length + 1;
                    }
                    else
                    {
                        startIndex = (strArray2[0].Length + strArray2[1].Length) + 1;
                    }
                }
                if (startIndex > 0)
                {
                    str = this.string_8.Substring(startIndex);
                    this.string_8 = this.string_8.Substring(0, startIndex);
                }
            }
            this.string_8 = this.string_8.Trim();
        }
        this.string_8 = this.string_8.Substring(1);
        if (((this.string_8 == BookmarkStart.b("献", num)) || (this.string_8 == BookmarkStart.b("吮", num))) || (this.string_8 == BookmarkStart.b("刮", num)))
        {
            this.method_57(this.string_8);
        }
        if (this.string_8 == BookmarkStart.b("Ԯ", num))
        {
            if (!this.bool_13)
            {
                this.stack_6.Push(BookmarkStart.b("吮", num));
            }
            this.bool_13 = true;
        }
        string[] strArray = this.method_166(this.string_8);
        if (this.string_8 == BookmarkStart.b("弮堰倲䄴", num))
        {
            this.method_33()[BookmarkStart.b("弮堰倲䄴", num)] = string.Empty;
            this.class564_0.method_2(false);
        }
        this.method_95(this.string_8, strArray[0], strArray[1]);
        this.string_10 = strArray[0];
        this.string_11 = strArray[1];
        if (!string.IsNullOrEmpty(str))
        {
            str = str.Substring(this.int_25);
            this.method_57(str);
        }
        if (!string.IsNullOrEmpty(strArray[2]) && !strArray[0].StartsWith(BookmarkStart.b("࠮", num)))
        {
            if (strArray[0] == BookmarkStart.b("娮", num))
            {
                if (this.stack_28.Count > 0)
                {
                    this.int_25 = this.stack_28.Peek();
                }
                if (this.bool_68)
                {
                    this.int_25--;
                    this.bool_68 = false;
                }
                string str2 = strArray[2].Substring(this.int_25);
                this.method_57(str2);
            }
            else if ((!this.string_8.StartsWith(BookmarkStart.b("瀮", num)) && !this.string_8.StartsWith(BookmarkStart.b("儮", num))) && (!this.string_8.StartsWith(BookmarkStart.b("Ȯ", num)) && !this.string_8.StartsWith(BookmarkStart.b("ᔮ", num))))
            {
                this.method_57(strArray[2]);
            }
        }
    }

    private bool method_48()
    {
        if (((this.method_21() == RtfTableType.None) && !this.bool_17) && (!this.bool_14 && !this.bool_32))
        {
            return false;
        }
        return true;
    }

    private void method_49()
    {
        int num = 8;
        if (((this.itable_0 != null) && !this.bool_33) && this.bool_74)
        {
            this.method_142(0);
            this.bool_74 = false;
        }
        if (this.bool_61 && (this.method_21() == RtfTableType.None))
        {
            this.stack_4.Push(BookmarkStart.b("唭", num));
        }
        if (this.stack_39.Count > 0)
        {
            this.stack_39.Push(false);
        }
        if (this.stack_37 == null)
        {
            this.stack_37 = new Stack<string>();
        }
        if ((this.stack_15 != null) && (this.stack_15.Count > 0))
        {
            this.stack_15.Push(true);
        }
        this.stack_37.Push(BookmarkStart.b("唭", num));
        this.stack_18.Push(this.method_96(this.dictionary_9));
        this.stack_51.Push(this.lineBreakClear_0);
        if ((this.stack_0 != null) && (this.stack_0.Count > 0))
        {
            this.stack_0.Push(BookmarkStart.b("唭", num));
        }
        if (this.stack_49 == null)
        {
            this.stack_49 = new Stack<string>();
        }
        if ((this.bool_70 && this.bool_71) && (this.stack_49 != null))
        {
            this.stack_49.Push(BookmarkStart.b("唭", num));
        }
        if (this.stack_48 == null)
        {
            this.stack_48 = new Stack<string>();
        }
        if (this.bool_70 && (this.stack_48 != null))
        {
            this.stack_48.Push(BookmarkStart.b("唭", num));
        }
        if (this.stack_50 == null)
        {
            this.stack_50 = new Stack<string>();
        }
        if (this.bool_73 && (this.stack_50 != null))
        {
            this.stack_50.Push(BookmarkStart.b("唭", num));
        }
        if (this.stack_19 != null)
        {
            this.stack_19.Push(BookmarkStart.b("唭", num));
        }
        this.class564_0.method_6(RtfTokenType.GroupStart);
        this.stack_28.Push(this.int_6);
        this.stack_3.Push((this.encoding_0 == null) ? 0 : this.encoding_0.CodePage);
        if (this.method_48())
        {
            this.stack_4.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_6)
        {
            this.stack_5.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_63)
        {
            this.stack_40.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_13)
        {
            this.stack_6.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_28 || this.bool_29)
        {
            this.stack_7.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_64)
        {
            this.stack_41.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_41)
        {
            if (this.stack_23.Peek() == BookmarkStart.b("䠭尯嘱崳堵䬷丹", num))
            {
                this.stack_11.Push(this.class835_0.method_0());
            }
            this.stack_23.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_51)
        {
            this.stack_27.Push(BookmarkStart.b("爭", num));
        }
        if (this.bool_54)
        {
            this.stack_30.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_59)
        {
            this.stack_35.Push(BookmarkStart.b("唭", num));
        }
        if (this.bool_45)
        {
            this.stack_25.Push(BookmarkStart.b("爭", num));
        }
        if (!this.bool_41)
        {
            this.stack_10.Push(this.class835_0.method_0());
        }
        this.stack_26.Push(new Dictionary<string, object>());
        if (this.iparagraph_0 != null)
        {
            ParagraphFormat item = new ParagraphFormat(this.document_0);
            item.ImportContainer(this.iparagraph_0.Format);
            item.method_21(this.iparagraph_0.Format);
            this.stack_52.Push(item);
        }
        else
        {
            this.stack_52.Push(null);
        }
    }

    public int method_5()
    {
        return this.int_12;
    }

    private void method_50()
    {
        int num = 0x10;
        if (this.stack_38.Count > 0)
        {
            this.bool_19 = this.stack_38.Pop();
        }
        if (this.bool_20)
        {
            this.bool_20 = false;
        }
        this.bool_23 = false;
        this.bool_24 = false;
        if (this.stack_52.Count > 0)
        {
            this.paragraphFormat_0 = this.stack_52.Pop();
        }
        if ((this.stack_15 != null) && (this.stack_15.Count > 0))
        {
            this.stack_15.Pop();
            if (this.dictionary_8 == null)
            {
                this.dictionary_8 = new Dictionary<int, string>();
            }
            if (this.stack_15.Count > 0)
            {
                this.dictionary_8.Add(this.dictionary_8.Count, this.string_18.EndsWith(BookmarkStart.b("വ", num)) ? this.string_18.Substring(0, this.string_18.Length - 1) : this.string_18);
                this.string_18 = string.Empty;
            }
        }
        if (this.stack_39.Count > 0)
        {
            this.stack_39.Pop();
        }
        if (this.bool_22)
        {
            this.bool_22 = false;
            if (((this.stack_39.Count == 0) || !this.stack_39.Peek()) && !string.IsNullOrEmpty(this.string_20))
            {
                this.method_7().AppendBookmarkStart(this.string_20);
            }
            this.string_20 = null;
        }
        else if (this.bool_27)
        {
            this.bool_27 = false;
            if (((this.stack_39.Count == 0) || !this.stack_39.Peek()) && !string.IsNullOrEmpty(this.string_20))
            {
                this.method_7().AppendBookmarkEnd(this.string_20);
            }
            this.string_20 = null;
        }
        if (this.bool_25)
        {
            this.bool_25 = false;
            if (!string.IsNullOrEmpty(this.string_19))
            {
                this.method_7().AppendPermStart(this.string_19);
            }
            this.string_19 = null;
        }
        if (this.bool_26)
        {
            this.bool_26 = false;
            if (!string.IsNullOrEmpty(this.string_19))
            {
                this.method_7().AppendPermEnd(this.string_19);
            }
            this.string_19 = null;
        }
        if ((this.stack_37 != null) && (this.stack_37.Count > 0))
        {
            this.stack_37.Pop();
        }
        if ((this.stack_36 != null) && (this.stack_36.Count > 0))
        {
            this.bool_60 = this.stack_36.Pop();
        }
        if ((this.bool_73 && (this.stack_50 != null)) && ((this.stack_50.Count > 0) && this.stack_50.Pop().Equals(BookmarkStart.b("刵夷丹崻堽⤿❁⡃≅", num))))
        {
            this.bool_73 = false;
            if (this.class840_0 != null)
            {
                this.class840_0.method_12(this.string_31);
            }
            this.string_31 = string.Empty;
        }
        if (this.stack_51.Count > 0)
        {
            this.lineBreakClear_0 = this.stack_51.Pop();
        }
        if (((this.bool_70 && this.bool_71) && ((this.stack_49 != null) && (this.stack_49.Count > 0))) && this.stack_49.Pop().Equals(BookmarkStart.b("夵娷倹弻刽ℿㅁ㝃", num)))
        {
            this.bool_71 = false;
            this.stack_49 = null;
            if (this.docOleObject_0 != null)
            {
                this.docOleObject_0.Interface49.set_ObjectType(this.string_30);
                this.string_30 = string.Empty;
            }
        }
        if ((this.bool_70 && (this.stack_48 != null)) && (this.stack_48.Count > 0))
        {
            this.stack_48.Pop();
            if (this.stack_48.Count == 0)
            {
                this.bool_70 = false;
                this.docOleObject_0.SetOlePicture(this.ipicture_0 as DocPicture);
                this.method_58(this.docOleObject_0);
                if (this.ipicture_0 != null)
                {
                    this.method_7().AppendFieldMark(FieldMarkType.FieldSeparator);
                    this.method_58(this.ipicture_0 as DocPicture);
                    this.method_7().AppendFieldMark(FieldMarkType.FieldEnd);
                }
                this.docOleObject_0 = null;
                this.ipicture_0 = null;
            }
        }
        if ((this.stack_18 != null) && (this.stack_18.Count > 0))
        {
            this.dictionary_9 = this.stack_18.Pop();
            this.int_17 = this.dictionary_9.Count;
        }
        this.class564_0.method_6(RtfTokenType.GroupEnd);
        if (this.stack_28.Count > 0)
        {
            this.stack_28.Pop();
        }
        this.int_25 = 0;
        this.method_110(this.stack_3.Pop());
        if (this.method_48())
        {
            this.stack_4.Pop();
            if (this.stack_4.Count == 0)
            {
                this.bool_6 = false;
                this.bool_15 = false;
                if (this.bool_17)
                {
                    this.bool_17 = false;
                    this.method_94(this.method_7().Format, this.paragraphFormat_1);
                    this.method_169(this.characterFormat_0, this.class835_0);
                    this.iparagraph_0 = this.paragraph_0;
                }
                this.bool_14 = false;
                this.bool_32 = false;
                this.method_22(RtfTableType.None);
            }
        }
        if (this.bool_13 || this.bool_57)
        {
            if (this.stack_6.Count > 0)
            {
                this.stack_6.Pop();
            }
            if (this.stack_6.Count == 0)
            {
                this.bool_13 = false;
            }
        }
        if (this.bool_63 && (this.stack_40.Count == 0))
        {
            this.bool_63 = false;
        }
        if (this.bool_63)
        {
            this.stack_40.Pop();
        }
        if (this.bool_28 || this.bool_29)
        {
            this.stack_7.Pop();
            if (this.stack_7.Count == 0)
            {
                this.bool_28 = false;
                this.bool_29 = false;
                if ((this.itable_0 != null) && !this.bool_33)
                {
                    this.method_142(0);
                    this.bool_74 = false;
                }
                this.method_42();
                this.int_17 = 0;
                this.int_16 = 0;
                this.dictionary_9.Clear();
                this.method_32(new Class842());
                if (this.iparagraph_0 != null)
                {
                    this.method_138(this.iparagraph_0.Format);
                }
                this.iparagraph_0 = null;
                this.body_0 = null;
            }
        }
        if ((this.bool_61 && (this.method_21() == RtfTableType.None)) && (this.stack_4.Pop() == BookmarkStart.b("䘵強帹伻崽㐿⁁⡃", num)))
        {
            this.bool_61 = false;
            this.method_51(this.isection_0 as Section);
        }
        if (this.bool_64)
        {
            this.stack_41.Pop();
            if (this.stack_41.Count == 0)
            {
                this.bool_64 = false;
                if (this.stack_42.Count > 0)
                {
                    this.method_42();
                    this.iparagraph_0 = this.stack_42.Pop();
                    this.footnote_0 = null;
                }
                if (this.stack_43.Count > 0)
                {
                    this.body_0 = this.stack_43.Pop();
                }
                else
                {
                    this.body_0 = this.method_10().Body;
                }
                this.int_13 = this.int_29;
                this.int_12 = this.int_30;
                this.bool_33 = this.bool_66;
                this.bool_34 = this.bool_67;
                this.itable_0 = this.stack_45.Pop();
                this.tableRow_0 = this.stack_46.Pop();
                this.tableCell_0 = this.stack_47.Pop();
                if (this.stack_44.Count > 0)
                {
                    this.dictionary_2 = this.stack_44.Pop();
                }
            }
        }
        if (this.bool_41)
        {
            if (this.stack_23.Pop() == BookmarkStart.b("倵儷弹倻娽", num))
            {
                if (this.class840_0.method_2().Count == 0)
                {
                    this.class840_0.method_2().Add(this.string_23);
                    this.class840_0.method_7().Add(this.class835_0.method_0());
                }
                if (this.class841_0.method_0().Count == 0)
                {
                    this.class841_0.method_0().Add(this.string_24);
                    this.class841_0.method_2().Add(this.class835_0.method_0());
                }
                if (!this.bool_44)
                {
                    this.class840_0.method_4().Add(this.class841_0);
                    this.bool_44 = true;
                    this.class841_0 = new Class841();
                    if (((this.stack_23.Count > 0) && (this.stack_23.Peek() == BookmarkStart.b("倵吷帹唻倽㌿㙁", num))) && (this.stack_24.Count > 0))
                    {
                        Class840 class4 = this.stack_24.Pop();
                        class4.method_2().Add(this.class840_0);
                        this.class840_0 = class4.method_17();
                    }
                    if (this.stack_24.Count == 1)
                    {
                        Class840 item = this.stack_24.Pop();
                        item.method_4().Add(this.class840_0);
                        if (item.method_6() == FieldType.FieldTOC)
                        {
                            this.stack_24.Push(item);
                            this.class840_0 = this.class840_0.method_17();
                        }
                        else
                        {
                            this.class840_0 = item.method_17();
                        }
                    }
                }
                else if (this.stack_24.Count > 0)
                {
                    Class840 class3 = this.stack_24.Pop();
                    if ((this.stack_23.Count > 0) && (this.stack_24.Count > 0))
                    {
                        class3.method_4().Add(this.class840_0);
                        this.class840_0 = this.stack_24.Pop();
                        this.class840_0.method_4().Add(class3);
                        this.stack_24.Push(this.class840_0);
                    }
                    if (this.stack_24.Count == 0)
                    {
                        this.class840_0 = class3;
                    }
                    else
                    {
                        this.class840_0 = class3.method_17();
                    }
                }
                if ((this.stack_23.Count > 0) && (this.stack_23.Peek() == BookmarkStart.b("倵吷帹唻倽㌿㙁", num)))
                {
                    this.bool_42 = true;
                }
                else if ((this.stack_23.Count > 0) && (this.stack_23.Peek() == BookmarkStart.b("倵吷帹主䴽ⰿ㙁", num)))
                {
                    this.bool_43 = true;
                }
                if ((this.stack_24.Count == 0) && (this.stack_23.Count == 0))
                {
                    this.method_77(this.class840_0);
                    if (this.bool_47)
                    {
                        this.bool_47 = false;
                        this.class838_0 = null;
                    }
                    this.bool_41 = false;
                    this.bool_43 = false;
                    this.bool_48 = false;
                    this.bool_44 = false;
                    this.bool_60 = false;
                    this.class841_0.method_4();
                    this.string_23 = string.Empty;
                    this.string_24 = string.Empty;
                }
                else if (this.stack_24.Count == 0)
                {
                    this.bool_48 = false;
                }
            }
            else
            {
                this.method_62();
            }
        }
        Dictionary<string, object> dictionary = this.stack_26.Peek();
        if ((this.bool_30 && (dictionary != null)) && dictionary.ContainsKey(BookmarkStart.b("娵崷䰹夻刽㐿❁㱃㉅", num)))
        {
            this.method_97();
            this.bool_30 = false;
        }
        if (this.bool_51)
        {
            if (this.stack_27.Count > 0)
            {
                this.stack_27.Pop();
            }
            if (this.stack_27.Count == 0)
            {
                if (this.method_21() == RtfTableType.ListOverrideTable)
                {
                    ListLevel overrideListLevel = this.class12_0.method_23().method_5(this.int_8 - 1).OverrideListLevel;
                    this.method_94(this.method_13().ParagraphFormat, overrideListLevel.ParagraphFormat);
                    this.method_169(overrideListLevel.CharacterFormat, this.class835_0);
                    this.method_106(this.method_13(), overrideListLevel);
                    this.method_138(this.method_13().ParagraphFormat);
                }
                else
                {
                    this.method_94(this.method_7().Format, this.method_13().ParagraphFormat);
                    this.method_169(this.method_13().CharacterFormat, this.class835_0);
                }
                this.iparagraph_0 = null;
                this.bool_51 = false;
            }
        }
        if (this.bool_6)
        {
            if (this.stack_5.Count > 0)
            {
                this.stack_5.Pop();
            }
            if (this.stack_5.Count == 0)
            {
                this.bool_6 = false;
                this.bool_15 = false;
                this.class564_0.method_1(false);
            }
        }
        if ((this.itable_0 != null) && (this.string_9 == BookmarkStart.b("䐵圷䴹", num)))
        {
            this.method_127(false);
        }
        if (this.bool_53)
        {
            if (this.stack_29.Count > 0)
            {
                this.stack_29.Pop();
            }
            if (this.stack_29.Count == 0)
            {
                this.bool_53 = false;
            }
        }
        if (this.bool_54)
        {
            if (this.stack_30.Count > 0)
            {
                string str3 = this.stack_30.Pop();
                if (str3 == BookmarkStart.b("䔵䠷", num))
                {
                    this.method_148(this.string_26, this.string_27);
                    this.bool_56 = false;
                    this.bool_55 = false;
                    this.string_26 = string.Empty;
                    this.string_27 = string.Empty;
                }
                else if (str3 == BookmarkStart.b("䔵倷䨹", num))
                {
                    if (this.stack_30.Count > 0)
                    {
                        this.stack_30.Pop();
                    }
                    this.bool_57 = false;
                    if (this.stack_34.Count > 0)
                    {
                        this.shapeObject_0.SetShapeAttribute(0x1023, (this.double_0 / ((double) this.shapeGroup_0.NumLevel)) - this.shapeObject_0.Left);
                        this.shapeObject_0.SetShapeAttribute(0x1024, (this.double_1 / ((double) this.shapeGroup_0.NumLevel)) - this.shapeObject_0.Top);
                        this.shapeGroup_0 = this.stack_34.Pop() as ShapeGroup;
                        this.shapeGroup_0.ChildObjects.Add(this.shapeObject_0);
                    }
                    if (this.stack_31.Count > 0)
                    {
                        this.body_0 = this.stack_31.Pop();
                    }
                    if (this.stack_32.Count > 0)
                    {
                        this.iparagraph_0 = this.stack_32.Pop();
                    }
                    if (this.stack_33.Count > 0)
                    {
                        this.bool_13 = this.stack_33.Pop();
                    }
                    if ((this.stack_18.Count > 0) && (this.textBox_0 != null))
                    {
                        this.dictionary_9 = this.stack_18.Pop();
                        this.int_17 = this.dictionary_9.Count;
                    }
                }
                else if ((str3 == BookmarkStart.b("䔵倷䨹嬻䰽〿", num)) && (this.stack_34.Count > 0))
                {
                    ShapeGroup group = this.stack_34.Pop() as ShapeGroup;
                    group.ChildObjects.Add(this.shapeObject_0);
                    this.shapeGroup_0 = group;
                }
                if (this.stack_30.Count == 0)
                {
                    if (this.bool_45)
                    {
                        this.method_52(this.shapeObject_0);
                    }
                    else if ((this.shapeObject_0 != null) && ((this.shapeObject_0.IsImage && !this.shapeObject_0.HasImageBytes) || this.bool_15))
                    {
                        DocPicture lastItem = this.iparagraph_0.ChildObjects.LastItem as DocPicture;
                        if (lastItem != null)
                        {
                            this.method_170(this.shapeObject_0, this.class837_0);
                            this.method_92(lastItem, this.class837_0);
                        }
                    }
                    this.bool_58 = false;
                    this.bool_54 = false;
                    this.bool_59 = false;
                    this.bool_15 = false;
                    this.shapeObject_0 = null;
                    this.shapeGroup_0 = null;
                }
            }
        }
        else if ((this.bool_59 && (this.stack_35.Count > 0)) && (this.stack_35.Pop() == BookmarkStart.b("䈵䀷尹唻嬽ⰿ♁ぃ⍅ぇ㹉", num)))
        {
            this.bool_59 = false;
        }
        if (this.bool_45)
        {
            if (this.stack_25.Count > 0)
            {
                this.stack_25.Pop();
            }
            if (this.stack_25.Count == 0)
            {
                this.bool_45 = false;
            }
        }
        this.stack_26.Pop();
        if (!this.bool_41)
        {
            this.class835_0 = this.stack_10.Pop();
        }
        if (this.stack_19.Count > 0)
        {
            if ((this.stack_19.Pop() == BookmarkStart.b("䘵吷嬹唻倽", num)) && (this.stack_20.Count > 0))
            {
                this.class835_2 = this.stack_20.Pop();
            }
            else if (((this.stack_19.Count > 0) && (this.stack_19.Peek() == BookmarkStart.b("䘵吷嬹唻倽", num))) && (this.bool_39 && (this.class835_2 == null)))
            {
                this.bool_39 = false;
                this.class835_2 = this.method_175();
                this.method_137(this.class835_0, this.class835_2);
            }
        }
        if (((this.stack_0 != null) && (this.stack_0.Count > 0)) && (this.stack_0.Pop() == BookmarkStart.b("䐵䰷尹഻", num)))
        {
            if (this.stack_2.Count > 0)
            {
                this.dictionary_1 = this.stack_2.Pop();
            }
            if (this.stack_1.Count > 0)
            {
                this.dictionary_0 = this.stack_1.Pop();
            }
        }
    }

    private void method_51(Section A_0)
    {
        if (A_0 != null)
        {
            foreach (HeaderFooter footer in A_0.HeadersFooters)
            {
                footer.ChildObjects.Clear();
            }
        }
    }

    private void method_52(ShapeObject A_0)
    {
        switch (A_0.Fill.FillType)
        {
            case FillType.Solid:
                this.document_0.Background.Type = BackgroundType.Color;
                this.document_0.Background.Color = A_0.FillColor;
                this.document_0.Background.FillType = (BackgroundFillType) A_0.Fill.FillType;
                return;

            case FillType.Pattern:
            case FillType.Shade:
                break;

            case FillType.Texture:
            {
                this.document_0.Background.Type = BackgroundType.Texture;
                this.document_0.Background.Color = A_0.FillColor;
                this.document_0.Background.ImageBytes = A_0.Fill.ImageBytes;
                this.document_0.Background.FillType = (BackgroundFillType) A_0.Fill.FillType;
                DocPicture picture2 = new DocPicture(this.document_0);
                picture2.LoadImage(this.document_0.Background.ImageBytes);
                this.document_0.Background.ImageRecord = this.document_0.Images.method_5(this.document_0.Background.ImageBytes);
                this.document_0.Background.ImageRecord.method_10(Size.Truncate(picture2.Size));
                this.document_0.Background.ImageRecord.method_12(picture2.Image.RawFormat);
                this.document_0.Background.ImageRecord.method_14(this.document_0.Background.ImageBytes.Length);
                return;
            }
            case FillType.Picture:
            {
                DocPicture picture = new DocPicture(this.document_0);
                picture.LoadImage(A_0.Fill.ImageBytes);
                this.document_0.Background.Type = BackgroundType.Picture;
                this.document_0.Background.Picture = picture.Image;
                this.document_0.Background.FillType = (BackgroundFillType) A_0.Fill.FillType;
                return;
            }
            case FillType.ShadeCenter:
            case FillType.ShadeShape:
            case FillType.ShadeScale:
            {
                this.document_0.Background.Type = BackgroundType.Gradient;
                this.document_0.Background.Color = A_0.FillColor;
                BackgroundGradient gradient = this.document_0.Background.Gradient;
                gradient.Color1 = A_0.Fill.Color;
                gradient.Color2 = A_0.Fill.Color2;
                gradient.ShadingStyle = this.method_53(A_0.Fill.Angle, A_0.Fill.FillType);
                gradient.ShadingVariant = this.method_54(A_0.Fill.Focus);
                this.document_0.Background.FillType = (BackgroundFillType) A_0.Fill.FillType;
                break;
            }
            default:
                return;
        }
    }

    private GradientShadingStyle method_53(double A_0, FillType A_1)
    {
        if (A_1 == FillType.ShadeCenter)
        {
            return GradientShadingStyle.FromCorner;
        }
        if (A_1 == FillType.ShadeShape)
        {
            return GradientShadingStyle.FromCenter;
        }
        if (A_0 == -135.0)
        {
            return GradientShadingStyle.DiagonalUp;
        }
        if (A_0 == -90.0)
        {
            return GradientShadingStyle.Vertical;
        }
        if (A_0 == -45.0)
        {
            return GradientShadingStyle.DiagonalDown;
        }
        return GradientShadingStyle.Horizontal;
    }

    private GradientShadingVariant method_54(int A_0)
    {
        int num = A_0;
        switch (num)
        {
            case -50:
                return GradientShadingVariant.ShadingOut;

            case 50:
                return GradientShadingVariant.ShadingMiddle;
        }
        if (num != 100)
        {
            return GradientShadingVariant.ShadingDown;
        }
        return GradientShadingVariant.ShadingUp;
    }

    private string method_55(string A_0)
    {
        if ((this.string_12 == BookmarkStart.b("伱", 12)) || (this.class564_0.method_5() == RtfTokenType.Text))
        {
            return A_0;
        }
        if (this.string_8.Length > 1)
        {
            A_0 = A_0.Substring(1, A_0.Length - 1);
            return A_0;
        }
        return null;
    }

    private bool method_56()
    {
        return ((this.bool_6 && this.bool_15) && this.class564_0.method_0());
    }

    private void method_57(string A_0)
    {
        int num = 0x11;
        if ((this.bool_70 && this.bool_71) && (this.docOleObject_0 != null))
        {
            this.string_30 = this.string_30 + A_0.Trim();
        }
        else if (this.bool_70 && this.bool_72)
        {
            this.bool_72 = false;
            this.class564_0.method_2(true);
            this.class564_0.method_1(false);
            if (this.docOleObject_0 != null)
            {
                this.docOleObject_0.method_106(A_0);
            }
        }
        else if (this.bool_73)
        {
            this.string_31 = this.string_31 + A_0.Trim();
        }
        else if ((string.IsNullOrEmpty(A_0) || (A_0.Trim().Length != 1)) || (A_0.Trim()[0] != '?'))
        {
            if (this.method_33().ContainsKey(BookmarkStart.b("䜶倸堺䤼", num)))
            {
                this.class564_0.method_2(true);
            }
            if (!this.bool_17 && (A_0 != null))
            {
                this.rtfTokenType_0 = RtfTokenType.Text;
                this.class564_0.method_6(RtfTokenType.Text);
                if (!this.bool_60 && this.method_56())
                {
                    this.method_63();
                }
                else if ((this.method_21() != RtfTableType.FontTable) || this.bool_13)
                {
                    if ((this.method_21() == RtfTableType.FontTable) && this.bool_69)
                    {
                        string str = A_0;
                        if (this.document_0.FontSubstitutionTable.ContainsKey(this.class839_1.method_6()))
                        {
                            this.document_0.FontSubstitutionTable[this.class839_1.method_6()] = str;
                        }
                        else
                        {
                            this.document_0.FontSubstitutionTable.Add(this.class839_1.method_6(), str);
                        }
                    }
                    else if (this.method_21() == RtfTableType.StyleSheet)
                    {
                        this.string_25 = this.string_25 + A_0;
                    }
                    else if (this.bool_22)
                    {
                        this.string_20 = this.string_20 + A_0;
                    }
                    else if (this.bool_27)
                    {
                        this.string_20 = this.string_20 + A_0;
                    }
                    else if (this.bool_25)
                    {
                        this.string_19 = this.string_19 + A_0;
                    }
                    else if (this.bool_26)
                    {
                        this.string_19 = this.string_19 + A_0;
                    }
                    else if (this.bool_32)
                    {
                        this.method_64();
                    }
                    else if (this.bool_14)
                    {
                        this.method_65();
                    }
                    else if (this.bool_42 && (this.class838_0 != null))
                    {
                        this.method_61(A_0);
                    }
                    else if ((this.bool_42 && (this.string_9 != BookmarkStart.b("匶堸伺尼夾⡀♂⥄⍆", num))) && (!this.bool_6 && this.bool_41))
                    {
                        if ((!A_0.StartsWith(BookmarkStart.b("᜶", num)) && (A_0.Length > 0)) && char.IsNumber(A_0, 0))
                        {
                            this.string_23 = this.string_23 + BookmarkStart.b("᜶", num) + A_0;
                        }
                        else
                        {
                            this.string_23 = this.string_23 + A_0;
                        }
                    }
                    else if (((this.bool_43 && !this.bool_6) && (!this.bool_60 && this.bool_41)) && !this.bool_54)
                    {
                        if (A_0 == BookmarkStart.b("欶䴸娺弼", num))
                        {
                            this.string_24 = this.string_24 + BookmarkStart.b("㸶", num);
                        }
                        else
                        {
                            this.string_24 = this.string_24 + A_0;
                        }
                    }
                    else if ((((this.method_21() == RtfTableType.None) && (((!this.bool_13 && !this.bool_54) || (this.bool_13 && this.bool_64)) || this.bool_57)) && ((!this.bool_14 && !this.bool_6) && ((!this.bool_41 && !this.bool_47) || this.bool_54))) && !this.bool_59)
                    {
                        if (((this.string_9 != null) && this.string_9.StartsWith(BookmarkStart.b("ံ", num))) && this.bool_37)
                        {
                            this.bool_37 = false;
                        }
                        if ((((this.class835_0 == this.class835_1) && (this.method_7().Items.Count != 0)) && ((this.method_7().Items.Count <= 0) || (this.method_7().LastItem.DocumentObjectType == DocumentObjectType.TextRange))) && (((this.method_7().Items.Count <= 0) || (this.method_7().LastItem.DocumentObjectType != DocumentObjectType.TextRange)) || ((this.method_7().LastItem as TextRange).Text != BookmarkStart.b("㸶", num))))
                        {
                            TextRange lastItem = this.method_7().LastItem as TextRange;
                            lastItem.Text = lastItem.Text + A_0;
                        }
                        else
                        {
                            this.itextRange_0 = new TextRange(this.document_0);
                            this.itextRange_0.Text = A_0;
                            this.method_58(this.itextRange_0);
                            this.method_169(this.itextRange_0.CharacterFormat, this.class835_0);
                        }
                        if (this.class835_0 != this.class835_1)
                        {
                            this.class835_1 = this.class835_0.method_0();
                        }
                        this.bool_27 = false;
                    }
                    else if (!this.bool_55)
                    {
                        if (this.bool_56)
                        {
                            this.string_27 = this.string_27 + A_0;
                        }
                        else if ((this.stack_15 != null) && (this.stack_15.Count > 0))
                        {
                            this.string_18 = this.string_18 + A_0;
                        }
                    }
                    else
                    {
                        this.string_26 = this.string_26 + A_0;
                        if (this.string_26 == BookmarkStart.b("䜶倸夺", num))
                        {
                            this.bool_15 = true;
                        }
                    }
                }
                else
                {
                    this.class839_1.method_7(this.class839_1.method_6() + A_0);
                    if (this.class839_0 == this.class839_1)
                    {
                        Style style = this.document_0.AddStyle(BuiltinStyle.Normal);
                        style.CharacterFormat.FontName = this.class839_1.method_6();
                        style.CharacterFormat.FontSize = 12f;
                    }
                }
            }
            else if (this.bool_17 && (A_0 != null))
            {
                if (this.method_13() == null)
                {
                    this.method_14(new ListLevel(this.document_0));
                }
                this.method_13().BulletCharacter = A_0;
            }
        }
    }

    private void method_58(IDocumentObject A_0)
    {
        this.method_7().Items.Add(A_0);
    }

    private void method_59(int A_0, IDocumentObject A_1)
    {
        this.method_7().Items.Insert(A_0, A_1);
    }

    public Body method_6()
    {
        return this.body_0;
    }

    private void method_60()
    {
        if (this.method_7().Items.Count == 0)
        {
            this.method_169(this.method_7().BreakCharacterFormat, this.class835_0);
        }
    }

    private void method_61(string A_0)
    {
        int num = 13;
        this.string_8 = this.string_8.TrimStart(new char[0]);
        string key = this.string_9;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_156 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("唲匴夶堸嘺堼", num), 0);
                dictionary1.Add(BookmarkStart.b("唲匴匶尸崺䤼娾㥀㝂", num), 1);
                dictionary1.Add(BookmarkStart.b("唲匴儶嘸䤺值帾㕀", num), 2);
                dictionary1.Add(BookmarkStart.b("唲匴弶尸场䴼䬾⑀㭂ㅄ", num), 3);
                dictionary1.Add(BookmarkStart.b("唲匴䐶䴸娺䤼䬾⑀㭂ㅄ", num), 4);
                dictionary1.Add(BookmarkStart.b("唲匴制圸伺似䘾ⱀ⁂㝄", num), 5);
                dictionary1.Add(BookmarkStart.b("唲匴制䄸刺䤼刾≀ㅂ", num), 6);
                dictionary1.Add(BookmarkStart.b("唲匴嬶", num), 7);
                Class1160.dictionary_156 = dictionary1;
            }
            if (Class1160.dictionary_156.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.class838_0.method_23(A_0);
                        return;

                    case 1:
                        this.class838_0.method_9(A_0);
                        return;

                    case 2:
                        this.class838_0.method_7(A_0);
                        return;

                    case 3:
                        this.class838_0.method_25(A_0);
                        return;

                    case 4:
                        this.class838_0.method_29(A_0);
                        return;

                    case 5:
                        this.class838_0.method_21(A_0);
                        return;

                    case 6:
                        this.class838_0.method_19(A_0);
                        return;

                    case 7:
                        this.class838_0.dropDownCollection_0.Add(A_0);
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_62()
    {
        string str2;
        int num = 0x12;
        if ((this.stack_23.Count > 0) && ((str2 = this.stack_23.Peek()) != null))
        {
            if (str2 == BookmarkStart.b("帷嘹堻圽⸿ㅁぃ", num))
            {
                if (!string.IsNullOrEmpty(this.string_23))
                {
                    if ((this.class840_0.method_2().Count == 1) && (this.class840_0.method_2()[0] is string))
                    {
                        List<object> list2;
                        (list2 = this.class840_0.method_2())[0] = list2[0] + this.string_23;
                        this.class840_0.method_7()[0] = this.class835_0;
                    }
                    else
                    {
                        this.class840_0.method_2().Add(this.string_23);
                        this.class840_0.method_7().Add(this.class835_0);
                    }
                    this.string_23 = string.Empty;
                }
                this.class835_0 = this.stack_11.Pop();
            }
            else if ((str2 == BookmarkStart.b("帷嘹堻䰽㌿⹁ぃ", num)) && !string.IsNullOrEmpty(this.string_24))
            {
                if ((this.class841_0.method_0().Count == 1) && (this.class841_0.method_0()[0] is string))
                {
                    List<object> list;
                    (list = this.class841_0.method_0())[0] = list[0] + this.string_24;
                    this.class841_0.method_2()[0] = this.class835_0.method_0();
                }
                else
                {
                    this.class841_0.method_0().Add(this.string_24);
                    this.class841_0.method_2().Add(this.class835_0.method_0());
                }
                this.string_24 = string.Empty;
            }
        }
    }

    private void method_63()
    {
        int num = 0x13;
        if (!this.bool_41)
        {
            if (!this.bool_59)
            {
                if (this.string_9 != BookmarkStart.b("嬸场吼伾㑀⩂⅄", num))
                {
                    if (((!(this.string_9 == BookmarkStart.b("匸䬺堼堾⍀⽂ⱄ㝆", num)) && !this.string_9.StartsWith(BookmarkStart.b("丸嘺堼䬾⁀╂ⱄ⭆ⱈ", num))) && (!(this.string_9 == BookmarkStart.b("䤸唺娼崾ⵀ⩂㕄", num)) && !(this.string_9 == BookmarkStart.b("尸嘺嬼崾ⵀ⩂㕄", num)))) && !(this.string_9 == BookmarkStart.b("吸娺帼伾⡀⁂ㅄ", num)))
                    {
                        this.method_89(this.string_8);
                    }
                    else
                    {
                        this.method_89(this.string_8);
                    }
                }
                else if (this.string_12 == BookmarkStart.b("䐸", num))
                {
                    this.method_89(this.string_8);
                }
            }
        }
        else if (this.bool_42)
        {
            DocPicture item = new DocPicture(this.document_0);
            if (this.string_9 == BookmarkStart.b("嬸场吼伾㑀⩂⅄", num))
            {
                if (this.string_12 == BookmarkStart.b("䐸", num))
                {
                    item = this.method_91(this.string_8);
                }
            }
            else if (((!(this.string_9 == BookmarkStart.b("匸䬺堼堾⍀⽂ⱄ㝆", num)) && !this.string_9.StartsWith(BookmarkStart.b("丸嘺堼䬾⁀╂ⱄ⭆ⱈ", num))) && (!(this.string_9 == BookmarkStart.b("䤸唺娼崾ⵀ⩂㕄", num)) && !(this.string_9 == BookmarkStart.b("尸嘺嬼崾ⵀ⩂㕄", num)))) && !(this.string_9 == BookmarkStart.b("吸娺帼伾⡀⁂ㅄ", num)))
            {
                item = this.method_91(this.string_8);
            }
            else
            {
                item = this.method_91(this.string_8);
            }
            if ((item.Height > 0f) && (item.Width > 0f))
            {
                this.class840_0.method_2().Add(item);
                this.class840_0.method_7().Add(this.class835_0);
            }
        }
        else if (this.bool_43)
        {
            DocPicture picture2 = new DocPicture(this.document_0);
            if (this.string_9 == BookmarkStart.b("嬸场吼伾㑀⩂⅄", num))
            {
                if (this.string_12 == BookmarkStart.b("䐸", num))
                {
                    picture2 = this.method_91(this.string_8);
                }
            }
            else if (((!(this.string_9 == BookmarkStart.b("匸䬺堼堾⍀⽂ⱄ㝆", num)) && !this.string_9.StartsWith(BookmarkStart.b("丸嘺堼䬾⁀╂ⱄ⭆ⱈ", num))) && (!(this.string_9 == BookmarkStart.b("䤸唺娼崾ⵀ⩂㕄", num)) && !(this.string_9 == BookmarkStart.b("尸嘺嬼崾ⵀ⩂㕄", num)))) && !(this.string_9 == BookmarkStart.b("吸娺帼伾⡀⁂ㅄ", num)))
            {
                picture2 = this.method_91(this.string_8);
            }
            else
            {
                picture2 = this.method_91(this.string_8);
            }
            if ((picture2.Width > 0f) && (picture2.Height > 0f))
            {
                this.class841_0.method_0().Add(picture2);
                this.class841_0.method_2().Add(this.class835_0.method_0());
            }
        }
        else if (this.string_12 == BookmarkStart.b("䐸", num))
        {
            this.byte_0 = this.method_90(this.string_8);
            this.docPicture_0 = new DocPicture(this.document_0);
            this.docPicture_0.LoadImage(this.byte_0);
            this.method_92(this.docPicture_0, this.class837_0);
        }
    }

    private void method_64()
    {
        int num = 15;
        string str = this.string_9;
        if (str == null)
        {
            return;
        }
        if (str == BookmarkStart.b("䔴䔶嘸䬺匼帾ⱀ♂", num))
        {
            this.string_21 = this.string_8;
            return;
        }
        if (!(str == BookmarkStart.b("䘴䌶堸伺吼尾㝀≂⥄", num)))
        {
            return;
        }
        PropertyType type = this.propertyType_0;
        if (type <= PropertyType.Bool)
        {
            switch (type)
            {
                case PropertyType.Int16:
                case PropertyType.Int32:
                    goto Label_00CD;

                case 4:
                    goto Label_00A7;

                case PropertyType.Double:
                    this.object_0 = Convert.ToDouble(this.string_8);
                    goto Label_00E3;
            }
            if (type != PropertyType.Bool)
            {
                goto Label_00A7;
            }
            this.object_0 = Convert.ToBoolean(Convert.ToInt32(this.string_8));
            goto Label_00E3;
        }
        switch (type)
        {
            case PropertyType.Int:
                goto Label_00CD;

            case PropertyType.DateTime:
                this.object_0 = Convert.ToDateTime(this.string_8);
                goto Label_00E3;
        }
    Label_00A7:
        this.object_0 = this.string_8;
        goto Label_00E3;
    Label_00CD:
        this.object_0 = Convert.ToInt32(this.string_8);
    Label_00E3:
        if ((this.string_21 != null) && (this.object_0 != null))
        {
            if (!this.document_0.CustomDocumentProperties.method_6(this.string_21))
            {
                this.document_0.CustomDocumentProperties.Add(this.string_21, this.object_0);
                this.document_0.CustomDocumentProperties[this.string_21].PropertyType = this.propertyType_0;
            }
            else
            {
                DocumentProperty property = new DocumentProperty(this.string_21, this.object_0, DocumentProperty.smethod_0(this.object_0));
                this.document_0.CustomDocumentProperties.method_8(this.string_21, property);
                this.document_0.CustomDocumentProperties[this.string_21].PropertyType = this.propertyType_0;
            }
        }
        this.string_21 = null;
        this.object_0 = null;
    }

    private void method_65()
    {
        int num = 4;
        string key = this.string_9;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_157 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                dictionary1.Add(BookmarkStart.b("帩䔫娭尯圱", num), 0);
                dictionary1.Add(BookmarkStart.b("䤩䴫娭唯唱嬳䐵䄷", num), 1);
                dictionary1.Add(BookmarkStart.b("丩䌫䴭匯崱夳嬵", num), 2);
                dictionary1.Add(BookmarkStart.b("䔩尫䬭䈯匱䀳夵䨷", num), 3);
                dictionary1.Add(BookmarkStart.b("䜩䴫䀭儯唱儳䐵", num), 4);
                dictionary1.Add(BookmarkStart.b("䤩䌫䌭䀯匱娳伵", num), 5);
                dictionary1.Add(BookmarkStart.b("䄩䤫圭䜯崱䘳刵䬷", num), 6);
                dictionary1.Add(BookmarkStart.b("天夫䰭娯圱圳䈵", num), 7);
                Class1160.dictionary_157 = dictionary1;
            }
            if (Class1160.dictionary_157.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.document_0.BuiltinDocumentProperties.Title = this.string_8;
                        return;

                    case 1:
                        this.document_0.BuiltinDocumentProperties.Category = this.string_8;
                        return;

                    case 2:
                        this.document_0.BuiltinDocumentProperties.Comments = this.string_8;
                        return;

                    case 3:
                        this.document_0.BuiltinDocumentProperties.Author = this.string_8;
                        return;

                    case 4:
                        this.document_0.BuiltinDocumentProperties.Manager = this.string_8;
                        return;

                    case 5:
                        this.document_0.BuiltinDocumentProperties.Company = this.string_8;
                        return;

                    case 6:
                        this.document_0.BuiltinDocumentProperties.Keywords = this.string_8;
                        return;

                    case 7:
                        this.document_0.BuiltinDocumentProperties.Subject = this.string_8;
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private string method_66(string A_0)
    {
        string str;
        int num = 1;
        if (A_0.Contains(BookmarkStart.b("ܦ", 1)))
        {
            int index = A_0.IndexOf(BookmarkStart.b("ܦ", num));
            str = A_0.Substring(0, index);
        }
        else
        {
            str = A_0;
        }
        return str.ToUpper(CultureInfo.InvariantCulture);
    }

    private void method_67()
    {
        Image image;
        int num = 0x12;
        string str = this.string_23.Trim();
        string fieldName = this.string_24;
        IField field = null;
        string str3 = this.method_66(str);
        string key = str3;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_158 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1b);
                dictionary1.Add(BookmarkStart.b("簷甹缻栽Ŀ၁ൃ݅ੇىो", num), 0);
                dictionary1.Add(BookmarkStart.b("样笹笻笽", num), 1);
                dictionary1.Add(BookmarkStart.b("瘷漹焻渽ĿՁŃᕅ", num), 2);
                dictionary1.Add(BookmarkStart.b("瀷挹氻笽ሿแൃࡅ͇", num), 3);
                dictionary1.Add(BookmarkStart.b("男缹渻礽Կсൃͅч้", num), 4);
                dictionary1.Add(BookmarkStart.b("瘷缹搻樽", num), 5);
                dictionary1.Add(BookmarkStart.b("瘷缹搻樽िс", num), 6);
                dictionary1.Add(BookmarkStart.b("样根画瀽ᐿفՃቅേ", num), 7);
                dictionary1.Add(BookmarkStart.b("笷根礻缽ᐿ݁C݅᱇ཉ", num), 8);
                dictionary1.Add(BookmarkStart.b("礷漹栻瘽༿၁", num), 9);
                dictionary1.Add(BookmarkStart.b("笷甹焻猽Կు၃ᕅ", num), 10);
                dictionary1.Add(BookmarkStart.b("猷缹攻椽༿၁Cᕅ", num), 11);
                dictionary1.Add(BookmarkStart.b("礷漹栻焽฿ᝁृ", num), 12);
                dictionary1.Add(BookmarkStart.b("瘷漹焻椽༿၁Cᕅ", num), 13);
                dictionary1.Add(BookmarkStart.b("焷琹稻焽", num), 14);
                dictionary1.Add(BookmarkStart.b("礷漹栻焽ᐿ݁᱃ቅ", num), 15);
                dictionary1.Add(BookmarkStart.b("欷笹樻笽п́၃ͅ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("焷簹", num), 0x11);
                dictionary1.Add(BookmarkStart.b("簷笹栻笽", num), 0x12);
                dictionary1.Add(BookmarkStart.b("氷猹焻笽", num), 0x13);
                dictionary1.Add(BookmarkStart.b("縷猹瀻笽฿́ृͅ", num), 20);
                dictionary1.Add(BookmarkStart.b("礷漹栻焽ᐿ݁᱃ቅч͉Ὃᩍ", num), 0x15);
                dictionary1.Add(BookmarkStart.b("欷挹焻簽༿แ", num), 0x16);
                dictionary1.Add(BookmarkStart.b("縷甹渻猽̿ੁŃՅ͇ࡉ͋ᙍ", num), 0x17);
                dictionary1.Add(BookmarkStart.b("縷甹渻猽ᐿ݁᱃ቅ", num), 0x18);
                dictionary1.Add(BookmarkStart.b("縷甹渻猽п၁ୃᙅేՉᭋM", num), 0x19);
                dictionary1.Add(BookmarkStart.b("焷琹缻爽ᔿفŃᙅŇॉᡋ᭍ɏᝑ", num), 0x1a);
                Class1160.dictionary_158 = dictionary1;
            }
            if (Class1160.dictionary_158.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldDocVariable);
                        goto Label_0C82;

                    case 1:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldPage);
                        goto Label_0C82;

                    case 2:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldNumPages);
                        goto Label_0C82;

                    case 3:
                        this.method_87(str, fieldName, string.Empty);
                        goto Label_0C82;

                    case 4:
                        this.method_84(str, fieldName);
                        goto Label_0C82;

                    case 5:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldNext);
                        goto Label_0C82;

                    case 6:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldNextIf);
                        goto Label_0C82;

                    case 7:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldPrintDate);
                        goto Label_0C82;

                    case 8:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldCreateDate);
                        goto Label_0C82;

                    case 9:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldAuthor);
                        goto Label_0C82;

                    case 10:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldComments);
                        goto Label_0C82;

                    case 11:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldKeyWord);
                        goto Label_0C82;

                    case 12:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldAutoNum);
                        goto Label_0C82;

                    case 13:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldNumWords);
                        goto Label_0C82;

                    case 14:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldInfo);
                        goto Label_0C82;

                    case 15:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldAutoText);
                        goto Label_0C82;

                    case 0x10:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldSaveDate);
                        goto Label_0C82;

                    case 0x11:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldIf);
                        goto Label_0C82;

                    case 0x12:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldData);
                        goto Label_0C82;

                    case 0x13:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldTime);
                        goto Label_0C82;

                    case 20:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldFileName);
                        goto Label_0C82;

                    case 0x15:
                        field = this.method_7().AppendField(fieldName, FieldType.FieldAutoTextList);
                        goto Label_0C82;

                    case 0x16:
                    {
                        if ((str.Contains(BookmarkStart.b("欷挹焻簽༿แ", num)) && (str.Length > 6)) && !char.IsWhiteSpace(str, 6))
                        {
                            str = str.Insert(6, BookmarkStart.b("ᠷ", num));
                        }
                        if (str.Contains(BookmarkStart.b("搷尹", num)))
                        {
                            int startIndex = str.IndexOf(BookmarkStart.b("搷尹", num));
                            if ((startIndex > 1) && !char.IsWhiteSpace(str, startIndex - 1))
                            {
                                str = str.Insert(startIndex, BookmarkStart.b("ᠷ", num));
                            }
                            startIndex = str.IndexOf(BookmarkStart.b("搷尹", num));
                            if (!char.IsWhiteSpace(str, startIndex + 2))
                            {
                                str = str.Insert(startIndex + 2, BookmarkStart.b("ᠷ", num));
                            }
                        }
                        if (str.Contains(BookmarkStart.b("搷䤹", num)))
                        {
                            int num10 = str.IndexOf(BookmarkStart.b("搷䤹", num));
                            if ((num10 > 1) && !char.IsWhiteSpace(str, num10 - 1))
                            {
                                str = str.Insert(num10, BookmarkStart.b("ᠷ", num));
                            }
                            num10 = str.IndexOf(BookmarkStart.b("搷䤹", num));
                            if (!char.IsWhiteSpace(str, num10 + 2))
                            {
                                str = str.Insert(num10 + 2, BookmarkStart.b("ᠷ", num));
                            }
                        }
                        string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        Symbol symbol = null;
                        int index = 0;
                        for (int i = 1; i < strArray.Length; i += 2)
                        {
                            if (strArray[index] == BookmarkStart.b("欷挹焻簽༿แ", num))
                            {
                                symbol = this.method_7().AppendSymbol(Convert.ToByte(strArray[i]));
                            }
                            if ((strArray[index] == BookmarkStart.b("搷尹", num)) && (symbol != null))
                            {
                                symbol.FontName = strArray[i].Replace(BookmarkStart.b("ᨷ", num), string.Empty);
                            }
                            if ((strArray[index] == BookmarkStart.b("搷䤹", num)) && (symbol != null))
                            {
                                symbol.CharacterFormat.FontSize = float.Parse(strArray[i], NumberStyles.Float);
                            }
                            if ((strArray[index].StartsWith(BookmarkStart.b("ᨷ", num)) && strArray[index].EndsWith(BookmarkStart.b("ᨷ", num))) && (symbol != null))
                            {
                                symbol.FontName = strArray[index].Replace(BookmarkStart.b("ᨷ", num), string.Empty);
                                symbol.CharacterFormat.FontSize = float.Parse(strArray[i], NumberStyles.Float);
                            }
                            index += 2;
                        }
                        this.method_169(symbol.CharacterFormat, this.class835_0);
                        symbol.CharacterFormat.FontName = symbol.FontName;
                        goto Label_0C82;
                    }
                    case 0x17:
                    {
                        if (this.method_7().ChildObjects.LastItem is BookmarkStart)
                        {
                            this.method_7().ChildObjects.RemoveAt(this.method_7().ChildObjects.Count - 1);
                        }
                        CheckBoxFormField field4 = null;
                        if ((this.class838_0.method_22() != null) && (this.document_0.Bookmarks[this.class838_0.method_22()] == null))
                        {
                            field4 = this.method_7().AppendCheckBox(this.class838_0.method_22(), false);
                        }
                        else
                        {
                            this.class838_0.method_23(this.class838_0.method_22() + this.int_22++.ToString());
                            field4 = this.method_7().AppendCheckBox(this.class838_0.method_22(), false);
                        }
                        this.method_169(field4.CharacterFormat, this.class835_0);
                        this.method_83(field4);
                        this.method_82(field4);
                        goto Label_0C82;
                    }
                    case 0x18:
                    {
                        if (this.method_7().ChildObjects.LastItem is BookmarkStart)
                        {
                            this.method_7().ChildObjects.RemoveAt(this.method_7().ChildObjects.Count - 1);
                        }
                        TextFormField field2 = null;
                        if ((this.class838_0.method_22() != null) && (this.document_0.Bookmarks[this.class838_0.method_22()] == null))
                        {
                            field2 = this.method_7().AppendTextFormField(this.class838_0.method_22(), (this.class838_0.method_8() != null) ? this.class838_0.method_8() : BookmarkStart.b("㨗㠙㸛㰝䈟", num));
                        }
                        else
                        {
                            this.class838_0.method_23(this.class838_0.method_22() + this.int_24++.ToString());
                            field2 = this.method_7().AppendTextFormField(this.class838_0.method_22(), (this.class838_0.method_8() != null) ? this.class838_0.method_8() : BookmarkStart.b("㨗㠙㸛㰝䈟", num));
                        }
                        if ((fieldName != null) && (fieldName != string.Empty))
                        {
                            field2.TextRange.Text = fieldName;
                        }
                        this.method_169(field2.TextRange.CharacterFormat, this.class835_0);
                        this.method_83(field2);
                        this.method_81(field2);
                        goto Label_0C82;
                    }
                    case 0x19:
                    {
                        if (this.method_7().ChildObjects.LastItem is BookmarkStart)
                        {
                            this.method_7().ChildObjects.RemoveAt(this.method_7().ChildObjects.Count - 1);
                        }
                        DropDownFormField field3 = null;
                        if ((this.class838_0.method_22() != null) && (this.document_0.Bookmarks[this.class838_0.method_22()] == null))
                        {
                            field3 = this.method_7().AppendDropDownFormField(this.class838_0.method_22());
                        }
                        else
                        {
                            this.class838_0.method_23(this.class838_0.method_22() + this.int_23++.ToString());
                            field3 = this.method_7().AppendDropDownFormField(this.class838_0.method_22());
                        }
                        for (int j = 0; j < this.class838_0.dropDownCollection_0.Count; j++)
                        {
                            if ((this.class838_0.dropDownCollection_0[j].Text != null) && (this.class838_0.dropDownCollection_0[j].Text != string.Empty))
                            {
                                field3.DropDownItems.Add(this.class838_0.dropDownCollection_0[j].Text);
                            }
                        }
                        this.method_169(field3.CharacterFormat, this.class835_0);
                        this.method_83(field3);
                        this.method_80(field3);
                        goto Label_0C82;
                    }
                    case 0x1a:
                    {
                        string[] strArray2 = str.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
                        if (strArray2.Length <= 1)
                        {
                            goto Label_0C82;
                        }
                        string path = string.Empty;
                        if (strArray2[1].Contains(BookmarkStart.b("ȷ", num)))
                        {
                            path = this.method_75(strArray2[1]);
                        }
                        else
                        {
                            path = BookmarkStart.b("搷昹", num) + this.method_75(strArray2[1]);
                            if (!File.Exists(path))
                            {
                                path = Path.GetDirectoryName(this.document_0.FileName) + BookmarkStart.b("搷", num) + this.method_75(strArray2[1]);
                            }
                        }
                        image = null;
                        if (File.Exists(path))
                        {
                            image = Image.FromFile(path);
                        }
                        else
                        {
                            if (Uri.IsWellFormedUriString(path, UriKind.Absolute))
                            {
                                using (WebClient client = new WebClient())
                                {
                                    using (Stream stream = client.OpenRead(path))
                                    {
                                        image = Image.FromStream(stream);
                                    }
                                    goto Label_0C1B;
                                }
                            }
                            string name = BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝ၟୡݣብᵧᡩ५ㅭṯᵱsၵ᝷ཹቻ᩽깿", num);
                            image = Image.FromStream(Assembly.GetCallingAssembly().GetManifestResourceStream(name));
                        }
                        goto Label_0C1B;
                    }
                }
            }
        }
        field = this.method_7().AppendField(fieldName, FieldType.FieldUnknown);
        goto Label_0C82;
    Label_0C1B:
        if (image != null)
        {
            DocPicture picture = this.method_7().AppendPicture(image);
            if (picture.Width > 1584f)
            {
                float num7 = (this.method_10().PageSetup.ClientWidth / picture.Width) * 100f;
                picture.WidthScale = num7;
                picture.HeightScale = num7;
            }
        }
    Label_0C82:
        if (field != null)
        {
            (field as Field).Code = str;
            (field as Field).FormattingString = this.method_78(str, str3);
            if ((str3 == BookmarkStart.b("簷笹栻笽", num)) || (str3 == BookmarkStart.b("氷猹焻笽", num)))
            {
                (field as Field).method_49();
            }
            this.method_169(field.CharacterFormat, this.class835_0);
            if ((((field.Type == FieldType.FieldPage) || (field.Type == FieldType.FieldNumPages)) || ((field.Type == FieldType.FieldDate) || (field.Type == FieldType.FieldTime))) && (((((field as Field).NextSibling != null) && ((field as Field).NextSibling.DocumentObjectType == DocumentObjectType.FieldMark)) && ((((field as Field).NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator) && ((field as Field).NextSibling.NextSibling != null))) && ((field as Field).NextSibling.NextSibling.DocumentObjectType == DocumentObjectType.TextRange)))
            {
                this.method_169(((field as Field).NextSibling.NextSibling as TextRange).CharacterFormat, this.class835_0);
            }
        }
    }

    private IField method_68(Class840 A_0, int A_1)
    {
        IField field = null;
        string str = string.Empty;
        bool flag = false;
        Class841 class2 = (A_0.method_4().Count > 0) ? (A_0.method_4()[0] as Class841) : null;
        if ((class2 != null) && (class2.method_0()[0] is string))
        {
            flag = true;
            str = class2.method_0()[0].ToString();
        }
        field = this.method_70(str, A_0.method_6(), A_1);
        (field as Field).Code = A_0.method_1();
        int index = this.method_7().Items.IndexOf((field as Field).Separator);
        int num3 = 1;
        while (num3 < A_0.method_2().Count)
        {
            if (A_0.method_2()[num3] is string)
            {
                TextRange range = new TextRange(this.document_0) {
                    Text = A_0.method_2()[num3].ToString()
                };
                this.method_59(index, range);
            }
            else if (A_0.method_2()[num3] is Class840)
            {
                int count = this.method_7().Items.Count;
                this.method_68(A_0.method_2()[num3] as Class840, index);
                index += (this.method_7().Items.Count - count) - 1;
            }
            else
            {
                this.method_59(index, A_0.method_2()[num3] as IDocumentObject);
            }
            num3++;
            index++;
        }
        index = this.method_7().Items.IndexOf((field as Field).End);
        for (int i = 0; i < class2.method_0().Count; i++)
        {
            if (flag)
            {
                flag = false;
            }
            else
            {
                if (class2.method_0()[i] is string)
                {
                    TextRange range2 = new TextRange(this.document_0) {
                        Text = class2.method_0()[i].ToString()
                    };
                    this.method_59(index, range2);
                }
                else
                {
                    this.method_59(index, class2.method_0()[i] as IDocumentObject);
                }
                index++;
            }
        }
        return field;
    }

    private IField method_69(Class840 A_0)
    {
        IField field = null;
        field = new IfField(this.document_0);
        (field as Field).Code = A_0.method_1();
        (field as Field).Type = A_0.method_6();
        this.method_58(field);
        for (int i = 1; i < A_0.method_2().Count; i++)
        {
            if (A_0.method_2()[i] is string)
            {
                TextRange range = new TextRange(this.document_0) {
                    Text = A_0.method_2()[i].ToString()
                };
                this.method_58(range);
            }
            else if (A_0.method_2()[i] is Class840)
            {
                this.method_68(A_0.method_2()[i] as Class840, this.method_7().Items.Count);
            }
            else
            {
                this.method_58(A_0.method_2()[i] as IDocumentObject);
            }
        }
        for (int j = 0; j < A_0.method_4().Count; j++)
        {
            if (j == 0)
            {
                FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
                this.method_58(mark2);
                (field as Field).Separator = mark2;
            }
            Class841 class2 = A_0.method_4()[j] as Class841;
            if (class2 != null)
            {
                for (int k = 0; k < class2.method_0().Count; k++)
                {
                    if (class2.method_0()[k] is string)
                    {
                        TextRange range2 = new TextRange(this.document_0) {
                            Text = class2.method_0()[k].ToString()
                        };
                        this.method_58(range2);
                    }
                    else
                    {
                        this.method_58(class2.method_0()[k] as IDocumentObject);
                    }
                }
            }
            else
            {
                this.method_68(A_0.method_4()[j] as Class840, this.method_7().Items.Count);
            }
        }
        FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
        this.method_58(mark);
        (field as Field).End = mark;
        return field;
    }

    protected Paragraph method_7()
    {
        if (this.iparagraph_0 == null)
        {
            this.iparagraph_0 = new Paragraph(this.document_0);
            this.method_139(this.iparagraph_0.Format);
        }
        return (this.iparagraph_0 as Paragraph);
    }

    private IField method_70(string A_0, FieldType A_1, int A_2)
    {
        int num = 9;
        IField field = null;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䤮堰嘲头匶眸娺值娾", num));
        }
        if (A_1 == FieldType.FieldMergeField)
        {
            MergeField field2 = new MergeField(this.document_0) {
                FieldName = A_0
            };
            field = field2;
        }
        else if (A_1 == FieldType.FieldSequence)
        {
            field = new SequenceField(this.document_0);
        }
        else
        {
            field = new Field(this.document_0);
        }
        field.Type = A_1;
        if (field.Type == FieldType.FieldFormula)
        {
            A_0 = A_0.Replace(BookmarkStart.b("༮", num), string.Empty);
            A_0 = A_0.Replace(BookmarkStart.b("മ", num), string.Empty);
            A_0 = A_0.Replace(BookmarkStart.b("ሮ", num), string.Empty);
        }
        if ((A_0.IndexOf(' ') != -1) && (field.Type != FieldType.FieldIndex))
        {
            (field as Field).m_fieldValue = BookmarkStart.b("മ", num) + A_0 + BookmarkStart.b("മ", num);
        }
        else
        {
            (field as Field).m_fieldValue = A_0;
        }
        if (A_1 == FieldType.FieldDocVariable)
        {
            (field as Field).m_formattingString = BookmarkStart.b("献ᬰጲ破父欸簺砼社เᅂࡄنᵈ", num);
        }
        this.method_59(A_2++, field);
        if ((field.Type != FieldType.FieldMergeField) && (field.Type != FieldType.FieldNext))
        {
            FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
            this.method_59(A_2++, mark);
            (field as Field).Separator = mark;
        }
        if ((A_1 != FieldType.FieldMergeField) && (A_1 != FieldType.FieldNext))
        {
            if (A_1 != FieldType.FieldSequence)
            {
                TextRange range = new TextRange(this.document_0) {
                    Text = A_0
                };
                this.method_59(A_2++, range);
                if (A_1 == FieldType.FieldHyperlink)
                {
                    range.CharacterFormat.method_55(Color.Blue);
                    range.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                }
            }
            FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
            this.method_59(A_2++, mark2);
            (field as Field).End = mark2;
        }
        return field;
    }

    private void method_71(Class840 A_0)
    {
        DocPicture picture;
        Image image;
        int num = 10;
        Class841 class2 = (A_0.method_4().Count > 0) ? (A_0.method_4()[0] as Class841) : null;
        string str2 = A_0.method_1().Trim();
        string fieldName = (class2 != null) ? ((class2.method_0().Count > 0) ? ((class2.method_0()[0] is string) ? class2.method_0()[0].ToString() : string.Empty) : string.Empty) : string.Empty;
        this.class835_0 = (class2 != null) ? ((class2.method_0().Count > 0) ? class2.method_2()[0] : A_0.method_7()[0]) : A_0.method_7()[0];
        IField field3 = null;
        string str5 = this.method_66(str2);
        string key = str5;
        if (key != null)
        {
            int num5;
            if (Class1160.dictionary_159 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x22);
                dictionary1.Add(BookmarkStart.b("甯挱", num), 0);
                dictionary1.Add(BookmarkStart.b("搯紱眳", num), 1);
                dictionary1.Add(BookmarkStart.b("愯朱笳戵紷", num), 2);
                dictionary1.Add(BookmarkStart.b("振眱攳", num), 3);
                dictionary1.Add(BookmarkStart.b("琯紱眳怵礷根画缽ȿแŃ", num), 4);
                dictionary1.Add(BookmarkStart.b("怯猱猳猵", num), 5);
                dictionary1.Add(BookmarkStart.b("怯猱猳猵樷缹稻", num), 6);
                dictionary1.Add(BookmarkStart.b("縯朱礳昵礷紹礻洽", num), 7);
                dictionary1.Add(BookmarkStart.b("砯欱搳猵樷瘹画瀽ି", num), 8);
                dictionary1.Add(BookmarkStart.b("累眱昳焵紷簹画笽ిف", num), 9);
                dictionary1.Add(BookmarkStart.b("縯眱氳戵", num), 10);
                dictionary1.Add(BookmarkStart.b("縯眱氳戵焷簹", num), 11);
                dictionary1.Add(BookmarkStart.b("怯怱紳砵氷縹紻樽Կ", num), 12);
                dictionary1.Add(BookmarkStart.b("猯怱焳眵氷缹砻缽ᐿ݁", num), 13);
                dictionary1.Add(BookmarkStart.b("瘯笱砳猵瘷笹焻笽", num), 14);
                dictionary1.Add(BookmarkStart.b("焯朱怳礵氷缹搻樽ిୁᝃቅ", num), 15);
                dictionary1.Add(BookmarkStart.b("焯朱怳縵眷根", num), 0x10);
                dictionary1.Add(BookmarkStart.b("猯紱礳笵紷琹栻洽", num), 0x11);
                dictionary1.Add(BookmarkStart.b("笯眱洳愵眷根砻洽", num), 0x12);
                dictionary1.Add(BookmarkStart.b("焯朱怳礵瘷漹焻", num), 0x13);
                dictionary1.Add(BookmarkStart.b("縯朱礳愵眷根砻洽", num), 20);
                dictionary1.Add(BookmarkStart.b("礯簱爳礵", num), 0x15);
                dictionary1.Add(BookmarkStart.b("焯朱怳礵氷缹搻樽", num), 0x16);
                dictionary1.Add(BookmarkStart.b("振猱戳猵簷笹栻笽", num), 0x17);
                dictionary1.Add(BookmarkStart.b("礯琱", num), 0x18);
                dictionary1.Add(BookmarkStart.b("琯猱怳猵", num), 0x19);
                dictionary1.Add(BookmarkStart.b("搯笱礳猵", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("戯眱爳", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("振欱礳琵眷瘹", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("瘯紱昳笵笷爹礻紽ିAୃṅ", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("瘯紱昳笵氷缹搻樽", num), 30);
                dictionary1.Add(BookmarkStart.b("瘯紱昳笵簷根猻渽пുፃࡅ", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("礯簱眳稵洷縹礻渽िŁ၃ፅᩇཉ", num), 0x20);
                dictionary1.Add(BookmarkStart.b("礯簱眳稵洷縹礻樽Կᩁ၃", num), 0x21);
                Class1160.dictionary_159 = dictionary1;
            }
            if (Class1160.dictionary_159.TryGetValue(key, out num5))
            {
                FieldMark mark;
                switch (num5)
                {
                    case 0:
                        if (!A_0.method_0())
                        {
                            field3 = this.method_7().AppendField(fieldName, FieldType.FieldUnknown);
                        }
                        else
                        {
                            Class2 class3 = new Class2(this.document_0);
                            this.method_169(class3.CharacterFormat, this.class835_0);
                            class3.method_60(A_0.method_1());
                            this.method_58(class3);
                        }
                        goto Label_0F4C;

                    case 1:
                        this.method_85(A_0);
                        goto Label_0F4C;

                    case 2:
                        field3 = this.method_68(A_0, this.method_7().Items.Count);
                        goto Label_0F4C;

                    case 3:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldSequence);
                        goto Label_0F4C;

                    case 4:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldDocVariable);
                        goto Label_0F4C;

                    case 5:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldPage);
                        goto Label_0F4C;

                    case 6:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldPageRef);
                        goto Label_0F4C;

                    case 7:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldNumPages);
                        goto Label_0F4C;

                    case 8:
                    {
                        if ((((A_0.method_4().Count <= 0) || !(A_0.method_4()[0] is Class840)) || (((A_0.method_4()[0] as Class840).method_6() != FieldType.FieldIncludePicture) || ((A_0.method_4()[0] as Class840).method_4().Count <= 0))) || ((!((A_0.method_4()[0] as Class840).method_4()[0] is Class841) || (((A_0.method_4()[0] as Class840).method_4()[0] as Class841).method_0().Count <= 0)) || !(((A_0.method_4()[0] as Class840).method_4()[0] as Class841).method_0()[0] is DocPicture)))
                        {
                            if (((A_0.method_4().Count > 0) && (A_0.method_4()[0] is Class841)) && (((A_0.method_4()[0] as Class841).method_0().Count > 0) && ((A_0.method_4()[0] as Class841).method_0()[0] is DocPicture)))
                            {
                                this.docPicture_0 = (A_0.method_4()[0] as Class841).method_0()[0] as DocPicture;
                            }
                        }
                        else
                        {
                            this.docPicture_0 = ((A_0.method_4()[0] as Class840).method_4()[0] as Class841).method_0()[0] as DocPicture;
                        }
                        string str6 = this.method_74(A_0.method_11(), FieldType.FieldHyperlink);
                        this.method_87(str2, fieldName, str6);
                        goto Label_0F4C;
                    }
                    case 9:
                        this.method_84(str2, fieldName);
                        goto Label_0F4C;

                    case 10:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldNext);
                        goto Label_0F4C;

                    case 11:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldNextIf);
                        goto Label_0F4C;

                    case 12:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldPrintDate);
                        goto Label_0F4C;

                    case 13:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldCreateDate);
                        goto Label_0F4C;

                    case 14:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldFileName);
                        goto Label_0F4C;

                    case 15:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldAutoTextList);
                        goto Label_0F4C;

                    case 0x10:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldAuthor);
                        goto Label_0F4C;

                    case 0x11:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldComments);
                        goto Label_0F4C;

                    case 0x12:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldKeyWord);
                        goto Label_0F4C;

                    case 0x13:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldAutoNum);
                        goto Label_0F4C;

                    case 20:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldNumWords);
                        goto Label_0F4C;

                    case 0x15:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldInfo);
                        goto Label_0F4C;

                    case 0x16:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldAutoText);
                        goto Label_0F4C;

                    case 0x17:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldSaveDate);
                        goto Label_0F4C;

                    case 0x18:
                        field3 = this.method_69(A_0);
                        goto Label_0F4C;

                    case 0x19:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldDate);
                        goto Label_0F4C;

                    case 0x1a:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldTime);
                        goto Label_0F4C;

                    case 0x1b:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldRef);
                        goto Label_0F4C;

                    case 0x1c:
                    {
                        if ((str2.Contains(BookmarkStart.b("振欱礳琵眷瘹", num)) && (str2.Length > 6)) && !char.IsWhiteSpace(str2, 6))
                        {
                            str2 = str2.Insert(6, BookmarkStart.b("ု", num));
                        }
                        if (str2.Contains(BookmarkStart.b("氯吱", num)))
                        {
                            int startIndex = str2.IndexOf(BookmarkStart.b("氯吱", num));
                            if ((startIndex > 1) && !char.IsWhiteSpace(str2, startIndex - 1))
                            {
                                str2 = str2.Insert(startIndex, BookmarkStart.b("ု", num));
                            }
                            startIndex = str2.IndexOf(BookmarkStart.b("氯吱", num));
                            if (!char.IsWhiteSpace(str2, startIndex + 2))
                            {
                                str2 = str2.Insert(startIndex + 2, BookmarkStart.b("ု", num));
                            }
                        }
                        if (str2.Contains(BookmarkStart.b("氯䄱", num)))
                        {
                            int num7 = str2.IndexOf(BookmarkStart.b("氯䄱", num));
                            if ((num7 > 1) && !char.IsWhiteSpace(str2, num7 - 1))
                            {
                                str2 = str2.Insert(num7, BookmarkStart.b("ု", num));
                            }
                            num7 = str2.IndexOf(BookmarkStart.b("氯䄱", num));
                            if (!char.IsWhiteSpace(str2, num7 + 2))
                            {
                                str2 = str2.Insert(num7 + 2, BookmarkStart.b("ု", num));
                            }
                        }
                        string[] strArray = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        Symbol symbol = null;
                        int index = 0;
                        for (int i = 1; i < strArray.Length; i += 2)
                        {
                            if (strArray[index] == BookmarkStart.b("振欱礳琵眷瘹", num))
                            {
                                symbol = this.method_7().AppendSymbol(Convert.ToByte(strArray[i]));
                            }
                            if ((strArray[index] == BookmarkStart.b("氯吱", num)) && (symbol != null))
                            {
                                symbol.FontName = strArray[i].Replace(BookmarkStart.b("ሯ", num), string.Empty);
                            }
                            if ((strArray[index] == BookmarkStart.b("氯䄱", num)) && (symbol != null))
                            {
                                symbol.CharacterFormat.FontSize = float.Parse(strArray[i], NumberStyles.Float);
                            }
                            if ((strArray[index].StartsWith(BookmarkStart.b("ሯ", num)) && strArray[index].EndsWith(BookmarkStart.b("ሯ", num))) && (symbol != null))
                            {
                                symbol.FontName = strArray[index].Replace(BookmarkStart.b("ሯ", num), string.Empty);
                                symbol.CharacterFormat.FontSize = float.Parse(strArray[i], NumberStyles.Float);
                            }
                            index += 2;
                        }
                        this.method_169(symbol.CharacterFormat, this.class835_0);
                        symbol.CharacterFormat.FontName = symbol.FontName;
                        goto Label_0F4C;
                    }
                    case 0x1d:
                    {
                        CheckBoxFormField field4 = null;
                        field4 = this.method_7().AppendCheckBox(this.class838_0.method_22(), false);
                        this.method_169(field4.CharacterFormat, this.class835_0);
                        this.method_83(field4);
                        this.method_82(field4);
                        mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                        field4.End = mark;
                        this.method_58(mark);
                        goto Label_0F4C;
                    }
                    case 30:
                    {
                        TextFormField field2 = null;
                        field2 = this.method_7().AppendTextFormField(this.class838_0.method_22(), (this.class838_0.method_8() != null) ? this.class838_0.method_8() : BookmarkStart.b("㈏】㘓㐕㨗", num));
                        field2.TextFieldType = this.class838_0.method_10();
                        if ((fieldName != null) && (fieldName != string.Empty))
                        {
                            field2.TextRange.Text = fieldName;
                        }
                        this.method_169(field2.TextRange.CharacterFormat, this.class835_0);
                        this.method_83(field2);
                        this.method_81(field2);
                        this.method_58(new FieldMark(this.document_0, FieldMarkType.FieldSeparator));
                        TextRange entity = new TextRange(this.document_0) {
                            Text = string.IsNullOrEmpty(fieldName) ? this.class838_0.method_8() : fieldName
                        };
                        this.method_169(entity.CharacterFormat, this.class835_0);
                        this.method_7().ChildObjects.Add(entity);
                        mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                        field2.End = mark;
                        this.method_58(mark);
                        goto Label_0F4C;
                    }
                    case 0x1f:
                    {
                        DropDownFormField field = null;
                        field = this.method_7().AppendDropDownFormField(this.class838_0.method_22());
                        for (int j = 0; j < this.class838_0.dropDownCollection_0.Count; j++)
                        {
                            if ((this.class838_0.dropDownCollection_0[j].Text != null) && (this.class838_0.dropDownCollection_0[j].Text != string.Empty))
                            {
                                field.DropDownItems.Add(this.class838_0.dropDownCollection_0[j].Text);
                            }
                        }
                        this.method_169(field.CharacterFormat, this.class835_0);
                        this.method_169(field.CharacterFormat, this.class835_0);
                        this.method_83(field);
                        this.method_80(field);
                        mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                        field.End = mark;
                        this.method_58(mark);
                        goto Label_0F4C;
                    }
                    case 0x20:
                    {
                        string[] strArray2 = str2.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
                        if (strArray2.Length <= 1)
                        {
                            goto Label_0F4C;
                        }
                        string path = string.Empty;
                        if (strArray2[1].Contains(BookmarkStart.b("ਯ", num)))
                        {
                            path = this.method_75(strArray2[1]);
                        }
                        else
                        {
                            path = BookmarkStart.b("氯渱", num) + this.method_75(strArray2[1]);
                            if (!File.Exists(path))
                            {
                                path = Path.GetDirectoryName(this.document_0.FileName) + BookmarkStart.b("氯", num) + this.method_75(strArray2[1]);
                            }
                        }
                        image = null;
                        picture = null;
                        if (File.Exists(path))
                        {
                            image = Image.FromFile(path);
                        }
                        else
                        {
                            if (Uri.IsWellFormedUriString(path, UriKind.Absolute))
                            {
                                using (WebClient client = new WebClient())
                                {
                                    try
                                    {
                                        using (Stream stream = client.OpenRead(path))
                                        {
                                            image = Image.FromStream(stream);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        picture = A_0.method_18();
                                        if (picture == null)
                                        {
                                            image = this.method_73();
                                        }
                                    }
                                    goto Label_0EB7;
                                }
                            }
                            image = this.method_73();
                        }
                        goto Label_0EB7;
                    }
                    case 0x21:
                        field3 = this.method_7().AppendField(fieldName, FieldType.FieldIncludeText);
                        goto Label_0F4C;
                }
            }
        }
        field3 = this.method_7().AppendField(fieldName, FieldType.FieldUnknown);
        goto Label_0F4C;
    Label_0EB7:
        if (image != null)
        {
            DocPicture picture2 = this.method_7().AppendPicture(image);
            if (picture2.Width > 1584f)
            {
                float num8 = (this.method_10().PageSetup.ClientWidth / picture2.Width) * 100f;
                picture2.WidthScale = num8;
                picture2.HeightScale = num8;
            }
        }
        else if (picture != null)
        {
            this.method_7().Items.Add(picture);
        }
    Label_0F4C:
        if (field3 != null)
        {
            (field3 as Field).Code = A_0.method_1();
            (field3 as Field).FormattingString = this.method_79(str2);
            (field3 as Field).IsLocked = A_0.method_13();
            (field3 as Field).IsDirty = A_0.method_15();
            if ((str5 == BookmarkStart.b("琯猱怳猵", num)) || (str5 == BookmarkStart.b("搯笱礳猵", num)))
            {
                (field3 as Field).method_49();
            }
            this.method_169(field3.CharacterFormat, this.class835_0);
            if (((((field3 as Field).NextSibling != null) && ((field3 as Field).NextSibling is FieldMark)) && ((((field3 as Field).NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator) && ((field3 as Field).NextSibling.NextSibling != null))) && ((field3 as Field).NextSibling.NextSibling.DocumentObjectType == DocumentObjectType.TextRange))
            {
                this.method_169(((field3 as Field).NextSibling.NextSibling as TextRange).CharacterFormat, this.class835_0);
                this.method_72((field3 as Field).NextSibling.NextSibling as TextRange, field3 as Field);
            }
        }
    }

    private void method_72(TextRange A_0, Field A_1)
    {
        string str = string.Empty;
        str = A_0.Text.Replace(Class816.string_4, Class816.string_27).Replace('\n', '\r');
        if (str.Contains(Class816.string_27))
        {
            int index = str.IndexOf(Class816.string_27);
            string str2 = str.Substring(index + 1);
            TextRange entity = A_0.Clone() as TextRange;
            if (index > 0)
            {
                entity.Text = str.Substring(index + 1);
                A_0.Text = str.Substring(0, index);
            }
            else if (str2 != string.Empty)
            {
                entity.Text = str2;
                A_0.Text = string.Empty;
            }
            Paragraph ownerParagraph = A_0.OwnerParagraph;
            Paragraph item = ownerParagraph.Clone() as Paragraph;
            item.method_57();
            this.list_0.Add(item);
            item.Items.Add(entity);
            if (str == Class816.string_27)
            {
                A_0.Text = string.Empty;
                entity.Text = string.Empty;
            }
            ParagraphItemCollection items = ownerParagraph.Items;
            if (items != null)
            {
                int num2 = items.IndexOf(A_0);
                item.method_68(items, num2 + 1, A_1);
            }
            this.method_72(entity, A_1);
        }
    }

    private Image method_73()
    {
        string name = BookmarkStart.b("戰䌲尴䔶尸ᔺ礼倾≀浂ᝄ≆㩈⑊㡌㵎㉐㙒♔祖⥘㉚㹜⭞ᑠᅢd㡦ݨѪᥬ८Ṱٲ᭴፶坸ᅺർ᡾", 11);
        return Image.FromStream(Assembly.GetCallingAssembly().GetManifestResourceStream(name));
    }

    private string method_74(string A_0, FieldType A_1)
    {
        int num = 2;
        string str = string.Empty;
        if (!string.IsNullOrEmpty(A_0))
        {
            if (A_0.Contains(BookmarkStart.b("ἧጩᤫᘭ࠯̱刳ȵଷ堹഻娽眿⑁灃繅⥇ⱉ繋ⵍ桏恑慓㉕㭗湙摛歝剟啡剣啥塧婩屫幭䁯䉱䑳䙵᥷佹ᵻᱽ끿늁뒃뚅", num)))
            {
                A_0 = A_0.Substring(0, A_0.LastIndexOf(BookmarkStart.b("ἧጩᤫᘭ࠯̱刳ȵଷ堹഻娽眿⑁灃繅⥇ⱉ繋ⵍ桏恑慓㉕㭗湙摛歝剟啡剣啥塧婩屫幭䁯䉱䑳䙵᥷佹ᵻᱽ끿늁뒃뚅", num)) + 0x30);
            }
            byte[] sourceArray = Class57.smethod_14(A_0);
            if (A_1 == FieldType.FieldHyperlink)
            {
                int num2 = 0x44;
                if (sourceArray.Length > 0x44)
                {
                    int length = sourceArray.Length - num2;
                    byte[] destinationArray = new byte[length];
                    Array.Copy(sourceArray, 0x2c, destinationArray, 0, length);
                    str = Encoding.ASCII.GetString(destinationArray, 0, length).Replace(BookmarkStart.b("⠧", num), string.Empty);
                }
            }
        }
        return str;
    }

    private string method_75(string A_0)
    {
        return this.method_76(A_0, false);
    }

    private string method_76(string A_0, bool A_1)
    {
        int num = 7;
        A_0 = A_0.Trim();
        if (string.IsNullOrEmpty(A_0))
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder();
        string[] strArray = A_1 ? A_0.Split(new char[] { '\\' }) : A_0.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        int index = 0;
        int length = strArray.Length;
        while (index < length)
        {
            builder.Append(strArray[index].Trim(new char[] { ' ' }));
            if ((length > 1) && (index < (length - 1)))
            {
                builder.Append(BookmarkStart.b("焬", num));
            }
            index++;
        }
        return builder.ToString();
    }

    private List<object> method_77(Class840 A_0)
    {
        List<object> list = new List<object>();
        if (A_0 != null)
        {
            this.method_71(A_0);
            list = A_0.method_4();
            if (((list.Count > 1) && (list[1] is Class840)) && (A_0.method_6() != FieldType.FieldTOC))
            {
                list = this.method_77(list[1] as Class840);
            }
        }
        return list;
    }

    private string method_78(string A_0, string A_1)
    {
        return A_0.Replace(A_1, string.Empty).Trim();
    }

    private string method_79(string A_0)
    {
        int num = 14;
        string str = string.Empty;
        int index = A_0.IndexOf(BookmarkStart.b("栳瘵", 14));
        if (index == -1)
        {
            index = A_0.IndexOf(BookmarkStart.b("栳ᰵ", num));
        }
        if (index > -1)
        {
            str = A_0.Substring(index);
        }
        return str;
    }

    protected Column method_8()
    {
        if (this.column_0 == null)
        {
            this.column_0 = this.method_10().AddColumn(0f, 0f);
        }
        return this.column_0;
    }

    private void method_80(DropDownFormField A_0)
    {
        A_0.DefaultDropDownValue = this.class838_0.int_3;
    }

    private void method_81(TextFormField A_0)
    {
        int num = 3;
        if (((this.class838_0.method_8() == null) && (this.class838_0.method_4() < BookmarkStart.b("⬈⤊⼌ⴎ㌐", num).Length)) && (this.class838_0.method_4() != 0))
        {
            A_0.DefaultText = string.Empty;
        }
        else
        {
            A_0.DefaultText = (this.class838_0.method_8() != null) ? this.class838_0.method_8() : BookmarkStart.b("⬈⤊⼌ⴎ㌐", num);
        }
        if (this.class838_0.method_4() > 0)
        {
            A_0.MaximumLength = this.class838_0.method_4();
        }
        A_0.StringFormat = (this.class838_0.method_6() != null) ? this.class838_0.method_6() : string.Empty;
    }

    private void method_82(CheckBoxFormField A_0)
    {
        A_0.SizeType = this.class838_0.method_12();
        A_0.CheckBoxSize = this.class838_0.method_14();
        A_0.Checked = this.class838_0.method_0();
    }

    private void method_83(FormField A_0)
    {
        if ((this.class838_0.method_22() != null) && (this.document_0.Bookmarks[this.class838_0.method_22()] == null))
        {
            A_0.Name = this.class838_0.method_22();
        }
        A_0.Help = this.class838_0.method_24();
        A_0.StatusBarHelp = this.class838_0.method_28();
        A_0.MacroOnStart = this.class838_0.method_20();
        A_0.MacroOnEnd = this.class838_0.method_18();
        A_0.Enabled = this.class838_0.method_16();
        A_0.CalculateOnExit = this.class838_0.method_26();
    }

    private void method_84(string A_0, string A_1)
    {
        char ch = '\x00ab';
        char ch2 = '\x00bb';
        string fieldName = A_1.Replace(ch.ToString(), string.Empty).Replace(ch2.ToString(), string.Empty);
        MergeField field = this.method_7().AppendField(fieldName, FieldType.FieldMergeField) as MergeField;
        field.Text = A_1;
        field.Code = A_0;
        field.FormattingString = this.method_79(A_0);
        this.method_169(field.CharacterFormat, this.class835_0);
    }

    private void method_85(Class840 A_0)
    {
        this.iparagraph_0 = new Paragraph(this.document_0);
        this.method_139(this.method_7().Format);
        string switches = A_0.method_1().Substring(5);
        TableOfContent content = new TableOfContent(this.document_0, switches);
        this.document_0.TOC = content;
        content.FormattingString = switches;
        this.method_58(content);
        this.method_7().IsTOCPara = true;
        FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
        this.method_58(mark);
        content.TOCField.Separator = mark;
        for (int i = 0; i < A_0.method_4().Count; i++)
        {
            if (i > 1)
            {
                this.iparagraph_0 = new Paragraph(this.document_0);
                this.method_139(this.method_7().Format);
            }
            if (A_0.method_4()[i] is Class840)
            {
                this.method_94((A_0.method_4()[i] as Class840).method_9(), this.method_7().Format);
                this.method_77(A_0.method_4()[i] as Class840);
                this.method_162(this.method_7());
            }
            else if (A_0.method_4()[i] is Class841)
            {
                this.method_94(A_0.method_9(), this.method_7().Format);
                List<object> list = (A_0.method_4()[i] as Class841).method_0();
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] is string)
                    {
                        TextRange range = new TextRange(this.document_0) {
                            Text = list[j] as string
                        };
                        this.method_169(range.CharacterFormat, A_0.method_7()[i]);
                        this.method_58(range);
                    }
                    else
                    {
                        this.method_58(list[j] as IDocumentObject);
                    }
                }
            }
        }
        FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
        this.method_58(mark2);
    }

    private string method_86(string A_0)
    {
        int num = 8;
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        int startIndex = A_0.IndexOf(BookmarkStart.b("భ", num)) + 1;
        int num2 = A_0.LastIndexOf(BookmarkStart.b("భ", num));
        if ((startIndex == 0) && (num2 == -1))
        {
            return A_0.Replace(BookmarkStart.b("昭椯戱焳搵琷猹爻甽", num), string.Empty).Trim();
        }
        if (num2 > startIndex)
        {
            return A_0.Substring(startIndex, num2 - startIndex);
        }
        return A_0.Substring(startIndex);
    }

    private void method_87(string A_0, string A_1, string A_2)
    {
        int num = 0x13;
        int num2 = A_0.IndexOf(BookmarkStart.b("ᬸ", 0x13)) + 1;
        string str = this.method_86(A_0);
        Field field2 = this.method_7().AppendField(A_1, FieldType.FieldHyperlink) as Field;
        field2.Code = A_0;
        field2.RtfDataFieldTag = A_2;
        Hyperlink hyperlink = new Hyperlink(field2);
        str = (string.IsNullOrEmpty(A_2) || str.Equals(A_2)) ? str : A_2;
        if (str.StartsWith(BookmarkStart.b("吸娺吼匾㕀ⱂ罄", num)))
        {
            hyperlink.Type = HyperlinkType.EMailLink;
            hyperlink.Uri = str;
        }
        else if ((!str.StartsWith(BookmarkStart.b("儸伺䤼伾", num)) && !str.StartsWith(BookmarkStart.b("丸䰺䨼", num))) && (!str.StartsWith(BookmarkStart.b("弸伺䴼", num)) && !str.StartsWith(BookmarkStart.b("儸伺䤼伾㉀", num))))
        {
            if (!A_0.Substring(0, num2 + 1).Contains(BookmarkStart.b("攸场", num)) && !A_0.Substring(0, num2 + 1).Contains(BookmarkStart.b("攸吺", num)))
            {
                hyperlink.Type = HyperlinkType.FileLink;
                hyperlink.FilePath = str;
            }
            else
            {
                hyperlink.Type = HyperlinkType.Bookmark;
                hyperlink.BookmarkName = str;
            }
        }
        else
        {
            hyperlink.Type = HyperlinkType.WebLink;
            hyperlink.Uri = str;
            if (this.docPicture_0 != null)
            {
                hyperlink.PictureToDisplay = this.docPicture_0;
                this.docPicture_0 = null;
            }
        }
        IDocumentObject field = hyperlink.Field;
        if (((field.NextSibling != null) && (field.NextSibling.DocumentObjectType == DocumentObjectType.FieldMark)) && ((field.NextSibling as FieldMark).Type == FieldMarkType.FieldSeparator))
        {
            for (field = field.NextSibling.NextSibling; field != null; field = field.NextSibling)
            {
                if (field.DocumentObjectType == DocumentObjectType.TextRange)
                {
                    TextRange range = field as TextRange;
                    this.method_169(range.CharacterFormat, this.class835_0);
                    range.CharacterFormat.method_55(Class843.smethod_0(this.class835_0.class843_0));
                    if (this.class835_0.threeState_2 == ThreeState.True)
                    {
                        range.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                    }
                    else
                    {
                        range.CharacterFormat.UnderlineStyle = UnderlineStyle.None;
                    }
                }
                if ((field.DocumentObjectType == DocumentObjectType.FieldMark) && ((field as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    break;
                }
            }
        }
        this.method_169(hyperlink.Field.CharacterFormat, this.class835_0);
    }

    private PixelFormat method_88(int A_0)
    {
        int num = A_0;
        switch (num)
        {
            case 4:
                return PixelFormat.Format4bppIndexed;

            case 8:
                return PixelFormat.Format8bppIndexed;
        }
        if (num != 0x18)
        {
            return PixelFormat.Format1bppIndexed;
        }
        return PixelFormat.Format24bppRgb;
    }

    private void method_89(string A_0)
    {
        int num = 10;
        if (!this.class837_0.bool_3 && !this.bool_45)
        {
            if ((((this.method_7().LastItem != null) && (this.shapeObject_0 != null)) && ((this.shapeObject_0.IsImage && !this.shapeObject_0.HasImageBytes) || this.bool_15)) && (this.method_7().LastItem is ShapeGroup))
            {
                this.shapeObject_0.SetShapeAttribute(0x1006, this.method_90(A_0));
            }
            else
            {
                DocPicture picture = this.method_91(A_0);
                if ((((this.method_7().LastItem != null) && (this.shapeObject_0 != null)) && ((this.shapeObject_0.IsImage && !this.shapeObject_0.HasImageBytes) || this.bool_15)) && (((this.method_7().LastItem is ShapeObject) && !(this.method_7().LastItem is ShapeGroup)) && (this.string_26.ToLower() != BookmarkStart.b("嘯嬱堳娵娷嘹唻丽", num))))
                {
                    picture.IsHeaderPicture = this.shapeObject_0.IsHeaderAutoShape;
                    this.method_7().Items.RemoveAt(this.method_7().Items.Count - 1);
                }
                if (!this.bool_70 && !(this.string_26.ToLower() == BookmarkStart.b("嘯嬱堳娵娷嘹唻丽", num)))
                {
                    this.method_58(picture);
                }
                else
                {
                    this.ipicture_0 = picture;
                }
            }
        }
        else if (this.bool_45 && this.bool_62)
        {
            this.shapeObject_0.SetShapeAttribute(0x100f, this.method_90(A_0));
        }
        else
        {
            this.ipicture_0 = new DocPicture(this.document_0);
            this.ipicture_0.LoadImage(this.method_90(A_0));
        }
        this.bool_46 = false;
    }

    protected void method_9(Column A_0)
    {
        this.column_0 = A_0;
    }

    private byte[] method_90(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("⬥", 0), string.Empty);
        A_0 = A_0.Replace(BookmarkStart.b("Ⱕ", 0), string.Empty);
        A_0 = A_0.Replace(BookmarkStart.b("إ", 0), string.Empty);
        byte[] buffer = new byte[A_0.Length / 2];
        int num = 0;
        int num2 = 0;
        while (num < (A_0.Length / 2))
        {
            int num3 = int.Parse(A_0.Substring(num * 2, 2), NumberStyles.HexNumber);
            buffer[num2++] = Convert.ToByte(num3);
            num++;
        }
        this.class564_0.method_1(false);
        return buffer;
    }

    private DocPicture method_91(string A_0)
    {
        DocPicture picture = new DocPicture(this.document_0);
        byte[] sourceArray = this.method_90(A_0);
        if (this.class837_0.bool_1)
        {
            int num = this.class837_0.int_2;
            if ((this.class837_0.int_4 > 0) && (num == 1))
            {
                num = (this.class837_0.int_4 / this.class837_0.int_0) * 8;
            }
            PixelFormat format = this.method_88(num);
            using (Bitmap bitmap = new Bitmap(this.class837_0.int_0, this.class837_0.int_1, format))
            {
                int sourceIndex = 0;
                switch (format)
                {
                    case PixelFormat.Format24bppRgb:
                        sourceIndex = 40;
                        break;

                    case PixelFormat.Format8bppIndexed:
                    {
                        ColorPalette palette = bitmap.Palette;
                        for (int i = 0; i < 0xff; i++)
                        {
                            int blue = sourceArray[((i * 4) + 1) + 0x27];
                            int green = sourceArray[((i * 4) + 2) + 0x27];
                            int red = sourceArray[((i * 4) + 3) + 0x27];
                            palette.Entries[i] = Color.FromArgb(red, green, blue);
                        }
                        bitmap.Palette = palette;
                        sourceIndex = 0x428;
                        break;
                    }
                }
                Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
                IntPtr destination = bitmapdata.Scan0;
                int length = Math.Abs(bitmapdata.Stride);
                int num7 = length * bitmap.Height;
                byte[] destinationArray = new byte[num7];
                if (this.class837_0.bool_2)
                {
                    int num8 = 0;
                    int height = bitmap.Height;
                    while (num8 < height)
                    {
                        Array.Copy(sourceArray, (num8 * length) + sourceIndex, destinationArray, (length * (height - num8)) - length, length);
                        num8++;
                    }
                }
                else
                {
                    Array.Copy(sourceArray, sourceIndex, destinationArray, 0, num7);
                }
                Marshal.Copy(destinationArray, 0, destination, num7);
                bitmap.UnlockBits(bitmapdata);
                destinationArray = null;
                picture.LoadImage(bitmap);
                goto Label_01EE;
            }
        }
        picture.LoadImage(sourceArray);
    Label_01EE:
        this.method_92(picture, this.class837_0);
        sourceArray = null;
        return picture;
    }

    private void method_92(IPicture A_0, Class837 A_1)
    {
        if (this.bool_46)
        {
            if (A_1.method_4() == 0f)
            {
                A_1.method_5(((float) A_1.int_0) / 35.3f);
            }
            if (A_1.method_0() == 0f)
            {
                A_1.method_1(((float) A_1.int_1) / 35.3f);
            }
        }
        else
        {
            if (A_1.method_4() == 0f)
            {
                A_1.method_5((float) ((A_1.int_0 * 0x48) / 0x60));
            }
            if (A_1.method_0() == 0f)
            {
                A_1.method_1((float) ((A_1.int_1 * 0x48) / 0x60));
            }
        }
        if (this.bool_46)
        {
            A_1 = this.method_93(A_1);
        }
        if (A_1.method_0() > 0f)
        {
            A_0.Height = A_1.method_0();
        }
        if (A_1.method_4() > 0f)
        {
            A_0.Width = A_1.method_4();
        }
        if (A_1.method_2() > 0f)
        {
            A_0.HeightScale = A_1.method_2();
        }
        if (A_1.method_6() > 0f)
        {
            A_0.WidthScale = A_1.method_6();
        }
        A_0.HorizontalOrigin = A_1.horizontalOrigin_0;
        A_0.VerticalOrigin = A_1.verticalOrigin_0;
        A_0.HorizontalAlignment = A_1.shapeHorizontalAlignment_0;
        A_0.VerticalAlignment = A_1.shapeVerticalAlignment_0;
        A_0.TextWrappingStyle = A_1.textWrappingStyle_0;
        A_0.TextWrappingType = A_1.textWrappingType_0;
        if (A_1.float_5 != 0f)
        {
            A_0.VerticalPosition = A_1.float_5;
        }
        if (A_1.float_4 != 0f)
        {
            A_0.HorizontalPosition = A_1.float_4;
        }
        A_0.IsUnderText = A_1.bool_0;
        if (A_0.IsUnderText)
        {
            A_0.TextWrappingStyle = TextWrappingStyle.Behind;
        }
        if (A_0 is DocPicture)
        {
            (A_0 as DocPicture).OrderIndex = A_1.long_0;
        }
        if (A_1.float_7 != 0f)
        {
            (A_0 as DocPicture).CropFromBottom = A_1.float_7;
        }
        if (A_1.float_8 != 0f)
        {
            (A_0 as DocPicture).CropFromLeft = A_1.float_8;
        }
        if (A_1.float_9 != 0f)
        {
            (A_0 as DocPicture).CropFromRight = A_1.float_9;
        }
        if (A_1.float_6 != 0f)
        {
            (A_0 as DocPicture).CropFromTop = A_1.float_6;
        }
        this.bool_46 = false;
    }

    private Class837 method_93(Class837 A_0)
    {
        float num = (A_0.method_4() * A_0.method_6()) / 100f;
        float num2 = (A_0.method_0() * A_0.method_2()) / 100f;
        float num3 = (914400f * num) / 72f;
        A_0.method_7(((num3 / 12700f) * 100f) / A_0.method_4());
        float num4 = (914400f * num2) / 72f;
        A_0.method_3(((num4 / 12700f) * 100f) / A_0.method_0());
        return A_0;
    }

    private void method_94(ParagraphFormat A_0, ParagraphFormat A_1)
    {
        if ((A_0 != null) && (A_1 != null))
        {
            if (A_0.HasKey(0x15))
            {
                A_1.BackColor = A_0.BackColor;
            }
            if (A_0.HasKey(0x4b0))
            {
                A_1.BeforeSpacing = A_0.BeforeSpacing;
            }
            if (A_0.HasKey(0x4c4))
            {
                A_1.AfterSpacing = A_0.AfterSpacing;
            }
            if (A_0.HasKey(0x618))
            {
                A_1.IsBidi = A_0.IsBidi;
            }
            A_0.Borders.CopyPropertiesTo(A_1.Borders);
            if (A_0.HasKey(0x16) && A_0.IsColumnBreakAfter)
            {
                A_1.IsColumnBreakAfter = true;
            }
            if (A_0.HasKey(0x3fe) && A_0.IsContextualSpacing)
            {
                A_1.IsContextualSpacing = true;
            }
            if (A_0.HasKey(0x20))
            {
                A_1.ForeColor = A_0.ForeColor;
            }
            if (A_0.HasKey(0x3fc))
            {
                A_1.HorizontalAlignment = A_0.HorizontalAlignment;
            }
            if (A_0.HasKey(0x410) && A_0.KeepLines)
            {
                A_1.KeepLines = true;
            }
            if (A_0.HasKey(0x41a) && A_0.KeepFollow)
            {
                A_1.KeepFollow = true;
            }
            if (A_0.HasKey(0x488))
            {
                A_1.LeftIndent = A_0.LeftIndent;
            }
            if (A_0.HasKey(0x47e))
            {
                A_1.RightIndent = A_0.RightIndent;
            }
            if (A_0.HasKey(0x492))
            {
                A_1.FirstLineIndent = A_0.FirstLineIndent;
            }
            if (A_1.HasKey(0x618))
            {
                if (A_0.HasKey(0x44))
                {
                    A_1.LeftIndentBi = A_0.LeftIndentBi;
                }
                if (A_0.HasKey(0x45))
                {
                    A_1.RightIndentBi = A_0.RightIndentBi;
                }
                if (A_0.HasKey(70))
                {
                    A_1.FirstLineIndentBi = A_0.FirstLineIndentBi;
                }
            }
            if (this.bool_36)
            {
                A_1.LineSpacing = A_0.LineSpacing;
                A_1.LineSpacingRule = A_0.LineSpacingRule;
            }
            if (A_0.HasKey(0x500))
            {
                A_1.OutlineLevel = A_0.OutlineLevel;
            }
            if (A_0.HasKey(13))
            {
                A_1.PageBreakAfter = A_0.PageBreakAfter;
            }
            if (A_0.HasKey(0x424))
            {
                A_1.PageBreakBefore = A_0.PageBreakBefore;
            }
            if (A_0.HasKey(0x410))
            {
                A_1.KeepLines = A_0.KeepLines;
            }
            if (A_0.HasKey(0x4ce))
            {
                A_1.AfterAutoSpacing = A_0.AfterAutoSpacing;
            }
            if (A_0.HasKey(0x4ba))
            {
                A_1.BeforeAutoSpacing = A_0.BeforeAutoSpacing;
            }
            if (A_0.HasKey(0x21))
            {
                A_1.TextureStyle = A_0.TextureStyle;
            }
            if (A_0.HasKey(0x5be))
            {
                A_1.IsWidowControl = A_0.IsWidowControl;
            }
            if (A_0.WrapFrameAround)
            {
                A_1.WrapFrameAround = true;
            }
            if (A_0.HasKey(0x21))
            {
                A_1.TextureStyle = A_0.TextureStyle;
            }
            if (A_0.HasKey(0x474))
            {
                foreach (Tab tab in A_0.Tabs)
                {
                    if (!A_1.Tabs.method_7(tab.Position, tab.Justification, tab.TabLeader))
                    {
                        A_1.Tabs.AddTab(tab.Position, tab.Justification, tab.TabLeader);
                    }
                }
            }
            if (A_0.Frame.HasKey(5))
            {
                A_1.FrameAnchorLock = A_0.FrameAnchorLock;
            }
            if (A_0.Frame.HasKey(6))
            {
                A_1.FrameHeight = A_0.FrameHeight;
            }
            if (A_0.Frame.HasKey(0x12))
            {
                A_1.FrameWrapType = A_0.FrameWrapType;
            }
            if (A_0.Frame.HasKey(12))
            {
                A_1.FrameVerticalPos = A_0.FrameVerticalPos;
            }
            if (A_0.Frame.HasKey(9))
            {
                A_1.FrameHorizontalDistanceFromText = A_0.FrameHorizontalDistanceFromText;
            }
            if (A_0.Frame.HasKey(11))
            {
                A_1.FrameHorizontalPos = A_0.FrameHorizontalPos;
            }
            if (A_0.Frame.HasKey(0x10))
            {
                A_1.FrameVerticalDistanceFromText = A_0.FrameVerticalDistanceFromText;
            }
            if (A_0.Frame.HasKey(0x11))
            {
                A_1.FrameWidth = A_0.FrameWidth;
            }
            if (A_0.Frame.HasKey(3))
            {
                A_1.FrameX = A_0.FrameX;
            }
            if (A_0.Frame.HasKey(4))
            {
                A_1.FrameY = A_0.FrameY;
            }
        }
    }

    private void method_95(string A_0, string A_1, string A_2)
    {
        int num = 4;
        switch (this.method_21())
        {
            case RtfTableType.FontTable:
                this.method_109(this.string_8, A_1, A_2);
                return;

            case RtfTableType.ListTable:
            case RtfTableType.ListOverrideTable:
                this.method_102(this.string_8, A_1, A_2);
                return;

            case RtfTableType.ColorTable:
                this.method_111(this.string_8, A_1, A_2);
                return;

            case RtfTableType.StyleSheet:
                this.method_113(A_0, A_1, A_2);
                return;

            case RtfTableType.PgpTable:
                this.method_101(this.string_8, A_1, A_2);
                return;

            case RtfTableType.None:
            {
                string key = A_1;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_160 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                        dictionary1.Add(BookmarkStart.b("堩堫䠭", num), 0);
                        dictionary1.Add(BookmarkStart.b("䰩䌫䀭䐯䘱嘳娵", num), 1);
                        dictionary1.Add(BookmarkStart.b("天堫圭尯圱䜳帵崷弹䠻", num), 2);
                        dictionary1.Add(BookmarkStart.b("䘩䔫崭䐯䘱唳吵吷弹", num), 3);
                        dictionary1.Add(BookmarkStart.b("䘩䔫崭䐯崱䈳匵䨷䠹唻娽┿㙁╃⑅⑇⽉", num), 4);
                        dictionary1.Add(BookmarkStart.b("䤩䌫䈭弯䀱䀳吵吷", num), 5);
                        dictionary1.Add(BookmarkStart.b("娩䬫席䐯倱堳", num), 6);
                        dictionary1.Add(BookmarkStart.b("娩䬫䨭䌯儱䀳吵吷", num), 7);
                        dictionary1.Add(BookmarkStart.b("䌩䈫䠭弯", num), 8);
                        dictionary1.Add(BookmarkStart.b("弩弫䬭䈯䈱䘳夵䠷䤹", num), 9);
                        dictionary1.Add(BookmarkStart.b("丩䤫䠭嘯", num), 10);
                        dictionary1.Add(BookmarkStart.b("丩含䜭崯匱匳匵䴷䠹唻", num), 11);
                        dictionary1.Add(BookmarkStart.b("崩尫娭弯崱堳䔵", num), 12);
                        Class1160.dictionary_160 = dictionary1;
                    }
                    if (Class1160.dictionary_160.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                this.stack_0.Push(BookmarkStart.b("堩堫䠭į", num));
                                this.stack_1.Push(this.dictionary_0);
                                this.dictionary_0 = new Dictionary<string, Class839>();
                                this.stack_2.Push(this.dictionary_1);
                                this.dictionary_1 = new Dictionary<int, Class843>();
                                this.class843_0 = null;
                                return;

                            case 1:
                                this.class839_1 = new Class839();
                                this.method_22(RtfTableType.FontTable);
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 2:
                                this.method_22(RtfTableType.StyleSheet);
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 3:
                                this.method_22(RtfTableType.ListTable);
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 4:
                                this.method_22(RtfTableType.ListOverrideTable);
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 5:
                                this.method_22(RtfTableType.ColorTable);
                                this.class843_0 = new Class843();
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 6:
                                this.method_22(RtfTableType.PgpTable);
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 7:
                                if (!(this.string_12 == BookmarkStart.b(")", num)))
                                {
                                    break;
                                }
                                this.bool_61 = true;
                                this.stack_4.Push(BookmarkStart.b("娩䬫䨭䌯儱䀳吵吷", num));
                                return;

                            case 8:
                                this.bool_14 = true;
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 9:
                                this.bool_32 = true;
                                this.stack_4.Push(BookmarkStart.b("儩", num));
                                return;

                            case 10:
                                this.int_5 = int.Parse(A_2);
                                return;

                            case 11:
                            case 12:
                                this.stack_36.Push(this.bool_60);
                                this.bool_60 = true;
                                return;
                        }
                    }
                }
                if (!this.bool_59)
                {
                    this.method_113(A_0, A_1, A_2);
                }
                break;
            }
            default:
                return;
        }
    }

    private Dictionary<int, Class842> method_96(Dictionary<int, Class842> A_0)
    {
        Dictionary<int, Class842> dictionary = new Dictionary<int, Class842>();
        foreach (KeyValuePair<int, Class842> pair in A_0)
        {
            dictionary.Add(pair.Key, pair.Value.method_6());
        }
        return dictionary;
    }

    private void method_97()
    {
        int num = 9;
        List<string> list = (List<string>) this.method_33()[BookmarkStart.b("䌮吰䔲倴嬶䴸帺䔼䬾", 9)];
        if (list.Count > 0)
        {
            if (this.method_13().PatternType == ListPatternType.Bullet)
            {
                if ((list.Count > 2) && (list[2].Length > 0))
                {
                    string str = this.method_134(BookmarkStart.b("࠮", num) + list[2]);
                    str = (str != BookmarkStart.b("⼮", num)) ? str : string.Empty;
                    this.method_13().BulletCharacter = str;
                }
                else if (list[1].Length > 0)
                {
                    this.method_13().BulletCharacter = list[1];
                }
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                bool flag = false;
                if (list[1].Length > 0)
                {
                    builder.Append(list[1]);
                }
                for (int i = 2; i < list.Count; i += 2)
                {
                    string input = list[i];
                    if (this.regex_1.IsMatch(input))
                    {
                        int num4;
                        num4 = num4 = int.Parse(input);
                        if (num4 == this.method_13().LevelNumber)
                        {
                            if (builder.Length > 0)
                            {
                                this.method_13().NumberPrefix = this.method_99(builder.ToString());
                                builder.Length = 0;
                            }
                            flag = true;
                        }
                        else
                        {
                            if (num4 == 0)
                            {
                                int length = builder.Length;
                            }
                            builder.Append(BookmarkStart.b("⼮", num) + num4);
                        }
                    }
                    else if (this.regex_2.IsMatch(input) && (input.Length == 2))
                    {
                        string str3 = this.method_100(input);
                        builder.Append(str3);
                    }
                    else
                    {
                        builder.Append(input);
                    }
                    builder.Append(list[i + 1]);
                }
                if (builder.Length > 0)
                {
                    if (flag)
                    {
                        this.method_13().NumberSufix = builder.ToString();
                    }
                    else
                    {
                        this.method_13().NumberPrefix = builder.ToString();
                    }
                }
                else
                {
                    int result = 1;
                    if (int.TryParse(list[0], out result) && (result == 0))
                    {
                        this.method_13().NoLevelText = true;
                    }
                }
            }
        }
    }

    private OverrideLevelFormat method_98()
    {
        int num = 3;
        OverrideLevelFormat format = new OverrideLevelFormat(this.document_0);
        if (this.bool_76)
        {
            format.OverrideFormatting = true;
            this.bool_76 = false;
        }
        if (this.bool_75)
        {
            format.StartAt = this.method_13().StartAt;
            format.OverrideStartAtValue = true;
            this.bool_75 = false;
        }
        List<string> list = (List<string>) this.method_33()[BookmarkStart.b("䔨个嬬䨮崰䜲倴伶䴸", num)];
        if (list.Count > 0)
        {
            if (this.method_13().PatternType == ListPatternType.Bullet)
            {
                if ((list.Count > 2) && (list[2].Length > 0))
                {
                    string str = this.method_134(BookmarkStart.b("ศ", num) + list[2]);
                    str = (str != BookmarkStart.b("⤨", num)) ? str : string.Empty;
                    format.OverrideListLevel.BulletCharacter = str;
                    return format;
                }
                if (list[1].Length > 0)
                {
                    format.OverrideListLevel.BulletCharacter = list[1];
                }
                return format;
            }
            StringBuilder builder = new StringBuilder();
            bool flag = false;
            if (list[1].Length > 0)
            {
                builder.Append(list[1]);
            }
            for (int i = 2; i < list.Count; i += 2)
            {
                string input = list[i];
                if (this.regex_1.IsMatch(input))
                {
                    int num2;
                    num2 = num2 = int.Parse(input);
                    if (num2 == this.method_13().LevelNumber)
                    {
                        if (builder.Length > 0)
                        {
                            format.OverrideListLevel.NumberPrefix = this.method_99(builder.ToString());
                            builder.Length = 0;
                        }
                        flag = true;
                    }
                    else
                    {
                        if (num2 == 0)
                        {
                            int length = builder.Length;
                        }
                        builder.Append(BookmarkStart.b("⤨", num) + num2);
                    }
                }
                else if (this.regex_2.IsMatch(input) && (input.Length == 2))
                {
                    string str3 = this.method_100(input);
                    builder.Append(str3);
                }
                else
                {
                    builder.Append(input);
                }
                builder.Append(list[i + 1]);
            }
            if (builder.Length <= 0)
            {
                return format;
            }
            if (flag)
            {
                format.OverrideListLevel.NumberSufix = builder.ToString();
                return format;
            }
            format.OverrideListLevel.NumberPrefix = builder.ToString();
        }
        return format;
    }

    private string method_99(string A_0)
    {
        int num = 7;
        if ((A_0 != null) && !(A_0 == string.Empty))
        {
            string str = A_0;
            return str.Replace(BookmarkStart.b("⴬Ἦ", num), BookmarkStart.b("⴬", num)).Replace(BookmarkStart.b("⴬Ḯ", num), BookmarkStart.b("Ⱜ", num)).Replace(BookmarkStart.b("⴬ᴮ", num), BookmarkStart.b("⼬", num)).Replace(BookmarkStart.b("⴬ᰮ", num), BookmarkStart.b("⸬", num)).Replace(BookmarkStart.b("⴬ᬮ", num), BookmarkStart.b("⤬", num)).Replace(BookmarkStart.b("⴬ᨮ", num), BookmarkStart.b("⠬", num)).Replace(BookmarkStart.b("⴬᤮", num), BookmarkStart.b("⬬", num)).Replace(BookmarkStart.b("⴬ᠮ", num), BookmarkStart.b("⨬", num)).Replace(BookmarkStart.b("⴬ᜮ", num), BookmarkStart.b("┬", num));
        }
        return A_0;
    }

    private static bool smethod_0(int A_0)
    {
        return ((((A_0 >= 0x30) && (A_0 <= 0x39)) || ((A_0 >= 0x61) && (A_0 <= 0x66))) || ((A_0 >= 0x41) && (A_0 <= 70)));
    }

    void IDisposable.Dispose()
    {
        this.regex_0 = null;
        this.regex_1 = null;
        this.regex_2 = null;
        this.stack_28 = null;
        this.dictionary_0 = null;
        this.dictionary_1 = null;
        this.dictionary_2 = null;
        this.stack_3 = null;
        this.stack_4 = null;
        this.stack_5 = null;
        this.stack_6 = null;
        this.stack_7 = null;
        this.stack_8 = null;
        this.stack_9 = null;
        this.stack_10 = null;
        this.stack_11 = null;
        this.dictionary_4 = null;
        this.dictionary_5 = null;
        this.dictionary_6 = null;
        this.stack_16 = null;
        this.stack_17 = null;
        this.dictionary_9 = null;
        this.stack_21 = null;
        this.stack_22 = null;
        this.stack_23 = null;
        this.stack_25 = null;
        this.stack_26 = null;
        this.stack_27 = null;
        this.list_1 = null;
        this.stack_40 = null;
        this.stack_41 = null;
        this.stack_42 = null;
        this.stack_43 = null;
        this.stack_44 = null;
        this.stack_45 = null;
        this.stack_46 = null;
        this.stack_47 = null;
        this.dictionary_7 = null;
        this.stack_19 = null;
        this.stack_20 = null;
        this.stack_52 = null;
        this.stack_39 = null;
        if (this.class564_0 != null)
        {
            this.class564_0.System.IDisposable.Dispose();
        }
        this.class564_0 = null;
        if (this.list_2 != null)
        {
            this.list_2.Clear();
            this.list_2 = null;
        }
        if (this.dictionary_8 != null)
        {
            this.dictionary_8.Clear();
            this.dictionary_8 = null;
        }
        this.class51_0 = null;
    }

    internal class Class835
    {
        internal bool bool_0;
        internal bool bool_1;
        public bool bool_2;
        public bool bool_3;
        public bool bool_4;
        public bool bool_5;
        public bool bool_6;
        public bool bool_7;
        public bool bool_8;
        public bool bool_9;
        public BuiltinStyle builtinStyle_0;
        public CharacterEncodingType characterEncodingType_0;
        public Class843 class843_0 = new Class843();
        public Class843 class843_1 = new Class843();
        public Class843 class843_2 = new Class843();
        public DateTime dateTime_0 = DateTime.MinValue;
        public float float_0 = -1f;
        public float float_1 = -1f;
        public float float_2;
        public float float_3;
        public float float_4;
        public float float_5;
        public float float_6 = -1f;
        public float float_7 = float.MaxValue;
        public float float_8 = float.MaxValue;
        public HorizontalAlignment horizontalAlignment_0;
        public int int_0 = 0x409;
        public int int_1 = -2147483648;
        public int int_2 = -2147483648;
        public short short_0 = 100;
        public string string_0 = string.Empty;
        public string string_1 = string.Empty;
        public SubSuperScript subSuperScript_0;
        public Class834.ThreeState threeState_0 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_1 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_2 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_3 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_4 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_5 = Class834.ThreeState.Unknown;
        public Class834.ThreeState threeState_6 = Class834.ThreeState.Unknown;
        public UnderlineStyle underlineStyle_0;

        internal Class835()
        {
            this.float_0 = 12f;
        }

        public Class834.Class835 method_0()
        {
            return (Class834.Class835) base.MemberwiseClone();
        }
    }

    internal class Class836
    {
        public bool bool_0;
        public bool bool_1;
        public bool bool_2;
        public bool bool_3;
        public bool bool_4;
        public float float_0 = Convert.ToSingle(0x24);
        public float float_1 = Convert.ToSingle(0x24);
        public float float_2 = Convert.ToSingle(0x24);
        private float? nullable_0;
        private float? nullable_1;
        private float? nullable_2;
        private float? nullable_3;
        private float? nullable_4;
        public PageAlignment pageAlignment_0;
        internal PageOrientation pageOrientation_0 = PageOrientation.Portrait;
        public SizeF sizeF_0;

        public float? method_0()
        {
            return this.nullable_4;
        }

        public void method_1(float? A_0)
        {
            this.nullable_4 = A_0;
        }

        public float? method_2()
        {
            return this.nullable_0;
        }

        public void method_3(float? A_0)
        {
            this.nullable_0 = A_0;
        }

        public float? method_4()
        {
            return this.nullable_1;
        }

        public void method_5(float? A_0)
        {
            this.nullable_1 = A_0;
        }

        public float? method_6()
        {
            return this.nullable_2;
        }

        public void method_7(float? A_0)
        {
            this.nullable_2 = A_0;
        }

        public float? method_8()
        {
            return this.nullable_3;
        }

        public void method_9(float? A_0)
        {
            this.nullable_3 = A_0;
        }
    }

    internal class Class837
    {
        public bool bool_0;
        internal bool bool_1;
        internal bool bool_2;
        internal bool bool_3;
        private float float_0;
        private float float_1;
        private float float_2;
        private float float_3;
        public float float_4;
        public float float_5;
        internal float float_6;
        internal float float_7;
        internal float float_8;
        internal float float_9;
        public HorizontalOrigin horizontalOrigin_0;
        internal int int_0;
        internal int int_1;
        internal int int_2 = 1;
        internal int int_3 = 1;
        internal int int_4;
        internal long long_0;
        public ShapeHorizontalAlignment shapeHorizontalAlignment_0;
        public ShapeVerticalAlignment shapeVerticalAlignment_0;
        public TextWrappingStyle textWrappingStyle_0 = TextWrappingStyle.Inline;
        public TextWrappingType textWrappingType_0;
        public VerticalOrigin verticalOrigin_0;

        public float method_0()
        {
            return this.float_0;
        }

        public void method_1(float A_0)
        {
            this.float_0 = A_0;
        }

        public float method_2()
        {
            return this.float_2;
        }

        public void method_3(float A_0)
        {
            this.float_2 = A_0;
        }

        public float method_4()
        {
            return this.float_1;
        }

        public void method_5(float A_0)
        {
            this.float_1 = A_0;
        }

        public float method_6()
        {
            return this.float_3;
        }

        public void method_7(float A_0)
        {
            this.float_3 = A_0;
        }
    }

    internal enum ThreeState
    {
        False,
        True,
        Unknown
    }
}

