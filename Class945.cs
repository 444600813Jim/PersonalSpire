using Spire.Doc;
using System;
using System.Security.Cryptography;
using System.Text;

internal class Class945 : IDisposable
{
    private bool bool_0;
    private Class540 class540_0;
    private IntPtr intptr_0 = IntPtr.Zero;

    public Class945(Class540 A_0)
    {
        this.class540_0 = A_0;
        this.bool_0 = Class946.CryptAcquireContext(out this.intptr_0, null, BookmarkStart.b("欥䄧䤩師䄭䌯崱刳䈵ᠷ缹刻嘽ℿⱁ❃⍅ⱇ橉ཋ㱍⥏≑⁓㥕㽗⡙㵛⹝࡟ୡݣ䙥㡧ᡩͫᡭ᥯ᙱᅳѵ塷౹䵻偽끿", 0), 1, 0);
    }

    internal bool method_0(string A_0)
    {
        Class709 class2 = this.class540_0.method_7();
        IntPtr ptr = this.method_2(A_0, class2.method_0(), 0, this.class540_0.method_6().method_12());
        byte[] buffer = this.method_1(ptr, class2.method_2());
        byte[] buffer2 = this.method_1(ptr, class2.method_4());
        Class946.CryptDestroyKey(ptr);
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

    internal byte[] method_1(IntPtr A_0, byte[] A_1)
    {
        byte[] dst = new byte[A_1.Length];
        Buffer.BlockCopy(A_1, 0, dst, 0, A_1.Length);
        int length = dst.Length;
        this.bool_0 = Class946.CryptDecrypt(A_0, IntPtr.Zero, 0, 0, dst, ref length);
        return dst;
    }

    internal IntPtr method_2(string A_0, byte[] A_1, uint A_2, int A_3)
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
        if (Class946.CryptCreateHash(this.intptr_0, 0x8004, IntPtr.Zero, 0, ref ptr))
        {
            int num3;
            this.bool_0 = Class946.CryptHashData(ptr, dst, num2, 0);
            this.bool_0 = Class946.CryptGetHashParam(ptr, 4, out num3, out num2, 0);
            buffer = new byte[num3];
            this.bool_0 = Class946.CryptGetHashParam(ptr, 2, buffer, ref num3, 0);
            this.bool_0 = Class946.CryptDestroyHash(ptr);
        }
        int num = buffer.Length + 4;
        byte[] buffer2 = new byte[num];
        byte[] buffer3 = BitConverter.GetBytes(A_2);
        Buffer.BlockCopy(buffer, 0, buffer2, 0, buffer.Length);
        Buffer.BlockCopy(buffer3, 0, buffer2, buffer.Length, buffer3.Length);
        ptr = IntPtr.Zero;
        if (Class946.CryptCreateHash(this.intptr_0, 0x8004, IntPtr.Zero, 0, ref ptr))
        {
            this.bool_0 = Class946.CryptHashData(ptr, buffer2, num, 0);
            this.bool_0 = Class946.CryptDeriveKey(this.intptr_0, 0x6801, ptr, A_3 << 0x10, ref zero);
            this.bool_0 = Class946.CryptDestroyHash(ptr);
        }
        return zero;
    }

    void IDisposable.Dispose()
    {
        Class946.CryptReleaseContext(this.intptr_0, 0);
    }
}

