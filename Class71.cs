using Spire.Doc;
using System;

internal class Class71 : Interface7
{
    private readonly Interface0 interface0_0;

    internal Class71(Interface0 A_0)
    {
        this.interface0_0 = A_0;
    }

    private string imethod_0()
    {
        return (string) this.interface0_0.imethod_2(0x1008);
    }

    private void imethod_1(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("弨䨪䄬娮吰", 3));
        this.interface0_0.imethod_3(0x1008, A_0);
    }

    private byte[] imethod_2()
    {
        return (byte[]) this.interface0_0.imethod_2(0x1006);
    }

    private void imethod_3(byte[] A_0)
    {
        if ((A_0 != null) && (A_0.Length != 0))
        {
            this.interface0_0.imethod_3(0x1006, A_0);
        }
        else
        {
            this.interface0_0.imethod_4(0x1006);
        }
    }
}

