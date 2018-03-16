using Spire.Doc;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

internal class Class996
{
    private readonly Class147 class147_0;
    private readonly Class147 class147_1;
    private readonly IDictionary idictionary_0;
    internal const string string_0 = "_PictureBullets";
    private readonly StringCollection stringCollection_0;

    internal Class996()
    {
        this.stringCollection_0 = new StringCollection();
        this.class147_0 = new Class147(0);
        this.class147_1 = new Class147(0);
        this.idictionary_0 = Class83.smethod_0();
    }

    internal Class996(Class703 A_0, BinaryReader A_1)
    {
        this.stringCollection_0 = new StringCollection();
        this.class147_0 = new Class147(0);
        this.class147_1 = new Class147(0);
        this.idictionary_0 = Class83.smethod_0();
        Class343.smethod_1(A_1, A_0.class597_0.class1111_21, this.stringCollection_0);
        A_1.BaseStream.Seek((long) A_0.class597_0.class1111_23.int_0, SeekOrigin.Begin);
        Class144.smethod_0(A_1, A_0.class597_0.class1111_23.int_1, 0, new Class997(this), BookmarkStart.b("眦䔨䠪䬬䴮娰弲", 1));
        A_1.BaseStream.Seek((long) A_0.class597_0.class1111_22.int_0, SeekOrigin.Begin);
        Class144.smethod_0(A_1, A_0.class597_0.class1111_22.int_1, 4, new Class998(this), BookmarkStart.b("眦䔨䠪䬬䴮娰唲", 1));
        this.class147_0.method_8(0x7fffffff);
        this.class147_1.method_8(0x7fffffff);
        this.method_0(A_0);
    }

    private void method_0(Class703 A_0)
    {
        Class760 class2 = new Class760(0, A_0.int_14);
        for (int i = 0; i < this.class147_0.method_4(); i++)
        {
            int num2 = this.method_3(i);
            if (class2.method_0(num2))
            {
                int num3 = this.method_5(i).method_1();
                int num4 = this.method_4(num3);
                if (!class2.method_0(num4))
                {
                    this.class147_1.method_17(num3, class2.method_4() - 1);
                }
            }
        }
    }

    internal void method_1(Class703 A_0, BinaryWriter A_1, int A_2)
    {
        A_0.class597_0.class1111_21.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_21.int_1 = Class343.smethod_4(A_1, this.stringCollection_0);
        A_0.class597_0.class1111_22.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_22.int_1 = this.method_10(A_1, A_2);
        A_0.class597_0.class1111_23.int_0 = (int) A_1.BaseStream.Position;
        A_0.class597_0.class1111_23.int_1 = this.method_11(A_1, A_2);
    }

    private int method_10(BinaryWriter A_0, int A_1)
    {
        if (this.class147_0.method_4() == 0)
        {
            return 0;
        }
        long position = A_0.BaseStream.Position;
        for (int i = 0; i < this.class147_0.method_4(); i++)
        {
            A_0.Write(this.method_3(i));
        }
        A_0.Write(A_1);
        for (int j = 0; j < this.class147_0.method_4(); j++)
        {
            Class995 class2 = this.method_5(j);
            A_0.Write((short) class2.method_1());
            A_0.Write((ushort) class2.method_3());
        }
        return (int) (A_0.BaseStream.Position - position);
    }

    private int method_11(BinaryWriter A_0, int A_1)
    {
        if (this.class147_1.method_4() == 0)
        {
            return 0;
        }
        long position = A_0.BaseStream.Position;
        for (int i = 0; i < this.class147_1.method_4(); i++)
        {
            A_0.Write(this.method_4(i));
        }
        A_0.Write(A_1);
        return (int) (A_0.BaseStream.Position - position);
    }

    private int method_12(string A_0)
    {
        object obj2 = this.idictionary_0[A_0];
        if (obj2 != null)
        {
            return (int) obj2;
        }
        return -1;
    }

    internal Class147 method_13()
    {
        return this.class147_0;
    }

    internal Class147 method_14()
    {
        return this.class147_1;
    }

    internal void method_2(Class996 A_0, int A_1)
    {
        for (int i = 0; i < A_0.class147_0.method_4(); i++)
        {
            int num4 = A_0.method_3(i);
            Class995 class3 = A_0.method_5(i);
            this.method_7(A_1 + num4, class3.method_0(), class3.method_3());
        }
        for (int j = 0; j < A_0.class147_1.method_4(); j++)
        {
            int num3 = A_0.method_4(j);
            this.method_8(A_1 + num3, A_0.method_6(j).method_0());
        }
    }

    private int method_3(int A_0)
    {
        return this.class147_0.method_16(A_0);
    }

    private int method_4(int A_0)
    {
        return this.class147_1.method_16(A_0);
    }

    private Class995 method_5(int A_0)
    {
        return (Class995) this.class147_0.method_18(A_0);
    }

    private Class933 method_6(int A_0)
    {
        return (Class933) this.class147_1.method_18(A_0);
    }

    internal void method_7(int A_0, string A_1, int A_2)
    {
        this.stringCollection_0.Add(A_1);
        int num = this.class147_0.method_6(A_0, new Class995(A_1, -1, (ushort) A_2));
        this.idictionary_0.Add(A_1, num);
    }

    internal void method_8(int A_0, string A_1)
    {
        int num = this.method_12(A_1);
        if (num >= 0)
        {
            int num2 = this.class147_1.method_6(A_0, new Class933(A_1));
            this.method_5(num).method_2(num2);
        }
    }

    internal int method_9()
    {
        return this.class147_0.method_4();
    }

    private class Class997 : Interface16
    {
        private readonly Class996 class996_0;

        public Class997(Class996 A_0)
        {
            this.class996_0 = A_0;
        }

        private void imethod_0(BinaryReader A_0, int A_1, int A_2)
        {
            this.class996_0.class147_1.method_6(A_1, new Class933());
        }
    }

    private class Class998 : Interface16
    {
        private readonly Class996 class996_0;

        public Class998(Class996 A_0)
        {
            this.class996_0 = A_0;
        }

        private void imethod_0(BinaryReader A_0, int A_1, int A_2)
        {
            string str = this.class996_0.stringCollection_0[this.class996_0.class147_0.method_4()];
            short num = A_0.ReadInt16();
            ushort num2 = A_0.ReadUInt16();
            Class995 class2 = new Class995(str, num, num2);
            this.class996_0.class147_0.method_6(A_1, class2);
            this.class996_0.method_6(num).method_1(str);
        }
    }
}

