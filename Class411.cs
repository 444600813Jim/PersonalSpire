using Spire.Doc;
using Spire.Doc.Formatting;
using System;

internal class Class411
{
    internal bool bool_0;
    internal Border border_0;
    internal double double_0 = double.NaN;
    internal double double_1 = double.NaN;
    internal double double_2 = double.NaN;
    internal string string_0;
    internal string string_1;
    internal string string_2;
    internal string string_3;

    internal void method_0(Class400 A_0, string A_1)
    {
        A_0.method_40(string.Format(BookmarkStart.b("䀥䜧ဩ尫伭启嘱崳堵強᜹䜻฽㴿", 0), A_1), this.string_2);
        A_0.method_40(string.Format(BookmarkStart.b("䀥䜧ဩ丫䄭䈯嘱儳䐵ᔷ䄹఻䌽", 0), A_1), this.string_0);
        A_0.method_40(string.Format(BookmarkStart.b("䀥䜧ဩ䄫伭䈯唱崳堵ᔷ䄹఻䌽", 0), A_1), this.string_3);
        A_0.method_40(string.Format(BookmarkStart.b("唥尧匩䀫䬭ਯ倱嬳䐵尷弹主ጽⰿ⭁⩃⍅敇㵉╋⩍⑏㩑祓ⵕ桗❙", 0), A_1), this.string_1);
    }

    internal bool method_1(bool A_0, bool A_1)
    {
        double num4;
        int num = 10;
        double d = A_1 ? 0.0 : double.NaN;
        if (this.border_0 != null)
        {
            double num2 = Class576.smethod_44((double) this.border_0.Space);
            if (A_1)
            {
                d = num2;
                if (double.IsNaN(this.double_2))
                {
                    num4 = num2 - Class576.smethod_44((double) this.border_0.LineWidth);
                }
                else if (!double.IsNaN(this.double_0))
                {
                    num4 = (this.double_0 - num2) - Class576.smethod_44((double) this.border_0.LineWidth);
                }
                else if (!double.IsNaN(this.double_1))
                {
                    num4 = (this.double_1 - num2) - Class576.smethod_44((double) this.border_0.LineWidth);
                }
                else
                {
                    num4 = (this.double_2 - num2) - Class576.smethod_44((double) this.border_0.LineWidth);
                }
                if (this.bool_0)
                {
                    double num5 = num4;
                    num4 = d;
                    d = num5;
                }
            }
            else
            {
                if (double.IsNaN(this.double_2))
                {
                    d = (num2 == 0.0) ? double.NaN : num2;
                }
                else
                {
                    d = ((this.double_2 - num2) == 0.0) ? double.NaN : (this.double_2 - num2);
                }
                num4 = this.double_2;
            }
            if (Class922.smethod_34(this.border_0.BorderType) == BookmarkStart.b("启崱䄳吵吷弹", num))
            {
                string str = Class576.smethod_42(Class576.smethod_59(this.border_0.BorderType, (int) this.border_0.LineWidth) / 3.0);
                this.string_1 = string.Format(BookmarkStart.b("䬯ȱ䤳ᘵ䌷ହ䄻ḽ㬿灁㥃", num), str, str, str);
            }
            this.string_0 = Class576.smethod_58(this.border_0, A_0);
        }
        else if (!double.IsNaN(this.double_0))
        {
            num4 = this.double_0;
        }
        else if (!double.IsNaN(this.double_1))
        {
            num4 = this.double_1;
        }
        else
        {
            num4 = this.double_2;
        }
        if (!double.IsNaN(num4) && (num4 >= 0.0))
        {
            this.string_3 = Class576.smethod_54(num4);
        }
        if (!double.IsNaN(d) && (d >= 0.0))
        {
            this.string_2 = Class576.smethod_54(d);
        }
        if ((this.string_2 == null) && (this.string_0 == null))
        {
            return (this.string_3 != null);
        }
        return true;
    }
}

