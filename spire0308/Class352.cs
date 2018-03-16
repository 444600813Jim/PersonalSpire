using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;

internal class Class352
{
    internal static bool bool_0;
    private Class1063 class1063_0;
    private Class274 class274_0;
    private readonly Document document_0;
    private readonly Hashtable hashtable_0 = new Hashtable();
    private readonly Hashtable hashtable_1 = new Hashtable();
    private readonly Hashtable hashtable_2 = new Hashtable();
    private const int int_0 = 0x400;
    private ShapeObject shapeObject_0;

    internal Class352(Document A_0)
    {
        this.document_0 = A_0;
    }

    internal ShapeBase method_0(int A_0, EscherDrawingType A_1)
    {
        return (ShapeBase) this.method_11(A_1)[A_0];
    }

    internal void method_1(int A_0, EscherDrawingType A_1)
    {
        this.method_11(A_1).Remove(A_0);
    }

    private void method_10(Class276 A_0)
    {
        int num = 14;
        Class658 class2 = new Class658(this.document_0, this.class274_0.method_14(), A_0.method_13());
        Class931 class3 = new Class931(class2);
        Hashtable hashtable = this.method_11(A_0.method_14());
        for (int i = 0; i < A_0.method_8(); i++)
        {
            Class266 class4 = A_0.method_9(i);
            switch (class4.method_3().method_8())
            {
                case EscherRecordType.ShapeGroupContainer:
                {
                    Class277 class6 = (Class277) class4;
                    if (class6.method_11().method_10() && !class6.method_11().method_12())
                    {
                        smethod_1(class6, class3, hashtable);
                    }
                    break;
                }
                case EscherRecordType.ShapeContainer:
                {
                    Class273 class5 = (Class273) class4;
                    if (class5.method_11().method_24() && !class5.method_11().method_12())
                    {
                        this.shapeObject_0 = class3.method_4(class5);
                    }
                    break;
                }
                case EscherRecordType.SolverContainer:
                case EscherRecordType.Dg:
                case EscherRecordType.RegroupItems:
                    break;

                case EscherRecordType.Dgg:
                case EscherRecordType.Bse:
                    goto Label_00FF;

                default:
                    goto Label_00FF;
            }
        }
        return;
    Label_00FF:
        throw new InvalidOperationException(BookmarkStart.b("愳堵匷吹医䤽⸿扁㙃⍅⭇╉㹋⩍灏♑ⵓ♕㵗穙㕛そ䁟͡੣䙥ⵧᥩཫ٭ᕯqᝳṵᵷࡹ屻᩽ꊋ", num));
    }

    private Hashtable method_11(EscherDrawingType A_0)
    {
        int num = 0x12;
        switch (A_0)
        {
            case EscherDrawingType.Main:
                return this.hashtable_0;

            case EscherDrawingType.Header:
                return this.hashtable_1;
        }
        throw new InvalidOperationException(BookmarkStart.b("洷吹夻䘽〿❁❃㉅ⵇ⹉汋⩍≏㍑⍓㽕㙗㵙籛⩝ᥟቡţ䡥", num));
    }

    internal ShapeObject method_12()
    {
        return this.shapeObject_0;
    }

    internal void method_13(ShapeObject A_0)
    {
        this.shapeObject_0 = A_0;
    }

    internal Document method_14()
    {
        return this.document_0;
    }

    internal Class274 method_15()
    {
        return this.class274_0;
    }

    private bool method_16()
    {
        if ((this.shapeObject_0 == null) && (this.hashtable_0.Count <= 0))
        {
            return (this.hashtable_1.Count > 0);
        }
        return true;
    }

    internal void method_2(ShapeBase A_0, EscherDrawingType A_1)
    {
        this.method_11(A_1).Add(A_0.Id, A_0);
    }

