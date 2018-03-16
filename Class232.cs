using Spire.Doc;
using System;
using System.Text;

internal class Class232 : Class231
{
    private Class398 class398_0;

    internal void method_3(Class460 A_0, Class421 A_1)
    {
        this.class398_0 = A_1.Interface52.imethod_1();
        base.method_0(A_0, A_1);
    }

    protected override void vmethod_0(string A_0)
    {
        this.class398_0.method_24(BookmarkStart.b("娬ᔮ唰刲䄴嘶樸吺䠼䴾≀♂", 7), A_0);
    }

    protected override void vmethod_1(string A_0)
    {
        this.class398_0.method_24(BookmarkStart.b("䈴ശ儸帺尼嬾⑀ㅂᙄ⡆㱈㥊⹌⩎", 15), A_0);
    }

    protected override void vmethod_2(string A_0)
    {
        this.class398_0.method_24(BookmarkStart.b("䜯࠱䜳䐵嬷", 10), A_0);
    }

    protected override void vmethod_3(Class1035 A_0)
    {
        int num = 14;
        foreach (OdsoRecipientData data in A_0.method_15())
        {
            this.class398_0.method_4(BookmarkStart.b("䌳వ䨷弹弻圽〿⭁⅃⡅㱇้ⵋ㩍ㅏ", num));
            if (!data.Active)
            {
                this.class398_0.method_28(BookmarkStart.b("䌳వ夷夹䠻圽㘿❁", num), 0);
            }
            this.class398_0.method_32(BookmarkStart.b("䌳వ嬷唹倻䬽ⴿⱁ", num), data.Column, 0);
            this.class398_0.method_32(BookmarkStart.b("䌳వ倷嬹伻嘽", num), data.Hash, 0);
            byte[] uniqueTag = data.UniqueTag;
            if (uniqueTag != null)
            {
                this.class398_0.method_24(BookmarkStart.b("䌳వ䴷吹唻伽㔿❁၃❅⽇", num), Encoding.Unicode.GetString(uniqueTag, 0, uniqueTag.Length));
            }
            this.class398_0.method_5();
        }
    }

    protected override void vmethod_4(Class1035 A_0)
    {
        int num = 0x12;
        this.class398_0.method_24(BookmarkStart.b("伷9嘻娽㌿ⵁ၃㽅㡇⽉", 0x12), Class533.smethod_7(A_0.method_9(), false));
        if (A_0.method_3())
        {
            this.class398_0.method_28(BookmarkStart.b("伷9娻瘽␿ぁ", num), 1);
        }
    }
}

