using System;
using System.Collections;
using System.IO;

internal class Class168
{
    private readonly ArrayList arrayList_0;
    private readonly ArrayList arrayList_1;
    internal static bool bool_0;
    private readonly Class154 class154_0;
    private readonly Class164 class164_0;
    private readonly Class741 class741_0;
    private readonly Hashtable hashtable_0;
    private readonly Hashtable hashtable_1;
    private readonly Hashtable hashtable_2;
    private readonly Hashtable hashtable_3;
    private const int int_0 = 6;
    private const int int_1 = 12;
    private const int int_2 = 0x100;

    internal Class168()
    {
        this.class741_0 = new Class741();
        this.class154_0 = new Class154();
        this.class164_0 = new Class164();
        this.hashtable_0 = new Hashtable();
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.hashtable_1 = new Hashtable();
        this.hashtable_2 = new Hashtable();
        this.hashtable_3 = new Hashtable();
    }

    internal Class168(Class703 A_0, BinaryReader A_1)
    {
        this.class741_0 = new Class741();
        this.class154_0 = new Class154();
        this.class164_0 = new Class164();
        this.hashtable_0 = new Hashtable();
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.hashtable_1 = new Hashtable();
        this.hashtable_2 = new Hashtable();
        this.hashtable_3 = new Hashtable();
        if (A_0.class929_0.class1111_6.int_1 != 0)
        {
            this.method_0(A_1, A_0.class929_0.class1111_6);
            this.class154_0.method_23(A_1, A_0.class929_0.class1111_7);
            this.class164_0.method_23(A_1, A_0.class929_0.class1111_9);
            this.method_1(A_1, A_0.class929_0.class1111_10);
        }
    }

    private void method_0(BinaryReader A_0, Class1111 A_1)
    {
        if (A_1.int_1 != 0)
        {
            A_0.BaseStream.Position = A_1.int_0;
            A_0.ReadUInt16();
            int num3 = A_0.ReadInt16();
            A_0.ReadInt16();
            for (int i = 0; i < num3; i++)
            {
                A_0.ReadInt16();
                int num = A_0.ReadInt32();
                this.class741_0.method_9(num);
                A_0.ReadInt32();
                A_0.ReadInt32();
            }
        }
    }

    private void method_1(BinaryReader A_0, Class1111 A_1)
    {
        if (A_1.int_1 != 0)
        {
            A_0.BaseStream.Position = A_1.int_0;
            this.method_2(A_0);
            this.method_3(A_0);
            this.method_4(A_0);
        }
    }

    private void method_10(BinaryWriter A_0)
    {
        foreach (Class765 class2 in this.arrayList_1)
        {
            class2.method_0(A_0);
        }
    }

    internal void method_11(Class168 A_0, int A_1)
    {
        int num = this.class741_0.method_2();
        for (int i = 0; i < A_0.method_21().method_4(); i++)
        {
            this.class741_0.method_9(num + A_0.method_17(i));
            Class1110 class3 = (Class1110) A_0.method_21().method_18(i);
            class3.int_1 += num;
            int num5 = A_0.method_21().method_16(i);
            this.class154_0.method_6(A_1 + num5, class3);
            Class765 class2 = A_0.method_18(i);
            Class433 class4 = A_0.method_19(class2.int_0);
            Class433 class5 = this.method_12(class4.string_0, class4.string_1);
            class2.int_0 = class5.int_0;
            this.arrayList_1.Add(class2);
            for (int k = 0; k < class2.int_1.Length; k++)
            {
                string str = A_0.method_20(class2.int_1[k]);
                class2.int_1[k] = this.method_13(str);
                string str2 = A_0.method_20(class2.int_2[k]);
                class2.int_2[k] = this.method_13(str2);
            }
        }
        for (int j = 0; j < A_0.method_22().method_4(); j++)
        {
            Class486 class6 = (Class486) A_0.method_22().method_18(j);
            class6.int_1 += num;
            int num6 = A_0.method_22().method_16(j);
            this.class164_0.method_6(A_1 + num6, class6);
        }
    }

    private Class433 method_12(string A_0, string A_1)
    {
        string key = A_0 + A_1;
        Class433 class2 = (Class433) this.hashtable_2[key];
        if (class2 == null)
        {
            int num = this.hashtable_0.Count + 1;
            class2 = new Class433(num, A_0, A_1);
            this.hashtable_0.Add(class2.int_0, class2);
            this.hashtable_2.Add(key, class2);
        }
        return class2;
    }

    private int method_13(string A_0)
    {
        object obj2 = this.hashtable_3[A_0];
        if (obj2 == null)
        {
            int num = this.arrayList_0.Add(A_0);
            this.hashtable_3.Add(A_0, num);
            return num;
        }
        return (int) obj2;
    }

    internal void method_14(int A_0)
    {
        if (this.class741_0.method_2() != 0)
        {
            this.class154_0.method_8(A_0);
            this.class164_0.method_8(A_0);
            this.method_15();
            this.method_16();
        }
    }

