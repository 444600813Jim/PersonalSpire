using System;

internal class Class914
{
    private readonly string string_0;
    private readonly string string_1;

    internal Class914(string A_0, string A_1)
    {
        this.string_0 = A_0;
        this.string_1 = A_1;
    }

    internal string method_0()
    {
        return this.string_0;
    }

    internal string method_1()
    {
        return this.string_1;
    }

    internal static Class914 smethod_0(string A_0)
    {
        string[] strArray = A_0.Split(new char[] { ':' });
        if (strArray.Length >= 2)
        {
            string str = strArray[0].Trim();
            string str2 = strArray[1].Trim();
            if (!string.IsNullOrEmpty(str) && !string.IsNullOrEmpty(str2))
            {
                return new Class914(str, str2);
            }
        }
        return null;
    }
}

