using Spire.Doc;
using System;
using System.IO;
using System.Runtime.InteropServices;

internal class Stream5 : Stream1
{
    private static bool bool_0;
    private Interface39 interface39_0;
    private long long_0;

    public Stream5(Interface39 A_0, string A_1) : base(A_1)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱䀳䐵崷嬹儻", num));
        }
        this.interface39_0 = A_0;
    }

    private void method_2(byte[] A_0, int A_1, int A_2)
    {
        int num = 2;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨧弩䨫䠭唯䀱", num));
        }
        if ((A_1 + A_2) > A_0.Length)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("椧堩師伭䤯ሱ䜳張䈷弹ျḽ⼿⑁≃㕅ⵇ㹉汋⽍㹏㙑瑓㩕㵗㑙㭛⩝࡟䉡c॥൧ᥩɫ䥭ѯ剱ᥳ᝵౷᥹ᑻ幽ꢇ", num));
        }
        if (A_1 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜧䰩䨫崭唯䘱", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䐧伩䈫䤭䐯娱", num));
        }
    }

    void Stream.Dispose(bool A_0)
    {
        base.Dispose(A_0);
        if (this.interface39_0 != null)
        {
            this.interface39_0.imethod_5(0);
            Marshal.FinalReleaseComObject(this.interface39_0);
            this.interface39_0 = null;
        }
        this.long_0 = -1L;
    }

    void Stream.Flush()
    {
        this.interface39_0.imethod_5(0);
    }

    int Stream.Read(byte[] A_0, int A_1, int A_2)
    {
        this.method_2(A_0, A_1, A_2);
        byte[] buffer = (A_1 != 0) ? new byte[A_2] : A_0;
        uint num = 0;
        this.interface39_0.imethod_0(buffer, (uint) A_2, ref num);
        int count = (int) num;
        this.long_0 += num;
        if (A_1 != 0)
        {
            Buffer.BlockCopy(buffer, 0, A_0, A_1, count);
        }
        return count;
    }

    long Stream.Seek(long A_0, SeekOrigin A_1)
    {
        long num;
        this.interface39_0.imethod_2(A_0, A_1, out num);
        this.long_0 = num;
        return num;
    }

    void Stream.SetLength(long A_0)
    {
        this.interface39_0.imethod_3((ulong) A_0);
    }

    void Stream.Write(byte[] A_0, int A_1, int A_2)
    {
        byte[] buffer;
        this.method_2(A_0, A_1, A_2);
        if (A_1 == 0)
        {
            buffer = A_0;
        }
        else
        {
            buffer = new byte[A_2];
            Buffer.BlockCopy(A_0, A_1, buffer, 0, A_2);
        }
        uint num = 0;
        this.interface39_0.imethod_1(buffer, (uint) A_2, ref num);
        this.long_0 += num;
    }

    bool Stream.CanRead
    {
        get
        {
            return true;
        }
    }

    bool Stream.CanSeek
    {
        get
        {
            return true;
        }
    }

    bool Stream.CanWrite
    {
        get
        {
            return true;
        }
    }

    long Stream.Length
    {
        get
        {
            long num;
            if (!bool_0)
            {
                bool_0 = true;
            }
            this.interface39_0.imethod_2(0L, SeekOrigin.End, out num);
            this.interface39_0.imethod_2(this.long_0, SeekOrigin.Begin, out this.long_0);
            return num;
        }
    }

    long Stream.Position
    {
        get
        {
            return this.long_0;
        }
        set
        {
            this.long_0 = this.Seek(value, SeekOrigin.Begin);
        }
    }
}

