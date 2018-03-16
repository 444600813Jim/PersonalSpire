using Spire.Doc;
using Spire.Doc.Utilities.Text;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

internal class Class360
{
    public const char char_0 = ' ';
    public const char char_1 = '\t';
    public static readonly char[] char_2 = new char[] { ' ', '\t' };
    private int int_0;
    private static Regex regex_0 = new Regex(BookmarkStart.b("洲渴᜶攸伺怼ᐾ敀", 13), RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private const RegexOptions regexOptions_0 = (RegexOptions.Compiled | RegexOptions.IgnoreCase);
    private const string string_0 = @"^[ \t]+$";
    private string string_1;

    public Class360(string A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐯圱䰳䈵", num));
        }
        this.string_1 = A_0;
    }

    private int method_0()
    {
        return this.string_1.Length;
    }

    public int method_1()
    {
        return this.int_0;
    }

    public void method_2(int A_0)
    {
        this.int_0 = A_0;
    }

    public string method_3()
    {
        int num = this.int_0;
        bool flag = false;
        while (num < this.method_0())
        {
            Separator separator;
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
                    string str4 = this.string_1.Substring(this.int_0, num - this.int_0);
                    this.int_0 = num;
                    return str4;
                }
                case '\n':
                case '\r':
                {
                    int num2 = num + 1;
                    if (((ch == '\r') && (num2 < this.method_0())) && (this.string_1[num2] == '\n'))
                    {
                        num++;
                    }
                    string str2 = this.string_1.Substring(this.int_0, (num - this.int_0) + 1);
                    this.int_0 = num + 1;
                    return str2;
                }
                default:
                    separator = smethod_0(ch);
                    switch (separator)
                    {
                        case Separator.Separator:
                        {
                            num++;
                            string str5 = this.string_1.Substring(this.int_0, num - this.int_0);
                            this.int_0 = num;
                            return str5;
                        }
                        case Separator.LineBreakSeparator:
                            break;

                        case Separator.InitialQuotePunctuation:
                        {
                            if (num <= this.int_0)
                            {
                                break;
                            }
                            if (flag)
                            {
                                goto Label_007A;
                            }
                            string str = this.string_1.Substring(this.int_0, num - this.int_0);
                            this.int_0 = num;
                            return str;
                        }
                        case Separator.G7FFLetter:
                        {
                            if ((num <= this.int_0) || flag)
                            {
                                int num3 = num + 1;
                                if (num3 < this.method_0())
                                {
                                    char ch2 = this.string_1[num3];
                                    if (smethod_0(ch2) == Separator.Separator)
                                    {
                                        num++;
                                    }
                                }
                                num++;
                                string str3 = this.string_1.Substring(this.int_0, num - this.int_0);
                                this.int_0 = num;
                                return str3;
                            }
                            string str6 = this.string_1.Substring(this.int_0, num - this.int_0);
                            this.int_0 = num;
                            return str6;
                        }
                        default:
                            break;
                    }
                    flag = true;
                    break;
            }
        Label_007A:
            if (separator != Separator.InitialQuotePunctuation)
            {
                flag = false;
            }
            num++;
        }
        if (num > this.int_0)
        {
            string str7 = this.string_1.Substring(this.int_0, num - this.int_0);
            this.int_0 = num;
            return str7;
        }
        return null;
    }

    public string method_4()
    {
        int num = this.int_0;
        string str = this.method_3();
        this.int_0 = num;
        return str;
    }

    internal static Separator smethod_0(char A_0)
    {
        if (char.IsLetterOrDigit(A_0))
        {
            if (A_0 < 'ࠀ')
            {
                return Separator.None;
            }
            return Separator.G7FFLetter;
        }
        UnicodeCategory unicodeCategory = char.GetUnicodeCategory(A_0);
        if ((unicodeCategory != UnicodeCategory.InitialQuotePunctuation) && (unicodeCategory != UnicodeCategory.OpenPunctuation))
        {
            return Separator.Separator;
        }
        return Separator.InitialQuotePunctuation;
    }

    internal static bool smethod_1(char A_0)
    {
        return (smethod_0(A_0) != Separator.None);
    }
}