    private void method_15()
    {
        int num = this.class154_0.method_4();
        for (int i = 0; i < num; i++)
        {
            int num4 = this.class154_0.method_16(i);
            Class1110 class3 = (Class1110) this.class154_0.method_18(i);
            class3.int_3 = 0;
            for (int j = 0; j < num; j++)
            {
                Class760 class2 = new Class760(this.class154_0.method_16(j), this.class164_0.method_16(j));
                if (class2.method_1() || class2.method_0(num4))
                {
                    class3.int_3++;
                }
                if (class2.method_2() > num4)
                {
                    break;
                }
            }
        }
    }

    private void method_16()
    {
        int num = this.class164_0.method_4();
        for (int i = 0; i < num; i++)
        {
            int num4 = this.class164_0.method_16(i);
            Class486 class3 = (Class486) this.class164_0.method_18(i);
            class3.int_2 = 0;
            for (int j = 0; j < num; j++)
            {
                Class760 class2 = new Class760(this.class154_0.method_16(j), this.class164_0.method_16(j));
                if (!class2.method_1() && class2.method_0(num4))
                {
                    class3.int_2++;
                }
                if (class2.method_2() > num4)
                {
                    break;
                }
            }
        }
    }

    private int method_17(int A_0)
    {
        return this.class741_0.method_7(A_0);
    }

    internal Class765 method_18(int A_0)
    {
        return (Class765) this.arrayList_1[A_0];
    }

    internal Class433 method_19(int A_0)
    {
        return (Class433) this.hashtable_0[A_0];
    }

    private void method_2(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            Class433 class2 = new Class433(A_0);
            this.hashtable_0[class2.int_0] = class2;
        }
    }

    internal string method_20(int A_0)
    {
        if ((A_0 >= 0) && (A_0 < this.arrayList_0.Count))
        {
            return (string) this.arrayList_0[A_0];
        }
        return "";
    }

    internal Class154 method_21()
    {
        return this.class154_0;
    }

    internal Class164 method_22()
    {
        return this.class164_0;
    }

    private void method_3(BinaryReader A_0)
    {
        A_0.ReadUInt16();
        A_0.ReadUInt16();
        A_0.ReadInt32();
        int num = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_0.Add(Class654.smethod_0(A_0));
        }
    }

    private void method_4(BinaryReader A_0)
    {
        int num = this.class741_0.method_2();
        for (int i = 0; i < num; i++)
        {
            this.arrayList_1.Add(new Class765(A_0));
        }
    }

    internal void method_5(Class703 A_0, BinaryWriter A_1)
    {
        A_0.class929_0.class1111_6.int_0 = (int) A_1.BaseStream.Position;
        A_0.class929_0.class1111_6.int_1 = this.method_6(A_1);
        A_0.class929_0.class1111_7.int_0 = (int) A_1.BaseStream.Position;
        A_0.class929_0.class1111_7.int_1 = this.class154_0.vmethod_1(A_1);
        A_0.class929_0.class1111_9.int_0 = (int) A_1.BaseStream.Position;
        A_0.class929_0.class1111_9.int_1 = this.class164_0.vmethod_1(A_1);
        A_0.class929_0.class1111_10.int_0 = (int) A_1.BaseStream.Position;
        A_0.class929_0.class1111_10.int_1 = this.method_7(A_1);
    }

    private int method_6(BinaryWriter A_0)
    {
        if (this.class741_0.method_2() == 0)
        {
            return 0;
        }
        int position = (int) A_0.BaseStream.Position;
        A_0.Write((ushort) 0xffff);
        A_0.Write((short) this.class741_0.method_2());
        A_0.Write((short) 0);
        for (int i = 0; i < this.class741_0.method_2(); i++)
        {
            A_0.Write((short) 6);
            A_0.Write(this.class741_0.method_7(i));
            A_0.Write(0);
            A_0.Write(0);
        }
        return (((int) A_0.BaseStream.Position) - position);
    }

    private int method_7(BinaryWriter A_0)
    {
        if (this.hashtable_0.Count == 0)
        {
            return 0;
        }
        int position = (int) A_0.BaseStream.Position;
        this.method_8(A_0);
        this.method_9(A_0);
        this.method_10(A_0);
        return (((int) A_0.BaseStream.Position) - position);
    }

    private void method_8(BinaryWriter A_0)
    {
        A_0.Write(this.hashtable_0.Count);
        foreach (Class433 class2 in this.hashtable_0.Values)
        {
            class2.method_0(A_0);
        }
    }

    private void method_9(BinaryWriter A_0)
    {
        A_0.Write((ushort) 12);
        A_0.Write((ushort) 0x100);
        A_0.Write(0);
        A_0.Write(this.arrayList_0.Count);
        foreach (string str in this.arrayList_0)
        {
            Class654.smethod_1(A_0, str);
        }
    }
}

