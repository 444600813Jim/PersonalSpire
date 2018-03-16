using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class68 : Interface6
{
    public SizeF[] imethod_0(ShapeObject[] A_0)
    {
        SizeF[] efArray = new SizeF[A_0.Length];
        for (int i = 0; i < efArray.Length; i++)
        {
            efArray[i] = this.method_0(A_0[i]);
        }
        return efArray;
    }

    private SizeF method_0(ShapeObject A_0)
    {
        Class673 class2 = this.method_1(A_0);
        Class672 class3 = new Class672(new Class724(A_0), class2, null);
        float num = Class315.smethod_2(A_0);
        return Class315.smethod_0(class3, num).Size;
    }

    private Class673 method_1(DocumentObject A_0)
    {
        if (A_0.DocumentObjectType == DocumentObjectType.Shape)
        {
            return this.method_1(A_0.ParentObject);
        }
        ShapeGroup group = (A_0.DocumentObjectType == DocumentObjectType.ShapeGroup) ? ((ShapeGroup) A_0) : null;
        if (group == null)
        {
            return Class673.smethod_0();
        }
        DocumentObject parentObject = group.ParentObject;
        Class673 class2 = Class673.smethod_0();
        if ((parentObject != null) && (parentObject.DocumentObjectType == DocumentObjectType.ShapeGroup))
        {
            class2 = this.method_1(parentObject);
        }
        SizeF size = group.Size;
        spr➂ r➂ = Class316.smethod_9(group, size, false);
        r➂.ᜀ(class2.method_0(), MatrixOrder.Append);
        Class316.smethod_9(group, size, true).ᜀ(class2.method_0(), MatrixOrder.Append);
        SizeF ef2 = Class316.smethod_0(group, class2.method_1(), class2.method_2());
        float width = ef2.Width;
        float height = ef2.Height;
        float num3 = (size.Width / ((float) group.CoordSizeWidth)) * width;
        float num4 = (size.Height / ((float) group.CoordSizeHeight)) * height;
        return new Class673(r➂, num3, num4, ((float) group.Rotation) + class2.method_3());
    }
}

