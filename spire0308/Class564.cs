using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Text;

internal class Class564 : IDisposable
{
    private bool bool_0;
    private bool bool_1 = true;
    private bool bool_2 = true;
    private const char char_0 = '{';
    private const char char_1 = '}';
    private const char char_2 = '\\';
    private const char char_3 = ' ';
    private const char char_4 = '\r';
    private const char char_5 = '\n';
    private const char char_6 = ';';
    private const char char_7 = ':';
    private char char_8;
    private Class1084 class1084_0;
    private int int_0;
    private int int_1;
    private RtfTableType rtfTableType_0;
    private RtfTokenType rtfTokenType_0;
    private string string_0;
    private string string_1;

    public Class564(Class1084 A_0)
    {
        this.class1084_0 = A_0;
    }

    public bool method_0()
    {
        return this.bool_0;
    }

    public void method_1(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public string method_10()
    {
        char ch;
        char ch2;
        int num = 5;
        if (!string.IsNullOrEmpty(this.string_1))
        {
            this.string_0 = this.string_1;
            this.string_1 = string.Empty;
            return this.string_0;
        }
        if (this.class1084_0.method_1())
        {
            return string.Empty;
        }
        this.string_0 = null;
        if (this.bool_2)
        {
            ch2 = this.class1084_0.method_2();
        }
        else
        {
            ch2 = this.char_8;
        }
        switch (ch2)
        {
            case '\n':
            case '\r':
                this.bool_2 = true;
                this.string_0 = ch2.ToString();
                return this.string_0;

            case '{':
                this.bool_2 = true;
                return ch2.ToString();

            case '}':
                this.bool_2 = true;
                return ch2.ToString();

            case '\\':
            {
                this.string_0 = BookmarkStart.b("眪", num);
                char c = this.class1084_0.method_3();
                if (((c != '\'') && (c != '~')) && ((c != '*') && char.IsPunctuation(c)))
                {
                    ch = this.class1084_0.method_2();
                    this.string_0 = this.string_0 + ch;
                    this.bool_2 = true;
                    goto Label_03AC;
                }
                ch = this.class1084_0.method_2();
                char ch3 = this.class1084_0.method_3();
                if ((ch != 'u') || !char.IsDigit(ch3))
                {
                    if ((this.method_3() != RtfTableType.None) || ((ch != '\'') && (ch != '~')))
                    {
                        while (!this.class1084_0.method_1())
                        {
                            if (((((ch == '}') || (ch == '{')) || ((ch == '\\') || (ch == '\r'))) || (((ch == '\n') || (ch == ';')) || ((ch == ':') || (ch == ' ')))) || this.method_11(ch, this.string_0))
                            {
                                break;
                            }
                            this.string_0 = this.string_0 + ch;
                            ch = this.class1084_0.method_2();
                        }
                        goto Label_03A5;
                    }
                    break;
                }
            Label_02AD:
                if (this.class1084_0.method_1())
                {
                    goto Label_03A5;
                }
                switch (ch)
                {
                    case '}':
                    case '\\':
                    case '{':
                    case '\r':
                    case '\n':
                    case ':':
                        goto Label_03A5;

                    default:
                        this.string_0 = this.string_0 + ch;
                        ch = this.class1084_0.method_2();
                        goto Label_02AD;
                }
                break;
            }
            case ' ':
                if ((this.method_0() && !this.bool_1) && (this.class1084_0.method_3() != '\\'))
                {
                    this.string_0 = this.class1084_0.method_4();
                    this.bool_2 = true;
                    return this.string_0;
                }
                if ((this.char_8 == '{') && (this.class1084_0.method_3() == '}'))
                {
                    this.bool_2 = true;
                    return ch2.ToString();
                }
                ch = this.class1084_0.method_2();
                while (!this.class1084_0.method_1())
                {
                    if ((((ch == '\\') || (ch == ';')) || ((ch == '{') || (ch == '}'))) || ((ch == '\r') || (ch == '\n')))
                    {
                        break;
                    }
                    this.string_0 = this.string_0 + ch;
                    ch = this.class1084_0.method_2();
                }
                this.char_8 = ch;
                this.bool_2 = false;
                if (this.string_0 == null)
                {
                    if (this.char_8 != '\\')
                    {
                        this.bool_2 = true;
                    }
                    if ((ch == '{') && (this.method_5() == RtfTokenType.GroupEnd))
                    {
                        this.string_1 = ch.ToString();
                        return ch2.ToString();
                    }
                    return ch.ToString();
                }
                if ((this.method_5() != RtfTokenType.Text) && (this.method_5() != RtfTokenType.GroupEnd))
                {
                    return this.string_0;
                }
                return (BookmarkStart.b("ପ", num) + this.string_0);

            default:
            {
                if (this.method_0() && !this.bool_1)
                {
                    this.string_0 = ch2 + this.class1084_0.method_4();
                    this.bool_2 = true;
                    return this.string_0;
                }
                StringBuilder builder = new StringBuilder();
                if (this.string_0 != null)
                {
                    builder.Append(this.string_0);
                }
                while (!this.class1084_0.method_1())
                {
                    if ((((ch2 == '\\') || (ch2 == ';')) || ((ch2 == '{') || (ch2 == '}'))) || ((ch2 == '\r') || (ch2 == '\n')))
                    {
                        break;
                    }
                    builder.Append(ch2);
                    ch2 = this.class1084_0.method_2();
                }
                this.bool_2 = true;
                if (builder.Length == 0)
                {
                    return ch2.ToString();
                }
                if ((((ch2 == '\\') || (ch2 == ';')) || ((ch2 == '{') || (ch2 == '}'))) || ((ch2 == '\r') || (ch2 == '\n')))
                {
                    this.char_8 = ch2;
                    this.bool_2 = false;
                }
                return builder.ToString();
            }
        }
    Label_032F:
        if (!this.class1084_0.method_1())
        {
            switch (ch)
            {
                case '}':
                case '\\':
                case '{':
                case '\r':
                case '\n':
                case ':':
                    break;

                default:
                    this.string_0 = this.string_0 + ch;
                    ch = this.class1084_0.method_2();
                    goto Label_032F;
            }
        }
    Label_03A5:
        this.bool_2 = false;
    Label_03AC:
        this.char_8 = ch;
        if (this.string_0 == null)
        {
            return ch.ToString();
        }
        return this.string_0;
    }

    private bool method_11(char A_0, string A_1)
    {
        if (!string.IsNullOrEmpty(A_1) && (A_1.Length >= 2))
        {
            char ch = A_1[1];
            if (((!ch.Equals('\'') && !A_0.Equals('*')) && (!A_0.Equals('-') && A_0.Equals('~'))) && (char.IsPunctuation(A_0) || char.IsSymbol(A_0)))
            {
                return true;
            }
        }
        return false;
    }

    internal void method_2(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public RtfTableType method_3()
    {
        return this.rtfTableType_0;
    }

    public void method_4(RtfTableType A_0)
    {
        this.rtfTableType_0 = A_0;
    }

    public RtfTokenType method_5()
    {
        return this.rtfTokenType_0;
    }

    public void method_6(RtfTokenType A_0)
    {
        this.rtfTokenType_0 = A_0;
    }

    public Class1084 method_7()
    {
        return this.class1084_0;
    }

    public string method_8()
    {
        if (string.IsNullOrEmpty(this.string_1))
        {
            this.string_1 = this.method_10();
        }
        return this.string_1;
    }

    public string method_9()
    {
        if (this.class1084_0.method_1())
        {
            return string.Empty;
        }
        return this.class1084_0.method_3().ToString();
    }

    void IDisposable.Dispose()
    {
        if (this.class1084_0 != null)
        {
            this.class1084_0.System.IDisposable.Dispose();
            this.class1084_0 = null;
        }
    }
}

