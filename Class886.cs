using Spire.Doc;
using Spire.Doc.Fields.Shape.Ps.Wrapping;
using System;
using System.Drawing;

internal class Class886
{
    private PointF pointF_0;
    private VertexType vertexType_0;

    internal Class886(PointF A_0) : this(A_0, VertexType.Simple)
    {
    }

    internal Class886(PointF A_0, VertexType A_1)
    {
        this.method_3(A_0);
        this.method_1(A_1);
    }

    internal VertexType method_0()
    {
        return this.vertexType_0;
    }

    internal void method_1(VertexType A_0)
    {
        this.vertexType_0 = A_0;
    }

    internal PointF method_2()
    {
        return this.pointF_0;
    }

    internal void method_3(PointF A_0)
    {
        this.pointF_0 = A_0;
    }

    public bool method_4(Class886 A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        return (object.ReferenceEquals(this, A_0) || (object.Equals(A_0.vertexType_0, this.vertexType_0) && A_0.pointF_0.Equals(this.pointF_0)));
    }

    bool object.Equals(object A_0)
    {
        if (object.ReferenceEquals(null, A_0))
        {
            return false;
        }
        if (object.ReferenceEquals(this, A_0))
        {
            return true;
        }
        if (A_0.GetType() != typeof(Class886))
        {
            return false;
        }
        return this.method_4((Class886) A_0);
    }

    int object.GetHashCode()
    {
        return (((int) (this.vertexType_0 * ((VertexType) 0x18d))) ^ this.pointF_0.GetHashCode());
    }

    string object.ToString()
    {
        return (this.vertexType_0 + BookmarkStart.b("࠱", 12) + this.pointF_0);
    }
}

