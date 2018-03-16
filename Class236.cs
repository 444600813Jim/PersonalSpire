using Spire.Doc;
using System;
using System.Drawing;

internal class Class236
{
    private readonly Color color_0;
    private readonly Color color_1;

    public Class236(Color A_0, Color A_1)
    {
        int num = 2;
        if (A_0.IsEmpty)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐧䔩嬫洭弯帱嬳䐵", num));
        }
        if (A_1.IsEmpty)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀧䌩䬫䘭猯崱堳夵䨷", num));
        }
        this.color_1 = A_0;
        this.color_0 = A_1;
    }

    public Class236(Color A_0, int A_1)
    {
        int num = 0x13;
        if (A_0.IsEmpty)
        {
            throw new ArgumentNullException(BookmarkStart.b("娸帺匼䬾⑀ㅂ", num));
        }
        this.color_1 = Color.FromArgb(0xff, Math.Max(A_0.R - A_1, 0), Math.Max(A_0.G - A_1, 0), Math.Max(A_0.B - A_1, 0));
        this.color_0 = Color.FromArgb(0xff, Math.Min(A_0.R + A_1, 0xff), Math.Min(A_0.G + A_1, 0xff), Math.Min(A_0.B + A_1, 0xff));
    }

    public Color method_0()
    {
        return this.color_1;
    }

    public Color method_1()
    {
        return this.color_0;
    }

    public bool method_2(Color A_0)
    {
        return this.method_3(A_0.R, A_0.G, A_0.B);
    }

    public bool method_3(int A_0, int A_1, int A_2)
    {
        return (((((A_0 >= this.method_0().R) && (A_0 <= this.method_1().R)) && ((A_1 >= this.method_0().G) && (A_1 <= this.method_1().G))) && (A_2 >= this.method_0().B)) && (A_2 <= this.method_1().B));
    }

    int object.GetHashCode()
    {
        return ((this.color_1.GetHashCode() * 0x18d) ^ this.color_0.GetHashCode());
    }
}

