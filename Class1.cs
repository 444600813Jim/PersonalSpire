using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Interface;
using System;
using System.Drawing;

internal class Class1 : DocPicture
{
    private bool bool_20;
    private float float_27;
    private float float_28;
    private GroupedShapeOrigin groupedShapeOrigin_0;
    private GroupedShapeOrigin groupedShapeOrigin_1;

    public Class1(IDocumentObject A_0) : base((Document) A_0)
    {
    }

    public float method_111()
    {
        return this.float_28;
    }

    public void method_112(float A_0)
    {
        this.float_28 = A_0;
    }

    public GroupedShapeOrigin method_113()
    {
        return this.groupedShapeOrigin_0;
    }

    public void method_114(GroupedShapeOrigin A_0)
    {
        this.groupedShapeOrigin_0 = A_0;
    }

    public float method_115()
    {
        return this.float_27;
    }

    public void method_116(float A_0)
    {
        this.float_27 = A_0;
    }

    public GroupedShapeOrigin method_117()
    {
        return this.groupedShapeOrigin_1;
    }

    public void method_118(GroupedShapeOrigin A_0)
    {
        this.groupedShapeOrigin_1 = A_0;
    }

    internal bool method_119()
    {
        return this.bool_20;
    }

    internal void method_120(bool A_0)
    {
        this.bool_20 = A_0;
    }

    public float method_121()
    {
        return base.Width;
    }

    public void method_122(float A_0)
    {
        base.Width = A_0;
    }

    public float method_123()
    {
        return base.Height;
    }

    public void method_124(float A_0)
    {
        base.Height = A_0;
    }

    public float method_125()
    {
        return base.WidthScale;
    }

    public void method_126(float A_0)
    {
        base.WidthScale = A_0;
    }

    public float method_127()
    {
        return base.HeightScale;
    }

    public void method_128(float A_0)
    {
        base.HeightScale = A_0;
    }

    internal byte[] method_129()
    {
        return base.ImageBytes;
    }

    internal Image method_130()
    {
        return base.Image;
    }
}

