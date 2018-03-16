using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class1043
{
    internal static void smethod_0(Paragraph A_0, Interface27 A_1)
    {
        smethod_3(A_0, true, A_1);
    }

    internal static void smethod_1(Paragraph A_0, Interface27 A_1)
    {
        smethod_3(A_0, false, A_1);
    }

    private static ArrayList smethod_2(Paragraph A_0, bool A_1)
    {
        ArrayList list = null;
        if (A_1 ? ((A_0.ParentObject == null) || (A_0.ParentObject.FirstChild == A_0)) : ((A_0.ParentObject == null) || (A_0.ParentObject.LastChild == A_0)))
        {
            for (DocumentObject obj2 = A_0.ParentObject; obj2 != null; obj2 = obj2.ParentObject)
            {
                if (obj2.DocumentObjectType == DocumentObjectType.CustomXml)
                {
                    if (list == null)
                    {
                        list = new ArrayList();
                    }
                    if (A_1)
                    {
                        list.Insert(0, obj2);
                    }
                    else
                    {
                        list.Add(obj2);
                    }
                }
                if (A_1 ? ((obj2.ParentObject != null) && (obj2.ParentObject.FirstChild != obj2)) : ((obj2.ParentObject != null) && (obj2.ParentObject.LastChild != obj2)))
                {
                    return list;
                }
            }
        }
        return list;
    }

    private static void smethod_3(Paragraph A_0, bool A_1, Interface27 A_2)
    {
        ArrayList list = smethod_2(A_0, A_1);
        if (list != null)
        {
            foreach (Interface60 interface2 in list)
            {
                if (A_1)
                {
                    A_2.imethod_0((Class9) interface2);
                }
                else
                {
                    A_2.imethod_1((Class9) interface2);
                }
            }
        }
    }
}

