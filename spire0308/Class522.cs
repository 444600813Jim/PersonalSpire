using Spire.Doc;
using System;
using System.IO;

internal class Class522
{
    internal const int int_0 = 0x6d;
    internal const int int_1 = 0x4c;
    private const int int_2 = 3;
    private const int int_3 = 0x10;
    internal int int_4;
    internal int int_5;
    internal int int_6;
    internal int int_7;
    private const long long_0 = -2226271756974174256L;
    internal uint uint_0;
    internal uint uint_1;
    internal uint uint_2;
    internal uint uint_3;
    internal ushort ushort_0;
    internal ushort ushort_1;
    internal ushort ushort_2;
    internal ushort ushort_3;

    internal Class522()
    {
        this.ushort_2 = 0x21;
        this.ushort_0 = 3;
        this.ushort_3 = 9;
        this.ushort_1 = 6;
        this.uint_0 = 0x1000;
    }

    internal Class522(BinaryReader A_0)
    {
        int num2 = 6;
        if (A_0.ReadInt64() != -2226271756974174256L)
        {
            throw new InvalidOperationException(BookmarkStart.b("砫䘭夯䄱ᐳ張䬷ᨹ刻儽㐿扁╃晅㭇㹉㹋㭍㍏♑⅓⑕㵗㹙籛ⵝᑟൡᙣݥཧཀྵ䱫࡭᥯ṱᅳ塵", num2));
        }
        A_0.ReadBytes(0x10);
        this.ushort_2 = A_0.ReadUInt16();
        this.ushort_0 = A_0.ReadUInt16();
        if (this.ushort_0 > 3)
        {
            throw new NotSupportedException(BookmarkStart.b("砫䘭夯䄱ᐳ䔵䰷䠹䤻崽㐿㝁㙃⍅ⱇ橉㽋㩍㽏⁑㕓ㅕ㵗穙⩛㭝቟ᅡൣ॥٧䩩իᵭ偯ᱱ᭳ɵ塷ॹॻ๽ꊋ", num2));
        }
        A_0.ReadUInt16();
        this.ushort_3 = A_0.ReadUInt16();
        this.ushort_1 = A_0.ReadUInt16();
        A_0.ReadUInt16();
        A_0.ReadUInt32();
        this.int_5 = A_0.ReadInt32();
        this.int_6 = A_0.ReadInt32();
        this.uint_2 = A_0.ReadUInt32();
        A_0.ReadUInt32();
        this.uint_0 = A_0.ReadUInt32();
        this.uint_3 = A_0.ReadUInt32();
        this.int_7 = A_0.ReadInt32();
        this.uint_1 = A_0.ReadUInt32();
        this.int_4 = A_0.ReadInt32();
    }

    internal int method_0()
    {
        return (this.int_7 * 0x200);
    }

    internal void method_1(BinaryWriter A_0)
    {
        A_0.Write((long) (-2226271756974174256L));
        A_0.Write(new byte[0x10]);
        A_0.Write(this.ushort_2);
        A_0.Write(this.ushort_0);
        A_0.Write((ushort) 0xfffe);
        A_0.Write(this.ushort_3);
        A_0.Write(this.ushort_1);
        A_0.Write((short) 0);
        A_0.Write(0);
        A_0.Write(this.int_5);
        A_0.Write(this.int_6);
        A_0.Write(this.uint_2);
        A_0.Write(0);
        A_0.Write(this.uint_0);
        A_0.Write(this.uint_3);
        A_0.Write(this.int_7);
        A_0.Write(this.uint_1);
        A_0.Write(this.int_4);
    }

    internal bool method_2(long A_0)
    {
        return (A_0 >= this.uint_0);
    }
}

