using Spire.Doc;
using System;
using System.Text;

internal class Class493
{
    private Class493()
    {
    }

    public static Guid smethod_0(params object[] A_0)
    {
        return Guid.NewGuid();
    }

    private static int smethod_1(object A_0)
    {
        int num = 2;
        if (A_0 is byte[])
        {
            byte[] buffer = (byte[]) A_0;
            A_0 = smethod_2(buffer, 0, Math.Min(0x100, buffer.Length));
        }
        if (A_0 is string)
        {
            return smethod_3((string) A_0);
        }
        if (!(A_0 is int) && !(A_0 is Enum))
        {
            throw new NotImplementedException(BookmarkStart.b("簧匩尫䬭ု崱刳ᘵ圷堹嘻嬽⌿㙁摃⽅㭇橉≋⅍⑏牑❓⍕⡗⩙㍛ⱝᑟݡc䡥", num));
        }
        return (int) A_0;
    }

    public static string smethod_2(byte[] A_0, int A_1, int A_2)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            return BookmarkStart.b("砵䴷嘹倻", num);
        }
        StringBuilder builder = new StringBuilder();
        while (A_2 > 0)
        {
            builder.AppendFormat(BookmarkStart.b("䴵࠷9搻ఽ㴿扁", num), A_0[A_1]);
            A_1++;
            A_2--;
        }
        return builder.ToString();
    }

    public static int smethod_3(string A_0)
    {
        int num = 0x15051505;
        int num2 = 0x15051505;
        int num3 = 0;
        for (int i = A_0.Length; i > 0; i -= 4)
        {
            int num9 = A_0[num3];
            int num6 = (i > 1) ? A_0[num3 + 1] : 0;
            int num5 = (i > 2) ? A_0[num3 + 2] : 0;
            int num7 = (i > 3) ? A_0[num3 + 3] : 0;
            int num8 = num6;
            num8 = num8 << 0x10;
            num8 += num9;
            int num10 = num7;
            num10 = num10 << 0x10;
            num10 += num5;
            num = (((num << 5) + num) + (num >> 0x1b)) ^ num8;
            if (i <= 2)
            {
                break;
            }
            num2 = (((num2 << 5) + num2) + (num2 >> 0x1b)) ^ num10;
            num3 += 4;
        }
        return (num + (num2 * 0x5d588b65));
    }
}

