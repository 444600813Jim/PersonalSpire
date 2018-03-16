using System;
using System.Drawing;

internal class Class545
{
    public float float_0;
    public SizeF sizeF_0;
    public string string_0;
    public Struct11[] struct11_0;

    public bool method_0()
    {
        if (this.struct11_0 != null)
        {
            return (this.struct11_0.Length == 0);
        }
        return true;
    }

    public int method_1()
    {
        return (!this.method_0() ? this.struct11_0.Length : 0);
    }
}

