using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

internal class Class409
{
    private const double double_0 = 39.370078740157481;
    public const float float_0 = 96f;
    public const int int_0 = 300;

    private Class409()
    {
    }

    public static ImageFormat smethod_0(byte[] A_0)
    {
        if ((A_0 == null) || (A_0.Length == 0))
        {
            return ImageFormat.Unknown;
        }
        using (Stream stream = new MemoryStream(A_0))
        {
            return smethod_5(stream);
        }
    }

    public static bool smethod_1(ImageFormat A_0)
    {
        switch (A_0)
        {
            case ImageFormat.Emf:
            case ImageFormat.Jpeg:
            case ImageFormat.Png:
            case ImageFormat.Wmf:
                return true;
        }
        return false;
    }

    public static Class1044 smethod_10(byte[] A_0, ImageFormat A_1)
    {
        return smethod_11(new MemoryStream(A_0), A_1);
    }

    public static Class1044 smethod_11(Stream A_0, ImageFormat A_1)
    {
        Class1044 class2;
        long position = A_0.Position;
        switch (A_1)
        {
            case ImageFormat.Emf:
            case ImageFormat.Wmf:
                class2 = smethod_26(A_0);
                break;

            case ImageFormat.Gif:
                class2 = smethod_21(A_0);
                break;

            case ImageFormat.Tiff:
                class2 = smethod_24(A_0);
                break;

            default:
                class2 = Class1044.smethod_1(100, 100, 96.0, 96.0);
                break;
        }
        A_0.Position = position;
        return class2;
    }

