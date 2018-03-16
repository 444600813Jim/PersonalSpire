using Spire.Doc;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

internal class Class917 : Class916
{
    private readonly Class522 class522_0;
    private readonly Stream stream_0;

    internal Class917(Stream A_0, Class522 A_1)
    {
        this.stream_0 = A_0;
        this.class522_0 = A_1;
    }

    internal void method_6()
    {
        Class916 class2 = Class523.smethod_0(this.stream_0, this.class522_0.int_6, this.class522_0.uint_1, this.class522_0.int_4);
        byte[] buffer = new byte[0x200];
        BinaryReader reader = new BinaryReader(new MemoryStream(buffer), Encoding.Unicode);
        for (uint i = 0; i < this.class522_0.int_6; i++)
        {
            this.stream_0.Position = Class967.smethod_0(class2.method_0(i), true);
            this.stream_0.Read(buffer, 0, 0x200);
            reader.BaseStream.Position = 0L;
            for (int j = 0; j < 0x80; j++)
            {
                base.method_5(reader.ReadUInt32());
            }
        }
    }

    [Conditional("DEBUG")]
    internal void method_7()
    {
        int num = 0x10;
        using (StreamWriter writer = new StreamWriter(BookmarkStart.b("爵ȷ昹䐻ွⰿⵁ⍃", 0x10)))
        {
            for (uint i = 0; i < base.method_2(); i++)
            {
                writer.WriteLine(string.Format(BookmarkStart.b("䴵࠷䜹᰻䔽焿㽁摃癅ぇㅉ繋瑍ࡏ橑⥓", num), i, base.method_0(i), base.method_0(i)));
            }
        }
    }

    internal void method_8()
    {
        MemoryStream stream = base.method_4();
        BinaryWriter writer = new BinaryWriter(this.stream_0, Encoding.Unicode);
        uint num = Class967.smethod_1(this.stream_0.Position, true);
        int num2 = base.method_2();
        int num3 = Class567.smethod_4((long) num2, 0x80);
        num3 = Class567.smethod_4((long) (num2 + num3), 0x80);
        this.stream_0.Write(stream.GetBuffer(), 0, (int) stream.Length);
        for (int i = 0; i < num3; i++)
        {
            writer.Write((uint) 0xfffffffd);
        }
        int num8 = Class567.smethod_4((long) (num2 + num3), 0x80);
        if (num8 > 0x6d)
        {
            int num7 = Class567.smethod_4((long) (num8 - 0x6d), 0x7f);
            for (int j = 0; j < num7; j++)
            {
                writer.Write((uint) 0xfffffffd);
            }
            for (int k = 0; k < num7; k++)
            {
                writer.Write((uint) 0xfffffffc);
            }
            num8 = Class567.smethod_4((long) ((num2 + num3) + num7), 0x80);
        }
        this.class522_0.int_6 = num8;
        Class967.smethod_2(writer);
        Class523.smethod_1(this.stream_0, num, num8, this.class522_0);
    }
}

