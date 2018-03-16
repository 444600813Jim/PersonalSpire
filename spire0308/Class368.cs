using Spire.Doc;
using System;
using System.Text;

internal class Class368 : Class364
{
    private byte[] byte_0;
    private byte[] byte_1;
    private const int int_0 = 0;
    private const int int_1 = -858997829;
    private const int int_2 = 4;
    private string string_0;

    internal Class368(Stream1 A_0)
    {
        byte[] buffer = new byte[A_0.Length];
        A_0.Read(buffer, 0, buffer.Length);
        this.vmethod_0(buffer, 0);
    }

    internal Class368(string A_0)
    {
        this.string_0 = A_0;
        ASCIIEncoding encoding = new ASCIIEncoding();
        UnicodeEncoding encoding2 = new UnicodeEncoding();
        this.byte_0 = encoding.GetBytes(this.string_0);
        this.byte_1 = encoding2.GetBytes(this.string_0);
    }

    internal void method_0(Stream12 A_0)
    {
        byte[] buffer = new byte[this.vmethod_2()];
        int num = 0;
        buffer[0] = (byte) this.byte_0.Length;
        num = 2;
        Class364.smethod_11(buffer, ref num, this.byte_0);
        num += 2;
        Class364.smethod_11(buffer, ref num, BitConverter.GetBytes(-858997829));
        buffer[num] = (byte) this.byte_0.Length;
        num += 2;
        Class364.smethod_11(buffer, ref num, this.byte_1);
        A_0.Write(buffer, 0, buffer.Length);
    }

    internal override void vmethod_0(byte[] A_0, int A_1)
    {
        int num = 0;
        int num2 = 0;
        int length = A_0.Length;
        while (num2 < length)
        {
            if (num > 0)
            {
                num -= 3;
            }
            if (Class364.smethod_1(A_0, ref num) == -858997829)
            {
                break;
            }
            num2++;
        }
        byte[] buffer = new byte[num - 4];
        int num5 = 0;
        this.byte_0 = Class364.smethod_5(A_0, num - 4, ref num5);
        num5 += 4;
        int num6 = (A_0.Length - buffer.Length) - 4;
        this.byte_1 = Class364.smethod_5(A_0, num6, ref num5);
    }

    internal override int vmethod_1(byte[] A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("眸吺䤼Ἶ⡀⹂㕄⭆ⱈ♊⡌ⅎ═㙒ㅔ", 0x13));
    }

    internal override int vmethod_2()
    {
        if ((this.byte_0 != null) && (this.byte_1 != null))
        {
            return (((this.byte_0.Length + this.byte_1.Length) + 4) + 8);
        }
        return 0;
    }
}

