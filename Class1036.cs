using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;
using System.IO;

internal class Class1036 : IDisposable
{
    private byte[] byte_0;
    private byte[] byte_1;
    private byte[] byte_2;
    private byte[] byte_3;
    private byte[] byte_4;
    private byte[] byte_5;
    private float float_0;
    private ImageFormat imageFormat_0;
    private const int int_0 = 0x2a;
    private int int_1;
    private int int_2;
    private Stream stream_0;
    private const string string_0 = "GIF8";

    internal Class1036()
    {
        this.byte_0 = new byte[] { 0x89, 80, 0x4e, 0x47, 13, 10, 0x1a, 10 };
        this.byte_1 = new byte[] { 0xff, 0xd8 };
        this.byte_2 = new byte[] { 0x42, 0x4d };
        this.byte_3 = new byte[] { 0x49, 0x49 };
        this.byte_4 = new byte[] { 0x4d, 0x4d };
    }

    public Class1036(Stream A_0)
    {
        int num = 15;
        this.byte_0 = new byte[] { 0x89, 80, 0x4e, 0x47, 13, 10, 0x1a, 10 };
        this.byte_1 = new byte[] { 0xff, 0xd8 };
        this.byte_2 = new byte[] { 0x42, 0x4d };
        this.byte_3 = new byte[] { 0x49, 0x49 };
        this.byte_4 = new byte[] { 0x4d, 0x4d };
        if (!A_0.CanRead || !A_0.CanSeek)
        {
            throw new ArgumentException(BookmarkStart.b("昴䌶䬸帺尼刾", num));
        }
        this.stream_0 = A_0;
        this.method_8();
        if (this.imageFormat_0 == ImageFormat.Unknown)
        {
            throw new ArgumentException(BookmarkStart.b("愴弶尸ᬺ吼刾⁀⑂⁄杆㩈㽊㽌⩎ぐ㹒畔㑖㡘㕚㍜ぞᕠ䍢ݤɦ䥨ᡪᡬὮŰᱲݴͶᱸὺ卼", num));
        }
    }

    public int method_0()
    {
        return this.int_2;
    }

    public int method_1()
    {
        return this.int_1;
    }

    private bool method_10()
    {
        this.method_30();
        for (int i = 0; i < this.byte_2.Length; i++)
        {
            if (this.byte_2[i] != this.stream_0.ReadByte())
            {
                return false;
            }
        }
        return true;
    }

    private void method_11()
    {
        this.method_30();
        byte[] buffer = new byte[14];
        this.stream_0.Read(buffer, 0, 14);
        this.method_24();
        this.int_2 = this.method_24();
        this.int_1 = this.method_24();
    }

    private bool method_12()
    {
        this.method_30();
        int num = this.method_27();
        int num2 = this.method_27();
        return ((num == 0) && (num2 == 1));
    }

    private bool method_13()
    {
        this.method_30();
        for (int i = 0; i < this.byte_0.Length; i++)
        {
            if (this.byte_0[i] != this.stream_0.ReadByte())
            {
                return false;
            }
        }
        return true;
    }

    private bool method_14()
    {
        this.method_30();
        for (int i = 0; i < this.byte_1.Length; i++)
        {
            if (this.byte_1[i] != this.stream_0.ReadByte())
            {
                return false;
            }
        }
        return true;
    }

    private bool method_15()
    {
        this.method_30();
        return this.method_29(6).StartsWith(BookmarkStart.b("琲簴然ĸ", 13));
    }

    private bool method_16()
    {
        this.method_30();
        if (this.method_24() == 1)
        {
            this.imageFormat_0 = ImageFormat.Emf;
            return true;
        }
        this.method_30();
        if (this.method_24() == -1698247209)
        {
            this.imageFormat_0 = ImageFormat.Wmf;
            return true;
        }
        return false;
    }

    private void method_17()
    {
        this.method_30();
        Bitmap bitmap = new Bitmap(this.stream_0);
        this.int_2 = bitmap.Width;
        this.int_1 = bitmap.Height;
    }

    private void method_18()
    {
        this.method_30();
        Bitmap bitmap = new Bitmap(this.stream_0);
        this.int_2 = bitmap.Width;
        this.int_1 = bitmap.Height;
    }

    private void method_19()
    {
        this.int_2 = this.method_26();
        this.int_1 = this.method_26();
    }

    public ImageFormat method_2()
    {
        return this.imageFormat_0;
    }

    private void method_20()
    {
        this.method_30();
        byte[] buffer = new byte[6];
        this.stream_0.Read(buffer, 0, buffer.Length);
        this.int_2 = this.stream_0.ReadByte();
        this.int_1 = this.stream_0.ReadByte();
    }

    private void method_21()
    {
        byte[] buffer;
        this.method_30();
        if (this.imageFormat_0 == ImageFormat.Emf)
        {
            buffer = new byte[0x10];
            this.stream_0.Read(buffer, 0, buffer.Length);
            this.int_2 = this.method_24();
            this.int_1 = this.method_24();
        }
        else if (this.method_2() == ImageFormat.Wmf)
        {
            buffer = new byte[10];
            this.stream_0.Read(buffer, 0, buffer.Length);
            this.int_2 = this.method_28();
            this.int_1 = this.method_28();
        }
    }

