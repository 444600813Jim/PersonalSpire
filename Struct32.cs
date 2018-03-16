using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct32
{
    public string string_0;
    public string string_1;
    public string string_2;
    public string string_3;
    public string string_4;
    public string string_5;
    public string string_6;
    public void method_0(Struct32 A_0)
    {
        if (string.IsNullOrEmpty(this.string_0) && !string.IsNullOrEmpty(A_0.string_0))
        {
            this.string_0 = A_0.string_0;
        }
        if (string.IsNullOrEmpty(this.string_1) && !string.IsNullOrEmpty(A_0.string_1))
        {
            this.string_1 = A_0.string_1;
        }
        if (string.IsNullOrEmpty(this.string_2) && !string.IsNullOrEmpty(A_0.string_2))
        {
            this.string_2 = A_0.string_2;
        }
        if (string.IsNullOrEmpty(this.string_3) && !string.IsNullOrEmpty(A_0.string_3))
        {
            this.string_3 = A_0.string_3;
        }
        if (string.IsNullOrEmpty(this.string_4) && !string.IsNullOrEmpty(A_0.string_4))
        {
            this.string_4 = A_0.string_4;
        }
        if (string.IsNullOrEmpty(this.string_5) && !string.IsNullOrEmpty(A_0.string_5))
        {
            this.string_5 = A_0.string_5;
        }
        if (string.IsNullOrEmpty(this.string_6) && !string.IsNullOrEmpty(A_0.string_6))
        {
            this.string_6 = A_0.string_6;
        }
    }

    public bool method_1()
    {
        if ((string.IsNullOrEmpty(this.string_0) && string.IsNullOrEmpty(this.string_1)) && string.IsNullOrEmpty(this.string_2))
        {
            return !string.IsNullOrEmpty(this.string_3);
        }
        return true;
    }
}

