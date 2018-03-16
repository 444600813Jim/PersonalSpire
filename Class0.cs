using Spire.Doc.Fields.Shape;
using System;
using System.IO;

internal class Class0 : SortedIntegerList
{
    internal void method_2(Class379 A_0)
    {
        base.Add(A_0.method_0(), A_0);
    }

    internal void method_3(int A_0, int A_1)
    {
        this.method_2(new Class387(A_0, A_1));
    }

    internal void method_4(int A_0, string A_1)
    {
        this.method_2(new Class386(A_0, A_1));
    }

    internal void method_5(BinaryReader A_0, int A_1, Interface57 A_2)
    {
        for (int i = 0; i < A_1; i++)
        {
            Class379 class2;
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
                        class2 = smethod_0(num2, num9, A_2);
                        goto Label_00A6;
                    }
                }
                int num6 = num3;
                class2 = smethod_1(num2, num6, A_2);
            }
            else
            {
                class2 = new Class387(num2, num3);
            }
        Label_00A6:
            if (class2 != null)
            {
                this.method_2(class2);
            }
        }
        for (int j = 0; j < base.Count; j++)
        {
            Class379 byIndex = (Class379) base.GetByIndex(j);
            if (byIndex.vmethod_0())
            {
                ((Class380) byIndex).vmethod_2(A_0);
            }
        }
    }

    internal int method_6(BinaryWriter A_0)
    {
        int position = (int) A_0.BaseStream.Position;
        for (int i = 0; i < base.Count; i++)
        {
            Class379 byIndex = (Class379) base.GetByIndex(i);
            int num4 = byIndex.method_0();
            if (smethod_2(byIndex.method_0()))
            {
                num4 |= 0x4000;
            }
            if (byIndex.vmethod_0())
            {
                num4 |= 0x8000;
            }
            A_0.Write((short) num4);
            A_0.Write(byIndex.vmethod_0() ? ((Class380) byIndex).method_1() : byIndex.vmethod_1());
        }
        for (int j = 0; j < base.Count; j++)
        {
            Class379 class3 = (Class379) base.GetByIndex(j);
            if (class3.vmethod_0())
            {
                ((Class380) class3).vmethod_3(A_0);
            }
        }
        return (((int) A_0.BaseStream.Position) - position);
    }

    private static Class379 smethod_0(int A_0, int A_1, Interface57 A_2)
    {
        int num = A_0 & -64;
        int num3 = A_0 + (num - 0x1c0);
        if (num3 == 0x1c6)
        {
            return new Class386(A_0, A_1);
        }
        if (num3 != 0x1cf)
        {
            return new Class384(A_0, A_1);
        }
        return new Class383(A_0, A_1);
    }

    private static Class379 smethod_1(int A_0, int A_1, Interface57 A_2)
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
                    return new Class382(A_0, A_1);

                case 0x383:
                    goto Label_0194;

                case 780:
                    return new Class381(A_0, A_1);
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
                    return new Class386(A_0, A_1);

                case 0x700:
                    return new Class385(A_0, A_1);

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
        return new Class384(A_0, A_1);
    Label_0138:
        return new Class386(A_0, A_1);
    Label_0194:
        return new Class383(A_0, A_1);
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

