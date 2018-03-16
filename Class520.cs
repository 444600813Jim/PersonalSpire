using Spire.Doc;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal class Class520
{
    private readonly Class566 class566_0;
    public static Guid guid_0 = new Guid(BookmarkStart.b("氩ḫᜭ瘯਱ĳ猵࠷᜹࠻砽ؿ筁楃睅硇籉瑋捍ᅏၑ浓杕畗橙摛湝偟偡♣呥彧⡩彫⩭䥯", 4));
    public static Guid guid_1 = new Guid(BookmarkStart.b("温ᤫ洭琯瘱ĳص਷᜹฻笽礿Ł楃睅硇等๋捍楏慑浓慕畗橙摛湝偟偡♣呥⭧Ⱪ啫⽭㕯", 4));
    public static Guid guid_2 = new Guid(BookmarkStart.b("温ᤫ洭琯瘱ĳصഷ᜹฻笽礿Ł楃睅硇等๋捍楏慑浓慕畗橙摛湝偟偡♣呥⭧Ⱪ啫⽭㕯", 4));
    private Guid guid_3;
    private const int int_0 = 4;
    private const int int_1 = 0;
    private const int int_2 = 1;
    private const int int_3 = 2;
    private const int int_4 = 0x7fffffff;
    private const int int_5 = -2147483648;
    private const int int_6 = -2147483645;
    private readonly int int_7;
    private const long long_0 = 0x701ce1722770000L;
    private const short short_0 = 0x4e4;
    private const short short_1 = 0x4b0;

    private Class520(Guid A_0)
    {
        this.guid_3 = Guid.Empty;
        this.guid_3 = A_0;
        this.class566_0 = new Class566();
    }

    public Class520(Guid A_0, int A_1) : this(A_0)
    {
        int num = 4;
        if (A_1 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䤩䌫䨭唯戱唳儵崷", num));
        }
        this.int_7 = A_1;
    }

    public Class520(Guid A_0, BinaryReader A_1) : this(A_0)
    {
        long position = A_1.BaseStream.Position;
        A_1.ReadInt32();
        int num2 = A_1.ReadInt32();
        ArrayList list = new ArrayList();
        for (int i = 0; i < num2; i++)
        {
            list.Add(new Class739(A_1));
        }
        this.int_7 = 0x4e4;
        int num4 = smethod_0(list, 1);
        if (num4 != -1)
        {
            A_1.BaseStream.Position = position + num4;
            object obj2 = smethod_3(A_1, 0);
            if (obj2 is short)
            {
                short num5 = (short) obj2;
                this.int_7 = num5 & 0xffff;
            }
        }
        Hashtable hashtable = new Hashtable();
        int num6 = smethod_0(list, 0);
        if (num6 != -1)
        {
            A_1.BaseStream.Position = position + num6;
            smethod_1(A_1, hashtable, this.int_7);
        }
        for (int j = 0; j < list.Count; j++)
        {
            Class739 class2 = (Class739) list[j];
            long num8 = class2.int_0 & 0xfffffffL;
            if ((num8 >= 2L) && (num8 <= 0x7fffffffL))
            {
                A_1.BaseStream.Position = position + class2.int_1;
                object obj3 = smethod_3(A_1, this.int_7);
                if (obj3 != null)
                {
                    string str = (string) hashtable[class2.int_0];
                    this.class566_0.method_5(new Class521(class2.int_0, str, obj3));
                }
            }
        }
    }

    public Class566 method_0()
    {
        return this.class566_0;
    }

    public Guid method_1()
    {
        return this.guid_3;
    }

    public int method_2()
    {
        return this.int_7;
    }

    public byte[] method_3()
    {
        bool flag;
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output);
        int num = 0x10 + (8 * this.class566_0.method_2());
        if (flag = this.class566_0.method_3() || this.guid_3.Equals(guid_2))
        {
            num += 8;
        }
        output.Position = num;
        ArrayList list = new ArrayList();
        if (flag)
        {
            list.Add(new Class739(0, (int) output.Position));
            smethod_2(writer, this.class566_0, this.int_7);
        }
        list.Add(new Class739(1, (int) output.Position));
        smethod_6(writer, (short) this.int_7, this.int_7, true);
        for (int i = 0; i < this.class566_0.method_2(); i++)
        {
            Class521 class2 = this.class566_0.method_0(i);
            list.Add(new Class739(class2.int_0, (int) output.Position));
            smethod_6(writer, class2.object_0, this.int_7, true);
        }
        output.Position = 0L;
        writer.Write((int) output.Length);
        writer.Write(list.Count);
        for (int j = 0; j < list.Count; j++)
        {
            ((Class739) list[j]).method_0(writer);
        }
        return output.ToArray();
    }

    private static int smethod_0(ArrayList A_0, int A_1)
    {
        for (int i = 0; i < A_0.Count; i++)
        {
            Class739 class2 = (Class739) A_0[i];
            if (class2.int_0 == A_1)
            {
                return class2.int_1;
            }
        }
        return -1;
    }

    private static void smethod_1(BinaryReader A_0, Hashtable A_1, int A_2)
    {
        int num = A_0.ReadInt32();
        for (int i = 0; i < num; i++)
        {
            int key = A_0.ReadInt32();
            string str = smethod_11(A_0, A_2);
            if (!Class567.smethod_16(str))
            {
                return;
            }
            A_1.Add(key, str);
        }
    }

    private static void smethod_10(BinaryWriter A_0, string A_1)
    {
        A_0.Write((int) (A_1.Length + 1));
        A_0.Write(Encoding.Unicode.GetBytes(A_1));
        A_0.Write((short) 0);
    }

    private static string smethod_11(BinaryReader A_0, int A_1)
    {
        if (A_1 == 0x4b0)
        {
            string str = smethod_9(A_0);
            Class567.smethod_6(A_0.BaseStream, 4);
            return str;
        }
        return smethod_7(A_0, A_1);
    }

    private static void smethod_12(BinaryWriter A_0, string A_1, int A_2)
    {
        if (A_2 == 0x4b0)
        {
            smethod_10(A_0, A_1);
            Class567.smethod_6(A_0.BaseStream, 4);
        }
        else
        {
            smethod_8(A_0, A_1, A_2);
        }
    }

    public static DateTime smethod_13(long A_0, string A_1)
    {
        if (A_0 < 0L)
        {
            throw new ArgumentOutOfRangeException(A_1);
        }
        return new DateTime(A_0 + 0x701ce1722770000L, DateTimeKind.Utc);
    }

    public static long smethod_14(DateTime A_0, string A_1)
    {
        long num = A_0.Ticks - 0x701ce1722770000L;
        if (num < 0L)
        {
            throw new ArgumentOutOfRangeException(A_1);
        }
        return num;
    }

    private static void smethod_2(BinaryWriter A_0, Class566 A_1, int A_2)
    {
        A_0.Write(A_1.method_4());
        for (int i = 0; i < A_1.method_2(); i++)
        {
            Class521 class2 = A_1.method_0(i);
            if (class2.method_0())
            {
                A_0.Write(class2.int_0);
                smethod_12(A_0, class2.string_0, A_2);
            }
        }
    }

    private static object smethod_3(BinaryReader A_0, int A_1)
    {
        int num = 12;
        switch (((VarEnum) A_0.ReadInt32()))
        {
            case VarEnum.VT_I2:
                return A_0.ReadInt16();

            case VarEnum.VT_I4:
                return A_0.ReadInt32();

            case VarEnum.VT_R8:
                return A_0.ReadDouble();

            case VarEnum.VT_BOOL:
                return (A_0.ReadInt16() != 0);

            case VarEnum.VT_UI4:
                return A_0.ReadUInt32();

            case VarEnum.VT_LPSTR:
                return smethod_7(A_0, A_1);

            case VarEnum.VT_LPWSTR:
            {
                string str = smethod_9(A_0);
                Class567.smethod_6(A_0.BaseStream, 4);
                return str;
            }
            case VarEnum.VT_FILETIME:
            {
                long num2 = A_0.ReadInt64();
                if ((num2 <= DateTime.MinValue.Ticks) || (num2 > DateTime.MaxValue.Ticks))
                {
                    return DateTime.MinValue;
                }
                return smethod_13(num2, BookmarkStart.b("䘱崳唵匷䤹", num));
            }
            case VarEnum.VT_BLOB:
            {
                int count = A_0.ReadInt32();
                return A_0.ReadBytes(count);
            }
            case (VarEnum.VT_VECTOR | VarEnum.VT_LPSTR):
            {
                int num4 = (A_1 != 0x4b0) ? A_1 : 0x4e4;
                return smethod_4(A_0, num4);
            }
            case (VarEnum.VT_VECTOR | VarEnum.VT_LPWSTR):
                return smethod_4(A_0, A_1);

            case (VarEnum.VT_VECTOR | VarEnum.VT_VARIANT):
                return smethod_5(A_0, A_1);
        }
        return null;
    }

    private static string[] smethod_4(BinaryReader A_0, int A_1)
    {
        int num = A_0.ReadInt32();
        string[] strArray = new string[num];
        for (int i = 0; i < num; i++)
        {
            strArray[i] = smethod_11(A_0, A_1);
        }
        return strArray;
    }

    private static object[] smethod_5(BinaryReader A_0, int A_1)
    {
        int num = A_0.ReadInt32();
        object[] objArray = new object[num];
        for (int i = 0; i < num; i++)
        {
            objArray[i] = smethod_3(A_0, A_1);
        }
        bool flag = true;
        for (int j = 0; j < objArray.Length; j++)
        {
            object obj2 = objArray[j];
            flag &= Class567.smethod_3((long) j) ? ((obj2 is int) && (((int) obj2) > 0)) : (obj2 is string);
        }
        if (!flag)
        {
            return null;
        }
        return objArray;
    }

    private static void smethod_6(BinaryWriter A_0, object A_1, int A_2, bool A_3)
    {
        int num = 0x11;
        if (A_1 is string)
        {
            if (A_2 == 0x4b0)
            {
                A_0.Write(0x1f);
            }
            else
            {
                A_0.Write(30);
            }
            smethod_12(A_0, (string) A_1, A_2);
        }
        else if (A_1 is short)
        {
            A_0.Write(2);
            A_0.Write((short) A_1);
        }
        else if (A_1 is int)
        {
            A_0.Write(3);
            A_0.Write((int) A_1);
        }
        else if (A_1 is uint)
        {
            A_0.Write(0x13);
            A_0.Write((uint) A_1);
        }
        else if (A_1 is double)
        {
            A_0.Write(5);
            A_0.Write((double) A_1);
        }
        else if (A_1 is bool)
        {
            A_0.Write(11);
            bool flag = (bool) A_1;
            A_0.Write(flag ? ((short) (-1)) : ((short) 0));
        }
        else if (A_1 is DateTime)
        {
            A_0.Write(0x40);
            DateTime time = (DateTime) A_1;
            if (time != DateTime.MinValue)
            {
                A_0.Write(smethod_14(time, BookmarkStart.b("匶堸伺堼款⡀⹂⁄", num)));
            }
            else
            {
                A_0.Write((long) 0L);
            }
        }
        else if (A_1 is byte[])
        {
            A_0.Write(0x41);
            byte[] buffer = (byte[]) A_1;
            A_0.Write(buffer.Length);
            A_0.Write(buffer);
        }
        else if (A_1 is string[])
        {
            if (A_2 == 0x4b0)
            {
                A_0.Write(0x101f);
            }
            else
            {
                A_0.Write(0x101e);
            }
            string[] strArray2 = (string[]) A_1;
            A_0.Write(strArray2.Length);
            foreach (string str in strArray2)
            {
                smethod_12(A_0, str, A_2);
            }
        }
        else
        {
            if (!(A_1 is object[]))
            {
                throw new NotSupportedException(BookmarkStart.b("挶ᤸ䬺似倾ㅀ♂㝄㍆え歊㭌⹎㵐♒ご睖㙘㵚絜⭞ॠ੢ᙤ䝦ᵨቪᵬ੮兰ၲᑴ᥶奸ᕺቼ୾ꆀꞆ愈ﺊﶌﾎﺐﶘ떚", num));
            }
            A_0.Write(0x100c);
            object[] objArray = (object[]) A_1;
            A_0.Write(objArray.Length);
            foreach (object obj2 in objArray)
            {
                smethod_6(A_0, obj2, A_2, false);
            }
        }
        if (A_3)
        {
            Class567.smethod_6(A_0.BaseStream, 4);
        }
    }

    private static string smethod_7(BinaryReader A_0, int A_1)
    {
        int num = A_0.ReadInt32();
        if (!Class567.smethod_46(A_0, num))
        {
            num = 0;
        }
        byte[] bytes = A_0.ReadBytes(num);
        return Encoding.GetEncoding(A_1).GetString(bytes, 0, num).TrimEnd(new char[1]);
    }

    private static void smethod_8(BinaryWriter A_0, string A_1, int A_2)
    {
        A_1 = A_1 + '\0';
        byte[] bytes = Encoding.GetEncoding(A_2).GetBytes(A_1);
        A_0.Write(bytes.Length);
        A_0.Write(bytes);
    }

    private static string smethod_9(BinaryReader A_0)
    {
        int count = A_0.ReadInt32() * 2;
        byte[] bytes = A_0.ReadBytes(count);
        return Encoding.Unicode.GetString(bytes, 0, count - 2);
    }
}

