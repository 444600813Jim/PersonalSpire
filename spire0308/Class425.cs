using Spire.Doc;
using System;

internal class Class425 : Class424
{
    private readonly byte[] byte_1;
    private readonly byte[] byte_2;
    private readonly byte[] byte_3;

    internal Class425(Class394 A_0)
    {
        int num = 4;
        while (A_0.method_19())
        {
            if (!base.method_0(A_0))
            {
                string str = A_0.method_1();
                if (str == null)
                {
                    goto Label_00B3;
                }
                if (str != BookmarkStart.b("伩䈫䴭䈯䬱䐳䈵崷帹樻嬽㈿⭁≃⽅ⵇ㡉ы⽍⍏㩑ᵓ㡕⡗⽙⡛", num))
                {
                    if (!(str == BookmarkStart.b("伩䈫䴭䈯䬱䐳䈵崷帹樻嬽㈿⭁≃⽅ⵇ㡉ы⽍⍏㩑ɓ㝕㑗⽙㥛", num)))
                    {
                        if (!(str == BookmarkStart.b("伩䈫䴭䈯䬱䐳䈵崷帹眻嬽㤿ᑁ╃⩅㵇⽉", num)))
                        {
                            goto Label_00B3;
                        }
                        this.byte_3 = Convert.FromBase64String(A_0.method_3());
                    }
                    else
                    {
                        this.byte_2 = Convert.FromBase64String(A_0.method_3());
                    }
                }
                else
                {
                    this.byte_1 = Convert.FromBase64String(A_0.method_3());
                }
            }
        }
        return;
    Label_00B3:
        throw new InvalidOperationException(BookmarkStart.b("缩䈫䔭帯崱䌳堵ᠷ丹崻夽怿ⱁ╃⭅ⵇ灉汋", num) + A_0.method_1());
    }

    internal byte[] method_10()
    {
        return this.byte_1;
    }

    internal byte[] method_11()
    {
        return this.byte_2;
    }

    internal byte[] method_12()
    {
        return this.byte_3;
    }
}

