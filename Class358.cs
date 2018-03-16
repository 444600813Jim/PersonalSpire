using Spire.CompoundFile.Doc;
using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

internal class Class358 : IDisposable, Interface37
{
    private bool bool_0;
    public const int int_0 = 0;
    public const int int_1 = 8;
    private const int int_2 = 4;
    private const int int_3 = 0xff;
    private const int int_4 = 0x20;
    internal const int int_5 = 0x1000000;
    public static readonly int int_6 = (8 + (IntPtr.Size * 2));
    public static readonly int int_7 = (8 + IntPtr.Size);
    private IntPtr intptr_0;
    private List<IntPtr> list_0;
    private List<IntPtr> list_1;
    private List<Class358> list_2;
    private const long long_0 = 0xffffffffL;
    internal const long long_1 = 0x701ce1722770000L;
    private Struct8 struct8_0;
    private const ulong ulong_0 = 18446744069414584320L;

    public Class358()
    {
        this.list_0 = new List<IntPtr>();
        this.list_1 = new List<IntPtr>();
        this.intptr_0 = Marshal.AllocHGlobal(int_6);
        this.struct8_0 = new Struct8();
        this.list_2 = new List<Class358>();
        this.bool_0 = true;
        this.struct8_0.intptr_0 = (IntPtr) 1L;
        int num = 0;
        for (int i = 0; num < (int_6 / 4); i += 4)
        {
            Marshal.WriteInt32(this.intptr_0, i, 0);
            num++;
        }
    }

    public Class358(IntPtr A_0) : this()
    {
        this.method_5(A_0);
    }

    internal Class358(Struct7 A_0, Interface43 A_1, bool A_2) : this()
    {
        this.method_40(A_0, A_1, A_2);
    }

    public bool imethod_5(object A_0, PropertyType A_1)
    {
        switch (A_1)
        {
            case PropertyType.Int32:
                this.method_3((int) A_0);
                break;

            case PropertyType.Double:
                this.method_19((double) A_0);
                break;

            case PropertyType.Bool:
                this.method_13((bool) A_0);
                break;

            case PropertyType.Int:
                this.method_1((int) A_0);
                break;

            case PropertyType.DateTime:
                this.method_17((DateTime) A_0);
                break;

            case PropertyType.Blob:
                this.method_29((byte[]) A_0);
                break;

            case PropertyType.String:
                this.method_15(A_0.ToString());
                break;

            case PropertyType.ObjectArray:
                this.method_28((object[]) A_0);
                break;

            case PropertyType.StringArray:
                this.method_27((string[]) A_0);
                break;

            default:
                return false;
        }
        return true;
    }

    object Interface37.imethod_0()
    {
        return this.method_38();
    }

    VarEnum Interface37.imethod_1()
    {
        return (VarEnum) Marshal.ReadInt16(this.intptr_0, 0);
    }

    string Interface37.imethod_2()
    {
        if (this.struct8_0.intptr_0 == ((IntPtr) 0L))
        {
            return Marshal.PtrToStringUni(this.struct8_0.intptr_1);
        }
        return null;
    }

    int Interface37.imethod_3()
    {
        return this.struct8_0.intptr_1.ToInt32();
    }

    void Interface37.imethod_4(int A_0)
    {
        this.struct8_0.intptr_0 = (IntPtr) 1L;
        this.struct8_0.intptr_1 = (IntPtr) A_0;
    }

    public int method_0()
    {
        return this.method_31().ToInt32();
    }

    public void method_1(int A_0)
    {
        this.method_36();
        this.method_35(VarEnum.VT_INT);
        this.method_32((IntPtr) A_0);
        this.method_34(IntPtr.Zero);
    }

    public FILETIME method_10()
    {
        FILETIME filetime = new FILETIME();
        long num = Marshal.ReadInt64(this.intptr_0, 8);
        filetime.dwLowDateTime = (int) (num & 0xffffffffL);
        filetime.dwHighDateTime = (int) ((num >> 0x20) & 0xffffffffL);
        return filetime;
    }

    public void method_11(FILETIME A_0)
    {
        this.method_35(VarEnum.VT_FILETIME);
        long val = (A_0.dwHighDateTime << 0x20) + ((long) ((ulong) A_0.dwLowDateTime));
        Marshal.WriteInt64(this.intptr_0, 8, val);
    }

    public bool method_12()
    {
        return (this.method_31() != IntPtr.Zero);
    }

