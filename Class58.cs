using Spire.Doc;
using System;
using System.Drawing;

internal static class Class58
{
    private static FontFamily fontFamily_0;

    static Class58()
    {
        try
        {
            fontFamily_0 = new Font(string.Empty, 1f).FontFamily;
        }
        catch (Exception)
        {
        }
    }

    public static Font smethod_0(string A_0, float A_1)
    {
        return smethod_1(A_0, A_1, FontStyle.Regular);
    }

    public static Font smethod_1(string A_0, float A_1, FontStyle A_2)
    {
        try
        {
            return new Font(A_0, A_1, A_2);
        }
        catch (Exception)
        {
            if (A_1 <= 0f)
            {
                return new Font(A_0, 9f, A_2);
            }
            FontFamily family = null;
            try
            {
                family = new FontFamily(A_0);
            }
            catch (Exception)
            {
            }
            Font font = smethod_2(family, A_1, A_2);
            if (font == null)
            {
                font = smethod_2(fontFamily_0, A_1, A_2);
            }
            return font;
        }
    }

    public static Font smethod_2(FontFamily A_0, float A_1, FontStyle A_2)
    {
        if ((A_0 == null) || (A_1 <= 0f))
        {
            return null;
        }
        bool flag = true;
        FontStyle style6 = FontStyle.Italic | FontStyle.Bold;
        FontStyle bold = FontStyle.Bold;
        FontStyle italic = FontStyle.Italic;
        FontStyle regular = FontStyle.Regular;
        FontStyle style3 = FontStyle.Regular;
        FontStyle style = FontStyle.Regular;
        if (((A_2 & (FontStyle.Italic | FontStyle.Bold)) == (FontStyle.Italic | FontStyle.Bold)) && A_0.IsStyleAvailable(style6))
        {
            style3 |= style6;
        }
        else if (((A_2 & bold) == bold) && A_0.IsStyleAvailable(bold))
        {
            style3 |= bold;
        }
        else if (((A_2 & italic) == italic) && A_0.IsStyleAvailable(italic))
        {
            style3 |= italic;
        }
        else if (((regular & A_2) == regular) && A_0.IsStyleAvailable(regular))
        {
            style3 |= regular;
        }
        else
        {
            flag = false;
        }
        if (!flag)
        {
            if (A_0.IsStyleAvailable(regular))
            {
                if ((regular & A_2) == regular)
                {
                    style3 |= regular;
                }
                if (style == FontStyle.Regular)
                {
                    style = regular;
                }
            }
            else if (A_0.IsStyleAvailable(bold))
            {
                if ((bold & A_2) == bold)
                {
                    style3 |= bold;
                }
                if (style == FontStyle.Regular)
                {
                    style = bold;
                }
            }
            else if (A_0.IsStyleAvailable(italic))
            {
                if ((italic & A_2) == italic)
                {
                    style3 |= italic;
                }
                if (style == FontStyle.Regular)
                {
                    style = italic;
                }
            }
            else if (A_0.IsStyleAvailable(style6))
            {
                if ((style6 & A_2) == style6)
                {
                    style3 |= style6;
                }
                if (style == FontStyle.Regular)
                {
                    style = style6;
                }
            }
        }
        if (style3 == FontStyle.Regular)
        {
            if (A_0.IsStyleAvailable(FontStyle.Regular))
            {
                style3 = smethod_3(A_2, style3);
                return new Font(A_0, A_1, style3);
            }
            if (style != FontStyle.Regular)
            {
                return new Font(A_0, A_1, smethod_3(A_2, style));
            }
            return null;
        }
        try
        {
            return new Font(A_0, A_1, smethod_3(A_2, style3));
        }
        catch (Exception)
        {
            return null;
        }
    }

    private static FontStyle smethod_3(FontStyle A_0, FontStyle A_1)
    {
        if ((A_0 & FontStyle.Underline) == FontStyle.Underline)
        {
            A_1 |= FontStyle.Underline;
        }
        if ((A_0 & FontStyle.Strikeout) == FontStyle.Strikeout)
        {
            A_1 |= FontStyle.Strikeout;
        }
        return A_1;
    }

    internal static byte smethod_4(string A_0)
    {
        return smethod_5(new Font(A_0, 1f));
    }

    internal static byte smethod_5(Font A_0)
    {
        if (A_0 == null)
        {
            return 0;
        }
        return (byte) smethod_6(A_0).lfCharSet;
    }

    internal static LOGFONT smethod_6(Font A_0)
    {
        if (A_0 == null)
        {
            return new LOGFONT();
        }
        LOGFONT logFont = new LOGFONT();
        A_0.ToLogFont(logFont);
        return logFont;
    }
}

