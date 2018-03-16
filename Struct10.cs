using System;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct10
{
    private PrivateFontCollection privateFontCollection_0;
    private string string_0;
    private Stream stream_0;
    public string method_0()
    {
        return this.string_0;
    }

    public void method_1(string A_0)
    {
        this.string_0 = A_0;
    }

    public Stream method_2()
    {
        return this.stream_0;
    }

    public void method_3(Stream A_0)
    {
        this.stream_0 = A_0;
    }

    public PrivateFontCollection method_4()
    {
        return this.privateFontCollection_0;
    }

    public void method_5(PrivateFontCollection A_0)
    {
        this.privateFontCollection_0 = A_0;
    }
}

