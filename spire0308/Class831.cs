using System;

internal class Class831
{
    internal char char_0;
    internal Class639 class639_0;
    internal string string_0;
    private string string_1;

    public void method_0(string A_0, string A_1, char A_2)
    {
        this.string_0 = A_0;
        this.string_1 = A_1;
        this.char_0 = A_2;
        this.class639_0 = null;
    }

    public string method_1()
    {
        if (this.string_1 != null)
        {
            return this.string_1;
        }
        if (this.class639_0 != null)
        {
            return this.class639_0.method_1();
        }
        return null;
    }

    public bool method_2()
    {
        return (this.string_1 == null);
    }
}

