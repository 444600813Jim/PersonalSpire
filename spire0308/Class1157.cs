using Spire.CompoundFile.Doc.Net;
using System;

internal class Class1157
{
    private bool bool_0;
    private Class1157 class1157_0;
    private Class1157 class1157_1;
    private Class1157 class1157_2;
    private NodeColor nodeColor_0;
    private object object_0;
    private object object_1;

    public Class1157(Class1157 A_0, Class1157 A_1, Class1157 A_2, object A_3, object A_4) : this(A_0, A_1, A_2, A_3, A_4, NodeColor.Red)
    {
    }

    public Class1157(Class1157 A_0, Class1157 A_1, Class1157 A_2, object A_3, object A_4, NodeColor A_5)
    {
        this.class1157_0 = A_0;
        this.class1157_2 = A_1;
        this.class1157_1 = A_2;
        this.object_0 = A_3;
        this.object_1 = A_4;
        this.nodeColor_0 = A_5;
    }

    public Class1157 method_0()
    {
        return this.class1157_0;
    }

    public void method_1(Class1157 A_0)
    {
        this.class1157_0 = A_0;
    }

    public object method_10()
    {
        return this.object_0;
    }

    public void method_11(object A_0)
    {
        this.object_0 = A_0;
    }

    public object method_12()
    {
        return this.object_1;
    }

    public void method_13(object A_0)
    {
        this.object_1 = A_0;
    }

    public bool method_14()
    {
        return (this.method_6() == NodeColor.Red);
    }

    public bool method_15()
    {
        return (this.method_6() == NodeColor.Black);
    }

    public Class1157 method_2()
    {
        return this.class1157_1;
    }

    public void method_3(Class1157 A_0)
    {
        this.class1157_1 = A_0;
    }

    public Class1157 method_4()
    {
        return this.class1157_2;
    }

    public void method_5(Class1157 A_0)
    {
        this.class1157_2 = A_0;
    }

    public NodeColor method_6()
    {
        return this.nodeColor_0;
    }

    public void method_7(NodeColor A_0)
    {
        this.nodeColor_0 = A_0;
    }

    public bool method_8()
    {
        return this.bool_0;
    }

    public void method_9(bool A_0)
    {
        this.bool_0 = A_0;
    }
}

