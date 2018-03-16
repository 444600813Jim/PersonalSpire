using System;
using System.IO;

internal class Class176 : Class172
{
    private byte[] byte_0;
    private static Guid guid_0 = new Guid(BookmarkStart.b("䴵ķह଻崽焿⍁睃牅敇等祋罍㑏网恓恕楗橙煛杝͟͡剣䭥१剩ཫ൭䥯ၱၳᑵ䵷ṹ䑻䵽ﵿ", 0x10));

    internal Class176(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class176(int A_0, byte[] A_1) : base(A_0, A_1.Length + 20)
    {
        this.byte_0 = A_1;
    }

    internal byte[] method_3()
    {
        return this.byte_0;
    }

    internal override void vmethod_2(BinaryReader A_0)
    {
        new Guid(A_0.ReadBytes(0x10));
        int count = A_0.ReadInt32();
        this.byte_0 = A_0.ReadBytes(count);
    }

    internal override void vmethod_3(BinaryWriter A_0)
    {
        A_0.Write(guid_0.ToByteArray());
        A_0.Write(this.byte_0.Length);
        A_0.Write(this.byte_0);
    }
}

