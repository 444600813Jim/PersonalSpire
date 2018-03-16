using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class481
{
    private readonly bool bool_0;
    private readonly bool bool_1;
    private readonly bool bool_2;
    private readonly Class137 class137_0 = new Class137();
    private readonly int int_0;
    private readonly RouteSlipOrder routeSlipOrder_0;
    private readonly RouteSlipProtectionType routeSlipProtectionType_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;

    internal Class481(Class703 A_0, BinaryReader A_1, int A_2)
    {
        if (A_0.class597_0.class1111_70.int_1 != 0)
        {
            long position = A_1.BaseStream.Position;
            A_1.BaseStream.Position = A_0.class597_0.class1111_70.int_0;
            this.bool_0 = A_1.ReadInt16() != 0;
            this.bool_1 = A_1.ReadInt16() != 0;
            this.bool_2 = A_1.ReadInt16() != 0;
            A_1.ReadInt16();
            this.routeSlipProtectionType_0 = (RouteSlipProtectionType) A_1.ReadInt16();
            this.int_0 = A_1.ReadInt16();
            this.routeSlipOrder_0 = (RouteSlipOrder) A_1.ReadInt16();
            int num2 = A_1.ReadInt16();
            this.string_0 = Class813.smethod_17(A_1, A_2);
            this.string_1 = Class813.smethod_17(A_1, A_2);
            this.string_2 = Class813.smethod_17(A_1, A_2);
            this.string_3 = Class813.smethod_17(A_1, A_2);
            for (int i = 0; i < num2; i++)
            {
                this.class137_0.method_1(new Class138(A_1, A_2));
            }
            A_1.BaseStream.Position = position;
        }
    }

    internal int method_0(BinaryWriter A_0, int A_1)
    {
        long position = A_0.BaseStream.Position;
        A_0.Write(this.bool_0 ? ((short) 1) : ((short) 0));
        A_0.Write(this.bool_1 ? ((short) 1) : ((short) 0));
        A_0.Write(this.bool_2 ? ((short) 1) : ((short) 0));
        A_0.Write((short) 0);
        A_0.Write((short) this.routeSlipProtectionType_0);
        A_0.Write((short) this.int_0);
        A_0.Write((short) this.routeSlipOrder_0);
        A_0.Write((short) this.method_15().method_2());
        Class813.smethod_20(A_0, this.string_0, A_1, true);
        Class813.smethod_20(A_0, this.string_1, A_1, true);
        Class813.smethod_20(A_0, this.string_2, A_1, true);
        Class813.smethod_20(A_0, this.string_3, A_1, true);
        for (int i = 0; i < this.method_15().method_2(); i++)
        {
            this.method_15().method_0(i).method_0(A_0, A_1);
        }
        return (int) (A_0.BaseStream.Position - position);
    }

    internal bool method_1()
    {
        return this.bool_0;
    }

    internal string method_10()
    {
        return this.string_3;
    }

    internal void method_11(string A_0)
    {
        this.string_3 = smethod_0(A_0);
    }

    internal RouteSlipProtectionType method_12()
    {
        return this.routeSlipProtectionType_0;
    }

    internal RouteSlipOrder method_13()
    {
        return this.routeSlipOrder_0;
    }

    internal int method_14()
    {
        return this.int_0;
    }

    internal Class137 method_15()
    {
        return this.class137_0;
    }

    internal bool method_2()
    {
        return this.bool_1;
    }

    internal bool method_3()
    {
        return this.bool_2;
    }

    internal string method_4()
    {
        return this.string_0;
    }

    internal void method_5(string A_0)
    {
        this.string_0 = smethod_0(A_0);
    }

    internal string method_6()
    {
        return this.string_1;
    }

    internal void method_7(string A_0)
    {
        this.string_1 = smethod_0(A_0);
    }

    internal string method_8()
    {
        return this.string_2;
    }

    internal void method_9(string A_0)
    {
        this.string_2 = smethod_0(A_0);
    }

    private static string smethod_0(string A_0)
    {
        int num = 14;
        if (A_0.Length > 0xff)
        {
            throw new InvalidOperationException(BookmarkStart.b("怳匵䀷丹᰻刽┿ⱁ⍃㉅⁇橉⅋㭍⍏♑瑓㑕㵗穙せ㭝፟ᅡ䑣ብg୩ɫ乭䉯䝱䉳塵", num));
        }
        return A_0;
    }
}

