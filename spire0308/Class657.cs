using System;
using System.IO;

internal class Class657 : Class656
{
    internal void method_23(Class171 A_0)
    {
        base.method_5(A_0.method_0(), A_0);
    }

    internal void method_24(int A_0, int A_1)
    {
        this.method_23(new Class179(A_0, A_1));
    }

    internal void method_25(int A_0, string A_1)
    {
        this.method_23(new Class175(A_0, A_1));
    }

    internal void method_26(BinaryReader A_0, int A_1)
    {
        for (int i = 0; i < A_1; i++)
        {
            Class171 class2;
            int num7 = A_0.ReadUInt16();
            int num2 = num7 & 0x3fff;
            bool flag = (num7 & 0x8000) != 0;
            int num3 = A_0.ReadInt32();
            if (flag)
            {
                switch ((num2 & -64))
                {
                    case 0x1c0:
                    case 0x540:
                    case 0x580:
                    case 0x5c0:
                    case 0x600:
                    case 0x640:
                    {
                        int num9 = num3;
                        class2 = smethod_0(num2, num9);
                        goto Label_00A4;
                    }
                }
                int num6 = num3;
                class2 = smethod_1(num2, num6);
            }
            else
            {
                class2 = new Class179(num2, num3);
            }
        Label_00A4:
            if (class2 != null)
            {
                this.method_23(class2);
            }
        }
        for (int j = 0; j < base.method_2(); j++)
        {
            Class171 class3 = (Class171) base.method_12(j);
            if (class3.vmethod_0())
            {
                ((Class172) class3).vmethod_2(A_0);
            }
        }
    }

    internal int method_27(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        for (int i = 0; i < base.method_2(); i++)
        {
            Class171 class2 = (Class171) base.method_12(i);
            int num4 = class2.method_0();
            if (smethod_2(class2.method_0()))
            {
                num4 |= 0x4000;
            }
            if (class2.vmethod_0())
            {
                num4 |= 0x8000;
            }
            A_0.Write((short) num4);
            A_0.Write(class2.vmethod_0() ? ((Class172) class2).method_1() : class2.vmethod_1());
        }
        for (int j = 0; j < base.method_2(); j++)
        {
            Class171 class3 = (Class171) base.method_12(j);
            if (class3.vmethod_0())
            {
                ((Class172) class3).vmethod_3(A_0);
            }
        }
        return (((int) A_0.BaseStream.Position) - position);
    }

    private static Class171 smethod_0(int A_0, int A_1)
    {
        int num = A_0 & -64;
        int num3 = A_0 + (num - 0x1c0);
        if (num3 == 0x1c6)
        {
            return new Class175(A_0, A_1);
        }
        if (num3 != 0x1cf)
        {
            return new Class178(A_0, A_1);
        }
        return new Class173(A_0, A_1);
    }

    private static Class171 smethod_1(int A_0, int A_1)
    {
        int num = A_0;
        if (num <= 0x197)
        {
            switch (num)
            {
                case 0x105:
                case 0x110:
                case 0xc0:
                case 0xc5:
                case 0x187:
                    goto Label_0138;

                case 0x145:
                case 0x146:
                case 0x151:
                case 0x152:
                case 0x155:
                case 0x156:
                case 0x157:
                case 0x197:
                    goto Label_0194;
            }
        }
        else if (num <= 0x397)
        {
            switch (num)
            {
                case 0x38d:
                case 910:
                case 0x397:
                case 0x380:
                case 0x381:
                    goto Label_0138;

                case 0x382:
                    return new Class177(A_0, A_1);

                case 0x383:
                    goto Label_0194;

                case 780:
                    return new Class174(A_0, A_1);
            }
        }
        else if (num > 0x504)
        {
            switch (num)
            {
                case 0x781:
                case 0x782:
                case 0x783:
                case 0x784:
                case 0x785:
                case 0x786:
                case 0x787:
                case 0x788:
                    return new Class175(A_0, A_1);

                case 0x700:
                    return new Class176(A_0, A_1);

                case 0x508:
                    goto Label_0194;
            }
        }
        else
        {
            switch (num)
            {
                case 0x39a:
                    goto Label_0138;

                case 0x504:
                    goto Label_0194;
            }
        }
        return new Class178(A_0, A_1);
    Label_0138:
        return new Class175(A_0, A_1);
    Label_0194:
        return new Class173(A_0, A_1);
    }

    private static bool smethod_2(int A_0)
    {
        switch (A_0)
        {
            case 260:
            case 0x105:
            case 390:
            case 0x187:
            case 0x1c5:
            case 0x1c6:
                return true;
        }
        return false;
    }
}

