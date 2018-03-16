using Spire.Doc;
using Spire.Doc.Formatting;
using System;

internal class Class1130
{
    private Class1130()
    {
    }

    internal static void smethod_0(Class421 A_0, FootnoteType A_1, AttrCollection A_2, bool A_3)
    {
        int num = 0;
        bool flag = A_1 == FootnoteType.Endnote;
        object obj2 = A_2.method_31(2);
        object obj3 = A_2.method_31(1);
        object obj4 = A_2.method_31(4);
        object obj5 = A_2.method_31(3);
        if ((((obj2 != null) || (obj3 != null)) || ((obj4 != null) || (obj5 != null))) || A_3)
        {
            Class398 class2 = A_0.Interface52.imethod_1();
            class2.method_4(flag ? BookmarkStart.b("儥ሧ伩䈫䨭帯崱䀳匵样䠹", num) : BookmarkStart.b("儥ሧ䰩䌫䄭䐯就嬳䈵崷樹主", num));
            if (obj2 != null)
            {
                class2.method_24(BookmarkStart.b("儥ሧ娩䌫崭", num), Class339.smethod_7((FootnotePosition) obj2, false));
            }
            class2.method_24(BookmarkStart.b("儥ሧ䐩夫䌭瘯弱䀳", num), Class911.smethod_3(Class911.smethod_12((FootnoteNumberFormat) obj3)));
            if (obj4 != null)
            {
                class2.method_32(BookmarkStart.b("儥ሧ䐩夫䌭振䘱唳䐵䰷", num), (int) obj4, 1);
            }
            if (obj5 != null)
            {
                class2.method_24(BookmarkStart.b("儥ሧ䐩夫䌭戯圱䜳䈵夷䠹䠻", num), Class339.smethod_1((FootnoteRestartRule) obj5, false));
            }
            if (A_3)
            {
                smethod_1(A_0, flag, flag ? FootnoteSeparatorType.EndnoteSeparator : FootnoteSeparatorType.FootnoteSeparator);
                smethod_1(A_0, flag, flag ? FootnoteSeparatorType.EndnoteContinuation : FootnoteSeparatorType.FootnoteContinuation);
            }
            class2.method_5();
        }
    }

    private static void smethod_1(Class421 A_0, bool A_1, FootnoteSeparatorType A_2)
    {
    }
}