    internal void method_3(BinaryReader A_0, int A_1, int A_2, BinaryReader A_3)
    {
        if (A_2 != 0)
        {
            A_0.BaseStream.Position = A_1;
            int num = A_1 + A_2;
            this.class274_0 = (Class274) Class1062.smethod_0(A_0);
            this.class274_0.method_11(A_3);
            if (this.class274_0.method_14() != null)
            {
                foreach (Class268 class4 in this.class274_0.method_14().method_7())
                {
                    if (class4.method_8() != null)
                    {
                        this.method_4(class4);
                    }
                }
            }
            this.class1063_0 = new Class1063();
            while (A_0.BaseStream.Position < num)
            {
                EscherDrawingType type = (EscherDrawingType) A_0.ReadByte();
                Class276 class3 = (Class276) Class1062.smethod_0(A_0);
                class3.method_15(type);
                this.class1063_0.Add(class3);
            }
            foreach (Class276 class2 in this.class1063_0)
            {
                this.method_10(class2);
            }
        }
    }

    internal void method_4(Class268 A_0)
    {
        this.hashtable_2[A_0.method_8().method_4()] = A_0;
    }

    internal Class268 method_5(Guid A_0)
    {
        return (Class268) this.hashtable_2[A_0];
    }

    internal int method_6(BinaryWriter A_0, BinaryWriter A_1, bool A_2)
    {
        if (!this.method_16())
        {
            return 0;
        }
        this.class274_0 = Class274.smethod_0();
        this.class1063_0 = new Class1063();
        this.method_7(EscherDrawingType.Main);
        if (A_2)
        {
            this.method_7(EscherDrawingType.Header);
        }
        this.class274_0.method_12(A_1);
        this.class274_0.method_13();
        this.method_8();
        return this.method_9(A_0);
    }

    private void method_7(EscherDrawingType A_0)
    {
        Class276 class2 = Class276.smethod_0(A_0);
        Class278 class3 = new Class278();
        Class658 class4 = new Class658(this.document_0, this.class274_0.method_14(), class3);
        Class931 class5 = new Class931(class4);
        ShapeBase[] baseArray = smethod_0(this.method_11(A_0));
        Class277 class6 = class2.method_16();
        for (int i = 0; i < baseArray.Length; i++)
        {
            class6.method_7().Add(class5.method_1(baseArray[i], EscherShapeKind.Top));
        }
        if ((A_0 == EscherDrawingType.Main) && (this.shapeObject_0 != null))
        {
            Class273 class7 = class5.method_6(this.shapeObject_0, EscherShapeKind.Background);
            class2.method_7().Add(class7);
        }
        if (class3.method_8() > 0)
        {
            class2.method_7().Add(class3);
        }
        this.class1063_0.Add(class2);
    }

    private void method_8()
    {
        Class284 class2 = this.class274_0.method_15();
        class2.method_10().Clear();
        int num = 0;
        foreach (Class276 class3 in this.class1063_0)
        {
            int num3;
            class3.method_16().method_11().method_5((class2.method_10().Count + 1) * 0x400);
            class3.method_11();
            for (int i = (class3.method_12().method_8() - class3.method_16().method_11().method_4()) + 1; i > 0; i -= num3)
            {
                num3 = Math.Min(i, 0x400);
                class2.method_10().Add(new Class1151(class3.method_12().method_4(), num3));
            }
            num += class3.method_12().method_6();
            class2.method_9(class2.method_8() + 1);
        }
        class2.method_7(num);
        class2.method_5(((class2.method_10().Count + 1) * 0x400) + 2);
    }

    private int method_9(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        this.class274_0.method_2(A_0);
        foreach (Class276 class2 in this.class1063_0)
        {
            A_0.Write((byte) class2.method_14());
            class2.method_2(A_0);
        }
        return (((int) A_0.BaseStream.Position) - position);
    }

    private static ShapeBase[] smethod_0(Hashtable A_0)
    {
        int index = 0;
        ShapeBase[] array = new ShapeBase[A_0.Count];
        foreach (ShapeBase base2 in A_0.Values)
        {
            array[index] = base2;
            index++;
        }
        Array.Sort(array, new Class823());
        return array;
    }

    private static void smethod_1(Class277 A_0, Class931 A_1, Hashtable A_2)
    {
        for (int i = 1; i < A_0.method_8(); i++)
        {
            Class272 class2 = (Class272) A_0.method_9(i);
            ShapeBase base2 = A_1.method_0(class2);
            base2.ZOrder = i - 1;
            A_2[base2.Id] = base2;
        }
    }
}

