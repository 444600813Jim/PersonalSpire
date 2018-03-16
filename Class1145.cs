using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using System;

internal class Class1145
{
    private Class1145()
    {
    }

    internal static void smethod_0(string A_0, StyleCollection A_1, bool A_2, Style A_3)
    {
        Class567.smethod_19(A_0, BookmarkStart.b("就唳嬵崷", 12));
        Class567.smethod_20(A_1, BookmarkStart.b("䄱䀳伵吷弹伻", 12));
        Class567.smethod_20(A_3, BookmarkStart.b("䄱䀳伵吷弹", 12));
        StyleIdentifier user = A_2 ? StyleIdentifier.User : Class417.smethod_25(A_0);
        if (user != StyleIdentifier.User)
        {
            A_0 = Class417.smethod_27(A_0);
        }
        if (A_1.InnerList.Contains(user))
        {
            user = StyleIdentifier.User;
        }
        if (Class881.smethod_3(user) == 0xfff)
        {
            int num = A_1.method_15();
        }
        A_3.method_14(user);
        A_3.Name = A_0;
    }
}