    public void method_13(bool A_0)
    {
        this.method_35(VarEnum.VT_BOOL);
        this.method_32(A_0 ? ((IntPtr) 1) : IntPtr.Zero);
        this.method_34(IntPtr.Zero);
    }

    public string method_14()
    {
        return Marshal.PtrToStringUni(this.method_31());
    }

    public void method_15(string A_0)
    {
        IntPtr ptr = Marshal.StringToHGlobalUni(A_0);
        this.method_35(VarEnum.VT_LPWSTR);
        this.method_32(ptr);
        this.method_34(IntPtr.Zero);
        this.list_0.Add(ptr);
    }

    public DateTime method_16()
    {
        FILETIME filetime = this.method_10();
        long ticks = (filetime.dwHighDateTime << 0x20) + ((long) ((ulong) filetime.dwLowDateTime));
        ticks += 0x701ce1722770000L;
        DateTime time = new DateTime(ticks);
        if (this.method_6() != PIDSI.EditTime)
        {
            time = time.ToLocalTime();
        }
        return time;
    }

    public void method_17(DateTime A_0)
    {
        if (this.method_6() != PIDSI.EditTime)
        {
            A_0 = A_0.ToUniversalTime();
        }
        ulong num = (ulong) (A_0.Ticks - 0x701ce1722770000L);
        FILETIME filetime = new FILETIME {
            dwHighDateTime = (int) ((num & -4294967296L) >> 0x20),
            dwLowDateTime = (int) (num & ((ulong) 0xffffffffL))
        };
        this.method_11(filetime);
    }

    public double method_18()
    {
        return BitConverter.Int64BitsToDouble(Marshal.ReadInt64(this.intptr_0, 8));
    }

    public void method_19(double A_0)
    {
        this.method_35(VarEnum.VT_R8);
        long val = BitConverter.DoubleToInt64Bits(A_0);
        Marshal.WriteInt64(this.intptr_0, 8, val);
    }

    public int method_2()
    {
        return this.method_31().ToInt32();
    }

