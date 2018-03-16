using System;

internal class Class664 : Interface61
{
    private Class1069 class1069_0;

    public Class664(Class1069 A_0)
    {
        this.class1069_0 = A_0;
    }

    public void imethod_12(Interface61 A_0)
    {
        this.class1069_0.imethod_12(A_0);
    }

    public void imethod_13(Stream1 A_0)
    {
        this.class1069_0.imethod_13(A_0);
    }

    public Stream1 imethod_2(string A_0)
    {
        return this.class1069_0.imethod_2(A_0);
    }

    public Interface61 imethod_4(string A_0)
    {
        return this.class1069_0.imethod_4(A_0);
    }

    public bool imethod_7(string A_0)
    {
        return this.class1069_0.imethod_7(A_0);
    }

    public void imethod_8()
    {
        this.class1069_0.Interface59.imethod_1();
    }

    Stream1 Interface61.imethod_0(string A_0)
    {
        return this.class1069_0.Interface61.imethod_0(A_0);
    }

    void Interface61.imethod_1(string A_0)
    {
        this.class1069_0.Interface61.imethod_1(A_0);
    }

    string[] Interface61.imethod_10()
    {
        return this.class1069_0.Interface61.imethod_10();
    }

    string Interface61.imethod_11()
    {
        return this.class1069_0.Interface61.imethod_11();
    }

    bool Interface61.imethod_3(string A_0)
    {
        return this.class1069_0.Interface61.imethod_3(A_0);
    }

    Interface61 Interface61.imethod_5(string A_0)
    {
        return this.class1069_0.Interface61.imethod_5(A_0);
    }

    void Interface61.imethod_6(string A_0)
    {
        this.class1069_0.Interface61.imethod_6(A_0);
    }

    string[] Interface61.imethod_9()
    {
        return this.class1069_0.Interface61.imethod_9();
    }

    internal Class1069 method_0()
    {
        return this.class1069_0;
    }

    void IDisposable.Dispose()
    {
        if (this.class1069_0 != null)
        {
            this.class1069_0 = null;
            GC.SuppressFinalize(this);
        }
    }
}

