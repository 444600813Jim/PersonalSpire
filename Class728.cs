using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class728
{
    private EsRecordType esRecordType_0;
    private int int_0;
    private int int_1;
    private int int_2;

    internal Class728()
    {
    }

    internal Class728(BinaryReader A_0)
    {
        this.method_0(A_0);
    }

    internal void method_0(BinaryReader A_0)
    {
        int num = A_0.ReadInt32();
        this.int_0 = num & 15;
        this.int_1 = (num & 0xfff0) >> 4;
        this.esRecordType_0 = (EsRecordType) ((int) ((num & 0xffff0000L) >> 0x10));
        this.int_2 = A_0.ReadInt32();
    }

    internal void method_1(BinaryWriter A_0)
    {
        int num = 0;
        num = 0 | this.int_0;
        num |= this.int_1 << 4;
        num |= ((int) this.esRecordType_0) << 0x10;
        A_0.Write(num);
        A_0.Write(this.int_2);
    }

    internal int method_10()
    {
        return this.int_2;
    }

    internal void method_11(int A_0)
    {
        this.int_2 = A_0;
    }

    internal bool method_2()
    {
        return (this.int_0 == 15);
    }

    internal void method_3(bool A_0)
    {
        this.int_0 = A_0 ? 15 : 0;
    }

    internal int method_4()
    {
        return this.int_0;
    }

    internal void method_5(int A_0)
    {
        this.int_0 = A_0;
    }

    internal int method_6()
    {
        return this.int_1;
    }

    internal void method_7(int A_0)
    {
        this.int_1 = A_0;
    }

    internal EsRecordType method_8()
    {
        return this.esRecordType_0;
    }

    internal void method_9(EsRecordType A_0)
    {
        this.esRecordType_0 = A_0;
    }

    string object.ToString()
    {
        return string.Format(BookmarkStart.b("甯䄱簳匵夷帹夻䰽氿扁၃㽅㡇⽉癋㕍恏桑౓⭕瑗穙ਜ਼㭝቟ᅡൣ॥٧偩ᝫ彭൯幱味㽵ᙷॹࡻώ벅뢉ꊍ낏\ude91\uf193ﾗ꒝\udb9f\u91a1\ud9a3", 10), new object[] { this.esRecordType_0, this.int_0, this.int_1, this.int_2 });
    }
}

