using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class1004 : Interface51
{
    private bool bool_0;
    private Class1003 class1003_0;
    private Class1069 class1069_0;
    private Class357 class357_0;
    private Class938 class938_0;
    private Class939 class939_0;
    private Class939 class939_1;
    private Stream stream_0;
    private Stream stream_1;
    private Stream stream_2;
    private const string string_0 = "Root Entry";

    public Class1004()
    {
        this.stream_0 = new MemoryStream();
        this.method_8();
    }

    public Class1004(Stream A_0)
    {
        this.method_7(A_0);
    }

    public Class1004(string A_0, bool A_1)
    {
        if (!A_1)
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                this.method_7(stream);
                return;
            }
        }
        this.stream_0 = new MemoryStream();
        this.method_8();
    }

    public void imethod_4(string A_0)
    {
        using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            this.Interface51.imethod_3(stream);
        }
    }

    Interface61 Interface51.imethod_0()
    {
        return this.class1069_0;
    }

    Class1003 Interface51.imethod_1()
    {
        return this.class1003_0;
    }

    void Interface51.imethod_2()
    {
        this.class1069_0.Interface59.imethod_1();
        this.method_23();
        this.method_24();
        this.class939_0.method_10(this.stream_0, this.class357_0, this.class938_0);
        this.class357_0.method_1(this.stream_0, this.class938_0);
        this.class938_0.method_29(this.stream_0);
        this.stream_0.Position = 0L;
    }

    void Interface51.imethod_3(Stream A_0)
    {
        this.Interface51.imethod_2();
        this.method_22(A_0);
    }

    internal Class938 method_0()
    {
        return this.class938_0;
    }

    public Interface61 method_1()
    {
        return this.class1069_0;
    }

    internal Stream method_10(Class297 A_0)
    {
        int num = 4;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伩䈫娭䈯䬱", num));
        }
        Stream stream2 = null;
        if (A_0.method_2() == Class297.EntryType.Stream)
        {
            Class939 class2;
            Stream stream;
            if ((this.class939_1 != null) && (A_0.method_22() < this.class938_0.method_19()))
            {
                class2 = this.class939_1;
                stream = this.stream_1;
            }
            else
            {
                class2 = this.class939_0;
                stream = this.stream_0;
            }
            byte[] buffer = class2.method_1(stream, A_0.method_20(), this);
            stream2 = (buffer != null) ? new MemoryStream(buffer) : new MemoryStream();
            stream2.SetLength((long) A_0.method_22());
        }
        return stream2;
    }

    internal void method_11(Class297 A_0, Stream A_1)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("个䌬嬮䌰䨲", num));
        }
        if (A_1.Length >= this.class938_0.method_19())
        {
            this.method_12(A_0, A_1);
        }
        else
        {
            this.method_13(A_0, A_1);
        }
        A_0.method_23((uint) A_1.Length);
    }

    private void method_12(Class297 A_0, Stream A_1)
    {
        this.class938_0.method_9();
        int num = this.class938_0.method_5();
        long num2 = A_0.method_22();
        long length = A_1.Length;
        int num4 = (int) Math.Ceiling((double) (((double) num2) / ((double) num)));
        int num5 = (int) Math.Ceiling((double) (((double) length) / ((double) num)));
        this.method_15(A_0, num4, num5, this.class939_0);
        this.method_14(this.stream_0, A_0.method_20(), A_1, this.class939_0);
    }

    private void method_13(Class297 A_0, Stream A_1)
    {
        if (this.stream_1 == null)
        {
            this.stream_1 = new MemoryStream();
        }
        if (this.class939_1 == null)
        {
            this.class939_1 = new Class939(this.stream_1, this.class938_0.method_10(), 0);
        }
        this.class938_0.method_10();
        int num = this.class939_1.method_0();
        long num2 = A_0.method_22();
        long length = A_1.Length;
        int num4 = (int) Math.Ceiling((double) (((double) num2) / ((double) num)));
        int num5 = (int) Math.Ceiling((double) (((double) length) / ((double) num)));
        this.method_15(A_0, num4, num5, this.class939_1);
        this.method_14(this.stream_1, A_0.method_20(), A_1, this.class939_1);
    }

    private void method_14(Stream A_0, int A_1, Stream A_2, Class939 A_3)
    {
        int num3;
        int num = 3;
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        long num2 = A_3.method_16(A_1);
        int count = A_3.method_0();
        byte[] buffer = new byte[count];
        long position = A_2.Position;
        A_2.Position = 0L;
        while ((num3 = A_2.Read(buffer, 0, count)) > 0)
        {
            A_0.Position = num2;
            A_0.Write(buffer, 0, num3);
            A_1 = A_3.method_2(A_1);
            if (A_1 < 0)
            {
                break;
            }
            num2 = A_3.method_16(A_1);
        }
        A_2.Position = position;
    }

    private void method_15(Class297 A_0, int A_1, int A_2, Class939 A_3)
    {
        if (A_1 != A_2)
        {
            int num = (A_0.int_9 >= 0) ? A_0.int_9 : A_0.method_20();
            int num2 = this.method_16(num, A_1, A_2, A_3);
            if (num < 0)
            {
                A_0.method_21(num2);
            }
        }
    }

    private int method_16(int A_0, int A_1, int A_2, Class939 A_3)
    {
        int num = -1;
        if (A_1 == A_2)
        {
            return A_0;
        }
        if (A_1 < A_2)
        {
            for (int j = (A_0 >= 0) ? A_3.method_2(A_0) : A_0; j >= 0; j = A_3.method_2(A_0))
            {
                A_0 = j;
            }
            int num3 = A_3.method_4(A_0, A_2 - A_1);
            if (A_0 < 0)
            {
                num = num3;
            }
            return num;
        }
        for (int i = 0; i < (A_2 - 1); i++)
        {
            A_0 = A_3.method_2(A_0);
        }
        A_3.method_3(A_0);
        return num;
    }

    internal Class297 method_17(string A_0, Class297.EntryType A_1)
    {
        DateTime time;
        Class297 class2 = new Class297(A_0, A_1, this.class1003_0.method_0().Count);
        this.class1003_0.method_2(class2);
        class2.method_17(time = DateTime.Now);
        class2.method_19(time);
        return class2;
    }

    internal void method_18(Class297 A_0)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䰧䌩師䬭匯䘱嬳䐵䄷缹刻䨽㈿㭁", num));
        }
        A_0.method_3(Class297.EntryType.Invalid);
        if (A_0.method_2() == Class297.EntryType.Stream)
        {
            this.class939_0.method_3(A_0.method_20());
            A_0.method_21(-1);
        }
    }

    internal int method_19(Class297 A_0, long A_1, byte[] A_2, int A_3)
    {
        throw new Exception(BookmarkStart.b("朲崴制ᤸ嘺堼䬾⥀ⱂ⅄杆♈㥊浌⁎⅐㙒❔㙖ⵘ㉚㉜ㅞ䅠੢ᙤ䝦ݨѪᥬ佮ᡰṲմ᭶ᱸᙺ᡼ᅾꦆ", 13));
    }

    internal Class357 method_2()
    {
        return this.class357_0;
    }

    internal void method_20(Class297 A_0, long A_1, byte[] A_2, int A_3, int A_4)
    {
        this.class938_0.method_9();
        int num = this.class938_0.method_5();
        long num2 = A_0.method_22();
        long num3 = A_1 + A_4;
        int num4 = (int) Math.Ceiling((double) (((double) num2) / ((double) num)));
        int num5 = (int) Math.Ceiling((double) (((double) num3) / ((double) num)));
        if (num5 > num4)
        {
            this.method_15(A_0, num4, num5, this.class939_0);
        }
        int num9 = A_0.method_20();
        int num6 = this.class939_0.method_0();
        int num11 = num6;
        this.method_21(A_0, A_1, ref num11, ref num9);
        A_0.int_9 = num9;
        A_0.int_10 = num11;
        int num7 = (int) (A_1 % ((long) num6));
        while (A_4 > 0)
        {
            int count = Math.Min(A_4, num6 - num7);
            long num10 = this.class939_0.method_16(num9) + num7;
            this.stream_0.Position = num10;
            this.stream_0.Write(A_2, A_3, count);
            num7 = 0;
            A_3 += count;
            A_4 -= count;
            num9 = this.class939_0.method_2(num9);
        }
        A_0.method_23((uint) Math.Max((long) A_0.method_22(), num3));
    }

    private void method_21(Class297 A_0, long A_1, ref int A_2, ref int A_3)
    {
        int num = this.class939_0.method_0();
        if (A_0.int_9 >= 0)
        {
            int num2 = ((int) A_1) % num;
            long num3 = (num2 > 0) ? ((A_1 + num) - num2) : A_1;
            if (A_0.int_10 <= num3)
            {
                A_2 = A_0.int_10;
                A_3 = A_0.int_9;
            }
        }
        while (((long) A_2) <= A_1)
        {
            A_3 = this.class939_0.method_2(A_3);
            A_2 += num;
        }
    }

    private void method_22(Stream A_0)
    {
        MemoryStream stream = this.stream_0 as MemoryStream;
        if (stream != null)
        {
            stream.WriteTo(A_0);
        }
        else
        {
            int num;
            byte[] buffer = new byte[0x8000];
            while ((num = this.stream_0.Read(buffer, 0, 0x8000)) > 0)
            {
                A_0.Write(buffer, 0, num);
            }
        }
    }

    private void method_23()
    {
        if ((this.stream_1 != null) && (this.stream_1.Length != 0L))
        {
            int num = (int) Math.Ceiling((double) (((double) this.stream_1.Length) / ((double) this.class938_0.method_5())));
            Class297 class2 = this.class1003_0.method_0()[0];
            int num2 = class2.method_20();
            int num3 = (int) Math.Ceiling((double) (((double) class2.method_22()) / ((double) this.class939_0.method_0())));
            num2 = this.method_16(num2, num3, num, this.class939_0);
            this.method_14(this.stream_0, num2, this.stream_1, this.class939_0);
            Class297 class3 = this.class1003_0.method_0()[0];
            class3.method_21(num2);
            class3.method_23((uint) this.stream_1.Length);
            MemoryStream stream = new MemoryStream();
            this.class939_1.method_15(stream, this.class938_0.method_5());
            num = (int) Math.Ceiling((double) (((double) stream.Length) / ((double) this.class938_0.method_5())));
            num2 = this.method_16(this.class938_0.method_20(), this.class938_0.method_22(), num, this.class939_0);
            this.method_14(this.stream_0, num2, stream, this.class939_0);
            this.class938_0.method_21(num2);
            this.class938_0.method_10();
            this.class938_0.method_23(num);
        }
    }

    private void method_24()
    {
        int num4;
        MemoryStream stream = new MemoryStream();
        this.class1003_0.method_3(stream);
        int num = (int) Math.Ceiling((double) (((double) stream.Length) / ((double) this.class938_0.method_5())));
        int num2 = this.class938_0.method_16();
        int num3 = (num2 >= 0) ? this.class939_0.method_17(num2) : 0;
        this.class938_0.method_17(num4 = this.method_16(num2, num3, num, this.class939_0));
        num2 = num4;
        this.method_14(this.stream_0, num2, stream, this.class939_0);
    }

    internal Class939 method_3()
    {
        return this.class939_0;
    }

    internal Stream method_4()
    {
        return this.stream_0;
    }

    internal bool method_5()
    {
        return this.bool_0;
    }

    internal void method_6(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public void method_7(Stream A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬷丹主嬽ℿ⽁", num));
        }
        long position = A_0.Position;
        int capacity = (int) (A_0.Length - position);
        MemoryStream stream = new MemoryStream(capacity);
        stream.SetLength((long) capacity);
        A_0.Read(stream.GetBuffer(), 0, capacity);
        stream.Position = 0L;
        this.stream_0 = stream;
        this.class938_0 = new Class938(this.stream_0);
        this.class357_0 = new Class357(this.stream_0, this.class938_0);
        this.class939_0 = new Class939(this, this.stream_0, this.class357_0, this.class938_0);
        byte[] buffer = this.class939_0.method_1(this.stream_0, this.class938_0.method_16(), this);
        this.class1003_0 = new Class1003(buffer);
        Class297 class2 = this.class1003_0.method_0()[0];
        this.class1069_0 = new Class1069(this, class2);
        int num2 = class2.method_20();
        if (num2 >= 0)
        {
            this.stream_1 = new MemoryStream(this.class939_0.method_1(this.stream_0, num2, this));
            if (this.class938_0.method_20() >= 0)
            {
                this.stream_2 = new MemoryStream(this.class939_0.method_1(this.stream_0, this.class938_0.method_20(), this));
                this.class939_1 = new Class939(this.stream_1, this.class938_0.method_10(), this.stream_2, 0);
            }
            this.class939_0.method_3(num2);
            if (this.class938_0.method_20() >= 0)
            {
                this.class939_0.method_3(this.class938_0.method_20());
            }
        }
    }

    private void method_8()
    {
        this.class1003_0 = new Class1003();
        this.class1069_0 = new Class1069(this, BookmarkStart.b("紮帰尲䄴᜶簸唺䤼䴾㡀", 9), 0);
        this.stream_0.SetLength(0x200L);
        this.class938_0 = new Class938();
        this.class357_0 = new Class357();
        Class297 class2 = this.class1069_0.Interface59.imethod_0();
        class2.method_3(Class297.EntryType.Root);
        this.class1003_0.method_2(class2);
        this.class939_0 = new Class939(this.stream_0, this.class938_0.method_9(), 0x200);
    }

    internal void method_9(byte[] A_0, int A_1, int A_2, Class938 A_3)
    {
        ushort num = A_3.method_9();
        int count = A_3.method_5();
        long num3 = smethod_4(A_2, num);
        this.stream_0.Position = num3;
        this.stream_0.Read(A_0, A_1, count);
    }

    public static void smethod_0()
    {
        int num = 0x10;
        Class1004 class2 = new Class1004();
        using (FileStream stream = new FileStream(BookmarkStart.b("爵ȷ昹樻簽Ŀفⵃ❅⑇╉⭋恍⡏㹑❓", 0x10), FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            class2.method_7(stream);
            Console.WriteLine(class2.method_1().imethod_0(BookmarkStart.b("愵圷䠹圻尽⼿ⵁ⽃", num)).Length);
        }
    }

    private static void smethod_1(string A_0, Class1003 A_1)
    {
        int num = 2;
        using (StreamWriter writer = new StreamWriter(Path.Combine(A_0, BookmarkStart.b("䰧䌩師䬭匯䘱嬳䐵䄷ᐹ䠻䘽㐿", 2))))
        {
            List<Class297> list = A_1.method_0();
            int num2 = 0;
            int count = list.Count;
            while (num2 < count)
            {
                Class297 class2 = list[num2];
                writer.WriteLine(new string('-', 20));
                writer.WriteLine(BookmarkStart.b("洧䐩堫尭䤯笱倳వᠷ䄹఻䌽", num), class2.method_26());
                writer.WriteLine(BookmarkStart.b("昧䬩䄫䬭ਯሱ伳ص䔷ᘹ᰻笽⸿㙁㙃㽅᱇㍉㱋⭍橏牑⽓杕╗", num), class2.method_0(), class2.method_2());
                writer.WriteLine(BookmarkStart.b("搧伩䨫娭ਯሱ伳ص䔷ᘹ᰻氽⤿╁ⱃ㉅片橉㝋罍ⵏ繑瑓ᕕし㍙せ㩝婟䉡ὣ呥ᕧ", num), class2.method_6(), class2.method_8(), class2.method_10());
                writer.WriteLine(BookmarkStart.b("漧弩䔫䨭ਯሱ伳ص䔷ᘹ᰻稽ℿ㙁⅃Յ㩇⽉ⵋ㩍㕏桑瑓ⵕ楗❙灛繝⑟͡ၣͥ╧թ࡫ݭᙯୱ乳噵ͷ䡹Ż", num), class2.method_12(), class2.method_16(), class2.method_18());
                writer.WriteLine(BookmarkStart.b("笧帩䴫尭䐯愱儳唵䰷唹主н怿㥁瑃㭅摇橉ੋ⅍㹏♑ݓ㽕≗㽙晛繝᭟卡ᥣ", num), class2.method_20(), class2.method_22());
                num2++;
            }
        }
    }

    private static void smethod_2(string A_0, Interface61 A_1)
    {
        foreach (string str2 in A_1.imethod_9())
        {
            smethod_3(A_0, str2, A_1);
        }
        foreach (string str3 in A_1.imethod_10())
        {
            string path = Path.Combine(A_0, str3);
            Directory.CreateDirectory(path);
            using (Interface61 interface2 = A_1.imethod_5(str3))
            {
                smethod_2(path, interface2);
            }
        }
    }

    private static void smethod_3(string A_0, string A_1, Interface61 A_2)
    {
        byte[] buffer = new byte[0x8000];
        using (Stream stream = A_2.imethod_0(A_1))
        {
            if (A_1[0] < ' ')
            {
                A_1 = A_1.Substring(1);
            }
            using (FileStream stream2 = new FileStream(Path.Combine(A_0, A_1), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                int num;
                while ((num = stream.Read(buffer, 0, 0x8000)) > 0)
                {
                    stream2.Write(buffer, 0, num);
                }
            }
        }
    }

    [CLSCompliant(false)]
    public static long smethod_4(int A_0, ushort A_1)
    {
        return (long) ((A_0 << A_1) + 0x200);
    }

    [CLSCompliant(false)]
    public static long smethod_5(int A_0, ushort A_1, int A_2)
    {
        return (long) ((A_0 << A_1) + A_2);
    }

    public static bool smethod_6(Stream A_0)
    {
        return Class938.smethod_0(A_0);
    }

    void IDisposable.Dispose()
    {
        if (this.class1069_0 != null)
        {
            this.class1069_0.System.IDisposable.Dispose();
            this.class1069_0 = null;
            this.stream_0.Dispose();
            this.stream_0 = null;
            this.class938_0 = null;
            this.class939_0 = null;
            this.class1003_0 = null;
        }
    }
}

