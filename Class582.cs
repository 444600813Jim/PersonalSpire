using Spire.Compression.Zip;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

internal class Class582 : Class581
{
    private readonly bool bool_2;
    private readonly Class394 class394_0;
    private readonly Dictionary<string, byte[]> dictionary_1;
    private readonly Dictionary<string, byte[]> dictionary_2;
    private readonly Dictionary<ListStyle, string> dictionary_3;
    private readonly Dictionary<ListLevel, string> dictionary_4;
    private readonly Dictionary<string, string> dictionary_5;

    internal Class582(Stream A_0, Document A_1) : base(A_1)
    {
        this.dictionary_1 = new Dictionary<string, byte[]>();
        this.dictionary_2 = new Dictionary<string, byte[]>();
        this.dictionary_3 = new Dictionary<ListStyle, string>();
        this.dictionary_4 = new Dictionary<ListLevel, string>();
        this.dictionary_5 = new Dictionary<string, string>();
        this.class394_0 = new Class395(A_0);
    }

    internal Class582(Stream A_0, Document A_1, Class861 A_2) : base(A_1, A_2)
    {
        this.dictionary_1 = new Dictionary<string, byte[]>();
        this.dictionary_2 = new Dictionary<string, byte[]>();
        this.dictionary_3 = new Dictionary<ListStyle, string>();
        this.dictionary_4 = new Dictionary<ListLevel, string>();
        this.dictionary_5 = new Dictionary<string, string>();
        this.class394_0 = new Class395(A_0);
    }

    internal Class582(Stream A_0, Document A_1, Class861 A_2, bool A_3) : this(A_0, A_1, A_2)
    {
        this.bool_2 = A_3;
    }

    public override Class394 Class581.imethod_1()
    {
        return this.class394_0;
    }

    public override DocOleObject Class581.imethod_2(string A_0, DocOleObject A_1)
    {
        if (!this.dictionary_2.ContainsKey(A_0))
        {
            return null;
        }
        byte[] buffer = this.dictionary_2[A_0];
        using (MemoryStream stream = new MemoryStream(buffer))
        {
            A_1.stream_1 = new MemoryStream(buffer);
            OleObjectType oleObjectType = A_1.OleObjectType;
            if (((((oleObjectType != OleObjectType.Excel_97_2003_Worksheet) && (oleObjectType != OleObjectType.ExcelBinaryWorksheet)) && ((oleObjectType != OleObjectType.ExcelChart) && (oleObjectType != OleObjectType.ExcelMacroWorksheet))) && (((oleObjectType != OleObjectType.ExcelWorksheet) && (oleObjectType != OleObjectType.PowerPoint_97_2003_Presentation)) && ((oleObjectType != OleObjectType.PowerPoint_97_2003_Slide) && (oleObjectType != OleObjectType.PowerPointMacroPresentation)))) && ((((oleObjectType != OleObjectType.PowerPointMacroSlide) && (oleObjectType != OleObjectType.PowerPointPresentation)) && ((oleObjectType != OleObjectType.PowerPointSlide) && (oleObjectType != OleObjectType.VisioDrawing))) && (((oleObjectType != OleObjectType.Word_97_2003_Document) && (oleObjectType != OleObjectType.WordDocument)) && ((oleObjectType != OleObjectType.WordMacroDocument) && (oleObjectType != OleObjectType.VisioDrawing_2013)))))
            {
                Class1004 class3 = null;
                stream.Position = 0L;
                class3 = new Class1004(stream);
                Class1116 class2 = new Class1116();
                class2.method_4(class3.Interface51.imethod_0());
                buffer = class2.method_0();
                if (A_1.OleObjectType == OleObjectType.Package)
                {
                    A_1.method_105(class2.method_2(), class2.method_3());
                }
            }
        }
        A_1.SetNativeData(buffer);
        A_1.method_102(buffer, string.Empty);
        return A_1;
    }

    public override byte[] Class581.imethod_3(string A_0)
    {
        if (this.dictionary_1.ContainsKey(A_0))
        {
            return this.dictionary_1[A_0];
        }
        return null;
    }

    public override string Class581.imethod_4(string A_0)
    {
        return A_0;
    }

    public override bool Class581.imethod_5(string A_0)
    {
        return !A_0.StartsWith(BookmarkStart.b("䌳夵䨷帹儻刽稿流歃", 14));
    }

