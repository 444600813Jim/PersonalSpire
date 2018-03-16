using System;
using System.Reflection;

[DefaultMember("Item")]
internal class Class830
{
    private int int_0;
    private int int_1;
    private int int_2;
    private object[] object_0;

    public Class830(int A_0)
    {
        this.int_2 = A_0;
    }

    public int method_0()
    {
        return this.int_1;
    }

    public void method_1(int A_0)
    {
        this.int_1 = A_0;
    }

    public int method_2()
    {
        return this.int_0;
    }

    public object method_3(int A_0)
    {
        if ((A_0 >= 0) && (A_0 < this.int_0))
        {
            return this.object_0[A_0];
        }
        return null;
    }

    public void method_4(int A_0, object A_1)
    {
        this.object_0[A_0] = A_1;
    }

    public object method_5()
    {
        this.int_1--;
        if (this.int_1 > 0)
        {
            return this.object_0[this.int_1 - 1];
        }
        return null;
    }

    public object method_6()
    {
        if (this.int_1 == this.int_0)
        {
            int num = this.int_0 + this.int_2;
            object[] destinationArray = new object[num];
            if (this.object_0 != null)
            {
                Array.Copy(this.object_0, destinationArray, this.int_0);
            }
            this.int_0 = num;
            this.object_0 = destinationArray;
        }
        return this.object_0[this.int_1++];
    }

    public void method_7(int A_0)
    {
        this.object_0[A_0] = null;
        Array.Copy(this.object_0, A_0 + 1, this.object_0, A_0, (this.int_1 - A_0) - 1);
        this.int_1--;
    }
}

