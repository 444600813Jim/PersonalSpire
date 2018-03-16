using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Tables;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class592
{
    private static readonly IComparer icomparer_0 = new Class984();

    private Class592()
    {
    }

    internal static void smethod_0(Class732 A_0, int A_1, SprmCode A_2, Interface53 A_3)
    {
        smethod_5(smethod_6(A_0, A_1), A_2, A_3, null);
    }

    internal static void smethod_1(WordAttrCollection A_0, SprmCode A_1, Interface53 A_2)
    {
        smethod_2(A_0, A_1, A_2, icomparer_0);
    }

    internal static void smethod_2(WordAttrCollection A_0, SprmCode A_1, Interface53 A_2, IComparer A_3)
    {
        Hashtable hashtable = smethod_8(A_0, A_1, A_2);
        ArrayList list = new ArrayList();
        foreach (object obj2 in hashtable.Keys)
        {
            CellAlign align = (CellAlign) hashtable[obj2];
            list.Add(new Class127(0, 0, align, obj2));
        }
        smethod_5(list, A_1, A_2, A_3);
    }

    internal static void smethod_3(Class732 A_0, SprmCode A_1, Interface53 A_2)
    {
        smethod_4(A_0, A_1, A_2, icomparer_0);
    }

    internal static void smethod_4(Class732 A_0, SprmCode A_1, Interface53 A_2, IComparer A_3)
    {
        ArrayList list = new ArrayList();
        CellAlign none = CellAlign.None;
        for (int i = 0; i < A_0.Count; i++)
        {
            Hashtable hashtable = smethod_8(A_0.method_0(i), A_1, A_2);
            Class656 class2 = new Class656();
            foreach (object obj2 in hashtable.Keys)
            {
                CellAlign align3 = (CellAlign) hashtable[obj2];
                class2.method_5((int) align3, obj2);
                none |= align3;
            }
            list.Add(class2);
        }
        ArrayList list2 = new ArrayList();
        for (CellAlign align2 = CellAlign.None; align2 <= none; align2 += 1)
        {
            list2.AddRange(smethod_6(list, (int) align2));
        }
        smethod_5(list2, A_1, A_2, A_3);
    }

    private static void smethod_5(ArrayList A_0, SprmCode A_1, Interface53 A_2, IComparer A_3)
    {
        if (A_3 != null)
        {
            A_0.Sort(A_3);
        }
        foreach (Class127 class2 in A_0)
        {
            A_2.imethod_2(A_1, class2.method_0(), class2.method_1(), class2.method_2(), class2.method_3());
        }
    }

    private static ArrayList smethod_6(ArrayList A_0, int A_1)
    {
        ArrayList list = new ArrayList();
        object objA = smethod_7(A_0[0]).method_3(A_1);
        if ((A_1 == 0xbc2) && ((A_0[0] as CellFormat).TwipCellWidth != 0))
        {
            objA = ((float) (A_0[0] as CellFormat).TwipCellWidth) / 20f;
        }
        int num2 = 0;
        for (int i = 1; i < A_0.Count; i++)
        {
            object objB = smethod_7(A_0[i]).method_3(A_1);
            if ((A_1 == 0xbc2) && ((A_0[i] as CellFormat).TwipCellWidth != 0))
            {
                objB = ((float) (A_0[i] as CellFormat).TwipCellWidth) / 20f;
            }
            if (!object.Equals(objA, objB))
            {
                if (objA != null)
                {
                    list.Add(new Class127(num2, i, (CellAlign) A_1, objA));
                }
                objA = objB;
                num2 = i;
            }
        }
        if (objA != null)
        {
            list.Add(new Class127(num2, A_0.Count, (CellAlign) A_1, objA));
        }
        return list;
    }

    private static Class656 smethod_7(object A_0)
    {
        Class656 class2 = new Class656();
        if (A_0 is CellFormat)
        {
            CellFormat format = A_0 as CellFormat;
            class2.method_5(6, format.CellScaling);
            class2.method_5(0xbc6, (WidthType) format.WidthUnit);
            class2.method_5(0xbc4, format.CellWidth);
            class2.method_5(0xbe0, format.HorizontalMerge);
            class2.method_5(0xbd6, format.VerticalMerge);
            class2.method_5(1, format.Borders);
            class2.method_5(0xc62, format.Shading);
            class2.method_5(2, format.Paddings);
            class2.method_5(0xc6c, format.TextWrap);
            class2.method_5(0xc94, format.HideMark);
            class2.method_5(0xc76, format.FitText);
            class2.method_5(0xbea, format.TextDirection);
            class2.method_5(0xbf4, format.VerticalAlignment);
            class2.method_5(0x271a, format.FormatRevision);
            return class2;
        }
        return (A_0 as Class656);
    }

    private static Hashtable smethod_8(WordAttrCollection A_0, SprmCode A_1, Interface53 A_2)
    {
        Hashtable hashtable = new Hashtable();
        smethod_9(hashtable, A_0, A_1, CellAlign.Left, A_2);
        smethod_9(hashtable, A_0, A_1, CellAlign.Right, A_2);
        smethod_9(hashtable, A_0, A_1, CellAlign.Top, A_2);
        smethod_9(hashtable, A_0, A_1, CellAlign.Bottom, A_2);
        return hashtable;
    }

    private static void smethod_9(Hashtable A_0, WordAttrCollection A_1, SprmCode A_2, CellAlign A_3, Interface53 A_4)
    {
        int num = A_4.imethod_1(A_2, A_3);
        object obj2 = A_1.method_31(num);
        if ((A_1 is CellFormat) && (A_1 as CellFormat).SamePaddingsAsTable)
        {
            switch (num)
            {
                case 0xc12:
                case 0xc1c:
                case 0xbfe:
                case 0xc08:
                    obj2 = null;
                    break;
            }
        }
        if (obj2 != null)
        {
            if (A_0[obj2] != null)
            {
                A_3 |= (CellAlign) A_0[obj2];
            }
            A_0[obj2] = A_3;
        }
    }
}

