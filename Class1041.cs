using Spire.Doc;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

internal class Class1041
{
    private const int int_0 = 0x76c;
    private const string string_0 = "ddd, d MMM yyyy HH':'mm':'ss zzzz";
    private const string string_1 = "fr-CH";
    private const string string_2 = "SFr.";
    private const string string_3 = "fr.";

    private Class1041()
    {
    }

    public static string smethod_0(DateTime A_0)
    {
        return A_0.ToString(BookmarkStart.b("䴳伵䄷䌹ᄻ猽ി潁⁃≅᱇ɉы瑍㵏㽑湓╕⭗Y", 14), CultureInfo.InvariantCulture);
    }

    public static string smethod_1(DateTime A_0)
    {
        return A_0.ToString(BookmarkStart.b("䄷䌹䔻䜽洿ཁृ歅ⱇ⹉ᡋٍᡏ桑㥓㭕扗⥙⽛", 0x12), CultureInfo.InvariantCulture);
    }

    public static string smethod_10(uint A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    public static int smethod_11(string A_0)
    {
        return Class567.smethod_24((double) smethod_13(A_0));
    }

    public static double smethod_12(string A_0)
    {
        double d = smethod_15(A_0);
        if (!double.IsNaN(d))
        {
            return d;
        }
        return 0.0;
    }

    public static float smethod_13(string A_0)
    {
        float f = Convert.ToSingle(smethod_15(A_0));
        if (!float.IsNaN(f))
        {
            return f;
        }
        return 0f;
    }

    public static float smethod_14(string A_0)
    {
        return smethod_13(A_0);
    }

    public static double smethod_15(string A_0)
    {
        double num;
        if (!double.TryParse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
        {
            return double.NaN;
        }
        return num;
    }

    public static double smethod_16(string A_0)
    {
        double num;
        if (!double.TryParse(A_0, NumberStyles.Float, CultureInfo.CurrentCulture, out num))
        {
            return double.NaN;
        }
        return num;
    }

    public static bool smethod_17(string A_0)
    {
        double num;
        return double.TryParse(A_0, NumberStyles.None, CultureInfo.InvariantCulture, out num);
    }

    public static int smethod_18(string A_0)
    {
        double num;
        if (!double.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture, out num))
        {
            return -2147483648;
        }
        return Class567.smethod_24(num);
    }

    public static int smethod_19(string A_0)
    {
        int num = -2147483648;
        while (A_0.Length > 0)
        {
            num = smethod_18(A_0);
            if (num != -2147483648)
            {
                return num;
            }
            A_0 = A_0.Substring(0, A_0.Length - 1);
        }
        return num;
    }

    public static string smethod_2(DateTime A_0)
    {
        return A_0.ToString(BookmarkStart.b("带倨刪听戮簰圲儴缶焸嘺值䰾㉀᥂", 1), CultureInfo.InvariantCulture);
    }

    public static double smethod_20(string A_0)
    {
        double num;
        if (!double.TryParse(A_0, NumberStyles.Currency, CultureInfo.CurrentCulture, out num))
        {
            return double.NaN;
        }
        return num;
    }

    public static DateTime smethod_21(string A_0)
    {
        return smethod_22(A_0, smethod_60());
    }

    private static DateTime smethod_22(string A_0, IFormatProvider A_1)
    {
        DateTime time;
        if (!DateTime.TryParse(A_0, A_1, DateTimeStyles.AdjustToUniversal, out time))
        {
            return DateTime.MinValue;
        }
        return time;
    }

    public static int smethod_23(string A_0)
    {
        return int.Parse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture);
    }

