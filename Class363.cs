using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;
using System.Runtime.InteropServices;

internal class Class363 : IDisposable
{
    private BinaryReader binaryReader_0;
    private BinaryReader binaryReader_1;
    private BinaryReader binaryReader_2;
    private BinaryReader binaryReader_3;
    private BinaryReader binaryReader_4;
    private BinaryWriter binaryWriter_0;
    private BinaryWriter binaryWriter_1;
    private BinaryWriter binaryWriter_2;
    private BinaryWriter binaryWriter_3;
    private BinaryWriter binaryWriter_4;
    private bool bool_0;
    private byte[] byte_0;
    private DigitalSignatures digitalSignatures_0;
    private Interface51 interface51_0;
    private MemoryStream memoryStream_0;
    private MemoryStream memoryStream_1;
    private MemoryStream memoryStream_2;
    private MemoryStream memoryStream_3;
    private MemoryStream memoryStream_4;
    private MemoryStream memoryStream_5;
    private MemoryStream memoryStream_6;
    private const STGM stgm_0 = STGM.STGM_SHARE_DENY_WRITE;
    private const STGM stgm_1 = STGM.STGM_SHARE_EXCLUSIVE;
    private const STGM stgm_2 = (STGM.STGM_DIRECT_SWMR | STGM.STGM_SHARE_DENY_NONE);
    private const STGM stgm_3 = (STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
    private Stream stream_0;
    internal Stream12 stream12_0;
    public const string string_0 = "Macros";
    public const string string_1 = "ObjectPool";
    public const string string_2 = "_xmlsignatures";
    public const string string_3 = "_signatures";
    private const string string_4 = "WordDocument";
    private const string string_5 = "Data";
    private const string string_6 = "1Table";
    private const string string_7 = "\x0005SummaryInformation";
    private const string string_8 = "\x0005DocumentSummaryInformation";
    private string string_9;

    public Class363(Stream A_0, bool A_1)
    {
        this.byte_0 = new byte[] { 
            1, 0, 0xfe, 0xff, 3, 10, 0, 0, 0xff, 0xff, 0xff, 0xff, 6, 9, 2, 0, 
            0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0, 0, 70, 0x27, 0, 0, 0, 
            0x4d, 0x69, 0x63, 0x72, 0x6f, 0x73, 0x6f, 0x66, 0x74, 0x20, 0x4f, 0x66, 0x66, 0x69, 0x63, 0x65, 
            0x20, 0x57, 0x6f, 0x72, 100, 0x20, 0x39, 0x37, 0x2d, 50, 0x30, 0x30, 0x33, 0x20, 0x44, 0x6f, 
            0x63, 0x75, 0x6d, 0x65, 110, 0x74, 0, 10, 0, 0, 0, 0x4d, 0x53, 0x57, 0x6f, 0x72, 
            100, 0x44, 0x6f, 0x63, 0, 0x10, 0, 0, 0, 0x57, 0x6f, 0x72, 100, 0x2e, 0x44, 0x6f, 
            0x63, 0x75, 0x6d, 0x65, 110, 0x74, 0x2e, 0x38, 0, 0xf4, 0x39, 0xb2, 0x71, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0
         };
        this.stream_0 = A_0;
        if (A_1)
        {
            this.method_42();
            if (this.bool_0)
            {
                this.interface51_0 = new Class1004();
            }
            else
            {
                this.stream12_0 = Stream12.smethod_2();
            }
        }
        else
        {
            this.method_30(A_0);
        }
    }

    public Class363(string A_0, bool A_1)
    {
        this.byte_0 = new byte[] { 
            1, 0, 0xfe, 0xff, 3, 10, 0, 0, 0xff, 0xff, 0xff, 0xff, 6, 9, 2, 0, 
            0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0, 0, 70, 0x27, 0, 0, 0, 
            0x4d, 0x69, 0x63, 0x72, 0x6f, 0x73, 0x6f, 0x66, 0x74, 0x20, 0x4f, 0x66, 0x66, 0x69, 0x63, 0x65, 
            0x20, 0x57, 0x6f, 0x72, 100, 0x20, 0x39, 0x37, 0x2d, 50, 0x30, 0x30, 0x33, 0x20, 0x44, 0x6f, 
            0x63, 0x75, 0x6d, 0x65, 110, 0x74, 0, 10, 0, 0, 0, 0x4d, 0x53, 0x57, 0x6f, 0x72, 
            100, 0x44, 0x6f, 0x63, 0, 0x10, 0, 0, 0, 0x57, 0x6f, 0x72, 100, 0x2e, 0x44, 0x6f, 
            0x63, 0x75, 0x6d, 0x65, 110, 0x74, 0x2e, 0x38, 0, 0xf4, 0x39, 0xb2, 0x71, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 0
         };
        this.string_9 = A_0;
        if (A_1)
        {
            this.method_42();
            if (this.bool_0)
            {
                this.interface51_0 = new Class1004();
            }
            else
            {
                this.stream12_0 = Stream12.smethod_1(A_0);
            }
        }
        else
        {
            this.method_29(A_0);
        }
    }

    internal Interface51 method_0()
    {
        return this.interface51_0;
    }

    internal bool method_1()
    {
        return (this.memoryStream_0 != null);
    }

    internal void method_10(MemoryStream A_0)
    {
        this.memoryStream_6 = A_0;
    }

    internal MemoryStream method_11()
    {
        return this.memoryStream_4;
    }

    internal void method_12(MemoryStream A_0)
    {
        this.memoryStream_4 = A_0;
    }

    internal MemoryStream method_13()
    {
        return this.memoryStream_5;
    }

    internal void method_14(MemoryStream A_0)
    {
        this.memoryStream_5 = A_0;
    }

    internal BinaryWriter method_15()
    {
        return this.binaryWriter_3;
    }

    internal void method_16(BinaryWriter A_0)
    {
        this.binaryWriter_3 = A_0;
    }

    internal BinaryWriter method_17()
    {
        return this.binaryWriter_4;
    }

    internal void method_18(BinaryWriter A_0)
    {
        this.binaryWriter_4 = A_0;
    }

    internal BinaryReader method_19()
    {
        return this.binaryReader_3;
    }

    internal Stream12 method_2()
    {
        return this.stream12_0;
    }

    internal void method_20(BinaryReader A_0)
    {
        this.binaryReader_3 = A_0;
    }

    internal BinaryReader method_21()
    {
        return this.binaryReader_4;
    }

    internal void method_22(BinaryReader A_0)
    {
        this.binaryReader_4 = A_0;
    }

    internal BinaryWriter method_23()
    {
        return this.binaryWriter_0;
    }

    internal BinaryWriter method_24()
    {
        return this.binaryWriter_1;
    }

    internal BinaryWriter method_25()
    {
        return this.binaryWriter_2;
    }

    internal BinaryReader method_26()
    {
        return this.binaryReader_0;
    }

    internal BinaryReader method_27()
    {
        return this.binaryReader_1;
    }

    internal BinaryReader method_28()
    {
        return this.binaryReader_2;
    }

    internal void method_29(string A_0)
    {
        if (this.bool_0)
        {
            this.interface51_0 = new Class1004(A_0, false);
        }
        else
        {
            this.stream12_0 = new Stream12(A_0, STGM.STGM_DIRECT_SWMR | STGM.STGM_SHARE_DENY_NONE);
        }
        this.method_43();
    }

    internal MemoryStream method_3()
    {
        return this.memoryStream_0;
    }

    internal void method_30(Stream A_0)
    {
        if (this.bool_0)
        {
            this.interface51_0 = new Class1004(A_0);
        }
        else
        {
            this.stream12_0 = new Stream12(A_0, STGM.STGM_DIRECT_SWMR | STGM.STGM_SHARE_DENY_NONE);
        }
        this.method_43();
    }

    internal void method_31(string A_0)
    {
        int num = 3;
        string str = ((A_0 == BookmarkStart.b("ᠨ缪䰬䴮崰嘲", 3)) || (A_0.Trim().Length == 0)) ? BookmarkStart.b("ᠨ缪䰬䴮崰嘲", num) : A_0;
        if (this.bool_0)
        {
            this.memoryStream_1 = this.method_44(str);
        }
        else
        {
            this.memoryStream_1 = this.method_49(str);
        }
        this.binaryReader_1 = new BinaryReader(this.memoryStream_1);
    }

    internal void method_32()
    {
        int num = 0x11;
        if (this.bool_0)
        {
            this.memoryStream_4 = this.method_44(BookmarkStart.b("㈶樸为值刾⁀ㅂ㱄ๆ❈ⵊ≌㵎㱐㉒⅔㹖㙘㕚", num));
        }
        else if (this.stream12_0.method_19(BookmarkStart.b("㈶樸为值刾⁀ㅂ㱄ๆ❈ⵊ≌㵎㱐㉒⅔㹖㙘㕚", num)))
        {
            this.memoryStream_4 = this.method_49(BookmarkStart.b("㈶樸为值刾⁀ㅂ㱄ๆ❈ⵊ≌㵎㱐㉒⅔㹖㙘㕚", num));
        }
        if (this.memoryStream_4 != null)
        {
            this.binaryReader_3 = new BinaryReader(this.memoryStream_4);
        }
    }

    internal void method_33()
    {
        int num = 0x10;
        if (this.bool_0)
        {
            this.memoryStream_5 = this.method_44(BookmarkStart.b("㌵簷唹弻䬽ⴿ❁⩃㉅ᭇ㽉⅋⍍ㅏ⁑ⵓὕ㙗㱙㍛ⱝൟ͡ၣཥݧѩ", num));
        }
        else if (this.stream12_0.method_19(BookmarkStart.b("㌵簷唹弻䬽ⴿ❁⩃㉅ᭇ㽉⅋⍍ㅏ⁑ⵓὕ㙗㱙㍛ⱝൟ͡ၣཥݧѩ", num)))
        {
            this.memoryStream_5 = this.method_49(BookmarkStart.b("㌵簷唹弻䬽ⴿ❁⩃㉅ᭇ㽉⅋⍍ㅏ⁑ⵓὕ㙗㱙㍛ⱝൟ͡ၣཥݧѩ", num));
        }
        if (this.memoryStream_5 != null)
        {
            this.binaryReader_4 = new BinaryReader(this.memoryStream_5);
        }
    }

    internal void method_34(MemoryStream A_0, MemoryStream A_1, MemoryStream A_2)
    {
        this.memoryStream_0 = A_0;
        this.memoryStream_1 = A_1;
        this.memoryStream_2 = A_2;
    }

    internal void method_35(MemoryStream A_0, MemoryStream A_1, MemoryStream A_2)
    {
        this.memoryStream_0 = A_0;
        if (this.binaryReader_0 != null)
        {
            this.binaryReader_0 = new BinaryReader(this.memoryStream_0);
        }
        this.memoryStream_1 = A_1;
        if (this.memoryStream_1 != null)
        {
            this.binaryReader_1 = new BinaryReader(this.memoryStream_1);
        }
        this.memoryStream_2 = A_2;
        if (this.memoryStream_2 != null)
        {
            this.binaryReader_2 = new BinaryReader(this.memoryStream_2);
        }
    }

    internal void method_36(MemoryStream A_0, MemoryStream A_1, MemoryStream A_2)
    {
        this.memoryStream_0 = A_0;
        if (this.memoryStream_0 != null)
        {
            this.binaryWriter_0 = new BinaryWriter(this.memoryStream_0);
        }
        this.memoryStream_1 = A_1;
        if (this.memoryStream_1 != null)
        {
            this.binaryWriter_1 = new BinaryWriter(this.memoryStream_1);
        }
        this.memoryStream_2 = A_2;
        if (this.memoryStream_2 != null)
        {
            this.binaryWriter_2 = new BinaryWriter(this.memoryStream_2);
        }
    }

    internal void method_37(MemoryStream A_0, string A_1)
    {
        if (!this.bool_0)
        {
            A_0.Position = 0L;
            Stream12 stream = new Stream12(A_0);
            Stream12 stream2 = stream.method_11(A_1);
            Stream12.smethod_0(stream2, this.stream12_0);
            stream.Dispose();
            stream = null;
            stream2.Dispose();
            stream2 = null;
        }
    }

    internal void method_38()
    {
        int num = 14;
        this.method_40(BookmarkStart.b("挳夵䨷帹砻儽⌿㝁⥃⍅♇㹉", 14), this.memoryStream_0);
        this.method_40(BookmarkStart.b("Գ戵夷堹倻嬽", 14), this.memoryStream_1);
        if ((this.memoryStream_2 != null) && (this.memoryStream_2.Length != 0L))
        {
            this.method_40(BookmarkStart.b("瀳圵䰷嬹", num), this.memoryStream_2);
        }
        this.method_41();
        if (this.memoryStream_3 != null)
        {
            this.method_37(this.memoryStream_3, BookmarkStart.b("礳圵嬷䠹医䴽", num));
        }
        if (this.memoryStream_6 != null)
        {
            this.method_37(this.memoryStream_6, BookmarkStart.b("笳吵刷弹弻䨽ဿⵁ⭃⩅", num));
        }
        if ((this.memoryStream_5 != null) && (this.memoryStream_5.Length != 0L))
        {
            this.method_40(BookmarkStart.b("ㄳ爵圷夹䤻匽┿ⱁぃᕅ㵇❉⅋⽍≏⭑ᵓ㡕㹗㕙⹛㍝şᙡൣ॥٧", num), this.memoryStream_5);
        }
        if ((this.memoryStream_4 != null) && (this.memoryStream_4.Length != 0L))
        {
            this.method_40(BookmarkStart.b("ㄳ攵䴷圹儻弽㈿㭁ൃ⡅⹇╉㹋⍍ㅏ♑㵓㥕㙗", num), this.memoryStream_4);
        }
        if (this.stream_0 != null)
        {
            if (this.bool_0)
            {
                this.interface51_0.imethod_3(this.stream_0);
                this.stream_0.Flush();
            }
            else
            {
                this.stream12_0.Flush();
                this.stream12_0.method_17(this.stream_0);
                this.stream_0.Flush();
            }
        }
        this.method_39();
    }

    internal void method_39()
    {
        if (this.bool_0)
        {
            if (this.interface51_0 != null)
            {
                this.interface51_0.imethod_0().Dispose();
                this.interface51_0 = null;
            }
        }
        else if (this.stream12_0 != null)
        {
            this.stream12_0.Dispose();
            this.stream12_0 = null;
        }
        if (this.memoryStream_0 != null)
        {
            this.memoryStream_0.Dispose();
            this.memoryStream_0 = null;
        }
        if (this.memoryStream_1 != null)
        {
            this.memoryStream_1.Dispose();
            this.memoryStream_1 = null;
        }
        if (this.memoryStream_2 != null)
        {
            this.memoryStream_2.Dispose();
            this.memoryStream_2 = null;
        }
        if (this.memoryStream_3 != null)
        {
            this.memoryStream_3.Dispose();
            this.memoryStream_3 = null;
        }
        if (this.memoryStream_6 != null)
        {
            this.memoryStream_6.Dispose();
            this.memoryStream_6 = null;
        }
        if (this.binaryWriter_0 != null)
        {
            this.binaryWriter_0.Close();
            this.binaryWriter_0 = null;
        }
        if (this.binaryWriter_1 != null)
        {
            this.binaryWriter_1.Close();
            this.binaryWriter_1 = null;
        }
        if (this.binaryWriter_2 != null)
        {
            this.binaryWriter_2.Close();
            this.binaryWriter_2 = null;
        }
        if (this.binaryReader_0 != null)
        {
            this.binaryReader_0.Close();
            this.binaryReader_0 = null;
        }
        if (this.binaryReader_1 != null)
        {
            this.binaryReader_1.Close();
            this.binaryReader_1 = null;
        }
        if (this.binaryReader_2 != null)
        {
            this.binaryReader_2.Close();
            this.binaryReader_2 = null;
        }
    }

    internal MemoryStream method_4()
    {
        return this.memoryStream_1;
    }

    private void method_40(string A_0, MemoryStream A_1)
    {
        if (this.bool_0)
        {
            using (Stream1 stream = this.interface51_0.imethod_0().imethod_2(A_0))
            {
                stream.Write(A_1.GetBuffer(), 0, (int) A_1.Length);
                return;
            }
        }
        this.stream12_0.method_15(A_0);
        this.stream12_0.Write(A_1.GetBuffer(), 0, (int) A_1.Length);
        this.stream12_0.Close();
    }

    private void method_41()
    {
        int num = 0;
        if (this.bool_0)
        {
            using (Stream1 stream = this.interface51_0.imethod_0().imethod_2(BookmarkStart.b("✥欧䔩䄫席缯倱帳", num)))
            {
                stream.Write(this.byte_0, 0, this.byte_0.Length);
                return;
            }
        }
        this.stream12_0.method_15(BookmarkStart.b("✥欧䔩䄫席缯倱帳", num));
        this.stream12_0.Write(this.byte_0, 0, this.byte_0.Length);
        this.stream12_0.Close();
    }

    private void method_42()
    {
        this.memoryStream_0 = new MemoryStream(0xfff);
        this.binaryWriter_0 = new BinaryWriter(this.memoryStream_0);
        this.memoryStream_1 = new MemoryStream(0xfff);
        this.binaryWriter_1 = new BinaryWriter(this.memoryStream_0);
        this.memoryStream_2 = new MemoryStream();
        this.binaryWriter_2 = new BinaryWriter(this.memoryStream_2);
        this.memoryStream_5 = new MemoryStream();
        this.binaryWriter_4 = new BinaryWriter(this.memoryStream_5);
        this.memoryStream_4 = new MemoryStream();
        this.binaryWriter_3 = new BinaryWriter(this.memoryStream_4);
    }

    private void method_43()
    {
        int num = 11;
        if (this.bool_0)
        {
            this.memoryStream_0 = this.method_44(BookmarkStart.b("昰尲䜴匶紸吺帼䨾ⱀ♂⭄㍆", num));
            if (this.interface51_0.imethod_0().imethod_3(BookmarkStart.b("田刲䄴嘶", num)))
            {
                this.memoryStream_2 = this.method_44(BookmarkStart.b("田刲䄴嘶", num));
            }
        }
        else
        {
            this.memoryStream_0 = this.method_49(BookmarkStart.b("昰尲䜴匶紸吺帼䨾ⱀ♂⭄㍆", num));
            if (this.stream12_0.method_19(BookmarkStart.b("田刲䄴嘶", num)))
            {
                this.memoryStream_2 = this.method_49(BookmarkStart.b("田刲䄴嘶", num));
            }
            this.memoryStream_3 = this.method_46(BookmarkStart.b("簰刲嘴䔶嘸䠺", num));
            this.memoryStream_6 = this.method_46(BookmarkStart.b("縰儲弴制娸伺洼倾⹀⽂", num));
            Class1028.smethod_0(this, this.method_8());
        }
        this.binaryReader_0 = new BinaryReader(this.memoryStream_0);
        if (this.memoryStream_2 != null)
        {
            this.binaryReader_2 = new BinaryReader(this.memoryStream_2);
        }
    }

    private MemoryStream method_44(string A_0)
    {
        byte[] buffer = null;
        using (Stream1 stream = this.interface51_0.imethod_0().imethod_0(A_0))
        {
            int length = (int) stream.Length;
            buffer = new byte[length];
            stream.Read(buffer, 0, length);
        }
        return new MemoryStream(buffer);
    }

    private MemoryStream method_45(string A_0)
    {
        return null;
    }

    internal MemoryStream method_46(string A_0)
    {
        if (this.stream12_0.method_20(A_0))
        {
            Stream12 stream = this.stream12_0.method_11(A_0);
            Stream12 stream2 = Stream12.smethod_2();
            Stream12.smethod_0(stream, stream2);
            MemoryStream stream3 = new MemoryStream();
            stream2.method_17(stream3);
            stream2.Close();
            stream2.Dispose();
            stream.Close();
            stream.Dispose();
            return stream3;
        }
        return null;
    }

    internal Class1132 method_47()
    {
        if (this.stream_0 != null)
        {
            return new Class1132(this.stream_0);
        }
        return new Class1132(this.string_9);
    }

    internal Class1089 method_48(Stream12 A_0, string A_1)
    {
        Class1132 class2 = new Class1132(this.method_46(A_1));
        return class2.method_0();
    }

    internal MemoryStream method_49(string A_0)
    {
        MemoryStream stream;
        int num = 14;
        try
        {
            if (!this.stream12_0.method_19(A_0))
            {
                return null;
            }
            this.stream12_0.method_10(A_0, STGM.STGM_SHARE_EXCLUSIVE);
            Stream stream2 = this.stream12_0;
            byte[] buffer = new byte[stream2.Length];
            long position = stream2.Position;
            stream2.Position = 0L;
            stream2.Read(buffer, 0, buffer.Length);
            stream2.Position = position;
            stream = new MemoryStream(buffer);
        }
        catch
        {
            throw new ArgumentException(BookmarkStart.b("眳圵嘷吹医䨽怿ぁ⅃❅ⱇ橉⡋⽍⑏㍑瑓さ⩗㕙ㅛ繝፟ᙡᙣͥ१ݩ䱫", num));
        }
        finally
        {
            this.stream12_0.Close();
        }
        return stream;
    }

    internal MemoryStream method_5()
    {
        return this.memoryStream_2;
    }

    internal MemoryStream method_6()
    {
        return this.memoryStream_3;
    }

    internal void method_7(MemoryStream A_0)
    {
        this.memoryStream_3 = A_0;
    }

    internal DigitalSignatures method_8()
    {
        if (this.digitalSignatures_0 == null)
        {
            this.digitalSignatures_0 = new DigitalSignatures();
        }
        return this.digitalSignatures_0;
    }

    internal MemoryStream method_9()
    {
        return this.memoryStream_6;
    }

    internal static void smethod_0(MemoryStream A_0, int A_1, MemoryStream A_2, out byte[] A_3)
    {
        Stream12 stream = new Stream12(A_0);
        Stream12 stream2 = stream.method_11(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", 0x10));
        string str = BookmarkStart.b("椵", 0x10) + A_1.ToString();
        Stream12 stream3 = stream2.method_11(str);
        Stream12 stream4 = new Stream12(A_2, STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        Stream12 stream5 = stream4.method_12(BookmarkStart.b("礵娷倹夻崽㐿ቁ⭃⥅⑇", 0x10), STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_READWRITE);
        if (!stream5.method_20(str))
        {
            Stream12.smethod_0(stream3, stream5);
        }
        stream.Dispose();
        stream2.Dispose();
        stream3.Dispose();
        stream = null;
        stream2 = null;
        stream3 = null;
        A_2 = new MemoryStream();
        stream4.method_17(A_2);
        A_3 = A_2.GetBuffer();
        stream5.Dispose();
        stream4.Dispose();
        stream4 = null;
        stream5 = null;
    }

    internal static void smethod_1(Stream A_0, int A_1, Document A_2)
    {
        int num = 2;
        if (((A_0 != null) && (A_0.Length != 0L)) && (A_1 != 0))
        {
            string item = BookmarkStart.b("眧", num) + A_1;
            if (!A_2.ObjPoolContainers.Contains(item))
            {
                A_2.ObjPoolContainers.Add(item);
                A_0.Position = 0L;
                MemoryStream stream = new MemoryStream();
                Stream12 stream2 = Stream12.smethod_2();
                Stream12 stream3 = stream2.method_13(BookmarkStart.b("朧䠩䘫䬭匯䘱搳夵圷嘹", num));
                byte[] buffer = new byte[A_0.Length];
                A_0.Read(buffer, 0, buffer.Length);
                A_0.Position = 0L;
                MemoryStream stream4 = new MemoryStream(buffer);
                Stream12 stream5 = new Stream12(stream4);
                Stream12 stream6 = stream5.method_11(item);
                Stream12.smethod_0(stream6, stream3);
                stream2.Flush();
                stream2.method_17(stream);
                stream.Position = 0L;
                if (A_2.ObjectPool == null)
                {
                    A_2.ObjectPool = stream.GetBuffer();
                }
                else
                {
                    byte[] objectPool = A_2.ObjectPool;
                    smethod_0(stream, A_1, new MemoryStream(A_2.ObjectPool), out objectPool);
                    A_2.ObjectPool = objectPool;
                }
                stream2.Close();
                stream2.Dispose();
                stream3.Close();
                stream3.Dispose();
                stream5.Close();
                stream5.Dispose();
                stream6.Close();
                stream6.Dispose();
                stream.Close();
                stream.Dispose();
            }
        }
    }

    void IDisposable.Dispose()
    {
        this.string_9 = null;
        this.stream_0 = null;
        if (this.stream12_0 != null)
        {
            this.stream12_0.Dispose();
            this.stream12_0 = null;
        }
        this.digitalSignatures_0 = null;
        this.interface51_0 = null;
        this.memoryStream_0 = null;
        this.memoryStream_1 = null;
        this.memoryStream_2 = null;
        this.memoryStream_3 = null;
        this.memoryStream_4 = null;
        this.memoryStream_5 = null;
        this.memoryStream_6 = null;
        this.binaryWriter_0 = null;
        this.binaryWriter_1 = null;
        this.binaryWriter_2 = null;
        this.binaryWriter_3 = null;
        this.binaryWriter_4 = null;
        this.binaryReader_0 = null;
        this.binaryReader_1 = null;
        this.binaryReader_2 = null;
        this.binaryReader_3 = null;
        this.binaryReader_4 = null;
    }
}

