using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

internal static class Class57
{
    internal static char[] smethod_0(BinaryReader A_0, bool A_1, int A_2)
    {
        byte[] bytes = A_0.ReadBytes(A_1 ? (A_2 * 2) : A_2);
        if (A_1)
        {
            return Encoding.Unicode.GetChars(bytes);
        }
        return Encoding.GetEncoding(0x4e4).GetChars(bytes);
    }

    internal static int smethod_1(string A_0, int A_1, BinaryWriter A_2, bool A_3, bool A_4)
    {
        int position = (int) A_2.BaseStream.Position;
        A_0 = (A_0 != null) ? A_0 : "";
        if (A_0.Length > A_1)
        {
            A_0 = A_0.Substring(0, A_1);
        }
        if (A_3)
        {
            A_2.Write((ushort) A_0.Length);
            byte[] bytes = Encoding.Unicode.GetBytes(A_0);
            A_2.Write(bytes);
            if (A_4)
            {
                A_2.Write((ushort) 0);
            }
        }
        else
        {
            int count = (byte) Math.Min(A_0.Length, 0xff);
            A_2.Write((byte) count);
            byte[] buffer = Encoding.GetEncoding(0x4e4).GetBytes(A_0);
            A_2.Write(buffer, 0, count);
            if (A_4)
            {
                A_2.Write((byte) 0);
            }
        }
        return (((int) A_2.BaseStream.Position) - position);
    }

    internal static bool smethod_10(char A_0)
    {
        if (!smethod_11(A_0))
        {
            return smethod_12(A_0);
        }
        return true;
    }

    internal static bool smethod_11(char A_0)
    {
        if (!char.IsLower(A_0))
        {
            return char.IsUpper(A_0);
        }
        return true;
    }

    internal static bool smethod_12(char A_0)
    {
        return char.IsDigit(A_0);
    }

    internal static bool smethod_13(char A_0)
    {
        if ((((A_0 < '⺀') || (A_0 > 0xd7af)) && ((A_0 < 0xf900) || (A_0 > 0xfaff))) && ((A_0 < 0xff00) || (A_0 > 0xffef)))
        {
            return false;
        }
        return true;
    }

    internal static byte[] smethod_14(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ࠧ", 2), string.Empty).Replace(BookmarkStart.b("┧", 2), string.Empty).Replace(BookmarkStart.b("∧", 2), string.Empty);
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        List<byte> list = new List<byte>();
        int num = 0;
        int length = A_0.Length;
        while (num < length)
        {
            list.Add((byte) smethod_15(A_0[num], A_0[num + 1]));
            num += 2;
        }
        return list.ToArray();
    }

    private static char smethod_15(char A_0, char A_1)
    {
        return (char) byte.Parse(A_0.ToString() + A_1, NumberStyles.HexNumber);
    }

    public static Stream smethod_16(Stream A_0)
    {
        Stream stream = new MemoryStream((int) A_0.Length);
        long position = A_0.Position;
        A_0.Position = 0L;
        smethod_4(A_0, stream);
        stream.Position = A_0.Position = position;
        return stream;
    }

    public static XmlReader smethod_17(Stream A_0, bool A_1)
    {
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        if (A_1)
        {
            while (reader.NodeType != XmlNodeType.Element)
            {
                reader.Read();
            }
        }
        return reader;
    }

    public static XmlReader smethod_18(Stream A_0)
    {
        return smethod_17(A_0, true);
    }

    public static XmlWriter smethod_19(Stream A_0, Encoding A_1)
    {
        XmlWriterSettings settings = new XmlWriterSettings {
            Encoding = A_1
        };
        return XmlWriter.Create(A_0, settings);
    }

    public static double smethod_2(DateTime A_0)
    {
        double num = A_0.ToOADate();
        if (num < 61.0)
        {
            num--;
        }
        return num;
    }

    public static XmlWriter smethod_20(TextWriter A_0)
    {
        XmlWriterSettings settings = new XmlWriterSettings();
        return XmlWriter.Create(A_0, settings);
    }

    public static XmlWriter smethod_21(TextWriter A_0, bool A_1)
    {
        XmlWriterSettings settings = new XmlWriterSettings {
            Indent = A_1
        };
        return XmlWriter.Create(A_0, settings);
    }

