using Spire.Doc;
using System;

internal class Class897
{
    private const string string_0 = "Operation would return a negative value";
    private const uint uint_0 = 20;
    private uint uint_1;
    private uint[] uint_2;
    internal static readonly uint[] uint_3 = new uint[] { 
        2, 3, 5, 7, 11, 13, 0x11, 0x13, 0x17, 0x1d, 0x1f, 0x25, 0x29, 0x2b, 0x2f, 0x35, 
        0x3b, 0x3d, 0x43, 0x47, 0x49, 0x4f, 0x53, 0x59, 0x61, 0x65, 0x67, 0x6b, 0x6d, 0x71, 0x7f, 0x83, 
        0x89, 0x8b, 0x95, 0x97, 0x9d, 0xa3, 0xa7, 0xad, 0xb3, 0xb5, 0xbf, 0xc1, 0xc5, 0xc7, 0xd3, 0xdf, 
        0xe3, 0xe5, 0xe9, 0xef, 0xf1, 0xfb, 0x101, 0x107, 0x10d, 0x10f, 0x115, 0x119, 0x11b, 0x125, 0x133, 0x137, 
        0x139, 0x13d, 0x14b, 0x151, 0x15b, 0x15d, 0x161, 0x167, 0x16f, 0x175, 0x17b, 0x17f, 0x185, 0x18d, 0x191, 0x199, 
        0x1a3, 0x1a5, 0x1af, 0x1b1, 0x1b7, 0x1bb, 0x1c1, 0x1c9, 0x1cd, 0x1cf, 0x1d3, 0x1df, 0x1e7, 0x1eb, 0x1f3, 0x1f7, 
        0x1fd, 0x209, 0x20b, 0x21d, 0x223, 0x22d, 0x233, 0x239, 0x23b, 0x241, 0x24b, 0x251, 0x257, 0x259, 0x25f, 0x265, 
        0x269, 0x26b, 0x277, 0x281, 0x283, 0x287, 0x28d, 0x293, 0x295, 0x2a1, 0x2a5, 0x2ab, 0x2b3, 0x2bd, 0x2c5, 0x2cf, 
        0x2d7, 0x2dd, 0x2e3, 0x2e7, 0x2ef, 0x2f5, 0x2f9, 0x301, 0x305, 0x313, 0x31d, 0x329, 0x32b, 0x335, 0x337, 0x33b, 
        0x33d, 0x347, 0x355, 0x359, 0x35b, 0x35f, 0x36d, 0x371, 0x373, 0x377, 0x38b, 0x38f, 0x397, 0x3a1, 0x3a9, 0x3ad, 
        0x3b3, 0x3b9, 0x3c7, 0x3cb, 0x3d1, 0x3d7, 0x3df, 0x3e5, 0x3f1, 0x3f5, 0x3fb, 0x3fd, 0x407, 0x409, 0x40f, 0x419, 
        0x41b, 0x425, 0x427, 0x42d, 0x43f, 0x443, 0x445, 0x449, 0x44f, 0x455, 0x45d, 0x463, 0x469, 0x47f, 0x481, 0x48b, 
        0x493, 0x49d, 0x4a3, 0x4a9, 0x4b1, 0x4bd, 0x4c1, 0x4c7, 0x4cd, 0x4cf, 0x4d5, 0x4e1, 0x4eb, 0x4fd, 0x4ff, 0x503, 
        0x509, 0x50b, 0x511, 0x515, 0x517, 0x51b, 0x527, 0x529, 0x52f, 0x551, 0x557, 0x55d, 0x565, 0x577, 0x581, 0x58f, 
        0x593, 0x595, 0x599, 0x59f, 0x5a7, 0x5ab, 0x5ad, 0x5b3, 0x5bf, 0x5c9, 0x5cb, 0x5cf, 0x5d1, 0x5d5, 0x5db, 0x5e7, 
        0x5f3, 0x5fb, 0x607, 0x60d, 0x611, 0x617, 0x61f, 0x623, 0x62b, 0x62f, 0x63d, 0x641, 0x647, 0x649, 0x64d, 0x653, 
        0x655, 0x65b, 0x665, 0x679, 0x67f, 0x683, 0x685, 0x69d, 0x6a1, 0x6a3, 0x6ad, 0x6b9, 0x6bb, 0x6c5, 0x6cd, 0x6d3, 
        0x6d9, 0x6df, 0x6f1, 0x6f7, 0x6fb, 0x6fd, 0x709, 0x713, 0x71f, 0x727, 0x737, 0x745, 0x74b, 0x74f, 0x751, 0x755, 
        0x757, 0x761, 0x76d, 0x773, 0x779, 0x78b, 0x78d, 0x79d, 0x79f, 0x7b5, 0x7bb, 0x7c3, 0x7c9, 0x7cd, 0x7cf, 0x7d3, 
        0x7db, 0x7e1, 0x7eb, 0x7ed, 0x7f7, 0x805, 0x80f, 0x815, 0x821, 0x823, 0x827, 0x829, 0x833, 0x83f, 0x841, 0x851, 
        0x853, 0x859, 0x85d, 0x85f, 0x869, 0x871, 0x883, 0x89b, 0x89f, 0x8a5, 0x8ad, 0x8bd, 0x8bf, 0x8c3, 0x8cb, 0x8db, 
        0x8dd, 0x8e1, 0x8e9, 0x8ef, 0x8f5, 0x8f9, 0x905, 0x907, 0x91d, 0x923, 0x925, 0x92b, 0x92f, 0x935, 0x943, 0x949, 
        0x94d, 0x94f, 0x955, 0x959, 0x95f, 0x96b, 0x971, 0x977, 0x985, 0x989, 0x98f, 0x99b, 0x9a3, 0x9a9, 0x9ad, 0x9c7, 
        0x9d9, 0x9e3, 0x9eb, 0x9ef, 0x9f5, 0x9f7, 0x9fd, 0xa13, 0xa1f, 0xa21, 0xa31, 0xa39, 0xa3d, 0xa49, 0xa57, 0xa61, 
        0xa63, 0xa67, 0xa6f, 0xa75, 0xa7b, 0xa7f, 0xa81, 0xa85, 0xa8b, 0xa93, 0xa97, 0xa99, 0xa9f, 0xaa9, 0xaab, 0xab5, 
        0xabd, 0xac1, 0xacf, 0xad9, 0xae5, 0xae7, 0xaed, 0xaf1, 0xaf3, 0xb03, 0xb11, 0xb15, 0xb1b, 0xb23, 0xb29, 0xb2d, 
        0xb3f, 0xb47, 0xb51, 0xb57, 0xb5d, 0xb65, 0xb6f, 0xb7b, 0xb89, 0xb8d, 0xb93, 0xb99, 0xb9b, 0xbb7, 0xbb9, 0xbc3, 
        0xbcb, 0xbcf, 0xbdd, 0xbe1, 0xbe9, 0xbf5, 0xbfb, 0xc07, 0xc0b, 0xc11, 0xc25, 0xc2f, 0xc31, 0xc41, 0xc5b, 0xc5f, 
        0xc61, 0xc6d, 0xc73, 0xc77, 0xc83, 0xc89, 0xc91, 0xc95, 0xc9d, 0xcb3, 0xcb5, 0xcb9, 0xcbb, 0xcc7, 0xce3, 0xce5, 
        0xceb, 0xcf1, 0xcf7, 0xcfb, 0xd01, 0xd03, 0xd0f, 0xd13, 0xd1f, 0xd21, 0xd2b, 0xd2d, 0xd3d, 0xd3f, 0xd4f, 0xd55, 
        0xd69, 0xd79, 0xd81, 0xd85, 0xd87, 0xd8b, 0xd8d, 0xda3, 0xdab, 0xdb7, 0xdbd, 0xdc7, 0xdc9, 0xdcd, 0xdd3, 0xdd5, 
        0xddb, 0xde5, 0xde7, 0xdf3, 0xdfd, 0xdff, 0xe09, 0xe17, 0xe1d, 0xe21, 0xe27, 0xe2f, 0xe35, 0xe3b, 0xe4b, 0xe57, 
        0xe59, 0xe5d, 0xe6b, 0xe71, 0xe75, 0xe7d, 0xe87, 0xe8f, 0xe95, 0xe9b, 0xeb1, 0xeb7, 0xeb9, 0xec3, 0xed1, 0xed5, 
        0xedb, 0xeed, 0xeef, 0xef9, 0xf07, 0xf0b, 0xf0d, 0xf17, 0xf25, 0xf29, 0xf31, 0xf43, 0xf47, 0xf4d, 0xf4f, 0xf53, 
        0xf59, 0xf5b, 0xf67, 0xf6b, 0xf7f, 0xf95, 0xfa1, 0xfa3, 0xfa7, 0xfad, 0xfb3, 0xfb5, 0xfbb, 0xfd1, 0xfd3, 0xfd9, 
        0xfe9, 0xfef, 0xffb, 0xffd, 0x1003, 0x100f, 0x101f, 0x1021, 0x1025, 0x102b, 0x1039, 0x103d, 0x103f, 0x1051, 0x1069, 0x1073, 
        0x1079, 0x107b, 0x1085, 0x1087, 0x1091, 0x1093, 0x109d, 0x10a3, 0x10a5, 0x10af, 0x10b1, 0x10bb, 0x10c1, 0x10c9, 0x10e7, 0x10f1, 
        0x10f3, 0x10fd, 0x1105, 0x110b, 0x1115, 0x1127, 0x112d, 0x1139, 0x1145, 0x1147, 0x1159, 0x115f, 0x1163, 0x1169, 0x116f, 0x1181, 
        0x1183, 0x118d, 0x119b, 0x11a1, 0x11a5, 0x11a7, 0x11ab, 0x11c3, 0x11c5, 0x11d1, 0x11d7, 0x11e7, 0x11ef, 0x11f5, 0x11fb, 0x120d, 
        0x121d, 0x121f, 0x1223, 0x1229, 0x122b, 0x1231, 0x1237, 0x1241, 0x1247, 0x1253, 0x125f, 0x1271, 0x1273, 0x1279, 0x127d, 0x128f, 
        0x1297, 0x12af, 0x12b3, 0x12b5, 0x12b9, 0x12bf, 0x12c1, 0x12cd, 0x12d1, 0x12df, 0x12fd, 0x1307, 0x130d, 0x1319, 0x1327, 0x132d, 
        0x1337, 0x1343, 0x1345, 0x1349, 0x134f, 0x1357, 0x135d, 0x1367, 0x1369, 0x136d, 0x137b, 0x1381, 0x1387, 0x138b, 0x1391, 0x1393, 
        0x139d, 0x139f, 0x13af, 0x13bb, 0x13c3, 0x13d5, 0x13d9, 0x13df, 0x13eb, 0x13ed, 0x13f3, 0x13f9, 0x13ff, 0x141b, 0x1421, 0x142f, 
        0x1433, 0x143b, 0x1445, 0x144d, 0x1459, 0x146b, 0x146f, 0x1471, 0x1475, 0x148d, 0x1499, 0x149f, 0x14a1, 0x14b1, 0x14b7, 0x14bd, 
        0x14cb, 0x14d5, 0x14e3, 0x14e7, 0x1505, 0x150b, 0x1511, 0x1517, 0x151f, 0x1525, 0x1529, 0x152b, 0x1537, 0x153d, 0x1541, 0x1543, 
        0x1549, 0x155f, 0x1565, 0x1567, 0x156b, 0x157d, 0x157f, 0x1583, 0x158f, 0x1591, 0x1597, 0x159b, 0x15b5, 0x15bb, 0x15c1, 0x15c5, 
        0x15cd, 0x15d7, 0x15f7, 0x1607, 0x1609, 0x160f, 0x1613, 0x1615, 0x1619, 0x161b, 0x1625, 0x1633, 0x1639, 0x163d, 0x1645, 0x164f, 
        0x1655, 0x1669, 0x166d, 0x166f, 0x1675, 0x1693, 0x1697, 0x169f, 0x16a9, 0x16af, 0x16b5, 0x16bd, 0x16c3, 0x16cf, 0x16d3, 0x16d9, 
        0x16db, 0x16e1, 0x16e5, 0x16eb, 0x16ed, 0x16f7, 0x16f9, 0x1709, 0x170f, 0x1723, 0x1727, 0x1733, 0x1741, 0x175d, 0x1763
     };

