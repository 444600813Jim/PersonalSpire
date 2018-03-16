using Spire.Doc;
using System;

internal class Class1048
{
    internal bool bool_0;
    internal bool bool_1;
    internal readonly Class411 class411_0 = new Class411();
    internal readonly Class411 class411_1 = new Class411();
    internal readonly Class411 class411_2 = new Class411();
    internal readonly Class411 class411_3 = new Class411();
    private float float_0;

    internal Class1048()
    {
    }

    internal void method_0(Class400 A_0)
    {
        int num = 0x12;
        this.class411_0.method_0(A_0, BookmarkStart.b("䰷唹䰻", 0x12));
        this.class411_1.method_0(A_0, BookmarkStart.b("娷唹䠻䨽⼿⽁", 0x12));
        this.class411_2.method_0(A_0, BookmarkStart.b("吷弹娻䨽", 0x12));
        this.class411_3.method_0(A_0, BookmarkStart.b("䨷匹嬻嘽㐿", 0x12));
        if (this.bool_0)
        {
            A_0.method_40(BookmarkStart.b("䬷丹䔻刽┿硁㝃⹅⥇⹉⍋㥍", num), string.Format(BookmarkStart.b("ᬷਹ఻฽瀿牁瑃晅㍇穉ㅋ湍⭏捑⥓", num), Class576.smethod_42((double) this.float_0), Class576.smethod_42((double) this.float_0)));
        }
    }

    internal bool method_1(bool A_0, bool A_1)
    {
        bool flag = false;
        if (this.method_2(this.class411_0, A_0, A_1))
        {
            flag = true;
        }
        if (this.method_2(this.class411_1, A_0, A_1))
        {
            flag = true;
        }
        if (this.method_2(this.class411_2, A_0, A_1))
        {
            flag = true;
        }
        if (this.method_2(this.class411_3, A_0, A_1))
        {
            flag = true;
        }
        return flag;
    }

    private bool method_2(Class411 A_0, bool A_1, bool A_2)
    {
        if ((A_0.border_0 != null) && A_0.border_0.Shadow)
        {
            this.bool_0 = true;
            if (A_0.border_0.LineWidth > this.float_0)
            {
                this.float_0 = A_0.border_0.LineWidth;
            }
        }
        A_0.bool_0 = this.bool_1;
        if (!A_0.method_1(A_1, A_2))
        {
            return this.bool_0;
        }
        return true;
    }
}

