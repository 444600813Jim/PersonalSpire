using Spire.Doc.Converters.Sgml;
using System;
using System.Xml;

internal class Class832
{
    internal bool bool_0;
    internal bool bool_1;
    internal Class636 class636_0;
    private Class830 class830_0 = new Class830(10);
    internal State state_0;
    internal string string_0;
    internal string string_1;
    internal string string_2;
    internal XmlNodeType xmlNodeType_0;
    internal XmlSpace xmlSpace_0;

    public void method_0(string A_0, XmlNodeType A_1, string A_2)
    {
        this.string_0 = A_2;
        this.string_2 = A_0;
        this.xmlNodeType_0 = A_1;
        this.xmlSpace_0 = XmlSpace.None;
        this.string_1 = null;
        this.bool_0 = true;
        this.class830_0.method_1(0);
        this.class636_0 = null;
    }

    public Class831 method_1(string A_0, string A_1, char A_2, bool A_3)
    {
        Class831 class2;
        int num = 0;
        int num2 = this.class830_0.method_0();
        while (num < num2)
        {
            class2 = (Class831) this.class830_0.method_3(num);
            if (string.Equals(class2.string_0, A_0, A_3 ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
            {
                return null;
            }
            num++;
        }
        class2 = (Class831) this.class830_0.method_6();
        if (class2 == null)
        {
            class2 = new Class831();
            this.class830_0.method_4(this.class830_0.method_0() - 1, class2);
        }
        class2.method_0(A_0, A_1, A_2);
        return class2;
    }

    public void method_2(string A_0)
    {
        int num = 0;
        int num2 = this.class830_0.method_0();
        while (num < num2)
        {
            Class831 class2 = (Class831) this.class830_0.method_3(num);
            if (string.Equals(class2.string_0, A_0, StringComparison.OrdinalIgnoreCase))
            {
                this.class830_0.method_7(num);
                return;
            }
            num++;
        }
    }

    public void method_3(Class832 A_0)
    {
        int num = 0;
        int num2 = A_0.class830_0.method_0();
        while (num < num2)
        {
            Class831 class2 = (Class831) A_0.class830_0.method_3(num);
            this.method_1(class2.string_0, class2.method_1(), class2.char_0, false).class639_0 = class2.class639_0;
            num++;
        }
    }

    public int method_4()
    {
        return this.class830_0.method_0();
    }

    public int method_5(string A_0)
    {
        int num = 0;
        int num2 = this.class830_0.method_0();
        while (num < num2)
        {
            Class831 class2 = (Class831) this.class830_0.method_3(num);
            if (string.Equals(class2.string_0, A_0, StringComparison.OrdinalIgnoreCase))
            {
                return num;
            }
            num++;
        }
        return -1;
    }

    public Class831 method_6(int A_0)
    {
        if ((A_0 >= 0) && (A_0 < this.class830_0.method_0()))
        {
            return (Class831) this.class830_0.method_3(A_0);
        }
        return null;
    }
}

