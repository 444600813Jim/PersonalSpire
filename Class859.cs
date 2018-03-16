using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class859
{
    internal static RowAlignment smethod_0(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("堳匵帷丹", num))
            {
                return RowAlignment.Left;
            }
            if (str == BookmarkStart.b("䜳䈵夷䠹䠻", num))
            {
                return RowAlignment.Left;
            }
            if (str == BookmarkStart.b("圳匵嘷丹夻䰽", num))
            {
                return RowAlignment.Center;
            }
            if (str == BookmarkStart.b("䘳張強刹䠻", num))
            {
                return RowAlignment.Right;
            }
            if (str == BookmarkStart.b("儳堵尷", num))
            {
                return RowAlignment.Right;
            }
        }
        return RowAlignment.Left;
    }

    internal static string smethod_1(RowAlignment A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case RowAlignment.Left:
                return BookmarkStart.b("䌮吰唲䄴", num);

            case RowAlignment.Center:
                return BookmarkStart.b("䰮吰崲䄴制䬸", num);

            case RowAlignment.Right:
                return BookmarkStart.b("崮堰吲崴䌶", num);
        }
        return "";
    }

    internal static TableRowHeightType smethod_2(string A_0)
    {
        int num = 11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("倰䘲䄴堶", num))
            {
                return TableRowHeightType.Auto;
            }
            if (str == BookmarkStart.b("吰䬲吴吶䴸", num))
            {
                return TableRowHeightType.Exactly;
            }
            if ((str == BookmarkStart.b("倰䜲礴制堸䠺䤼", num)) || (str == BookmarkStart.b("倰䜲ᠴ嬶尸娺丼䬾", num)))
            {
                return TableRowHeightType.AtLeast;
            }
        }
        return TableRowHeightType.Auto;
    }

    internal static string smethod_3(TableRowHeightType A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case TableRowHeightType.AtLeast:
                if (A_1)
                {
                    return BookmarkStart.b("丮䔰缲倴嘶䨸伺", num);
                }
                return BookmarkStart.b("丮䔰Ḳ头制堸䠺䤼", num);

            case TableRowHeightType.Exactly:
                return BookmarkStart.b("䨮䤰刲嘴䌶", num);

            case TableRowHeightType.Auto:
                return BookmarkStart.b("丮䐰䜲娴", num);
        }
        return "";
    }

    internal static CellMerge smethod_4(string A_0)
    {
        int num = 1;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐦䘨䔪夬䘮弰䘲倴", num))
            {
                return CellMerge.Continue;
            }
            if (str == BookmarkStart.b("唦䰨堪夬丮䌰䜲", num))
            {
                return CellMerge.Start;
            }
        }
        return CellMerge.None;
    }

    internal static string smethod_5(CellMerge A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case CellMerge.Start:
                return BookmarkStart.b("娧伩弫娭儯䀱䀳", num);

            case CellMerge.Continue:
                return BookmarkStart.b("䬧䔩䈫娭夯就䄳匵", num);
        }
        return "";
    }

    internal static VerticalAlignment smethod_6(string A_0)
    {
        int num = 15;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䄴堶䤸", num))
            {
                return VerticalAlignment.Top;
            }
            if (str == BookmarkStart.b("嘴制圸伺堼䴾", num))
            {
                return VerticalAlignment.Middle;
            }
            if (str == BookmarkStart.b("圴堶䴸伺刼刾", num))
            {
                return VerticalAlignment.Bottom;
            }
        }
        return VerticalAlignment.Top;
    }

    internal static string smethod_7(VerticalAlignment A_0)
    {
        int num = 7;
        switch (A_0)
        {
            case VerticalAlignment.Top:
                return BookmarkStart.b("夬䀮䄰", num);

            case VerticalAlignment.Middle:
                return BookmarkStart.b("丬䨮弰䜲倴䔶", num);

            case VerticalAlignment.Bottom:
                return BookmarkStart.b("伬䀮䔰䜲娴娶", num);
        }
        return "";
    }
}

