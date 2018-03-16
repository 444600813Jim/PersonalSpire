using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class383 : Class380
{
    private byte[] byte_0;
    private const int int_2 = -2147483648;
    private int int_3;
    private int int_4;
    private int int_5;

    internal Class383(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class383(int A_0, Class456[] A_1) : this(A_0, A_1.Length, 8)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write((byte) A_1[i].operation_0);
                writer.Write((byte) A_1[i].int_0);
                writer.Write((short) A_1[i].int_1);
                writer.Write((short) A_1[i].int_2);
                writer.Write((short) A_1[i].int_3);
            }
        }
    }

    internal Class383(int A_0, Class679[] A_1) : this(A_0, A_1.Length, 2)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                int num2 = Class781.smethod_4(A_1[i]);
                writer.Write((ushort) num2);
            }
        }
    }

    internal Class383(int A_0, Class70[] A_1) : this(A_0, A_1.Length, 0x10)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                Class70 class2 = A_1[i];
                writer.Write(smethod_2(class2.class623_0));
                writer.Write(smethod_2(class2.class623_1));
                writer.Write(smethod_2(class2.class623_2));
                writer.Write(smethod_2(class2.class623_3));
            }
        }
    }

    internal Class383(int A_0, Class782[] A_1) : this(A_0, A_1.Length, 12)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write(A_1[i].int_0);
                writer.Write(A_1[i].int_1);
                writer.Write(A_1[i].int_2);
            }
        }
    }

    internal Class383(int A_0, Class784[] A_1) : this(A_0, A_1.Length, 0x24)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write(A_1[i].method_0());
                writer.Write(A_1[i].class72_0.method_0());
                writer.Write(A_1[i].class72_1.method_0());
                writer.Write(A_1[i].class623_0.method_1());
                writer.Write(A_1[i].class623_1.method_1());
                writer.Write(A_1[i].class623_2.method_1());
                writer.Write(A_1[i].class623_3.method_1());
                writer.Write(A_1[i].class623_4.method_1());
                writer.Write(A_1[i].class623_5.method_1());
            }
        }
    }

    internal Class383(int A_0, Class891[] A_1) : this(A_0, A_1.Length, 8)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write(smethod_2(A_1[i].method_0()));
                writer.Write(smethod_2(A_1[i].method_1()));
            }
        }
    }

    internal Class383(int A_0, Class954[] A_1) : this(A_0, A_1.Length, 8)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write(Class624.smethod_6(A_1[i].color_0));
                writer.Write(A_1[i].int_0);
            }
        }
    }

    internal Class383(int A_0, int[] A_1) : this(A_0, A_1.Length, 4)
    {
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryWriter writer = new BinaryWriter(stream);
            for (int i = 0; i < A_1.Length; i++)
            {
                writer.Write(A_1[i]);
            }
        }
    }

    private Class383(int A_0, int A_1, int A_2) : base(A_0, smethod_0(A_1, A_2))
    {
        this.int_3 = A_1;
        this.int_4 = A_1;
        this.int_5 = A_2;
        this.byte_0 = new byte[this.int_5 * this.int_3];
    }

    internal Class679[] method_10()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class679[] classArray = new Class679[this.int_3];
            for (int i = 0; i < classArray.Length; i++)
            {
                int num2 = reader.ReadUInt16();
                classArray[i] = Class781.smethod_3(num2);
            }
            return classArray;
        }
    }

    internal int[] method_11()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            int[] numArray = new int[this.int_3];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = reader.ReadInt32();
            }
            return numArray;
        }
    }

    public bool method_3(int A_0)
    {
        return (((A_0 >= 2) && (this.int_5 <= 0x24)) && ((A_0 % 2) == 0));
    }

    internal Class954[] method_4()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class954[] classArray = new Class954[this.int_3];
            for (int i = 0; i < classArray.Length; i++)
            {
                classArray[i] = new Class954 { color_0 = Class624.smethod_7(reader.ReadInt32()), int_0 = reader.ReadInt32() };
            }
            return classArray;
        }
    }

    internal Class782[] method_5()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class782[] classArray = new Class782[this.int_3];
            for (int i = 0; i < classArray.Length; i++)
            {
                classArray[i] = new Class782 { int_0 = reader.ReadInt32(), int_1 = reader.ReadInt32(), int_2 = reader.ReadInt32() };
            }
            return classArray;
        }
    }

    internal Class891[] method_6()
    {
        int num = 0x10;
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class891[] classArray = new Class891[this.int_3];
            int num2 = this.int_5;
            if (num2 != 4)
            {
                if (num2 != 8)
                {
                    throw new InvalidOperationException(BookmarkStart.b("挵嘷儹刻儽㜿ⱁ摃⁅❇㡉⅋⽍⑏牑㉓㥕⩗穙⽛㙝şቡţ䙥ᡧ୩ᡫ٭幯", num));
                }
                for (int i = 0; i < classArray.Length; i++)
                {
                    int num3 = reader.ReadInt32();
                    int num4 = reader.ReadInt32();
                    classArray[i] = new Class891(smethod_3(num3), smethod_3(num4));
                }
            }
            else
            {
                for (int j = 0; j < classArray.Length; j++)
                {
                    int num7 = reader.ReadInt16();
                    int num8 = reader.ReadInt16();
                    classArray[j] = new Class891(num7, num8);
                }
            }
            return classArray;
        }
    }

    internal Class784[] method_7()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class784[] classArray = new Class784[this.int_3];
            for (int i = 0; i < classArray.Length; i++)
            {
                Class784 class2 = new Class784();
                int num2 = reader.ReadInt32();
                class2.bool_0 = (num2 & 0x2000) != 0;
                class2.bool_1 = (num2 & 0x20) != 0;
                class2.bool_2 = (num2 & 0x10) != 0;
                class2.bool_3 = (num2 & 8) != 0;
                class2.bool_4 = (num2 & 4) != 0;
                class2.bool_6 = (num2 & 2) != 0;
                class2.bool_5 = (num2 & 1) != 0;
                class2.class72_0 = new Class72(smethod_1(reader, true).method_1());
                class2.class72_1 = new Class72(smethod_1(reader, true).method_1());
                class2.class623_0 = smethod_1(reader, (num2 & 0x800) != 0);
                class2.class623_1 = smethod_1(reader, (num2 & 0x1000) != 0);
                class2.class623_2 = smethod_1(reader, (num2 & 0x80) != 0);
                class2.class623_3 = smethod_1(reader, (num2 & 0x100) != 0);
                class2.class623_4 = smethod_1(reader, (num2 & 0x200) != 0);
                class2.class623_5 = smethod_1(reader, (num2 & 0x400) != 0);
                classArray[i] = class2;
            }
            return classArray;
        }
    }

    internal Class70[] method_8()
    {
        if (this.int_5 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            Class70[] classArray = new Class70[this.int_3];
            for (int i = 0; i < this.int_3; i++)
            {
                BinaryReader reader = new BinaryReader(stream);
                classArray[i] = new Class70 { class623_0 = smethod_3(reader.ReadInt32()), class623_1 = smethod_3(reader.ReadInt32()), class623_2 = smethod_3(reader.ReadInt32()), class623_3 = smethod_3(reader.ReadInt32()) };
            }
            return classArray;
        }
    }

    internal Class456[] method_9()
    {
        if (this.int_3 == 0)
        {
            return null;
        }
        using (MemoryStream stream = new MemoryStream(this.byte_0))
        {
            BinaryReader reader = new BinaryReader(stream);
            Class456[] classArray = new Class456[this.int_3];
            for (int i = 0; i < classArray.Length; i++)
            {
                classArray[i] = new Class456 { operation_0 = (Operation) reader.ReadByte(), int_0 = reader.ReadByte(), int_1 = reader.ReadInt16(), int_2 = reader.ReadInt16(), int_3 = reader.ReadInt16() };
            }
            return classArray;
        }
    }

    private static int smethod_0(int A_0, int A_1)
    {
        return (6 + (A_0 * A_1));
    }

    private static Class623 smethod_1(BinaryReader A_0, bool A_1)
    {
        return new Class623(A_0.ReadInt32(), A_1);
    }

    internal static int smethod_2(Class623 A_0)
    {
        int num = A_0.method_1();
        if (A_0.method_0() && smethod_4(num))
        {
            num |= -2147483648;
        }
        return num;
    }

    internal static Class623 smethod_3(int A_0)
    {
        if ((A_0 & -2147483648) != 0)
        {
            int num = A_0 & 0x7fffffff;
            if (smethod_4(num))
            {
                return new Class623(num, true);
            }
        }
        return new Class623(A_0, false);
    }

    private static bool smethod_4(int A_0)
    {
        return ((A_0 >= 0) && (A_0 <= 0x7f));
    }

    internal override void vmethod_2(BinaryReader A_0)
    {
        if (base.method_1() != 0)
        {
            this.int_3 = A_0.ReadUInt16();
            this.int_4 = A_0.ReadUInt16();
            this.int_5 = A_0.ReadUInt16();
            if (this.int_5 == 0xfff0)
            {
                this.int_5 = 4;
            }
            else if ((((this.int_3 * this.int_5) != (base.method_1() - 6)) || !this.method_3(this.int_5)) || ((this.int_3 == 0) || (this.int_5 == 0)))
            {
                A_0.BaseStream.Position = 0L;
                this.int_5 = 4;
                this.int_3 = base.method_1() / this.int_5;
                this.int_4 = base.method_1() / this.int_5;
            }
            this.byte_0 = A_0.ReadBytes(this.int_3 * this.int_5);
        }
    }

    internal override void vmethod_3(BinaryWriter A_0)
    {
        A_0.Write((short) this.int_3);
        A_0.Write((short) this.int_4);
        A_0.Write((short) this.int_5);
        A_0.Write(this.byte_0);
    }
}

