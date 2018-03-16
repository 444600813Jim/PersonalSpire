using Spire.Doc.Fields.Shape.Ps;
using System;
using System.Drawing;

internal class Class952
{
    private BorderConnectionType borderConnectionType_0;
    private Class1031 class1031_0;
    private Class1031 class1031_1;
    private Class952 class952_0;
    private Class952 class952_1;
    private Class952 class952_2;
    private Class952 class952_3;
    private ConnectedBorders connectedBorders_0;
    private PointF pointF_0 = PointF.Empty;

    internal void method_0()
    {
        bool flag2;
        this.connectedBorders_0 = ConnectedBorders.None;
        bool flag = false;
        if (this.method_7().method_38(this.method_10(), out flag2))
        {
            this.connectedBorders_0 |= ConnectedBorders.Left;
            this.connectedBorders_0 |= ConnectedBorders.Top;
            flag = flag2;
        }
        if (this.method_10().method_38(this.method_9(), out flag2))
        {
            this.connectedBorders_0 |= ConnectedBorders.Top;
            this.connectedBorders_0 |= ConnectedBorders.Right;
            flag = flag2;
        }
        if (this.method_9().method_38(this.method_12(), out flag2))
        {
            this.connectedBorders_0 |= ConnectedBorders.Right;
            this.connectedBorders_0 |= ConnectedBorders.Bottom;
            flag = flag2;
        }
        if (this.method_12().method_38(this.method_7(), out flag2))
        {
            this.connectedBorders_0 |= ConnectedBorders.Bottom;
            this.connectedBorders_0 |= ConnectedBorders.Left;
            flag = flag2;
        }
        if (this.connectedBorders_0 != ConnectedBorders.None)
        {
            this.borderConnectionType_0 = flag ? BorderConnectionType.LineStyleMirror : BorderConnectionType.Regular;
        }
        else if (this.method_7().method_36(this.method_9()))
        {
            this.borderConnectionType_0 = BorderConnectionType.HorizontalContinue;
        }
        else if (this.method_10().method_36(this.method_12()))
        {
            this.borderConnectionType_0 = BorderConnectionType.VerticalContinue;
        }
        else
        {
            this.borderConnectionType_0 = BorderConnectionType.None;
        }
    }

    internal PointF method_1()
    {
        return this.pointF_0;
    }

    internal Class1031 method_10()
    {
        if (this.method_5())
        {
            return Class1031.class1031_0;
        }
        return this.class1031_1;
    }

    internal void method_11(Class1031 A_0)
    {
        this.class1031_1 = A_0;
    }

    internal Class1031 method_12()
    {
        if (this.method_6())
        {
            return Class1031.class1031_0;
        }
        return this.class952_3.method_10();
    }

    internal Class952 method_13()
    {
        return this.class952_0;
    }

    internal void method_14(Class952 A_0)
    {
        this.class952_0 = A_0;
    }

    internal Class952 method_15()
    {
        return this.class952_1;
    }

    internal void method_16(Class952 A_0)
    {
        this.class952_1 = A_0;
    }

    internal Class952 method_17()
    {
        return this.class952_2;
    }

    internal void method_18(Class952 A_0)
    {
        this.class952_2 = A_0;
    }

    internal Class952 method_19()
    {
        return this.class952_3;
    }

    internal void method_2(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    internal void method_20(Class952 A_0)
    {
        this.class952_3 = A_0;
    }

    internal bool method_21()
    {
        return (this.borderConnectionType_0 == BorderConnectionType.LineStyleMirror);
    }

    internal bool method_22()
    {
        return (this.borderConnectionType_0 == BorderConnectionType.HorizontalContinue);
    }

    internal bool method_23()
    {
        return (this.borderConnectionType_0 == BorderConnectionType.VerticalContinue);
    }

    internal bool method_24()
    {
        if (this.borderConnectionType_0 != BorderConnectionType.Regular)
        {
            return (this.borderConnectionType_0 == BorderConnectionType.LineStyleMirror);
        }
        return true;
    }

    internal int method_25()
    {
        if (!this.method_24())
        {
            return 0;
        }
        int num = 0;
        if (this.method_26())
        {
            num++;
        }
        if (this.method_27())
        {
            num++;
        }
        if (this.method_28())
        {
            num++;
        }
        if (this.method_29())
        {
            num++;
        }
        return num;
    }

    internal bool method_26()
    {
        return ((this.connectedBorders_0 & ConnectedBorders.Left) != ConnectedBorders.None);
    }

    internal bool method_27()
    {
        return ((this.connectedBorders_0 & ConnectedBorders.Right) != ConnectedBorders.None);
    }

    internal bool method_28()
    {
        return ((this.connectedBorders_0 & ConnectedBorders.Top) != ConnectedBorders.None);
    }

    internal bool method_29()
    {
        return ((this.connectedBorders_0 & ConnectedBorders.Bottom) != ConnectedBorders.None);
    }

    internal bool method_3()
    {
        return (this.class952_0 == null);
    }

    internal void method_30(float A_0, float A_1)
    {
        this.pointF_0 = new PointF(this.pointF_0.X + A_0, this.pointF_0.Y + A_1);
    }

    internal Class952 method_31(float A_0)
    {
        Class952 class2 = this.method_15();
        if ((this.method_1().X >= A_0) || (!this.method_4() && (A_0 >= class2.method_1().X)))
        {
            return null;
        }
        Class952 class3 = new Class952();
        class3.method_2(new PointF(A_0, this.method_1().Y));
        this.method_16(class3);
        class3.method_14(this);
        if (class2 != null)
        {
            class3.method_16(class2);
            class2.method_14(class3);
        }
        return class3;
    }

    internal Class952 method_32(float A_0)
    {
        if (!this.method_3())
        {
            return this.method_13().method_31(A_0);
        }
        if (A_0 >= this.method_1().X)
        {
            return null;
        }
        Class952 class2 = new Class952();
        class2.method_2(new PointF(A_0, this.method_1().Y));
        this.method_14(class2);
        class2.method_16(this);
        return class2;
    }

    internal Class952 method_33()
    {
        Class952 class3;
        Class952 class2 = this;
        do
        {
            class3 = class2;
            class2 = class2.method_13();
        }
        while (class2 != null);
        return class3;
    }

    internal bool method_4()
    {
        return (this.class952_1 == null);
    }

    internal bool method_5()
    {
        return (this.class952_2 == null);
    }

    internal bool method_6()
    {
        return (this.class952_3 == null);
    }

    internal Class1031 method_7()
    {
        if (this.method_3())
        {
            return Class1031.class1031_0;
        }
        return this.class1031_0;
    }

    internal void method_8(Class1031 A_0)
    {
        this.class1031_0 = A_0;
    }

    internal Class1031 method_9()
    {
        if (this.method_4())
        {
            return Class1031.class1031_0;
        }
        return this.class952_1.method_7();
    }
}

