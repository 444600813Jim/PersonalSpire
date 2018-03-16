using Spire.Doc;
using System;
using System.Drawing;
using System.Globalization;

internal class Class326
{
    private Color color_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private ThemeColorTypes themeColorTypes_0;

    public Color method_0()
    {
        return this.color_0;
    }

    public void method_1(Color A_0)
    {
        this.color_0 = A_0;
        this.method_11(A_0);
    }

    internal Class326 method_10()
    {
        return (Class326) base.MemberwiseClone();
    }

    private void method_11(Color A_0)
    {
        this.string_2 = A_0.R.ToString(BookmarkStart.b("縥ᨧ", 0)) + A_0.G.ToString(BookmarkStart.b("縥ᨧ", 0)) + A_0.B.ToString(BookmarkStart.b("縥ᨧ", 0));
    }

    private void method_12(string A_0)
    {
        if (!string.IsNullOrEmpty(A_0) && !string.IsNullOrEmpty(A_0.Trim()))
        {
            this.color_0 = this.method_13(A_0);
        }
    }

    private Color method_13(string A_0)
    {
        int num = 13;
        A_0 = A_0.Replace(BookmarkStart.b("ဲ", 13), string.Empty);
        if (A_0.Length > 6)
        {
            A_0 = A_0.Substring(0, 6);
        }
        else if ((A_0.Length < 6) && (A_0.Length != 3))
        {
            int num2 = 6 - A_0.Length;
            for (int i = 0; i < num2; i++)
            {
                A_0 = A_0.Insert(0, BookmarkStart.b("̲", num));
            }
        }
        else if (A_0.Length == 3)
        {
            A_0 = A_0.Insert(0, A_0[0].ToString());
            A_0 = A_0.Insert(2, A_0[2].ToString());
            A_0 = A_0.Insert(4, A_0[4].ToString());
        }
        try
        {
            string s = A_0.Substring(0, 2);
            string str2 = A_0.Substring(2, 2);
            string str3 = A_0.Substring(4, 2);
            int red = int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            int green = int.Parse(str2, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            int blue = int.Parse(str3, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return Color.FromArgb(red, green, blue);
        }
        catch
        {
        }
        return this.method_14(A_0);
    }

    private Color method_14(string A_0)
    {
        int index = A_0.IndexOf(BookmarkStart.b("漳", 14));
        if (index != -1)
        {
            A_0 = A_0.Remove(index, A_0.Length - index);
            A_0 = A_0.Trim();
        }
        try
        {
            return ColorTranslator.FromHtml(A_0);
        }
        catch
        {
        }
        return Color.Empty;
    }

    public string method_2()
    {
        return this.string_1;
    }

    internal void method_3(string A_0)
    {
        this.string_1 = A_0;
    }

    public string method_4()
    {
        return this.string_2;
    }

    internal void method_5(string A_0)
    {
        this.string_2 = A_0;
        this.method_12(this.string_2);
    }

    public string method_6()
    {
        return this.string_0;
    }

    public void method_7(string A_0)
    {
        this.string_0 = A_0;
    }

    public ThemeColorTypes method_8()
    {
        return this.themeColorTypes_0;
    }

    public void method_9(ThemeColorTypes A_0)
    {
        this.themeColorTypes_0 = A_0;
    }
}

