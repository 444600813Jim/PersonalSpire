namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Core.DataStreamParser.Escher;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.Converters;
    using Spire.Doc.Documents.Markup;
    using Spire.Doc.Documents.Rendering;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Fields.Shape;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using Spire.Doc.Reporting;
    using Spire.Layouting;
    using Spire.License;
    using Spire.Pdf;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Drawing.Printing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Security.Permissions;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [LicenseProvider(typeof(LicenseProvider))]
    public class Document : DocumentContainer, IXmlSerializable, IDisposable, Interface3, IDocument
    {
        private ArrayList arrayList_0;
        private ArrayList arrayList_1;
        private ArrayList arrayList_2;
        private Spire.Doc.Background background_0;
        internal BodyRegion bodyRegion_0;
        private BodyRegion bodyRegion_1;
        private BookmarkCollection bookmarkCollection_0;
        private bool bool_10;
        internal bool bool_11;
        private bool bool_12;
        private bool bool_13;
        private bool bool_14;
        private bool bool_15;
        private bool bool_16;
        private bool bool_17;
        private bool bool_18;
        private bool bool_19;
        private bool bool_20;
        private bool bool_21;
        private bool bool_22;
        internal bool bool_23;
        private bool bool_24;
        private bool bool_25;
        private bool bool_26;
        [CompilerGenerated]
        private static bool bool_27;
        internal bool bool_3;
        internal bool bool_4;
        internal bool bool_5;
        internal bool bool_6;
        internal bool bool_7;
        private bool bool_8;
        private bool bool_9;
        internal Spire.Doc.BuiltinDocumentProperties builtinDocumentProperties_0;
        private byte[] byte_10;
        private byte[] byte_2;
        private byte[] byte_3;
        private byte[] byte_4;
        private byte[] byte_5;
        private byte[] byte_6;
        private byte[] byte_7;
        private byte[] byte_8;
        private byte[] byte_9;
        internal readonly char[] char_0;
        private CharacterFormat characterFormat_0;
        private Class1011 class1011_0;
        private Class1089 class1089_0;
        private Class1128 class1128_0;
        private Class1128 class1128_1;
        private Class1128 class1128_2;
        private Class1129 class1129_0;
        private Class14 class14_0;
        private Class195 class195_0;
        private Class195 class195_1;
        private Class294 class294_0;
        private Class324 class324_0;
        private Class458 class458_0;
        private Class478 class478_0;
        private Class48 class48_0;
        private Class481 class481_0;
        private Class50 class50_0;
        private Class514 class514_0;
        private Class515 class515_0;
        private Class516 class516_0;
        private Class52 class52_0;
        private Class865 class865_0;
        private Class907 class907_0;
        private CommentsCollection commentsCollection_0;
        internal Spire.Doc.CustomDocumentProperties customDocumentProperties_0;
        private CustomXmlPartCollection customXmlPartCollection_0;
        private Dictionary<string, string> dictionary_0;
        private Dictionary<string, string> dictionary_1;
        private Dictionary<string, string> dictionary_2;
        private Dictionary<string, bool> dictionary_3;
        private Dictionary<string, Dictionary<int, int>> dictionary_4;
        private Dictionary<string, int> dictionary_5;
        private Dictionary<string, int> dictionary_6;
        private Dictionary<string, DocOleObject> dictionary_7;
        private Dictionary<int, Struct0> dictionary_8;
        private Spire.Doc.Fields.Shape.DigitalSignatures digitalSignatures_0;
        private DocumentOperationType documentOperationType_0;
        private DocumentProperties documentProperties_0;
        private FieldCollection fieldCollection_0;
        private FileFormat fileFormat_0;
        private FileFormat fileFormat_1;
        private float float_2;
        private float float_3;
        private FootEndnoteOptions footEndnoteOptions_0;
        private FootEndnoteOptions footEndnoteOptions_1;
        private Hashtable hashtable_0;
        private Spire.Doc.HtmlExportOptions htmlExportOptions_0;
        private HybridDictionary hybridDictionary_0;
        private ImportOptions importOptions_0;
        private int int_10;
        private int int_11;
        private int int_12;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        internal int int_7;
        internal int int_8;
        private int int_9;
        [CompilerGenerated]
        private Spire.License.InternalLicense internalLicense_0;
        private LicenseInfo licenseInfo_0;
        private List<char> list_0;
        private List<Stream> list_1;
        private List<Class512> list_10;
        private List<string> list_11;
        private List<PrivateFontPath> list_12;
        private List<Stream> list_2;
        private List<XmlNode> list_3;
        private List<Footnote> list_4;
        private List<Footnote> list_5;
        private List<Stream> list_6;
        private List<Stream> list_7;
        private List<string> list_8;
        private List<Font> list_9;
        protected ListStyleCollection m_listStyles;
        protected SectionCollection m_sections;
        protected StyleCollection m_styles;
        private Spire.Doc.Reporting.MailMerge mailMerge_0;
        private MemoryStream memoryStream_0;
        private MemoryStream memoryStream_1;
        private readonly object object_0;
        private ParagraphBase paragraphBase_0;
        internal ParagraphFormat paragraphFormat_0;
        private PermissionCollection permissionCollection_0;
        private System.Windows.Forms.PrintDialog printDialog_0;
        private System.Drawing.Printing.PrintDocument printDocument_0;
        private Section section_0;
        private ShapeObject shapeObject_0;
        private Stack<Field> stack_1;
        private Stream stream_0;
        internal string string_10;
        private string string_11;
        private string string_12;
        private string string_13;
        private string string_14;
        private string string_15;
        private string string_16;
        private string string_17;
        private const string string_7 = "Normal";
        internal const string string_8 = "Bulleted";
        internal const string string_9 = "Numbered";
        private StringCollection stringCollection_0;
        private TableOfContent tableOfContent_0;
        private TextBoxCollection textBoxCollection_0;
        private ushort ushort_0;
        private VariableCollection variableCollection_0;
        private Spire.Doc.Documents.Converters.VbaDocumentEvents vbaDocumentEvents_0;
        private Spire.Doc.Formatting.ViewSetup viewSetup_0;
        internal WatermarkBase watermarkBase_0;
        private XHTMLValidationType xhtmlvalidationType_0;
        private XmlNode xmlNode_0;

        public event BookmarkLevelHandler BookmarkLayout;

        internal event Delegate4 PageImagePainted;

        public event PageLayoutHandler PageLayout;

        public event UpdateFieldsHandler UpdateFields;

        public Document() : base(null, null)
        {
            this.char_0 = new char[] { ' ', '–', '\t', '\x00a0', '\v' };
            this.bool_6 = true;
            this.fileFormat_0 = FileFormat.Auto;
            this.builtinDocumentProperties_0 = new Spire.Doc.BuiltinDocumentProperties();
            this.customDocumentProperties_0 = new Spire.Doc.CustomDocumentProperties();
            this.int_2 = 1;
            this.object_0 = new object();
            this.xhtmlvalidationType_0 = XHTMLValidationType.None;
            this.importOptions_0 = ImportOptions.UseDestinationStyles;
            this.bool_9 = true;
            this.bool_12 = true;
            this.bool_22 = true;
            this.digitalSignatures_0 = new Spire.Doc.Fields.Shape.DigitalSignatures();
            this.dictionary_8 = new Dictionary<int, Struct0>();
            this.string_16 = string.Empty;
            this.int_12 = 80;
            this.string_17 = BookmarkStart.b("欸樺缼ാ@тDن⭈੊ཌ繎ၐᑒၔᙖ㵘ᩚ὜⽞⁠③嵤♦୨౪ⱬ࡮ば㕲ᙴ㙶⁸⩺㽼پ삀쒂놄욆\uda8a\ucf8c搜킐풒횖횘ﲚ\udc9c\uf89e좨쎮諸ﾼ즾胀蓂裄蛆귈髊迌믎郐铒胔雖믘볚鿜ꃠꃢꓤꛦ跨鳪꿬蟮냰믲룴뛶냸뫺뿼闾䀀䬂䰄䘆匈娊伌朎倐嬒䐔嘖䌘䨚弜琞怠怢搤昦䴨尪漬弮瀰笲搴瘶堸稺簼堾@Ղࡄن⩈੊ཌ㽎ၐ᭒᱔ᙖ͘ਗ਼ᱜ⩞⁠♢㑤♦୨ᱪ⽬ծばひ㑴㙶⍸ᱺ㽼ॾ삀쮂첄욆삈쪊첌搜킐횒ꆔ횖쮘쪚\udf9c\uca9e醤", 0x13);
            this.bool_12 = true;
            if (this.method_175())
            {
                this.method_194();
            }
            base.m_doc = this;
            this.method_165();
        }

        protected Document(Document doc) : this()
        {
            this.string_11 = doc.StandardAsciiFont;
            this.string_12 = doc.StandardFarEastFont;
            this.string_13 = doc.StandardNonFarEastFont;
            this.string_14 = doc.string_14;
            this.viewSetup_0 = doc.ViewSetup.method_5(this);
            if (doc.BuiltinDocumentProperties != null)
            {
                this.builtinDocumentProperties_0 = doc.BuiltinDocumentProperties.Clone();
            }
            if (doc.CustomDocumentProperties != null)
            {
                this.customDocumentProperties_0 = doc.CustomDocumentProperties.Clone();
            }
            this.class907_0 = doc.Settings.method_12();
            if (doc.Watermark.Type != WatermarkType.NoWatermark)
            {
                this.Watermark = (WatermarkBase) doc.Watermark.Clone();
            }
            if (doc.Background.Type != BackgroundType.NoBackground)
            {
                this.background_0 = doc.Background.method_5();
                this.background_0.method_0(this);
                this.background_0.method_6(this);
            }
            if (doc.DefCharFormat != null)
            {
                this.characterFormat_0 = new CharacterFormat(this);
                this.characterFormat_0.ImportContainer(doc.DefCharFormat);
            }
            if (doc.DefParaFormat != null)
            {
                this.paragraphFormat_0 = new ParagraphFormat(this);
                this.paragraphFormat_0.ImportContainer(doc.DefParaFormat);
            }
            foreach (KeyValuePair<string, string> pair in doc.FontSubstitutionTable)
            {
                if (!this.FontSubstitutionTable.ContainsKey(pair.Key))
                {
                    this.FontSubstitutionTable.Add(pair.Key, pair.Value);
                }
                else
                {
                    this.FontSubstitutionTable[pair.Key] = pair.Value;
                }
            }
            this.ImportContent(doc);
        }

        public Document(Stream stream) : this()
        {
            this.LoadFromStream(stream, FileFormat.Auto, "");
        }

        public Document(string fileName) : this()
        {
            this.method_28(fileName, "");
        }

        public Document(Stream stream, FileFormat type) : this()
        {
            this.LoadFromStream(stream, type, (string) null);
        }

        public Document(Stream stream, string password) : this()
        {
            this.LoadFromStream(stream, FileFormat.Auto, password);
        }

        public Document(string fileName, FileFormat type) : this()
        {
            this.LoadFromFile(fileName, type, "");
        }

        public Document(string fileName, string password) : this()
        {
            this.method_28(fileName, password);
        }

        public Document(Stream stream, FileFormat type, XHTMLValidationType validationType) : this()
        {
            this.LoadFromStream(stream, type, validationType);
        }

        public Document(Stream stream, FileFormat type, string password) : this()
        {
            this.LoadFromStream(stream, type, password);
        }

        public Document(string fileName, FileFormat type, XHTMLValidationType validationType) : this()
        {
            if (type == FileFormat.Auto)
            {
                type = this.method_29(fileName);
            }
            this.LoadFromFile(fileName, type, validationType);
        }

        public Document(string fileName, FileFormat type, string password) : this()
        {
            if (type == FileFormat.Auto)
            {
                type = this.method_29(fileName);
            }
            this.LoadFromFile(fileName, type, password);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        public void AcceptChanges()
        {
            foreach (Section section in this.Sections)
            {
                section.method_29(true);
            }
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_1(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_0(this);
        }

        public ListStyle AddListStyle(ListType listType, string styleName)
        {
            ListStyle style = new ListStyle(this, listType);
            this.ListStyles.Add(style);
            style.Name = styleName;
            return style;
        }

        public ParagraphStyle AddParagraphStyle(string styleName)
        {
            return (this.method_33(StyleType.ParagraphStyle, styleName) as ParagraphStyle);
        }

        public Section AddSection()
        {
            Section section = new Section(base.Document);
            if (this.m_sections.Count > 0)
            {
                PageSetup pageSetup = this.m_sections[this.m_sections.Count - 1].PageSetup;
                PageSetup setup2 = section.PageSetup;
                setup2.Margins = pageSetup.Margins.Clone();
                setup2.PageSize = pageSetup.method_5();
                setup2.Orientation = pageSetup.Orientation;
            }
            this.m_sections.Add(section);
            return section;
        }

        public Style AddStyle(BuiltinStyle builtinStyle)
        {
            int num = 13;
            this.method_34();
            string name = Style.smethod_4(builtinStyle);
            Style style = base.Document.Styles.FindByName(name);
            if (style == null)
            {
                style = Style.CreateBuiltinStyle(builtinStyle, base.Document);
                base.Document.Styles.Add(style);
                if ((builtinStyle != BuiltinStyle.MacroText) && (builtinStyle != BuiltinStyle.CommentSubject))
                {
                    (base.Document.Styles.FindByName(name) as Style).ApplyBaseStyle(BookmarkStart.b("紲娴䔶吸娺儼", num));
                }
            }
            return style;
        }

        public void ClearMacros()
        {
            if (this.stream_0 != null)
            {
                this.stream_0.Close();
                this.stream_0 = null;
            }
            if (this.list_10 != null)
            {
                this.list_10.Clear();
                this.list_10 = null;
            }
            if (this.list_11 != null)
            {
                this.list_11.Clear();
                this.list_11 = null;
            }
            if (this.byte_3 != null)
            {
                this.byte_3 = null;
            }
            if (this.byte_6 != null)
            {
                this.byte_6 = null;
            }
        }

        public Document Clone()
        {
            return (Document) this.CloneImpl();
        }

        protected override object CloneImpl()
        {
            lock (this.object_0)
            {
                return new Document(this);
            }
        }

        public void Close()
        {
            this.method_113(false);
        }

        protected internal CellFormat CreateCellFormatImpl()
        {
            return new CellFormat();
        }

        protected internal CharacterFormat CreateCharacterFormatImpl()
        {
            return new CharacterFormat(this);
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Vertical);
        }

        protected internal ListFormat CreateListFormatImpl(IParagraph owner)
        {
            return new ListFormat(owner);
        }

        protected internal ListLevel CreateListLevelImpl(ListStyle style)
        {
            return new ListLevel(style);
        }

        protected internal ListStyle CreateListStyleImpl()
        {
            return new ListStyle(this);
        }

        public void CreateMinialDocument()
        {
            if (this.Sections.Count == 0)
            {
                this.AddSection().Body.AddParagraph();
            }
        }

        public Paragraph CreateParagraph()
        {
            return new Paragraph(this);
        }

        protected internal ParagraphFormat CreateParagraphFormatImpl()
        {
            return new ParagraphFormat(this);
        }

        public ParagraphBase CreateParagraphItem(ParagraphItemType itemType)
        {
            int num = 13;
            switch (itemType)
            {
                case ParagraphItemType.TextRange:
                    return new TextRange(this);

                case ParagraphItemType.Picture:
                    return new DocPicture(this);

                case ParagraphItemType.Field:
                    return new Field(this);

                case ParagraphItemType.FieldMark:
                    return new FieldMark(this);

                case ParagraphItemType.MergeField:
                    return new MergeField(this);

                case ParagraphItemType.CheckBox:
                    return new CheckBoxFormField(this);

                case ParagraphItemType.TextFormField:
                    return new TextFormField(this);

                case ParagraphItemType.DropDownFormField:
                    return new DropDownFormField(this);

                case ParagraphItemType.EmbedField:
                    return new Class3(this);

                case ParagraphItemType.BookmarkStart:
                    return new BookmarkStart(this);

                case ParagraphItemType.BookmarkEnd:
                    return new BookmarkEnd(this);

                case ParagraphItemType.ShapeObject:
                    return new ShapeObject(this);

                case ParagraphItemType.ShapeGroup:
                    return new ShapeGroup(this);

                case ParagraphItemType.Comment:
                    return new Comment(this);

                case ParagraphItemType.CommentMark:
                    return new CommentMark(this);

                case ParagraphItemType.Footnote:
                    return new Footnote(this);

                case ParagraphItemType.TextBox:
                    return new TextBox(this);

                case ParagraphItemType.Break:
                    return new Break(this);

                case ParagraphItemType.Symbol:
                    return new Symbol(this);

                case ParagraphItemType.TOC:
                    return new TableOfContent(this);

                case ParagraphItemType.OleObject:
                    return new DocOleObject(this);
            }
            throw new ArgumentException(BookmarkStart.b("稲䌴嘶唸刺夼Ἶ㕀㩂㕄≆楈⑊⭌潎⅐㉒❔㙖㹘⥚㱜⽞ॠ䍢౤፦౨٪", num));
        }

        protected internal RowFormat CreateTableFormatImpl()
        {
            return new RowFormat();
        }

        protected internal TextBoxItemCollection CreateTextBoxCollectionImpl()
        {
            return new TextBoxItemCollection(this);
        }

        protected internal TextBoxFormat CreateTextboxFormatImpl()
        {
            return new TextBoxFormat();
        }

        public void Dispose()
        {
            this.method_113(true);
        }

        public void Encrypt(string password)
        {
            int num = 14;
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception(BookmarkStart.b("搳圵䬷䤹䬻儽㈿♁摃⽅㭇橉≋㭍㱏㹑瑓㥕⩗穙㥛㍝ၟᙡᵣ䝥", num));
            }
            this.string_10 = password;
            this.bool_14 = true;
        }

        public TextSelection[] FindAllPattern(Regex pattern)
        {
            Class185 class2 = null;
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    Class185 collection = body.method_23(pattern);
                    if ((collection != null) && (collection.Count > 0))
                    {
                        if (class2 == null)
                        {
                            class2 = collection;
                        }
                        else
                        {
                            class2.AddRange(collection);
                        }
                    }
                }
            }
            if (class2 == null)
            {
                return null;
            }
            return class2.ToArray();
        }

        public TextSelection[] FindAllString(string matchString, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.FindAllPattern(pattern);
        }

        public TextSelection FindPattern(Regex pattern)
        {
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    TextSelection selection = body.method_22(pattern);
                    if (selection != null)
                    {
                        return selection;
                    }
                }
            }
            return null;
        }

        public TextSelection FindPattern(BodyRegion start, Regex pattern)
        {
            int num = 6;
            if (start == null)
            {
                throw new ArgumentException(BookmarkStart.b("缫娭儯䀱䀳ᘵ娷唹堻䜽怿⭁ぃ⍅╇橉⽋⽍㹏畑⁓癕㩗㽙籛そᕟ๡ࡣ", num), BookmarkStart.b("弫娭儯䀱䀳", num));
            }
            if (this.bodyRegion_1 == null)
            {
                this.bodyRegion_1 = start;
            }
            else if (this.bodyRegion_1 != start)
            {
                this.paragraphBase_0 = null;
                this.bodyRegion_1 = start;
            }
            TextSelection selection = null;
            if ((this.paragraphBase_0 != null) && (this.paragraphBase_0.OwnerParagraph != null))
            {
                selection = this.method_147(pattern);
                if (selection != null)
                {
                    selection.GetAsOneRange();
                    this.method_148(selection);
                    return selection;
                }
                start = this.paragraphBase_0.OwnerParagraph.NextTextBodyItem;
                if (start == null)
                {
                    this.paragraphBase_0 = null;
                    return null;
                }
            }
            BodyRegion nextTextBodyItem = start;
        Label_00AB:
            selection = nextTextBodyItem.Find(pattern);
            if (!this.method_151(selection))
            {
                nextTextBodyItem = nextTextBodyItem.NextTextBodyItem;
                if (nextTextBodyItem == null)
                {
                    return null;
                }
                goto Label_00AB;
            }
            selection.GetAsOneRange();
            this.method_148(selection);
            return selection;
        }

        public TextSelection[] FindPatternInLine(Regex pattern)
        {
            TextSelection[] selectionArray = null;
            foreach (Section section in this.Sections)
            {
                selectionArray = Class192.smethod_0().method_2(section.Body, pattern);
                if (selectionArray != null)
                {
                    return selectionArray;
                }
            }
            return selectionArray;
        }

        public TextSelection[] FindPatternInLine(BodyRegion start, Regex pattern)
        {
            int num = 0x13;
            if (start == null)
            {
                throw new ArgumentException(BookmarkStart.b("樸伺尼䴾㕀捂❄⡆ⵈ㉊浌♎═㙒㡔睖㩘㩚㍜硞ᕠ䍢ݤɦ䥨ժᡬͮᵰ", num), BookmarkStart.b("䨸伺尼䴾㕀", num));
            }
            if (this.bodyRegion_1 == null)
            {
                this.bodyRegion_1 = start;
            }
            else if (this.bodyRegion_1 != start)
            {
                this.paragraphBase_0 = null;
                this.bodyRegion_1 = start;
            }
            TextSelection[] selectionArray = null;
            if (this.paragraphBase_0 == null)
            {
                this.paragraphBase_0 = this.method_149(start);
            }
            selectionArray = this.method_152(pattern);
            if (selectionArray != null)
            {
                TextSelection selection = selectionArray[selectionArray.Length - 1];
                selection.GetAsOneRange();
                this.method_148(selection);
                return selectionArray;
            }
            this.paragraphBase_0 = null;
            return null;
        }

        public TextSelection FindString(string stringValue, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(stringValue, caseSensitive, wholeWord);
            return this.FindPattern(pattern);
        }

        public TextSelection FindString(BodyRegion start, string matchString, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.FindPattern(start, pattern);
        }

        public TextSelection[] FindStringInLine(string given, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(given, caseSensitive, wholeWord);
            return this.FindPatternInLine(pattern);
        }

        public TextSelection[] FindStringInLine(BodyRegion start, string matchString, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.FindPatternInLine(start, pattern);
        }

        public int GetPageCount()
        {
            this.method_130();
            return this.int_8;
        }

        protected XmlSchema GetSchema()
        {
            return Class707.smethod_4();
        }

        public string GetText()
        {
            Class775 class2 = new Class775();
            return class2.method_1(this);
        }

        public void ImportContent(IDocument doc)
        {
            this.ImportContent(doc, true);
        }

        public void ImportContent(IDocument doc, bool importStyles)
        {
            (doc as Document).bool_5 = true;
            this.bool_9 = importStyles;
            doc.Sections.method_12(this.m_sections);
            if ((doc as Document).Themes != null)
            {
                base.m_doc.Themes = (doc as Document).Themes.method_7();
            }
            foreach (KeyValuePair<string, string> pair3 in (doc as Document).Settings.method_7())
            {
                if (!this.Settings.method_7().ContainsKey(pair3.Key))
                {
                    this.Settings.method_7().Add(pair3.Key, pair3.Value);
                }
            }
            Style style = null;
            foreach (KeyValuePair<string, string> pair in (doc as Document).StyleNameIds)
            {
                if (!this.StyleNameIds.ContainsKey(pair.Key))
                {
                    this.StyleNameIds.Add(pair.Key, pair.Value);
                }
            }
            int num = 0;
            int count = doc.Styles.Count;
            while (num < count)
            {
                style = doc.Styles[num] as Style;
                if (!(this.Styles.FindByName(style.Name, style.StyleType) is Style))
                {
                    this.Styles.Add(style.Clone());
                }
                num++;
            }
            ListStyle style3 = null;
            int num3 = 0;
            int num4 = doc.ListStyles.Count;
            while (num3 < num4)
            {
                style3 = doc.ListStyles[num3];
                if (this.ListStyles.FindByName(style3.Name) == null)
                {
                    this.ListStyles.Add((ListStyle) style3.Clone());
                }
                num3++;
            }
            foreach (KeyValuePair<string, string> pair2 in (doc as Document).FontSubstitutionTable)
            {
                if (!this.FontSubstitutionTable.ContainsKey(pair2.Key))
                {
                    this.FontSubstitutionTable.Add(pair2.Key, pair2.Value);
                }
                else
                {
                    this.FontSubstitutionTable[pair2.Key] = pair2.Value;
                }
            }
            Class12 class2 = null;
            int num2 = 0;
            int num6 = (doc as Document).ListOverrides.Count;
            while (num2 < num6)
            {
                class2 = (doc as Document).ListOverrides.method_33(num2);
                if (this.ListOverrides.method_35(class2.Name) == null)
                {
                    this.ListOverrides.method_34((Class12) class2.Clone());
                }
                num2++;
            }
            this.method_167((doc as Document).MacrosData, ref this.byte_3);
            this.method_167((doc as Document).MacroCommands, ref this.byte_6);
            if (((doc as Document).ObjectPool != null) && (this.ObjectPool != null))
            {
                this.method_32(doc);
            }
            else
            {
                this.method_167((doc as Document).ObjectPool, ref this.byte_2);
            }
            if ((doc as Document).DefCharFormat != null)
            {
                if (this.characterFormat_0 == null)
                {
                    this.characterFormat_0 = new CharacterFormat(base.m_doc);
                }
                this.characterFormat_0.ImportContainer((doc as Document).DefCharFormat);
            }
            if ((doc as Document).DefParaFormat != null)
            {
                if (this.paragraphFormat_0 == null)
                {
                    this.paragraphFormat_0 = new ParagraphFormat(base.m_doc);
                }
                this.paragraphFormat_0.ImportContainer((doc as Document).DefParaFormat);
            }
            if ((this.class1129_0 == null) && ((doc as Document).DocxPackage != null))
            {
                this.class1129_0 = (doc as Document).DocxPackage.method_25();
            }
            this.list_3 = (doc as Document).list_3;
            this.list_1 = (doc as Document).list_1;
            (doc as Document).bool_5 = false;
        }

        public void ImportSection(ISection section)
        {
            ISection section2 = section.Clone();
            this.Sections.Add(section2);
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䜳䈵䄷嘹夻䴽", 14), this.Styles);
            base.XDLSHolder.AddElement(BookmarkStart.b("堳張䬷丹伻䨽㤿⹁⅃㕅", 14), this.m_listStyles);
            base.XDLSHolder.AddElement(BookmarkStart.b("䜳匵嬷丹唻儽⸿ㅁ", 14), this.Sections);
            base.XDLSHolder.AddElement(BookmarkStart.b("䈳張崷䴹ᄻ䴽┿㙁ㅃ㙅", 14), this.ViewSetup);
            base.XDLSHolder.AddElement(BookmarkStart.b("嘳䌵儷嘹䠻圽⸿潁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", 14), this.BuiltinDocumentProperties);
            base.XDLSHolder.AddElement(BookmarkStart.b("圳䌵䬷丹医匽洿㉁㙃⥅㡇⽉㹋㩍㥏㝑❓", 14), this.CustomDocumentProperties);
            base.XDLSHolder.AddElement(BookmarkStart.b("堳張䬷丹ᄻ儽㘿❁㙃㑅ⅇ⹉⥋㵍", 14), this.ListOverrides);
            base.XDLSHolder.AddElement(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", 14), this.Background);
            base.XDLSHolder.AddElement(BookmarkStart.b("䌳圵䰷弹主匽ℿぁ⽃", 14), this.Watermark);
        }

        public void InsertTextFromFile(string fileName, FileFormat fileFormat)
        {
            if (this.Sections.Count > 0)
            {
                this.bool_22 = false;
                this.int_7 = this.Sections.Count;
                this.LoadFromFile(fileName, fileFormat);
                this.bool_22 = true;
            }
            else
            {
                this.LoadFromFile(fileName, fileFormat);
            }
        }

        public void InsertTextFromStream(Stream stream, FileFormat fileFormat)
        {
            if (this.Sections.Count > 0)
            {
                this.bool_22 = false;
                this.int_7 = this.Sections.Count;
                this.LoadFromStream(stream, fileFormat);
                this.bool_22 = true;
            }
            else
            {
                this.LoadFromStream(stream, fileFormat);
            }
        }

        public void LoadFromFile(string fileName)
        {
            this.method_28(fileName, "");
        }

        public void LoadFromFile(string fileName, FileFormat fileFormat)
        {
            this.LoadFromFile(fileName, fileFormat, (string) null);
        }

        public void LoadFromFile(string fileName, FileFormat fileFormat, XHTMLValidationType validationType)
        {
            bool flag;
            if (fileFormat == FileFormat.Auto)
            {
                fileFormat = this.method_29(fileName);
            }
            fileName = this.method_176(fileName, fileFormat, out flag);
            if (flag)
            {
                this.CreateMinialDocument();
            }
            else
            {
                this.method_90(fileName, ref fileFormat);
                this.DetectedFormatType = fileFormat;
                if (FileFormat.Html == fileFormat)
                {
                    using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        if (this.bool_22)
                        {
                            this.method_165();
                        }
                        this.HtmlBaseUrl = Path.GetDirectoryName(fileName).TrimEnd(new char[] { '\\' });
                        this.method_84(stream, validationType);
                        return;
                    }
                }
                this.LoadFromFile(fileName, fileFormat);
            }
        }

        public void LoadFromFile(string fileName, FileFormat fileFormat, string password)
        {
            bool flag;
            int num = 3;
            if (this.bool_22)
            {
                this.method_165();
            }
            this.method_177(fileName);
            this.Password = password;
            if (fileFormat == FileFormat.Auto)
            {
                fileFormat = this.method_29(fileName);
            }
            fileName = this.method_176(fileName, fileFormat, out flag);
            if (flag)
            {
                this.CreateMinialDocument();
            }
            else
            {
                this.string_15 = fileName;
                this.method_90(fileName, ref fileFormat);
                this.DetectedFormatType = fileFormat;
                switch (fileFormat)
                {
                    case FileFormat.Doc:
                    case FileFormat.Dot:
                        this.method_86(fileName, password, fileFormat);
                        return;

                    case FileFormat.Docx:
                    case FileFormat.Dotx:
                    case FileFormat.Docm:
                    case FileFormat.Dotm:
                        this.method_40(fileName);
                        return;

                    case FileFormat.Docx2010:
                    case FileFormat.Dotx2010:
                    case FileFormat.Docm2010:
                    case FileFormat.Dotm2010:
                        this.method_44(fileName);
                        return;

                    case FileFormat.Docx2013:
                    case FileFormat.Dotx2013:
                    case FileFormat.Docm2013:
                    case FileFormat.Dotm2013:
                        this.method_46(fileName);
                        return;

                    case FileFormat.WordML:
                        this.method_49(fileName);
                        return;

                    case FileFormat.WordXml:
                        this.method_42(fileName);
                        return;

                    case FileFormat.Odt:
                        this.method_50(fileName);
                        return;

                    case FileFormat.Rtf:
                        this.method_80(fileName);
                        return;

                    case FileFormat.Xml:
                        this.method_54(fileName);
                        return;

                    case FileFormat.Txt:
                        this.method_76(fileName);
                        return;

                    case FileFormat.Html:
                        this.method_107(fileName, fileFormat);
                        return;
                }
                throw new NotSupportedException(BookmarkStart.b("紨䌪䠬༮地娲头制ᤸ崺刼䴾ⱀ≂ㅄ杆⩈⩊⍌ⅎ㹐❒畔㕖㱘筚⹜⩞ᅠ።੤ᕦᵨ๪६䅮", num));
            }
        }

        public void LoadFromFileInReadMode(string strFileName, FileFormat fileFormat)
        {
            using (FileStream stream = new FileStream(strFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                this.bool_11 = true;
                this.LoadFromStream(stream, fileFormat);
            }
        }

        public void LoadFromStream(Stream stream, FileFormat fileFormat)
        {
            this.LoadFromStream(stream, fileFormat, (string) null);
        }

        public void LoadFromStream(Stream stream, FileFormat fileFormat, XHTMLValidationType validationType)
        {
            this.method_112(stream, ref fileFormat);
            this.DetectedFormatType = fileFormat;
            if (FileFormat.Html == fileFormat)
            {
                if (this.bool_22)
                {
                    this.method_165();
                }
                this.method_84(stream, validationType);
            }
            else
            {
                this.LoadFromStream(stream, fileFormat);
            }
        }

        public void LoadFromStream(Stream stream, FileFormat fileFormat, string password)
        {
            int num = 12;
            if (this.bool_22)
            {
                this.method_165();
            }
            this.Password = password;
            if (fileFormat == FileFormat.Auto)
            {
                this.method_112(stream, ref fileFormat);
            }
            this.DetectedFormatType = fileFormat;
            switch (fileFormat)
            {
                case FileFormat.Doc:
                case FileFormat.Dot:
                    this.method_39(stream, password, fileFormat);
                    return;

                case FileFormat.Docx:
                case FileFormat.Dotx:
                case FileFormat.Docm:
                case FileFormat.Dotm:
                    this.method_41(stream);
                    return;

                case FileFormat.Docx2010:
                case FileFormat.Dotx2010:
                case FileFormat.Docm2010:
                case FileFormat.Dotm2010:
                    this.method_45(stream);
                    return;

                case FileFormat.Docx2013:
                case FileFormat.Dotx2013:
                case FileFormat.Docm2013:
                case FileFormat.Dotm2013:
                    this.method_47(stream);
                    return;

                case FileFormat.WordML:
                    this.method_48(stream);
                    return;

                case FileFormat.Odt:
                    this.method_51(stream);
                    return;

                case FileFormat.Rtf:
                    this.method_81(stream);
                    return;

                case FileFormat.Xml:
                    this.method_55(stream);
                    return;

                case FileFormat.Txt:
                    this.method_77(stream);
                    return;

                case FileFormat.Html:
                    this.method_84(stream, XHTMLValidationType.None);
                    return;
            }
            throw new NotSupportedException(BookmarkStart.b("昱尳匵ᠷ尹唻刽┿扁≃⥅㩇❉ⵋ㩍灏ㅑ㕓㡕㙗㕙⡛繝ɟݡ䑣ᕥᵧᩩᱫŭɯٱᅳት噷", num));
        }

        public void LoadHTML(TextReader reader, XHTMLValidationType validationType)
        {
            string html = reader.ReadToEnd().Trim();
            if (this.Sections.Count == 0)
            {
                this.AddSection();
            }
            this.ViewSetup.DocumentViewType = DocumentViewType.WebLayout;
            this.XHTMLValidateOption = validationType;
            this.LastSection.PageSetup.Margins.All = 72f;
            this.LastSection.Body.InsertXHTML(html, 0);
        }

        public void LoadHTML(TextReader reader, string baseURL, XHTMLValidationType validationType)
        {
            int num = 11;
            if (string.IsNullOrEmpty(baseURL))
            {
                baseURL = null;
            }
            else
            {
                if (!Uri.IsWellFormedUriString(baseURL, UriKind.Absolute))
                {
                    throw new ArgumentException(BookmarkStart.b("攰嬲倴᜶嬸娺丼娾慀㙂㝄⭆楈㡊╌⁎⑐㽒ㅔ睖㭘㹚絜㹞䅠ɢݤᑦ٨ݪᡬ᭮ᑰ卲ᑴ᥶ᵸ孺੼᩾ꖄ力뎒뮚펠쪢쮤삦", num), BookmarkStart.b("匰刲䘴制永椺焼", num));
                }
                this.HtmlBaseUrl = baseURL;
            }
            this.LoadHTML(reader, validationType);
        }

        public void LoadRtf(Stream stream)
        {
            this.LoadFromStream(stream, FileFormat.Rtf);
        }

        public void LoadRtf(TextReader reader)
        {
            this.method_83(reader);
        }

        public void LoadRtf(string fileName)
        {
            this.bool_3 = true;
            this.LoadFromFile(fileName, FileFormat.Rtf);
            this.bool_3 = false;
        }

        public void LoadRtf(Stream stream, Encoding encoding)
        {
            this.method_82(stream, encoding);
        }

        public void LoadRtf(string fileName, Encoding encoding)
        {
            bool flag;
            fileName = this.method_176(fileName, FileFormat.Rtf, out flag);
            if (flag)
            {
                this.CreateMinialDocument();
            }
            else
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    this.LoadRtf(stream, encoding);
                }
            }
        }

        public void LoadText(Stream stream)
        {
            this.LoadFromStream(stream, FileFormat.Txt);
        }

        public void LoadText(TextReader reader)
        {
            this.method_79(reader);
        }

        public void LoadText(string fileName)
        {
            this.LoadFromFile(fileName, FileFormat.Txt);
        }

        public void LoadText(Stream stream, Encoding encoding)
        {
            this.method_78(stream, encoding);
        }

        public void LoadText(string fileName, Encoding encoding)
        {
            bool flag;
            fileName = this.method_176(fileName, FileFormat.Txt, out flag);
            if (flag)
            {
                this.CreateMinialDocument();
            }
            else
            {
                using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    this.LoadText(stream, encoding);
                }
            }
        }

        private void method_100(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
                {
                    using (Class698 class2 = new Class698())
                    {
                        class2.method_2(this.JPEGQuality);
                        class2.method_3(this, stream);
                        class2.Dispose();
                    }
                }
            }
        }

        private void method_101(string A_0, ToPdfParameterList A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    if ((A_1 != null) && A_1.UsePSCoversion)
                    {
                        using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.ReadWrite))
                        {
                            class2.method_11(this, stream, A_1);
                            goto Label_0079;
                        }
                    }
                    using (PdfNewDocument document = class2.method_6(this, A_1))
                    {
                        this.method_193(this.licenseInfo_0, document);
                        document.Save(A_0);
                        document.Close();
                    }
                Label_0079:
                    class2.Dispose();
                }
            }
        }

        private void method_102(string A_0, List<string> A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    using (PdfNewDocument document = class2.method_7(this, A_1))
                    {
                        this.method_193(this.licenseInfo_0, document);
                        document.Save(A_0);
                        document.Close();
                    }
                    class2.Dispose();
                }
            }
        }

        internal void method_103(string A_0, List<Image> A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    using (PdfNewDocument document = class2.method_10(A_1))
                    {
                        this.method_193(this.licenseInfo_0, document);
                        document.Save(A_0);
                        document.Close();
                    }
                    class2.Dispose();
                }
            }
        }

        private void method_104(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class698 class2 = new Class698())
                {
                    class2.method_2(this.JPEGQuality);
                    class2.method_3(this, A_0);
                    class2.Dispose();
                }
            }
        }

        private void method_105(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    using (PdfNewDocument document = class2.method_5(this))
                    {
                        this.method_193(this.licenseInfo_0, document);
                        document.Save(A_0);
                        document.Close();
                    }
                    class2.Dispose();
                }
            }
        }

        private void method_106(Stream A_0, ToPdfParameterList A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    if ((A_1 != null) && A_1.UsePSCoversion)
                    {
                        class2.method_11(this, A_0, A_1);
                    }
                    else
                    {
                        using (PdfNewDocument document = class2.method_6(this, A_1))
                        {
                            this.method_193(this.licenseInfo_0, document);
                            document.Save(A_0);
                            document.Close();
                        }
                    }
                    class2.Dispose();
                }
            }
        }

        private void method_107(string A_0, FileFormat A_1)
        {
            using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.HtmlBaseUrl = Path.GetDirectoryName(A_0);
                this.LoadFromStream(stream, A_1, XHTMLValidationType.None);
            }
        }

        private FileFormat method_108(Stream A_0)
        {
            FileFormat auto;
            using (Class1129 class2 = new Class1129())
            {
                using (Class771 class3 = new Class771())
                {
                    class3.method_27(A_0, false);
                    class2.method_20(class3);
                    if (this.method_109(class2))
                    {
                        A_0.Position = 0L;
                        return FileFormat.Odt;
                    }
                    if (this.method_110(class2))
                    {
                        A_0.Position = 0L;
                        return FileFormat.Docx;
                    }
                    auto = FileFormat.Auto;
                }
            }
            return auto;
        }

        private bool method_109(Class1129 A_0)
        {
            int num = 9;
            if (A_0 == null)
            {
                return false;
            }
            return this.method_111(A_0.method_12(BookmarkStart.b("䰮帰崲䄴制圸伺ጼ䜾ⱀ⽂", num)), BookmarkStart.b("䀮地唲尴吶尸ĺ䤼娾㥀㝂", num));
        }

        private bool method_110(Class1129 A_0)
        {
            int num = 0x11;
            if (A_0 == null)
            {
                return false;
            }
            string str = string.Empty;
            bool flag = false;
            Class229 class2 = A_0.method_19(BookmarkStart.b("氶稸吺匼䬾⑀ⵂㅄᡆᵈ㉊㵌⩎≐๒答⽖㑘㝚", num));
            if (class2 != null)
            {
                using (XmlReader reader = Class57.smethod_18(class2.method_4()))
                {
                    string attribute;
                    while (reader.NodeType != XmlNodeType.Element)
                    {
                        reader.Read();
                    }
                    if (reader.LocalName != BookmarkStart.b("挶䀸䬺堼䰾", num))
                    {
                        return false;
                    }
                    reader.Read();
                    while (reader.LocalName != BookmarkStart.b("挶䀸䬺堼䰾", num))
                    {
                        if ((reader.LocalName == BookmarkStart.b("砶伸帺似䴾⡀❂⁄", num)) && reader.HasAttributes)
                        {
                            attribute = reader.GetAttribute(BookmarkStart.b("朶堸䤺䤼焾⁀⹂⁄", num));
                            string str3 = reader.GetAttribute(BookmarkStart.b("琶嘸唺䤼娾⽀㝂ᅄ㹆㥈⹊", num));
                            if (attribute.StartsWith(BookmarkStart.b("ᠶ丸吺似嬾湀❂⩄⑆㱈♊⡌ⅎ═", num)) && str3.EndsWith(BookmarkStart.b("ᤶ吸娺吼儾橀㭂⡄⭆", num)))
                            {
                                goto Label_0110;
                            }
                        }
                        reader.Read();
                    }
                    goto Label_012C;
                Label_0110:
                    str = attribute.Substring(1);
                    flag = true;
                }
            }
        Label_012C:
            if (((!flag || string.IsNullOrEmpty(str)) || !this.method_111(A_0.method_19(str), BookmarkStart.b("䀶̸夺刼嬾㡀", num))) && (flag || !this.method_111(A_0.method_19(BookmarkStart.b("䀶嘸䤺夼ှ╀ⱂ♄㉆⑈⹊⍌㭎罐⭒㡔㭖", num)), BookmarkStart.b("䀶̸夺刼嬾㡀", num))))
            {
                return false;
            }
            return true;
        }

        private bool method_111(Class229 A_0, string A_1)
        {
            if (A_0 == null)
            {
                return false;
            }
            using (XmlReader reader = Class57.smethod_18(A_0.method_4()))
            {
                if (reader == null)
                {
                    return false;
                }
                return reader.ReadToFollowing(A_1);
            }
        }

        private void method_112(Stream A_0, ref FileFormat A_1)
        {
            if (A_1 == FileFormat.Auto)
            {
                if (A_0 is FileStream)
                {
                    A_1 = this.method_29((A_0 as FileStream).Name);
                }
                else
                {
                    A_1 = FileFormat.Doc;
                }
            }
            A_0.Position = 0L;
            if (this.method_155(A_0))
            {
                using (Interface51 interface2 = this.method_154(A_0))
                {
                    Interface61 interface3 = interface2.imethod_0();
                    Class299.EncrytionType type = new Class299().method_0(interface3);
                    A_0.Position = 0L;
                    if (type != Class299.EncrytionType.None)
                    {
                        A_1 = FileFormat.Docx;
                        return;
                    }
                }
            }
            A_0.Position = 0L;
            byte[] buffer = new byte[5];
            if (((A_0.Read(buffer, 0, 5) == 5) && (buffer[0] == 80)) && (buffer[1] == 0x4b))
            {
                A_0.Position = 0L;
                A_1 = this.method_108(A_0);
            }
            else
            {
                if ((buffer[0] == 0xd0) && (buffer[1] == 0xcf))
                {
                    try
                    {
                        using (Class363 class2 = new Class363(A_0, false))
                        {
                            if (class2.method_1())
                            {
                                A_1 = FileFormat.Doc;
                            }
                        }
                        goto Label_011C;
                    }
                    catch (Exception)
                    {
                        goto Label_011C;
                    }
                }
                Encoding encoding = this.method_91(buffer);
                this.method_92(A_0, ref A_1, encoding);
            }
        Label_011C:
            A_0.Position = 0L;
        }

        private void method_113(bool A_0)
        {
            this.bool_17 = true;
            this.method_114();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            if (!A_0)
            {
                base.m_doc = this;
                this.method_165();
            }
            this.bool_17 = false;
        }

        private void method_114()
        {
            if (this.builtinDocumentProperties_0 != null)
            {
                this.builtinDocumentProperties_0.method_7();
                this.builtinDocumentProperties_0 = null;
            }
            if (this.customDocumentProperties_0 != null)
            {
                this.customDocumentProperties_0.method_5();
                this.customDocumentProperties_0 = null;
            }
            this.method_115();
            this.method_116();
            this.ClearMacros();
            if (this.commentsCollection_0 != null)
            {
                this.commentsCollection_0.Clear();
                this.commentsCollection_0 = null;
            }
            if (this.fieldCollection_0 != null)
            {
                this.fieldCollection_0.method_8();
                this.fieldCollection_0 = null;
            }
            if (this.bookmarkCollection_0 != null)
            {
                this.bookmarkCollection_0.Clear();
                this.bookmarkCollection_0 = null;
            }
            if (this.ClonedFields != null)
            {
                this.ClonedFields.Clear();
                this.stack_1 = null;
            }
            if (this.class516_0 != null)
            {
                this.class516_0.method_4();
                this.class516_0 = null;
            }
            if (this.class294_0 != null)
            {
                this.class294_0.method_4();
                this.class294_0 = null;
            }
            if (this.textBoxCollection_0 != null)
            {
                this.textBoxCollection_0.Clear();
                this.textBoxCollection_0 = null;
            }
            this.mailMerge_0 = null;
            this.class515_0 = null;
            this.viewSetup_0 = null;
            this.watermarkBase_0 = null;
            this.background_0 = null;
            if (this.class1011_0 != null)
            {
                this.class1011_0.System.IDisposable.Dispose();
                this.class1011_0 = null;
            }
            this.string_10 = string.Empty;
            this.byte_2 = null;
            this.byte_3 = null;
            this.byte_4 = null;
            this.byte_5 = null;
            this.byte_6 = null;
            this.int_2 = 1;
            this.string_11 = null;
            this.string_12 = null;
            this.string_13 = null;
            this.bool_8 = false;
            this.section_0 = null;
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            if (this.paragraphFormat_0 != null)
            {
                this.paragraphFormat_0.Close();
                this.paragraphFormat_0 = null;
            }
            if (this.list_3 != null)
            {
                this.list_3.Clear();
                this.list_3 = null;
            }
            if (this.list_1 != null)
            {
                int num7 = 0;
                int count = this.list_1.Count;
                while (num7 < count)
                {
                    this.list_1[num7].Dispose();
                    this.list_1[num7] = null;
                    num7++;
                }
                this.list_1.Clear();
                this.list_1 = null;
            }
            if (this.list_2 != null)
            {
                int num3 = 0;
                int num4 = this.list_2.Count;
                while (num3 < num4)
                {
                    this.list_2[num3].Dispose();
                    this.list_2[num3] = null;
                    num3++;
                }
                this.list_2.Clear();
                this.list_2 = null;
            }
            if (this.list_2 != null)
            {
                int num5 = 0;
                int num6 = this.list_2.Count;
                while (num5 < num6)
                {
                    this.list_2[num5].Dispose();
                    this.list_2[num5] = null;
                    num5++;
                }
                this.list_2.Clear();
                this.list_2 = null;
            }
            if (this.dictionary_1 != null)
            {
                this.dictionary_1.Clear();
                this.dictionary_1 = null;
            }
            if (this.dictionary_2 != null)
            {
                this.dictionary_2.Clear();
                this.dictionary_2 = null;
            }
            if (this.class52_0 != null)
            {
                this.class52_0 = null;
            }
            this.bool_19 = false;
            this.bool_20 = false;
            this.bool_21 = false;
            this.string_15 = string.Empty;
            this.tableOfContent_0 = null;
            this.memoryStream_0 = null;
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
                this.dictionary_0 = null;
            }
            if (this.class324_0 != null)
            {
                this.class324_0.System.IDisposable.Dispose();
                this.class324_0 = null;
            }
            this.class514_0 = null;
            this.class50_0 = null;
            this.tableOfContent_0 = null;
            this.class907_0 = null;
            this.class1128_0 = null;
            this.class1128_1 = null;
            this.class1128_2 = null;
            this.xhtmlvalidationType_0 = XHTMLValidationType.None;
            if (this.hashtable_0 != null)
            {
                this.hashtable_0.Clear();
                this.hashtable_0 = null;
            }
            if (this.class195_0 != null)
            {
                this.class195_0.System.IDisposable.Dispose();
                this.class195_0 = null;
            }
            if (this.dictionary_6 != null)
            {
                this.dictionary_6.Clear();
                this.dictionary_6 = null;
            }
            if (this.hybridDictionary_0 != null)
            {
                this.hybridDictionary_0.Clear();
                this.hybridDictionary_0 = null;
            }
            if (this.dictionary_4 != null)
            {
                this.dictionary_4.Clear();
                this.dictionary_4 = null;
            }
            if (this.dictionary_6 != null)
            {
                this.dictionary_6.Clear();
                this.dictionary_6 = null;
            }
            if (this.dictionary_5 != null)
            {
                this.dictionary_5.Clear();
                this.dictionary_5 = null;
            }
            if (this.list_9 != null)
            {
                int num = 0;
                int num2 = this.list_9.Count;
                while (num < num2)
                {
                    this.list_9[num].Dispose();
                    this.list_9[num] = null;
                    num++;
                }
                this.list_9.Clear();
                this.list_9 = null;
            }
            if (this.class458_0 != null)
            {
                this.class458_0.method_5();
                this.class458_0 = null;
            }
            if (this.customXmlPartCollection_0 != null)
            {
                this.customXmlPartCollection_0.Clear();
                this.customXmlPartCollection_0 = null;
            }
            if (this.class1129_0 != null)
            {
                this.class1129_0.System.IDisposable.Dispose();
                this.class1129_0 = null;
            }
            this.list_3 = null;
            this.list_4 = null;
            this.list_5 = null;
            this.bool_9 = true;
            this.variableCollection_0 = null;
            this.section_0 = null;
            this.paragraphBase_0 = null;
            this.bodyRegion_1 = null;
            if (this.class865_0 != null)
            {
                this.class865_0.System.IDisposable.Dispose();
                this.class865_0 = null;
            }
        }

        private void method_115()
        {
            if ((this.m_sections != null) && (this.m_sections.Count > 0))
            {
                Section section = null;
                for (int i = 0; i < this.m_sections.Count; i++)
                {
                    section = this.m_sections[i];
                    section.method_31();
                    section = null;
                }
                this.m_sections.Clear();
                this.m_sections = null;
            }
        }

        private void method_116()
        {
            if (this.m_styles != null)
            {
                int count = this.m_styles.Count;
                Style style = null;
                for (int i = 0; i < count; i++)
                {
                    style = this.m_styles[i] as Style;
                    style.Close();
                    style = null;
                }
                this.m_styles.InnerList.Clear();
                this.m_styles = null;
            }
            if (this.m_listStyles != null)
            {
                int num6 = this.m_listStyles.Count;
                ListStyle style2 = null;
                for (int j = 0; j < num6; j++)
                {
                    style2 = this.m_listStyles[j];
                    style2.Close();
                    style2 = null;
                }
                this.m_listStyles.InnerList.Clear();
                this.m_listStyles.ListStyleNames.Clear();
                this.m_listStyles = null;
            }
            if (this.class48_0 != null)
            {
                int num3 = this.class48_0.Count;
                for (int k = 0; k < num3; k++)
                {
                    this.class48_0.method_33(k).method_28();
                }
                this.class48_0.InnerList.Clear();
                this.class48_0 = null;
            }
        }

        internal void method_117(ImageType A_0, bool A_1)
        {
            new Class962().method_2(this, A_0, A_1);
        }

        internal void method_118(ImageType A_0, ToPdfParameterList A_1)
        {
            new Class962().method_3(this, A_0, A_1);
        }

        internal void method_119()
        {
            this.method_178();
            this.class195_1 = new Class195();
            this.class195_1.method_20(new ToPdfParameterList());
            this.class195_1.method_19().IsHidden = false;
            this.class195_1.method_44(this);
            this.class195_1.method_52();
        }

        internal int method_120(string A_0, TextSelection A_1, bool A_2, bool A_3, bool A_4)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_121(regex, A_1, A_4);
        }

        internal int method_121(Regex A_0, TextSelection A_1, bool A_2)
        {
            A_1.method_1();
            int num = 0;
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    num += body.method_25(A_0, A_1, A_2);
                    if (this.ReplaceFirst && (num > 0))
                    {
                        return num;
                    }
                }
            }
            return num;
        }

        internal int method_122(string A_0, TextBodyPart A_1, bool A_2, bool A_3)
        {
            return this.method_123(A_0, A_1, A_2, A_3, false);
        }

        internal int method_123(string A_0, TextBodyPart A_1, bool A_2, bool A_3, bool A_4)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_125(regex, A_1, A_4);
        }

        internal int method_124(Regex A_0, TextBodyPart A_1)
        {
            return this.method_125(A_0, A_1, false);
        }

        internal int method_125(Regex A_0, TextBodyPart A_1, bool A_2)
        {
            int num = 0;
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    num += body.method_26(A_0, A_1, A_2);
                    if (this.ReplaceFirst && (num > 0))
                    {
                        return num;
                    }
                }
            }
            return num;
        }

        internal int method_126(string A_0, IDocument A_1, bool A_2, bool A_3, bool A_4)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_127(regex, A_1, A_4);
        }

        internal int method_127(Regex A_0, IDocument A_1, bool A_2)
        {
            int num = 0;
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    num += body.method_27(A_0, A_1, A_2);
                    if (this.ReplaceFirst && (num > 0))
                    {
                        return num;
                    }
                }
            }
            if (base.m_doc.ObjectPool != null)
            {
                this.method_32(A_1);
                return num;
            }
            this.method_167((A_1 as Document).ObjectPool, ref this.byte_2);
            return num;
        }

        private void method_128(char[] A_0, bool A_1)
        {
            foreach (Section section in this.Sections)
            {
                section.Body.method_31(A_0, A_1);
                this.int_3 += section.Body.int_4;
                this.int_4 += section.Body.int_2;
                this.int_5 += section.Body.int_3;
                this.int_6 += section.Body.int_5;
            }
        }

        private void method_129(char[] A_0, bool A_1)
        {
            foreach (Footnote footnote2 in this.Endnotes)
            {
                footnote2.TextBody.method_31(A_0, A_1);
                this.int_3 += footnote2.TextBody.int_4;
                this.int_4 += footnote2.TextBody.int_2;
                this.int_5 += footnote2.TextBody.int_3;
                this.int_6 += footnote2.TextBody.int_5;
            }
            foreach (Footnote footnote in this.Footnotes)
            {
                footnote.TextBody.method_31(A_0, A_1);
                this.int_3 += footnote.TextBody.int_4;
                this.int_4 += footnote.TextBody.int_2;
                this.int_5 += footnote.TextBody.int_3;
                this.int_6 += footnote.TextBody.int_5;
            }
        }

        internal void method_130()
        {
            if ((this.Sections != null) && (this.Sections.Count > 0))
            {
                using (Class195 class2 = new Class195())
                {
                    class2.method_85(this);
                    class2.method_51();
                    this.int_8 = class2.method_0().Count;
                }
            }
        }

        internal void method_131()
        {
            this.method_130();
            for (int i = 0; i < base.m_doc.Fields.Count; i++)
            {
                if (!this.LayoutVariables.method_3().Contains(base.m_doc.Fields[i]))
                {
                    base.m_doc.Fields[i].method_49();
                }
            }
            this.LayoutVariables.method_4();
        }

        internal string method_132(Paragraph A_0, ListFormat A_1, ListLevel A_2)
        {
            return this.method_133(A_0, A_1, A_2, LocaleIDs.en_US);
        }

        internal string method_133(Paragraph A_0, ListFormat A_1, ListLevel A_2, LocaleIDs A_3)
        {
            int num = 3;
            if (A_0.IsInCell)
            {
                TableCell owner = A_0.Owner as TableCell;
                if ((owner != null) && (owner.CellFormat.VerticalMerge == CellMerge.Continue))
                {
                    return string.Empty;
                }
            }
            string customStyleName = A_1.CustomStyleName;
            if (A_0.IsInCell && (A_0.OwnerTextBody as TableCell).OwnerRow.OwnerTable.IsTextBox)
            {
                customStyleName = customStyleName + BookmarkStart.b("瘨弪䠬圮䔰儲娴伶", num);
            }
            Class12 class2 = null;
            string key = string.Empty;
            if ((A_1.LFOStyleName != null) && (A_1.LFOStyleName.Length > 0))
            {
                class2 = this.ListOverrides.method_35(A_1.LFOStyleName);
                if (class2 != null)
                {
                    key = A_1.LFOStyleName + BookmarkStart.b("瘨", num) + A_2.LevelNumber.ToString();
                }
            }
            if ((((class2 != null) && class2.method_23().method_11(A_2.LevelNumber)) && (class2.method_23().method_5(A_2.LevelNumber).OverrideStartAtValue && !this.LfoListLevel.ContainsKey(key))) || (A_0.ListFormat.HasKey(3) && A_0.ListFormat.IsRestartNumbering))
            {
                this.method_137(A_1, customStyleName, true);
            }
            else if (this.PreviousListLevel.ContainsKey(customStyleName) && (A_2.LevelNumber > this.PreviousListLevel[customStyleName]))
            {
                this.method_137(A_1, customStyleName, false);
            }
            if (this.PreviousListLevel.ContainsKey(customStyleName))
            {
                this.PreviousListLevel[customStyleName] = A_2.LevelNumber;
            }
            else
            {
                this.PreviousListLevel.Add(customStyleName, A_2.LevelNumber);
            }
            if ((class2 != null) && !this.LfoListLevel.ContainsKey(key))
            {
                this.LfoListLevel.Add(key, A_2.LevelNumber);
            }
            else if (((class2 == null) && (A_2.PatternType != ListPatternType.Bullet)) && (A_0.ListFormat.method_6(1) && (A_0.ListFormat.ListType == ListType.Numbered)))
            {
                this.LfoListLevel.Clear();
            }
            string bulletCharacter = string.Empty;
            int num2 = 0;
            int num3 = this.method_138(A_1, customStyleName);
            bulletCharacter = A_2.method_6(num3, A_1.ListType, A_3);
            num2 = this.method_139(A_1, customStyleName);
            if (((A_1.CurrentListLevel.PatternType != ListPatternType.Arabic) && (A_1.CurrentListLevel.NumberPrefix != null)) && A_1.CurrentListLevel.NumberPrefix.StartsWith(BookmarkStart.b("⤨Ԫ", num)))
            {
                bulletCharacter = this.method_140(A_1, customStyleName, A_2, num2, num3);
            }
            else if ((A_1.CurrentListLevel.PatternType != ListPatternType.Arabic) && (A_2.PatternType != ListPatternType.Arabic))
            {
                if ((((A_1.CurrentListLevel.NumberPrefix != null) && (A_1.CurrentListLevel.NumberSufix != null)) && ((A_1.CurrentListLevel.PatternType == ListPatternType.UpLetter) && !bulletCharacter.StartsWith(A_1.CurrentListLevel.NumberPrefix))) || (((A_1.CurrentListLevel.NumberPrefix != null) && (A_1.CurrentListLevel.NumberSufix != null)) && ((A_1.CurrentListLevel.PatternType == ListPatternType.LowLetter) && !bulletCharacter.StartsWith(A_1.CurrentListLevel.NumberPrefix))))
                {
                    bulletCharacter = A_1.CurrentListLevel.NumberPrefix + bulletCharacter.Replace(BookmarkStart.b("ܨ", num), "") + A_1.CurrentListLevel.NumberSufix;
                }
                else if ((((A_1.CurrentListLevel.NumberPrefix != null) && (A_1.CurrentListLevel.NumberSufix != null)) && ((A_1.CurrentListLevel.PatternType == ListPatternType.UpRoman) && !bulletCharacter.StartsWith(A_1.CurrentListLevel.NumberPrefix))) || ((((A_1.CurrentListLevel.NumberPrefix != null) && (A_1.CurrentListLevel.NumberSufix != null)) && (A_1.CurrentListLevel.PatternType == ListPatternType.LowRoman)) && (!bulletCharacter.StartsWith(A_1.CurrentListLevel.NumberPrefix) || string.IsNullOrEmpty(A_1.CurrentListLevel.NumberPrefix))))
                {
                    bulletCharacter = A_1.CurrentListLevel.NumberPrefix + bulletCharacter.Replace(BookmarkStart.b("ܨ", num), "") + A_1.CurrentListLevel.NumberSufix;
                }
            }
            else
            {
                bulletCharacter = this.method_134(bulletCharacter, A_1, customStyleName, A_2, num2, num3);
            }
            if (A_2.PatternType == ListPatternType.Bullet)
            {
                bulletCharacter = A_2.BulletCharacter;
            }
            return bulletCharacter;
        }

        private string method_134(string A_0, ListFormat A_1, string A_2, ListLevel A_3, int A_4, int A_5)
        {
            int num = 6;
            if (this.Lists.ContainsKey(A_2))
            {
                if (!this.method_135(A_0))
                {
                    return A_0;
                }
                if (!string.IsNullOrEmpty(A_3.LevelText))
                {
                    A_0 = A_3.LevelText;
                }
                else if ((A_1.CurrentListLevel.NumberPrefix != null) && A_1.CurrentListLevel.NumberPrefix.StartsWith(BookmarkStart.b("Ⱛ-", num)))
                {
                    return this.method_140(A_1, A_2, A_3, A_4, A_5);
                }
                Class12 class2 = null;
                if (!string.IsNullOrEmpty(A_1.LFOStyleName))
                {
                    class2 = base.Document.ListOverrides.method_35(A_1.LFOStyleName);
                }
                for (int i = 0; i < 9; i++)
                {
                    if (!this.Lists[A_2].ContainsKey(i))
                    {
                        break;
                    }
                    ListLevel level = (((class2 == null) || !class2.method_23().method_11(i)) || !class2.method_23().method_5(i).OverrideFormatting) ? A_1.CurrentListStyle.Levels[i] : class2.method_23().method_5(i).OverrideListLevel;
                    string newValue = (this.Lists[A_2][i] - 1).ToString();
                    if (level.PatternType != ListPatternType.Arabic)
                    {
                        newValue = level.method_5(this.Lists[A_2][i] - 2, A_1.CurrentListStyle.ListType, false);
                    }
                    A_0 = A_0.Replace(BookmarkStart.b("फ", num) + ((i + 1)).ToString(), newValue);
                    A_0 = A_0.Replace(A_3.LevelStr[i], newValue);
                }
                if (this.method_135(A_0))
                {
                    A_0 = string.Empty;
                }
            }
            return A_0;
        }

        private bool method_135(string A_0)
        {
            int num = 9;
            if (((((!A_0.Contains(BookmarkStart.b("⼮", 9)) && !A_0.Contains(BookmarkStart.b("⸮", num))) && (!A_0.Contains(BookmarkStart.b("⴮", num)) && !A_0.Contains(BookmarkStart.b("Ⱞ", num)))) && ((!A_0.Contains(BookmarkStart.b("⬮", num)) && !A_0.Contains(BookmarkStart.b("⨮", num))) && (!A_0.Contains(BookmarkStart.b("⤮", num)) && !A_0.Contains(BookmarkStart.b("⠮", num))))) && (((!A_0.Contains(BookmarkStart.b("✮", num)) && !A_0.Contains(BookmarkStart.b("ਮ0", num))) && (!A_0.Contains(BookmarkStart.b("ਮ̰", num)) && !A_0.Contains(BookmarkStart.b("ਮȰ", num)))) && ((!A_0.Contains(BookmarkStart.b("ਮ԰", num)) && !A_0.Contains(BookmarkStart.b("ਮа", num))) && (!A_0.Contains(BookmarkStart.b("ਮܰ", num)) && !A_0.Contains(BookmarkStart.b("ਮذ", num)))))) && (!A_0.Contains(BookmarkStart.b("ਮर", num)) && !A_0.Contains(BookmarkStart.b("ਮ࠰", num))))
            {
                return false;
            }
            return true;
        }

        internal void method_136()
        {
            this.PreviousListLevel.Clear();
            this.Lists.Clear();
            this.ListNames.Clear();
        }

        private void method_137(ListFormat A_0, string A_1, bool A_2)
        {
            if (this.hybridDictionary_0 != null)
            {
                Class12 class2 = null;
                if ((A_0.LFOStyleName != null) && (A_0.LFOStyleName.Length > 0))
                {
                    class2 = this.ListOverrides.method_35(A_0.LFOStyleName);
                }
                HybridDictionary dictionary = this.ListNames[A_1] as HybridDictionary;
                if (dictionary != null)
                {
                    ICollection keys = dictionary.Keys;
                    IEnumerator enumerator = keys.GetEnumerator();
                    int count = keys.Count;
                    int[] numArray = new int[count];
                    for (int i = 0; enumerator.MoveNext(); i++)
                    {
                        numArray[i] = (int) enumerator.Current;
                    }
                    for (int j = 0; j < count; j++)
                    {
                        if ((numArray[j] >= A_0.ListLevelNumber) && !A_0.CurrentListStyle.Levels[numArray[j]].NoRestartByHigher)
                        {
                            int startAt = A_0.CurrentListStyle.Levels[numArray[j]].StartAt;
                            if ((class2 != null) && class2.method_23().method_11(A_0.ListLevelNumber))
                            {
                                startAt = 0;
                                if (class2.method_23().method_5(A_0.ListLevelNumber).OverrideStartAtValue)
                                {
                                    if ((this.ListsIsReset.ContainsKey(A_1) && this.Lists.ContainsKey(A_1)) && (this.Lists[A_1].ContainsKey(numArray[j]) && (this.Lists[A_1][numArray[j]] > A_0.CurrentListStyle.Levels[numArray[j]].StartAt)))
                                    {
                                        startAt++;
                                    }
                                    startAt += class2.method_23().method_5(A_0.ListLevelNumber).StartAt;
                                }
                            }
                            dictionary[numArray[j]] = startAt;
                            if (this.Lists.ContainsKey(A_1) && this.Lists[A_1].ContainsKey(numArray[j]))
                            {
                                this.Lists[A_1][numArray[j]] = startAt;
                            }
                        }
                    }
                    if (this.ListsIsReset.ContainsKey(A_1))
                    {
                        this.ListsIsReset.Remove(A_1);
                    }
                }
            }
        }

        private int method_138(ListFormat A_0, string A_1)
        {
            Class12 class2 = null;
            if ((A_0.LFOStyleName != null) && (A_0.LFOStyleName.Length > 0))
            {
                class2 = this.ListOverrides.method_35(A_0.LFOStyleName);
            }
            HybridDictionary dictionary2 = this.ListNames[A_1] as HybridDictionary;
            int startAt = 0;
            if (((A_0.CurrentListStyle != null) && (A_0.ListLevelNumber >= A_0.CurrentListStyle.Levels.Count)) && (A_0.CurrentListStyle.Levels.Count > 0))
            {
                if (A_0.CurrentListStyle.IsSimple)
                {
                    A_0.ListLevelNumber = 0;
                }
                else
                {
                    A_0.ListLevelNumber = A_0.CurrentListStyle.Levels.Count - 1;
                }
            }
            if (dictionary2 == null)
            {
                HybridDictionary dictionary = new HybridDictionary();
                this.ListNames.Add(A_1, dictionary);
                startAt = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber].StartAt;
                if (((class2 != null) && class2.method_23().method_11(A_0.ListLevelNumber)) && class2.method_23().method_5(A_0.ListLevelNumber).OverrideStartAtValue)
                {
                    startAt = class2.method_23().method_5(A_0.ListLevelNumber).StartAt;
                }
                dictionary.Add(A_0.ListLevelNumber, startAt + 1);
                if (dictionary[0] == null)
                {
                    int num2 = (A_0.CurrentListStyle.Levels[0] != null) ? A_0.CurrentListStyle.Levels[0].StartAt : (startAt + 1);
                    dictionary.Add(0, num2 + 1);
                }
                return (startAt - 1);
            }
            if (dictionary2[A_0.ListLevelNumber] != null)
            {
                startAt = (int) dictionary2[A_0.ListLevelNumber];
                dictionary2[A_0.ListLevelNumber] = startAt + 1;
                return (startAt - 1);
            }
            startAt = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber].StartAt;
            if (((class2 != null) && class2.method_23().method_11(A_0.ListLevelNumber)) && class2.method_23().method_5(A_0.ListLevelNumber).OverrideStartAtValue)
            {
                startAt = class2.method_23().method_5(A_0.ListLevelNumber).StartAt;
            }
            dictionary2.Add(A_0.ListLevelNumber, startAt + 1);
            return (startAt - 1);
        }

        private int method_139(ListFormat A_0, string A_1)
        {
            if ((A_0.CurrentListLevel != null) && (A_0.CurrentListLevel.PatternType == ListPatternType.Bullet))
            {
                return 1;
            }
            if (!this.Lists.ContainsKey(A_1))
            {
                Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
                this.Lists.Add(A_1, dictionary2);
                if (A_0.CurrentListStyle == null)
                {
                    return 1;
                }
                ListLevel level = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
                if (!this.ListsIsReset.ContainsKey(A_1) && !string.IsNullOrEmpty(A_0.LFOStyleName))
                {
                    this.ListsIsReset.Add(A_1, true);
                }
                for (int i = 0; i <= level.LevelNumber; i++)
                {
                    dictionary2.Add(i, A_0.CurrentListStyle.Levels[i].StartAt + 1);
                }
                return level.StartAt;
            }
            Dictionary<int, int> dictionary = this.Lists[A_1];
            if (dictionary.ContainsKey(A_0.ListLevelNumber))
            {
                int num = dictionary[A_0.ListLevelNumber];
                num = (num <= 0) ? 1 : num;
                dictionary[A_0.ListLevelNumber] = num + 1;
                for (int j = A_0.ListLevelNumber; dictionary.ContainsKey(j + 1); j++)
                {
                    dictionary[j + 1] = 1;
                }
                return num;
            }
            ListLevel level2 = A_0.CurrentListStyle.Levels[A_0.ListLevelNumber];
            dictionary.Add(A_0.ListLevelNumber, level2.StartAt + 1);
            return level2.StartAt;
        }

        private string method_140(ListFormat A_0, string A_1, ListLevel A_2, int A_3, int A_4)
        {
            // This item is obfuscated and can not be translated.
            int num = 3;
            string str = string.Empty;
            int levelNumber = A_2.LevelNumber;
            if (!this.Lists.ContainsKey(A_1))
            {
                return str;
            }
            string str2 = string.Empty;
            Dictionary<int, int> dictionary = this.Lists[A_1];
            int[] array = new int[dictionary.Count];
            dictionary.Keys.CopyTo(array, 0);
            array = this.method_141(array);
            int num4 = (array.Length > 0) ? array[0] : 0;
            for (int i = num4; num4 == levelNumber; i++)
            {
            Label_007D:
                if (i > levelNumber)
                {
                    if ((A_2.PatternType == ListPatternType.LeadingZero) && (A_3 < 10))
                    {
                        str2 = str2 + BookmarkStart.b("ᤨ", num);
                    }
                    return (str2 + A_3.ToString() + A_2.NumberSufix);
                }
                if (dictionary.ContainsKey(i))
                {
                    str2 = str2 + Convert.ToString((int) (Convert.ToInt32(dictionary[i]) - 1)) + BookmarkStart.b("ܨ", num);
                }
            }
            goto Label_007D;
        }

        private int[] method_141(int[] A_0)
        {
            for (int i = 0; i < (A_0.Length - 1); i++)
            {
                for (int j = i + 1; j < A_0.Length; j++)
                {
                    if (A_0[i] > A_0[j])
                    {
                        int num3 = A_0[i];
                        A_0[i] = A_0[j];
                        A_0[j] = num3;
                    }
                }
            }
            return A_0;
        }

        internal int method_142(string A_0, TextBodyPart A_1, bool A_2, bool A_3)
        {
            Regex regex = Class191.smethod_1(A_0, A_2, A_3);
            return this.method_143(regex, A_1);
        }

        internal int method_143(Regex A_0, TextBodyPart A_1)
        {
            int num = 0;
            BodyRegion start = this.Sections[0].Body.Items[0];
            for (TextSelection[] selectionArray = this.FindPatternInLine(start, A_0); selectionArray != null; selectionArray = this.FindPatternInLine(start, A_0))
            {
                Class193.smethod_0().method_3(selectionArray, A_1);
                num++;
                if (this.ReplaceFirst)
                {
                    return num;
                }
            }
            return num;
        }

        private int method_144(Regex A_0, string A_1)
        {
            this.method_145();
            int num = 0;
            foreach (Section section in this.Sections)
            {
                foreach (HeaderFooter footer in section.HeadersFooters)
                {
                    if (footer.Items.Count > 0)
                    {
                        num += this.method_146(A_0, A_1, footer.Items[0]);
                    }
                }
            }
            this.method_145();
            return num;
        }

        private void method_145()
        {
            this.ResetFindState();
            Class192.smethod_0().method_0().Clear();
        }

        private int method_146(Regex A_0, string A_1, BodyRegion A_2)
        {
            int num = 0;
            for (TextSelection[] selectionArray = this.FindPatternInLine(A_2, A_0); selectionArray != null; selectionArray = this.FindPatternInLine(A_2, A_0))
            {
                Class193.smethod_0().method_1(selectionArray, A_1);
                num++;
                if (this.ReplaceFirst)
                {
                    return num;
                }
            }
            return num;
        }

        private TextSelection method_147(Regex A_0)
        {
            Class185 class2 = this.paragraphBase_0.OwnerParagraph.FindAll(A_0);
            if (class2.Count > 0)
            {
                TextSelection selection2;
                int num = this.paragraphBase_0.method_5();
                int num2 = 0;
                using (List<TextSelection>.Enumerator enumerator = class2.GetEnumerator())
                {
                    TextSelection current;
                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        if (this.method_151(current))
                        {
                            current.StartTextRange.method_5();
                            num2 = current.EndTextRange.method_5();
                            if (num <= num2)
                            {
                                goto Label_0072;
                            }
                        }
                    }
                    goto Label_0089;
                Label_0072:
                    selection2 = current;
                }
                return selection2;
            }
        Label_0089:
            return null;
        }

        private void method_148(TextSelection A_0)
        {
            this.paragraphBase_0 = null;
            TextRange[] ranges = A_0.GetRanges();
            if (ranges != null)
            {
                TextRange range = ranges[ranges.Length - 1];
                if (range.NextSibling != null)
                {
                    this.paragraphBase_0 = range.NextSibling as ParagraphBase;
                    return;
                }
            }
            BodyRegion ownerParagraph = A_0.OwnerParagraph;
            while (ownerParagraph.NextTextBodyItem != null)
            {
                ownerParagraph = ownerParagraph.NextTextBodyItem;
                this.paragraphBase_0 = this.method_149(ownerParagraph);
                if (this.paragraphBase_0 != null)
                {
                    return;
                }
            }
        }

        private ParagraphBase method_149(BodyRegion A_0)
        {
            if (A_0 != null)
            {
                if (A_0 is Table)
                {
                    ParagraphBase base2 = null;
                    Table table = A_0 as Table;
                    foreach (TableRow row in table.Rows)
                    {
                        foreach (TableCell cell in row.Cells)
                        {
                            base2 = this.method_150(cell);
                            if (base2 != null)
                            {
                                return base2;
                            }
                        }
                    }
                }
                else
                {
                    if ((A_0 as Paragraph).Items.Count > 0)
                    {
                        return (A_0 as Paragraph).Items[0];
                    }
                    if (A_0.NextSibling != null)
                    {
                        return this.method_149(A_0.NextSibling as BodyRegion);
                    }
                }
            }
            return null;
        }

        private ParagraphBase method_150(Body A_0)
        {
            ParagraphBase base2 = null;
            ParagraphBase base3;
            using (IEnumerator enumerator = A_0.Items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    BodyRegion current = (BodyRegion) enumerator.Current;
                    base2 = this.method_149(current);
                    if (current != null)
                    {
                        goto Label_0032;
                    }
                }
                return null;
            Label_0032:
                base3 = base2;
            }
            return base3;
        }

        private bool method_151(TextSelection A_0)
        {
            return ((A_0 != null) && (A_0.Count > 0));
        }

        private TextSelection[] method_152(Regex A_0)
        {
            if (this.paragraphBase_0 == null)
            {
                return null;
            }
            Paragraph ownerParagraph = this.paragraphBase_0.OwnerParagraph;
            int num = ownerParagraph.method_5();
            if (num == 0)
            {
                Class192.smethod_0().method_0().Clear();
            }
            int num2 = this.paragraphBase_0.method_5();
            TextSelection[] selectionArray = Class192.smethod_0().method_4(ownerParagraph, A_0, num2, ownerParagraph.Items.Count - 1);
            if (selectionArray == null)
            {
                Body ownerTextBody = ownerParagraph.OwnerTextBody;
                if (ownerTextBody != null)
                {
                    selectionArray = Class192.smethod_0().method_3(ownerTextBody, A_0, num + 1, ownerTextBody.Items.Count - 1);
                }
                if (selectionArray != null)
                {
                    return selectionArray;
                }
                BodyRegion region2 = ownerTextBody.Items[ownerTextBody.Items.Count - 1];
                BodyRegion nextTextBodyItem = region2.NextTextBodyItem;
                while (nextTextBodyItem != null)
                {
                    if (nextTextBodyItem.method_5() == 0)
                    {
                        Class192.smethod_0().method_0().Clear();
                    }
                    this.paragraphBase_0 = this.method_149(nextTextBodyItem);
                    if (this.paragraphBase_0 != null)
                    {
                        break;
                    }
                    nextTextBodyItem = nextTextBodyItem.NextTextBodyItem;
                }
                if (nextTextBodyItem != null)
                {
                    selectionArray = this.method_152(A_0);
                }
            }
            return selectionArray;
        }

        internal Interface51 method_153()
        {
            return new Class1004();
        }

        internal Interface51 method_154(Stream A_0)
        {
            return new Class1004(A_0);
        }

        internal bool method_155(Stream A_0)
        {
            int num = 0;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("唥尧堩䤫伭崯", num));
            }
            bool flag = false;
            if (Class1004.smethod_6(A_0))
            {
                flag = true;
            }
            return flag;
        }

        internal void method_156(IParagraph A_0)
        {
            int num = 0x11;
            if (A_0.StyleName == null)
            {
                if (this.Styles.FindByName(BookmarkStart.b("礶嘸䤺值帾ⵀ", num)) == null)
                {
                    this.method_33(StyleType.ParagraphStyle, BookmarkStart.b("礶嘸䤺值帾ⵀ", num));
                }
                A_0.ApplyStyle(BookmarkStart.b("礶嘸䤺值帾ⵀ", num));
            }
        }

        internal void method_157(Document A_0, IParagraphBase A_1)
        {
        }

        internal string method_158()
        {
            return this.string_10;
        }

        internal int method_159()
        {
            switch (this.SaveFormatType)
            {
                case FileFormat.Docx:
                case FileFormat.Dotx:
                case FileFormat.Docm:
                case FileFormat.Dotm:
                case FileFormat.WordXml:
                    return 12;

                case FileFormat.Docx2010:
                case FileFormat.Dotx2010:
                case FileFormat.Docm2010:
                case FileFormat.Dotm2010:
                    return 14;

                case FileFormat.Docx2013:
                case FileFormat.Dotx2013:
                case FileFormat.Docm2013:
                case FileFormat.Dotm2013:
                    return 15;
            }
            return 11;
        }

        internal void method_160(WatermarkType A_0)
        {
            this.method_186();
            if (A_0 == WatermarkType.PictureWatermark)
            {
                this.watermarkBase_0 = new PictureWatermark(this);
            }
            else if (A_0 == WatermarkType.TextWatermark)
            {
                this.watermarkBase_0 = new TextWatermark(this);
            }
            else
            {
                this.watermarkBase_0 = new WatermarkBase(this, A_0);
            }
        }

        internal void method_161()
        {
            this.background_0 = new Spire.Doc.Background(this);
        }

        internal void method_162(MemoryStream A_0)
        {
            this.method_59(A_0);
        }

        internal bool method_163()
        {
            if (this.m_listStyles.Count <= 0)
            {
                return false;
            }
            return true;
        }

        private void method_164()
        {
            this.paragraphFormat_0 = new ParagraphFormat(this);
            ParagraphStyle style = this.Styles.FindByName(BookmarkStart.b("栥䜧堩䄫伭尯", 0), StyleType.ParagraphStyle) as ParagraphStyle;
            if (style != null)
            {
                this.paragraphFormat_0.ImportContainer(style.ParagraphFormat);
                this.paragraphFormat_0.method_21(style.ParagraphFormat);
            }
        }

        private void method_165()
        {
            this.bool_7 = false;
            this.mailMerge_0 = new Spire.Doc.Reporting.MailMerge(this);
            this.viewSetup_0 = new Spire.Doc.Formatting.ViewSetup(this);
            this.m_sections = new SectionCollection(this);
            this.m_styles = new StyleCollection(this);
            this.m_listStyles = new ListStyleCollection(this);
            this.class48_0 = new Class48(this);
            this.textBoxCollection_0 = new TextBoxCollection(this);
            this.watermarkBase_0 = new WatermarkBase(this, WatermarkType.NoWatermark);
            this.background_0 = new Spire.Doc.Background(BackgroundType.NoBackground);
            this.background_0.method_0(this);
            this.builtinDocumentProperties_0 = new Spire.Doc.BuiltinDocumentProperties();
            this.customDocumentProperties_0 = new Spire.Doc.CustomDocumentProperties();
            if (this.dictionary_0 != null)
            {
                this.dictionary_0.Clear();
            }
            if (this.class907_0 != null)
            {
                this.class907_0 = null;
            }
            if (this.list_9 != null)
            {
                this.list_9.Clear();
            }
            if (this.dictionary_1 != null)
            {
                this.dictionary_1.Clear();
            }
            if (this.dictionary_2 != null)
            {
                this.dictionary_2.Clear();
            }
            if (this.list_8 != null)
            {
                this.list_8.Clear();
            }
            if (this.list_5 != null)
            {
                this.list_5.Clear();
            }
            if (this.list_5 != null)
            {
                this.list_5.Clear();
            }
            if (this.list_7 != null)
            {
                this.list_7.Clear();
            }
            if (this.list_4 != null)
            {
                this.list_4.Clear();
            }
            if (this.list_6 != null)
            {
                this.list_6.Clear();
            }
            if (this.list_3 != null)
            {
                this.list_3.Clear();
            }
            if (this.list_1 != null)
            {
                this.list_1.Clear();
            }
            if (this.list_2 != null)
            {
                this.list_2.Clear();
            }
            if (this.commentsCollection_0 != null)
            {
                this.commentsCollection_0.Clear();
            }
            if (this.fieldCollection_0 != null)
            {
                this.fieldCollection_0.method_8();
            }
            if (this.bookmarkCollection_0 != null)
            {
                this.bookmarkCollection_0.Clear();
            }
            this.xhtmlvalidationType_0 = XHTMLValidationType.None;
            this.bool_8 = false;
            this.bool_18 = false;
            this.bool_16 = false;
            this.bool_15 = false;
            this.bool_14 = false;
            this.bool_10 = false;
            this.bool_11 = false;
            this.bool_9 = true;
            this.int_2 = 1;
            this.tableOfContent_0 = null;
            this.memoryStream_0 = null;
            this.xmlNode_0 = null;
            this.string_14 = null;
            this.string_13 = null;
            this.string_12 = null;
            this.string_11 = null;
            this.byte_6 = null;
            this.byte_3 = null;
            this.byte_2 = null;
            this.string_10 = string.Empty;
            this.byte_7 = null;
            this.htmlExportOptions_0 = null;
            this.bodyRegion_1 = null;
            this.paragraphBase_0 = null;
            this.documentProperties_0 = null;
            this.variableCollection_0 = null;
            this.class1129_0 = null;
            this.class1011_0 = null;
            if (this.class294_0 != null)
            {
                this.class294_0.method_4();
                this.class294_0 = null;
            }
            if (this.paragraphFormat_0 != null)
            {
                this.paragraphFormat_0.Close();
                this.paragraphFormat_0 = null;
            }
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            this.ClearMacros();
            if (this.stack_1 != null)
            {
                this.stack_1.Clear();
                this.stack_1 = null;
            }
            if (this.class516_0 != null)
            {
                this.class516_0.method_4();
                this.class516_0 = null;
            }
            if (this.class324_0 != null)
            {
                this.class324_0.System.IDisposable.Dispose();
                this.class324_0 = null;
            }
            if (this.class52_0 != null)
            {
                this.class52_0 = null;
            }
            this.bool_19 = false;
            this.bool_20 = false;
            this.bool_21 = false;
            this.int_7 = 0;
            if (this.dictionary_7 != null)
            {
                this.dictionary_7 = null;
            }
        }

        private void method_166()
        {
            ListStyle style = new ListStyle(this, ListType.Numbered) {
                Name = BookmarkStart.b("眸为值崾⑀ㅂ⁄⍆", 0x13),
                ListType = ListType.Numbered
            };
            this.m_listStyles.Add(style);
            this.m_listStyles.ListStyleNames.Add(BookmarkStart.b("崸਺", 0x13), style.Name);
            ListStyle style2 = new ListStyle(this, ListType.Bulleted) {
                Name = BookmarkStart.b("笸为儼匾⑀㝂⁄⍆", 0x13),
                ListType = ListType.Bulleted
            };
            this.m_listStyles.Add(style2);
            this.m_listStyles.ListStyleNames.Add(BookmarkStart.b("崸ऺ", 0x13), style2.Name);
        }

        private void method_167(byte[] A_0, ref byte[] A_1)
        {
            if (A_0 != null)
            {
                A_1 = new byte[A_0.Length];
                A_0.CopyTo(A_1, 0);
            }
        }

        private void method_168(Document A_0, DocPicture A_1)
        {
            int shapeId = A_1.ShapeId;
            if (this.method_171(EscherShapeType.msosptPictureFrame, shapeId) && (this.int_2 != -1))
            {
                A_1.ShapeId = this.int_2;
            }
        }

        private void method_169(Document A_0, TextBox A_1)
        {
            int textBoxShapeID = A_1.Format.TextBoxShapeID;
            if (this.method_171(EscherShapeType.msosptTextBox, textBoxShapeID))
            {
                bool isHeaderTextBox = A_1.Format.IsHeaderTextBox;
                if (this.int_2 != -1)
                {
                    A_1.Format.TextBoxShapeID = this.int_2;
                }
            }
        }

        private void method_170(Document A_0, ShapeObject A_1)
        {
        }

        private bool method_171(EscherShapeType A_0, int A_1)
        {
            return true;
        }

        private Image method_172()
        {
            if (this.background_0.Type == BackgroundType.Picture)
            {
                return this.background_0.Picture;
            }
            return null;
        }

        private void method_173(Image A_0)
        {
            this.background_0.Picture = A_0;
            this.background_0.Type = BackgroundType.Picture;
        }

        private bool method_174()
        {
            bool flag;
            if ((this.m_sections == null) || (this.m_sections.Count == 0))
            {
                return false;
            }
            using (IEnumerator enumerator = this.m_sections.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Section current = (Section) enumerator.Current;
                    if (current.method_30())
                    {
                        goto Label_0042;
                    }
                }
                return false;
            Label_0042:
                flag = true;
            }
            return flag;
        }

        internal bool method_175()
        {
            SecurityPermission permission = new SecurityPermission(PermissionState.Unrestricted);
            bool flag = false;
            try
            {
                permission.Demand();
                flag = true;
            }
            catch (SecurityException)
            {
            }
            return flag;
        }

        private string method_176(string A_0, FileFormat A_1, out bool A_2)
        {
            int num = 13;
            A_2 = false;
            FileInfo info = new FileInfo(A_0);
            if (info.Length <= 0L)
            {
                A_2 = true;
            }
            if (!info.Exists && (A_1 != FileFormat.Html))
            {
                string extension = info.Extension;
                if (!(extension != A_1.ToString()))
                {
                    return A_0;
                }
                if (extension != string.Empty)
                {
                    int startIndex = A_0.LastIndexOf(extension);
                    A_0 = A_0.Remove(startIndex);
                }
                A_0 = A_0 + BookmarkStart.b("ᴲ", num) + A_1.ToString();
            }
            return A_0;
        }

        private void method_177(string A_0)
        {
            int num = 0x11;
            bool flag = false;
            if (A_0.Length >= 260)
            {
                flag = true;
            }
            else if (Path.GetDirectoryName(A_0).Length >= 0xf8)
            {
                flag = true;
            }
            if (flag)
            {
                throw new PathTooLongException(BookmarkStart.b("挶儸帺ᴼ夾⡀⽂⁄杆❈⩊⁌⩎煐㩒♔睖ⵘ㑚㉜罞ൠౢ୤f䝨䭪㥬ݮᑰ卲፴ɶᕸ᝺Ѽ彾뎒ﺖﺚ붜삠캢삤螦쒨\udeaa\udeac\udbae\u91b0톲킴鞶햸\udeba\ucebc첾럂귄ꛆꟈￌ硫뛔뿖룘꧚볜볞闠蛢韤铦짨諪菬诮퇰蟲鷴鋶\ud9f8\u9ffa铼跾搀怂焄栆笈爊ⴌ愎瀐縒瀔㜖琘渚渜欞Ġ䄢䀤ܦ䔨个帬尮ᄰ䜲崴嘶圸ᬺ༼ା祀捂♄⽆⡈㥊ⱌⱎ═㙒❔⑖", num));
            }
        }

        internal void method_178()
        {
            if (this.method_179())
            {
                try
                {
                    this.method_180();
                    this.bool_13 = true;
                }
                catch
                {
                }
            }
        }

        private bool method_179()
        {
            if (Class511.smethod_0(this.InternalLicense))
            {
                this.licenseInfo_0 = this.InternalLicense.License;
                this.bool_12 = false;
                return false;
            }
            if (!this.bool_12)
            {
                return false;
            }
            return true;
        }

        private void method_180()
        {
            switch (((int) (Math.Pow((double) this.method_181(), 2.0) % 9.0)))
            {
                case 0:
                    this.method_182();
                    return;

                case 1:
                    this.method_183();
                    return;

                case 4:
                    this.method_184();
                    return;
            }
            this.method_185();
        }

        private int method_181()
        {
            int num = 0;
            try
            {
                DateTime time = new DateTime(0x7da, 1, 1, 0, 0, 0);
                TimeSpan span = (TimeSpan) (DateTime.Now.AddDays(1.0) - time);
                num = Convert.ToInt32(span.TotalSeconds);
            }
            catch (Exception)
            {
            }
            return num;
        }

        private void method_182()
        {
            Paragraph entity = new Paragraph(this);
            byte[] bytes = Convert.FromBase64String(this.string_17);
            ITextRange range = entity.AppendText(Encoding.Unicode.GetString(bytes, 0, bytes.Length));
            range.CharacterFormat.method_55(Color.Red);
            range.CharacterFormat.FontSize = 12f;
            if (((this.m_sections[0].Body.ChildObjects.Count <= 0) || !(this.m_sections[0].Body.ChildObjects[0] is Paragraph)) || (string.IsNullOrEmpty((this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text) || !(this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text.Contains(Encoding.Unicode.GetString(bytes, 0, bytes.Length))))
            {
                this.m_sections[0].Body.ChildObjects.Insert(0, entity);
            }
        }

        private void method_183()
        {
            Paragraph entity = new Paragraph(this);
            byte[] bytes = Convert.FromBase64String(this.string_17);
            ITextRange range = entity.AppendText(Encoding.Unicode.GetString(bytes, 0, bytes.Length));
            range.CharacterFormat.method_55(Color.Red);
            range.CharacterFormat.FontSize = 12f;
            if (((this.m_sections[0].Body.ChildObjects.Count <= 0) || !(this.m_sections[0].Body.ChildObjects[0] is Paragraph)) || (string.IsNullOrEmpty((this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text) || !(this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text.Contains(Encoding.Unicode.GetString(bytes, 0, bytes.Length))))
            {
                this.m_sections[0].Body.ChildObjects.Insert(0, entity);
            }
        }

        private void method_184()
        {
            Paragraph entity = new Paragraph(this);
            byte[] bytes = Convert.FromBase64String(this.string_17);
            ITextRange range = entity.AppendText(Encoding.Unicode.GetString(bytes, 0, bytes.Length));
            range.CharacterFormat.method_55(Color.Red);
            range.CharacterFormat.FontSize = 12f;
            if (((this.m_sections[0].Body.ChildObjects.Count <= 0) || !(this.m_sections[0].Body.ChildObjects[0] is Paragraph)) || (string.IsNullOrEmpty((this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text) || !(this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text.Contains(Encoding.Unicode.GetString(bytes, 0, bytes.Length))))
            {
                this.m_sections[0].Body.ChildObjects.Insert(0, entity);
            }
        }

        private void method_185()
        {
            Paragraph entity = new Paragraph(this);
            byte[] bytes = Convert.FromBase64String(this.string_17);
            ITextRange range = entity.AppendText(Encoding.Unicode.GetString(bytes, 0, bytes.Length));
            range.CharacterFormat.method_55(Color.Red);
            range.CharacterFormat.FontSize = 12f;
            if (((this.m_sections[0].Body.ChildObjects.Count <= 0) || !(this.m_sections[0].Body.ChildObjects[0] is Paragraph)) || (string.IsNullOrEmpty((this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text) || !(this.m_sections[0].Body.ChildObjects[0] as Paragraph).Text.Contains(Encoding.Unicode.GetString(bytes, 0, bytes.Length))))
            {
                this.m_sections[0].Body.ChildObjects.Insert(0, entity);
            }
        }

        private void method_186()
        {
            this.method_187(false);
        }

        private void method_187(bool A_0)
        {
            foreach (Section section in this.Sections)
            {
                section.HeadersFooters.EvenHeader.WriteWatermark = false;
                section.HeadersFooters.OddHeader.WriteWatermark = false;
                section.HeadersFooters.FirstPageHeader.WriteWatermark = false;
                if (A_0)
                {
                    section.HeadersFooters.EvenHeader.Watermark = null;
                    section.HeadersFooters.OddHeader.Watermark = null;
                    section.HeadersFooters.FirstPageHeader.Watermark = null;
                }
            }
        }

        internal void method_188(WatermarkBase A_0)
        {
            this.method_187(true);
            this.watermarkBase_0 = A_0;
            if (this.watermarkBase_0 == null)
            {
                this.watermarkBase_0 = new WatermarkBase(this, WatermarkType.NoWatermark);
            }
            this.watermarkBase_0.method_0(this);
            if (this.watermarkBase_0 is PictureWatermark)
            {
                (this.watermarkBase_0 as PictureWatermark).WordPicture.method_0(this);
            }
        }

        private void method_189(Spire.Doc.ProtectionType A_0)
        {
            if (A_0 == Spire.Doc.ProtectionType.AllowOnlyFormFields)
            {
                foreach (Section section in this.Sections)
                {
                    section.ProtectForm = true;
                }
            }
        }

        internal void method_190(ShapeObject A_0)
        {
            this.shapeObject_0 = A_0;
        }

        private void method_191(XmlWriter A_0)
        {
            new Class669(A_0).method_0(this);
        }

        private void method_192(XmlReader A_0)
        {
            new XDLSReader(A_0).Deserialize(this);
        }

        private void method_193(LicenseInfo A_0, PdfDocumentBase A_1)
        {
            int num = 9;
            if (!this.bool_12 && (this.licenseInfo_0 != null))
            {
                Spire.License.InternalLicense license = new Spire.License.InternalLicense {
                    License = A_0,
                    LicenseType = A_0.Type,
                    ProductName = BookmarkStart.b("簮䄰娲䜴制᜸缺刼尾", num),
                    AssemblyList = new string[] { BookmarkStart.b("簮䄰娲䜴制᜸缺刼尾", num) }
                };
                A_1.ᜀ(license);
            }
        }

        private void method_194()
        {
            this.bool_12 = true;
            this.licenseInfo_0 = null;
            License license = null;
            LicenseManager.IsValid(typeof(Document), this, out license);
            Spire.License.LicenseType type = Class1126.smethod_0(license);
            if ((type & Spire.License.LicenseType.Runtime) == Spire.License.LicenseType.Runtime)
            {
                this.bool_12 = false;
                this.licenseInfo_0 = (LicenseInfo) license;
                this.licenseInfo_0.Type = type;
            }
            else
            {
                this.bool_12 = true;
            }
        }

        internal void method_195(int A_0, int A_1)
        {
            int num = 6;
            if ((A_0 < 0) || (A_0 > (this.int_8 - 1)))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("尫伭圯圱紳堵尷弹䐻", num));
            }
            if ((A_1 < 1) || ((A_0 + A_1) > this.int_8))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("尫伭圯圱眳夵䴷吹䠻", num));
            }
        }

        internal void method_21(BookmarkLevelEventArgs A_0)
        {
            if (this.bookmarkLevelHandler_0 != null)
            {
                this.bookmarkLevelHandler_0(this, A_0);
            }
        }

        internal void method_22(PageLayoutEventArgs A_0)
        {
            if (this.pageLayoutHandler_0 != null)
            {
                this.pageLayoutHandler_0(this, A_0);
            }
        }

        internal void method_23(Class309 A_0)
        {
            if (this.delegate4_0 != null)
            {
                this.delegate4_0(this, A_0);
            }
        }

        internal void method_24(IFieldsEventArgs A_0)
        {
            if (this.updateFieldsHandler_0 != null)
            {
                this.updateFieldsHandler_0(this, A_0);
            }
        }

        private void method_28(string A_0, string A_1)
        {
            int num = 0x10;
            if (File.Exists(A_0))
            {
                if (!string.IsNullOrEmpty(Path.GetExtension(A_0)))
                {
                    FileFormat fileFormat = this.method_29(A_0);
                    this.LoadFromFile(A_0, fileFormat, A_1);
                    return;
                }
                try
                {
                    this.LoadFromFile(A_0, FileFormat.Doc, A_1);
                }
                catch (Exception)
                {
                }
                return;
                try
                {
                    this.LoadFromFile(A_0, FileFormat.Docx, A_1);
                    return;
                }
                catch
                {
                    throw new Exception(BookmarkStart.b("瀵儷嘹夻ḽ☿ⵁ㙃⭅⥇㹉汋്ㅏ㱑㩓㥕ⱗ穙㹛㭝䁟ၡţեݧ൩ɫݭ੯᝱ၳ塵", num));
                }
            }
            throw new Exception(BookmarkStart.b("ᐵ", num) + A_0 + BookmarkStart.b("ᐵᠷ匹伻ḽ⸿ⵁぃ晅ⵇ㉉╋㩍⍏籑", num));
        }

        private FileFormat method_29(string A_0)
        {
            int num = 0x13;
            string key = Path.GetExtension(A_0).ToLower();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_46 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(15);
                    dictionary1.Add(BookmarkStart.b("᜸强刼尾", num), 0);
                    dictionary1.Add(BookmarkStart.b("᜸强刼䬾", num), 1);
                    dictionary1.Add(BookmarkStart.b("᜸强刼尾㥀", num), 2);
                    dictionary1.Add(BookmarkStart.b("᜸强刼䬾㥀", num), 3);
                    dictionary1.Add(BookmarkStart.b("᜸强刼尾ⱀ", num), 4);
                    dictionary1.Add(BookmarkStart.b("᜸强刼䬾ⱀ", num), 5);
                    dictionary1.Add(BookmarkStart.b("᜸伺䔼䬾", num), 6);
                    dictionary1.Add(BookmarkStart.b("᜸䌺值匾", num), 7);
                    dictionary1.Add(BookmarkStart.b("᜸区䤼刾ⵀ", num), 8);
                    dictionary1.Add(BookmarkStart.b("᜸帺䴼䨾⍀", num), 9);
                    dictionary1.Add(BookmarkStart.b("᜸䤺䤼夾", num), 10);
                    dictionary1.Add(BookmarkStart.b("᜸吺夼䬾", num), 11);
                    dictionary1.Add(BookmarkStart.b("᜸䠺䬼堾", num), 12);
                    dictionary1.Add(BookmarkStart.b("᜸䬺夼夾", num), 13);
                    dictionary1.Add(BookmarkStart.b("᜸䌺䴼䰾", num), 14);
                    Class1160.dictionary_46 = dictionary1;
                }
                if (Class1160.dictionary_46.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                            return FileFormat.Doc;

                        case 2:
                            return FileFormat.Docx;

                        case 3:
                            return FileFormat.Dotx;

                        case 4:
                            return FileFormat.Docm;

                        case 5:
                            return FileFormat.Dotm;

                        case 6:
                            return FileFormat.Txt;

                        case 7:
                            return FileFormat.Xml;

                        case 8:
                            return FileFormat.Html;

                        case 9:
                            return FileFormat.EPub;

                        case 10:
                            return FileFormat.Rtf;

                        case 11:
                            return FileFormat.Odt;

                        case 12:
                            return FileFormat.SVG;

                        case 13:
                            return FileFormat.PDF;

                        case 14:
                            return FileFormat.XPS;
                    }
                }
            }
            throw new Exception(BookmarkStart.b("稸娺匼儾⹀㝂敄⍆ⱈ㽊⡌ⱎ═獒㙔≖⭘⥚㡜ㅞᕠ䍢ͤ๦ը๪䵬᭮ࡰͲၴ", num));
        }

        internal void method_30(IDocument A_0, ImportOptions A_1)
        {
            (A_0 as Document).bool_5 = true;
            this.importOptions_0 = A_1;
            if (this.importOptions_0 == ImportOptions.UseDestinationStyles)
            {
                this.bool_9 = false;
            }
            if (this.importOptions_0 == ImportOptions.KeepTextOnly)
            {
                this.method_31(A_0);
            }
            else
            {
                A_0.Sections.method_12(this.m_sections);
                this.method_167((A_0 as Document).MacrosData, ref this.byte_3);
                this.method_167((A_0 as Document).MacroCommands, ref this.byte_6);
                if (((A_0 as Document).ObjectPool != null) && (this.ObjectPool != null))
                {
                    this.method_32(A_0);
                }
                else
                {
                    this.method_167((A_0 as Document).ObjectPool, ref this.byte_2);
                }
                if ((this.class1129_0 == null) && ((A_0 as Document).DocxPackage != null))
                {
                    this.class1129_0 = (A_0 as Document).DocxPackage.method_25();
                }
                this.list_3 = (A_0 as Document).list_3;
                this.list_1 = (A_0 as Document).list_1;
            }
            (A_0 as Document).bool_5 = false;
            this.importOptions_0 = ImportOptions.UseDestinationStyles;
            this.bool_9 = true;
        }

        private void method_31(IDocument A_0)
        {
            string str = A_0.Sections.method_22();
            this.bodyRegion_0 = null;
            ISection section = this.AddSection();
            string[] strArray = str.Split(new char[] { '\r' });
            for (int i = 0; i < strArray.Length; i++)
            {
                section.AddParagraph().AppendText(strArray[i]);
            }
        }

        internal void method_32(IDocument A_0)
        {
            int num = 14;
            if (((A_0 as Document).ObjectPool != null) && ((A_0 as Document).ObjectPool.Length > 0))
            {
                MemoryStream stream = new MemoryStream((A_0 as Document).ObjectPool);
                int num3 = -1;
                try
                {
                    stream.Position = 0L;
                    Stream12 stream2 = new Stream12(stream);
                    string str = stream2.method_2()[0].Replace(BookmarkStart.b("欳", num), string.Empty);
                    if (str == BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num))
                    {
                        Stream12 stream3 = stream2.method_11(str);
                        for (int i = 0; i < stream3.method_2().Length; i++)
                        {
                            str = stream3.method_2()[i].Replace(BookmarkStart.b("欳", num), string.Empty);
                            base.m_doc.ObjPoolContainers.Add(str);
                            num3 = int.Parse(str);
                            if (num3 != -1)
                            {
                                byte[] objectPool = base.m_doc.ObjectPool;
                                Class363.smethod_0(new MemoryStream((A_0 as Document).ObjectPool), num3, new MemoryStream(base.m_doc.ObjectPool), out objectPool);
                                base.m_doc.ObjectPool = objectPool;
                            }
                        }
                    }
                    stream2.Close();
                    stream2.Dispose();
                }
                catch
                {
                }
                stream.Close();
                stream.Dispose();
            }
        }

        internal IStyle method_33(StyleType A_0, string A_1)
        {
            if (A_0 == StyleType.ListStyle)
            {
                throw new NotSupportedException();
            }
            IStyle style = null;
            switch (A_0)
            {
                case StyleType.ParagraphStyle:
                    style = new ParagraphStyle(base.Document);
                    break;

                case StyleType.CharacterStyle:
                    style = new Class11(base.Document);
                    break;

                case StyleType.TableStyle:
                    style = new Class13(base.Document);
                    break;
            }
            if (style != null)
            {
                if ((A_1 != null) && ((A_1.Length > 0) || this.bool_3))
                {
                    style.Name = A_1;
                }
                this.m_styles.Add(style);
            }
            return style;
        }

        private void method_34()
        {
            if (!(base.Document.Styles.FindByName(BookmarkStart.b("戫䄭䈯弱唳娵", 6), StyleType.ParagraphStyle) is ParagraphStyle))
            {
                ParagraphStyle style = (ParagraphStyle) Style.CreateBuiltinStyle(BuiltinStyle.Normal, base.Document);
                base.Document.Styles.Add(style);
            }
        }

        private void method_35(object A_0, Class309 A_1)
        {
            Struct0 struct2 = new Struct0 {
                double_1 = Struct27.smethod_0((double) A_1.method_2()[A_1.method_0()].Height).method_10(),
                double_0 = Struct27.smethod_0((double) A_1.method_2()[A_1.method_0()].Width).method_10(),
                image_0 = A_1.method_4(),
                class500_0 = A_1.method_12()[A_1.method_0()]
            };
            this.dictionary_8.Add(A_1.method_0(), struct2);
        }

        private float method_36(float A_0, float A_1)
        {
            if (A_1 <= 0f)
            {
                A_1 = 96f;
            }
            return (float) Math.Round((double) (A_0 * A_1));
        }

        private float method_37(float A_0, float A_1)
        {
            if (A_1 <= 0f)
            {
                A_1 = 96f;
            }
            return (float) Math.Round((double) (A_0 / A_1), 2);
        }

        private Image method_38(Image A_0, SizeF A_1, SizeF A_2, int A_3)
        {
            int num;
            int num2;
            Image image2;
            int width;
            int height;
            if (A_3 != 0)
            {
                A_3 = A_3 % 360;
                double d = (A_3 * 3.1415926535897931) / 180.0;
                double num4 = Math.Cos(d);
                double num5 = Math.Sin(d);
                width = A_0.Width;
                height = A_0.Height;
                num = (int) Math.Max(Math.Abs((double) ((width * num4) - (height * num5))), Math.Abs((double) ((width * num4) + (height * num5))));
                num2 = (int) Math.Max(Math.Abs((double) ((width * num5) - (height * num4))), Math.Abs((double) ((width * num5) + (height * num4))));
                image2 = null;
                if (A_0 is Metafile)
                {
                    MemoryStream stream = new MemoryStream();
                    using (Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppPArgb))
                    {
                        bitmap.SetResolution(96f, 96f);
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            IntPtr hdc = graphics.GetHdc();
                            RectangleF frameRect = new RectangleF(0f, 0f, (float) num, (float) num2);
                            image2 = new Metafile(stream, hdc, frameRect, MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
                            graphics.Dispose();
                        }
                        goto Label_024E;
                    }
                }
                image2 = new Bitmap(num, num2);
                goto Label_024E;
            }
            Image image = null;
            if (A_0 is Metafile)
            {
                MemoryStream stream2 = new MemoryStream();
                using (Bitmap bitmap2 = new Bitmap((int) A_2.Width, (int) A_2.Height, PixelFormat.Format32bppPArgb))
                {
                    bitmap2.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
                    using (Graphics graphics4 = Graphics.FromImage(bitmap2))
                    {
                        IntPtr referenceHdc = graphics4.GetHdc();
                        RectangleF ef2 = new RectangleF(new PointF(0f, 0f), A_2);
                        image = new Metafile(stream2, referenceHdc, ef2, MetafileFrameUnit.Pixel, EmfType.EmfPlusDual);
                        graphics4.Dispose();
                    }
                    goto Label_00D1;
                }
            }
            image = new Bitmap((int) A_2.Width, (int) A_2.Height);
            (image as Bitmap).SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
        Label_00D1:
            using (Graphics graphics3 = Graphics.FromImage(image))
            {
                graphics3.InterpolationMode = InterpolationMode.High;
                graphics3.DrawImage(A_0, new Rectangle(0, 0, (int) A_2.Width, (int) A_2.Height), new Rectangle(0, 0, A_0.Width, A_0.Height), GraphicsUnit.Pixel);
            }
            return image;
        Label_024E:
            using (Graphics graphics2 = Graphics.FromImage(image2))
            {
                graphics2.InterpolationMode = InterpolationMode.High;
                graphics2.SmoothingMode = SmoothingMode.HighQuality;
                Point point = new Point((num - width) / 2, (num2 - height) / 2);
                Rectangle rect = new Rectangle(point.X, point.Y, width, height);
                Point point2 = new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));
                graphics2.TranslateTransform((float) point2.X, (float) point2.Y);
                graphics2.RotateTransform((float) A_3);
                graphics2.TranslateTransform((float) -point2.X, (float) -point2.Y);
                graphics2.DrawImage(A_0, rect);
                graphics2.ResetTransform();
                graphics2.Save();
            }
            return image2;
        }

        private void method_39(Stream A_0, string A_1, FileFormat A_2)
        {
            this.bool_3 = true;
            Class861 class2 = new Class861();
            class2.method_3(A_2);
            Class1132 class3 = new Class1132(A_0);
            new Class764(class3, A_1, this, class2).method_28();
            this.bool_3 = false;
        }

        private void method_40(string A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_25(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_41(Stream A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_26(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_42(string A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_27(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_43(Stream A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_28(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_44(string A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_25(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_45(Stream A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_26(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_46(string A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_25(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_47(Stream A_0)
        {
            using (Class563 class2 = new Class563())
            {
                this.bool_3 = true;
                class2.method_26(A_0, this);
                this.bool_3 = false;
            }
        }

        private void method_48(Stream A_0)
        {
            this.bool_3 = true;
            new Class582(A_0, this).method_27();
            this.bool_3 = false;
        }

        private void method_49(string A_0)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.bool_3 = true;
                Class861 class2 = new Class861();
                class2.method_3(FileFormat.WordML);
                new Class582(stream, this, class2).method_27();
                this.bool_3 = false;
            }
        }

        private void method_50(string A_0)
        {
            using (Stream stream = File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                this.method_51(stream);
            }
        }

        private void method_51(Stream A_0)
        {
            this.bool_3 = true;
            new Class861().method_3(FileFormat.Odt);
            new Class857(A_0, this).method_0();
            this.bool_3 = false;
        }

        private void method_52(Stream A_0, Class928 A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class422().method_4(this, A_0, A_1);
            }
        }

        private void method_53(string A_0)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.Write))
            {
                Class253 class2 = new Class255(FileFormat.Odt);
                Class928 class3 = new Class928(this, stream, A_0, class2);
                this.method_52(stream, class3);
                stream.Flush();
            }
        }

        internal void method_54(string A_0)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.method_55(stream);
            }
        }

        internal void method_55(Stream A_0)
        {
            XmlReaderSettings settings;
            settings = new XmlReaderSettings {
                ValidationType = ValidationType.Schema,
                ValidationFlags = settings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings,
                CheckCharacters = false
            };
            XmlReader reader = XmlReader.Create(A_0, settings);
            this.method_192(reader);
        }

        internal void method_56(string A_0)
        {
            using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.method_57(stream);
            }
        }

        internal void method_57(Stream A_0)
        {
            this.bool_3 = true;
            new Class878().method_1(A_0, this);
            this.bool_3 = false;
        }

        private void method_58(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                XmlTextWriter writer = new XmlTextWriter(A_0, Encoding.Unicode) {
                    Formatting = Formatting.Indented
                };
                this.method_191(writer);
                writer.Close();
            }
        }

        private void method_59(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                XmlTextWriter writer = new XmlTextWriter(A_0, Encoding.Unicode);
                try
                {
                    writer.Formatting = Formatting.Indented;
                    this.method_191(writer);
                }
                finally
                {
                    writer.Flush();
                }
            }
        }

        private void method_60(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                this.SaveToTxt(A_0, Encoding.UTF8);
            }
        }

        private void method_61(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                StreamWriter writer = new StreamWriter(A_0);
                try
                {
                    new Class775().method_2(writer, this);
                }
                finally
                {
                    writer.Flush();
                }
            }
        }

        private void method_62(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class423().method_5(this, A_0);
            }
        }

        private void method_63(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class423().method_6(this, A_0, FileFormat.Dot);
            }
        }

        private void method_64(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class421().method_3(this, A_0);
            }
        }

        private void method_65(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class421().method_4(this, A_0);
            }
        }

        private void method_66(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class465 class2 = new Class465())
                {
                    class2.method_52(A_0, this);
                }
            }
        }

        private void method_67(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class465 class2 = new Class465())
                {
                    class2.method_53(A_0, this);
                }
            }
        }

        private void method_68(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class465 class2 = new Class465())
                {
                    class2.method_49(A_0, this);
                }
            }
        }

        private void method_69(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class465 class2 = new Class465())
                {
                    class2.method_50(A_0, this);
                }
            }
        }

        private void method_70(string A_0, DocPicture A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                Class1147 class2 = new Class1147();
                class2.method_3(Path.GetFileName(A_0).Replace(Path.GetExtension(A_0), string.Empty));
                class2.method_1(A_1);
                class2.method_4(A_0, this);
            }
        }

        private void method_71(Stream A_0, DocPicture A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                Class1147 class2 = new Class1147();
                class2.method_1(A_1);
                class2.method_5(A_0, this);
            }
        }

        private void method_72(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class926().method_15(this, A_0);
            }
        }

        private void method_73(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class926().method_17(this, A_0);
            }
        }

        private Encoding method_74(Stream A_0)
        {
            int num2;
            A_0.Position = 0L;
            Encoding unicode = Encoding.Default;
            BinaryReader reader = new BinaryReader(A_0, Encoding.Default);
            int.TryParse(A_0.Length.ToString(), out num2);
            byte[] buffer = reader.ReadBytes(num2);
            if (!this.method_75(buffer) && (((buffer[0] != 0xef) || (buffer[1] != 0xbb)) || (buffer[2] != 0xbf)))
            {
                if ((buffer[0] == 0xfe) && (buffer[1] == 0xff))
                {
                    return Encoding.BigEndianUnicode;
                }
                if ((buffer[0] == 0xff) && (buffer[1] == 0xfe))
                {
                    unicode = Encoding.Unicode;
                }
                return unicode;
            }
            return Encoding.UTF8;
        }

        private bool method_75(byte[] A_0)
        {
            int num = 1;
            for (int i = 0; i < A_0.Length; i++)
            {
                byte num3 = A_0[i];
                if (num == 1)
                {
                    if (num3 >= 0x80)
                    {
                        while (((num3 = (byte) (num3 << 1)) & 0x80) != 0)
                        {
                            num++;
                        }
                        if ((num == 1) || (num > 6))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if ((num3 & 0xc0) != 0x80)
                    {
                        return false;
                    }
                    num--;
                }
            }
            if (num > 1)
            {
                return false;
            }
            return true;
        }

        internal void method_76(string A_0)
        {
            using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.method_77(stream);
            }
        }

        internal void method_77(Stream A_0)
        {
            this.method_78(A_0, null);
        }

        internal void method_78(Stream A_0, Encoding A_1)
        {
            if (A_1 == null)
            {
                A_1 = this.method_74(A_0);
            }
            A_0.Position = 0L;
            using (StreamReader reader = new StreamReader(A_0, A_1))
            {
                this.method_79(reader);
            }
        }

        internal void method_79(TextReader A_0)
        {
            new Class775().method_4(A_0, this);
        }

        private void method_80(string A_0)
        {
            using (Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.method_81(stream);
            }
        }

        internal void method_81(Stream A_0)
        {
            this.method_82(A_0, null);
        }

        internal void method_82(Stream A_0, Encoding A_1)
        {
            using (Class834 class2 = new Class834(this, A_0, A_1))
            {
                class2.method_41();
            }
        }

        internal void method_83(TextReader A_0)
        {
            using (Class834 class2 = new Class834(this, A_0))
            {
                class2.method_41();
            }
        }

        internal void method_84(Stream A_0, XHTMLValidationType A_1)
        {
            int codepage = this.method_85(A_0);
            A_0.Position = 0L;
            using (StreamReader reader = new StreamReader(A_0, Encoding.GetEncoding(codepage)))
            {
                this.LoadHTML(reader, A_1);
            }
        }

        private int method_85(Stream A_0)
        {
            int num = 13;
            int codePage = 0x4e4;
            StreamReader reader = new StreamReader(A_0, Encoding.GetEncoding(0x4e4));
            string str = reader.ReadToEnd().Trim();
            using (Class747 class2 = new Class747())
            {
                class2.method_18(str, null);
                XmlNode documentElement = class2.xmlDocument_0.DocumentElement;
                XmlNode node2 = class2.xmlDocument_0.DocumentElement;
                if (documentElement.LocalName.ToLower() == BookmarkStart.b("嬲䄴娶唸", num))
                {
                    using (IEnumerator enumerator = documentElement.ChildNodes.GetEnumerator())
                    {
                        XmlNode current;
                        while (enumerator.MoveNext())
                        {
                            current = (XmlNode) enumerator.Current;
                            if ((current.LocalName.ToLower() == BookmarkStart.b("嬲倴嘶崸", num)) && (current.NodeType == XmlNodeType.Element))
                            {
                                goto Label_00EE;
                            }
                            if (current.LocalName.ToLower() == BookmarkStart.b("儲娴匶䀸", num))
                            {
                                goto Label_0283;
                            }
                        }
                        goto Label_02AC;
                    Label_00EE:
                        node2 = current;
                        foreach (XmlNode node4 in node2.ChildNodes)
                        {
                            string str2;
                            if (((node4.NodeType == XmlNodeType.Element) && ((str2 = node4.LocalName.ToLower()) != null)) && (str2 == BookmarkStart.b("帲倴䌶堸", num)))
                            {
                                foreach (XmlAttribute attribute in node4.Attributes)
                                {
                                    if ((attribute.Name.ToLower() == BookmarkStart.b("倲娴夶䴸帺匼䬾", num)) && attribute.Value.Contains(BookmarkStart.b("倲崴嘶䬸䠺堼䬾", num)))
                                    {
                                        string str3 = attribute.Value;
                                        int index = str3.IndexOf(BookmarkStart.b("า", num), str3.IndexOf(BookmarkStart.b("倲崴嘶䬸䠺堼䬾", num)));
                                        if (index >= 0)
                                        {
                                            codePage = Encoding.GetEncoding(str3.Substring(index + 1).Trim()).CodePage;
                                        }
                                    }
                                    else if ((attribute.Name.ToLower() == BookmarkStart.b("倲崴嘶䬸䠺堼䬾", num)) && !string.IsNullOrEmpty(attribute.Value))
                                    {
                                        codePage = Encoding.GetEncoding(attribute.Value.Trim()).CodePage;
                                    }
                                }
                            }
                        }
                        goto Label_02AC;
                    Label_0283:
                        documentElement = current;
                    }
                }
            }
        Label_02AC:
            reader = null;
            return codePage;
        }

        private void method_86(string A_0, string A_1, FileFormat A_2)
        {
            using (Stream stream = File.Open(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                this.method_39(stream, A_1, A_2);
            }
        }

        private void method_87(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class423().method_3(this, A_0);
            }
        }

        private void method_88(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class423().method_4(this, A_0, FileFormat.Dot);
            }
        }

        internal void method_89(string A_0, FileFormat A_1, XHTMLValidationType A_2, string A_3)
        {
            this.HtmlBaseUrl = A_3;
            this.LoadFromFile(A_0, A_1, A_2);
        }

        private void method_90(string A_0, ref FileFormat A_1)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = 0L;
                if (this.method_155(stream))
                {
                    using (Interface51 interface2 = this.method_154(stream))
                    {
                        Interface61 interface3 = interface2.imethod_0();
                        Class299.EncrytionType type = new Class299().method_0(interface3);
                        stream.Position = 0L;
                        if (type != Class299.EncrytionType.None)
                        {
                            A_1 = FileFormat.Docx;
                            stream.Close();
                            return;
                        }
                    }
                }
                stream.Position = 0L;
                byte[] buffer = new byte[5];
                if (((stream.Read(buffer, 0, 5) == 5) && (buffer[0] == 80)) && (buffer[1] == 0x4b))
                {
                    stream.Position = 0L;
                    A_1 = this.method_108(stream);
                }
                else
                {
                    if ((buffer[0] == 0xd0) && (buffer[1] == 0xcf))
                    {
                        try
                        {
                            using (Class363 class2 = new Class363(A_0, false))
                            {
                                if (class2.method_1())
                                {
                                    A_1 = FileFormat.Doc;
                                }
                            }
                            goto Label_010D;
                        }
                        catch (Exception)
                        {
                            goto Label_010D;
                        }
                    }
                    Encoding encoding = this.method_91(buffer);
                    this.method_92(stream, ref A_1, encoding);
                }
            Label_010D:
                stream.Close();
                stream.Dispose();
            }
        }

        private Encoding method_91(byte[] A_0)
        {
            if (((A_0[0] == 0xef) && (A_0[1] == 0xbb)) && (A_0[2] == 0xbf))
            {
                return Encoding.UTF8;
            }
            if (((A_0[0] != 0xff) || (A_0[1] != 0xfe)) && ((A_0[0] != 0xfe) || (A_0[1] != 0xff)))
            {
                return Encoding.ASCII;
            }
            return Encoding.Unicode;
        }

        private void method_92(Stream A_0, ref FileFormat A_1, Encoding A_2)
        {
            int num = 14;
            byte[] buffer = new byte[12];
            A_0.Position = 0L;
            A_0.Read(buffer, 0, 12);
            string str = A_2.GetString(buffer).ToLower();
            if (str.StartsWith(BookmarkStart.b("伳樵䨷丹娻", 14)))
            {
                A_0.Position = 0L;
                A_1 = FileFormat.Rtf;
            }
            if (!str.Contains(BookmarkStart.b("࠳帵䰷圹倻", num)) && !str.Contains(BookmarkStart.b("࠳᜵尷唹弻", num)))
            {
                if (str.Contains(BookmarkStart.b("࠳व䀷圹倻", num)))
                {
                    A_0.Position = 0L;
                    this.method_93(A_0, ref A_1);
                }
            }
            else
            {
                A_0.Position = 0L;
                A_1 = FileFormat.Html;
            }
        }

        private void method_93(Stream A_0, ref FileFormat A_1)
        {
            int num = 12;
            A_0.Position = 0L;
            XmlReaderSettings settings = new XmlReaderSettings {
                XmlResolver = null,
                ProhibitDtd = false
            };
            XmlReader reader = XmlReader.Create(A_0, settings);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            if (((document.ChildNodes.Count >= 3) && !string.IsNullOrEmpty(document.ChildNodes[1].Value)) && ((document.ChildNodes[1].Value.ToLower() == BookmarkStart.b("䈱䘳夵強匹堻̽房㕁⭃㑅ⱇ摉⡋⅍㍏❑㥓㍕㙗⹙繛", num)) || (document.ChildNodes[1].Value.ToLower() == BookmarkStart.b("䈱䘳夵強匹堻̽朿㕁⭃㑅ⱇ摉⡋⅍㍏❑㥓㍕㙗⹙筛", num))))
            {
                if (document.ChildNodes[2].LocalName.ToLower() == BookmarkStart.b("䈱唳唵匷嬹嬻嬽", num))
                {
                    A_1 = FileFormat.WordXml;
                }
                else if (!(document.ChildNodes[2].LocalName.ToLower() == BookmarkStart.b("娱䀳嬵吷", num)) && (A_1 != FileFormat.Html))
                {
                    A_1 = FileFormat.WordML;
                }
                else
                {
                    A_1 = FileFormat.Html;
                }
            }
            else if (document.ChildNodes.Count >= 2)
            {
                if (document.ChildNodes[1].LocalName.ToLower() == BookmarkStart.b("䈱唳唵匷嬹嬻嬽", num))
                {
                    A_1 = FileFormat.WordXml;
                }
                else if (!(document.ChildNodes[1].LocalName.ToLower() == BookmarkStart.b("娱䀳嬵吷", num)) && (A_1 != FileFormat.Html))
                {
                    A_1 = FileFormat.WordML;
                }
                else
                {
                    A_1 = FileFormat.Html;
                }
            }
            else
            {
                A_1 = FileFormat.Xml;
            }
            document = null;
        }

        private void method_94(string A_0, DocPicture A_1)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                if (this.IsUpdateFields)
                {
                    this.method_131();
                }
                this.method_70(A_0, A_1);
            }
        }

        private void method_95(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class643 class2 = new Class643())
                {
                    class2.method_21(A_0, this);
                }
            }
        }

        private void method_96(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                StreamWriter writer = new StreamWriter(A_0, Encoding.ASCII);
                using (Class643 class2 = new Class643())
                {
                    writer.AutoFlush = true;
                    class2.method_22(writer, this);
                }
            }
        }

        private void method_97(Stream A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class804().method_1(this, A_0);
            }
        }

        private void method_98(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                new Class804().method_0(this, A_0);
            }
        }

        private void method_99(string A_0)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class866 class2 = new Class866())
                {
                    class2.method_4(this.JPEGQuality);
                    using (PdfNewDocument document = class2.method_5(this))
                    {
                        this.method_193(this.licenseInfo_0, document);
                        document.Save(A_0);
                        document.Close();
                    }
                    class2.Dispose();
                }
            }
        }

        protected virtual void OnBeginPrint(object sender, PrintEventArgs e)
        {
            this.int_9 = this.printDocument_0.PrinterSettings.FromPage;
            this.int_10 = this.printDocument_0.PrinterSettings.ToPage;
            if (this.int_9 <= 0)
            {
                this.int_11 = 0;
            }
            else
            {
                this.int_11 = this.int_9 - 1;
            }
            this.dictionary_8.Clear();
            this.PageImagePainted += new Delegate4(this.method_35);
            this.method_119();
            this.PageImagePainted -= new Delegate4(this.method_35);
            if ((this.int_10 <= 0) || (this.int_10 > this.dictionary_8.Count))
            {
                this.int_10 = this.dictionary_8.Count;
            }
        }

        protected virtual void OnEndPrint(object sender, PrintEventArgs e)
        {
            if (this.printDocument_0 != null)
            {
                this.printDocument_0.Dispose();
                this.printDocument_0 = null;
            }
            if (this.printDialog_0 != null)
            {
                this.printDialog_0 = null;
            }
            if (this.dictionary_8.Count > 0)
            {
                foreach (int num in this.dictionary_8.Keys)
                {
                    this.dictionary_8[num].System.IDisposable.Dispose();
                }
                this.dictionary_8 = new Dictionary<int, Struct0>();
            }
            if (this.class195_1 != null)
            {
                this.class195_1.method_54();
                this.class195_1.System.IDisposable.Dispose();
                this.class195_1 = null;
            }
        }

        protected virtual void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            if (this.int_11 < this.int_10)
            {
                Struct0 struct2 = this.dictionary_8[this.int_11];
                if (this.class195_1 != null)
                {
                    this.class195_1.method_53(struct2.class500_0, e.Graphics, this.int_11);
                }
                this.int_11++;
                e.HasMorePages = this.int_11 < this.int_10;
            }
        }

        protected virtual void OnQueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            if (this.int_11 < this.int_10)
            {
                Struct0 struct2 = this.dictionary_8[this.int_11];
                PaperSize paperSize = e.PageSettings.PaperSize;
                if ((paperSize.Width < paperSize.Height) && (struct2.double_0 > struct2.double_1))
                {
                    e.PageSettings.Landscape = true;
                }
                else
                {
                    e.PageSettings.Landscape = false;
                }
            }
        }

        public void Protect(Spire.Doc.ProtectionType type)
        {
            this.Protect(type, null);
        }

        public void Protect(Spire.Doc.ProtectionType type, string password)
        {
            this.Settings.method_13(type, password);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 4;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("礩堫伭帯嘱唳䐵尷笹伻崽⤿⭁", 4)))
            {
                this.string_11 = reader.ReadString(BookmarkStart.b("礩堫伭帯嘱唳䐵尷笹伻崽⤿⭁", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("礩堫伭帯嘱唳䐵尷簹崻䰽Կ⍁㝃㉅", num)))
            {
                this.string_12 = reader.ReadString(BookmarkStart.b("礩堫伭帯嘱唳䐵尷簹崻䰽Կ⍁㝃㉅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("礩堫伭帯嘱唳䐵尷琹医倽ؿ⍁㙃ͅ⥇㥉㡋", num)))
            {
                this.string_13 = reader.ReadString(BookmarkStart.b("礩堫伭帯嘱唳䐵尷琹医倽ؿ⍁㙃ͅ⥇㥉㡋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("紩䴫娭唯䀱夳圵䨷儹栻䜽〿❁", num)))
            {
                WatermarkType type = (WatermarkType) reader.ReadEnum(BookmarkStart.b("紩䴫娭唯䀱夳圵䨷儹栻䜽〿❁", num), typeof(WatermarkType));
                this.method_160(type);
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            int num = 14;
            if (reader.TagName == BookmarkStart.b("夳圵嬷䠹医䴽", 14))
            {
                this.MacrosData = reader.ReadChildBinaryElement();
            }
            if (reader.TagName == BookmarkStart.b("夳圵嬷䠹医䴽洿⅁⭃⭅╇⭉≋⩍⍏", num))
            {
                this.MacroCommands = reader.ReadChildBinaryElement();
            }
            if (reader.TagName == BookmarkStart.b("嬳吵刷弹弻䨽洿㉁⭃⥅⑇", num))
            {
                this.ObjectPool = reader.ReadChildBinaryElement();
            }
            if (reader.TagName == BookmarkStart.b("儳䔵嬷刹夻䰽洿⅁⭃⡅㱇⭉╋⁍㕏⁑❓", num))
            {
                this.byte_5 = reader.ReadChildBinaryElement();
            }
            if (reader.TagName == BookmarkStart.b("儳䔵嬷刹夻䰽洿♁╃㉅⥇", num))
            {
                this.byte_4 = reader.ReadChildBinaryElement();
            }
            if ((this.byte_4 != null) && (this.byte_5 != null))
            {
                MemoryStream stream = new MemoryStream(this.byte_4, 0, this.byte_4.Length);
                MemoryStream stream2 = new MemoryStream(this.byte_5, 0, this.byte_5.Length);
                stream.Close();
                stream2.Close();
                stream = null;
                stream2 = null;
                this.byte_4 = null;
                this.byte_5 = null;
            }
            if (reader.TagName == BookmarkStart.b("倳夵䠷᜹唻倽㐿❁㙃⡅⥇♉", num))
            {
                MemoryStream stream3 = new MemoryStream(reader.ReadChildBinaryElement());
                stream3.Close();
                stream3 = null;
            }
            if (this.class1011_0 == null)
            {
                this.class1011_0 = new Class1011();
            }
            if (reader.TagName == BookmarkStart.b("匳䐵夷圹儻弽㈿潁⁃❅㱇⭉", num))
            {
                this.class1011_0.method_3(reader.ReadChildBinaryElement());
            }
            if (reader.TagName == BookmarkStart.b("䜳䘵崷嘹倻圽⸿╁楃≅⥇㹉ⵋ", num))
            {
                this.class1011_0.method_1(reader.ReadChildBinaryElement());
            }
            return base.ReadXmlContent(reader);
        }

        public void RejectChanges()
        {
            foreach (Section section in this.Sections)
            {
                section.method_29(false);
            }
        }

        public void RemoveEncryption()
        {
            this.string_10 = string.Empty;
            this.bool_14 = false;
        }

        public int Replace(Regex pattern, TextSelection textSelection)
        {
            return this.method_121(pattern, textSelection, false);
        }

        public int Replace(Regex pattern, string replace)
        {
            int num = 0;
            foreach (Section section in this.Sections)
            {
                foreach (Body body in section.ChildObjects)
                {
                    num += body.method_24(pattern, replace);
                    if (this.ReplaceFirst && (num > 0))
                    {
                        return num;
                    }
                }
            }
            return num;
        }

        public int Replace(string matchString, TextSelection textSelection, bool caseSensitive, bool wholeWord)
        {
            return this.method_120(matchString, textSelection, caseSensitive, wholeWord, false);
        }

        public int Replace(string matchString, IDocument matchDoc, bool caseSensitive, bool wholeWord)
        {
            return this.method_126(matchString, matchDoc, caseSensitive, wholeWord, false);
        }

        public int Replace(string matchString, string newValue, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.Replace(pattern, newValue);
        }

        public int ReplaceInLine(Regex pattern, TextSelection matchSelection)
        {
            int num = 0;
            BodyRegion start = this.Sections[0].Body.Items[0];
            for (TextSelection[] selectionArray = this.FindPatternInLine(start, pattern); selectionArray != null; selectionArray = this.FindPatternInLine(start, pattern))
            {
                Class193.smethod_0().method_2(selectionArray, matchSelection);
                num++;
                if (this.ReplaceFirst)
                {
                    return num;
                }
            }
            return num;
        }

        public int ReplaceInLine(Regex pattern, string newValue)
        {
            BodyRegion region = this.Sections[0].Body.Items[0];
            int num = this.method_146(pattern, newValue, region);
            if (this.ReplaceFirst && (num > 0))
            {
                return num;
            }
            return (num + this.method_144(pattern, newValue));
        }

        public int ReplaceInLine(string matchString, TextSelection matchSelection, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.ReplaceInLine(pattern, matchSelection);
        }

        public int ReplaceInLine(string matchString, string newValue, bool caseSensitive, bool wholeWord)
        {
            Regex pattern = Class191.smethod_1(matchString, caseSensitive, wholeWord);
            return this.ReplaceInLine(pattern, newValue);
        }

        public void ResetFindState()
        {
            this.paragraphBase_0 = null;
            this.bodyRegion_1 = null;
        }

        internal override void ResetLayoutInfo()
        {
            base.ResetLayoutInfo();
        }

        public void SaveToFile(string fileName)
        {
            this.SaveToFile(fileName, FileFormat.Auto);
        }

        public void SaveToFile(Stream stream, FileFormat fileFormat)
        {
            int num = 10;
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                if (this.IsUpdateFields)
                {
                    this.method_131();
                }
                this.method_178();
                this.SaveFormatType = fileFormat;
                switch (fileFormat)
                {
                    case FileFormat.Doc:
                        this.method_62(stream);
                        return;

                    case FileFormat.Dot:
                        this.method_63(stream);
                        return;

                    case FileFormat.Docx:
                    case FileFormat.Docx2010:
                    case FileFormat.Docx2013:
                    case FileFormat.Dotx:
                    case FileFormat.Dotx2010:
                    case FileFormat.Dotx2013:
                    case FileFormat.Docm:
                    case FileFormat.Docm2010:
                    case FileFormat.Docm2013:
                    case FileFormat.Dotm:
                    case FileFormat.Dotm2010:
                    case FileFormat.Dotm2013:
                        this.method_69(stream);
                        return;

                    case FileFormat.WordML:
                        this.method_64(stream);
                        return;

                    case FileFormat.WordXml:
                        this.method_67(stream);
                        return;

                    case FileFormat.Odt:
                    {
                        Class253 class2 = new Class255(FileFormat.Odt);
                        Class928 class3 = new Class928(this, stream, string.Empty, class2);
                        this.method_52(stream, class3);
                        return;
                    }
                    case FileFormat.Ott:
                    case FileFormat.SVG:
                        return;

                    case FileFormat.PDF:
                        this.method_105(stream);
                        return;

                    case FileFormat.Rtf:
                        this.method_96(stream);
                        return;

                    case FileFormat.Xml:
                        this.method_59(stream);
                        return;

                    case FileFormat.Txt:
                        this.method_61(stream);
                        return;

                    case FileFormat.Html:
                        this.method_73(stream);
                        return;

                    case FileFormat.XPS:
                        this.method_104(stream);
                        return;

                    case FileFormat.EPub:
                        this.method_71(stream, null);
                        return;

                    case FileFormat.DocPre97:
                        throw new ArgumentException(BookmarkStart.b("术䀱崳䈵儷吹嬻ḽؿ⭁⡃⍅็╉㹋⍍ㅏ♑瑓ቕ㝗㥙౛ⱝ՟孡卣䙥ŧᥩ䱫mὯٱ味յ൷੹౻ᅽꚇ", num), BookmarkStart.b("嘯嬱堳匵縷唹主匽ℿ㙁", num));

                    case FileFormat.Auto:
                        throw new Exception(BookmarkStart.b("猯匱娳ᘵ嘷唹䠻ḽ㔿ㅁ⅃晅⥇㽉㡋⅍灏㑑㭓⑕㕗㭙⡛繝ᑟ᭡ᑣͥ䡧ṩͫ乭ͯ፱ɳ፵塷ᱹᕻች겁", num));
                }
            }
        }

        public void SaveToFile(string fileName, FileFormat fileFormat)
        {
            int num = 5;
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                if (this.IsUpdateFields)
                {
                    this.method_131();
                }
                this.method_178();
                if (fileFormat == FileFormat.Auto)
                {
                    fileFormat = this.method_29(fileName);
                }
                this.SaveFormatType = fileFormat;
                switch (fileFormat)
                {
                    case FileFormat.Doc:
                        this.method_87(fileName);
                        return;

                    case FileFormat.Dot:
                        this.method_88(fileName);
                        return;

                    case FileFormat.Docx:
                    case FileFormat.Docx2010:
                    case FileFormat.Docx2013:
                    case FileFormat.Dotx:
                    case FileFormat.Dotx2010:
                    case FileFormat.Dotx2013:
                    case FileFormat.Docm:
                    case FileFormat.Docm2010:
                    case FileFormat.Docm2013:
                    case FileFormat.Dotm:
                    case FileFormat.Dotm2010:
                    case FileFormat.Dotm2013:
                        this.method_68(fileName);
                        return;

                    case FileFormat.WordML:
                        this.method_65(fileName);
                        return;

                    case FileFormat.WordXml:
                        this.method_66(fileName);
                        return;

                    case FileFormat.Odt:
                        this.method_53(fileName);
                        return;

                    case FileFormat.Ott:
                        return;

                    case FileFormat.PDF:
                        this.method_99(fileName);
                        return;

                    case FileFormat.Rtf:
                        this.method_95(fileName);
                        return;

                    case FileFormat.SVG:
                        this.SaveToSVG(fileName);
                        return;

                    case FileFormat.Xml:
                        this.method_58(fileName);
                        return;

                    case FileFormat.Txt:
                        this.method_60(fileName);
                        return;

                    case FileFormat.Html:
                        this.method_72(fileName);
                        return;

                    case FileFormat.XPS:
                        this.method_100(fileName);
                        return;

                    case FileFormat.EPub:
                        this.method_70(fileName, null);
                        return;

                    case FileFormat.DocPre97:
                        throw new ArgumentException(BookmarkStart.b("簪弬䘮䔰娲嬴倶ᤸ紺吼匾⑀Ղ⩄㕆⑈⩊㥌潎ᕐ㱒㙔ݖ⭘㹚摜桞䅠੢ᙤ䝦ݨѪᥬ佮ɰٲմݶᙸॺॼ᩾궂", num), BookmarkStart.b("䴪䐬䌮吰甲娴䔶吸娺䤼", num));
                }
            }
        }

        public void SaveToFile(string fileName, ToPdfParameterList paramList)
        {
            int num = 6;
            if (paramList == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("ห席儯䀱唳嬵琷匹伻䨽房扁㑃❅㩇⭉⅋⭍⑏㝑♓╕硗㥙㵛そ䝟ᙡ䑣eݧᡩ䱫୭ᵯɱsཱུ噷", num));
            }
            this.method_101(fileName, paramList);
        }

        [Obsolete("Use SaveToFile(string fileName, ToPdfParameterList paramList)")]
        public void SaveToFile(string fileName, List<string> embeddedFontNameList)
        {
            int num = 9;
            if (embeddedFontNameList == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("മ吰帲圴制崸强堼嬾݀ⱂ⭄㍆݈⩊⁌⩎ᵐ㩒♔⍖筘筚ⵜ㹞፠ɢࡤɦᵨ๪Ὤᱮ兰ၲᑴ᥶幸ེ嵼᥾ꖄﮊ歷뾐", num));
            }
            this.method_102(fileName, embeddedFontNameList);
        }

        public void SaveToFile(string fileName, FileFormat fileFormat, HttpResponse response, HttpContentType contentType)
        {
            int num = 9;
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                if (this.IsUpdateFields)
                {
                    this.method_131();
                }
                this.method_178();
                fileName = Path.GetFileName(fileName);
                if (fileFormat == FileFormat.Auto)
                {
                    fileFormat = this.method_29(fileName);
                }
                this.SaveFormatType = fileFormat;
                response.Clear();
                string str = string.Empty;
                switch (fileFormat)
                {
                    case FileFormat.Doc:
                    case FileFormat.Dot:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄⩆㩈㱊≌㵎㕐", num);
                        break;

                    case FileFormat.Docx:
                    case FileFormat.Dotx:
                    case FileFormat.Docm:
                    case FileFormat.Dotm:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄ㅆ❈⽊捌≎≐繒≔㡖⭘㽚獜㭞๠bၤ੦౨ժᥬ䅮䁰䅲", num);
                        break;

                    case FileFormat.Docx2010:
                    case FileFormat.Dotx2010:
                    case FileFormat.Docm2010:
                    case FileFormat.Dotm2010:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄ㅆ❈⽊捌≎≐繒≔㡖⭘㽚獜㭞๠bၤ੦౨ժᥬ䅮䁰䝲", num);
                        break;

                    case FileFormat.Docx2013:
                    case FileFormat.Dotx2013:
                    case FileFormat.Docm2013:
                    case FileFormat.Dotm2013:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄ㅆ❈⽊捌≎≐繒≔㡖⭘㽚獜㭞๠bၤ੦౨ժᥬ䅮䁰䙲", num);
                        break;

                    case FileFormat.PDF:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄㝆ⵈⵊ", num);
                        break;

                    case FileFormat.Xml:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄㽆⑈❊", num);
                        break;

                    case FileFormat.EPub:
                        str = BookmarkStart.b("丮䄰䌲头帶娸娺䤼嘾⹀ⵂ橄≆㥈㹊⽌摎⭐㩒╔", num);
                        break;
                }
                string str2 = (contentType == HttpContentType.InBrowser) ? BookmarkStart.b("䘮弰弲尴夶尸", num) : BookmarkStart.b("丮䔰䜲吴吶儸嘺堼儾㕀", num);
                response.AddHeader(BookmarkStart.b("氮帰崲䄴制圸伺ြ款㡀㍂⁄", num), str);
                response.AddHeader(BookmarkStart.b("氮帰崲䄴制圸伺ြ笾⡀あ㕄⡆㩈≊㥌♎㹐㵒", num), string.Format(BookmarkStart.b("吮İ串ิ儶倸场堼儾⁀⹂⁄穆㉈穊が瑎", num), str2, fileName));
                this.SaveToFile(response.OutputStream, fileFormat);
                response.End();
            }
        }

        public Image[] SaveToImages(ImageType type)
        {
            if (this.LicenseType == Spire.License.LicenseType.None)
            {
                return null;
            }
            this.method_178();
            Class962 class2 = new Class962();
            return class2.method_4(this, type);
        }

        public Image SaveToImages(int pageIndex, ImageType type)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                Image[] imageArray = new Class962().method_6(pageIndex, 1, this, type);
                if ((imageArray != null) && (imageArray.Length > pageIndex))
                {
                    return imageArray[pageIndex];
                }
            }
            return null;
        }

        public Stream SaveToImages(int pageIndex, ImageFormat imageFormat)
        {
            if (this.LicenseType == Spire.License.LicenseType.None)
            {
                return null;
            }
            this.method_178();
            Class962 class2 = new Class962();
            return class2.method_7(pageIndex, this, imageFormat);
        }

        public Image[] SaveToImages(int pageIndex, int pageCount, ImageType type)
        {
            if (this.LicenseType == Spire.License.LicenseType.None)
            {
                return null;
            }
            this.method_178();
            Image[] imageArray = new Class962().method_6(pageIndex, pageCount, this, type);
            List<Image> list = new List<Image>();
            for (int i = 0; i < imageArray.Length; i++)
            {
                if (imageArray[i] != null)
                {
                    list.Add(imageArray[i]);
                }
                if ((pageCount > 0) && (list.Count >= pageCount))
                {
                    break;
                }
            }
            return list.ToArray();
        }

        public void SaveToStream(Stream stream, FileFormat fileFormat)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                this.SaveToFile(stream, fileFormat);
            }
        }

        public void SaveToStream(Stream stream, ToPdfParameterList paramList)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                this.method_106(stream, paramList);
            }
        }

        public Queue<byte[]> SaveToSVG()
        {
            if (this.LicenseType == Spire.License.LicenseType.None)
            {
                return new Queue<byte[]>();
            }
            this.method_178();
            using (Class535 class2 = new Class535())
            {
                ToPdfParameterList list = new ToPdfParameterList {
                    UsePSCoversion = true
                };
                return class2.method_2(this, list);
            }
        }

        public void SaveToSVG(string fileName)
        {
            int num = 2;
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (Class535 class2 = new Class535())
                {
                    ToPdfParameterList list = new ToPdfParameterList {
                        UsePSCoversion = true
                    };
                    Queue<byte[]> queue = class2.method_2(this, list);
                    string directoryName = Path.GetDirectoryName(fileName);
                    if (!string.IsNullOrEmpty(directoryName))
                    {
                        directoryName = directoryName + BookmarkStart.b("琧", num);
                    }
                    string extension = Path.GetExtension(fileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string path = fileName;
                    int num2 = 0;
                    while (queue.Count > 0)
                    {
                        num2++;
                        if (num2 >= 2)
                        {
                            path = directoryName + fileNameWithoutExtension + num2.ToString() + extension;
                        }
                        File.WriteAllBytes(path, queue.Dequeue());
                    }
                }
            }
        }

        public void SaveToTxt(string fileName, Encoding encoding)
        {
            if (this.LicenseType != Spire.License.LicenseType.None)
            {
                this.method_178();
                using (StreamWriter writer = new StreamWriter(fileName, false, encoding))
                {
                    new Class775().method_2(writer, this);
                }
            }
        }

        private static void smethod_0(object sender, ValidationEventArgs e)
        {
            int num = 10;
            if (e.Severity != XmlSeverityType.Warning)
            {
                throw new Exception10(BookmarkStart.b("㤯搱唳娵儷帹崻䨽⤿ⵁ⩃晅ⵇ㡉㹋⅍≏桑瑓", num) + e.Message);
            }
        }

        XmlSchema IXmlSerializable.GetSchema()
        {
            return this.GetSchema();
        }

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            this.method_192(reader);
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            this.method_191(writer);
        }

        public void UpdateTableOfContents()
        {
            if (this.HasTOC)
            {
                this.TOC.method_51();
                this.method_136();
            }
        }

        public void UpdateWordCount()
        {
            this.UpdateWordCount(new char[] { ' ' });
        }

        public void UpdateWordCount(char[] splitchar)
        {
            this.UpdateWordCount(splitchar, true);
        }

        public void UpdateWordCount(char[] splitchar, bool includeTbFnEn)
        {
            this.int_6 = 0;
            this.int_5 = 0;
            this.int_4 = 0;
            this.int_3 = 0;
            this.method_128(splitchar, includeTbFnEn);
            if (includeTbFnEn)
            {
                this.method_129(splitchar, includeTbFnEn);
            }
            this.BuiltinDocumentProperties.ParagraphCount = this.int_3;
            this.BuiltinDocumentProperties.WordCount = this.int_4;
            this.BuiltinDocumentProperties.CharCount = this.int_5;
            this.BuiltinDocumentProperties.CharCountWithSpace = this.int_6;
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 12;
            base.WriteXmlAttributes(writer);
            if (this.string_11 != null)
            {
                writer.WriteValue(BookmarkStart.b("愱䀳圵嘷帹崻䰽␿́㝃╅ⅇ⍉", num), this.string_11);
            }
            if (this.string_12 != null)
            {
                writer.WriteValue(BookmarkStart.b("愱䀳圵嘷帹崻䰽␿с╃㑅േ⭉㽋㩍", num), this.string_12);
            }
            if (this.string_13 != null)
            {
                writer.WriteValue(BookmarkStart.b("愱䀳圵嘷帹崻䰽␿ు⭃⡅็⭉㹋୍ㅏ⅑⁓", num), this.string_13);
            }
            if (this.watermarkBase_0.Type != WatermarkType.NoWatermark)
            {
                writer.WriteValue(BookmarkStart.b("攱唳䈵崷䠹儻弽㈿⥁၃㽅㡇⽉", num), this.watermarkBase_0.Type);
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 0x13;
            base.WriteXmlContent(writer);
            if (this.MacrosData != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("吸娺帼䴾⹀あ", num), this.MacrosData);
            }
            if (this.MacroCommands != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("吸娺帼䴾⹀あ桄⑆♈♊⁌⹎㽐㝒♔", num), this.MacroCommands);
            }
            if (this.ObjectPool != null)
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("嘸夺圼娾≀㝂桄㝆♈⑊⅌", num), this.ObjectPool);
            }
            if (((this.class1011_0 != null) && (this.GrammarSpellingData.method_2() != null)) && (this.GrammarSpellingData.method_0() != null))
            {
                writer.WriteChildBinaryElement(BookmarkStart.b("常䤺尼刾ⱀ≂㝄橆ⵈ⩊㥌⹎", num), this.GrammarSpellingData.method_2());
                writer.WriteChildBinaryElement(BookmarkStart.b("䨸䬺堼匾ⵀ⩂⭄⁆摈⽊ⱌ㭎ぐ", num), this.GrammarSpellingData.method_0());
            }
        }

        internal ArrayList AllocatedCommands
        {
            get
            {
                if (this.arrayList_0 == null)
                {
                    this.arrayList_0 = new ArrayList();
                }
                return this.arrayList_0;
            }
            set
            {
                this.arrayList_0 = value;
            }
        }

        internal byte[] AssociatedStrings
        {
            get
            {
                return this.byte_7;
            }
            set
            {
                this.byte_7 = value;
            }
        }

        internal byte[] AttachedToolbars
        {
            get
            {
                return this.byte_9;
            }
            set
            {
                this.byte_9 = value;
            }
        }

        internal StringCollection AuthorsTable
        {
            get
            {
                return this.stringCollection_0;
            }
            set
            {
                this.stringCollection_0 = value;
            }
        }

        public Spire.Doc.Background Background
        {
            get
            {
                return this.background_0;
            }
            internal set
            {
                this.background_0 = value;
                this.background_0.method_0(this);
            }
        }

        internal ShapeObject BackgroundShape
        {
            get
            {
                return this.shapeObject_0;
            }
            set
            {
                int num = 7;
                if (value != null)
                {
                    if (value.Document != this)
                    {
                        throw new ArgumentException(BookmarkStart.b("礬䜮吰ጲ䘴弶堸䬺堼Ἶ㙀≂㙄杆⩈㥊⡌⹎═㙒ㅔ睖㽘⥚㉜㉞䅠ɢ䕤ͦh൪୬੮Ͱᙲ᭴Ͷ奸ὺቼ᱾ﶈꖊ", num));
                    }
                    if (value.ParentParagraph != null)
                    {
                        throw new ArgumentException(BookmarkStart.b("礬䜮吰ጲ䘴弶堸䬺堼Ἶ⡀あ敄♆楈⡊╌♎㵐㝒畔㡖㽘筚㱜ㅞ๠ᝢ൤ɦ᭨䭪ͬnᕰᙲ孴", num));
                    }
                    if (value.ShapeType != ShapeType.Rectangle)
                    {
                        throw new ArgumentException(BookmarkStart.b("戬䄮崰䨲ᔴ嘶ᤸ䤺堼尾㕀≂⭄⁆╈⹊浌㱎㥐㉒╔㉖祘㡚㱜ㅞ䅠Ţd䝦ᩨ๪ᥬ佮ၰr啴ᙶ奸ὺቼ᱾ﶈꮊﮞ辠", num));
                    }
                }
                this.shapeObject_0 = value;
            }
        }

        public BookmarkCollection Bookmarks
        {
            get
            {
                if (this.bookmarkCollection_0 == null)
                {
                    this.bookmarkCollection_0 = new BookmarkCollection(this);
                }
                return this.bookmarkCollection_0;
            }
        }

        public Spire.Doc.BuiltinDocumentProperties BuiltinDocumentProperties
        {
            get
            {
                if (this.builtinDocumentProperties_0 == null)
                {
                    this.builtinDocumentProperties_0 = new Spire.Doc.BuiltinDocumentProperties();
                }
                return this.builtinDocumentProperties_0;
            }
            internal set
            {
                this.builtinDocumentProperties_0 = value;
            }
        }

        internal Hashtable CanvasCache
        {
            get
            {
                if (this.hashtable_0 == null)
                {
                    this.hashtable_0 = new Hashtable();
                }
                return this.hashtable_0;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.m_sections;
            }
        }

        internal Stack<Field> ClonedFields
        {
            get
            {
                if (this.stack_1 == null)
                {
                    this.stack_1 = new Stack<Field>();
                }
                return this.stack_1;
            }
        }

        internal Dictionary<string, string> ColorScheme
        {
            get
            {
                if (this.dictionary_2 == null)
                {
                    this.dictionary_2 = new Dictionary<string, string>();
                }
                return this.dictionary_2;
            }
            set
            {
                this.dictionary_2 = value;
            }
        }

        public CommentsCollection Comments
        {
            get
            {
                if (this.commentsCollection_0 == null)
                {
                    this.commentsCollection_0 = new CommentsCollection(this);
                }
                return this.commentsCollection_0;
            }
        }

        internal byte CompatibilityMode
        {
            get
            {
                return this.Settings.method_3();
            }
        }

        internal MemoryStream CompObj
        {
            get
            {
                return this.memoryStream_1;
            }
            set
            {
                this.memoryStream_1 = value;
            }
        }

        internal Section CurClonedSection
        {
            get
            {
                return this.section_0;
            }
            set
            {
                this.section_0 = value;
            }
        }

        public Spire.Doc.CustomDocumentProperties CustomDocumentProperties
        {
            get
            {
                if (this.customDocumentProperties_0 == null)
                {
                    this.customDocumentProperties_0 = new Spire.Doc.CustomDocumentProperties();
                }
                return this.customDocumentProperties_0;
            }
            internal set
            {
                this.customDocumentProperties_0 = value;
            }
        }

        internal Class1128 CustomUIPartContainer
        {
            get
            {
                return this.class1128_0;
            }
            set
            {
                this.class1128_0 = value;
            }
        }

        internal Class1128 CustomXMLContainer
        {
            get
            {
                return this.class1128_1;
            }
            set
            {
                this.class1128_1 = value;
            }
        }

        internal CustomXmlPartCollection CustomXmlParts
        {
            get
            {
                if (this.customXmlPartCollection_0 == null)
                {
                    this.customXmlPartCollection_0 = new CustomXmlPartCollection(this);
                }
                return this.customXmlPartCollection_0;
            }
            set
            {
                int num = 6;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("伫嬭䌯䘱嬳嬵怷圹倻渽ℿぁぃ㕅", num));
                }
                this.customXmlPartCollection_0 = value;
            }
        }

        internal Class515 DefaultFontNameTable
        {
            get
            {
                if (this.class515_0 == null)
                {
                    this.class515_0 = new Class515();
                }
                return this.class515_0;
            }
            set
            {
                this.class515_0 = value;
            }
        }

        internal CharacterFormat DefCharFormat
        {
            get
            {
                return this.characterFormat_0;
            }
            set
            {
                this.characterFormat_0 = value;
            }
        }

        internal ParagraphFormat DefParaFormat
        {
            get
            {
                return this.paragraphFormat_0;
            }
            set
            {
                this.paragraphFormat_0 = value;
            }
        }

        public FileFormat DetectedFormatType
        {
            get
            {
                return this.fileFormat_0;
            }
            internal set
            {
                this.fileFormat_0 = value;
            }
        }

        internal Spire.Doc.Fields.Shape.DigitalSignatures DigitalSignatures
        {
            get
            {
                return this.digitalSignatures_0;
            }
            set
            {
                this.digitalSignatures_0 = value;
            }
        }

        internal List<string> DocEvents
        {
            get
            {
                if (this.list_11 == null)
                {
                    this.list_11 = new List<string>();
                }
                return this.list_11;
            }
            set
            {
                this.list_11 = value;
            }
        }

        internal Class195 DocLayoter
        {
            get
            {
                return this.class195_0;
            }
            set
            {
                this.class195_0 = value;
            }
        }

        internal Dictionary<string, DocOleObject> DocOleObjects
        {
            get
            {
                if (this.dictionary_7 == null)
                {
                    this.dictionary_7 = new Dictionary<string, DocOleObject>();
                }
                return this.dictionary_7;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Document;
            }
        }

        internal Class865 DocxNameSpace
        {
            get
            {
                if (this.class865_0 == null)
                {
                    this.class865_0 = new Class865();
                }
                return this.class865_0;
            }
        }

        internal Class1129 DocxPackage
        {
            get
            {
                return this.class1129_0;
            }
            set
            {
                this.class1129_0 = value;
            }
        }

        internal List<XmlNode> DocxProps
        {
            get
            {
                if (this.list_3 == null)
                {
                    this.list_3 = new List<XmlNode>();
                }
                return this.list_3;
            }
        }

        internal List<Stream> DocxProps2010
        {
            get
            {
                if (this.list_1 == null)
                {
                    this.list_1 = new List<Stream>();
                }
                return this.list_1;
            }
        }

        internal List<Stream> DocxPropsCompat2010
        {
            get
            {
                if (this.list_2 == null)
                {
                    this.list_2 = new List<Stream>();
                }
                return this.list_2;
            }
        }

        internal byte[] DropdownStrings
        {
            get
            {
                return this.byte_8;
            }
            set
            {
                this.byte_8 = value;
            }
        }

        public bool EmbedFontsInFile
        {
            get
            {
                return this.bool_19;
            }
            set
            {
                this.bool_19 = value;
            }
        }

        public bool EmbedSystemFonts
        {
            get
            {
                return this.bool_20;
            }
            set
            {
                this.bool_20 = value;
            }
        }

        internal List<Stream> EndnoteNodes2010
        {
            get
            {
                if (this.list_7 == null)
                {
                    this.list_7 = new List<Stream>();
                }
                return this.list_7;
            }
        }

        public FootEndnoteOptions EndnoteOptions
        {
            get
            {
                if (this.footEndnoteOptions_0 == null)
                {
                    this.footEndnoteOptions_0 = new FootEndnoteOptions(this, false);
                }
                return this.footEndnoteOptions_0;
            }
        }

        public List<Footnote> Endnotes
        {
            get
            {
                if (this.list_5 == null)
                {
                    this.list_5 = new List<Footnote>();
                }
                return this.list_5;
            }
        }

        internal bool EnforceDocProt
        {
            get
            {
                return this.Settings.method_10();
            }
            set
            {
                this.Settings.method_11(value);
            }
        }

        public FieldCollection Fields
        {
            get
            {
                if (this.fieldCollection_0 == null)
                {
                    this.fieldCollection_0 = new FieldCollection(this);
                }
                return this.fieldCollection_0;
            }
        }

        internal string FileName
        {
            get
            {
                return this.string_15;
            }
        }

        internal Class52 FontInfoList
        {
            get
            {
                if (this.class52_0 == null)
                {
                    this.class52_0 = new Class52(this);
                }
                return this.class52_0;
            }
        }

        internal Dictionary<string, string> FontSubstitutionTable
        {
            get
            {
                if (this.dictionary_1 == null)
                {
                    this.dictionary_1 = new Dictionary<string, string>();
                }
                return this.dictionary_1;
            }
            set
            {
                this.dictionary_1 = value;
            }
        }

        internal List<Stream> FootnoteNodes2010
        {
            get
            {
                if (this.list_6 == null)
                {
                    this.list_6 = new List<Stream>();
                }
                return this.list_6;
            }
        }

        public FootEndnoteOptions FootnoteOptions
        {
            get
            {
                if (this.footEndnoteOptions_1 == null)
                {
                    this.footEndnoteOptions_1 = new FootEndnoteOptions(this, true);
                }
                return this.footEndnoteOptions_1;
            }
        }

        public List<Footnote> Footnotes
        {
            get
            {
                if (this.list_4 == null)
                {
                    this.list_4 = new List<Footnote>();
                }
                return this.list_4;
            }
        }

        internal Class478 FootnoteSeparators
        {
            get
            {
                if (this.class478_0 == null)
                {
                    this.class478_0 = new Class478();
                }
                return this.class478_0;
            }
        }

        internal Class14 Frame
        {
            get
            {
                return this.class14_0;
            }
            set
            {
                this.class14_0 = value;
            }
        }

        internal Class1128 GlossaryContainer
        {
            get
            {
                return this.class1128_2;
            }
            set
            {
                this.class1128_2 = value;
            }
        }

        internal Class1011 GrammarSpellingData
        {
            get
            {
                if (this.class1011_0 == null)
                {
                    this.class1011_0 = new Class1011();
                }
                return this.class1011_0;
            }
            set
            {
                this.class1011_0 = value;
            }
        }

        public bool HasChanges
        {
            get
            {
                return this.method_174();
            }
        }

        internal bool HasDocOleObject
        {
            get
            {
                return ((this.dictionary_7 != null) && (this.dictionary_7.Count > 0));
            }
        }

        internal bool HasDocxProps
        {
            get
            {
                return (this.list_3 != null);
            }
        }

        internal bool HasPicture
        {
            get
            {
                return this.bool_18;
            }
            set
            {
                this.bool_18 = value;
            }
        }

        internal bool HasTOC
        {
            get
            {
                return (this.tableOfContent_0 != null);
            }
        }

        public string HtmlBaseUrl
        {
            get
            {
                return this.string_16;
            }
            set
            {
                this.string_16 = value;
            }
        }

        public bool HTMLCustomComment
        {
            get
            {
                return this.bool_26;
            }
            set
            {
                this.bool_26 = value;
            }
        }

        public Spire.Doc.HtmlExportOptions HtmlExportOptions
        {
            get
            {
                if (this.htmlExportOptions_0 == null)
                {
                    this.htmlExportOptions_0 = new Spire.Doc.HtmlExportOptions();
                }
                return this.htmlExportOptions_0;
            }
        }

        public List<char> HTMLIdentifierPunctuations
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<char>();
                    this.list_0.Add('!');
                    this.list_0.Add('?');
                    this.list_0.Add('.');
                }
                return this.list_0;
            }
            set
            {
                this.list_0 = value;
            }
        }

        public bool HTMLSentenceIdentifier
        {
            get
            {
                return this.bool_25;
            }
            set
            {
                this.bool_25 = value;
            }
        }

        public bool HTMLTrackChanges
        {
            get
            {
                return this.bool_24;
            }
            set
            {
                this.bool_24 = value;
            }
        }

        internal Class294 Images
        {
            get
            {
                if (this.class294_0 == null)
                {
                    this.class294_0 = new Class294(this);
                }
                return this.class294_0;
            }
        }

        internal ImportOptions ImportOption
        {
            get
            {
                return this.importOptions_0;
            }
            set
            {
                this.importOptions_0 = value;
            }
        }

        internal bool ImportStyles
        {
            get
            {
                return this.bool_9;
            }
            set
            {
                this.bool_9 = value;
            }
        }

        internal Spire.License.InternalLicense InternalLicense
        {
            [CompilerGenerated]
            get
            {
                return this.internalLicense_0;
            }
            [CompilerGenerated]
            set
            {
                this.internalLicense_0 = value;
            }
        }

        internal static bool IsCloneParagraphCheckFormat
        {
            [CompilerGenerated]
            get
            {
                return bool_27;
            }
            [CompilerGenerated]
            set
            {
                bool_27 = value;
            }
        }

        internal bool IsClosing
        {
            get
            {
                return this.bool_17;
            }
        }

        public bool IsContainMacro
        {
            get
            {
                if (((this.VbaProject == null) || ((this.VbaData.Count <= 0) && (this.DocEvents.Count <= 0))) && ((this.VbaMacroNames.Count <= 0) && (this.VbaMacros.Count <= 0)))
                {
                    return (this.AllocatedCommands.Count > 0);
                }
                return true;
            }
        }

        internal bool IsEncrypted
        {
            get
            {
                return this.bool_14;
            }
            set
            {
                this.bool_14 = value;
            }
        }

        internal bool IsMacroEnabled
        {
            get
            {
                if ((((this.SaveFormatType != FileFormat.Docm) && (this.SaveFormatType != FileFormat.Docm2010)) && ((this.SaveFormatType != FileFormat.Docm2013) && (this.SaveFormatType != FileFormat.Dotm))) && (this.SaveFormatType != FileFormat.Dotm2010))
                {
                    return (this.SaveFormatType == FileFormat.Dotm2013);
                }
                return true;
            }
        }

        internal bool IsSaveTemplate
        {
            get
            {
                if ((((this.SaveFormatType != FileFormat.Dot) && (this.SaveFormatType != FileFormat.Dotx)) && ((this.SaveFormatType != FileFormat.Dotx2010) && (this.SaveFormatType != FileFormat.Dotx2013))) && (((this.SaveFormatType != FileFormat.Dotm) && (this.SaveFormatType != FileFormat.Dotm2010)) && (this.SaveFormatType != FileFormat.Dotm2013)))
                {
                    return false;
                }
                return true;
            }
        }

        public bool IsUpdateFields
        {
            get
            {
                return this.bool_15;
            }
            set
            {
                this.bool_15 = value;
            }
        }

        public int JPEGQuality
        {
            get
            {
                return this.int_12;
            }
            set
            {
                this.int_12 = value;
            }
        }

        internal ArrayList KeyMaps
        {
            get
            {
                return this.arrayList_1;
            }
            set
            {
                this.arrayList_1 = value;
            }
        }

        public Paragraph LastParagraph
        {
            get
            {
                Section lastSection = this.LastSection;
                if (lastSection != null)
                {
                    lastSection.Body.Paragraphs.method_12();
                    int count = lastSection.Body.Paragraphs.Count;
                    DocumentObject lastChild = lastSection.Body.LastChild;
                    if (lastChild is Paragraph)
                    {
                        return (lastChild as Paragraph);
                    }
                    if (lastChild is Table)
                    {
                        return (lastChild as Table).LastParagraph;
                    }
                }
                return null;
            }
        }

        public Section LastSection
        {
            get
            {
                int count = this.Sections.Count;
                if (count > 0)
                {
                    return this.Sections[count - 1];
                }
                return null;
            }
        }

        internal XmlNode LatentStyles
        {
            get
            {
                return this.xmlNode_0;
            }
            set
            {
                this.xmlNode_0 = value;
            }
        }

        internal MemoryStream LatentStyles2010
        {
            get
            {
                return this.memoryStream_0;
            }
            set
            {
                this.memoryStream_0 = value;
            }
        }

        internal Class516 LayoutVariables
        {
            get
            {
                if (this.class516_0 == null)
                {
                    this.class516_0 = new Class516(this);
                }
                return this.class516_0;
            }
        }

        internal uint LegacyHash
        {
            get
            {
                return this.Settings.uint_0;
            }
            set
            {
                this.Settings.uint_0 = value;
            }
        }

        private Dictionary<string, int> LfoListLevel
        {
            get
            {
                if (this.dictionary_6 == null)
                {
                    this.dictionary_6 = new Dictionary<string, int>();
                }
                return this.dictionary_6;
            }
        }

        internal Spire.License.LicenseType LicenseType
        {
            get
            {
                if ((this.licenseInfo_0 != null) && (this.licenseInfo_0.Type != Spire.License.LicenseType.None))
                {
                    return this.licenseInfo_0.Type;
                }
                return Spire.License.LicenseType.Demo;
            }
        }

        private HybridDictionary ListNames
        {
            get
            {
                if (this.hybridDictionary_0 == null)
                {
                    this.hybridDictionary_0 = new HybridDictionary();
                }
                return this.hybridDictionary_0;
            }
        }

        internal Class48 ListOverrides
        {
            get
            {
                return this.class48_0;
            }
        }

        private Dictionary<string, Dictionary<int, int>> Lists
        {
            get
            {
                if (this.dictionary_4 == null)
                {
                    this.dictionary_4 = new Dictionary<string, Dictionary<int, int>>();
                }
                return this.dictionary_4;
            }
        }

        private Dictionary<string, bool> ListsIsReset
        {
            get
            {
                if (this.dictionary_3 == null)
                {
                    this.dictionary_3 = new Dictionary<string, bool>();
                }
                return this.dictionary_3;
            }
        }

        public ListStyleCollection ListStyles
        {
            get
            {
                if (this.m_listStyles.Count == 0)
                {
                    this.method_166();
                }
                return this.m_listStyles;
            }
        }

        internal byte[] MacroCommands
        {
            get
            {
                return this.byte_6;
            }
            set
            {
                this.byte_6 = value;
            }
        }

        internal byte[] MacrosData
        {
            get
            {
                return this.byte_3;
            }
            set
            {
                this.byte_3 = value;
            }
        }

        public Spire.Doc.Reporting.MailMerge MailMerge
        {
            get
            {
                return this.mailMerge_0;
            }
        }

        internal bool NoTabForInd
        {
            get
            {
                if (((this.DetectedFormatType != FileFormat.Doc) || !this.Settings.method_5().method_3()) && (((((this.DetectedFormatType != FileFormat.Docx) && (this.DetectedFormatType != FileFormat.Docm)) && ((this.DetectedFormatType != FileFormat.Docx2010) && (this.DetectedFormatType != FileFormat.Docm2010))) && ((this.DetectedFormatType != FileFormat.Docx2013) && (this.DetectedFormatType != FileFormat.Docm2013))) || ((this.Settings == null) || !this.Settings.method_5().method_0(CompatibilityOptions.NoTabForInd))))
                {
                    return false;
                }
                return true;
            }
        }

        internal byte[] ObjectPool
        {
            get
            {
                return this.byte_2;
            }
            set
            {
                this.byte_2 = value;
            }
        }

        internal List<string> ObjPoolContainers
        {
            get
            {
                if (this.list_8 == null)
                {
                    this.list_8 = new List<string>();
                }
                return this.list_8;
            }
        }

        internal DocumentOperationType OperationType
        {
            get
            {
                return this.documentOperationType_0;
            }
            set
            {
                this.documentOperationType_0 = value;
            }
        }

        internal Class458 PackageCustomParts
        {
            get
            {
                if (this.class458_0 == null)
                {
                    this.class458_0 = new Class458();
                }
                return this.class458_0;
            }
            set
            {
                int num = 5;
                if (value == null)
                {
                    throw new ArgumentNullException(BookmarkStart.b("嬪䰬䰮娰刲刴制稸为丼䬾⹀⹂ᕄ♆㭈㽊㹌", num));
                }
                this.class458_0 = value;
            }
        }

        public int PageCount
        {
            get
            {
                if (this.int_8 <= 0)
                {
                    this.method_130();
                }
                return this.int_8;
            }
        }

        internal string Password
        {
            set
            {
                this.string_10 = string.IsNullOrEmpty(value) ? string.Empty : value;
            }
        }

        internal PermissionCollection Permissions
        {
            get
            {
                if (this.permissionCollection_0 == null)
                {
                    this.permissionCollection_0 = new PermissionCollection(this);
                }
                return this.permissionCollection_0;
            }
        }

        private Dictionary<string, int> PreviousListLevel
        {
            get
            {
                if (this.dictionary_5 == null)
                {
                    this.dictionary_5 = new Dictionary<string, int>();
                }
                return this.dictionary_5;
            }
        }

        [Browsable(false)]
        public System.Windows.Forms.PrintDialog PrintDialog
        {
            set
            {
                this.printDialog_0 = value;
            }
        }

        [Browsable(false)]
        public System.Drawing.Printing.PrintDocument PrintDocument
        {
            get
            {
                if (this.printDialog_0 == null)
                {
                    this.printDialog_0 = new System.Windows.Forms.PrintDialog();
                    this.printDialog_0.PrinterSettings.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                }
                if (this.printDocument_0 == null)
                {
                    this.printDocument_0 = new System.Drawing.Printing.PrintDocument();
                    this.printDocument_0.PrinterSettings = this.printDialog_0.PrinterSettings;
                    this.printDocument_0.BeginPrint += new PrintEventHandler(this.OnBeginPrint);
                    this.printDocument_0.QueryPageSettings += new QueryPageSettingsEventHandler(this.OnQueryPageSettings);
                    this.printDocument_0.EndPrint += new PrintEventHandler(this.OnEndPrint);
                    this.printDocument_0.PrintPage += new PrintPageEventHandler(this.OnPrintPage);
                }
                return this.printDocument_0;
            }
        }

        public List<PrivateFontPath> PrivateFontList
        {
            get
            {
                if (this.list_12 == null)
                {
                    this.list_12 = new List<PrivateFontPath>();
                }
                return this.list_12;
            }
        }

        public DocumentProperties Properties
        {
            get
            {
                if (this.documentProperties_0 == null)
                {
                    this.documentProperties_0 = new DocumentProperties(this);
                }
                return this.documentProperties_0;
            }
        }

        public Spire.Doc.ProtectionType ProtectionType
        {
            get
            {
                return this.Settings.method_8();
            }
            set
            {
                this.Settings.method_9(value);
            }
        }

        public bool QuiteMode
        {
            get
            {
                return !this.bool_8;
            }
            set
            {
                this.bool_8 = !value;
            }
        }

        public bool ReplaceFirst
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                this.bool_10 = value;
            }
        }

        internal Class481 RouteSlip
        {
            get
            {
                return this.class481_0;
            }
            set
            {
                this.class481_0 = value;
            }
        }

        internal FileFormat SaveFormatType
        {
            get
            {
                return this.fileFormat_1;
            }
            set
            {
                this.fileFormat_1 = value;
            }
        }

        internal bool SaveSubsetFonts
        {
            get
            {
                return this.bool_21;
            }
            set
            {
                this.bool_21 = value;
            }
        }

        public SectionCollection Sections
        {
            get
            {
                return this.m_sections;
            }
        }

        internal Class907 Settings
        {
            get
            {
                if (this.class907_0 == null)
                {
                    this.class907_0 = new Class907(this);
                }
                return this.class907_0;
            }
        }

        internal string StandardAsciiFont
        {
            get
            {
                return this.string_11;
            }
            set
            {
                this.string_11 = value;
            }
        }

        internal string StandardBidiFont
        {
            get
            {
                return this.string_14;
            }
            set
            {
                this.string_14 = value;
            }
        }

        internal string StandardFarEastFont
        {
            get
            {
                return this.string_12;
            }
            set
            {
                this.string_12 = value;
            }
        }

        internal string StandardNonFarEastFont
        {
            get
            {
                return this.string_13;
            }
            set
            {
                this.string_13 = value;
            }
        }

        internal Dictionary<string, string> StyleNameIds
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.dictionary_0 = new Dictionary<string, string>();
                }
                return this.dictionary_0;
            }
        }

        public StyleCollection Styles
        {
            get
            {
                return this.m_styles;
            }
        }

        public TextBoxCollection TextBoxes
        {
            get
            {
                return this.textBoxCollection_0;
            }
            set
            {
                this.textBoxCollection_0 = value;
            }
        }

        internal Class514 ThemeFontLanguage
        {
            get
            {
                return this.class514_0;
            }
            set
            {
                this.class514_0 = value;
            }
        }

        internal Class324 Themes
        {
            get
            {
                return this.class324_0;
            }
            set
            {
                this.class324_0 = value;
            }
        }

        public TableOfContent TOC
        {
            get
            {
                if (this.HasTOC)
                {
                    return this.tableOfContent_0;
                }
                return null;
            }
            set
            {
                this.tableOfContent_0 = value;
            }
        }

        public bool TrackChanges
        {
            get
            {
                return this.Settings.bool_21;
            }
            set
            {
                this.Settings.bool_21 = value;
            }
        }

        internal List<Font> UsedFontNames
        {
            get
            {
                if (this.list_9 == null)
                {
                    this.list_9 = new List<Font>();
                }
                return this.list_9;
            }
            set
            {
                this.list_9 = value;
            }
        }

        internal bool UseHangingIndentAsListTab
        {
            get
            {
                if (((this.DetectedFormatType != FileFormat.Doc) || !this.Settings.method_5().method_105()) && (((((this.DetectedFormatType != FileFormat.Docx) && (this.DetectedFormatType != FileFormat.Docm)) && ((this.DetectedFormatType != FileFormat.Docx2010) && (this.DetectedFormatType != FileFormat.Docm2010))) && ((this.DetectedFormatType != FileFormat.Docx2013) && (this.DetectedFormatType != FileFormat.Docm2013))) || ((this.Settings == null) || !this.Settings.method_5().method_0(CompatibilityOptions.DontUseIndentAsNumberingTabStop))))
                {
                    return false;
                }
                return true;
            }
        }

        public VariableCollection Variables
        {
            get
            {
                if (this.variableCollection_0 == null)
                {
                    this.variableCollection_0 = new VariableCollection();
                }
                return this.variableCollection_0;
            }
        }

        internal List<Class512> VbaData
        {
            get
            {
                if (this.list_10 == null)
                {
                    this.list_10 = new List<Class512>();
                }
                return this.list_10;
            }
            set
            {
                this.list_10 = value;
            }
        }

        internal Spire.Doc.Documents.Converters.VbaDocumentEvents VbaDocumentEvents
        {
            get
            {
                return this.vbaDocumentEvents_0;
            }
            set
            {
                this.vbaDocumentEvents_0 = value;
            }
        }

        internal ArrayList VbaMacroNames
        {
            get
            {
                if (this.arrayList_2 == null)
                {
                    this.arrayList_2 = new ArrayList();
                }
                return this.arrayList_2;
            }
            set
            {
                this.arrayList_2 = value;
            }
        }

        internal Class1089 VbaMacros
        {
            get
            {
                if (this.class1089_0 == null)
                {
                    this.class1089_0 = new Class1089();
                }
                return this.class1089_0;
            }
            set
            {
                this.class1089_0 = value;
            }
        }

        internal Stream VbaProject
        {
            get
            {
                return this.stream_0;
            }
            set
            {
                this.stream_0 = value;
            }
        }

        internal byte[] VbaSignature
        {
            get
            {
                return this.byte_10;
            }
            set
            {
                this.byte_10 = value;
            }
        }

        public Spire.Doc.Formatting.ViewSetup ViewSetup
        {
            get
            {
                return this.viewSetup_0;
            }
        }

        public WatermarkBase Watermark
        {
            get
            {
                if (this.Sections.Count > 0)
                {
                    return this.Sections[0].HeadersFooters.OddHeader.Watermark;
                }
                return this.watermarkBase_0;
            }
            set
            {
                this.method_188(value);
            }
        }

        internal Class50 WebSettings
        {
            get
            {
                if (this.class50_0 == null)
                {
                    this.class50_0 = new Class50(this);
                }
                return this.class50_0;
            }
            set
            {
                this.class50_0 = value;
            }
        }

        protected override IDocumentObjectCollection WidgetCollection
        {
            get
            {
                return this.Sections;
            }
        }

        internal ushort WordVersion
        {
            get
            {
                return this.ushort_0;
            }
            set
            {
                this.ushort_0 = value;
            }
        }

        internal bool WriteProtected
        {
            get
            {
                return this.bool_16;
            }
            set
            {
                this.bool_16 = value;
            }
        }

        public XHTMLValidationType XHTMLValidateOption
        {
            get
            {
                return this.xhtmlvalidationType_0;
            }
            set
            {
                this.xhtmlvalidationType_0 = value;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct0 : IDisposable
        {
            public double double_0;
            public double double_1;
            public Image image_0;
            public Class500 class500_0;
            void IDisposable.Dispose()
            {
                if (this.image_0 != null)
                {
                    this.image_0.Dispose();
                    this.image_0 = null;
                }
            }
        }
    }
}