    public static bool smethod_24(string A_0, out int A_1)
    {
        return int.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture, out A_1);
    }

    public static long smethod_25(string A_0)
    {
        return long.Parse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture);
    }

    public static int smethod_26(string A_0)
    {
        return int.Parse(A_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
    }

    public static int smethod_27(string A_0)
    {
        int num;
        if (!int.TryParse(A_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num))
        {
            return -2147483648;
        }
        return num;
    }

    public static bool smethod_28(string A_0)
    {
        return bool.Parse(A_0);
    }

    public static string smethod_29(bool A_0)
    {
        int num = 12;
        if (!A_0)
        {
            return BookmarkStart.b("吱唳娵䬷弹", num);
        }
        return BookmarkStart.b("䘱䘳䌵崷", num);
    }

    public static DateTime smethod_3(string A_0)
    {
        return smethod_22(A_0, CultureInfo.InvariantCulture);
    }

    public static string smethod_30(int A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    public static string smethod_31(long A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    public static string smethod_32(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("眲ܴ", 13), CultureInfo.InvariantCulture);
    }

    public static string smethod_33(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("琯ı", 10), CultureInfo.InvariantCulture);
    }

    public static string smethod_34(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("欮԰", 9), CultureInfo.InvariantCulture);
    }

    public static string smethod_35(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("挦ᠨᬪ", 1), CultureInfo.InvariantCulture);
    }

    public static string smethod_36(int A_0)
    {
        if (A_0 != 0)
        {
            return smethod_30(A_0);
        }
        return "";
    }

    public static string smethod_37(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("洴", 15), CultureInfo.InvariantCulture);
    }

    public static string smethod_38(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("䬲", 13), CultureInfo.InvariantCulture);
    }

    public static string smethod_39(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("栯1", 10), CultureInfo.InvariantCulture);
    }

    public static string smethod_4(DateTime A_0)
    {
        string str = A_0.ToString(BookmarkStart.b("儴匶崸᜺ᴼ嬾慀โࡄ੆楈㉊㑌㙎⡐獒ᵔὖ繘慚穜㉞ౠ䑢彤䁦ᩨᡪ䵬ᕮ୰ॲུ", 15), DateTimeFormatInfo.InvariantInfo);
        return str.Remove(str.LastIndexOf(':'), 1);
    }

    public static string smethod_40(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("利ḫ", 4), CultureInfo.InvariantCulture);
    }

    public static string smethod_41(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("怷ู", 0x12), CultureInfo.InvariantCulture);
    }

    public static string smethod_42(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("洴Ķ", 15), CultureInfo.InvariantCulture);
    }

    public static string smethod_43(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("甬ᜮ", 7), CultureInfo.InvariantCulture);
    }

    public static string smethod_44(double A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    public static string smethod_45(double A_0)
    {
        return A_0.ToString(BookmarkStart.b("ࠪฬమሰဲᘴᐶᨸᠺḼ᰾⑀獂", 5), CultureInfo.InvariantCulture);
    }

    public static string smethod_46(double A_0)
    {
        return A_0.ToString(BookmarkStart.b("ᜦܨࠪฬ", 1), CultureInfo.InvariantCulture);
    }

    public static string smethod_47(double A_0)
    {
        return A_0.ToString(BookmarkStart.b("ܶ᜸ᠺḼ᰾所恂晄摆橈桊", 0x11), CultureInfo.InvariantCulture);
    }

    public static string smethod_48(float A_0)
    {
        return A_0.ToString(BookmarkStart.b("ᘥاऩ༫", 0), CultureInfo.InvariantCulture);
    }

    public static string smethod_49(float A_0)
    {
        double num = A_0;
        return num.ToString(BookmarkStart.b("ᬪ̬మሰဲᘴᐶᨸᠺḼ", 5), CultureInfo.InvariantCulture);
    }

    public static DateTime smethod_5(string A_0)
    {
        return DateTime.ParseExact(A_0, BookmarkStart.b("倳刵尷ᘹ᰻娽怿ཁृ୅桇㍉㕋㝍⥏牑᱓ṕ罗恙筛㍝ൟ䕡幣䅥᭧ᥩ䱫ᑭ੯ࡱ๳", 14), DateTimeFormatInfo.InvariantInfo);
    }

    public static string smethod_50(float A_0)
    {
        double num = A_0;
        return num.ToString(BookmarkStart.b("/ᰱᜳᔵᬷ᤹Ἳᴽ挿慁权", 10), CultureInfo.InvariantCulture);
    }

    public static string smethod_51(double A_0, bool A_1, bool A_2)
    {
        string str;
        int num = 13;
        if (A_1)
        {
            str = BookmarkStart.b("倲", num);
        }
        else if (A_2)
        {
            str = BookmarkStart.b("ဲᤴᐶᨸ଺ጼ᰾所恂晄摆橈桊", num);
        }
        else
        {
            str = BookmarkStart.b("᬴̲ᐶᨸᠺḼ᰾所恂", num);
        }
        return A_0.ToString(str, CultureInfo.CurrentCulture);
    }

    public static string smethod_52(double A_0, string A_1, bool A_2)
    {
        int num = 4;
        string str = smethod_53(A_1);
        if (((str.IndexOf(BookmarkStart.b("༩", 4)) >= 0) && (str.IndexOf(BookmarkStart.b("ഩफभ", num)) < 0)) && !A_2)
        {
            str = str.Replace(BookmarkStart.b("༩", num), BookmarkStart.b("ഩफभ", num));
        }
        if (Class567.smethod_16(str) && ((str[0] == ',') || (str[0] == '.')))
        {
            str = BookmarkStart.b("ऩ", num) + str;
        }
        return A_0.ToString(str, CultureInfo.CurrentCulture);
    }

    private static string smethod_53(string A_0)
    {
        NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
        StringBuilder builder = new StringBuilder();
        int num = 0;
        while (num < A_0.Length)
        {
            if (smethod_54(A_0, num, currentInfo.NumberDecimalSeparator))
            {
                builder.Append('.');
                num += currentInfo.NumberDecimalSeparator.Length;
            }
            else
            {
                if (smethod_54(A_0, num, currentInfo.NumberGroupSeparator))
                {
                    builder.Append(',');
                    num += currentInfo.NumberGroupSeparator.Length;
                    continue;
                }
                if (smethod_54(A_0, num, currentInfo.PercentSymbol))
                {
                    builder.Append('%');
                    num += currentInfo.PercentSymbol.Length;
                    continue;
                }
                if (smethod_54(A_0, num, currentInfo.PerMilleSymbol))
                {
                    builder.Append('‰');
                    num += currentInfo.PerMilleSymbol.Length;
                    continue;
                }
                builder.Append(A_0[num]);
                num++;
            }
        }
        return builder.ToString();
    }

    private static bool smethod_54(string A_0, int A_1, string A_2)
    {
        return Class737.smethod_0(A_0, A_1, A_2, 0, A_2.Length);
    }

    public static string smethod_55()
    {
        return smethod_60().ShortDatePattern;
    }

    public static string smethod_56()
    {
        return smethod_60().ShortTimePattern.Replace(BookmarkStart.b("䜲䄴", 13), BookmarkStart.b("刲場ᠶ䤸嘺", 13));
    }

    public static string smethod_57()
    {
        return smethod_60().ShortDatePattern;
    }

    public static string smethod_58()
    {
        return smethod_60().LongTimePattern;
    }

    public static string smethod_59()
    {
        return smethod_60().TimeSeparator;
    }

    public static int smethod_6(DateTime A_0)
    {
        if (A_0.Year < 0x76c)
        {
            return 0;
        }
        int num = 0;
        num = 0 | A_0.Minute;
        num |= A_0.Hour << 6;
        num |= A_0.Day << 11;
        num |= A_0.Month << 0x10;
        num |= (A_0.Year - 0x76c) << 20;
        return (num | (((int) A_0.DayOfWeek) << 0x1d));
    }

    private static DateTimeFormatInfo smethod_60()
    {
        return DateTimeFormatInfo.CurrentInfo;
    }

    public static char smethod_61()
    {
        string numberDecimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
        if (!Class567.smethod_16(numberDecimalSeparator))
        {
            return '.';
        }
        return numberDecimalSeparator[0];
    }

    public static char smethod_62()
    {
        string numberGroupSeparator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator;
        if (!Class567.smethod_16(numberGroupSeparator))
        {
            return ',';
        }
        return numberGroupSeparator[0];
    }

    public static string smethod_63()
    {
        return NumberFormatInfo.CurrentInfo.CurrencySymbol;
    }

    public static string smethod_64(string A_0)
    {
        int num = 10;
        string str = Class1040.smethod_13();
        if (BookmarkStart.b("嘯䀱ᤳ电瀷", 10).Equals(str) && (A_0.IndexOf(BookmarkStart.b("嘯䀱ᨳ", num)) >= 0))
        {
            A_0 = A_0.Replace(BookmarkStart.b("嘯䀱ᨳ", num), BookmarkStart.b("振琱䘳ᠵ", num));
        }
        return A_0;
    }

    public static DateTime smethod_7(int A_0)
    {
        if (A_0 == 0)
        {
            return DateTime.MinValue;
        }
        int minute = A_0 & 0x3f;
        int hour = (A_0 & 0x7c0) >> 6;
        int day = (A_0 & 0xf800) >> 11;
        int month = (A_0 & 0xf0000) >> 0x10;
        int year = ((A_0 & 0x1ff00000) >> 20) + 0x76c;
        try
        {
            return new DateTime(year, month, day, hour, minute, 0, 0);
        }
        catch (Exception)
        {
            return DateTime.MinValue;
        }
    }

    public static string smethod_8(int A_0)
    {
        return smethod_30(A_0);
    }

    public static string smethod_9(long A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }
}

