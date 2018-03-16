using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

internal class Class567
{
    private static readonly char[] char_0 = new char[] { ';' };
    private static readonly char[] char_1 = new char[] { ',' };
    private static readonly char[] char_2 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
    internal const int int_0 = 0;
    internal const int int_1 = 1;
    internal const int int_2 = 2;
    internal const int int_3 = 3;
    internal const int int_4 = 4;
    public static readonly string string_0 = BookmarkStart.b("ᨩ含", 4);

    private Class567()
    {
    }

    public static void smethod_0(int A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < 4; i++)
        {
            A_1[A_2 + i] = (byte) A_0;
            A_0 = A_0 >> 8;
        }
    }

    public static void smethod_1(uint A_0, Stream A_1)
    {
        for (int i = 0; i < 4; i++)
        {
            A_1.WriteByte((byte) A_0);
            A_0 = A_0 >> 8;
        }
    }

    public static byte[] smethod_10(Stream A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尮䌰倲昴䌶䬸帺尼刾", num));
        }
        byte[] buffer = new byte[(int) A_0.Length];
        using (MemoryStream stream = new MemoryStream(buffer))
        {
            A_0.Position = 0L;
            smethod_8(A_0, stream);
            return buffer;
        }
    }

    public static void smethod_11(string A_0, Stream A_1)
    {
        using (Stream stream = File.OpenRead(A_0))
        {
            smethod_8(stream, A_1);
        }
    }

    public static byte[] smethod_12(string A_0)
    {
        using (Stream stream = File.OpenRead(A_0))
        {
            return smethod_10(stream);
        }
    }

    public static Stream smethod_13()
    {
        return Class1040.smethod_0(BookmarkStart.b("甥堧䌩師䬭ḯ瘱嬳唵ᘷ根夻䴽⼿㝁㙃╅ⵇ㥉手㹍㥏ㅑ⁓⍕⩗㽙͛そཟᙡɣ॥ᵧѩ࡫䁭ᩯɱ፳", 0));
    }

    public static byte[] smethod_14()
    {
        using (Stream stream = smethod_13())
        {
            return smethod_10(stream);
        }
    }

    public static string smethod_15(object A_0, string A_1)
    {
        int num = 3;
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat(BookmarkStart.b("刨ᬪ倬༮戰䜲吴䔶䴸ㄺ", 3), A_1);
        foreach (FieldInfo info in A_0.GetType().GetFields())
        {
            builder.AppendFormat(BookmarkStart.b("刨ᬪ倬ᔮ䨰Ȳ䠴ᬶᤸ଺䔼䐾獀祂ᵄ㩆䍈", num), info.Name, info.GetValue(A_0), info.GetValue(A_0));
        }
        builder.AppendFormat(BookmarkStart.b("刨ᬪ倬༮琰崲儴", num), A_1);
        return builder.ToString();
    }

    public static bool smethod_16(string A_0)
    {
        return ((A_0 != null) && (A_0.Length > 0));
    }

    public static string smethod_17(string A_0, int A_1)
    {
        int num = 8;
        if ((A_1 <= 0) || !smethod_16(A_0))
        {
            return string.Empty;
        }
        if (A_1 >= A_0.Length)
        {
            return A_0;
        }
        if (A_1 > BookmarkStart.b("-ḯᰱ", num).Length)
        {
            return (A_0.Substring(0, A_1 - BookmarkStart.b("-ḯᰱ", num).Length) + BookmarkStart.b("-ḯᰱ", num));
        }
        return A_0.Substring(0, A_1);
    }

    public static string smethod_18(string A_0)
    {
        if (A_0 == null)
        {
            return "";
        }
        return A_0;
    }

    public static void smethod_19(string A_0, string A_1)
    {
        int num = 7;
        if (!smethod_16(A_0))
        {
            throw new ArgumentException(BookmarkStart.b("礬䜮吰ጲ吴䔶常为值娾⽀㝂敄⑆⡈╊⍌⁎═獒㝔㉖祘㕚⡜㍞ൠ䍢੤ᕦ䥨๪lὮհੲ啴Ѷ൸ॺᑼᅾ궂", num), A_1);
        }
    }

    public static void smethod_2(string A_0, Stream A_1)
    {
        foreach (char ch in A_0)
        {
            A_1.WriteByte((byte) ch);
        }
    }

    public static void smethod_20(object A_0, string A_1)
    {
        if (A_0 == null)
        {
            throw new ArgumentNullException(A_1);
        }
    }

    public static void smethod_21(int A_0, int A_1, int A_2, string A_3)
    {
        int num = 8;
        if ((A_0 < A_1) || (A_0 > A_2))
        {
            throw new ArgumentOutOfRangeException(A_3, string.Format(BookmarkStart.b("欭䠯䈱儳唵䰷弹堻ḽℿ扁㉃❅⑇㽉⥋湍㉏㝑⁓⅕㵗㽙㉛繝᭟剡ᥣ䙥१ѩ࡫乭୯䍱ॳ塵", num), A_1, A_2));
        }
    }

    public static void smethod_22(int A_0, string A_1)
    {
        int num = 11;
        if (A_0 <= 0)
        {
            throw new ArgumentOutOfRangeException(A_1, BookmarkStart.b("琰䬲䔴制娸伺堼嬾慀≂敄㝆♈㡊⑌㭎㡐╒ご睖⽘㩚ㅜ⩞Ѡ䵢", num));
        }
    }

    public static double smethod_23(double A_0, double A_1, double A_2, double A_3, double A_4, bool A_5, string A_6)
    {
        if (A_0 < A_1)
        {
            if (A_5)
            {
                throw new ArgumentOutOfRangeException(A_6);
            }
            return A_2;
        }
        if (A_0 > A_3)
        {
            if (A_5)
            {
                throw new ArgumentOutOfRangeException(A_6);
            }
            return A_4;
        }
        return A_0;
    }

    public static int smethod_24(double A_0)
    {
        long num = (long) A_0;
        return (int) num;
    }

    public static bool smethod_25(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (ch > '\x007f')
            {
                return false;
            }
        }
        return true;
    }

    public static bool smethod_26(string A_0, string A_1, bool A_2)
    {
        if (A_2)
        {
            A_0 = A_0.ToUpper();
            A_1 = A_1.ToUpper();
        }
        return (A_0.IndexOf(A_1) >= 0);
    }

    public static bool smethod_27(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (ch != ' ')
            {
                return false;
            }
        }
        return true;
    }

    public static bool smethod_28(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (!char.IsWhiteSpace(ch))
            {
                return false;
            }
        }
        return true;
    }

    public static bool smethod_29(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (char.IsWhiteSpace(ch))
            {
                return true;
            }
        }
        return false;
    }

    public static bool smethod_3(long A_0)
    {
        return ((A_0 & 1L) != 0L);
    }

    public static bool smethod_30(int A_0)
    {
        switch (A_0)
        {
            case 9:
            case 10:
            case 13:
            case 0x20:
                return true;
        }
        return false;
    }

    public static int smethod_31(char A_0)
    {
        int num = 0x11;
        int num2 = (A_0 > '9') ? (smethod_32(A_0) + 10) : (A_0 - '0');
        if ((num2 < 0) || (num2 > 15))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("匶倸尺吼䬾", num));
        }
        return num2;
    }

    public static int smethod_32(char A_0)
    {
        int num = 0x11;
        int num2 = A_0 - ((A_0 <= 'Z') ? 'A' : 'a');
        if ((num2 < 0) || (num2 > 0x19))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬶尸伺䤼娾㍀", num));
        }
        return num2;
    }

    public static bool smethod_33(int A_0)
    {
        return (((A_0 >= 0x61) && (A_0 <= 0x7a)) || ((A_0 >= 0x41) && (A_0 <= 90)));
    }

    public static bool smethod_34(int A_0)
    {
        if (!smethod_33(A_0))
        {
            return smethod_48(A_0);
        }
        return true;
    }

    public static bool smethod_35(char A_0)
    {
        return ((((A_0 >= '0') && (A_0 <= '9')) || ((A_0 >= 'A') && (A_0 <= 'F'))) || ((A_0 >= 'a') && (A_0 <= 'f')));
    }

    public static bool smethod_36(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (!smethod_48(ch))
            {
                return false;
            }
        }
        return true;
    }

    public static bool smethod_37(string A_0)
    {
        foreach (char ch in A_0)
        {
            if (!smethod_35(ch))
            {
                return false;
            }
        }
        return true;
    }

    public static string smethod_38(byte[] A_0, int A_1, int A_2, bool A_3)
    {
        StringBuilder builder = new StringBuilder(A_2 * 2);
        int num2 = A_3 ? -1 : 1;
        if (A_3)
        {
            A_1 += A_2 - 1;
        }
        for (int i = 0; i < A_2; i++)
        {
            builder.Append(smethod_39(A_0[A_1]));
            A_1 += num2;
        }
        return builder.ToString();
    }

    public static char[] smethod_39(byte A_0)
    {
        return new char[] { char_2[(A_0 >> 4) & 15], char_2[A_0 & 15] };
    }

    public static int smethod_4(long A_0, int A_1)
    {
        long num = A_0 / ((long) A_1);
        if ((A_0 % ((long) A_1)) != 0L)
        {
            num += 1L;
        }
        return (int) num;
    }

    public static string smethod_40(byte[] A_0)
    {
        return smethod_38(A_0, 0, A_0.Length, false);
    }

    public static bool smethod_41(string A_0, string A_1)
    {
        return Class737.smethod_1(A_0, A_1);
    }

    public static bool smethod_42(SizeF A_0, SizeF A_1, bool A_2, double A_3)
    {
        if (A_2)
        {
            if ((Math.Abs((float) (A_0.Width - A_1.Height)) <= A_3) && (Math.Abs((float) (A_0.Height - A_1.Width)) <= A_3))
            {
                return true;
            }
        }
        else if ((Math.Abs((float) (A_0.Width - A_1.Width)) <= A_3) && (Math.Abs((float) (A_0.Height - A_1.Height)) <= A_3))
        {
            return true;
        }
        return false;
    }

    public static bool[] smethod_43(byte A_0)
    {
        bool[] flagArray = new bool[8];
        for (int i = 0; i < flagArray.Length; i++)
        {
            flagArray[i] = (A_0 & (((int) 1) << i)) != 0;
        }
        return flagArray;
    }

    public static byte[] smethod_44(Guid A_0)
    {
        byte[] array = A_0.ToByteArray();
        Array.Reverse(array, 0, 4);
        Array.Reverse(array, 4, 2);
        Array.Reverse(array, 6, 2);
        return array;
    }

    public static char[] smethod_45()
    {
        switch (Class1041.smethod_61())
        {
            case ',':
                return char_0;
        }
        return char_1;
    }

    public static bool smethod_46(BinaryReader A_0, int A_1)
    {
        return (A_1 <= (A_0.BaseStream.Length - A_0.BaseStream.Position));
    }

    public static PointF smethod_47(PointF A_0, SizeF A_1)
    {
        return new PointF(A_0.X + A_1.Width, A_0.Y + A_1.Height);
    }

    public static bool smethod_48(int A_0)
    {
        return ((A_0 >= 0x30) && (A_0 <= 0x39));
    }

    public static StringCollection smethod_49(string A_0, bool A_1)
    {
        StringCollection strings = new StringCollection();
        if (A_1)
        {
            smethod_50(strings, A_0);
            return strings;
        }
        strings.AddRange(Directory.GetFiles(A_0));
        return strings;
    }

    public static int smethod_5(long A_0, int A_1)
    {
        return (smethod_4(A_0, A_1) * A_1);
    }

    private static void smethod_50(StringCollection A_0, string A_1)
    {
        A_0.AddRange(Directory.GetFiles(A_1));
        foreach (string str in Directory.GetDirectories(A_1))
        {
            smethod_50(A_0, str);
        }
    }

    public static void smethod_51(Exception A_0)
    {
    }

    public static bool smethod_52(char[] A_0, char A_1)
    {
        foreach (char ch in A_0)
        {
            if (A_1 == ch)
            {
                return true;
            }
        }
        return false;
    }

    public static string smethod_53(string A_0)
    {
        for (int i = A_0.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(A_0[i]))
            {
                return A_0.Substring(0, i + 1);
            }
        }
        return A_0;
    }

    public static Uri smethod_54(string A_0)
    {
        if (!smethod_16(A_0))
        {
            return null;
        }
        try
        {
            return new Uri(A_0);
        }
        catch (UriFormatException)
        {
            return null;
        }
    }

    public static void smethod_55(MemoryStream A_0)
    {
        A_0.Dispose();
    }

    public static string smethod_56(string A_0)
    {
        char[] array = A_0.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    public static string smethod_57(string A_0)
    {
        StringBuilder builder = new StringBuilder();
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                if (current == 0)
                {
                    goto Label_004C;
                }
                builder.Append(Class334.smethod_0(current));
            }
        }
    Label_004C:
        return builder.ToString();
    }

    internal static string smethod_58()
    {
        return BookmarkStart.b("怲䔴帶䬸帺ጼ笾⹀⁂", 13);
    }

    public static void smethod_6(Stream A_0, int A_1)
    {
        int num = smethod_5(A_0.Position, A_1);
        if (A_0.Length < num)
        {
            A_0.SetLength((long) num);
        }
        A_0.Position = num;
    }

    public static byte[] smethod_7(Stream A_0, int A_1)
    {
        long position = A_0.Position;
        byte[] buffer = new byte[A_1];
        A_0.Read(buffer, 0, buffer.Length);
        A_0.Position = position;
        return buffer;
    }

    public static void smethod_8(Stream A_0, Stream A_1)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唥娧䤩缫娭䈯圱唳嬵", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈥嬧帩缫娭䈯圱唳嬵", num));
        }
        byte[] buffer = new byte[0x1000];
        while (true)
        {
            int count = A_0.Read(buffer, 0, buffer.Length);
            if (count <= 0)
            {
                return;
            }
            A_1.Write(buffer, 0, count);
        }
    }

    public static MemoryStream smethod_9(Stream A_0)
    {
        if (A_0 is MemoryStream)
        {
            return (MemoryStream) A_0;
        }
        MemoryStream stream = new MemoryStream((int) A_0.Length);
        smethod_8(A_0, stream);
        return stream;
    }
}

