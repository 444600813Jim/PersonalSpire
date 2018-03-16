using Spire.Doc;
using System;
using System.IO;

internal class Class356
{
    private const int int_0 = 0x2000;
    private long long_0;
    private static readonly uint[] uint_0;
    private uint uint_1 = uint.MaxValue;

    static Class356()
    {
        uint num = 0xedb88320;
        uint_0 = new uint[0x100];
        for (uint i = 0; i < 0x100; i++)
        {
            uint num4 = i;
            for (uint j = 8; j > 0; j--)
            {
                if ((num4 & 1) == 1)
                {
                    num4 = (num4 >> 1) ^ num;
                }
                else
                {
                    num4 = num4 >> 1;
                }
            }
            uint_0[i] = num4;
        }
    }

    public long method_0()
    {
        return this.long_0;
    }

    public int method_1()
    {
        return (int) ~this.uint_1;
    }

    public int method_2(Stream A_0)
    {
        return this.method_3(A_0, null);
    }

    public int method_3(Stream A_0, Stream A_1)
    {
        int num = 14;
        if (A_0 == null)
        {
            throw new Exception0(BookmarkStart.b("怳帵崷ᨹ唻倽〿㝁ぃ晅㭇㹉㹋⭍ㅏ㽑瑓㭕ⵗ⥙⡛繝๟ൡၣ䙥੧ཀྵ䱫mկṱᡳ塵", num));
        }
        byte[] buffer = new byte[0x2000];
        int count = 0x2000;
        this.long_0 = 0L;
        int num2 = A_0.Read(buffer, 0, 0x2000);
        if (A_1 != null)
        {
            A_1.Write(buffer, 0, num2);
        }
        this.long_0 += num2;
        while (num2 > 0)
        {
            this.method_6(buffer, 0, num2);
            num2 = A_0.Read(buffer, 0, count);
            if (A_1 != null)
            {
                A_1.Write(buffer, 0, num2);
            }
            this.long_0 += num2;
        }
        return (int) ~this.uint_1;
    }

    public int method_4(int A_0, byte A_1)
    {
        return this.method_5((uint) A_0, A_1);
    }

    internal int method_5(uint A_0, byte A_1)
    {
        return (int) (uint_0[(int) ((IntPtr) ((A_0 ^ A_1) & 0xff))] ^ (A_0 >> 8));
    }

    public void method_6(byte[] A_0, int A_1, int A_2)
    {
        int num = 4;
        if (A_0 == null)
        {
            throw new Exception0(BookmarkStart.b("縩䐫䬭ု嘱唳䈵夷ᨹ帻䬽☿⑁⅃㑅桇❉㥋㵍⑏牑㩓㥕ⱗ穙㹛㭝䁟ౡᅣ੥ѧ䑩", num));
        }
        for (int i = 0; i < A_2; i++)
        {
            int index = A_1 + i;
            this.uint_1 = (this.uint_1 >> 8) ^ uint_0[(int) ((IntPtr) (A_0[index] ^ (this.uint_1 & 0xff)))];
        }
        this.long_0 += A_2;
    }
}

