using System;
using System.Collections;
using System.Runtime.InteropServices;

[ComVisible(true), CLSCompliant(false)]
internal class Class941 : ArrayList, Interface66
{
    private int int_0 = -1;

    public uint imethod_0(ref Interface66 A_0)
    {
        return 0x80000001;
    }

    public uint imethod_1(uint A_0, ref Struct34 A_1, ref uint A_2)
    {
        int num = (A_0 > 1) ? 1 : ((int) A_0);
        this.int_0 += num;
        if (this.int_0 >= this.Count)
        {
            return 0x80004005;
        }
        A_1 = ((Class940) this[this.int_0]).method_1();
        A_2 = (uint) num;
        return 0;
    }

    public uint imethod_2()
    {
        this.int_0 = -1;
        return 0;
    }

    public uint imethod_3(uint A_0)
    {
        if ((this.int_0 + A_0) > this.Count)
        {
            return 0x80004005;
        }
        this.int_0 += (int) A_0;
        return 0;
    }
}

