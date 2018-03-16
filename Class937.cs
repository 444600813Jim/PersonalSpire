using Spire.CompoundFile.Doc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

internal class Class937 : IComparable, Interface37
{
    private const int int_0 = 0x1000000;
    private const int int_1 = 0;
    private int int_2;
    public object object_0;
    public PropertyType propertyType_0;
    private string string_0;

    internal Class937()
    {
    }

    public Class937(int A_0)
    {
        this.imethod_4(A_0);
    }

    public void imethod_4(int A_0)
    {
        this.int_2 = A_0;
    }

    public bool imethod_5(object A_0, PropertyType A_1)
    {
        bool flag = false;
        PropertyType type = A_1;
        if (type <= PropertyType.String)
        {
            if (type <= PropertyType.UInt32)
            {
                switch (type)
                {
                    case PropertyType.Empty:
                    case PropertyType.Null:
                    case PropertyType.Int16:
                    case PropertyType.Int32:
                    case PropertyType.Double:
                    case PropertyType.Bool:
                    case PropertyType.Object:
                    case PropertyType.UInt32:
                        goto Label_00A8;

                    case 4:
                    case 6:
                    case (PropertyType.Double | PropertyType.Int16):
                    case 8:
                    case 9:
                    case 10:
                        return flag;
                }
                return flag;
            }
            switch (type)
            {
                case PropertyType.AsciiString:
                case PropertyType.String:
                case PropertyType.Int:
                    goto Label_00A8;
            }
            return flag;
        }
        if (type <= PropertyType.Vector)
        {
            switch (type)
            {
                case PropertyType.DateTime:
                case PropertyType.Blob:
                case PropertyType.Vector:
                    goto Label_00A8;
            }
            return flag;
        }
        switch (type)
        {
            case PropertyType.AsciiStringArray:
            case PropertyType.StringArray:
            case PropertyType.ObjectArray:
                break;

            default:
                return flag;
        }
    Label_00A8:
        this.method_16(A_0);
        this.method_17((VarEnum) A_1);
        return true;
    }

    object Interface37.imethod_0()
    {
        return this.object_0;
    }

    VarEnum Interface37.imethod_1()
    {
        return (VarEnum) this.propertyType_0;
    }

    string Interface37.imethod_2()
    {
        return this.string_0;
    }

    int Interface37.imethod_3()
    {
        return this.int_2;
    }

    public bool method_0()
    {
        return ((this.Interface37.imethod_3() & 0x1000000) != 0);
    }

    public int method_1()
    {
        if (!this.method_0())
        {
            return this.Interface37.imethod_3();
        }
        return (this.Interface37.imethod_3() - 0x1000000);
    }

    private int method_10(Stream A_0, object A_1)
    {
        PropertyType @bool;
        if (A_1 is int)
        {
            @bool = PropertyType.Int32;
        }
        else if (A_1 is double)
        {
            @bool = PropertyType.Double;
        }
        else if (A_1 is bool)
        {
            @bool = PropertyType.Bool;
        }
        else
        {
            if (!(A_1 is string))
            {
                throw new NotImplementedException();
            }
            @bool = PropertyType.String;
        }
        Class1115.smethod_4(A_0, (int) @bool);
        return (this.method_14(A_0, A_1, @bool) + 4);
    }

    public int method_11(Stream A_0)
    {
        int num = Class1115.smethod_4(A_0, (int) this.propertyType_0);
        if ((this.propertyType_0 & PropertyType.Vector) == PropertyType.Vector)
        {
            num += this.method_13(A_0, (IList) this.object_0);
        }
        else if (this.Interface37.imethod_3() == 0)
        {
            if (this.object_0 != null)
            {
                A_0.Position -= 4L;
                num += this.method_12(A_0, (Dictionary<int, string>) this.object_0);
            }
        }
        else
        {
            num += this.method_14(A_0, this.object_0, this.propertyType_0);
        }
        Class1115.smethod_11(A_0, ref num);
        return num;
    }

    private int method_12(Stream A_0, Dictionary<int, string> A_1)
    {
        int num = 0;
        int count = A_1.Count;
        num = 0 + Class1115.smethod_4(A_0, count);
        foreach (KeyValuePair<int, string> pair in A_1)
        {
            num += Class1115.smethod_4(A_0, pair.Key);
            num += Class1115.smethod_8(A_0, pair.Value);
        }
        return num;
    }

    private int method_13(Stream A_0, IList A_1)
    {
        int count = A_1.Count;
        Class1115.smethod_4(A_0, count);
        int num2 = 4;
        PropertyType type = this.propertyType_0 & ~PropertyType.Vector;
        for (int i = 0; i < count; i++)
        {
            num2 += this.method_14(A_0, A_1[i], type);
        }
        return num2;
    }

