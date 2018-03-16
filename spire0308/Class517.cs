using Spire.Doc;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;

internal class Class517
{
    private bool bool_0;
    internal static readonly byte[] byte_0 = new byte[] { 
        0x49, 0, 0x6d, 0, 0x67, 0, 0x48, 0, 0x61, 0, 0x73, 0, 0x68, 0, 0x4b, 0, 
        0x65, 0, 0x79, 0
     };
    internal byte[] byte_1;
    private Document document_0;
    private ImageFormat imageFormat_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private Size size_0;

    internal Class517(byte[] A_0)
    {
        this.size_0 = new Size(-2147483648, -2147483648);
        this.int_2 = -2147483648;
        this.byte_1 = A_0;
        Image image = this.method_19(this.byte_1);
        if (image != null)
        {
            if (image is Metafile)
            {
                this.bool_0 = true;
            }
            image.Dispose();
        }
    }

    internal Class517(Document A_0, byte[] A_1)
    {
        this.size_0 = new Size(-2147483648, -2147483648);
        this.int_2 = -2147483648;
        this.document_0 = A_0;
        this.byte_1 = A_1;
        Image image = this.method_19(this.byte_1);
        if (image != null)
        {
            if (image is Metafile)
            {
                this.bool_0 = true;
            }
            image.Dispose();
        }
    }

    internal int method_0()
    {
        return this.int_0;
    }

    internal void method_1(int A_0)
    {
        this.int_0 = A_0;
    }

    internal void method_10(Size A_0)
    {
        this.size_0 = A_0;
    }

    internal ImageFormat method_11()
    {
        if (this.imageFormat_0 == null)
        {
            this.method_18(this.method_19(this.method_3()));
        }
        return this.imageFormat_0;
    }

    internal void method_12(ImageFormat A_0)
    {
        this.imageFormat_0 = A_0;
    }

    internal int method_13()
    {
        if (this.int_2 == -2147483648)
        {
            this.int_2 = this.method_3().Length;
        }
        return this.int_2;
    }

    internal void method_14(int A_0)
    {
        this.int_2 = A_0;
    }

    internal bool method_15()
    {
        if ((!this.method_11().Equals(ImageFormat.Png) && !this.method_11().Equals(ImageFormat.Bmp)) && !this.method_11().Equals(ImageFormat.MemoryBmp))
        {
            return this.method_11().Equals(ImageFormat.Jpeg);
        }
        return true;
    }

    internal Class517 method_16()
    {
        Class517 class2 = (Class517) base.MemberwiseClone();
        class2.byte_1 = (byte[]) this.byte_1.Clone();
        return class2;
    }

    internal void method_17()
    {
        this.byte_1 = null;
        this.int_0 = 0;
        this.int_1 = 0;
    }

    internal void method_18(Image A_0)
    {
        if (A_0 != null)
        {
            this.size_0 = A_0.Size;
            this.imageFormat_0 = A_0.RawFormat;
            A_0.Dispose();
        }
    }

    private Image method_19(byte[] A_0)
    {
        if (A_0 != null)
        {
            this.int_2 = A_0.Length;
            return smethod_0(A_0);
        }
        return null;
    }

    internal bool method_2()
    {
        return Class85.smethod_19(this.method_3());
    }

    internal byte[] method_3()
    {
        if (this.bool_0 && (this.document_0 != null))
        {
            return this.document_0.Images.method_9(this.byte_1);
        }
        return this.byte_1;
    }

    internal byte[] method_4()
    {
        if (this.byte_1 != null)
        {
            HMACSHA1 hmacsha = new HMACSHA1 {
                Key = byte_0
            };
            return hmacsha.ComputeHash(this.byte_1);
        }
        return null;
    }

    internal int method_5()
    {
        return this.int_1;
    }

    internal void method_6(int A_0)
    {
        this.int_1 = A_0;
        if (this.int_1 == 0)
        {
            if (this.document_0 != null)
            {
                this.document_0.Images.method_3(this.int_0);
            }
            this.method_17();
        }
    }

    internal bool method_7()
    {
        return this.bool_0;
    }

    internal void method_8(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal Size method_9()
    {
        if ((this.size_0.Width == -2147483648) || (this.size_0.Height == -2147483648))
        {
            this.method_18(this.method_19(this.method_3()));
        }
        return this.size_0;
    }

    internal static Image smethod_0(byte[] A_0)
    {
        Image image = null;
        if (A_0 != null)
        {
            try
            {
                image = Image.FromStream(new MemoryStream(A_0), true, false);
                A_0 = null;
            }
            catch
            {
            }
        }
        return image;
    }
}

