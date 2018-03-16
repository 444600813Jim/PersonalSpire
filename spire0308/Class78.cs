using Spire.Doc;
using System;

internal class Class78
{
    [ThreadStatic]
    private static Interface10 interface10_0;

    internal static Interface10 smethod_0()
    {
        if (interface10_0 == null)
        {
            interface10_0 = new Class747();
        }
        return interface10_0;
    }

    internal static void smethod_1(Interface10 A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("匯崱娳䀵崷䠹䠻儽㈿", num));
        }
        interface10_0 = A_0;
    }
}