    private int method_14(Stream A_0, object A_1, PropertyType A_2)
    {
        int num = 0;
        switch (A_2)
        {
            case PropertyType.Empty:
            case PropertyType.Null:
                return num;

            case PropertyType.Int16:
                return (num + Class1115.smethod_3(A_0, (short) A_1));

            case PropertyType.Int32:
            case PropertyType.Int:
                return (num + Class1115.smethod_4(A_0, (int) A_1));

            case PropertyType.Double:
                return (num + Class1115.smethod_5(A_0, (double) A_1));

            case PropertyType.Bool:
            {
                bool flag = (bool) A_1;
                return (num + Class1115.smethod_4(A_0, flag ? 1 : 0));
            }
            case PropertyType.Object:
                return (num + this.method_10(A_0, A_1));

            case PropertyType.UInt32:
                return (num + Class1115.smethod_4(A_0, (int) ((uint) A_1)));

            case PropertyType.AsciiString:
                return (num + Class1115.smethod_8(A_0, (string) A_1));

            case PropertyType.String:
                return (num + Class1115.smethod_9(A_0, (string) A_1));

            case PropertyType.DateTime:
            {
                DateTime time;
                if (A_1 is TimeSpan)
                {
                    TimeSpan span = (TimeSpan) A_1;
                    time = DateTime.FromBinary(span.Ticks);
                }
                else
                {
                    time = (DateTime) A_1;
                }
                if (this.Interface37.imethod_3() != 10)
                {
                    time = time.ToUniversalTime();
                }
                ulong num2 = (ulong) (time.Ticks - 0x701ce1722770000L);
                byte[] bytes = BitConverter.GetBytes(num2);
                A_0.Write(bytes, 0, bytes.Length);
                return (num + bytes.Length);
            }
            case PropertyType.Blob:
            {
                byte[] buffer = (byte[]) A_1;
                return (num + this.method_15(A_0, buffer));
            }
        }
        throw new NotImplementedException();
    }

    private int method_15(Stream A_0, byte[] A_1)
    {
        int num = 0;
        int length = A_1.Length;
        num = 0 + Class1115.smethod_4(A_0, length);
        A_0.Write(A_1, 0, length);
        return (num + length);
    }

    public void method_16(object A_0)
    {
        this.object_0 = A_0;
    }

    public void method_17(VarEnum A_0)
    {
        this.propertyType_0 = (PropertyType) A_0;
    }

    public void method_18(string A_0)
    {
        this.string_0 = A_0;
    }

    public void method_2(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[4];
        this.propertyType_0 = (PropertyType) Class1115.smethod_1(A_0, buffer);
        if ((this.propertyType_0 & PropertyType.Vector) != PropertyType.Empty)
        {
            this.object_0 = this.method_3(A_0, A_1);
        }
        else
        {
            this.object_0 = this.method_5(this.propertyType_0, A_0, A_1);
        }
        if ((this.propertyType_0 & PropertyType.AsciiString) == PropertyType.AsciiString)
        {
            this.propertyType_0 &= ~PropertyType.AsciiString;
            this.propertyType_0 |= PropertyType.String;
        }
    }

    private IList method_3(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[4];
        int num = Class1115.smethod_1(A_0, buffer);
        PropertyType type = this.propertyType_0 & ~PropertyType.Vector;
        IList list = this.method_4(type, num);
        for (int i = 0; i < num; i++)
        {
            list[i] = this.method_5(type, A_0, A_1 - 4);
        }
        return list;
    }

    private IList method_4(PropertyType A_0, int A_1)
    {
        switch (A_0)
        {
            case PropertyType.Int32:
            case PropertyType.Int:
                return new int[A_1];

            case PropertyType.AsciiString:
            case PropertyType.String:
                return new string[A_1];
        }
        return new object[A_1];
    }

    private object method_5(PropertyType A_0, Stream A_1, int A_2)
    {
        byte[] buffer = new byte[8];
        object obj2 = null;
        switch (A_0)
        {
            case PropertyType.Empty:
            case PropertyType.Null:
                return null;

            case PropertyType.Int16:
                obj2 = Class1115.smethod_0(A_1, buffer);
                A_1.Position += 2L;
                return obj2;

            case PropertyType.Int32:
            case PropertyType.Int:
                return Class1115.smethod_1(A_1, buffer);

            case PropertyType.Double:
                return Class1115.smethod_2(A_1, buffer);

            case PropertyType.Bool:
                return (Class1115.smethod_1(A_1, buffer) != 0);

            case PropertyType.Object:
                return this.method_9(A_1, A_2 - 4);

            case PropertyType.UInt32:
                return (uint) Class1115.smethod_0(A_1, buffer);

            case PropertyType.AsciiString:
                return Class1115.smethod_6(A_1, A_2 - 4);

            case PropertyType.String:
                return Class1115.smethod_7(A_1, A_2 - 4);

            case PropertyType.DateTime:
                return this.method_8(A_1, buffer);

            case PropertyType.Blob:
                return this.method_6(A_1, buffer);

            case PropertyType.ClipboardData:
                return this.method_7(A_1, buffer);
        }
        throw new NotImplementedException();
    }

    private object method_6(Stream A_0, byte[] A_1)
    {
        int count = Class1115.smethod_1(A_0, A_1);
        byte[] buffer = new byte[count];
        if (A_0.Read(buffer, 0, count) != count)
        {
            throw new Exception();
        }
        return buffer;
    }

    private object method_7(Stream A_0, byte[] A_1)
    {
        ClipboardData data = new ClipboardData();
        data.Parse(A_0);
        return data;
    }

    private object method_8(Stream A_0, byte[] A_1)
    {
        A_0.Read(A_1, 0, 8);
        long ticks = BitConverter.ToInt64(A_1, 0) + 0x701ce1722770000L;
        DateTime time = new DateTime(ticks);
        if (this.Interface37.imethod_3() != 10)
        {
            time = time.ToLocalTime();
        }
        return time;
    }

    private object method_9(Stream A_0, int A_1)
    {
        byte[] buffer = new byte[4];
        PropertyType type = (PropertyType) Class1115.smethod_1(A_0, buffer);
        return this.method_5(type, A_0, A_1 - 4);
    }

    int IComparable.CompareTo(object A_0)
    {
        Class937 class2 = (Class937) A_0;
        return (this.Interface37.imethod_3() - class2.Interface37.imethod_3());
    }
}

