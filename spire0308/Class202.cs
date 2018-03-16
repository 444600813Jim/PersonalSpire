using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;

internal class Class202 : IDisposable
{
    private PrivateFontCollection privateFontCollection_0 = new PrivateFontCollection();

    public int method_0()
    {
        return this.method_1().Length;
    }

    private FontFamily[] method_1()
    {
        if (this.privateFontCollection_0 == null)
        {
            this.privateFontCollection_0 = new PrivateFontCollection();
        }
        return this.privateFontCollection_0.Families;
    }

    public void method_2(string A_0)
    {
        if (this.privateFontCollection_0 == null)
        {
            this.privateFontCollection_0 = new PrivateFontCollection();
        }
        this.privateFontCollection_0.AddFontFile(A_0);
    }

    public void method_3(IntPtr A_0, int A_1)
    {
        if (this.privateFontCollection_0 == null)
        {
            this.privateFontCollection_0 = new PrivateFontCollection();
        }
        this.privateFontCollection_0.AddMemoryFont(A_0, A_1);
    }

    public int method_4(string A_0)
    {
        int index = 0;
        int length = this.method_1().Length;
        while (index < length)
        {
            if (this.method_1()[index].Name.Contains(A_0))
            {
                return index;
            }
            index++;
        }
        return -1;
    }

    public FontFamily method_5(int A_0)
    {
        if ((A_0 >= 0) && (this.method_1().Length > A_0))
        {
            return this.method_1()[A_0];
        }
        return null;
    }

    public FontFamily method_6(string A_0)
    {
        return this.method_5(this.method_4(A_0));
    }

    public FontFamily method_7(string A_0, List<int> A_1)
    {
        string str = A_0.ToLowerInvariant();
        int index = 0;
        int length = this.method_1().Length;
        while (index < length)
        {
            FontFamily family = this.method_1()[index];
            if (str.Equals(family.Name.ToLowerInvariant()))
            {
                return family;
            }
            if (A_1.Count > 0)
            {
                foreach (int num3 in A_1)
                {
                    string str2 = family.GetName(num3).ToLowerInvariant();
                    if (str.Equals(str2))
                    {
                        return family;
                    }
                }
            }
            index++;
        }
        return null;
    }

    void IDisposable.Dispose()
    {
        if (this.privateFontCollection_0 != null)
        {
            this.privateFontCollection_0.Dispose();
        }
    }
}

