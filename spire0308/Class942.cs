using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;

[Guid("0000010e-0000-0000-C000-000000000046"), ComVisible(true), CLSCompliant(false), ClassInterface(ClassInterfaceType.None)]
internal class Class942 : Interface67
{
    private Class941 class941_0 = new Class941();

    public uint imethod_2(ref Struct34 A_0)
    {
        return 0x80000001;
    }

    public uint imethod_3(ref Struct34 A_0, ref Struct34 A_1)
    {
        return 0x80000001;
    }

    public uint imethod_4(ref Struct34 A_0, ref Struct33 A_1, int A_2)
    {
        Struct34 struct2 = A_0;
        Struct33 struct3 = A_1;
        if (IntPtr.Zero != struct3.intptr_0)
        {
            Marshal.AddRef(struct3.intptr_0);
        }
        struct3.intptr_1 = IntPtr.Zero;
        if (A_2 > 0)
        {
            if (IntPtr.Zero != A_1.intptr_0)
            {
                Marshal.Release(A_1.intptr_0);
            }
            if (IntPtr.Zero != A_1.intptr_1)
            {
                Marshal.Release(A_1.intptr_1);
            }
        }
        this.class941_0.Add(new Class940(DATADIR.DATADIR_SET, struct3, struct2));
        return 0;
    }

    public uint imethod_5(uint A_0, ref Interface66 A_1)
    {
        A_1 = this.class941_0;
        return 0;
    }

    public uint imethod_6(ref Struct34 A_0, uint A_1, IntPtr A_2, ref uint A_3)
    {
        return 0x80040003;
    }

    public uint imethod_7(uint A_0)
    {
        return 0x80040003;
    }

    public uint imethod_8(ref IntPtr A_0)
    {
        return 0x80040003;
    }

    uint Interface67.imethod_0(ref Struct34 A_0, ref Struct33 A_1)
    {
        if (this.class941_0.Count > 0)
        {
            Class940 class2 = (Class940) this.class941_0[0];
            A_0 = class2.method_1();
            A_1 = class2.method_0();
            return 0;
        }
        return 0x80040064;
    }

    uint Interface67.imethod_1(ref Struct34 A_0, ref Struct33 A_1)
    {
        return 0x80000001;
    }
}

