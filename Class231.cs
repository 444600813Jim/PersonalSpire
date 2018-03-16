using Spire.Doc;
using System;
using System.Collections;

internal abstract class Class231
{
    private Class460 class460_0;
    private Interface52 interface52_0;

    protected Class231()
    {
    }

    protected void method_0(Class460 A_0, Interface52 A_1)
    {
        int num = 1;
        if (!A_0.method_0())
        {
            this.class460_0 = A_0;
            this.interface52_0 = A_1;
            Class398 class2 = this.interface52_0.imethod_1();
            class2.method_4(BookmarkStart.b("倦ጨ䘪䰬䘮崰縲倴䔶常帺", num));
            class2.method_26(BookmarkStart.b("倦ጨ䘪䰬䘮弰眲娴吶䰸嘺堼儾㕀ᝂ㱄㝆ⱈ", num), Class533.smethod_1(this.class460_0.method_27(), A_1.imethod_2()));
            class2.method_31(BookmarkStart.b("倦ጨ䜪䐬䄮娰朲娴昶䰸帺似䘾", num), this.class460_0.method_21());
            class2.method_26(BookmarkStart.b("倦ጨ伪䰬嬮倰朲䰴䜶尸", num), Class533.smethod_5(this.class460_0.method_13(), A_1.imethod_2()));
            class2.method_25(BookmarkStart.b("倦ጨ䠪䈬䄮弰嘲嘴䌶樸伺似嘾⽀⑂", num), this.class460_0.method_9());
            class2.method_24(BookmarkStart.b("倦ጨ娪堬䨮䌰䨲", num), this.class460_0.method_31());
            this.vmethod_0(this.class460_0.method_11());
            this.vmethod_1(this.class460_0.method_19());
            class2.method_31(BookmarkStart.b("倦ጨ伪䈬愮帰䜲昴䈶䤸䬺似娾㉀あ݄⭆⡈╊♌͎㡐㵒ご⑖", num), this.class460_0.method_17());
            class2.method_24(BookmarkStart.b("倦ጨ伪䠬尮䔰娲嬴嘶䴸刺刼儾", num), Class533.smethod_3(this.class460_0.method_15(), A_1.imethod_2()));
            class2.method_24(BookmarkStart.b("倦ጨ䨪䤬䬮䌰嘲䘴䐶缸刺堼匾╀ൂ⑄⩆ⱈ", num), this.class460_0.method_5());
            class2.method_24(BookmarkStart.b("倦ጨ䘪䰬䘮崰怲䀴唶匸帺帼䬾", num), this.class460_0.method_25());
            class2.method_31(BookmarkStart.b("倦ጨ䘪䰬䘮崰爲䘴瘶䴸伺尼尾⥀⹂⁄⥆㵈", num), this.class460_0.method_23());
            class2.method_31(BookmarkStart.b("倦ጨ崪䐬䨮䘰縲倴䔶常帺夼笾⁀㝂⑄", num), this.class460_0.method_33());
            class2.method_32(BookmarkStart.b("倦ጨ䨪丬嬮堰䔲倴收尸堺刼䴾╀", num), this.class460_0.method_3(), 0);
            class2.method_32(BookmarkStart.b("倦ጨ䠪䔬䨮到堲瀴䔶䬸吺似䰾", num), (int) this.class460_0.method_7(), 2);
            this.method_1();
            class2.method_5();
        }
    }

    private void method_1()
    {
        Class398 class2 = this.interface52_0.imethod_1();
        class2.method_4(BookmarkStart.b("䜯࠱嬳刵䬷唹", 10));
        Class1035 class3 = this.class460_0.method_29();
        class2.method_24(BookmarkStart.b("䜯࠱䄳刵吷", 10), class3.method_11());
        class2.method_24(BookmarkStart.b("䜯࠱䀳圵娷嘹夻", 10), class3.method_7());
        this.vmethod_2(class3.method_5());
        int num = class3.method_1();
        class2.method_32(BookmarkStart.b("䜯࠱圳夵吷縹夻刽⤿⽁", 10), num, 0);
        this.vmethod_4(class3);
        using (IEnumerator enumerator = class3.method_13().System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class228 current = (Class228) enumerator.Current;
                this.method_2(current, class2);
            }
        }
        this.vmethod_3(class3);
        class2.method_5();
    }

    private void method_2(Class228 A_0, Class398 A_1)
    {
        int num = 7;
        A_1.method_4(BookmarkStart.b("娬ᔮ地娲倴嬶崸瘺尼伾Հ≂ㅄ♆", 7));
        A_1.method_24(BookmarkStart.b("娬ᔮ䔰䨲䔴制", 7), Class533.smethod_9(A_0.method_12(), this.interface52_0.imethod_2()));
        A_1.method_24(BookmarkStart.b("娬ᔮ弰刲場制", 7), A_0.method_10());
        A_1.method_24(BookmarkStart.b("娬ᔮ尰刲䔴䜶尸强猼帾ⱀ♂", 7), A_0.method_8());
        if (!this.interface52_0.imethod_2() || Class567.smethod_16(A_0.method_10()))
        {
            A_1.method_28(BookmarkStart.b("娬ᔮ到尲头䈶吸唺", num), A_0.method_1());
        }
        A_1.method_24(BookmarkStart.b("娬ᔮ崰娲儴", num), Class860.smethod_1((int) A_0.method_6(), this.interface52_0.imethod_2()));
        A_1.method_31(BookmarkStart.b("娬ᔮ唰䨲嬴嘶吸刺帼績╀❂㝄≆㩈㡊", num), A_0.method_4());
        A_1.method_5();
    }

    protected abstract void vmethod_0(string A_0);
    protected abstract void vmethod_1(string A_0);
    protected abstract void vmethod_2(string A_0);
    protected abstract void vmethod_3(Class1035 A_0);
    protected abstract void vmethod_4(Class1035 A_0);
}

