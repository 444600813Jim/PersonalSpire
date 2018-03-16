using Spire.Compression;
using Spire.Doc;
using System;
using System.IO;

internal class Stream11 : Stream
{
    private long long_0;
    private MemoryStream memoryStream_0;
    private Stream stream_0;
    private uint uint_0;

    private Stream11()
    {
        this.memoryStream_0 = new MemoryStream();
        this.stream_0 = this.method_3(this.memoryStream_0);
    }

    public Stream11(Class771.Delegate5 A_0)
    {
        this.memoryStream_0 = new MemoryStream();
        this.stream_0 = A_0(this.memoryStream_0);
    }

    public Stream method_0()
    {
        this.stream_0.Close();
        return this.memoryStream_0;
    }

    public uint method_1()
    {
        return this.uint_0;
    }

    public long method_2()
    {
        return this.long_0;
    }

    private Stream method_3(Stream A_0)
    {
        return new Stream6(CompressionLevel.Best, A_0);
    }

    void Stream.Flush()
    {
        this.stream_0.Flush();
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        throw new Exception(BookmarkStart.b("簧䈩䤫อ崯圱䀳帵圷帹᰻儽㈿扁⭃㙅ⵇ㡉ⵋ㩍㥏㵑㩓癕ㅗ⥙籛そཟᙡ䑣ཥէᩩk୭ᵯ᝱ᩳɵᵷṹ剻", 2));
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        throw new Exception(BookmarkStart.b("爥䀧伩ఫ䌭唯䘱尳夵尷ᨹ医䰽怿ⵁ㑃⍅㩇⭉㡋❍㽏㱑瑓㽕⭗穙㉛ㅝᑟ䉡ൣ୥ᡧ٩५ͭᕯᱱs፵ᱷ呹", 0));
    }

    void Stream.SetLength(long A_0)
    {
        throw new Exception(BookmarkStart.b("怳帵崷ᨹ儻嬽㐿⩁⭃≅桇╉㹋湍㽏≑ㅓ⑕㥗⹙㕛ㅝ๟䉡ൣᕥ䡧ѩͫᩭ偯᭱ᥳٵᑷόᅻ᭽ꚇ", 14));
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        this.stream_0.Write(A_0, A_1, A_2);
        this.uint_0 = Class1155.smethod_0(A_0, A_1, A_2, this.uint_0);
        this.long_0 += A_2;
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
            return this.stream_0.Position;
        }
        set
        {
            throw new Exception(BookmarkStart.b("挶儸帺ᴼ刾⑀㝂ⵄ⡆ⵈ歊≌㵎煐㱒╔㉖⭘㩚⥜㙞๠ൢ䕤๦ᩨ䭪ͬnհ卲ᱴ᩶ॸ᝺᡼ቾꖊ", 0x11));
        }
    }
}

