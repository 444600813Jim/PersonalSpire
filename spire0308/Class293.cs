using System;

internal class Class293 : Interface29
{
    private string string_0;

    public Class293(string A_0)
    {
        this.string_0 = A_0;
    }

    public string imethod_0(string A_0)
    {
        string str = A_0;
        if ((this.string_0 != null) && A_0.StartsWith(this.string_0))
        {
            str = A_0.Remove(0, this.string_0.Length);
        }
        return str;
    }
}

