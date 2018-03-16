using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.IO;
using System.Text;

internal class Class369 : Class364
{
    private Class370 class370_0;
    private const int int_0 = 0x5d;
    private const int int_1 = 400;
    private const int int_2 = 40;
    private int int_3;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private const uint uint_0 = 0x71b239f4;
    private uint uint_1;

    internal Class369(OleObjectType A_0)
    {
        int num = 2;
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.uint_1 = 0x71b239f4;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        this.class370_0 = new Class370();
        switch (A_0)
        {
            case OleObjectType.AdobeAcrobatDocument:
                this.string_0 = BookmarkStart.b("椧䤩師䄭刯匱䀳ᘵ簷唹弻䬽ⴿ❁⩃㉅䡇", num);
                this.string_2 = BookmarkStart.b("椧䤩師䄭甯䨱圳帵ᘷ縹医崽㔿⽁⅃⡅㱇摉筋乍", num);
                return;

            case OleObjectType.BitmapImage:
            case OleObjectType.MediaClip:
            case OleObjectType.Equation:
            case OleObjectType.GraphChart:
            case OleObjectType.Excel_97_2003_Worksheet:
            case OleObjectType.ExcelBinaryWorksheet:
            case OleObjectType.ExcelChart:
            case OleObjectType.ExcelMacroWorksheet:
            case OleObjectType.ExcelWorksheet:
            case OleObjectType.PowerPoint_97_2003_Presentation:
            case OleObjectType.PowerPoint_97_2003_Slide:
            case OleObjectType.PowerPointMacroPresentation:
            case OleObjectType.PowerPointMacroSlide:
            case OleObjectType.PowerPointPresentation:
            case OleObjectType.PowerPointSlide:
            case OleObjectType.Word_97_2003_Document:
            case OleObjectType.WordDocument:
            case OleObjectType.WordMacroDocument:
            case OleObjectType.MIDISequence:
            case OleObjectType.Package:
            case OleObjectType.VideoClip:
            case OleObjectType.VisioDrawing_2013:
                this.string_0 = Class1117.smethod_1(A_0, true) + BookmarkStart.b("⠧", num);
                break;

            case OleObjectType.VisioDrawing:
            case OleObjectType.OpenDocumentPresentation:
            case OleObjectType.OpenDocumentSpreadsheet:
            case OleObjectType.OpenDocumentText:
            case OleObjectType.OpenOfficeSpreadsheet1_1:
            case OleObjectType.OpenOfficeText_1_1:
            case OleObjectType.WordPadDocument:
            case OleObjectType.OpenOfficeSpreadsheet:
            case OleObjectType.OpenOfficeText:
                break;

            case OleObjectType.WaveSound:
                this.string_0 = BookmarkStart.b("缧䬩娫䬭ု愱嬳䌵嘷帹㰻", num);
                this.string_2 = BookmarkStart.b("笧䔩夫䀭启怱儳唵㠷", num);
                return;

            default:
                return;
        }
    }

    internal Class369(Stream1 A_0)
    {
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.uint_1 = 0x71b239f4;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.string_5 = string.Empty;
        byte[] buffer = new byte[A_0.Length];
        A_0.Read(buffer, 0, buffer.Length);
        this.vmethod_0(buffer, 0);
    }

    internal string method_0()
    {
        if (!string.IsNullOrEmpty(this.string_2))
        {
            return this.string_2;
        }
        return this.string_0;
    }

    internal string method_1()
    {
        return this.string_2;
    }

    internal void method_2(Stream12 A_0)
    {
        this.class370_0.method_0(A_0);
        this.method_4(A_0, this.string_0);
        this.method_4(A_0, this.string_1);
        this.method_4(A_0, this.string_2);
        this.method_3(A_0, 4);
        this.method_3(A_0, 4);
        this.method_3(A_0, 4);
        this.method_3(A_0, 4);
    }

    private void method_3(Stream12 A_0, int A_1)
    {
        byte[] buffer = new byte[A_1];
        A_0.Write(buffer, 0, A_1);
    }

    private void method_4(Stream12 A_0, string A_1)
    {
        byte[] buffer = new byte[4];
        ASCIIEncoding encoding = new ASCIIEncoding();
        int num = 0;
        byte[] bytes = encoding.GetBytes(A_1);
        Class364.smethod_8(buffer, ref num, bytes.Length);
        A_0.Write(buffer, 0, buffer.Length);
        if (bytes.Length > 0)
        {
            A_0.Write(bytes, 0, bytes.Length);
        }
    }