    public override void Class581.imethod_9()
    {
        int num = 0x13;
        string str = this.class394_0.method_12(BookmarkStart.b("圸娺值娾", 0x13), "");
        if (!string.IsNullOrEmpty(str))
        {
            byte[] buffer = Convert.FromBase64String(this.class394_0.method_21());
            string str3 = Path.GetExtension(str).ToLower();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("᜸帺值䔾", num)) && !(str3 == BookmarkStart.b("᜸䰺值䔾", num)))
                {
                    if (str3 == BookmarkStart.b("᜸䬺帼䔾", num))
                    {
                        buffer = Class734.smethod_28(buffer);
                    }
                }
                else
                {
                    buffer = Class734.smethod_30(buffer);
                }
            }
            this.dictionary_1[str] = base.method_2(buffer);
        }
    }

    public override void Interface50.imethod_10(ShapeBase A_0)
    {
        A_0.IsTextbox = true;
        Class629.smethod_0(this, A_0);
    }

    internal void method_27()
    {
        int num = 10;
        base.Interface50.imethod_0().bool_6 = false;
        base.method_23(this.class394_0.method_12(BookmarkStart.b("䌯䈱唳唵崷", 10), "") == BookmarkStart.b("䀯䀱儳䔵崷䠹䨻嬽", 10));
        while (this.class394_0.method_9(BookmarkStart.b("䜯崱䘳刵簷唹弻䬽ⴿ❁⩃㉅", num)))
        {
            string key = this.class394_0.method_1();
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_201 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                    dictionary1.Add(BookmarkStart.b("振弱唳䐵䰷渹崻夽ᐿ㭁㑃⍅", num), 0);
                    dictionary1.Add(BookmarkStart.b("琯崱圳䌵唷弹刻䨽ဿぁ⭃㙅ⵇ㡉㡋❍㕏⅑", num), 1);
                    dictionary1.Add(BookmarkStart.b("猯䜱䜳䈵圷圹砻儽⌿㝁⥃⍅♇㹉᱋㱍㽏≑ㅓ⑕ⱗ㍙㥛ⵝ", num), 2);
                    dictionary1.Add(BookmarkStart.b("嘯崱娳䈵䬷", num), 3);
                    dictionary1.Add(BookmarkStart.b("嘯䀱唳嬵崷䤹夻䨽", num), 4);
                    dictionary1.Add(BookmarkStart.b("尯嬱䜳䈵䬷", num), 5);
                    dictionary1.Add(BookmarkStart.b("䌯䘱䴳娵崷䤹", num), 6);
                    dictionary1.Add(BookmarkStart.b("启崱圳礵吷弹砻弽㐿⍁", num), 7);
                    dictionary1.Add(BookmarkStart.b("启崱圳攵䴷䨹䰻稽ℿ㙁╃", num), 8);
                    dictionary1.Add(BookmarkStart.b("䌯娱唳䘵崷縹夻堽ℿ㝁⡃㉅㭇", num), 9);
                    dictionary1.Add(BookmarkStart.b("刯唱搳張嬷丹", num), 10);
                    dictionary1.Add(BookmarkStart.b("启崱圳昵䨷", num), 11);
                    dictionary1.Add(BookmarkStart.b("刯崱倳伵", num), 12);
                    Class1160.dictionary_201 = dictionary1;
                }
                if (Class1160.dictionary_201.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            this.method_28();
                            continue;
                        }
                        case 1:
                        {
                            Class81.smethod_0(this);
                            continue;
                        }
                        case 2:
                        {
                            Class81.smethod_1(this);
                            continue;
                        }
                        case 3:
                        {
                            Class961.smethod_0(this);
                            continue;
                        }
                        case 4:
                        {
                            continue;
                        }
                        case 5:
                        {
                            Class684.smethod_0(this);
                            continue;
                        }
                        case 6:
                        {
                            Class1081.smethod_0(this);
                            Class684.smethod_11(this);
                            continue;
                        }
                        case 7:
                        {
                            this.method_29();
                            continue;
                        }
                        case 8:
                        {
                            this.method_30();
                            continue;
                        }
                        case 9:
                        {
                            this.class394_0.vmethod_1();
                            continue;
                        }
                        case 10:
                        {
                            Class964.smethod_1(this);
                            continue;
                        }
                        case 11:
                        {
                            Class913.smethod_0(this);
                            continue;
                        }
                        case 12:
                        {
                            Class1038.smethod_0(this);
                            continue;
                        }
                    }
                }
            }
            this.class394_0.vmethod_1();
        }
        base.Interface50.imethod_0().bool_6 = true;
        base.method_0();
        base.method_1();
    }

    private void method_28()
    {
        int num = 11;
        string str = "";
        string str2 = "";
        while (this.class394_0.method_19())
        {
            string str3 = this.class394_0.method_1();
            if (str3 != null)
            {
                if (!(str3 == BookmarkStart.b("弰刲場制䨸䬺尼尾⑀㙂㝄⹆", num)))
                {
                    if (str3 == BookmarkStart.b("弰刲場制", num))
                    {
                        str2 = this.class394_0.method_3();
                    }
                }
                else
                {
                    str = this.class394_0.method_3();
                }
            }
        }
        string str4 = str + str2;
        this.dictionary_5[str4] = str4;
    }

    private void method_29()
    {
        this.method_32();
        byte[] buffer = this.imethod_3(BookmarkStart.b("䌫䈭唯嘱唳䈵夷ᐹ儻䴽⼿", 6));
        if (buffer.Length > 0)
        {
            MemoryStream stream = new MemoryStream(buffer);
            Class1132 class2 = new Class1132(stream);
            foreach (DictionaryEntry entry in class2.method_0())
            {
                byte[] buffer2 = smethod_1((MemoryStream) entry.Value);
                this.dictionary_2[(string) entry.Key] = buffer2;
            }
        }
    }

    private void method_30()
    {
        Document document = base.Interface50.imethod_0();
        this.method_32();
        MemoryStream input = new MemoryStream(this.imethod_3(BookmarkStart.b("䌥䰧䌩堫䨭儯䘱唳ᠵ唷䤹医", 0)));
        BinaryReader reader = new BinaryReader(input);
        reader.ReadBytes(10);
        while (input.Position < input.Length)
        {
            switch (reader.ReadInt32())
            {
                case -268369920:
                {
                    reader.ReadInt32();
                    reader.ReadInt32();
                    continue;
                }
                case -267976704:
                {
                    int num2 = reader.ReadInt32();
                    reader.ReadBytes(8);
                    int count = reader.ReadInt32();
                    document.VbaDocumentEvents = (VbaDocumentEvents) reader.ReadInt32();
                    if (count > 0)
                    {
                        document.VbaSignature = reader.ReadBytes(count);
                    }
                    int num = reader.ReadInt32();
                    int num4 = (num2 - count) - 20;
                    if (num4 > 0)
                    {
                        MemoryStream stream2 = new MemoryStream(Class1156.smethod_0(reader.ReadBytes(num4), num, CompressionMethod.Stored));
                        document.VbaMacros = new Class1132(stream2).method_0();
                    }
                    break;
                }
                case -267714560:
                    reader.ReadInt32();
                    reader.ReadInt32();
                    break;

                case -267583488:
                {
                    int num5 = reader.ReadInt32();
                    byte[] buffer3 = reader.ReadBytes(num5);
                    this.method_31(buffer3);
                    break;
                }
            }
        }
    }

    private void method_31(byte[] A_0)
    {
        MemoryStream stream = new MemoryStream(A_0) {
            Position = 0x10L
        };
    }

    private void method_32()
    {
        int num = 8;
        this.class394_0.method_18();
        string str = this.class394_0.method_1();
        while (this.class394_0.method_9(str))
        {
            string str2;
            if (((str2 = this.class394_0.method_1()) != null) && (str2 == BookmarkStart.b("䰭夯就瀳圵䰷嬹", num)))
            {
                this.imethod_9();
            }
        }
    }

    internal Dictionary<ListStyle, string> method_33()
    {
        return this.dictionary_3;
    }

    internal Dictionary<ListLevel, string> method_34()
    {
        return this.dictionary_4;
    }

    internal bool method_35()
    {
        return this.bool_2;
    }

    private static byte[] smethod_1(Stream A_0)
    {
        A_0.Position = 4L;
        return Class1156.smethod_1(A_0, 0, CompressionMethod.Stored);
    }

    internal override bool vmethod_0()
    {
        return this.dictionary_5.ContainsKey(this.class394_0.method_7() + this.class394_0.method_1());
    }

    internal override bool vmethod_1()
    {
        return (!this.vmethod_0() && !this.class394_0.vmethod_2());
    }

    internal override Footnote vmethod_2(FootnoteType A_0, int A_1)
    {
        throw new InvalidOperationException(BookmarkStart.b("笴堶䴸ᬺ丼䨾ㅀ㍂⩄㑆ⱈ⽊浌㭎㹐獒㙔㙖㕘㝚絜⭞ॠ੢ᙤ䥦", 15));
    }

    internal override void vmethod_3(Comment A_0)
    {
        throw new InvalidOperationException(BookmarkStart.b("椦䘨弪ബ尮䐰䌲䔴堶䨸帺夼Ἶ㕀ⱂ敄⑆⡈❊⅌潎═㭒㱔⑖睘", 1));
    }

    internal override Comment vmethod_4(int A_0)
    {
        throw new InvalidOperationException(BookmarkStart.b("木䐪夬༮䈰䘲䔴䜶嘸䠺堼嬾慀㝂⩄杆⩈⩊⅌⍎煐❒㵔㹖⩘畚", 3));
    }

    internal override bool vmethod_5()
    {
        return false;
    }
}

