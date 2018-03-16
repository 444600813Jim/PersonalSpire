using Spire.Doc;
using System;
using System.IO;

internal class Class147 : Class146, Interface16
{
    private const int int_0 = 4;
    private readonly int int_1;

    internal Class147(int A_0)
    {
        this.int_1 = A_0;
    }

    void Interface16.imethod_0(BinaryReader A_0, int A_1, int A_2)
    {
        if (base.method_3() == 0)
        {
            base.method_8(A_1);
        }
        base.method_6(A_2, this.vmethod_0(A_0));
    }

    internal int method_20()
    {
        return ((base.method_3() * 4) + (base.method_4() * this.int_1));
    }

    internal int method_21()
    {
        return this.int_1;
    }

    internal int method_22()
    {
        return (this.int_1 + ((base.method_4() == 0) ? 8 : 4));
    }

    internal void method_23(BinaryReader A_0, Class1111 A_1)
    {
        A_0.BaseStream.Position = A_1.int_0;
        Class144.smethod_0(A_0, A_1.int_1, this.int_1, this, base.GetType().Name);
    }

    internal void method_24(int A_0)
    {
        for (int i = 0; i < base.method_3(); i++)
        {
            base.method_17(i, A_0 + (base.method_16(i) * 2));
        }
    }

    protected virtual object vmethod_0(BinaryReader A_0)
    {
        int num = 12;
        switch (this.int_1)
        {
            case 0:
                return null;

            case 4:
                return A_0.ReadInt32();
        }
        throw new InvalidOperationException(BookmarkStart.b("欱嬳䌵ᠷ吹夻嬽␿扁ぃ⥅桇╉㩋⭍≏⁑㵓㉕㵗穙⡛㙝य़ᅡ䑣୥൧ṩѫŭᑯ剱s᥵塷ࡹ᥻ώꊁ풃쪅쮇첉겋뢕", num));
    }

    internal virtual int vmethod_1(BinaryWriter A_0)
    {
        int num = 2;
        if (base.method_4() == 0)
        {
            return 0;
        }
        for (int i = 0; i < base.method_3(); i++)
        {
            A_0.Write(base.method_16(i));
        }
        for (int j = 0; j < base.method_4(); j++)
        {
            if (base.method_18(j) != null)
            {
                if (base.method_18(j) is int)
                {
                    A_0.Write((int) base.method_18(j));
                }
                else
                {
                    if (!(base.method_18(j) is Interface35))
                    {
                        throw new InvalidOperationException(BookmarkStart.b("欧䬩䈫䀭弯䘱ᐳ䄵䨷匹䠻嬽怿ቁࡃՅ็橉╋㩍㕏㽑瑓㑕㵗㥙㵛⭝፟ݡ䑣ཥᱧ䩩࡫ŭᕯű味ᡵ᝷๹屻᭽ꪉ얋\ud98d\ue28fﮑ流鍊뺝즟첡킣쎥\udaa7\ucca9춫춭햯鲱", num));
                    }
                    ((Interface35) base.method_18(j)).imethod_0(A_0);
                }
            }
        }
        return this.method_20();
    }
}