    public void method_20(string A_0)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔲吴嬶䰸帺", num));
        }
        this.method_30(A_0);
    }

    public bool method_21()
    {
        return ((this.struct8_0.intptr_0 == ((IntPtr) 1L)) && ((this.struct8_0.intptr_1.ToInt32() & 0x1000000) != 0));
    }

    public int method_22()
    {
        if (!this.method_21())
        {
            return this.struct8_0.intptr_1.ToInt32();
        }
        return (this.struct8_0.intptr_1.ToInt32() - 0x1000000);
    }

    public string[] method_23()
    {
        int num = this.method_31().ToInt32();
        string[] strArray = new string[num];
        IntPtr ptr = this.method_33();
        for (int i = 0; i < num; i++)
        {
            IntPtr ptr3 = Marshal.ReadIntPtr(ptr, i * IntPtr.Size);
            strArray[i] = this.method_24(ptr3);
        }
        return strArray;
    }

    private string method_24(IntPtr A_0)
    {
        int num = 0x11;
        if (A_0 == IntPtr.Zero)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜶䴸䤺渼䬾㍀⩂⭄⁆", num));
        }
        int num2 = ((int) this.Interface37.imethod_1()) & 0xff;
        if (num2 != 30)
        {
            return Marshal.PtrToStringUni(A_0);
        }
        return this.method_25(A_0);
    }

    private string method_25(IntPtr A_0)
    {
        int num = 3;
        if (A_0 == IntPtr.Zero)
        {
            throw new ArgumentNullException(BookmarkStart.b("夨弪弬簮䔰䄲尴夶常", num));
        }
        int ofs = 0;
        while (Marshal.ReadByte(A_0, ofs) != 0)
        {
            ofs++;
        }
        byte[] destination = new byte[ofs];
        Marshal.Copy(A_0, destination, 0, ofs);
        return Encoding.Default.GetString(destination, 0, ofs);
    }

    public object[] method_26()
    {
        int num = this.method_31().ToInt32();
        object[] objArray = new object[num];
        this.method_33();
        int index = 0;
        for (int i = 0; index < num; i += int_6)
        {
            objArray[index] = new Class358((IntPtr) (this.method_33().ToInt64() + i)).method_38();
            index++;
        }
        return objArray;
    }

    public void method_27(string[] A_0)
    {
        this.method_36();
        int length = A_0.Length;
        IntPtr[] ptrArray = new IntPtr[length];
        IntPtr item = Marshal.AllocHGlobal((int) (length * IntPtr.Size));
        this.list_1.Add(item);
        for (int i = 0; i < length; i++)
        {
            ptrArray[i] = Marshal.StringToHGlobalUni(A_0[i]);
            this.list_0.Add(ptrArray[i]);
        }
        int ofs = 0;
        for (int j = 0; j < length; j++)
        {
            Marshal.WriteIntPtr(item, ofs, ptrArray[j]);
            ofs += IntPtr.Size;
        }
        this.method_35(VarEnum.VT_VECTOR | VarEnum.VT_LPWSTR);
        this.method_32((IntPtr) length);
        this.method_34(item);
    }

    public void method_28(object[] A_0)
    {
        this.method_36();
        this.method_35(VarEnum.VT_VECTOR | VarEnum.VT_VARIANT);
        int length = A_0.Length;
        IntPtr item = Marshal.AllocHGlobal((int) (int_6 * length));
        this.list_1.Add(item);
        int index = 0;
        for (int i = 0; index < length; i += int_6)
        {
            Class358 class2;
            if (A_0[index] is int)
            {
                class2 = new Class358((IntPtr) (item.ToInt64() + i));
                class2.method_1((int) A_0[index]);
                class2.method_35(VarEnum.VT_I4);
                this.list_2.Add(class2);
            }
            else if (A_0[index] is string)
            {
                class2 = new Class358((IntPtr) (item.ToInt64() + i));
                class2.method_15((string) A_0[index]);
                this.list_2.Add(class2);
            }
            index++;
        }
        this.method_32((IntPtr) length);
        this.method_34(item);
    }

    public void method_29(byte[] A_0)
    {
        int num2 = 3;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弨䨪䄬娮吰", num2));
        }
        this.method_36();
        this.method_35(VarEnum.VT_BLOB);
        int length = A_0.Length;
        this.method_32((IntPtr) length);
        IntPtr destination = Marshal.AllocHGlobal(length);
        Marshal.Copy(A_0, 0, destination, length);
        this.method_34(destination);
        this.list_1.Add(destination);
    }

    public void method_3(int A_0)
    {
        this.method_36();
        this.method_35(VarEnum.VT_I4);
        this.method_32((IntPtr) A_0);
        this.method_34(IntPtr.Zero);
    }

    public void method_30(string A_0)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀲䄴䔶眸娺值娾", num));
        }
        if (A_0.Length == 0)
        {
            throw new ArgumentException(BookmarkStart.b("䀲䄴䔶眸娺值娾慀湂敄㑆㵈㥊⑌ⅎ㙐獒㙔㙖㝘㕚㉜⭞䅠Ţd䝦౨٪ᵬ᭮ࡰ嵲", num));
        }
        this.method_37();
        this.struct8_0.intptr_0 = (IntPtr) 0L;
        IntPtr ptr = Marshal.StringToHGlobalUni(A_0);
        this.struct8_0.intptr_1 = ptr;
    }

    private IntPtr method_31()
    {
        return Marshal.ReadIntPtr(this.intptr_0, 8);
    }

    private void method_32(IntPtr A_0)
    {
        Marshal.WriteIntPtr(this.intptr_0, 8, A_0);
    }

    private IntPtr method_33()
    {
        return Marshal.ReadIntPtr(this.intptr_0, int_7);
    }

    private void method_34(IntPtr A_0)
    {
        Marshal.WriteIntPtr(this.intptr_0, int_7, A_0);
    }

    public void method_35(VarEnum A_0)
    {
        Marshal.WriteInt16(this.intptr_0, 0, (short) A_0);
    }

    private void method_36()
    {
        IntPtr ptr;
        int num = 0;
        int count = this.list_0.Count;
        while (num < count)
        {
            ptr = this.list_0[num];
            Marshal.FreeCoTaskMem(ptr);
            num++;
        }
        this.list_0.Clear();
        int num3 = 0;
        int num4 = this.list_1.Count;
        while (num3 < num4)
        {
            ptr = this.list_1[num3];
            Marshal.FreeHGlobal(ptr);
            num3++;
        }
        this.list_1.Clear();
        for (int i = 0; i < this.list_2.Count; i++)
        {
            this.list_2[i].System.IDisposable.Dispose();
        }
        this.list_2.Clear();
    }

    private void method_37()
    {
        int num = (int) this.struct8_0.intptr_1;
        if ((this.struct8_0.intptr_0 == ((IntPtr) 0L)) && (num != 0))
        {
            IntPtr hglobal = (IntPtr) num;
            Marshal.FreeHGlobal(hglobal);
            this.struct8_0.intptr_1 = IntPtr.Zero;
        }
    }

    private object method_38()
    {
        VarEnum enum2 = this.Interface37.imethod_1();
        IntPtr ptr = (IntPtr) (this.intptr_0.ToInt64() + 8L);
        switch (enum2)
        {
            case VarEnum.VT_I4:
            case VarEnum.VT_INT:
                return Marshal.ReadInt32(ptr);

            case VarEnum.VT_R8:
                return BitConverter.Int64BitsToDouble(Marshal.ReadInt64(ptr));

            case VarEnum.VT_BOOL:
                return (Marshal.ReadInt32(ptr) != 0);

            case VarEnum.VT_LPSTR:
            case VarEnum.VT_LPWSTR:
            {
                string str = this.method_24(this.method_31());
                if (enum2 == VarEnum.VT_LPSTR)
                {
                    this.method_15(str);
                }
                return str;
            }
            case VarEnum.VT_FILETIME:
                return this.method_16();

            case VarEnum.VT_BLOB:
            {
                int length = this.method_31().ToInt32();
                byte[] destination = new byte[length];
                Marshal.Copy(this.method_33(), destination, 0, length);
                return destination;
            }
            case (VarEnum.VT_VECTOR | VarEnum.VT_LPSTR):
            case (VarEnum.VT_VECTOR | VarEnum.VT_LPWSTR):
            {
                object obj2 = this.method_23();
                this.method_35(VarEnum.VT_VECTOR | VarEnum.VT_LPWSTR);
                return obj2;
            }
            case (VarEnum.VT_VECTOR | VarEnum.VT_VARIANT):
                return this.method_26();
        }
        return null;
    }

    [CLSCompliant(false)]
    public void method_39(Interface43 A_0)
    {
        PID pid = PID.PID_FIRST_USABLE;
        if (this.struct8_0.intptr_0 == ((IntPtr) 1L))
        {
            pid = (PID) ((int) this.struct8_0.intptr_1);
        }
        A_0.imethod_13(1, ref this.struct8_0, this.method_4(), pid);
    }

    public IntPtr method_4()
    {
        return this.intptr_0;
    }

    internal void method_40(Struct7 A_0, Interface43 A_1, bool A_2)
    {
        this.struct8_0.intptr_1 = (IntPtr) A_0.uint_0;
        this.struct8_0.intptr_0 = (IntPtr) 1L;
        A_1.imethod_12(1, ref this.struct8_0, this.intptr_0);
        if (!A_2 && ((this.struct8_0.intptr_1.ToInt32() & 0x1000000) == 0))
        {
            this.method_20(A_0.string_0);
        }
    }

    [CLSCompliant(false)]
    public void method_41(Interface43 A_0, bool A_1)
    {
        A_0.imethod_12(1, ref this.struct8_0, this.intptr_0);
    }

    public void method_5(IntPtr A_0)
    {
        this.method_36();
        if (this.intptr_0 != A_0)
        {
            this.intptr_0 = A_0;
            this.bool_0 = false;
        }
    }

    public PIDSI method_6()
    {
        return (PIDSI) ((int) this.struct8_0.intptr_1);
    }

    public void method_7(PIDSI A_0)
    {
        this.struct8_0.intptr_0 = (IntPtr) 1L;
        this.struct8_0.intptr_1 = (IntPtr) ((long) A_0);
    }

    public PIDDSI method_8()
    {
        return (PIDDSI) ((int) this.struct8_0.intptr_1);
    }

    public void method_9(PIDDSI A_0)
    {
        this.struct8_0.intptr_1 = (IntPtr) ((long) A_0);
    }

    void IDisposable.Dispose()
    {
        if (this.intptr_0 != IntPtr.Zero)
        {
            this.method_36();
            this.method_37();
            if (this.bool_0)
            {
                Marshal.FreeHGlobal(this.intptr_0);
                this.intptr_0 = IntPtr.Zero;
            }
        }
        GC.SuppressFinalize(this);
    }

    void object.Finalize()
    {
        try
        {
            this.System.IDisposable.Dispose();
        }
        finally
        {
            base.Finalize();
        }
    }
}

