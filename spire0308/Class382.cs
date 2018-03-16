using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;
using System.Text;

internal class Class382 : Class380
{
    private static readonly byte[] byte_0 = new byte[] { 0xd0, 0xc9, 0xea, 0x79, 0xf9, 0xba, 0xce, 0x11, 140, 130, 0, 170, 0, 0x4b, 0xa9, 11 };
    private static readonly byte[] byte_1 = new byte[] { 0xe0, 0xc9, 0xea, 0x79, 0xf9, 0xba, 0xce, 0x11, 140, 130, 0, 170, 0, 0x4b, 0xa9, 11 };
    private static readonly byte[] byte_2 = new byte[] { 3, 3, 0, 0, 0, 0, 0, 0, 0xc0, 0, 0, 0, 0, 0, 0, 70 };
    private string string_0;
    private string string_1;
    private string string_2;

    internal Class382(int A_0, int A_1) : base(A_0, A_1)
    {
    }

    internal Class382(int A_0, string A_1, string A_2, string A_3) : base(A_0, 0)
    {
        this.string_0 = A_1;
        this.string_1 = A_2;
        this.string_2 = A_3;
        base.method_2(this.method_3());
    }

    private int method_3()
    {
        MemoryStream output = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(output);
        this.vmethod_3(writer);
        return (int) output.Position;
    }

    private void method_4(BinaryReader A_0)
    {
        int num = 0;
        if (base.method_1() != 0)
        {
            A_0.ReadBytes(0x10);
            if (A_0.ReadInt32() == 2)
            {
                EsUriFlags flags = (EsUriFlags) A_0.ReadInt32();
                if ((flags & EsUriFlags.HasDisplayName) != 0)
                {
                    Class1029.smethod_7(A_0);
                }
                if ((flags & EsUriFlags.HasFrameName) != 0)
                {
                    this.string_2 = Class1029.smethod_7(A_0);
                }
                if ((flags & EsUriFlags.HasMoniker) != 0)
                {
                    if ((flags & EsUriFlags.MonikerSavedAsStr) == 0)
                    {
                        byte[] buffer = A_0.ReadBytes(0x10);
                        if (!Class85.smethod_1(buffer, byte_1))
                        {
                            if (!Class85.smethod_1(buffer, byte_2))
                            {
                                Guid guid = new Guid(buffer);
                                throw new InvalidOperationException(string.Format(BookmarkStart.b("猥䘧䄩䈫䄭䜯就ᐳ帵䄷䨹夻䰽ⰿ⭁⩃ⵅ桇ⱉ⍋㱍㵏㍑⁓硕硗᝙㍛そय़ॡţᑥ䡧⵩㥫❭㑯剱ᵳյ塷Ź䱻ͽ깿", num), guid.ToString()));
                            }
                            this.string_0 = smethod_1(A_0);
                        }
                        else
                        {
                            this.string_0 = smethod_0(A_0);
                        }
                    }
                    else
                    {
                        this.string_0 = Class1029.smethod_7(A_0);
                    }
                }
                if ((flags & EsUriFlags.HasLocationStr) != 0)
                {
                    this.string_1 = Class1029.smethod_7(A_0);
                }
                if ((flags & EsUriFlags.HasGUID) != 0)
                {
                    A_0.ReadBytes(0x10);
                }
                if ((flags & EsUriFlags.HasCreationTime) != 0)
                {
                    A_0.ReadBytes(8);
                }
            }
        }
    }

    internal string method_5()
    {
        return this.string_0;
    }

    internal string method_6()
    {
        return this.string_1;
    }

    internal string method_7()
    {
        return this.string_2;
    }

    private static string smethod_0(BinaryReader A_0)
    {
        string str = Class1029.smethod_6(A_0);
        int index = str.IndexOf('\0');
        if (index >= 0)
        {
            return str.Substring(0, index);
        }
        return str;
    }

    private static string smethod_1(BinaryReader A_0)
    {
        A_0.ReadUInt16();
        string str = Class1029.smethod_14(A_0);
        A_0.ReadUInt16();
        A_0.ReadUInt16();
        for (int i = 0; i < 5; i++)
        {
            A_0.ReadInt32();
        }
        if (A_0.ReadInt32() > 0)
        {
            int count = A_0.ReadInt32();
            A_0.ReadInt16();
            byte[] bytes = A_0.ReadBytes(count);
            return Encoding.Unicode.GetString(bytes);
        }
        return str;
    }

    internal override void vmethod_2(BinaryReader A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        try
        {
            this.method_4(A_0);
        }
        finally
        {
            int num2 = position + base.method_1();
            A_0.BaseStream.Position = num2;
        }
    }

    internal override void vmethod_3(BinaryWriter A_0)
    {
        A_0.Write(byte_0);
        A_0.Write(2);
        int position = (int) A_0.BaseStream.Position;
        int num2 = 0;
        A_0.Write(0);
        if (Class567.smethod_16(this.string_2))
        {
            Class1029.smethod_9(this.string_2, A_0);
            num2 |= 0x80;
        }
        if (Class567.smethod_16(this.string_0))
        {
            A_0.Write(byte_1);
            Class1029.smethod_10(this.string_0, A_0);
            num2 |= 1;
            num2 |= 2;
        }
        if (Class567.smethod_16(this.string_1))
        {
            Class1029.smethod_9(this.string_1, A_0);
            num2 |= 8;
        }
        int num3 = (int) A_0.BaseStream.Position;
        A_0.BaseStream.Position = position;
        A_0.Write(num2);
        A_0.BaseStream.Position = num3;
    }
}

