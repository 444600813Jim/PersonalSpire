using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Schema;

internal class Class747 : IDisposable, Interface10
{
    private BodyRegionCollection bodyRegionCollection_0;
    private readonly bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private Class2 class2_0;
    private Class298 class298_0;
    private Class748 class748_0;
    private Class751 class751_0;
    private Class751 class751_1;
    private Class751 class751_2;
    private Class751 class751_3;
    private Dictionary<int, XmlNode> dictionary_0;
    private Dictionary<string, int> dictionary_1;
    private Dictionary<string, string> dictionary_2;
    private const float float_0 = 35f;
    private const float float_1 = 3f;
    private const float float_2 = 4.5f;
    private const float float_3 = 0.75f;
    private const float float_4 = 36f;
    private const float float_5 = 3f;
    private const float float_6 = 36f;
    internal float float_7;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    public IParagraphStyle iparagraphStyle_0;
    private List<Dictionary<string, string>> list_0;
    private List<string> list_1;
    private ListStyle listStyle_0;
    private Paragraph paragraph_0;
    private readonly Regex regex_0;
    private readonly Regex regex_1;
    private readonly Regex regex_2;
    private readonly Regex regex_3;
    private readonly Regex regex_4;
    private readonly Regex regex_5;
    private readonly Regex regex_6;
    private ShapeObject shapeObject_0;
    private Stack<Class751> stack_0;
    private Stack<BodyRegionCollection> stack_1;
    private Stack<RowFormat> stack_10;
    private Stack<Color> stack_11;
    private Stack<bool> stack_12;
    private Stack<bool> stack_13;
    private Stack<Class51> stack_14;
    private Stack<bool> stack_15;
    private Stack<bool> stack_16;
    private Stack<Field> stack_17;
    private Stack<Class752> stack_18;
    private Stack<Class749> stack_19;
    private Stack<Table> stack_2;
    private Stack<List<Dictionary<string, string>>> stack_20;
    private Stack<TableRow> stack_21;
    private Stack<Table> stack_22;
    private Stack<TableCell> stack_23;
    private Stack<XmlNode> stack_24;
    private Stack<ListStyle> stack_3;
    private Stack<bool> stack_4;
    private Stack<Class751> stack_5;
    private Stack<Class751> stack_6;
    private Stack<bool> stack_7;
    private Stack<Class751> stack_8;
    private Stack<bool> stack_9;
    private const string string_0 = "Spire.Doc.Resources.xhtml1-strict.xsd";
    private const string string_1 = "Spire.Doc.Resources.xhtml1-transitional.xsd";
    private const string string_2 = " ";
    private const string string_3 = "Spire.Doc.Resources.picture_notfound.jpg";
    private string string_4;
    private Table table_0;
    private Uri uri_0;
    private VerticalAlignment verticalAlignment_0;
    internal XmlDocument xmlDocument_0;

    public Class747() : this(false)
    {
    }

    public Class747(bool A_0)
    {
        this.regex_0 = new Regex(BookmarkStart.b("氯䄱ἳ", 10));
        this.regex_1 = new Regex(BookmarkStart.b("యᨱ嘳䐵ᄷй䀻Ƚ栿流♃㑅慇瑉", 10), RegexOptions.IgnoreCase);
        this.regex_2 = new Regex(BookmarkStart.b("港ᨱ栳刵ጷጹᐻ戽㌿桁ὃ㙅ᡇᝉᝋ㙍ࡏད絓楕籗", 10));
        this.regex_3 = new Regex(BookmarkStart.b("港嘱唳䈵夷9唻匽ℿ╁⅃楅恇ᅉቋ才歏ད罓罕灗慙㽛㙝şၡᝣͥᱧ坩㝫ね屯䥱⥳嵵具䕹呻䕽뺇뺉ꖋ농뢏즑쪓몕얗놙떛ꆝ貟", 10), RegexOptions.IgnoreCase);
        this.regex_4 = new Regex(BookmarkStart.b("ᠯัᬳਵ᜷ጹ", 10));
        this.regex_5 = new Regex(BookmarkStart.b("ᠯัᬳḵ挷搹ᐻ=㰿繁浃ᭅ慇慉灋慍祏", 10));
        this.regex_6 = new Regex(BookmarkStart.b("ᠯั࠳ἵ", 10));
        this.stack_0 = new Stack<Class751>();
        this.stack_1 = new Stack<BodyRegionCollection>();
        this.stack_2 = new Stack<Table>();
        this.int_0 = -1;
        this.class751_0 = new Class751();
        this.verticalAlignment_0 = VerticalAlignment.Middle;
        this.int_1 = -1;
        this.stack_4 = new Stack<bool>();
        this.stack_5 = new Stack<Class751>();
        this.stack_6 = new Stack<Class751>();
        this.stack_7 = new Stack<bool>();
        this.stack_8 = new Stack<Class751>();
        this.stack_9 = new Stack<bool>();
        this.stack_10 = new Stack<RowFormat>();
        this.class298_0 = new Class298();
        this.stack_11 = new Stack<Color>();
        this.stack_12 = new Stack<bool>();
        this.stack_13 = new Stack<bool>();
        this.stack_14 = new Stack<Class51>();
        this.stack_15 = new Stack<bool>();
        this.stack_16 = new Stack<bool>();
        this.stack_17 = new Stack<Field>();
        this.stack_18 = new Stack<Class752>();
        this.stack_19 = new Stack<Class749>();
        this.stack_20 = new Stack<List<Dictionary<string, string>>>();
        this.stack_21 = new Stack<TableRow>();
        this.stack_22 = new Stack<Table>();
        this.stack_23 = new Stack<TableCell>();
        this.stack_24 = new Stack<XmlNode>();
        this.dictionary_0 = new Dictionary<int, XmlNode>();
        this.list_1 = new List<string>();
        this.dictionary_1 = new Dictionary<string, int>();
        this.dictionary_2 = new Dictionary<string, string>();
        this.bool_0 = A_0;
    }

    public void imethod_0(IBody A_0, string A_1, int A_2, int A_3)
    {
        bool flag;
        int num = 15;
        this.method_152();
        this.string_4 = A_0.Document.HtmlBaseUrl;
        if (Uri.IsWellFormedUriString(this.string_4, UriKind.Absolute))
        {
            this.uri_0 = new Uri(this.string_4);
        }
        TextBodyPart part = new TextBodyPart(A_0.Document);
        this.bodyRegionCollection_0 = part.BodyItems;
        if (!this.bool_0)
        {
            this.bodyRegionCollection_0.Document.Settings.method_5().method_152();
        }
        this.paragraph_0 = null;
        this.method_17(A_1);
        this.class748_0 = new Class748();
        XmlNode documentElement = this.xmlDocument_0.DocumentElement;
        XmlNode node2 = this.xmlDocument_0.DocumentElement;
        List<XmlElement> list = new List<XmlElement>();
        if (documentElement.LocalName.ToLower() == BookmarkStart.b("崴䌶吸场", num))
        {
            using (IEnumerator enumerator = documentElement.ChildNodes.GetEnumerator())
            {
                XmlNode current;
                while (enumerator.MoveNext())
                {
                    current = (XmlNode) enumerator.Current;
                    if ((current.LocalName.ToLower() == BookmarkStart.b("崴制堸强", num)) && (current.NodeType == XmlNodeType.Element))
                    {
                        node2 = current;
                        foreach (XmlNode node4 in node2.ChildNodes)
                        {
                            string str2;
                            if ((node4.NodeType == XmlNodeType.Element) && ((str2 = node4.LocalName.ToLower()) != null))
                            {
                                if (str2 != BookmarkStart.b("圴嘶䨸帺", num))
                                {
                                    if (!(str2 == BookmarkStart.b("䘴䌶䀸场堼", num)))
                                    {
                                        if (str2 == BookmarkStart.b("头帶圸债", num))
                                        {
                                            XmlElement element = node4 as XmlElement;
                                            string attribute = element.GetAttribute(BookmarkStart.b("䜴制唸", num));
                                            string str = element.GetAttribute(BookmarkStart.b("崴䔶尸崺", num));
                                            if (((!string.IsNullOrEmpty(attribute) && ((attribute = attribute.Trim()).Length > 0)) && ((attribute.ToLower() == BookmarkStart.b("䘴䌶䀸场堼䰾⥀♂⁄㍆", num)) && !string.IsNullOrEmpty(str))) && ((str = str.Trim()).Length > 0))
                                            {
                                                list.Add(node4 as XmlElement);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        list.Add(node4 as XmlElement);
                                    }
                                }
                                else
                                {
                                    this.method_2(this.method_97(node4, BookmarkStart.b("崴䔶尸崺", num)));
                                    if ((this.uri_0 == null) && Uri.IsWellFormedUriString(this.method_1(), UriKind.Absolute))
                                    {
                                        this.uri_0 = new Uri(this.method_1());
                                    }
                                }
                            }
                        }
                    }
                    if (current.LocalName.ToLower() == BookmarkStart.b("圴堶崸䈺", num))
                    {
                        goto Label_02E7;
                    }
                }
                goto Label_0301;
            Label_02E7:
                documentElement = current;
            }
        }
    Label_0301:
        foreach (XmlElement element2 in list)
        {
            string str4 = element2.LocalName.ToLower();
            if (str4 != null)
            {
                if (!(str4 == BookmarkStart.b("䘴䌶䀸场堼", num)))
                {
                    if (str4 == BookmarkStart.b("头帶圸债", num))
                    {
                        this.class298_0.method_1(this.method_8(element2));
                    }
                }
                else
                {
                    this.class298_0.method_1(element2.InnerText);
                }
            }
        }
        if (flag = this.method_81(documentElement))
        {
            Class751 class2 = this.stack_0.Peek();
            this.class751_3 = class2.method_97();
            if (!class2.method_53().IsEmpty)
            {
                A_0.Document.Background.Type = BackgroundType.Color;
                if (class2.method_53().A == 0)
                {
                    A_0.Document.Background.Color = Color.FromArgb(class2.method_53().R, class2.method_53().G, class2.method_53().B);
                }
                else
                {
                    A_0.Document.Background.Color = class2.method_53();
                }
                class2.method_54(Color.Empty);
            }
            else if (class2.method_24() != null)
            {
                A_0.Document.Background.Type = BackgroundType.Picture;
                A_0.Document.Background.Picture = class2.method_24();
            }
            SizeF pageSize = A_0.Document.Sections[0].PageSetup.PageSize;
            if ((class2.method_26() != 0) && (class2.method_28() != 0))
            {
                if (class2.method_26() > class2.method_28())
                {
                    A_0.Document.Sections[0].PageSetup.Orientation = PageOrientation.Landscape;
                }
                A_0.Document.Sections[0].PageSetup.PageSize = new SizeF((float) class2.method_26(), (float) class2.method_28());
            }
            else if (class2.method_26() != 0)
            {
                A_0.Document.Sections[0].PageSetup.PageSize = new SizeF((float) class2.method_26(), pageSize.Height);
            }
            if (class2.method_12() > 0f)
            {
                A_0.Document.Sections[0].PageSetup.LinePitch = class2.method_12();
                A_0.Document.Sections[0].PageSetup.PitchType = class2.method_10();
            }
        }
        this.method_21(documentElement.ChildNodes);
        this.method_94(flag);
        part.PasteAt(A_0, A_2, A_3);
        if ((part.BodyItems.Count > 0) && (part.BodyItems[0].DocumentObjectType == DocumentObjectType.Paragraph))
        {
            Paragraph paragraph = part.BodyItems[0] as Paragraph;
            ParagraphFormat format = paragraph.Format;
            (A_0.ChildObjects[A_2] as Paragraph).Format.ImportContainer(format);
            if (!string.IsNullOrEmpty(paragraph.StyleName))
            {
                (A_0.ChildObjects[A_2] as Paragraph).ApplyStyle(paragraph.StyleName);
            }
        }
    }

    public void imethod_1(IBody A_0, string A_1, int A_2, int A_3, IParagraphStyle A_4, ListStyle A_5)
    {
        if (A_4 != null)
        {
            this.iparagraphStyle_0 = A_4;
        }
        if (A_5 != null)
        {
            this.listStyle_0 = A_5;
        }
        this.imethod_0(A_0, A_1, A_2, A_3);
        this.iparagraphStyle_0 = null;
        this.listStyle_0 = null;
    }

    public bool imethod_2(string A_0, XHTMLValidationType A_1)
    {
        string str;
        return this.imethod_3(A_0, A_1, out str);
    }

    public bool imethod_3(string A_0, XHTMLValidationType A_1, out string A_2)
    {
        bool flag;
        int num = 12;
        A_2 = string.Empty;
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        XmlSchema schema = null;
        A_0 = this.method_10(A_0);
        switch (A_1)
        {
            case XHTMLValidationType.Strict:
                schema = XmlSchema.Read(executingAssembly.GetManifestResourceStream(BookmarkStart.b("愱䐳張䨷弹ሻ稽⼿⅁橃ᑅⵇ㥉⍋㭍≏ㅑㅓ╕癗≙㑛⩝ൟ๡啣䭥᭧ṩṫݭ፯ٱ婳๵୷ṹ", num)), new ValidationEventHandler(this.method_103));
                break;

            case XHTMLValidationType.Transitional:
                schema = XmlSchema.Read(executingAssembly.GetManifestResourceStream(BookmarkStart.b("愱䐳張䨷弹ሻ稽⼿⅁橃ᑅⵇ㥉⍋㭍≏ㅑㅓ╕癗≙㑛⩝ൟ๡啣䭥ᱧᡩ൫mͯ᭱sή᝷ᑹᵻች깿嬨", num)), new ValidationEventHandler(this.method_103));
                break;

            case XHTMLValidationType.None:
                return true;
        }
        string str = A_0.ToLower();
        this.xmlDocument_0 = new XmlDocument();
        this.xmlDocument_0.PreserveWhitespace = true;
        string str2 = BookmarkStart.b("ั尳䈵唷嘹᰻䘽ⴿ⹁⩃㕅畇桉", num) + schema.TargetNamespace + BookmarkStart.b("ေਲ਼", num);
        if (str.StartsWith(BookmarkStart.b("ั尳䈵唷嘹", num)))
        {
            int index = str.IndexOf(BookmarkStart.b("ఱ", num));
            A_0 = str2 + A_0.Remove(0, index + 1);
        }
        else
        {
            A_0 = str2 + A_0 + BookmarkStart.b("ัᬳ帵䰷圹倻=", num);
        }
        A_0 = this.method_9(A_0);
        try
        {
            XmlValidatingReader reader = new XmlValidatingReader(A_0, XmlNodeType.Document, new XmlParserContext(null, null, null, XmlSpace.None));
            reader.Schemas.Add(schema);
            while (reader.Read())
            {
            }
            return true;
        }
        catch (Exception exception)
        {
            A_2 = exception.Message;
            flag = false;
        }
        return flag;
    }

    internal Class51 method_0()
    {
        if (this.stack_14.Count > 0)
        {
            return this.stack_14.Peek();
        }
        return null;
    }

    protected string method_1()
    {
        return this.string_4;
    }

    private string method_10(string A_0)
    {
        A_0 = this.method_11(A_0);
        A_0 = this.method_12(A_0);
        A_0 = this.method_13(A_0);
        A_0 = this.method_14(A_0);
        A_0 = this.method_15(A_0);
        A_0 = this.method_16(A_0);
        return A_0;
    }

    private HorizontalAlignment method_100(string A_0, HorizontalAlignment A_1)
    {
        int num = 11;
        A_0 = A_0.Trim().ToLower();
        string str = A_0;
        if (str == null)
        {
            return A_1;
        }
        if (str == BookmarkStart.b("到嘲嬴䌶尸䤺", num))
        {
            return HorizontalAlignment.Center;
        }
        if (str == BookmarkStart.b("嬰䘲䘴䌶倸崺䐼", num))
        {
            return HorizontalAlignment.Justify;
        }
        if (!(str == BookmarkStart.b("崰嘲匴䌶", num)))
        {
            if (str == BookmarkStart.b("䌰娲刴弶䴸", num))
            {
                return HorizontalAlignment.Right;
            }
            return A_1;
        }
        return HorizontalAlignment.Left;
    }

    private SubSuperScript method_101(string A_0)
    {
        int num = 12;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䄱䄳䘵崷䠹", num))
            {
                return SubSuperScript.SuperScript;
            }
            if (str == BookmarkStart.b("䄱䄳吵", num))
            {
                return SubSuperScript.SubScript;
            }
        }
        return SubSuperScript.None;
    }

    private float method_102(string A_0, string A_1)
    {
        A_0 = A_0.Substring(0, A_0.IndexOf(A_1));
        return float.Parse(A_0, CultureInfo.InvariantCulture);
    }

    private void method_103(object sender, ValidationEventArgs e)
    {
        throw new NotSupportedException(e.Message, e.Exception);
    }

    private void method_104(XmlNode A_0)
    {
        int num = 9;
        if (this.method_110(A_0))
        {
            this.method_105(A_0);
        }
        else
        {
            if (!string.IsNullOrEmpty(this.method_97(A_0, BookmarkStart.b("礮瀰缲怴父", num))))
            {
                this.method_6().Pop();
                ListStyle item = this.method_106(A_0);
                this.method_6().Push(item);
            }
            if (((this.method_7() != null) && !string.IsNullOrEmpty(this.method_7().Name)) && (this.paragraph_0.Document.ListStyles.FindByName(this.method_7().Name) != null))
            {
                this.paragraph_0.ListFormat.ApplyStyle(this.method_7().Name);
                this.paragraph_0.ListFormat.ListLevelNumber = this.int_0;
            }
            else
            {
                this.method_105(A_0);
            }
        }
    }

    private void method_105(XmlNode A_0)
    {
        this.int_0++;
        ListStyle item = this.method_106(A_0);
        this.paragraph_0.ListFormat.ApplyStyle(item.Name);
        this.paragraph_0.ListFormat.ListLevelNumber = this.int_0;
        this.paragraph_0.ListFormat.IsRestartNumbering = true;
        if (((this.paragraph_0.ListFormat.CurrentListLevel != null) && (this.paragraph_0.ListFormat.ListType == ListType.Numbered)) && (this.method_3() != null))
        {
            this.method_70(this.method_3(), this.paragraph_0.ListFormat.CurrentListLevel.CharacterFormat);
        }
        this.method_6().Push(item);
    }

    private ListStyle method_106(XmlNode A_0)
    {
        int num = 0;
        string styleName = null;
        ListStyle style = null;
        ListPatternType type = (A_0.ParentNode.Name.ToLower() == BookmarkStart.b("䤥䐧", 0)) ? ListPatternType.Arabic : ListPatternType.Bullet;
        string str6 = string.Empty;
        string str7 = string.Empty;
        string str4 = string.Empty;
        foreach (XmlAttribute attribute in A_0.ParentNode.Attributes)
        {
            string str5;
            if (((str5 = attribute.Name) != null) && (str5 == BookmarkStart.b("唥尧匩䀫䬭", num)))
            {
                str4 = attribute.Value;
            }
        }
        str4 = this.class298_0.method_5(A_0.ParentNode) + str4;
        if (A_0.Attributes[BookmarkStart.b("別儧娩䤫", num)] != null)
        {
            str4 = str4 + BookmarkStart.b("別儧娩䤫ᐭ", num) + A_0.Attributes[BookmarkStart.b("別儧娩䤫", num)].Value;
        }
        this.method_107(str4, ref type, ref str6, ref str7);
        if (this.listStyle_0 != null)
        {
            return this.listStyle_0;
        }
        if (((((this.listStyle_0 == null) && (this.iparagraphStyle_0 != null)) && ((this.iparagraphStyle_0 is ParagraphStyle) && ((this.iparagraphStyle_0 as ParagraphStyle).ListFormat != null))) && ((this.iparagraphStyle_0 as ParagraphStyle).ListFormat.ListType != ListType.NoList)) && ((((this.iparagraphStyle_0 as ParagraphStyle).ListFormat.ListType == ListType.Bulleted) && (type == ListPatternType.Bullet)) || (((this.iparagraphStyle_0 as ParagraphStyle).ListFormat.ListType == ListType.Numbered) && (type != ListPatternType.Bullet))))
        {
            return (this.iparagraphStyle_0 as ParagraphStyle).ListFormat.CurrentListStyle;
        }
        if (type == ListPatternType.Bullet)
        {
            styleName = BookmarkStart.b("搥崧䘩䀫䬭䐯圱倳椵", num) + this.paragraph_0.Document.ListStyles.Count.ToString();
            style = this.paragraph_0.Document.AddListStyle(ListType.Bulleted, styleName);
        }
        else
        {
            styleName = BookmarkStart.b("栥崧䜩丫䬭䈯圱倳椵", num) + this.paragraph_0.Document.ListStyles.Count.ToString();
            style = this.paragraph_0.Document.AddListStyle(ListType.Numbered, styleName);
        }
        ListLevel level = style.Levels[this.int_0];
        if (!string.IsNullOrEmpty(str7))
        {
            level.BulletCharacter = str7;
            if (!string.IsNullOrEmpty(str6))
            {
                level.CharacterFormat.FontName = str6;
            }
        }
        level.PatternType = type;
        level.TabSpaceAfter = 10f;
        level.FollowCharacter = FollowCharacterType.Tab;
        string str2 = this.method_97(A_0, BookmarkStart.b("瀥椧昩礫欭", num));
        string str3 = this.method_97(A_0.ParentNode, BookmarkStart.b("甥簧欩縫稭", num));
        if (!string.IsNullOrEmpty(str2))
        {
            try
            {
                level.StartAt = Convert.ToInt32(str2);
                return style;
            }
            catch
            {
                level.StartAt = this.method_108(str2, this.method_97(A_0.ParentNode, BookmarkStart.b("爥焧稩椫", num)));
                return style;
            }
        }
        if (!string.IsNullOrEmpty(str3))
        {
            try
            {
                level.StartAt = Convert.ToInt32(str3);
            }
            catch
            {
                level.StartAt = this.method_108(str3, this.method_97(A_0.ParentNode, BookmarkStart.b("爥焧稩椫", num)));
            }
        }
        return style;
    }

    private void method_107(string A_0, ref ListPatternType A_1, ref string A_2, ref string A_3)
    {
        int num = 8;
        string[] strArray = A_0.Split(new char[] { ';', ':' });
        int index = 0;
        int length = strArray.Length;
        while (index < (length - 1))
        {
            string str4;
            string str2 = strArray[index].ToLower().Trim();
            string str3 = strArray[index + 1].ToLower().Trim();
            if (((str4 = str2) != null) && (str4 == BookmarkStart.b("䈭夯䄱䀳ᬵ䬷丹䔻刽┿潁ぃ㽅㡇⽉", num)))
            {
                A_2 = string.Empty;
                A_3 = string.Empty;
                string key = str3;
                if (key != null)
                {
                    int num4;
                    if (Class1160.dictionary_133 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(20);
                        dictionary1.Add(BookmarkStart.b("䴭夯䀱圳娵崷", num), 0);
                        dictionary1.Add(BookmarkStart.b("崭䄯䜱唳䐵崷", num), 1);
                        dictionary1.Add(BookmarkStart.b("䨭唯儱崳嬵夷嘹", num), 2);
                        dictionary1.Add(BookmarkStart.b("䨭唯儱崳嬵夷嘹ᄻ刽┿⍁⁃⽅♇ⵉ態㑍㕏⁑㭓", num), 3);
                        dictionary1.Add(BookmarkStart.b("䈭弯䔱儳䐵ᔷ䠹医匽ℿⱁ", num), 4);
                        dictionary1.Add(BookmarkStart.b("嬭䀯䈱儳䐵ᔷ䠹医匽ℿⱁ", num), 5);
                        dictionary1.Add(BookmarkStart.b("䈭弯䔱儳䐵ᔷ嬹倻丽⠿⍁", num), 6);
                        dictionary1.Add(BookmarkStart.b("䈭弯䔱儳䐵ᔷ嘹崻䨽⤿ⱁ", num), 7);
                        dictionary1.Add(BookmarkStart.b("嬭䀯䈱儳䐵ᔷ嬹倻丽⠿⍁", num), 8);
                        dictionary1.Add(BookmarkStart.b("嬭䀯䈱儳䐵ᔷ嘹崻䨽⤿ⱁ", num), 9);
                        dictionary1.Add(BookmarkStart.b("䈭弯䔱儳䐵ᔷ崹主嬽┿⥁", num), 10);
                        dictionary1.Add(BookmarkStart.b("䘭唯倱䘳匵伷", num), 11);
                        dictionary1.Add(BookmarkStart.b("伭䈯弱儳堵儷嬹刻", num), 12);
                        dictionary1.Add(BookmarkStart.b("䤭唯崱䘳儵儷嬹刻", num), 13);
                        dictionary1.Add(BookmarkStart.b("䴭娯失ᤳ張尷弹医夽㈿⍁㑃⹅ⅇ⥉", num), 14);
                        dictionary1.Add(BookmarkStart.b("䘭夯䀱唳儵夷吹崻", num), 15);
                        dictionary1.Add(BookmarkStart.b("䔭儯䘱唳崵夷吹崻", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䘭夯䀱唳儵夷吹崻ጽ⤿ぁ⭃⹅⥇", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("䔭儯䘱唳崵夷吹崻ጽ⤿ぁ⭃⹅⥇", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("䨭夯䄱圳", num), 0x13);
                        Class1160.dictionary_133 = dictionary1;
                    }
                    if (Class1160.dictionary_133.TryGetValue(key, out num4))
                    {
                        switch (num4)
                        {
                            case 0:
                                A_1 = ListPatternType.Bullet;
                                A_2 = BookmarkStart.b("洭弯䜱䘳張崷䠹᰻瀽┿㕁", num);
                                A_3 = BookmarkStart.b("䄭", num);
                                goto Label_0353;

                            case 1:
                                A_1 = ListPatternType.Bullet;
                                A_2 = BookmarkStart.b("礭夯就匳刵儷吹嬻䴽", num);
                                A_3 = BookmarkStart.b("觝", num);
                                goto Label_0353;

                            case 2:
                                A_1 = ListPatternType.Arabic;
                                goto Label_0353;

                            case 3:
                                A_1 = ListPatternType.LeadingZero;
                                goto Label_0353;

                            case 4:
                                A_1 = ListPatternType.LowRoman;
                                goto Label_0353;

                            case 5:
                                A_1 = ListPatternType.UpRoman;
                                goto Label_0353;

                            case 6:
                            case 7:
                                A_1 = ListPatternType.LowLetter;
                                goto Label_0353;

                            case 8:
                            case 9:
                                A_1 = ListPatternType.UpLetter;
                                goto Label_0353;

                            case 10:
                                A_1 = ListPatternType.LowLetter;
                                A_2 = BookmarkStart.b("紭䤯弱嘳夵吷", num);
                                A_3 = BookmarkStart.b("駝", num);
                                goto Label_0353;

                            case 11:
                                A_1 = ListPatternType.Hebrew1;
                                goto Label_0353;

                            case 12:
                            case 13:
                                A_1 = ListPatternType.Arabic;
                                goto Label_0353;

                            case 14:
                                A_1 = ListPatternType.IdeographDigital;
                                goto Label_0353;

                            case 15:
                                A_1 = ListPatternType.Arabic;
                                goto Label_0353;

                            case 0x10:
                                A_1 = ListPatternType.AiueoFullWidth;
                                goto Label_0353;

                            case 0x11:
                                A_1 = ListPatternType.Arabic;
                                goto Label_0353;

                            case 0x12:
                                A_1 = ListPatternType.IrohaFullWidth;
                                goto Label_0353;
                        }
                    }
                }
                A_1 = ListPatternType.Bullet;
                A_2 = BookmarkStart.b("紭䤯弱嘳夵吷", num);
                A_3 = BookmarkStart.b("駝", num);
            }
        Label_0353:
            index += 2;
        }
    }

    private int method_108(string A_0, string A_1)
    {
        int num = 12;
        if ((A_1 == BookmarkStart.b("嬱", 12)) || (A_1 == BookmarkStart.b("笱", num)))
        {
            return this.method_151(A_0);
        }
        byte num2 = (byte) A_0.ToCharArray()[0];
        if ((num2 >= 0x41) && (num2 <= 90))
        {
            return (num2 - 0x40);
        }
        if ((num2 >= 0x61) && (num2 <= 0x7a))
        {
            return (num2 - 0x60);
        }
        return 1;
    }

    private bool method_109(XmlNode A_0)
    {
        int num = 13;
        while (A_0.NextSibling != null)
        {
            if (!(A_0.NextSibling.Name == BookmarkStart.b("ဲ䈴弶倸伺堼䰾ㅀ≂♄≆", num)))
            {
                return false;
            }
            A_0 = A_0.NextSibling;
        }
        return true;
    }

    private string method_11(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䘶䰸吺䤼о", 15), BookmarkStart.b("ጴᐶਸ༺ؼ", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嘶䤸吺丼о", 15), BookmarkStart.b("ጴᐶਸȺؼ", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嘶吸䬺ؼ", 15), BookmarkStart.b("ጴᐶਸ̺ؼ", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嬶䴸:", 15), BookmarkStart.b("ጴᐶ༸଺ؼ", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ倶䴸:", 15), BookmarkStart.b("ጴᐶ༸ऺؼ", 15));
        return A_0;
    }

    private bool method_110(XmlNode A_0)
    {
        int num = 13;
        while (A_0.PreviousSibling != null)
        {
            if ((A_0.PreviousSibling.Name != BookmarkStart.b("ဲ䈴弶倸伺堼䰾ㅀ≂♄≆", num)) && ((!(A_0.Name == BookmarkStart.b("弲尴", num)) && !(A_0.Name == BookmarkStart.b("弲崴", num))) || !(A_0.PreviousSibling.Name == BookmarkStart.b("ဲ䄴制䄸伺", num))))
            {
                return false;
            }
            A_0 = A_0.PreviousSibling;
        }
        return true;
    }

    private bool method_111(XmlNode A_0)
    {
        int num = 0;
        if (((A_0.ParentNode != null) && ((A_0.ParentNode.Name.ToUpper() == BookmarkStart.b("椥搧", num)) || (A_0.ParentNode.Name.ToUpper() == BookmarkStart.b("猥搧", num)))) && ((A_0.ParentNode.ParentNode != null) && ((A_0.ParentNode.ParentNode.Name.ToUpper() == BookmarkStart.b("搥朧温甫", num)) || (A_0.ParentNode.ParentNode.Name.ToUpper() == BookmarkStart.b("渥簧朩怫", num)))))
        {
            return false;
        }
        return true;
    }

    private bool method_112(XmlNode A_0)
    {
        int num = 0x13;
        for (XmlNode node = A_0.ParentNode; node != null; node = node.ParentNode)
        {
            if (node.NodeType != XmlNodeType.Element)
            {
                break;
            }
            if (node.Name.ToLower() == BookmarkStart.b("椸", num))
            {
                return true;
            }
            if (node.Name.ToLower() == BookmarkStart.b("崸刺䬼", num))
            {
                return false;
            }
        }
        return false;
    }

    private void method_113(XmlNode A_0)
    {
        if ((this.stack_22.Count > 0) && (this.stack_23.Count == 0))
        {
            if (this.stack_21.Count > 0)
            {
                if (this.stack_21.Peek().Cells.Count == 0)
                {
                    this.stack_18.Pop();
                    this.stack_22.Peek().Rows.Remove(this.stack_21.Peek());
                    this.stack_21.Pop();
                }
                else
                {
                    this.method_122(this.stack_21.Peek(), this.stack_22.Peek());
                }
            }
            this.method_115(this.stack_24.Peek(), this.stack_19.Peek(), this.stack_22.Peek());
        }
        if (this.list_0 != null)
        {
            this.stack_20.Push(this.list_0);
        }
        if (this.stack_22.Count == 0)
        {
            Class751 class4 = (this.class751_3 != null) ? this.class751_3.method_97() : new Class751();
            if (!this.method_112(A_0))
            {
                if ((this.stack_5.Count > 0) && this.stack_5.Peek().method_102(7))
                {
                    class4.method_54(this.stack_5.Peek().method_53());
                }
            }
            else if (this.stack_5.Count > 1)
            {
                Class751 class5 = this.stack_5.Pop();
                if (this.stack_5.Peek().method_102(7))
                {
                    class4.method_54(this.stack_5.Peek().method_53());
                }
                this.stack_5.Push(class5);
            }
            if (this.method_3().method_102(12))
            {
                class4.method_86(this.method_3().method_85());
            }
            if (this.method_3().method_102(1))
            {
                class4.method_56(this.method_3().method_55());
            }
            this.stack_0.Push(class4);
        }
        this.list_0 = null;
        Class752 class2 = new Class752(null);
        Class749 class3 = new Class749();
        class3.method_1(new Dictionary<int, ArrayList>());
        this.class748_0.method_0().Push(class3.method_0());
        Table item = new Table(this.bodyRegionCollection_0.Document, false);
        if (this.method_0() != null)
        {
            item.TableFormat.DivId = this.method_0().method_7();
        }
        if ((this.bodyRegionCollection_0.Count > 0) && (this.bodyRegionCollection_0.LastItem.DocumentObjectType == DocumentObjectType.Table))
        {
            Paragraph entity = new Paragraph(this.bodyRegionCollection_0.Document) {
                BreakCharacterFormat = { Hidden = true }
            };
            this.bodyRegionCollection_0.Add(entity);
        }
        this.stack_22.Push(item);
        this.stack_24.Push(A_0);
        item.TableFormat.IsAutoResized = true;
        this.method_96();
        this.method_3().method_98(10);
        this.method_3().class752_0 = new Class752(null);
        this.method_3().method_98(0x19);
        if (this.method_114(A_0))
        {
            item.TableFormat.BackColor = this.method_3().method_53();
            item.TableFormat.LeftIndent = this.method_3().method_85();
            switch (this.method_3().method_83())
            {
                case HorizontalAlignment.Center:
                    item.TableFormat.HorizontalAlignment = RowAlignment.Center;
                    goto Label_036A;

                case HorizontalAlignment.Right:
                    item.TableFormat.HorizontalAlignment = RowAlignment.Right;
                    goto Label_036A;
            }
            item.TableFormat.HorizontalAlignment = RowAlignment.Left;
        }
    Label_036A:
        this.method_3().method_98(12);
        this.method_3().method_98(14);
        this.method_3().method_98(11);
        this.method_3().method_98(13);
        this.method_142(A_0, class3, class2);
        this.stack_5.Push(this.class751_1);
        this.class751_1 = this.method_3().method_97();
        this.stack_18.Push(class2);
        this.stack_19.Push(class3);
        this.method_21(A_0.ChildNodes);
        this.method_115(A_0, class3, item);
    }

    private bool method_114(XmlNode A_0)
    {
        int num = 14;
        bool flag = true;
        XmlNode previousSibling = A_0.PreviousSibling;
        if (previousSibling != null)
        {
            while (previousSibling != null)
            {
                if ((previousSibling.NodeType == XmlNodeType.Element) && (previousSibling.LocalName == BookmarkStart.b("䐳", num)))
                {
                    return false;
                }
                previousSibling = previousSibling.PreviousSibling;
            }
            return flag;
        }
        return flag;
    }

    private void method_115(XmlNode A_0, Class749 A_1, Table A_2)
    {
        int num = 0;
        if ((this.stack_22.Count != 0) && (this.stack_22.Peek() == A_2))
        {
            if ((this.stack_21.Count > 0) && (this.stack_21.Peek().OwnerTable == A_2))
            {
                this.method_122(this.stack_21.Peek(), A_2);
            }
            if (this.stack_18.Count > 0)
            {
                this.stack_18.Pop();
            }
            if (this.stack_19.Count > 0)
            {
                A_1 = this.stack_19.Pop();
            }
            if (this.stack_5.Count > 0)
            {
                this.class751_1 = this.stack_5.Pop();
            }
            this.method_94(true);
            A_1.method_7(A_2, this.class748_0.method_0());
            if (A_0.ParentNode.Name == BookmarkStart.b("別䰧", num))
            {
                this.float_7 = A_2.Width;
            }
            else
            {
                this.float_7 = 0f;
            }
            if (this.int_1 != -1)
            {
                A_2.Rows.Add(A_2.Rows[this.int_1]);
                this.int_1 = -1;
            }
            this.bodyRegionCollection_0 = this.stack_1.Peek();
            this.table_0 = A_2;
            if (A_2.Rows.Count > 0)
            {
                this.bodyRegionCollection_0.Add(A_2);
            }
            this.stack_22.Pop();
            if (this.stack_22.Count == 0)
            {
                this.method_94(true);
            }
            this.stack_24.Pop();
            if (this.stack_20.Count > 0)
            {
                this.list_0 = this.stack_20.Pop();
            }
            else
            {
                this.list_0 = null;
            }
            this.method_49();
        }
    }

    private void method_116(XmlNode A_0)
    {
        if (this.stack_22.Count != 0)
        {
            Table table = this.stack_22.Peek();
            this.stack_10.Push(table.TableFormat.method_50());
            this.stack_18.Push(this.stack_18.Peek().method_0());
            this.method_142(A_0, this.stack_19.Peek(), this.stack_18.Peek());
            this.method_21(A_0.ChildNodes);
            this.stack_18.Pop();
            table.TableFormat.method_21(this.stack_10.Pop());
        }
    }

    private void method_117(XmlNode A_0)
    {
        int num = 4;
        int num2 = 1;
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        num2 = this.method_127(A_0, dictionary);
        if (A_0.ChildNodes.Count > 0)
        {
            foreach (XmlNode node in A_0.ChildNodes)
            {
                if ((node.NodeType != XmlNodeType.Whitespace) && (node.Name.ToLower() == BookmarkStart.b("䤩䌫䈭", num)))
                {
                    dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                    num2 = this.method_127(node, dictionary);
                    if (this.list_0 == null)
                    {
                        this.list_0 = new List<Dictionary<string, string>>();
                    }
                    for (int i = 0; i < num2; i++)
                    {
                        this.list_0.Add(dictionary);
                    }
                }
            }
        }
        else
        {
            if (this.list_0 == null)
            {
                this.list_0 = new List<Dictionary<string, string>>();
            }
            for (int j = 0; j < num2; j++)
            {
                this.list_0.Add(dictionary);
            }
        }
    }

    private void method_118(XmlNode A_0)
    {
        int num = 1;
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        num = this.method_127(A_0, dictionary);
        if (this.list_0 == null)
        {
            this.list_0 = new List<Dictionary<string, string>>();
        }
        for (int i = 0; i < num; i++)
        {
            this.list_0.Add(dictionary);
        }
    }

    private void method_119(XmlNode A_0)
    {
        TableRow row;
        int num = 3;
        if (((this.stack_1.Count > 0) && (this.stack_1.Peek().Owner is TableCell)) && (this.stack_22.Peek() == (this.stack_1.Peek().Owner.Owner.Owner as Table)))
        {
            this.method_120(this.stack_24.Peek(), this.stack_23.Peek());
        }
        if ((this.stack_22.Count > 0) && ((this.stack_21.Count == 0) || (this.stack_21.Peek().OwnerTable != this.stack_22.Peek())))
        {
            this.method_96();
            row = this.stack_22.Peek().AddRow(true, false);
            this.stack_21.Push(row);
            this.stack_18.Push(this.stack_18.Peek().method_0());
        }
        else
        {
            if ((this.stack_21.Count <= 0) || (this.stack_21.Count != (this.stack_23.Count + 1)))
            {
                this.method_21(A_0.ChildNodes);
                return;
            }
            row = this.stack_21.Peek();
        }
        int num2 = this.stack_19.Peek().method_15(row.OwnerTable.Rows.Count - 1);
        TableCell item = row.AddCell(false);
        item.HTMLColIndex = num2;
        this.bool_5 = false;
        this.bodyRegionCollection_0 = item.Items;
        this.stack_23.Push(item);
        this.stack_24.Push(A_0);
        this.stack_1.Push(this.bodyRegionCollection_0);
        item.CellFormat.IsAutoResized = true;
        this.paragraph_0 = null;
        this.method_96();
        if (A_0.Name.ToLower() == BookmarkStart.b("崨䌪", num))
        {
            this.method_3().method_84(HorizontalAlignment.Center);
            this.method_3().method_41(true);
        }
        this.stack_18.Push(this.stack_18.Peek().method_0());
        this.method_135(A_0, item, row.OwnerTable.Rows.Count - 1, this.stack_19.Peek(), this.stack_18.Peek());
        this.stack_5.Push(this.class751_1);
        this.class751_1 = this.method_3().method_97();
        this.stack_15.Push(true);
        this.method_21(A_0.ChildNodes);
        this.method_120(A_0, item);
        if (item.ChildObjects.LastItem is Table)
        {
            item.AddParagraph();
        }
    }

    private string method_12(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ሳ堵娷䤹䰻Խ", 14), BookmarkStart.b("ሳᔵषహ఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張崷䈹弻刽笿", 14), BookmarkStart.b("ሳᔵषహ഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ唵崷吹䠻Խ", 14), BookmarkStart.b("ሳᔵषహ฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䘵圷伹刻娽笿", 14), BookmarkStart.b("ሳᔵषహ༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ唵䴷䠹主嬽⸿祁", 14), BookmarkStart.b("ሳᔵषహ࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ伵崷吹ܻ", 14), BookmarkStart.b("ሳᔵषహऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ吵䨷䰹帻弽㈿祁", 14), BookmarkStart.b("ሳᔵषహ਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵崷夹䠻Խ", 14), BookmarkStart.b("ሳᔵषహ଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䌵唷嘹ܻ", 14), BookmarkStart.b("ሳᔵषహлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ唵圷䨹䔻Խ", 14), BookmarkStart.b("ሳᔵषహԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵䨷帹娻Խ", 14), BookmarkStart.b("ሳᔵषഹ఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ娵夷䬹䤻儽笿", 14), BookmarkStart.b("ሳᔵषഹ഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ堵圷丹ܻ", 14), BookmarkStart.b("ሳᔵषഹ฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵倷䌹ܻ", 14), BookmarkStart.b("ሳᔵषഹ༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䐵崷崹ܻ", 14), BookmarkStart.b("ሳᔵषഹ࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ嬵夷夹主Խ", 14), BookmarkStart.b("ሳᔵषഹऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ刵崷崹ܻ", 14), BookmarkStart.b("ሳᔵषഹ਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䘵吷伹伻匽⸿祁", 14), BookmarkStart.b("ሳᔵषഹ଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵䴷䨹฻Խ", 14), BookmarkStart.b("ሳᔵषഹлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵䴷䨹༻Խ", 14), BookmarkStart.b("ሳᔵषഹԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵嬷伹䠻嬽笿", 14), BookmarkStart.b("ሳᔵषȹ఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ嬵儷夹主儽笿", 14), BookmarkStart.b("ሳᔵषȹ഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䘵夷䠹崻Խ", 14), BookmarkStart.b("ሳᔵषȹ฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ嬵儷帹堻儽㐿祁", 14), BookmarkStart.b("ሳᔵषȹ༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ唵崷帹唻刽笿", 14), BookmarkStart.b("ሳᔵषȹ࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵䴷䨹഻Խ", 14), BookmarkStart.b("ሳᔵषȹऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵䨷帹儻Խ", 14), BookmarkStart.b("ሳᔵषȹ਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䐵夷䬹䤻儽笿", 14), BookmarkStart.b("ሳᔵषȹ଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ倵䨷嬹弻༽琿祁", 14), BookmarkStart.b("ሳᔵषȹлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ倵䨷嬹弻༽爿祁", 14), BookmarkStart.b("ሳᔵषȹԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ倵䨷嬹弻ഽ琿祁", 14), BookmarkStart.b("ሳᔵष̹఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張䤷伹夻䴽㐿祁", 14), BookmarkStart.b("ሳᔵष഻̹Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䈵儷圹夻䴽笿", 14), BookmarkStart.b("ሳᔵ਷ହऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ刵儷䰹唻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷ู଻Խ", 14));
        return A_0;
    }

    private void method_120(XmlNode A_0, TableCell A_1)
    {
        if ((this.stack_23.Count != 0) && (A_1 == this.stack_23.Peek()))
        {
            if (this.stack_1.Count > 1)
            {
                this.stack_1.Pop();
                this.bodyRegionCollection_0 = this.stack_1.Peek();
            }
            this.stack_15.Pop();
            if (this.stack_5.Count > 0)
            {
                this.class751_1 = this.stack_5.Pop();
            }
            this.method_94(true);
            this.stack_23.Pop();
            this.stack_24.Pop();
            this.stack_18.Pop();
        }
    }

    private void method_121(XmlNode A_0)
    {
        int num = 13;
        if ((A_0.Name.ToLower() != BookmarkStart.b("儲䜴", 13)) && (this.stack_22.Count != 0))
        {
            Table table = this.stack_22.Peek();
            if ((this.stack_21.Count > 0) && (this.stack_21.Peek() == table.LastRow))
            {
                this.method_122(this.stack_21.Peek(), this.stack_22.Peek());
            }
            TableRow item = table.AddRow(true, false);
            this.stack_21.Push(item);
            this.stack_24.Push(A_0);
            if (item == table.FirstRow)
            {
                item.RowFormat.method_21(table.TableFormat);
            }
            if (A_0.ParentNode.Name == BookmarkStart.b("䜲崴制堸强", num))
            {
                item.IsHeader = true;
            }
            else if (item.IsHeader)
            {
                item.IsHeader = false;
            }
            if (A_0.ParentNode.Name == BookmarkStart.b("䜲匴堶嘸伺", num))
            {
                this.int_1 = table.Rows.Count - 1;
            }
            this.method_96();
            this.stack_18.Push(this.stack_18.Peek().method_0());
            this.method_140(A_0, item, this.stack_18.Peek());
            this.stack_5.Push(this.class751_1);
            this.class751_1 = this.method_3().method_97();
            this.stack_19.Peek().method_2();
            this.method_21(A_0.ChildNodes);
            this.method_122(item, table);
        }
        else
        {
            this.method_21(A_0.ChildNodes);
        }
    }

    private void method_122(TableRow A_0, Table A_1)
    {
        if ((this.stack_21.Count != 0) && (A_0 == this.stack_21.Peek()))
        {
            Class749 class2 = this.stack_19.Peek();
            if (A_0.Cells.Count == 0)
            {
                TableCell cell = A_0.AddCell(true);
                cell.CellFormat.Borders.BorderType = BorderStyle.None;
                int count = A_1.Rows[A_1.Rows.Count - 2].Cells.Count;
                if (count > 1)
                {
                    cell.CellFormat.HorizontalMerge = CellMerge.Start;
                    cell.int_9 = count;
                    int hTMLColIndex = cell.HTMLColIndex;
                    while (count > 1)
                    {
                        TableCell cell2 = cell.OwnerRow.AddCell(false);
                        cell2.HTMLColIndex = ++hTMLColIndex;
                        cell2.CellFormat.ImportContainer(cell.CellFormat);
                        cell2.CellFormat.HorizontalMerge = CellMerge.Continue;
                        class2.method_13(cell.OwnerRow.Cells.Count);
                        count--;
                    }
                }
                cell.CellFormat.IsAutoResized = true;
                cell.CellFormat.SamePaddingsAsTable = true;
                class2.method_14(A_1.Rows.Count - 1, cell.HTMLColIndex, 1, cell.int_9);
                class2.method_3(cell);
            }
            this.stack_18.Pop();
            if (this.stack_5.Count > 0)
            {
                this.class751_1 = this.stack_5.Pop();
            }
            this.method_94(true);
            class2.method_1(this.class748_0.method_0().Pop());
            class2.method_0().Add(class2.method_0().Count, class2.arrayList_0.Clone() as ArrayList);
            class2.arrayList_0.Clear();
            this.class748_0.method_0().Push(class2.method_0());
            this.verticalAlignment_0 = VerticalAlignment.Middle;
            if (this.stack_21.Count > 0)
            {
                this.stack_21.Pop();
            }
        }
    }

    private void method_123(XmlNode A_0, ref int A_1, Class749 A_2, Class752 A_3, bool A_4)
    {
        int num = 0;
        foreach (XmlNode node in A_0.ChildNodes)
        {
            TableRow row;
            if (node.NodeType == XmlNodeType.Whitespace)
            {
                continue;
            }
            Stack<Class752> stack = new Stack<Class752>();
            if (((node.Name == BookmarkStart.b("別䨧䔩䠫圭", num)) || (node.Name == BookmarkStart.b("別䀧伩䴫䨭", num))) || (node.Name == BookmarkStart.b("別丧䔩䌫娭", num)))
            {
                goto Label_0FD2;
            }
            if (node.Name.ToLower() == BookmarkStart.b("䔥䜧䘩䬫尭弯䜱䐳", num))
            {
                int num6 = 1;
                Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                num6 = this.method_127(node, dictionary);
                if (node.ChildNodes.Count > 0)
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if ((node2.NodeType != XmlNodeType.Whitespace) && (node2.Name.ToLower() == BookmarkStart.b("䔥䜧䘩", num)))
                        {
                            dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                            num6 = this.method_127(node2, dictionary);
                            if (this.list_0 == null)
                            {
                                this.list_0 = new List<Dictionary<string, string>>();
                            }
                            for (int i = 0; i < num6; i++)
                            {
                                this.list_0.Add(dictionary);
                            }
                        }
                    }
                }
                else
                {
                    if (this.list_0 == null)
                    {
                        this.list_0 = new List<Dictionary<string, string>>();
                    }
                    for (int j = 0; j < num6; j++)
                    {
                        this.list_0.Add(dictionary);
                    }
                }
                continue;
            }
            if (node.Name.ToLower() == BookmarkStart.b("䔥䜧䘩", num))
            {
                int num13 = 1;
                Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                num13 = this.method_127(node, dictionary2);
                if (this.list_0 == null)
                {
                    this.list_0 = new List<Dictionary<string, string>>();
                }
                for (int k = 0; k < num13; k++)
                {
                    this.list_0.Add(dictionary2);
                }
                continue;
            }
            if (node.Name.ToLower() == BookmarkStart.b("䔥䤧娩堫䜭弯就", num))
            {
                this.method_125(node, A_3);
                A_2.method_1(this.class748_0.method_0().Pop());
                A_2.method_0().Add(A_2.method_0().Count, A_2.arrayList_0);
                this.class748_0.method_0().Push(A_2.method_0());
                A_1++;
                continue;
            }
            if (node.Name.ToLower() == BookmarkStart.b("䐥娧", num))
            {
                continue;
            }
            if (node.Name.ToLower() != BookmarkStart.b("別娧", num))
            {
                throw new NotSupportedException(BookmarkStart.b("渥尧䜩䀫อ匯崱娳䈵夷匹刻䴽怿ⱁ⭃㉅桇㵉⥋≍㱏牑㉓㥕⩗㝙㵛⩝ᑟݡc䙥ᱧ୩๫ɭᕯ", num));
            }
            if (A_4)
            {
                row = this.table_0.AddRow(true, false);
            }
            else
            {
                row = this.table_0.AddRow(false, false);
            }
            A_1++;
            if ((row == this.table_0.FirstRow) && A_4)
            {
                row.RowFormat.method_21(this.table_0.TableFormat);
            }
            if (node.ParentNode.Name == BookmarkStart.b("別䀧伩䴫䨭", num))
            {
                row.IsHeader = true;
            }
            else if (node.ParentNode.Name == BookmarkStart.b("別丧䔩䌫娭", num))
            {
                this.int_1 = this.table_0.Rows.Count - 1;
            }
            this.method_96();
            stack.Push(A_3.method_0());
            this.method_140(node, row, A_3);
            this.stack_5.Push(this.class751_1);
            this.class751_1 = this.method_3().method_97();
            A_2.method_2();
            using (IEnumerator enumerator4 = node.ChildNodes.GetEnumerator())
            {
                XmlNode current;
                XmlNode node12;
                while (enumerator4.MoveNext())
                {
                    current = (XmlNode) enumerator4.Current;
                    if (current.NodeType != XmlNodeType.Whitespace)
                    {
                        if ((current.Name.ToLower() != BookmarkStart.b("別䰧", num)) && (current.Name.ToLower() != BookmarkStart.b("別䀧", num)))
                        {
                            if ((current.Name.ToLower() == BookmarkStart.b("別娧", num)) && (current.ParentNode.Name.ToLower() == BookmarkStart.b("別娧", num)))
                            {
                                goto Label_09F3;
                            }
                            if (!(current.Name.ToLower() == BookmarkStart.b("別䤧䠩䀫䬭", num)) || !(current.ParentNode.Name.ToLower() == BookmarkStart.b("別娧", num)))
                            {
                                throw new NotSupportedException(BookmarkStart.b("渥尧䜩䀫อ匯崱娳䈵夷匹刻䴽怿ⱁ⭃㉅桇㵉⥋≍㱏㑑㭓⑕㕗㭙⡛⩝՟١䑣ብ१ࡩk୭", num));
                            }
                            XmlNode node3 = this.method_133(current);
                            XmlNode node4 = this.method_134(current);
                            if ((node3 == null) && (node4 == null))
                            {
                                BodyRegionCollection regions = new BodyRegionCollection(this.bodyRegionCollection_0.Document);
                                this.bodyRegionCollection_0.method_12(regions);
                                this.bodyRegionCollection_0.Clear();
                                TableCell cell3 = row.AddCell(false);
                                this.method_30(current);
                                this.bodyRegionCollection_0.CloneToImpl(cell3.Items);
                                this.bodyRegionCollection_0.Clear();
                                regions.method_12(this.bodyRegionCollection_0);
                                continue;
                            }
                            if (((node3 == null) && (node4 != null)) || (((node3 != null) && (node3.LocalName.ToLower() == BookmarkStart.b("別䤧䠩䀫䬭", num))) && ((this.method_131(current) == null) && (node4 != null))))
                            {
                                string str2 = node4.InnerXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                string str3 = current.OuterXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                if ((node4.LocalName.ToLower() != BookmarkStart.b("別䰧", num)) && (node4.LocalName.ToLower() != BookmarkStart.b("別䀧", num)))
                                {
                                    if (!(node4.LocalName.ToLower() == BookmarkStart.b("別䤧䠩䀫䬭", num)))
                                    {
                                        continue;
                                    }
                                    XmlNode nextSibling = node4.NextSibling;
                                    while (nextSibling != null)
                                    {
                                        if ((nextSibling.LocalName.ToLower() == BookmarkStart.b("別䰧", num)) || (nextSibling.LocalName.ToLower() == BookmarkStart.b("別䀧", num)))
                                        {
                                            break;
                                        }
                                        nextSibling = nextSibling.NextSibling;
                                    }
                                    if ((nextSibling != null) && ((nextSibling.LocalName.ToLower() == BookmarkStart.b("別䰧", num)) || (nextSibling.LocalName.ToLower() == BookmarkStart.b("別䀧", num))))
                                    {
                                        if (node3 == null)
                                        {
                                            str2 = nextSibling.InnerXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                            nextSibling.InnerXml = str2.Insert(0, str3);
                                        }
                                        else
                                        {
                                            string str7 = node3.OuterXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                            str2 = nextSibling.InnerXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                            int index = str2.IndexOf(str7, 0);
                                            nextSibling.InnerXml = str2.Insert(index + str7.Length, str3);
                                        }
                                    }
                                    continue;
                                }
                                if (node3 == null)
                                {
                                    node4.InnerXml = str2.Insert(0, str3);
                                }
                                else
                                {
                                    string str = node3.OuterXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                                    int num7 = str2.IndexOf(str, 0);
                                    node4.InnerXml = str2.Insert(num7 + str.Length, str3);
                                }
                                continue;
                            }
                            if (node3 != null)
                            {
                                this.method_30(current);
                            }
                            continue;
                        }
                        int num10 = A_2.method_15(A_1);
                        TableCell cell4 = row.AddCell(false);
                        cell4.HTMLColIndex = num10;
                        this.bool_5 = false;
                        this.bodyRegionCollection_0 = cell4.Items;
                        cell4.CellFormat.IsAutoResized = true;
                        this.paragraph_0 = null;
                        this.method_96();
                        if (current.Name.ToLower() == BookmarkStart.b("別䀧", num))
                        {
                            this.method_3().method_84(HorizontalAlignment.Center);
                            this.method_3().method_41(true);
                        }
                        this.method_135(current, cell4, A_1, A_2, A_3);
                        this.stack_5.Push(this.class751_1);
                        this.class751_1 = this.method_3().method_97();
                        this.stack_15.Push(true);
                        this.method_21(current.ChildNodes);
                        this.stack_15.Pop();
                        if (this.stack_5.Count > 0)
                        {
                            this.class751_1 = this.stack_5.Pop();
                        }
                        for (int m = 0; m < current.ChildNodes.Count; m++)
                        {
                            if (current.ChildNodes.Item(m).Name == BookmarkStart.b("別䤧䠩䀫䬭", num))
                            {
                                A_2.arrayList_0.Add(this.float_7);
                                A_2.method_5(cell4.int_9);
                            }
                        }
                        this.method_94(true);
                    }
                }
                goto Label_0E33;
            Label_09F3:
                node12 = this.method_133(current);
                XmlNode node13 = this.method_134(current);
                if (row.Cells.Count == 0)
                {
                    row.AddCell(false);
                }
                if ((node12 == null) && (node13 == null))
                {
                    A_2.method_1(this.class748_0.method_0().Pop());
                    A_2.method_0().Add(A_2.method_0().Count, A_2.arrayList_0);
                    this.class748_0.method_0().Push(A_2.method_0());
                    TableRow row2 = this.table_0.AddRow(true, false);
                    A_1++;
                    stack.Push(A_3.method_0());
                    this.method_140(current, row2, A_3);
                    A_2.method_2();
                    this.method_128(current, row2, A_1, A_2, A_3);
                    A_3 = stack.Pop();
                }
                else
                {
                    XmlNode node6 = current.CloneNode(false);
                    string str4 = node.InnerXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                    string str5 = current.OuterXml.Replace(BookmarkStart.b("⬥∧", num), string.Empty).Replace(BookmarkStart.b("⼥", num), string.Empty);
                    int startIndex = str4.IndexOf(str5);
                    string str6 = str4.Substring(startIndex);
                    node6.InnerXml = str6;
                    StringBuilder builder = new StringBuilder();
                    foreach (XmlNode node9 in node6.ChildNodes)
                    {
                        if (node9.NodeType != XmlNodeType.Whitespace)
                        {
                            if (node9.LocalName.ToLower() == BookmarkStart.b("別娧", num))
                            {
                                builder.Append(node9.OuterXml);
                            }
                            else if ((node9.LocalName.ToLower() == BookmarkStart.b("別䰧", num)) || (node9.LocalName.ToLower() == BookmarkStart.b("別䀧", num)))
                            {
                                XmlNode node10 = this.method_133(node9);
                                XmlNode node8 = this.method_134(node9);
                                if ((node10.LocalName.ToLower() != BookmarkStart.b("別䰧", num)) && (node10.LocalName.ToLower() != BookmarkStart.b("別䀧", num)))
                                {
                                    builder.Append(BookmarkStart.b("ᨥ尧堩ራ", num));
                                }
                                builder.Append(node9.OuterXml);
                                if (((node8 == null) && ((node9.LocalName.ToLower() == BookmarkStart.b("別䰧", num)) || (node9.LocalName.ToLower() == BookmarkStart.b("別䀧", num)))) || (((node8 != null) && (node8.LocalName.ToLower() != BookmarkStart.b("別䰧", num))) && (node8.LocalName.ToLower() != BookmarkStart.b("別䀧", num))))
                                {
                                    builder.Append(BookmarkStart.b("ᨥܧ帩師ိ", num));
                                }
                            }
                        }
                    }
                    node6.InnerXml = builder.ToString();
                    foreach (XmlNode node11 in node6.ChildNodes)
                    {
                        A_2.method_1(this.class748_0.method_0().Pop());
                        A_2.method_0().Add(A_2.method_0().Count, A_2.arrayList_0);
                        this.class748_0.method_0().Push(A_2.method_0());
                        TableRow row3 = this.table_0.AddRow(true, false);
                        A_1++;
                        stack.Push(A_3.method_0());
                        this.method_140(node11, row3, A_3);
                        A_2.method_2();
                        this.method_128(node11, row3, A_1, A_2, A_3);
                        A_3 = stack.Pop();
                    }
                }
            }
        Label_0E33:
            if (row.Cells.Count == 0)
            {
                TableCell cell = row.AddCell(true);
                cell.CellFormat.Borders.BorderType = BorderStyle.None;
                int count = this.table_0.Rows[this.table_0.Rows.Count - 2].Cells.Count;
                if (count > 1)
                {
                    cell.CellFormat.HorizontalMerge = CellMerge.Start;
                    cell.int_9 = count;
                    int hTMLColIndex = cell.HTMLColIndex;
                    while (count > 1)
                    {
                        TableCell cell2 = cell.OwnerRow.AddCell(false);
                        cell2.HTMLColIndex = ++hTMLColIndex;
                        cell2.CellFormat.ImportContainer(cell.CellFormat);
                        cell2.CellFormat.HorizontalMerge = CellMerge.Continue;
                        A_2.method_13(cell.OwnerRow.Cells.Count);
                        count--;
                    }
                }
                cell.CellFormat.IsAutoResized = true;
                cell.CellFormat.SamePaddingsAsTable = true;
                A_2.method_14(A_1, cell.HTMLColIndex, 1, cell.int_9);
                A_2.method_3(cell);
            }
            A_3 = stack.Pop();
            if (this.stack_5.Count > 0)
            {
                this.class751_1 = this.stack_5.Pop();
            }
            this.method_94(true);
            A_2.method_1(this.class748_0.method_0().Pop());
            A_2.method_0().Add(A_2.method_0().Count, A_2.arrayList_0.Clone() as ArrayList);
            A_2.arrayList_0.Clear();
            this.class748_0.method_0().Push(A_2.method_0());
            this.verticalAlignment_0 = VerticalAlignment.Middle;
            continue;
        Label_0FD2:
            this.stack_10.Push(this.table_0.TableFormat.method_50());
            stack.Push(A_3.method_0());
            this.method_142(node, A_2, A_3);
            this.method_123(node, ref A_1, A_2, A_3, A_4);
            A_3 = stack.Pop();
            this.table_0.TableFormat.method_21(this.stack_10.Pop());
        }
    }

    private void method_124(XmlNode A_0)
    {
        if (this.stack_22.Count != 0)
        {
            Table table = this.stack_22.Peek();
            TableRow row2 = new TableRow(table.Document);
            int index = 0;
            int num = 0;
            int count = table.Rows.Count;
            while (num < count)
            {
                TableRow row = table.Rows[num];
                if (!row.IsHtmlCaption)
                {
                    break;
                }
                index++;
                num++;
            }
            table.Rows.Insert(index, row2);
            row2.RowFormat.method_21(table.TableFormat);
            row2.IsHeader = true;
            row2.IsHtmlCaption = true;
            TableCell cell = row2.AddCell();
            this.method_96();
            this.method_136(A_0, cell, this.stack_18.Peek());
            this.stack_1.Push(this.bodyRegionCollection_0);
            this.bodyRegionCollection_0 = cell.Items;
            this.paragraph_0 = null;
            this.method_21(A_0.ChildNodes);
            this.method_94(true);
            this.bodyRegionCollection_0 = this.stack_1.Pop();
            Class749 class2 = this.stack_19.Peek();
            class2.method_1(this.class748_0.method_0().Pop());
            class2.method_0().Add(class2.method_0().Count, class2.arrayList_0);
            this.class748_0.method_0().Push(class2.method_0());
        }
    }

    private void method_125(XmlNode A_0, Class752 A_1)
    {
        TableRow row = new TableRow(this.table_0.Document);
        int index = 0;
        int num2 = 0;
        int count = this.table_0.Rows.Count;
        while (num2 < count)
        {
            TableRow row2 = this.table_0.Rows[num2];
            if (!row2.IsHtmlCaption)
            {
                break;
            }
            index++;
            num2++;
        }
        this.table_0.Rows.Insert(index, row);
        row.RowFormat.method_21(this.table_0.TableFormat);
        row.IsHeader = true;
        row.IsHtmlCaption = true;
        TableCell cell = row.AddCell();
        this.method_96();
        this.method_136(A_0, cell, A_1);
        this.bodyRegionCollection_0 = cell.Items;
        this.paragraph_0 = null;
        this.method_30(A_0);
        this.method_94(true);
    }

    private void method_126(XmlNode A_0, Class749 A_1, Class752 A_2)
    {
        int num = -1;
        this.method_123(A_0, ref num, A_1, A_2, true);
    }

    private int method_127(XmlNode A_0, Dictionary<string, string> A_1)
    {
        int num = 0x10;
        int num2 = 1;
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str = attribute.Name.ToLower();
            if (str == BookmarkStart.b("䔵䠷嬹刻", num))
            {
                num2 = int.Parse(attribute.Value);
            }
            A_1[str] = attribute.Value;
        }
        return num2;
    }

    private void method_128(XmlNode A_0, TableRow A_1, int A_2, Class749 A_3, Class752 A_4)
    {
        int num = 11;
        using (IEnumerator enumerator = A_0.ChildNodes.GetEnumerator())
        {
            XmlNode current;
            XmlNode node10;
            while (enumerator.MoveNext())
            {
                current = (XmlNode) enumerator.Current;
                if (current.NodeType != XmlNodeType.Whitespace)
                {
                    if ((current.Name.ToLower() != BookmarkStart.b("䔰圲", num)) && (current.Name.ToLower() != BookmarkStart.b("䔰嬲", num)))
                    {
                        if ((current.Name.ToLower() == BookmarkStart.b("䔰䄲", num)) && (current.ParentNode.Name.ToLower() == BookmarkStart.b("䔰䄲", num)))
                        {
                            goto Label_058C;
                        }
                        if (!(current.Name.ToLower() == BookmarkStart.b("䔰刲圴嬶尸", num)) || !(current.ParentNode.Name.ToLower() == BookmarkStart.b("䔰䄲", num)))
                        {
                            throw new NotSupportedException(BookmarkStart.b("礰䜲場嬶ᤸ堺刼儾㕀≂ⱄ⥆㩈歊⍌⁎═獒≔㉖㕘㝚絜㥞๠ᅢࡤ٦ᵨὪ࡬୮兰ݲᑴᕶᕸṺ", num));
                        }
                        XmlNode node4 = this.method_133(current);
                        XmlNode node9 = this.method_134(current);
                        if ((node4 == null) && (node9 == null))
                        {
                            BodyRegionCollection regions = new BodyRegionCollection(this.bodyRegionCollection_0.Document);
                            this.bodyRegionCollection_0.method_12(regions);
                            this.bodyRegionCollection_0.Clear();
                            TableCell cell2 = A_1.AddCell(false);
                            this.method_30(current);
                            this.bodyRegionCollection_0.CloneToImpl(cell2.Items);
                            this.bodyRegionCollection_0.Clear();
                            regions.method_12(this.bodyRegionCollection_0);
                            continue;
                        }
                        if (((node4 == null) && (node9 != null)) || (((node4 != null) && (node4.LocalName.ToLower() == BookmarkStart.b("䔰刲圴嬶尸", num))) && ((this.method_131(current) == null) && (node9 != null))))
                        {
                            string str2 = node9.InnerXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                            string str3 = current.OuterXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                            if ((node9.LocalName.ToLower() != BookmarkStart.b("䔰圲", num)) && (node9.LocalName.ToLower() != BookmarkStart.b("䔰嬲", num)))
                            {
                                if (!(node9.LocalName.ToLower() == BookmarkStart.b("䔰刲圴嬶尸", num)))
                                {
                                    continue;
                                }
                                XmlNode nextSibling = node9.NextSibling;
                                while (nextSibling != null)
                                {
                                    if ((nextSibling.LocalName.ToLower() == BookmarkStart.b("䔰圲", num)) || (nextSibling.LocalName.ToLower() == BookmarkStart.b("䔰嬲", num)))
                                    {
                                        break;
                                    }
                                    nextSibling = nextSibling.NextSibling;
                                }
                                if ((nextSibling != null) && ((nextSibling.LocalName.ToLower() == BookmarkStart.b("䔰圲", num)) || (nextSibling.LocalName.ToLower() == BookmarkStart.b("䔰嬲", num))))
                                {
                                    if (node4 == null)
                                    {
                                        str2 = nextSibling.InnerXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                                        nextSibling.InnerXml = str2.Insert(0, str3);
                                    }
                                    else
                                    {
                                        string str = node4.OuterXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                                        str2 = nextSibling.InnerXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                                        int index = str2.IndexOf(str, 0);
                                        nextSibling.InnerXml = str2.Insert(index + str.Length, str3);
                                    }
                                }
                                continue;
                            }
                            if (node4 == null)
                            {
                                node9.InnerXml = str2.Insert(0, str3);
                            }
                            else
                            {
                                string str7 = node4.OuterXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                                int num5 = str2.IndexOf(str7, 0);
                                node9.InnerXml = str2.Insert(num5 + str7.Length, str3);
                            }
                            continue;
                        }
                        if (node4 != null)
                        {
                            this.method_30(current);
                        }
                        continue;
                    }
                    int num4 = A_3.method_15(A_2);
                    TableCell cell = A_1.AddCell(false);
                    cell.HTMLColIndex = num4;
                    this.bool_5 = false;
                    this.bodyRegionCollection_0 = cell.Items;
                    cell.CellFormat.IsAutoResized = true;
                    this.paragraph_0 = null;
                    this.method_96();
                    if (current.Name.ToLower() == BookmarkStart.b("䔰嬲", num))
                    {
                        this.method_3().method_84(HorizontalAlignment.Center);
                        this.method_3().method_41(true);
                    }
                    this.method_135(current, cell, A_2, A_3, A_4);
                    this.stack_5.Push(this.class751_1);
                    this.class751_1 = this.method_3().method_97();
                    this.method_21(current.ChildNodes);
                    if (this.stack_5.Count > 0)
                    {
                        this.class751_1 = this.stack_5.Pop();
                    }
                    this.method_94(true);
                }
            }
            goto Label_09D1;
        Label_058C:
            node10 = this.method_133(current);
            XmlNode node11 = this.method_134(current);
            if (A_1.Cells.Count == 0)
            {
                A_1.AddCell(false);
            }
            if ((node10 == null) && (node11 == null))
            {
                A_3.method_1(this.class748_0.method_0().Pop());
                A_3.method_0().Add(A_3.method_0().Count, A_3.arrayList_0);
                this.class748_0.method_0().Push(A_3.method_0());
                TableRow row = this.table_0.AddRow(true, false);
                A_2++;
                Stack<Class752> stack = new Stack<Class752>();
                stack.Push(A_4.method_0());
                this.method_140(current, row, A_4);
                A_3.method_2();
                this.method_128(current, row, A_2, A_3, A_4);
                A_4 = stack.Pop();
            }
            else
            {
                XmlNode node6 = current.CloneNode(false);
                string str4 = A_0.InnerXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                string str5 = current.OuterXml.Replace(BookmarkStart.b("㰰㤲", num), string.Empty).Replace(BookmarkStart.b("㠰", num), string.Empty);
                int startIndex = str4.IndexOf(str5);
                string str6 = str4.Substring(startIndex);
                node6.InnerXml = str6;
                StringBuilder builder = new StringBuilder();
                foreach (XmlNode node in node6.ChildNodes)
                {
                    if (node.NodeType != XmlNodeType.Whitespace)
                    {
                        if (node.LocalName.ToLower() == BookmarkStart.b("䔰䄲", num))
                        {
                            builder.Append(node.OuterXml);
                        }
                        else if ((node.LocalName.ToLower() == BookmarkStart.b("䔰圲", num)) || (node.LocalName.ToLower() == BookmarkStart.b("䔰嬲", num)))
                        {
                            XmlNode node2 = this.method_133(node);
                            XmlNode node3 = this.method_134(node);
                            if ((node2.LocalName.ToLower() != BookmarkStart.b("䔰圲", num)) && (node2.LocalName.ToLower() != BookmarkStart.b("䔰嬲", num)))
                            {
                                builder.Append(BookmarkStart.b("ര䜲䜴श", num));
                            }
                            builder.Append(node.OuterXml);
                            if (((node3 == null) && ((node.LocalName.ToLower() == BookmarkStart.b("䔰圲", num)) || (node.LocalName.ToLower() == BookmarkStart.b("䔰嬲", num)))) || (((node3 != null) && (node3.LocalName.ToLower() != BookmarkStart.b("䔰圲", num))) && (node3.LocalName.ToLower() != BookmarkStart.b("䔰嬲", num))))
                            {
                                builder.Append(BookmarkStart.b("രᰲ䄴䔶ܸ", num));
                            }
                        }
                    }
                }
                node6.InnerXml = builder.ToString();
                foreach (XmlNode node8 in node6.ChildNodes)
                {
                    A_3.method_1(this.class748_0.method_0().Pop());
                    A_3.method_0().Add(A_3.method_0().Count, A_3.arrayList_0);
                    this.class748_0.method_0().Push(A_3.method_0());
                    TableRow row2 = this.table_0.AddRow(true, false);
                    A_2++;
                    Stack<Class752> stack2 = new Stack<Class752>();
                    stack2.Push(A_4.method_0());
                    this.method_140(node8, row2, A_4);
                    A_3.method_2();
                    this.method_128(node8, row2, A_2, A_3, A_4);
                    A_4 = stack2.Pop();
                }
            }
        }
    Label_09D1:
        this.paragraph_0 = null;
    }

    private bool method_129(XmlNode A_0)
    {
        int num = 10;
        if (A_0.LocalName == BookmarkStart.b("䐯嘱", 10))
        {
            using (IEnumerator enumerator = A_0.ChildNodes.GetEnumerator())
            {
                XmlNode current;
                while (enumerator.MoveNext())
                {
                    current = (XmlNode) enumerator.Current;
                    if (current.NodeType == XmlNodeType.Element)
                    {
                        goto Label_004F;
                    }
                }
                goto Label_0085;
            Label_004F:
                if (current.LocalName == BookmarkStart.b("䐯匱嘳娵崷", num))
                {
                    return true;
                }
                return false;
            }
        }
    Label_0085:
        return false;
    }

    private string method_13(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵष̹฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵष̹༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵष̹࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵष̹ऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵष̹਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵䨷匹刻夽笿", 14), BookmarkStart.b("ሳᔵष̹଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ眵紷嘹唻夽笿", 14), BookmarkStart.b("ሳᔵष̹лԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ电嬷弹堻圽ⰿ祁", 14), BookmarkStart.b("ሳᔵष̹ԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ猵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ਹ఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ猵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ਹ഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ猵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ਹ฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ猵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷ਹ༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ缵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ਹ࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ缵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ਹऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ缵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ਹ਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ缵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷ਹ଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ猵氷爹ܻ", 14), BookmarkStart.b("ሳᔵ਷ਹлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ砵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷ਹԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ହ఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ହ഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ହ฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷ହ༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷ହ࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ礵䬷嘹崻䴽⠿祁", 14), BookmarkStart.b("ሳᔵ਷ହ਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ挵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ହ଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ挵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ହлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ挵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ହԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ挵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷࠹఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ漵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷࠹഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ戵瀷甹渻瀽笿", 14), BookmarkStart.b("ሳᔵ਷࠹฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䔵䈷嘹唻夽笿", 14), BookmarkStart.b("ሳᔵ਷࠹༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷࠹࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷࠹ऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷࠹਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷࠹଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷࠹лԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵䨷匹刻夽笿", 14), BookmarkStart.b("ሳᔵ਷࠹ԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ圵崷嘹唻夽笿", 14), BookmarkStart.b("ሳᔵ਷ह఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ唵嬷弹堻圽ⰿ祁", 14), BookmarkStart.b("ሳᔵ਷ह഻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ匵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ह฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ匵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ह༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ匵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ह࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ匵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷हऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ह਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ह଻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷हлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ張䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷हԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ匵䰷刹ܻ", 14), BookmarkStart.b("ሳᔵ਷ู఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ堵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷഻ูԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ู฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷ู༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷ู࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵䰷匹倻娽┿祁", 14), BookmarkStart.b("ሳᔵ਷ูऻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷ู਻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ夵䬷嘹崻䴽⠿祁", 14), BookmarkStart.b("ሳᔵ਷ูлԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䌵強䠹崻䠽┿祁", 14), BookmarkStart.b("ሳᔵ਷ูԻԽ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䌵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷༹఻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䌵嬷匹主崽笿", 14), BookmarkStart.b("ሳᔵ਷഻༹Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䌵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷༹฻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ伵夷夹䤻䨽┿祁", 14), BookmarkStart.b("ሳᔵ਷༹༻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ䈵倷唹主倽笿", 14), BookmarkStart.b("ሳᔵ਷༹࠻Խ", 14));
        A_0 = A_0.Replace(BookmarkStart.b("ሳ伵䴷圹倻Խ", 14), BookmarkStart.b("ሳᔵ਷༹ऻԽ", 14));
        return A_0;
    }

    private XmlNode method_130(XmlNode A_0)
    {
        int num = 0x12;
        A_0.Clone();
        while (A_0.LocalName.ToLower() == BookmarkStart.b("䰷嬹帻刽┿", num))
        {
            XmlNode node;
            XmlNode node2;
            int num2 = 0;
            int count = A_0.ChildNodes.Count;
            while (num2 < count)
            {
                node2 = A_0.ChildNodes[num2];
                if (node2.NodeType != XmlNodeType.Whitespace)
                {
                    int num3 = 0;
                    int num4 = node2.ChildNodes.Count;
                    while (num3 < num4)
                    {
                        node = node2.ChildNodes[num3];
                        if (((node.NodeType != XmlNodeType.Whitespace) && (node.LocalName.ToLower() != BookmarkStart.b("䰷帹", num))) && (node.LocalName.ToLower() != BookmarkStart.b("䰷刹", num)))
                        {
                            if (node.LocalName.ToLower() == BookmarkStart.b("䰷䠹", num))
                            {
                                goto Label_00FD;
                            }
                            bool flag1 = node.LocalName.ToLower() == BookmarkStart.b("䰷嬹帻刽┿", num);
                        }
                        num3++;
                    }
                }
                num2++;
            }
            return A_0;
        Label_00FD:
            this.method_133(node);
            A_0.InsertBefore(node, node2);
        }
        return A_0;
    }

    private XmlNode method_131(XmlNode A_0)
    {
        int num = 1;
        XmlNode previousSibling = A_0.PreviousSibling;
        while (previousSibling != null)
        {
            if ((previousSibling.LocalName.ToLower() == BookmarkStart.b("匦䴨", num)) || (previousSibling.LocalName.ToLower() == BookmarkStart.b("匦䄨", num)))
            {
                return previousSibling;
            }
            previousSibling = previousSibling.PreviousSibling;
        }
        return previousSibling;
    }

    private XmlNode method_132(XmlNode A_0)
    {
        int num = 3;
        XmlNode nextSibling = A_0.NextSibling;
        while (nextSibling != null)
        {
            if ((nextSibling.LocalName.ToLower() == BookmarkStart.b("崨伪", num)) || (nextSibling.LocalName.ToLower() == BookmarkStart.b("崨䌪", num)))
            {
                return nextSibling;
            }
            nextSibling = nextSibling.NextSibling;
        }
        return nextSibling;
    }

    private XmlNode method_133(XmlNode A_0)
    {
        XmlNode previousSibling = A_0.PreviousSibling;
        Regex regex = new Regex(BookmarkStart.b("爫崭匯䀱崳䘵䰷ḹ", 6));
        while (previousSibling != null)
        {
            if ((previousSibling.NodeType != XmlNodeType.Whitespace) && !regex.IsMatch(previousSibling.Name))
            {
                return previousSibling;
            }
            previousSibling = previousSibling.PreviousSibling;
        }
        return previousSibling;
    }

    private XmlNode method_134(XmlNode A_0)
    {
        XmlNode nextSibling = A_0.NextSibling;
        Regex regex = new Regex(BookmarkStart.b("爫崭匯䀱崳䘵䰷ḹ", 6));
        while (nextSibling != null)
        {
            if ((nextSibling.NodeType != XmlNodeType.Whitespace) && !regex.IsMatch(nextSibling.Name))
            {
                return nextSibling;
            }
            nextSibling = nextSibling.NextSibling;
        }
        return nextSibling;
    }

    private void method_135(XmlNode A_0, TableCell A_1, int A_2, Class749 A_3, Class752 A_4)
    {
        int num = 6;
        Class752 class2 = new Class752(A_4);
        int num2 = 1;
        int num3 = 1;
        CellFormat cellFormat = A_1.CellFormat;
        cellFormat.VerticalAlignment = this.verticalAlignment_0;
        new List<XmlAttribute>();
        XmlAttribute attribute = null;
        string str = null;
        foreach (XmlAttribute attribute2 in A_0.Attributes)
        {
            string key = attribute2.Name.ToLower();
            if (key != null)
            {
                int num5;
                if (Class1160.dictionary_134 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("嬫䜭启䘱尳", num), 0);
                    dictionary1.Add(BookmarkStart.b("丫䄭䈯嘱儳䐵", num), 1);
                    dictionary1.Add(BookmarkStart.b("丫䄭䈯嘱儳䐵嬷唹倻儽㈿", num), 2);
                    dictionary1.Add(BookmarkStart.b("弫娭䤯帱儳", num), 3);
                    dictionary1.Add(BookmarkStart.b("伫䄭尯䄱䐳圵嘷", num), 4);
                    dictionary1.Add(BookmarkStart.b("師䄭䜯䄱䐳圵嘷", num), 5);
                    dictionary1.Add(BookmarkStart.b("䴫䈭夯唱娳", num), 6);
                    dictionary1.Add(BookmarkStart.b("丫䤭匯崱堳夵䨷", num), 7);
                    dictionary1.Add(BookmarkStart.b("娫伭尯嬱匳堵", num), 8);
                    Class1160.dictionary_134 = dictionary1;
                }
                if (Class1160.dictionary_134.TryGetValue(key, out num5))
                {
                    switch (num5)
                    {
                        case 0:
                            if (!(attribute2.Value.ToLower() == BookmarkStart.b("䴫嬭䐯崱", num)))
                            {
                                goto Label_0198;
                            }
                            A_1.CellFormat.IsAutoResized = true;
                            break;

                        case 1:
                            class2.float_0 = Convert.ToSingle(this.method_79(attribute2.Value));
                            break;

                        case 2:
                            class2.color_0 = Class1007.smethod_0(attribute2.Value);
                            break;

                        case 3:
                            this.bool_5 = true;
                            attribute = attribute2;
                            break;

                        case 4:
                            num3 = Convert.ToInt32(attribute2.Value);
                            break;

                        case 5:
                            num2 = Convert.ToInt32(attribute2.Value);
                            break;

                        case 6:
                            this.method_3().method_84(this.method_149(attribute2.Value));
                            break;

                        case 7:
                            A_1.CellFormat.BackColor = Class1007.smethod_0(attribute2.Value);
                            break;

                        case 8:
                        {
                            string str3 = attribute2.Value.ToLower();
                            if (str3 != null)
                            {
                                if (str3 == BookmarkStart.b("堫䄭䀯", num))
                                {
                                    goto Label_02AD;
                                }
                                if (str3 == BookmarkStart.b("䄫䜭启嘱堳匵", num))
                                {
                                    goto Label_029F;
                                }
                                if (str3 == BookmarkStart.b("丫䄭䐯䘱嬳嬵", num))
                                {
                                    A_1.CellFormat.VerticalAlignment = VerticalAlignment.Bottom;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            continue;
        Label_0198:
            str = attribute2.Value;
            continue;
        Label_029F:
            A_1.CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            continue;
        Label_02AD:
            A_1.CellFormat.VerticalAlignment = VerticalAlignment.Top;
        }
        string str2 = this.method_138(A_1, num3, A_3) + this.class298_0.method_5(A_0);
        if (!string.IsNullOrEmpty(str))
        {
            str2 = str2 + string.Format(BookmarkStart.b("嬫䜭启䘱尳వᠷ䄹఻䌽", num), str);
        }
        this.method_139(attribute, str2, A_1, class2);
        if (((A_1.OwnerRow != null) && A_1.CellFormat.BackColor.IsEmpty) && !A_1.OwnerRow.RowFormat.BackColor.IsEmpty)
        {
            A_1.CellFormat.BackColor = A_1.OwnerRow.RowFormat.BackColor;
        }
        class2.method_4(cellFormat);
        if (num3 > 1)
        {
            A_1.CellFormat.HorizontalMerge = CellMerge.Start;
        }
        else
        {
            A_1.CellFormat.HorizontalMerge = CellMerge.None;
        }
        A_1.int_9 = num3;
        int hTMLColIndex = A_1.HTMLColIndex;
        while (num3 > 1)
        {
            TableCell cell = A_1.OwnerRow.AddCell(false);
            cell.HTMLColIndex = ++hTMLColIndex;
            cell.CellFormat.ImportContainer(A_1.CellFormat);
            cell.CellFormat.HorizontalMerge = CellMerge.Continue;
            A_3.method_13(A_1.OwnerRow.Cells.Count);
            num3--;
        }
        if (num2 > 1)
        {
            A_1.CellFormat.VerticalMerge = CellMerge.Start;
            A_3.method_5(num2);
        }
        else
        {
            A_1.CellFormat.VerticalMerge = CellMerge.None;
        }
        A_3.method_14(A_2, A_1.HTMLColIndex, num2, A_1.int_9);
        A_3.method_3(A_1);
        A_3.method_4();
    }

    private void method_136(XmlNode A_0, TableCell A_1, Class752 A_2)
    {
        int num = 0x10;
        Class752 class2 = new Class752(A_2);
        CellFormat cellFormat = A_1.CellFormat;
        cellFormat.VerticalAlignment = VerticalAlignment.Middle;
        new List<XmlAttribute>();
        XmlAttribute attribute = null;
        string str = null;
        foreach (XmlAttribute attribute2 in A_0.Attributes)
        {
            string key = attribute2.Name.ToLower();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_135 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("䄵儷帹䠻嘽", num), 0);
                    dictionary1.Add(BookmarkStart.b("吵圷䠹堻嬽㈿", num), 1);
                    dictionary1.Add(BookmarkStart.b("吵圷䠹堻嬽㈿⅁⭃⩅❇㡉", num), 2);
                    dictionary1.Add(BookmarkStart.b("䔵䰷䌹倻嬽", num), 3);
                    dictionary1.Add(BookmarkStart.b("唵圷嘹伻丽ℿⱁ", num), 4);
                    dictionary1.Add(BookmarkStart.b("䐵圷䴹伻丽ℿⱁ", num), 5);
                    dictionary1.Add(BookmarkStart.b("圵吷匹嬻倽", num), 6);
                    Class1160.dictionary_135 = dictionary1;
                }
                if (Class1160.dictionary_135.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            if (!(attribute2.Value.ToLower() == BookmarkStart.b("圵䴷丹医", num)))
                            {
                                goto Label_015B;
                            }
                            A_1.CellFormat.IsAutoResized = true;
                            break;

                        case 1:
                            class2.float_0 = Convert.ToSingle(this.method_79(attribute2.Value));
                            break;

                        case 2:
                            class2.color_0 = Class1007.smethod_0(attribute2.Value);
                            break;

                        case 3:
                            this.bool_5 = true;
                            attribute = attribute2;
                            break;

                        case 4:
                            Convert.ToInt32(attribute2.Value);
                            break;

                        case 5:
                            Convert.ToInt32(attribute2.Value);
                            break;

                        case 6:
                            this.method_3().method_84(this.method_149(attribute2.Value));
                            break;
                    }
                }
            }
            continue;
        Label_015B:
            str = attribute2.Value;
        }
        string str2 = this.class298_0.method_5(A_0);
        if (!string.IsNullOrEmpty(str))
        {
            str2 = str2 + string.Format(BookmarkStart.b("䄵儷帹䠻嘽稿扁㽃癅㕇", num), str);
        }
        this.method_139(attribute, str2, A_1, class2);
        if (((A_1.OwnerRow != null) && A_1.CellFormat.BackColor.IsEmpty) && !A_1.OwnerRow.RowFormat.BackColor.IsEmpty)
        {
            A_1.CellFormat.BackColor = A_1.OwnerRow.RowFormat.BackColor;
        }
        class2.method_4(cellFormat);
    }

    private string method_137(int A_0)
    {
        int num = 0x12;
        if ((this.list_0 != null) || (A_0 <= this.list_0.Count))
        {
            Dictionary<string, string> dictionary = this.list_0[A_0];
            if (dictionary.ContainsKey(BookmarkStart.b("伷匹堻䨽⠿", num)))
            {
                string input = dictionary[BookmarkStart.b("伷匹堻䨽⠿", num)];
                Match match = this.regex_2.Match(input);
                if (match.Success)
                {
                    return string.Format(BookmarkStart.b("䌷ਹ䄻丽㠿", num), match.Groups[1].Value);
                }
            }
        }
        return null;
    }

    private string method_138(TableCell A_0, int A_1, Class749 A_2)
    {
        int num = 14;
        string str = null;
        if ((this.list_0 != null) && (A_0.HTMLColIndex < this.list_0.Count))
        {
            Dictionary<string, string> dictionary = this.list_0[A_0.HTMLColIndex];
            foreach (string str2 in dictionary.Keys)
            {
                string str3 = dictionary[str2];
                if (str2 == BookmarkStart.b("䜳䈵䄷嘹夻", num))
                {
                    str = str + string.Format(BookmarkStart.b("伳ص䔷Ĺ", num), str3);
                }
                else
                {
                    str = str + string.Format(BookmarkStart.b("伳ص䔷9䜻༽㴿祁", num), str2, str3);
                }
            }
        }
        return str;
    }

    private void method_139(XmlAttribute A_0, string A_1, TableCell A_2, Class752 A_3)
    {
        int num = 14;
        string str = A_1;
        if ((A_0 != null) && (A_0.Name.ToLower() == BookmarkStart.b("䜳䈵䄷嘹夻", num)))
        {
            str = (str.EndsWith(BookmarkStart.b("༳", num)) ? str : (str + BookmarkStart.b("༳", num))) + A_0.Value;
        }
        if (!string.IsNullOrEmpty(str) && ((str = str.Trim()).Length != 0))
        {
            Class751 class2 = this.method_3();
            this.bool_5 = true;
            class2.class752_0 = new Class752(null);
            CellFormat cellFormat = A_2.CellFormat;
            string[] strArray = str.Split(new char[] { ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            char[] trimChars = new char[] { ' ' };
            int index = 0;
            int length = strArray.Length;
            while (index < (length - 1))
            {
                string[] strArray2;
                string str3 = strArray[index].ToLower().Trim();
                string str2 = strArray[index + 1].ToLower().Trim();
                if (str2.ToLower().EndsWith(BookmarkStart.b("ᔳ張唷䨹医䰽㐿⍁⩃㉅", num)))
                {
                    str2 = str2.ToLower().Replace(BookmarkStart.b("ᔳ張唷䨹医䰽㐿⍁⩃㉅", num), string.Empty).TrimEnd(trimChars);
                }
                A_3.method_1(str3, str2);
                string key = str3.ToLower();
                if (key != null)
                {
                    int num5;
                    if (Class1160.dictionary_136 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                        dictionary1.Add(BookmarkStart.b("䐳圵尷帹唻倽✿", num), 0);
                        dictionary1.Add(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅敇⥉⍋≍㽏⁑", num), 1);
                        dictionary1.Add(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", num), 2);
                        dictionary1.Add(BookmarkStart.b("圳夵吷唹主", num), 3);
                        dictionary1.Add(BookmarkStart.b("䌳張尷丹吻", num), 4);
                        dictionary1.Add(BookmarkStart.b("尳匵儷崹吻䨽", num), 5);
                        dictionary1.Add(BookmarkStart.b("䈳圵吷匹嬻倽", num), 6);
                        dictionary1.Add(BookmarkStart.b("䈳匵䨷丹唻崽ℿ⹁楃❅⑇⍉⭋⁍", num), 7);
                        dictionary1.Add(BookmarkStart.b("䀳匵䀷丹ᄻ弽ⰿ⭁⍃⡅", num), 8);
                        dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ䴽⤿㡁⅃", num), 9);
                        dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ堽ℿ⽁ⵃ⩅ㅇ", num), 10);
                        dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ䴽㐿㭁⡃⍅", num), 11);
                        dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ䤽┿⭁⍃⹅㱇", num), 12);
                        dictionary1.Add(BookmarkStart.b("䀳匵䀷丹ᄻ䨽㈿⍁⩃㕅⹇╉㹋⍍", num), 13);
                        dictionary1.Add(BookmarkStart.b("䐳圵尷帹唻倽✿潁⡃⍅⹇㹉", num), 14);
                        dictionary1.Add(BookmarkStart.b("䐳圵尷帹唻倽✿潁㙃⽅⽇≉㡋", num), 15);
                        dictionary1.Add(BookmarkStart.b("䐳圵尷帹唻倽✿潁ぃ⥅㡇", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䐳圵尷帹唻倽✿潁♃⥅㱇㹉⍋⍍", num), 0x11);
                        Class1160.dictionary_136 = dictionary1;
                    }
                    if (Class1160.dictionary_136.TryGetValue(key, out num5))
                    {
                        switch (num5)
                        {
                            case 0:
                            {
                                strArray2 = str2.Split(trimChars);
                                int num3 = strArray2.Length;
                                cellFormat.SamePaddingsAsTable = false;
                                switch (num3)
                                {
                                    case 1:
                                        goto Label_035A;

                                    case 2:
                                        goto Label_037A;

                                    case 3:
                                        goto Label_03D7;

                                    case 4:
                                        goto Label_043E;
                                }
                                break;
                            }
                            case 1:
                            {
                                Color color = Class1007.smethod_0(str2);
                                if (!color.IsEmpty && (color.A != 0))
                                {
                                    cellFormat.BackColor = Class1007.smethod_0(str2);
                                }
                                break;
                            }
                            case 2:
                                this.method_87(cellFormat, str2);
                                break;

                            case 3:
                                class2.method_52(Class1007.smethod_0(str2));
                                break;

                            case 4:
                                if (!(str2.ToLower() == BookmarkStart.b("唳䌵䰷唹", num)))
                                {
                                    goto Label_052A;
                                }
                                A_2.CellFormat.IsAutoResized = true;
                                break;

                            case 5:
                            {
                                TableRow owner = A_2.Owner as TableRow;
                                owner.HeightType = TableRowHeightType.AtLeast;
                                owner.Height = Convert.ToSingle(this.method_79(str2));
                                break;
                            }
                            case 6:
                            case 7:
                                A_2.CellFormat.VerticalAlignment = this.method_148(str2);
                                break;

                            case 8:
                                class2.method_84(this.method_149(str2));
                                break;

                            case 9:
                                if (!(str2 == BookmarkStart.b("䜳嬵夷嘹倻嬽㈿", num)))
                                {
                                    goto Label_0659;
                                }
                                class2.method_68(10f);
                                break;

                            case 10:
                                class2.method_56(str2);
                                break;

                            case 11:
                                goto Label_067D;

                            case 12:
                                class2.method_41(true);
                                break;

                            case 13:
                                if (str2.ToLower() == BookmarkStart.b("䄳䘵䠷弹主崽ℿㅁ⅃", num))
                                {
                                    class2.method_80(true);
                                }
                                break;

                            case 14:
                                goto Label_06FF;

                            case 15:
                                goto Label_072A;

                            case 0x10:
                                goto Label_0755;

                            case 0x11:
                                goto Label_0780;
                        }
                    }
                }
                goto Label_07A9;
            Label_035A:
                cellFormat.Paddings.All = Convert.ToSingle(this.method_79(strArray2[0]));
                goto Label_07A9;
            Label_037A:
                cellFormat.Paddings.Top = cellFormat.Paddings.Bottom = Convert.ToSingle(this.method_79(strArray2[0]));
                cellFormat.Paddings.Left = cellFormat.Paddings.Right = Convert.ToSingle(this.method_79(strArray2[1]));
                goto Label_07A9;
            Label_03D7:
                cellFormat.Paddings.Top = Convert.ToSingle(this.method_79(strArray2[0]));
                cellFormat.Paddings.Left = cellFormat.Paddings.Right = Convert.ToSingle(this.method_79(strArray2[1]));
                cellFormat.Paddings.Bottom = Convert.ToSingle(this.method_79(strArray2[2]));
                goto Label_07A9;
            Label_043E:
                cellFormat.Paddings.Top = Convert.ToSingle(this.method_79(strArray2[0]));
                cellFormat.Paddings.Right = Convert.ToSingle(this.method_79(strArray2[1]));
                cellFormat.Paddings.Bottom = Convert.ToSingle(this.method_79(strArray2[2]));
                cellFormat.Paddings.Left = Convert.ToSingle(this.method_79(strArray2[3]));
                goto Label_07A9;
            Label_052A:
                if (str2.ToLower().EndsWith(BookmarkStart.b("ᄳ", num)))
                {
                    A_2.WidthType = FtsWidth.Percentage;
                    A_2.Width = Convert.ToSingle(str2.ToLower().Replace(BookmarkStart.b("ᄳ", num), string.Empty));
                    A_2.CellFormat.IsAutoResized = false;
                    (A_2.Owner.Owner as Table).TableFormat.IsAutoResized = false;
                }
                else
                {
                    A_2.Width = Convert.ToSingle(this.method_79(str2));
                    A_2.WidthType = FtsWidth.Point;
                    A_2.CellFormat.IsAutoResized = false;
                    (A_2.Owner.Owner as Table).TableFormat.IsAutoResized = false;
                }
                goto Label_07A9;
            Label_0659:
                class2.method_68(this.method_99(str2, class2.method_67()));
                goto Label_07A9;
            Label_067D:
                if ((str2 == BookmarkStart.b("崳䈵夷嘹唻崽", num)) || (str2 == BookmarkStart.b("嬳吵吷匹䴻䬽┿", num)))
                {
                    class2.method_43(true);
                }
                if (str2 == BookmarkStart.b("䜳䈵䨷匹圻嬽", num))
                {
                    class2.method_48(true);
                }
                goto Label_07A9;
            Label_06FF:
                if (cellFormat.SamePaddingsAsTable)
                {
                    cellFormat.SamePaddingsAsTable = false;
                }
                cellFormat.Paddings.Left = Convert.ToSingle(this.method_79(str2));
                goto Label_07A9;
            Label_072A:
                if (cellFormat.SamePaddingsAsTable)
                {
                    cellFormat.SamePaddingsAsTable = false;
                }
                cellFormat.Paddings.Right = Convert.ToSingle(this.method_79(str2));
                goto Label_07A9;
            Label_0755:
                if (cellFormat.SamePaddingsAsTable)
                {
                    cellFormat.SamePaddingsAsTable = false;
                }
                cellFormat.Paddings.Top = Convert.ToSingle(this.method_79(str2));
                goto Label_07A9;
            Label_0780:
                if (cellFormat.SamePaddingsAsTable)
                {
                    cellFormat.SamePaddingsAsTable = false;
                }
                cellFormat.Paddings.Bottom = Convert.ToSingle(this.method_79(str2));
            Label_07A9:
                index += 2;
            }
        }
    }

    private string method_14(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ጴ儶嘸䤺尼匾ⵀ硂", 15), BookmarkStart.b("ጴᐶĸ఺഼ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䜶堸䤺䤼о", 15), BookmarkStart.b("ጴᐶĸ఺഼ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ制䄸刺丼䬾穀", 15), BookmarkStart.b("ጴᐶĸ఺഼࠾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ制吸䬺䤼䘾穀", 15), BookmarkStart.b("ጴᐶĸ఺഼ؾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ夶堸夺儼帾穀", 15), BookmarkStart.b("ጴᐶĸ఺఼฾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ帶䨸刺匼о", 15), BookmarkStart.b("ጴᐶĸ఺఼ാ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ夶嘸伺吼儾穀", 15), BookmarkStart.b("ጴᐶĸ఺఼ా穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ夶倸:", 15), BookmarkStart.b("ጴᐶĸ఺఼ਾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䜶䬸吺夼о", 15), BookmarkStart.b("ጴᐶĸ఺఼ؾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶䰸嘺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺༼฾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ娶倸唺䠼䰾穀", 15), BookmarkStart.b("ጴᐶĸ఺༼ാ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嬶嘸䰺尼䰾㕀硂", 15), BookmarkStart.b("ጴᐶĸ఺༼࠾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䔶堸强吼尾穀", 15), BookmarkStart.b("ጴᐶĸ఺฼༾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䜶䬸吺䴼о", 15), BookmarkStart.b("ጴᐶĸ఺฼ా穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ帶圸崺吼儾穀", 15), BookmarkStart.b("ጴᐶĸ఺฼ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嘶圸尺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺฼ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嘶圸强ؼ", 15), BookmarkStart.b("ጴᐶĸ఺़ా穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ堶䬸:", 15), BookmarkStart.b("ጴᐶĸ఺़ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ吶堸䬺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺़ਾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ吶䰸䬺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺़ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ帶圸伺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺़࠾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䌶儸帺似娾畀硂", 15), BookmarkStart.b("ጴᐶĸ఺࠼ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶倸嘺ؼ", 15), BookmarkStart.b("ጴᐶĸ఺଼ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ吶嘸唺娼о", 15), BookmarkStart.b("ጴᐶĸ఺਼ా穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嘶䨸䈺值伾穀", 15), BookmarkStart.b("ጴᐶĸ఺਼ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ夶尸:", 15), BookmarkStart.b("ጴᐶĸ഼̺༾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ制䠸为吼䤾穀", 15), BookmarkStart.b("ጴᐶĸ഼̺฾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ嬶尸:", 15), BookmarkStart.b("ጴᐶĸ഼̺ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ倶尸:", 15), BookmarkStart.b("ጴᐶĸ഼̺ਾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶䰸夺ؼ", 15), BookmarkStart.b("ጴᐶĸ̺฼ା穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶䰸䬺ؼ", 15), BookmarkStart.b("ጴᐶĸ̺฼ਾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ夶䨸为弼о", 15), BookmarkStart.b("ጴᐶĸ̺฼ा穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶䰸夺堼о", 15), BookmarkStart.b("ጴᐶĸ̺฼ܾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶䰸䬺堼о", 15), BookmarkStart.b("ጴᐶĸ̺฼ؾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ堶䤸场䠼䰾穀", 15), BookmarkStart.b("ጴᐶĸ̺࠼ా穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ堶䴸刺值娾㉀硂", 15), BookmarkStart.b("ጴᐶĸ̺࠼ਾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䜶尸䤺䴼о", 15), BookmarkStart.b("ጴᐶĸ଼̺ؾ穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ䐶崸吺䤼о", 15), BookmarkStart.b("ጴᐶĸȺ഼฾穀", 15));
        A_0 = A_0.Replace(BookmarkStart.b("ጴ儶䬸娺丼匾穀", 15), BookmarkStart.b("ጴᐶĸऺ଼༾穀", 15));
        return A_0;
    }

    private void method_140(XmlNode A_0, TableRow A_1, Class752 A_2)
    {
        int num = 14;
        if (this.stack_11.Count > 0)
        {
            A_1.RowFormat.BackColor = this.stack_11.Pop();
        }
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str = attribute.Name.ToLower();
            if (str != null)
            {
                if (str != BookmarkStart.b("尳匵儷崹吻䨽", num))
                {
                    if (str != BookmarkStart.b("唳娵儷崹刻", num))
                    {
                        if (str == BookmarkStart.b("䜳䈵䄷嘹夻", num))
                        {
                            string[] strArray2 = attribute.Value.ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            if (strArray2.Length > 0)
                            {
                                foreach (string str2 in strArray2)
                                {
                                    string str3;
                                    string[] strArray = str2.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                    if ((strArray.Length == 2) && ((str3 = strArray[0].Trim()) != null))
                                    {
                                        int num3;
                                        if (Class1160.dictionary_137 == null)
                                        {
                                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                                            dictionary1.Add(BookmarkStart.b("圳夵吷唹主", num), 0);
                                            dictionary1.Add(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅敇⥉⍋≍㽏⁑", num), 1);
                                            dictionary1.Add(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", num), 2);
                                            dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ䤽┿⭁⍃⹅㱇", num), 3);
                                            dictionary1.Add(BookmarkStart.b("倳張䬷䨹倻弽㤿", num), 4);
                                            dictionary1.Add(BookmarkStart.b("䈳匵䨷丹唻崽ℿ⹁楃❅⑇⍉⭋⁍", num), 5);
                                            dictionary1.Add(BookmarkStart.b("䀳匵䀷丹ᄻ弽ⰿ⭁⍃⡅", num), 6);
                                            dictionary1.Add(BookmarkStart.b("䀳匵䀷丹ᄻ䨽㈿⍁⩃㕅⹇╉㹋⍍", num), 7);
                                            dictionary1.Add(BookmarkStart.b("嘳夵䨷帹夻䰽", num), 8);
                                            dictionary1.Add(BookmarkStart.b("尳匵儷崹吻䨽", num), 9);
                                            dictionary1.Add(BookmarkStart.b("嬳䀵崷䠹娻刽⼿㕁", num), 10);
                                            dictionary1.Add(BookmarkStart.b("刳夵嘷丹ᄻ䴽⤿㡁⅃", num), 11);
                                            Class1160.dictionary_137 = dictionary1;
                                        }
                                        if (Class1160.dictionary_137.TryGetValue(str3, out num3))
                                        {
                                            switch (num3)
                                            {
                                                case 0:
                                                    this.method_3().method_52(Class1007.smethod_0(strArray[1]));
                                                    break;

                                                case 1:
                                                    this.stack_11.Push(A_1.RowFormat.BackColor);
                                                    A_1.RowFormat.BackColor = Class1007.smethod_0(strArray[1]);
                                                    break;

                                                case 2:
                                                    this.method_88(A_1.RowFormat, strArray[1]);
                                                    break;

                                                case 3:
                                                    string str4;
                                                    if (((str4 = strArray[1]) != null) && (str4 == BookmarkStart.b("嘳夵吷帹", num)))
                                                    {
                                                        this.method_3().method_41(true);
                                                    }
                                                    break;

                                                case 4:
                                                    if (strArray[1] == BookmarkStart.b("娳夵嘷弹", num))
                                                    {
                                                        A_1.Hidden = true;
                                                    }
                                                    break;

                                                case 5:
                                                    this.verticalAlignment_0 = this.method_148(strArray[1]);
                                                    break;

                                                case 6:
                                                    this.method_3().method_84(this.method_149(strArray[1]));
                                                    break;

                                                case 7:
                                                    if (strArray[1].ToLower() == BookmarkStart.b("䄳䘵䠷弹主崽ℿㅁ⅃", num))
                                                    {
                                                        this.method_3().method_80(true);
                                                    }
                                                    break;

                                                case 8:
                                                    this.method_146(strArray[0], strArray[1], ref A_2.color_0, ref A_2.borderStyle_0, ref A_2.float_0);
                                                    break;

                                                case 9:
                                                    A_1.Height = Convert.ToSingle(this.method_79(strArray[1]));
                                                    break;

                                                case 10:
                                                    if (strArray[1].ToLower() == BookmarkStart.b("尳張尷帹夻倽", num))
                                                    {
                                                        A_1.HeightType = TableRowHeightType.Exactly;
                                                    }
                                                    break;

                                                case 11:
                                                {
                                                    Regex regex = new Regex(BookmarkStart.b("栳᜵ጷ昹᰻ᐽ⤿⽁㑃⥅㩇㹉ⵋ⁍⑏", num), RegexOptions.IgnoreCase);
                                                    strArray[1] = regex.Replace(strArray[1], string.Empty).Trim();
                                                    this.method_3().method_68(this.method_99(strArray[1], this.method_3().method_67()));
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        this.method_3().method_84(this.method_149(attribute.Value));
                    }
                }
                else
                {
                    A_1.Height = Convert.ToSingle(this.method_79(attribute.Value));
                    A_1.HeightType = TableRowHeightType.AtLeast;
                }
            }
        }
        this.method_141(this.class298_0.method_5(A_0), A_2, A_1);
    }

    private void method_141(string A_0, Class752 A_1, TableRow A_2)
    {
        int num = 7;
        if (!string.IsNullOrEmpty(A_0))
        {
            string[] strArray = A_0.Split(new char[] { ';', ':' });
            int index = 0;
            int length = strArray.Length;
            while (index < (length - 1))
            {
                string str3;
                string str = strArray[index].ToLower().Trim();
                string str2 = strArray[index + 1].ToLower().Trim();
                if ((str2 != BookmarkStart.b("䐬䄮夰嘲䜴帶䴸", num)) && ((str3 = str.ToLower()) != null))
                {
                    int num4;
                    if (Class1160.dictionary_138 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                        dictionary1.Add(BookmarkStart.b("伬䀮䌰圲倴䔶", num), 0);
                        dictionary1.Add(BookmarkStart.b("伬䀮䌰圲倴䔶ᐸ场堼夾㕀", num), 1);
                        dictionary1.Add(BookmarkStart.b("伬䀮䌰圲倴䔶ᐸ䤺吼堾⥀㝂", num), 2);
                        dictionary1.Add(BookmarkStart.b("伬䀮䌰圲倴䔶ᐸ伺刼伾", num), 3);
                        dictionary1.Add(BookmarkStart.b("伬䀮䌰圲倴䔶ᐸ夺刼䬾㕀ⱂ⡄", num), 4);
                        dictionary1.Add(BookmarkStart.b("䔬䨮堰吲崴䌶", num), 5);
                        dictionary1.Add(BookmarkStart.b("䈬央吰䄲匴嬶嘸䰺", num), 6);
                        Class1160.dictionary_138 = dictionary1;
                    }
                    if (Class1160.dictionary_138.TryGetValue(str3, out num4))
                    {
                        switch (num4)
                        {
                            case 0:
                                this.method_146(str, str2, ref A_1.color_0, ref A_1.borderStyle_0, ref A_1.float_0);
                                break;

                            case 1:
                                this.method_146(str, str2, ref A_1.color_3, ref A_1.borderStyle_3, ref A_1.float_3);
                                break;

                            case 2:
                                this.method_146(str, str2, ref A_1.color_4, ref A_1.borderStyle_4, ref A_1.float_4);
                                break;

                            case 3:
                                this.method_146(str, str2, ref A_1.color_1, ref A_1.borderStyle_1, ref A_1.float_1);
                                break;

                            case 4:
                                this.method_146(str, str2, ref A_1.color_2, ref A_1.borderStyle_2, ref A_1.float_2);
                                break;

                            case 5:
                                A_2.Height = Convert.ToSingle(this.method_79(str2));
                                break;

                            case 6:
                                if (str2 == BookmarkStart.b("䔬䘮唰圲倴夶", num))
                                {
                                    A_2.HeightType = TableRowHeightType.Exactly;
                                }
                                break;
                        }
                    }
                }
                index += 2;
            }
        }
    }

    private void method_142(XmlNode A_0, Class749 A_1, Class752 A_2)
    {
        int num = 15;
        Table table = (this.stack_22.Count > 0) ? this.stack_22.Peek() : null;
        if (table != null)
        {
            RowFormat tableFormat = table.TableFormat;
            XmlAttribute attribute = null;
            bool flag = false;
            Color empty = Color.Empty;
            string str2 = string.Empty;
            if (A_0.ParentNode.Name == BookmarkStart.b("儴帶伸", num))
            {
                if (A_0.ParentNode.ChildNodes.Count == 1)
                {
                    str2 = this.method_97(A_0.ParentNode, BookmarkStart.b("吴嬶倸尺匼", num));
                }
                if (!string.IsNullOrEmpty(str2))
                {
                    string str = str2.ToLower();
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("嘴制圸伺堼䴾", num))
                        {
                            if (!(str == BookmarkStart.b("䜴帶常区䤼", num)))
                            {
                                if (str == BookmarkStart.b("头制弸伺", num))
                                {
                                    table.TableFormat.HorizontalAlignment = RowAlignment.Left;
                                }
                            }
                            else
                            {
                                table.TableFormat.HorizontalAlignment = RowAlignment.Right;
                            }
                        }
                        else
                        {
                            table.TableFormat.HorizontalAlignment = RowAlignment.Center;
                        }
                    }
                    table.TableFormat.method_53(false);
                }
            }
            foreach (XmlAttribute attribute2 in A_0.Attributes)
            {
                string key = attribute2.Name.ToLower();
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_139 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                        dictionary1.Add(BookmarkStart.b("圴堶䬸强堼䴾", num), 0);
                        dictionary1.Add(BookmarkStart.b("圴堶䬸强堼䴾≀ⱂ⥄⡆㭈", num), 1);
                        dictionary1.Add(BookmarkStart.b("嘴制唸场䴼帾╀❂ⱄ⥆⹈", num), 2);
                        dictionary1.Add(BookmarkStart.b("嘴制唸场丼伾⁀⁂ⱄ⥆⹈", num), 3);
                        dictionary1.Add(BookmarkStart.b("䘴䌶䀸场堼", num), 4);
                        dictionary1.Add(BookmarkStart.b("圴嘶娸债娼䴾⹀㙂⭄⍆", num), 5);
                        dictionary1.Add(BookmarkStart.b("圴嘶娸债娼䴾⹀㙂⭄⍆摈⡊≌⍎㹐⅒", num), 6);
                        dictionary1.Add(BookmarkStart.b("圴倶娸吺儼倾㍀", num), 7);
                        dictionary1.Add(BookmarkStart.b("吴嬶倸尺匼", num), 8);
                        dictionary1.Add(BookmarkStart.b("䈴帶崸伺唼", num), 9);
                        dictionary1.Add(BookmarkStart.b("儴帶䬸", num), 10);
                        Class1160.dictionary_139 = dictionary1;
                    }
                    if (Class1160.dictionary_139.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                A_2.method_1(attribute2.Name, attribute2.Value);
                                flag = true;
                                if (A_2.float_0 != 0f)
                                {
                                    goto Label_02B9;
                                }
                                A_2.float_0 = -1f;
                                A_2.borderStyle_0 = BorderStyle.None;
                                A_2.color_0 = Color.Empty;
                                break;

                            case 1:
                                empty = Class1007.smethod_0(attribute2.Value);
                                break;

                            case 2:
                                tableFormat.Paddings.All = Convert.ToSingle(this.method_79(attribute2.Value));
                                break;

                            case 3:
                                tableFormat.CellSpacingEx = Convert.ToSingle(this.method_79(attribute2.Value));
                                break;

                            case 4:
                                attribute = attribute2;
                                break;

                            case 5:
                                this.method_88(tableFormat, attribute2.Value);
                                break;

                            case 6:
                            case 7:
                                tableFormat.BackColor = Class1007.smethod_0(attribute2.Value);
                                this.method_3().method_54(tableFormat.BackColor);
                                break;

                            case 8:
                            {
                                string str3 = attribute2.Value.ToLower();
                                if (str3 != null)
                                {
                                    if (str3 == BookmarkStart.b("嘴制圸伺堼䴾", num))
                                    {
                                        goto Label_03E1;
                                    }
                                    if (str3 == BookmarkStart.b("䜴帶常区䤼", num))
                                    {
                                        goto Label_03D0;
                                    }
                                    if (str3 == BookmarkStart.b("头制弸伺", num))
                                    {
                                        table.TableFormat.HorizontalAlignment = RowAlignment.Left;
                                    }
                                }
                                break;
                            }
                            case 9:
                                if (!(attribute2.Value.ToLower() == BookmarkStart.b("吴䈶䴸吺", num)))
                                {
                                    goto Label_043D;
                                }
                                table.TableFormat.IsAutoResized = true;
                                table.PreferredTableWidth.method_52(FtsWidth.Auto);
                                table.PreferredTableWidth.method_50(0f);
                                break;

                            case 10:
                                if (!(attribute2.Value.ToLower() == BookmarkStart.b("䜴䌶唸", num)))
                                {
                                    goto Label_0533;
                                }
                                table.TableFormat.Bidi = true;
                                this.method_3().method_82(true);
                                break;
                        }
                    }
                }
                continue;
            Label_02B9:
                if (A_2.borderStyle_0 == BorderStyle.None)
                {
                    A_2.borderStyle_0 = BorderStyle.Outset;
                }
                continue;
            Label_03D0:
                table.TableFormat.HorizontalAlignment = RowAlignment.Right;
                continue;
            Label_03E1:
                table.TableFormat.HorizontalAlignment = RowAlignment.Center;
                continue;
            Label_043D:
                if (attribute2.Value.Contains(BookmarkStart.b("ဴ", num)))
                {
                    table.PreferredTableWidth.method_52(FtsWidth.Percentage);
                    table.PreferredTableWidth.method_50(Convert.ToSingle(attribute2.Value.Replace(BookmarkStart.b("ဴ", num), string.Empty)));
                    table.TableFormat.IsAutoResized = false;
                    this.method_144(table);
                }
                else
                {
                    A_1.float_1 = Convert.ToSingle(this.method_79(attribute2.Value));
                    table.PreferredTableWidth.method_52(FtsWidth.Point);
                    table.PreferredTableWidth.method_50(Convert.ToSingle(this.method_79(attribute2.Value)) * 20f);
                    table.TableFormat.IsAutoResized = false;
                }
                continue;
            Label_0533:
                if (attribute2.Value.ToLower() == BookmarkStart.b("头䌶䬸", num))
                {
                    table.TableFormat.Bidi = false;
                    this.method_3().method_82(false);
                }
            }
            if (!empty.IsEmpty)
            {
                A_2.color_0 = empty;
                if ((A_2.float_0 == -1f) && !flag)
                {
                    tableFormat.Borders.LineWidth = 3f;
                    tableFormat.Borders.BorderType = BorderStyle.Single;
                }
                else if (A_2.float_0 != -1f)
                {
                    A_2.borderStyle_0 = BorderStyle.Single;
                }
            }
            string str5 = this.class298_0.method_5(A_0);
            this.method_143(attribute, str5, A_2, A_1);
            A_2.method_3(tableFormat);
        }
    }

    private void method_143(XmlAttribute A_0, string A_1, Class752 A_2, Class749 A_3)
    {
        int num = 9;
        string str = A_1;
        if ((A_0 != null) && (A_0.Name.ToLower() == BookmarkStart.b("尮䔰䨲头制", num)))
        {
            str = str + A_0.Value;
        }
        if (!string.IsNullOrEmpty(str) && ((str = str.Trim()).Length != 0))
        {
            Table table = (this.stack_22.Count > 0) ? this.stack_22.Peek() : null;
            RowFormat tableFormat = table.TableFormat;
            string[] strArray2 = str.Split(new char[] { ';', ':' });
            float num6 = -1f;
            Regex regex = new Regex(BookmarkStart.b("献ူᠲ椴᜶ጸ刺值伾⹀ㅂㅄ♆❈㽊", num), RegexOptions.IgnoreCase);
            int index = 0;
            int length = strArray2.Length;
            while (index < (length - 1))
            {
                string str3 = strArray2[index].ToLower().Trim();
                string str2 = strArray2[index + 1].ToLower().Trim();
                if (str2 == BookmarkStart.b("䘮弰嬲倴䔶倸伺", num))
                {
                    goto Label_0A9A;
                }
                string key = str3;
                if (key != null)
                {
                    int num10;
                    if (Class1160.dictionary_140 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x13);
                        dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀", num), 0);
                        dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀湂♄⡆╈⑊㽌", num), 1);
                        dictionary1.Add(BookmarkStart.b("䴮嘰倲娴嬶嘸䤺", num), 2);
                        dictionary1.Add(BookmarkStart.b("堮堰圲䄴弶", num), 3);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䨼嘾╀㝂ⵄ", num), 4);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ帼倾ⵀⱂ㝄", num), 5);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ弼倾㕀㝂⩄⩆", num), 6);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䤼倾ㅀ", num), 7);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ儼娾❀㝂", num), 8);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ似嘾♀⭂ㅄ", num), 9);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ丼䬾㡀⽂⁄", num), 10);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸", num), 11);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ帼倾ⵀ⽂⑄㝆㩈⹊", num), 12);
                        dictionary1.Add(BookmarkStart.b("䬮堰䀲䔴嬶堸䈺", num), 13);
                        dictionary1.Add(BookmarkStart.b("䰮帰弲娴䔶", num), 14);
                        dictionary1.Add(BookmarkStart.b("䤮帰崲䄴ᨶ䨸刺䜼娾", num), 15);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ堸场吼堾⽀", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ儼娾❀㝂", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ䴸䤺尼儾㉀╂⩄㕆⑈", num), 0x12);
                        Class1160.dictionary_140 = dictionary1;
                    }
                    if (Class1160.dictionary_140.TryGetValue(key, out num10))
                    {
                        switch (num10)
                        {
                            case 0:
                                this.method_88(tableFormat, str2);
                                goto Label_0A9A;

                            case 1:
                            case 2:
                                tableFormat.BackColor = Class1007.smethod_0(str2);
                                this.method_3().method_54(tableFormat.BackColor);
                                goto Label_0A9A;

                            case 3:
                                if (!(str2.ToLower() == BookmarkStart.b("丮䐰䜲娴", num)))
                                {
                                    goto Label_0365;
                                }
                                table.TableFormat.IsAutoResized = true;
                                table.PreferredTableWidth.method_52(FtsWidth.Auto);
                                table.PreferredTableWidth.method_50(0f);
                                goto Label_0A9A;

                            case 4:
                                num6 = Convert.ToSingle(this.method_79(str2));
                                if (A_2.float_0 == -1f)
                                {
                                    goto Label_0449;
                                }
                                A_2.float_0 = num6;
                                tableFormat.Borders.LineWidth = num6;
                                goto Label_0A9A;

                            case 5:
                                A_2.color_0 = Class1007.smethod_0(str2);
                                tableFormat.Borders.Color = A_2.color_0;
                                goto Label_0A9A;

                            case 6:
                                this.method_145(str3, str2, tableFormat.Borders.Bottom);
                                goto Label_0A9A;

                            case 7:
                                this.method_145(str3, str2, tableFormat.Borders.Top);
                                goto Label_0A9A;

                            case 8:
                                this.method_145(str3, str2, tableFormat.Borders.Left);
                                goto Label_0A9A;

                            case 9:
                                this.method_145(str3, str2, tableFormat.Borders.Right);
                                goto Label_0A9A;

                            case 10:
                                goto Label_0500;

                            case 11:
                            {
                                this.method_145(str3, str2, tableFormat.Borders.Left);
                                this.method_145(str3, str2, tableFormat.Borders.Right);
                                this.method_145(str3, str2, tableFormat.Borders.Top);
                                this.method_145(str3, str2, tableFormat.Borders.Bottom);
                                A_2.color_3 = A_2.color_4 = A_2.color_1 = A_2.color_2 = tableFormat.Borders.Top.Color;
                                A_2.borderStyle_3 = A_2.borderStyle_4 = A_2.borderStyle_1 = A_2.borderStyle_2 = tableFormat.Borders.Top.BorderType;
                                if ((A_2.borderStyle_3 != BorderStyle.None) || (tableFormat.Borders.Top.LineWidth != 0f))
                                {
                                    goto Label_092E;
                                }
                                float num11 = -1f;
                                A_2.float_2 = -1f;
                                float num12 = -1f;
                                A_2.float_1 = num11;
                                float num13 = -1f;
                                A_2.float_4 = num12;
                                A_2.float_3 = num13;
                                goto Label_0965;
                            }
                            case 12:
                                if (str2 == BookmarkStart.b("䰮帰弲头嘶䤸䠺堼", num))
                                {
                                    tableFormat.CellSpacingEx = -1f;
                                }
                                goto Label_0A9A;

                            case 13:
                                if (str2 == BookmarkStart.b("䄮帰崲倴", num))
                                {
                                    tableFormat.Hidden = true;
                                }
                                goto Label_0A9A;

                            case 14:
                                this.method_3().method_52(Class1007.smethod_0(str2));
                                goto Label_0A9A;

                            case 15:
                                str2 = regex.Replace(str2, string.Empty).Trim();
                                this.method_3().method_68(this.method_99(str2, this.method_3().method_67()));
                                goto Label_0A9A;

                            case 0x10:
                                this.method_3().method_84(this.method_149(str2));
                                goto Label_0A9A;

                            case 0x11:
                            {
                                str2 = regex.Replace(str2, string.Empty).Trim();
                                float num14 = Convert.ToSingle(this.method_79(str2));
                                if (num14 != 0f)
                                {
                                    tableFormat.LeftIndent = num14;
                                }
                                goto Label_0A9A;
                            }
                            case 0x12:
                                if (str2.ToLower() == BookmarkStart.b("娮䄰䌲倴䔶娸娺丼娾", num))
                                {
                                    this.method_3().method_80(true);
                                }
                                goto Label_0A9A;
                        }
                    }
                }
                goto Label_0A90;
            Label_0365:
                if (str2.Contains(BookmarkStart.b("ਮ", num)))
                {
                    table.PreferredTableWidth.method_52(FtsWidth.Percentage);
                    table.PreferredTableWidth.method_50(Convert.ToSingle(str2.Replace(BookmarkStart.b("ਮ", num), string.Empty)));
                    table.TableFormat.IsAutoResized = false;
                    this.method_144(table);
                }
                else
                {
                    float num2 = Convert.ToSingle(this.method_79(str2));
                    A_3.float_1 = num2;
                    table.PreferredTableWidth.method_52(FtsWidth.Point);
                    table.PreferredTableWidth.method_50(num2 * 20f);
                    table.TableFormat.IsAutoResized = false;
                }
                goto Label_0A9A;
            Label_0449:
                if (tableFormat.Borders.Top.LineWidth != 0f)
                {
                    tableFormat.Borders.LineWidth = num6;
                }
                goto Label_0A9A;
            Label_0500:;
                string[] strArray = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (num6 == -1f)
                {
                    num6 = 3f;
                }
                if (((tableFormat.Borders.Top.LineWidth == tableFormat.Borders.Right.LineWidth) && (tableFormat.Borders.Right.LineWidth == tableFormat.Borders.Left.LineWidth)) && ((tableFormat.Borders.Left.LineWidth == tableFormat.Borders.Bottom.LineWidth) && (tableFormat.Borders.Bottom.LineWidth == 0f)))
                {
                    tableFormat.Borders.Top.LineWidth = tableFormat.Borders.Right.LineWidth = tableFormat.Borders.Bottom.LineWidth = tableFormat.Borders.Left.LineWidth = num6;
                }
                switch (strArray.Length)
                {
                    case 1:
                        tableFormat.Borders.Top.BorderType = tableFormat.Borders.Right.BorderType = tableFormat.Borders.Bottom.BorderType = tableFormat.Borders.Left.BorderType = this.method_93(strArray[0]);
                        break;

                    case 2:
                        tableFormat.Borders.Top.BorderType = tableFormat.Borders.Bottom.BorderType = this.method_93(strArray[0]);
                        tableFormat.Borders.Left.BorderType = tableFormat.Borders.Right.BorderType = this.method_93(strArray[1]);
                        break;

                    case 3:
                        tableFormat.Borders.Top.BorderType = this.method_93(strArray[0]);
                        tableFormat.Borders.Left.BorderType = tableFormat.Borders.Right.BorderType = this.method_93(strArray[1]);
                        tableFormat.Borders.Bottom.BorderType = this.method_93(strArray[2]);
                        break;

                    case 4:
                        tableFormat.Borders.Top.BorderType = this.method_93(strArray[0]);
                        tableFormat.Borders.Right.BorderType = this.method_93(strArray[1]);
                        tableFormat.Borders.Bottom.BorderType = this.method_93(strArray[2]);
                        tableFormat.Borders.Left.BorderType = this.method_93(strArray[3]);
                        break;
                }
                if (A_2.borderStyle_0 != BorderStyle.None)
                {
                    A_2.borderStyle_0 = BorderStyle.None;
                    A_2.borderStyle_3 = tableFormat.Borders.Left.BorderType;
                    A_2.borderStyle_4 = tableFormat.Borders.Right.BorderType;
                    A_2.borderStyle_1 = tableFormat.Borders.Top.BorderType;
                    A_2.borderStyle_2 = tableFormat.Borders.Bottom.BorderType;
                }
                goto Label_0A9A;
            Label_092E:
                A_2.float_3 = A_2.float_4 = A_2.float_1 = A_2.float_2 = tableFormat.Borders.Top.LineWidth;
            Label_0965:
                A_2.color_0 = Color.Empty;
                A_2.borderStyle_0 = BorderStyle.None;
                A_2.float_0 = -1f;
                goto Label_0A9A;
            Label_0A90:
                A_2.method_1(str3, str2);
            Label_0A9A:
                index += 2;
            }
        }
    }

    private void method_144(Table A_0)
    {
        Table ownerTable;
        for (Table table = A_0; table != null; table = ownerTable.IsInCell ? ownerTable : null)
        {
            if (!table.IsInCell)
            {
                break;
            }
            ownerTable = (table.Owner as TableCell).OwnerRow.OwnerTable;
            if ((ownerTable.PreferredTableWidth.method_51() == FtsWidth.Auto) || (ownerTable.PreferredTableWidth.method_51() == FtsWidth.None))
            {
                ownerTable.PreferredTableWidth.method_52(FtsWidth.Percentage);
                ownerTable.PreferredTableWidth.method_50(100f);
                ownerTable.TableFormat.IsAutoResized = false;
            }
        }
    }

    private void method_145(string A_0, string A_1, Border A_2)
    {
        int num = 4;
        string[] strArray2 = new string[] { BookmarkStart.b("丩䴫崭堯圱倳", 4), BookmarkStart.b("丩䌫娭䐯圱倳", 4), BookmarkStart.b("丩䌫嬭刯帱儳", 4), BookmarkStart.b("䴩師䄭弯䐱儳", 4), BookmarkStart.b("䌩䈫崭唯䘱", 4), BookmarkStart.b("䔩夫娭䌯圱䀳", 4), BookmarkStart.b("堩䔫䨭圯圱", 4), BookmarkStart.b("天䌫䈭夯嘱", 4), BookmarkStart.b("䈩䔫䨭启圱娳", 4), BookmarkStart.b("䐩䌫䀭唯", 4) };
        char[] separator = new char[] { ' ' };
        string[] strArray3 = A_1.Split(separator);
        for (int i = 0; i < strArray3.Length; i++)
        {
            if (strArray3[i].StartsWith(BookmarkStart.b("ऩ", num)))
            {
                A_2.Color = Class1007.smethod_0(strArray3[i]);
                continue;
            }
            if (strArray3[i].StartsWith(BookmarkStart.b("堩䬫䰭ᠯ", num)))
            {
                string str = string.Empty;
                while (i < strArray3.Length)
                {
                    str = str + strArray3[i];
                    if (strArray3[i].EndsWith(BookmarkStart.b("̩", num)))
                    {
                        break;
                    }
                    i++;
                }
                A_2.Color = Class1007.smethod_0(str);
                continue;
            }
            if (this.method_90(strArray3[i]))
            {
                A_2.LineWidth = this.method_91(strArray3[i]);
            }
            else
            {
                foreach (string str2 in strArray2)
                {
                    if (strArray3[i] == str2)
                    {
                        this.bool_4 = true;
                    }
                }
                if (this.bool_4)
                {
                    A_2.BorderType = this.method_93(strArray3[i]);
                    this.bool_4 = false;
                }
                else
                {
                    A_2.Color = Class1007.smethod_0(strArray3[i]);
                }
            }
        }
    }

    private void method_146(string A_0, string A_1, ref Color A_2, ref BorderStyle A_3, ref float A_4)
    {
        int num = 15;
        string[] strArray2 = new string[] { BookmarkStart.b("儴嘶䨸区堼嬾", 15), BookmarkStart.b("儴堶䴸伺堼嬾", 15), BookmarkStart.b("儴堶䰸夺儼娾", 15), BookmarkStart.b("刴䔶嘸吺䬼娾", 15), BookmarkStart.b("尴夶䨸帺䤼", 15), BookmarkStart.b("娴䈶䴸䠺堼䬾", 15), BookmarkStart.b("䜴帶崸尺堼", 15), BookmarkStart.b("䘴堶唸刺夼", 15), BookmarkStart.b("崴帶崸强堼儾", 15), BookmarkStart.b("嬴堶圸帺", 15) };
        char[] separator = new char[] { ' ' };
        string[] strArray3 = A_1.Split(separator);
        for (int i = 0; i < strArray3.Length; i++)
        {
            if (strArray3[i].StartsWith(BookmarkStart.b("ᘴ", num)))
            {
                A_2 = Class1007.smethod_0(strArray3[i]);
                continue;
            }
            if (strArray3[i].StartsWith(BookmarkStart.b("䜴倶嬸ጺ", num)))
            {
                string str = string.Empty;
                while (i < strArray3.Length)
                {
                    str = str + strArray3[i];
                    if (strArray3[i].EndsWith(BookmarkStart.b("ᰴ", num)))
                    {
                        break;
                    }
                    i++;
                }
                A_2 = Class1007.smethod_0(str);
                continue;
            }
            if (this.method_90(strArray3[i]))
            {
                A_4 = this.method_91(strArray3[i]);
                continue;
            }
            foreach (string str2 in strArray2)
            {
                if (strArray3[i] == str2)
                {
                    goto Label_01A3;
                }
            }
            goto Label_01AA;
        Label_01A3:
            this.bool_4 = true;
        Label_01AA:
            if (this.bool_4)
            {
                A_3 = this.method_93(strArray3[i]);
                this.bool_4 = false;
            }
            else
            {
                A_2 = Class1007.smethod_0(strArray3[i]);
            }
        }
        if (A_4 == 0f)
        {
            A_4 = -1f;
            A_3 = BorderStyle.None;
            A_2 = Color.Empty;
        }
    }

    private float method_147(string A_0)
    {
        if (A_0.EndsWith(BookmarkStart.b("䔴伶", 15)))
        {
            A_0 = A_0.Substring(0, A_0.Length - 2);
        }
        return PointsConverter.FromPixel(Convert.ToSingle(A_0));
    }

    private VerticalAlignment method_148(string A_0)
    {
        int num = 13;
        string str = A_0.ToLower();
        if (str != null)
        {
            if (str == BookmarkStart.b("䜲娴䜶", num))
            {
                return VerticalAlignment.Top;
            }
            if ((str == BookmarkStart.b("倲倴夶䴸帺似", num)) || (str == BookmarkStart.b("帲尴匶崸场堼", num)))
            {
                return VerticalAlignment.Middle;
            }
            if (str == BookmarkStart.b("儲娴䌶䴸吺值", num))
            {
                return VerticalAlignment.Bottom;
            }
        }
        return VerticalAlignment.Top;
    }

    private HorizontalAlignment method_149(string A_0)
    {
        int num = 8;
        string str = A_0.ToLower();
        if (str != null)
        {
            if (str == BookmarkStart.b("䴭唯就䀳匵䨷", num))
            {
                return HorizontalAlignment.Center;
            }
            if (str == BookmarkStart.b("尭夯唱尳䈵", num))
            {
                return HorizontalAlignment.Right;
            }
            if (str == BookmarkStart.b("䐭䔯䄱䀳張帷䌹", num))
            {
                return HorizontalAlignment.Justify;
            }
        }
        return HorizontalAlignment.Left;
    }

    private string method_15(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ဵ礷嘹䰻嘽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ഻̹ഽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ稷弹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ഻̹਽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ缷嬹儻匽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ഻̹ଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ簷弹倻䨽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ഻̹࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ紷䨹伻圽ⰿⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ഻̹ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ户弹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ഻̹ؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ紷丹崻Խ", 0x10), BookmarkStart.b("ဵᬷ഻̹ܽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ氷刹夻䨽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹฻฽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ焷唹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ̹฻༽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ猷嬹䰻丽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹฻ఽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ琷嬹儻尽␿⍁罃", 0x10), BookmarkStart.b("ဵᬷ̹฻ഽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ男伹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹฻਽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ瘷伹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹฻ଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ怷匹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹฻࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ眷圹唻崽㈿ⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ̹฻ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ样匹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹฻ؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ樷刹医Խ", 0x10), BookmarkStart.b("ဵᬷ̹฻ܽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ欷匹嬻匽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹༻༽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ氷嬹䤻Խ", 0x10), BookmarkStart.b("ဵᬷ̹༻ఽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ洷䨹伻圽ⰿⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ̹༻ഽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ样刹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹༻਽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ笷刹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹༻ଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ样䤹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹༻࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ眷圹夻夽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹༻ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ夷嘹䰻嘽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹࠻ଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ娷弹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ̹࠻࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ強嬹儻匽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹࠻ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ尷弹倻䨽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹࠻ؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ崷䨹伻圽ⰿⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ̹࠻ܽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䈷弹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ̹ऻ฽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ崷丹崻Խ", 0x10), BookmarkStart.b("ဵᬷ̹ऻ༽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䰷刹夻䨽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹ऻఽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ儷唹䠻弽笿", 0x10), BookmarkStart.b("ဵᬷ̹ऻഽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ匷嬹䰻丽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹ऻ਽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ吷嬹儻尽␿⍁罃", 0x10), BookmarkStart.b("ဵᬷ̹ऻଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ唷伹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹ऻ࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ嘷伹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹ऻऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䀷匹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹ऻؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ圷圹唻崽㈿ⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ̹ऻܽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䠷匹ܻ", 0x10), BookmarkStart.b("ဵᬷ̹਻฽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䨷刹医Խ", 0x10), BookmarkStart.b("ဵᬷ̹਻༽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䬷匹嬻匽ℿ⑁罃", 0x10), BookmarkStart.b("ဵᬷ̹਻ఽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䬷匹嬻匽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹਻ഽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䰷嬹䤻Խ", 0x10), BookmarkStart.b("ဵᬷ̹਻਽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䴷䨹伻圽ⰿⵁ⩃絅", 0x10), BookmarkStart.b("ဵᬷ̹਻ଽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䠷刹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹਻࠽笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ嬷刹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹਻ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䠷䤹唻Խ", 0x10), BookmarkStart.b("ဵᬷ̹਻ؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ圷圹夻夽ℿ祁", 0x10), BookmarkStart.b("ဵᬷ̹਻ܽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䰷刹夻䨽ℿㅁ㵃⭅獇", 0x10), BookmarkStart.b("ဵᬷ̹଻ऽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䴷䨹伻圽⠿祁", 0x10), BookmarkStart.b("ဵᬷ̹଻ؽ笿", 0x10));
        A_0 = A_0.Replace(BookmarkStart.b("ဵ䠷匹䨻Խ", 0x10), BookmarkStart.b("ဵᬷ̹лఽ笿", 0x10));
        return A_0;
    }

    private string method_150(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        int index = 0;
        while (chArray[index] == ' ')
        {
            index++;
        }
        int startIndex = index;
        index = chArray.Length - 1;
        while (chArray[index] == ' ')
        {
            index--;
        }
        int num2 = index;
        return A_0.Substring(startIndex, (num2 - startIndex) + 1);
    }

    private int method_151(string A_0)
    {
        A_0 = A_0.ToUpper();
        char[] chArray = A_0.ToCharArray();
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        for (int i = chArray.Length - 1; i >= 0; i--)
        {
            if (chArray[i] == 'M')
            {
                num = 0x3e8;
            }
            else if (chArray[i] == 'D')
            {
                num = 500;
            }
            else if (chArray[i] == 'C')
            {
                num = 100;
            }
            else if (chArray[i] == 'L')
            {
                num = 50;
            }
            else if (chArray[i] == 'X')
            {
                num = 10;
            }
            else if (chArray[i] == 'V')
            {
                num = 5;
            }
            else if (chArray[i] == 'I')
            {
                num = 1;
            }
            else
            {
                num = 0;
            }
            if (num2 > num)
            {
                num3 = num2 - num;
            }
            else
            {
                num3 += num;
            }
            num2 = num;
        }
        return num3;
    }

    private void method_152()
    {
        this.bool_3 = false;
        this.bool_2 = false;
        this.int_0 = -1;
        this.stack_3 = null;
    }

    private string method_16(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ḷ甹礻刽⤿╁罃", 0x12), BookmarkStart.b("ḷ᤹༻ഽ砿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ唹夻刽⤿╁罃", 0x12), BookmarkStart.b("ḷ᤹༻ഽ礿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ椹弻弽㈿ⵁ⩃絅", 0x12), BookmarkStart.b("ḷ᤹༻ଽ爿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䤹弻弽㈿ⵁ⩃絅", 0x12), BookmarkStart.b("ḷ᤹༻ଽ猿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ挹䤻匽ⰿ祁", 0x12), BookmarkStart.b("ḷ᤹༻ऽ瘿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ尹刻儽☿祁", 0x12), BookmarkStart.b("ḷ᤹࠻฽爿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ夹唻䰽⌿祁", 0x12), BookmarkStart.b("ḷ᤹଻༽瀿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ丹唻刽␿❁罃", 0x12), BookmarkStart.b("ḷ᤹଻ഽ爿祁", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ弹刻䴽〿祁", 0x12), BookmarkStart.b("ḷ᤹л༽礿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ弹儻䴽〿祁", 0x12), BookmarkStart.b("ḷ᤹л༽礿睁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ丹吻圽⸿ㅁ㑃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ瀿獁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䀹䬻倽⨿祁", 0x12), BookmarkStart.b("ḷ᤹лఽ瀿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䀹䬻吽笿", 0x12), BookmarkStart.b("ḷ᤹лఽ瀿睁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹主匽笿", 0x12), BookmarkStart.b("ḷ᤹лఽ瀿瑁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹倻匽笿", 0x12), BookmarkStart.b("ḷ᤹лఽ瀿畁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ吹堻弽㌿⩁罃", 0x12), BookmarkStart.b("ḷ᤹лఽ焿獁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ圹堻弽㌿⩁罃", 0x12), BookmarkStart.b("ḷ᤹лఽ焿灁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹伻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ焿瑁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹伻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ焿畁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䤹帻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ焿穁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹堻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ爿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹堻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ爿獁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ堹堻伽㔿ⵁ罃", 0x12), BookmarkStart.b("ḷ᤹лఽ爿灁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ帹崻夽✿❁㙃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ爿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ縹崻夽✿❁㙃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ爿睁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ堹䤻刽ⰿ祁", 0x12), BookmarkStart.b("ḷ᤹лఽ爿瑁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ刹夻刽ⰿ⭁㑃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ猿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䨹夻䰽ⴿ⭁⡃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ琿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䨹主圽ⴿ❁罃", 0x12), BookmarkStart.b("ḷ᤹лఽ琿灁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ樹主圽ⴿ❁罃", 0x12), BookmarkStart.b("ḷ᤹лఽ琿煁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹伻弽ㄿ㝁⭃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ琿筁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹伻弽ㄿ㝁⭃絅", 0x12), BookmarkStart.b("ḷ᤹лఽ甿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ唹倻圽⸿❁罃", 0x12), BookmarkStart.b("ḷ᤹лఽ甿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ弹䤻䰽⼿祁", 0x12), BookmarkStart.b("ḷ᤹лഽ瘿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ丹主弽␿❁罃", 0x12), BookmarkStart.b("ḷ᤹л਽砿灁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹崻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹лଽ礿灁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ伹崻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹лଽ礿煁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹崻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹лଽ礿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ帹崻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹лଽ礿睁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ刹崻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹лଽ礿瑁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ夹主弽㈿ぁ罃", 0x12), BookmarkStart.b("ḷ᤹л࠽爿筁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹紻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹л࠽甿瑁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ伹紻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹л࠽甿畁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹紻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹л࠽甿穁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ帹紻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹л࠽甿筁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ刹紻䰽㈿祁", 0x12), BookmarkStart.b("ḷ᤹л࠽瘿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹弻嬽⤿⹁罃", 0x12), BookmarkStart.b("ḷ᤹лܽ瘿穁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹弻嬽⤿⹁罃", 0x12), BookmarkStart.b("ḷ᤹лܽ瘿筁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹娻刽⼿ⵁ㙃絅", 0x12), BookmarkStart.b("ḷ᤹лܽ眿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹娻刽⼿ⵁ㙃絅", 0x12), BookmarkStart.b("ḷ᤹лܽ眿獁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹医䐽笿", 0x12), BookmarkStart.b("ḷ᤹Ի࠽眿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䤹䰻弽␿❁㝃絅", 0x12), BookmarkStart.b("ḷ᤹Իؽ爿癁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ夹倻䬽∿ㅁ罃", 0x12), BookmarkStart.b("ḷ᤹Իؽ爿畁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ刹夻弽㈿㙁㝃絅", 0x12), BookmarkStart.b("ḷ᤹Իؽ爿筁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ帹唻弽ⴿㅁ罃", 0x12), BookmarkStart.b("ḷ᤹Իؽ猿牁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ嘹崻倽✿祁", 0x12), BookmarkStart.b("ḷ᤹Ի฽瀿獁罃", 0x12));
        A_0 = A_0.Replace(BookmarkStart.b("ḷ䠹崻倽✿祁", 0x12), BookmarkStart.b("ḷ᤹Ի฽瀿灁罃", 0x12));
        return A_0;
    }

    private void method_17(string A_0)
    {
        int num = 13;
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        XmlSchema schema = null;
        A_0 = A_0.Replace(BookmarkStart.b("ᔲ嬴唶䨸䬺ؼ", 13), BookmarkStart.b("崲圴䐶䤸:", 13));
        switch (this.bodyRegionCollection_0.Document.XHTMLValidateOption)
        {
            case XHTMLValidationType.Strict:
                schema = XmlSchema.Read(executingAssembly.GetManifestResourceStream(BookmarkStart.b("怲䔴帶䬸帺ጼ笾⹀⁂歄ᕆⱈ㡊≌㩎⍐げご⑖睘⍚㕜⭞ౠར呤䩦ᩨὪὬٮተݲ孴ྲྀ੸ὺ", num)), new ValidationEventHandler(this.method_103));
                break;

            case XHTMLValidationType.Transitional:
                schema = XmlSchema.Read(executingAssembly.GetManifestResourceStream(BookmarkStart.b("怲䔴帶䬸帺ጼ笾⹀⁂歄ᕆⱈ㡊≌㩎⍐げご⑖睘⍚㕜⭞ౠར呤䩦ᵨᥪ౬ŮɰᩲŴṶᙸᕺᱼ፾꾀ﮂ", num)), new ValidationEventHandler(this.method_103));
                break;
        }
        try
        {
            this.xmlDocument_0 = new XmlDocument();
            this.xmlDocument_0.PreserveWhitespace = true;
            this.method_18(A_0, schema);
        }
        catch (XmlException exception)
        {
            throw new NotSupportedException(BookmarkStart.b("䬲崴䌶吸场ᴼ夾⹀ㅂ⡄♆㵈歊⹌⹎㽐獒㭔㡖ⵘ筚㽜㩞䅠ၢၤᝦᥨѪὬ᭮ᑰᝲ啴ᕶx孺⹼ཾꦆ춈ꎎ鮐횒Ꞝ", num) + exception.Message, exception);
        }
    }

    internal void method_18(string A_0, XmlSchema A_1)
    {
        int num = 3;
        A_0 = this.method_10(A_0);
        if (A_0.StartsWith(BookmarkStart.b("ᔨᐪ唬䈮崰ጲ䌴制䬸䠺吼倾⽀", 3)) || A_0.StartsWith(BookmarkStart.b("ᔨᐪ唬䈮崰䔲倴䔶䨸刺刼儾", num)))
        {
            int index = A_0.IndexOf(BookmarkStart.b("ᜨ", num));
            A_0 = A_0.Remove(0, index + 1);
            if (A_0.StartsWith(BookmarkStart.b("न", num)))
            {
                A_0 = A_0.Remove(0, 1);
            }
            if (A_0.StartsWith(BookmarkStart.b("␨", num)))
            {
                A_0 = A_0.Remove(0, 1);
            }
            if (A_0.StartsWith(BookmarkStart.b("⌨", num)))
            {
                A_0 = A_0.Remove(0, 1);
            }
        }
        string str5 = A_0.ToLower();
        if (A_1 != null)
        {
            string str6 = BookmarkStart.b("ᔨ䌪夬䈮崰ጲ䴴娶唸唺丼Ⱦ捀", num) + A_1.TargetNamespace + BookmarkStart.b("ନᔪ", num);
            if (str5.StartsWith(BookmarkStart.b("ᔨ䌪夬䈮崰", num)))
            {
                int num2 = str5.IndexOf(BookmarkStart.b("ᜨ", num));
                A_0 = str6 + A_0.Remove(0, num2 + 1);
            }
            else if (!str5.StartsWith(BookmarkStart.b("ᔨਪ䤬䀮到䜲䰴䜶尸", num)))
            {
                A_0 = str6 + BookmarkStart.b("ᔨ䌪䠬丮唰ലऴ䌶倸伺儼娾罀罂橄㍆⁈㽊⅌⩎潐潒穔㽖㱘㩚㥜慞", num) + A_0 + BookmarkStart.b("ᔨЪ䔬嬮尰弲଴", num);
            }
            A_0 = this.method_9(A_0);
            Class833.smethod_4(ref A_0);
            A_0 = this.regex_1.Replace(A_0, BookmarkStart.b("ᔨ䤪弬.༰", num));
            A_0 = this.method_19(A_0);
            XmlValidatingReader reader = new XmlValidatingReader(A_0, XmlNodeType.Document, new XmlParserContext(null, null, null, XmlSpace.None));
            reader.Schemas.Add(A_1);
            this.xmlDocument_0.Load(reader);
        }
        else
        {
            A_0 = this.method_9(A_0);
            A_0 = BookmarkStart.b("ᔨ䌪夬䈮崰ലऴ唶嘸强䐼ľ", num) + A_0 + BookmarkStart.b("ᔨЪ伬䀮唰䨲଴ଶᘸ区䤼刾ⵀ終", num);
            if ((A_0.ToLower().IndexOf(BookmarkStart.b("ᔨЪ䔬嬮尰弲଴", num)) != 0) && (A_0.ToLower().IndexOf(BookmarkStart.b("ᔨЪ䔬嬮尰弲଴", num)) != A_0.ToLower().LastIndexOf(BookmarkStart.b("ᔨЪ䔬嬮尰弲଴", num))))
            {
                string str = string.Empty;
                string str2 = string.Empty;
                string str3 = string.Empty;
                string str4 = string.Empty;
                A_0 = this.method_20(A_0, BookmarkStart.b("䄨弪䀬䌮", num), ref str2, ref str4);
                A_0 = this.method_20(A_0, BookmarkStart.b("䄨个䰬䬮", num), ref str3, ref str4);
                A_0 = this.method_20(A_0, BookmarkStart.b("䬨䐪䤬嘮", num), ref str, ref str4);
                A_0 = string.Format(BookmarkStart.b("ᔨ䌪夬䈮崰ጲ临ܶ䐸Ժļ圾⑀≂⅄杆㉈穊が煎⩐慒⡔歖癘㍚㡜㹞ՠ嵢奤զ٨ཪᑬ佮ੰ䁲ࡴ䥶ɸ佺|䍾꺀떊놌ꂎ戀ﮖꞘ", num), new object[] { str2, str3, str4, str, A_0 });
            }
            A_0 = A_0.Replace(BookmarkStart.b("༨䔪伬尮䄰࠲", num), string.Empty).Replace(BookmarkStart.b("༨䔪伬尮䄰", num), string.Empty);
            A_0 = this.regex_1.Replace(A_0, BookmarkStart.b("ᔨ䤪弬.༰", num));
            A_0 = this.method_19(A_0);
            this.xmlDocument_0 = Class833.smethod_3(A_0);
        }
        if (this.xmlDocument_0 != null)
        {
            foreach (XmlNode node in this.xmlDocument_0.SelectNodes(BookmarkStart.b("بЪ丬䀮尰帲倴夶䴸ጺᐼ", num)))
            {
                node.ParentNode.RemoveChild(node);
            }
        }
    }

    private string method_19(string A_0)
    {
        int num = 15;
        A_0 = this.regex_6.Replace(A_0, BookmarkStart.b("ጴ嬶䴸:ļ", 15));
        A_0 = this.regex_4.Replace(A_0, BookmarkStart.b("ጴ嬶䴸:ሼ̾湀", 15));
        while (this.regex_5.IsMatch(A_0))
        {
            Match match = this.regex_5.Match(A_0);
            string newValue = BookmarkStart.b("ጴ嬶䴸:", num) + match.Value.Substring(1);
            A_0 = A_0.Replace(match.Value, newValue);
        }
        return A_0;
    }

    protected void method_2(string A_0)
    {
        this.string_4 = A_0;
    }

    private string method_20(string A_0, string A_1, ref string A_2, ref string A_3)
    {
        int num = 2;
        string str = string.Empty;
        string str2 = BookmarkStart.b("ᐧ", 2) + A_1 + BookmarkStart.b("ᘧ", 2);
        string str3 = BookmarkStart.b("ᐧ", 2) + A_1 + BookmarkStart.b("ࠧ", 2);
        string str4 = BookmarkStart.b("ᐧԩ", 2) + A_1;
        while (true)
        {
            string str5 = A_0;
            if (!string.IsNullOrEmpty(str))
            {
                str5 = str;
                str = string.Empty;
            }
            if ((!str5.ToLower().Contains(str2) && !str5.ToLower().Contains(str3)) || !str5.ToLower().Contains(str4))
            {
                return str5;
            }
            int index = str5.ToLower().IndexOf(str2);
            int num3 = (index < 0) ? (str3.Length - 1) : (str2.Length - 1);
            index = (index < 0) ? str5.ToLower().IndexOf(str3) : index;
            if (index >= 0)
            {
                str = str + str5.Substring(0, index);
                str5 = str5.Substring(str5.Substring(0, index + num3).Length);
                if (string.IsNullOrEmpty(A_2))
                {
                    A_2 = str5.Substring(0, str5.IndexOf(BookmarkStart.b("ᘧ", num))).Trim();
                }
                else
                {
                    string str6 = str5.Substring(0, str5.IndexOf(BookmarkStart.b("ᘧ", num)));
                    XmlDocument document = new XmlDocument();
                    document.LoadXml(BookmarkStart.b("ᐧ", num) + A_1 + BookmarkStart.b("ࠧ", num) + str6 + BookmarkStart.b("ᘧᘩ̫", num) + A_1 + BookmarkStart.b("ᘧ", num));
                    foreach (XmlAttribute attribute in document.ChildNodes[0].Attributes)
                    {
                        if (!A_2.ToLower().Contains(attribute.Name.ToLower()))
                        {
                            A_2 = A_2 + BookmarkStart.b("ࠧ", num) + attribute.Name + BookmarkStart.b("ᔧࠩ", num) + attribute.Value + BookmarkStart.b("ਧ", num);
                        }
                    }
                }
                str5 = str5.Substring(str5.IndexOf(BookmarkStart.b("ᘧ", num)) + 1);
            }
            index = str5.ToLower().IndexOf(str4);
            if (index >= 0)
            {
                if (A_1 == BookmarkStart.b("䀧伩䴫䨭", num))
                {
                    A_3 = A_3 + str5.Substring(0, index);
                }
                else
                {
                    str = str + str5.Substring(0, index);
                }
                str5 = str5.Substring(str5.Substring(0, index + str4.Length).Length);
                str5 = str5.Substring(str5.IndexOf(BookmarkStart.b("ᘧ", num)) + 1);
            }
            str = str + str5;
            if ((!str.ToLower().Contains(str2) && !str.ToLower().Contains(str3)) && !str.ToLower().Contains(str4))
            {
                return str;
            }
        }
    }

    private void method_21(XmlNodeList A_0)
    {
        int num = 14;
        XmlNode node = null;
        foreach (XmlNode node2 in A_0)
        {
            if (node2.NodeType == XmlNodeType.Text)
            {
                this.method_22(node2, node);
            }
            else if (node2.NodeType == XmlNodeType.Element)
            {
                this.method_30(node2);
                string outerXml = node2.OuterXml;
                if (outerXml.Length >= 5)
                {
                    string str2 = outerXml.Substring(outerXml.Length - 5, 5).ToLower();
                    if ((this.method_6().Count > 0) && ((str2 == BookmarkStart.b("࠳ᤵ䴷嘹Ȼ", num)) || (str2 == BookmarkStart.b("࠳ᤵ圷嘹Ȼ", num))))
                    {
                        this.int_0--;
                        this.method_6().Pop();
                    }
                }
            }
            else if ((node2.NodeType == XmlNodeType.Whitespace) && (node2.Value == BookmarkStart.b("ᐳ", num)))
            {
                ITextRange range = this.method_5().AppendText(BookmarkStart.b("ᐳ", num));
                this.method_75(range);
            }
            node = node2;
        }
    }

    private void method_22(XmlNode A_0, XmlNode A_1)
    {
        int num = 8;
        if (this.bool_10 && ((A_0.ParentNode.LocalName.ToLower() == BookmarkStart.b("䰭尯崱圳崵䤷伹医䨽┿", num)) || ((A_0.ParentNode.LocalName.ToLower() == BookmarkStart.b("崭䀯匱娳", num)) && this.method_25(A_0.ParentNode))))
        {
            this.method_27();
            this.method_5().Format.LeftIndent += this.int_2 * 0x24;
        }
        if (this.method_24(A_1))
        {
            this.method_27();
        }
        string str2 = string.Empty;
        if (!A_0.ParentNode.HasChildNodes)
        {
            str2 = this.method_97(A_0.ParentNode, BookmarkStart.b("䜭启", num));
        }
        if (!string.IsNullOrEmpty(str2))
        {
            this.method_5().AppendBookmarkStart(str2);
        }
        string innerText = A_0.InnerText;
        if (!this.bool_9)
        {
            innerText = innerText.Replace('\n', ' ').Replace('\r', ' ');
            if (innerText != BookmarkStart.b("อ", num))
            {
                innerText = this.regex_0.Replace(innerText, BookmarkStart.b("อ", num));
            }
        }
        innerText = this.method_23(innerText);
        if (this.class751_1 != null)
        {
            float num3 = innerText.Length * this.class751_1.method_67();
            int num4 = (int) Math.Ceiling((double) (num3 / ((float) this.class751_1.method_30())));
            short num2 = (short) (num4 * this.class751_1.method_67());
            if (this.bool_6 && (this.class751_1.method_32() < num2))
            {
                this.class751_1.method_33(num2);
            }
        }
        innerText = this.method_26(innerText, this.method_5());
        if ((this.stack_12.Count > 0) && ((this.stack_12.Count == (this.stack_13.Count + 1)) || ((A_1 != null) && ((A_1.Name == BookmarkStart.b("嬭尯", num)) || (A_1.Name == BookmarkStart.b("䄭尯", num))))))
        {
            this.method_5().Format.LeftIndent = this.stack_12.Count * 36f;
        }
        if (this.bool_11)
        {
            if (!this.bool_12)
            {
                this.class2_0.Text = innerText;
                this.method_75(this.class2_0);
                this.method_5().Items.Add(this.class2_0);
            }
            else
            {
                this.class2_0.method_45().Text = innerText;
                this.method_75(this.class2_0.method_45());
            }
        }
        else
        {
            if ((A_0.ParentNode.LocalName == BookmarkStart.b("䰭弯嘱䴳", num)) && (A_0.PreviousSibling == null))
            {
                ITextRange range2 = this.method_5().AppendText(innerText);
                this.method_75(range2);
            }
            else
            {
                if ((A_0.ParentNode.LocalName == BookmarkStart.b("席", num)) && this.bool_1)
                {
                    this.method_27();
                    this.bool_1 = true;
                }
                if (A_0.ParentNode.LocalName == BookmarkStart.b("䰭弯嘱䴳", num))
                {
                    this.method_67();
                }
                ITextRange range = this.method_5().AppendText(innerText);
                this.method_75(range);
            }
            if (!string.IsNullOrEmpty(str2))
            {
                this.method_5().AppendBookmarkEnd(str2);
            }
        }
    }

    private string method_23(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("弰儲䘴䜶ȸ", 11), '\x00a0'.ToString());
        A_0 = A_0.Replace(BookmarkStart.b("ᜰဲдĶस", 11), '\x00a0'.ToString());
        A_0 = A_0.Replace(BookmarkStart.b("ᜰ弲䄴శ", 11), '<'.ToString());
        A_0 = A_0.Replace(BookmarkStart.b("ᜰ吲䄴శ", 11), '>'.ToString());
        return A_0;
    }

    private bool method_24(XmlNode A_0)
    {
        int num = 4;
        if ((A_0 == null) || ((((!(A_0.LocalName.ToLower() == BookmarkStart.b("丩堫", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("丩䠫", num))) && (!(A_0.LocalName.ToLower() == BookmarkStart.b("䈩ᴫ", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("䈩ḫ", num)))) && ((!(A_0.LocalName.ToLower() == BookmarkStart.b("䈩Ἣ", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("䈩ᠫ", num))) && (!(A_0.LocalName.ToLower() == BookmarkStart.b("䈩ᤫ", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("䈩ᨫ", num))))) && ((!(A_0.LocalName.ToLower() == BookmarkStart.b("丩䔫堭", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("娩", num))) && ((!(A_0.LocalName.ToLower() == BookmarkStart.b("弩䀫", num)) && !(A_0.LocalName.ToLower() == BookmarkStart.b("䔩䀫", num))) && !(A_0.LocalName.ToLower() == BookmarkStart.b("帩䴫䰭尯圱", num))))))
        {
            return false;
        }
        return true;
    }

    private bool method_25(XmlNode A_0)
    {
        int num = 11;
        if (!(A_0.ParentNode.LocalName.ToLower() == BookmarkStart.b("匰弲娴吶券䨺䠼倾㕀♂", 11)))
        {
            return false;
        }
        while (A_0.PreviousSibling != null)
        {
            if (!(A_0.PreviousSibling.Name == BookmarkStart.b("ሰ䐲崴帶䴸帺丼伾⁀⁂⁄", num)) && !(A_0.PreviousSibling.Name == BookmarkStart.b("ሰ䀲尴倶圸刺嬼嘾≀≂⭄㍆摈㱊╌♎═㙒♔❖㡘㡚㡜", num)))
            {
                return false;
            }
            A_0 = A_0.PreviousSibling;
        }
        return true;
    }

    private string method_26(string A_0, Paragraph A_1)
    {
        if (A_0.StartsWith(BookmarkStart.b("ఫ", 6)))
        {
            if ((A_1.ChildObjects.LastItem != null) && (A_1.ChildObjects.LastItem.DocumentObjectType == DocumentObjectType.Break))
            {
                A_0 = A_0.TrimStart(new char[0]);
                return A_0;
            }
            if (!(A_1.Text == "") && (A_1.Text != null))
            {
                return A_0;
            }
            A_0 = A_0.TrimStart(new char[0]);
        }
        return A_0;
    }

    private void method_27()
    {
        this.paragraph_0 = new Paragraph(this.bodyRegionCollection_0.Document);
        this.bodyRegionCollection_0.Add(this.paragraph_0);
        if ((this.method_0() != null) && (((this.stack_15.Count == 0) || (this.stack_16.Count == 0)) || this.stack_16.Peek()))
        {
            this.paragraph_0.Format.DivId = this.method_0().method_7();
        }
        this.method_73();
        this.method_67();
        if (this.bool_6 && (this.class751_1 != null))
        {
            ParagraphFormat format = this.paragraph_0.Format;
            if (this.class751_1.method_102(7))
            {
                format.BackColor = this.class751_1.method_53();
            }
            if (this.class751_1.method_102(12))
            {
                format.LeftIndent = this.class751_1.method_85();
            }
            if (this.class751_1.method_102(0x19))
            {
                format.LeftIndent += this.class751_1.method_16();
            }
            if (this.class751_1.method_102(0x1b))
            {
                format.IsBidi = this.class751_1.method_81();
            }
            if (this.class751_1.method_102(10))
            {
                format.HorizontalAlignment = this.class751_1.method_83();
            }
        }
    }

    private void method_28(XmlNode A_0)
    {
        bool flag = this.method_68(A_0);
        this.method_21(A_0.ChildNodes);
        if (!flag)
        {
            this.method_68(A_0);
        }
        this.method_67();
    }

    private bool method_29(XmlNode A_0)
    {
        int num = 4;
        if (A_0.ParentNode.Name.ToLower() == BookmarkStart.b("帩䠫", 4))
        {
            while (A_0.PreviousSibling != null)
            {
                if (!(A_0.PreviousSibling.Name == BookmarkStart.b("ऩ嬫䘭夯䘱儳䔵䠷嬹弻嬽", num)))
                {
                    return false;
                }
                A_0 = A_0.PreviousSibling;
            }
            return true;
        }
        return (A_0.ParentNode.Name.ToLower() == BookmarkStart.b("䘩䔫", num));
    }

    protected Class751 method_3()
    {
        if (this.stack_0.Count > 0)
        {
            return this.stack_0.Peek();
        }
        if (this.class751_0 == null)
        {
            this.class751_0 = new Class751();
        }
        return this.class751_0;
    }

    private void method_30(XmlNode A_0)
    {
        int num = 0x10;
        string str = A_0.Name.ToLower();
        int count = 0;
        string key = str;
        if (key != null)
        {
            int num3;
            if (Class1160.dictionary_127 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x27);
                dictionary1.Add(BookmarkStart.b("刵儷䠹", num), 0);
                dictionary1.Add(BookmarkStart.b("吵圷帹䔻", num), 1);
                dictionary1.Add(BookmarkStart.b("䘵", num), 2);
                dictionary1.Add(BookmarkStart.b("娵儷", num), 3);
                dictionary1.Add(BookmarkStart.b("刵䰷", num), 4);
                dictionary1.Add(BookmarkStart.b("刵尷", num), 5);
                dictionary1.Add(BookmarkStart.b("娵倷", num), 6);
                dictionary1.Add(BookmarkStart.b("刵儷䰹", num), 7);
                dictionary1.Add(BookmarkStart.b("䘵䨷弹", num), 8);
                dictionary1.Add(BookmarkStart.b("帵ष", num), 9);
                dictionary1.Add(BookmarkStart.b("帵਷", num), 10);
                dictionary1.Add(BookmarkStart.b("帵ଷ", num), 11);
                dictionary1.Add(BookmarkStart.b("帵ష", num), 12);
                dictionary1.Add(BookmarkStart.b("帵ഷ", num), 13);
                dictionary1.Add(BookmarkStart.b("帵ื", num), 14);
                dictionary1.Add(BookmarkStart.b("帵༷", num), 15);
                dictionary1.Add(BookmarkStart.b("䈵夷堹倻嬽", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䈵䨷", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䈵倷", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䈵尷", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䈵娷唹堻䜽", num), 20);
                dictionary1.Add(BookmarkStart.b("䈵倷弹崻娽", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䈵帷唹医䨽", num), 0x16);
                dictionary1.Add(BookmarkStart.b("唵圷嘹嬻䰽⼿㝁㑃", num), 0x17);
                dictionary1.Add(BookmarkStart.b("唵圷嘹", num), 0x18);
                dictionary1.Add(BookmarkStart.b("唵夷䨹䠻圽⼿ⱁ", num), 0x19);
                dictionary1.Add(BookmarkStart.b("張唷崹", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("圵", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("吵䨷", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("吵吷唹弻唽ㄿ㝁⭃㉅ⵇ", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("䐵䴷堹䔻", num), 30);
                dictionary1.Add(BookmarkStart.b("䐵䠷", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("䐵䰷", num), 0x20);
                dictionary1.Add(BookmarkStart.b("張嘷䤹", num), 0x21);
                dictionary1.Add(BookmarkStart.b("張嘷䤹夻䰽㐿", num), 0x22);
                dictionary1.Add(BookmarkStart.b("刵崷嘹", num), 0x23);
                dictionary1.Add(BookmarkStart.b("刵崷嘹夻䨽┿", num), 0x24);
                dictionary1.Add(BookmarkStart.b("䔵䠷嬹刻", num), 0x25);
                dictionary1.Add(BookmarkStart.b("帵䨷", num), 0x26);
                Class1160.dictionary_127 = dictionary1;
            }
            if (Class1160.dictionary_127.TryGetValue(key, out num3))
            {
                Class751 class4;
                switch (num3)
                {
                    case 0:
                    case 1:
                        this.method_21(A_0.ChildNodes);
                        return;

                    case 2:
                    {
                        string pattern = BookmarkStart.b("ਵ᜷刹朻༽洿瑁᥃硅", num);
                        string innerXml = A_0.InnerXml;
                        this.method_35(A_0);
                        count = this.stack_0.Count;
                        if (Regex.IsMatch(innerXml, pattern))
                        {
                            XmlNode node = A_0.CloneNode(false);
                            node.InnerXml = this.method_38(innerXml);
                            this.method_96();
                            Class751 class2 = this.class751_1;
                            this.stack_5.Push(this.method_3());
                            foreach (XmlNode node2 in node.ChildNodes)
                            {
                                this.method_30(node2);
                            }
                            if ((count + 1) == this.stack_0.Count)
                            {
                                this.method_94(true);
                                this.stack_5.Pop();
                                this.class751_1 = class2;
                                return;
                            }
                            this.class751_1 = (this.stack_5.Count > 0) ? this.stack_5.Peek() : null;
                            return;
                        }
                        Class751 class3 = this.class751_1;
                        if ((this.stack_13.Count == 0) || !this.stack_13.Peek())
                        {
                            this.paragraph_0 = null;
                        }
                        string str5 = (A_0.ParentNode != null) ? A_0.ParentNode.Name.ToLower() : string.Empty;
                        bool flag = this.method_81(A_0);
                        foreach (XmlAttribute attribute in A_0.Attributes)
                        {
                            string str6 = attribute.LocalName.ToLower();
                            if (str6 != null)
                            {
                                if (str6 != BookmarkStart.b("圵吷匹嬻倽", num))
                                {
                                    if (str6 == BookmarkStart.b("刵儷䠹", num))
                                    {
                                        if (attribute.Value.ToLower() == BookmarkStart.b("䐵䰷嘹", num))
                                        {
                                            this.method_3().method_82(true);
                                        }
                                        else if (attribute.Value.ToLower() == BookmarkStart.b("娵䰷䠹", num))
                                        {
                                            this.method_3().method_82(false);
                                        }
                                    }
                                }
                                else
                                {
                                    this.method_3().method_84(this.method_149(attribute.Value));
                                }
                            }
                        }
                        if (!flag)
                        {
                            this.method_96();
                            this.method_3().class752_0 = new Class752(null);
                            this.method_3().method_99();
                            this.method_3().method_100();
                        }
                        this.stack_5.Push(this.method_3().method_97());
                        this.stack_5.Peek().method_99();
                        this.stack_5.Peek().method_100();
                        if (str5 == BookmarkStart.b("䈵尷", num))
                        {
                            this.method_28(A_0);
                        }
                        else if (str5 == BookmarkStart.b("娵儷", num))
                        {
                            this.method_68(A_0);
                            this.method_21(A_0.ChildNodes);
                        }
                        else
                        {
                            this.method_27();
                            this.method_28(A_0);
                        }
                        if ((count + 1) == this.stack_0.Count)
                        {
                            if (!this.method_3().method_102(11) && (this.paragraph_0 != null))
                            {
                                this.paragraph_0.Format.BeforeAutoSpacing = true;
                            }
                            if (!this.method_3().method_102(13) && (this.paragraph_0 != null))
                            {
                                this.paragraph_0.Format.AfterAutoSpacing = true;
                            }
                            if (this.paragraph_0 != null)
                            {
                                this.method_70(this.method_3(), this.paragraph_0.BreakCharacterFormat);
                            }
                            this.method_94(true);
                            this.stack_5.Pop();
                            this.class751_1 = class3;
                            this.paragraph_0 = null;
                            return;
                        }
                        this.class751_1 = (this.stack_5.Count > 0) ? this.stack_5.Peek() : null;
                        return;
                    }
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    {
                        bool flag2 = this.method_81(A_0);
                        count = this.stack_0.Count;
                        this.stack_13.Push(true);
                        this.method_66(A_0);
                        this.method_94(flag2 && (count == this.stack_0.Count));
                        this.stack_13.Pop();
                        this.paragraph_0 = null;
                        return;
                    }
                    case 7:
                        if ((this.paragraph_0 != null) && (this.paragraph_0.ChildObjects.Count > 0))
                        {
                            this.paragraph_0 = null;
                        }
                        this.method_42(A_0);
                        this.method_21(A_0.ChildNodes);
                        this.method_46();
                        return;

                    case 8:
                        this.method_35(A_0);
                        this.paragraph_0 = null;
                        this.method_47(A_0);
                        count = this.stack_0.Count;
                        this.method_21(A_0.ChildNodes);
                        if (!this.stack_9.Peek() || (count != this.stack_0.Count))
                        {
                            this.stack_9.Pop();
                            return;
                        }
                        this.method_48();
                        return;

                    case 9:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 24f, BuiltinStyle.Heading1, A_0, true, false);
                        return;

                    case 10:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 18f, BuiltinStyle.Heading2, A_0, true, false);
                        return;

                    case 11:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 15f, BuiltinStyle.Heading3, A_0, true, false);
                        return;

                    case 12:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 12f, BuiltinStyle.Heading4, A_0, true, false);
                        return;

                    case 13:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 9f, BuiltinStyle.Heading5, A_0, true, false);
                        return;

                    case 14:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 6.5f, BuiltinStyle.Heading6, A_0, true, false);
                        return;

                    case 15:
                        class4 = this.method_77(A_0);
                        this.method_39(class4, 12f, BuiltinStyle.Heading7, A_0, false, false);
                        return;

                    case 0x10:
                        if (this.stack_17.Count > 0)
                        {
                            for (int i = 0; i < this.stack_17.Count; i++)
                            {
                                this.method_54();
                            }
                        }
                        this.method_50();
                        this.method_113(A_0);
                        return;

                    case 0x11:
                        this.method_121(A_0);
                        return;

                    case 0x12:
                    case 0x13:
                        this.method_119(A_0);
                        return;

                    case 20:
                    case 0x15:
                    case 0x16:
                        this.method_116(A_0);
                        return;

                    case 0x17:
                        this.method_117(A_0);
                        return;

                    case 0x18:
                        this.method_118(A_0);
                        return;

                    case 0x19:
                        this.method_124(A_0);
                        return;

                    case 0x1a:
                        class4 = this.method_77(A_0);
                        this.method_57(A_0);
                        this.method_94(true);
                        return;

                    case 0x1b:
                        class4 = this.method_77(A_0);
                        count = this.stack_0.Count;
                        this.method_51(A_0);
                        this.method_94(count == this.stack_0.Count);
                        return;

                    case 0x1c:
                        this.method_37(A_0);
                        return;

                    case 0x1d:
                        this.method_40(A_0);
                        this.method_21(A_0.ChildNodes);
                        this.method_41();
                        return;

                    case 30:
                        this.bool_11 = true;
                        this.class2_0 = new Class2(this.bodyRegionCollection_0.Document);
                        this.method_77(A_0);
                        this.method_21(A_0.ChildNodes);
                        if (this.stack_0.Count > 0)
                        {
                            this.stack_0.Pop();
                        }
                        this.bool_11 = false;
                        this.class2_0 = null;
                        return;

                    case 0x1f:
                        return;

                    case 0x20:
                        this.bool_12 = true;
                        this.method_77(A_0);
                        count = this.stack_0.Count;
                        this.method_21(A_0.ChildNodes);
                        if ((this.stack_0.Count > 0) && (count == this.stack_0.Count))
                        {
                            this.stack_0.Pop();
                        }
                        this.bool_12 = false;
                        return;

                    case 0x21:
                        this.method_33(A_0, true);
                        return;

                    case 0x22:
                        if (!this.bodyRegionCollection_0.Document.HTMLTrackChanges || !this.method_34(A_0))
                        {
                            this.method_60(A_0);
                            return;
                        }
                        this.method_33(A_0, true);
                        return;

                    case 0x23:
                        this.method_33(A_0, false);
                        return;

                    case 0x24:
                        if (!this.bodyRegionCollection_0.Document.HTMLTrackChanges || !this.method_34(A_0))
                        {
                            this.method_60(A_0);
                            return;
                        }
                        this.method_33(A_0, false);
                        return;

                    case 0x25:
                    {
                        XmlElement element = A_0 as XmlElement;
                        string str7 = (element != null) ? element.GetAttribute(BookmarkStart.b("唵ȷ夹倻弽㌿ㅁ", num)) : string.Empty;
                        if ((!this.bodyRegionCollection_0.Document.HTMLCustomComment || string.IsNullOrEmpty(str7)) || !(str7 == BookmarkStart.b("唵圷圹儻嬽⸿㙁", num)))
                        {
                            this.method_60(A_0);
                            return;
                        }
                        this.method_61(A_0);
                        return;
                    }
                    case 0x26:
                        this.method_31(A_0);
                        return;
                }
            }
        }
        this.method_60(A_0);
    }

    private void method_31(XmlNode A_0)
    {
        ShapeObject obj2 = new ShapeObject(this.bodyRegionCollection_0.Document, ShapeType.Rectangle);
        this.shapeObject_0 = obj2;
        obj2.HorizontalRule.method_7(ShapeHorizontalAlignment.Center);
        obj2.HorizontalRule.method_5(true);
        obj2.HorizontalRule.method_1(true);
        obj2.Stroke.method_1(false);
        obj2.TextWrappingStyle = TextWrappingStyle.Inline;
        obj2.FillColor = Color.Gray;
        this.method_32(obj2, A_0);
        if (this.method_5().ChildObjects.Count > 0)
        {
            this.method_27();
        }
        this.method_5().method_13(obj2);
        this.paragraph_0 = null;
        this.shapeObject_0 = null;
    }

    private void method_32(ShapeObject A_0, XmlNode A_1)
    {
        int num = 6;
        bool flag = this.method_81(A_1);
        if (this.method_3().method_102(7))
        {
            A_0.FillColor = this.method_3().method_53();
            this.method_3().method_98(7);
        }
        this.method_70(this.method_3(), A_0.CharacterFormat);
        foreach (XmlAttribute attribute in A_1.Attributes)
        {
            string str = attribute.Name.ToLower();
            if (str != null)
            {
                if (str != BookmarkStart.b("䴫䈭夯唱娳", num))
                {
                    if (str != BookmarkStart.b("䈫䄭䌯娱唳刵崷", num))
                    {
                        if (str != BookmarkStart.b("弫䜭䨯圱", num))
                        {
                            if (str == BookmarkStart.b("嬫䜭启䘱尳", num))
                            {
                                float result = 0f;
                                if (attribute.Value.EndsWith(BookmarkStart.b("फ", num)) && float.TryParse(attribute.Value.Replace(BookmarkStart.b("फ", num), string.Empty), out result))
                                {
                                    A_0.HorizontalRule.method_9((double) result);
                                }
                                else
                                {
                                    A_0.Width = Convert.ToSingle(this.method_79(attribute.Value));
                                }
                            }
                        }
                        else
                        {
                            float num3 = 0f;
                            if (float.TryParse(attribute.Value, out num3))
                            {
                                A_0.Height = num3 * 0.75f;
                            }
                        }
                    }
                    else
                    {
                        A_0.HorizontalRule.method_3(true);
                        if (!A_0.ShapePr.HasKey(0x1024))
                        {
                            A_0.Height = 1.5;
                        }
                    }
                }
                else
                {
                    string str2 = attribute.Value.ToLower();
                    if (str2 != null)
                    {
                        if (!(str2 == BookmarkStart.b("䀫䬭嘯䘱", num)))
                        {
                            if (str2 == BookmarkStart.b("師䜭圯娱䀳", num))
                            {
                                A_0.HorizontalRule.method_7(ShapeHorizontalAlignment.Right);
                            }
                        }
                        else
                        {
                            A_0.HorizontalRule.method_7(ShapeHorizontalAlignment.Left);
                        }
                    }
                }
            }
        }
        if (flag)
        {
            this.stack_0.Pop();
        }
    }

    private void method_33(XmlNode A_0, bool A_1)
    {
        this.method_77(A_0);
        if (A_1)
        {
            this.method_3().method_5(true);
            this.method_3().method_7(false);
        }
        else
        {
            this.method_3().method_7(true);
            this.method_3().method_5(false);
        }
        int count = this.stack_0.Count;
        this.method_21(A_0.ChildNodes);
        if ((this.stack_0.Count > 0) && (count == this.stack_0.Count))
        {
            this.stack_0.Pop();
        }
    }

    private bool method_34(XmlNode A_0)
    {
        int num = 0x12;
        if (((((A_0.ParentNode.Name.ToLower() != BookmarkStart.b("䬷䨹崻倽", 0x12)) && (A_0.ParentNode.Name.ToLower() != BookmarkStart.b("䠷", num))) && (A_0.ParentNode.Name.ToLower() != BookmarkStart.b("尷匹䨻", num))) && ((this.method_133(A_0) == null) || (this.method_133(A_0).NodeType != XmlNodeType.Text))) && ((this.method_134(A_0) == null) || (this.method_134(A_0).NodeType != XmlNodeType.Text)))
        {
            return false;
        }
        return true;
    }

    private void method_35(XmlNode A_0)
    {
        int num = 0x13;
        Regex regex = new Regex(BookmarkStart.b("朸䬺᤼", 0x13), RegexOptions.IgnoreCase);
        Regex regex2 = new Regex(BookmarkStart.b("朸伺夼䌾㕀ㅂ㥄㍆⡈⥊⅌⩎畐", 0x13), RegexOptions.IgnoreCase);
        for (XmlNode node = A_0.ParentNode; node != null; node = node.ParentNode)
        {
            if (!(node.Name.ToLower() != BookmarkStart.b("儸伺值匾", num)))
            {
                return;
            }
            if (regex.IsMatch(node.Name))
            {
                if (!this.dictionary_0.ContainsValue(node))
                {
                    this.dictionary_0.Add(this.dictionary_0.Count, node);
                    this.method_36(A_0, node);
                    return;
                }
                return;
            }
            if (regex2.IsMatch(node.Name))
            {
                return;
            }
        }
    }

    private void method_36(XmlNode A_0, XmlNode A_1)
    {
        int num = 3;
        while (A_0 != A_1)
        {
            this.stack_0.Pop();
            A_0 = A_0.ParentNode;
            if ((A_0.Name.ToLower() == BookmarkStart.b("夨", num)) || (A_0.Name.ToLower() == BookmarkStart.b("䴨䈪嬬", num)))
            {
                this.class751_1 = this.stack_5.Pop();
            }
        }
    }

    private void method_37(XmlNode A_0)
    {
        int num = 6;
        if ((A_0.ParentNode == null) || ((A_0.ParentNode.Name != BookmarkStart.b("堫尭", num)) && (A_0.ParentNode.Name != BookmarkStart.b("堫伭刯帱儳", num))))
        {
            this.method_77(A_0);
            Regex regex = new Regex(BookmarkStart.b("爫席䰯䘱倳䨵尷匹䨻䈽㐿⍁♃⩅ⵇ湉", num));
            XmlNode node = this.method_133(A_0);
            XmlNode node2 = this.method_134(A_0);
            BreakType lineBreak = BreakType.LineBreak;
            if (this.bool_3 || this.bool_2)
            {
                lineBreak = BreakType.PageBreak;
                this.bool_3 = false;
                this.bool_2 = false;
            }
            if (((node != null) && (node.Name == BookmarkStart.b("堫伭刯帱儳", num))) && (lineBreak == BreakType.LineBreak))
            {
                if ((node2 != null) && !(node2.Name == BookmarkStart.b("堫伭刯帱儳", num)))
                {
                    this.method_5().AppendBreak(lineBreak);
                }
                else if (this.class751_1 == null)
                {
                    this.class751_1 = this.method_3().method_97();
                    this.method_27();
                    this.class751_1 = null;
                }
                else
                {
                    this.method_27();
                }
            }
            else if ((((node == null) && (node2 == null)) && regex.IsMatch(A_0.ParentNode.Name)) || (((node == null) && (node2 != null)) && ((node2.Name == BookmarkStart.b("堫伭刯帱儳", num)) && (lineBreak == BreakType.LineBreak))))
            {
                if (this.class751_1 == null)
                {
                    this.class751_1 = this.method_3().method_97();
                    this.method_27();
                    this.class751_1 = null;
                }
                else
                {
                    this.method_27();
                }
            }
            else
            {
                if (((node != null) && (node2 != null)) && (node2.Name == BookmarkStart.b("堫伭刯帱儳", num)))
                {
                    this.method_94(true);
                    return;
                }
                this.method_5().AppendBreak(lineBreak);
            }
            this.method_94(true);
        }
    }

    private string method_38(string A_0)
    {
        int num = 4;
        string pattern = BookmarkStart.b("ᘩ̫䘭欯̱ᤳ5攷й", 4);
        string str2 = BookmarkStart.b("ᘩ䐫甭įἱȳ欵", 4);
        MatchCollection matchs = Regex.Matches(A_0, pattern);
        MatchCollection matchs2 = Regex.Matches(A_0, str2);
        if ((matchs.Count <= 0) || (matchs.Count != matchs2.Count))
        {
            return A_0;
        }
        List<Class753> list = new List<Class753>();
        int num5 = 0;
        int count = matchs2.Count;
        while (num5 < count)
        {
            Match match2 = matchs2[num5];
            if ((num5 == 0) && (match2.Index != 0))
            {
                Class753 item = new Class753();
                item.method_1(0);
                item.method_5(0);
                item.method_3(true);
                list.Add(item);
                Class753 class4 = new Class753();
                class4.method_1(match2.Index);
                class4.method_5(match2.Length);
                class4.method_3(false);
                list.Add(class4);
            }
            else if (num5 != 0)
            {
                Class753 class2 = new Class753();
                class2.method_1(match2.Index);
                class2.method_5(match2.Length);
                class2.method_3(false);
                list.Add(class2);
            }
            num5++;
        }
        int num2 = 0;
        int num3 = matchs.Count;
        while (num2 < num3)
        {
            Match match = matchs[num2];
            if (num2 < (num3 - 1))
            {
                Class753 class6 = new Class753();
                class6.method_1(match.Index);
                class6.method_5(match.Length);
                class6.method_3(true);
                list.Add(class6);
            }
            else if ((num2 == (num3 - 1)) && ((match.Index + match.Length) < A_0.Length))
            {
                Class753 class7 = new Class753();
                class7.method_1(match.Index);
                class7.method_5(match.Length);
                class7.method_3(true);
                list.Add(class7);
                Class753 class8 = new Class753();
                class8.method_1(A_0.Length);
                class8.method_5(0);
                class8.method_3(false);
                list.Add(class8);
            }
            num2++;
        }
        list.Sort();
        StringBuilder builder = new StringBuilder();
        int startIndex = 0;
        foreach (Class753 class5 in list)
        {
            if ((class5.method_0() == 0) && class5.method_2())
            {
                builder.Append(BookmarkStart.b("ᘩ尫ိ", num));
            }
            else if (class5.method_2())
            {
                string str4 = A_0.Substring(startIndex, (class5.method_0() + class5.method_4()) - startIndex);
                builder.Append(str4);
                builder.Append(BookmarkStart.b("ᘩ尫ိ", num));
                startIndex = class5.method_0() + class5.method_4();
            }
            else if (!class5.method_2())
            {
                string str5 = A_0.Substring(startIndex, class5.method_0() - startIndex);
                builder.Append(str5);
                builder.Append(BookmarkStart.b("ᘩ̫席ฯ", num));
                startIndex = class5.method_0();
            }
        }
        if (startIndex < A_0.Length)
        {
            string str3 = A_0.Substring(startIndex, A_0.Length - startIndex);
            builder.Append(str3);
        }
        return builder.ToString();
    }

    private void method_39(Class751 A_0, float A_1, BuiltinStyle A_2, XmlNode A_3, bool A_4, bool A_5)
    {
        A_0.method_41(A_4);
        A_0.method_43(A_0.method_44() ? A_5 : A_0.method_42());
        if ((A_1 > 0f) && A_0.method_71())
        {
            A_0.method_68(A_1);
        }
        A_0.builtinStyle_0 = A_2;
        this.stack_5.Push((this.class751_1 == null) ? null : this.class751_1);
        this.class751_1 = A_0;
        int count = this.stack_0.Count;
        this.method_66(A_3);
        this.class751_1 = this.stack_5.Pop();
        this.method_94(count == this.stack_0.Count);
        if (this.paragraph_0 != null)
        {
            if (A_0.method_91() < 0f)
            {
                this.paragraph_0.Format.BeforeAutoSpacing = true;
            }
            if (A_0.method_93() < 0f)
            {
                this.paragraph_0.Format.AfterAutoSpacing = true;
            }
            this.paragraph_0.BreakCharacterFormat.Hidden = A_0.method_8();
        }
        this.paragraph_0 = null;
    }

    protected void method_4(Class751 A_0)
    {
        if (this.stack_0.Count > 0)
        {
            this.stack_0.Pop();
            this.stack_0.Push(A_0);
        }
        else
        {
            this.class751_0 = A_0;
        }
    }

    private void method_40(XmlNode A_0)
    {
        this.bool_10 = true;
        this.int_2++;
        this.method_42(A_0);
    }

    private void method_41()
    {
        this.int_2--;
        if (this.int_2 == 0)
        {
            this.bool_10 = false;
        }
        this.method_46();
    }

    private void method_42(XmlNode A_0)
    {
        int num = 11;
        this.method_35(A_0);
        bool flag = false;
        if ((this.stack_15.Count > 0) && this.stack_15.Peek())
        {
            this.stack_16.Push(true);
        }
        else
        {
            this.stack_16.Push(false);
        }
        if (this.bool_6)
        {
            flag = true;
            Class751 item = (this.class751_1 != null) ? this.class751_1.method_97() : null;
            this.stack_6.Push(item);
            if ((this.paragraph_0 != null) && (this.paragraph_0.Items.Count > 0))
            {
                this.paragraph_0 = null;
            }
        }
        this.stack_7.Push(true);
        this.bool_6 = true;
        HorizontalAlignment alignment = this.method_100(this.method_97(A_0, BookmarkStart.b("倰弲尴倶圸", num)).ToLower(), HorizontalAlignment.Left);
        bool flag2 = false;
        bool flag3 = false;
        flag2 = this.method_82(A_0, ref flag3);
        if ((this.class751_1 != null) && (this.stack_0.Count > 0))
        {
            short num2 = this.class751_1.method_30();
            short num3 = this.class751_1.method_32();
            if (flag2)
            {
                this.class751_1 = this.stack_0.Peek();
            }
            else
            {
                this.method_96();
                this.class751_1 = this.stack_0.Peek();
                this.class751_1.class752_0 = new Class752(null);
                this.class751_1.method_88(this.class751_1.method_16());
                this.class751_1.method_98(0x19);
                this.class751_1.method_99();
            }
            this.class751_1.method_35(num2);
            this.class751_1.method_37(num3);
        }
        else if (!flag2)
        {
            this.method_96();
            this.class751_1 = this.stack_0.Peek();
            this.class751_1.method_98(0x19);
            this.class751_1.method_99();
        }
        else
        {
            this.class751_1 = this.stack_0.Peek();
        }
        this.stack_5.Push(this.class751_1);
        if (flag3)
        {
            this.class751_1.bool_2 = true;
            this.bool_3 = false;
        }
        else
        {
            this.class751_1.bool_2 = false;
        }
        if ((this.class751_1 == null) && (alignment != HorizontalAlignment.Left))
        {
            this.class751_1 = new Class751();
            if (!this.class751_1.method_102(10))
            {
                this.class751_1.method_84(alignment);
            }
        }
        Class51 class2 = this.method_43(this.class751_1, flag);
        if (!flag)
        {
            this.bodyRegionCollection_0.Document.WebSettings.method_5().method_6(class2);
        }
        else
        {
            this.stack_14.Peek().method_13().method_6(class2);
        }
        this.stack_14.Push(class2);
    }

    private Class51 method_43(Class751 A_0, bool A_1)
    {
        Class51 class2 = new Class51(this.bodyRegionCollection_0.Document);
        class2.method_8(this.method_44());
        if (A_1)
        {
            class2.method_10(this.stack_14.Peek().method_7());
        }
        class2.method_5().Left = A_0.method_85() + ((this.stack_6.Count == 0) ? 0f : this.stack_6.Peek().method_16());
        class2.method_5().Top = A_0.method_91();
        class2.method_5().Right = A_0.method_89();
        class2.method_5().Bottom = A_0.method_93();
        A_0.method_99();
        this.method_45(A_0, class2.method_6());
        A_0.class752_0 = new Class752(null);
        A_0.method_100();
        return class2;
    }

    private int method_44()
    {
        return ++this.int_3;
    }

    private void method_45(Class751 A_0, Borders A_1)
    {
        A_1.Left.LineWidth = (A_0.class752_0.float_0 != -1f) ? A_0.class752_0.float_0 : ((A_0.class752_0.float_3 != -1f) ? A_0.class752_0.float_3 : 0f);
        A_1.Left.BorderType = A_0.class752_0.borderStyle_3;
        A_1.Left.Color = A_0.class752_0.color_3;
        A_1.Left.Space = A_0.method_16();
        A_1.Top.LineWidth = (A_0.class752_0.float_0 != -1f) ? A_0.class752_0.float_0 : ((A_0.class752_0.float_1 != -1f) ? A_0.class752_0.float_1 : 0f);
        A_1.Top.BorderType = A_0.class752_0.borderStyle_1;
        A_1.Top.Color = A_0.class752_0.color_1;
        A_1.Top.Space = A_0.method_20();
        A_1.Right.LineWidth = (A_0.class752_0.float_0 != -1f) ? A_0.class752_0.float_0 : ((A_0.class752_0.float_4 != -1f) ? A_0.class752_0.float_4 : 0f);
        A_1.Right.BorderType = A_0.class752_0.borderStyle_4;
        A_1.Right.Color = A_0.class752_0.color_4;
        A_1.Right.Space = A_0.method_18();
        A_1.Bottom.LineWidth = (A_0.class752_0.float_0 != -1f) ? A_0.class752_0.float_0 : ((A_0.class752_0.float_2 != -1f) ? A_0.class752_0.float_2 : 0f);
        A_1.Bottom.BorderType = A_0.class752_0.borderStyle_2;
        A_1.Bottom.Color = A_0.class752_0.color_2;
        A_1.Bottom.Space = A_0.method_22();
    }

    private void method_46()
    {
        if (((this.class751_1 != null) && this.class751_1.bool_2) && ((this.paragraph_0 != null) && !this.paragraph_0.IsInCell))
        {
            this.method_5().Format.PageBreakAfter = true;
            this.bool_3 = false;
        }
        this.class751_1 = (this.stack_5.Count > 0) ? this.stack_5.Pop() : null;
        this.class751_1 = (this.stack_6.Count > 0) ? this.stack_6.Pop() : this.class751_1;
        this.stack_7.Pop();
        this.bool_6 = this.stack_7.Count > 0;
        this.stack_0.Pop();
        if (this.stack_14.Count > 0)
        {
            this.stack_14.Pop();
        }
        if (this.stack_16.Count > 0)
        {
            this.stack_16.Pop();
        }
        this.paragraph_0 = null;
    }

    private void method_47(XmlNode A_0)
    {
        bool flag;
        if (this.bool_9)
        {
            Class751 item = (this.class751_2 != null) ? this.class751_2.method_97() : null;
            this.stack_8.Push(item);
        }
        this.bool_9 = true;
        if (flag = this.method_81(A_0))
        {
            this.class751_2 = this.stack_0.Peek().method_97();
            this.method_74();
        }
        this.stack_9.Push(flag);
    }

    private void method_48()
    {
        this.class751_2 = (this.stack_8.Count > 0) ? this.stack_8.Pop() : null;
        this.bool_9 = this.stack_8.Count > 0;
        this.stack_9.Pop();
        this.paragraph_0 = null;
    }

    private void method_49()
    {
        this.table_0.method_63();
        this.table_0 = this.stack_2.Pop();
        this.bodyRegionCollection_0 = this.stack_1.Pop();
        this.bool_5 = this.stack_4.Pop();
        this.paragraph_0 = null;
    }

    protected Paragraph method_5()
    {
        if (this.paragraph_0 == null)
        {
            this.paragraph_0 = new Paragraph(this.bodyRegionCollection_0.Document);
            this.bodyRegionCollection_0.Add(this.paragraph_0);
            if ((this.method_0() != null) && (((this.stack_15.Count == 0) || (this.stack_16.Count == 0)) || this.stack_16.Peek()))
            {
                this.paragraph_0.Format.DivId = this.method_0().method_7();
            }
            this.method_67();
            this.method_73();
            if (this.bool_9)
            {
                this.method_74();
            }
            if (this.iparagraphStyle_0 != null)
            {
                this.paragraph_0.method_65(this.iparagraphStyle_0);
            }
        }
        return this.paragraph_0;
    }

    private void method_50()
    {
        this.stack_1.Push(this.bodyRegionCollection_0);
        this.stack_2.Push(this.table_0);
        this.stack_4.Push(this.bool_5);
    }

    private void method_51(XmlNode A_0)
    {
        int num = 5;
        HyperlinkType none = HyperlinkType.None;
        string item = string.Empty;
        string str2 = string.Empty;
        string str3 = string.Empty;
        bool flag = false;
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str4 = attribute.Name.ToLower();
            if (str4 != null)
            {
                if (str4 != BookmarkStart.b("䌪弬䨮地", num))
                {
                    if (str4 != BookmarkStart.b("弪䰬崮嘰嘲䄴", num))
                    {
                        if (!(str4 == BookmarkStart.b("䔪䰬䈮吰", num)))
                        {
                            if (str4 == BookmarkStart.b("䈪䤬", num))
                            {
                                str3 = attribute.Value;
                            }
                        }
                        else
                        {
                            str2 = attribute.Value;
                        }
                    }
                    else
                    {
                        string text1 = attribute.Value;
                    }
                }
                else
                {
                    item = attribute.Value;
                    flag = true;
                }
            }
        }
        if (!this.list_1.Contains(str2) && this.list_1.Contains(str3))
        {
            str2 = str3;
        }
        this.method_52(str2, true);
        if (item.StartsWith(BookmarkStart.b("ࠪ", num)))
        {
            none = HyperlinkType.Bookmark;
            item = item.Replace(BookmarkStart.b("ࠪ", num), string.Empty);
            if (!this.list_1.Contains(item))
            {
                this.list_1.Add(item);
            }
        }
        else if (item.StartsWith(BookmarkStart.b("䘪䰬䘮崰䜲娴ശ", num)))
        {
            none = HyperlinkType.EMailLink;
        }
        else if (!item.StartsWith(BookmarkStart.b("䌪夬嬮䄰", num)) && !item.StartsWith(BookmarkStart.b("尪娬堮", num)))
        {
            none = HyperlinkType.FileLink;
            item = this.method_1() + item;
        }
        else
        {
            none = HyperlinkType.WebLink;
        }
        if (A_0.HasChildNodes)
        {
            if (flag)
            {
                this.method_53(item, none);
            }
            this.method_21(A_0.ChildNodes);
            if (this.stack_17.Count > 0)
            {
                this.method_54();
            }
        }
        this.method_52(str2, false);
    }

    private void method_52(string A_0, bool A_1)
    {
        if (!string.IsNullOrEmpty(A_0))
        {
            if (A_1)
            {
                this.method_5().AppendBookmarkStart(A_0);
            }
            else
            {
                this.method_5().AppendBookmarkEnd(A_0);
            }
        }
    }

    private void method_53(string A_0, HyperlinkType A_1)
    {
        int num = 9;
        Field item = new Field(this.method_5().Document) {
            Type = FieldType.FieldHyperlink
        };
        this.stack_17.Push(item);
        this.method_5().Items.Add(item);
        FieldMark entity = new FieldMark(this.method_5().Document, FieldMarkType.FieldSeparator);
        this.method_5().Items.Add(entity);
        item.Separator = entity;
        Hyperlink hyperlink = new Hyperlink(item) {
            Type = A_1
        };
        if ((A_1 != HyperlinkType.WebLink) && (A_1 != HyperlinkType.EMailLink))
        {
            if (hyperlink.Type == HyperlinkType.Bookmark)
            {
                hyperlink.BookmarkName = A_0;
                item.Code = BookmarkStart.b("༮礰樲攴父欸眺琼焾ੀ捂敄ᭆ╈歊潌", num) + A_0 + BookmarkStart.b("മ", num);
            }
            else if (hyperlink.Type == HyperlinkType.FileLink)
            {
                hyperlink.FilePath = A_0;
            }
        }
        else
        {
            hyperlink.Uri = A_0;
        }
    }

    private void method_54()
    {
        FieldMark entity = new FieldMark(this.method_5().Document, FieldMarkType.FieldEnd);
        this.method_5().Items.Add(entity);
        this.stack_17.Pop().End = entity;
    }

    private void method_55(ITextRange A_0)
    {
        if (this.stack_17.Count > 0)
        {
            A_0.CharacterFormat.method_55(Color.Blue);
            A_0.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
        }
    }

    private void method_56(XmlNode A_0, IPicture A_1)
    {
        int num = 3;
        bool flag = false;
        bool flag2 = false;
        string str = string.Empty;
        string str2 = string.Empty;
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str5 = attribute.Name.ToLower();
            if (str5 != null)
            {
                if (str5 != BookmarkStart.b("䄨个䐬䠮夰䜲", num))
                {
                    if (str5 != BookmarkStart.b("帨䈪䤬嬮夰", num))
                    {
                        if (str5 != BookmarkStart.b("嬨䐪夬丮䔰嘲", num))
                        {
                            if (!(str5 == BookmarkStart.b("娨弪听䌮吰", num)))
                            {
                                if (str5 == BookmarkStart.b("䠨䜪䐬䠮弰", num))
                                {
                                    str2 = attribute.Value.ToLower();
                                }
                            }
                            else
                            {
                                string[] strArray = attribute.Value.Split(new char[] { ';', ':' });
                                int index = 0;
                                int length = strArray.Length;
                                while (index < (length - 1))
                                {
                                    string str7 = strArray[index].ToLower().Trim();
                                    string str3 = strArray[index + 1].ToLower().Trim();
                                    string str6 = str7;
                                    if (str6 != null)
                                    {
                                        if (str6 != BookmarkStart.b("䄨个䐬䠮夰䜲", num))
                                        {
                                            if (!(str6 == BookmarkStart.b("帨䈪䤬嬮夰", num)))
                                            {
                                                if (str6 == BookmarkStart.b("伨䜪䈬丮䔰", num))
                                                {
                                                    str = str3;
                                                }
                                            }
                                            else
                                            {
                                                float num4 = Convert.ToSingle(this.method_79(str3));
                                                if (num4 > 0f)
                                                {
                                                    A_1.Width = num4;
                                                    flag2 = true;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            A_1.Height = Convert.ToSingle(this.method_79(str3));
                                            flag = true;
                                        }
                                    }
                                    index += 2;
                                }
                            }
                        }
                        else
                        {
                            (A_1 as DocPicture).Rotation = Convert.ToSingle(attribute.Value);
                        }
                    }
                    else
                    {
                        A_1.Width = Convert.ToSingle(this.method_79(attribute.Value));
                        flag2 = true;
                    }
                }
                else
                {
                    A_1.Height = Convert.ToSingle(this.method_79(attribute.Value));
                    flag = true;
                }
            }
        }
        if ((str != BookmarkStart.b("嬨䈪䨬䜮䔰", num)) && ((str2 != BookmarkStart.b("嬨䈪䨬䜮䔰", num)) || !string.IsNullOrEmpty(str)))
        {
            if ((str == BookmarkStart.b("䔨个䬬嬮", num)) || (str2 == BookmarkStart.b("䔨个䬬嬮", num)))
            {
                A_1.TextWrappingStyle = TextWrappingStyle.Square;
                A_1.HorizontalAlignment = ShapeHorizontalAlignment.Left;
                A_1.HorizontalOrigin = HorizontalOrigin.Column;
                A_1.VerticalAlignment = ShapeVerticalAlignment.None;
                A_1.VerticalOrigin = VerticalOrigin.Line;
            }
        }
        else
        {
            A_1.TextWrappingStyle = TextWrappingStyle.Square;
            A_1.HorizontalAlignment = ShapeHorizontalAlignment.Right;
            A_1.HorizontalOrigin = HorizontalOrigin.Column;
            A_1.VerticalAlignment = ShapeVerticalAlignment.None;
            A_1.VerticalOrigin = VerticalOrigin.Line;
        }
        if (!flag2 && (A_1.Image != null))
        {
            A_1.Width = A_1.Image.Width * 0.75f;
        }
        if (!flag && (A_1.Image != null))
        {
            A_1.Height = A_1.Image.Height * 0.75f;
        }
    }

    private void method_57(XmlNode A_0)
    {
        int num = 0x12;
        string str = this.method_97(A_0, BookmarkStart.b("䬷䠹弻", 0x12));
        IPicture picture = new DocPicture(this.bodyRegionCollection_0.Document);
        try
        {
            byte[] imageBytes = this.method_59(str);
            if ((imageBytes != null) && (imageBytes.Length > 0))
            {
                picture = this.method_5().AppendPicture(imageBytes);
            }
            else
            {
                if (Uri.IsWellFormedUriString(str, UriKind.Absolute))
                {
                    using (WebClient client2 = new WebClient())
                    {
                        client2.Credentials = CredentialCache.DefaultCredentials;
                        client2.Headers.Set(BookmarkStart.b("䴷䤹夻䰽洿⍁⍃⍅♇㹉", num), BookmarkStart.b("男唹䘻圽ⰿ⹁╃楅籇摉籋湍硏ㅑ㭓㭕⡗㭙⡛㝝ɟ๡ţ嵥䡧❩㽫❭㕯剱䱳塵䡷䅹屻⥽ﾇ黎겋삍쒏늑ꊓ뢕ꢗꆙ벛쪝튟쮡삣쎥욧\udea9\u83ab骭麯花鶳", num));
                        using (Stream stream2 = client2.OpenRead(str))
                        {
                            picture = this.method_5().AppendPicture(Image.FromStream(stream2));
                        }
                        goto Label_01AA;
                    }
                }
                if (this.uri_0 != null)
                {
                    Uri address = new Uri(this.uri_0, str);
                    using (WebClient client = new WebClient())
                    {
                        client.Credentials = CredentialCache.DefaultCredentials;
                        client.Headers.Set(BookmarkStart.b("䴷䤹夻䰽洿⍁⍃⍅♇㹉", num), BookmarkStart.b("男唹䘻圽ⰿ⹁╃楅籇摉籋湍硏ㅑ㭓㭕⡗㭙⡛㝝ɟ๡ţ嵥䡧❩㽫❭㕯剱䱳塵䡷䅹屻⥽ﾇ黎겋삍쒏늑ꊓ뢕ꢗꆙ벛쪝튟쮡삣쎥욧\udea9\u83ab骭麯花鶳", num));
                        using (Stream stream = client.OpenRead(address))
                        {
                            picture = this.method_5().AppendPicture(Image.FromStream(stream));
                        }
                        goto Label_01AA;
                    }
                }
                if (File.Exists(str))
                {
                    picture = this.method_5().AppendPicture(Image.FromFile(str));
                }
                else if (File.Exists(this.method_58(this.method_1(), str)))
                {
                    picture = this.method_5().AppendPicture(Image.FromFile(this.method_58(this.method_1(), str)));
                }
            }
        }
        catch (Exception)
        {
        }
    Label_01AA:
        if (picture.Image == null)
        {
            Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(BookmarkStart.b("欷䨹唻䰽┿汁C⥅⭇摉ṋ⭍⍏㵑⅓⑕㭗㽙⽛灝ၟୡݣብᵧᡩ५ㅭṯᵱsၵ᝷ཹቻ᩽깿", num));
            picture = this.method_5().AppendPicture(Image.FromStream(manifestResourceStream));
            if (this.stack_17.Count > 0)
            {
                string str2 = this.method_97(A_0, BookmarkStart.b("夷嘹䠻", num));
                if (!string.IsNullOrEmpty(str2) && (str2.Length > 0))
                {
                    str2 = this.method_150(str2);
                    TextRange range = this.method_5().AppendText(str2);
                    range.CharacterFormat.method_55(Color.Blue);
                    range.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
                    this.method_75(range);
                }
            }
        }
        if (this.method_5().Owner is TableCell)
        {
            TableCell owner = this.method_5().Owner as TableCell;
            TableRow ownerRow = owner.OwnerRow;
            if ((ownerRow.Height < picture.Height) && (ownerRow.HeightType == TableRowHeightType.Exactly))
            {
                ownerRow.Height = picture.Height;
            }
        }
        this.method_56(A_0, picture);
    }

    private string method_58(string A_0, string A_1)
    {
        int num = 10;
        if ((!A_0.EndsWith(BookmarkStart.b("氯渱", 10)) && !A_0.EndsWith(BookmarkStart.b("Ἧ", num))) && (!A_1.StartsWith(BookmarkStart.b("氯", num)) && !A_1.StartsWith(BookmarkStart.b("Ἧ", num))))
        {
            return (A_0 + BookmarkStart.b("Ἧ", num) + A_1);
        }
        return (A_0 + A_1);
    }

    private byte[] method_59(string A_0)
    {
        int index = A_0.IndexOf(',');
        if (index == -1)
        {
            return null;
        }
        string input = A_0.Substring(0, index + 1).Trim();
        Match match = this.regex_3.Match(input);
        if ((match == null) || !match.Success)
        {
            return null;
        }
        string s = A_0.Substring(index + 1);
        if (match.Groups[3].Value.Length > 0)
        {
            return Convert.FromBase64String(s);
        }
        return HttpUtility.UrlDecodeToBytes(s);
    }

    private Stack<ListStyle> method_6()
    {
        if (this.stack_3 == null)
        {
            this.stack_3 = new Stack<ListStyle>();
        }
        return this.stack_3;
    }

    private void method_60(XmlNode A_0)
    {
        int num = 12;
        string str = A_0.Name.ToLower();
        string attribute = string.Empty;
        if (str != BookmarkStart.b("䄱圳䐵儷䨹䠻", 12))
        {
            Class751 class2 = this.method_77(A_0);
            int count = this.stack_0.Count;
            bool flag = false;
            string key = str;
            if (key != null)
            {
                int num3;
                if (Class1160.dictionary_128 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x17);
                    dictionary1.Add(BookmarkStart.b("倱", num), 0);
                    dictionary1.Add(BookmarkStart.b("䄱䀳䐵圷吹嬻", num), 1);
                    dictionary1.Add(BookmarkStart.b("嬱", num), 2);
                    dictionary1.Add(BookmarkStart.b("圱夳", num), 3);
                    dictionary1.Add(BookmarkStart.b("儱崳䈵崷", num), 4);
                    dictionary1.Add(BookmarkStart.b("嘱刳堵", num), 5);
                    dictionary1.Add(BookmarkStart.b("䐱唳䐵", num), 6);
                    dictionary1.Add(BookmarkStart.b("䜱", num), 7);
                    dictionary1.Add(BookmarkStart.b("䄱", num), 8);
                    dictionary1.Add(BookmarkStart.b("䄱䀳䐵儷儹夻", num), 9);
                    dictionary1.Add(BookmarkStart.b("䄱夳圵吷嘹", num), 10);
                    dictionary1.Add(BookmarkStart.b("倱崳儵", num), 11);
                    dictionary1.Add(BookmarkStart.b("儱嬳刵崷", num), 12);
                    dictionary1.Add(BookmarkStart.b("䘱䀳", num), 13);
                    dictionary1.Add(BookmarkStart.b("䈱䘳匵", num), 14);
                    dictionary1.Add(BookmarkStart.b("䄱唳嬵䠷", num), 15);
                    dictionary1.Add(BookmarkStart.b("吱嬳堵䰷", num), 0x10);
                    dictionary1.Add(BookmarkStart.b("䜱堳", num), 0x11);
                    dictionary1.Add(BookmarkStart.b("崱堳", num), 0x12);
                    dictionary1.Add(BookmarkStart.b("匱", num), 0x13);
                    dictionary1.Add(BookmarkStart.b("䄱䄳䘵", num), 20);
                    dictionary1.Add(BookmarkStart.b("䄱䄳吵", num), 0x15);
                    dictionary1.Add(BookmarkStart.b("䄱䐳圵嘷", num), 0x16);
                    Class1160.dictionary_128 = dictionary1;
                }
                if (Class1160.dictionary_128.TryGetValue(key, out num3))
                {
                    switch (num3)
                    {
                        case 0:
                        case 1:
                            class2.method_41(true);
                            break;

                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            class2.method_43(true);
                            break;

                        case 7:
                            class2.method_46(true);
                            break;

                        case 8:
                        case 9:
                            class2.method_48(true);
                            break;

                        case 10:
                            if (class2.method_67() < 0f)
                            {
                                class2.method_68(10f);
                            }
                            class2.method_68(class2.method_67() - 2f);
                            break;

                        case 11:
                            class2.method_68(class2.method_67() + 2f);
                            break;

                        case 12:
                        case 13:
                        case 14:
                        case 15:
                            class2.method_56(BookmarkStart.b("焱嬳䌵䨷匹夻䰽怿ు⅃ㅅ", num));
                            class2.method_68(10f);
                            break;

                        case 0x10:
                        {
                            string str4 = this.method_97(A_0, BookmarkStart.b("儱嬳娵圷䠹", num));
                            string str5 = this.method_97(A_0, BookmarkStart.b("吱唳唵崷", num));
                            if (str4.Length > 0)
                            {
                                class2.method_52(Class1007.smethod_0(str4));
                            }
                            if (str5.Length > 0)
                            {
                                class2.method_56(str5);
                            }
                            string str6 = this.method_97(A_0, BookmarkStart.b("䄱崳䰵崷", num));
                            if ((str6.Length > 0) && class2.method_71())
                            {
                                this.method_64(str6, class2);
                            }
                            break;
                        }
                        case 0x11:
                            this.paragraph_0 = null;
                            if (!class2.bool_5)
                            {
                                this.stack_12.Push(true);
                                flag = true;
                                this.method_65(true, A_0, class2);
                            }
                            break;

                        case 0x12:
                            this.paragraph_0 = null;
                            if (!class2.bool_5)
                            {
                                this.stack_12.Push(true);
                                flag = true;
                                this.method_65(false, A_0, class2);
                            }
                            break;

                        case 0x13:
                            class2.method_52(Color.Blue);
                            class2.method_46(true);
                            break;

                        case 20:
                            class2.method_50(SubSuperScript.SuperScript);
                            break;

                        case 0x15:
                            class2.method_50(SubSuperScript.SubScript);
                            break;

                        case 0x16:
                        {
                            XmlElement element = A_0 as XmlElement;
                            if (element != null)
                            {
                                attribute = element.GetAttribute(BookmarkStart.b("嬱倳", num));
                            }
                            break;
                        }
                    }
                }
            }
            if (A_0.HasChildNodes && !string.IsNullOrEmpty(attribute))
            {
                this.method_52(attribute, true);
            }
            this.method_21(A_0.ChildNodes);
            if (A_0.HasChildNodes && !string.IsNullOrEmpty(attribute))
            {
                this.method_52(attribute, false);
            }
            if (flag)
            {
                this.stack_12.Pop();
                this.paragraph_0 = null;
            }
            this.method_94(count == this.stack_0.Count);
        }
    }

    private void method_61(XmlNode A_0)
    {
        int num = 5;
        string text = null;
        string str2 = null;
        string str3 = null;
        string key = null;
        string str5 = null;
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str6 = attribute.LocalName.ToLower();
            if (str6 != null)
            {
                if (str6 != BookmarkStart.b("伪䰬嬮倰Ḳ䀴䐶尸䤺", num))
                {
                    if (str6 != BookmarkStart.b("伪䰬嬮倰Ḳ儴嘶䴸帺", num))
                    {
                        if (str6 != BookmarkStart.b("伪䰬嬮倰Ḳ嘴堶吸嘺堼儾㕀", num))
                        {
                            if (!(str6 == BookmarkStart.b("伪䰬嬮倰Ḳ嘴帶崸", num)))
                            {
                                if (str6 == BookmarkStart.b("伪䰬嬮倰Ḳ䔴嘶䬸帺匼䬾汀⁂ⱄ⍆", num))
                                {
                                    str5 = attribute.Value;
                                }
                            }
                            else
                            {
                                key = attribute.Value;
                            }
                        }
                        else
                        {
                            text = attribute.Value;
                        }
                    }
                    else
                    {
                        str3 = attribute.Value;
                    }
                }
                else
                {
                    str2 = attribute.Value;
                }
            }
        }
        if (((text != null) && !this.dictionary_1.ContainsKey(key)) && (A_0.ChildNodes.Count != 0))
        {
            DateTime time;
            int num5 = Class323.smethod_0().Next();
            CommentMark entity = new CommentMark(this.method_5().Document, num5) {
                Type = CommentMarkType.CommentStart
            };
            CommentMark mark = new CommentMark(this.method_5().Document, num5) {
                Type = CommentMarkType.CommentEnd
            };
            if (str5 != null)
            {
                this.dictionary_2.Add(key, str5);
            }
            this.dictionary_1.Add(key, num5);
            if (!this.method_63(A_0))
            {
                BookmarkStart start = new BookmarkStart(this.method_5().Document, key);
                this.method_5().Items.Add(start);
            }
            int count = this.method_5().Items.Count;
            this.method_5().Items.Insert(count, entity);
            if (A_0.HasChildNodes)
            {
                this.method_21(A_0.ChildNodes);
            }
            int index = this.method_5().Items.Count;
            this.method_5().Items.Insert(index, mark);
            Comment comment2 = this.method_5().AppendComment(text);
            comment2.Format.CommentId = num5;
            if (!this.method_63(A_0))
            {
                BookmarkEnd end = new BookmarkEnd(this.method_5().Document, key);
                this.method_5().Items.Add(end);
            }
            if (!string.IsNullOrEmpty(str2))
            {
                comment2.Format.Author = str2;
            }
            if (!string.IsNullOrEmpty(str3) && DateTime.TryParse(str3, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.AdjustToUniversal, out time))
            {
                comment2.Format.DateTime = time;
            }
            comment2.CommentMarkStart = entity;
            comment2.CommentMarkEnd = mark;
            for (int i = count + 1; i < index; i++)
            {
                if (!(this.method_5().ChildObjects[i] is CommentMark))
                {
                    comment2.Items.Add(this.method_5().ChildObjects[i]);
                }
            }
            foreach (string str7 in this.dictionary_2.Keys)
            {
                if (this.dictionary_2[str7] == key)
                {
                    int num10 = this.dictionary_1[str7];
                    foreach (DocumentObject obj2 in this.method_5().ChildObjects)
                    {
                        if ((obj2 is Comment) && ((obj2 as Comment).Format.CommentId == num10))
                        {
                            comment2.ReplyCommentItems.method_6(obj2 as Comment);
                        }
                    }
                }
            }
            if (comment2.ReplyCommentItems.Count > 0)
            {
                int commentId = comment2.ReplyCommentItems[comment2.ReplyCommentItems.Count - 1].Format.CommentId;
                this.method_62(comment2, commentId, key);
            }
        }
        else if (!this.dictionary_1.ContainsKey(key))
        {
            if (A_0.ChildNodes.Count == 0)
            {
                DateTime time2;
                int num4 = Class323.smethod_0().Next();
                if (str5 != null)
                {
                    this.dictionary_2.Add(key, str5);
                }
                if (!this.method_63(A_0))
                {
                    BookmarkStart start2 = new BookmarkStart(this.method_5().Document, key);
                    this.method_5().Items.Add(start2);
                }
                Comment comment = this.method_5().AppendComment(text);
                comment.Format.CommentId = num4;
                if (!string.IsNullOrEmpty(str2))
                {
                    comment.Format.Author = str2;
                }
                if (!string.IsNullOrEmpty(str3) && DateTime.TryParse(str3, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.AdjustToUniversal, out time2))
                {
                    comment.Format.DateTime = time2;
                }
                if (!this.method_63(A_0))
                {
                    BookmarkEnd end2 = new BookmarkEnd(this.method_5().Document, key);
                    this.method_5().Items.Add(end2);
                }
                if (string.IsNullOrEmpty(str5))
                {
                    return;
                }
                int num13 = this.dictionary_1[str5];
                using (IEnumerator enumerator4 = this.method_5().ChildObjects.GetEnumerator())
                {
                    DocumentObject current;
                    while (enumerator4.MoveNext())
                    {
                        current = (DocumentObject) enumerator4.Current;
                        if ((current is Comment) && ((current as Comment).Format.CommentId == num13))
                        {
                            goto Label_0733;
                        }
                    }
                    return;
                Label_0733:
                    (current as Comment).ReplyCommentItems.method_6(comment);
                    return;
                }
            }
            this.method_21(A_0.ChildNodes);
        }
        else
        {
            Comment comment3 = null;
            int num12 = 0;
            int num3 = this.method_5().Items.Count - 1;
            this.method_21(A_0.ChildNodes);
            for (int j = 0; j < this.method_5().Items.Count; j++)
            {
                if ((this.method_5().Items[j] is Comment) && ((this.method_5().Items[j] as Comment).Format.CommentId == this.dictionary_1[key]))
                {
                    comment3 = this.method_5().Items[j] as Comment;
                    num12 = j;
                    break;
                }
            }
            if (str5 == null)
            {
                for (int k = num3 + 1; k < this.method_5().Items.Count; k++)
                {
                    if ((!(this.method_5().ChildObjects[k] is CommentMark) && !(this.method_5().ChildObjects[k] is BookmarkStart)) && (!(this.method_5().ChildObjects[k] is BookmarkEnd) && !(this.method_5().ChildObjects[k] is Comment)))
                    {
                        comment3.Items.Add(this.method_5().ChildObjects[k]);
                        ParagraphBase base2 = this.method_5().ChildObjects[k] as ParagraphBase;
                        this.method_5().Items.Remove(base2);
                        this.method_5().Items.Insert(num12 - 1, base2);
                        num12++;
                    }
                }
            }
        }
    }

    private void method_62(Comment A_0, int A_1, string A_2)
    {
        int index = 0;
        int num2 = 0;
        for (int i = 0; i < this.method_5().Items.Count; i++)
        {
            if ((this.method_5().Items[i] is CommentMark) && ((this.method_5().Items[i] as CommentMark).Type == CommentMarkType.CommentEnd))
            {
                if ((this.method_5().Items[i] as CommentMark).CommentId == A_1)
                {
                    index = i;
                }
                else if ((this.method_5().Items[i] as CommentMark).CommentId == A_0.Format.CommentId)
                {
                    num2 = i;
                }
            }
        }
        CommentMark entity = this.method_5().Items[num2] as CommentMark;
        if (this.method_5().Items.Count < (num2 + 3))
        {
            BookmarkEnd end = new BookmarkEnd(this.method_5().Document, A_2);
            this.method_5().Items.Add(end);
        }
        BookmarkEnd end2 = this.method_5().Items[num2 + 2] as BookmarkEnd;
        this.method_5().Items.Remove(end2);
        this.method_5().Items.Remove(entity);
        this.method_5().Items.Remove(A_0);
        this.method_5().Items.Insert(index, end2);
        this.method_5().Items.Insert(index, A_0);
        this.method_5().Items.Insert(index, entity);
        for (int j = this.method_5().Items.Count - 1; j >= 0; j--)
        {
            if (this.method_5().Items[j] is Comment)
            {
                if ((this.method_5().Items[j] as Comment).Format.CommentId != A_1)
                {
                    this.method_62(this.method_5().Items[j] as Comment, A_1, A_2);
                }
                return;
            }
        }
    }

    private bool method_63(XmlNode A_0)
    {
        int num = 7;
        return (((A_0.ParentNode.Name.ToLower() == BookmarkStart.b("䰬", 7)) && (A_0.ParentNode.ChildNodes.Count == 1)) || ((A_0.ChildNodes.Count == 1) && (A_0.ChildNodes[0].Name.ToLower() == BookmarkStart.b("䰬", num))));
    }

    private void method_64(string A_0, Class751 A_1)
    {
        int num = 10;
        bool flag = false;
        bool flag2 = false;
        bool flag3 = false;
        if (A_0.StartsWith(BookmarkStart.b("ᬯ", 10)))
        {
            flag = true;
            A_0 = A_0.Substring(1, A_0.Length - 1);
        }
        else if (A_0.StartsWith(BookmarkStart.b("ᴯ", num)))
        {
            flag2 = true;
            A_0 = A_0.Substring(1, A_0.Length - 1);
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (!char.IsDigit(c))
            {
                flag3 = true;
                break;
            }
            flag3 = false;
        }
        if (flag3)
        {
            A_1.method_68(12f);
        }
        else
        {
            int num2 = Convert.ToInt32(A_0);
            if (flag)
            {
                num2 = 3 + num2;
            }
            else if (flag2)
            {
                num2 = 3 - num2;
            }
            if (num2 <= 1)
            {
                A_1.method_68(7.5f);
            }
            else if (num2 >= 7)
            {
                A_1.method_68(36f);
            }
            else
            {
                switch (num2)
                {
                    case 2:
                        A_1.method_68(10f);
                        return;

                    case 3:
                        A_1.method_68(12f);
                        return;

                    case 4:
                        A_1.method_68(13.5f);
                        return;

                    case 5:
                        A_1.method_68(18f);
                        return;

                    case 6:
                        A_1.method_68(24f);
                        return;
                }
            }
        }
    }

    private void method_65(bool A_0, XmlNode A_1, Class751 A_2)
    {
        int num = 0x12;
        if (A_0)
        {
            A_2.bool_1 = true;
        }
        else
        {
            A_2.bool_0 = true;
        }
        if (((A_1.ParentNode != null) && (A_1.ParentNode.Name != null)) && ((A_1.ParentNode.Name.ToLower() == BookmarkStart.b("倷丹儻刽", num)) || (A_1.ParentNode.Name.ToLower() == BookmarkStart.b("娷唹堻䜽", num))))
        {
            this.int_0 = -1;
        }
    }

    private void method_66(XmlNode A_0)
    {
        int num = 9;
        if (!this.method_29(A_0))
        {
            this.method_27();
        }
        if (this.paragraph_0 != null)
        {
            this.method_71(this.paragraph_0.Format, this.method_3(), A_0);
            if (this.method_3().method_102(0x19) && (this.paragraph_0.ListFormat.CurrentListLevel != null))
            {
                ParagraphFormat format = this.paragraph_0.Format;
                format.LeftIndent += this.method_3().method_16();
            }
        }
        this.method_67();
        if ((A_0.HasChildNodes && (A_0.FirstChild.Name.ToLower() != BookmarkStart.b("弮", num))) || !A_0.HasChildNodes)
        {
            this.method_68(A_0);
        }
        this.method_21(A_0.ChildNodes);
    }

    private void method_67()
    {
        Class751 class2 = this.method_3();
        if (this.paragraph_0 != null)
        {
            if (this.iparagraphStyle_0 == null)
            {
                if (class2.builtinStyle_0 == BuiltinStyle.Normal)
                {
                    this.paragraph_0.ApplyStyle(BuiltinStyle.NormalWeb);
                }
                else
                {
                    this.paragraph_0.ApplyStyle(class2.builtinStyle_0);
                    if (!class2.method_95())
                    {
                        BuiltinStyle style2 = class2.builtinStyle_0;
                        string name = Style.smethod_4(style2);
                        IStyle style = this.paragraph_0.Document.Styles.FindByName(name, StyleType.ParagraphStyle) as IParagraphStyle;
                        if (style is ParagraphStyle)
                        {
                            this.method_69(class2, (style as ParagraphStyle).ParagraphFormat);
                            this.method_70(class2, (style as ParagraphStyle).CharacterFormat);
                            this.method_3().builtinStyle_0 = style2;
                            this.method_3().method_96(true);
                        }
                    }
                }
            }
            else
            {
                this.paragraph_0.method_65(this.iparagraphStyle_0);
            }
        }
    }

    private bool method_68(XmlNode A_0)
    {
        int num = 15;
        if (this.paragraph_0 == null)
        {
            return false;
        }
        if (!this.bool_6 || !this.paragraph_0.IsInCell)
        {
            this.method_73();
        }
        if (this.bool_9)
        {
            this.method_74();
        }
        ParagraphFormat format = this.paragraph_0.Format;
        Class751 class2 = this.method_3();
        this.method_67();
        this.method_72(format, class2);
        if (class2.builtinStyle_0 != BuiltinStyle.Normal)
        {
            this.paragraph_0.ApplyStyle(class2.builtinStyle_0);
        }
        else if (this.iparagraphStyle_0 != null)
        {
            this.paragraph_0.method_65(this.iparagraphStyle_0);
        }
        else
        {
            this.paragraph_0.ApplyStyle(BuiltinStyle.NormalWeb);
        }
        this.method_69(class2, format);
        if (this.bool_2)
        {
            format.PageBreakBefore = true;
            this.bool_2 = false;
        }
        if (this.bool_3 && !this.paragraph_0.IsInCell)
        {
            format.PageBreakAfter = true;
            this.bool_3 = false;
        }
        if (A_0.LocalName.ToLower() == BookmarkStart.b("儴匶", num))
        {
            this.paragraph_0.Format.LeftIndent = 36f;
            this.paragraph_0.Format.LeftIndentBi = 36f;
        }
        this.method_95(A_0);
        if ((A_0.LocalName.ToLower() == BookmarkStart.b("头帶", num)) && ((A_0.NextSibling == null) || (A_0.NextSibling.LocalName.ToLower() != BookmarkStart.b("头帶", num))))
        {
            format.AfterAutoSpacing = true;
        }
        if ((A_0.LocalName.ToLower() == BookmarkStart.b("头帶", num)) && ((A_0.PreviousSibling == null) || (A_0.PreviousSibling.LocalName.ToLower() != BookmarkStart.b("头帶", num))))
        {
            format.BeforeAutoSpacing = true;
        }
        if (this.bool_10)
        {
            format.LeftIndent = this.method_5().Format.LeftIndent + (this.int_2 * 36f);
        }
        return true;
    }

    private void method_69(Class751 A_0, ParagraphFormat A_1)
    {
        if (A_0.method_102(0x1b))
        {
            A_1.IsBidi = A_0.method_81();
        }
        if (A_0.method_102(10))
        {
            A_1.HorizontalAlignment = A_0.method_83();
        }
        if (A_0.method_77())
        {
            A_1.AfterAutoSpacing = true;
            A_1.BeforeAutoSpacing = true;
        }
        if (A_0.method_102(8))
        {
            A_1.LineSpacingRule = A_0.method_75();
            A_1.LineSpacing = A_0.method_73();
        }
        if (A_0.method_85() > 0f)
        {
            if (A_1.IsBidi)
            {
                A_1.RightIndent = A_0.method_85();
            }
            else
            {
                A_1.LeftIndent = A_0.method_85();
            }
        }
        if (A_0.method_87() != 0f)
        {
            A_1.FirstLineIndent = A_0.method_87();
        }
        if (A_0.method_89() > 0f)
        {
            if (A_1.IsBidi)
            {
                A_1.LeftIndent = A_0.method_89();
            }
            else
            {
                A_1.RightIndent = A_0.method_89();
            }
        }
        if (A_0.method_93() >= 0f)
        {
            A_1.AfterSpacing = A_0.method_93();
        }
        if (A_0.method_91() >= 0f)
        {
            A_1.BeforeSpacing = A_0.method_91();
        }
        A_0.method_53();
        A_1.BackColor = A_0.method_53();
    }

    private ListStyle method_7()
    {
        if ((this.stack_3 != null) && (this.stack_3.Count != 0))
        {
            return this.stack_3.Peek();
        }
        return null;
    }

    private void method_70(Class751 A_0, CharacterFormat A_1)
    {
        if (A_0.method_102(2))
        {
            A_1.Bold = A_0.method_40();
        }
        if (A_0.method_102(4))
        {
            A_1.Italic = A_0.method_42();
        }
        if (A_0.method_102(3) && A_0.method_45())
        {
            A_1.UnderlineStyle = UnderlineStyle.Single;
        }
        if (A_0.method_102(5) && A_0.method_47())
        {
            A_1.IsStrikeout = true;
        }
        if (A_0.method_102(6) && (A_0.method_51() != Color.Empty))
        {
            A_1.method_55(A_0.method_51());
        }
        if (A_0.method_102(1) && (A_0.method_55().Length > 0))
        {
            char[] trimChars = new char[] { '\'' };
            A_1.FontName = A_0.method_55().Trim(trimChars);
        }
        if (A_0.method_102(0x2a) && !string.IsNullOrEmpty(A_0.method_57()))
        {
            char[] chArray6 = new char[] { '\'' };
            A_1.FontNameFarEast = A_0.method_57().Trim(chArray6);
        }
        if (A_0.method_102(0x2a) && !string.IsNullOrEmpty(A_0.method_59()))
        {
            char[] chArray10 = new char[] { '\'' };
            A_1.FontNameBidi = A_0.method_59().Trim(chArray10);
        }
        if (A_0.method_102(0x2c) && !string.IsNullOrEmpty(A_0.method_61()))
        {
            char[] chArray4 = new char[] { '\'' };
            A_1.LocaleIdASCII = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), A_0.method_61().Trim(chArray4).Replace('-', '_'), true));
        }
        if (A_0.method_102(0x2d) && !string.IsNullOrEmpty(A_0.method_63()))
        {
            char[] chArray12 = new char[] { '\'' };
            A_1.LocaleIdFarEast = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), A_0.method_63().Trim(chArray12).Replace('-', '_'), true));
        }
        if (A_0.method_102(0x2e) && !string.IsNullOrEmpty(A_0.method_65()))
        {
            char[] chArray2 = new char[] { '\'' };
            A_1.LocaleIdBi = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), A_0.method_65().Trim(chArray2).Replace('-', '_'), true));
        }
        if (A_0.method_102(0))
        {
            A_1.FontSize = A_0.method_67();
            if (A_1.Bidi && !A_1.HasKey(350))
            {
                A_1.FontSizeBidi = A_0.method_67();
            }
        }
        if (A_0.method_102(7) && (A_0.method_53() != Color.Empty))
        {
            A_1.TextBackgroundColor = A_0.method_53();
        }
        if (A_0.method_49() != SubSuperScript.None)
        {
            A_1.SubSuperScript = A_0.method_49();
        }
        if (A_0.method_102(0x1c) && A_0.method_79())
        {
            A_1.AllCaps = A_0.method_79();
        }
    }

    private void method_71(ParagraphFormat A_0, Class751 A_1, XmlNode A_2)
    {
        int num = 12;
        if ((A_1.bool_0 || A_1.bool_1) && (((A_2.Name.ToLower() == BookmarkStart.b("帱崳", num)) && (A_2.Name.ToLower() != BookmarkStart.b("帱尳", num))) && ((A_2.ParentNode.Name.ToLower() == BookmarkStart.b("崱堳", num)) || (A_2.ParentNode.Name.ToLower() == BookmarkStart.b("䜱堳", num)))))
        {
            this.method_104(A_2);
        }
        else if (A_2.Name.ToUpper() == BookmarkStart.b("縱簳", num))
        {
            A_0.LeftIndent = 35f;
        }
    }

    private void method_72(ParagraphFormat A_0, Class751 A_1)
    {
        if (A_1.class752_0.borderStyle_0 != BorderStyle.None)
        {
            if (A_1.class752_0.color_0 != Color.Empty)
            {
                A_0.Borders.Bottom.Color = A_1.class752_0.color_2;
                A_0.Borders.Top.Color = A_1.class752_0.color_1;
                A_0.Borders.Left.Color = A_1.class752_0.color_3;
                A_0.Borders.Right.Color = A_1.class752_0.color_4;
            }
            else
            {
                A_0.Borders.Bottom.Color = A_0.Borders.Top.Color = A_0.Borders.Left.Color = A_0.Borders.Right.Color = Color.Silver;
            }
            if (A_1.class752_0.float_0 != -1f)
            {
                A_0.Borders.Bottom.LineWidth = A_1.class752_0.float_2;
                A_0.Borders.Top.LineWidth = A_1.class752_0.float_1;
                A_0.Borders.Left.LineWidth = A_1.class752_0.float_3;
                A_0.Borders.Right.LineWidth = A_1.class752_0.float_4;
            }
            else
            {
                A_0.Borders.Bottom.LineWidth = 1f;
                A_0.Borders.Top.LineWidth = 1f;
                A_0.Borders.Left.LineWidth = 1f;
                A_0.Borders.Right.LineWidth = 1f;
            }
            A_0.Borders.Bottom.BorderType = A_1.class752_0.borderStyle_2;
            A_0.Borders.Top.BorderType = A_1.class752_0.borderStyle_1;
            A_0.Borders.Left.BorderType = A_1.class752_0.borderStyle_3;
            A_0.Borders.Right.BorderType = A_1.class752_0.borderStyle_4;
        }
        if (A_1.class752_0.float_2 >= 0f)
        {
            A_0.Borders.Bottom.LineWidth = A_1.class752_0.float_2;
        }
        A_0.Borders.Bottom.Color = A_1.class752_0.color_2;
        A_0.Borders.Bottom.BorderType = A_1.class752_0.borderStyle_2;
        if (A_1.class752_0.float_1 >= 0f)
        {
            A_0.Borders.Top.LineWidth = A_1.class752_0.float_1;
        }
        A_0.Borders.Top.Color = A_1.class752_0.color_1;
        A_0.Borders.Top.BorderType = A_1.class752_0.borderStyle_1;
        if (A_1.class752_0.float_3 >= 0f)
        {
            A_0.Borders.Left.LineWidth = A_1.class752_0.float_3;
        }
        A_0.Borders.Left.Color = A_1.class752_0.color_3;
        A_0.Borders.Left.BorderType = A_1.class752_0.borderStyle_3;
        if (A_1.class752_0.float_4 >= 0f)
        {
            A_0.Borders.Right.LineWidth = A_1.class752_0.float_4;
        }
        A_0.Borders.Right.Color = A_1.class752_0.color_4;
        A_0.Borders.Right.BorderType = A_1.class752_0.borderStyle_4;
    }

    private void method_73()
    {
        if (this.class751_1 != null)
        {
            ParagraphFormat format = this.paragraph_0.Format;
            if (this.class751_1.method_102(7))
            {
                format.BackColor = this.class751_1.method_53();
            }
            if (this.class751_1.method_102(12))
            {
                format.LeftIndent = this.class751_1.method_85();
            }
            if (this.bool_6 && this.class751_1.method_102(0x19))
            {
                format.LeftIndent += this.class751_1.method_16();
            }
            if (this.class751_1.method_102(0x1b))
            {
                format.IsBidi = this.class751_1.method_81();
            }
            if (this.class751_1.method_102(10))
            {
                format.HorizontalAlignment = this.class751_1.method_83();
            }
            if (this.class751_1.class752_0.borderStyle_0 != BorderStyle.None)
            {
                format.Borders.Bottom.BorderType = this.class751_1.class752_0.borderStyle_2;
                format.Borders.Top.BorderType = this.class751_1.class752_0.borderStyle_1;
                format.Borders.Left.BorderType = this.class751_1.class752_0.borderStyle_3;
                format.Borders.Right.BorderType = this.class751_1.class752_0.borderStyle_4;
                if (this.class751_1.class752_0.color_0 != Color.Empty)
                {
                    format.Borders.Bottom.Color = this.class751_1.class752_0.color_2;
                    format.Borders.Top.Color = this.class751_1.class752_0.color_1;
                    format.Borders.Left.Color = this.class751_1.class752_0.color_3;
                    format.Borders.Right.Color = this.class751_1.class752_0.color_4;
                }
                else
                {
                    format.Borders.Bottom.Color = format.Borders.Top.Color = format.Borders.Left.Color = format.Borders.Right.Color = Color.Silver;
                }
                if (this.class751_1.class752_0.float_0 != -1f)
                {
                    format.Borders.Bottom.LineWidth = this.class751_1.class752_0.float_2;
                    format.Borders.Top.LineWidth = this.class751_1.class752_0.float_1;
                    format.Borders.Left.LineWidth = this.class751_1.class752_0.float_3;
                    format.Borders.Right.LineWidth = this.class751_1.class752_0.float_4;
                }
                else
                {
                    format.Borders.Bottom.LineWidth = 1f;
                    format.Borders.Top.LineWidth = 1f;
                    format.Borders.Left.LineWidth = 1f;
                    format.Borders.Right.LineWidth = 1f;
                }
            }
            if (this.class751_1.class752_0.borderStyle_2 != BorderStyle.None)
            {
                format.Borders.Bottom.BorderType = this.class751_1.class752_0.borderStyle_2;
                format.Borders.Bottom.LineWidth = this.class751_1.class752_0.float_2;
                format.Borders.Bottom.Color = this.class751_1.class752_0.color_2;
            }
            if (this.class751_1.class752_0.borderStyle_1 != BorderStyle.None)
            {
                format.Borders.Top.BorderType = this.class751_1.class752_0.borderStyle_1;
                format.Borders.Top.LineWidth = this.class751_1.class752_0.float_1;
                format.Borders.Top.Color = this.class751_1.class752_0.color_1;
            }
            if (this.class751_1.method_102(0x19))
            {
                format.Borders.Left.Space = this.class751_1.method_16();
            }
            if (this.class751_1.method_102(30))
            {
                format.Borders.Right.Space = this.class751_1.method_18();
            }
            if (this.class751_1.method_102(0x1f))
            {
                format.Borders.Top.Space = this.class751_1.method_20();
            }
            if (this.class751_1.method_102(0x20))
            {
                format.Borders.Bottom.Space = this.class751_1.method_22();
            }
            if (this.bool_2)
            {
                format.PageBreakBefore = true;
                this.bool_2 = false;
            }
            this.paragraph_0.BreakCharacterFormat.Hidden = this.class751_1.method_8();
        }
    }

    private void method_74()
    {
        if (this.class751_2 != null)
        {
            ParagraphFormat format = (this.paragraph_0 == null) ? this.method_5().Format : this.paragraph_0.Format;
            format.BackColor = this.class751_2.method_53();
            format.LeftIndent = this.class751_2.method_85();
            format.IsBidi = this.class751_2.method_81();
            format.HorizontalAlignment = this.class751_2.method_83();
            if (this.class751_2.class752_0.borderStyle_0 != BorderStyle.None)
            {
                format.Borders.Bottom.BorderType = this.class751_2.class752_0.borderStyle_2;
                format.Borders.Top.BorderType = this.class751_2.class752_0.borderStyle_1;
                format.Borders.Left.BorderType = this.class751_2.class752_0.borderStyle_3;
                format.Borders.Right.BorderType = this.class751_2.class752_0.borderStyle_4;
                if (this.class751_1.class752_0.color_0 != Color.Empty)
                {
                    format.Borders.Bottom.Color = this.class751_2.class752_0.color_2;
                    format.Borders.Top.Color = this.class751_2.class752_0.color_1;
                    format.Borders.Left.Color = this.class751_2.class752_0.color_3;
                    format.Borders.Right.Color = this.class751_2.class752_0.color_4;
                }
                else
                {
                    format.Borders.Bottom.Color = format.Borders.Top.Color = format.Borders.Left.Color = format.Borders.Right.Color = Color.Silver;
                }
                if (this.class751_1.class752_0.float_0 != -1f)
                {
                    format.Borders.Bottom.LineWidth = this.class751_2.class752_0.float_2;
                    format.Borders.Top.LineWidth = this.class751_2.class752_0.float_1;
                    format.Borders.Left.LineWidth = this.class751_2.class752_0.float_3;
                    format.Borders.Right.LineWidth = this.class751_2.class752_0.float_4;
                }
                else
                {
                    format.Borders.Bottom.LineWidth = 1f;
                    format.Borders.Top.LineWidth = 1f;
                    format.Borders.Left.LineWidth = 1f;
                    format.Borders.Right.LineWidth = 1f;
                }
            }
            if (this.class751_2.class752_0.borderStyle_2 != BorderStyle.None)
            {
                format.Borders.Bottom.BorderType = this.class751_2.class752_0.borderStyle_2;
                format.Borders.Bottom.LineWidth = this.class751_2.class752_0.float_2;
                format.Borders.Bottom.Color = this.class751_2.class752_0.color_2;
            }
            if (this.class751_2.class752_0.borderStyle_1 != BorderStyle.None)
            {
                format.Borders.Top.BorderType = this.class751_2.class752_0.borderStyle_1;
                format.Borders.Top.LineWidth = this.class751_2.class752_0.float_1;
                format.Borders.Top.Color = this.class751_2.class752_0.color_1;
            }
        }
    }

    private void method_75(ITextRange A_0)
    {
        int num = 2;
        this.method_55(A_0);
        if (!this.bool_6 || !this.paragraph_0.IsInCell)
        {
            this.method_76(A_0);
        }
        Class751 class2 = this.method_3();
        if (!class2.method_95() || !class2.method_72())
        {
            if (((this.iparagraphStyle_0 == null) || !this.iparagraphStyle_0.CharacterFormat.HasKey(60)) && class2.method_102(2))
            {
                A_0.CharacterFormat.Bold = class2.method_40();
            }
            if (class2.method_102(0x1b))
            {
                A_0.CharacterFormat.Bidi = class2.method_81();
            }
            if (class2.method_102(4))
            {
                A_0.CharacterFormat.Italic = class2.method_42();
            }
            if (class2.method_102(3) && class2.method_45())
            {
                A_0.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            }
            if (class2.method_102(5) && class2.method_47())
            {
                A_0.CharacterFormat.IsStrikeout = true;
            }
            if (class2.method_102(6) && (class2.method_51() != Color.Empty))
            {
                A_0.CharacterFormat.method_55(class2.method_51());
            }
            if (class2.method_102(1) && (class2.method_55().Length > 0))
            {
                char[] trimChars = new char[] { '\'' };
                A_0.CharacterFormat.FontName = class2.method_55().Trim(trimChars);
            }
            if (class2.method_102(0x2a) && !string.IsNullOrEmpty(class2.method_57()))
            {
                char[] chArray12 = new char[] { '\'' };
                A_0.CharacterFormat.FontNameFarEast = class2.method_57().Trim(chArray12);
            }
            if (class2.method_102(0x2a) && !string.IsNullOrEmpty(class2.method_59()))
            {
                char[] chArray8 = new char[] { '\'' };
                A_0.CharacterFormat.FontNameBidi = class2.method_59().Trim(chArray8);
            }
            if (class2.method_102(0x2c) && !string.IsNullOrEmpty(class2.method_61()))
            {
                char[] chArray6 = new char[] { '\'' };
                A_0.CharacterFormat.LocaleIdASCII = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), class2.method_61().Trim(chArray6).Replace('-', '_'), true));
            }
            if (class2.method_102(0x2d) && !string.IsNullOrEmpty(class2.method_63()))
            {
                char[] chArray10 = new char[] { '\'' };
                A_0.CharacterFormat.LocaleIdFarEast = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), class2.method_63().Trim(chArray10).Replace('-', '_'), true));
            }
            if (class2.method_102(0x2e) && !string.IsNullOrEmpty(class2.method_65()))
            {
                char[] chArray4 = new char[] { '\'' };
                A_0.CharacterFormat.LocaleIdBi = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), class2.method_65().Trim(chArray4).Replace('-', '_'), true));
            }
            if (class2.method_102(0))
            {
                A_0.CharacterFormat.FontSize = class2.method_67();
                if (A_0.CharacterFormat.Bidi && !A_0.CharacterFormat.HasKey(350))
                {
                    A_0.CharacterFormat.FontSizeBidi = class2.method_67();
                }
            }
            else if ((this.method_5().ParaStyle != null) && this.method_5().ParaStyle.CharacterFormat.HasKey(190))
            {
                A_0.CharacterFormat.FontSize = this.method_5().ParaStyle.CharacterFormat.FontSize;
            }
            else if (!A_0.CharacterFormat.HasKey(190))
            {
                ParagraphStyle style = A_0.Document.Styles.FindByName(BookmarkStart.b("昧䔩師䌭儯帱ᐳḵ漷弹帻᜽", num)) as ParagraphStyle;
                if (style != null)
                {
                    A_0.CharacterFormat.FontSize = (style.CharacterFormat.FontSize != 12f) ? style.CharacterFormat.FontSize : 12f;
                }
                else
                {
                    A_0.CharacterFormat.FontSize = 12f;
                }
            }
            if ((class2.method_102(7) && (class2.method_53() != Color.Empty)) && (class2.method_53().A != 0))
            {
                A_0.CharacterFormat.TextBackgroundColor = class2.method_53();
            }
            if (class2.method_102(0x2f))
            {
                A_0.CharacterFormat.CharacterSpacing = class2.method_69();
            }
            if (class2.method_49() != SubSuperScript.None)
            {
                A_0.CharacterFormat.SubSuperScript = class2.method_49();
            }
            if (class2.method_102(0x1c))
            {
                A_0.CharacterFormat.AllCaps = class2.method_79();
            }
            if (class2.method_102(0x25))
            {
                A_0.CharacterFormat.Hidden = class2.method_8();
            }
            if (class2.method_4())
            {
                A_0.CharacterFormat.IsInsertRevision = true;
                A_0.CharacterFormat.InsertRevision = new Class579(EditRevisionType.Insertion);
                if (class2.method_102(0x26))
                {
                    A_0.CharacterFormat.InsertRevision.method_1(class2.method_0());
                }
                if (class2.method_102(0x27))
                {
                    A_0.CharacterFormat.InsertRevision.method_3(class2.method_2());
                }
            }
            else if (class2.method_6())
            {
                A_0.CharacterFormat.IsDeleteRevision = true;
                A_0.CharacterFormat.DeleteRevision = new Class579(EditRevisionType.Deletion);
                if (class2.method_102(0x26))
                {
                    A_0.CharacterFormat.DeleteRevision.method_1(class2.method_0());
                }
                if (class2.method_102(0x27))
                {
                    A_0.CharacterFormat.DeleteRevision.method_3(class2.method_2());
                }
            }
        }
    }

    private void method_76(ITextRange A_0)
    {
    }

    private Class751 method_77(XmlNode A_0)
    {
        int num = 0x12;
        if (!this.method_81(A_0))
        {
            this.method_96();
        }
        foreach (XmlAttribute attribute in A_0.Attributes)
        {
            string str = attribute.LocalName.ToLower();
            if (str != null)
            {
                if (str != BookmarkStart.b("夷嘹唻夽⸿", num))
                {
                    if (str != BookmarkStart.b("尷匹主", num))
                    {
                        if (str != BookmarkStart.b("尷嬹䠻弽洿㝁㝃⍅㩇⑉ⵋ⍍㕏", num))
                        {
                            if (!(str == BookmarkStart.b("尷嬹䠻弽洿㙁ⵃ⭅ⵇ", num)))
                            {
                                if (str == BookmarkStart.b("尷嬹䠻嬽㐿⭁⥃⍅", num))
                                {
                                    this.method_3().method_3(this.method_78(attribute.Value));
                                }
                            }
                            else if (this.bodyRegionCollection_0.Document.HTMLTrackChanges)
                            {
                                this.method_3().method_3(this.method_78(attribute.Value));
                            }
                        }
                        else if (this.bodyRegionCollection_0.Document.HTMLTrackChanges)
                        {
                            this.method_3().method_1(attribute.Value);
                        }
                    }
                    else if (attribute.Value.ToLower() == BookmarkStart.b("䨷丹倻", num))
                    {
                        this.method_3().method_82(true);
                    }
                    else if (attribute.Value.ToLower() == BookmarkStart.b("吷丹主", num))
                    {
                        this.method_3().method_82(false);
                    }
                }
                else
                {
                    this.method_3().method_84(this.method_149(attribute.Value));
                }
            }
        }
        return this.method_3();
    }

    private DateTime method_78(string A_0)
    {
        long num;
        num = long.TryParse(A_0, out num) ? num : -9223372036854775808L;
        if (num == -9223372036854775808L)
        {
            DateTime time;
            if (!DateTime.TryParse(A_0, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.AdjustToUniversal, out time))
            {
                return DateTime.Now;
            }
            return time;
        }
        if (A_0.Length != 0x12)
        {
            return DateTime.Now;
        }
        return new DateTime(num);
    }

    internal string method_79(string A_0)
    {
        bool flag = true;
        return this.method_80(A_0, false, ref flag);
    }

    private string method_8(XmlElement A_0)
    {
        string str5;
        int num = 5;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌪弬䨮地", 5));
        string str2 = A_0.GetAttribute(BookmarkStart.b("䠪䔬丮䌰䀲倴䌶", 5));
        Uri address = null;
        if (Uri.IsWellFormedUriString(attribute, UriKind.Absolute))
        {
            address = new Uri(attribute);
        }
        else if (this.uri_0 != null)
        {
            address = new Uri(this.uri_0, attribute);
        }
        if (address != null)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Credentials = CredentialCache.DefaultCredentials;
                    client.Headers.Set(BookmarkStart.b("帪帬䨮䌰Ḳ吴倶尸唺䤼", num), BookmarkStart.b("昪䈬售堰弲头嘶ᘸ༺ጼ༾慀歂♄⡆⑈㭊ⱌ㭎㡐ㅒ㥔㉖托筚ၜ౞⡠♢䕤彦䝨孪噬佮♰ᩲ᭴፶ᙸ౺๼彾쾀힂ꖄ놆ꞈ뮊뚌꾎얐ﲔﲘ낞閠趢閤躦", num));
                    using (Stream stream2 = client.OpenRead(address))
                    {
                        if (!string.IsNullOrEmpty(str2))
                        {
                            using (StreamReader reader3 = new StreamReader(stream2, Encoding.GetEncoding(str2), true))
                            {
                                return reader3.ReadToEnd();
                            }
                        }
                        using (StreamReader reader4 = new StreamReader(stream2, true))
                        {
                            return reader4.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        string path = null;
        if (File.Exists(attribute))
        {
            path = attribute;
        }
        else
        {
            string str4 = Path.Combine(this.method_1(), attribute);
            if (File.Exists(str4))
            {
                path = str4;
            }
        }
        if (path == null)
        {
            return null;
        }
        using (Stream stream = File.OpenRead(path))
        {
            if (!string.IsNullOrEmpty(str2))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding(str2), true))
                {
                    return reader.ReadToEnd();
                }
            }
            using (StreamReader reader2 = new StreamReader(stream, true))
            {
                str5 = reader2.ReadToEnd();
            }
        }
        return str5;
    }

    internal string method_80(string A_0, bool A_1, ref bool A_2)
    {
        int num = 0x12;
        if (A_0 == BookmarkStart.b("夷伹䠻儽", 0x12))
        {
            return BookmarkStart.b("࠷", num);
        }
        A_2 = true;
        float minValue = float.MinValue;
        if (A_0.EndsWith(BookmarkStart.b("䠷丹", num)))
        {
            return A_0.Replace(BookmarkStart.b("䠷丹", num), string.Empty);
        }
        if (A_0.EndsWith(BookmarkStart.b("ᴷ", num)))
        {
            A_2 = false;
            float num4 = Convert.ToSingle(A_0.Replace(BookmarkStart.b("ᴷ", num), string.Empty));
            float width = float.MinValue;
            if (A_1)
            {
                minValue = num4 / 100f;
                return minValue.ToString();
            }
            Table table = (this.stack_22.Count > 0) ? this.stack_22.Peek() : null;
            if (this.paragraph_0 != null)
            {
                if (this.paragraph_0.IsInCell && ((this.paragraph_0.Owner as TableCell).WidthType == FtsWidth.Point))
                {
                    width = (this.paragraph_0.Owner as TableCell).Width;
                }
            }
            else if (table != null)
            {
                width = table.Document.Sections[0].PageSetup.ClientWidth;
            }
            else if (this.class751_1 != null)
            {
                width = this.class751_1.method_30();
            }
            else
            {
                width = (this.bodyRegionCollection_0.method_22() != null) ? this.bodyRegionCollection_0.method_22().PageSetup.ClientWidth : 0f;
            }
            minValue = (num4 / 100f) * width;
            return minValue.ToString();
        }
        if (A_0.EndsWith(BookmarkStart.b("崷圹", num)))
        {
            minValue = Convert.ToSingle(A_0.Replace(BookmarkStart.b("崷圹", num), string.Empty)) * 12f;
        }
        else if (A_0.EndsWith(BookmarkStart.b("儷吹", num)))
        {
            minValue = PointsConverter.FromInch(Convert.ToSingle(A_0.Replace(BookmarkStart.b("儷吹", num), string.Empty)));
        }
        else if (A_0.EndsWith(BookmarkStart.b("嬷圹", num)))
        {
            minValue = PointsConverter.FromCm(Convert.ToSingle(A_0.Replace(BookmarkStart.b("嬷圹", num), string.Empty)));
        }
        else if (A_0.EndsWith(BookmarkStart.b("䠷夹", num)))
        {
            minValue = Convert.ToSingle(A_0.Replace(BookmarkStart.b("䠷夹", num), string.Empty)) * 12f;
        }
        else if (A_0.EndsWith(BookmarkStart.b("唷圹", num)))
        {
            float cantimeter = Convert.ToSingle(A_0.Replace(BookmarkStart.b("唷圹", num), string.Empty)) / 10f;
            minValue = PointsConverter.FromCm(cantimeter);
        }
        else if (A_0.EndsWith(BookmarkStart.b("䠷䈹", num)))
        {
            minValue = PointsConverter.FromPixel(Convert.ToSingle(A_0.Replace(BookmarkStart.b("䠷䈹", num), string.Empty)));
        }
        else if (A_1)
        {
            A_2 = false;
            minValue = Convert.ToSingle(A_0);
        }
        else
        {
            minValue = PointsConverter.FromPixel(Convert.ToSingle(A_0));
        }
        return minValue.ToString();
    }

    private bool method_81(XmlNode A_0)
    {
        bool flag = false;
        return this.method_82(A_0, ref flag);
    }

    private bool method_82(XmlNode A_0, ref bool A_1)
    {
        int num = 9;
        string str = this.class298_0.method_5(A_0) + this.method_97(A_0, BookmarkStart.b("尮䔰䨲头制", 9));
        string str7 = (A_0.Name != null) ? A_0.Name.ToLower() : string.Empty;
        if (str.Length == 0)
        {
            return false;
        }
        Class751 class2 = this.method_96();
        class2.class752_0 = new Class752(null);
        class2.method_99();
        class2.method_100();
        string[] strArray2 = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        char[] trimChars = new char[] { ' ' };
        Regex regex = new Regex(BookmarkStart.b("献ူᠲ椴᜶ጸ刺值伾⹀ㅂㅄ♆❈㽊", num), RegexOptions.IgnoreCase);
        for (int i = 0; i < strArray2.Length; i++)
        {
            string[] strArray;
            string str2;
            float num5;
            float num11;
            float num12;
            string[] strArray3 = strArray2[i].Split(new char[] { ':' });
            string str5 = strArray3[0].ToLower().Trim();
            if (!string.IsNullOrEmpty(str5))
            {
                string str6;
                str2 = strArray2[i].Remove(0, strArray3[0].Length).ToLower().Trim(new char[] { ' ', ':' });
                str2 = regex.Replace(str2, string.Empty).Trim(trimChars);
                if ((str2 != BookmarkStart.b("䘮弰嬲倴䔶倸伺", num)) && ((str6 = str5) != null))
                {
                    int num15;
                    if (Class1160.dictionary_129 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x40);
                        dictionary1.Add(BookmarkStart.b("䤮帰崲䄴ᨶ弸娺值嘾ⵀ㩂", num), 0);
                        dictionary1.Add(BookmarkStart.b("䈮䈰尲ᠴ儶堸䤺堼帾㉀㝂桄ⅆ♈╊㥌扎㝐㉒㡔㹖㕘≚", num), 1);
                        dictionary1.Add(BookmarkStart.b("䈮䈰尲ᠴ唶倸强吼ሾ❀ⱂ⭄㍆摈ⵊⱌ≎㡐㽒ⱔ", num), 2);
                        dictionary1.Add(BookmarkStart.b("䌮倰崲刴", num), 3);
                        dictionary1.Add(BookmarkStart.b("䈮䈰尲ᠴ儶堸䤺堼帾㉀㝂桄⭆⡈╊⩌㩎ぐ㑒ご", num), 4);
                        dictionary1.Add(BookmarkStart.b("䈮䈰尲ᠴ嘶圸䠺吼ሾⵀ≂⭄⁆㱈⩊⩌⩎", num), 5);
                        dictionary1.Add(BookmarkStart.b("䤮帰崲䄴ᨶ䨸伺䐼匾⑀", num), 6);
                        dictionary1.Add(BookmarkStart.b("䤮帰崲䄴ᨶ丸帺吼堾⥀㝂", num), 7);
                        dictionary1.Add(BookmarkStart.b("䤮帰崲䄴ᨶ䨸刺䜼娾", num), 8);
                        dictionary1.Add(BookmarkStart.b("弮倰吲倴䀶倸强䤼圾", num), 9);
                        dictionary1.Add(BookmarkStart.b("堮堰圲䄴弶", num), 10);
                        dictionary1.Add(BookmarkStart.b("弮倰吲倴弶尸刺娼圾㕀", num), 11);
                        dictionary1.Add(BookmarkStart.b("䜮吰娲刴弶䴸", num), 12);
                        dictionary1.Add(BookmarkStart.b("䬮帰倲刴䔶倸强䤼䘾ㅀ♂", num), 13);
                        dictionary1.Add(BookmarkStart.b("䬮帰倲刴䔶倸强儼嘾⽀♂㕄⹆㵈⡊╌", num), 14);
                        dictionary1.Add(BookmarkStart.b("䰮崰嘲吴䔶", num), 15);
                        dictionary1.Add(BookmarkStart.b("䤮崰尲吴䌶", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䌮堰崲倴ᨶ儸帺吼堾⥀㝂", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ堸场吼堾⽀", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("央吰䄲䄴帶娸娺儼ሾ⁀⽂ⱄ⁆❈", num), 0x13);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ崸帺帼倾㍀≂ㅄ⹆♈╊", num), 20);
                        dictionary1.Add(BookmarkStart.b("䰮帰弲娴䔶", num), 0x15);
                        dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀", num), 0x16);
                        dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀湂ⱄ⩆⡈ⱊ⡌", num), 0x17);
                        dictionary1.Add(BookmarkStart.b("䴮倰倲帴倶䬸吺䠼儾╀湂♄⡆╈⑊㽌", num), 0x18);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ儼娾❀㝂", num), 0x19);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ倸唺夼娾⽀㝂", num), 0x1a);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ似嘾♀⭂ㅄ", num), 0x1b);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ䤼倾ㅀ", num), 0x1c);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ弼倾㕀㝂⩄⩆", num), 0x1d);
                        dictionary1.Add(BookmarkStart.b("䈮倰䄲刴帶圸", num), 30);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ弼倾㕀㝂⩄⩆", num), 0x1f);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䤼倾ㅀ", num), 0x20);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ儼娾❀㝂", num), 0x21);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ似嘾♀⭂ㅄ", num), 0x22);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ帼倾ⵀⱂ㝄", num), 0x23);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ儼娾❀㝂桄⑆♈❊≌㵎", num), 0x24);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ似嘾♀⭂ㅄ橆⩈⑊⅌⁎⍐", num), 0x25);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䤼倾ㅀ湂♄⡆╈⑊㽌", num), 0x26);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ弼倾㕀㝂⩄⩆摈⡊≌⍎㹐⅒", num), 0x27);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䨼嘾╀㝂ⵄ", num), 40);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ儼娾❀㝂桄う⁈⽊㥌❎", num), 0x29);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ似嘾♀⭂ㅄ橆㹈≊⥌㭎㥐", num), 0x2a);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䤼倾ㅀ湂㉄⹆ⵈ㽊╌", num), 0x2b);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ弼倾㕀㝂⩄⩆摈㱊⑌⭎═㭒", num), 0x2c);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ丼䬾㡀⽂⁄", num), 0x2d);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ儼娾❀㝂桄㑆㵈㉊⅌⩎", num), 0x2e);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ似嘾♀⭂ㅄ橆㩈㽊㑌⍎㑐", num), 0x2f);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ䤼倾ㅀ湂㙄㍆え❊⡌", num), 0x30);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸ᘺ弼倾㕀㝂⩄⩆摈㡊㥌㙎㵐㙒", num), 0x31);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸", num), 50);
                        dictionary1.Add(BookmarkStart.b("弮倰吲倴ᨶ嬸䤺堼帾⩀湂❄≆⽈⑊㽌⩎", num), 0x33);
                        dictionary1.Add(BookmarkStart.b("弮倰吲倴ᨶ嬸䤺堼帾⩀湂⑄ⅆ㵈⹊㽌", num), 0x34);
                        dictionary1.Add(BookmarkStart.b("弮倰圲儴帶圸尺", num), 0x35);
                        dictionary1.Add(BookmarkStart.b("弮倰圲儴帶圸尺ြ匾⑀╂ㅄ", num), 0x36);
                        dictionary1.Add(BookmarkStart.b("弮倰圲儴帶圸尺ြ䴾⡀⑂ⵄ㍆", num), 0x37);
                        dictionary1.Add(BookmarkStart.b("弮倰圲儴帶圸尺ြ䬾⹀㍂", num), 0x38);
                        dictionary1.Add(BookmarkStart.b("弮倰圲儴帶圸尺ြ崾⹀㝂ㅄ⡆⑈", num), 0x39);
                        dictionary1.Add(BookmarkStart.b("崮䐰儲䰴ᨶ堸场吼堾⽀", num), 0x3a);
                        dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴ᨶ䴸䤺尼儾㉀╂⩄㕆⑈", num), 0x3b);
                        dictionary1.Add(BookmarkStart.b("䌮堰䀲䄴ᨶ䨸伺䐼匾⑀", num), 60);
                        dictionary1.Add(BookmarkStart.b("䬮堰䄲倴吶䴸刺刼儾", num), 0x3d);
                        dictionary1.Add(BookmarkStart.b("䬮堰䀲䔴嬶堸䈺", num), 0x3e);
                        dictionary1.Add(BookmarkStart.b("䌮吰䜲䄴制䬸ᘺ丼伾⁀⁂ⱄ⥆⹈", num), 0x3f);
                        Class1160.dictionary_129 = dictionary1;
                    }
                    if (Class1160.dictionary_129.TryGetValue(str6, out num15))
                    {
                        string str4;
                        switch (num15)
                        {
                            case 0:
                                class2.method_56(str2);
                                break;

                            case 1:
                                class2.method_58(str2);
                                break;

                            case 2:
                                class2.method_60(str2);
                                break;

                            case 3:
                                class2.method_62(str2);
                                break;

                            case 4:
                                class2.method_64(str2);
                                break;

                            case 5:
                                class2.method_66(str2);
                                break;

                            case 6:
                                goto Label_079D;

                            case 7:
                                if (!(str2 == BookmarkStart.b("䘮弰嬲倴䔶倸伺", num)))
                                {
                                    goto Label_0819;
                                }
                                class2.method_41(this.method_3().method_40());
                                break;

                            case 8:
                                if (class2.method_49() == SubSuperScript.None)
                                {
                                    goto Label_08A4;
                                }
                                if (!(str2 == BookmarkStart.b("尮尰刲头嬶尸䤺", num)))
                                {
                                    goto Label_0885;
                                }
                                class2.method_68(10f);
                                break;

                            case 9:
                                class2.method_27((short) Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 10:
                                if ((this.shapeObject_0 == null) || !str2.EndsWith(BookmarkStart.b("ਮ", num)))
                                {
                                    goto Label_0949;
                                }
                                this.shapeObject_0.HorizontalRule.method_9((double) ((short) Convert.ToSingle(str2.Replace(BookmarkStart.b("ਮ", num), string.Empty))));
                                break;

                            case 11:
                                class2.method_29((short) Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 12:
                                if (this.shapeObject_0 == null)
                                {
                                    goto Label_09A1;
                                }
                                this.shapeObject_0.Height = Convert.ToSingle(this.method_79(str2));
                                break;

                            case 13:
                                string str8;
                                if (!string.IsNullOrEmpty(str2) && ((str8 = str2) != null))
                                {
                                    if (str8 == BookmarkStart.b("䌮堰崲倴䐶", num))
                                    {
                                        goto Label_0A27;
                                    }
                                    if (str8 == BookmarkStart.b("䌮堰崲倴䐶堸唺夼尾⥀≂㝄㑆", num))
                                    {
                                        goto Label_0A1B;
                                    }
                                    if (str8 == BookmarkStart.b("尮弰刲䔴䌶嘸堺唼帾㍀あ", num))
                                    {
                                        class2.method_11(GridPitchType.SnapToChars);
                                    }
                                }
                                break;

                            case 14:
                                class2.method_13(float.Parse(this.method_79(str2), CultureInfo.InvariantCulture));
                                break;

                            case 15:
                                goto Label_0A50;

                            case 0x10:
                                this.bool_8 = true;
                                break;

                            case 0x11:
                            {
                                if (!(str2 != BookmarkStart.b("䄮帰䄲場嘶唸", num)))
                                {
                                    goto Label_0AEB;
                                }
                                bool flag = true;
                                class2.method_74(float.Parse(this.method_80(str2, true, ref flag), CultureInfo.InvariantCulture));
                                if (!flag)
                                {
                                    class2.method_74(class2.method_73() * 12f);
                                    class2.method_76(LineSpacingRule.Multiple);
                                }
                                break;
                            }
                            case 0x12:
                                class2.method_84(this.method_100(str2, class2.method_83()));
                                break;

                            case 0x13:
                                class2.method_50(this.method_101(str2));
                                break;

                            case 20:
                                goto Label_0B23;

                            case 0x15:
                                class2.method_52(Class1007.smethod_0(str2));
                                break;

                            case 0x16:
                                str4 = A_0.Name.ToLower();
                                if (((str4 != BookmarkStart.b("嬮倰儲头制", num)) && (str4 != BookmarkStart.b("嬮夰", num))) && (str4 != BookmarkStart.b("嬮唰", num)))
                                {
                                    this.method_85(class2, str2);
                                }
                                break;

                            case 0x17:
                                str4 = A_0.Name.ToLower();
                                if (((str4 != BookmarkStart.b("嬮倰儲头制", num)) && (str4 != BookmarkStart.b("嬮夰", num))) && ((str4 != BookmarkStart.b("嬮唰", num)) && !string.IsNullOrEmpty(this.method_84(str2))))
                                {
                                    class2.method_25(Image.FromFile(this.method_84(str2)));
                                }
                                break;

                            case 0x18:
                                str4 = A_0.Name.ToLower();
                                if (((str4 != BookmarkStart.b("嬮倰儲头制", num)) && (str4 != BookmarkStart.b("嬮夰", num))) && (str4 != BookmarkStart.b("嬮唰", num)))
                                {
                                    class2.method_54(Class1007.smethod_0(str2));
                                }
                                break;

                            case 0x19:
                                goto Label_0CB8;

                            case 0x1a:
                                class2.method_88(class2.method_87() + Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x1b:
                                class2.method_90(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x1c:
                                if (!(str2.ToLower() != BookmarkStart.b("丮䐰䜲娴", num)))
                                {
                                    goto Label_0D8A;
                                }
                                class2.method_92(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x1d:
                                if (!(str2.ToLower() != BookmarkStart.b("丮䐰䜲娴", num)))
                                {
                                    goto Label_0DCB;
                                }
                                class2.method_94(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 30:
                                strArray = str2.Split(trimChars);
                                switch (strArray.Length)
                                {
                                    case 1:
                                        goto Label_0E0C;

                                    case 2:
                                        goto Label_0E61;

                                    case 3:
                                        goto Label_0EA4;

                                    case 4:
                                        goto Label_0EED;
                                }
                                goto Label_0F3D;

                            case 0x1f:
                                this.method_89(str2, ref class2.class752_0.color_2, ref class2.class752_0.float_2, ref class2.class752_0.borderStyle_2);
                                break;

                            case 0x20:
                                this.method_89(str2, ref class2.class752_0.color_1, ref class2.class752_0.float_1, ref class2.class752_0.borderStyle_1);
                                break;

                            case 0x21:
                                this.method_89(str2, ref class2.class752_0.color_3, ref class2.class752_0.float_3, ref class2.class752_0.borderStyle_3);
                                break;

                            case 0x22:
                                this.method_89(str2, ref class2.class752_0.color_4, ref class2.class752_0.float_4, ref class2.class752_0.borderStyle_4);
                                break;

                            case 0x23:
                                class2.class752_0.color_0 = Class1007.smethod_0(str2);
                                break;

                            case 0x24:
                                class2.class752_0.color_3 = Class1007.smethod_0(str2);
                                break;

                            case 0x25:
                                class2.class752_0.color_4 = Class1007.smethod_0(str2);
                                break;

                            case 0x26:
                                class2.class752_0.color_1 = Class1007.smethod_0(str2);
                                break;

                            case 0x27:
                                class2.class752_0.color_2 = Class1007.smethod_0(str2);
                                break;

                            case 40:
                                strArray = str2.Split(trimChars, StringSplitOptions.RemoveEmptyEntries);
                                switch (strArray.Length)
                                {
                                    case 1:
                                        goto Label_10ED;

                                    case 2:
                                        goto Label_1106;

                                    case 3:
                                        goto Label_1153;

                                    case 4:
                                        goto Label_11A4;
                                }
                                break;

                            case 0x29:
                                class2.class752_0.float_3 = this.method_91(str2);
                                break;

                            case 0x2a:
                                class2.class752_0.float_4 = this.method_91(str2);
                                break;

                            case 0x2b:
                                class2.class752_0.float_1 = this.method_91(str2);
                                break;

                            case 0x2c:
                                class2.class752_0.float_2 = this.method_91(str2);
                                break;

                            case 0x2d:
                                strArray = str2.Split(trimChars, StringSplitOptions.RemoveEmptyEntries);
                                switch (strArray.Length)
                                {
                                    case 1:
                                        goto Label_1287;

                                    case 2:
                                        goto Label_12A0;

                                    case 3:
                                        goto Label_12ED;

                                    case 4:
                                        goto Label_133E;
                                }
                                break;

                            case 0x2e:
                                class2.class752_0.borderStyle_3 = this.method_93(str2);
                                break;

                            case 0x2f:
                                class2.class752_0.borderStyle_4 = this.method_93(str2);
                                break;

                            case 0x30:
                                class2.class752_0.borderStyle_1 = this.method_93(str2);
                                break;

                            case 0x31:
                                class2.class752_0.borderStyle_2 = this.method_93(str2);
                                break;

                            case 50:
                                this.method_89(str2, ref class2.class752_0.color_4, ref class2.class752_0.float_4, ref class2.class752_0.borderStyle_4);
                                this.method_89(str2, ref class2.class752_0.color_3, ref class2.class752_0.float_3, ref class2.class752_0.borderStyle_3);
                                this.method_89(str2, ref class2.class752_0.color_2, ref class2.class752_0.float_2, ref class2.class752_0.borderStyle_2);
                                this.method_89(str2, ref class2.class752_0.color_1, ref class2.class752_0.float_1, ref class2.class752_0.borderStyle_1);
                                break;

                            case 0x33:
                                if (str2 == BookmarkStart.b("丮崰䐲吴丶䨸", num))
                                {
                                    this.bool_2 = true;
                                }
                                break;

                            case 0x34:
                                if (str2 == BookmarkStart.b("丮崰䐲吴丶䨸", num))
                                {
                                    this.bool_3 = true;
                                    class2.method_39(HtmlPageBreak.Always);
                                    A_1 = true;
                                }
                                break;

                            case 0x35:
                                strArray = str2.Split(trimChars);
                                switch (strArray.Length)
                                {
                                    case 1:
                                        goto Label_151D;

                                    case 2:
                                        goto Label_1572;

                                    case 3:
                                        goto Label_15C7;

                                    case 4:
                                        goto Label_161C;
                                }
                                break;

                            case 0x36:
                                class2.method_17(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x37:
                                if (str7 == BookmarkStart.b("䬮堰䔲", num))
                                {
                                    class2.method_19(Convert.ToSingle(this.method_79(str2)));
                                }
                                break;

                            case 0x38:
                                class2.method_21(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x39:
                                class2.method_23(Convert.ToSingle(this.method_79(str2)));
                                break;

                            case 0x3a:
                                this.class2_0.method_52(this.method_83(str2));
                                break;

                            case 0x3b:
                                if (str2.ToLower() == BookmarkStart.b("娮䄰䌲倴䔶娸娺丼娾", num))
                                {
                                    class2.method_80(true);
                                }
                                break;

                            case 60:
                                string str3;
                                if (((str3 = str2) != null) && (str3 == BookmarkStart.b("䄮帰崲倴", num)))
                                {
                                    class2.bool_5 = true;
                                }
                                break;

                            case 0x3d:
                                if (!(str2.ToLower() == BookmarkStart.b("崮䔰弲", num)))
                                {
                                    goto Label_177A;
                                }
                                class2.method_82(true);
                                break;

                            case 0x3e:
                                if (str2.ToLower() == BookmarkStart.b("䄮帰崲倴", num))
                                {
                                    class2.method_9(true);
                                }
                                break;

                            case 0x3f:
                                goto Label_17C4;
                        }
                    }
                }
            }
            continue;
        Label_079D:
            if ((str2 == BookmarkStart.b("䘮䔰刲头帶娸", num)) || (str2 == BookmarkStart.b("䀮匰弲尴䘶䰸帺", num)))
            {
                class2.method_43(true);
            }
            if (str2 == BookmarkStart.b("尮䔰䄲尴尶尸", num))
            {
                class2.method_48(true);
            }
            continue;
        Label_0819:
            if (!(str2 == BookmarkStart.b("䄮帰䄲場嘶唸", num)) && !(str2 == BookmarkStart.b("ᬮİ̲", num)))
            {
                class2.method_41(true);
            }
            else
            {
                class2.method_41(false);
            }
            continue;
        Label_0885:
            class2.method_68(this.method_99(str2, class2.method_67()) * 2f);
            continue;
        Label_08A4:
            if (str2 == BookmarkStart.b("尮尰刲头嬶尸䤺", num))
            {
                class2.method_68(10f);
            }
            else
            {
                class2.method_68(this.method_99(str2, class2.method_67()));
            }
            continue;
        Label_0949:
            class2.method_31((short) Convert.ToSingle(this.method_79(str2)));
            continue;
        Label_09A1:
            class2.method_33((short) Convert.ToSingle(this.method_79(str2)));
            continue;
        Label_0A1B:
            class2.method_11(GridPitchType.CharsAndLine);
            continue;
        Label_0A27:
            class2.method_11(GridPitchType.LinesOnly);
            continue;
        Label_0A50:
            if ((str2 == BookmarkStart.b("䴮帰䜲崴", num)) || (str2 == BookmarkStart.b("崮堰吲崴䌶", num)))
            {
                this.bool_7 = true;
            }
            continue;
        Label_0AEB:
            class2.method_78(true);
            continue;
        Label_0B23:
            if (str2 == BookmarkStart.b("娮弰圲倴䔶唸刺匼娾", num))
            {
                class2.method_46(true);
            }
            if (str2 == BookmarkStart.b("䌮堰崲倴ᨶ䴸区似倾㑀⑂ⵄ", num))
            {
                class2.method_48(true);
            }
            continue;
        Label_0CB8:
            class2.method_86(Convert.ToSingle(this.method_79(str2)));
            if (((str7 == BookmarkStart.b("䌮堰", num)) || (str7 == BookmarkStart.b("娮崰", num))) || (str7 == BookmarkStart.b("䀮崰", num)))
            {
                class2.method_17(class2.method_16() + class2.method_85());
            }
            continue;
        Label_0D8A:
            class2.method_92(-1f);
            continue;
        Label_0DCB:
            class2.method_94(-1f);
            continue;
        Label_0E0C:
            class2.method_92(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_90(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_94(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_86(Convert.ToSingle(this.method_79(strArray[0])));
            goto Label_0F3D;
        Label_0E61:
            class2.method_94(num11 = Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_92(num11);
            class2.method_90(num12 = Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_86(num12);
            goto Label_0F3D;
        Label_0EA4:
            class2.method_92(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_90(num5 = Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_86(num5);
            class2.method_94(Convert.ToSingle(this.method_79(strArray[2])));
            goto Label_0F3D;
        Label_0EED:
            class2.method_92(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_90(Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_94(Convert.ToSingle(this.method_79(strArray[2])));
            class2.method_86(Convert.ToSingle(this.method_79(strArray[3])));
        Label_0F3D:
            if (((str7 == BookmarkStart.b("䌮堰", num)) || (str7 == BookmarkStart.b("娮崰", num))) || (str7 == BookmarkStart.b("䀮崰", num)))
            {
                class2.method_17(class2.method_16() + class2.method_85());
            }
            continue;
        Label_10ED:
            class2.class752_0.float_0 = this.method_91(strArray[0]);
            continue;
        Label_1106:
            class2.class752_0.float_1 = class2.class752_0.float_2 = this.method_91(strArray[0]);
            class2.class752_0.float_3 = class2.class752_0.float_4 = this.method_91(strArray[1]);
            continue;
        Label_1153:
            class2.class752_0.float_1 = this.method_91(strArray[0]);
            class2.class752_0.float_3 = class2.class752_0.float_4 = this.method_91(strArray[1]);
            class2.class752_0.float_2 = this.method_91(strArray[2]);
            continue;
        Label_11A4:
            class2.class752_0.float_1 = this.method_91(strArray[0]);
            class2.class752_0.float_4 = this.method_91(strArray[1]);
            class2.class752_0.float_2 = this.method_91(strArray[2]);
            class2.class752_0.float_3 = this.method_91(strArray[3]);
            continue;
        Label_1287:
            class2.class752_0.borderStyle_0 = this.method_93(strArray[0]);
            continue;
        Label_12A0:
            class2.class752_0.borderStyle_1 = class2.class752_0.borderStyle_2 = this.method_93(strArray[0]);
            class2.class752_0.borderStyle_3 = class2.class752_0.borderStyle_4 = this.method_93(strArray[1]);
            continue;
        Label_12ED:
            class2.class752_0.borderStyle_1 = this.method_93(strArray[0]);
            class2.class752_0.borderStyle_3 = class2.class752_0.borderStyle_4 = this.method_93(strArray[1]);
            class2.class752_0.borderStyle_2 = this.method_93(strArray[2]);
            continue;
        Label_133E:
            class2.class752_0.borderStyle_1 = this.method_93(strArray[0]);
            class2.class752_0.borderStyle_4 = this.method_93(strArray[1]);
            class2.class752_0.borderStyle_2 = this.method_93(strArray[2]);
            class2.class752_0.borderStyle_3 = this.method_93(strArray[3]);
            continue;
        Label_151D:
            class2.method_17(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_19(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_21(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_23(Convert.ToSingle(this.method_79(strArray[0])));
            continue;
        Label_1572:
            class2.method_21(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_23(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_17(Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_19(Convert.ToSingle(this.method_79(strArray[1])));
            continue;
        Label_15C7:
            class2.method_21(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_17(Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_19(Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_23(Convert.ToSingle(this.method_79(strArray[2])));
            continue;
        Label_161C:
            class2.method_21(Convert.ToSingle(this.method_79(strArray[0])));
            class2.method_19(Convert.ToSingle(this.method_79(strArray[1])));
            class2.method_23(Convert.ToSingle(this.method_79(strArray[2])));
            class2.method_17(Convert.ToSingle(this.method_79(strArray[3])));
            continue;
        Label_177A:
            if (str2.ToLower() == BookmarkStart.b("䌮䔰䄲", num))
            {
                class2.method_82(false);
            }
            continue;
        Label_17C4:
            if (str2.ToLower().Contains(BookmarkStart.b("弮䤰", num)))
            {
                class2.method_70(Convert.ToSingle(this.method_79(str2)));
            }
            if (str2.ToLower().Contains(BookmarkStart.b("弮䔰", num)))
            {
                class2.method_70(float.Parse(str2.Substring(0, str2.Length - 2)));
            }
        }
        return true;
    }

    private RubyAlign method_83(string A_0)
    {
        int num = 3;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_130 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䔨个夬䤮", num), 0);
                dictionary1.Add(BookmarkStart.b("嬨䈪䨬䜮䔰", num), 1);
                dictionary1.Add(BookmarkStart.b("䴨䈪帬嬮䌰娲圴䈶䴸帺ြ䰾ㅀ≂♄≆", num), 2);
                dictionary1.Add(BookmarkStart.b("䴨䈪帬嬮䌰娲圴䈶䴸帺ြ匾⑀㝂ㅄ≆㭈", num), 3);
                dictionary1.Add(BookmarkStart.b("䠨帪夬䀮", num), 4);
                dictionary1.Add(BookmarkStart.b("䨨个䌬嬮吰䄲", num), 5);
                dictionary1.Add(BookmarkStart.b("䔨䈪䌬䨮ᰰ嘲儴倶尸", num), 6);
                Class1160.dictionary_130 = dictionary1;
            }
            if (Class1160.dictionary_130.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return RubyAlign.Left;

                    case 1:
                        return RubyAlign.Right;

                    case 2:
                        return RubyAlign.DistributeSpace;

                    case 3:
                        return RubyAlign.DistributeLetter;
                }
            }
        }
        return RubyAlign.Center;
    }

    private string method_84(string A_0)
    {
        string str = string.Empty;
        A_0 = A_0.Replace(BookmarkStart.b("ጰ", 11), string.Empty);
        int startIndex = 0;
        int num2 = 0;
        startIndex = A_0.IndexOf(BookmarkStart.b("ᤰ", 11)) + 1;
        num2 = A_0.LastIndexOf(BookmarkStart.b("ᠰ", 11));
        if (((startIndex > -1) && (num2 > -1)) && (num2 >= startIndex))
        {
            str = A_0.Substring(startIndex, num2 - startIndex);
        }
        return str;
    }

    private Class751 method_85(Class751 A_0, string A_1)
    {
        int num = 15;
        string[] strArray2 = A_1.Split(new char[] { ' ' });
        int index = 0;
    Label_001F:
        if (index >= strArray2.Length)
        {
            return A_0;
        }
        string str = strArray2[index];
        if (this.method_86(str))
        {
            A_0.method_54(Class1007.smethod_0(str));
        }
        else if (str.Contains(BookmarkStart.b("䀴䔶唸", num)))
        {
            try
            {
                string uriString = this.method_84(str);
                if (!Uri.IsWellFormedUriString(uriString, UriKind.Absolute) && !uriString.StartsWith(BookmarkStart.b("崴䌶䴸䬺", num)))
                {
                    if (this.uri_0 != null)
                    {
                        Uri address = new Uri(this.uri_0, str);
                        using (WebClient client2 = new WebClient())
                        {
                            client2.Credentials = CredentialCache.DefaultCredentials;
                            client2.Headers.Set(BookmarkStart.b("䀴䐶尸䤺ြ帾♀♂⭄㍆", num), BookmarkStart.b("破堶䌸刺儼匾⁀求煄楆祈歊敌ⱎ㹐㹒╔㙖ⵘ㉚㽜㍞Ѡ塢䕤⩦㩨≪⡬佮䥰嵲䕴䱶奸ⱺᑼᅾꦈ얊\ud98c\uaf8eꞐ붒ꖔ겖릘쾚얠욢쮤펦蚨龪莬龮颰", num));
                            using (Stream stream2 = client2.OpenRead(address))
                            {
                                A_0.method_25(Image.FromStream(stream2));
                            }
                            goto Label_01EA;
                        }
                    }
                    if (File.Exists(uriString))
                    {
                        A_0.method_25(Image.FromFile(uriString));
                    }
                    else if (File.Exists(this.method_1() + BookmarkStart.b("椴", num) + uriString))
                    {
                        A_0.method_25(Image.FromFile(this.method_1() + BookmarkStart.b("椴", num) + uriString));
                    }
                }
                else
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Credentials = CredentialCache.DefaultCredentials;
                        client.Headers.Set(BookmarkStart.b("䀴䐶尸䤺ြ帾♀♂⭄㍆", num), BookmarkStart.b("破堶䌸刺儼匾⁀求煄楆祈歊敌ⱎ㹐㹒╔㙖ⵘ㉚㽜㍞Ѡ塢䕤⩦㩨≪⡬佮䥰嵲䕴䱶奸ⱺᑼᅾꦈ얊\ud98c\uaf8eꞐ붒ꖔ겖릘쾚얠욢쮤펦蚨龪莬龮颰", num));
                        using (Stream stream = client.OpenRead(uriString))
                        {
                            A_0.method_25(Image.FromStream(stream));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    Label_01EA:
        index++;
        goto Label_001F;
    }

    private bool method_86(string A_0)
    {
        A_0 = A_0.Trim();
        Regex regex = new Regex(BookmarkStart.b("栵ᬷ愹఻ጽ礿⍁楃⁅े杉ੋፍ⭏捑硓⭕籗", 0x10));
        Regex regex2 = new Regex(BookmarkStart.b("栵挷䠹渻挽ᬿ╁̓ᭅፇ⡉๋ፍ౏⅑繓੕灗牙[㩝䭟䭡㡣ᕥ䉧䙩にᵭ婯婱⡳ት卷卹⁻ൽꩿ꺁\ud883\uf585ꊇꊉ킋뮏뮑좓늗욙떛몝", 0x10));
        return ((Color.FromName(A_0).IsKnownColor || regex.Match(A_0).Success) || regex2.Match(A_0).Success);
    }

    private CellFormat method_87(CellFormat A_0, string A_1)
    {
        if (this.method_86(A_1))
        {
            A_0.BackColor = Class1007.smethod_0(A_1);
            this.method_3().method_54(A_0.BackColor);
        }
        return A_0;
    }

    private RowFormat method_88(RowFormat A_0, string A_1)
    {
        if (this.method_86(A_1))
        {
            A_0.BackColor = Class1007.smethod_0(A_1);
            this.method_3().method_54(A_0.BackColor);
        }
        return A_0;
    }

    private void method_89(string A_0, ref Color A_1, ref float A_2, ref BorderStyle A_3)
    {
        int num = 0x10;
        string[] strArray2 = new string[] { BookmarkStart.b("刵夷䤹吻嬽␿", 0x10), BookmarkStart.b("刵圷丹䠻嬽␿", 0x10), BookmarkStart.b("刵圷伹帻刽┿", 0x10), BookmarkStart.b("儵䨷唹医䠽┿", 0x10), BookmarkStart.b("張嘷䤹夻䨽", 0x10), BookmarkStart.b("夵䴷丹伻嬽㐿", 0x10), BookmarkStart.b("䐵儷帹嬻嬽", 0x10), BookmarkStart.b("䔵圷嘹唻娽", 0x10), BookmarkStart.b("帵儷帹堻嬽⸿", 0x10), BookmarkStart.b("堵圷吹夻", 0x10) };
        string[] strArray3 = A_0.Split(new char[] { ' ' });
        for (int i = 0; i < strArray3.Length; i++)
        {
            if (strArray3[i].StartsWith(BookmarkStart.b("ᔵ", num)))
            {
                if (strArray3[i].Length > 6)
                {
                    strArray3[i] = strArray3[i].Replace(BookmarkStart.b("ᔵ", num), string.Empty);
                    int red = int.Parse(strArray3[i].Substring(0, 2), NumberStyles.AllowHexSpecifier);
                    int green = int.Parse(strArray3[i].Substring(2, 2), NumberStyles.AllowHexSpecifier);
                    int blue = int.Parse(strArray3[i].Substring(4, 2), NumberStyles.AllowHexSpecifier);
                    A_1 = Color.FromArgb(red, green, blue);
                }
                else
                {
                    A_1 = Class1007.smethod_0(strArray3[i]);
                }
                continue;
            }
            if (this.method_90(strArray3[i]))
            {
                A_2 = this.method_91(strArray3[i]);
                continue;
            }
            foreach (string str in strArray2)
            {
                if (strArray3[i] == str)
                {
                    goto Label_01C3;
                }
            }
            goto Label_01CA;
        Label_01C3:
            this.bool_4 = true;
        Label_01CA:
            if (this.bool_4)
            {
                A_3 = this.method_93(strArray3[i]);
                this.bool_4 = false;
            }
            else
            {
                A_1 = Class1007.smethod_0(strArray3[i]);
            }
        }
    }

    private string method_9(string A_0)
    {
        int num = 7;
        if (A_0.Contains(BookmarkStart.b("ᄬฮ唰尲嘴䌶䀸䬺堼", 7)) || A_0.Contains(BookmarkStart.b("ᄬฮ田簲瘴挶怸欺砼", num)))
        {
            int index = A_0.IndexOf(BookmarkStart.b("ᄬฮ田簲瘴挶怸欺砼", num));
            if (index == -1)
            {
                index = A_0.IndexOf(BookmarkStart.b("ᄬฮ唰尲嘴䌶䀸䬺堼", num));
            }
            int num3 = A_0.IndexOf(BookmarkStart.b("ጬ", num));
            A_0 = A_0.Remove(index, num3 + 1);
        }
        return A_0;
    }

    private bool method_90(string A_0)
    {
        float num2;
        int num = 5;
        return ((((A_0.EndsWith(BookmarkStart.b("嬪夬", 5)) || A_0.EndsWith(BookmarkStart.b("嬪唬", num))) || (A_0.EndsWith(BookmarkStart.b("䈪䌬", num)) || A_0.EndsWith(BookmarkStart.b("个䀬", num)))) || (A_0.EndsWith(BookmarkStart.b("䠪䀬", num)) || A_0.EndsWith(BookmarkStart.b("嬪丬", num)))) || ((((A_0 == BookmarkStart.b("䘪䠬䬮堰䘲場", num)) || (A_0 == BookmarkStart.b("弪䔬䘮到堲", num))) || (A_0 == BookmarkStart.b("弪䔬䘮弰", num))) || float.TryParse(A_0, out num2)));
    }

    internal float method_91(string A_0)
    {
        int num = 15;
        if (((!A_0.EndsWith(BookmarkStart.b("䔴䌶", 15)) && !A_0.EndsWith(BookmarkStart.b("䔴伶", num))) && (!A_0.EndsWith(BookmarkStart.b("倴娶", num)) && !A_0.EndsWith(BookmarkStart.b("嘴娶", num)))) && !A_0.EndsWith(BookmarkStart.b("䔴吶", num)))
        {
            if (A_0.EndsWith(BookmarkStart.b("尴夶", num)))
            {
                if (this.method_92(A_0)[1] == null)
                {
                    return 0.75f;
                }
                return Convert.ToSingle(this.method_79(A_0));
            }
            if (A_0 == BookmarkStart.b("場制崸刺䠼刾", num))
            {
                return 3f;
            }
            if (A_0 == BookmarkStart.b("䄴弶倸堺嘼", num))
            {
                return 4.5f;
            }
            return Convert.ToSingle(this.method_79(A_0));
        }
        return Convert.ToSingle(this.method_79(A_0));
    }

    private string[] method_92(string A_0)
    {
        string[] strArray = new string[2];
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (char.IsDigit(c))
            {
                string[] strArray3;
                (strArray3 = strArray)[1] = strArray3[1] + c;
            }
            else
            {
                string[] strArray2;
                (strArray2 = strArray)[0] = strArray2[0] + c;
            }
        }
        return strArray;
    }

    private BorderStyle method_93(string A_0)
    {
        int num = 7;
        string key = A_0.ToLower();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_131 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("䤬丮䈰嬲倴匶", num), 0);
                dictionary1.Add(BookmarkStart.b("䤬䀮䔰䜲倴匶", num), 1);
                dictionary1.Add(BookmarkStart.b("䤬䀮䐰儲头制", num), 2);
                dictionary1.Add(BookmarkStart.b("䨬崮帰尲䌴制", num), 3);
                dictionary1.Add(BookmarkStart.b("䐬䄮䈰嘲䄴", num), 4);
                dictionary1.Add(BookmarkStart.b("䈬娮䔰䀲倴䌶", num), 5);
                dictionary1.Add(BookmarkStart.b("弬䘮唰吲倴", num), 6);
                dictionary1.Add(BookmarkStart.b("帬䀮崰娲儴", num), 7);
                dictionary1.Add(BookmarkStart.b("䌬䀮弰嘲", num), 8);
                dictionary1.Add(BookmarkStart.b("䔬䘮唰圲倴夶", num), 9);
                Class1160.dictionary_131 = dictionary1;
            }
            if (Class1160.dictionary_131.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BorderStyle.DashLargeGap;

                    case 1:
                        return BorderStyle.Dot;

                    case 2:
                        return BorderStyle.Double;

                    case 3:
                        return BorderStyle.Engrave3D;

                    case 4:
                        return BorderStyle.Inset;

                    case 5:
                        return BorderStyle.Outset;

                    case 6:
                        return BorderStyle.Emboss3D;

                    case 7:
                        return BorderStyle.Single;

                    case 8:
                    case 9:
                        return BorderStyle.None;
                }
            }
        }
        return BorderStyle.None;
    }

    private void method_94(bool A_0)
    {
        if (A_0)
        {
            this.stack_0.Pop();
        }
    }

    private void method_95(XmlNode A_0)
    {
        int num = 2;
        if (this.paragraph_0 != null)
        {
            ParagraphFormat format = this.paragraph_0.Format;
            string str = this.method_97(A_0, BookmarkStart.b("䤧䘩䔫䤭帯", num)).ToLower();
            if ((str != string.Empty) && (A_0.Name.ToLower() != BookmarkStart.b("尧䬩丫䈭唯", num)))
            {
                if (format.IsBidi)
                {
                    switch (format.HorizontalAlignment)
                    {
                        case HorizontalAlignment.Left:
                            format.HorizontalAlignment = HorizontalAlignment.Right;
                            return;

                        case HorizontalAlignment.Center:
                            return;

                        case HorizontalAlignment.Right:
                            format.HorizontalAlignment = HorizontalAlignment.Left;
                            return;
                    }
                }
                else if (str == BookmarkStart.b("䬧伩䈫娭唯䀱", num))
                {
                    format.HorizontalAlignment = HorizontalAlignment.Center;
                }
                else if (str == BookmarkStart.b("娧䌩䬫䘭䐯", num))
                {
                    format.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
            else if (this.method_3().method_102(10))
            {
                format.HorizontalAlignment = this.method_3().method_83();
            }
        }
    }

    private Class751 method_96()
    {
        Class751 item = ((this.stack_0.Count <= 0) || (this.stack_0.Peek() == null)) ? (((this.stack_6.Count <= 0) || (this.stack_6.Peek() == null)) ? new Class751() : this.stack_6.Peek().method_97()) : this.stack_0.Peek().method_97();
        this.stack_0.Push(item);
        return item;
    }

    private string method_97(XmlNode A_0, string A_1)
    {
        A_1 = A_1.ToLower();
        XmlAttribute attribute = null;
        for (int i = 0; i < A_0.Attributes.Count; i++)
        {
            attribute = A_0.Attributes[i];
            if (attribute.LocalName.ToLower() == A_1)
            {
                return attribute.Value;
            }
        }
        return string.Empty;
    }

    private double method_98(string A_0, float A_1)
    {
        Font font;
        int num = 14;
        A_0 = A_0.Trim();
        if (A_1 < 0f)
        {
            A_1 = 3f;
        }
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_132 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("䰳丵ᔷ䤹儻弽ⰿ⹁", num), 0);
                dictionary1.Add(BookmarkStart.b("䰳ᬵ䬷圹崻刽ⰿ", num), 1);
                dictionary1.Add(BookmarkStart.b("䜳嬵夷嘹倻", num), 2);
                dictionary1.Add(BookmarkStart.b("夳匵尷匹䤻匽", num), 3);
                dictionary1.Add(BookmarkStart.b("堳圵䨷崹夻", num), 4);
                dictionary1.Add(BookmarkStart.b("䰳ᬵ吷嬹主夽┿", num), 5);
                dictionary1.Add(BookmarkStart.b("䰳丵ᔷ嘹崻䰽✿❁", num), 6);
                dictionary1.Add(BookmarkStart.b("䜳嬵夷嘹倻嬽㈿", num), 7);
                dictionary1.Add(BookmarkStart.b("嘳張強崹夻䰽", num), 8);
                dictionary1.Add(BookmarkStart.b("堳圵䨷崹夻䰽", num), 9);
                Class1160.dictionary_132 = dictionary1;
            }
            if (Class1160.dictionary_132.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return 7.5;

                    case 1:
                        return 10.0;

                    case 2:
                        return 12.0;

                    case 3:
                        return 13.5;

                    case 4:
                        return 18.0;

                    case 5:
                        return 24.0;

                    case 6:
                        return 36.0;

                    case 7:
                        return 10.0;

                    case 8:
                        return 12.0;

                    case 9:
                        return 13.5;
                }
            }
        }
        if (A_0.EndsWith(BookmarkStart.b("ᄳ", num)))
        {
            return (double) ((A_1 * this.method_102(A_0, BookmarkStart.b("ᄳ", num))) / 100f);
        }
        if (A_0.EndsWith(BookmarkStart.b("儳嬵", num)))
        {
            return (double) (A_1 * this.method_102(A_0, BookmarkStart.b("儳嬵", num)));
        }
        if (A_0.EndsWith(BookmarkStart.b("儳丵", num)))
        {
            return (double) ((A_1 / 2f) * this.method_102(A_0, BookmarkStart.b("儳丵", num)));
        }
        if (A_0.EndsWith(BookmarkStart.b("䐳䈵", num)))
        {
            return (double) this.method_102(A_0, BookmarkStart.b("䐳䈵", num));
        }
        if (A_0.EndsWith(BookmarkStart.b("崳堵", num)))
        {
            font = new Font("", this.method_102(A_0, BookmarkStart.b("崳堵", num)), GraphicsUnit.Inch);
            return (double) font.SizeInPoints;
        }
        if (A_0.EndsWith(BookmarkStart.b("圳嬵", num)))
        {
            font = new Font("", this.method_102(A_0, BookmarkStart.b("圳嬵", num)) / 10f, GraphicsUnit.Millimeter);
            return (double) font.SizeInPoints;
        }
        if (A_0.EndsWith(BookmarkStart.b("夳嬵", num)))
        {
            font = new Font("", this.method_102(A_0, BookmarkStart.b("夳嬵", num)), GraphicsUnit.Millimeter);
            return (double) font.SizeInPoints;
        }
        if (A_0.EndsWith(BookmarkStart.b("䐳唵", num)))
        {
            font = new Font("", this.method_102(A_0, BookmarkStart.b("䐳唵", num)) * 12f, GraphicsUnit.Point);
            return (double) font.SizeInPoints;
        }
        if (A_0.EndsWith(BookmarkStart.b("䐳丵", num)))
        {
            font = new Font("", this.method_102(A_0, BookmarkStart.b("䐳丵", num)), GraphicsUnit.Pixel);
            return (double) font.SizeInPoints;
        }
        float emSize = float.Parse(A_0, CultureInfo.InvariantCulture);
        font = new Font("", emSize, GraphicsUnit.Pixel);
        return (double) font.SizeInPoints;
    }

    private float method_99(string A_0, float A_1)
    {
        return (float) Math.Round(this.method_98(A_0, A_1), 1);
    }

    internal static HorizontalAlignment smethod_0(HorizontalAlignment A_0, bool A_1)
    {
        switch (A_0)
        {
            case HorizontalAlignment.Left:
                if (A_1)
                {
                    return HorizontalAlignment.Right;
                }
                return HorizontalAlignment.Left;

            case HorizontalAlignment.Center:
                return A_0;

            case HorizontalAlignment.Right:
                if (!A_1)
                {
                    return HorizontalAlignment.Right;
                }
                return HorizontalAlignment.Left;
        }
        return A_0;
    }

    void IDisposable.Dispose()
    {
        this.xmlDocument_0 = null;
        this.bodyRegionCollection_0 = null;
        this.paragraph_0 = null;
        this.table_0 = null;
        this.string_4 = null;
        this.uri_0 = null;
        this.class751_1 = null;
        this.iparagraphStyle_0 = null;
        this.class748_0 = null;
        this.class751_0 = null;
        this.class751_1 = null;
        this.class751_2 = null;
        this.iparagraphStyle_0 = null;
        this.listStyle_0 = null;
        if (this.stack_0 != null)
        {
            this.stack_0.Clear();
            this.stack_0 = null;
        }
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
        if (this.stack_1 != null)
        {
            this.stack_1.Clear();
            this.stack_1 = null;
        }
        if (this.stack_2 != null)
        {
            this.stack_2.Clear();
            this.stack_2 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.stack_3 != null)
        {
            this.stack_3.Clear();
            this.stack_3 = null;
        }
        if (this.stack_4 != null)
        {
            this.stack_4.Clear();
            this.stack_4 = null;
        }
        if (this.stack_6 != null)
        {
            this.stack_6.Clear();
            this.stack_6 = null;
        }
        if (this.stack_7 != null)
        {
            this.stack_7.Clear();
            this.stack_7 = null;
        }
        if (this.stack_8 != null)
        {
            this.stack_8.Clear();
            this.stack_8 = null;
        }
        if (this.stack_9 != null)
        {
            this.stack_9.Clear();
            this.stack_9 = null;
        }
        if (this.stack_10 != null)
        {
            this.stack_10.Clear();
            this.stack_10 = null;
        }
        if (this.class298_0 != null)
        {
            this.class298_0.Clear();
            this.class298_0 = null;
        }
        if (this.stack_11 != null)
        {
            this.stack_11.Clear();
            this.stack_11 = null;
        }
        if (this.stack_5 != null)
        {
            this.stack_5.Clear();
            this.stack_5 = null;
        }
        if (this.stack_15 != null)
        {
            this.stack_15.Clear();
            this.stack_15 = null;
        }
        if (this.stack_16 != null)
        {
            this.stack_16.Clear();
            this.stack_16 = null;
        }
    }

    internal class Class748
    {
        private Stack<Dictionary<int, ArrayList>> stack_0 = new Stack<Dictionary<int, ArrayList>>();

        internal Stack<Dictionary<int, ArrayList>> method_0()
        {
            return this.stack_0;
        }

        internal void method_1(Stack<Dictionary<int, ArrayList>> A_0)
        {
            this.stack_0 = A_0;
        }
    }

    internal class Class749
    {
        internal ArrayList arrayList_0 = new ArrayList();
        private ArrayList arrayList_1 = new ArrayList();
        private Class750 class750_0 = new Class750();
        private Dictionary<int, ArrayList> dictionary_0 = new Dictionary<int, ArrayList>();
        internal float float_0;
        internal float float_1;
        private int int_0;
        private Queue<int> queue_0 = new Queue<int>();

        internal Class749()
        {
        }

        internal Dictionary<int, ArrayList> method_0()
        {
            return this.dictionary_0;
        }

        internal void method_1(Dictionary<int, ArrayList> A_0)
        {
            this.dictionary_0 = A_0;
        }

        private void method_10(Table A_0, float A_1)
        {
            int num = 0;
            for (int i = 0; i < A_0.Rows.Count; i++)
            {
                int count = A_0.Rows[i].Cells.Count;
                if (num < count)
                {
                    num = count;
                }
            }
            float num4 = A_1 / ((float) num);
            for (int j = 0; j < A_0.Rows.Count; j++)
            {
                for (int k = 0; k < A_0.Rows[j].Cells.Count; k++)
                {
                    if (((A_0.Rows[j].Cells[k].Width == 0.0) || (A_0.Rows[j].Cells[k].Width == 3f)) && ((A_0.TableGrid.Count > (k + 1)) && (num4 > 0f)))
                    {
                        A_0.Rows[j].Cells[k].Width = A_0.Rows[j].Cells[k].int_9 * num4;
                        A_0.TableGrid[k + 1] = A_0.TableGrid[k] + (A_0.Rows[j].Cells[k].Width * 20f);
                    }
                }
            }
            A_0.method_82();
        }

        private void method_11(Table A_0)
        {
        }

        internal void method_12()
        {
            this.arrayList_0.Add(0f);
            this.method_4();
        }

        internal void method_13(int A_0)
        {
            while (this.arrayList_0.Count < A_0)
            {
                this.method_12();
            }
        }

        internal void method_14(int A_0, int A_1, int A_2, int A_3)
        {
            this.class750_0.method_0(A_0, A_1, A_2, A_3);
        }

        internal int method_15(int A_0)
        {
            return this.class750_0.method_1(A_0);
        }

        internal void method_2()
        {
            this.int_0 = 0;
        }

        internal void method_3(TableCell A_0)
        {
            float width = A_0.Width;
            float num2 = 0f;
            if (A_0.Width != 0f)
            {
                width = A_0.Width;
            }
            else
            {
                width = num2;
            }
            if (A_0.HTMLColIndex >= this.arrayList_0.Count)
            {
                while (A_0.HTMLColIndex >= this.arrayList_0.Count)
                {
                    this.arrayList_0.Add(3f);
                }
                this.arrayList_0[A_0.HTMLColIndex] = width;
            }
            else if (((float) this.arrayList_0[A_0.HTMLColIndex]) < width)
            {
                this.arrayList_0[A_0.HTMLColIndex] = width;
            }
        }

        internal void method_4()
        {
            this.int_0++;
        }

        internal void method_5(int A_0)
        {
            this.queue_0.Enqueue(A_0);
        }

        private ArrayList method_6(Dictionary<int, ArrayList> A_0, Table A_1)
        {
            int count = 0;
            ArrayList list = new ArrayList();
            for (int i = 0; i < this.method_0().Count; i++)
            {
                if (count < this.method_0()[i].Count)
                {
                    count = this.method_0()[i].Count;
                }
            }
            for (int j = 0; j < count; j++)
            {
                float num4 = 0f;
                float num6 = 0f;
                bool flag = true;
                for (int k = 0; k < A_0.Count; k++)
                {
                    ArrayList list2 = A_0[k];
                    if ((j < list2.Count) && (num4 < ((float) list2[j])))
                    {
                        if (((k <= (A_1.Rows.Count - 1)) && (j <= (A_1.Rows[k].Cells.Count - 1))) && (A_1.Rows[k].Cells[j].CellFormat.HorizontalMerge != CellMerge.None))
                        {
                            num6 = (float) list2[j];
                        }
                        else
                        {
                            num4 = (float) list2[j];
                            flag = false;
                        }
                    }
                }
                if (((num4 == 0f) && flag) && (num6 != 0f))
                {
                    num4 = num6;
                }
                list.Add(num4);
            }
            return list;
        }

        internal void method_7(Table A_0, Stack<Dictionary<int, ArrayList>> A_1)
        {
            this.dictionary_0 = A_1.Pop();
            int num = 0;
            foreach (TableRow row2 in A_0.Rows)
            {
                this.arrayList_0 = this.dictionary_0[num];
                int num14 = 0;
                int num17 = row2.Cells.Count;
                while (num14 < num17)
                {
                    TableCell cell4 = row2.Cells[num14];
                    if (cell4.CellFormat.VerticalMerge == CellMerge.Start)
                    {
                        int cellIndex = cell4.GetCellIndex();
                        int num11 = cell4.OwnerRow.GetRowIndex() + 1;
                        int num15 = this.queue_0.Dequeue();
                        int num16 = cell4.int_9;
                        int num12 = 1;
                        int num13 = num15;
                        while (num12 < num13)
                        {
                            if (A_0.Rows.Count <= num11)
                            {
                                break;
                            }
                            for (int i = 0; i < num16; i++)
                            {
                                int num9 = cellIndex + i;
                                TableCell cell5 = (TableCell) cell4.Clone();
                                cell5.Items.Clear();
                                int index = 0;
                                while (index < A_0.Rows[num11].Cells.Count)
                                {
                                    if (num9 < A_0.Rows[num11].Cells[index].HTMLColIndex)
                                    {
                                        break;
                                    }
                                    index++;
                                }
                                A_0.Rows[num11].Cells.Insert(index, cell5);
                                cell5.CellFormat.VerticalMerge = CellMerge.Continue;
                                if (num16 > 1)
                                {
                                    if (i == 0)
                                    {
                                        cell5.CellFormat.HorizontalMerge = CellMerge.Start;
                                    }
                                    else
                                    {
                                        cell5.CellFormat.HorizontalMerge = CellMerge.Continue;
                                    }
                                }
                                if (A_0.Rows[num11].Cells.Count > this.arrayList_0.Count)
                                {
                                    this.arrayList_0.Add(3f);
                                }
                            }
                            num11++;
                            num12++;
                        }
                    }
                    num14++;
                }
                num++;
            }
            this.arrayList_0 = this.method_6(this.dictionary_0, A_0);
            int num2 = 0;
            int count = A_0.Rows.Count;
            while (num2 < count)
            {
                this.arrayList_1.Clear();
                int num3 = 0;
                int num20 = A_0.Rows[num2].Cells.Count;
                while (num3 < num20)
                {
                    if ((A_0.Rows[num2].Cells[num3].Width == 0.0) || ((A_0.Rows[num2].Cells[num3].Width == 3f) && (this.arrayList_0.Count < num3)))
                    {
                        TableCell cell = A_0.Rows[num2].Cells[num3];
                        if ((this.method_8(cell) && (cell.OwnerRow.PreviousSibling == null)) && (cell.OwnerRow.NextSibling == null))
                        {
                            A_0.Rows[num2].Cells[num3].Width = 3f;
                            this.arrayList_1.Add(num3);
                        }
                        else
                        {
                            cell.Width = (float) this.arrayList_0[num3];
                        }
                    }
                    foreach (Table table in A_0.Rows[num2].Cells[num3].Tables)
                    {
                        this.method_10(table, A_0.Rows[num2].Cells[num3].Width);
                    }
                    num3++;
                }
                this.method_9(this.arrayList_1, A_0.Rows[num2], this.arrayList_0);
                num2++;
            }
            if (A_0.Rows.Count > 1)
            {
                foreach (TableRow row3 in A_0.Rows)
                {
                    if ((A_0.TableGrid.Count - 1) > this.arrayList_0.Count)
                    {
                        int num18 = 0;
                        int num19 = this.arrayList_0.Count;
                        while (num18 < num19)
                        {
                            if (row3.Cells.Count < (num18 + 1))
                            {
                                row3.AddCell(true);
                            }
                            TableCell cell6 = row3.Cells[num18];
                            cell6.Width = (float) this.arrayList_0[num18];
                            if (cell6.Width == 3f)
                            {
                                cell6.CellFormat.WidthUnit = FtsWidth.Auto;
                            }
                            num18++;
                        }
                    }
                }
            }
            if (((A_0.Rows.Count > 0) && A_0.Rows[0].IsHtmlCaption) && (this.arrayList_0.Count > 1))
            {
                TableRow row = A_0.Rows[0];
                TableCell cell2 = row.Cells[0];
                row.Cells[0].CellFormat.HorizontalMerge = CellMerge.Start;
                for (int j = 0; j < this.arrayList_0.Count; j++)
                {
                    float num4 = (float) this.arrayList_0[j];
                    if ((j == 0) && (num4 > 0f))
                    {
                        cell2.Width = num4;
                        cell2.WidthType = FtsWidth.Point;
                    }
                    else if (j > 0)
                    {
                        TableCell cell3 = row.AddCell();
                        cell3.CellFormat.HorizontalMerge = CellMerge.Continue;
                        if (num4 > 0f)
                        {
                            cell3.Width = num4;
                            cell3.WidthType = FtsWidth.Point;
                        }
                    }
                }
            }
            this.method_11(A_0);
        }

        private bool method_8(TableCell A_0)
        {
            bool flag = true;
            foreach (DocumentObject obj2 in A_0.ChildObjects)
            {
                if (obj2.DocumentObjectType == DocumentObjectType.Paragraph)
                {
                    foreach (ParagraphBase base2 in (obj2 as Paragraph).Items)
                    {
                        if (base2.DocumentObjectType == DocumentObjectType.TextRange)
                        {
                            if ((base2 as TextRange).Text != "")
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if ((base2.DocumentObjectType == DocumentObjectType.Picture) || (base2.DocumentObjectType == DocumentObjectType.Field))
                            {
                                return false;
                            }
                            if (((base2.DocumentObjectType != DocumentObjectType.Break) && (base2.DocumentObjectType != DocumentObjectType.CommentMark)) && (base2.DocumentObjectType != DocumentObjectType.FieldMark))
                            {
                                flag = false;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                    }
                }
                else if (obj2.DocumentObjectType == DocumentObjectType.Table)
                {
                    return false;
                }
            }
            return flag;
        }

        private void method_9(ArrayList A_0, TableRow A_1, ArrayList A_2)
        {
            float num = 0f;
            foreach (int num4 in A_0)
            {
                num += ((float) this.arrayList_0[num4]) - 3f;
            }
            int num6 = A_1.Cells.Count - A_0.Count;
            float num3 = num / ((float) num6);
            for (int i = 0; i < A_1.Cells.Count; i++)
            {
                if (!A_0.Contains(i))
                {
                    TableCell cell1 = A_1.Cells[i];
                    cell1.Width += num3;
                }
            }
        }

        internal class Class750
        {
            private int int_0 = 0x10;
            private List<List<ushort>> list_0 = new List<List<ushort>>();

            internal void method_0(int A_0, int A_1, int A_2, int A_3)
            {
                int num = (A_1 + A_3) - 1;
                int num2 = A_1 / this.int_0;
                int num3 = A_1 % this.int_0;
                int num4 = num / this.int_0;
                int num5 = num % this.int_0;
                int num6 = (A_0 + A_2) - 1;
                while (this.list_0.Count <= num6)
                {
                    this.list_0.Add(new List<ushort>());
                }
                for (int i = A_0; i <= num6; i++)
                {
                    List<ushort> list = this.list_0[i];
                    while (list.Count <= num4)
                    {
                        list.Add(0);
                    }
                    int num7 = list[num2];
                    if (num2 == num4)
                    {
                        for (int j = num3; j <= num5; j++)
                        {
                            num7 |= ((int) 1) << ((this.int_0 - j) - 1);
                        }
                    }
                    else
                    {
                        num7 |= (((int) 1) << (this.int_0 - num3)) - 1;
                        for (int k = num2 + 1; k < num4; k++)
                        {
                            list[k] = 0xffff;
                        }
                        int num11 = list[num4];
                        num11 |= ~((((int) 1) << ((this.int_0 - num5) - 1)) - 1);
                        list[num4] = (ushort) num11;
                    }
                    list[num2] = (ushort) num7;
                }
            }

            internal int method_1(int A_0)
            {
                if (this.list_0.Count <= A_0)
                {
                    return 0;
                }
                List<ushort> list = this.list_0[A_0];
                for (int i = 0; i < list.Count; i++)
                {
                    ushort num2 = list[i];
                    int num3 = this.method_2(num2);
                    if (num3 != -1)
                    {
                        return ((i * this.int_0) + num3);
                    }
                }
                return (list.Count * this.int_0);
            }

            private int method_2(ushort A_0)
            {
                if (A_0 == 0)
                {
                    return 0;
                }
                if (A_0 == 0xffff)
                {
                    return -1;
                }
                int num3 = 0;
                ushort num = ~A_0;
                ushort num2 = (ushort) (num >> 8);
                if (num2 > 0)
                {
                    num = num2;
                    num3 += 8;
                }
                num2 = (ushort) (num >> 4);
                if (num2 > 0)
                {
                    num = num2;
                    num3 += 4;
                }
                num2 = (ushort) (num >> 2);
                if (num2 > 0)
                {
                    num = num2;
                    num3 += 2;
                }
                num2 = (ushort) (num >> 1);
                if (num2 > 0)
                {
                    num = num2;
                    num3++;
                }
                if ((num & 1) > 0)
                {
                    num3++;
                }
                return (this.int_0 - num3);
            }
        }
    }

    internal class Class751
    {
        public bool bool_0;
        public bool bool_1;
        public bool bool_2;
        private bool bool_3 = true;
        private bool bool_4 = true;
        internal bool bool_5;
        private bool bool_6 = true;
        public BuiltinStyle builtinStyle_0;
        public Class747.Class752 class752_0 = new Class747.Class752(null);
        private Dictionary<int, object> dictionary_0 = new Dictionary<int, object>();
        internal const short short_0 = 0;
        internal const short short_1 = 1;
        internal const short short_10 = 10;
        internal const short short_11 = 11;
        internal const short short_12 = 12;
        internal const short short_13 = 13;
        internal const short short_14 = 14;
        internal const short short_15 = 15;
        internal const short short_16 = 0x10;
        internal const short short_17 = 0x11;
        internal const short short_18 = 0x12;
        internal const short short_19 = 0x13;
        internal const short short_2 = 2;
        internal const short short_20 = 20;
        internal const short short_21 = 0x15;
        internal const short short_22 = 0x16;
        internal const short short_23 = 0x17;
        internal const short short_24 = 0x18;
        internal const short short_25 = 0x23;
        internal const short short_26 = 0x24;
        internal const short short_27 = 0x19;
        internal const short short_28 = 0x1a;
        internal const short short_29 = 0x1b;
        internal const short short_3 = 3;
        internal const short short_30 = 0x1c;
        internal const short short_31 = 0x1d;
        internal const short short_32 = 30;
        internal const short short_33 = 0x1f;
        internal const short short_34 = 0x20;
        internal const short short_35 = 0x21;
        internal const short short_36 = 0x22;
        internal const short short_37 = 0x25;
        internal const short short_38 = 0x26;
        internal const short short_39 = 0x27;
        internal const short short_4 = 4;
        internal const short short_40 = 40;
        internal const short short_41 = 0x29;
        internal const short short_42 = 0x2a;
        internal const short short_43 = 0x2b;
        internal const short short_44 = 0x2c;
        internal const short short_45 = 0x2d;
        internal const short short_46 = 0x2e;
        internal const short short_47 = 0x2f;
        internal const short short_5 = 5;
        internal const short short_6 = 6;
        internal const short short_7 = 7;
        internal const short short_8 = 8;
        internal const short short_9 = 9;

        internal Class751()
        {
        }

        internal string method_0()
        {
            if (this.method_102(0x26))
            {
                return (string) this.dictionary_0[0x26];
            }
            return null;
        }

        internal void method_1(string A_0)
        {
            this.method_103(0x26, A_0);
        }

        public GridPitchType method_10()
        {
            if (this.method_102(0x21))
            {
                return (GridPitchType) this.dictionary_0[0x21];
            }
            return GridPitchType.NoGrid;
        }

        internal void method_100()
        {
            this.dictionary_0.Remove(0x19);
            this.dictionary_0.Remove(30);
            this.dictionary_0.Remove(0x1f);
            this.dictionary_0.Remove(0x20);
        }

        private void method_101(int A_0, bool A_1)
        {
            if (!this.dictionary_0.ContainsKey(A_0))
            {
                this.dictionary_0.Add(A_0, A_1);
            }
            else
            {
                this.dictionary_0[A_0] = A_1;
            }
        }

        internal bool method_102(int A_0)
        {
            return this.dictionary_0.ContainsKey(A_0);
        }

        private void method_103(int A_0, object A_1)
        {
            this.bool_4 = false;
            if (!this.dictionary_0.ContainsKey(A_0))
            {
                this.dictionary_0.Add(A_0, A_1);
            }
            else
            {
                this.dictionary_0[A_0] = A_1;
            }
        }

        public void method_11(GridPitchType A_0)
        {
            this.method_103(0x21, A_0);
        }

        public float method_12()
        {
            if (this.method_102(0x22))
            {
                return (float) this.dictionary_0[0x22];
            }
            return 0f;
        }

        public void method_13(float A_0)
        {
            this.method_103(0x22, A_0);
        }

        public RubyAlign method_14()
        {
            if (this.method_102(0x1a))
            {
                return (RubyAlign) this.dictionary_0[0x1a];
            }
            return RubyAlign.Center;
        }

        public void method_15(RubyAlign A_0)
        {
            this.method_103(0x1a, A_0);
        }

        public float method_16()
        {
            if (this.method_102(0x19))
            {
                return (float) this.dictionary_0[0x19];
            }
            return 0f;
        }

        public void method_17(float A_0)
        {
            this.method_103(0x19, A_0);
        }

        internal float method_18()
        {
            if (this.method_102(30))
            {
                return (float) this.dictionary_0[30];
            }
            return 0f;
        }

        internal void method_19(float A_0)
        {
            this.method_103(30, A_0);
        }

        internal DateTime method_2()
        {
            if (this.method_102(0x27))
            {
                return (DateTime) this.dictionary_0[0x27];
            }
            return DateTime.MinValue;
        }

        internal float method_20()
        {
            if (this.method_102(0x1f))
            {
                return (float) this.dictionary_0[0x1f];
            }
            return 0f;
        }

        internal void method_21(float A_0)
        {
            this.method_103(0x1f, A_0);
        }

        internal float method_22()
        {
            if (this.method_102(0x20))
            {
                return (float) this.dictionary_0[0x20];
            }
            return 0f;
        }

        internal void method_23(float A_0)
        {
            this.method_103(0x20, A_0);
        }

        public Image method_24()
        {
            if (this.method_102(0x13))
            {
                return (Image) this.dictionary_0[0x13];
            }
            return null;
        }

        public void method_25(Image A_0)
        {
            this.method_103(0x13, A_0);
        }

        public short method_26()
        {
            if (this.method_102(0x23))
            {
                return (short) this.dictionary_0[0x23];
            }
            return 0;
        }

        public void method_27(short A_0)
        {
            this.method_103(0x23, A_0);
        }

        public short method_28()
        {
            if (this.method_102(0x24))
            {
                return (short) this.dictionary_0[0x24];
            }
            return 0;
        }

        public void method_29(short A_0)
        {
            this.method_103(0x24, A_0);
        }

        internal void method_3(DateTime A_0)
        {
            this.method_103(0x27, A_0);
        }

        public short method_30()
        {
            if (this.method_102(0x15))
            {
                return (short) this.dictionary_0[0x15];
            }
            return 0;
        }

        public void method_31(short A_0)
        {
            this.method_103(0x15, A_0);
        }

        public short method_32()
        {
            if (this.method_102(0x16))
            {
                return (short) this.dictionary_0[0x16];
            }
            return 0;
        }

        public void method_33(short A_0)
        {
            this.method_103(0x16, A_0);
        }

        public short method_34()
        {
            if (this.method_102(0x17))
            {
                return (short) this.dictionary_0[0x17];
            }
            return 0;
        }

        public void method_35(short A_0)
        {
            this.method_103(0x17, A_0);
        }

        public short method_36()
        {
            if (this.method_102(0x18))
            {
                return (short) this.dictionary_0[0x18];
            }
            return 0;
        }

        public void method_37(short A_0)
        {
            this.method_103(0x18, A_0);
        }

        public Class747.HtmlPageBreak method_38()
        {
            if (this.method_102(0x12))
            {
                return (Class747.HtmlPageBreak) this.dictionary_0[0x12];
            }
            return Class747.HtmlPageBreak.Auto;
        }

        public void method_39(Class747.HtmlPageBreak A_0)
        {
            this.method_103(0x12, A_0);
        }

        internal bool method_4()
        {
            return (this.method_102(40) && ((bool) this.dictionary_0[40]));
        }

        public bool method_40()
        {
            return (this.method_102(2) && ((bool) this.dictionary_0[2]));
        }

        public void method_41(bool A_0)
        {
            this.method_101(2, A_0);
        }

        public bool method_42()
        {
            return (this.method_102(4) && ((bool) this.dictionary_0[4]));
        }

        public void method_43(bool A_0)
        {
            this.bool_6 = false;
            this.method_101(4, A_0);
        }

        internal bool method_44()
        {
            return this.bool_6;
        }

        public bool method_45()
        {
            return (this.method_102(3) && ((bool) this.dictionary_0[3]));
        }

        public void method_46(bool A_0)
        {
            this.method_101(3, A_0);
        }

        public bool method_47()
        {
            return (this.method_102(5) && ((bool) this.dictionary_0[5]));
        }

        public void method_48(bool A_0)
        {
            this.method_101(5, A_0);
        }

        public SubSuperScript method_49()
        {
            if (this.method_102(0x10))
            {
                return (SubSuperScript) this.dictionary_0[0x10];
            }
            return SubSuperScript.None;
        }

        internal void method_5(bool A_0)
        {
            this.method_101(40, A_0);
        }

        public void method_50(SubSuperScript A_0)
        {
            this.method_103(0x10, A_0);
        }

        public Color method_51()
        {
            if (this.method_102(6))
            {
                return (Color) this.dictionary_0[6];
            }
            return Color.Empty;
        }

        public void method_52(Color A_0)
        {
            this.method_103(6, A_0);
        }

        public Color method_53()
        {
            if (this.method_102(7))
            {
                return (Color) this.dictionary_0[7];
            }
            return Color.Empty;
        }

        public void method_54(Color A_0)
        {
            this.method_103(7, A_0);
        }

        public string method_55()
        {
            if (this.method_102(1))
            {
                return (string) this.dictionary_0[1];
            }
            return string.Empty;
        }

        public void method_56(string A_0)
        {
            this.method_103(1, A_0);
        }

        public string method_57()
        {
            if (this.method_102(0x2a))
            {
                return (string) this.dictionary_0[0x2a];
            }
            return string.Empty;
        }

        public void method_58(string A_0)
        {
            this.method_103(0x2a, A_0);
        }

        public string method_59()
        {
            if (this.method_102(0x2b))
            {
                return (string) this.dictionary_0[0x2b];
            }
            return string.Empty;
        }

        internal bool method_6()
        {
            return (this.method_102(0x29) && ((bool) this.dictionary_0[0x29]));
        }

        public void method_60(string A_0)
        {
            this.method_103(0x2b, A_0);
        }

        public string method_61()
        {
            if (this.method_102(0x2c))
            {
                return (string) this.dictionary_0[0x2c];
            }
            return string.Empty;
        }

        public void method_62(string A_0)
        {
            this.method_103(0x2c, A_0);
        }

        public string method_63()
        {
            if (this.method_102(0x2d))
            {
                return (string) this.dictionary_0[0x2d];
            }
            return string.Empty;
        }

        public void method_64(string A_0)
        {
            this.method_103(0x2d, A_0);
        }

        public string method_65()
        {
            if (this.method_102(0x2e))
            {
                return (string) this.dictionary_0[0x2e];
            }
            return string.Empty;
        }

        public void method_66(string A_0)
        {
            this.method_103(0x2e, A_0);
        }

        public float method_67()
        {
            if (this.method_102(0))
            {
                return (float) this.dictionary_0[0];
            }
            return 12f;
        }

        public void method_68(float A_0)
        {
            this.bool_3 = false;
            this.method_103(0, A_0);
        }

        public float method_69()
        {
            if (this.method_102(0x2f))
            {
                return (float) this.dictionary_0[0x2f];
            }
            return 0f;
        }

        internal void method_7(bool A_0)
        {
            this.method_101(0x29, A_0);
        }

        public void method_70(float A_0)
        {
            this.method_103(0x2f, A_0);
        }

        internal bool method_71()
        {
            return this.bool_3;
        }

        internal bool method_72()
        {
            return this.bool_4;
        }

        public float method_73()
        {
            if (this.method_102(8))
            {
                return (float) this.dictionary_0[8];
            }
            return -1f;
        }

        public void method_74(float A_0)
        {
            this.method_103(8, A_0);
        }

        public LineSpacingRule method_75()
        {
            if (this.method_102(0x1d))
            {
                return (LineSpacingRule) this.dictionary_0[0x1d];
            }
            return LineSpacingRule.AtLeast;
        }

        public void method_76(LineSpacingRule A_0)
        {
            this.method_103(0x1d, A_0);
        }

        public bool method_77()
        {
            return (this.method_102(9) && ((bool) this.dictionary_0[9]));
        }

        public void method_78(bool A_0)
        {
            this.method_101(9, A_0);
        }

        internal bool method_79()
        {
            return (this.method_102(0x1c) && ((bool) this.dictionary_0[0x1c]));
        }

        public bool method_8()
        {
            return (this.method_102(0x25) && ((bool) this.dictionary_0[0x25]));
        }

        internal void method_80(bool A_0)
        {
            this.method_101(0x1c, A_0);
        }

        internal bool method_81()
        {
            return (this.method_102(0x1b) && ((bool) this.dictionary_0[0x1b]));
        }

        internal void method_82(bool A_0)
        {
            this.method_101(0x1b, A_0);
        }

        public HorizontalAlignment method_83()
        {
            if (this.method_102(10))
            {
                return (HorizontalAlignment) this.dictionary_0[10];
            }
            return HorizontalAlignment.Left;
        }

        public void method_84(HorizontalAlignment A_0)
        {
            this.method_103(10, A_0);
        }

        public float method_85()
        {
            if (this.method_102(12))
            {
                return (float) this.dictionary_0[12];
            }
            return 0f;
        }

        public void method_86(float A_0)
        {
            this.method_103(12, A_0);
        }

        public float method_87()
        {
            if (this.method_102(15))
            {
                return (float) this.dictionary_0[15];
            }
            return 0f;
        }

        public void method_88(float A_0)
        {
            this.method_103(15, A_0);
        }

        public float method_89()
        {
            if (this.method_102(14))
            {
                return (float) this.dictionary_0[14];
            }
            return 0f;
        }

        public void method_9(bool A_0)
        {
            this.method_101(0x25, A_0);
        }

        public void method_90(float A_0)
        {
            this.method_103(14, A_0);
        }

        public float method_91()
        {
            if (this.method_102(11))
            {
                return (float) this.dictionary_0[11];
            }
            return -1f;
        }

        public void method_92(float A_0)
        {
            this.method_103(11, A_0);
        }

        public float method_93()
        {
            if (this.method_102(13))
            {
                return (float) this.dictionary_0[13];
            }
            return -1f;
        }

        public void method_94(float A_0)
        {
            this.method_103(13, A_0);
        }

        public bool method_95()
        {
            return (this.method_102(20) && ((bool) this.dictionary_0[20]));
        }

        public void method_96(bool A_0)
        {
            this.method_101(20, A_0);
        }

        public Class747.Class751 method_97()
        {
            return new Class747.Class751 { dictionary_0 = new Dictionary<int, object>(this.dictionary_0), bool_0 = this.bool_0, bool_1 = this.bool_1, bool_2 = this.bool_2, class752_0 = this.class752_0 };
        }

        internal void method_98(int A_0)
        {
            this.dictionary_0.Remove(A_0);
        }

        internal void method_99()
        {
            this.dictionary_0.Remove(12);
            this.dictionary_0.Remove(14);
            this.dictionary_0.Remove(11);
            this.dictionary_0.Remove(13);
        }
    }

    internal class Class752
    {
        private bool bool_0;
        public BorderStyle borderStyle_0;
        public BorderStyle borderStyle_1;
        public BorderStyle borderStyle_2;
        public BorderStyle borderStyle_3;
        public BorderStyle borderStyle_4;
        public Class747.Class752 class752_0;
        public Color color_0 = Color.Empty;
        public Color color_1 = Color.Empty;
        public Color color_2 = Color.Empty;
        public Color color_3 = Color.Empty;
        public Color color_4 = Color.Empty;
        public float float_0 = -1f;
        public float float_1 = -1f;
        public float float_2 = -1f;
        public float float_3 = -1f;
        public float float_4 = -1f;

        public Class752(Class747.Class752 A_0)
        {
            this.class752_0 = A_0;
        }

        internal Class747.Class752 method_0()
        {
            return new Class747.Class752(this.class752_0) { color_0 = this.color_0, borderStyle_0 = this.borderStyle_0, float_0 = this.float_0, color_1 = this.color_1, borderStyle_1 = this.borderStyle_1, float_1 = this.float_1, color_2 = this.color_2, borderStyle_2 = this.borderStyle_2, float_2 = this.float_2, color_3 = this.color_3, borderStyle_3 = this.borderStyle_3, float_3 = this.float_3, color_4 = this.color_4, borderStyle_4 = this.borderStyle_4, float_4 = this.float_4 };
        }

        internal void method_1(string A_0, string A_1)
        {
            int num = 10;
            using (Class747 class2 = new Class747())
            {
                string[] strArray;
                string[] strArray2;
                string[] strArray3;
                string key = A_0;
                if (key != null)
                {
                    int num11;
                    if (Class1160.dictionary_141 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(20);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ崽⼿⹁⭃㑅", num), 0);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ刽┿⑁ぃ歅⭇╉⁋⅍≏", num), 1);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䰽⤿╁ⱃ㉅敇⥉⍋≍㽏⁑", num), 2);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䨽⼿㉁楃╅❇♉⍋㱍", num), 3);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ尽⼿㙁ぃ⥅╇杉⽋⅍㱏㵑♓", num), 4);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䤽⤿♁ぃ⹅", num), 5);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ刽┿⑁ぃ歅㽇⍉⡋㩍㡏", num), 6);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䰽⤿╁ⱃ㉅敇㵉╋⩍⑏㩑", num), 7);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䨽⼿㉁楃ㅅⅇ⹉㡋♍", num), 8);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ尽⼿㙁ぃ⥅╇杉㭋❍㑏♑㱓", num), 9);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䴽㐿㭁⡃⍅", num), 10);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ刽┿⑁ぃ歅㭇㹉㕋≍㕏", num), 11);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䰽⤿╁ⱃ㉅敇㥉㡋㝍㱏㝑", num), 12);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䨽⼿㉁楃㕅㱇㍉⁋⭍", num), 13);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ尽⼿㙁ぃ⥅╇杉㽋㩍⥏㹑ㅓ", num), 14);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ尽⼿㙁ぃ⥅╇", num), 15);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䨽⼿㉁", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ刽┿⑁ぃ", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹ᄻ䰽⤿╁ⱃ㉅", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("刯崱䘳刵崷䠹", num), 0x13);
                        Class1160.dictionary_141 = dictionary1;
                    }
                    if (Class1160.dictionary_141.TryGetValue(key, out num11))
                    {
                        switch (num11)
                        {
                            case 0:
                                strArray = A_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                switch (strArray.Length)
                                {
                                    case 1:
                                        goto Label_024C;

                                    case 2:
                                        goto Label_028B;

                                    case 3:
                                        goto Label_02C2;

                                    case 4:
                                        goto Label_02FC;
                                }
                                break;

                            case 1:
                                this.color_3 = Class1007.smethod_0(A_1);
                                break;

                            case 2:
                                this.color_4 = Class1007.smethod_0(A_1);
                                break;

                            case 3:
                                this.color_1 = Class1007.smethod_0(A_1);
                                break;

                            case 4:
                                this.color_2 = Class1007.smethod_0(A_1);
                                break;

                            case 5:
                                strArray3 = A_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                switch (strArray3.Length)
                                {
                                    case 1:
                                        goto Label_03BA;

                                    case 2:
                                        goto Label_03FB;

                                    case 3:
                                        goto Label_0436;

                                    case 4:
                                        goto Label_0476;
                                }
                                break;

                            case 6:
                                this.float_3 = class2.method_91(A_1);
                                break;

                            case 7:
                                this.float_4 = class2.method_91(A_1);
                                break;

                            case 8:
                                this.float_1 = class2.method_91(A_1);
                                break;

                            case 9:
                                this.float_2 = class2.method_91(A_1);
                                break;

                            case 10:
                                strArray2 = A_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                switch (strArray2.Length)
                                {
                                    case 1:
                                        goto Label_0540;

                                    case 2:
                                        goto Label_0581;

                                    case 3:
                                        goto Label_05BC;

                                    case 4:
                                        goto Label_05FC;
                                }
                                break;

                            case 11:
                                this.borderStyle_3 = this.method_12(A_1);
                                break;

                            case 12:
                                this.borderStyle_4 = this.method_12(A_1);
                                break;

                            case 13:
                                this.borderStyle_1 = this.method_12(A_1);
                                break;

                            case 14:
                                this.borderStyle_2 = this.method_12(A_1);
                                break;

                            case 15:
                                this.method_2(A_1, ref this.color_2, ref this.float_2, ref this.borderStyle_2, class2);
                                break;

                            case 0x10:
                                this.method_2(A_1, ref this.color_1, ref this.float_1, ref this.borderStyle_1, class2);
                                break;

                            case 0x11:
                                this.method_2(A_1, ref this.color_3, ref this.float_3, ref this.borderStyle_3, class2);
                                break;

                            case 0x12:
                                this.method_2(A_1, ref this.color_4, ref this.float_4, ref this.borderStyle_4, class2);
                                break;

                            case 0x13:
                                this.method_2(A_1, ref this.color_0, ref this.float_0, ref this.borderStyle_0, class2);
                                this.method_2(A_1, ref this.color_2, ref this.float_2, ref this.borderStyle_2, class2);
                                this.method_2(A_1, ref this.color_4, ref this.float_4, ref this.borderStyle_4, class2);
                                this.method_2(A_1, ref this.color_1, ref this.float_1, ref this.borderStyle_1, class2);
                                this.method_2(A_1, ref this.color_3, ref this.float_3, ref this.borderStyle_3, class2);
                                break;
                        }
                    }
                }
                return;
            Label_024C:
                this.color_1 = this.color_2 = this.color_3 = this.color_4 = this.color_0 = Class1007.smethod_0(strArray[0]);
                return;
            Label_028B:
                this.color_1 = this.color_2 = Class1007.smethod_0(strArray[0]);
                this.color_3 = this.color_4 = Class1007.smethod_0(strArray[1]);
                return;
            Label_02C2:
                this.color_1 = Class1007.smethod_0(strArray[0]);
                this.color_3 = this.color_4 = Class1007.smethod_0(strArray[1]);
                this.color_2 = Class1007.smethod_0(strArray[2]);
                return;
            Label_02FC:
                this.color_1 = Class1007.smethod_0(strArray[0]);
                this.color_4 = Class1007.smethod_0(strArray[1]);
                this.color_2 = Class1007.smethod_0(strArray[2]);
                this.color_3 = Class1007.smethod_0(strArray[3]);
                return;
            Label_03BA:
                this.float_1 = this.float_2 = this.float_3 = this.float_4 = this.float_0 = class2.method_91(strArray3[0]);
                return;
            Label_03FB:
                this.float_1 = this.float_2 = class2.method_91(strArray3[0]);
                this.float_3 = this.float_4 = class2.method_91(strArray3[1]);
                return;
            Label_0436:
                this.float_1 = class2.method_91(strArray3[0]);
                this.float_3 = this.float_4 = class2.method_91(strArray3[1]);
                this.float_2 = class2.method_91(strArray3[2]);
                return;
            Label_0476:
                this.float_1 = class2.method_91(strArray3[0]);
                this.float_4 = class2.method_91(strArray3[1]);
                this.float_2 = class2.method_91(strArray3[2]);
                this.float_3 = class2.method_91(strArray3[3]);
                return;
            Label_0540:
                this.borderStyle_1 = this.borderStyle_2 = this.borderStyle_3 = this.borderStyle_4 = this.borderStyle_0 = this.method_12(strArray2[0]);
                return;
            Label_0581:
                this.borderStyle_1 = this.borderStyle_2 = this.method_12(strArray2[0]);
                this.borderStyle_3 = this.borderStyle_4 = this.method_12(strArray2[1]);
                return;
            Label_05BC:
                this.borderStyle_1 = this.method_12(strArray2[0]);
                this.borderStyle_3 = this.borderStyle_4 = this.method_12(strArray2[1]);
                this.borderStyle_2 = this.method_12(strArray2[2]);
                return;
            Label_05FC:
                this.borderStyle_1 = this.method_12(strArray2[0]);
                this.borderStyle_4 = this.method_12(strArray2[1]);
                this.borderStyle_2 = this.method_12(strArray2[2]);
                this.borderStyle_3 = this.method_12(strArray2[3]);
            }
        }

        private void method_10(Borders A_0, Color A_1)
        {
            A_0.Color = A_1;
            A_0.Horizontal.Color = A_1;
            A_0.Vertical.Color = A_1;
        }

        private void method_11(Borders A_0, BorderStyle A_1)
        {
            A_0.BorderType = A_1;
            A_0.Horizontal.BorderType = A_1;
            A_0.Vertical.BorderType = A_1;
        }

        private BorderStyle method_12(string A_0)
        {
            int num = 8;
            string key = A_0.ToLower();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_142 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("䨭儯䄱尳匵尷", num), 0);
                    dictionary1.Add(BookmarkStart.b("䨭弯䘱䀳匵尷", num), 1);
                    dictionary1.Add(BookmarkStart.b("䨭弯䜱嘳娵崷", num), 2);
                    dictionary1.Add(BookmarkStart.b("䤭䈯崱嬳䀵崷", num), 3);
                    dictionary1.Add(BookmarkStart.b("䜭帯䄱儳䈵", num), 4);
                    dictionary1.Add(BookmarkStart.b("䄭䔯䘱䜳匵䰷", num), 5);
                    dictionary1.Add(BookmarkStart.b("尭夯嘱匳匵", num), 6);
                    dictionary1.Add(BookmarkStart.b("崭弯帱崳刵", num), 7);
                    dictionary1.Add(BookmarkStart.b("䀭弯就儳", num), 8);
                    dictionary1.Add(BookmarkStart.b("䘭夯嘱倳匵嘷", num), 9);
                    Class1160.dictionary_142 = dictionary1;
                }
                if (Class1160.dictionary_142.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            return BorderStyle.DashLargeGap;

                        case 1:
                            return BorderStyle.Dot;

                        case 2:
                            return BorderStyle.Double;

                        case 3:
                            return BorderStyle.Engrave3D;

                        case 4:
                            return BorderStyle.Inset;

                        case 5:
                            return BorderStyle.Outset;

                        case 6:
                            return BorderStyle.Emboss3D;

                        case 7:
                            return BorderStyle.Single;

                        case 8:
                        case 9:
                            return BorderStyle.None;
                    }
                }
            }
            return BorderStyle.None;
        }

        private void method_2(string A_0, ref Color A_1, ref float A_2, ref BorderStyle A_3, Class747 A_4)
        {
            int num = 0x13;
            string[] strArray2 = new string[] { BookmarkStart.b("崸娺丼圾⑀❂", 0x13), BookmarkStart.b("崸吺䤼䬾⑀❂", 0x13), BookmarkStart.b("崸吺䠼崾ⵀ♂", 0x13), BookmarkStart.b("常䤺刼倾㝀♂", 0x13), BookmarkStart.b("倸唺丼娾㕀", 0x13), BookmarkStart.b("嘸为䤼䰾⑀㝂", 0x13), BookmarkStart.b("䬸刺夼堾⑀", 0x13), BookmarkStart.b("䨸吺儼嘾╀", 0x13), BookmarkStart.b("儸刺夼嬾⑀ⵂ", 0x13), BookmarkStart.b("圸吺匼娾", 0x13) };
            string[] strArray3 = A_0.Split(new char[] { ' ' });
            for (int i = 0; i < strArray3.Length; i++)
            {
                if (strArray3[i].StartsWith(BookmarkStart.b("ᨸ", num)))
                {
                    if (strArray3[i].Length > 6)
                    {
                        strArray3[i] = strArray3[i].Replace(BookmarkStart.b("ᨸ", num), string.Empty);
                        int red = int.Parse(strArray3[i].Substring(0, 2), NumberStyles.AllowHexSpecifier);
                        int green = int.Parse(strArray3[i].Substring(2, 2), NumberStyles.AllowHexSpecifier);
                        int blue = int.Parse(strArray3[i].Substring(4, 2), NumberStyles.AllowHexSpecifier);
                        A_1 = Color.FromArgb(red, green, blue);
                    }
                    else
                    {
                        A_1 = Class1007.smethod_0(strArray3[i]);
                    }
                }
                else if (A_4.method_90(strArray3[i]))
                {
                    A_2 = A_4.method_91(strArray3[i]);
                }
                else
                {
                    foreach (string str in strArray2)
                    {
                        if (strArray3[i] == str)
                        {
                            this.bool_0 = true;
                        }
                    }
                    if (this.bool_0)
                    {
                        A_3 = this.method_12(strArray3[i]);
                        this.bool_0 = false;
                    }
                    else
                    {
                        A_1 = Class1007.smethod_0(strArray3[i]);
                    }
                }
            }
        }

        internal void method_3(RowFormat A_0)
        {
            if (this.float_0 != -1f)
            {
                this.method_9(A_0.Borders, this.float_0);
                this.method_11(A_0.Borders, BorderStyle.Outset);
                if (this.color_0 == Color.Empty)
                {
                    this.method_10(A_0.Borders, Color.Silver);
                }
            }
            else
            {
                A_0.Borders.Left.HasNoneStyle = true;
                A_0.Borders.Right.HasNoneStyle = true;
                A_0.Borders.Top.HasNoneStyle = true;
                A_0.Borders.Bottom.HasNoneStyle = true;
                A_0.Borders.Vertical.HasNoneStyle = true;
                A_0.Borders.Horizontal.HasNoneStyle = true;
            }
            if (this.borderStyle_0 != BorderStyle.None)
            {
                this.method_11(A_0.Borders, this.borderStyle_0);
                this.method_10(A_0.Borders, Color.Silver);
                if (this.float_0 == -1f)
                {
                    this.method_9(A_0.Borders, 1f);
                }
            }
            if (this.color_0 != Color.Empty)
            {
                this.method_10(A_0.Borders, this.color_0);
            }
            this.method_8(A_0.Borders.Top, this.borderStyle_1, this.float_1, this.color_1);
            this.method_8(A_0.Borders.Bottom, this.borderStyle_2, this.float_2, this.color_2);
            this.method_8(A_0.Borders.Left, this.borderStyle_3, this.float_3, this.color_3);
            this.method_8(A_0.Borders.Right, this.borderStyle_4, this.float_4, this.color_4);
        }

        internal void method_4(CellFormat A_0)
        {
            bool flag = true;
            if (this.float_0 != -1f)
            {
                flag = false;
                if (this.borderStyle_0 != BorderStyle.None)
                {
                    this.method_9(A_0.Borders, this.float_0);
                    this.method_11(A_0.Borders, BorderStyle.Outset);
                }
            }
            if (this.borderStyle_0 != BorderStyle.None)
            {
                flag = false;
                this.method_11(A_0.Borders, this.borderStyle_0);
                this.method_10(A_0.Borders, Color.Silver);
                if (this.float_0 == -1f)
                {
                    this.method_9(A_0.Borders, 1f);
                }
            }
            if (this.color_0 != Color.Empty)
            {
                this.method_10(A_0.Borders, this.color_0);
            }
            this.method_8(A_0.Borders.Top, this.borderStyle_1, this.float_1, this.color_1);
            this.method_8(A_0.Borders.Bottom, this.borderStyle_2, this.float_2, this.color_2);
            this.method_8(A_0.Borders.Left, this.borderStyle_3, this.float_3, this.color_3);
            this.method_8(A_0.Borders.Right, this.borderStyle_4, this.float_4, this.color_4);
            if (flag && (this.class752_0 != null))
            {
                if (this.borderStyle_1 == BorderStyle.None)
                {
                    Color color2 = this.method_5(this.color_1, this.class752_0.color_1, this.class752_0.color_0);
                    float num2 = this.method_6(this.float_1, this.class752_0.float_1, this.class752_0.float_0);
                    BorderStyle style2 = this.method_7(this.borderStyle_1, this.class752_0.borderStyle_1, this.class752_0.borderStyle_0);
                    this.method_8(A_0.Borders.Top, style2, num2, color2);
                }
                if (this.borderStyle_2 == BorderStyle.None)
                {
                    Color color = this.method_5(this.color_2, this.class752_0.color_2, this.class752_0.color_0);
                    float num = this.method_6(this.float_2, this.class752_0.float_2, this.class752_0.float_0);
                    BorderStyle style = this.method_7(this.borderStyle_2, this.class752_0.borderStyle_2, this.class752_0.borderStyle_0);
                    this.method_8(A_0.Borders.Bottom, style, num, color);
                }
                if (this.borderStyle_3 == BorderStyle.None)
                {
                    Color color4 = this.method_5(this.color_3, this.class752_0.color_3, this.class752_0.color_0);
                    float num4 = this.method_6(this.float_3, this.class752_0.float_3, this.class752_0.float_0);
                    BorderStyle style4 = this.method_7(this.borderStyle_3, this.class752_0.borderStyle_3, this.class752_0.borderStyle_0);
                    this.method_8(A_0.Borders.Left, style4, num4, color4);
                }
                if (this.borderStyle_4 == BorderStyle.None)
                {
                    Color color3 = this.method_5(this.color_4, this.class752_0.color_4, this.class752_0.color_0);
                    float num3 = this.method_6(this.float_4, this.class752_0.float_4, this.class752_0.float_0);
                    BorderStyle style3 = this.method_7(this.borderStyle_4, this.class752_0.borderStyle_4, this.class752_0.borderStyle_0);
                    this.method_8(A_0.Borders.Right, style3, num3, color3);
                }
            }
        }

        private Color method_5(Color A_0, Color A_1, Color A_2)
        {
            if (A_0 != Color.Empty)
            {
                return A_0;
            }
            if (A_1 != Color.Empty)
            {
                return A_1;
            }
            return A_2;
        }

        private float method_6(float A_0, float A_1, float A_2)
        {
            if (A_0 != -1f)
            {
                return A_0;
            }
            if (A_1 != -1f)
            {
                return A_1;
            }
            return A_2;
        }

        private BorderStyle method_7(BorderStyle A_0, BorderStyle A_1, BorderStyle A_2)
        {
            if (A_0 != BorderStyle.None)
            {
                return A_0;
            }
            if (A_1 != BorderStyle.None)
            {
                return A_1;
            }
            return A_2;
        }

        private void method_8(Border A_0, BorderStyle A_1, float A_2, Color A_3)
        {
            if (A_2 != -1f)
            {
                if (A_1 != BorderStyle.None)
                {
                    A_0.LineWidth = A_2;
                }
                A_0.BorderType = A_1;
                if (A_3 == Color.Empty)
                {
                    A_0.Color = Color.Silver;
                }
            }
            if (A_1 != BorderStyle.None)
            {
                A_0.BorderType = A_1;
                A_0.Color = Color.Silver;
                if (A_2 == -1f)
                {
                    A_0.LineWidth = 1f;
                }
            }
            if (A_3 != Color.Empty)
            {
                A_0.Color = A_3;
            }
        }

        private void method_9(Borders A_0, float A_1)
        {
            A_0.LineWidth = A_1;
            A_0.Horizontal.LineWidth = A_1;
            A_0.Vertical.LineWidth = A_1;
        }
    }

    internal enum HtmlPageBreak
    {
        Auto,
        Always,
        Avoid,
        Left,
        Right
    }

    internal enum ThreeState
    {
        False,
        True,
        Unknown
    }
}

