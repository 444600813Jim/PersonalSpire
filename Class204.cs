using System;
using System.Collections.Generic;
using System.Drawing;

internal class Class204
{
    private List<Color> list_0;

    public Class204()
    {
        Color[] collection = new Color[] { Color.FromArgb(0xff, 0x26, 0x26, 0x26), Color.FromArgb(0xff, 13, 13, 13), Color.FromArgb(0xff, 12, 12, 12), Color.FromArgb(0xff, 0x1d, 0x1b, 0x11), Color.FromArgb(0xff, 0x17, 0x36, 0x5d), Color.FromArgb(0xff, 15, 0x24, 0x3e), Color.FromArgb(0xff, 0x24, 0x40, 0x61), Color.FromArgb(0xff, 0x63, 0x24, 0x23), Color.FromArgb(0xff, 0x40, 0x31, 0x52), Color.FromArgb(0xff, 0xc0, 0, 0), Color.FromArgb(0xff, 0, 0x20, 0x60), Color.FromArgb(0xff, 0, 0, 0xff), Color.FromArgb(0xff, 0, 0, 0) };
        this.list_0 = new List<Color>(collection);
    }

    public bool method_0(Color A_0)
    {
        foreach (Color color in this.list_0)
        {
            if (color.Name.Equals(A_0.Name))
            {
                return true;
            }
            if (((color.A == A_0.A) && (color.R == A_0.R)) && ((color.G == A_0.G) && (color.B == A_0.B)))
            {
                return true;
            }
        }
        return false;
    }
}

