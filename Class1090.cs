using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.IO;
using System.Text;

internal class Class1090
{
    internal bool bool_0;
    internal DirEntryColor dirEntryColor_0;
    internal DirEntryType dirEntryType_0;
    internal Guid guid_0;
    internal const int int_0 = 0x80;
    private const int int_1 = 0x40;
    private const int int_2 = 0x10;
    private const int int_3 = 20;
    internal long long_0;
    internal long long_1;
    internal long long_2;
    internal string string_0;
    internal const uint uint_0 = uint.MaxValue;
    internal uint uint_1;
    internal uint uint_2;
    internal uint uint_3;
    internal uint uint_4;
    internal uint uint_5;

    internal Class1090()
    {
        this.dirEntryType_0 = DirEntryType.Invalid;
        this.dirEntryColor_0 = DirEntryColor.Black;
        this.uint_2 = uint.MaxValue;
        this.uint_3 = uint.MaxValue;
        this.uint_1 = uint.MaxValue;
        this.guid_0 = Guid.Empty;
    }

    internal Class1090(BinaryReader A_0)
    {
        int num3 = 9;
        int position = (int) A_0.BaseStream.Position;
        byte[] bytes = A_0.ReadBytes(0x40);
        if (bytes.Length >= 0x40)
        {
            int num2 = A_0.ReadUInt16();
            if (num2 <= 0x40)
            {
                if (num2 > 0)
                {
                    if (num2 > bytes.Length)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("笮夰嘲ᔴ䐶䴸䤺䠼尾㕀㙂㝄≆ⵈ歊㹌㭎㹐⅒㑔ざ㱘筚㹜ぞ፠ᅢၤᝦᵨ๪६䅮", num3));
                    }
                    this.string_0 = Encoding.Unicode.GetString(bytes, 0, num2 - 2);
                }
                else
                {
                    this.string_0 = null;
                }
                this.dirEntryType_0 = (DirEntryType) A_0.ReadByte();
                if (this.dirEntryType_0 == DirEntryType.Invalid)
                {
                    A_0.BaseStream.Position = position + 0x80;
                }
                else
                {
                    this.dirEntryColor_0 = (DirEntryColor) A_0.ReadByte();
                    this.uint_2 = A_0.ReadUInt32();
                    this.uint_3 = A_0.ReadUInt32();
                    this.uint_1 = A_0.ReadUInt32();
                    this.guid_0 = new Guid(A_0.ReadBytes(0x10));
                    this.uint_5 = A_0.ReadUInt32();
                    this.long_0 = A_0.ReadInt64();
                    if (Class567.smethod_46(A_0, 20))
                    {
                        this.long_1 = A_0.ReadInt64();
                        this.uint_4 = A_0.ReadUInt32();
                        this.long_2 = A_0.ReadUInt32();
                        A_0.ReadInt32();
                    }
                }
            }
        }
    }

    internal Class1090(string A_0, DirEntryType A_1, long A_2) : this()
    {
        this.string_0 = A_0;
        this.dirEntryType_0 = A_1;
        this.long_2 = A_2;
        this.uint_4 = uint.MaxValue;
    }

    internal Class1090(string A_0, bool A_1, Guid A_2) : this()
    {
        this.string_0 = A_0;
        this.dirEntryType_0 = A_1 ? DirEntryType.Root : DirEntryType.Storage;
        this.guid_0 = A_2;
        this.uint_4 = A_1 ? uint.MaxValue : 0;
    }

    internal void method_0(BinaryWriter A_0)
    {
        int num2;
        int num = 13;
        byte[] destinationArray = new byte[0x40];
        if (Class567.smethod_16(this.string_0))
        {
            byte[] bytes = Encoding.Unicode.GetBytes(this.string_0);
            if (bytes.Length > 0x3e)
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("朲崴制ᤸ唺尼刾⑀捂扄㱆祈㙊橌潎㡐⁒畔⍖㙘㑚絜㍞๠ൢɤ䥦", num), this.string_0));
            }
            Array.Copy(bytes, 0, destinationArray, 0, bytes.Length);
            num2 = bytes.Length + 2;
        }
        else
        {
            num2 = 0;
        }
        A_0.Write(destinationArray);
        A_0.Write((ushort) num2);
        A_0.Write((byte) this.dirEntryType_0);
        A_0.Write((byte) this.dirEntryColor_0);
        A_0.Write(this.uint_2);
        A_0.Write(this.uint_3);
        A_0.Write(this.uint_1);
        A_0.Write(this.guid_0.ToByteArray());
        A_0.Write(this.uint_5);
        A_0.Write(this.long_0);
        A_0.Write(this.long_1);
        A_0.Write(this.uint_4);
        A_0.Write((uint) this.long_2);
        A_0.Write(0);
    }
}

