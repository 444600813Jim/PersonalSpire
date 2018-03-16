using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

internal class Class377
{
    internal static void smethod_0(sprᮃ A_0, SizeF A_1, Stream A_2, ImageFormat A_3, Class378 A_4)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伭䀯䄱", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷", num));
        }
        switch (A_3)
        {
            case ImageFormat.Bmp:
            {
                using (spr⊗ r⊗ = smethod_1(A_0, A_1, A_4))
                {
                    r⊗.ᜂ(A_2);
                    return;
                }
            }
            case ImageFormat.Emf:
            case ImageFormat.Wmf:
                smethod_2(A_0, A_1, A_4, A_2);
                return;

            case ImageFormat.Jpeg:
            {
                using (spr⊗ r⊗3 = smethod_1(A_0, A_1, A_4))
                {
                    r⊗3.ᜀ(A_2, A_4.method_7());
                    return;
                }
            }
            case ImageFormat.Png:
            {
                using (spr⊗ r⊗2 = smethod_1(A_0, A_1, A_4))
                {
                    r⊗2.ᜁ(A_2);
                    return;
                }
            }
            case ImageFormat.Tiff:
                using (spr⊗ r⊗4 = smethod_1(A_0, A_1, A_4))
                {
                    r⊗4.ᜀ(A_2, A_4.method_6());
                }
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("笭帯圱䰳䘵崷夹䠻嬽␿扁ⵃ⭅⥇ⵉ⥋湍⍏㍑≓㍕硗㱙㍛ⱝൟ͡ၣ䙥ᩧཀྵᵫ᭭ᕯűs፵ᱷ呹", num));
    }

    internal static spr⊗ smethod_1(sprᮃ A_0, SizeF A_1, Class378 A_2)
    {
        Size size = Class969.smethod_5(A_1, A_2.method_0(), (double) A_2.method_1());
        spr⊗ r⊗ = new spr⊗(size.Width, size.Height, A_2.method_1(), A_2.method_1(), A_2.method_5());
        using (spr⤿ r⤿ = new spr⤿(r⊗))
        {
            smethod_3(A_0, r⤿, size, A_2);
        }
        r⊗.ᜀ(new spr⇼(A_2.method_2(), A_2.method_3(), A_2.method_4()));
        return r⊗;
    }

    private static void smethod_2(sprᮃ A_0, SizeF A_1, Class378 A_2, Stream A_3)
    {
        int num = 12;
        Bitmap bitmap = null;
        Graphics graphics = null;
        IntPtr zero = IntPtr.Zero;
        Metafile metafile = null;
        try
        {
            bitmap = new Bitmap(1, 1);
            bitmap.SetResolution(96f, 96f);
            graphics = spr᪻.ᜀ(bitmap);
            zero = graphics.GetHdc();
            Size size = Class969.smethod_5(A_1, A_2.method_0(), 96.0);
            metafile = new Metafile(A_3, zero, new RectangleF(0f, 0f, (float) size.Width, (float) size.Height), MetafileFrameUnit.Pixel, A_2.method_8());
            using (spr⤿ r⤿ = new spr⤿(metafile))
            {
                smethod_3(A_0, r⤿, size, A_2);
            }
        }
        finally
        {
            if (metafile != null)
            {
                metafile.Dispose();
            }
            if ((zero != IntPtr.Zero) && (graphics != null))
            {
                graphics.ReleaseHdc(zero);
            }
            if (graphics != null)
            {
                graphics.Dispose();
            }
            if (bitmap != null)
            {
                bitmap.Dispose();
            }
        }
        if (A_3 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱䀳䐵崷嬹儻", num));
        }
    }

    private static void smethod_3(sprᮃ A_0, spr⤿ A_1, Size A_2, Class378 A_3)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刲䔴䐶", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吲匴伶", num));
        }
        A_1.ᜅ();
        if (A_3.method_9())
        {
            A_1.ᜀ();
        }
        if (A_3.method_11())
        {
            A_1.ᜃ();
        }
        A_1.ᜀ(A_3.method_13(), 0f, 0f, (float) A_2.Width, (float) A_2.Height);
        A_1.ᜀ(A_3.method_0());
        new Class450().method_0(A_0, A_1.ᜆ());
    }
}