    internal Class897()
    {
        this.uint_1 = 1;
        this.uint_2 = new uint[20];
        this.uint_1 = 20;
    }

    internal Class897(Class897 A_0)
    {
        this.uint_1 = 1;
        this.uint_2 = (uint[]) A_0.uint_2.Clone();
        this.uint_1 = A_0.uint_1;
    }

    internal Class897(byte[] A_0)
    {
        this.uint_1 = 1;
        this.uint_1 = ((uint) A_0.Length) >> 2;
        int num = A_0.Length & 3;
        if (num != 0)
        {
            this.uint_1++;
        }
        this.uint_2 = new uint[this.uint_1];
        int index = A_0.Length - 1;
        for (int i = 0; index >= 3; i++)
        {
            this.uint_2[i] = (uint) ((((A_0[index - 3] << 0x18) | (A_0[index - 2] << 0x10)) | (A_0[index - 1] << 8)) | A_0[index]);
            index -= 4;
        }
        switch (num)
        {
            case 1:
                this.uint_2[(int) ((IntPtr) (this.uint_1 - 1))] = A_0[0];
                break;

            case 2:
                this.uint_2[(int) ((IntPtr) (this.uint_1 - 1))] = (uint) ((A_0[0] << 8) | A_0[1]);
                break;

            case 3:
                this.uint_2[(int) ((IntPtr) (this.uint_1 - 1))] = (uint) (((A_0[0] << 0x10) | (A_0[1] << 8)) | A_0[2]);
                break;
        }
        this.method_11();
    }

    internal Class897(uint[] A_0)
    {
        this.uint_1 = 1;
        this.uint_1 = (uint) A_0.Length;
        this.uint_2 = new uint[this.uint_1];
        int index = ((int) this.uint_1) - 1;
        for (int i = 0; index >= 0; i++)
        {
            this.uint_2[i] = A_0[index];
            index--;
        }
        this.method_11();
    }

    internal Class897(uint A_0)
    {
        this.uint_1 = 1;
        this.uint_2 = new uint[] { A_0 };
    }

    internal Class897(ulong A_0)
    {
        this.uint_1 = 1;
        this.uint_2 = new uint[] { (uint) A_0, (uint) (A_0 >> 0x20) };
        this.uint_1 = 2;
        this.method_11();
    }

    internal Class897(Class897 A_0, uint A_1)
    {
        this.uint_1 = 1;
        this.uint_2 = new uint[A_1];
        for (uint i = 0; i < A_0.uint_1; i++)
        {
            this.uint_2[i] = A_0.uint_2[i];
        }
        this.uint_1 = A_0.uint_1;
    }

    internal Class897(Sign A_0, uint A_1)
    {
        this.uint_1 = 1;
        this.uint_2 = new uint[A_1];
        this.uint_1 = A_1;
    }

    public int method_0()
    {
        this.method_11();
        uint num = this.uint_2[(int) ((IntPtr) (this.uint_1 - 1))];
        uint num2 = 0x80000000;
        uint num3 = 0x20;
        while (num3 > 0)
        {
            if ((num & num2) != 0)
            {
                break;
            }
            num3--;
            num2 = num2 >> 1;
        }
        num3 += (uint) ((this.uint_1 - 1) << 5);
        return (int) num3;
    }

    internal bool method_1(uint A_0)
    {
        uint index = A_0 >> 5;
        byte num2 = (byte) (A_0 & 0x1f);
        uint num3 = ((uint) 1) << num2;
        return ((this.uint_2[index] & num3) != 0);
    }

    internal string method_10(uint A_0, string A_1)
    {
        int num = 0x12;
        if (A_1.Length < A_0)
        {
            throw new ArgumentException(BookmarkStart.b("嬷刹崻䰽ጿ❁ぃ晅⑇⽉≋⥍⑏㩑瑓㩕㵗⥙⽛繝ᑟ੡գࡥ䡧ᡩ൫੭᥯ੱ", num), BookmarkStart.b("嬷刹崻䰽ℿ⅁ぃ⍅㩇᥉⥋㩍", num));
        }
        if (A_0 == 1)
        {
            throw new ArgumentException(BookmarkStart.b("氷刹夻䰽┿扁ⵃ㕅桇⑉⍋湍⍏❑㝓㹕硗⹙㑛㝝๟ա䑣ݥ᭧䩩ṫ཭ᑯ᭱౳噵᝷ᑹ᥻幽ﲇ", num), BookmarkStart.b("䨷嬹堻圽㠿", num));
        }
        if (smethod_24(this, 0))
        {
            return BookmarkStart.b("࠷", num);
        }
        if (smethod_24(this, 1))
        {
            return BookmarkStart.b("ष", num);
        }
        string str = "";
        Class897 class2 = new Class897(this);
        while (smethod_25(class2, 0))
        {
            uint num2 = Class900.smethod_5(class2, A_0);
            str = A_1[(int) num2] + str;
        }
        return str;
    }

    private void method_11()
    {
        while (this.uint_1 > 0)
        {
            if (this.uint_2[(int) ((IntPtr) (this.uint_1 - 1))] != 0)
            {
                break;
            }
            this.uint_1--;
        }
        if (this.uint_1 == 0)
        {
            this.uint_1++;
        }
    }

