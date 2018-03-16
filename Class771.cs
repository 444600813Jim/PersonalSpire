using Spire.Compression;
using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

[DefaultMember("Item")]
internal class Class771 : IEnumerable, IDisposable
{
    private bool bool_0 = true;
    private bool bool_1;
    [ThreadStatic]
    private static byte[] byte_0 = new byte[4];
    private CompressionLevel compressionLevel_0 = CompressionLevel.Best;
    public Delegate5 delegate5_0;
    private Dictionary<string, Class814> dictionary_0 = new Dictionary<string, Class814>();
    private Interface29 interface29_0;
    private List<Class814> list_0 = new List<Class814>();

    public Class771()
    {
        this.delegate5_0 = new Delegate5(this.method_11);
    }

    public Class814 method_0(int A_0)
    {
        int num = 9;
        if ((A_0 < 0) || (A_0 > this.list_0.Count))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䘮弰圲倴伶", num));
        }
        return this.list_0[A_0];
    }

    public Class814 method_1(string A_0)
    {
        Class814 class2;
        this.dictionary_0.TryGetValue(A_0, out class2);
        return class2;
    }

    public void method_10(bool A_0)
    {
        this.bool_1 = A_0;
    }

    private Stream method_11(Stream A_0)
    {
        if (this.bool_1)
        {
            return new Stream6(CompressionLevel.Best, A_0);
        }
        return new DeflateStream(A_0, CompressionMode.Compress, true);
    }

    public Class814 method_12(string A_0)
    {
        int num = 0x10;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("刵儷䠹夻崽㐿ⵁ㙃㽅ه⭉⅋⭍", num));
        }
        DirectoryInfo info = new DirectoryInfo(A_0);
        FileAttributes attributes = info.Attributes;
        if (this.interface29_0 != null)
        {
            A_0 = this.interface29_0.imethod_0(A_0);
        }
        return this.method_14(A_0, null, false, attributes);
    }

    public Class814 method_13(string A_0)
    {
        Stream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
        FileInfo info = new FileInfo(A_0);
        FileAttributes attributes = info.Attributes;
        if (this.interface29_0 != null)
        {
            A_0 = this.interface29_0.imethod_0(A_0);
        }
        return this.method_14(A_0, stream, true, attributes);
    }

    public Class814 method_14(string A_0, Stream A_1, bool A_2, FileAttributes A_3)
    {
        int num = 4;
        A_0 = A_0.Replace('\\', '/');
        if (A_0.IndexOf(':') != A_0.LastIndexOf(':'))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("瀩䔫席礯䘱儳嬵ᠷ吹崻匽┿扁❃⥅♇㹉ⵋ❍㹏⅑瑓㽕㑗㙙㥛㥝ş๡䑣եg୩ṫ཭፯ٱᅳѵ୷呹", num), BookmarkStart.b("䌩堫䬭崯簱唳嬵崷", num));
        }
        if (this.dictionary_0.ContainsKey(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("挩堫䬭崯ሱ", num) + A_0 + BookmarkStart.b("਩䴫䈭䈯圱唳刵䄷ᨹ夻䘽⤿ㅁぃ㕅桇⍉≋湍⑏㩑ㅓ癕㥗⡙㽛㙝य़ᑡţ", num));
        }
        Class814 class2 = new Class814(this, A_0, A_1, A_2, A_3);
        class2.method_5(this.compressionLevel_0);
        return this.method_16(class2);
    }

    public Class814 method_15(string A_0, byte[] A_1)
    {
        MemoryStream stream = new MemoryStream(A_1);
        return this.method_14(A_0, stream, false, FileAttributes.Archive);
    }

    public Class814 method_16(Class814 A_0)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尴䌶尸嘺", num));
        }
        this.list_0.Add(A_0);
        this.dictionary_0.Add(A_0.method_0(), A_0);
        return A_0;
    }

    public void method_17(string A_0)
    {
        int num = this.method_29(A_0);
        if (num >= 0)
        {
            this.method_18(num);
        }
    }

    public void method_18(int A_0)
    {
        int num = 12;
        if ((A_0 < 0) || (A_0 >= this.list_0.Count))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬱娳刵崷䈹", num));
        }
        Class814 class2 = this.method_0(A_0);
        this.list_0.RemoveAt(A_0);
        this.dictionary_0.Remove(class2.method_0());
    }

    public void method_19(Regex A_0)
    {
        int index = 0;
        int count = this.list_0.Count;
        while (index < count)
        {
            string input = this.list_0[index].method_0();
            if (A_0.IsMatch(input))
            {
                this.list_0.RemoveAt(index);
                this.dictionary_0.Remove(input);
                index--;
                count--;
            }
            index++;
        }
    }

    public int method_2()
    {
        if (this.list_0 == null)
        {
            return 0;
        }
        return this.list_0.Count;
    }

    public void method_20(string A_0, Stream A_1, bool A_2)
    {
        int num = 0x10;
        Class814 class2 = this.method_1(A_0);
        if (class2 == null)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("張䰷弹儻瀽ℿ⽁⅃", num), BookmarkStart.b("电夷吹刻儽㐿扁≃⽅♇⹉汋㵍⁏㝑㝓㽕㹗㍙㥛㩝䁟ୡၣͥէ䑩", num));
        }
        class2.method_17(A_1, A_2);
    }

    public void method_21(string A_0, Stream A_1, bool A_2, FileAttributes A_3)
    {
        Class814 class2 = this.method_1(A_0);
        if (class2 != null)
        {
            class2.method_17(A_1, A_2);
        }
        else
        {
            this.method_14(A_0, A_1, A_2, A_3);
        }
    }

    public void method_22(string A_0, byte[] A_1)
    {
        int num = 8;
        Class814 class2 = this.method_1(A_0);
        if (class2 == null)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜭䐯圱夳砵夷圹夻", num), BookmarkStart.b("洭儯就娳夵䰷ᨹ娻圽⸿♁摃㕅㡇⽉⽋❍㙏㭑ㅓ㉕硗㍙⡛㭝ൟ䱡", num));
        }
        MemoryStream stream = new MemoryStream(A_1);
        class2.method_17(stream, true);
    }

    public void method_23(string A_0)
    {
        int num = 9;
        if ((A_0 == null) || (A_0.Length == 0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀮䐰䜲䔴䈶䴸紺吼匾⑀ൂ⑄⩆ⱈ", num));
        }
        this.method_24(A_0, false);
    }

    public void method_24(string A_0, bool A_1)
    {
        int num = 9;
        if ((A_0 != null) && (A_0.Length != 0))
        {
            if (A_1)
            {
                string directoryName = Path.GetDirectoryName(Path.GetFullPath(A_0));
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
            }
            using (FileStream stream = new FileStream(A_0, FileMode.Create, FileAccess.Write))
            {
                this.method_25(stream, false);
                return;
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("䀮䐰䜲䔴䈶䴸紺吼匾⑀ൂ⑄⩆ⱈ", num));
    }

    public void method_25(Stream A_0, bool A_1)
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
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            this.list_0[num].method_19(A_0);
            num++;
        }
        this.method_31(A_0);
        if (stream != null)
        {
            A_0.Position = 0L;
            ((MemoryStream) A_0).WriteTo(stream);
            A_0.Close();
            A_0 = stream;
        }
        if (A_1)
        {
            A_0.Close();
        }
    }

    public void method_26(string A_0)
    {
        int num = 15;
        if ((A_0 != null) && (A_0.Length != 0))
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                this.method_27(stream, false);
                return;
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("尴夶䤸为䤼社⡀⽂⁄ॆ⡈♊⡌", num));
    }

    public void method_27(Stream A_0, bool A_1)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶䴸䤺堼帾ⱀ", num));
        }
        long num2 = smethod_0(A_0, 0x6054b50, 0x10015);
        if (num2 < 0L)
        {
            throw new Exception2(BookmarkStart.b("琶堸唺ᨼ䬾慀⽂⩄⑆⡈㽊⡌潎㑐㵒ㅔ睖㙘㵚絜㱞Ѡൢᅤᕦࡨݪ䵬୮ᡰŲၴᑶ൸ᑺོپꆀ力ꆎ놐쎒杖ﾜ쒠莢튤햦욨얪쪬辮ힰ\udab2\ud9b4튶馸\uddba\ud2bc춾곀ꋂ뇄ꛈ맊껎ꏐ냒뷔뻖꿘뻚﷜뛞鋠쏢蛤裦鯨駪飬鿮藰\uddf2", num));
        }
        A_0.Position = num2 + 12L;
        int num3 = smethod_1(A_0);
        long num4 = num2 - num3;
        A_0.Position = num4;
        this.method_33(A_0);
        this.method_34(A_0);
    }

    public void method_28()
    {
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            this.list_0[num].method_20();
            num++;
        }
        this.list_0.Clear();
        this.dictionary_0.Clear();
        this.dictionary_0 = null;
    }

    public int method_29(string A_0)
    {
        Class814 class2;
        if (this.dictionary_0.TryGetValue(A_0, out class2))
        {
            int num2 = 0;
            int count = this.list_0.Count;
            while (num2 < count)
            {
                Class814 class3 = this.list_0[num2];
                if (class3 == class2)
                {
                    return num2;
                }
                num2++;
            }
        }
        return -1;
    }

    public Interface29 method_3()
    {
        return this.interface29_0;
    }

    public int method_30(Regex A_0)
    {
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            string input = this.list_0[num2].method_0();
            if (A_0.IsMatch(input))
            {
                return num2;
            }
            num2++;
        }
        return -1;
    }

    private void method_31(Stream A_0)
    {
        long position = A_0.Position;
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            this.list_0[num2].method_21(A_0);
            num2++;
        }
        this.method_32(A_0, position);
    }

    private void method_32(Stream A_0, long A_1)
    {
        int num2 = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堪夬崮吰刲場", num2));
        }
        int num = (int) (A_0.Position - A_1);
        A_0.Write(BitConverter.GetBytes(0x6054b50), 0, 4);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
        byte[] bytes = BitConverter.GetBytes((short) this.list_0.Count);
        A_0.Write(bytes, 0, 2);
        A_0.Write(bytes, 0, 2);
        A_0.Write(BitConverter.GetBytes(num), 0, 4);
        A_0.Write(BitConverter.GetBytes((int) A_1), 0, 4);
        A_0.WriteByte(0);
        A_0.WriteByte(0);
    }

    private void method_33(Stream A_0)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堪夬崮吰刲場", num));
        }
        while (smethod_1(A_0) == 0x2014b50)
        {
            Class814 item = new Class814(this);
            item.method_23(A_0);
            this.list_0.Add(item);
        }
    }

    private void method_34(Stream A_0)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException();
        }
        if (!A_0.CanSeek || !A_0.CanRead)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䔵䰷䠹夻弽ⴿ", num), BookmarkStart.b("愵崷ᨹ刻嬽┿♁摃㕅ⵇ⽉❋⽍㉏㹑ㅓ癕㥗㑙㡛繝቟ݡգɥ१ࡩk୭偯űsѵᵷ᭹ᅻ幽ꒃﾋ낏ﮑ늛", num));
        }
        int num2 = 0;
        int count = this.list_0.Count;
        while (num2 < count)
        {
            Class814 class2 = this.list_0[num2];
            class2.method_24(A_0, this.bool_0);
            this.dictionary_0.Add(class2.method_0(), class2);
            num2++;
        }
    }

    public Class771 method_35()
    {
        Class771 class2 = (Class771) base.MemberwiseClone();
        class2.list_0 = new List<Class814>();
        class2.dictionary_0 = new Dictionary<string, Class814>();
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            Class814 class3 = this.list_0[num];
            class3 = class3.method_36();
            class2.method_16(class3);
            num++;
        }
        return class2;
    }

    public void method_4(Interface29 A_0)
    {
        this.interface29_0 = A_0;
    }

    public CompressionLevel method_5()
    {
        return this.compressionLevel_0;
    }

    public void method_6(CompressionLevel A_0)
    {
        this.compressionLevel_0 = A_0;
    }

    public bool method_7()
    {
        return this.bool_0;
    }

    public void method_8(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_9()
    {
        return this.bool_1;
    }

    [CLSCompliant(false)]
    public static long smethod_0(Stream A_0, uint A_1, int A_2)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐶䴸䤺堼帾ⱀ", num));
        }
        if (!A_0.CanSeek || !A_0.CanRead)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("怶尸ᬺ匼娾⑀❂敄㍆♈歊╌⹎❐㙒畔⑖㱘㹚㙜㹞͠རd䝦ࡨժ६佮Ͱᙲᑴ፶ᡸ᥺ᅼ᩾ꆀꆎ", num));
        }
        long length = A_0.Length;
        if (length >= 4L)
        {
            bool flag;
            byte[] buffer = new byte[4];
            long num3 = Math.Max((long) 0L, (long) (length - A_2));
            long num4 = (length - 1L) - 4L;
            A_0.Position = num4;
            A_0.Read(buffer, 0, 4);
            uint num5 = BitConverter.ToUInt32(buffer, 0);
            if (!(flag = num5 == A_1))
            {
                while (num4 > num3)
                {
                    num5 = num5 << 8;
                    num4 -= 1L;
                    A_0.Position = num4;
                    num5 += (uint) A_0.ReadByte();
                    if (num5 == A_1)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                return num4;
            }
        }
        return -1L;
    }

    public static int smethod_1(Stream A_0)
    {
        int num = 0x13;
        smethod_3();
        if (A_0.Read(byte_0, 0, 4) != 4)
        {
            throw new Exception2(BookmarkStart.b("永唺尼崾ⵀ♂敄㍆♈歊㽌⩎ぐ㝒畔⅖㡘㝚⡜㩞䅠ɢᅤ䝦ᵨͪ࡬佮ɰͲၴᑶၸᵺᑼ᩾ꎂ愈歷ﺐﶒ떔몖릘ﺚﮞ膠첢쎤螦\udaa8\udfaa\udfac\ucaae킰\udeb2\u95b4삶\ud8b8\uc8ba鶼춾꓀ꋂꛄ꿆곈꿊", num));
        }
        return BitConverter.ToInt32(byte_0, 0);
    }

    public static short smethod_2(Stream A_0)
    {
        int num = 9;
        smethod_3();
        if (A_0.Read(byte_0, 0, 2) != 2)
        {
            throw new Exception2(BookmarkStart.b("種弰刲圴嬶尸ᬺ䤼倾慀ㅂ⁄♆ⵈ歊㭌⹎㵐♒ご睖㡘⽚絜⭞ॠ٢䕤ᑦᥨ๪๬ٮᝰᩲၴ፶奸୺ቼ౾ꮊꂌ꾎ﶒ랖ﶚ붜햠톢삤욦쒨讪\udaac\uceae슰鎲잴튶\ud8b8\ud8ba햼\udabe\ua5c0", num));
        }
        return BitConverter.ToInt16(byte_0, 0);
    }

    public static void smethod_3()
    {
        if (byte_0 == null)
        {
            byte_0 = new byte[4];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.list_0.GetEnumerator();
    }

    void IDisposable.Dispose()
    {
        if (this.list_0 != null)
        {
            int num = 0;
            int count = this.list_0.Count;
            while (num < count)
            {
                this.list_0[num].System.IDisposable.Dispose();
                num++;
            }
            GC.SuppressFinalize(this);
        }
    }

    void object.Finalize()
    {
        try
        {
            if (this.list_0 != null)
            {
                this.System.IDisposable.Dispose();
            }
        }
        finally
        {
            base.Finalize();
        }
    }

    public delegate Stream Delegate5(Stream A_0);
}

