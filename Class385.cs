using System;
using System.IO;

internal class Class385 : Class380
{
    private byte[] byte_0;
    private static Guid guid_0 = new Guid(BookmarkStart.b("儩ᔫᴭܯ儱Գ圵ଷูᄻ༽甿獁⁃歅籇籉絋繍絏歑㝓㝕湗睙㵛晝͟š嵣ѥ౧ࡩ奫੭䡯䅱ॳ", 4));

    internal Class385(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class385(int A_0, byte[] A_1) : base(A_0, A_1.Length + 20)
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

