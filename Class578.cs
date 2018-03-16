using Spire.Doc.Documents;
using System;
using System.ComponentModel;

internal class Class578 : Class577, Interface31
{
    private bool bool_0;
    private bool bool_1;
    private readonly byte[] byte_0;
    private readonly int[] int_0;
    private readonly ListPatternType[] listPatternType_0;
    private string string_1;

    internal Class578() : base("", DateTime.MinValue)
    {
        this.byte_0 = new byte[9];
        this.listPatternType_0 = new ListPatternType[9];
        this.int_0 = new int[9];
        this.string_1 = "";
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private Interface31 imethod_1()
    {
        return (Class578) base.MemberwiseClone();
    }

    bool Interface31.imethod_0()
    {
        return false;
    }

    internal byte[] method_10()
    {
        return this.byte_0;
    }

    internal ListPatternType[] method_11()
    {
        return this.listPatternType_0;
    }

    internal int[] method_12()
    {
        return this.int_0;
    }

    internal string method_13()
    {
        return this.string_1;
    }

    internal void method_14(string A_0)
    {
        this.string_1 = A_0;
    }

    internal bool method_4()
    {
        if (!this.method_6())
        {
            return this.method_5();
        }
        return true;
    }

    internal bool method_5()
    {
        if (this.bool_1)
        {
            foreach (ListPatternType type in this.listPatternType_0)
            {
                if (type != ListPatternType.Bullet)
                {
                    return true;
                }
            }
        }
        return false;
    }

    internal bool method_6()
    {
        return this.bool_0;
    }

    internal void method_7(bool A_0)
    {
        this.bool_0 = A_0;
    }

    internal bool method_8()
    {
        return this.bool_1;
    }

    internal void method_9(bool A_0)
    {
        this.bool_1 = A_0;
    }
}

