using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

[DefaultMember("Item")]
internal class Class833 : XmlReader
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private CaseFolding caseFolding_0;
    private char char_0;
    private Class631 class631_0;
    private Class631 class631_1;
    private Class640 class640_0;
    private Class830 class830_0;
    private Class831 class831_0;
    private Class832 class832_0;
    private Class832 class832_1;
    private Dictionary<string, string> dictionary_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private State state_0;
    public const string string_0 = "#unknown";
    private const string string_1 = " \t\r\n><";
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_13;
    private string string_14;
    private string string_15;
    private string string_16;
    private const string string_2 = " \t\r\n=/><";
    private const string string_3 = " \t\r\n='\"/>";
    private const string string_4 = " \t\r\n>";
    private const string string_5 = "\t\r\n[]<>";
    private const string string_6 = " \t\r\n>";
    private const string string_7 = " \t\r\n?";
    private string string_8;
    private string string_9;
    private StringBuilder stringBuilder_0;
    private StringBuilder stringBuilder_1;
    private TextReader textReader_0;
    private TextWriter textWriter_0;
    private Uri uri_0;
    private WhitespaceHandling whitespaceHandling_0;

    public Class833()
    {
        this.bool_3 = true;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_31();
    }

    public Class833(XmlNameTable A_0)
    {
        this.bool_3 = true;
        this.dictionary_0 = new Dictionary<string, string>();
        this.method_31();
    }

    public Class640 method_0()
    {
        if (this.class640_0 == null)
        {
            this.method_2(this.uri_0);
        }
        return this.class640_0;
    }

    public void method_1(Class640 A_0)
    {
        this.class640_0 = A_0;
    }

    public string method_10()
    {
        return this.string_15;
    }

    public void method_11(string A_0)
    {
        this.string_15 = A_0;
    }

    public TextReader method_12()
    {
        return this.textReader_0;
    }

    public void method_13(TextReader A_0)
    {
        this.textReader_0 = A_0;
        this.method_31();
    }

    public string method_14()
    {
        return this.string_12;
    }

    public void method_15(string A_0)
    {
        this.string_12 = A_0;
    }

    public void method_16(string A_0)
    {
        this.uri_0 = new Uri(A_0);
    }

    public string method_17()
    {
        return this.string_10;
    }

    public void method_18(string A_0)
    {
        int num = 11;
        this.string_10 = A_0;
        this.method_31();
        if (this.uri_0 == null)
        {
            if (this.string_10.IndexOf(BookmarkStart.b("ରᰲᨴ", num)) > 0)
            {
                this.uri_0 = new Uri(this.string_10);
            }
            else
            {
                this.uri_0 = new Uri(BookmarkStart.b("地娲头制̸ᐺሼ", num) + Directory.GetCurrentDirectory() + BookmarkStart.b("Ḱᰲ", num));
            }
        }
    }

    public bool method_19()
    {
        return this.bool_3;
    }

    private void method_2(Uri A_0)
    {
        int num = 0;
        if ((((this.class640_0 == null) && !this.bool_1) && (!string.IsNullOrEmpty(this.string_13) && (this.string_16 != null))) && Class641.smethod_0(this.string_16, BookmarkStart.b("严尧䜩䀫", num)))
        {
            string name = BookmarkStart.b("甥堧䌩師䬭ḯ瘱嬳唵ᘷ根夻䴽⼿㝁㙃╅ⵇ㥉手ٍ⑏㽑㡓硕㱗⹙㡛", num);
            Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(name);
            if (manifestResourceStream != null)
            {
                StreamReader reader = new StreamReader(manifestResourceStream);
                this.class640_0 = Class640.smethod_1(A_0, BookmarkStart.b("渥簧朩怫", num), reader, null, this.string_12, null);
            }
        }
        if ((this.class640_0 != null) && (this.class640_0.method_0() != null))
        {
            switch (this.method_23())
            {
                case CaseFolding.ToUpper:
                    this.string_9 = this.class640_0.method_0().ToUpperInvariant();
                    break;

                case CaseFolding.ToLower:
                    this.string_9 = this.class640_0.method_0().ToLowerInvariant();
                    break;

                default:
                    this.string_9 = this.class640_0.method_0();
                    break;
            }
            this.bool_2 = Class641.smethod_0(this.class640_0.method_0(), BookmarkStart.b("严尧䜩䀫", num));
        }
    }

    public void method_20(bool A_0)
    {
        this.bool_3 = A_0;
    }

    public bool method_21()
    {
        return this.bool_1;
    }

    public void method_22(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public CaseFolding method_23()
    {
        return this.caseFolding_0;
    }

    public void method_24(CaseFolding A_0)
    {
        this.caseFolding_0 = A_0;
    }

    public TextWriter method_25()
    {
        return this.textWriter_0;
    }

    public void method_26(TextWriter A_0)
    {
        this.textWriter_0 = A_0;
    }

    public string method_27()
    {
        return this.string_11;
    }

    public void method_28(string A_0)
    {
        this.string_11 = A_0;
        this.textWriter_0 = new StreamWriter(A_0);
    }

    private void method_29(string A_0, params string[] A_1)
    {
        int num = 2;
        if (this.method_25() != null)
        {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, A_0, (object[]) A_1);
            if (this.class631_1 != this.class631_0)
            {
                str = str + BookmarkStart.b("ࠧ਩ఫอ", num) + this.class631_0.method_29();
                this.class631_1 = this.class631_0;
                this.method_25().WriteLine(BookmarkStart.b("ଧऩ༫อ甯䀱䘳夵䨷9", num) + str);
            }
            else
            {
                string absolutePath = "";
                if (this.class631_0.method_5() != null)
                {
                    absolutePath = this.class631_0.method_5().AbsolutePath;
                }
                this.method_25().WriteLine(BookmarkStart.b("ଧऩ༫อ甯䀱䘳夵䨷ᨹ唻倽怿㥁瑃㭅歇ㅉ絋㍍籏牑㡓㽕㙗㽙籛╝剟ὡ䡣䙥ᡧթὫݭѯ᭱᭳ᡵ塷Ź佻ͽ멿ꊁﾃ늅", num), new object[] { absolutePath, this.class631_0.method_0(), this.class631_0.method_8(), this.class631_0.method_9(), str });
            }
        }
    }

    public string method_3()
    {
        return this.string_16;
    }

    private void method_30(string A_0, char A_1)
    {
        this.method_29(A_0, new string[] { A_1.ToString() });
    }

    private void method_31()
    {
        this.state_0 = State.Initial;
        this.class830_0 = new Class830(10);
        this.class832_0 = this.method_32(null, XmlNodeType.Document, null);
        this.class832_0.bool_0 = false;
        this.stringBuilder_0 = new StringBuilder();
        this.stringBuilder_1 = new StringBuilder();
        this.int_1 = 0;
        this.class631_0 = null;
        this.char_0 = '\0';
        this.string_8 = null;
        this.class831_0 = null;
        this.int_0 = 0;
        this.class832_1 = null;
        this.int_2 = 0;
        this.bool_0 = false;
        this.dictionary_0.Clear();
    }

    private Class832 method_32(string A_0, XmlNodeType A_1, string A_2)
    {
        int num = 0x12;
        Class832 class2 = (Class832) this.class830_0.method_6();
        if (class2 == null)
        {
            class2 = new Class832();
            this.class830_0.method_4(this.class830_0.method_0() - 1, class2);
        }
        class2.method_0(A_0, A_1, string.IsNullOrEmpty(A_2) ? A_2 : A_2.Replace(BookmarkStart.b("з", num), BookmarkStart.b("ḷ嘹䠻Խ", num)).Replace(BookmarkStart.b("ط", num), BookmarkStart.b("ḷ崹䠻Խ", num)));
        this.class832_0 = class2;
        return class2;
    }

    private void method_33()
    {
        int num = this.class830_0.method_0() - 1;
        if (num > 0)
        {
            Class832 class2 = (Class832) this.class830_0.method_3(num - 1);
            this.class830_0.method_4(num - 1, this.class830_0.method_3(num));
            this.class830_0.method_4(num, class2);
        }
    }

    private Class832 method_34(Class832 A_0)
    {
        Class832 class2 = this.method_32(A_0.string_2, A_0.xmlNodeType_0, A_0.string_0);
        class2.class636_0 = A_0.class636_0;
        class2.bool_0 = A_0.bool_0;
        class2.xmlSpace_0 = A_0.xmlSpace_0;
        class2.string_1 = A_0.string_1;
        class2.state_0 = A_0.state_0;
        class2.method_3(A_0);
        this.class832_0 = class2;
        return class2;
    }

    private void method_35()
    {
        if (this.class830_0.method_0() > 1)
        {
            this.class832_0 = (Class832) this.class830_0.method_5();
        }
    }

    private Class832 method_36()
    {
        int num = this.class830_0.method_0() - 1;
        if (num > 0)
        {
            return (Class832) this.class830_0.method_3(num);
        }
        return null;
    }

    public WhitespaceHandling method_37()
    {
        return this.whitespaceHandling_0;
    }

    public void method_38(WhitespaceHandling A_0)
    {
        this.whitespaceHandling_0 = A_0;
    }

    public bool method_39()
    {
        return this.bool_2;
    }

    public void method_4(string A_0)
    {
        this.string_16 = A_0;
    }

    public Encoding method_40()
    {
        if (this.class631_0 == null)
        {
            this.method_41();
        }
        return this.class631_0.method_17();
    }

    private void method_41()
    {
        int num = 2;
        this.method_2(this.uri_0);
        if (this.method_17() != null)
        {
            this.class631_0 = new Class631(BookmarkStart.b("ଧ丩䌫䴭䔯弱儳堵䰷", num), null, this.string_10, this.string_12);
        }
        else
        {
            if (this.textReader_0 == null)
            {
                throw new InvalidOperationException(BookmarkStart.b("焧䔩夫อ崯䜱䜳䈵ᠷ䤹䰻嬽⌿⭁≃㽅桇⍉≋㹍╏♑瑓㍕ㅗ⹙㑛㭝቟䉡ባཥ१䩩⑫ᱭᕯᑱ味᥵੷婹㕻ၽ햅ﲇﶏ늑鍊풟쮡솣향", num));
            }
            this.class631_0 = new Class631(BookmarkStart.b("ଧ丩䌫䴭䔯弱儳堵䰷", num), null, this.textReader_0, this.string_12);
        }
        this.class631_0.method_2(this.method_39());
        this.class631_0.method_16(null, this.uri_0);
        if (this.class631_0.method_5() != null)
        {
            this.uri_0 = this.class631_0.method_5();
        }
        if (this.class631_0.method_1() && (this.class640_0 == null))
        {
            this.string_16 = BookmarkStart.b("性縩愫戭", num);
            this.method_2(this.uri_0);
        }
    }

    private bool method_42()
    {
        char ch = this.class631_0.method_7();
        switch (ch)
        {
            case '<':
                ch = this.class631_0.method_15();
                return this.method_43(ch);

            case 0xffff:
                this.state_0 = State.Eof;
                return false;
        }
        if ((this.class832_0.class636_0 != null) && (this.class832_0.class636_0.method_1().method_1() == DeclaredContent.CDATA))
        {
            this.char_0 = '\0';
            this.state_0 = State.CData;
            return false;
        }
        if (this.method_53(ch, true))
        {
            this.class832_0.xmlNodeType_0 = XmlNodeType.Whitespace;
        }
        return true;
    }

    private bool method_43(char A_0)
    {
        int num = 12;
        if (A_0 == '%')
        {
            return this.method_48();
        }
        if (A_0 == '!')
        {
            A_0 = this.class631_0.method_15();
            if (A_0 == '-')
            {
                return this.method_49();
            }
            if (A_0 == '[')
            {
                return this.method_50();
            }
            if ((A_0 != '_') && !char.IsLetter(A_0))
            {
                this.method_29(BookmarkStart.b("笱匳堵圷䠹唻倽✿扁ⵃ⡅㹇⭉⁋❍㑏牑㥓㝕⩗ㅙ⥛⹝䁟䕡塣䝥", num) + this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("怱儳唵圷䰹夻䰽⤿ⱁ⍃", num), BookmarkStart.b("ఱ", num)) + BookmarkStart.b("ఱ", num), new string[0]);
                return false;
            }
            string a = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ሱ㴳㬵㈷й;", num), false);
            if (string.Equals(a, BookmarkStart.b("瘱笳电氷挹氻笽", num), StringComparison.OrdinalIgnoreCase))
            {
                this.method_51();
                if ((this.GetAttribute(BookmarkStart.b("愱洳攵氷缹焻", num)) == null) && (this.GetAttribute(BookmarkStart.b("戱愳琵琷猹缻", num)) != null))
                {
                    this.class832_0.method_1(BookmarkStart.b("愱洳攵氷缹焻", num), "", '"', this.caseFolding_0 == CaseFolding.None);
                }
                if (this.bool_3)
                {
                    return false;
                }
                this.class832_0.xmlNodeType_0 = XmlNodeType.DocumentType;
                return true;
            }
            this.method_29(BookmarkStart.b("笱娳䀵夷嘹唻娽怿♁⅃╅⑇⭉㹋⽍⑏㭑㭓㡕硗絙恛罝᭟剡ᥣ䡥䙧䑩䭫䁭偯剱ㅳ๵ࡷόύ੽ꚅ꾇뚉궋쪍\udf8f\ud191삓쾕좗\udf99\ubb9b뺝쾟첡좣\udfa5\u86a7", num), new string[] { a });
            this.class631_0.method_22(null, BookmarkStart.b("怱儳唵圷䰹夻䰽⤿ⱁ⍃", num), BookmarkStart.b("ఱ", num));
            return false;
        }
        if (A_0 == '?')
        {
            this.class631_0.method_15();
            return this.method_52();
        }
        if (A_0 == '/')
        {
            return this.method_47();
        }
        return this.method_45(A_0);
    }

    private string method_44(string A_0)
    {
        string str = this.class631_0.method_20(this.stringBuilder_0, A_0, false);
        switch (this.caseFolding_0)
        {
            case CaseFolding.ToUpper:
                return str.ToUpperInvariant();

            case CaseFolding.ToLower:
                return str.ToLowerInvariant();
        }
        return str;
    }

    private bool method_45(char A_0)
    {
        int num = 13;
        string str = null;
        if (this.state_0 != State.PseudoStartTag)
        {
            if (BookmarkStart.b("ጲ㰴㨶㌸غሼľ絀", num).IndexOf(A_0) >= 0)
            {
                this.stringBuilder_0.Length = 0;
                this.stringBuilder_0.Append('<');
                this.state_0 = State.PartialText;
                return false;
            }
            str = this.method_44(BookmarkStart.b("ጲ㰴㨶㌸غሼľ絀", num));
        }
        else
        {
            this.state_0 = State.Markup;
        }
        Class832 class2 = this.method_32(str, XmlNodeType.Element, null);
        class2.bool_0 = this.method_46(class2.string_2);
        this.method_57(class2);
        A_0 = this.class631_0.method_19();
        while (true)
        {
            if ((A_0 == 0xffff) || (A_0 == '>'))
            {
                break;
            }
            if (A_0 == '/')
            {
                class2.bool_0 = true;
                A_0 = this.class631_0.method_15();
                if (A_0 != '>')
                {
                    this.method_30(BookmarkStart.b("瘲䴴䜶尸堺䤼娾╀捂⁄⩆㥈㽊㑌潎≐❒㑔╖ⵘ筚⥜㹞٠䍢䉤䡦坨䱪䵬ᱮᑰɲtቶ᝸᡺᡼彾꾎ﺐ떔낖ꮚ뢞", num), A_0);
                    this.class631_0.method_22(null, BookmarkStart.b("愲倴吶嘸䴺堼䴾⡀ⵂ≄", num), BookmarkStart.b("ല", num));
                    return false;
                }
                break;
            }
            if (A_0 == '<')
            {
                this.method_29(BookmarkStart.b("怲䄴嘶䬸伺ᴼ䬾⁀⑂敄恆㉈筊が桎煐㩒♔睖㑘㉚⹜ⱞࡠൢɤ䝦乨啪䩬", num), new string[] { str });
                break;
            }
            string a = this.method_44(BookmarkStart.b("ጲ㰴㨶㌸غᨼᴾ湀終", num));
            A_0 = this.class631_0.method_19();
            if ((!string.Equals(a, BookmarkStart.b("ἲ", num), StringComparison.OrdinalIgnoreCase) && !string.Equals(a, BookmarkStart.b("า", num), StringComparison.OrdinalIgnoreCase)) && (!string.Equals(a, BookmarkStart.b("ल", num), StringComparison.OrdinalIgnoreCase) && !string.Equals(a, BookmarkStart.b("࠲", num), StringComparison.OrdinalIgnoreCase)))
            {
                string str2 = null;
                char ch = '\0';
                if (((A_0 == '=') || (A_0 == '"')) || (A_0 == '\''))
                {
                    if (A_0 == '=')
                    {
                        this.class631_0.method_15();
                        A_0 = this.class631_0.method_19();
                    }
                    if ((A_0 != '\'') && (A_0 != '"'))
                    {
                        if (A_0 != '>')
                        {
                            string str4 = BookmarkStart.b("ጲ㰴㨶㌸Ժ", num);
                            str2 = this.class631_0.method_20(this.stringBuilder_0, str4, false);
                        }
                    }
                    else
                    {
                        ch = A_0;
                        str2 = this.method_54(this.stringBuilder_0, A_0);
                    }
                }
                if (smethod_13(a))
                {
                    Class831 class3 = class2.method_1(a, str2 ?? a, ch, this.caseFolding_0 == CaseFolding.None);
                    if (class3 == null)
                    {
                        this.method_29(BookmarkStart.b("眲䀴䜶唸刺帼帾㕀♂敄♆㵈㽊㽌♎㍐♒⅔㉖祘籚♜潞ᱠ䑢䕤๦๨ժɬᵮᑰᝲ", num), new string[] { a });
                    }
                    else
                    {
                        smethod_12(class2, class3);
                    }
                }
                A_0 = this.class631_0.method_19();
            }
        }
        if (A_0 == 0xffff)
        {
            this.class631_0.method_28(BookmarkStart.b("昲嬴制䄸䬺堼尾㕀♂⅄杆ైъୌ潎⅐㉒❔⑖じ㕚㩜罞በᝢѤᕦᵨ䭪ᥬ๮ᙰ卲剴౶䥸ٺ婼", num), str);
        }
        else if (A_0 == '>')
        {
            this.class631_0.method_15();
        }
        if (this.Depth == 1)
        {
            if (this.int_2 == 1)
            {
                this.state_0 = State.Eof;
                return false;
            }
            this.int_2++;
        }
        this.method_58(class2);
        return true;
    }

    private bool method_46(string A_0)
    {
        int num = 7;
        string key = A_0.ToLower();
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_155 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("䰬崮吰刲", num), 0);
                dictionary1.Add(BookmarkStart.b("伬丮䈰嘲", num), 1);
                dictionary1.Add(BookmarkStart.b("伬丮䈰嘲匴堶圸伺", num), 2);
                dictionary1.Add(BookmarkStart.b("伬崮", num), 3);
                dictionary1.Add(BookmarkStart.b("丬䀮崰", num), 4);
                dictionary1.Add(BookmarkStart.b("䠬䈮匰嘲儴", num), 5);
                dictionary1.Add(BookmarkStart.b("䬬崮倰帲倴", num), 6);
                dictionary1.Add(BookmarkStart.b("䔬崮", num), 7);
                dictionary1.Add(BookmarkStart.b("䐬䈮嘰", num), 8);
                dictionary1.Add(BookmarkStart.b("䐬䄮䄰䘲䄴", num), 9);
                dictionary1.Add(BookmarkStart.b("䘬䨮䠰吲倴夶", num), 10);
                dictionary1.Add(BookmarkStart.b("䄬䘮弰堲", num), 11);
                dictionary1.Add(BookmarkStart.b("䀬䨮䔰刲", num), 12);
                dictionary1.Add(BookmarkStart.b("崬丮䌰刲場", num), 13);
                Class1160.dictionary_155 = dictionary1;
            }
            if (Class1160.dictionary_155.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        return true;
                }
            }
        }
        return false;
    }

    private bool method_47()
    {
        int num = 11;
        State state = this.state_0;
        this.state_0 = State.EndTag;
        this.class631_0.method_15();
        string str = this.method_44(BookmarkStart.b("ᄰ㨲㠴㴶иᐺ̼̾", 11));
        char ch = this.class631_0.method_19();
        if (this.method_46(str))
        {
            this.state_0 = state;
            this.class631_0.method_22(null, BookmarkStart.b("挰嘲嘴堶伸帺似嘾⽀⑂", num), BookmarkStart.b("༰", num));
            return false;
        }
        if (ch != '>')
        {
            this.method_30(BookmarkStart.b("琰䬲䔴制娸伺堼嬾慀♂⡄㝆㵈㉊浌㱎═㉒❔⍖祘⽚㱜㡞䅠䑢䩤奦乨䭪Ṭ੮pٲၴ᥶᩸Ṻ嵼ᙾ권뎒는ꦘ몜", num), ch);
            this.class631_0.method_22(null, BookmarkStart.b("挰嘲嘴堶伸帺似嘾⽀⑂", num), BookmarkStart.b("༰", num));
        }
        this.class631_0.method_15();
        this.string_8 = str;
        bool flag = this.caseFolding_0 == CaseFolding.None;
        this.class832_0 = (Class832) this.class830_0.method_3(this.class830_0.method_0() - 1);
        for (int i = this.class830_0.method_0() - 1; i > 0; i--)
        {
            Class832 class2 = (Class832) this.class830_0.method_3(i);
            if (string.Equals(class2.string_2, str, flag ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
            {
                this.string_8 = class2.string_2;
                return true;
            }
        }
        this.method_29(BookmarkStart.b("缰尲ᔴ娶堸伺帼圾⡀ⵂ≄杆㩈㽊ⱌ㵎═獒⅔㙖㹘筚㭜ぞ፠䍢䉤学䙨ၪ嵬ቮ佰呲", num), new string[] { str });
        this.state_0 = State.Markup;
        return false;
    }

    private bool method_48()
    {
        string str = BookmarkStart.b("ᔨส", 3) + this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("栨堪崬愮吰䜲", 3), BookmarkStart.b("నᔪ", 3)) + BookmarkStart.b("నᔪ", 3);
        this.method_32(null, XmlNodeType.CDATA, str);
        return true;
    }

    private bool method_49()
    {
        int num = 7;
        char ch = this.class631_0.method_15();
        if (ch != '-')
        {
            this.method_30(BookmarkStart.b("栬圮䄰嘲嘴䌶倸唺娼Ἶ≀ⱂ⡄⩆ⱈ╊㥌潎癐潒瑔穖瑘籚絜㵞ᑠᝢ䕤Ŧ٨Ṫͬ୮兰ࡲ䕴੶", num), ch);
            this.class631_0.method_22(null, BookmarkStart.b("測䀮尰帲倴夶䴸", num), BookmarkStart.b("ጬ", num));
            return false;
        }
        string str = this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("測䀮尰帲倴夶䴸", num), BookmarkStart.b(",Ȯ༰", num));
        for (int i = str.IndexOf(BookmarkStart.b(",Ȯ", num)); i >= 0; i = str.IndexOf(BookmarkStart.b(",Ȯ", num)))
        {
            int startIndex = i + 2;
            while (startIndex < str.Length)
            {
                if (str[startIndex] != '-')
                {
                    break;
                }
                startIndex++;
            }
            if (i > 0)
            {
                str = str.Substring(0, i - 1) + BookmarkStart.b(",", num) + str.Substring(startIndex);
            }
            else
            {
                str = BookmarkStart.b(",", num) + str.Substring(startIndex);
            }
        }
        if ((str.Length > 0) && (str[str.Length - 1] == '-'))
        {
            str = str + BookmarkStart.b("ബ", num);
        }
        this.method_32(null, XmlNodeType.Comment, str);
        return true;
    }

    public string method_5()
    {
        return this.string_9;
    }

    private bool method_50()
    {
        int num = 0x10;
        char ch = this.class631_0.method_15();
        ch = this.class631_0.method_19();
        string a = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("㼵㔷〹朻挽簿籁", 0x10), false);
        if (a.StartsWith(BookmarkStart.b("張帷ᨹ", 0x10)))
        {
            this.class631_0.method_22(null, BookmarkStart.b("电簷笹栻缽", num), BookmarkStart.b("࠵", num));
            return false;
        }
        if (!string.Equals(a, BookmarkStart.b("电簷笹栻缽", num), StringComparison.OrdinalIgnoreCase))
        {
            this.method_29(BookmarkStart.b("猵䀷䨹夻崽㐿⭁⩃ⅅ桇ॉࡋཌྷяፑ瑓㑕ⵗ⹙籛㡝ཟᝡ੣ɥ䡧䵩ᝫ幭൯啱", num), new string[] { a });
            this.class631_0.method_22(null, BookmarkStart.b("电簷笹栻缽", num), BookmarkStart.b("࠵", num));
            return false;
        }
        ch = this.class631_0.method_19();
        if (ch != '[')
        {
            this.method_30(BookmarkStart.b("猵䀷䨹夻崽㐿⭁⩃ⅅ桇浉ᝋ楍灏け⅓≕硗㱙㍛⭝๟١䑣䅥፧婩ᅫ䥭", num), ch);
            this.class631_0.method_22(null, BookmarkStart.b("电簷笹栻缽", num), BookmarkStart.b("࠵", num));
            return false;
        }
        string str2 = this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("电簷笹栻缽", num), BookmarkStart.b("欵攷й", num));
        this.method_32(null, XmlNodeType.CDATA, str2);
        return true;
    }

    private void method_51()
    {
        int num = 2;
        char ch = this.class631_0.method_19();
        string str = this.method_44(BookmarkStart.b("ࠧ〈Å␭ฯ", 2));
        this.method_32(str, XmlNodeType.DocumentType, null);
        ch = this.class631_0.method_19();
        if (ch != '>')
        {
            string str2 = "";
            string str3 = "";
            string str4 = "";
            if (ch != '[')
            {
                string a = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ࠧ〈Å␭ฯ", num), false);
                if (string.Equals(a, BookmarkStart.b("砧缩渫戭礯焱", num), StringComparison.OrdinalIgnoreCase))
                {
                    ch = this.class631_0.method_19();
                    switch (ch)
                    {
                        case '"':
                        case '\'':
                            str3 = this.class631_0.method_21(this.stringBuilder_0, ch);
                            this.class832_0.method_1(a, str3, ch, this.caseFolding_0 == CaseFolding.None);
                            break;
                    }
                }
                else if (!string.Equals(a, BookmarkStart.b("笧猩缫稭甯缱", num), StringComparison.OrdinalIgnoreCase))
                {
                    this.method_29(BookmarkStart.b("紧䐩䤫嘭䀯圱圳䈵崷帹᰻䨽⼿⥁⅃⡅桇⍉≋湍ᑏᵑᝓɕŗਖ਼ᥛ繝䝟ᥡ呣᭥佧", num), new string[] { a });
                    this.class631_0.method_22(null, BookmarkStart.b("氧攩漫稭椯戱焳", num), BookmarkStart.b("ᘧ", num));
                }
                ch = this.class631_0.method_19();
                switch (ch)
                {
                    case '"':
                    case '\'':
                        a = BookmarkStart.b("笧猩缫稭甯缱", num);
                        str4 = this.class631_0.method_21(this.stringBuilder_0, ch);
                        this.class832_0.method_1(a, str4, ch, this.caseFolding_0 == CaseFolding.None);
                        break;
                }
                ch = this.class631_0.method_19();
            }
            if (ch == '[')
            {
                str2 = this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("愧䐩堫䬭䈯就唳娵ᠷ椹䤻尽㌿❁ぃ", num), BookmarkStart.b("甧", num));
                this.class832_0.string_0 = str2;
            }
            ch = this.class631_0.method_19();
            if (ch != '>')
            {
                this.method_30(BookmarkStart.b("洧利尫䬭匯䘱崳堵強ᨹ夻倽␿扁⭃⁅桇്้͋я୑ѓፕ硗⹙㵛㥝䱟䉡٣፥ᱧ䩩੫ŭկᱱၳ噵彷Ź䱻ͽꝿ", num), ch);
                this.class631_0.method_22(null, BookmarkStart.b("氧攩漫稭椯戱焳", num), BookmarkStart.b("ᘧ", num));
            }
            if ((this.class640_0 != null) && !string.Equals(this.class640_0.method_0(), str, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(BookmarkStart.b("氧縩栫อ启崱儳䔵ᠷ吹医䨽怿⽁╃㉅⭇≉汋⩍㽏ㅑ⅓㭕㵗㑙⡛繝ᑟ᭡ᑣͥ", num));
            }
            this.string_16 = str;
            this.string_14 = str3;
            this.string_13 = str4;
            this.string_15 = str2;
            this.method_2(this.class631_0.method_5());
        }
        this.class631_0.method_15();
    }

    private bool method_52()
    {
        int num = 1;
        string a = this.class631_0.method_20(this.stringBuilder_0, BookmarkStart.b("ܦ\u2028☪✬ီ", 1), false);
        string str2 = null;
        if (this.class631_0.method_7() != '?')
        {
            str2 = this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("眦嬨䐪丬䨮䈰䀲尴夶常ᬺ琼儾㉀㝂㝄㉆⩈㽊⑌⁎㽐", num), BookmarkStart.b("ᤦ", num)).TrimEnd(new char[] { '/' });
        }
        else
        {
            str2 = this.class631_0.method_22(this.stringBuilder_0, BookmarkStart.b("眦嬨䐪丬䨮䈰䀲尴夶常ᬺ琼儾㉀㝂㝄㉆⩈㽊⑌⁎㽐", num), BookmarkStart.b("ᤦ", num));
        }
        int index = a.IndexOf(':');
        if (index > 0)
        {
            a = a.Substring(index + 1);
        }
        if (!string.Equals(a, BookmarkStart.b("弦䐨䜪", num), StringComparison.OrdinalIgnoreCase))
        {
            this.method_32(a, XmlNodeType.ProcessingInstruction, str2);
            return true;
        }
        return false;
    }

    private bool method_53(char A_0, bool A_1)
    {
        bool flag = !A_1 || this.class631_0.method_13();
        if (A_1)
        {
            this.stringBuilder_0.Length = 0;
        }
        this.state_0 = State.Text;
        while (A_0 != 0xffff)
        {
            if (A_0 == '<')
            {
                A_0 = this.class631_0.method_15();
                if (((A_0 == '/') || (A_0 == '!')) || ((A_0 == '?') || char.IsLetter(A_0)))
                {
                    this.state_0 = State.PartialTag;
                    this.char_0 = A_0;
                    break;
                }
                this.stringBuilder_0.Append('<');
                flag = false;
            }
            else
            {
                if (A_0 == '&')
                {
                    this.method_56(this.stringBuilder_0, '<');
                    flag = false;
                    A_0 = this.class631_0.method_7();
                    continue;
                }
                if (!this.class631_0.method_13())
                {
                    flag = false;
                }
                this.stringBuilder_0.Append(A_0);
                A_0 = this.class631_0.method_15();
            }
        }
        string str = this.stringBuilder_0.ToString();
        this.method_32(null, XmlNodeType.Text, str);
        return flag;
    }

    private string method_54(StringBuilder A_0, char A_1)
    {
        A_0.Length = 0;
        char ch = this.class631_0.method_15();
        while (ch != 0xffff)
        {
            if (ch == A_1)
            {
                break;
            }
            if (ch == '&')
            {
                this.method_56(A_0, A_1);
                ch = this.class631_0.method_7();
            }
            else
            {
                A_0.Append(ch);
                ch = this.class631_0.method_15();
            }
        }
        if (ch == A_1)
        {
            this.class631_0.method_15();
        }
        return A_0.ToString();
    }

    private bool method_55()
    {
        int num = 7;
        bool flag = this.class631_0.method_13();
        this.stringBuilder_0.Length = 0;
        char ch = this.class631_0.method_7();
        if (this.char_0 != '\0')
        {
            this.method_35();
            switch (this.char_0)
            {
                case '!':
                    this.char_0 = ' ';
                    return this.method_49();

                case '/':
                    this.state_0 = State.EndTag;
                    return true;

                case '?':
                    this.char_0 = ' ';
                    return this.method_52();
            }
        }
        goto Label_01CC;
    Label_01C0:
        ch = this.class631_0.method_15();
    Label_01CC:
        if (ch != 0xffff)
        {
            if (ch == '<')
            {
                ch = this.class631_0.method_15();
                switch (ch)
                {
                    case '!':
                        ch = this.class631_0.method_15();
                        if (ch == '-')
                        {
                            if (flag)
                            {
                                this.char_0 = ' ';
                                return this.method_49();
                            }
                            this.char_0 = '!';
                            goto Label_0258;
                        }
                        this.stringBuilder_0.Append('<');
                        this.stringBuilder_0.Append('!');
                        this.stringBuilder_0.Append(ch);
                        flag = false;
                        goto Label_01C0;

                    case '?':
                        this.class631_0.method_15();
                        if (flag)
                        {
                            this.char_0 = ' ';
                            return this.method_52();
                        }
                        this.char_0 = '?';
                        goto Label_0258;

                    case '/':
                    {
                        string str = this.stringBuilder_0.ToString();
                        if (this.method_47() && string.Equals(this.string_8, this.class832_0.string_2, StringComparison.OrdinalIgnoreCase))
                        {
                            if (flag || string.IsNullOrEmpty(str))
                            {
                                return true;
                            }
                            this.char_0 = '/';
                            this.stringBuilder_0.Length = 0;
                            this.stringBuilder_0.Append(str);
                            this.state_0 = State.CData;
                            goto Label_0258;
                        }
                        this.stringBuilder_0.Length = 0;
                        this.stringBuilder_0.Append(str);
                        this.stringBuilder_0.Append(BookmarkStart.b("ᄬ.", num) + this.string_8 + BookmarkStart.b("ጬ", num));
                        flag = false;
                        ch = this.class631_0.method_7();
                        goto Label_01CC;
                    }
                }
                this.stringBuilder_0.Append('<');
                this.stringBuilder_0.Append(ch);
                flag = false;
            }
            else
            {
                if (!this.class631_0.method_13() && flag)
                {
                    flag = false;
                }
                this.stringBuilder_0.Append(ch);
            }
            goto Label_01C0;
        }
    Label_0258:
        if (ch == 0xffff)
        {
            this.state_0 = State.Eof;
            return false;
        }
        string str2 = this.stringBuilder_0.ToString().Replace(BookmarkStart.b("ᄬฮ樰瀲焴瘶洸稺昼", num), string.Empty).Replace(BookmarkStart.b("瀬爮༰", num), string.Empty).Replace(BookmarkStart.b("ȬԮᬰᰲ", num), string.Empty);
        this.method_32(null, XmlNodeType.CDATA, str2);
        if (this.char_0 == '\0')
        {
            this.char_0 = ' ';
        }
        return true;
    }

    private void method_56(StringBuilder A_0, char A_1)
    {
        int num = 7;
        char c = this.class631_0.method_15();
        if (c == '#')
        {
            string str = this.class631_0.method_23();
            A_0.Append(str);
            c = this.class631_0.method_7();
            return;
        }
        this.stringBuilder_1.Length = 0;
    Label_008B:
        if (((c == 0xffff) || ((!char.IsLetter(c) && (c != '_')) && (c != '-'))) && ((this.stringBuilder_1.Length <= 0) || !char.IsDigit(c)))
        {
            string str3 = this.stringBuilder_1.ToString();
            string str2 = str3;
            if (str2 != null)
            {
                if (str2 == BookmarkStart.b("䰬䈮䄰", num))
                {
                    A_0.Append(BookmarkStart.b("ବ", num));
                    if (((c != A_1) && (c != '&')) && (c != 0xffff))
                    {
                        c = this.class631_0.method_15();
                    }
                    return;
                }
                if (str2 == BookmarkStart.b("䄬嬮", num))
                {
                    A_0.Append(BookmarkStart.b("ᄬ", num));
                    if (((c != A_1) && (c != '&')) && (c != 0xffff))
                    {
                        c = this.class631_0.method_15();
                    }
                    return;
                }
                if (str2 == BookmarkStart.b("䨬嬮", num))
                {
                    A_0.Append(BookmarkStart.b("ጬ", num));
                    if (((c != A_1) && (c != '&')) && (c != 0xffff))
                    {
                        c = this.class631_0.method_15();
                    }
                    return;
                }
                if (str2 == BookmarkStart.b("尬娮帰䜲", num))
                {
                    A_0.Append(BookmarkStart.b("༬", num));
                    if (((c != A_1) && (c != '&')) && (c != 0xffff))
                    {
                        c = this.class631_0.method_15();
                    }
                    return;
                }
                if (str2 == BookmarkStart.b("䰬弮帰䀲", num))
                {
                    A_0.Append(BookmarkStart.b("ਬ", num));
                    if (((c != A_1) && (c != '&')) && (c != 0xffff))
                    {
                        c = this.class631_0.method_15();
                    }
                    return;
                }
            }
            if ((this.class640_0 != null) && !string.IsNullOrEmpty(str3))
            {
                Class631 class2 = this.class640_0.method_2(str3);
                if (class2 != null)
                {
                    if (class2.method_10())
                    {
                        A_0.Append(class2.method_11());
                        if (((c != A_1) && (c != '&')) && (c != 0xffff))
                        {
                            c = this.class631_0.method_15();
                        }
                        return;
                    }
                    Class631 class3 = new Class631(str3, class2.method_3(), class2.method_4(), this.class631_0.method_14());
                    class2.method_16(this.class631_0, new Uri(class2.method_4()));
                    this.class631_0 = class3;
                    this.class631_0.method_15();
                    return;
                }
                this.method_29(BookmarkStart.b("砬䄮唰嘲匴帶圸帺夼Ἶ⑀ⵂㅄ⹆㵈㉊浌桎⩐捒⡔灖", num), new string[] { str3 });
            }
            A_0.Append(BookmarkStart.b("ବ", num));
            A_0.Append(str3);
            if (((c != A_1) && (c != '&')) && (c != 0xffff))
            {
                A_0.Append(c);
                c = this.class631_0.method_15();
            }
        }
        else
        {
            this.stringBuilder_1.Append(c);
            c = this.class631_0.method_15();
            goto Label_008B;
        }
    }

    private void method_57(Class832 A_0)
    {
        if (this.class640_0 != null)
        {
            Class636 class2 = this.class640_0.method_3(A_0.string_2);
            if (class2 != null)
            {
                A_0.class636_0 = class2;
                if (class2.method_1().method_1() == DeclaredContent.EMPTY)
                {
                    A_0.bool_0 = true;
                }
            }
        }
    }

    private void method_58(Class832 A_0)
    {
        int num = 10;
        if (this.class640_0 != null)
        {
            string str = A_0.string_2.ToUpperInvariant();
            int num2 = 0;
            int num3 = this.class830_0.method_0() - 2;
            if (A_0.class636_0 != null)
            {
                num2 = num3;
                while (num2 > 0)
                {
                    Class832 class4 = (Class832) this.class830_0.method_3(num2);
                    if (!class4.bool_0)
                    {
                        Class636 class3 = class4.class636_0;
                        if (((class3 == null) || ((num2 == 2) && string.Equals(class3.method_0(), BookmarkStart.b("爯紱瀳漵", num), StringComparison.OrdinalIgnoreCase))) || ((string.Equals(class3.method_0(), this.class640_0.method_0(), StringComparison.OrdinalIgnoreCase) || class3.method_6(str, this.class640_0)) || !class3.method_2()))
                        {
                            break;
                        }
                    }
                    num2--;
                }
            }
            if ((num2 != 0) && (num2 < num3))
            {
                Class832 class2 = (Class832) this.class830_0.method_3(num3);
                if (num2 == (num3 - 1))
                {
                    string.Equals(str, class2.string_2, StringComparison.OrdinalIgnoreCase);
                }
                this.state_0 = State.AutoClose;
                this.class832_1 = A_0;
                this.method_35();
                this.int_1 = num2 + 1;
            }
        }
    }

    public string method_6()
    {
        return this.string_14;
    }

    public void method_7(string A_0)
    {
        this.string_14 = A_0;
    }

    public string method_8()
    {
        return this.string_13;
    }

    public void method_9(string A_0)
    {
        this.string_13 = A_0;
    }

    private static bool smethod_0(string A_0)
    {
        try
        {
            XmlConvert.VerifyName(A_0);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }

    public static XmlDocument smethod_1(TextReader A_0)
    {
        Class833 reader = new Class833();
        reader.method_4(BookmarkStart.b("性縩愫戭", 2));
        reader.method_24(CaseFolding.ToLower);
        reader.method_13(A_0);
        XmlDocument document = new XmlDocument {
            PreserveWhitespace = true,
            XmlResolver = null
        };
        document.Load(reader);
        List<XmlNode> list = new List<XmlNode>();
        smethod_5(document, ref list);
        smethod_2(list, document.DocumentElement);
        return document;
    }

    private static bool smethod_10(XmlNode A_0, XmlNode A_1, Dictionary<XmlNode, XmlNode> A_2)
    {
        int num = 2;
        Regex regex = new Regex(BookmarkStart.b("瘧ȩ尫刭䌯䈱唳堵䐷䨹主嬽㰿♁ⵃぅ慇湉", 2));
        if (A_0 != null)
        {
            if ((A_0.Value != null) && !A_2.ContainsKey(A_0))
            {
                return false;
            }
            XmlNode node2 = smethod_9(A_1, false);
            XmlNode node = smethod_9(A_1, true);
            bool flag = true;
            while (flag)
            {
                if ((node == null) || !(node.Name != BookmarkStart.b("䨧堩", num)))
                {
                    if (((node == null) || !(node.Name == BookmarkStart.b("䨧堩", num))) || regex.IsMatch(A_1.ParentNode.Name))
                    {
                        return false;
                    }
                    node = smethod_9(node, true);
                    if (((node != null) || (node2 == null)) && ((((node == null) || !(node.Name != BookmarkStart.b("尧䬩丫䈭唯", num))) || ((node2 != null) && !(node2.Name != BookmarkStart.b("尧䬩丫䈭唯", num)))) || (node.Value != null)))
                    {
                        return false;
                    }
                    return true;
                }
                if ((node.NodeType != XmlNodeType.Whitespace) && ((node2 == null) || (node2.Name != BookmarkStart.b("尧䬩丫䈭唯", num))))
                {
                    if (node == A_0)
                    {
                        return false;
                    }
                    if (!(flag = smethod_10(node, A_1, A_2)))
                    {
                        return flag;
                    }
                }
                else if ((node.Value != null) && !A_2.ContainsKey(A_0))
                {
                    return true;
                }
                node = smethod_9(node, true);
            }
        }
        return true;
    }

    private static void smethod_11(XmlNode A_0)
    {
        int num = 13;
        if (A_0 != null)
        {
            List<XmlNode> list = new List<XmlNode>();
            foreach (XmlNode node in A_0.ChildNodes)
            {
                if (node.LocalName.ToLower() == BookmarkStart.b("儲䜴", num))
                {
                    list.Add(node);
                }
            }
            int num2 = 0;
            int count = list.Count;
            while (num2 < count)
            {
                A_0.RemoveChild(list[num2]);
                num2++;
            }
        }
    }

    private static void smethod_12(Class832 A_0, Class831 A_1)
    {
        Class636 class2 = A_0.class636_0;
        if (class2 != null)
        {
            Class639 class3 = class2.method_4(A_1.string_0);
            if (class3 != null)
            {
                A_1.class639_0 = class3;
            }
        }
    }

    private static bool smethod_13(string A_0)
    {
        try
        {
            XmlConvert.VerifyNMTOKEN(A_0);
            int index = A_0.IndexOf(':');
            if (index >= 0)
            {
                XmlConvert.VerifyNCName(A_0.Substring(index + 1));
            }
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
        catch (ArgumentNullException)
        {
            return false;
        }
    }

    private static void smethod_2(List<XmlNode> A_0, XmlNode A_1)
    {
        int num = 0x11;
        if (A_0.Count > 0)
        {
            using (IEnumerator enumerator = A_1.ChildNodes.GetEnumerator())
            {
                XmlNode current;
                while (enumerator.MoveNext())
                {
                    current = (XmlNode) enumerator.Current;
                    if (current.NodeType == XmlNodeType.Element)
                    {
                        goto Label_0047;
                    }
                }
                return;
            Label_0047:
                if (current.Name.ToLower() != BookmarkStart.b("弶尸娺夼", num))
                {
                    XmlNode newChild = A_1.OwnerDocument.CreateElement(BookmarkStart.b("弶尸娺夼", num));
                    foreach (XmlNode node4 in A_0)
                    {
                        newChild.InnerXml = newChild.InnerXml + node4.OuterXml;
                    }
                    if (newChild != null)
                    {
                        A_1.InsertBefore(newChild, current);
                    }
                }
                else
                {
                    foreach (XmlNode node in A_0)
                    {
                        current.InsertBefore(node, null);
                    }
                }
            }
        }
    }

    public static XmlDocument smethod_3(string A_0)
    {
        XmlDocument document;
        using (MemoryStream stream = new MemoryStream())
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(A_0);
                writer.Flush();
                stream.Position = 0L;
                using (TextReader reader = new StreamReader(stream))
                {
                    document = smethod_1(reader);
                }
            }
        }
        return document;
    }

    public static void smethod_4(ref string A_0)
    {
        XmlDocument document = smethod_3(A_0);
        A_0 = document.InnerXml;
    }

    private static void smethod_5(XmlNode A_0, ref List<XmlNode> A_1)
    {
        int num = 15;
        smethod_6(A_0);
        List<XmlNode> list = new List<XmlNode>();
        foreach (XmlNode node in A_0.ChildNodes)
        {
            if ((node.Name == BookmarkStart.b("䄴䔶", num)) && (node.ParentNode.Name == BookmarkStart.b("䄴䔶", num)))
            {
                XmlNode parentNode = node.ParentNode;
                XmlNode previousSibling = node.PreviousSibling;
                while (previousSibling != null)
                {
                    if (!(previousSibling.Name != BookmarkStart.b("䄴匶", num)))
                    {
                        break;
                    }
                    previousSibling = previousSibling.PreviousSibling;
                }
                if (((previousSibling != null) && (previousSibling.Name == BookmarkStart.b("䄴匶", num))) && (previousSibling.LastChild.Name == BookmarkStart.b("䄴嘶嬸场堼", num)))
                {
                    previousSibling.LastChild.AppendChild(node.Clone());
                    list.Add(node);
                }
            }
            else if (node.Name == BookmarkStart.b("圴䔶", num))
            {
                smethod_8(node, list);
            }
            else if (node.Name == BookmarkStart.b("头帶", num))
            {
                smethod_11(node);
            }
            else if ((((node.Name.ToLower() == BookmarkStart.b("䘴䌶䀸场堼", num)) || (node.Name.ToLower() == BookmarkStart.b("䄴帶䴸场堼", num))) || (((node.Name.ToLower() == BookmarkStart.b("头帶圸债", num)) || (node.Name.ToLower() == BookmarkStart.b("場制䴸娺", num))) || (node.Name.ToLower() == BookmarkStart.b("䘴吶䬸刺䴼䬾", num)))) && (((node.ParentNode == null) || (node.ParentNode.Name != BookmarkStart.b("崴制堸强", num))) || ((node.ParentNode.ParentNode == null) || (node.ParentNode.ParentNode.Name != BookmarkStart.b("崴䌶吸场", num)))))
            {
                A_1.Add(node);
                list.Add(node);
            }
            if (node.ChildNodes.Count > 0)
            {
                smethod_5(node, ref A_1);
            }
        }
        if (list.Count > 0)
        {
            int num2 = 0;
            int count = list.Count;
            while (num2 < count)
            {
                A_0.RemoveChild(list[num2]);
                num2++;
            }
        }
    }

    private static void smethod_6(XmlNode A_0)
    {
        int num = 0x11;
        if ((((A_0 != null) && (A_0.ChildNodes.Count > 0)) && ((A_0.LocalName.ToLower() != BookmarkStart.b("䐶䤸娺匼", num)) && (A_0.LocalName.ToLower() != BookmarkStart.b("䜶", num)))) && ((A_0.LocalName.ToLower() != BookmarkStart.b("嘶", num)) || !smethod_7(A_0)))
        {
            for (int i = 0; i < A_0.ChildNodes.Count; i++)
            {
                XmlNode oldChild = A_0.ChildNodes[i];
                if ((oldChild.NodeType == XmlNodeType.Whitespace) && string.IsNullOrEmpty(oldChild.Value.Trim(new char[] { ' ' })))
                {
                    A_0.RemoveChild(oldChild);
                    i--;
                }
            }
        }
    }

    private static bool smethod_7(XmlNode A_0)
    {
        int num = 4;
        if (A_0 != null)
        {
            for (XmlNode node = A_0.ParentNode; node != null; node = node.ParentNode)
            {
                if (node.LocalName.ToLower() == BookmarkStart.b("娩", num))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private static void smethod_8(XmlNode A_0, List<XmlNode> A_1)
    {
        XmlNode parentNode = A_0.ParentNode;
        Regex regex = new Regex(BookmarkStart.b("琩尫刭䐯嘱䠳刵儷䰹䀻䨽ℿ⁁⡃⍅汇", 4));
        Dictionary<XmlNode, XmlNode> dictionary = new Dictionary<XmlNode, XmlNode>();
        while (parentNode != null)
        {
            if (regex.IsMatch(parentNode.Name))
            {
                break;
            }
            dictionary.Add(parentNode, A_0);
            parentNode = parentNode.ParentNode;
        }
        if ((parentNode != null) && smethod_10(parentNode, A_0, dictionary))
        {
            A_1.Add(A_0);
            dictionary.Clear();
        }
    }

    private static XmlNode smethod_9(XmlNode A_0, bool A_1)
    {
        Regex regex = new Regex(BookmarkStart.b("甪帬䰮䌰娲䔴䌶ᴸ", 5));
        XmlNode node = A_1 ? A_0.PreviousSibling : A_0.NextSibling;
        while (node != null)
        {
            if ((node.NodeType != XmlNodeType.Whitespace) && !regex.IsMatch(node.Name))
            {
                return node;
            }
            node = A_1 ? node.PreviousSibling : node.NextSibling;
        }
        return node;
    }

    void XmlReader.Close()
    {
        if (this.class631_0 != null)
        {
            this.class631_0.method_18();
            this.class631_0 = null;
        }
        if (this.textWriter_0 != null)
        {
            this.textWriter_0.Close();
            this.textWriter_0 = null;
        }
    }

    string XmlReader.GetAttribute(int A_0)
    {
        int num = 0;
        if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
        {
            Class831 class2 = this.class832_0.method_6(A_0);
            if (class2 != null)
            {
                return class2.method_1();
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("伥", num));
    }

    string XmlReader.GetAttribute(string A_0)
    {
        if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
        {
            int i = this.class832_0.method_5(A_0);
            if (i >= 0)
            {
                return this.GetAttribute(i);
            }
        }
        return null;
    }

    string XmlReader.GetAttribute(string A_0, string A_1)
    {
        return this.GetAttribute(A_0);
    }

    string XmlReader.LookupNamespace(string A_0)
    {
        return null;
    }

    void XmlReader.MoveToAttribute(int A_0)
    {
        int num = 1;
        Class831 class2 = this.class832_0.method_6(A_0);
        if (class2 == null)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("並", num));
        }
        this.int_0 = A_0;
        this.class831_0 = class2;
        if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
        {
            this.class832_0.state_0 = this.state_0;
        }
        this.state_0 = State.Attr;
    }

    bool XmlReader.MoveToAttribute(string A_0)
    {
        int i = this.class832_0.method_5(A_0);
        if (i >= 0)
        {
            this.MoveToAttribute(i);
            return true;
        }
        return false;
    }

    bool XmlReader.MoveToAttribute(string A_0, string A_1)
    {
        return this.MoveToAttribute(A_0);
    }

    bool XmlReader.MoveToElement()
    {
        if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
        {
            return (this.class832_0.xmlNodeType_0 == XmlNodeType.Element);
        }
        this.state_0 = this.class832_0.state_0;
        this.class831_0 = null;
        return true;
    }

    bool XmlReader.MoveToFirstAttribute()
    {
        if (this.class832_0.method_4() > 0)
        {
            this.MoveToAttribute(0);
            return true;
        }
        return false;
    }

    bool XmlReader.MoveToNextAttribute()
    {
        if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
        {
            return this.MoveToFirstAttribute();
        }
        if (this.int_0 < (this.class832_0.method_4() - 1))
        {
            this.MoveToAttribute((int) (this.int_0 + 1));
            return true;
        }
        return false;
    }

    bool XmlReader.Read()
    {
        int num = 12;
        if (this.class631_0 == null)
        {
            this.method_41();
        }
        if (this.class832_0.bool_1)
        {
            this.class832_0.bool_1 = false;
            this.class832_0 = this.method_36();
            this.state_0 = this.class832_0.state_0;
            return true;
        }
        bool flag = false;
        while (!flag)
        {
            switch (this.state_0)
            {
                case State.Initial:
                    this.state_0 = State.Markup;
                    this.class631_0.method_15();
                    goto Label_00EE;

                case State.Markup:
                    goto Label_00EE;

                case State.EndTag:
                    if (!string.Equals(this.string_8, this.class832_0.string_2, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    this.method_35();
                    this.state_0 = State.Markup;
                    goto Label_00EE;

                case State.Attr:
                case State.AttrValue:
                    this.state_0 = State.Markup;
                    goto Label_00EE;

                case State.Text:
                    this.method_35();
                    goto Label_00EE;

                case State.PartialTag:
                    this.method_35();
                    this.state_0 = State.Markup;
                    flag = this.method_43(this.char_0);
                    goto Label_01F3;

                case State.AutoClose:
                    this.method_35();
                    if (this.class830_0.method_0() <= this.int_1)
                    {
                        this.state_0 = State.Markup;
                        if (this.class832_1 == null)
                        {
                            goto Label_0171;
                        }
                        this.method_34(this.class832_1);
                        this.class832_1 = null;
                        this.state_0 = State.Markup;
                    }
                    goto Label_018A;

                case State.CData:
                    flag = this.method_55();
                    goto Label_01F3;

                case State.PartialText:
                    if (this.method_53(this.class631_0.method_7(), false))
                    {
                        this.class832_0.xmlNodeType_0 = XmlNodeType.Whitespace;
                    }
                    flag = true;
                    goto Label_01F3;

                case State.PseudoStartTag:
                    flag = this.method_45('<');
                    goto Label_01F3;

                case State.Eof:
                    goto Label_01C7;

                default:
                    goto Label_01F3;
            }
            this.method_35();
            flag = true;
            goto Label_01F3;
        Label_00EE:
            if (this.class832_0.bool_0)
            {
                this.method_35();
            }
            flag = this.method_42();
            goto Label_01F3;
        Label_0171:
            if (this.class832_0.xmlNodeType_0 == XmlNodeType.Document)
            {
                this.state_0 = State.Eof;
                goto Label_01C7;
            }
        Label_018A:
            flag = true;
            goto Label_01F3;
        Label_01C7:
            if (this.class631_0.method_6() == null)
            {
                return false;
            }
            this.class631_0.method_18();
            this.class631_0 = this.class631_0.method_6();
        Label_01F3:
            if ((flag && (this.class832_0.xmlNodeType_0 == XmlNodeType.Whitespace)) && (this.whitespaceHandling_0 == WhitespaceHandling.None))
            {
                flag = false;
            }
            if ((!flag && (this.state_0 == State.Eof)) && (this.class830_0.method_0() > 1))
            {
                this.int_1 = 1;
                this.state_0 = State.AutoClose;
                this.class832_0 = this.method_36();
                return true;
            }
        }
        if (!this.bool_0 && (((this.NodeType == XmlNodeType.Element) || (this.NodeType == XmlNodeType.Text)) || (this.NodeType == XmlNodeType.CDATA)))
        {
            this.bool_0 = true;
            if (this.method_39() && ((this.NodeType != XmlNodeType.Element) || !string.Equals(this.LocalName, BookmarkStart.b("娱䀳嬵吷", num), StringComparison.OrdinalIgnoreCase)))
            {
                this.class832_0.state_0 = this.state_0;
                Class832 class2 = this.method_32(BookmarkStart.b("娱䀳嬵吷", num), XmlNodeType.Element, null);
                this.method_33();
                this.class832_0 = class2;
                class2.bool_1 = true;
                class2.bool_0 = false;
                this.state_0 = State.Markup;
            }
        }
        return true;
    }

    bool XmlReader.ReadAttributeValue()
    {
        int num = 0x10;
        if (this.state_0 == State.Attr)
        {
            this.state_0 = State.AttrValue;
            return true;
        }
        if (this.state_0 != State.AttrValue)
        {
            throw new InvalidOperationException(BookmarkStart.b("砵圷丹᰻儽⸿扁╃⡅桇⭉㡋㩍≏㭑㙓⍕ⱗ㽙牛", num));
        }
        return false;
    }

    string XmlReader.ReadInnerXml()
    {
        StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
        XmlTextWriter writer2 = new XmlTextWriter(w) {
            Formatting = Formatting.Indented
        };
        switch (this.NodeType)
        {
            case XmlNodeType.Element:
                this.Read();
                while (!this.EOF)
                {
                    if (this.NodeType == XmlNodeType.EndElement)
                    {
                        break;
                    }
                    writer2.WriteNode(this, true);
                }
                break;

            case XmlNodeType.Attribute:
                w.Write(this.Value);
                goto Label_006C;

            default:
                goto Label_006C;
        }
        this.Read();
    Label_006C:
        writer2.Close();
        return w.ToString();
    }

    string XmlReader.ReadOuterXml()
    {
        StringWriter w = new StringWriter(CultureInfo.InvariantCulture);
        XmlTextWriter writer2 = new XmlTextWriter(w) {
            Formatting = Formatting.Indented
        };
        writer2.WriteNode(this, true);
        writer2.Close();
        return w.ToString();
    }

    string XmlReader.ReadString()
    {
        if (this.class832_0.xmlNodeType_0 != XmlNodeType.Element)
        {
            return this.class832_0.string_0;
        }
        this.stringBuilder_0.Length = 0;
        while (this.Read())
        {
            switch (this.NodeType)
            {
                case XmlNodeType.Text:
                case XmlNodeType.CDATA:
                case XmlNodeType.Whitespace:
                case XmlNodeType.SignificantWhitespace:
                    break;

                default:
                    return this.stringBuilder_0.ToString();
            }
            this.stringBuilder_0.Append(this.class832_0.string_0);
        }
        return this.stringBuilder_0.ToString();
    }

    void XmlReader.ResolveEntity()
    {
        throw new InvalidOperationException(BookmarkStart.b("簱嬳䈵ᠷ唹刻ḽℿⱁ摃⍅♇㹉╋㩍⥏牑♓㍕㹗㽙⹛㭝๟šţ䡥", 12));
    }

    int XmlReader.AttributeCount
    {
        get
        {
            if (((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue)) && ((this.class832_0.xmlNodeType_0 != XmlNodeType.Element) && (this.class832_0.xmlNodeType_0 != XmlNodeType.DocumentType)))
            {
                return 0;
            }
            return this.class832_0.method_4();
        }
    }

    string XmlReader.BaseURI
    {
        get
        {
            if (this.uri_0 != null)
            {
                return this.uri_0.AbsoluteUri;
            }
            return "";
        }
    }

    int XmlReader.Depth
    {
        get
        {
            if (this.state_0 == State.Attr)
            {
                return this.class830_0.method_0();
            }
            if (this.state_0 == State.AttrValue)
            {
                return (this.class830_0.method_0() + 1);
            }
            return (this.class830_0.method_0() - 1);
        }
    }

    bool XmlReader.EOF
    {
        get
        {
            return (this.state_0 == State.Eof);
        }
    }

    bool XmlReader.HasValue
    {
        get
        {
            if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
            {
                return (this.class832_0.string_0 != null);
            }
            return true;
        }
    }

    bool XmlReader.IsDefault
    {
        get
        {
            if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
            {
                return false;
            }
            return this.class831_0.method_2();
        }
    }

    bool XmlReader.IsEmptyElement
    {
        get
        {
            if (((this.state_0 != State.Markup) && (this.state_0 != State.Attr)) && (this.state_0 != State.AttrValue))
            {
                return false;
            }
            return this.class832_0.bool_0;
        }
    }

    string XmlReader.this[int A_0]
    {
        get
        {
            return this.GetAttribute(A_0);
        }
    }

    string XmlReader.this[string A_0]
    {
        get
        {
            return this.GetAttribute(A_0);
        }
    }

    string XmlReader.this[string A_0, string A_1]
    {
        get
        {
            return this.GetAttribute(A_0, A_1);
        }
    }

    string XmlReader.LocalName
    {
        get
        {
            string name = this.Name;
            if (name != null)
            {
                int index = name.IndexOf(':');
                if (index != -1)
                {
                    name = name.Substring(index + 1);
                }
            }
            return name;
        }
    }

    string XmlReader.Name
    {
        get
        {
            string str = null;
            if (this.state_0 == State.Attr)
            {
                return XmlConvert.EncodeName(this.class831_0.string_0);
            }
            if (this.state_0 != State.AttrValue)
            {
                str = this.class832_0.string_2;
            }
            return str;
        }
    }

    string XmlReader.NamespaceURI
    {
        get
        {
            int num = 14;
            if ((this.state_0 == State.Attr) && string.Equals(this.class831_0.string_0, BookmarkStart.b("䰳嬵吷吹伻", num), StringComparison.OrdinalIgnoreCase))
            {
                return BookmarkStart.b("尳䈵䰷䨹ػᄽ漿㕁㍃ㅅ晇㵉罋恍㽏⁑㍓祕橗橙汛湝佟ᩡॣ੥٧ᥩ䍫", num);
            }
            string prefix = this.Prefix;
            string str2 = this.Prefix;
            if (str2 != null)
            {
                if (str2 == BookmarkStart.b("䰳嬵吷吹伻", num))
                {
                    return BookmarkStart.b("尳䈵䰷䨹ػᄽ漿㕁㍃ㅅ晇㵉罋恍㽏⁑㍓祕橗橙汛湝佟ᩡॣ੥٧ᥩ䍫", num);
                }
                if (str2 == BookmarkStart.b("䰳嬵吷", num))
                {
                    return BookmarkStart.b("尳䈵䰷䨹ػᄽ漿㕁㍃ㅅ晇㵉罋恍㽏⁑㍓祕W᝙ၛ煝兟孡嵣幥䝧ѩ൫ͭᕯűѳ᝵᭷ό", num);
                }
                if (str2 != "")
                {
                    string str4;
                    if ((this.NodeType == XmlNodeType.Attribute) || (this.NodeType == XmlNodeType.Element))
                    {
                        string str = BookmarkStart.b("䰳嬵吷吹伻н", num) + prefix;
                        for (int i = this.class830_0.method_0() - 1; i > 0; i--)
                        {
                            Class832 class2 = this.class830_0.method_3(i) as Class832;
                            if ((class2 != null) && (class2.xmlNodeType_0 == XmlNodeType.Element))
                            {
                                int num2 = class2.method_5(str);
                                if (num2 >= 0)
                                {
                                    str4 = class2.method_6(num2).method_1();
                                    if (str4 != null)
                                    {
                                        return str4;
                                    }
                                }
                            }
                        }
                    }
                    if (!this.dictionary_0.TryGetValue(prefix, out str4))
                    {
                        if (this.dictionary_0.Count > 0)
                        {
                            str4 = BookmarkStart.b("ᜳ䌵嘷儹刻儽㜿ⱁ", num) + this.dictionary_0.Count.ToString();
                        }
                        else
                        {
                            str4 = BookmarkStart.b("ᜳ䌵嘷儹刻儽㜿ⱁ", num);
                        }
                        this.dictionary_0[prefix] = str4;
                    }
                    return str4;
                }
            }
            if ((this.NodeType != XmlNodeType.Attribute) && (this.NodeType == XmlNodeType.Element))
            {
                for (int j = this.class830_0.method_0() - 1; j > 0; j--)
                {
                    Class832 class3 = this.class830_0.method_3(j) as Class832;
                    if ((class3 != null) && (class3.xmlNodeType_0 == XmlNodeType.Element))
                    {
                        int num5 = class3.method_5(BookmarkStart.b("䰳嬵吷吹伻", num));
                        if (num5 >= 0)
                        {
                            string str5 = class3.method_6(num5).method_1();
                            if (str5 != null)
                            {
                                return str5;
                            }
                        }
                    }
                }
            }
            return string.Empty;
        }
    }

    XmlNameTable XmlReader.NameTable
    {
        get
        {
            return null;
        }
    }

    XmlNodeType XmlReader.NodeType
    {
        get
        {
            if (this.state_0 == State.Attr)
            {
                return XmlNodeType.Attribute;
            }
            if (this.state_0 == State.AttrValue)
            {
                return XmlNodeType.Text;
            }
            if ((this.state_0 != State.EndTag) && (this.state_0 != State.AutoClose))
            {
                return this.class832_0.xmlNodeType_0;
            }
            return XmlNodeType.EndElement;
        }
    }

    string XmlReader.Prefix
    {
        get
        {
            string name = this.Name;
            if (name != null)
            {
                int index = name.IndexOf(':');
                if (index != -1)
                {
                    name = name.Substring(0, index);
                }
                else
                {
                    name = string.Empty;
                }
            }
            return (name ?? string.Empty);
        }
    }

    char XmlReader.QuoteChar
    {
        get
        {
            if (this.class831_0 != null)
            {
                return this.class831_0.char_0;
            }
            return '\0';
        }
    }

    ReadState XmlReader.ReadState
    {
        get
        {
            if (this.state_0 == State.Initial)
            {
                return ReadState.Initial;
            }
            if (this.state_0 == State.Eof)
            {
                return ReadState.EndOfFile;
            }
            return ReadState.Interactive;
        }
    }

    string XmlReader.Value
    {
        get
        {
            if ((this.state_0 != State.Attr) && (this.state_0 != State.AttrValue))
            {
                return this.class832_0.string_0;
            }
            return this.class831_0.method_1();
        }
    }

    string XmlReader.XmlLang
    {
        get
        {
            for (int i = this.class830_0.method_0() - 1; i > 1; i--)
            {
                Class832 class2 = (Class832) this.class830_0.method_3(i);
                string str = class2.string_1;
                if (str != null)
                {
                    return str;
                }
            }
            return string.Empty;
        }
    }

    XmlSpace XmlReader.XmlSpace
    {
        get
        {
            for (int i = this.class830_0.method_0() - 1; i > 1; i--)
            {
                Class832 class2 = (Class832) this.class830_0.method_3(i);
                XmlSpace space = class2.xmlSpace_0;
                if (space != XmlSpace.None)
                {
                    return space;
                }
            }
            return XmlSpace.None;
        }
    }
}

