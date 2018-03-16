using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Tables;
using Spire.Doc.Formatting;
using System;
using System.IO;

internal class Class354
{
    internal const int int_0 = 20;

    internal static void smethod_0(BinaryReader A_0, CellFormat A_1)
    {
        CellMerge start;
        CellMerge none;
        int num = A_0.ReadInt16();
        bool flag = (num & 1) != 0;
        bool flag2 = (num & 2) != 0;
        if (flag)
        {
            start = CellMerge.Start;
        }
        else if (flag2)
        {
            start = CellMerge.Continue;
        }
        else
        {
            start = CellMerge.None;
        }
        A_1.SetAttr(0xbe0, start);
        A_1.SetAttr(0xbea, Class417.smethod_36((num & 0x1c) >> 2));
        bool flag3 = (num & 0x20) != 0;
        if ((num & 0x40) != 0)
        {
            none = CellMerge.Start;
        }
        else if (flag3)
        {
            none = CellMerge.Continue;
        }
        else
        {
            none = CellMerge.None;
        }
        A_1.SetAttr(0xbd6, none);
        A_1.SetAttr(0xbf4, (VerticalAlignment) ((num & 0x180) >> 7));
        FtsWidth width = (FtsWidth) ((num & 0xe00) >> 9);
        int num2 = A_0.ReadInt16();
        switch (width)
        {
            case FtsWidth.Auto:
                A_1.SetAttr(0xbc6, width);
                A_1.SetAttr(0xbc4, 0f);
                break;

            case FtsWidth.Percentage:
                A_1.SetAttr(0xbc6, width);
                A_1.SetAttr(0xbc4, ((float) num2) / 50f);
                break;

            case FtsWidth.Point:
                A_1.SetAttr(0xbc6, width);
                A_1.SetAttr(0xbc4, ((float) num2) / 20f);
                break;
        }
        A_1.SetAttr(0xc76, (num & 0x1000) != 0);
        A_1.SetAttr(0xc6c, (num & 0x2000) == 0);
        smethod_2(A_0, A_1, 0xc26);
        smethod_2(A_0, A_1, 0xc30);
        smethod_2(A_0, A_1, 0xc3a);
        smethod_2(A_0, A_1, 0xc44);
    }

    internal static void smethod_1(CellFormat A_0, BinaryWriter A_1)
    {
        int num = 0;
        num = 0 | ((A_0.HorizontalMerge == CellMerge.Start) ? 1 : 0);
        num |= (A_0.HorizontalMerge == CellMerge.Continue) ? 2 : 0;
        num |= Class417.smethod_37(A_0.TextDirection) << 2;
        num |= (A_0.VerticalMerge != CellMerge.None) ? 0x20 : 0;
        num |= (A_0.VerticalMerge == CellMerge.Start) ? 0x40 : 0;
        num |= ((int) A_0.VerticalAlignment) << 7;
        num |= ((int) A_0.WidthUnit) << 9;
        num |= A_0.FitText ? 0x1000 : 0;
        num |= A_0.TextWrap ? 0 : 0x2000;
        A_1.Write((short) num);
        A_1.Write((short) (A_0.CellWidth * 20f));
        smethod_3(A_0, 0xc26, A_1);
        smethod_3(A_0, 0xc30, A_1);
        smethod_3(A_0, 0xc3a, A_1);
        smethod_3(A_0, 0xc44, A_1);
    }

    private static void smethod_2(BinaryReader A_0, CellFormat A_1, int A_2)
    {
        Class355.smethod_0(A_0, A_1.method_33(A_2) as Border);
    }

    private static void smethod_3(CellFormat A_0, int A_1, BinaryWriter A_2)
    {
        Border border = (Border) A_0.method_31(A_1);
        if ((border != null) && !border.IsDefault)
        {
            if (border.BorderType == BorderStyle.Cleared)
            {
                A_2.Write(uint.MaxValue);
            }
            else
            {
                Class355.smethod_2(border, A_2, false);
            }
        }
        else
        {
            A_2.Write((uint) 0);
        }
    }

    internal static void smethod_4(Class345 A_0, SprmCode A_1, CellAlign A_2, object A_3)
    {
        smethod_5(A_0, A_1, 0, 1, A_2, A_3);
    }

    internal static void smethod_5(Class345 A_0, SprmCode A_1, int A_2, int A_3, CellAlign A_4, object A_5)
    {
        if ((A_5 != null) && (float.Parse(A_5.ToString()) >= 0f))
        {
            A_0.method_5(A_1);
            A_0.Write((byte) 6);
            A_0.Write((byte) A_2);
            A_0.Write((byte) A_3);
            A_0.Write((byte) A_4);
            A_0.Write((byte) 3);
            int num2 = (int) Math.Round((double) (float.Parse(A_5.ToString()) * 20f));
            A_0.Write((short) num2);
        }
    }
}

