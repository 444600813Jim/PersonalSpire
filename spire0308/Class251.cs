using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class251
{
    private Class251()
    {
    }

    internal static void smethod_0(Class581 A_0)
    {
        int num = 0;
        TableCell cell = new TableCell(A_0.Interface50.imethod_0());
        A_0.method_3(cell);
        Class394 class2 = A_0.imethod_1();
        while (class2.method_9(BookmarkStart.b("別䬧", num)))
        {
            string str = class2.method_1();
            if (str != null)
            {
                if (!(str == BookmarkStart.b("別䬧稩師", num)))
                {
                    if (!(str == BookmarkStart.b("別䬧紩", num)))
                    {
                        goto Label_006E;
                    }
                    class2.method_45(cell.CellFormat);
                }
                else
                {
                    Class419.smethod_0(A_0, cell.CellFormat);
                }
                continue;
            }
        Label_006E:
            Class629.smethod_2(A_0);
        }
        A_0.method_5(DocumentObjectType.TableCell);
    }
}

