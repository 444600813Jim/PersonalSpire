using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class371 : Class364
{
    private byte[] byte_0;
    private const int int_0 = 6;

    internal Class371()
    {
    }

    internal Class371(Stream1 A_0)
    {
        byte[] buffer = new byte[A_0.Length];
        A_0.Read(buffer, 0, buffer.Length);
        this.vmethod_0(buffer, 0);
    }

    internal void method_0(Stream12 A_0, OleLinkType A_1, OleObjectType A_2)
    {
        this.byte_0 = smethod_13(A_1, A_2, true);
        A_0.Write(this.byte_0, 0, this.byte_0.Length);
    }

    internal static byte[] smethod_13(OleLinkType A_0, OleObjectType A_1, bool A_2)
    {
        byte[] buffer = new byte[6];
        switch (A_1)
        {
            case OleObjectType.Undefined:
            case OleObjectType.WordPadDocument:
            {
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 2, 3, 0, 13, 0 };
                }
                byte[] buffer6 = new byte[6];
                buffer6[2] = 3;
                buffer6[4] = 4;
                return buffer6;
            }
            case OleObjectType.AdobeAcrobatDocument:
            case OleObjectType.Excel_97_2003_Worksheet:
            case OleObjectType.ExcelBinaryWorksheet:
            case OleObjectType.ExcelMacroWorksheet:
            case OleObjectType.ExcelWorksheet:
            case OleObjectType.PowerPoint_97_2003_Presentation:
            case OleObjectType.PowerPointMacroPresentation:
            case OleObjectType.PowerPointMacroSlide:
            case OleObjectType.PowerPointPresentation:
            case OleObjectType.PowerPointSlide:
            case OleObjectType.WordMacroDocument:
            case OleObjectType.VisioDrawing:
            case OleObjectType.OpenDocumentPresentation:
            case OleObjectType.OpenDocumentSpreadsheet:
            case OleObjectType.OpenOfficeSpreadsheet1_1:
            case OleObjectType.OpenOfficeText_1_1:
            case OleObjectType.OpenOfficeSpreadsheet:
            case OleObjectType.OpenOfficeText:
            case OleObjectType.VisioDrawing_2013:
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 0, 3, 0, 13, 0 };
                }
                if (!A_2)
                {
                    byte[] buffer3 = new byte[6];
                    buffer3[2] = 3;
                    buffer3[4] = 13;
                    return buffer3;
                }
                return new byte[] { 0x40, 0, 3, 0, 4, 0 };

            case OleObjectType.BitmapImage:
            case OleObjectType.MIDISequence:
            case OleObjectType.VideoClip:
            {
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 0, 3, 0, 4, 0 };
                }
                byte[] buffer4 = new byte[6];
                buffer4[2] = 3;
                buffer4[4] = 4;
                return buffer4;
            }
            case OleObjectType.MediaClip:
            case OleObjectType.Package:
            case OleObjectType.WaveSound:
                return new byte[] { 0x40, 0, 3, 0, 4, 0 };

            case OleObjectType.Equation:
                if (A_0 == OleLinkType.Embed)
                {
                    byte[] buffer2 = new byte[6];
                    buffer2[2] = 3;
                    buffer2[4] = 4;
                    buffer = buffer2;
                }
                return buffer;

            case OleObjectType.GraphChart:
            case OleObjectType.ExcelChart:
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 0, 3, 0, 13, 0 };
                }
                return new byte[] { 0, 2, 3, 0, 13, 0 };

            case OleObjectType.PowerPoint_97_2003_Slide:
            case OleObjectType.WordDocument:
            {
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 0, 3, 0, 13, 0 };
                }
                byte[] buffer5 = new byte[6];
                buffer5[2] = 3;
                buffer5[4] = 1;
                return buffer5;
            }
            case OleObjectType.Word_97_2003_Document:
            case OleObjectType.WordPicture:
                if (A_0 != OleLinkType.Embed)
                {
                    return new byte[] { 0x10, 2, 3, 0, 13, 0 };
                }
                return new byte[] { 0, 2, 3, 0, 1, 0 };

            case OleObjectType.OpenDocumentText:
                return buffer;
        }
        return buffer;
    }

    internal override void vmethod_0(byte[] A_0, int A_1)
    {
        this.byte_0 = A_0;
    }

    internal override int vmethod_1(byte[] A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("紲娴䌶ᤸ刺值伾ⵀ♂⡄≆❈㽊⡌⭎", 13));
    }

    internal override int vmethod_2()
    {
        return 6;
    }
}

