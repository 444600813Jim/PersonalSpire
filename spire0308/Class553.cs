using Spire.Doc;
using System;
using System.IO;

internal class Class553 : Interface24
{
    private byte[] byte_0;
    private Class451 class451_0;
    private readonly Class451 class451_1;
    private Guid guid_0;
    private const int int_0 = 0x71b239f4;
    private int int_1;
    private int int_2;
    private string string_0;
    private string string_1;
    private string string_2;
    private readonly string string_3;

    internal Class553(Class1089 A_0)
    {
        MemoryStream input = A_0.method_4(BookmarkStart.b("〰瀲娴娶䤸琺弼唾", 11));
        if (input != null)
        {
            BinaryReader reader = new BinaryReader(input);
            this.int_1 = reader.ReadInt32();
            this.int_2 = reader.ReadInt32();
            this.byte_0 = reader.ReadBytes(4);
            this.guid_0 = new Guid(reader.ReadBytes(0x10));
            this.string_3 = Class627.smethod_2(reader);
            this.class451_1 = new Class451(reader, false);
            this.string_0 = Class627.smethod_2(reader);
            if (Class567.smethod_46(reader, 4) && (reader.ReadInt32() == 0x71b239f4))
            {
                this.string_1 = Class1029.smethod_6(reader);
                this.class451_0 = new Class451(reader, true);
                this.string_2 = Class1029.smethod_6(reader);
            }
        }
    }

    internal Class553(string A_0)
    {
        this.guid_0 = Class627.smethod_7(A_0);
        this.string_3 = "";
        this.class451_1 = new Class451("");
    }

    private void imethod_0(BinaryWriter A_0)
    {
        A_0.Write((uint) 0xfffe0001);
        A_0.Write(0xa03);
        A_0.Write(uint.MaxValue);
        A_0.Write(this.guid_0.ToByteArray());
        Class627.smethod_5(A_0, this.string_3);
        ((this.class451_1 == null) ? new Class451("") : this.class451_1).method_2(A_0, false);
        Class627.smethod_5(A_0, "");
        A_0.Write(0x71b239f4);
        A_0.Write(0);
        A_0.Write(0);
        A_0.Write(0);
    }

    string Interface24.imethod_1()
    {
        return BookmarkStart.b("㐴琶嘸嘺䴼瀾⍀⥂", 15);
    }

    internal string method_0()
    {
        return this.string_3;
    }

    internal Class451 method_1()
    {
        return this.class451_1;
    }

    internal Guid method_2()
    {
        return this.guid_0;
    }

    internal string method_3()
    {
        return this.string_2;
    }
}

