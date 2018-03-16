using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class1069 : Interface59, Interface61
{
    private Class1004 class1004_0;
    private Class297 class297_0;
    private List<string> list_0;
    private List<string> list_1;
    private SortedList<string, Interface59> sortedList_0;

    public Class1069(Class1004 A_0, Class297 A_1)
    {
        int num = 0;
        this.sortedList_0 = new SortedList<string, Interface59>(new Class1002());
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("嘥䤧堩䤫䀭䐯琱崳娵崷", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌥䘧帩師圭", num));
        }
        if ((A_1.method_2() != Class297.EntryType.Storage) && (A_1.method_2() != Class297.EntryType.Root))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌥䘧帩師圭", num));
        }
        this.class297_0 = A_1;
        this.class1004_0 = A_0;
        this.method_0(A_1.method_10());
    }

    public Class1069(Class1004 A_0, string A_1, int A_2)
    {
        int num = 13;
        this.sortedList_0 = new SortedList<string, Interface59>(new Class1002());
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䌲吴䔶尸唺䤼", num));
        }
        this.class1004_0 = A_0;
        this.class297_0 = new Class297(A_1, Class297.EntryType.Storage, A_2);
    }

    public void imethod_12(Interface61 A_0)
    {
        Interface61 interface2 = this.imethod_4(A_0.imethod_11());
        if (A_0 is Class664)
        {
            (interface2 as Class664).method_0().Interface59.imethod_0().method_13((A_0 as Class664).method_0().Interface59.imethod_0().method_12());
        }
        string[] strArray2 = A_0.imethod_9();
        int index = 0;
        int length = strArray2.Length;
        while (index < length)
        {
            using (Stream1 stream = A_0.imethod_0(strArray2[index]))
            {
                interface2.imethod_13(stream);
            }
            index++;
        }
        string[] strArray = A_0.imethod_10();
        int num3 = 0;
        int num4 = strArray.Length;
        while (num3 < num4)
        {
            using (Interface61 interface3 = A_0.imethod_5(strArray[num3]))
            {
                interface2.imethod_12(interface3);
            }
            num3++;
        }
    }

    public void imethod_13(Stream1 A_0)
    {
        int num2;
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷渹医紽⼿㉁㵃", num));
        }
        Stream1 stream = this.imethod_2(A_0.method_0());
        byte[] buffer = new byte[0x8000];
        long position = A_0.Position;
        A_0.Position = 0L;
        while ((num2 = A_0.Read(buffer, 0, 0x8000)) > 0)
        {
            stream.Write(buffer, 0, num2);
        }
        A_0.Position = position;
    }

    public Stream1 imethod_2(string A_0)
    {
        int num = 11;
        if (this.Interface61.imethod_3(A_0) || this.imethod_7(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈰䜲䜴制堸嘺猼帾ⱀ♂", num), BookmarkStart.b("縰儲弴制娸伺ᴼ䠾⡀㝂ⵄ杆㩈㹊⹌❎煐㵒㑔㩖㱘筚㱜㍞፠٢Ѥͦၨ䭪࡬ᝮᡰrŴѶ", num));
        }
        Class297 class2 = this.class1004_0.method_17(A_0, Class297.EntryType.Stream);
        Stream3 stream = this.class1004_0.method_5() ? new Stream4(this.class1004_0, class2) : new Stream3(this.class1004_0, class2);
        this.list_1.Add(A_0);
        this.sortedList_0.Add(A_0, stream);
        stream.vmethod_1();
        return new Stream2(stream);
    }

    public Interface61 imethod_4(string A_0)
    {
        DateTime time;
        int num = 10;
        if (this.Interface61.imethod_3(A_0) || this.imethod_7(A_0))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䌯䘱䘳匵夷圹爻弽ⴿ❁", num), BookmarkStart.b("缯倱帳匵嬷丹᰻䤽⤿㙁ⱃ晅㭇㽉⽋♍灏㱑㕓㭕㵗穙㵛㉝቟ݡգɥᅧ䩩५᙭᥯űsյ", num));
        }
        Class297 class2 = this.class1004_0.method_17(A_0, Class297.EntryType.Storage);
        class2.method_19(time = DateTime.Now);
        class2.method_17(time);
        Class1069 class3 = new Class1069(this.class1004_0, class2);
        this.list_0.Add(A_0);
        this.sortedList_0.Add(A_0, class3);
        class3.method_1();
        return new Class664(class3);
    }

    public bool imethod_7(string A_0)
    {
        return this.sortedList_0.ContainsKey(A_0);
    }

    Class297 Interface59.imethod_0()
    {
        return this.class297_0;
    }

    public void Interface59.imethod_1()
    {
        this.class297_0.method_7(-1);
        foreach (Interface59 interface4 in this.sortedList_0.Values)
        {
            interface4.imethod_1();
        }
        Interface59 interface3 = null;
        foreach (Interface59 interface2 in this.sortedList_0.Values)
        {
            if (interface3 != null)
            {
                interface3.imethod_0().method_9(interface2.imethod_0().method_26());
                interface3.imethod_0().method_7(-1);
            }
            else
            {
                this.class297_0.method_11(interface2.imethod_0().method_26());
            }
            interface3 = interface2;
        }
    }

    Stream1 Interface61.imethod_0(string A_0)
    {
        Stream3 stream = this.sortedList_0[A_0] as Stream3;
        if (stream != null)
        {
            stream.vmethod_1();
        }
        return new Stream2(stream);
    }

    void Interface61.imethod_1(string A_0)
    {
        Stream3 stream = this.sortedList_0[A_0] as Stream3;
        if (stream != null)
        {
            this.class1004_0.method_18(stream.Interface59.imethod_0());
            stream.Dispose();
            this.sortedList_0.Remove(A_0);
        }
    }

    string[] Interface61.imethod_10()
    {
        return this.list_0.ToArray();
    }

    string Interface61.imethod_11()
    {
        return this.class297_0.method_0();
    }

    bool Interface61.imethod_3(string A_0)
    {
        return this.sortedList_0.ContainsKey(A_0);
    }

    Interface61 Interface61.imethod_5(string A_0)
    {
        Class1069 class2 = this.sortedList_0[A_0] as Class1069;
        if (class2 != null)
        {
            class2.method_1();
        }
        return new Class664(class2);
    }

    void Interface61.imethod_6(string A_0)
    {
        Class1069 class2 = this.sortedList_0[A_0] as Class1069;
        if (class2 != null)
        {
            class2.System.IDisposable.Dispose();
            this.sortedList_0.Remove(A_0);
        }
    }

    string[] Interface61.imethod_9()
    {
        return this.list_1.ToArray();
    }

    private void method_0(int A_0)
    {
        if (A_0 >= 0)
        {
            Class297 class2 = this.class1004_0.Interface51.imethod_1().method_0()[A_0];
            int num = class2.method_6();
            string key = class2.method_0();
            this.method_0(num);
            switch (class2.method_2())
            {
                case Class297.EntryType.Storage:
                    this.sortedList_0.Add(key, new Class1069(this.class1004_0, class2));
                    this.list_0.Add(key);
                    break;

                case Class297.EntryType.Stream:
                    if (!this.list_1.Contains(key))
                    {
                        Stream3 stream = new Stream3(this.class1004_0, class2);
                        this.sortedList_0.Add(key, stream);
                        this.list_1.Add(key);
                    }
                    break;

                default:
                    throw new NotImplementedException();
            }
            int num2 = class2.method_8();
            this.method_0(num2);
        }
    }

    private void method_1()
    {
    }

    private void method_2(Class1157 A_0)
    {
        object obj2 = A_0.method_12();
        if (obj2 != null)
        {
            Class297 class2 = (obj2 as Interface59).imethod_0();
            class2.method_5((byte) A_0.method_6());
            class2.method_7(this.method_3(A_0.method_0()));
            class2.method_9(this.method_3(A_0.method_2()));
            if (this.class297_0.method_10() < 0)
            {
                this.class297_0.method_11(class2.method_26());
            }
            Stream3 stream = obj2 as Stream3;
            if (stream != null)
            {
                class2.method_23((uint) stream.Length);
            }
        }
    }

    private int method_3(Class1157 A_0)
    {
        if (A_0.method_8())
        {
            return -1;
        }
        return (A_0.method_12() as Interface59).imethod_0().method_26();
    }

    void IDisposable.Dispose()
    {
        if (this.class1004_0 != null)
        {
            this.class1004_0 = null;
            this.sortedList_0 = null;
            this.class297_0 = null;
            GC.SuppressFinalize(this);
        }
    }
}

