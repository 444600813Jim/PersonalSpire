using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;

internal class Class734
{
    private static readonly byte[] byte_0 = new byte[] { 0x1f, 0x8b, 8, 0, 0, 0, 0, 0, 2, 11 };
    private const double double_0 = 16777216.0;
    [ThreadStatic]
    private static int int_0 = 0x400;

    internal static string smethod_0(int A_0)
    {
        return smethod_20(Class969.smethod_42(A_0));
    }

    internal static string smethod_1(int A_0)
    {
        return smethod_21(Class969.smethod_52(A_0));
    }

    internal static string smethod_10(int A_0)
    {
        int num = 5;
        if (A_0 == 0)
        {
            return BookmarkStart.b("ᬪ", num);
        }
        if ((A_0 % 0x4000) == 0)
        {
            return Class1041.smethod_46(((double) A_0) / 65536.0);
        }
        return (A_0.ToString() + BookmarkStart.b("䴪", num));
    }

    internal static string smethod_11(object A_0, bool A_1)
    {
        bool flag;
        if ((flag = (bool) A_0) != A_1)
        {
            return smethod_13(flag);
        }
        return null;
    }

    internal static string smethod_12(object A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        return smethod_13((bool) A_0);
    }

    internal static string smethod_13(bool A_0)
    {
        int num = 6;
        if (!A_0)
        {
            return BookmarkStart.b("䨫", num);
        }
        return BookmarkStart.b("堫", num);
    }

    internal static string smethod_14(int A_0)
    {
        int num2 = 8;
        double a = Class969.smethod_68(A_0);
        if (a == Math.Round(a))
        {
            return Class1041.smethod_8((int) a);
        }
        return (Class1041.smethod_8(A_0) + BookmarkStart.b("䠭启", num2));
    }

