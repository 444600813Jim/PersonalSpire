using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;

internal class Class248
{
    private Class248()
    {
    }

    internal static TextAlignment smethod_0(string A_0)
    {
        int num = 1;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("匦䘨嬪", num))
            {
                return TextAlignment.Top;
            }
            if (str == BookmarkStart.b("䐦䰨䔪夬䨮䌰", num))
            {
                return TextAlignment.Center;
            }
            if (str == BookmarkStart.b("䔦䠨堪䠬䌮堰崲倴", num))
            {
                return TextAlignment.Baseline;
            }
            if (str == BookmarkStart.b("䔦䘨弪夬䀮尰", num))
            {
                return TextAlignment.Bottom;
            }
            if (str == BookmarkStart.b("䘦尨弪䈬", num))
            {
                return TextAlignment.Auto;
            }
        }
        return TextAlignment.Auto;
    }

    internal static string smethod_1(TextAlignment A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case TextAlignment.Top:
                return BookmarkStart.b("弪䈬弮", num);

            case TextAlignment.Center:
                return BookmarkStart.b("䠪䠬䄮䔰嘲䜴", num);

            case TextAlignment.Baseline:
                return BookmarkStart.b("䤪䰬尮吰弲尴夶尸", num);

            case TextAlignment.Bottom:
                return BookmarkStart.b("䤪䈬嬮䔰尲場", num);

            case TextAlignment.Auto:
                return BookmarkStart.b("䨪堬嬮帰", num);
        }
        return "";
    }

    internal static FrameVertAnchor smethod_10(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐯圱䰳䈵", num))
            {
                return FrameVertAnchor.Text;
            }
            if (str == BookmarkStart.b("崯匱䘳儵儷吹", num))
            {
                return FrameVertAnchor.Margin;
            }
            if (str == BookmarkStart.b("䀯匱匳匵", num))
            {
            }
        }
        return FrameVertAnchor.Page;
    }

    internal static string smethod_11(byte A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case 0:
                return BookmarkStart.b("䘪䰬崮嘰娲嬴", num);

            case 1:
                return BookmarkStart.b("嬪䰬䠮吰", num);

            case 2:
                return BookmarkStart.b("弪䠬圮䔰", num);
        }
        return "";
    }

    internal static FrameTextWrap smethod_12(string A_0)
    {
        int num = 5;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_5 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䨪堬嬮帰", num), 0);
                dictionary1.Add(BookmarkStart.b("䔪䈬嬮猰嘲䘴帶崸帺", num), 1);
                dictionary1.Add(BookmarkStart.b("䔪䈬嬮ᰰ儲倴䐶倸强堼", num), 2);
                dictionary1.Add(BookmarkStart.b("䨪弬䀮䐰崲儴", num), 3);
                dictionary1.Add(BookmarkStart.b("弪䐬䠮夰䜲", num), 4);
                dictionary1.Add(BookmarkStart.b("弪䔬崮帰䘲刴弶", num), 5);
                dictionary1.Add(BookmarkStart.b("䔪䈬䄮吰", num), 6);
                Class1160.dictionary_5 = dictionary1;
            }
            if (Class1160.dictionary_5.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return FrameTextWrap.Auto;

                    case 1:
                        return FrameTextWrap.NotBeside;

                    case 2:
                        return FrameTextWrap.NotBeside;

                    case 3:
                        return FrameTextWrap.Around;

                    case 4:
                        return FrameTextWrap.Tight;

                    case 5:
                        return FrameTextWrap.Through;

                    case 6:
                        return FrameTextWrap.None;
                }
            }
        }
        return FrameTextWrap.None;
    }

    internal static string smethod_13(FrameTextWrap A_0, bool A_1)
    {
        int num = 14;
        switch (A_0)
        {
            case FrameTextWrap.Auto:
                return BookmarkStart.b("唳䌵䰷唹", num);

            case FrameTextWrap.NotBeside:
                if (A_1)
                {
                    return BookmarkStart.b("娳夵䰷砹夻䴽⤿♁⅃", num);
                }
                return BookmarkStart.b("娳夵䰷᜹帻嬽㌿⭁⁃⍅", num);

            case FrameTextWrap.Around:
                return BookmarkStart.b("唳䐵圷伹刻娽", num);

            case FrameTextWrap.None:
                return BookmarkStart.b("娳夵嘷弹", num);

            case FrameTextWrap.Tight:
                return BookmarkStart.b("䀳張強刹䠻", num);

            case FrameTextWrap.Through:
                return BookmarkStart.b("䀳帵䨷唹䤻夽⠿", num);
        }
        return "";
    }

    internal static FrameSizeRule smethod_14(string A_0)
    {
        int num = 0x13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("堸为䤼倾", num))
            {
                return FrameSizeRule.Auto;
            }
            if (str == BookmarkStart.b("尸䌺尼尾㕀", num))
            {
                return FrameSizeRule.Exact;
            }
            if (str == BookmarkStart.b("堸伺焼娾⁀あㅄ", num))
            {
                return FrameSizeRule.AtLeast;
            }
            if (str == BookmarkStart.b("堸伺ြ匾⑀≂㙄㍆", num))
            {
                return FrameSizeRule.AtLeast;
            }
        }
        return FrameSizeRule.Auto;
    }

    internal static string smethod_15(FrameSizeRule A_0, bool A_1)
    {
        int num = 0x10;
        switch (A_0)
        {
            case FrameSizeRule.Auto:
                return BookmarkStart.b("圵䴷丹医", num);

            case FrameSizeRule.AtLeast:
                if (A_1)
                {
                    return BookmarkStart.b("圵䰷瘹夻弽㌿㙁", num);
                }
                return BookmarkStart.b("圵䰷᜹倻嬽ℿㅁぃ", num);

            case FrameSizeRule.Exact:
                return BookmarkStart.b("匵䀷嬹弻䨽", num);
        }
        return "";
    }

    internal static LineSpacingRule smethod_16(string A_0)
    {
        int num = 4;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䬩夫娭弯", num))
            {
                return LineSpacingRule.Multiple;
            }
            if (str == BookmarkStart.b("伩含伭匯䘱", num))
            {
                return LineSpacingRule.Exactly;
            }
            if (str == BookmarkStart.b("䬩堫戭唯匱䜳䈵", num))
            {
                return LineSpacingRule.AtLeast;
            }
            if (str == BookmarkStart.b("䬩堫̭尯圱唳䔵䰷", num))
            {
                return LineSpacingRule.AtLeast;
            }
        }
        return LineSpacingRule.AtLeast;
    }

    internal static string smethod_17(LineSpacingRule A_0, bool A_1)
    {
        int num = 4;
        switch (A_0)
        {
            case LineSpacingRule.AtLeast:
                if (A_1)
                {
                    return BookmarkStart.b("䬩堫戭唯匱䜳䈵", num);
                }
                return BookmarkStart.b("䬩堫̭尯圱唳䔵䰷", num);

            case LineSpacingRule.Exactly:
                return BookmarkStart.b("伩含伭匯䘱", num);

            case LineSpacingRule.Multiple:
                return BookmarkStart.b("䬩夫娭弯", num);
        }
        return "";
    }

    internal static HorizontalAlignment smethod_18(string A_0, bool A_1)
    {
        int num = 10;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_6 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䌯䘱唳䐵䰷", num), 0);
                dictionary1.Add(BookmarkStart.b("尯圱刳䈵", num), 1);
                dictionary1.Add(BookmarkStart.b("匯圱娳䈵崷䠹", num), 2);
                dictionary1.Add(BookmarkStart.b("䈯嬱匳帵䰷", num), 3);
                dictionary1.Add(BookmarkStart.b("唯就倳", num), 4);
                dictionary1.Add(BookmarkStart.b("刯崱䀳帵", num), 5);
                dictionary1.Add(BookmarkStart.b("启嬱䜳䈵䨷匹帻䬽㐿❁", num), 6);
                Class1160.dictionary_6 = dictionary1;
            }
            if (Class1160.dictionary_6.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return HorizontalAlignment.Left;

                    case 1:
                        if (A_1)
                        {
                            return HorizontalAlignment.Right;
                        }
                        return HorizontalAlignment.Left;

                    case 2:
                        return HorizontalAlignment.Center;

                    case 3:
                        if (A_1)
                        {
                            return HorizontalAlignment.Left;
                        }
                        return HorizontalAlignment.Right;

                    case 4:
                        return HorizontalAlignment.Right;

                    case 5:
                        return HorizontalAlignment.Justify;

                    case 6:
                        return HorizontalAlignment.Distribute;
                }
            }
        }
        return HorizontalAlignment.Left;
    }

    internal static string smethod_19(HorizontalAlignment A_0, bool A_1)
    {
        int num = 2;
        switch (A_0)
        {
            case HorizontalAlignment.Left:
                if (A_1)
                {
                    return BookmarkStart.b("娧䌩䬫䘭䐯", num);
                }
                return BookmarkStart.b("䐧伩䨫娭", num);

            case HorizontalAlignment.Center:
                return BookmarkStart.b("䬧伩䈫娭唯䀱", num);

            case HorizontalAlignment.Right:
                if (A_1)
                {
                    return BookmarkStart.b("䐧伩䨫娭", num);
                }
                return BookmarkStart.b("娧䌩䬫䘭䐯", num);

            case HorizontalAlignment.Justify:
                return BookmarkStart.b("䨧䔩堫䘭", num);

            case HorizontalAlignment.Distribute:
                return BookmarkStart.b("䰧䌩弫娭䈯嬱嘳䌵䰷弹", num);
        }
        return "";
    }

    internal static DropCapPosition smethod_2(string A_0)
    {
        int num = 5;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䔪䈬䄮吰", num))
            {
                return DropCapPosition.None;
            }
            if (str == BookmarkStart.b("伪弬䀮䄰", num))
            {
                return DropCapPosition.Normal;
            }
            if (str == BookmarkStart.b("䘪䰬崮嘰娲嬴", num))
            {
                return DropCapPosition.Margin;
            }
        }
        return DropCapPosition.None;
    }

    internal static TabLeader smethod_20(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_7 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("夶嘸唺堼", num), 0);
                dictionary1.Add(BookmarkStart.b("匶嘸伺", num), 1);
                dictionary1.Add(BookmarkStart.b("弶䀸䬺唼娾⽀", num), 2);
                dictionary1.Add(BookmarkStart.b("䈶圸强堼䴾㉀⁂⩄㕆ⱈ", num), 3);
                dictionary1.Add(BookmarkStart.b("弶尸娺䬼䘾", num), 4);
                dictionary1.Add(BookmarkStart.b("娶倸强夼匾⑀݂⩄㍆", num), 5);
                dictionary1.Add(BookmarkStart.b("娶倸强夼匾⑀湂⅄⡆㵈", num), 6);
                Class1160.dictionary_7 = dictionary1;
            }
            if (Class1160.dictionary_7.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return TabLeader.NoLeader;

                    case 1:
                        return TabLeader.Dotted;

                    case 2:
                        return TabLeader.Hyphenated;

                    case 3:
                        return TabLeader.Single;

                    case 4:
                        return TabLeader.Heavy;

                    case 5:
                        return TabLeader.MiddleDot;

                    case 6:
                        return TabLeader.MiddleDot;
                }
            }
        }
        return TabLeader.NoLeader;
    }

    internal static string smethod_21(TabLeader A_0, bool A_1)
    {
        int num = 4;
        switch (A_0)
        {
            case TabLeader.NoLeader:
                return BookmarkStart.b("䐩䌫䀭唯", num);

            case TabLeader.Dotted:
                return BookmarkStart.b("丩䌫娭", num);

            case TabLeader.Hyphenated:
                return BookmarkStart.b("䈩唫席堯圱娳", num);

            case TabLeader.Single:
                return BookmarkStart.b("弩䈫䨭唯䀱䜳唵圷䠹夻", num);

            case TabLeader.Heavy:
                return BookmarkStart.b("䈩䤫伭䘯䬱", num);

            case TabLeader.MiddleDot:
                if (A_1)
                {
                    return BookmarkStart.b("䜩䔫䨭启帱儳爵圷丹", num);
                }
                return BookmarkStart.b("䜩䔫䨭启帱儳ᬵ尷唹䠻", num);
        }
        return "";
    }

    internal static TabJustification smethod_22(string A_0)
    {
        int num = 5;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_8 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("䠪䄬䨮倰䄲", num), 0);
                dictionary1.Add(BookmarkStart.b("䜪䠬䤮䔰", num), 1);
                dictionary1.Add(BookmarkStart.b("堪夬丮䌰䜲", num), 2);
                dictionary1.Add(BookmarkStart.b("䠪䠬䄮䔰嘲䜴", num), 3);
                dictionary1.Add(BookmarkStart.b("太䐬䠮夰䜲", num), 4);
                dictionary1.Add(BookmarkStart.b("个䌬䬮", num), 5);
                dictionary1.Add(BookmarkStart.b("伪䠬䰮堰帲吴嬶", num), 6);
                dictionary1.Add(BookmarkStart.b("䤪䰬崮", num), 7);
                dictionary1.Add(BookmarkStart.b("䔪堬䈮", num), 8);
                dictionary1.Add(BookmarkStart.b("䜪䐬尮䔰", num), 9);
                Class1160.dictionary_8 = dictionary1;
            }
            if (Class1160.dictionary_8.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return TabJustification.Clear;

                    case 1:
                        return TabJustification.Left;

                    case 2:
                        return TabJustification.Left;

                    case 3:
                        return TabJustification.Centered;

                    case 4:
                        return TabJustification.Right;

                    case 5:
                        return TabJustification.Right;

                    case 6:
                        return TabJustification.Decimal;

                    case 7:
                        return TabJustification.Bar;

                    case 8:
                        return TabJustification.List;

                    case 9:
                        return TabJustification.List;
                }
            }
        }
        return TabJustification.Clear;
    }

    internal static string smethod_23(TabJustification A_0, bool A_1)
    {
        int num = 12;
        switch (A_0)
        {
            case TabJustification.Left:
                return BookmarkStart.b("帱儳倵䰷", num);

            case TabJustification.Centered:
                return BookmarkStart.b("儱儳堵䰷弹主", num);

            case TabJustification.Right:
                return BookmarkStart.b("䀱崳儵倷丹", num);

            case TabJustification.Decimal:
                return BookmarkStart.b("嘱儳唵儷圹崻刽", num);

            case TabJustification.Bar:
                return BookmarkStart.b("倱唳䐵", num);

            case TabJustification.List:
                if (!A_1)
                {
                    return BookmarkStart.b("帱崳䔵䰷", num);
                }
                return BookmarkStart.b("就䄳嬵", num);

            case TabJustification.Clear:
                return BookmarkStart.b("儱堳匵夷䠹", num);
        }
        return "";
    }

    internal static string smethod_3(DropCapPosition A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case DropCapPosition.None:
                return BookmarkStart.b("䔪䈬䄮吰", num);

            case DropCapPosition.Normal:
                return BookmarkStart.b("伪弬䀮䄰", num);

            case DropCapPosition.Margin:
                return BookmarkStart.b("䘪䰬崮嘰娲嬴", num);
        }
        return "";
    }

    internal static VerticalPosition smethod_4(string A_0)
    {
        int num = 14;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_4 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䀳夵䠷", num), 0);
                dictionary1.Add(BookmarkStart.b("圳匵嘷丹夻䰽", num), 1);
                dictionary1.Add(BookmarkStart.b("嘳夵䰷丹医匽", num), 2);
                dictionary1.Add(BookmarkStart.b("崳堵䬷匹堻嬽", num), 3);
                dictionary1.Add(BookmarkStart.b("嬳䌵䰷䤹唻娽┿", num), 4);
                dictionary1.Add(BookmarkStart.b("崳堵吷匹刻嬽", num), 5);
                Class1160.dictionary_4 = dictionary1;
            }
            if (Class1160.dictionary_4.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return VerticalPosition.Top;

                    case 1:
                        return VerticalPosition.Center;

                    case 2:
                        return VerticalPosition.Bottom;

                    case 3:
                        return VerticalPosition.Inside;

                    case 4:
                        return VerticalPosition.Outside;

                    case 5:
                        return VerticalPosition.Inline;
                }
            }
        }
        return VerticalPosition.None;
    }

    internal static string smethod_5(VerticalPosition A_0)
    {
        int num = 3;
        switch (A_0)
        {
            case VerticalPosition.Inline:
                return BookmarkStart.b("䀨䔪䄬䘮弰嘲", num);

            case VerticalPosition.Top:
                return BookmarkStart.b("崨䐪崬", num);

            case VerticalPosition.Center:
                return BookmarkStart.b("䨨个䌬嬮吰䄲", num);

            case VerticalPosition.Bottom:
                return BookmarkStart.b("䬨䐪夬嬮帰帲", num);

            case VerticalPosition.Inside:
                return BookmarkStart.b("䀨䔪帬䘮唰嘲", num);

            case VerticalPosition.Outside:
                return BookmarkStart.b("䘨帪夬尮堰圲倴", num);
        }
        return "";
    }

    internal static HorizontalPosition smethod_6(string A_0)
    {
        int num = 0x12;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("嬷弹刻䨽┿ぁ", num))
            {
                return HorizontalPosition.Center;
            }
            if (str == BookmarkStart.b("䨷匹嬻嘽㐿", num))
            {
                return HorizontalPosition.Right;
            }
            if (str == BookmarkStart.b("儷吹伻圽␿❁", num))
            {
                return HorizontalPosition.Inside;
            }
            if (str == BookmarkStart.b("圷伹䠻䴽⤿♁⅃", num))
            {
                return HorizontalPosition.Outside;
            }
            if (str == BookmarkStart.b("吷弹娻䨽", num))
            {
                return HorizontalPosition.Left;
            }
        }
        return HorizontalPosition.None;
    }

    internal static string smethod_7(HorizontalPosition A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case HorizontalPosition.Left:
                return BookmarkStart.b("䬦䰨䴪夬", num);

            case HorizontalPosition.Center:
                return BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);

            case HorizontalPosition.Right:
                return BookmarkStart.b("唦䀨䰪䔬嬮", num);

            case HorizontalPosition.Inside:
                return BookmarkStart.b("並䜨堪䐬䬮吰", num);

            case HorizontalPosition.Outside:
                return BookmarkStart.b("䠦尨弪帬䘮唰嘲", num);
        }
        return "";
    }

    internal static FrameHorzAnchor smethod_8(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐯圱䰳䈵", num))
            {
                return FrameHorzAnchor.Column;
            }
            if (str == BookmarkStart.b("崯匱䘳儵儷吹", num))
            {
                return FrameHorzAnchor.Margin;
            }
            if (str == BookmarkStart.b("䀯匱匳匵", num))
            {
            }
        }
        return FrameHorzAnchor.Page;
    }

    internal static string smethod_9(byte A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case 0:
                return BookmarkStart.b("䀳匵䀷丹", num);

            case 1:
                return BookmarkStart.b("夳圵䨷崹唻倽", num);

            case 2:
                return BookmarkStart.b("䐳圵強弹", num);
        }
        return "";
    }
}

