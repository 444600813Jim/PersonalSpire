using System;
using System.IO;

internal class Class124 : Class122
{
    internal Class124() : base(1)
    {
    }

    protected override object vmethod_0(int A_0)
    {
        return new Class1105(A_0);
    }

    private class Class1105 : Interface35
    {
        private readonly int int_0;

        internal Class1105(int A_0)
        {
            this.int_0 = A_0;
        }

        private void imethod_0(BinaryWriter A_0)
        {
            A_0.Write((byte) this.int_0);
        }
    }
}

