using Spire.Doc;
using System;
using System.Text;

internal class Class955
{
    private Class955()
    {
    }

    internal static bool smethod_0(string A_0)
    {
        int num = 0x13;
        return (A_0.StartsWith(BookmarkStart.b("ᬸ", 0x13)) && A_0.EndsWith(BookmarkStart.b("ᬸ", num)));
    }

    internal static string smethod_1(string A_0)
    {
        return smethod_2(A_0, true);
    }

    private static string smethod_10(string A_0)
    {
        if (!Class567.smethod_16(A_0))
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder();
        foreach (char ch in A_0)
        {
            if ((ch > ' ') && (ch < '\x007f'))
            {
                builder.Append((char) (0xff00 | (ch - ' ')));
            }
            else if (ch == ' ')
            {
                builder.Append('　');
            }
            else
            {
                builder.Append(ch);
            }
        }
        return builder.ToString();
    }

    internal static double smethod_11(TextureStyle A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case TextureStyle.TextureNone:
            case TextureStyle.TextureNil:
                return 0.0;

            case TextureStyle.TextureSolid:
                return 1.0;

            case TextureStyle.Texture5Percent:
                return 0.05;

            case TextureStyle.Texture10Percent:
                return 0.10000000149011612;

            case TextureStyle.Texture20Percent:
                return 0.2;

            case TextureStyle.Texture25Percent:
            case TextureStyle.TextureHorizontal:
            case TextureStyle.TextureVertical:
            case TextureStyle.TextureDiagonalDown:
            case TextureStyle.TextureDiagonalUp:
                return 0.25;

            case TextureStyle.Texture30Percent:
            case TextureStyle.TextureDiagonalCross:
                return 0.3;

            case TextureStyle.Texture40Percent:
                return 0.4;

            case TextureStyle.Texture50Percent:
            case TextureStyle.TextureDarkHorizontal:
            case TextureStyle.TextureDarkVertical:
            case TextureStyle.TextureDarkDiagonalDown:
            case TextureStyle.TextureDarkDiagonalUp:
            case TextureStyle.TextureDarkCross:
                return 0.5;

            case TextureStyle.Texture60Percent:
                return 0.6;

            case TextureStyle.Texture70Percent:
            case TextureStyle.TextureDarkDiagonalCross:
                return 0.7;

            case TextureStyle.Texture75Percent:
                return 0.75;

            case TextureStyle.Texture80Percent:
                return 0.8;

            case TextureStyle.Texture90Percent:
                return 0.9;

            case TextureStyle.TextureCross:
            case TextureStyle.Texture35Percent:
                return 0.35;

            case TextureStyle.Texture2Pt5Percent:
                return 0.025;

            case TextureStyle.Texture7Pt5Percent:
                return 0.075;

            case TextureStyle.Texture12Pt5Percent:
                return 0.125;

            case TextureStyle.Texture15Percent:
                return 0.15;

            case TextureStyle.Texture17Pt5Percent:
                return 0.175;

            case TextureStyle.Texture22Pt5Percent:
                return 0.225;

            case TextureStyle.Texture27Pt5Percent:
                return 0.275;

            case TextureStyle.Texture32Pt5Percent:
                return 0.325;

            case TextureStyle.Texture37Pt5Percent:
                return 0.375;

            case TextureStyle.Texture42Pt5Percent:
                return 0.425;

            case TextureStyle.Texture45Percent:
                return 0.45;

            case TextureStyle.Texture47Pt5Percent:
                return 0.475;

            case TextureStyle.Texture52Pt5Percent:
                return 0.525;

            case TextureStyle.Texture55Percent:
                return 0.55;

            case TextureStyle.Texture57Pt5Percent:
                return 0.575;

            case TextureStyle.Texture62Pt5Percent:
                return 0.625;

            case TextureStyle.Texture65Percent:
                return 0.65;

            case TextureStyle.Texture67Pt5Percent:
                return 0.675;

            case TextureStyle.Texture72Pt5Percent:
                return 0.725;

            case TextureStyle.Texture77Pt5Percent:
                return 0.775;

            case TextureStyle.Texture82Pt5Percent:
                return 0.825;

            case TextureStyle.Texture85Percent:
                return 0.85;

            case TextureStyle.Texture87Pt5Percent:
                return 0.875;

            case TextureStyle.Texture92Pt5Percent:
                return 0.925;

            case TextureStyle.Texture95Percent:
                return 0.95;

            case TextureStyle.Texture97Pt5Percent:
                return 0.975;
        }
        throw new InvalidOperationException(BookmarkStart.b("永唺嘼儾⹀㑂⭄杆㵈⹊㕌㭎⑐⅒ご祖", num));
    }

    internal static TextureStyle smethod_12(TextureStyle A_0)
    {
        switch (A_0)
        {
            case TextureStyle.TextureNone:
            case TextureStyle.TextureSolid:
            case TextureStyle.Texture5Percent:
            case TextureStyle.Texture10Percent:
            case TextureStyle.Texture20Percent:
            case TextureStyle.Texture25Percent:
            case TextureStyle.Texture30Percent:
            case TextureStyle.Texture40Percent:
            case TextureStyle.Texture50Percent:
            case TextureStyle.Texture60Percent:
            case TextureStyle.Texture70Percent:
            case TextureStyle.Texture75Percent:
            case TextureStyle.Texture80Percent:
            case TextureStyle.Texture90Percent:
            case TextureStyle.TextureDarkHorizontal:
            case TextureStyle.TextureDarkVertical:
            case TextureStyle.TextureDarkDiagonalDown:
            case TextureStyle.TextureDarkDiagonalUp:
            case TextureStyle.TextureDarkCross:
            case TextureStyle.TextureDarkDiagonalCross:
            case TextureStyle.TextureHorizontal:
            case TextureStyle.TextureVertical:
            case TextureStyle.TextureDiagonalDown:
            case TextureStyle.TextureDiagonalUp:
            case TextureStyle.TextureCross:
            case TextureStyle.TextureDiagonalCross:
            case TextureStyle.Texture2Pt5Percent:
            case TextureStyle.Texture7Pt5Percent:
            case TextureStyle.Texture12Pt5Percent:
            case TextureStyle.Texture15Percent:
            case TextureStyle.Texture17Pt5Percent:
            case TextureStyle.Texture22Pt5Percent:
            case TextureStyle.Texture27Pt5Percent:
            case TextureStyle.Texture32Pt5Percent:
            case TextureStyle.Texture35Percent:
            case TextureStyle.Texture37Pt5Percent:
            case TextureStyle.Texture42Pt5Percent:
            case TextureStyle.Texture45Percent:
            case TextureStyle.Texture47Pt5Percent:
            case TextureStyle.Texture52Pt5Percent:
            case TextureStyle.Texture55Percent:
            case TextureStyle.Texture57Pt5Percent:
            case TextureStyle.Texture62Pt5Percent:
            case TextureStyle.Texture65Percent:
            case TextureStyle.Texture67Pt5Percent:
            case TextureStyle.Texture72Pt5Percent:
            case TextureStyle.Texture77Pt5Percent:
            case TextureStyle.Texture82Pt5Percent:
            case TextureStyle.Texture85Percent:
            case TextureStyle.Texture87Pt5Percent:
            case TextureStyle.Texture92Pt5Percent:
            case TextureStyle.Texture95Percent:
            case TextureStyle.Texture97Pt5Percent:
                return A_0;

            case TextureStyle.TextureNil:
                return A_0;
        }
        return TextureStyle.TextureNone;
    }

    internal static bool smethod_13(TextureStyle A_0)
    {
        switch (A_0)
        {
            case TextureStyle.TextureDarkHorizontal:
            case TextureStyle.TextureDarkVertical:
            case TextureStyle.TextureDarkDiagonalDown:
            case TextureStyle.TextureDarkDiagonalUp:
            case TextureStyle.TextureDarkCross:
            case TextureStyle.TextureDarkDiagonalCross:
            case TextureStyle.TextureHorizontal:
            case TextureStyle.TextureVertical:
            case TextureStyle.TextureDiagonalDown:
            case TextureStyle.TextureDiagonalUp:
            case TextureStyle.TextureCross:
            case TextureStyle.TextureDiagonalCross:
                return true;
        }
        return false;
    }

    internal static TextureStyle smethod_14(double A_0)
    {
        switch (((int) (40.0 * A_0)))
        {
            case 0:
                return TextureStyle.TextureNone;

            case 1:
                return TextureStyle.Texture2Pt5Percent;

            case 2:
                return TextureStyle.Texture5Percent;

            case 3:
                return TextureStyle.Texture7Pt5Percent;

            case 4:
                return TextureStyle.Texture10Percent;

            case 5:
                return TextureStyle.Texture12Pt5Percent;

            case 6:
                return TextureStyle.Texture15Percent;

            case 7:
                return TextureStyle.Texture17Pt5Percent;

            case 8:
                return TextureStyle.Texture20Percent;

            case 9:
                return TextureStyle.Texture22Pt5Percent;

            case 10:
                return TextureStyle.Texture25Percent;

            case 11:
                return TextureStyle.Texture27Pt5Percent;

            case 12:
                return TextureStyle.Texture30Percent;

            case 13:
                return TextureStyle.Texture32Pt5Percent;

            case 14:
                return TextureStyle.Texture35Percent;

            case 15:
                return TextureStyle.Texture37Pt5Percent;

            case 0x10:
                return TextureStyle.Texture40Percent;

            case 0x11:
                return TextureStyle.Texture42Pt5Percent;

            case 0x12:
                return TextureStyle.Texture45Percent;

            case 0x13:
                return TextureStyle.Texture47Pt5Percent;

            case 20:
                return TextureStyle.Texture50Percent;

            case 0x15:
                return TextureStyle.Texture52Pt5Percent;

            case 0x16:
                return TextureStyle.Texture55Percent;

            case 0x17:
                return TextureStyle.Texture57Pt5Percent;

            case 0x18:
                return TextureStyle.Texture60Percent;

            case 0x19:
                return TextureStyle.Texture62Pt5Percent;

            case 0x1a:
                return TextureStyle.Texture65Percent;

            case 0x1b:
                return TextureStyle.Texture67Pt5Percent;

            case 0x1c:
                return TextureStyle.Texture70Percent;

            case 0x1d:
                return TextureStyle.Texture72Pt5Percent;

            case 30:
                return TextureStyle.Texture75Percent;

            case 0x1f:
                return TextureStyle.Texture77Pt5Percent;

            case 0x20:
                return TextureStyle.Texture80Percent;

            case 0x21:
                return TextureStyle.Texture82Pt5Percent;

            case 0x22:
                return TextureStyle.Texture85Percent;

            case 0x23:
                return TextureStyle.Texture87Pt5Percent;

            case 0x24:
                return TextureStyle.Texture90Percent;

            case 0x25:
                return TextureStyle.Texture92Pt5Percent;

            case 0x26:
                return TextureStyle.Texture95Percent;

            case 0x27:
                return TextureStyle.Texture97Pt5Percent;
        }
        return TextureStyle.TextureSolid;
    }

    internal static string smethod_2(string A_0, bool A_1)
    {
        int num = 0x13;
        if (A_1)
        {
            return A_0.Trim(new char[] { '"' });
        }
        if (A_0.StartsWith(BookmarkStart.b("ᬸ", num)))
        {
            A_0 = A_0.Substring(1);
        }
        if (A_0.EndsWith(BookmarkStart.b("ᬸ", num)))
        {
            A_0 = A_0.Substring(0, A_0.Length - 1);
        }
        return A_0;
    }

    internal static string smethod_3(string A_0)
    {
        return string.Format(BookmarkStart.b("భ䬯ȱ䤳ᐵ", 8), A_0);
    }

    internal static string smethod_4(string A_0)
    {
        A_0 = smethod_1(A_0);
        A_0 = A_0.Replace(BookmarkStart.b("用眪", 3), BookmarkStart.b("用", 3));
        return A_0;
    }

    internal static string smethod_5(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("琧", 2), BookmarkStart.b("琧瘩", 2));
        A_0 = smethod_3(A_0);
        return A_0;
    }

    internal static string smethod_6(string A_0)
    {
        StringBuilder builder = new StringBuilder(A_0);
        builder.Replace(Class816.string_4, Class816.string_2);
        builder.Replace(Class816.string_3, Class816.string_2);
        return builder.ToString();
    }

    internal static string smethod_7(string A_0)
    {
        StringBuilder builder = new StringBuilder(A_0);
        builder.Replace(Class816.string_4, Class816.string_3);
        builder.Replace(Class816.string_2, Class816.string_3);
        return builder.ToString();
    }

    internal static string smethod_8(string A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶", num));
        }
        StringBuilder builder = new StringBuilder(A_0);
        for (int i = 0; i < builder.Length; i++)
        {
            if (!char.IsWhiteSpace(builder[i]))
            {
                builder[i] = char.ToUpper(builder[i]);
                break;
            }
        }
        return builder.ToString();
    }

    internal static string smethod_9(string A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弫", num));
        }
        bool flag = false;
        StringBuilder builder = new StringBuilder(A_0);
        for (int i = 0; i < builder.Length; i++)
        {
            if (char.IsWhiteSpace(builder[i]))
            {
                flag = false;
            }
            else if (!flag)
            {
                builder[i] = char.ToUpper(builder[i]);
                flag = true;
            }
            else
            {
                builder[i] = char.ToLower(builder[i]);
            }
        }
        return builder.ToString();
    }
}

