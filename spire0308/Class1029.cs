using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class1029
{
    private static readonly Encoding encoding_0 = Encoding.Unicode;
    private static readonly Encoding encoding_1 = Encoding.GetEncoding(0x4e4);
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();

    static Class1029()
    {
        Class791.smethod_0(new object[] { 0, Language.LanguageNotSet, 1, Language.Japanese, 2, Language.ChineseSingapore, 3, Language.Korean, 4, Language.ChineseTaiwan }, hashtable_0, hashtable_1);
    }

    private Class1029()
    {
    }

    internal static Encoding smethod_0(bool A_0)
    {
        if (!A_0)
        {
            return encoding_1;
        }
        return encoding_0;
    }

    internal static string smethod_1(BinaryReader A_0, bool A_1, bool A_2)
    {
        if (A_1)
        {
            int num = A_0.ReadUInt16() * 2;
            if (!Class567.smethod_46(A_0, num))
            {
                num = 0;
            }
            byte[] buffer2 = A_0.ReadBytes(num);
            string str = smethod_0(A_1).GetString(buffer2);
            if (A_2)
            {
                A_0.ReadUInt16();
            }
            return str;
        }
        int count = A_0.ReadByte();
        byte[] bytes = A_0.ReadBytes(count);
        string str2 = smethod_0(A_1).GetString(bytes);
        if (A_2)
        {
            A_0.ReadByte();
        }
        return str2;
    }

    internal static void smethod_10(string A_0, BinaryWriter A_1)
    {
        A_1.Write(smethod_11(A_0));
        smethod_8(A_0, A_1);
    }

    internal static int smethod_11(string A_0)
    {
        return (smethod_12(A_0) * 2);
    }

    internal static int smethod_12(string A_0)
    {
        return (A_0.Length + 1);
    }

    internal static string smethod_13(BinaryReader A_0, int A_1)
    {
        if (A_1 == 0)
        {
            return string.Empty;
        }
        byte[] bytes = A_0.ReadBytes(A_1);
        return encoding_1.GetString(bytes, 0, A_1 - 1);
    }

    internal static string smethod_14(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        return smethod_13(A_0, num);
    }

    internal static char[] smethod_15(BinaryReader A_0, bool A_1, int A_2)
    {
        byte[] bytes = A_0.ReadBytes(A_1 ? (A_2 * 2) : A_2);
        return smethod_0(A_1).GetChars(bytes);
    }

    internal static string smethod_16(BinaryReader A_0, int A_1, int A_2)
    {
        byte[] bytes = A_0.ReadBytes(A_1 - 1);
        A_0.ReadByte();
        return Encoding.GetEncoding(A_2).GetString(bytes);
    }

    internal static string smethod_17(BinaryReader A_0, int A_1)
    {
        return smethod_16(A_0, A_0.ReadInt16(), A_1);
    }

    internal static string smethod_18(BinaryReader A_0, int A_1)
    {
        int num = A_0.ReadInt32();
        return smethod_19(A_0, num, A_1);
    }

    internal static string smethod_19(BinaryReader A_0, int A_1, int A_2)
    {
        if (A_1 == 0)
        {
            return string.Empty;
        }
        byte[] bytes = A_0.ReadBytes(A_1 - 1);
        A_0.ReadByte();
        return Encoding.GetEncoding(A_2).GetString(bytes);
    }

    internal static int smethod_2(string A_0, int A_1, BinaryWriter A_2, bool A_3, bool A_4)
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
            byte[] bytes = smethod_0(true).GetBytes(A_0);
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
            byte[] buffer = smethod_0(false).GetBytes(A_0);
            A_2.Write(buffer, 0, count);
            if (A_4)
            {
                A_2.Write((byte) 0);
            }
        }
        return (((int) A_2.BaseStream.Position) - position);
    }

    internal static void smethod_20(BinaryWriter A_0, string A_1, int A_2, bool A_3)
    {
        if (A_3)
        {
            A_0.Write((short) (A_1.Length + 1));
        }
        A_0.Write(Encoding.GetEncoding(A_2).GetBytes(A_1));
        A_0.Write((byte) 0);
    }

    internal static Language smethod_21(int A_0)
    {
        return (Language) Class791.smethod_3(hashtable_0, A_0, Language.LanguageNotSet);
    }

    internal static int smethod_22(Language A_0)
    {
        return (int) Class791.smethod_3(hashtable_1, A_0, 0);
    }

    internal static string smethod_3(BinaryReader A_0, int A_1)
    {
        int position = (int) A_0.BaseStream.Position;
        int num2 = A_0.ReadUInt16() * 2;
        num2 = Math.Min(num2, A_1 - 2);
        byte[] bytes = A_0.ReadBytes(num2);
        string str = encoding_0.GetString(bytes);
        A_0.BaseStream.Position = position + A_1;
        return str;
    }

    internal static void smethod_4(string A_0, BinaryWriter A_1, int A_2)
    {
        int num = (A_2 / 2) - 1;
        int num2 = Math.Min(A_0.Length, num);
        A_1.Write((ushort) num2);
        byte[] bytes = encoding_0.GetBytes(A_0);
        int count = num2 * 2;
        A_1.Write(bytes, 0, count);
        int num4 = (A_2 - count) - 2;
        A_1.Write(new byte[num4]);
    }

    internal static string smethod_5(BinaryReader A_0, int A_1)
    {
        if (A_1 == 0)
        {
            return string.Empty;
        }
        byte[] bytes = A_0.ReadBytes(A_1);
        return encoding_0.GetString(bytes, 0, A_1 - 2);
    }

    internal static string smethod_6(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        return smethod_5(A_0, num);
    }

    internal static string smethod_7(BinaryReader A_0)
    {
        int num = A_0.ReadInt32() * 2;
        return smethod_5(A_0, num);
    }

    internal static int smethod_8(string A_0, BinaryWriter A_1)
    {
        byte[] bytes = new byte[smethod_11(A_0)];
        encoding_0.GetBytes(A_0, 0, A_0.Length, bytes, 0);
        A_1.Write(bytes);
        return bytes.Length;
    }

    internal static void smethod_9(string A_0, BinaryWriter A_1)
    {
        A_1.Write(smethod_12(A_0));
        smethod_8(A_0, A_1);
    }
}

