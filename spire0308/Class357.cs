using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class357
{
    public const int int_0 = 0x6d;
    private List<int> list_0;
    private List<int> list_1;

    public Class357()
    {
        this.list_1 = new List<int>();
        this.list_0 = new List<int>();
    }

    public Class357(Stream A_0, Class938 A_1)
    {
        this.list_1 = new List<int>();
        int num = A_1.method_26();
        int count = A_1.method_5();
        ushort num3 = A_1.method_9();
        int capacity = 0x6d + ((num * (count - 4)) / 4);
        this.list_0 = new List<int>(capacity);
        this.list_0.AddRange(A_1.method_28());
        if (num > 0)
        {
            int num5 = A_1.method_24();
            A_1.method_9();
            byte[] buffer = new byte[count];
            int[] dst = new int[(count / 4) - 1];
            while (num5 >= 0)
            {
                long num6 = Class1004.smethod_4(num5, num3);
                this.list_1.Add(num5);
                A_0.Position = num6;
                A_0.Read(buffer, 0, count);
                Buffer.BlockCopy(buffer, 0, dst, 0, count - 4);
                this.list_0.AddRange(dst);
                num5 = BitConverter.ToInt32(buffer, count - 4);
            }
        }
    }

    public List<int> method_0()
    {
        return this.list_0;
    }

    internal void method_1(Stream A_0, Class938 A_1)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䈰䜲䜴制堸嘺", num));
        }
        int count = this.list_0.Count;
        int[] numArray = A_1.method_28();
        int index = 0;
        while (true)
        {
            if ((index >= count) || (index >= 0x6d))
            {
                break;
            }
            numArray[index] = this.list_0[index];
            index++;
        }
        while (index < 0x6d)
        {
            numArray[index] = -1;
            index++;
        }
        if (this.list_1.Count > 0)
        {
            A_1.method_25(this.list_1[0]);
            A_1.method_27(this.list_1.Count);
        }
        byte[] dst = new byte[A_1.method_5()];
        int num9 = A_1.method_5();
        int num10 = (num9 / 4) - 1;
        int num4 = 0;
        int num11 = this.list_1.Count;
        while (num4 < num11)
        {
            int num5 = this.list_1[num4];
            long num6 = A_1.method_30(num5);
            int num7 = 0;
            for (int i = 0; num7 < num10; i += 4)
            {
                int num13 = (index < count) ? this.list_0[index] : -1;
                Buffer.BlockCopy(BitConverter.GetBytes(num13), 0, dst, i, 4);
                num7++;
                index++;
            }
            int num12 = (num4 == (num11 - 1)) ? -2 : this.list_1[num4 + 1];
            Buffer.BlockCopy(BitConverter.GetBytes(num12), 0, dst, num9 - 4, 4);
            A_0.Position = num6;
            A_0.Write(dst, 0, num9);
            num4++;
        }
    }

    internal void method_2(int A_0, Class939 A_1)
    {
        int num = A_0 - 0x6d;
        if (num > 0)
        {
            int num2 = (int) Math.Ceiling((double) (((double) (num * 4)) / ((double) (A_1.method_0() - 4))));
            this.method_3(num2, A_1);
        }
    }

    private void method_3(int A_0, Class939 A_1)
    {
        int count = this.list_1.Count;
        if (count != A_0)
        {
            if (count > A_0)
            {
                this.method_4(count - A_0, A_1);
            }
            else
            {
                this.method_5(A_0 - count, A_1);
            }
        }
    }

    private void method_4(int A_0, Class939 A_1)
    {
        int num = 5;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("堪䠬䰮䔰尲䜴琶嘸为匼䬾", num));
        }
        if (A_0 != 0)
        {
            if (A_1 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䴪䰬嬮", num));
            }
            int num2 = 0;
            for (int i = this.list_1.Count - 1; num2 < A_0; i--)
            {
                int num4 = this.list_1[i];
                A_1.method_5(num4);
                num2++;
            }
            this.list_1.RemoveRange(this.list_1.Count - A_0, A_0);
            throw new NotImplementedException();
        }
    }

    private void method_5(int A_0, Class939 A_1)
    {
        int num = 7;
        if (A_0 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("帬䨮到䜲娴䔶稸吺䠼儾㕀", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䬬丮䔰", num));
        }
        for (int i = 0; i < A_0; i++)
        {
            int item = A_1.method_13(-4);
            this.list_1.Add(item);
        }
    }
}

