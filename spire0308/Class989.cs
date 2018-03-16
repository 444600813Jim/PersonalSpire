using Spire.Doc;
using System;
using System.Security.Cryptography;
using System.Text;

internal class Class989 : IDisposable
{
    private bool bool_0;
    private Class992 class992_0;
    private Class993 class993_0;
    internal const int int_0 = 0x10;
    internal const int int_1 = 0x40;
    internal const int int_2 = 0x200;
    internal const int int_3 = 0;
    internal const int int_4 = 0x100;
    private IntPtr intptr_0 = IntPtr.Zero;
    internal const uint uint_0 = 0xce4b;

    public Class989(Class993 A_0, Class992 A_1)
    {
        this.class993_0 = A_0;
        this.class992_0 = A_1;
        this.bool_0 = Class990.CryptAcquireContext(out this.intptr_0, null, BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅േ⑉⑋⽍㹏ㅑㅓ㉕硗ᥙ⹛❝ၟᙡୣťᩧ୩ᱫ٭᥯ᅱ味♵੷ᕹ੻᝽ꚅﺇ뮉ꊋ뺍", 14), 1, 0);
    }

    public Class993 method_0()
    {
        return this.class993_0;
    }

    public Class992 method_1()
    {
        return this.class992_0;
    }

    internal bool method_2(string A_0)
    {
        Class992 class2 = this.method_1();
        IntPtr ptr = this.method_4(A_0, class2.method_0(), 0, this.method_0().method_12());
        byte[] buffer = this.method_3(ptr, class2.method_2());
        byte[] buffer2 = this.method_3(ptr, class2.method_4());
        Class990.CryptDestroyKey(ptr);
        byte[] buffer3 = new SHA1Managed().ComputeHash(buffer);
        int index = 0;
        int length = buffer2.Length;
        while (index < length)
        {
            if (buffer2[index] != buffer3[index])
            {
                return false;
            }
            index++;
        }
        return true;
    }

    internal byte[] method_3(IntPtr A_0, byte[] A_1)
    {
        byte[] dst = new byte[A_1.Length];
        Buffer.BlockCopy(A_1, 0, dst, 0, A_1.Length);
        int length = dst.Length;
        this.bool_0 = Class990.CryptDecrypt(A_0, IntPtr.Zero, 0, 0, dst, ref length);
        return dst;
    }

    internal IntPtr method_4(string A_0, byte[] A_1, uint A_2, int A_3)
    {
        if (A_0.Length > 0xff)
        {
            A_0 = A_0.Substring(0, 0xff);
        }
        IntPtr zero = IntPtr.Zero;
        byte[] bytes = Encoding.Unicode.GetBytes(A_0);
        byte[] src = A_1;
        int num2 = src.Length + bytes.Length;
        byte[] dst = new byte[num2];
        Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
        IntPtr ptr = IntPtr.Zero;
        byte[] buffer = new byte[0];
        if (Class990.CryptCreateHash(this.intptr_0, 0x8004, IntPtr.Zero, 0, ref ptr))
        {
            int num3;
            this.bool_0 = Class990.CryptHashData(ptr, dst, num2, 0);
            this.bool_0 = Class990.CryptGetHashParam(ptr, 4, out num3, out num2, 0);
            buffer = new byte[num3];
            this.bool_0 = Class990.CryptGetHashParam(ptr, 2, buffer, ref num3, 0);
            this.bool_0 = Class990.CryptDestroyHash(ptr);
        }
        int num = buffer.Length + 4;
        byte[] buffer2 = new byte[num];
        byte[] buffer3 = BitConverter.GetBytes(A_2);
        Buffer.BlockCopy(buffer, 0, buffer2, 0, buffer.Length);
        Buffer.BlockCopy(buffer3, 0, buffer2, buffer.Length, buffer3.Length);
        ptr = IntPtr.Zero;
        if (Class990.CryptCreateHash(this.intptr_0, 0x8004, IntPtr.Zero, 0, ref ptr))
        {
            this.bool_0 = Class990.CryptHashData(ptr, buffer2, num, 0);
            this.bool_0 = Class990.CryptDeriveKey(this.intptr_0, 0x6801, ptr, A_3 << 0x10, ref zero);
            this.bool_0 = Class990.CryptDestroyHash(ptr);
        }
        return zero;
    }

    void IDisposable.Dispose()
    {
        Class990.CryptReleaseContext(this.intptr_0, 0);
    }
}