    internal static string smethod_15(Class954[] A_0)
    {
        int num = 0x13;
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            if (i == 0)
            {
                builder.Append(string.Format(BookmarkStart.b("䈸଺䀼Ἶ㩀牂㡄籆", num), 0, Class735.smethod_1(A_0[i].color_0)));
            }
            else if (i == (A_0.Length - 1))
            {
                builder.Append(string.Format(BookmarkStart.b("䈸଺䀼Ἶ㩀牂㡄籆", num), 1, Class735.smethod_1(A_0[i].color_0)));
            }
            else
            {
                builder.Append(string.Format(BookmarkStart.b("䈸଺䀼Ἶ㩀牂㡄籆", num), smethod_10(A_0[i].int_0), Class735.smethod_1(A_0[i].color_0)));
            }
        }
        if (builder.Length > 0)
        {
            return builder.ToString(0, builder.Length - 1);
        }
        return "";
    }

    internal static string smethod_16(Point A_0)
    {
        return string.Format(BookmarkStart.b("匧ᨩ儫ȭ䬯̱䤳", 2), Class1041.smethod_8(A_0.X), Class1041.smethod_8(A_0.Y));
    }

    internal static string smethod_17(double A_0, double A_1, bool A_2)
    {
        return string.Format(BookmarkStart.b("刨ᬪ倬̮䨰Ȳ䠴", 3), smethod_19(A_0, A_2), smethod_19(A_1, A_2));
    }

    internal static string smethod_18(object A_0, bool A_1)
    {
        if (A_0 == null)
        {
            return null;
        }
        double num = (double) A_0;
        return smethod_19(num, A_1);
    }

    internal static string smethod_19(double A_0, bool A_1)
    {
        if (A_1)
        {
            return smethod_20(A_0);
        }
        return Class1041.smethod_8(Class1133.smethod_5(A_0));
    }

    internal static string smethod_2(Class558 A_0)
    {
        return A_0.method_7(false).Replace(BookmarkStart.b("ᘬ༮", 7), BookmarkStart.b("ᘬ", 7));
    }

    internal static string smethod_20(double A_0)
    {
        int num = 5;
        if (A_0 == 0.0)
        {
            return BookmarkStart.b("ᬪ", num);
        }
        if ((A_0 % 72.0) == 0.0)
        {
            return (Class1041.smethod_46(A_0 / 72.0) + BookmarkStart.b("䈪䌬", num));
        }
        return (Class1041.smethod_46(A_0) + BookmarkStart.b("嬪夬", num));
    }

    internal static string smethod_21(double A_0)
    {
        int num = 12;
        if (A_0 == 0.0)
        {
            return BookmarkStart.b("ȱ", num);
        }
        return (Class1041.smethod_47(A_0) + BookmarkStart.b("弱夳", num));
    }

    internal static string smethod_22(int A_0)
    {
        int num = 3;
        if (A_0 == 0)
        {
            return BookmarkStart.b("ᤨ", num);
        }
        return (Class1041.smethod_8(A_0) + BookmarkStart.b("న", num));
    }

    internal static string smethod_23(Class1031 A_0)
    {
        if ((A_0 != null) && A_0.method_7())
        {
            return Class735.smethod_1(A_0.method_12());
        }
        return "";
    }

    internal static string smethod_24(int A_0)
    {
        double num = ((double) A_0) / 16777216.0;
        return Class1041.smethod_45(num);
    }

    internal static int smethod_25(string A_0)
    {
        return Class1133.smethod_5(Class1041.smethod_12(A_0) * 16777216.0);
    }

    internal static int smethod_26(string A_0)
    {
        byte[] bytes = Encoding.Unicode.GetBytes(A_0.Trim(new char[] { '#' }));
        CrcMaker maker = new CrcMaker();
        return maker.MakeCRC(bytes);
    }

    internal static byte[] smethod_27(byte[] A_0)
    {
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output);
        string str = BookmarkStart.b("破搶瘸紺笼瘾ɀق籄楆祈", 15);
        for (int i = 0; i < str.Length; i++)
        {
            writer.Write((byte) str[i]);
        }
        writer.Write((uint) A_0.Length);
        Class1044 class2 = Class409.smethod_27(A_0);
        writer.Write(class2.method_0());
        writer.Write(class2.method_1());
        writer.Write(class2.method_2());
        writer.Write(class2.method_3());
        writer.Write(class2.method_11());
        writer.Write(class2.method_12());
        writer.Write((uint) 0);
        writer.Write((ushort) 0xfe00);
        for (int j = 0; j < 0x1d3; j++)
        {
            writer.Write((byte) 0);
        }
        writer.Write(A_0);
        return smethod_29(output.ToArray());
    }

    internal static byte[] smethod_28(byte[] A_0)
    {
        byte[] sourceArray = smethod_30(A_0);
        byte[] destinationArray = new byte[sourceArray.Length - 0x200];
        Array.Copy(sourceArray, 0x200, destinationArray, 0, destinationArray.Length);
        return destinationArray;
    }

    internal static byte[] smethod_29(byte[] A_0)
    {
        A_0 = Class1156.smethod_2(A_0, CompressionMethod.Deflated);
        byte[] array = new byte[A_0.Length + byte_0.Length];
        A_0.CopyTo(array, byte_0.Length);
        for (int i = 0; i < byte_0.Length; i++)
        {
            array[i] = byte_0[i];
        }
        return array;
    }

    internal static string smethod_3(ShapeBase A_0)
    {
        int num = 0;
        string str = string.Format(BookmarkStart.b("礥倧ᨩᰫḭ/洱伳ص䔷䄹഻䌽", 0), A_0.IsInline ? BookmarkStart.b("伥", num) : BookmarkStart.b("唥", num), Class1041.smethod_34(smethod_5()));
        A_0.Name = str;
        return str;
    }

    internal static byte[] smethod_30(byte[] A_0)
    {
        if (smethod_34(A_0))
        {
            MemoryStream stream = new MemoryStream(A_0, 10, A_0.Length - 10);
            return Class1156.smethod_1(stream, 0, CompressionMethod.Deflated);
        }
        return A_0;
    }

    internal static string smethod_31(PointF[] A_0, char A_1, char A_2)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            PointF tf = A_0[i];
            builder.Append(tf.X);
            builder.Append(A_1);
            builder.Append(tf.Y);
            builder.Append(A_2);
        }
        builder.Remove(builder.Length - 1, 1);
        return builder.ToString();
    }

    internal static string smethod_32(Class891[] A_0, char A_1, char A_2)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            Class891 class2 = A_0[i];
            builder.Append(smethod_33(class2.method_0()));
            builder.Append(A_1);
            builder.Append(smethod_33(class2.method_1()));
            builder.Append(A_2);
        }
        builder.Remove(builder.Length - 1, 1);
        return builder.ToString();
    }

    internal static string smethod_33(Class623 A_0)
    {
        int num = 15;
        if (A_0.method_0())
        {
            return (BookmarkStart.b("甴", num) + Class1041.smethod_8(A_0.method_1()));
        }
        return Class1041.smethod_8(A_0.method_1());
    }

    private static bool smethod_34(byte[] A_0)
    {
        for (int i = 0; i < 4; i++)
        {
            if (A_0[i] != byte_0[i])
            {
                return false;
            }
        }
        return true;
    }

    internal static string smethod_4(ShapeBase A_0)
    {
        if (!Class567.smethod_16(A_0.Name))
        {
            return smethod_3(A_0);
        }
        return A_0.Name;
    }

    private static int smethod_5()
    {
        return ++int_0;
    }

    internal static int smethod_6()
    {
        return int_0;
    }

    internal static void smethod_7(int A_0)
    {
        int_0 = A_0;
    }

    internal static string smethod_8(Hashtable A_0)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0x81; i <= 0x84; i++)
        {
            if (A_0[i] != null)
            {
                builder.Append(smethod_20(Class969.smethod_42((int) A_0[i])));
            }
            builder.Append(',');
        }
        return builder.ToString().TrimEnd(new char[] { ',' });
    }

    internal static string smethod_9(object A_0)
    {
        if (A_0 == null)
        {
            return null;
        }
        int num = (int) A_0;
        return smethod_10(num);
    }
}

