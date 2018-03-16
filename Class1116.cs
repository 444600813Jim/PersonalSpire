using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class Class1116
{
    private byte[] byte_0;
    private Class365 class365_0;
    private Class368 class368_0;
    private Class369 class369_0;
    private Class371 class371_0;
    private OleObjectType oleObjectType_0;
    private const string string_0 = "\x0001Ole";
    private const string string_1 = "CONTENTS";
    private const string string_10 = "Equation Native";
    private const string string_11 = "Workbook";
    private const string string_12 = "Package";
    private const string string_13 = "PowerPoint Document";
    private const string string_14 = "WordDocument";
    private const string string_15 = "VisioDocument";
    private const string string_16 = "EmbeddedOdf";
    private const string string_17 = "package_stream";
    private const string string_18 = "\x0005SummaryInformation";
    private const string string_19 = "\x0005DocumentSummaryInformation";
    private const string string_2 = "Contents";
    private const string string_20 = "ObjectPool";
    private string string_21;
    private string string_22;
    private const string string_3 = "\x0003ObjInfo";
    private const string string_4 = "\x0001CompObj";
    private const string string_5 = "\x0003LinkInfo";
    private const string string_6 = "\x0001Ole10Native";
    private const string string_7 = "\x0003EPRINT";
    private const string string_8 = "\x0002OlePres000";
    private const string string_9 = "???";

    internal Class1116()
    {
        this.string_21 = string.Empty;
        this.string_22 = string.Empty;
    }

    internal Class1116(byte[] A_0, string A_1)
    {
        int num = 15;
        this.string_21 = string.Empty;
        this.string_22 = string.Empty;
        if ((A_0 != null) && (A_0.Length != 0))
        {
            if (((A_0.Length > 2) && (A_0[0] == 2)) && (A_0[1] == 0))
            {
                this.byte_0 = this.method_7(A_0);
                this.oleObjectType_0 = OleObjectType.Package;
            }
            else
            {
                MemoryStream stream = new MemoryStream(A_0);
                Class1004 class2 = new Class1004(stream);
                if (class2.Interface51.imethod_0().imethod_7(BookmarkStart.b("稴唶匸帺帼䬾ᅀⱂ⩄⭆", num)))
                {
                    Interface61 interface2 = class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("稴唶匸帺帼䬾ᅀⱂ⩄⭆", num));
                    if (interface2.imethod_7(A_1))
                    {
                        interface2 = interface2.imethod_5(A_1);
                        this.method_4(interface2);
                    }
                }
                else if (class2.Interface51.imethod_0().imethod_7(A_1))
                {
                    Interface61 interface3 = class2.Interface51.imethod_0().imethod_5(A_1);
                    this.method_4(interface3);
                }
                else if (class2.Interface51.imethod_0().imethod_7(BookmarkStart.b("㘴砶嬸儺琼儾❀ⱂ", num)) || class2.Interface51.imethod_0().imethod_7(BookmarkStart.b("㐴砶唸帺", num)))
                {
                    this.method_4(class2.Interface51.imethod_0());
                }
            }
        }
    }

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal OleObjectType method_1()
    {
        if (this.class369_0 != null)
        {
            this.oleObjectType_0 = Class1117.smethod_0(this.class369_0.method_0());
            if (((this.byte_0 != null) && (this.byte_0.Length > 2)) && ((this.byte_0[0] == 0xd0) && (this.byte_0[1] == 0xcf)))
            {
                switch (this.oleObjectType_0)
                {
                    case OleObjectType.ExcelMacroWorksheet:
                    case OleObjectType.ExcelWorksheet:
                        this.oleObjectType_0 = OleObjectType.Excel_97_2003_Worksheet;
                        break;

                    case OleObjectType.PowerPointMacroPresentation:
                    case OleObjectType.PowerPointPresentation:
                        this.oleObjectType_0 = OleObjectType.PowerPoint_97_2003_Presentation;
                        break;

                    case OleObjectType.WordDocument:
                    case OleObjectType.WordMacroDocument:
                        this.oleObjectType_0 = OleObjectType.Word_97_2003_Document;
                        break;
                }
            }
        }
        else
        {
            this.oleObjectType_0 = OleObjectType.Undefined;
        }
        return this.oleObjectType_0;
    }

    private void method_10(BinaryWriter A_0, string A_1)
    {
        A_0.Write(Encoding.Default.GetBytes(A_1));
        A_0.Write((byte) 0);
    }

    internal byte[] method_11(byte[] A_0, string A_1, string A_2, OleLinkType A_3, OleObjectType A_4)
    {
        int num = 10;
        this.string_22 = A_1;
        if (A_4 == OleObjectType.Package)
        {
            this.string_21 = A_1;
        }
        MemoryStream stream = new MemoryStream(A_0);
        Stream12 stream2 = new Stream12(stream, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        Stream12 stream3 = null;
        stream3 = stream2.method_12(BookmarkStart.b("缯倱帳匵嬷丹氻儽⼿⹁", num), STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        Stream12 stream4 = stream3.method_12(A_2, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        this.method_25(stream4, A_3, A_4, A_1);
        this.method_26(stream4, A_3, A_4);
        if (A_3 == OleLinkType.Embed)
        {
            this.byte_0 = File.ReadAllBytes(A_1);
            this.method_22(stream4, A_4);
            this.method_15(stream4, A_1, A_4);
        }
        else
        {
            this.method_24(stream4, A_4, A_1);
        }
        stream3.Flush();
        stream2.Flush();
        MemoryStream stream5 = new MemoryStream();
        stream2.method_17(stream5);
        stream5.Flush();
        byte[] buffer = stream5.ToArray();
        stream5.Close();
        stream2.Close();
        stream2.Dispose();
        stream3.Close();
        stream3.Dispose();
        return buffer;
    }

    internal byte[] method_12(byte[] A_0, byte[] A_1, string A_2, DocOleObject A_3)
    {
        int num = 14;
        MemoryStream stream = new MemoryStream(A_0);
        string str = BookmarkStart.b("欳", 14) + A_3.Interface49.get_OleStorageName();
        if ((A_3.stream_1 != null) && (A_3.OleObjectType == OleObjectType.Undefined))
        {
            return this.method_14(stream, A_3, str);
        }
        Stream12 stream3 = new Stream12(stream, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        Stream12 stream4 = null;
        stream4 = stream3.method_12(BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num), STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        Stream12 stream2 = stream4.method_12(str, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        this.method_25(stream2, A_3.Interface49.get_LinkType(), A_3.OleObjectType, A_2);
        this.method_26(stream2, A_3.Interface49.get_LinkType(), A_3.OleObjectType);
        if (A_3.Interface49.get_LinkType() == OleLinkType.Embed)
        {
            this.byte_0 = A_1;
            this.method_22(stream2, A_3.OleObjectType);
            this.method_15(stream2, A_2, A_3.OleObjectType);
        }
        else
        {
            this.method_24(stream2, A_3.OleObjectType, A_2);
        }
        stream4.Flush();
        stream3.Flush();
        MemoryStream stream5 = new MemoryStream();
        stream3.method_17(stream5);
        stream5.Flush();
        byte[] buffer = stream5.ToArray();
        stream5.Close();
        stream3.Close();
        stream3.Dispose();
        stream4.Close();
        stream4.Dispose();
        return buffer;
    }

    internal byte[] method_13(byte[] A_0, byte[] A_1, DocOleObject A_2)
    {
        MemoryStream stream = new MemoryStream(A_0);
        Stream12 stream2 = new Stream12(stream, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        if (A_2.Interface49.get_LinkType() == OleLinkType.Embed)
        {
            this.method_16(stream2, string.Empty, A_2.OleObjectType, A_1);
            this.method_22(stream2, A_2.OleObjectType);
        }
        else
        {
            this.method_24(stream2, A_2.OleObjectType, string.Empty);
        }
        this.method_26(stream2, A_2.Interface49.get_LinkType(), A_2.OleObjectType);
        MemoryStream stream3 = new MemoryStream();
        stream2.method_17(stream3);
        stream3.Flush();
        byte[] buffer = stream3.ToArray();
        stream3.Close();
        stream2.Close();
        stream2.Dispose();
        return buffer;
    }

    private byte[] method_14(MemoryStream A_0, DocOleObject A_1, string A_2)
    {
        Class1004 class2 = new Class1004(A_0);
        Interface61 interface2 = class2.Interface51.imethod_0().imethod_5(BookmarkStart.b("愭刯報儳唵䰷樹医儽ⰿ", 8));
        Class1004 class3 = new Class1004();
        class3.Interface51.imethod_0().imethod_12(interface2);
        Interface61 interface3 = class3.Interface51.imethod_0().imethod_5(BookmarkStart.b("愭刯報儳唵䰷樹医儽ⰿ", 8));
        if (interface2.imethod_7(A_2))
        {
            interface3 = interface3.imethod_5(A_2);
        }
        else
        {
            interface3 = interface3.imethod_4(A_2);
        }
        class2.System.IDisposable.Dispose();
        foreach (Class297 class5 in class3.Interface51.imethod_1().method_0())
        {
            if (A_1.dictionary_0.ContainsKey(class5.method_0()))
            {
                class5.method_13(A_1.dictionary_0[class5.method_0()]);
            }
        }
        A_1.dictionary_0.Clear();
        Class1004 class4 = new Class1004(A_1.stream_1);
        A_1.stream_1.Position = 0L;
        for (int i = 0; i < class4.Interface51.imethod_0().imethod_9().Length; i++)
        {
            Stream1 stream = class4.Interface51.imethod_0().imethod_0(class4.Interface51.imethod_0().imethod_9()[i]);
            Stream1 stream2 = interface3.imethod_2(class4.Interface51.imethod_0().imethod_9()[i]);
            stream.vmethod_0(stream2);
            stream2.Flush();
            stream2.Close();
            stream.Close();
        }
        class4.System.IDisposable.Dispose();
        class3.Interface51.imethod_2();
        byte[] buffer = (class3.method_4() as MemoryStream).ToArray();
        class3.System.IDisposable.Dispose();
        return buffer;
    }

    private void method_15(Stream12 A_0, string A_1, OleObjectType A_2)
    {
        this.method_16(A_0, A_1, A_2, this.byte_0);
    }

    private void method_16(Stream12 A_0, string A_1, OleObjectType A_2, byte[] A_3)
    {
        int num = 4;
        switch (A_2)
        {
            case OleObjectType.AdobeAcrobatDocument:
                this.method_18(A_0, BookmarkStart.b("椩挫怭搯眱稳戵欷", num), A_3);
                return;

            case OleObjectType.BitmapImage:
                this.method_20(A_0, A_3);
                return;

            case OleObjectType.MediaClip:
            case OleObjectType.MIDISequence:
            case OleObjectType.OpenDocumentText:
            case OleObjectType.VideoClip:
            case OleObjectType.WaveSound:
                break;

            case OleObjectType.Equation:
                this.method_18(A_0, BookmarkStart.b("漩崫嬭儯䘱崳夵嘷ᨹ爻弽㐿⭁㉃⍅", num), A_3);
                return;

            case OleObjectType.GraphChart:
                this.method_18(A_0, BookmarkStart.b("紩䌫尭嬯倱嬳夵匷", num), A_3);
                return;

            case OleObjectType.Excel_97_2003_Worksheet:
            case OleObjectType.ExcelChart:
            case OleObjectType.PowerPoint_97_2003_Presentation:
            case OleObjectType.PowerPoint_97_2003_Slide:
            case OleObjectType.Word_97_2003_Document:
            case OleObjectType.VisioDrawing:
            case OleObjectType.OpenOfficeSpreadsheet1_1:
            case OleObjectType.OpenOfficeText_1_1:
            case OleObjectType.OpenOfficeSpreadsheet:
            case OleObjectType.OpenOfficeText:
            {
                MemoryStream stream = new MemoryStream(A_3);
                this.method_21(A_0, stream);
                return;
            }
            case OleObjectType.ExcelBinaryWorksheet:
            case OleObjectType.ExcelMacroWorksheet:
            case OleObjectType.ExcelWorksheet:
            case OleObjectType.PowerPointMacroPresentation:
            case OleObjectType.PowerPointMacroSlide:
            case OleObjectType.PowerPointPresentation:
            case OleObjectType.PowerPointSlide:
            case OleObjectType.WordDocument:
            case OleObjectType.WordMacroDocument:
            case OleObjectType.VisioDrawing_2013:
                this.method_18(A_0, BookmarkStart.b("稩䴫䴭嬯匱匳匵", num), A_3);
                return;

            case OleObjectType.OpenDocumentPresentation:
            case OleObjectType.OpenDocumentSpreadsheet:
                this.method_18(A_0, BookmarkStart.b("漩䄫䰭唯嘱倳匵尷甹堻堽", num), A_3);
                return;

            case OleObjectType.Package:
                this.method_28(A_0, A_1, A_3);
                break;

            case OleObjectType.WordPadDocument:
                this.method_18(A_0, BookmarkStart.b("椩䌫䀭䐯圱娳䈵䬷", num), A_3);
                return;

            default:
                return;
        }
    }

    private void method_17(Stream12 A_0, string A_1)
    {
        this.method_18(A_0, A_1, this.byte_0);
    }

    private void method_18(Stream12 A_0, string A_1, byte[] A_2)
    {
        A_0.method_15(A_1);
        A_0.Write(A_2, 0, A_2.Length);
        A_0.Close();
    }

    private void method_19(Stream12 A_0)
    {
        this.method_20(A_0, this.byte_0);
    }

    internal string method_2()
    {
        return this.string_21;
    }

    private void method_20(Stream12 A_0, byte[] A_1)
    {
        int num = 0x10;
        int num2 = 0;
        int num3 = (A_1 == null) ? 0 : A_1.Length;
        byte[] buffer = new byte[num3 + 4];
        Class364.smethod_8(buffer, ref num2, num3);
        if (A_1 != null)
        {
            Class364.smethod_11(buffer, ref num2, A_1);
        }
        A_0.method_15(BookmarkStart.b("㜵眷嘹夻༽瀿ు╃㉅ⅇ㱉⥋", num));
        A_0.Write(buffer, 0, buffer.Length);
        A_0.Close();
    }

    private void method_21(Stream12 A_0, Stream A_1)
    {
        Class1004 class2 = new Class1004(A_1);
        string[] strArray = class2.Interface51.imethod_0().imethod_9();
        int index = 0;
        int length = strArray.Length;
        while (true)
        {
            if (index >= length)
            {
                break;
            }
            Stream1 stream = class2.Interface51.imethod_0().imethod_0(strArray[index]);
            A_0.method_15(strArray[index]);
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            A_0.Write(buffer, 0, buffer.Length);
            try
            {
                A_0.Flush();
            }
            catch
            {
            }
            A_0.Close();
            stream.Close();
            index++;
        }
        class2.System.IDisposable.Dispose();
    }

    private void method_22(Stream12 A_0, OleObjectType A_1)
    {
        int num = 1;
        switch (A_1)
        {
            case OleObjectType.AdobeAcrobatDocument:
            case OleObjectType.BitmapImage:
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
            case OleObjectType.VisioDrawing:
            case OleObjectType.OpenDocumentPresentation:
            case OleObjectType.OpenDocumentSpreadsheet:
            case OleObjectType.OpenOfficeSpreadsheet1_1:
            case OleObjectType.OpenOfficeText_1_1:
            case OleObjectType.Package:
            case OleObjectType.OpenOfficeSpreadsheet:
            case OleObjectType.OpenOfficeText:
            case OleObjectType.VisioDrawing_2013:
                if (!this.method_23(A_0.method_1(), BookmarkStart.b("☦樨䐪䀬弮縰儲弴", num)))
                {
                    A_0.method_15(BookmarkStart.b("☦樨䐪䀬弮縰儲弴", num));
                    this.class369_0 = new Class369(A_1);
                    this.class369_0.method_2(A_0);
                    A_0.Close();
                }
                break;

            case OleObjectType.MediaClip:
            case OleObjectType.MIDISequence:
            case OleObjectType.OpenDocumentText:
            case OleObjectType.VideoClip:
            case OleObjectType.WaveSound:
            case OleObjectType.WordPadDocument:
                break;

            default:
                return;
        }
    }

    private bool method_23(string[] A_0, string A_1)
    {
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            if (A_0[index] == A_1)
            {
                return true;
            }
            index++;
        }
        return false;
    }

    private void method_24(Stream12 A_0, OleObjectType A_1, string A_2)
    {
        A_0.method_15(BookmarkStart.b("⼫戭夯就弳缵嘷尹医", 6));
        this.class368_0 = new Class368(A_2);
        this.class368_0.method_0(A_0);
        A_0.Close();
    }

    private void method_25(Stream12 A_0, OleLinkType A_1, OleObjectType A_2, string A_3)
    {
        int num = 4;
        switch (A_2)
        {
            case OleObjectType.AdobeAcrobatDocument:
            case OleObjectType.BitmapImage:
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
            case OleObjectType.PowerPointSlide:
            case OleObjectType.VisioDrawing:
            case OleObjectType.OpenDocumentPresentation:
            case OleObjectType.OpenDocumentSpreadsheet:
            case OleObjectType.OpenOfficeSpreadsheet1_1:
            case OleObjectType.OpenOfficeText_1_1:
            case OleObjectType.Package:
            case OleObjectType.WordPadDocument:
            case OleObjectType.OpenOfficeText:
                A_0.method_15(BookmarkStart.b("⬩挫䈭唯", num));
                this.class365_0 = new Class365(A_1, A_3);
                this.class365_0.method_1(A_0);
                A_0.Close();
                break;

            case OleObjectType.MediaClip:
            case OleObjectType.PowerPointPresentation:
            case OleObjectType.Word_97_2003_Document:
            case OleObjectType.WordDocument:
            case OleObjectType.WordMacroDocument:
            case OleObjectType.MIDISequence:
            case OleObjectType.OpenDocumentText:
            case OleObjectType.VideoClip:
            case OleObjectType.WaveSound:
            case OleObjectType.OpenOfficeSpreadsheet:
                break;

            default:
                return;
        }
    }

    private void method_26(Stream12 A_0, OleLinkType A_1, OleObjectType A_2)
    {
        A_0.method_15(BookmarkStart.b("ⴭ缯倱帳缵嘷尹医", 8));
        this.class371_0 = new Class371();
        this.class371_0.method_0(A_0, A_1, A_2);
        A_0.Close();
    }

    private void method_27(Stream12 A_0, string A_1)
    {
        this.method_28(A_0, A_1, this.byte_0);
    }

    private void method_28(Stream12 A_0, string A_1, byte[] A_2)
    {
        int num = 14;
        if (string.IsNullOrEmpty(A_1))
        {
            A_1 = this.string_22;
        }
        Encoding encoding = Encoding.Default;
        string fileName = Path.GetFileName(A_1);
        byte[] bytes = encoding.GetBytes(fileName);
        byte[] buffer2 = encoding.GetBytes(A_1);
        byte[] buffer3 = new byte[2];
        buffer3[0] = 2;
        byte[] buffer4 = buffer3;
        byte[] buffer5 = new byte[4];
        buffer5[2] = 3;
        byte[] buffer6 = buffer5;
        int num2 = 4;
        num2 = 4 + buffer4.Length;
        num2 += bytes.Length + 1;
        num2 += buffer2.Length + 1;
        num2 += buffer6.Length;
        num2 += 4;
        num2 += buffer2.Length + 1;
        num2 += 4;
        num2 += A_2.Length;
        num2 += 2;
        int num3 = 0;
        byte[] buffer7 = new byte[num2];
        Class364.smethod_8(buffer7, ref num3, num2 - 4);
        Class364.smethod_11(buffer7, ref num3, buffer4);
        Class364.smethod_11(buffer7, ref num3, bytes);
        num3++;
        Class364.smethod_11(buffer7, ref num3, buffer2);
        num3++;
        Class364.smethod_11(buffer7, ref num3, buffer6);
        Class364.smethod_8(buffer7, ref num3, buffer2.Length + 1);
        Class364.smethod_11(buffer7, ref num3, buffer2);
        num3++;
        Class364.smethod_8(buffer7, ref num3, A_2.Length);
        Class364.smethod_11(buffer7, ref num3, A_2);
        A_0.method_15(BookmarkStart.b("㔳礵吷弹഻฽฿⍁ぃ⽅㹇⽉", num));
        A_0.Write(buffer7, 0, buffer7.Length);
        A_0.Close();
    }

    internal void method_29(string A_0, string A_1)
    {
        this.string_21 = A_0;
        this.string_22 = A_1;
    }

    internal string method_3()
    {
        return this.string_22;
    }

    internal void method_4(Interface61 A_0)
    {
        int num = 0x11;
        if (A_0.imethod_3(BookmarkStart.b("㘶瘸场堼", 0x11)))
        {
            Stream1 stream = A_0.imethod_0(BookmarkStart.b("㘶瘸场堼", num));
            this.class365_0 = new Class365(stream);
            stream.Flush();
            stream.Close();
        }
        if (A_0.imethod_3(BookmarkStart.b("㐶瘸夺圼瘾⽀╂⩄", num)))
        {
            Stream1 stream2 = A_0.imethod_0(BookmarkStart.b("㐶瘸夺圼瘾⽀╂⩄", num));
            this.class371_0 = new Class371(stream2);
            stream2.Flush();
            stream2.Close();
        }
        if (A_0.imethod_3(BookmarkStart.b("㘶稸吺值伾เ⅂⽄", num)))
        {
            Stream1 stream5 = A_0.imethod_0(BookmarkStart.b("㘶稸吺值伾เ⅂⽄", num));
            this.class369_0 = new Class369(stream5);
            stream5.Flush();
            stream5.Close();
        }
        if (A_0.imethod_3(BookmarkStart.b("㐶甸刺匼吾ࡀⵂ⍄⡆", num)))
        {
            Stream1 stream4 = A_0.imethod_0(BookmarkStart.b("㐶甸刺匼吾ࡀⵂ⍄⡆", num));
            this.class368_0 = new Class368(stream4);
            stream4.Flush();
            stream4.Close();
        }
        if (A_0.imethod_3(BookmarkStart.b("㘶瘸场堼฾煀ൂ⑄㍆⁈㵊⡌", num)))
        {
            Stream1 stream3 = A_0.imethod_0(BookmarkStart.b("㘶瘸场堼฾煀ൂ⑄㍆⁈㵊⡌", num));
            byte[] buffer = new byte[stream3.Length];
            stream3.Read(buffer, 0, buffer.Length);
            if (buffer.Length > 0)
            {
                if (this.method_1() == OleObjectType.Package)
                {
                    this.byte_0 = this.method_7(buffer);
                }
                else
                {
                    int num2 = 0;
                    int num3 = Class364.smethod_1(buffer, ref num2);
                    this.byte_0 = Class364.smethod_5(buffer, num3, ref num2);
                }
            }
            stream3.Flush();
            stream3.Close();
        }
        else
        {
            this.byte_0 = this.method_5(A_0);
        }
    }

    private byte[] method_5(Interface61 A_0)
    {
        int num = 6;
        MemoryStream stream = new MemoryStream();
        Stream12 stream2 = Stream12.smethod_2();
        int num2 = this.method_6(A_0);
        int index = 0;
        int length = A_0.imethod_9().Length;
        while (true)
        {
            if (index >= length)
            {
                stream2.Flush();
                if (stream2.Length > 0L)
                {
                    long num1 = stream2.Length;
                    stream2.method_17(stream);
                    stream2.Close();
                    stream2.Dispose();
                    return stream.ToArray();
                }
                stream2.Close();
                stream2.Dispose();
                stream.Dispose();
                return null;
            }
            string str = A_0.imethod_9().GetValue(index).ToString();
            if ((((str != BookmarkStart.b("⴫愭尯圱", num)) && (str != BookmarkStart.b("⼫愭刯報紳堵帷唹", num))) && ((str != BookmarkStart.b("⴫洭弯弱䐳礵娷倹", num)) && (str != BookmarkStart.b("⼫戭夯就弳缵嘷尹医", num)))) && (((str != BookmarkStart.b("⴫愭尯圱Գص瘷嬹䠻圽㘿❁", num)) && (str != BookmarkStart.b("⼫欭怯怱紳砵氷", num))) && (str != BookmarkStart.b("⸫愭尯圱搳䐵崷䤹఻฽瀿", num))))
            {
                Stream1 stream3 = A_0.imethod_0(str);
                if ((num2 == 1) || (str.ToLower() == BookmarkStart.b("簫伭匯失唳儵崷", num).ToLower()))
                {
                    byte[] buffer = new byte[stream3.Length];
                    stream3.Read(buffer, 0, buffer.Length);
                    stream3.Flush();
                    stream3.Close();
                    A_0.Dispose();
                    stream2.Close();
                    stream2.Dispose();
                    return buffer;
                }
                stream2.method_15(stream3.method_0());
                byte[] buffer2 = new byte[stream3.Length];
                stream3.Read(buffer2, 0, buffer2.Length);
                stream2.Write(buffer2, 0, buffer2.Length);
                try
                {
                    stream2.Flush();
                }
                catch
                {
                }
                stream2.Close();
                stream3.Close();
            }
            index++;
        }
    }

    private int method_6(Interface61 A_0)
    {
        int num = 0x10;
        int num2 = 0;
        int index = 0;
        int length = A_0.imethod_9().Length;
        while (index < length)
        {
            string str = A_0.imethod_9().GetValue(index).ToString();
            if ((((str != BookmarkStart.b("㜵眷嘹夻", num)) && (str != BookmarkStart.b("㔵眷堹嘻眽⸿⑁⭃", num))) && ((str != BookmarkStart.b("㜵笷唹儻丽༿⁁⹃", num)) && (str != BookmarkStart.b("㔵琷匹刻唽िⱁ≃⥅", num)))) && (((str != BookmarkStart.b("㜵眷嘹夻༽瀿ు╃㉅ⅇ㱉⥋", num)) && (str != BookmarkStart.b("㔵紷樹渻眽฿ᙁ", num))) && (str != BookmarkStart.b("㐵眷嘹夻渽㈿❁㝃癅硇穉", num))))
            {
                num2++;
            }
            index++;
        }
        return num2;
    }

    private byte[] method_7(byte[] A_0)
    {
        byte[] buffer2;
        byte[] destinationArray = A_0;
        int sourceIndex = 0;
        for (int i = 1; destinationArray[0] != 2; i++)
        {
            if (destinationArray[1] == 0)
            {
                break;
            }
            int length = A_0.Length - (4 * i);
            sourceIndex += 4;
            destinationArray = new byte[length];
            Array.Copy(A_0, sourceIndex, destinationArray, 0, length);
        }
        using (MemoryStream stream = new MemoryStream(destinationArray))
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                buffer2 = this.method_8(reader, out this.string_21, out this.string_22);
            }
        }
        return buffer2;
    }

    private byte[] method_8(BinaryReader A_0, out string A_1, out string A_2)
    {
        A_1 = string.Empty;
        A_2 = string.Empty;
        byte[] buffer = new byte[0];
        if (A_0.ReadUInt16() == 2)
        {
            this.method_9(A_0);
            A_1 = this.method_9(A_0);
            A_0.ReadUInt16();
            switch (A_0.ReadUInt16())
            {
                case 1:
                    A_0.ReadUInt16();
                    A_2 = this.method_9(A_0);
                    return null;

                case 2:
                    return buffer;

                case 3:
                {
                    A_0.ReadInt32();
                    A_2 = this.method_9(A_0);
                    int count = A_0.ReadInt32();
                    return A_0.ReadBytes(count);
                }
            }
        }
        return buffer;
    }

    private string method_9(BinaryReader A_0)
    {
        byte num;
        List<byte> list = new List<byte>();
    Label_000F:
        num = A_0.ReadByte();
        if (num != 0)
        {
            list.Add(num);
            goto Label_000F;
        }
        return Encoding.Default.GetString(list.ToArray(), 0, list.Count);
    }
}

