using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

internal class Class631 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    public const char char_0 = '￿';
    private char char_1;
    private Class631 class631_0;
    private Encoding encoding_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private static int[] int_3 = new int[] { 
        0x20ac, 0x81, 0x201a, 0x192, 0x201e, 0x2026, 0x2020, 0x2021, 710, 0x2030, 0x160, 0x2039, 0x152, 0x8d, 0x17d, 0x8f, 
        0x90, 0x2018, 0x2019, 0x201c, 0x201d, 0x2022, 0x2013, 0x2014, 0x2dc, 0x2122, 0x161, 0x203a, 0x153, 0x9d, 0x17e, 0x178
     };
    private LiteralType literalType_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private TextReader textReader_0;
    private Uri uri_0;

    public Class631(string A_0, string A_1)
    {
        this.string_1 = A_0;
        this.string_4 = A_1;
        this.bool_0 = true;
    }

    public Class631(string A_0, string A_1, string A_2, string A_3)
    {
        int num = 6;
        this.string_1 = A_0;
        this.string_2 = A_1;
        this.string_3 = A_2;
        this.string_0 = A_3;
        this.bool_1 = (A_0 != null) && Class641.smethod_0(A_0, BookmarkStart.b("䐫娭崯帱", num));
    }

    public Class631(string A_0, Uri A_1, TextReader A_2, string A_3)
    {
        this.string_1 = A_0;
        this.bool_0 = true;
        this.textReader_0 = A_2;
        this.uri_0 = A_1;
        this.string_0 = A_3;
        this.bool_1 = string.Equals(A_0, BookmarkStart.b("伦崨䘪䄬", 1), StringComparison.OrdinalIgnoreCase);
    }

    public string method_0()
    {
        return this.string_1;
    }

    public bool method_1()
    {
        return this.bool_1;
    }

    public bool method_10()
    {
        return this.bool_0;
    }

    public string method_11()
    {
        return this.string_4;
    }

    public LiteralType method_12()
    {
        return this.literalType_0;
    }

    public bool method_13()
    {
        return this.bool_2;
    }

    public string method_14()
    {
        return this.string_0;
    }

    public char method_15()
    {
        char ch = (char) this.textReader_0.Read();
        if (ch == '\0')
        {
            ch = ' ';
        }
        this.int_2++;
        switch (ch)
        {
            case '\n':
                this.bool_2 = true;
                this.int_1 = this.int_2 + 1;
                this.int_0++;
                break;

            case ' ':
            case '\t':
                this.bool_2 = true;
                if (this.char_1 == '\r')
                {
                    this.int_1 = this.int_2;
                    this.int_0++;
                }
                break;

            case '\r':
                this.bool_2 = true;
                break;

            default:
                this.bool_2 = false;
                if (this.char_1 == '\r')
                {
                    this.int_0++;
                    this.int_1 = this.int_2;
                }
                break;
        }
        this.char_1 = ch;
        return ch;
    }

    public void method_16(Class631 A_0, Uri A_1)
    {
        int num = 0;
        this.class631_0 = A_0;
        if (A_0 != null)
        {
            this.bool_1 = A_0.method_1();
        }
        this.int_0 = 1;
        if (this.bool_0)
        {
            if (this.string_4 != null)
            {
                this.textReader_0 = new StringReader(this.string_4);
            }
        }
        else if (this.string_3 == null)
        {
            this.method_28(BookmarkStart.b("猥䘧堩䤫崭弯帱䈳圵娷嘹夻ḽ┿ⱁぃ⽅㱇㍉汋楍⭏扑⥓煕", num), this.string_1);
        }
        else
        {
            string str4;
            if (A_1 != null)
            {
                this.uri_0 = new Uri(A_1, this.string_3);
            }
            else
            {
                this.uri_0 = new Uri(this.string_3);
            }
            Stream responseStream = null;
            Encoding encoding = Encoding.Default;
            if (((str4 = this.uri_0.Scheme) != null) && (str4 == BookmarkStart.b("䀥䄧䘩䤫", num)))
            {
                responseStream = new FileStream(this.uri_0.LocalPath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.method_5());
                request.UserAgent = BookmarkStart.b("欥䜧倩䔫䈭尯匱ᬳȵᘷਹ᰻ᘽ⌿ⵁ⥃㙅⥇㹉╋ⱍ㱏㝑潓罕捗", num);
                request.Timeout = 0x2710;
                if (this.string_0 != null)
                {
                    request.Proxy = new WebProxy(this.string_0);
                }
                request.PreAuthenticate = false;
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = request.GetResponse();
                Uri responseUri = response.ResponseUri;
                if (!string.Equals(responseUri.AbsoluteUri, this.uri_0.AbsoluteUri, StringComparison.OrdinalIgnoreCase))
                {
                    this.uri_0 = responseUri;
                }
                string str = response.ContentType.ToLowerInvariant();
                string str2 = str;
                int index = str.IndexOf(';');
                if (index >= 0)
                {
                    str2 = str.Substring(0, index);
                }
                if (Class641.smethod_0(str2, BookmarkStart.b("別䴧利堫ĭ堯䘱夳娵", num)))
                {
                    this.bool_1 = true;
                }
                index = str.IndexOf(BookmarkStart.b("䔥䀧䬩師崭唯䘱", num));
                encoding = Encoding.Default;
                if (index >= 0)
                {
                    int startIndex = str.IndexOf(BookmarkStart.b("ᬥ", num), index);
                    int length = str.IndexOf(BookmarkStart.b("ᴥ", num), startIndex);
                    if (length < 0)
                    {
                        length = str.Length;
                    }
                    if (startIndex > 0)
                    {
                        startIndex++;
                        string name = str.Substring(startIndex, length - startIndex).Trim();
                        try
                        {
                            encoding = Encoding.GetEncoding(name);
                        }
                        catch (ArgumentException)
                        {
                        }
                    }
                }
                responseStream = response.GetResponseStream();
            }
            this.bool_3 = true;
            Class632 class2 = new Class632(responseStream, encoding);
            this.encoding_0 = class2.method_0();
            this.textReader_0 = class2;
        }
    }

    public Encoding method_17()
    {
        return this.encoding_0;
    }

    public void method_18()
    {
        if (this.bool_3)
        {
            this.textReader_0.Close();
        }
    }

    public char method_19()
    {
        char ch = this.char_1;
        while (ch != 0xffff)
        {
            if (((ch != ' ') && (ch != '\r')) && ((ch != '\n') && (ch != '\t')))
            {
                return ch;
            }
            ch = this.method_15();
        }
        return ch;
    }

    public void method_2(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public string method_20(StringBuilder A_0, string A_1, bool A_2)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱嘳", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘱儳䐵唷", num));
        }
        A_0.Length = 0;
        char c = this.char_1;
        if ((A_2 && (c != '_')) && !char.IsLetter(c))
        {
            throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("笱娳䀵夷嘹唻娽怿ⱁ╃⭅ⵇ橉㽋㩍ㅏ⁑⁓癕㭗㉙㵛ⱝşšၣͥᩧ䩩䭫ᕭ䁯ཱ即", num), new object[] { c }));
        }
        while ((c != 0xffff) && (A_1.IndexOf(c) < 0))
        {
            if (((A_2 && (c != '_')) && ((c != '.') && (c != '-'))) && ((c != ':') && !char.IsLetterOrDigit(c)))
            {
                throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("笱娳䀵夷嘹唻娽怿ⱁ╃⭅ⵇ橉⽋♍ㅏ⁑㕓㕕ⱗ㽙⹛繝䝟ᥡ呣᭥佧", num), new object[] { c }));
            }
            A_0.Append(c);
            c = this.method_15();
        }
        return A_0.ToString();
    }

    public string method_21(StringBuilder A_0, char A_1)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堪伬", num));
        }
        A_0.Length = 0;
        char ch = this.method_15();
        while (ch != 0xffff)
        {
            if (ch == A_1)
            {
                break;
            }
            if (ch == '&')
            {
                ch = this.method_15();
                if (ch == '#')
                {
                    string str = this.method_23();
                    A_0.Append(str);
                    ch = this.char_1;
                }
                else
                {
                    A_0.Append('&');
                    A_0.Append(ch);
                    ch = this.method_15();
                }
            }
            else
            {
                A_0.Append(ch);
                ch = this.method_15();
            }
        }
        this.method_15();
        return A_0.ToString();
    }

    public string method_22(StringBuilder A_0, string A_1, string A_2)
    {
        int num = 0;
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("別䴧堩䄫䜭帯匱䀳夵䨷䤹", num));
        }
        if (A_0 != null)
        {
            A_0.Length = 0;
        }
        int num7 = this.int_0;
        char ch2 = this.method_15();
        int num4 = 0;
        char ch = A_2[0];
        while (ch2 != 0xffff)
        {
            if (ch2 == ch)
            {
                num4++;
                if (num4 >= A_2.Length)
                {
                    break;
                }
                ch = A_2[num4];
            }
            else if (num4 > 0)
            {
                int num2 = num4 - 1;
                int num5 = 0;
                while (num2 >= 0)
                {
                    if (num5 != 0)
                    {
                        break;
                    }
                    if (A_2[num2] == ch2)
                    {
                        int num3 = 1;
                        while ((num2 - num3) >= 0)
                        {
                            if (A_2[num2 - num3] != A_2[num4 - num3])
                            {
                                break;
                            }
                            num3++;
                        }
                        if (num3 > num2)
                        {
                            num5 = num2 + 1;
                        }
                        continue;
                    }
                    num2--;
                }
                if (A_0 != null)
                {
                    num2 = (num2 < 0) ? 1 : 0;
                    for (int i = 0; i <= ((num4 - num5) - num2); i++)
                    {
                        A_0.Append(A_2[i]);
                    }
                    if (num2 > 0)
                    {
                        A_0.Append(ch2);
                    }
                }
                num4 = num5;
                ch = A_2[num5];
            }
            else if (A_0 != null)
            {
                A_0.Append(ch2);
            }
            ch2 = this.method_15();
        }
        if (ch2 == '\0')
        {
            this.method_27(A_1 + BookmarkStart.b("إ嬧帩䴫尭䐯嬱娳儵ᠷ唹刻ḽⰿ⭁⩃⍅桇ㅉ籋㍍灏║㕓╕硗㑙㥛⡝՟ၡ䑣եѧթὫ୭ᑯ", num), num7);
        }
        this.method_15();
        if (A_0 != null)
        {
            return A_0.ToString();
        }
        return string.Empty;
    }

    public string method_23()
    {
        string str;
        int num = 11;
        int num2 = this.method_24(out str);
        if (str == BookmarkStart.b("ᜰဲдĶस", 11))
        {
            return str;
        }
        if (num2 == -1)
        {
            return str;
        }
        if (this.bool_1 && ((num2 >= 0x80) & (num2 <= 0x9f)))
        {
            int index = num2 - 0x80;
            int num5 = int_3[index];
            return Convert.ToChar(num5).ToString();
        }
        if ((0xd800 <= num2) && (num2 <= 0xdbff))
        {
            if (this.char_1 == '&')
            {
                char ch = this.method_15();
                if (ch == '#')
                {
                    string str2;
                    int num3 = this.method_24(out str2);
                    if (num3 == -1)
                    {
                        return (str + BookmarkStart.b("ਰ", num) + str2);
                    }
                    if ((0xdc00 <= num3) && (num3 <= 0xdfff))
                    {
                        num2 = char.ConvertToUtf32((char) num2, (char) num3);
                    }
                }
                else
                {
                    this.method_26(BookmarkStart.b("愰䄲倴娶堸伺䠼䴾⑀捂㹄睆㑈歊㵌⹎⍐⁒㱔㥖㹘筚⹜⩞፠ᅢ੤fࡨὪ࡬佮Űቲᱴն", num), ch);
                }
            }
            else
            {
                this.method_26(BookmarkStart.b("愰䄲倴娶堸伺䠼䴾⑀捂㹄睆㑈歊㵌⹎⍐⁒㱔㥖㹘筚⹜⩞፠ᅢ੤fࡨὪ࡬佮Űቲᱴն", num), this.char_1);
            }
        }
        return char.ConvertFromUtf32(num2);
    }

    private int method_24(out string A_0)
    {
        bool flag2;
        int num = 3;
        int num2 = 0;
        char ch = this.method_15();
        A_0 = BookmarkStart.b("༨ࠪ", 3);
        if (ch != 'x')
        {
            flag2 = false;
            while (ch != 0xffff)
            {
                if (((ch == ';') || (ch < '0')) || (ch > '9'))
                {
                    break;
                }
                num2 = (num2 * 10) + (ch - '0');
                flag2 = true;
                A_0 = A_0 + ch;
                ch = this.method_15();
            }
        }
        else
        {
            bool flag = false;
            A_0 = A_0 + BookmarkStart.b("儨", num);
            ch = this.method_15();
            while (ch != 0xffff)
            {
                if (ch == ';')
                {
                    break;
                }
                int num3 = 0;
                if ((ch >= '0') && (ch <= '9'))
                {
                    num3 = ch - '0';
                    flag = true;
                }
                else if ((ch >= 'a') && (ch <= 'f'))
                {
                    num3 = (ch - 'a') + 10;
                    flag = true;
                }
                else
                {
                    if ((ch < 'A') || (ch > 'F'))
                    {
                        break;
                    }
                    num3 = (ch - 'A') + 10;
                    flag = true;
                }
                A_0 = A_0 + ch;
                num2 = (num2 * 0x10) + num3;
                ch = this.method_15();
            }
            if (flag)
            {
                goto Label_0103;
            }
            return -1;
        }
        if (!flag2)
        {
            return -1;
        }
    Label_0103:
        switch (ch)
        {
            case '\0':
                this.method_26(BookmarkStart.b("礨太䠬䈮倰䜲䀴䔶尸ᬺ䘼༾㱀捂㕄♆㭈㡊⑌ⅎ㙐獒ご㥖ⵘ㉚⥜♞䅠ᅢdŦ౨ᥪ࡬Ůተᙲ", num), ch);
                return num2;

            case ';':
                this.method_15();
                return num2;
        }
        return num2;
    }

    public void method_25(string A_0)
    {
        throw new Exception1(A_0, this);
    }

    public void method_26(string A_0, char A_1)
    {
        int num = 0x10;
        string str = (A_1 == 0xffff) ? BookmarkStart.b("猵眷簹", num) : char.ToString(A_1);
        throw new Exception1(string.Format(CultureInfo.CurrentUICulture, A_0, new object[] { str }), this);
    }

    public void method_27(string A_0, int A_1)
    {
        throw new Exception1(string.Format(CultureInfo.CurrentUICulture, A_0, new object[] { A_1 }), this);
    }

    public void method_28(string A_0, string A_1)
    {
        throw new Exception1(string.Format(CultureInfo.CurrentUICulture, A_0, new object[] { A_1 }), this);
    }

    public string method_29()
    {
        int num = 3;
        Class631 class2 = this;
        StringBuilder builder = new StringBuilder();
        while (class2 != null)
        {
            string str;
            if (class2.bool_0)
            {
                str = string.Format(CultureInfo.InvariantCulture, BookmarkStart.b("⌨礪䠬䤮吰䄲倴夶娸帺夼Ἶ⹀ⵂ敄⭆⁈╊⡌潎⩐捒⡔策祘⭚㉜ⱞࡠᝢ౤ࡦݨ䭪ᙬ幮౰卲ᩴᅶ奸ቺ፼୾ꮊ朗릘벚궞\udca0\u84a2", num), new object[] { class2.int_0, class2.method_9(), class2.string_1 });
            }
            else
            {
                str = string.Format(CultureInfo.InvariantCulture, BookmarkStart.b("⌨礪䠬䤮吰䄲倴夶娸帺夼Ἶ⹀ⵂ敄⭆⁈╊⡌潎⩐捒⡔策祘⭚㉜ⱞࡠᝢ౤ࡦݨ䭪ᙬ幮౰卲ᩴᅶ奸屺ټ䵾ﲀꒂꖄﾊﮎ뎒릘삚겞\udca0\ufea2", num), new object[] { class2.int_0, class2.method_9(), class2.string_1, class2.method_5().AbsolutePath });
            }
            builder.Append(str);
            class2 = class2.method_6();
        }
        return builder.ToString();
    }

    public string method_3()
    {
        return this.string_2;
    }

    public void method_30(string A_0)
    {
        int num = 5;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("株椬渮攰爲", num))
            {
                this.literalType_0 = LiteralType.CDATA;
            }
            else if (str == BookmarkStart.b("砪椬渮攰爲", num))
            {
                this.literalType_0 = LiteralType.SDATA;
            }
            else if (str == BookmarkStart.b("笪搬", num))
            {
                this.literalType_0 = LiteralType.PI;
            }
        }
    }

    public string method_4()
    {
        return this.string_3;
    }

    public Uri method_5()
    {
        if (this.uri_0 != null)
        {
            return this.uri_0;
        }
        if (this.class631_0 != null)
        {
            return this.class631_0.method_5();
        }
        return null;
    }

    public Class631 method_6()
    {
        return this.class631_0;
    }

    public char method_7()
    {
        return this.char_1;
    }

    public int method_8()
    {
        return this.int_0;
    }

    public int method_9()
    {
        return ((this.int_2 - this.int_1) + 1);
    }

    public static bool smethod_0(string A_0)
    {
        int num = 0x10;
        if (!string.Equals(A_0, BookmarkStart.b("电簷笹栻缽", 0x10), StringComparison.OrdinalIgnoreCase) && !string.Equals(A_0, BookmarkStart.b("攵簷笹栻缽", num), StringComparison.OrdinalIgnoreCase))
        {
            return string.Equals(A_0, BookmarkStart.b("昵焷", num), StringComparison.OrdinalIgnoreCase);
        }
        return true;
    }

    void IDisposable.Dispose()
    {
        this.vmethod_0(true);
        GC.SuppressFinalize(this);
    }

    void object.Finalize()
    {
        try
        {
            this.vmethod_0(false);
        }
        finally
        {
            base.Finalize();
        }
    }

    protected virtual void vmethod_0(bool A_0)
    {
        if (A_0 && (this.textReader_0 != null))
        {
            this.textReader_0.Dispose();
            this.textReader_0 = null;
        }
    }
}

