using System;

internal class Class784
{
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_2;
    internal bool bool_3;
    internal bool bool_4;
    internal bool bool_5;
    internal bool bool_6;
    internal Class623 class623_0 = new Class623();
    internal Class623 class623_1 = new Class623();
    internal Class623 class623_2 = new Class623();
    internal Class623 class623_3 = new Class623();
    internal Class623 class623_4 = new Class623();
    internal Class623 class623_5 = new Class623();
    internal Class72 class72_0;
    internal Class72 class72_1;

    internal int method_0()
    {
        int num = 0;
        num = 0 | (this.bool_0 ? 0x2000 : 0);
        num |= this.class623_1.method_0() ? 0x1000 : 0;
        num |= this.class623_0.method_0() ? 0x800 : 0;
        num |= this.class623_5.method_0() ? 0x400 : 0;
        num |= this.class623_4.method_0() ? 0x200 : 0;
        num |= this.class623_3.method_0() ? 0x100 : 0;
        num |= this.class623_2.method_0() ? 0x80 : 0;
        num |= this.bool_1 ? 0x20 : 0;
        num |= this.bool_2 ? 0x10 : 0;
        num |= this.bool_3 ? 8 : 0;
        num |= this.bool_4 ? 4 : 0;
        num |= this.bool_6 ? 2 : 0;
        return (num | (this.bool_5 ? 1 : 0));
    }
}

