using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using System;

internal class Class626
{
    private readonly ShapeObject shapeObject_0;

    internal Class626(ShapeObject A_0)
    {
        this.shapeObject_0 = A_0;
    }

    internal DigitalSignature method_0()
    {
        Document document = this.shapeObject_0.Document;
        string directShapeAttribute = (string) this.shapeObject_0.GetDirectShapeAttribute(0x781);
        return document.DigitalSignatures.method_1(directShapeAttribute);
    }

    internal bool method_1()
    {
        return (this.method_0() != null);
    }

    internal bool method_2()
    {
        return (this.method_1() && this.method_0().IsValid);
    }

    internal byte[] method_3()
    {
        if (this.method_2())
        {
            return this.method_0().ImageBytesValid;
        }
        if (this.method_1())
        {
            return this.method_0().ImageBytesInvalid;
        }
        return this.shapeObject_0.ImageData.ImageBytes;
    }
}

