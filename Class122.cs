using System;
using System.Collections;
using System.IO;
using System.Text;

internal abstract class Class122
{
    private BinaryWriter binaryWriter_0;
    private Class147 class147_0;
    private Hashtable hashtable_0 = new Hashtable();
    private const int int_0 = 0x200;
    private int int_1;
    private MemoryStream memoryStream_0;

    internal Class122(int A_0)
    {
        this.class147_0 = new Class147(A_0);
        this.memoryStream_0 = new MemoryStream(0x200);
        this.binaryWriter_0 = new BinaryWriter(this.memoryStream_0, Encoding.Unicode);
        this.int_1 = 510;
    }

    internal bool method_0(int A_0, int A_1, Interface54 A_2)
    {
        int num = 0;
        int key = A_2.imethod_0();
        if (this.hashtable_0.Contains(key))
        {
            if (!this.method_3(0))
            {
                return false;
            }
            num = (int) this.hashtable_0[key];
        }
        else
        {
            int num3 = A_2.imethod_1(true);
            if (Class567.smethod_3((long) num3))
            {
                num3++;
            }
            if (!this.method_3(num3))
            {
                return false;
            }
            if (num3 > 0)
            {
                this.int_1 -= num3;
                this.memoryStream_0.Seek((long) this.int_1, SeekOrigin.Begin);
                A_2.imethod_2(this.binaryWriter_0, true);
                num = this.int_1 / 2;
                this.hashtable_0[key] = num;
            }
        }
        this.class147_0.method_5(A_0, A_1, this.vmethod_0(num));
        return true;
    }

    internal Class983 method_1()
    {
        this.memoryStream_0.Seek(0L, SeekOrigin.Begin);
        this.class147_0.vmethod_1(this.binaryWriter_0);
        this.memoryStream_0.Seek(0x1ffL, SeekOrigin.Begin);
        this.binaryWriter_0.Write((byte) this.class147_0.method_4());
        return new Class983(this.class147_0.method_0(), this.class147_0.method_1(), this.memoryStream_0.ToArray());
    }

    internal int method_2()
    {
        return (this.int_1 - this.class147_0.method_20());
    }

    private bool method_3(int A_0)
    {
        return (this.method_2() >= (this.class147_0.method_22() + A_0));
    }

    protected abstract object vmethod_0(int A_0);
}