    internal void method_12()
    {
        for (int i = 0; i < this.uint_1; i++)
        {
            this.uint_2[i] = 0;
        }
    }

    internal Class897 method_13(Class897 A_0)
    {
        return Class900.smethod_16(this, A_0);
    }

    internal Class897 method_14(Class897 A_0)
    {
        return Class900.smethod_18(this, A_0);
    }

    internal Class897 method_15(Class897 A_0, Class897 A_1)
    {
        Class898 class2 = new Class898(A_1);
        return class2.method_3(this, A_0);
    }

    internal bool method_2(int A_0)
    {
        int num4 = 9;
        if (A_0 < 0)
        {
            throw new IndexOutOfRangeException(BookmarkStart.b("䴮堰䜲笴䈶吸ᬺ刼䨾㕀捂⩄ⅆ楈㥊ⱌⅎ㙐㙒", num4));
        }
        uint index = (uint) (A_0 >> 5);
        byte num2 = (byte) (A_0 & 0x1f);
        uint num3 = ((uint) 1) << num2;
        return ((this.uint_2[index] | num3) == this.uint_2[index]);
    }

    internal void method_3(uint A_0)
    {
        this.method_5(A_0, true);
    }

    internal void method_4(uint A_0)
    {
        this.method_5(A_0, false);
    }

    internal void method_5(uint A_0, bool A_1)
    {
        uint index = A_0 >> 5;
        if (index < this.uint_1)
        {
            uint num2 = ((uint) 1) << A_0;
            if (A_1)
            {
                this.uint_2[index] |= num2;
            }
            else
            {
                this.uint_2[index] &= ~num2;
            }
        }
    }

    internal int method_6()
    {
        if (smethod_24(this, 0))
        {
            return -1;
        }
        int num = 0;
        while (!this.method_2(num))
        {
            num++;
        }
        return num;
    }

    internal byte[] method_7()
    {
        if (smethod_24(this, 0))
        {
            return new byte[1];
        }
        int num5 = this.method_0();
        int num6 = num5 >> 3;
        if ((num5 & 7) != 0)
        {
            num6++;
        }
        byte[] buffer = new byte[num6];
        int num7 = num6 & 3;
        if (num7 == 0)
        {
            num7 = 4;
        }
        int num = 0;
        for (int i = ((int) this.uint_1) - 1; i >= 0; i--)
        {
            uint num3 = this.uint_2[i];
            for (int j = num7 - 1; j >= 0; j--)
            {
                buffer[num + j] = (byte) (num3 & 0xff);
                num3 = num3 >> 8;
            }
            num += num7;
            num7 = 4;
        }
        return buffer;
    }

    internal Sign method_8(Class897 A_0)
    {
        return Class900.smethod_4(this, A_0);
    }

    internal string method_9(uint A_0)
    {
        return this.method_10(A_0, BookmarkStart.b("ᜦᠨᤪḬᬮаԲȴ༶8稺缼簾Հق̈́FňɊ݌юᵐṒ᭔ᡖक़ਗ਼ཛྷ౞㕠㙢㍤てㅨ㉪㝬", 1));
    }

    public static Class897 smethod_0(uint A_0)
    {
        return new Class897(A_0);
    }

