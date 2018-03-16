using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class Class1132
{
    private Class1089 class1089_0;
    private Class410 class410_0;
    private Class522 class522_0;
    private Class916 class916_0;
    private Class917 class917_0;
    private MemoryStream memoryStream_0;
    private Stream stream_0;

    public Class1132(Class1089 A_0)
    {
        this.class1089_0 = A_0;
    }

    public Class1132(Guid A_0) : this(new Class1089(A_0))
    {
    }

    public Class1132(Stream A_0)
    {
        this.method_2(A_0);
    }

    public Class1132(string A_0)
    {
        using (Stream stream = File.OpenRead(A_0))
        {
            this.method_2(stream);
            this.method_12();
        }
    }

    public Class1089 method_0()
    {
        if (this.class1089_0 == null)
        {
            this.method_12();
        }
        return this.class1089_0;
    }

    internal Class917 method_1()
    {
        return this.class917_0;
    }

    private MemoryStream method_10(uint A_0, int A_1, int A_2, bool A_3)
    {
        bool flag;
        A_2 = Math.Min(A_1, A_2);
        MemoryStream stream = new MemoryStream(A_2);
        stream.SetLength((long) A_2);
        if (!(flag = A_3 || this.class522_0.method_2((long) A_1)))
        {
            Class1090 class2 = this.class410_0.method_0(0);
            if ((class2.uint_4 != uint.MaxValue) && (this.memoryStream_0 == null))
            {
                this.memoryStream_0 = this.method_10(class2.uint_4, (int) class2.long_2, (int) class2.long_2, true);
            }
            if ((this.class522_0.method_0() == 0) || (this.memoryStream_0 == null))
            {
                stream.SetLength(0L);
                return stream;
            }
        }
        Class916 class3 = flag ? this.class917_0 : this.class916_0;
        Stream stream2 = flag ? this.stream_0 : this.memoryStream_0;
        int num6 = flag ? 0x200 : 0x40;
        int offset = 0;
        long position = stream2.Position;
        for (uint i = A_0; i != 0xfffffffe; i = class3.method_0(i))
        {
            if (i == uint.MaxValue)
            {
                return stream;
            }
            long num2 = Class967.smethod_0(i, flag);
            if (position != num2)
            {
                stream2.Position = position = num2;
            }
            int num5 = A_2 - offset;
            if (num5 == 0)
            {
                return stream;
            }
            int count = Math.Min(num6, num5);
            stream2.Read(stream.GetBuffer(), offset, count);
            offset += count;
            position += count;
        }
        return stream;
    }

    public MemoryStream method_11(string A_0)
    {
        int num = 0x13;
        Class1090 class2 = this.class410_0.method_4(A_0);
        if (class2 == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("稸娺匼儾⹀㝂敄ⅆ⁈╊⥌潎㕐㩒❔㉖㩘⽚㉜ⵞᡠ䍢d०ᵨᥪᑬ佮ੰ䍲ࡴ奶", num), A_0));
        }
        return this.method_10(class2.uint_4, (int) class2.long_2, 0x200, false);
    }

    private void method_12()
    {
        this.method_13(this.class410_0.method_0(0), null);
    }

    private void method_13(Class1090 A_0, Class1089 A_1)
    {
        int num = 10;
        if (!A_0.bool_0)
        {
            A_0.bool_0 = true;
            switch (A_0.dirEntryType_0)
            {
                case DirEntryType.Invalid:
                    return;

                case DirEntryType.Storage:
                case DirEntryType.Root:
                {
                    Class1089 class2 = new Class1089(A_0.guid_0);
                    if ((A_0.dirEntryType_0 != DirEntryType.Root) || (this.class1089_0 != null))
                    {
                        A_1.method_3(A_0.string_0, class2);
                    }
                    else
                    {
                        this.class1089_0 = class2;
                    }
                    Class1090 class3 = this.class410_0.method_6(A_0, A_0.uint_1);
                    if (class3 != null)
                    {
                        this.method_13(class3, class2);
                    }
                    break;
                }
                case DirEntryType.Stream:
                    A_1.method_2(A_0.string_0, this.method_10(A_0.uint_4, (int) A_0.long_2, (int) A_0.long_2, false));
                    break;

                default:
                    throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ㐿㭁㑃⍅桇╉⩋湍㑏㭑♓㍕㭗⹙㍛ⱝᥟ䉡ţࡥᱧᡩᕫ乭᥯ᱱ味ɵၷό屻ൽﲇﾉﺋ늑ﶛ劣얟財", num));
            }
            Class1090 class5 = this.class410_0.method_6(A_0, A_0.uint_2);
            if (class5 != null)
            {
                this.method_13(class5, A_1);
            }
            Class1090 class4 = this.class410_0.method_6(A_0, A_0.uint_3);
            if (class4 != null)
            {
                this.method_13(class4, A_1);
            }
        }
    }

    public bool method_14(string A_0)
    {
        return (this.class410_0.method_4(A_0) != null);
    }

    private void method_2(Stream A_0)
    {
        this.stream_0 = A_0;
        this.stream_0.Position = 0L;
        this.class522_0 = new Class522(new BinaryReader(this.stream_0, Encoding.Unicode));
        this.class917_0 = new Class917(this.stream_0, this.class522_0);
        this.class917_0.method_6();
        this.method_3();
        this.class916_0 = new Class916(this.method_10(this.class522_0.uint_3, this.class522_0.method_0(), this.class522_0.method_0(), true));
        this.method_9();
    }

    private void method_3()
    {
        int num = 0x13;
        int num2 = Math.Min(10, this.class917_0.method_2());
        for (uint i = 0; i < num2; i++)
        {
            if (this.class917_0.method_0(i) != 0)
            {
                return;
            }
        }
        throw new InvalidOperationException(BookmarkStart.b("洸区堼Ἶ㉀㝂㝄㉆⩈㽊㡌㵎㑐㝒畔⑖ⵘ㑚⽜㹞٠٢䕤ͦ٨ࡪᡬɮᑰᵲŴ坶੸Ṻ᡼ቾꎂꦈ꾎ﲒ爵얠趢", num));
    }

    public void method_4(string A_0)
    {
        using (Stream stream = File.Create(A_0))
        {
            this.method_5(stream);
        }
    }

    public void method_5(Stream A_0)
    {
        if (A_0 == null)
        {
            throw new ArgumentNullException();
        }
        Stream stream = null;
        if (!A_0.CanSeek)
        {
            stream = A_0;
            A_0 = new MemoryStream();
        }
        this.stream_0 = A_0;
        this.stream_0.Position = 0x200L;
        this.class522_0 = new Class522();
        this.class917_0 = new Class917(this.stream_0, this.class522_0);
        this.class916_0 = new Class916();
        this.memoryStream_0 = new MemoryStream();
        this.class410_0 = new Class410();
        this.method_6(this.class1089_0, null);
        if (this.memoryStream_0.Length > 0L)
        {
            int num;
            this.class410_0.method_0(0).uint_4 = this.method_8(this.memoryStream_0, true);
            this.class410_0.method_0(0).long_2 = this.memoryStream_0.Length;
            this.class522_0.uint_3 = this.method_7(this.class916_0.method_4(), true, out num);
            this.class522_0.int_7 = num;
        }
        else
        {
            this.class522_0.uint_3 = 0xfffffffe;
        }
        this.class522_0.uint_2 = this.method_8(this.class410_0.method_7(), true);
        this.class917_0.method_8();
        this.stream_0.Position = 0L;
        this.class522_0.method_1(new BinaryWriter(this.stream_0, Encoding.Unicode));
        this.stream_0.Position = this.stream_0.Length;
        if (stream != null)
        {
            A_0.Position = 0L;
            ((MemoryStream) A_0).WriteTo(stream);
            A_0.Close();
            A_0 = stream;
        }
    }

    private void method_6(Class1089 A_0, Class1090 A_1)
    {
        int num = 0x13;
        if (A_1 == null)
        {
            A_1 = new Class1090(BookmarkStart.b("欸吺刼䬾慀ق⭄㍆㭈㉊", num), true, A_0.method_0());
            this.class410_0.method_3(A_1);
        }
        if (A_0.Count > 0)
        {
            A_1.uint_1 = (uint) this.class410_0.method_2();
        }
        for (int i = 0; i < A_0.Count; i++)
        {
            Class1090 class2;
            string key = (string) A_0.GetKey(i);
            object byIndex = A_0.GetByIndex(i);
            if (byIndex is Class1089)
            {
                Class1089 class3 = (Class1089) byIndex;
                class2 = new Class1090(key, false, class3.method_0());
                this.class410_0.method_3(class2);
                this.method_6(class3, class2);
            }
            else
            {
                if (!(byIndex is Stream))
                {
                    throw new InvalidOperationException(BookmarkStart.b("永唺嘼儾⹀㑂⭄杆♈⥊❌⩎㉐❒畔㹖㝘筚ぜ㩞ౠౢᝤṦ䥨ᡪᥬnͰቲቴቶ坸", num));
                }
                Stream stream = (Stream) byIndex;
                class2 = new Class1090(key, DirEntryType.Stream, stream.Length);
                this.class410_0.method_3(class2);
                class2.uint_4 = this.method_8(stream, false);
            }
            if (i < (A_0.Count - 1))
            {
                class2.uint_3 = (uint) this.class410_0.method_2();
            }
        }
    }

    private uint method_7(Stream A_0, bool A_1, out int A_2)
    {
        bool flag;
        A_2 = 0;
        if (A_0.Length == 0L)
        {
            return 0xfffffffe;
        }
        Class916 class2 = (flag = this.class522_0.method_2(A_0.Length) || A_1) ? this.class917_0 : this.class916_0;
        Stream stream = flag ? this.stream_0 : this.memoryStream_0;
        int num3 = flag ? 0x200 : 0x40;
        uint num = Class967.smethod_1(stream.Position, flag);
        A_0.Position = 0L;
        Class567.smethod_8(A_0, stream);
        Class567.smethod_6(stream, num3);
        A_2 = Class567.smethod_4(A_0.Length, num3);
        for (uint i = 1; i < ((long) A_2); i++)
        {
            class2.method_5(num + i);
        }
        class2.method_5(0xfffffffe);
        return num;
    }

    private uint method_8(Stream A_0, bool A_1)
    {
        int num;
        return this.method_7(A_0, A_1, out num);
    }

    private void method_9()
    {
        int num = 4;
        this.class410_0 = new Class410();
        BinaryReader reader = new BinaryReader(this.stream_0, Encoding.Unicode);
        uint num2 = this.class522_0.uint_2;
        Class335 class2 = new Class335();
        while (num2 != 0xfffffffe)
        {
            this.stream_0.Position = Class967.smethod_0(num2, true);
            for (int i = 0; i < 4; i++)
            {
                this.class410_0.method_3(new Class1090(reader));
            }
            class2.Interface34.imethod_1(num2);
            num2 = this.class917_0.method_0(num2);
            if (class2.Interface34.imethod_3(num2))
            {
                throw new InvalidOperationException(BookmarkStart.b("縩䐫䬭ု䄱䀳䐵䴷夹䠻䬽㈿❁⁃晅㭇㹉⍋㱍ㅏ㕑ㅓ癕㹗㍙せ㭝䁟ᅡţͥէᥩ䱫ᩭὯ剱ᙳ፵塷᥹፻౽ꚇꪉ쪋쾍쒏늑秊ﶛ캟톡蒣얥톧즩삫쮭쎯鲱", num));
            }
        }
    }

    public static bool smethod_0(Stream A_0)
    {
        long position = A_0.Position;
        byte[] buffer = new byte[4];
        int num2 = A_0.Read(buffer, 0, 4);
        A_0.Position = position;
        return smethod_1(buffer, num2);
    }

    public static bool smethod_1(byte[] A_0, int A_1)
    {
        return ((((A_1 >= 4) && (A_0[0] == 0xd0)) && ((A_0[1] == 0xcf) && (A_0[2] == 0x11))) && (A_0[3] == 0xe0));
    }
}

