using Spire.Doc;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

[StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
internal abstract class Class1012
{
    private const int int_0 = 8;
    private const int int_1 = 0x10;
    private const int int_2 = 0x20;
    internal static readonly int[] int_3 = new int[] { 
        0, -16777216, -16776961, -16711681, -16744448, -65281, -65536, -256, -1, -16777077, -16741493, -16751616, -7667573, -7667712, -256, -5658199, 
        -2894893
     };
    internal Class1012()
    {
    }

    internal Class1012(byte[] A_0)
    {
        this.vmethod_2(A_0);
    }

    internal Class1012(byte[] A_0, int A_1)
    {
        this.vmethod_3(A_0, A_1);
    }

    internal Class1012(byte[] A_0, int A_1, int A_2)
    {
        this.vmethod_4(A_0, A_1, A_2);
    }

    internal Class1012(Stream A_0, int A_1)
    {
        this.vmethod_5(A_0, A_1);
    }

    internal virtual int vmethod_0()
    {
        Class364 class2 = this.vmethod_1();
        if (class2 != null)
        {
            return class2.vmethod_2();
        }
        return 0;
    }

    protected virtual Class364 vmethod_1()
    {
        throw new Exception(BookmarkStart.b("紧䐩䠫䬭䈯帱䴳張嘷崹漻䨽㈿㝁❃㉅㵇㡉⥋湍㽏㑑瑓ᑕㅗ㱙㩛ౝ՟šୣᑥ౧", 2));
    }

    internal static int smethod_0(Color A_0)
    {
        int index = 0;
        int length = int_3.Length;
        while (index < length)
        {
            if (Color.FromArgb(int_3[index]) == A_0)
            {
                return index;
            }
            index++;
        }
        return 0;
    }

    internal static bool smethod_1(byte A_0, int A_1)
    {
        int num = 5;
        if ((A_1 < 0) || (A_1 >= 8))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䤪䐬嬮愰尲䘴", num), A_1, BookmarkStart.b("椪䐬嬮ᄰ挲娴䐶倸伺吼倾⽀捂♄♆❈╊≌㭎煐ㅒご睖㕘㹚⹜ⱞ䅠ᝢ൤٦ݨ䭪嵬佮ṰŲ啴ၶ୸Ṻᱼ୾ꖄ꾎Ꚑ붒", num));
        }
        return smethod_3(A_0, A_1);
    }

    internal static bool smethod_2(short A_0, int A_1)
    {
        int num = 0x11;
        if ((A_1 < 0) || (A_1 >= 0x10))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("唶倸伺洼倾㉀", num), A_1, BookmarkStart.b("甶倸伺ᴼ漾⹀あⱄ㍆⁈⑊⍌潎㉐㉒㭔㥖㙘⽚絜㵞Ѡ䍢।ɦᩨᡪ䵬᭮ᥰቲ᭴坶䥸孺ቼൾꆀﾊﶎ놐ꊒꂔ릖", num));
        }
        if (A_1 != 15)
        {
            return smethod_3(A_0, A_1);
        }
        return (A_0 < 0);
    }

    internal static bool smethod_3(int A_0, int A_1)
    {
        int num = 12;
        if ((A_1 < 0) || (A_1 >= 0x20))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("倱崳䈵样唹伻", num), A_1, BookmarkStart.b("瀱崳䈵ᠷ樹医䴽⤿㙁ⵃ⥅♇橉⽋⽍㹏㱑㭓≕硗㡙㥛繝౟ݡᝣᕥ䡧ṩѫ཭ṯ剱䑳噵᝷ࡹ屻᥽겋붍ꆏ벑", num));
        }
        if (A_1 != 0x1f)
        {
            return ((A_0 & (((int) 1) << A_1)) != 0);
        }
        return (A_0 < 0);
    }

    internal static int smethod_4(int A_0, int A_1, int A_2)
    {
        return ((A_0 & A_1) >> A_2);
    }

    internal static uint smethod_5(uint A_0, int A_1, int A_2)
    {
        return (uint) ((A_0 & A_1) >> A_2);
    }

    internal static int smethod_6(int A_0, int A_1, bool A_2)
    {
        int num = 0x11;
        if ((A_1 < 0) || (A_1 >= 0x20))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("唶倸伺洼倾㉀", num), A_1, BookmarkStart.b("甶倸伺ᴼ漾⹀あⱄ㍆⁈⑊⍌潎㉐㉒㭔㥖㙘⽚絜㵞Ѡ䍢।ɦᩨᡪ䵬᭮ᥰቲ᭴坶䥸孺ቼൾꆀﾊﶎ놐ꂒꞔ릖", num));
        }
        if (A_1 == 0x1f)
        {
            A_0 = Math.Abs(A_0);
            if (!A_2)
            {
                A_0 = -A_0;
            }
            return A_0;
        }
        if (A_2)
        {
            A_0 |= ((int) 1) << A_1;
            return A_0;
        }
        A_0 &= ~(((int) 1) << A_1);
        return A_0;
    }

    internal static int smethod_7(int A_0, int A_1, int A_2)
    {
        A_0 &= ~A_1;
        A_0 += A_2 & A_1;
        return A_0;
    }

    internal static int smethod_8(int A_0, int A_1, int A_2, int A_3)
    {
        A_0 &= ~A_1;
        A_0 += (A_3 << A_2) & A_1;
        return A_0;
    }

    internal static uint smethod_9(uint A_0, int A_1, int A_2)
    {
        A_0 &= (uint) ~A_1;
        A_0 += (uint) (A_2 & A_1);
        return A_0;
    }

    internal static bool smethod_10(uint A_0, int A_1)
    {
        int num = 11;
        if ((A_1 < 0) || (A_1 > 0x20))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("匰娲䄴朶嘸䠺", num), BookmarkStart.b("猰娲䄴᜶椸吺丼嘾㕀⩂⩄⥆楈⡊ⱌⅎ㽐㱒⅔睖㭘㹚絜㍞Ѡၢᙤ䝦ᵨͪ౬Ů兰䍲啴ᡶ୸孺᩼ൾﮈꮊ뺌뺎뾐", num));
        }
        return ((A_0 & (((int) 1) << A_1)) != 0L);
    }

    internal static uint smethod_11(uint A_0, int A_1, bool A_2)
    {
        int num = 10;
        if ((A_1 < 0) || (A_1 >= 0x20))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("刯嬱䀳昵圷䤹", num), BookmarkStart.b("爯嬱䀳ᘵ样唹伻圽㐿⭁⭃⡅桇⥉ⵋ⁍灏けㅓ癕≗㽙⹛ㅝ౟ݡᝣᕥ䡧թṫ乭ᝯqᅳ᝵౷ό๻幽덿낁ꪃ", num));
        }
        if (A_2)
        {
            A_0 |= ((uint) 1) << A_1;
            return A_0;
        }
        A_0 &= (uint) ~(((int) 1) << A_1);
        return A_0;
    }

    internal static ushort smethod_12(Stream A_0)
    {
        byte[] buffer = new byte[2];
        if (A_0.Read(buffer, 0, 2) != 2)
        {
            throw new Exception5();
        }
        return BitConverter.ToUInt16(buffer, 0);
    }

    internal static uint smethod_13(Stream A_0)
    {
        byte[] buffer = new byte[4];
        if (A_0.Read(buffer, 0, 4) != 4)
        {
            throw new Exception5();
        }
        return BitConverter.ToUInt32(buffer, 0);
    }

    internal static short smethod_14(Stream A_0)
    {
        byte[] buffer = new byte[2];
        if (A_0.Read(buffer, 0, 2) != 2)
        {
            throw new Exception5();
        }
        return BitConverter.ToInt16(buffer, 0);
    }

    internal static int smethod_15(Stream A_0)
    {
        byte[] buffer = new byte[4];
        if (A_0.Read(buffer, 0, 4) != 4)
        {
            throw new Exception5();
        }
        return BitConverter.ToInt32(buffer, 0);
    }

    internal static ushort smethod_16(byte[] A_0, int A_1)
    {
        int num = 4;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬩師尭琯匱䀳圵", num));
        }
        if ((A_1 < 0) || (A_1 > (A_0.Length - 2)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌩挫䠭嘯䄱儳䈵", num), BookmarkStart.b("簩䴫䈭䔯圱ᐳ唵夷吹᰻倽⼿㙁摃⑅ⵇ橉⁋⭍⍏⅑瑓晕硗㭙㉛㩝䁟աᙣͥ१ṩ५ᱭ偯፱ٳѵ㱷᭹ࡻώ깿캁ﺉ꺍붏늑힓秊ﾝ캟횡힣袥펩\ud8ab\ucbad쎯ﮱ\udab3\ue1b5ힷ좹\ud8bb", num));
        }
        return BitConverter.ToUInt16(A_0, A_1);
    }

    internal static ushort smethod_17(byte[] A_0, ref int A_1)
    {
        ushort num = smethod_16(A_0, A_1);
        A_1 += 2;
        return num;
    }

    internal static string smethod_18(Stream A_0)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        int count = smethod_12(A_0) * 2;
        if ((count + A_0.Position) > A_0.Length)
        {
            return string.Empty;
        }
        byte[] buffer = new byte[count];
        if (A_0.Read(buffer, 0, count) != count)
        {
            throw new Exception(BookmarkStart.b("簨䔪䰬䴮崰嘲ᔴ䌶嘸ᬺ似娾⁀❂敄㕆ⱈ㩊㡌♎⍐㙒ㅔ睖㵘㩚⥜㹞䅠բᝤࡦѨ䭪ᥬݮᑰ卲ٴͶ୸Ṻᱼቾ", num));
        }
        return Encoding.Unicode.GetString(buffer);
    }

    internal static void smethod_19(Stream A_0, string A_1)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num));
        }
        smethod_29(A_0, (ushort) (Encoding.Unicode.GetByteCount(A_1) / 2));
        byte[] bytes = Encoding.Unicode.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
    }

    internal static string smethod_20(byte[] A_0, int A_1)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("匱䘳䐵簷嬹䠻弽", num));
        }
        if ((A_1 < 0) || (A_1 > (A_0.Length - 2)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬱笳倵帷䤹夻䨽", num), BookmarkStart.b("搱唳娵䴷弹᰻崽ℿⱁ摃⡅❇㹉汋ⱍ㕏牑㡓㍕⭗⥙籛湝䁟͡੣ɥ䡧൩ṫ୭ᅯٱᅳѵ塷᭹๻౽쑿ꚇ욉ﲓ뚕떗몙\udf9b\uf19d캟톡킣장욧\udea9\udfab肭쮱삳펵쮷튻꾿냁ꃃ", num));
        }
        ushort count = smethod_16(A_0, A_1);
        A_1 += 2;
        return Encoding.Unicode.GetString(A_0, A_1, count);
    }

    internal static string smethod_21(byte[] A_0, int A_1, ushort A_2)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䠨太弬欮倰䜲吴", num));
        }
        if ((A_1 < 0) || (A_1 > (A_0.Length - 2)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䀨搪䬬䤮䈰嘲䄴", num), BookmarkStart.b("缨䨪䄬娮吰ጲ嘴嘶圸ᬺ匼倾㕀捂❄≆楈❊⡌㱎≐獒敔睖㡘㕚㥜罞٠ᅢd٦ᵨ๪Ὤ佮ၰŲݴ㍶ᡸེᱼ兾춀ﶈ권ꊎ놐킒杖練ﲜ햠킢认킨\udfaa\uc8ac\udcae\uf8b0\uddb2\ue2b4\ud8b6\ucbb8\udfba", num));
        }
        return Encoding.Unicode.GetString(A_0, A_1, A_2);
    }

    internal static string smethod_22(byte[] A_0, int A_1, out int A_2)
    {
        int num = 1;
        byte num2 = A_0[A_1];
        A_1 += 2;
        string str = string.Empty;
        A_2 = A_1 + (num2 * 2);
        if (num2 != 0)
        {
            str = Encoding.Unicode.GetString(A_0, A_1, num2 * 2);
        }
        for (int i = A_2; i < (A_0.Length - 1); i++)
        {
            if ((A_0[i] == 0) && (A_0[i + 1] == 0))
            {
                A_2 += 2;
                return str;
            }
        }
        throw new Exception(BookmarkStart.b("琦崨䐪弬䨮唰ጲ䘴䌶䬸刺匼堾慀あⵄ⡆㱈❊⥌潎㍐㙒畔ⵖ㱘⥚㉜牞ѠൢŤɦ൨", num));
    }

    internal static byte[] smethod_23(string A_0)
    {
        byte[] bytes = new byte[(A_0.Length * 2) + 4];
        bytes[0] = (byte) A_0.Length;
        Encoding.Unicode.GetBytes(A_0.ToCharArray(), 0, A_0.Length, bytes, 2);
        return bytes;
    }

    internal static void smethod_24(byte[] A_0, ushort A_1, ref int A_2)
    {
        A_2 = smethod_31(A_0, BitConverter.GetBytes(A_1), A_2);
    }

    internal static void smethod_25(byte[] A_0, uint A_1, ref int A_2)
    {
        A_2 = smethod_31(A_0, BitConverter.GetBytes(A_1), A_2);
    }

    internal static void smethod_26(Stream A_0, uint A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
    }

    internal static void smethod_27(Stream A_0, int A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
    }

    internal static void smethod_28(Stream A_0, short A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
    }

    internal static void smethod_29(Stream A_0, ushort A_1)
    {
        byte[] bytes = BitConverter.GetBytes(A_1);
        A_0.Write(bytes, 0, bytes.Length);
    }

    internal static void smethod_30(byte[] A_0, string A_1, ref int A_2)
    {
        Encoding unicode = Encoding.Unicode;
        A_2 = smethod_31(A_0, unicode.GetBytes(A_1), A_2);
    }

    internal static int smethod_31(byte[] A_0, byte[] A_1, int A_2)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伭䈯䀱瀳圵䰷嬹", num));
        }
        if ((A_2 < 0) || (A_2 > (A_0.Length - 2)))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜭缯吱刳䔵崷丹", num), BookmarkStart.b("砭儯帱䄳匵ᠷ夹崻倽怿ⱁ⭃㉅桇⡉⥋湍㱏㝑❓╕硗橙籛㽝๟١䑣ťᩧཀྵ൫ᩭᕯq味᝵੷ࡹ㡻ώꪃ쪅揄늑릓뚕\udb97\uf599풟쎡쪣튥\udba7\u84a9힭쒯ힱ잳ﾵ횷펻첽꒿", num));
        }
        A_1.CopyTo(A_0, A_2);
        return (A_2 + A_1.Length);
    }

    internal byte[] method_0(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[A_1];
        if (A_0.Read(buffer, 0, A_1) != A_1)
        {
            throw new Exception5();
        }
        return buffer;
    }

    internal virtual void vmethod_2(byte[] A_0)
    {
        this.vmethod_3(A_0, 0);
    }

    internal virtual void vmethod_3(byte[] A_0, int A_1)
    {
        this.vmethod_4(A_0, A_1, A_0.Length - A_1);
    }

    internal virtual void vmethod_4(byte[] A_0, int A_1, int A_2)
    {
        int num = 15;
        Class364 class2 = this.vmethod_1();
        if (class2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("怴夶崸帺似匾㡀⩂⭄⁆ᩈ㽊㽌㩎㉐❒⁔╖㱘", num));
        }
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吴䔶䬸缺尼䬾⁀", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尴砶弸崺丼娾㕀", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尴琶嘸为匼䬾", num));
        }
        if ((A_1 + A_2) > A_0.Length)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尴砶弸崺丼娾㕀捂湄杆⁈ࡊ≌㩎㽐❒", num));
        }
        Class301.smethod_0().method_7(A_0, A_1, A_2, class2);
    }

    internal virtual void vmethod_5(Stream A_0, int A_1)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜭猯崱䄳堵䰷ᨹ弻弽⸿ⱁ⭃㉅桇⡉⥋湍㱏㝑❓╕硗⹙㑛㽝๟䉡呣", num));
        }
        byte[] buffer = new byte[A_1];
        if (A_0.Read(buffer, 0, A_1) != A_1)
        {
            throw new Exception(BookmarkStart.b("洭弯䜱堳刵嘷ᴹ䠻ḽ㈿❁╃≅桇㡉⥋㽍╏㭑♓㍕㱗穙㹛❝ᑟݡᝣ䙥๧ᡩͫͭ偯ٱᱳ፵塷ॹࡻ౽", num));
        }
        this.vmethod_4(buffer, 0, A_1);
    }

    internal virtual int vmethod_6(byte[] A_0, int A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("夷䠹主稽ℿ㙁╃", num));
        }
        if ((A_1 < 0) || (A_1 > A_0.Length))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儷甹娻堽㌿❁ぃ", num));
        }
        int num2 = A_0.Length - A_1;
        Class364 class2 = this.vmethod_1();
        if (class2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("洷吹堻嬽㈿⹁㵃⽅♇ⵉὋ㩍≏❑㝓≕ⵗ⡙㥛", num));
        }
        Class301.smethod_0().method_8(class2, A_0, A_1, num2);
        return num2;
    }

    internal virtual int vmethod_7(Stream A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱䀳䐵崷嬹儻", num));
        }
        int count = this.vmethod_0();
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬱砳匵嘷崹䠻嘽", num));
        }
        byte[] buffer = new byte[count];
        this.vmethod_6(buffer, 0);
        A_0.Write(buffer, 0, count);
        return count;
    }

    internal virtual void vmethod_8()
    {
    }
}