    public static MfMetafileType smethod_12(byte[] A_0)
    {
        if (!smethod_55(A_0))
        {
            return MfMetafileType.Invalid;
        }
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            reader.ReadUInt32();
            uint num = reader.ReadUInt32();
            reader.BaseStream.Position = num;
            if (reader.ReadUInt32() == 70)
            {
                reader.ReadInt32();
                reader.ReadInt32();
                if (reader.ReadInt32() == 0x2b464d45)
                {
                    if (reader.ReadUInt16() != 0x4001)
                    {
                        return MfMetafileType.EmfOnly;
                    }
                    if ((reader.ReadUInt16() & 1) == 1)
                    {
                        return MfMetafileType.EmfPlusDual;
                    }
                    return MfMetafileType.EmfPlusOnly;
                }
            }
            return MfMetafileType.EmfOnly;
        }
    }

    public static MfMetafileType smethod_13(byte[] A_0)
    {
        if (smethod_50(A_0))
        {
            return MfMetafileType.Wmf;
        }
        if (smethod_52(A_0))
        {
            return MfMetafileType.WmfPlaceable;
        }
        return smethod_12(A_0);
    }

    public static MfMetafileType smethod_14(Stream A_0)
    {
        A_0.Position = 0L;
        return smethod_13(Class567.smethod_7(A_0, 0x200));
    }

    public static byte[] smethod_15(BinaryReader A_0, int A_1)
    {
        int position = (int) A_0.BaseStream.Position;
        Class966 class2 = new Class966();
        class2.method_1(A_0);
        A_0.BaseStream.Position = position;
        int num2 = class2.int_2 + class2.method_0();
        return smethod_16(A_0, num2, A_1 - num2);
    }

    public static byte[] smethod_16(BinaryReader A_0, int A_1, int A_2)
    {
        int position = (int) A_0.BaseStream.Position;
        Class966 class2 = new Class966();
        class2.method_1(A_0);
        byte[] buffer = A_0.ReadBytes(class2.method_0());
        A_0.BaseStream.Position = position + A_1;
        return smethod_19(class2, buffer, A_0, A_2);
    }

    internal static byte[] smethod_17(Class966 A_0, Color[] A_1, BinaryReader A_2, int A_3)
    {
        return smethod_19(A_0, smethod_18(A_1), A_2, A_3);
    }

    private static byte[] smethod_18(Color[] A_0)
    {
        byte[] buffer = new byte[A_0.Length * 4];
        for (int i = 0; i < A_0.Length; i++)
        {
            buffer[4 * i] = A_0[i].B;
            buffer[(4 * i) + 1] = A_0[i].G;
            buffer[(4 * i) + 2] = A_0[i].R;
            buffer[(4 * i) + 3] = 0;
        }
        return buffer;
    }

    internal static byte[] smethod_19(Class966 A_0, byte[] A_1, BinaryReader A_2, int A_3)
    {
        int index = (14 + A_0.int_2) + A_1.Length;
        byte[] buffer = new byte[index + A_3];
        using (MemoryStream stream = new MemoryStream(buffer))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            new Class688 { uint_1 = (uint) (index + A_3), uint_0 = (uint) index }.method_1(writer);
            A_0.method_2(writer);
            writer.Write(A_1);
            writer.Flush();
            A_2.Read(buffer, index, A_3);
            return buffer;
        }
    }

    public static BlipImageType smethod_2(ImageFormat A_0)
    {
        BlipImageType noImage = BlipImageType.NoImage;
        switch (A_0)
        {
            case ImageFormat.Bmp:
                return BlipImageType.Bmp;

            case ImageFormat.Emf:
                return BlipImageType.Emf;

            case ImageFormat.Gif:
            case ImageFormat.Icon:
            case ImageFormat.Tiff:
            case ImageFormat.MemoryBmp:
                return noImage;

            case ImageFormat.Jpeg:
                return BlipImageType.Jpeg;

            case ImageFormat.Png:
                return BlipImageType.Png;

            case ImageFormat.Wmf:
                return BlipImageType.Wmf;

            case ImageFormat.MacPICT:
                return BlipImageType.Pict;
        }
        return noImage;
    }

    public static Class1044 smethod_20(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_21(stream);
        }
    }

    public static Class1044 smethod_21(Stream A_0)
    {
        A_0.Position = 6L;
        BinaryReader reader = new BinaryReader(A_0);
        ushort num = reader.ReadUInt16();
        ushort num2 = reader.ReadUInt16();
        return Class1044.smethod_1(num, num2, 0.0, 0.0);
    }

    public static Class1044 smethod_22(byte[] A_0)
    {
        using (new MemoryStream(A_0))
        {
            return Class1044.smethod_0();
        }
    }

    public static Class1044 smethod_23(byte[] A_0)
    {
        return smethod_24(new MemoryStream(A_0));
    }

    public static Class1044 smethod_24(Stream A_0)
    {
        return Class1044.smethod_0();
    }

    public static Class1044 smethod_25(byte[] A_0)
    {
        return smethod_26(new MemoryStream(A_0));
    }

    public static Class1044 smethod_26(Stream A_0)
    {
        return Class1044.smethod_0();
    }

    public static Class1044 smethod_27(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_28(stream);
        }
    }

    public static Class1044 smethod_28(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        reader.ReadUInt16();
        int num = Class336.smethod_4(reader.ReadUInt16());
        int num2 = Class336.smethod_4(reader.ReadUInt16());
        int num3 = Class336.smethod_4(reader.ReadUInt16());
        int num4 = Class336.smethod_4(reader.ReadUInt16());
        int num5 = Class969.smethod_40((double) (num4 - num2));
        int num6 = Class969.smethod_40((double) (num3 - num));
        return Class1044.smethod_3(num2, num, num4, num3, num5, num6);
    }

    public static byte[] smethod_29(byte[] A_0, Class1044 A_1)
    {
        using (MemoryStream stream = new MemoryStream())
        {
            BinaryWriter writer = new BinaryWriter(stream, Encoding.Unicode);
            int num = 0;
            writer.Write((ushort) 0xcdd7);
            num = 0xcdd7;
            writer.Write((ushort) 0x9ac6);
            num = 0x5711;
            writer.Write((short) 0);
            num = 0x5711;
            writer.Write((short) A_1.method_0());
            num = 0x5711 ^ A_1.method_0();
            writer.Write((short) A_1.method_1());
            num ^= A_1.method_1();
            writer.Write((short) A_1.method_2());
            num ^= A_1.method_2();
            writer.Write((short) A_1.method_3());
            num ^= A_1.method_3();
            writer.Write((short) A_1.method_6());
            num ^= (int) A_1.method_6();
            writer.Write((short) 0);
            writer.Write((short) 0);
            writer.Write((ushort) num);
            writer.Write(A_0);
            return stream.ToArray();
        }
    }

    internal static Bitmap smethod_3(int A_0, int A_1)
    {
        Bitmap bitmap = new Bitmap(A_0, A_1, PixelFormat.Format32bppArgb);
        bitmap.SetResolution(96f, 96f);
        return bitmap;
    }

    public static byte[] smethod_30(byte[] A_0)
    {
        if (smethod_52(A_0))
        {
            byte[] destinationArray = new byte[A_0.Length - 0x16];
            Array.Copy(A_0, 0x16, destinationArray, 0, destinationArray.Length);
            return destinationArray;
        }
        return A_0;
    }

    public static byte[] smethod_31(byte[] A_0)
    {
        MemoryStream input = new MemoryStream(A_0);
        BinaryReader reader = new BinaryReader(input);
        new Class688().method_0(reader);
        new Class966().method_1(reader);
        input.Seek(-40L, SeekOrigin.Current);
        byte[] buffer = new byte[A_0.Length - 14];
        input.Read(buffer, 0, buffer.Length);
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output);
        writer.Write((ushort) 1);
        writer.Write((ushort) 9);
        writer.Write((ushort) 0x300);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((uint) 4);
        writer.Write((ushort) 0x103);
        writer.Write((ushort) 8);
        writer.Write((uint) 5);
        writer.Write((ushort) 0x20b);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((uint) 5);
        writer.Write((ushort) 0x20c);
        writer.Write((uint) 3);
        writer.Write((ushort) 30);
        writer.Write((uint) 4);
        writer.Write((ushort) 0x107);
        writer.Write((ushort) 4);
        writer.Write((ushort) 0xb41);
        writer.Write((uint) 0xcc0020);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((uint) 4);
        writer.Write((ushort) 0x127);
        writer.Write((ushort) 0xffff);
        writer.Write((uint) 3);
        writer.Write((ushort) 0);
        writer.Close();
        return output.ToArray();
    }

    public static byte[] smethod_32(int A_0, int A_1)
    {
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output);
        writer.Write((ushort) 1);
        writer.Write((ushort) 9);
        writer.Write((ushort) 0x300);
        writer.Write((uint) 0x1a);
        writer.Write((ushort) 0);
        writer.Write((uint) 5);
        writer.Write((ushort) 0);
        writer.Write((uint) 4);
        writer.Write((ushort) 0x103);
        writer.Write((ushort) 8);
        writer.Write((uint) 5);
        writer.Write((ushort) 0x20b);
        writer.Write((ushort) 0);
        writer.Write((ushort) 0);
        writer.Write((uint) 5);
        writer.Write((ushort) 0x20c);
        writer.Write((ushort) (A_0 + 1));
        writer.Write((ushort) (A_1 + 1));
        writer.Write((uint) 3);
        writer.Write((ushort) 0);
        writer.Close();
        return output.ToArray();
    }

    public static Graphics smethod_33(Image A_0)
    {
        return Graphics.FromImage(A_0);
    }

    public static bool smethod_34(int A_0, int A_1)
    {
        return ((A_0 * A_1) > 0x1400000);
    }

    internal static double smethod_35(long A_0)
    {
        return (((double) A_0) / 39.370078740157481);
    }

    internal static int smethod_36(double A_0)
    {
        return (int) (A_0 * 39.370078740157481);
    }

    public static bool smethod_37(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_38(stream);
        }
    }

    public static bool smethod_38(Stream A_0)
    {
        int num = new BinaryReader(A_0).ReadInt16();
        if (num != 0x4949)
        {
            return (num == 0x4d4d);
        }
        return true;
    }

    public static bool smethod_39(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_40(stream);
        }
    }

    internal static Bitmap smethod_4(Bitmap A_0)
    {
        Bitmap image = smethod_3(A_0.Width, A_0.Height);
        image.SetResolution(A_0.HorizontalResolution, A_0.VerticalResolution);
        Graphics graphics = Graphics.FromImage(image);
        graphics.Clear(Color.White);
        graphics.DrawImage(A_0, 0, 0);
        return image;
    }

    public static bool smethod_40(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        if (reader.ReadUInt16() != 0xd8ff)
        {
            return false;
        }
        return true;
    }

    public static bool smethod_41(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_42(stream);
        }
    }

    public static bool smethod_42(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        if (reader.ReadUInt32() != 0x474e5089)
        {
            return false;
        }
        if (reader.ReadUInt32() != 0xa1a0a0d)
        {
            return false;
        }
        return true;
    }

    public static bool smethod_43(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_44(stream);
        }
    }

    public static bool smethod_44(Stream A_0)
    {
        bool flag;
        BinaryReader reader = new BinaryReader(A_0);
        if (reader.ReadUInt16() != 0x4d42)
        {
            return false;
        }
        uint num5 = reader.ReadUInt32();
        reader.ReadUInt32();
        uint num6 = reader.ReadUInt32();
        if ((num5 != 0) && (num6 > num5))
        {
            return false;
        }
        uint num4 = reader.ReadUInt32();
        if (!(flag = num4 == 12) && (num4 < 0x10))
        {
            return false;
        }
        if (flag)
        {
            reader.ReadUInt32();
        }
        else
        {
            reader.ReadInt32();
            reader.ReadInt32();
        }
        if (reader.ReadUInt16() != 1)
        {
            return false;
        }
        uint num2 = reader.ReadUInt16();
        if ((((num2 != 1) && (num2 != 4)) && ((num2 != 8) && (num2 != 0x10))) && ((num2 != 0x18) && (num2 != 0x20)))
        {
            return false;
        }
        return true;
    }

    public static bool smethod_45(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_46(stream);
        }
    }

    public static bool smethod_46(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        int num = reader.ReadInt32() & 0xffffff;
        return (num == 0x464947);
    }

    public static bool smethod_47(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_48(stream);
        }
    }

    public static bool smethod_48(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        reader.ReadUInt16();
        reader.ReadUInt16();
        reader.ReadUInt16();
        reader.ReadUInt16();
        reader.ReadUInt16();
        int num = Class336.smethod_4(reader.ReadUInt16());
        return ((num == 0x111) || ((num == 0x11) && (Class336.smethod_4(reader.ReadUInt16()) == 0x2ff)));
    }

    public static bool smethod_49(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            if (reader.ReadUInt16() != 40)
            {
                return false;
            }
            return true;
        }
    }

    public static ImageFormat smethod_5(Stream A_0)
    {
        if ((A_0 != null) && (A_0.Length != 0L))
        {
            long position = A_0.Position;
            try
            {
                bool flag = smethod_51(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Wmf;
                }
                flag = smethod_53(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Wmf;
                }
                flag = smethod_56(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Emf;
                }
                flag = smethod_40(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Jpeg;
                }
                flag = smethod_42(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Png;
                }
                flag = smethod_44(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Bmp;
                }
                flag = smethod_46(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Gif;
                }
                flag = smethod_38(A_0);
                A_0.Position = position;
                if (flag)
                {
                    return ImageFormat.Tiff;
                }
            }
            catch (Exception)
            {
            }
            A_0.Position = position;
        }
        return ImageFormat.Unknown;
    }

    public static bool smethod_50(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_51(stream);
        }
    }

    public static bool smethod_51(Stream A_0)
    {
        if (A_0.Length < 0x12L)
        {
            return false;
        }
        BinaryReader reader = new BinaryReader(A_0);
        int num2 = reader.ReadInt16();
        if ((num2 != 0) && (num2 != 1))
        {
            return false;
        }
        if (reader.ReadInt16() != 9)
        {
            return false;
        }
        reader.ReadInt16();
        reader.ReadInt32();
        reader.ReadInt16();
        reader.ReadInt32();
        if (reader.ReadInt16() != 0)
        {
            return false;
        }
        return true;
    }

    public static bool smethod_52(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_53(stream);
        }
    }

    public static bool smethod_53(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        if (reader.ReadUInt32() != 0x9ac6cdd7)
        {
            return false;
        }
        if (reader.ReadInt16() != 0)
        {
            return false;
        }
        return true;
    }

    public static bool smethod_54(byte[] A_0)
    {
        if (!smethod_50(A_0))
        {
            return smethod_52(A_0);
        }
        return true;
    }

    public static bool smethod_55(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_56(stream);
        }
    }

    public static bool smethod_56(Stream A_0)
    {
        BinaryReader reader = new BinaryReader(A_0);
        if (reader.ReadUInt32() != 1)
        {
            return false;
        }
        reader.BaseStream.Position = 40L;
        if (reader.ReadUInt32() != 0x464d4520)
        {
            return false;
        }
        return true;
    }

    public static bool smethod_57(ImageFormat A_0)
    {
        if (A_0 != ImageFormat.Wmf)
        {
            return (A_0 == ImageFormat.Emf);
        }
        return true;
    }

    public static bool smethod_58(byte[] A_0)
    {
        return smethod_57(smethod_0(A_0));
    }

    public static bool smethod_59(Stream A_0)
    {
        return smethod_60(Class567.smethod_7(A_0, 4));
    }

    public static ImageFormat smethod_6(string A_0)
    {
        return Class238.smethod_1(Path.GetExtension(A_0));
    }

    public static bool smethod_60(byte[] A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        return ((((A_0[0] == 0x25) && (A_0[1] == 80)) && (A_0[2] == 0x44)) && (A_0[3] == 70));
    }

    public static bool smethod_61(byte[] A_0)
    {
        using (MemoryStream stream = new MemoryStream(A_0))
        {
            return smethod_62(stream);
        }
    }

    public static bool smethod_62(Stream A_0)
    {
        return false;
    }

    public static Class1044 smethod_7(string A_0)
    {
        using (FileStream stream = new FileStream(A_0, FileMode.Open))
        {
            return smethod_8(stream);
        }
    }

    public static Class1044 smethod_8(Stream A_0)
    {
        return smethod_11(A_0, smethod_5(A_0));
    }

    public static Class1044 smethod_9(byte[] A_0)
    {
        return smethod_10(A_0, smethod_0(A_0));
    }
}