    public static Class897 smethod_1(int A_0)
    {
        int num = 4;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("尩䴫䈭䔯圱", num));
        }
        return new Class897((uint) A_0);
    }

    public static Class897 smethod_10(Class897 A_0, Class897 A_1)
    {
        return Class900.smethod_9(A_0, A_1)[0];
    }

    public static Class897 smethod_11(Class897 A_0, Class897 A_1)
    {
        int num = 6;
        if (smethod_24(A_0, 0) || smethod_24(A_1, 0))
        {
            return smethod_1(0);
        }
        if (A_0.uint_2.Length < A_0.uint_1)
        {
            throw new IndexOutOfRangeException(BookmarkStart.b("丫䜭įሱ嬳䌵䰷ᨹ医堽怿ぁ╃⡅⽇⽉", num));
        }
        if (A_1.uint_2.Length < A_1.uint_1)
        {
            throw new IndexOutOfRangeException(BookmarkStart.b("丫䜭ȯሱ嬳䌵䰷ᨹ医堽怿ぁ╃⡅⽇⽉", num));
        }
        Class897 class2 = new Class897(Sign.Positive, A_0.uint_1 + A_1.uint_1);
        Class900.smethod_13(A_0.uint_2, 0, A_0.uint_1, A_1.uint_2, 0, A_1.uint_1, class2.uint_2, 0);
        class2.method_11();
        return class2;
    }

    public static Class897 smethod_12(Class897 A_0, int A_1)
    {
        int num = 1;
        if (A_1 < 0)
        {
            throw new ArithmeticException(BookmarkStart.b("栦夨个弬丮䔰娲娴夶ᤸ䰺刼䨾ⵀ❂敄㕆ⱈ㽊㡌㵎㽐獒㑔睖㝘㹚㩜㹞ᕠ੢፤ɦ䥨ᵪ౬ͮѰᙲ", num));
        }
        if (A_1 == 0)
        {
            return smethod_1(0);
        }
        if (A_1 == 1)
        {
            return new Class897(A_0);
        }
        return Class900.smethod_12(A_0, (uint) A_1);
    }

    public static Class897 smethod_13(Class897 A_0, int A_1)
    {
        return Class900.smethod_10(A_0, A_1);
    }

    public static Class897 smethod_14(Class897 A_0, int A_1)
    {
        return Class900.smethod_11(A_0, A_1);
    }

    internal static Class897 smethod_15(Class897 A_0, Class897 A_1)
    {
        return smethod_4(A_0, A_1);
    }

    internal static Class897 smethod_16(Class897 A_0, Class897 A_1)
    {
        return smethod_5(A_0, A_1);
    }

    internal static int smethod_17(Class897 A_0, int A_1)
    {
        return smethod_6(A_0, A_1);
    }

    internal static uint smethod_18(Class897 A_0, uint A_1)
    {
        return smethod_7(A_0, A_1);
    }

    internal static Class897 smethod_19(Class897 A_0, Class897 A_1)
    {
        return smethod_8(A_0, A_1);
    }

    public static Class897 smethod_2(ulong A_0)
    {
        return new Class897(A_0);
    }

    internal static Class897 smethod_20(Class897 A_0, int A_1)
    {
        return smethod_9(A_0, A_1);
    }

    internal static Class897 smethod_21(Class897 A_0, Class897 A_1)
    {
        return smethod_10(A_0, A_1);
    }

    internal static Class897 smethod_22(Class897 A_0, Class897 A_1)
    {
        return smethod_11(A_0, A_1);
    }

    internal static Class897 smethod_23(Class897 A_0, int A_1)
    {
        return smethod_12(A_0, A_1);
    }

    public static bool smethod_24(Class897 A_0, uint A_1)
    {
        if (A_0.uint_1 != 1)
        {
            A_0.method_11();
        }
        return ((A_0.uint_1 == 1) && (A_0.uint_2[0] == A_1));
    }

    public static bool smethod_25(Class897 A_0, uint A_1)
    {
        if (A_0.uint_1 != 1)
        {
            A_0.method_11();
        }
        if (A_0.uint_1 == 1)
        {
            return (A_0.uint_2[0] != A_1);
        }
        return true;
    }

    public static bool smethod_26(Class897 A_0, Class897 A_1)
    {
        return ((A_0 == A_1) || ((!smethod_26(null, A_0) && !smethod_26(null, A_1)) && (Class900.smethod_4(A_0, A_1) == Sign.Zero)));
    }

    public static bool smethod_27(Class897 A_0, Class897 A_1)
    {
        if (A_0 == A_1)
        {
            return false;
        }
        if (!smethod_26(null, A_0) && !smethod_26(null, A_1))
        {
            return (Class900.smethod_4(A_0, A_1) != Sign.Zero);
        }
        return true;
    }

    public static bool smethod_28(Class897 A_0, Class897 A_1)
    {
        return (Class900.smethod_4(A_0, A_1) > Sign.Zero);
    }

    public static bool smethod_29(Class897 A_0, Class897 A_1)
    {
        return (Class900.smethod_4(A_0, A_1) < Sign.Zero);
    }

    internal static Class897 smethod_3(string A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䤦尨䘪伬䨮䌰", num));
        }
        int num2 = 0;
        int length = A_0.Length;
        bool flag = false;
        Class897 class2 = new Class897(0);
        if (A_0[0] == '+')
        {
            num2++;
        }
        else if (A_0[num2] == '-')
        {
            throw new ArgumentException(BookmarkStart.b("栦夨个弬丮䔰娲娴夶ᤸ䰺刼䨾ⵀ❂敄㕆ⱈ㽊㡌㵎㽐獒㑔睖㝘㹚㩜㹞ᕠ੢፤ɦ䥨ᵪ౬ͮѰᙲ", num));
        }
        while (num2 < length)
        {
            char c = A_0[num2];
            if (c == '\0')
            {
                num2 = length;
            }
            else
            {
                if ((c < '0') || (c > '9'))
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        throw new FormatException();
                    }
                    num2++;
                    while (num2 < length)
                    {
                        if (!char.IsWhiteSpace(A_0[num2]))
                        {
                            throw new FormatException();
                        }
                        num2++;
                    }
                    break;
                }
                class2 = smethod_4(smethod_12(class2, 10), smethod_1(c - '0'));
                flag = true;
            }
            num2++;
        }
        if (!flag)
        {
            throw new FormatException();
        }
        return class2;
    }

    public static bool smethod_30(Class897 A_0, Class897 A_1)
    {
        return (Class900.smethod_4(A_0, A_1) >= Sign.Zero);
    }

    public static bool smethod_31(Class897 A_0, Class897 A_1)
    {
        return (Class900.smethod_4(A_0, A_1) <= Sign.Zero);
    }

    public static Class897 smethod_4(Class897 A_0, Class897 A_1)
    {
        if (smethod_24(A_0, 0))
        {
            return new Class897(A_1);
        }
        if (smethod_24(A_1, 0))
        {
            return new Class897(A_0);
        }
        return Class900.smethod_0(A_0, A_1);
    }

    public static Class897 smethod_5(Class897 A_0, Class897 A_1)
    {
        int num = 12;
        if (smethod_24(A_1, 0))
        {
            return new Class897(A_0);
        }
        if (smethod_24(A_0, 0))
        {
            throw new ArithmeticException(BookmarkStart.b("紱䐳匵䨷嬹䠻圽⼿ⱁ摃ㅅ❇㽉⁋⩍灏⁑ㅓ≕ⵗ⡙㉛繝ş䉡੣ͥཧ୩ᡫݭٯ᝱味u᥷ᙹॻ᭽", num));
        }
        switch (Class900.smethod_4(A_0, A_1))
        {
            case Sign.Negative:
                throw new ArithmeticException(BookmarkStart.b("紱䐳匵䨷嬹䠻圽⼿ⱁ摃ㅅ❇㽉⁋⩍灏⁑ㅓ≕ⵗ⡙㉛繝ş䉡੣ͥཧ୩ᡫݭٯ᝱味u᥷ᙹॻ᭽", num));

            case Sign.Zero:
                return smethod_1(0);

            case Sign.Positive:
                return Class900.smethod_1(A_0, A_1);
        }
        throw new InvalidOperationException();
    }

    public static int smethod_6(Class897 A_0, int A_1)
    {
        if (A_1 > 0)
        {
            return (int) Class900.smethod_6(A_0, (uint) A_1);
        }
        return (int) -Class900.smethod_6(A_0, (uint) -A_1);
    }

    public static uint smethod_7(Class897 A_0, uint A_1)
    {
        return Class900.smethod_6(A_0, A_1);
    }

    public static Class897 smethod_8(Class897 A_0, Class897 A_1)
    {
        return Class900.smethod_9(A_0, A_1)[1];
    }

    public static Class897 smethod_9(Class897 A_0, int A_1)
    {
        int num = 3;
        if (A_1 <= 0)
        {
            throw new ArithmeticException(BookmarkStart.b("昨嬪䠬崮倰䜲尴堶圸ᬺ䨼倾㑀⽂⅄杆㭈⹊㥌㩎⍐㵒畔㙖祘㕚㡜㡞`ᝢ౤ᅦ౨䭪᭬๮ᵰٲၴ", num));
        }
        return Class900.smethod_7(A_0, (uint) A_1);
    }

    bool object.Equals(object A_0)
    {
        if (A_0 == null)
        {
            return false;
        }
        if (A_0 is int)
        {
            return ((((int) A_0) >= 0) && smethod_24(this, (uint) A_0));
        }
        return (Class900.smethod_4(this, (Class897) A_0) == Sign.Zero);
    }

    int object.GetHashCode()
    {
        uint num = 0;
        for (uint i = 0; i < this.uint_1; i++)
        {
            num ^= this.uint_2[i];
        }
        return (int) num;
    }

    string object.ToString()
    {
        return this.method_9(10);
    }

    internal class Class898
    {
        private Class897 class897_0;
        private Class897 class897_1;

        internal Class898(Class897 A_0)
        {
            this.class897_0 = A_0;
            uint index = this.class897_0.uint_1 << 1;
            this.class897_1 = new Class897(Class897.Sign.Positive, index + 1);
            this.class897_1.uint_2[index] = 1;
            this.class897_1 = Class897.smethod_10(this.class897_1, this.class897_0);
        }

        internal void method_0(Class897 A_0)
        {
            int num = 7;
            Class897 class2 = this.class897_0;
            uint num2 = class2.uint_1;
            uint num3 = num2 + 1;
            uint num4 = num2 - 1;
            if (A_0.uint_1 >= num2)
            {
                if (A_0.uint_2.Length < A_0.uint_1)
                {
                    throw new IndexOutOfRangeException(BookmarkStart.b("唬༮帰䘲䄴᜶嘸崺ᴼ䴾⁀ⵂ≄≆", num));
                }
                Class897 class5 = new Class897(Class897.Sign.Positive, (A_0.uint_1 - num4) + this.class897_1.uint_1);
                Class897.Class900.smethod_13(A_0.uint_2, num4, A_0.uint_1 - num4, this.class897_1.uint_2, 0, this.class897_1.uint_1, class5.uint_2, 0);
                uint num5 = (A_0.uint_1 > num3) ? num3 : A_0.uint_1;
                A_0.uint_1 = num5;
                A_0.method_11();
                Class897 class4 = new Class897(Class897.Sign.Positive, num3);
                Class897.Class900.smethod_14(class5.uint_2, (int) num3, (int) (class5.uint_1 - num3), class2.uint_2, 0, (int) class2.uint_1, class4.uint_2, 0, (int) num3);
                class4.method_11();
                if (Class897.smethod_31(class4, A_0))
                {
                    Class897.Class900.smethod_2(A_0, class4);
                }
                else
                {
                    Class897 class3 = new Class897(Class897.Sign.Positive, num3 + 1);
                    class3.uint_2[num3] = 1;
                    Class897.Class900.smethod_2(class3, class4);
                    Class897.Class900.smethod_3(A_0, class3);
                }
                while (Class897.smethod_30(A_0, class2))
                {
                    Class897.Class900.smethod_2(A_0, class2);
                }
            }
        }

        internal Class897 method_1(Class897 A_0, Class897 A_1)
        {
            if (Class897.smethod_24(A_0, 0) || Class897.smethod_24(A_1, 0))
            {
                return Class897.smethod_1(0);
            }
            if (A_0.uint_1 >= (this.class897_0.uint_1 << 1))
            {
                A_0 = Class897.smethod_8(A_0, this.class897_0);
            }
            if (A_1.uint_1 >= (this.class897_0.uint_1 << 1))
            {
                A_1 = Class897.smethod_8(A_1, this.class897_0);
            }
            if (A_0.uint_1 >= this.class897_0.uint_1)
            {
                this.method_0(A_0);
            }
            if (A_1.uint_1 >= this.class897_0.uint_1)
            {
                this.method_0(A_1);
            }
            Class897 class2 = new Class897(Class897.smethod_11(A_0, A_1));
            this.method_0(class2);
            return class2;
        }

        internal Class897 method_2(Class897 A_0, Class897 A_1)
        {
            Class897 class2;
            Class897.Sign sign = Class897.Class900.smethod_4(A_0, A_1);
            switch (sign)
            {
                case Class897.Sign.Negative:
                    class2 = Class897.smethod_5(A_1, A_0);
                    break;

                case Class897.Sign.Zero:
                    return Class897.smethod_1(0);

                case Class897.Sign.Positive:
                    class2 = Class897.smethod_5(A_0, A_1);
                    break;

                default:
                    throw new InvalidOperationException();
            }
            if (Class897.smethod_30(class2, this.class897_0))
            {
                if (class2.uint_1 >= (this.class897_0.uint_1 << 1))
                {
                    class2 = Class897.smethod_8(class2, this.class897_0);
                }
                else
                {
                    this.method_0(class2);
                }
            }
            if (sign == Class897.Sign.Negative)
            {
                class2 = Class897.smethod_5(this.class897_0, class2);
            }
            return class2;
        }

        internal Class897 method_3(Class897 A_0, Class897 A_1)
        {
            if ((this.class897_0.uint_2[0] & 1) == 1)
            {
                return this.method_5(A_0, A_1);
            }
            return this.method_4(A_0, A_1);
        }

        internal Class897 method_4(Class897 A_0, Class897 A_1)
        {
            Class897 class2 = new Class897(Class897.smethod_1(1), this.class897_0.uint_1 << 1);
            Class897 class3 = new Class897(Class897.smethod_8(A_0, this.class897_0), this.class897_0.uint_1 << 1);
            uint num = (uint) A_1.method_0();
            uint[] array = new uint[this.class897_0.uint_1 << 1];
            for (uint i = 0; i < num; i++)
            {
                if (A_1.method_1(i))
                {
                    Array.Clear(array, 0, array.Length);
                    Class897.Class900.smethod_13(class2.uint_2, 0, class2.uint_1, class3.uint_2, 0, class3.uint_1, array, 0);
                    class2.uint_1 += class3.uint_1;
                    uint[] numArray2 = array;
                    array = class2.uint_2;
                    class2.uint_2 = numArray2;
                    this.method_0(class2);
                }
                Class897.Class900.smethod_15(class3, ref array);
                this.method_0(class3);
                if (Class897.smethod_24(class3, 1))
                {
                    return class2;
                }
            }
            return class2;
        }

        private Class897 method_5(Class897 A_0, Class897 A_1)
        {
            Class897 class2 = new Class897(Class897.Class899.smethod_1(Class897.smethod_1(1), this.class897_0), this.class897_0.uint_1 << 1);
            Class897 class3 = new Class897(Class897.Class899.smethod_1(A_0, this.class897_0), this.class897_0.uint_1 << 1);
            uint num = Class897.Class899.smethod_0(this.class897_0.uint_2[0]);
            uint num2 = (uint) A_1.method_0();
            uint[] array = new uint[this.class897_0.uint_1 << 1];
            for (uint i = 0; i < num2; i++)
            {
                if (A_1.method_1(i))
                {
                    Array.Clear(array, 0, array.Length);
                    Class897.Class900.smethod_13(class2.uint_2, 0, class2.uint_1, class3.uint_2, 0, class3.uint_1, array, 0);
                    class2.uint_1 += class3.uint_1;
                    uint[] numArray2 = array;
                    array = class2.uint_2;
                    class2.uint_2 = numArray2;
                    Class897.Class899.smethod_2(class2, this.class897_0, num);
                }
                Class897.Class900.smethod_15(class3, ref array);
                Class897.Class899.smethod_2(class3, this.class897_0, num);
            }
            Class897.Class899.smethod_2(class2, this.class897_0, num);
            return class2;
        }

        internal Class897 method_6(uint A_0, Class897 A_1)
        {
            if ((this.class897_0.uint_2[0] & 1) == 1)
            {
                return this.method_7(A_0, A_1);
            }
            return this.method_8(A_0, A_1);
        }

        private Class897 method_7(uint A_0, Class897 A_1)
        {
            uint num3;
            uint num7;
            uint num8;
            uint[] numArray3;
            uint num10;
            uint num11;
            A_1.method_11();
            uint[] numArray = new uint[this.class897_0.uint_1 << 2];
            Class897 class2 = new Class897(Class897.Class899.smethod_1(Class897.smethod_0(A_0), this.class897_0), this.class897_0.uint_1 << 2);
            uint num = Class897.Class899.smethod_0(this.class897_0.uint_2[0]);
            uint num2 = (uint) (A_1.method_0() - 2);
            goto Label_02DD;
        Label_0061:
            if (num2-- > 0)
            {
                goto Label_02DD;
            }
            return Class897.Class899.smethod_2(class2, this.class897_0, num);
        Label_02AB:
            while (Class897.smethod_30(class2, this.class897_0))
            {
                Class897.Class900.smethod_2(class2, this.class897_0);
            }
            goto Label_0061;
        Label_02DD:
            Class897.Class900.smethod_15(class2, ref numArray);
            class2 = Class897.Class899.smethod_2(class2, this.class897_0, num);
            if (!A_1.method_1(num2))
            {
                goto Label_0061;
            }
            uint[] numArray2 = class2.uint_2;
            uint index = 0;
            ulong num6 = 0L;
            do
            {
                num6 += numArray2[index] * A_0;
                numArray2[index] = (uint) num6;
                num6 = num6 >> 0x20;
            }
            while (++index < class2.uint_1);
            if (class2.uint_1 < this.class897_0.uint_1)
            {
                if (num6 != 0L)
                {
                    numArray2[index] = (uint) num6;
                    class2.uint_1++;
                    while (Class897.smethod_30(class2, this.class897_0))
                    {
                        Class897.Class900.smethod_2(class2, this.class897_0);
                    }
                }
                goto Label_0061;
            }
            if (num6 == 0L)
            {
                while (Class897.smethod_30(class2, this.class897_0))
                {
                    Class897.Class900.smethod_2(class2, this.class897_0);
                }
                goto Label_0061;
            }
            uint num5 = (uint) num6;
            if (this.class897_0.uint_2[(int) ((IntPtr) (this.class897_0.uint_1 - 1))] < uint.MaxValue)
            {
                num8 = (uint) (((num5 << 0x20) | numArray2[(int) ((IntPtr) (index - 1))]) / ((ulong) (this.class897_0.uint_2[(int) ((IntPtr) (this.class897_0.uint_1 - 1))] + 1)));
            }
            else
            {
                num8 = (uint) (((num5 << 0x20) | numArray2[(int) ((IntPtr) (index - 1))]) / ((ulong) this.class897_0.uint_2[(int) ((IntPtr) (this.class897_0.uint_1 - 1))]));
            }
            index = 0;
            num6 = 0L;
        Label_01D3:
            num6 += this.class897_0.uint_2[index] * num8;
            uint num9 = numArray2[index];
            numArray2[index] -= (uint) num6;
            num6 = num6 >> 0x20;
            if (numArray2[index] > num9)
            {
                num6 += (ulong) 1L;
            }
            index++;
            if (index >= class2.uint_1)
            {
                num5 -= (uint) num6;
                if (num5 == 0)
                {
                    goto Label_02AB;
                }
                num3 = 0;
                num7 = 0;
                numArray3 = this.class897_0.uint_2;
            }
            else
            {
                goto Label_01D3;
            }
        Label_025B:
            num10 = numArray3[num7];
            numArray2[num7] = num11 = numArray2[num7] - num10;
            if (!(((num10 += num3) < num3) | (num11 > ~num10)))
            {
                num3 = 0;
            }
            else
            {
                num3 = 1;
            }
            num7++;
            if (num7 >= class2.uint_1)
            {
                num5 -= num3;
            }
            else
            {
                goto Label_025B;
            }
            goto Label_02AB;
        }

        private Class897 method_8(uint A_0, Class897 A_1)
        {
            uint num2;
            uint num3;
            uint[] numArray2;
            uint num9;
            uint num10;
            A_1.method_11();
            uint[] numArray = new uint[this.class897_0.uint_1 << 2];
            Class897 class2 = new Class897(Class897.smethod_0(A_0), this.class897_0.uint_1 << 2);
            uint num = (uint) (A_1.method_0() - 2);
            goto Label_0276;
        Label_0236:
            while (Class897.smethod_30(class2, this.class897_0))
            {
                Class897.Class900.smethod_2(class2, this.class897_0);
            }
        Label_0260:
            if (num-- <= 0)
            {
                return class2;
            }
        Label_0276:
            Class897.Class900.smethod_15(class2, ref numArray);
            if (class2.uint_1 >= this.class897_0.uint_1)
            {
                this.method_0(class2);
            }
            if (!A_1.method_1(num))
            {
                goto Label_0260;
            }
            uint[] numArray3 = class2.uint_2;
            uint index = 0;
            ulong num4 = 0L;
            do
            {
                num4 += numArray3[index] * A_0;
                numArray3[index] = (uint) num4;
                num4 = num4 >> 0x20;
            }
            while (++index < class2.uint_1);
            if (class2.uint_1 < this.class897_0.uint_1)
            {
                if (num4 != 0L)
                {
                    numArray3[index] = (uint) num4;
                    class2.uint_1++;
                    while (Class897.smethod_30(class2, this.class897_0))
                    {
                        Class897.Class900.smethod_2(class2, this.class897_0);
                    }
                }
                goto Label_0260;
            }
            if (num4 == 0L)
            {
                while (Class897.smethod_30(class2, this.class897_0))
                {
                    Class897.Class900.smethod_2(class2, this.class897_0);
                }
                goto Label_0260;
            }
            uint num6 = (uint) num4;
            uint num7 = (uint) (((num6 << 0x20) | numArray3[(int) ((IntPtr) (index - 1))]) / ((ulong) (this.class897_0.uint_2[(int) ((IntPtr) (this.class897_0.uint_1 - 1))] + 1)));
            index = 0;
            num4 = 0L;
        Label_0164:
            num4 += this.class897_0.uint_2[index] * num7;
            uint num8 = numArray3[index];
            numArray3[index] -= (uint) num4;
            num4 = num4 >> 0x20;
            if (numArray3[index] > num8)
            {
                num4 += (ulong) 1L;
            }
            index++;
            if (index >= class2.uint_1)
            {
                num6 -= (uint) num4;
                if (num6 == 0)
                {
                    goto Label_0236;
                }
                num2 = 0;
                num3 = 0;
                numArray2 = this.class897_0.uint_2;
            }
            else
            {
                goto Label_0164;
            }
        Label_01E9:
            num9 = numArray2[num3];
            numArray3[num3] = num10 = numArray3[num3] - num9;
            if (!(((num9 += num2) < num2) | (num10 > ~num9)))
            {
                num2 = 0;
            }
            else
            {
                num2 = 1;
            }
            num3++;
            if (num3 >= class2.uint_1)
            {
                num6 -= num2;
            }
            else
            {
                goto Label_01E9;
            }
            goto Label_0236;
        }
    }

    internal class Class899
    {
        private Class899()
        {
        }

        internal static uint smethod_0(uint A_0)
        {
            uint num2;
            uint num = A_0;
            while ((num2 = A_0 * num) != 1)
            {
                num *= 2 - num2;
            }
            return (uint) -((ulong) num);
        }

        internal static Class897 smethod_1(Class897 A_0, Class897 A_1)
        {
            A_0.method_11();
            A_1.method_11();
            A_0 = Class897.smethod_13(A_0, (int) (A_1.uint_1 * 0x20));
            A_0 = Class897.smethod_8(A_0, A_1);
            return A_0;
        }

        internal static Class897 smethod_2(Class897 A_0, Class897 A_1, uint A_2)
        {
            Class897 class2 = A_0;
            uint[] numArray = class2.uint_2;
            uint[] numArray2 = A_1.uint_2;
            for (uint i = 0; i < A_1.uint_1; i++)
            {
                uint num6 = numArray[0] * A_2;
                uint num7 = 0;
                uint num5 = 0;
                uint num3 = 0;
                num7 = 1;
                num5 = 1;
                ulong num4 = (num6 * numArray2[0]) + numArray[0];
                num4 = num4 >> 0x20;
                uint num2 = 1;
                while (num2 < A_1.uint_1)
                {
                    num4 += (num6 * numArray2[num7++]) + numArray[num5++];
                    numArray[num3++] = (uint) num4;
                    num4 = num4 >> 0x20;
                    num2++;
                }
                while (num2 < class2.uint_1)
                {
                    num4 += numArray[num5++];
                    numArray[num3++] = (uint) num4;
                    num4 = num4 >> 0x20;
                    if (num4 == 0L)
                    {
                        goto Label_00D5;
                    }
                    num2++;
                }
                goto Label_00F7;
            Label_00D5:
                num2++;
            Label_00F7:
                while (num2 < class2.uint_1)
                {
                    numArray[num3++] = numArray[num5++];
                    num2++;
                }
                numArray[num3++] = (uint) num4;
            }
            while (class2.uint_1 > 1)
            {
                if (numArray[(int) ((IntPtr) (class2.uint_1 - 1))] != 0)
                {
                    break;
                }
                class2.uint_1--;
            }
            if (Class897.smethod_30(class2, A_1))
            {
                Class897.Class900.smethod_2(class2, A_1);
            }
            return class2;
        }
    }

    private class Class900
    {
        internal static Class897 smethod_0(Class897 A_0, Class897 A_1)
        {
            uint[] numArray;
            uint num2;
            uint[] numArray2;
            uint num3;
            bool flag;
            uint index = 0;
            if (A_0.uint_1 < A_1.uint_1)
            {
                numArray = A_1.uint_2;
                num2 = A_1.uint_1;
                numArray2 = A_0.uint_2;
                num3 = A_0.uint_1;
            }
            else
            {
                numArray = A_0.uint_2;
                num2 = A_0.uint_1;
                numArray2 = A_1.uint_2;
                num3 = A_1.uint_1;
            }
            Class897 class2 = new Class897(Class897.Sign.Positive, num2 + 1);
            uint[] numArray3 = class2.uint_2;
            ulong num5 = 0L;
            do
            {
                num5 = (numArray[index] + numArray2[index]) + num5;
                numArray3[index] = (uint) num5;
                num5 = num5 >> 0x20;
            }
            while (++index < num3);
            if (flag = num5 != 0L)
            {
                if (index < num2)
                {
                    do
                    {
                        uint num4;
                        numArray3[index] = num4 = numArray[index] + 1;
                        flag = num4 == 0;
                    }
                    while ((++index < num2) && flag);
                }
                if (flag)
                {
                    numArray3[index] = 1;
                    class2.uint_1 = ++index;
                    return class2;
                }
            }
            if (index < num2)
            {
                do
                {
                    numArray3[index] = numArray[index];
                }
                while (++index < num2);
            }
            class2.method_11();
            return class2;
        }

        internal static Class897 smethod_1(Class897 A_0, Class897 A_1)
        {
            Class897 class2 = new Class897(Class897.Sign.Positive, A_0.uint_1);
            uint[] numArray = class2.uint_2;
            uint[] numArray2 = A_0.uint_2;
            uint[] numArray3 = A_1.uint_2;
            uint index = 0;
            uint num2 = 0;
            while (true)
            {
                uint num4;
                uint num3 = numArray3[index];
                numArray[index] = num4 = numArray2[index] - num3;
                if (!(((num3 += num2) < num2) | (num4 > ~num3)))
                {
                    num2 = 0;
                }
                else
                {
                    num2 = 1;
                }
                if (++index >= A_1.uint_1)
                {
                    if (index == A_0.uint_1)
                    {
                        goto Label_00C8;
                    }
                    if (num2 == 1)
                    {
                        do
                        {
                            numArray[index] = numArray2[index] - 1;
                        }
                        while ((numArray2[index++] == 0) && (index < A_0.uint_1));
                        if (index == A_0.uint_1)
                        {
                            goto Label_00C8;
                        }
                    }
                    break;
                }
            }
            do
            {
                numArray[index] = numArray2[index];
            }
            while (++index < A_0.uint_1);
        Label_00C8:
            class2.method_11();
            return class2;
        }

        internal static Class897 smethod_10(Class897 A_0, int A_1)
        {
            if (A_1 == 0)
            {
                return new Class897(A_0, A_0.uint_1 + 1);
            }
            int num3 = A_1 >> 5;
            A_1 &= 0x1f;
            Class897 class2 = new Class897(Class897.Sign.Positive, (A_0.uint_1 + 1) + ((uint) num3));
            uint index = 0;
            uint num2 = A_0.uint_1;
            if (A_1 == 0)
            {
                while (index < num2)
                {
                    class2.uint_2[(int) ((IntPtr) (index + num3))] = A_0.uint_2[index];
                    index++;
                }
            }
            else
            {
                uint num4 = 0;
                while (index < num2)
                {
                    uint num5 = A_0.uint_2[index];
                    class2.uint_2[(int) ((IntPtr) (index + num3))] = (num5 << A_1) | num4;
                    num4 = num5 >> (0x20 - A_1);
                    index++;
                }
                class2.uint_2[(int) ((IntPtr) (index + num3))] = num4;
            }
            class2.method_11();
            return class2;
        }

        internal static Class897 smethod_11(Class897 A_0, int A_1)
        {
            if (A_1 == 0)
            {
                return new Class897(A_0);
            }
            int num2 = A_1 >> 5;
            int num3 = A_1 & 0x1f;
            Class897 class2 = new Class897(Class897.Sign.Positive, (uint) ((A_0.uint_1 - num2) + 1));
            uint index = (uint) (class2.uint_2.Length - 1);
            if (num3 == 0)
            {
                while (index-- > 0)
                {
                    class2.uint_2[index] = A_0.uint_2[(int) ((IntPtr) (index + num2))];
                }
            }
            else
            {
                uint num5;
                for (uint i = 0; index-- > 0; i = num5 << (0x20 - A_1))
                {
                    num5 = A_0.uint_2[(int) ((IntPtr) (index + num2))];
                    class2.uint_2[index] = (num5 >> A_1) | i;
                }
            }
            class2.method_11();
            return class2;
        }

        internal static Class897 smethod_12(Class897 A_0, uint A_1)
        {
            Class897 class2 = new Class897(Class897.Sign.Positive, A_0.uint_1 + 1);
            uint index = 0;
            ulong num2 = 0L;
            do
            {
                num2 += A_0.uint_2[index] * A_1;
                class2.uint_2[index] = (uint) num2;
                num2 = num2 >> 0x20;
            }
            while (++index < A_0.uint_1);
            class2.uint_2[index] = (uint) num2;
            class2.method_11();
            return class2;
        }

        internal static void smethod_13(uint[] A_0, uint A_1, uint A_2, uint[] A_3, uint A_4, uint A_5, uint[] A_6, uint A_7)
        {
            uint index = A_1;
            uint num2 = index + A_2;
            uint num3 = A_4;
            uint num4 = num3 + A_5;
            for (uint i = A_7; index < num2; i++)
            {
                if (A_0[index] != 0)
                {
                    ulong num7 = 0L;
                    uint num6 = i;
                    uint num8 = num3;
                    while (num8 < num4)
                    {
                        num7 += (A_0[index] * A_3[num8]) + A_6[num6];
                        A_6[num6] = (uint) num7;
                        num7 = num7 >> 0x20;
                        num8++;
                        num6++;
                    }
                    if (num7 != 0L)
                    {
                        A_6[num6] = (uint) num7;
                    }
                }
                index++;
            }
        }

        internal static void smethod_14(uint[] A_0, int A_1, int A_2, uint[] A_3, int A_4, int A_5, uint[] A_6, int A_7, int A_8)
        {
            uint index = (uint) A_1;
            uint num2 = index + ((uint) A_2);
            uint num3 = (uint) A_4;
            uint num4 = num3 + ((uint) A_5);
            uint num5 = (uint) A_7;
            uint num6 = num5 + ((uint) A_8);
            while (index < num2)
            {
                if (A_0[index] != 0)
                {
                    ulong num7 = 0L;
                    uint num8 = num5;
                    uint num9 = num3;
                    while (num9 < num4)
                    {
                        if (num8 >= num6)
                        {
                            break;
                        }
                        num7 += (A_0[index] * A_3[num9]) + A_6[num8];
                        A_6[num8] = (uint) num7;
                        num7 = num7 >> 0x20;
                        num9++;
                        num8++;
                    }
                    if ((num7 != 0L) && (num8 < num6))
                    {
                        A_6[num8] = (uint) num7;
                    }
                }
                index++;
                num5++;
            }
        }

        internal static void smethod_15(Class897 A_0, ref uint[] A_1)
        {
            uint[] numArray = A_1;
            A_1 = A_0.uint_2;
            uint[] numArray2 = A_0.uint_2;
            uint num = A_0.uint_1;
            A_0.uint_2 = numArray;
            uint length = (uint) numArray.Length;
            for (uint i = 0; i < length; i++)
            {
                numArray[i] = 0;
            }
            uint index = 0;
            uint num4 = 0;
            uint num13 = 0;
            while (num13 < num)
            {
                if (numArray2[index] != 0)
                {
                    ulong num6 = 0L;
                    uint num7 = numArray2[index];
                    uint num8 = index + 1;
                    uint num9 = (num4 + (2 * num13)) + 1;
                    uint num10 = num13 + 1;
                    while (num10 < num)
                    {
                        num6 += (num7 * numArray2[num8]) + numArray[num9];
                        numArray[num9] = (uint) num6;
                        num6 = num6 >> 0x20;
                        num10++;
                        num9++;
                        num8++;
                    }
                    if (num6 != 0L)
                    {
                        numArray[num9] = (uint) num6;
                    }
                }
                num13++;
                index++;
            }
            num4 = 0;
            uint num5 = 0;
            while (num4 < length)
            {
                uint num15 = numArray[num4];
                numArray[num4] = (num15 << 1) | num5;
                num5 = num15 >> 0x1f;
                num4++;
            }
            if (num5 != 0)
            {
                numArray[num4] = num5;
            }
            index = 0;
            num4 = 0;
            uint num12 = 0 + num;
            while (index < num12)
            {
                ulong num16 = (numArray2[index] * numArray2[index]) + numArray[num4];
                numArray[num4] = (uint) num16;
                num16 = num16 >> 0x20;
                numArray[(int) ((IntPtr) (++num4))] += (uint) num16;
                if (numArray[num4] < ((uint) num16))
                {
                    uint num14 = num4;
                    numArray[++num14]++;
                    while (numArray[num14++] == 0)
                    {
                        numArray[num14]++;
                    }
                }
                index++;
                num4++;
            }
            A_0.uint_1 = A_0.uint_1 << 1;
            while (numArray[(int) ((IntPtr) (A_0.uint_1 - 1))] == 0)
            {
                if (A_0.uint_1 <= 1)
                {
                    break;
                }
                A_0.uint_1--;
            }
        }

        internal static Class897 smethod_16(Class897 A_0, Class897 A_1)
        {
            Class897 class2 = A_0;
            Class897 class3 = A_1;
            Class897 class4 = class3;
            while (class2.uint_1 > 1)
            {
                class4 = class2;
                class2 = Class897.smethod_8(class3, class2);
                class3 = class4;
            }
            if (Class897.smethod_24(class2, 0))
            {
                return class4;
            }
            uint num = class2.uint_2[0];
            uint num2 = Class897.smethod_7(class3, num);
            int num3 = 0;
            while (((num2 | num) & 1) == 0)
            {
                num2 = num2 >> 1;
                num = num >> 1;
                num3++;
            }
            while (num2 != 0)
            {
                while ((num2 & 1) == 0)
                {
                    num2 = num2 >> 1;
                }
                while ((num & 1) == 0)
                {
                    num = num >> 1;
                }
                if (num2 >= num)
                {
                    num2 = (num2 - num) >> 1;
                }
                else
                {
                    num = (num - num2) >> 1;
                }
            }
            return Class897.smethod_0(num << num3);
        }

        internal static uint smethod_17(Class897 A_0, uint A_1)
        {
            uint num = A_1;
            uint num2 = Class897.smethod_7(A_0, A_1);
            uint num3 = 0;
            uint num4 = 1;
            while (num2 != 0)
            {
                if (num2 == 1)
                {
                    return num4;
                }
                num3 += (num / num2) * num4;
                num = num % num2;
                switch (num)
                {
                    case 0:
                        goto Label_0042;

                    case 1:
                        return (A_1 - num3);
                }
                num4 += (num2 / num) * num3;
                num2 = num2 % num;
            }
        Label_0042:
            return 0;
        }

        internal static Class897 smethod_18(Class897 A_0, Class897 A_1)
        {
            int num = 10;
            if (A_1.uint_1 == 1)
            {
                return Class897.smethod_0(smethod_17(A_0, A_1.uint_2[0]));
            }
            Class897[] classArray5 = new Class897[] { Class897.smethod_1(0), Class897.smethod_1(1) };
            Class897[] classArray3 = new Class897[2];
            Class897[] classArray = new Class897[] { Class897.smethod_1(0), Class897.smethod_1(0) };
            int num2 = 0;
            Class897 class3 = A_1;
            Class897 class2 = A_0;
            Class897.Class898 class4 = new Class897.Class898(A_1);
            while (Class897.smethod_25(class2, 0))
            {
                if (num2 > 1)
                {
                    Class897 class5 = class4.method_2(classArray5[0], Class897.smethod_11(classArray5[1], classArray3[0]));
                    classArray5[0] = classArray5[1];
                    classArray5[1] = class5;
                }
                Class897[] classArray2 = smethod_9(class3, class2);
                classArray3[0] = classArray3[1];
                classArray3[1] = classArray2[0];
                classArray[0] = classArray[1];
                classArray[1] = classArray2[1];
                class3 = class2;
                class2 = classArray2[1];
                num2++;
            }
            if (Class897.smethod_25(classArray[0], 1))
            {
                throw new ArithmeticException(BookmarkStart.b("縯崱ᐳ張嘷䰹夻䰽㌿❁敃", num));
            }
            return class4.method_2(classArray5[0], Class897.smethod_11(classArray5[1], classArray3[0]));
        }

        internal static void smethod_2(Class897 A_0, Class897 A_1)
        {
            uint[] numArray = A_0.uint_2;
            uint[] numArray2 = A_1.uint_2;
            uint index = 0;
            uint num2 = 0;
            while (true)
            {
                uint num4;
                uint num3 = numArray2[index];
                numArray[index] = num4 = numArray[index] - num3;
                if (!(((num3 += num2) < num2) | (num4 > ~num3)))
                {
                    num2 = 0;
                }
                else
                {
                    num2 = 1;
                }
                if (++index >= A_1.uint_1)
                {
                    if ((index != A_0.uint_1) && (num2 == 1))
                    {
                        do
                        {
                            numArray[index]--;
                        }
                        while ((numArray[index++] == 0) && (index < A_0.uint_1));
                    }
                    break;
                }
            }
            while (A_0.uint_1 > 0)
            {
                if (A_0.uint_2[(int) ((IntPtr) (A_0.uint_1 - 1))] != 0)
                {
                    break;
                }
                A_0.uint_1--;
            }
            if (A_0.uint_1 == 0)
            {
                A_0.uint_1++;
            }
        }

        internal static void smethod_3(Class897 A_0, Class897 A_1)
        {
            uint[] numArray;
            uint num2;
            uint[] numArray2;
            uint num3;
            bool flag2;
            uint index = 0;
            bool flag = false;
            if (A_0.uint_1 < A_1.uint_1)
            {
                flag = true;
                numArray = A_1.uint_2;
                num2 = A_1.uint_1;
                numArray2 = A_0.uint_2;
                num3 = A_0.uint_1;
            }
            else
            {
                numArray = A_0.uint_2;
                num2 = A_0.uint_1;
                numArray2 = A_1.uint_2;
                num3 = A_1.uint_1;
            }
            uint[] numArray3 = A_0.uint_2;
            ulong num5 = 0L;
            do
            {
                num5 += numArray[index] + numArray2[index];
                numArray3[index] = (uint) num5;
                num5 = num5 >> 0x20;
            }
            while (++index < num3);
            if (flag2 = num5 != 0L)
            {
                if (index < num2)
                {
                    do
                    {
                        uint num4;
                        numArray3[index] = num4 = numArray[index] + 1;
                        flag2 = num4 == 0;
                    }
                    while ((++index < num2) && flag2);
                }
                if (flag2)
                {
                    numArray3[index] = 1;
                    A_0.uint_1 = ++index;
                    return;
                }
            }
            if (flag && (index < (num2 - 1)))
            {
                do
                {
                    numArray3[index] = numArray[index];
                }
                while (++index < num2);
            }
            A_0.uint_1 = num2 + 1;
            A_0.method_11();
        }

        internal static Class897.Sign smethod_4(Class897 A_0, Class897 A_1)
        {
            uint num = A_0.uint_1;
            uint num2 = A_1.uint_1;
            while (true)
            {
                if ((num <= 0) || (A_0.uint_2[(int) ((IntPtr) (num - 1))] != 0))
                {
                    break;
                }
                num--;
            }
            while (num2 > 0)
            {
                if (A_1.uint_2[(int) ((IntPtr) (num2 - 1))] != 0)
                {
                    break;
                }
                num2--;
            }
            if ((num != 0) || (num2 != 0))
            {
                if (num < num2)
                {
                    return Class897.Sign.Negative;
                }
                if (num > num2)
                {
                    return Class897.Sign.Positive;
                }
                uint index = num - 1;
                while (index != 0)
                {
                    if (A_0.uint_2[index] != A_1.uint_2[index])
                    {
                        break;
                    }
                    index--;
                }
                if (A_0.uint_2[index] < A_1.uint_2[index])
                {
                    return Class897.Sign.Negative;
                }
                if (A_0.uint_2[index] > A_1.uint_2[index])
                {
                    return Class897.Sign.Positive;
                }
            }
            return Class897.Sign.Zero;
        }

        internal static uint smethod_5(Class897 A_0, uint A_1)
        {
            ulong num = 0L;
            uint index = A_0.uint_1;
            while (index-- > 0)
            {
                num = num << 0x20;
                num |= A_0.uint_2[index];
                A_0.uint_2[index] = (uint) (num / ((ulong) A_1));
                num = num % ((ulong) A_1);
            }
            A_0.method_11();
            return (uint) num;
        }

        internal static uint smethod_6(Class897 A_0, uint A_1)
        {
            ulong num = 0L;
            uint index = A_0.uint_1;
            while (index-- > 0)
            {
                num = num << 0x20;
                num |= A_0.uint_2[index];
                num = num % ((ulong) A_1);
            }
            return (uint) num;
        }

        internal static Class897 smethod_7(Class897 A_0, uint A_1)
        {
            Class897 class2 = new Class897(Class897.Sign.Positive, A_0.uint_1);
            ulong num = 0L;
            uint index = A_0.uint_1;
            while (index-- > 0)
            {
                num = num << 0x20;
                num |= A_0.uint_2[index];
                class2.uint_2[index] = (uint) (num / ((ulong) A_1));
                num = num % ((ulong) A_1);
            }
            class2.method_11();
            return class2;
        }

        internal static Class897[] smethod_8(Class897 A_0, uint A_1)
        {
            Class897 class2 = new Class897(Class897.Sign.Positive, A_0.uint_1);
            ulong num = 0L;
            uint index = A_0.uint_1;
            while (index-- > 0)
            {
                num = num << 0x20;
                num |= A_0.uint_2[index];
                class2.uint_2[index] = (uint) (num / ((ulong) A_1));
                num = num % ((ulong) A_1);
            }
            class2.method_11();
            Class897 class3 = Class897.smethod_0((uint) num);
            return new Class897[] { class2, class3 };
        }

        internal static Class897[] smethod_9(Class897 A_0, Class897 A_1)
        {
            if (smethod_4(A_0, A_1) == Class897.Sign.Negative)
            {
                return new Class897[] { Class897.smethod_1(0), new Class897(A_0) };
            }
            A_0.method_11();
            A_1.method_11();
            if (A_1.uint_1 == 1)
            {
                return smethod_8(A_0, A_1.uint_2[0]);
            }
            uint num17 = A_0.uint_1 + 1;
            int num5 = ((int) A_1.uint_1) + 1;
            uint num10 = 0x80000000;
            uint num15 = A_1.uint_2[(int) ((IntPtr) (A_1.uint_1 - 1))];
            int num9 = 0;
            int num11 = (int) (A_0.uint_1 - A_1.uint_1);
            while (num10 != 0)
            {
                if ((num15 & num10) != 0)
                {
                    break;
                }
                num9++;
                num10 = num10 >> 1;
            }
            Class897 class2 = new Class897(Class897.Sign.Positive, (A_0.uint_1 - A_1.uint_1) + 1);
            Class897 class3 = Class897.smethod_13(A_0, num9);
            uint[] numArray = class3.uint_2;
            A_1 = Class897.smethod_13(A_1, num9);
            int num12 = (int) (num17 - A_1.uint_1);
            int index = ((int) num17) - 1;
            uint num14 = A_1.uint_2[(int) ((IntPtr) (A_1.uint_1 - 1))];
            ulong num18 = A_1.uint_2[(int) ((IntPtr) (A_1.uint_1 - 2))];
            while (num12 > 0)
            {
                uint num3;
                ulong num16 = (numArray[index] << 0x20) + numArray[index - 1];
                ulong num8 = num16 / ((ulong) num14);
                ulong num13 = num16 % ((ulong) num14);
                goto Label_0172;
            Label_0136:
                num8 -= (ulong) 1L;
                num13 += num14;
                if (num13 < 0x100000000L)
                {
                    goto Label_0172;
                }
                goto Label_0181;
            Label_015B:
                if ((num8 * num18) <= ((num13 << 0x20) + numArray[index - 2]))
                {
                    goto Label_0181;
                }
                goto Label_0136;
            Label_0172:
                if (num8 == 0x100000000L)
                {
                    goto Label_0136;
                }
                goto Label_015B;
            Label_0181:
                num3 = 0;
                int num6 = (index - num5) + 1;
                ulong num7 = 0L;
                uint num = (uint) num8;
                goto Label_01C0;
            Label_019D:
                num3++;
                num6++;
                if (num3 < num5)
                {
                    goto Label_01C0;
                }
                goto Label_0203;
            Label_01B0:
                num7 += (ulong) 1L;
                goto Label_019D;
            Label_01C0:
                num7 += A_1.uint_2[num3] * num;
                uint num19 = numArray[num6];
                numArray[num6] -= (uint) num7;
                num7 = num7 >> 0x20;
                if (numArray[num6] <= num19)
                {
                    goto Label_019D;
                }
                goto Label_01B0;
            Label_0203:
                num6 = (index - num5) + 1;
                num3 = 0;
                if (num7 != 0L)
                {
                    num--;
                    ulong num2 = 0L;
                    do
                    {
                        num2 = (numArray[num6] + A_1.uint_2[num3]) + num2;
                        numArray[num6] = (uint) num2;
                        num2 = num2 >> 0x20;
                        num3++;
                        num6++;
                    }
                    while (num3 < num5);
                }
                class2.uint_2[num11--] = num;
                index--;
                num12--;
            }
            class2.method_11();
            class3.method_11();
            Class897[] classArray2 = new Class897[] { class2, class3 };
            if (num9 != 0)
            {
                Class897[] classArray3;
                (classArray3 = classArray2)[1] = Class897.smethod_14(classArray3[1], num9);
            }
            return classArray2;
        }
    }

    internal enum Sign
    {
        Negative = -1,
        Positive = 1,
        Zero = 0
    }
}