    public static MemoryStream smethod_22(XmlReader A_0)
    {
        MemoryStream stream = new MemoryStream();
        XmlWriter writer = smethod_19(stream, Encoding.UTF8);
        writer.WriteNode(A_0, false);
        writer.Flush();
        stream.Position = 0L;
        return stream;
    }

    internal static string smethod_23(LineDashing A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case LineDashing.Dot:
                return BookmarkStart.b("ᘦनᨪ", num);

            case LineDashing.DashGEL:
                return BookmarkStart.b("䌦䠨堪䔬", num);

            case LineDashing.LongDashGEL:
                return BookmarkStart.b("䬦䘨䔪䨬欮倰䀲崴", num);

            case LineDashing.DashDotGEL:
                return BookmarkStart.b("䌦䠨堪䔬欮帰䜲", num);

            case LineDashing.LongDashDotGEL:
                return BookmarkStart.b("䬦䘨䔪䨬欮倰䀲崴猶嘸伺", num);

            case LineDashing.LongDashDotDotGEL:
                return BookmarkStart.b("䬦䘨䔪䨬欮倰䀲崴猶嘸伺礼倾㕀", num);
        }
        return null;
    }

    internal static LineDashing smethod_24(string A_0)
    {
        int num = 0x12;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_0 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("षᨹ഻", num), 0);
                dictionary1.Add(BookmarkStart.b("尷唹䠻", num), 1);
                dictionary1.Add(BookmarkStart.b("尷嬹伻嘽", num), 2);
                dictionary1.Add(BookmarkStart.b("尷嬹伻嘽пⵁぃ", num), 3);
                dictionary1.Add(BookmarkStart.b("吷唹刻夽п⍁㝃⹅", num), 4);
                dictionary1.Add(BookmarkStart.b("吷唹刻夽п⍁㝃⹅ే╉㡋", num), 5);
                dictionary1.Add(BookmarkStart.b("吷唹刻夽п⍁㝃⹅ే╉㡋੍㽏♑", num), 6);
                Class1160.dictionary_0 = dictionary1;
            }
            if (Class1160.dictionary_0.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return LineDashing.Dot;

                    case 2:
                        return LineDashing.DashGEL;

                    case 3:
                        return LineDashing.DashDot;

                    case 4:
                        return LineDashing.LongDashGEL;

                    case 5:
                        return LineDashing.LongDashDotGEL;

                    case 6:
                        return LineDashing.LongDashDotDotGEL;
                }
            }
        }
        return LineDashing.Solid;
    }

    internal static string smethod_25(TextBoxLineStyle A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case TextBoxLineStyle.Double:
                return BookmarkStart.b("䀳帵儷吹栻嘽⤿ⱁ", num);

            case TextBoxLineStyle.ThickThin:
                return BookmarkStart.b("䀳帵儷夹圻樽⠿⭁⩃", num);

            case TextBoxLineStyle.ThinThick:
                return BookmarkStart.b("䀳帵儷吹栻嘽⤿⅁⽃", num);

            case TextBoxLineStyle.Triple:
                return BookmarkStart.b("䀳帵儷夹圻簽┿㙁㍃⍅ⵇ⑉ᡋ♍㥏㱑", num);
        }
        return null;
    }

    internal static TextBoxLineStyle smethod_26(string A_0)
    {
        int num = 0;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("別䀧䌩䈫稭堯嬱娳", num))
            {
                return TextBoxLineStyle.Double;
            }
            if (str == BookmarkStart.b("別䀧䌩䈫稭堯嬱圳崵", num))
            {
                return TextBoxLineStyle.ThinThick;
            }
            if (str == BookmarkStart.b("別䀧䌩伫䔭搯娱崳堵", num))
            {
                return TextBoxLineStyle.ThickThin;
            }
            if (str == BookmarkStart.b("別䀧䌩伫䔭爯圱䀳䄵崷弹刻樽⠿⭁⩃", num))
            {
                return TextBoxLineStyle.Triple;
            }
        }
        return TextBoxLineStyle.Simple;
    }

    internal static BorderStyle smethod_27(TextBoxLineStyle A_0)
    {
        switch (A_0)
        {
            case TextBoxLineStyle.Simple:
                return BorderStyle.Single;

            case TextBoxLineStyle.Double:
                return BorderStyle.Double;

            case TextBoxLineStyle.ThickThin:
                return BorderStyle.ThickThinMediumGap;

            case TextBoxLineStyle.ThinThick:
                return BorderStyle.ThinThickMediumGap;

            case TextBoxLineStyle.Triple:
                return BorderStyle.Triple;
        }
        return BorderStyle.None;
    }

    public static DateTime smethod_3(double A_0)
    {
        if (A_0 < 61.0)
        {
            A_0++;
        }
        return DateTime.FromOADate(A_0);
    }

    public static void smethod_4(Stream A_0, Stream A_1)
    {
        int num2;
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭弯䜱䘳唵崷", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨭唯䄱䀳張嘷嬹䠻圽⼿ⱁ", num));
        }
        byte[] buffer = new byte[0x8000];
        while ((num2 = A_0.Read(buffer, 0, 0x8000)) > 0)
        {
            A_1.Write(buffer, 0, num2);
        }
    }

    public static byte[] smethod_5(Stream A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嬧堩伫紭䐯䀱儳圵唷", num));
        }
        byte[] buffer = new byte[(int) A_0.Length];
        using (MemoryStream stream = new MemoryStream(buffer))
        {
            A_0.Position = 0L;
            smethod_4(A_0, stream);
            return buffer;
        }
    }

    internal static CharacterCategory smethod_6(char A_0)
    {
        if ((A_0 >= '\0') && (A_0 <= '\x00ff'))
        {
            return CharacterCategory.Ascii;
        }
        if ((A_0 >= '⺀') && (A_0 <= 0xd7af))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 >= 0xf900) && (A_0 <= 0xfaff))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 >= 0xff00) && (A_0 <= 0xffef))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 < '֐') || (A_0 > '෿'))
        {
            if ((A_0 >= 0xfb1d) && (A_0 <= 0xfb4f))
            {
                return CharacterCategory.ComplexScript;
            }
            if (((A_0 < 0xfb50) || (A_0 > 0xfdff)) && ((A_0 < 0xfe70) || (A_0 > 0xfeff)))
            {
                return CharacterCategory.Other;
            }
        }
        return CharacterCategory.ComplexScript;
    }

    internal static CharacterCategory smethod_7(int A_0)
    {
        if ((A_0 >= 0) && (A_0 <= 0xff))
        {
            return CharacterCategory.Ascii;
        }
        if ((A_0 >= 0x2e80) && (A_0 <= 0xd7af))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 >= 0xf900) && (A_0 <= 0xfaff))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 >= 0xff00) && (A_0 <= 0xffef))
        {
            return CharacterCategory.FarEast;
        }
        if ((A_0 < 0x590) || (A_0 > 0xdff))
        {
            if ((A_0 >= 0xfb1d) && (A_0 <= 0xfb4f))
            {
                return CharacterCategory.ComplexScript;
            }
            if (((A_0 < 0xfb50) || (A_0 > 0xfdff)) && ((A_0 < 0xfe70) || (A_0 > 0xfeff)))
            {
                return CharacterCategory.Other;
            }
        }
        return CharacterCategory.ComplexScript;
    }

    internal static bool smethod_8(int A_0)
    {
        if (((((A_0 != 9) && (A_0 != 10)) && (A_0 != 13)) && ((A_0 < 0x20) || (A_0 > 0xd7ff))) && ((A_0 < 0xe000) || (A_0 > 0xfffd)))
        {
            return ((A_0 >= 0x10000) && (A_0 <= 0x10ffff));
        }
        return true;
    }

    internal static CharacterCategory smethod_9(string A_0)
    {
        CharacterCategory ascii = CharacterCategory.Ascii;
        if (!string.IsNullOrEmpty(A_0))
        {
            foreach (char ch in A_0)
            {
                ascii = smethod_6(ch);
                if ((ascii != CharacterCategory.Ascii) && (ascii != CharacterCategory.Other))
                {
                    return ascii;
                }
            }
        }
        return ascii;
    }
}

