using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;

internal class Class1124
{
    internal double double_0;
    internal double double_1;
    internal double double_2;
    internal double double_3;

    internal Class1124(double A_0, double A_1, double A_2, double A_3)
    {
        this.double_0 = A_0;
        this.double_1 = A_1;
        this.double_2 = A_2;
        this.double_3 = A_3;
    }

    internal void method_0()
    {
        this.double_0 += (this.double_2 - this.double_3) / 2.0;
        this.double_1 += (this.double_3 - this.double_2) / 2.0;
        double num = this.double_2;
        this.double_2 = this.double_3;
        this.double_3 = num;
    }

    internal static bool smethod_0(double A_0)
    {
        int num = 5;
        A_0 = A_0 % 360.0;
        if (A_0 < 0.0)
        {
            A_0 += 360.0;
        }
        if ((A_0 < 0.0) || (A_0 >= 45.0))
        {
            if ((A_0 >= 45.0) && (A_0 < 135.0))
            {
                return true;
            }
            if ((A_0 >= 135.0) && (A_0 < 225.0))
            {
                return false;
            }
            if ((A_0 >= 225.0) && (A_0 < 315.0))
            {
                return true;
            }
            if (A_0 < 315.0)
            {
                throw new InvalidOperationException(BookmarkStart.b("縪䌬䨮䤰䌲倴吶䴸帺夼Ἶ⁀ⵂ≄⭆ⱈ敊", num));
            }
        }
        return false;
    }

    internal static void smethod_1(ShapeBase A_0, double A_1, double A_2, double A_3, double A_4)
    {
        double num = A_1;
        if (A_1 > A_2)
        {
            A_1 = A_2;
            A_2 = num;
        }
        num = A_3;
        if (A_3 > A_4)
        {
            A_3 = A_4;
            A_4 = num;
        }
        smethod_2(A_0, Class969.smethod_33(A_1), Class969.smethod_33(A_3), Class969.smethod_33(A_2 - A_1), Class969.smethod_33(A_4 - A_3));
    }

    internal static void smethod_2(ShapeBase A_0, double A_1, double A_2, double A_3, double A_4)
    {
        Class1124 class2 = new Class1124(A_1, A_2, A_3, A_4);
        if (smethod_0(A_0.Rotation))
        {
            class2.method_0();
        }
        A_0.Left = class2.double_0;
        A_0.Top = class2.double_1;
        A_0.method_37(class2.double_2);
        A_0.method_39(class2.double_3);
    }

    internal static Class1124 smethod_3(ShapeBase A_0)
    {
        Class1124 class2 = new Class1124(A_0.Left, A_0.Top, A_0.Width, A_0.Height);
        if (smethod_0(A_0.Rotation))
        {
            class2.method_0();
        }
        return class2;
    }
}

