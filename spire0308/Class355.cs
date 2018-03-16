using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;
using System.IO;

internal class Class355
{
    internal const int int_0 = 4;
    internal const int int_1 = 8;

    internal static Border smethod_0(BinaryReader A_0, Border A_1)
    {
        int num = A_0.ReadByte();
        int num2 = A_0.ReadByte();
        if (num2 != 0xff)
        {
            if (A_1 == null)
            {
                A_1 = new Border();
            }
            A_1.BorderType = (BorderStyle) num2;
            A_1.LineWidth = ((float) num) / 8f;
            A_1.Color = Class624.smethod_1((Word97Color) A_0.ReadByte());
            int num3 = A_0.ReadByte();
            A_1.Space = (byte) (num3 & 0x1f);
            A_1.Shadow = (num3 & 0x20) != 0;
            A_1.Frame = (num3 & 0x40) != 0;
            A_1.IsChanged = true;
            return A_1;
        }
        A_0.ReadByte();
        A_0.ReadByte();
        return null;
    }

    internal static Border smethod_1(BinaryReader A_0, Border A_1)
    {
        int num = A_0.ReadInt32();
        int num2 = A_0.ReadByte();
        int num3 = A_0.ReadByte();
        if (num3 != 0xff)
        {
            if (A_1 == null)
            {
                A_1 = new Border();
            }
            A_1.LineWidth = ((float) num2) / 8f;
            A_1.BorderType = (BorderStyle) num3;
            if (num == -16777216)
            {
                A_1.Color = Color.Empty;
            }
            else
            {
                A_1.Color = Class624.smethod_7(num);
            }
            int num4 = A_0.ReadByte();
            A_1.Space = (byte) (num4 & 0x1f);
            A_1.Shadow = (num4 & 0x20) != 0;
            A_1.Frame = (num4 & 0x40) != 0;
            A_1.IsChanged = true;
            A_0.ReadByte();
            return A_1;
        }
        A_0.ReadByte();
        A_0.ReadByte();
        if (A_1 == null)
        {
            A_1 = new Border();
        }
        A_1.BorderType = BorderStyle.Cleared;
        return A_1;
    }

    internal static void smethod_2(Border A_0, BinaryWriter A_1, bool A_2)
    {
        smethod_3(A_0, A_1, A_2, 1f);
    }

    internal static void smethod_3(Border A_0, BinaryWriter A_1, bool A_2, float A_3)
    {
        while (A_0 != null)
        {
            if (!A_0.IsDefault || (A_0.BaseFormat == null))
            {
                break;
            }
            A_0 = A_0.BaseFormat as Border;
        }
        if ((A_0 != null) && !A_0.IsDefault)
        {
            A_1.Write((byte) Math.Round((double) (A_0.LineWidth * A_3)));
            A_1.Write((byte) smethod_5(A_0.BorderType, false));
            if ((A_0.BorderType == BorderStyle.None) && (A_0.Color == Color.Empty))
            {
                A_1.Write((byte) 0);
            }
            else
            {
                A_1.Write((byte) Class624.smethod_0(A_0.Color));
            }
            int num = 0;
            num = 0 | (A_2 ? ((int) A_0.Space) : 0);
            num |= (A_0.Shadow ? 0x20 : 0) | (A_0.Frame ? 0x40 : 0);
            A_1.Write((byte) num);
        }
        else
        {
            A_1.Write(uint.MaxValue);
        }
    }

    internal static void smethod_4(Border A_0, BinaryWriter A_1, bool A_2)
    {
        while (A_0 != null)
        {
            if (!A_0.IsDefault || (A_0.BaseFormat == null))
            {
                break;
            }
            A_0 = A_0.BaseFormat as Border;
        }
        if (((A_0 != null) && !A_0.IsDefault) && (A_0.BorderType != BorderStyle.Cleared))
        {
            A_1.Write(Class624.smethod_6(A_0.Color));
            A_1.Write((byte) (A_0.LineWidth * 8f));
            A_1.Write((byte) smethod_5(A_0.BorderType, true));
            int num = 0;
            num = 0 | (A_2 ? ((int) A_0.Space) : 0);
            num |= (A_0.Shadow ? 0x20 : 0) | (A_0.Frame ? 0x40 : 0);
            A_1.Write((byte) num);
            A_1.Write((byte) 0);
        }
        else
        {
            A_1.Write(uint.MaxValue);
            A_1.Write(uint.MaxValue);
        }
    }

    private static BorderStyle smethod_5(BorderStyle A_0, bool A_1)
    {
        if ((A_0 != BorderStyle.Inset) && (A_0 != BorderStyle.Outset))
        {
            if (A_0 == BorderStyle.Thick)
            {
                return BorderStyle.Single;
            }
            if (A_0 == BorderStyle.Cleared)
            {
                return BorderStyle.None;
            }
            return A_0;
        }
        if (!A_1)
        {
            return BorderStyle.Single;
        }
        return A_0;
    }

    internal static void smethod_6(Border A_0, BinaryWriter A_1, bool A_2, bool A_3)
    {
        if (A_3)
        {
            smethod_4(A_0, A_1, A_2);
        }
        else
        {
            smethod_2(A_0, A_1, A_2);
        }
    }

    internal static int smethod_7(bool A_0)
    {
        if (!A_0)
        {
            return 4;
        }
        return 8;
    }
}

