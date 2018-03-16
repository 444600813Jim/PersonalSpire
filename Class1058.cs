using Spire.Doc;
using System;
using System.IO;

internal class Class1058
{
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_2;
    internal bool bool_3;
    internal int int_0;
    internal MailMergeDataType mailMergeDataType_0;
    internal MailMergeLegacySeparator mailMergeLegacySeparator_0;
    internal MailMergeLegacySeparator mailMergeLegacySeparator_1;

    internal Class1058()
    {
    }

    internal Class1058(BinaryReader A_0)
    {
        this.mailMergeDataType_0 = (MailMergeDataType) A_0.ReadByte();
        int num = A_0.ReadByte();
        this.bool_0 = (num & 1) != 0;
        this.bool_1 = (num & 2) != 0;
        this.bool_2 = (num & 4) != 0;
        this.bool_3 = (num & 8) != 0;
        this.mailMergeLegacySeparator_0 = (MailMergeLegacySeparator) A_0.ReadInt16();
        this.mailMergeLegacySeparator_1 = (MailMergeLegacySeparator) A_0.ReadInt16();
        this.int_0 = A_0.ReadInt16();
    }

    internal void method_0(BinaryWriter A_0)
    {
        A_0.Write((byte) this.mailMergeDataType_0);
        int num = 0;
        num = 0 | (this.bool_0 ? 1 : 0);
        num |= this.bool_1 ? 2 : 0;
        num |= this.bool_2 ? 4 : 0;
        num |= this.bool_3 ? 8 : 0;
        A_0.Write((byte) num);
        A_0.Write((short) this.mailMergeLegacySeparator_0);
        A_0.Write((short) this.mailMergeLegacySeparator_1);
        A_0.Write((short) this.int_0);
    }
}

