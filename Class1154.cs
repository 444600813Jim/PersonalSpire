using System;

internal class Class1154
{
    private readonly byte[] byte_0 = new byte[0x100];
    private int int_0;
    private int int_1;

    public void method_0(byte[] A_0, int A_1)
    {
        this.method_3(A_0, 0, A_1);
    }

    public void method_1(byte[] A_0)
    {
        this.method_4(A_0, 0, A_0.Length, A_0, 0);
    }

    public void method_2(byte[] A_0, byte[] A_1)
    {
        this.method_4(A_0, 0, A_0.Length, A_1, 0);
    }

    public void method_3(byte[] A_0, int A_1, int A_2)
    {
        this.method_4(A_0, A_1, A_2, A_0, A_1);
    }

    public void method_4(byte[] A_0, int A_1, int A_2, byte[] A_3, int A_4)
    {
        int num = A_2 + A_1;
        for (int i = A_1; i < num; i++)
        {
            this.int_0 = (this.int_0 + 1) & 0xff;
            this.int_1 = (this.byte_0[this.int_0] + this.int_1) & 0xff;
            byte num3 = this.byte_0[this.int_0];
            this.byte_0[this.int_0] = this.byte_0[this.int_1];
            this.byte_0[this.int_1] = num3;
            A_3[(i - A_1) + A_4] = (byte) (A_0[i] ^ this.byte_0[(this.byte_0[this.int_0] + this.byte_0[this.int_1]) & 0xff]);
        }
    }

    public void method_5(byte[] A_0)
    {
        this.method_6(A_0, 0, A_0.Length);
    }

    public void method_6(byte[] A_0, int A_1, int A_2)
    {
        int num = 0;
        int index = 0;
        for (int i = 0; i < 0x100; i++)
        {
            this.byte_0[i] = (byte) i;
        }
        this.int_0 = 0;
        this.int_1 = 0;
        for (int j = 0; j < 0x100; j++)
        {
            index = ((A_0[num + A_1] + this.byte_0[j]) + index) & 0xff;
            byte num5 = this.byte_0[j];
            this.byte_0[j] = this.byte_0[index];
            this.byte_0[index] = num5;
            num = (num + 1) % A_2;
        }
    }
}

