using Spire.Doc;
using System;
using System.Collections.Generic;

[CLSCompliant(false)]
internal class Class1011 : IDisposable
{
    private byte[] byte_0;
    private byte[] byte_1;
    private List<int> list_0;
    private List<int> list_1;
    private ProofState proofState_0;
    private ProofState proofState_1;

    internal Class1011()
    {
    }

    internal byte[] method_0()
    {
        return this.byte_0;
    }

    internal void method_1(byte[] A_0)
    {
        this.byte_0 = A_0;
    }

    private int method_10(bool A_0, int A_1)
    {
        List<int> list = A_0 ? this.list_0 : this.list_1;
        int num = 0;
        int count = list.Count;
        while (num < count)
        {
            if (list[num] >= A_1)
            {
                return num;
            }
            num++;
        }
        return 0x7fffffff;
    }

    private void method_11(int A_0, int A_1, bool A_2)
    {
        List<int> list = A_2 ? this.list_0 : this.list_1;
        int num = A_0;
        int count = list.Count;
        while (num < count)
        {
            list[num] -= A_1;
            num++;
        }
    }

    internal byte[] method_2()
    {
        return this.byte_1;
    }

    internal void method_3(byte[] A_0)
    {
        this.byte_1 = A_0;
    }

    internal ProofState method_4()
    {
        return this.proofState_0;
    }

    internal void method_5(ProofState A_0)
    {
        this.proofState_0 = A_0;
    }

    internal ProofState method_6()
    {
        return this.proofState_1;
    }

    internal void method_7(ProofState A_0)
    {
        this.proofState_1 = A_0;
    }

    private bool method_8(bool A_0, int A_1, int A_2, int A_3)
    {
        int num = this.method_10(A_0, A_1);
        int num2 = this.method_10(A_0, A_2);
        if ((num != 0x7fffffff) && (num2 != 0x7fffffff))
        {
            num2++;
            this.method_9(A_1, num, num2, A_0);
            this.method_11(num2, A_3, A_0);
            return true;
        }
        return false;
    }

    private void method_9(int A_0, int A_1, int A_2, bool A_3)
    {
        List<int> list = A_3 ? this.list_0 : this.list_1;
        for (int i = A_1; i < A_2; i++)
        {
            list[i] = A_0;
        }
    }

    void IDisposable.Dispose()
    {
        if (this.byte_0 != null)
        {
            Array.Clear(this.byte_0, 0, this.byte_0.Length);
            this.byte_0 = null;
        }
        if (this.byte_1 != null)
        {
            Array.Clear(this.byte_1, 0, this.byte_1.Length);
            this.byte_1 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
    }
}

