using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;
using System.Text;

internal class Class430 : Class428, Interface54
{
    internal static bool bool_0;
    private const int int_0 = 1;
    private const int int_1 = 2;
    private const int int_2 = 0x1e5;
    private int int_3;

    internal Class430()
    {
    }

    internal Class430(int A_0, byte[] A_1)
    {
        this.int_3 = A_0;
        base.method_3(A_1);
    }

    internal Class430(BinaryReader A_0, bool A_1)
    {
        int num;
        int num3;
        if (A_1)
        {
            int num2 = A_0.ReadByte();
            if (num2 == 0)
            {
                num = A_0.ReadByte() * 2;
            }
            else
            {
                num = (num2 * 2) - 1;
            }
        }
        else
        {
            num = A_0.ReadInt16();
        }
        if (num > 0)
        {
            this.int_3 = A_0.ReadInt16();
            num3 = num - 2;
        }
        else
        {
            num3 = 0;
        }
        if (num3 > 0)
        {
            base.method_3(A_0.ReadBytes(num3));
        }
        else
        {
            base.method_3(Class85.byte_0);
        }
    }

    public override int Class428.imethod_0()
    {
        return (base.imethod_0() ^ this.int_3);
    }

    public int imethod_1(bool A_0)
    {
        if (!A_0)
        {
            return (4 + base.method_2().Length);
        }
        int num = 3 + base.method_2().Length;
        if (Class567.smethod_3((long) num))
        {
            num++;
        }
        return num;
    }

    public void imethod_2(BinaryWriter A_0, bool A_1)
    {
        if (A_1)
        {
            if (Class567.smethod_3((long) base.method_2().Length))
            {
                int num2 = (3 + base.method_2().Length) / 2;
                A_0.Write((byte) num2);
            }
            else
            {
                A_0.Write((byte) 0);
                int num = (2 + base.method_2().Length) / 2;
                A_0.Write((byte) num);
            }
        }
        else
        {
            int num3 = 2 + base.method_2().Length;
            A_0.Write((short) num3);
        }
        A_0.Write((short) this.int_3);
        A_0.Write(base.method_2());
    }

    internal bool method_4(Class430 A_0)
    {
        return (base.method_1(A_0) && (this.int_3 == A_0.int_3));
    }

    internal void method_5(Class428 A_0)
    {
        byte[] array = new byte[base.method_2().Length + A_0.method_2().Length];
        base.method_2().CopyTo(array, 0);
        A_0.method_2().CopyTo(array, base.method_2().Length);
        base.method_3(array);
    }

    internal int method_6()
    {
        return this.int_3;
    }

    internal static Class428 smethod_0(BinaryReader A_0, int A_1)
    {
        int num2 = 14;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("紳堵䠷伹䠻", num2));
        }
        A_0.BaseStream.Seek((long) A_1, SeekOrigin.Begin);
        return new Class428(A_0, A_0.ReadInt16());
    }

    internal static bool smethod_1(Class430 A_0)
    {
        return (A_0.method_2().Length > 0x1e5);
    }

    internal static Class430 smethod_2(Stream A_0, Class430 A_1)
    {
        int position = (int) A_0.Position;
        BinaryWriter writer = new BinaryWriter(A_0, Encoding.Unicode);
        writer.Write((short) A_1.method_2().Length);
        writer.Write(A_1.method_2());
        MemoryStream stream = new MemoryStream();
        new Class345(stream).method_3(SprmCode.PHugePapx, position);
        return new Class430(A_1.method_6(), stream.ToArray());
    }
}

