using Spire.CompoundFile.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class663
{
    private Guid guid_0;
    private const int int_0 = -2147483648;
    private int int_1;
    private int int_2;
    private List<Class937> list_0 = new List<Class937>();

    public Class663(Guid A_0, int A_1)
    {
        this.guid_0 = A_0;
        this.int_1 = A_1;
    }

    public int method_0()
    {
        return this.int_1;
    }

    public void method_1(int A_0)
    {
        this.int_1 = A_0;
    }

    private Dictionary<int, string> method_10(Stream A_0)
    {
        byte[] buffer = new byte[4];
        int num = Class1115.smethod_1(A_0, buffer);
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        for (int i = 0; i < num; i++)
        {
            int key = Class1115.smethod_1(A_0, buffer);
            string str = Class1115.smethod_6(A_0, -1);
            dictionary.Add(key, str);
        }
        return dictionary;
    }

    public void method_11(Stream A_0)
    {
        this.int_1 = (int) A_0.Position;
        Class1115.smethod_4(A_0, 0);
        Dictionary<int, string> dictionary = this.method_12();
        new Class937(1) { propertyType_0 = PropertyType.Int16 }.method_16((dictionary.Count == 0) ? ((short) 0x4e3) : ((short) (-535)));
        for (int i = this.list_0.Count - 1; i >= 0; i--)
        {
            Class937 local1 = this.list_0[i];
        }
        int count = this.list_0.Count;
        Class1115.smethod_4(A_0, count);
        A_0.Position += (count * 4) * 2;
        List<int> list = new List<int>();
        for (int j = 0; j < count; j++)
        {
            Class937 class3 = this.list_0[j];
            list.Add((int) A_0.Position);
            class3.method_11(A_0);
        }
        long position = A_0.Position;
        A_0.Position = this.int_1 + 8;
        int num4 = 0;
        int num5 = list.Count;
        while (num4 < num5)
        {
            int num6 = list[num4] - this.int_1;
            Class1115.smethod_4(A_0, this.list_0[num4].Interface37.imethod_3());
            Class1115.smethod_4(A_0, num6);
            num4++;
        }
        this.int_2 = ((int) position) - this.int_1;
        A_0.Position = this.int_1;
        Class1115.smethod_4(A_0, this.int_2);
        A_0.Position = position;
    }

    private Dictionary<int, string> method_12()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            Class937 class3 = this.list_0[num];
            if (class3.Interface37.imethod_2() != null)
            {
                dictionary.Add(class3.Interface37.imethod_3(), class3.Interface37.imethod_2());
            }
            num++;
        }
        if (dictionary.Count > 0)
        {
            Class937 item = new Class937(0);
            item.method_16(dictionary);
            this.list_0.Insert(0, item);
        }
        return dictionary;
    }

    public Guid method_2()
    {
        return this.guid_0;
    }

    public void method_3(Guid A_0)
    {
        this.guid_0 = A_0;
    }

    public int method_4()
    {
        return this.int_2;
    }

    public void method_5(int A_0)
    {
        this.int_2 = A_0;
    }

    public int method_6()
    {
        return this.list_0.Count;
    }

    public List<Class937> method_7()
    {
        return this.list_0;
    }

    public void method_8(Stream A_0)
    {
        byte[] buffer = new byte[4];
        A_0.Position = this.int_1;
        this.int_2 = Class1115.smethod_1(A_0, buffer);
        int num = Class1115.smethod_1(A_0, buffer);
        List<int> list = new List<int>();
        for (int i = 0; i < num; i++)
        {
            int num5 = Class1115.smethod_1(A_0, buffer);
            int item = Class1115.smethod_1(A_0, buffer);
            this.list_0.Add(new Class937(num5));
            list.Add(item);
        }
        list.Add((int) A_0.Length);
        Dictionary<int, string> dictionary = null;
        for (int j = 0; j < num; j++)
        {
            Class937 class2 = this.list_0[j];
            int num7 = list[j];
            int num8 = list[j + 1];
            A_0.Position = this.int_1 + list[j];
            int num3 = num8 - num7;
            if (class2.Interface37.imethod_3() < 2)
            {
                this.method_9(class2, A_0, num3, ref dictionary);
                this.list_0.RemoveAt(j);
                list.RemoveAt(j);
                num--;
                j--;
            }
            else
            {
                string str;
                class2.method_2(A_0, num3);
                if ((dictionary != null) && dictionary.TryGetValue(class2.Interface37.imethod_3(), out str))
                {
                    class2.method_18(str);
                }
            }
        }
    }

    private void method_9(Class937 A_0, Stream A_1, int A_2, ref Dictionary<int, string> A_3)
    {
        if (A_0.Interface37.imethod_3() == 0)
        {
            A_3 = this.method_10(A_1);
        }
        else
        {
            A_0.method_2(A_1, A_2);
        }
    }
}

