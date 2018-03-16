using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;
using System.IO;

internal class Class399 : Class398
{
    internal Class399(Stream A_0, bool A_1) : base(A_0, new UTF8Encoding(false), A_1, true)
    {
    }

    internal void method_58()
    {
        base.method_0().method_17(true);
        base.method_0().method_19(BookmarkStart.b("場䐶嘸ᘺ尼伾ㅀ⽂ⱄ⑆⡈㽊⑌⁎㽐", 15), BookmarkStart.b("䔴䔶嘸尺吼嬾籀慂ቄ⡆㭈⽊捌୎㹐げ⁔㩖㱘㕚⥜絞", 15));
        base.method_0().method_24(BookmarkStart.b("䈴", 15), BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㹒㱔㑖⭘㑚⹜ぞݠᝢ䭤Ѧ٨٪䉬nᝰᕲᱴᑶᱸ呺੼ၾꪄ떆릈뮊뺌ꂎﲒ", 15));
        base.method_4(BookmarkStart.b("䈴ശ丸吺似嬾Հⱂ♄㉆⑈⹊⍌㭎", 15));
    }

    internal void method_59(string A_0, string A_1, DateTime A_2, string A_3, bool A_4)
    {
        int num = 13;
        if (A_4)
        {
            base.method_4(string.Format(BookmarkStart.b("䐲༴䰶स䘺", num), A_3));
            base.method_40(BookmarkStart.b("䐲༴帶崸", num), A_0);
            base.method_40(BookmarkStart.b("䐲༴嘶䰸伺唼倾㍀", num), A_1);
        }
        else
        {
            base.method_4(BookmarkStart.b("刲場嬶̸娺匼儾⹀㝂⑄㍆⁈⑊⍌", num));
            base.method_40(BookmarkStart.b("刲場嬶̸刺夼", num), A_0);
            base.method_40(BookmarkStart.b("刲場嬶̸娺䠼䬾⥀ⱂ㝄", num), A_1);
            base.method_40(BookmarkStart.b("刲場嬶̸堺似娾⁀㝂⁄⍆⡈㽊⡌", num), Class1041.smethod_0(A_2));
            base.method_40(BookmarkStart.b("䐲༴䌶䀸䬺堼", num), A_3);
        }
    }

    internal override void vmethod_10(Class578 A_0, int A_1)
    {
        int num = 2;
        string str = A_0.method_6() ? BookmarkStart.b("缧䔩師䨭ḯ笱娳䔵崷䠹䠻圽⼿ⱁ", num) : BookmarkStart.b("缧䔩師䨭ḯ簱䄳嬵娷弹主圽⸿╁", num);
        this.method_59(A_1.ToString(), A_0.method_0(), A_0.method_2(), str, false);
        if (A_0.method_5())
        {
            base.method_18(BookmarkStart.b("弧ဩ䌫尭夯唱崳堵夷嘹", num), Class114.smethod_1(A_0));
        }
        base.method_6(BookmarkStart.b("䤧䜩䀫ᐭ儯就娳夵䰷嬹䠻圽⼿ⱁ", num));
    }

    internal override void vmethod_11(Class579 A_0, int A_1)
    {
        this.vmethod_12(A_0, A_1.ToString(), false);
    }

    internal override void vmethod_12(Class579 A_0, string A_1, bool A_2)
    {
        int num = 9;
        if (A_2)
        {
            this.method_59(A_1, A_0.method_0(), A_0.method_2(), (A_0.method_4() == EditRevisionType.Insertion) ? BookmarkStart.b("䘮弰䀲", num) : BookmarkStart.b("䬮吰弲", num), true);
            base.method_6(string.Format(BookmarkStart.b("堮ର䠲Դ䨶", num), (A_0.method_4() == EditRevisionType.Insertion) ? BookmarkStart.b("䘮弰䀲", num) : BookmarkStart.b("䬮吰弲", num)));
        }
        else
        {
            string str = (A_0.method_4() == EditRevisionType.Insertion) ? BookmarkStart.b("砮帰䄲儴ᤶ瀸唺丼娾㍀㝂ⱄ⡆❈", num) : BookmarkStart.b("砮帰䄲儴ᤶ紸帺儼娾㕀⩂⩄⥆", num);
            this.method_59(A_1, A_0.method_0(), A_0.method_2(), str, false);
            base.method_6(BookmarkStart.b("丮尰弲༴嘶圸唺刼䬾⁀㝂ⱄ⡆❈", num));
        }
    }

    protected override void vmethod_3(string A_0, Border A_1, bool A_2)
    {
        int num = 11;
        if (!A_2)
        {
            base.method_33(A_0, new object[] { BookmarkStart.b("䘰ल䌴嘶唸", num), Class911.smethod_7(A_1.BorderType), BookmarkStart.b("䘰ल䘴䴶", num), (int) (A_1.LineWidth * 8f), BookmarkStart.b("䘰䬲༴唶崸䤺䨼嘾╀㝂ⵄ", num), (int) Math.Round((double) (A_1.LineWidth * 20f)), BookmarkStart.b("䘰ल䘴䜶堸堺堼", num), A_1.Space, BookmarkStart.b("䘰ल嘴堶唸吺似", num), A_1.Color, BookmarkStart.b("䘰ल䘴弶堸强刼䠾", num), Class398.smethod_10(A_1.Shadow), BookmarkStart.b("䘰ल匴䔶堸嘺堼", num), Class398.smethod_10(A_1.Frame) });
        }
        else
        {
            base.method_33(A_0, new object[] { BookmarkStart.b("䘰ल䌴嘶唸", num), Class911.smethod_7(A_1.BorderType), BookmarkStart.b("䘰ल䘴䴶", num), (int) (A_1.LineWidth * 8f), BookmarkStart.b("䘰ल䘴䜶堸堺堼", num), A_1.Space, BookmarkStart.b("䘰ल嘴堶唸吺似", num), A_1.Color, BookmarkStart.b("䘰ल䘴弶堸强刼䠾", num), Class398.smethod_10(A_1.Shadow), BookmarkStart.b("䘰ल匴䔶堸嘺堼", num), Class398.smethod_10(A_1.Frame) });
        }
    }

    internal override void vmethod_4(Class16 A_0)
    {
        int num = 8;
        if (A_0 != null)
        {
            base.method_33(BookmarkStart.b("夭ਯ䄱尳刵", num), new object[] { BookmarkStart.b("夭ਯ䐱唳娵", num), Class417.smethod_35(A_0.method_62(), false), BookmarkStart.b("夭ਯ儱嬳娵圷䠹", num), A_0.method_60(), BookmarkStart.b("夭ਯ吱崳娵吷", num), A_0.method_56() });
        }
    }

    internal override void vmethod_5(Class580 A_0, string A_1, int A_2)
    {
        this.method_59(A_2.ToString(), A_0.method_0(), A_0.method_2(), BookmarkStart.b("砮帰䄲儴ᤶ缸吺似刾⁀㝂ㅄ⹆❈ⱊ", 9), false);
        base.method_4(BookmarkStart.b("丮尰弲༴吶嘸唺䤼娾⽀㝂", 9));
    }

    internal override void vmethod_6(Class579 A_0, int A_1)
    {
        this.vmethod_7(A_0, A_1.ToString(), false);
    }

    internal override void vmethod_7(Class579 A_0, string A_1, bool A_2)
    {
        int num = 12;
        if (A_2)
        {
            this.method_59(A_1, A_0.method_0(), A_0.method_2(), (A_0.method_4() == EditRevisionType.Insertion) ? BookmarkStart.b("嬱娳䔵", num) : BookmarkStart.b("嘱儳娵", num), A_2);
        }
        else
        {
            string str = (A_0.method_4() == EditRevisionType.Insertion) ? BookmarkStart.b("攱嬳䐵尷ᐹ画倽㌿❁㙃㉅ⅇ╉≋", num) : BookmarkStart.b("攱嬳䐵尷ᐹ砻嬽ⰿ❁ぃ⽅❇⑉", num);
            this.method_59(A_1, A_0.method_0(), A_0.method_2(), str, false);
            base.method_4(BookmarkStart.b("匱夳娵ȷ夹医倽㐿❁⩃㉅", num));
        }
    }

    internal override void vmethod_8()
    {
        this.vmethod_9(EditRevisionType.Insertion, false);
    }

    internal override void vmethod_9(EditRevisionType A_0, bool A_1)
    {
        int num = 8;
        if (A_1)
        {
            base.method_6(string.Format(BookmarkStart.b("夭ਯ䤱г䬵", num), (A_0 == EditRevisionType.Insertion) ? BookmarkStart.b("䜭帯䄱", num) : BookmarkStart.b("䨭唯帱", num)));
        }
        else
        {
            base.method_6(BookmarkStart.b("伭崯帱ำ唵圷吹䠻嬽⸿㙁", num));
            base.method_6(BookmarkStart.b("伭崯帱ำ圵嘷吹医䨽ℿ㙁ⵃ⥅♇", num));
        }
    }
}

