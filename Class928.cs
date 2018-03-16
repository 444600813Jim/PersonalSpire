using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;

internal class Class928
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ArrayList arrayList_1 = new ArrayList();
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_2;
    internal Class1089 class1089_0 = new Class1089();
    internal Class1089 class1089_1 = new Class1089();
    internal Class181 class181_0 = new Class181();
    internal Class181 class181_1 = new Class181();
    internal Class181 class181_2 = new Class181();
    internal Class253 class253_0;
    internal Class335 class335_0 = new Class335();
    internal Document document_0;
    internal Hashtable hashtable_0 = new Hashtable();
    internal Interface34 interface34_0;
    internal Stream stream_0;
    internal string string_0;

    internal Class928(Document A_0, Stream A_1, string A_2, Class253 A_3)
    {
        this.document_0 = A_0;
        this.stream_0 = A_1;
        this.string_0 = A_2;
        this.class253_0 = A_3;
    }

    internal FileFormat method_0()
    {
        return this.class253_0.vmethod_1();
    }

    internal bool method_1()
    {
        return (this.class1089_1.Count > 0);
    }

    internal void method_2(ShapeBase A_0, bool A_1)
    {
        if (A_0.IsTopLevel)
        {
            this.method_3(A_1).Add(A_0);
        }
    }

    private ArrayList method_3(bool A_0)
    {
        if (!A_0)
        {
            return this.arrayList_0;
        }
        return this.arrayList_1;
    }

    internal void method_4()
    {
        smethod_0(this.arrayList_0);
        smethod_0(this.arrayList_1);
    }

    internal void method_5()
    {
        smethod_1(this.arrayList_0);
        smethod_1(this.arrayList_1);
    }

    internal void method_6()
    {
        smethod_2(this.arrayList_0);
        smethod_2(this.arrayList_1);
    }

    internal bool method_7()
    {
        return false;
    }

    internal bool method_8()
    {
        if ((this.method_0() != FileFormat.Docm) && (this.method_0() != FileFormat.Dotx))
        {
            return (this.method_0() == FileFormat.Dotm);
        }
        return true;
    }

    private static void smethod_0(ArrayList A_0)
    {
        if (A_0.Count != 0)
        {
            A_0.Sort(new Class823());
            int num2 = 1;
            int num = 0;
            foreach (ShapeBase base3 in A_0)
            {
                if (!base3.IsInline)
                {
                    if (!base3.BehindText)
                    {
                        base3.TempZIndex = num2++;
                    }
                    else
                    {
                        num++;
                    }
                }
            }
            num2 = -num;
            foreach (ShapeBase base2 in A_0)
            {
                if (!base2.IsInline && base2.BehindText)
                {
                    base2.TempZIndex = num2++;
                }
            }
        }
    }

    private static void smethod_1(ArrayList A_0)
    {
        if (A_0.Count != 0)
        {
            A_0.Sort(new Class823());
            int num = 0;
            foreach (ShapeBase base3 in A_0)
            {
                if (!base3.IsInline && !base3.BehindText)
                {
                    base3.TempZIndex = 0xf000000 + num;
                    num += 0x400;
                }
            }
            num = 0;
            foreach (ShapeBase base2 in A_0)
            {
                if (!base2.IsInline && base2.BehindText)
                {
                    base2.TempZIndex = -251658240 + num;
                    num += 0x400;
                }
            }
        }
    }

    private static void smethod_2(ArrayList A_0)
    {
        if (A_0.Count != 0)
        {
            A_0.Sort(new Class823());
            int num = 0;
            foreach (ShapeBase base2 in A_0)
            {
                if (!base2.IsInline || base2.IsPseudoInline)
                {
                    base2.TempZIndex = num++;
                }
            }
        }
    }
}

