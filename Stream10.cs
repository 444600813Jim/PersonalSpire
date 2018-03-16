using Spire.Doc;
using System;
using System.IO;

internal class Stream10 : Stream
{
    private byte[] byte_0;
    private const int int_0 = 0x1000;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private long long_0;
    private Stream stream_0;

    private Stream10()
    {
    }

    public Stream10(Stream A_0) : this(A_0, 0x1000)
    {
    }

    public Stream10(Stream A_0, int A_1)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䘴䌶䬸帺尼刾", num));
        }
        if (A_1 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("圴䈶弸崺堼䴾ቀ⩂㽄≆", num));
        }
        this.stream_0 = A_0;
        this.int_4 = A_1;
        if (!this.stream_0.CanRead && !this.stream_0.CanWrite)
        {
            throw new ArgumentException(BookmarkStart.b("昴䌶䬸帺尼刾慀ㅂ⁄♆ⵈ歊扌潎♐⅒㱔⍖㱘筚㉜⽞ѠᅢѤ፦hѪͬᱮ兰ᩲٴ坶᩸᝺ቼ౾ꮄ", num), BookmarkStart.b("䘴䌶䬸帺尼刾", num));
        }
    }

    public Stream method_0()
    {
        return this.stream_0;
    }

    private void method_1()
    {
        if ((this.int_1 - this.int_2) != 0)
        {
            this.stream_0.Seek((long) (this.int_1 - this.int_2), SeekOrigin.Current);
        }
        this.int_1 = 0;
        this.int_2 = 0;
    }

    private void method_2()
    {
        this.stream_0.Write(this.byte_0, 0, this.int_3);
        this.int_3 = 0;
        this.long_0 = this.stream_0.Position;
        this.stream_0.Flush();
    }

    void Stream.Close()
    {
        if (this.stream_0 != null)
        {
            this.Flush();
            this.stream_0.Close();
        }
        this.stream_0 = null;
        this.byte_0 = null;
    }

    void Stream.Flush()
    {
        int num = 5;
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堪夬崮吰刲場", num));
        }
        if (this.int_3 > 0)
        {
            this.method_2();
        }
        else if ((this.int_1 < this.int_2) && this.stream_0.CanSeek)
        {
            this.method_1();
        }
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        int num = 0x12;
        int count = this.int_2 - this.int_1;
        if (count == 0)
        {
            if (!this.stream_0.CanRead)
            {
                throw new ArgumentException(BookmarkStart.b("欷丹主嬽ℿ⽁摃≅❇⽉㽋湍㹏㵑⁓癕⭗⽙ⱛ⹝ཟၡၣ䙥ᩧཀྵ൫੭偯ᵱѳ፵੷᭹ࡻ᝽ꪃ", num));
            }
            if (this.int_3 > 0)
            {
                this.method_2();
            }
            if (A_2 >= this.int_4)
            {
                count = this.stream_0.Read(A_0, A_1, A_2);
                this.long_0 = this.stream_0.Position;
                this.int_1 = 0;
                this.int_2 = 0;
                return count;
            }
            if (this.byte_0 == null)
            {
                this.byte_0 = new byte[this.int_4];
            }
            long num3 = this.long_0;
            this.long_0 = this.stream_0.Position;
            count = this.stream_0.Read(this.byte_0, 0, this.int_4);
            if (count == 0)
            {
                this.long_0 = num3;
                return 0;
            }
            this.int_1 = 0;
            this.int_2 = count;
        }
        if (count > A_2)
        {
            count = A_2;
        }
        Buffer.BlockCopy(this.byte_0, this.int_1, A_0, A_1, count);
        this.int_1 += count;
        if (count < A_2)
        {
            int num4 = this.stream_0.Read(A_0, A_1 + count, A_2 - count);
            count += num4;
            this.long_0 = this.stream_0.Position;
            this.int_1 = 0;
            this.int_2 = 0;
        }
        return count;
    }

    int Stream.ReadByte()
    {
        int num = 3;
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        if ((this.int_2 == 0) && !this.stream_0.CanRead)
        {
            throw new ArgumentException(BookmarkStart.b("稨弪弬䨮倰帲ᔴ匶嘸帺丼Ἶ⽀ⱂㅄ杆㩈㹊㵌㽎㹐⅒⅔睖୘㹚㱜㭞䅠ౢᕤɦ᭨੪ᥬٮṰᵲ孴", num));
        }
        if (this.int_1 == this.int_2)
        {
            if (this.int_3 > 0)
            {
                this.method_2();
            }
            if (this.byte_0 == null)
            {
                this.byte_0 = new byte[this.int_4];
            }
            this.long_0 = this.stream_0.Position;
            this.int_2 = this.stream_0.Read(this.byte_0, 0, this.int_4);
            this.int_1 = 0;
        }
        if (this.int_1 == this.int_2)
        {
            return -1;
        }
        return this.byte_0[this.int_1++];
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        int num = 11;
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈰䜲䜴制堸嘺", num));
        }
        if (!this.stream_0.CanSeek)
        {
            throw new ArgumentException(BookmarkStart.b("戰䜲䜴制堸嘺ᴼ嬾⹀♂㙄杆❈⑊㥌潎≐♒╔❖㙘⥚⥜罞㉠٢d౦䥨Ѫᵬ੮ͰቲŴṶᙸᕺ卼", num));
        }
        if (this.int_3 > 0)
        {
            this.method_2();
        }
        else if (A_1 == SeekOrigin.Current)
        {
            A_0 -= this.int_2 - this.int_1;
        }
        long num3 = this.stream_0.Position + (this.int_1 - this.int_2);
        long num2 = this.stream_0.Seek(A_0, A_1);
        if (this.int_2 > 0)
        {
            if (num3 == num2)
            {
                if (this.int_1 > 0)
                {
                    Buffer.BlockCopy(this.byte_0, this.int_1, this.byte_0, 0, this.int_2 - this.int_1);
                    this.int_2 -= this.int_1;
                    this.int_1 = 0;
                }
                if (this.int_2 > 0)
                {
                    this.stream_0.Seek((long) this.int_2, SeekOrigin.Current);
                }
            }
            else if (((num3 - this.int_1) < num2) && (num2 < ((num3 + this.int_2) - this.int_1)))
            {
                int num4 = (int) (num2 - num3);
                Buffer.BlockCopy(this.byte_0, this.int_1 + num4, this.byte_0, 0, this.int_2 - (this.int_1 + num4));
                this.int_2 -= this.int_1 + num4;
                this.int_1 = 0;
                if (this.int_2 > 0)
                {
                    this.stream_0.Seek((long) this.int_2, SeekOrigin.Current);
                }
            }
            else
            {
                this.int_1 = 0;
                this.int_2 = 0;
            }
        }
        this.long_0 = num2;
        return num2;
    }

    void Stream.SetLength(long A_0)
    {
        int num = 13;
        if (A_0 < 0L)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔲吴嬶䰸帺", num));
        }
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀲䄴䔶尸娺值", num));
        }
        if (!this.stream_0.CanSeek)
        {
            throw new ArgumentException(BookmarkStart.b("怲䄴䔶尸娺值Ἶ╀ⱂ⁄㑆楈╊≌㭎煐⁒⁔❖⥘㑚⽜⭞䅠ぢdɦɨ䭪ɬὮᑰŲᑴͶၸᑺ፼兾", num));
        }
        if (!this.stream_0.CanWrite)
        {
            throw new ArgumentException(BookmarkStart.b("怲䄴䔶尸娺值Ἶ╀ⱂ⁄㑆楈╊≌㭎煐⁒⁔❖⥘㑚⽜⭞䅠㑢ᝤ๦ᵨ๪䵬nŰᙲݴᙶ൸ቺቼᅾ꾀", num));
        }
        if (this.int_3 > 0)
        {
            this.method_2();
        }
        else if (this.int_1 < this.int_2)
        {
            this.method_1();
        }
        this.stream_0.SetLength(A_0);
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䠨太弬丮䠰", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘨䴪䬬尮吰䜲", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䨨䐪堬䄮䔰", num));
        }
        if ((A_0.Length - A_1) < A_2)
        {
            throw new ArgumentException();
        }
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        if (this.int_3 == 0)
        {
            if (!this.stream_0.CanWrite)
            {
                throw new ArgumentException(BookmarkStart.b("稨弪弬䨮倰帲ᔴ匶嘸帺丼Ἶ⽀ⱂㅄ杆㩈㹊㵌㽎㹐⅒⅔睖⹘⥚㑜⭞Ѡ䍢੤ᝦ౨ᥪ౬᭮ᡰᱲ᭴奶", num));
            }
            if (this.int_1 < this.int_2)
            {
                this.method_1();
            }
        }
        if (this.int_3 > 0)
        {
            int count = this.int_4 - this.int_3;
            if (count > 0)
            {
                if (count > A_2)
                {
                    count = A_2;
                }
                Buffer.BlockCopy(A_0, A_1, this.byte_0, this.int_3, count);
                this.int_3 += count;
                if (A_2 == count)
                {
                    return;
                }
                A_1 += count;
                A_2 -= count;
            }
            this.stream_0.Write(this.byte_0, 0, this.int_3);
            this.long_0 = this.stream_0.Position;
            this.int_3 = 0;
        }
        if (A_2 >= this.int_4)
        {
            this.stream_0.Write(A_0, A_1, A_2);
            this.long_0 = this.stream_0.Position;
        }
        else if (A_2 != 0)
        {
            if (this.byte_0 == null)
            {
                this.byte_0 = new byte[this.int_4];
            }
            Buffer.BlockCopy(A_0, A_1, this.byte_0, 0, A_2);
            this.int_3 += A_2;
        }
    }

    void Stream.WriteByte(byte A_0)
    {
        int num = 6;
        if (this.stream_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弫娭䈯圱唳嬵", num));
        }
        if (this.int_3 == 0)
        {
            if (!this.stream_0.CanWrite)
            {
                throw new ArgumentException(BookmarkStart.b("缫娭䈯圱唳嬵ᠷ帹医嬽㌿扁⩃⥅㱇橉㽋㭍⁏≑㭓⑕ⱗ穙⭛ⱝय़ᙡţ䙥ݧᩩ५ᱭᅯٱᵳ᥵ᙷ呹", num));
            }
            if (this.int_1 < this.int_2)
            {
                this.method_1();
            }
            if (this.byte_0 == null)
            {
                this.byte_0 = new byte[this.int_4];
            }
        }
        if (this.int_3 == this.int_4)
        {
            this.method_2();
        }
        this.byte_0[this.int_3++] = A_0;
    }

    bool Stream.CanRead
    {
        get
        {
            int num = 15;
            if (this.stream_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䘴䌶䬸帺尼刾", num));
            }
            return this.stream_0.CanRead;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            int num = 9;
            if (this.stream_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("尮䔰䄲倴嘶吸", num));
            }
            return this.stream_0.CanSeek;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            int num = 0x12;
            if (this.stream_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䬷丹主嬽ℿ⽁", num));
            }
            return this.stream_0.CanWrite;
        }
    }

    long Stream.Length
    {
        get
        {
            int num = 7;
            if (this.stream_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("帬嬮䌰嘲吴娶", num));
            }
            if (this.int_3 > 0)
            {
                this.method_2();
            }
            return this.stream_0.Length;
        }
    }

    long Stream.Position
    {
        get
        {
            return ((this.long_0 + this.int_1) + this.int_3);
        }
        set
        {
            int num = 14;
            if (value < 0L)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䈳圵吷伹夻", num));
            }
            if (this.stream_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䜳䈵䨷弹崻匽", num));
            }
            if (!this.stream_0.CanSeek)
            {
                throw new ArgumentException(BookmarkStart.b("朳䈵䨷弹崻匽怿♁⭃⍅㭇橉≋⅍⑏牑❓⍕⡗⩙㍛ⱝᑟ䉡ᝣͥ൧ũ䱫ŭo᝱ٳ᝵౷፹፻ၽ깿", num));
            }
            if (this.int_3 > 0)
            {
                this.method_2();
            }
            if (((this.long_0 + this.int_2) > value) && (value >= this.long_0))
            {
                this.int_1 = (int) (value - this.long_0);
            }
            else
            {
                this.int_1 = 0;
                this.int_2 = 0;
                this.long_0 = this.stream_0.Seek(value, SeekOrigin.Begin);
            }
        }
    }
}

