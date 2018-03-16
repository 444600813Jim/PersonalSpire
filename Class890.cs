using Spire.Doc.Fields;
using System;
using System.Drawing;

internal class Class890
{
    private float float_0;
    private float float_1;
    private float float_2;
    private float float_3;
    private float float_4;
    private float float_5;
    private float float_6;
    private float float_7;
    private PointF pointF_0;
    private PointF pointF_1;

    internal Class890(Class672 A_0)
    {
        ShapeObject obj2 = A_0.method_28();
        this.float_0 = (float) Class969.smethod_42(obj2.ExtrusionForeDepth);
        this.float_1 = (float) Class969.smethod_42(obj2.ExtrusionBackDepth);
        this.float_2 = (float) Class969.smethod_68(obj2.ExtrusionSkewAngle);
        SizeF ef = A_0.method_32();
        this.pointF_0 = new PointF((ef.Width / 2f) + (ef.Width * ((float) Class969.smethod_68(obj2.ViewpointOriginX))), (ef.Height / 2f) + (ef.Height * ((float) Class969.smethod_68(obj2.ViewpointOriginY))));
        this.float_3 = (float) Class969.smethod_42(obj2.ViewpointX);
        this.float_4 = (float) Class969.smethod_42(obj2.ViewpointY);
        this.float_5 = (float) Class969.smethod_42(obj2.ViewpointZ);
        this.float_6 = (float) Class969.smethod_68(-obj2.TDRotationAngleX);
        this.float_7 = (float) Class969.smethod_68(obj2.TDRotationAngleY);
        this.pointF_1 = new PointF(ef.Width / 2f, ef.Height / 2f);
    }

    internal float method_0()
    {
        return this.float_0;
    }

    internal void method_1(float A_0)
    {
        this.float_0 = A_0;
    }

    internal float method_10()
    {
        return this.float_4;
    }

    internal void method_11(float A_0)
    {
        this.float_4 = A_0;
    }

    internal float method_12()
    {
        return this.float_5;
    }

    internal void method_13(float A_0)
    {
        this.float_5 = A_0;
    }

    internal float method_14()
    {
        return this.float_6;
    }

    internal void method_15(float A_0)
    {
        this.float_6 = A_0;
    }

    internal float method_16()
    {
        return this.float_7;
    }

    internal void method_17(float A_0)
    {
        this.float_7 = A_0;
    }

    internal PointF method_18()
    {
        return this.pointF_1;
    }

    internal void method_19(PointF A_0)
    {
        this.pointF_1 = A_0;
    }

    internal float method_2()
    {
        return this.float_1;
    }

    internal void method_3(float A_0)
    {
        this.float_1 = A_0;
    }

    internal float method_4()
    {
        return this.float_2;
    }

    internal void method_5(float A_0)
    {
        this.float_2 = A_0;
    }

    internal PointF method_6()
    {
        return this.pointF_0;
    }

    internal void method_7(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    internal float method_8()
    {
        return this.float_3;
    }

    internal void method_9(float A_0)
    {
        this.float_3 = A_0;
    }
}

