using Spire.Doc;
using System;
using System.Text;

internal class Class148 : Class147
{
    internal Class148(int A_0) : base(A_0)
    {
    }

    protected void method_25(Class148 A_0, Class148 A_1)
    {
        int num = base.method_4();
        for (int i = 0; i < num; i++)
        {
            int num4 = base.method_16(i);
            Class434 class3 = (Class434) base.method_18(i);
            class3.int_0 = 0;
            for (int j = 0; j < num; j++)
            {
                Class760 class2 = new Class760(A_0.method_16(j), A_1.method_16(j));
                if (!class2.method_1() && class2.method_0(num4))
                {
                    class3.int_0++;
                }
                if (class2.method_2() > num4)
                {
                    break;
                }
            }
        }
    }

    internal void method_26(Class148 A_0, int A_1)
    {
        int num = base.method_4();
        for (int i = 0; i < A_0.method_4(); i++)
        {
            Class434 class2 = (Class434) A_0.method_18(i);
            class2.int_1 += num;
            int num3 = A_0.method_16(i);
            base.method_6(A_1 + num3, class2);
        }
    }

    internal string method_27()
    {
        int num = 0x11;
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < base.method_4(); i++)
        {
            Class434 class2 = (Class434) base.method_18(i);
            builder.AppendFormat(BookmarkStart.b("氶䈸଺䀼ጾ㩀牂㡄歆㉈祊が቎", num), base.method_16(i), class2.int_1, class2.int_0);
        }
        return builder.ToString();
    }
}

