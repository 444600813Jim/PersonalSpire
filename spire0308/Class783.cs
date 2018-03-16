using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.IO;

internal class Class783
{
    private readonly Document document_0;
    private ImageSize imageSize_0;
    private static int int_0;
    private readonly Interface7 interface7_0;
    private static string string_0;

    internal Class783(Document A_0, Interface7 A_1)
    {
        this.document_0 = A_0;
        this.interface7_0 = A_1;
    }

    internal void method_0(Image A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伥䔧䬩䬫䬭", num));
        }
        using (MemoryStream stream = new MemoryStream())
        {
            spr⊗.ᜀ(A_0, stream);
            this.method_1(stream);
        }
    }

    internal void method_1(Stream A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨸伺似娾⁀⹂", num));
        }
        this.method_17(Class567.smethod_10(A_0));
    }

    internal byte[] method_10()
    {
        return this.method_11(this.interface7_0.imethod_0());
    }

    internal byte[] method_11(string A_0)
    {
        return this.method_12(A_0);
    }

    private byte[] method_12(string A_0)
    {
        byte[] buffer = null;
        try
        {
            using (Stream stream = Class1040.smethod_1(A_0))
            {
                buffer = Class567.smethod_10(stream);
            }
        }
        catch
        {
        }
        return buffer;
    }

    private byte[] method_13()
    {
        byte[] buffer = this.method_10();
        if (buffer == null)
        {
            return Class567.smethod_14();
        }
        return buffer;
    }

    internal string method_14()
    {
        return this.interface7_0.imethod_0();
    }

    internal void method_15(string A_0)
    {
        this.interface7_0.imethod_1(A_0);
    }

    internal byte[] method_16()
    {
        return this.interface7_0.imethod_2();
    }

    internal void method_17(byte[] A_0)
    {
        this.imageSize_0 = null;
        if (!Class85.smethod_19(A_0))
        {
            this.interface7_0.imethod_3(null);
        }
        else
        {
            this.interface7_0.imethod_3(smethod_0(A_0));
        }
    }

    internal bool method_18()
    {
        if (!this.method_23())
        {
            return this.method_21();
        }
        return true;
    }

    internal ImageSize method_19()
    {
        if (this.imageSize_0 == null)
        {
            this.imageSize_0 = this.method_23() ? new ImageSize(Class409.smethod_9(this.method_16())) : new ImageSize(0, 0);
        }
        return this.imageSize_0;
    }

    internal void method_2(string A_0)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("弸刺儼娾ཀ≂⡄≆", 0x13));
        this.method_17(this.method_11(A_0));
    }

    internal BlipImageType method_20()
    {
        return smethod_1(this.method_24());
    }

    internal bool method_21()
    {
        return Class567.smethod_16(this.interface7_0.imethod_0());
    }

    internal bool method_22()
    {
        return (this.method_21() && !this.method_23());
    }

    internal bool method_23()
    {
        return Class85.smethod_19(this.method_16());
    }

    internal ImageFormat method_24()
    {
        if (this.method_23())
        {
            return Class409.smethod_0(this.method_16());
        }
        if (this.method_21() && (this.interface7_0.imethod_0().Length > 0))
        {
            return Class409.smethod_6(this.interface7_0.imethod_0());
        }
        return ImageFormat.Unknown;
    }

    internal Image method_3()
    {
        return spr⊗.ᜀ(this.method_4());
    }

    internal Stream method_4()
    {
        byte[] buffer = this.method_16();
        if (Class85.smethod_19(buffer))
        {
            return new MemoryStream(buffer);
        }
        try
        {
            return new MemoryStream(this.method_11(this.interface7_0.imethod_0()));
        }
        catch (Exception)
        {
            return Class567.smethod_13();
        }
    }

    internal byte[] method_5()
    {
        byte[] buffer = this.method_16();
        if (!Class85.smethod_19(buffer))
        {
            return this.method_13();
        }
        return buffer;
    }

    internal void method_6(Stream A_0)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶䴸䤺堼帾ⱀ", num));
        }
        using (Stream stream = this.method_4())
        {
            Class567.smethod_8(stream, A_0);
        }
    }

    internal void method_7(string A_0)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("䴪䐬䌮吰紲吴娶尸", 5));
        using (Stream stream = File.Create(A_0))
        {
            this.method_6(stream);
        }
    }

    internal void method_8(byte[] A_0)
    {
        try
        {
            if (string_0 != null)
            {
                this.method_9(A_0);
            }
            this.method_17(A_0);
        }
        catch
        {
        }
    }

    private void method_9(byte[] A_0)
    {
        int num = 6;
        try
        {
            if (!Directory.Exists(string_0))
            {
                Directory.CreateDirectory(string_0);
            }
            using (Stream stream = File.Create(string.Concat(new object[] { string_0, Path.DirectorySeparatorChar, Path.GetFileName(this.document_0.FileName), BookmarkStart.b("ȫ", num), ++int_0, BookmarkStart.b("ȫ", num), Class238.smethod_3(Class409.smethod_0(A_0)) })))
            {
                stream.Write(A_0, 0, A_0.Length);
                stream.Flush();
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    internal static byte[] smethod_0(byte[] A_0)
    {
        if (smethod_2(A_0))
        {
            if (Class409.smethod_50(A_0))
            {
                A_0 = Class409.smethod_29(A_0, Class409.smethod_25(A_0));
            }
            return A_0;
        }
        using (spr⊗ r⊗ = new spr⊗(A_0))
        {
            using (MemoryStream stream = new MemoryStream())
            {
                r⊗.ᜀ(stream, 6);
                A_0 = Class567.smethod_10(stream);
            }
        }
        return A_0;
    }

    internal static BlipImageType smethod_1(ImageFormat A_0)
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

    private static bool smethod_2(byte[] A_0)
    {
        return smethod_3(Class409.smethod_0(A_0));
    }

    private static bool smethod_3(ImageFormat A_0)
    {
        switch (A_0)
        {
            case ImageFormat.Emf:
            case ImageFormat.Jpeg:
            case ImageFormat.Png:
            case ImageFormat.Wmf:
            case ImageFormat.MacPICT:
                return true;
        }
        return false;
    }

    internal static void smethod_4(string A_0)
    {
        string_0 = A_0;
    }
}

