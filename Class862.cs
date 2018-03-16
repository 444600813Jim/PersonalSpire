using Spire.Doc;
using Spire.Doc.Formatting;
using System;
using System.Collections;

internal class Class862
{
    private Class862()
    {
    }

    internal static void smethod_0(Document A_0, Class398 A_1, bool A_2)
    {
    }

    private static void smethod_1(Class398 A_0, Class14 A_1, bool A_2, bool A_3)
    {
        int num = 2;
        A_0.method_4(A_1.method_120() ? BookmarkStart.b("弧ဩ䨫尭儯弱儳䔵崷丹", num) : BookmarkStart.b("弧ဩ䨫尭儯弱儳", num));
        if (A_3)
        {
            smethod_2(A_0, A_1);
        }
        else
        {
            smethod_3(A_0, A_1);
        }
        if (!A_1.method_120())
        {
            A_0.method_30(BookmarkStart.b("弧ဩ愫伭䈯稱", num), A_1.method_61());
            A_0.method_30(BookmarkStart.b("弧ဩ愫伭䈯搱", num), A_1.method_66());
            A_0.method_24(BookmarkStart.b("弧ဩ䈫伭崯圱", num), A_1.method_51());
            if ((A_1.method_53() != null) && !A_2)
            {
                A_0.method_24(BookmarkStart.b("弧ဩ弫䄭䔯䀱圳匵縷匹倻嬽฿⍁⥃⍅", num), A_1.method_53());
            }
        }
        A_0.method_31(BookmarkStart.b("弧ဩ䈫䄭戯圱䜳張䈷弹紻刽ⰿⵁ㍃⍅ⱇ", num), A_1.method_118());
        A_0.method_31(BookmarkStart.b("弧ဩ䀫䜭帯失儳刵氷唹稻圽ⰿ❁", num), A_1.method_116());
        A_0.method_24(BookmarkStart.b("弧ဩ堫䜭䐯帱儳", num), A_1.method_49());
        using (IEnumerator enumerator = A_1.method_121().System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class14 current = (Class14) enumerator.Current;
                smethod_1(A_0, current, A_2, false);
            }
        }
        A_0.method_5();
    }

    private static void smethod_2(Class398 A_0, Class14 A_1)
    {
        int num = 1;
        A_0.method_4(BookmarkStart.b("倦ጨ䴪弬丮尰嘲䘴制䴸栺䴼匾⡀㝂❄♆㭈", 1));
        A_0.method_32(BookmarkStart.b("倦ጨ尪", 1), A_1.method_126(), 0);
        A_0.method_27(BookmarkStart.b("倦ጨ䠪䈬䌮帰䄲", 1), A_1.method_124());
        string str = Class417.smethod_1(A_1.method_122());
        if (Class567.smethod_16(str))
        {
            A_0.vmethod_0(string.Format(BookmarkStart.b("倦ጨ倪ᴬ刮", num), str), true);
        }
        A_0.method_5();
    }

    private static void smethod_3(Class398 A_0, Class14 A_1)
    {
        int num = 0;
        string str = "";
        if (A_1.method_55() == FrameDividerPositionType.Percentage)
        {
            str = BookmarkStart.b("̥", num);
        }
        else if (A_1.method_55() == FrameDividerPositionType.Relative)
        {
            str = BookmarkStart.b("థ", num);
        }
        str = string.Format(BookmarkStart.b("崥ᠧ圩圫Ἥ䴯", num), A_1.method_57(), str);
        if (str != BookmarkStart.b("ᜥȧ", num))
        {
            A_0.method_24(BookmarkStart.b("儥ሧ天嘫", num), str);
        }
    }
}

