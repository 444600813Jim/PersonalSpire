using System;
using System.Collections.Generic;
using System.Drawing;

internal class Class498 : IDisposable
{
    private Image image_0;
    private List<Dictionary<string, RectangleF>> list_0;
    private List<Dictionary<string, Class310>> list_1;

    public Class498()
    {
    }

    public Class498(List<Dictionary<string, RectangleF>> A_0, List<Dictionary<string, Class310>> A_1) : this(null, A_0, A_1)
    {
    }

    public Class498(Image A_0, List<Dictionary<string, RectangleF>> A_1, List<Dictionary<string, Class310>> A_2)
    {
        this.image_0 = A_0;
        this.list_0 = A_1;
        this.list_1 = A_2;
    }

    public Image method_0()
    {
        return this.image_0;
    }

    public void method_1(Image A_0)
    {
        this.image_0 = A_0;
    }

    public List<Dictionary<string, RectangleF>> method_2()
    {
        return this.list_0;
    }

    public void method_3(List<Dictionary<string, RectangleF>> A_0)
    {
        this.list_0 = A_0;
    }

    public List<Dictionary<string, Class310>> method_4()
    {
        return this.list_1;
    }

    public void method_5(List<Dictionary<string, Class310>> A_0)
    {
        this.list_1 = A_0;
    }

    void IDisposable.Dispose()
    {
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
    }
}