    internal override void vmethod_0(byte[] A_0, int A_1)
    {
        int num = 5;
        this.int_3 = A_0.Length;
        int num2 = 0;
        ASCIIEncoding encoding = new ASCIIEncoding();
        UnicodeEncoding encoding2 = new UnicodeEncoding();
        Encoding encoding3 = Encoding.GetEncoding(0x4e3);
        this.class370_0 = new Class370();
        this.class370_0.vmethod_0(A_0, A_1);
        A_1 += this.class370_0.vmethod_2();
        num2 = Class364.smethod_1(A_0, ref A_1);
        if (num2 > 0)
        {
            byte[] bytes = Class364.smethod_5(A_0, num2, ref A_1);
            this.string_0 = encoding3.GetString(bytes);
        }
        uint num3 = Class364.smethod_4(A_0, ref A_1);
        if (num3 > 0)
        {
            byte[] buffer2 = null;
            switch (num3)
            {
                case uint.MaxValue:
                case 0xfffffffe:
                    buffer2 = Class364.smethod_5(A_0, 4, ref A_1);
                    this.string_0 = encoding.GetString(buffer2);
                    goto Label_00E6;
            }
            if (num3 > 400)
            {
                throw new InvalidDataException(BookmarkStart.b("搪愬樮ᄰ䀲䄴䔶尸娺值Ἶ⡀ⵂ敄⥆♈㽊浌㥎ぐ㽒㱔㍖", num));
            }
            buffer2 = Class364.smethod_5(A_0, (int) num3, ref A_1);
            this.string_1 = encoding3.GetString(buffer2);
        }
    Label_00E6:
        num2 = Class364.smethod_1(A_0, ref A_1);
        if ((num2 > 0) && (num2 <= 40))
        {
            byte[] buffer4 = Class364.smethod_5(A_0, num2, ref A_1);
            this.string_2 = encoding3.GetString(buffer4);
        }
        this.uint_1 = Class364.smethod_4(A_0, ref A_1);
        if (this.uint_1 == 0x71b239f4)
        {
            num2 = Class364.smethod_1(A_0, ref A_1);
            if (num2 > 0)
            {
                byte[] buffer6 = Class364.smethod_5(A_0, num2, ref A_1);
                this.string_3 = encoding2.GetString(buffer6);
            }
            num3 = Class364.smethod_4(A_0, ref A_1);
            if (num3 > 0)
            {
                if ((num3 != uint.MaxValue) && (num3 != 0xfffffffe))
                {
                    if (num3 > 400)
                    {
                        throw new InvalidDataException(BookmarkStart.b("搪愬樮ᄰ䀲䄴䔶尸娺值Ἶ⡀ⵂ敄⥆♈㽊浌㥎ぐ㽒㱔㍖", num));
                    }
                }
                else
                {
                    byte[] buffer5 = Class364.smethod_5(A_0, 4, ref A_1);
                    this.string_4 = encoding2.GetString(buffer5);
                }
            }
            num2 = Class364.smethod_1(A_0, ref A_1);
            if ((num2 > 0) && (num2 <= 40))
            {
                byte[] buffer3 = Class364.smethod_5(A_0, num2, ref A_1);
                this.string_5 = encoding2.GetString(buffer3);
            }
        }
    }

    internal override int vmethod_1(byte[] A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("缰尲䄴᜶倸嘺䴼匾⑀⹂⁄⥆㵈⹊⥌", 11));
    }

    internal override int vmethod_2()
    {
        if (this.int_3 == 0)
        {
            this.int_3 = 0x5d;
        }
        return this.int_3;
    }

    private class Class370 : Class364
    {
        internal byte[] byte_0 = new byte[20];
        internal const int int_0 = 0x1c;
        internal const int int_1 = 20;
        internal int int_2 = -131071;
        internal int int_3 = 0xa03;

        internal Class370()
        {
        }

        internal void method_0(Stream12 A_0)
        {
            byte[] bytes = BitConverter.GetBytes(this.int_2);
            A_0.Write(bytes, 0, 4);
            bytes = BitConverter.GetBytes(this.int_3);
            A_0.Write(bytes, 0, 4);
            if (this.byte_0 == null)
            {
                A_0.Write(new byte[20], 0, 20);
            }
            else
            {
                A_0.Write(this.byte_0, 0, 20);
            }
        }

        internal override void vmethod_0(byte[] A_0, int A_1)
        {
            this.int_2 = Class364.smethod_1(A_0, ref A_1);
            this.int_3 = Class364.smethod_1(A_0, ref A_1);
            this.byte_0 = Class364.smethod_5(A_0, 20, ref A_1);
        }

        internal override int vmethod_1(byte[] A_0, int A_1)
        {
            Class364.smethod_8(A_0, ref A_1, -131071);
            Class364.smethod_8(A_0, ref A_1, 0xa03);
            this.byte_0 = new byte[] { 
                0xff, 0xff, 0xff, 0xff, 0x65, 0xca, 1, 0xb8, 0xfc, 0xa1, 0xd0, 0x11, 0x85, 0xad, 0x44, 0x45, 
                0x53, 0x54, 0, 0
             };
            Class364.smethod_11(A_0, ref A_1, this.byte_0);
            return A_1;
        }

        internal override int vmethod_2()
        {
            return 0x1c;
        }
    }
}

