using Spire.Doc;
using System;
using System.IO;

internal class Class534
{
    internal byte[] byte_0;
    internal byte[] byte_1;
    internal byte[] byte_2;
    internal int int_0;
    internal int int_1;

    internal Class534()
    {
    }

    internal Class534(BinaryReader A_0, bool A_1)
    {
        int num = 0x11;
        this.int_0 = A_0.ReadInt32();
        if (this.int_0 != 0x10)
        {
            throw new InvalidOperationException(BookmarkStart.b("戶圸帺䔼伾⑀⁂ㅄ≆ⵈ歊㹌⹎㵐❒畔⑖じ⅚㡜煞", num));
        }
        this.byte_0 = A_0.ReadBytes(this.int_0);
        this.byte_1 = A_0.ReadBytes(0x10);
        this.int_1 = A_0.ReadInt32();
        this.byte_2 = A_0.ReadBytes(A_1 ? 0x20 : 20);
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write(0x10);
        A_0.Write(this.byte_0);
        A_0.Write(this.byte_1);
        A_0.Write(20);
        A_0.Write(this.byte_2);
    }
}

