using Spire.Doc;
using System;
using System.Text;
using System.Text.RegularExpressions;

internal class Class543
{
    public const char char_0 = ' ';
    public const char char_1 = '\t';
    public const char char_2 = '-';
    public static readonly char[] char_3 = new char[] { ' ', '\t', '-' };
    private int int_0;
    private static Regex regex_0 = new Regex(BookmarkStart.b("港椱ᐳ樵䰷᜹愻ᔽ搿", 10), RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private const RegexOptions regexOptions_0 = (RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private const string string_0 = @"^[ \t-]+$";
    private string string_1;

    public Class543(string A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䴸帺䔼䬾", num));
        }
        this.string_1 = A_0;
    }

    public bool method_0()
    {
        return (this.int_0 == this.string_1.Length);
    }

    public int method_1()
    {
        return this.string_1.Length;
    }

    public string method_10(char A_0, bool A_1)
    {
        StringBuilder builder = new StringBuilder();
        while (!this.method_0())
        {
            char ch = this.method_11();
            if (ch == A_0)
            {
                if (A_1)
                {
                    this.method_8();
                    builder.Append(ch);
                }
                break;
            }
            builder.Append(ch);
            this.method_8();
        }
        return builder.ToString();
    }

    public char method_11()
    {
        char ch = '\0';
        if (!this.method_0())
        {
            ch = this.string_1[this.int_0];
        }
        return ch;
    }

    public void method_12()
    {
        this.string_1 = null;
    }

    public string method_13()
    {
        string str;
        if (this.int_0 == 0)
        {
            str = this.string_1;
        }
        else
        {
            str = this.string_1.Substring(this.int_0, this.method_1() - this.int_0);
        }
        this.int_0 = this.method_1();
        return str;
    }

    public int method_2()
    {
        return this.int_0;
    }

    public void method_3(int A_0)
    {
        this.int_0 = A_0;
    }

    public string method_4()
    {
        int num = 1;
        int num2 = this.int_0;
        while (num2 < this.method_1())
        {
            char ch = this.string_1[num2];
            switch (ch)
            {
                case '\n':
                case '\r':
                {
                    string str = this.string_1.Substring(this.int_0, num2 - this.int_0);
                    this.int_0 = num2 + 1;
                    if (((ch == '\r') && (this.int_0 < this.method_1())) && (this.string_1[this.int_0] == '\n'))
                    {
                        this.int_0++;
                    }
                    if (str == "")
                    {
                        str = BookmarkStart.b("ܦ", num);
                    }
                    return str;
                }
            }
            num2++;
        }
        if (num2 > this.int_0)
        {
            string str2 = this.string_1.Substring(this.int_0, num2 - this.int_0);
            this.int_0 = num2;
            return str2;
        }
        if ((((num2 <= 0) || (num2 != this.int_0)) || (num2 != this.method_1())) || ((this.string_1[num2 - 1] != '\n') && (this.string_1[num2 - 1] != '\r')))
        {
            return null;
        }
        return BookmarkStart.b("ܦ", num);
    }

    public string method_5()
    {
        int num = this.int_0;
        string str = this.method_4();
        this.int_0 = num;
        return str;
    }

    public string method_6()
    {
        int num = this.int_0;
        while (num < this.method_1())
        {
            char ch = this.string_1[num];
            switch (ch)
            {
                case '\t':
                case ' ':
                {
                    if (num == this.int_0)
                    {
                        num++;
                    }
                    string str = this.string_1.Substring(this.int_0, num - this.int_0);
                    this.int_0 = num;
                    return str;
                }
                case '\n':
                case '\r':
                {
                    string str2 = this.string_1.Substring(this.int_0, num - this.int_0);
                    this.int_0 = num + 1;
                    if (((ch == '\r') && (this.int_0 < this.method_1())) && (this.string_1[this.int_0] == '\n'))
                    {
                        this.int_0++;
                    }
                    return str2;
                }
            }
            num++;
        }
        if (num > this.int_0)
        {
            string str3 = this.string_1.Substring(this.int_0, num - this.int_0);
            this.int_0 = num;
            return str3;
        }
        return null;
    }

    public string method_7()
    {
        int num = this.int_0;
        string str = this.method_6();
        this.int_0 = num;
        return str;
    }

    public char method_8()
    {
        char ch = '\0';
        if (!this.method_0())
        {
            ch = this.string_1[this.int_0];
            this.int_0++;
        }
        return ch;
    }

    public string method_9(int A_0)
    {
        int num = 0;
        StringBuilder builder = new StringBuilder();
        while (!this.method_0())
        {
            if (num >= A_0)
            {
                break;
            }
            char ch = this.method_8();
            builder.Append(ch);
            num++;
        }
        return builder.ToString();
    }

    public static int smethod_0(string A_0, char A_1)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀶儸吺儼娾ᕀ♂㵄㍆", num));
        }
        int num3 = 0;
        int startIndex = 0;
    Label_0033:
        startIndex = A_0.IndexOf(A_1, startIndex);
        if (startIndex != -1)
        {
            num3++;
            startIndex++;
            if (startIndex == A_0.Length)
            {
                return num3;
            }
            goto Label_0033;
        }
        return num3;
    }

    public static int smethod_1(string A_0, char[] A_1)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("別䴧利堫", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唥儧䜩丫䄭尯䄱", num));
        }
        int num3 = 0;
        int num2 = 0;
        int length = A_0.Length;
        while (num2 < length)
        {
            char ch = A_0[num2];
            if (smethod_6(A_1, ch))
            {
                num3++;
            }
            num2++;
        }
        return num3;
    }

    internal static bool smethod_2(string A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        try
        {
            return regex_0.Match(A_0).Success;
        }
        catch
        {
            return false;
        }
    }

    internal static bool smethod_3(char A_0)
    {
        return (A_0 == ' ');
    }

    internal static bool smethod_4(char A_0)
    {
        return (A_0 == '\t');
    }

    internal static int smethod_5(string A_0, bool A_1)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔨䈪䌬䨮", num));
        }
        int num3 = 0;
        if (A_0.Length > 0)
        {
            for (int i = A_1 ? 0 : (A_0.Length - 1); i >= 0; i = A_1 ? (i + 1) : (i - 1))
            {
                if (i >= A_0.Length)
                {
                    return num3;
                }
                char ch = A_0[i];
                if (!smethod_3(ch) && !smethod_4(ch))
                {
                    return num3;
                }
                num3++;
            }
        }
        return num3;
    }

    private static bool smethod_6(char[] A_0, char A_1)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䴫尭䈯匱䴳", num));
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] == A_1)
            {
                return true;
            }
        }
        return false;
    }
}

