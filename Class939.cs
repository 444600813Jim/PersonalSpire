using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class939
{
    private int int_0;
    private List<int> list_0;
    private List<int> list_1;
    private Stream stream_0;
    private ushort ushort_0;

    public Class939(Stream A_0, ushort A_1, int A_2)
    {
        this.list_0 = new List<int>();
        this.list_1 = new List<int>();
        this.stream_0 = A_0;
        this.ushort_0 = A_1;
        this.int_0 = A_2;
    }

    public Class939(Class1004 A_0, Stream A_1, Class357 A_2, Class938 A_3)
    {
        int num5 = 3;
        this.list_0 = new List<int>();
        this.list_1 = new List<int>();
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伨䈪䄬䨮", num5));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娨弪弬䨮倰帲", num5));
        }
        this.stream_0 = A_0.method_4();
        List<int> list = A_2.method_0();
        int count = A_3.method_5();
        this.ushort_0 = A_3.method_9();
        byte[] buffer = new byte[count];
        int[] dst = new int[count >> 2];
        this.int_0 = 0x200;
        int num2 = 0;
        int num3 = list.Count;
        while (num2 < num3)
        {
            int num4 = list[num2];
            if (num4 >= 0)
            {
                A_0.method_9(buffer, 0, num4, A_3);
                Buffer.BlockCopy(buffer, 0, dst, 0, count);
                this.list_0.AddRange(dst);
            }
            num2++;
        }
    }

    public Class939(Stream A_0, ushort A_1, Stream A_2, int A_3)
    {
        this.list_0 = new List<int>();
        this.list_1 = new List<int>();
        this.ushort_0 = A_1;
        this.int_0 = A_3;
        this.stream_0 = A_0;
        A_2.Position = 0L;
        byte[] buffer = new byte[4];
        while (A_2.Read(buffer, 0, 4) > 0)
        {
            this.list_0.Add(BitConverter.ToInt32(buffer, 0));
        }
    }

    public int method_0()
    {
        return (((int) 1) << this.ushort_0);
    }

    public byte[] method_1(Stream A_0, int A_1, Class1004 A_2)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔵䰷䠹夻弽ⴿ", num));
        }
        if (A_2 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倵儷嘹夻", num));
        }
        if (A_1 < 0)
        {
            return null;
        }
        List<int> list = new List<int>();
        A_2.method_0();
        for (int i = A_1; i != -2; i = this.list_0[i])
        {
            if ((i < 0) || (i >= this.list_0.Count))
            {
                throw new ApplicationException();
            }
            list.Add(i);
        }
        int count = list.Count;
        byte[] buffer = new byte[count << this.ushort_0];
        int num4 = ((int) 1) << this.ushort_0;
        int num5 = 0;
        for (int j = 0; num5 < count; j += num4)
        {
            long num7 = this.method_16(list[num5]);
            A_0.Position = num7;
            A_0.Read(buffer, j, num4);
            num5++;
        }
        return buffer;
    }

    public void method_10(Stream A_0, Class357 A_1, Class938 A_2)
    {
        int count = this.list_0.Count;
        int num2 = A_2.method_5();
        ushort num3 = A_2.method_9();
        int num4 = this.method_0() / 4;
        int num5 = num4 - 1;
        double num6 = (num5 * count) - 109.0;
        double num7 = (num5 * num5) - 1.0;
        int num8 = (int) Math.Ceiling((double) (num6 / num7));
        A_2.method_15(num8);
        byte[] buffer = new byte[num2];
        A_1.method_2(num8, this);
        this.method_11(num8, A_1);
        List<int> list = A_1.method_0();
        int num9 = 0;
        int num10 = 0;
        while (num9 < num8)
        {
            num10 = this.method_12(num10, buffer);
            int num11 = list[num9];
            long offset = Class1004.smethod_4(num11, num3);
            A_0.Seek(offset, SeekOrigin.Begin);
            A_0.Write(buffer, 0, num2);
            num9++;
        }
    }

    private void method_11(int A_0, Class357 A_1)
    {
        int num = 0x10;
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("刵儷尹", num));
        }
        List<int> list = A_1.method_0();
        int count = list.Count;
        if (count < A_0)
        {
            for (int i = count; i < A_0; i++)
            {
                int item = this.method_13(-3);
                list.Add(item);
            }
        }
    }

    private int method_12(int A_0, byte[] A_1)
    {
        int count = this.list_0.Count;
        int length = A_1.Length;
        int dstOffset = 0;
        while (dstOffset < length)
        {
            if (A_0 >= count)
            {
                break;
            }
            Buffer.BlockCopy(BitConverter.GetBytes(this.list_0[A_0]), 0, A_1, dstOffset, 4);
            dstOffset += 4;
            A_0++;
        }
        if (dstOffset < length)
        {
            byte[] bytes = BitConverter.GetBytes(-1);
            while (dstOffset < length)
            {
                Buffer.BlockCopy(bytes, 0, A_1, dstOffset, 4);
                dstOffset += 4;
            }
        }
        return A_0;
    }

    internal int method_13(int A_0)
    {
        int num3;
        int count = this.list_1.Count;
        if (count > 0)
        {
            int index = count - 1;
            num3 = this.list_1[index];
            this.list_1.RemoveAt(index);
            this.list_0[num3] = A_0;
            return num3;
        }
        num3 = this.method_14();
        this.list_0.Add(A_0);
        return num3;
    }

    internal int method_14()
    {
        long length = this.stream_0.Length;
        int num2 = this.method_0();
        this.stream_0.SetLength(length + num2);
        return (int) ((length - this.int_0) >> this.ushort_0);
    }

    internal void method_15(MemoryStream A_0, int A_1)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崭䐯䀱儳圵唷", num));
        }
        if (A_1 <= 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("崭唯儱䀳夵䨷椹唻䐽┿", num));
        }
        int num5 = (int) Math.Ceiling((double) (((double) (this.list_0.Count * 4)) / ((double) A_1)));
        byte[] buffer = new byte[A_1];
        int num3 = A_1 / 4;
        for (int i = 0; i < num5; i++)
        {
            int num4 = i * num3;
            this.method_12(num4, buffer);
            A_0.Write(buffer, 0, A_1);
        }
    }

    internal long method_16(int A_0)
    {
        return Class1004.smethod_5(A_0, this.ushort_0, this.int_0);
    }

    internal int method_17(int A_0)
    {
        int num = 1;
        while ((A_0 = this.method_2(A_0)) >= 0)
        {
            num++;
        }
        return num;
    }

    internal int method_2(int A_0)
    {
        return this.list_0[A_0];
    }

    internal void method_3(int A_0)
    {
        int num = this.list_0[A_0];
        this.list_0[A_0] = -2;
        while (num != -2)
        {
            A_0 = num;
            num = this.list_0[A_0];
            this.list_0[A_0] = -1;
            this.list_1.Add(A_0);
        }
    }

    internal int method_4(int A_0, int A_1)
    {
        if (A_1 <= 0)
        {
            return A_0;
        }
        int count = this.list_1.Count;
        int num2 = Math.Min(A_1, count);
        int num3 = A_1 - num2;
        int num4 = this.method_9(ref A_0, num2);
        num4 = this.method_7(ref A_0, num3);
        this.list_0[A_0] = -2;
        return num4;
    }

    internal void method_5(int A_0)
    {
        int num = 2;
        int count = this.list_0.Count;
        if ((A_0 < 0) || (A_0 >= count))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("嬧伩伫娭弯䀱", num));
        }
        if (A_0 != (count - 1))
        {
            this.list_0[A_0] = -1;
            this.list_1.Add(A_0);
        }
        else
        {
            this.list_0.RemoveAt(A_0);
            this.method_6();
        }
    }

    private void method_6()
    {
        long num = Math.Max((long) 0L, (long) (this.stream_0.Length - this.method_0()));
        this.stream_0.SetLength(num);
    }

    private int method_7(ref int A_0, int A_1)
    {
        int num = A_0;
        int num2 = A_0;
        A_0 = this.method_8(A_1);
        if (num < 0)
        {
            num = A_0;
        }
        int num3 = 0;
        while (num3 < A_1)
        {
            this.list_0.Add(A_0 + 1);
            if (num2 >= 0)
            {
                this.list_0[num2] = A_0;
            }
            num2 = A_0;
            num3++;
            A_0++;
        }
        A_0--;
        this.list_0[A_0] = -2;
        return num;
    }

    private int method_8(int A_0)
    {
        long length = this.stream_0.Length;
        this.stream_0.SetLength(length + (A_0 << this.ushort_0));
        return (int) ((length - this.int_0) >> this.ushort_0);
    }

    private int method_9(ref int A_0, int A_1)
    {
        int num = A_0;
        for (int i = 0; i < A_1; i++)
        {
            int num3 = this.list_1[i];
            if (A_0 >= 0)
            {
                this.list_0[A_0] = num3;
            }
            else
            {
                num = num3;
            }
            A_0 = num3;
        }
        this.list_1.RemoveRange(0, A_1);
        return num;
    }
}