    private void method_22()
    {
        int num = 15;
        int num2 = 0x100;
        int num3 = 0x101;
        this.stream_0.Position = 4L;
        int num4 = this.method_24();
        if (num4 > this.stream_0.Length)
        {
            throw new Exception(BookmarkStart.b("愴帶弸崺ᴼ嘾ⱀ≂≄≆楈ⵊ⑌⍎㑐獒㙔㡖⭘⥚⡜⽞ᕠ٢Ť", num));
        }
        this.stream_0.Position = num4 + 2;
        while (num4 < this.stream_0.Length)
        {
            int num5 = this.method_26();
            this.method_26();
            this.method_24();
            int num6 = this.method_24();
            if (num5 == num2)
            {
                this.int_2 = num6;
            }
            else
            {
                if (num5 == num3)
                {
                    this.int_1 = num6;
                    continue;
                }
                if (this.int_1 != 0)
                {
                    return;
                }
            }
        }
    }

    private int method_23()
    {
        byte[] buffer = new byte[4];
        this.stream_0.Read(buffer, 0, 4);
        return ((((buffer[0] << 0x18) + (buffer[1] << 0x10)) + (buffer[2] << 8)) + buffer[3]);
    }

    private int method_24()
    {
        byte[] buffer = new byte[4];
        this.stream_0.Read(buffer, 0, 4);
        return (((buffer[0] + (buffer[1] << 8)) + (buffer[2] << 0x10)) + (buffer[3] << 0x18));
    }

    private int method_25()
    {
        byte[] buffer = new byte[2];
        this.stream_0.Read(buffer, 0, 2);
        return ((buffer[0] << 8) + buffer[1]);
    }

    private int method_26()
    {
        byte[] buffer = new byte[2];
        this.stream_0.Read(buffer, 0, 2);
        return (buffer[0] | (buffer[1] << 8));
    }

    private int method_27()
    {
        return ((this.stream_0.ReadByte() + (this.stream_0.ReadByte() << 8)) & 0xffff);
    }

    private int method_28()
    {
        int num = this.method_27();
        if (num > 0x7fff)
        {
            num -= 0x10000;
        }
        return num;
    }

    private string method_29(int A_0)
    {
        char[] chArray = new char[A_0];
        for (int i = 0; i < A_0; i++)
        {
            chArray[i] = (char) this.stream_0.ReadByte();
        }
        return new string(chArray);
    }

    public Size method_3()
    {
        return new Size(this.int_2, this.int_1);
    }

    private void method_30()
    {
        this.stream_0.Position = 0L;
    }

    internal void method_31(MemoryStream A_0, ImageFormat A_1)
    {
    }

    internal byte[] method_4()
    {
        return this.byte_5;
    }

    public ImageFormat method_5()
    {
        return this.imageFormat_0;
    }

    public float method_6()
    {
        return this.float_0;
    }

    public bool method_7()
    {
        if ((this.method_5() != ImageFormat.Emf) && (this.method_5() != ImageFormat.Wmf))
        {
            return false;
        }
        return true;
    }

    private void method_8()
    {
        if (this.method_13())
        {
            this.imageFormat_0 = ImageFormat.Png;
            this.method_17();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_14())
        {
            this.imageFormat_0 = ImageFormat.Jpeg;
            this.method_18();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_15())
        {
            this.imageFormat_0 = ImageFormat.Gif;
            this.method_19();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_16())
        {
            this.method_21();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_12())
        {
            this.imageFormat_0 = ImageFormat.Icon;
            this.method_20();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_10())
        {
            this.imageFormat_0 = ImageFormat.Bmp;
            this.method_11();
        }
        if ((this.imageFormat_0 == ImageFormat.Unknown) && this.method_9())
        {
            this.imageFormat_0 = ImageFormat.Tiff;
            this.method_22();
        }
        if (this.imageFormat_0 != ImageFormat.Unknown)
        {
            this.method_30();
            this.byte_5 = new byte[this.stream_0.Length];
            this.stream_0.Read(this.byte_5, 0, this.byte_5.Length);
        }
    }

    private bool method_9()
    {
        this.method_30();
        byte[] buffer = new byte[3];
        this.stream_0.Read(buffer, 0, buffer.Length);
        return ((((buffer[0] == this.byte_3[0]) && (buffer[1] == this.byte_3[1])) || ((buffer[0] == this.byte_4[0]) && (buffer[1] == this.byte_4[1]))) && (buffer[2] == 0x2a));
    }

    internal static Class1036 smethod_0(MemoryStream A_0)
    {
        return new Class1036(A_0);
    }

    void IDisposable.Dispose()
    {
        this.byte_5 = null;
        if (this.stream_0 != null)
        {
            this.stream_0.Dispose();
            this.stream_0 = null;
        }
    }
}

