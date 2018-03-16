using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

internal class Class962
{
    internal bool bool_0;
    private ToPdfParameterList toPdfParameterList_0;

    public Class962()
    {
    }

    public Class962(int A_0, int A_1, Stream A_2, ImageFormat A_3)
    {
        if ((A_3 == ImageFormat.Emf) && (A_2 == null))
        {
            A_2 = new MemoryStream();
        }
    }

    public Class962(int A_0, int A_1, string A_2, ImageFormat A_3)
    {
    }

    public ToPdfParameterList method_0()
    {
        if (this.toPdfParameterList_0 == null)
        {
            this.toPdfParameterList_0 = new ToPdfParameterList();
        }
        return this.toPdfParameterList_0;
    }

    public void method_1(ToPdfParameterList A_0)
    {
        this.toPdfParameterList_0 = A_0;
    }

    internal void method_2(Document A_0, ImageType A_1, bool A_2)
    {
        ToPdfParameterList list = new ToPdfParameterList {
            IsHidden = A_2
        };
        this.method_3(A_0, A_1, list);
    }

    internal void method_3(Document A_0, ImageType A_1, ToPdfParameterList A_2)
    {
        Class195 class2 = new Class195();
        class2.method_20(A_2);
        class2.bool_2 = this.bool_0;
        class2.method_44(A_0);
        class2.method_50(A_1);
    }

    public Image[] method_4(Document A_0, ImageType A_1)
    {
        return this.method_5(A_0, A_1, null);
    }

    public Image[] method_5(Document A_0, ImageType A_1, MemoryStream A_2)
    {
        using (Class195 class2 = new Class195())
        {
            class2.method_20(this.method_0());
            class2.method_30(A_1);
            class2.bool_2 = this.bool_0;
            class2.method_43(A_0);
            return class2.method_49(0, -1, A_1, A_2, true);
        }
    }

    public Image[] method_6(int A_0, int A_1, Document A_2, ImageType A_3)
    {
        using (Class195 class2 = new Class195())
        {
            class2.method_20(this.method_0());
            class2.method_30(A_3);
            class2.bool_2 = this.bool_0;
            class2.method_43(A_2);
            return class2.method_49(A_0, A_1, A_3, null, true);
        }
    }

    public Stream method_7(int A_0, Document A_1, ImageFormat A_2)
    {
        MemoryStream stream = new MemoryStream();
        using (Class195 class2 = new Class195())
        {
            class2.method_20(this.method_0());
            class2.bool_2 = this.bool_0;
            class2.method_43(A_1);
            if (A_2 == ImageFormat.Emf)
            {
                return class2.method_61(A_0, 1, ImageType.Metafile, null);
            }
            Image[] imageArray = class2.method_49(A_0, 1, ImageType.Metafile, null, true);
            if (((imageArray != null) && (imageArray.Length > A_0)) && (imageArray[A_0] != null))
            {
                imageArray[A_0].Save(stream, A_2);
            }
            else
            {
                return null;
            }
        }
        return stream;
    }
}

