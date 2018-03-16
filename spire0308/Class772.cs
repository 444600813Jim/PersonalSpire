using System;

internal class Class772
{
    private byte[] byte_0 = new byte[0x100];
    private byte byte_1;
    private byte byte_2;

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal void method_1(byte[] A_0)
    {
        if (this.byte_0 != A_0)
        {
            this.byte_0 = A_0;
        }
    }

    internal byte method_2()
    {
        return this.byte_1;
    }

    internal void method_3(byte A_0)
    {
        if (this.byte_1 != A_0)
        {
            this.byte_1 = A_0;
        }
    }

    internal byte method_4()
    {
        return this.byte_2;
    }

    internal void method_5(byte A_0)
    {
        if (this.byte_2 != A_0)
        {
            this.byte_2 = A_0;
        }
    }
}

