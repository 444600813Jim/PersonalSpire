using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Markup;
using System;
using System.Collections;

internal class Class389
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly Hashtable hashtable_0 = new Hashtable();
    private readonly Hashtable hashtable_1 = new Hashtable();
    private readonly Stack stack_0 = new Stack();
    private readonly Stack stack_1 = new Stack();

    internal bool method_0(Interface60 A_0, DocumentObject A_1)
    {
        this.stack_0.Push(A_0);
        if (A_0.imethod_0() != MarkupLevel.Inline)
        {
            this.hashtable_0[A_0] = A_1;
        }
        return (A_0.imethod_0() != MarkupLevel.Inline);
    }

    internal void method_1(Interface60 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal void method_2(DocumentObject A_0)
    {
        foreach (Interface60 interface2 in this.arrayList_0)
        {
            this.method_0(interface2, A_0);
        }
        this.arrayList_0.Clear();
    }

    internal bool method_3(DocumentContainer A_0)
    {
        if (this.stack_0.Count == 0)
        {
            this.method_2(A_0);
            return false;
        }
        Interface60 interface2 = (Interface60) this.stack_0.Pop();
        if (interface2.imethod_0() != MarkupLevel.Inline)
        {
            this.stack_1.Push(interface2);
            this.hashtable_1[interface2] = A_0;
        }
        return (interface2.imethod_0() != MarkupLevel.Inline);
    }

    internal void method_4()
    {
        while (this.stack_1.Count > 0)
        {
            Interface60 interface2 = (Interface60) this.stack_1.Pop();
            ArrayList list = smethod_0((DocumentObject) this.hashtable_0[interface2], (DocumentObject) this.hashtable_1[interface2]);
            if (list != null)
            {
                DocumentObject parentObject = ((DocumentObject) list[0]).ParentObject;
                if ((((parentObject.DocumentObjectType == DocumentObjectType.Table) && (interface2.imethod_0() == MarkupLevel.Block)) || ((parentObject.DocumentObjectType == DocumentObjectType.TableRow) && (interface2.imethod_0() == MarkupLevel.Row))) || ((parentObject.DocumentObjectType == DocumentObjectType.TableCell) && (interface2.imethod_0() == MarkupLevel.Cell)))
                {
                    list.Clear();
                    list.Add(parentObject);
                    parentObject = parentObject.ParentObject;
                }
                else if ((parentObject.DocumentObjectType == DocumentObjectType.TableCell) && (interface2.imethod_0() == MarkupLevel.Row))
                {
                    list.Clear();
                    list.Add(((TableCell) parentObject).OwnerRow);
                    parentObject = ((TableCell) parentObject).OwnerRow;
                }
                if (parentObject.DocumentObjectType == (interface2 as DocumentObject).DocumentObjectType)
                {
                    smethod_1((DocumentObject) interface2, list);
                }
            }
        }
    }

    private void method_5(string A_0)
    {
    }

    internal bool method_6()
    {
        return (this.stack_0.Count > 0);
    }

    private static ArrayList smethod_0(DocumentObject A_0, DocumentObject A_1)
    {
        int num = Class681.smethod_19(A_0);
        int num2 = Class681.smethod_19(A_1);
        int num3 = Math.Min(num, num2);
        A_0 = Class681.smethod_20(A_0, num - num3);
        A_1 = Class681.smethod_20(A_1, num2 - num3);
        while (A_0 != null)
        {
            if ((A_1 == null) || (A_0.ParentObject == A_1.ParentObject))
            {
                break;
            }
            A_0 = A_0.ParentObject;
            A_1 = A_1.ParentObject;
        }
        if ((A_0 == null) || (A_1 == null))
        {
            return null;
        }
        ArrayList list = new ArrayList();
        while (A_0 != null)
        {
            if (A_0 == A_1)
            {
                break;
            }
            list.Add(A_0);
            A_0 = (DocumentObject) A_0.NextSibling;
        }
        list.Add(A_1);
        return list;
    }

    private static void smethod_1(DocumentObject A_0, ArrayList A_1)
    {
        DocumentObject obj2 = (DocumentObject) A_1[0];
        obj2.ParentObject.method_18(A_0, obj2);
        foreach (DocumentObject obj3 in A_1)
        {
            A_0.method_13(obj3);
        }
    }
}

