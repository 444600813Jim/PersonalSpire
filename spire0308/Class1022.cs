using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Pdf.General.Paper.Base;
using Spire.Pdf.General.Paper.Drawing.Images;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

internal class Class1022
{
    internal static bool smethod_0(SizeF A_0)
    {
        if (A_0.Width != 0f)
        {
            return (A_0.Height == 0f);
        }
        return true;
    }

    internal static bool smethod_1(ShapeObject A_0)
    {
        ShapeType shapeType = A_0.ShapeType;
        if (((shapeType != ShapeType.OleObject) && (shapeType != ShapeType.Image)) && (shapeType != ShapeType.OleControl))
        {
            return false;
        }
        return true;
    }

    internal static LineJoin smethod_2(StrokeJoinStyle A_0)
    {
        switch (A_0)
        {
            case StrokeJoinStyle.Bevel:
                return LineJoin.Bevel;

            case StrokeJoinStyle.Miter:
                return LineJoin.Miter;

            case StrokeJoinStyle.Round:
                return LineJoin.Round;
        }
        throw new ArgumentOutOfRangeException();
    }

    internal static LineCap smethod_3(StrokeEndCap A_0)
    {
        switch (A_0)
        {
            case StrokeEndCap.Flat:
                return LineCap.Flat;

            case StrokeEndCap.Round:
                return LineCap.Round;

            case StrokeEndCap.Square:
                return LineCap.Square;
        }
        throw new ArgumentOutOfRangeException();
    }

    internal static DashCap smethod_4(StrokeEndCap A_0)
    {
        switch (A_0)
        {
            case StrokeEndCap.Flat:
            case StrokeEndCap.Square:
                return DashCap.Flat;

            case StrokeEndCap.Round:
                return DashCap.Round;
        }
        throw new ArgumentOutOfRangeException();
    }

    internal static byte[] smethod_5(DocPicture A_0)
    {
        byte[] imageBytes = A_0.ImageBytes;
        spr⇼ r⇼ = smethod_7(A_0);
        if (!r⇼.ᜀ())
        {
            if (!A_0.ImageRecord.method_15())
            {
                return imageBytes;
            }
            ImageSize size = new ImageSize(((int) A_0.Size.Width) * 0x319c, ((int) A_0.Size.Height) * 0x319c);
            if (spr≨.ᜀ(size.WidthPixels, size.HeightPixels))
            {
                return imageBytes;
            }
            ImageFormat png = Class409.smethod_0(A_0.ImageRecord.method_3());
            switch (Class783.smethod_1(png))
            {
                case BlipImageType.Emf:
                case BlipImageType.Wmf:
                    imageBytes = spr᪻.ᜀ(imageBytes, new SizeF((float) size.HorizontalResolution, (float) size.VerticalResolution));
                    png = ImageFormat.Png;
                    break;
            }
            using (spr⊗ r⊗ = new spr⊗(imageBytes))
            {
                r⊗.ᜀ(r⇼);
                using (MemoryStream stream = new MemoryStream())
                {
                    r⊗.ᜀ(stream, smethod_6(png));
                    imageBytes = sprḆ.ᜀ(stream);
                }
            }
        }
        return imageBytes;
    }

    private static FileFormat smethod_6(ImageFormat A_0)
    {
        switch (A_0)
        {
            case ImageFormat.Jpeg:
                return 5;

            case ImageFormat.Png:
                return 6;

            case ImageFormat.Tiff:
                return 8;
        }
        return 7;
    }

    private static spr⇼ smethod_7(DocPicture A_0)
    {
        ImageColorModeCore core = 0;
        if (A_0.BiLevel)
        {
            core = 2;
        }
        else if (A_0.GrayScale)
        {
            core = 1;
        }
        float num = (float) Class1077.smethod_0((double) Class969.smethod_69((int) A_0.GetShapeAttribute(0x109)));
        return new spr⇼(core, num, (float) Class1077.smethod_2((double) Class969.smethod_69((int) A_0.GetShapeAttribute(0x108))));
    }
}

