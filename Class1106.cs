using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Drawing;
using System.IO;

internal class Class1106
{
    internal const int int_0 = 2;
    internal const int int_1 = 10;

    internal static Class16 smethod_0(BinaryReader A_0, Class16 A_1)
    {
        if (A_1 == null)
        {
            A_1 = new Class16();
        }
        int num = A_0.ReadUInt16();
        A_1.method_61(Class624.smethod_1(((Word97Color) num) & (Word97Color.LightGray | Word97Color.DarkGray)));
        A_1.method_57(Class624.smethod_1((Word97Color) ((num & 0x3e0) >> 5)));
        A_1.method_63((TextureStyle) ((num & 0xfc00) >> 10));
        return A_1;
    }

    internal static Class16 smethod_1(BinaryReader A_0, Class16 A_1)
    {
        Color empty;
        if (A_1 == null)
        {
            A_1 = new Class16();
        }
        int num = A_0.ReadInt32();
        if (num == -16777216)
        {
            empty = Color.Empty;
        }
        else
        {
            empty = Class624.smethod_7(num);
        }
        A_1.method_61(empty);
        num = A_0.ReadInt32();
        if (num == -16777216)
        {
            empty = Color.Empty;
        }
        else
        {
            empty = Class624.smethod_7(num);
        }
        A_1.method_57(empty);
        A_1.method_63(Class955.smethod_12((TextureStyle) A_0.ReadUInt16()));
        if (A_1.method_62() == TextureStyle.TextureNil)
        {
            A_1.method_57(Color.Empty);
            A_1.method_61(Color.Empty);
        }
        return A_1;
    }

    internal static void smethod_2(Class16 A_0, BinaryWriter A_1)
    {
        int num = 0;
        if (A_0.method_62() == TextureStyle.TextureNil)
        {
            num = 0xffff;
        }
        else
        {
            num |= Class624.smethod_0(A_0.method_60());
            num |= ((int) Class624.smethod_0(A_0.method_56())) << 5;
            num |= ((int) A_0.method_62()) << 10;
        }
        A_1.Write((ushort) num);
    }

    internal static void smethod_3(Class16 A_0, BinaryWriter A_1)
    {
        if (A_0.method_62() == TextureStyle.TextureNil)
        {
            A_1.Write(uint.MaxValue);
            A_1.Write(uint.MaxValue);
            A_1.Write((ushort) 0xffff);
        }
        else
        {
            A_1.Write(Class624.smethod_6(A_0.method_60()));
            A_1.Write(Class624.smethod_6(A_0.method_56()));
            A_1.Write((ushort) A_0.method_62());
        }
    }

    internal static void smethod_4(Class16 A_0, BinaryWriter A_1, bool A_2)
    {
        if (A_2)
        {
            smethod_3(A_0, A_1);
        }
        else
        {
            smethod_2(A_0, A_1);
        }
    }

    internal static int smethod_5(bool A_0)
    {
        if (!A_0)
        {
            return 2;
        }
        return 10;
    }
}

