using Spire.Doc;
using Spire.Doc.Fields;
using System;
using System.IO;

internal class Class798
{
    private Class798()
    {
    }

    internal static void smethod_0(Class857 A_0, DocumentObject A_1, ShapeObject A_2)
    {
        A_0.method_17(null);
        string str = A_0.method_11().method_1();
        smethod_1(A_0, A_2, str);
        smethod_2(A_0, A_2, str);
        if ((A_1 == null) || !A_1.ChildObjects.Contains(A_2))
        {
            A_0.method_7(A_1, A_2);
        }
    }

    internal static void smethod_1(Class857 A_0, ShapeObject A_1, string A_2)
    {
        int num = 3;
        Class396 class2 = A_0.method_11();
        while (class2.method_19())
        {
            string str2 = class2.method_1();
            if (str2 != null)
            {
                if (!(str2 == BookmarkStart.b("䄨太䠬䤮", num)))
                {
                    if (str2 == BookmarkStart.b("䨨䜪䰬尮䈰Ḳ尴匶", num))
                    {
                        class2.method_3();
                    }
                }
                else
                {
                    string str = class2.method_3();
                    if ((!str.StartsWith(BookmarkStart.b("䄨弪夬弮ର", num)) && !str.StartsWith(BookmarkStart.b("䄨弪夬弮䈰ल", num))) && !str.StartsWith(BookmarkStart.b("伨䈪䄬䨮ର", num)))
                    {
                        if ((A_2 == BookmarkStart.b("䘨䤪䜬䨮到䜲ᠴ堶唸帺", num)) || (A_2 == BookmarkStart.b("䘨䤪䜬䨮到䜲", num)))
                        {
                            byte[] buffer2 = smethod_3(A_0);
                            if (buffer2 != null)
                            {
                                MemoryStream stream = new MemoryStream(buffer2);
                                new Class1132(stream);
                            }
                            else
                            {
                                A_1.ImageData.SourceFullName = Class576.smethod_91(str);
                            }
                        }
                        if (A_2.EndsWith(BookmarkStart.b("䀨䘪䰬䠮吰", num)))
                        {
                            byte[] imageBytes = smethod_3(A_0);
                            if (imageBytes != null)
                            {
                                A_1.ImageData.LoadImage(imageBytes);
                            }
                        }
                        continue;
                    }
                    if ((A_2 == BookmarkStart.b("䘨䤪䜬䨮到䜲ᠴ堶唸帺", num)) || (A_2 == BookmarkStart.b("䘨䤪䜬䨮到䜲", num)))
                    {
                        A_1.OleFormat.SourceFullName = Class576.smethod_91(str);
                    }
                    if (A_2.EndsWith(BookmarkStart.b("䀨䘪䰬䠮吰", num)))
                    {
                        A_1.ImageData.SourceFullName = Class576.smethod_91(str);
                    }
                }
            }
        }
    }

    private static void smethod_2(Class857 A_0, ShapeObject A_1, string A_2)
    {
        Class396 class2 = A_0.method_11();
        while (class2.method_9(A_2))
        {
            if (!A_0.method_5(A_1.ShapePr))
            {
                A_0.method_11().method_1();
                class2.vmethod_1();
            }
        }
    }

    private static byte[] smethod_3(Class857 A_0)
    {
        string str = A_0.method_11().method_3().Replace(BookmarkStart.b("ᴲᨴ", 13), "");
        str = string.Format(BookmarkStart.b("ᰲ临ܶ䐸", 13), str);
        Class113 class3 = A_0.method_10().method_2(str);
        if (class3 == null)
        {
            return null;
        }
        byte[] buffer = class3.method_3().ToArray();
        Guid key = Class968.smethod_0(buffer);
        if (!A_0.method_28().ContainsKey(key))
        {
            A_0.method_28().Add(key, buffer);
            return buffer;
        }
        return (byte[]) A_0.method_28()[key];
    }
}

