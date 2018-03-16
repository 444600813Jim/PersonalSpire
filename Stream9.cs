using Spire.Compression;
using Spire.Compression.Zip;
using Spire.Doc;
using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class Stream9 : Stream
{
    protected internal bool bool_0;
    private bool bool_1;
    protected internal byte[] byte_0;
    protected internal byte[] byte_1 = new byte[1];
    protected internal Class1068 class1068_0;
    private readonly Class356 class356_0;
    protected internal CompressionLevel compressionLevel_0;
    protected internal CompressionMode compressionMode_0;
    protected internal CompressionStrategy compressionStrategy_0;
    protected internal DateTime dateTime_0;
    protected internal FlushType flushType_0 = FlushType.None;
    protected internal int int_0 = 0x2000;
    protected internal int int_1;
    protected internal Stream stream_0;
    protected internal StreamMode streamMode_0 = StreamMode.Undefined;
    protected internal string string_0;
    protected internal string string_1;
    protected internal ZlibStreamFlavor zlibStreamFlavor_0;

    public Stream9(Stream A_0, CompressionMode A_1, CompressionLevel A_2, ZlibStreamFlavor A_3, bool A_4)
    {
        this.stream_0 = A_0;
        this.bool_0 = A_4;
        this.compressionMode_0 = A_1;
        this.zlibStreamFlavor_0 = A_3;
        this.compressionLevel_0 = A_2;
        if (A_3 == ZlibStreamFlavor.GZIP)
        {
            this.class356_0 = new Class356();
        }
    }

    internal int method_0()
    {
        if (this.class356_0 == null)
        {
            return 0;
        }
        return this.class356_0.method_1();
    }

    protected internal bool method_1()
    {
        return (this.compressionMode_0 == CompressionMode.Compress);
    }

    private Class1068 method_2()
    {
        if (this.class1068_0 == null)
        {
            bool flag = this.zlibStreamFlavor_0 == ZlibStreamFlavor.ZLIB;
            this.class1068_0 = new Class1068();
            if (this.compressionMode_0 == CompressionMode.Decompress)
            {
                this.class1068_0.method_2(flag);
            }
            else
            {
                this.class1068_0.compressionStrategy_0 = this.compressionStrategy_0;
                this.class1068_0.method_10(this.compressionLevel_0, flag);
            }
        }
        return this.class1068_0;
    }

    private byte[] method_3()
    {
        if (this.byte_0 == null)
        {
            this.byte_0 = new byte[this.int_0];
        }
        return this.byte_0;
    }

    internal void method_4()
    {
        // This item is obfuscated and can not be translated.
        int num = 14;
        if (this.class1068_0 != null)
        {
            if (this.streamMode_0 != StreamMode.Writer)
            {
                if ((this.streamMode_0 == StreamMode.Reader) && (this.zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP))
                {
                    if (this.method_1())
                    {
                        throw new Exception0(BookmarkStart.b("昳匵夷帹唻倽✿扁㍃⽅㱇≉汋ⵍ㽏㽑⑓⑕㵗⥙⽛㝝ཟౡ䑣ཥ᭧䩩ɫŭѯ剱ݳ͵ࡷ੹፻౽ꢅ", num));
                    }
                    if (this.class1068_0.long_1 != 0L)
                    {
                        byte[] destinationArray = new byte[8];
                        if (this.class1068_0.int_1 != 8)
                        {
                            throw new Exception0(string.Format(BookmarkStart.b("搳䐵圷丹医崽⼿⹁摃⍅㩇㡉⍋㱍繏牑ᕓ⁕㥗㍙せ㽝ɟ๡ţ⑥ᅧṩ५ᵭ㥯ᱱ䥳൵䡷ݹ偻幽嬨ﺉ낏ꪑ", num), this.class1068_0.int_1));
                        }
                        Array.Copy(this.class1068_0.byte_0, this.class1068_0.int_0, destinationArray, 0, destinationArray.Length);
                        int num4 = BitConverter.ToInt32(destinationArray, 0);
                        int num5 = this.class356_0.method_1();
                        int num6 = BitConverter.ToInt32(destinationArray, 4);
                        int num7 = (int) (this.class1068_0.long_1 & 0xffffffffL);
                        if (num5 != num4)
                        {
                            throw new Exception0(string.Format(BookmarkStart.b("瘳圵尷ᨹ缻氽̿煁癃晅ⅇ⑉汋्੏᭑ѓ癕⭗⹙⹛㭝şཡ䩣䙥䁧୩ཫᩭկ፱ᡳ幵ͷ䩹䙻♽롿ﾁ궃ꞅ떇ﺍﲗ늙꾝骟瑱鲣\udba5\u81a7莩", num), num5, num4));
                        }
                        if (num7 != num6)
                        {
                            throw new Exception0(string.Format(BookmarkStart.b("瘳圵尷ᨹ伻圽㨿❁摃⽅♇橉ୋᑍ᥏ɑ瑓╕ⱗ⡙㥛㽝ൟ䱡䑣乥१३ᡫ᭭ᅯṱ屳൵䡷ݹ啻彽뵿ﲃ몑ꞕ뎙떛", num), num7, num6));
                        }
                    }
                }
            }
            else
            {
                bool flag = false;
                while (true)
                {
                    this.class1068_0.byte_1 = this.method_3();
                    this.class1068_0.int_2 = 0;
                    this.class1068_0.int_3 = this.byte_0.Length;
                    if (!this.method_1())
                    {
                    }
                    int num8 = this.class1068_0.method_14(FlushType.Finish);
                    if ((num8 != 1) && (num8 != 0))
                    {
                        throw new Exception0((this.method_1() ? BookmarkStart.b("倳匵", num) : BookmarkStart.b("崳堵", num)) + BookmarkStart.b("刳娵夷丹唻倽✿硁摃", num) + this.class1068_0.string_0);
                    }
                    if ((this.byte_0.Length - this.class1068_0.int_3) > 0)
                    {
                        this.stream_0.Write(this.byte_0, 0, this.byte_0.Length - this.class1068_0.int_3);
                    }
                    flag = (this.class1068_0.int_1 == 0) && (this.class1068_0.int_3 != 0);
                    if ((this.zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP) && !this.method_1())
                    {
                        flag = (this.class1068_0.int_1 == 8) && (this.class1068_0.int_3 != 0);
                    }
                    if (flag)
                    {
                        this.Flush();
                        if (this.zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP)
                        {
                            if (!this.method_1())
                            {
                                throw new Exception0(BookmarkStart.b("挳䐵儷丹唻倽✿扁㍃⽅㱇≉汋⩍㕏ㅑ㭓㭕⡗⡙㥛ⵝ፟ୡୣࡥ䡧ͩὫ乭ṯᵱs噵୷ཹ౻๽ꒉ", num));
                            }
                            int num2 = this.class356_0.method_1();
                            this.stream_0.Write(BitConverter.GetBytes(num2), 0, 4);
                            int num3 = (int) (this.class356_0.method_0() & 0xffffffffL);
                            this.stream_0.Write(BitConverter.GetBytes(num3), 0, 4);
                        }
                        return;
                    }
                }
            }
        }
    }

    private void method_5()
    {
        if (this.method_2() != null)
        {
            if (this.method_1())
            {
                this.class1068_0.method_15();
            }
            else
            {
                this.class1068_0.method_6();
            }
            this.class1068_0 = null;
        }
    }

    public static byte[] smethod_0(string A_0, Type A_1)
    {
        int num = 0x12;
        byte[] bytes = Encoding.UTF8.GetBytes(A_0);
        using (MemoryStream stream = new MemoryStream())
        {
            Stream stream2 = (Stream) A_1.InvokeMember(BookmarkStart.b("氷刹唻䴽怿ୁᝃ晅Ňⵉ≋⅍≏㝑こ", num), BindingFlags.CreateInstance, null, null, new object[] { stream, CompressionMode.Compress, CompressionLevel.Best });
            using (stream2)
            {
                stream2.Write(bytes, 0, bytes.Length);
            }
            return stream.ToArray();
        }
    }

    public static string smethod_1(byte[] A_0, Type A_1)
    {
        string str;
        int num = 0;
        byte[] buffer = new byte[0x400];
        Encoding encoding = Encoding.UTF8;
        using (MemoryStream stream = new MemoryStream())
        {
            using (MemoryStream stream2 = new MemoryStream(A_0))
            {
                Stream stream3 = (Stream) A_1.InvokeMember(BookmarkStart.b("爥䀧䌩弫อ礯愱ᐳ缵強吹医䰽┿♁", num), BindingFlags.CreateInstance, null, null, new object[] { stream2, CompressionMode.Decompress });
                using (stream3)
                {
                    int num2;
                    while ((num2 = stream3.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        stream.Write(buffer, 0, num2);
                    }
                }
                stream.Seek(0L, SeekOrigin.Begin);
                str = new StreamReader(stream, encoding).ReadToEnd();
            }
        }
        return str;
    }

    public static byte[] smethod_2(byte[] A_0, Type A_1)
    {
        int num = 9;
        using (MemoryStream stream = new MemoryStream())
        {
            Stream stream2 = (Stream) A_1.InvokeMember(BookmarkStart.b("笮夰娲䘴᜶瀸栺ᴼ瘾♀ⵂ⩄㕆ⱈ⽊", num), BindingFlags.CreateInstance, null, null, new object[] { stream, CompressionMode.Compress, CompressionLevel.Best });
            using (stream2)
            {
                stream2.Write(A_0, 0, A_0.Length);
            }
            return stream.ToArray();
        }
    }

    public static byte[] smethod_3(byte[] A_0, Type A_1)
    {
        byte[] buffer2;
        int num = 7;
        byte[] buffer = new byte[0x400];
        using (MemoryStream stream = new MemoryStream())
        {
            using (MemoryStream stream2 = new MemoryStream(A_0))
            {
                Stream stream3 = (Stream) A_1.InvokeMember(BookmarkStart.b("礬䜮堰䀲ᔴ縶樸ᬺ琼堾⽀ⱂ㝄≆ⵈ", num), BindingFlags.CreateInstance, null, null, new object[] { stream2, CompressionMode.Decompress });
                using (stream3)
                {
                    int num2;
                    while ((num2 = stream3.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        stream.Write(buffer, 0, num2);
                    }
                }
                buffer2 = stream.ToArray();
            }
        }
        return buffer2;
    }

    void Stream.Close()
    {
        if (this.stream_0 != null)
        {
            try
            {
                this.method_4();
            }
            finally
            {
                this.method_5();
                if (!this.bool_0)
                {
                    this.stream_0.Close();
                }
                this.stream_0 = null;
            }
        }
    }

    void Stream.Flush()
    {
        this.stream_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num = 0x11;
        if (this.streamMode_0 == StreamMode.Undefined)
        {
            if (!this.stream_0.CanRead)
            {
                throw new Exception0(BookmarkStart.b("挶儸帺ᴼ䰾㕀ㅂ⁄♆⑈歊⑌㱎煐㵒㩔⍖祘⥚㡜㹞ՠɢݤ୦౨䕪", num));
            }
            this.streamMode_0 = StreamMode.Reader;
            this.method_2().int_1 = 0;
        }
        if (this.streamMode_0 != StreamMode.Reader)
        {
            throw new Exception0(BookmarkStart.b("琶堸唺匼倾㕀捂ᝄ≆⡈⽊浌⹎㝐❒ご╖祘ౚ⽜㙞ᕠ੢୤f䝨", num));
        }
        if (A_2 == 0)
        {
            return 0;
        }
        if (this.bool_1 && this.method_1())
        {
            return 0;
        }
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唶䰸崺嬼娾㍀", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("吶嘸为匼䬾", num));
        }
        if (A_1 < A_0.GetLowerBound(0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("堶弸崺丼娾㕀", num));
        }
        if ((A_1 + A_2) > A_0.GetLength(0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("吶嘸为匼䬾", num));
        }
        int num2 = 0;
        this.class1068_0.byte_1 = A_0;
        this.class1068_0.int_2 = A_1;
        this.class1068_0.int_3 = A_2;
        this.class1068_0.byte_0 = this.method_3();
        while (true)
        {
            if ((this.class1068_0.int_1 == 0) && !this.bool_1)
            {
                this.class1068_0.int_0 = 0;
                this.class1068_0.int_1 = this.stream_0.Read(this.byte_0, 0, this.byte_0.Length);
                if (this.class1068_0.int_1 == 0)
                {
                    this.bool_1 = true;
                }
            }
            num2 = this.method_1() ? this.class1068_0.method_14(this.flushType_0) : this.class1068_0.method_5(this.flushType_0);
            if (this.bool_1 && (num2 == -5))
            {
                return 0;
            }
            if ((num2 != 0) && (num2 != 1))
            {
                throw new Exception0(string.Format(BookmarkStart.b("䰶स䘺嬼匾⁀㝂ⱄ⥆⹈煊浌潎⍐げ桔ⱖ桘♚絜罞ౠၢɤ婦ቨ奪ၬ", num), this.method_1() ? BookmarkStart.b("匶尸", num) : BookmarkStart.b("帶圸", num), num2, this.class1068_0.string_0));
            }
            if ((((this.bool_1 || (num2 == 1)) && (this.class1068_0.int_3 == A_2)) || ((this.class1068_0.int_3 <= 0) || this.bool_1)) || (num2 != 0))
            {
                if (this.class1068_0.int_3 > 0)
                {
                    if (num2 == 0)
                    {
                    }
                    if (this.bool_1 && this.method_1())
                    {
                        num2 = this.class1068_0.method_14(FlushType.Finish);
                        if ((num2 != 0) && (num2 != 1))
                        {
                            throw new Exception0(string.Format(BookmarkStart.b("猶尸崺儼帾㕀⩂⭄⁆獈歊浌㵎㉐湒⹔杖⑘筚絜㉞በѢ塤ᱦ塨ᙪ", num), num2, this.class1068_0.string_0));
                        }
                    }
                }
                num2 = A_2 - this.class1068_0.int_3;
                if (this.class356_0 != null)
                {
                    this.class356_0.method_6(A_0, A_1, num2);
                }
                return num2;
            }
        }
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        throw new NotImplementedException();
    }

    void Stream.SetLength(long A_0)
    {
        this.stream_0.SetLength(A_0);
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        // This item is obfuscated and can not be translated.
        int num = 2;
        if (this.class356_0 != null)
        {
            this.class356_0.method_6(A_0, A_1, A_2);
        }
        if (this.streamMode_0 == StreamMode.Undefined)
        {
            this.streamMode_0 = StreamMode.Writer;
        }
        else if (this.streamMode_0 != StreamMode.Writer)
        {
            throw new Exception0(BookmarkStart.b("欧䬩䈫䀭弯䘱ᐳ愵䨷匹䠻嬽怿⍁≃㉅ⵇ㡉汋ᱍ㕏㍑こ㽕㙗㵙牛", num));
        }
        if (A_2 != 0)
        {
            this.method_2().byte_0 = A_0;
            this.class1068_0.int_0 = A_1;
            this.class1068_0.int_1 = A_2;
            bool flag = false;
            while (true)
            {
                this.class1068_0.byte_1 = this.method_3();
                this.class1068_0.int_2 = 0;
                this.class1068_0.int_3 = this.byte_0.Length;
                if (this.method_1())
                {
                }
                int num2 = this.class1068_0.method_14(this.flushType_0);
                if ((num2 != 0) && (num2 != 1))
                {
                    throw new Exception0((this.method_1() ? BookmarkStart.b("䰧伩", num) : BookmarkStart.b("䄧䐩", num)) + BookmarkStart.b("丧䘩䴫娭夯就匳వᠷ", num) + this.class1068_0.string_0);
                }
                this.stream_0.Write(this.byte_0, 0, this.byte_0.Length - this.class1068_0.int_3);
                flag = (this.class1068_0.int_1 == 0) && (this.class1068_0.int_3 != 0);
                if ((this.zlibStreamFlavor_0 == ZlibStreamFlavor.GZIP) && !this.method_1())
                {
                    flag = (this.class1068_0.int_1 == 8) && (this.class1068_0.int_3 != 0);
                }
                if (flag)
                {
                    return;
                }
            }
        }
    }

    bool Stream.CanRead
    {
        get
        {
            return this.stream_0.CanRead;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return this.stream_0.CanSeek;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return this.stream_0.CanWrite;
        }
    }

    long Stream.Length
    {
        get
        {
            return this.stream_0.Length;
        }
    }

    long Stream.Position
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    internal enum StreamMode
    {
        Writer,
        Reader,
        Undefined
    }
}

