using Spire.Doc;
using System;
using System.IO;

internal class Class455 : Class453
{
    private readonly Guid guid_0;
    private readonly Stream stream_0;
    private readonly string string_0;
    private readonly string string_1;

    internal Class455(Stream A_0, string A_1)
    {
        this.stream_0 = A_0;
        this.string_1 = A_1;
    }

    internal Class455(Stream A_0, string A_1, string A_2, Guid A_3)
    {
        this.stream_0 = A_0;
        this.string_1 = A_1;
        this.string_0 = A_2;
        this.guid_0 = A_3;
    }

    internal string method_3()
    {
        return this.string_0;
    }

    internal Guid method_4()
    {
        return this.guid_0;
    }

    internal Stream method_5()
    {
        return this.stream_0;
    }

    internal string method_6()
    {
        return this.string_1;
    }

    internal override string vmethod_0(string A_0)
    {
        return this.string_1;
    }

    internal override string vmethod_1(string A_0)
    {
        return Class680.smethod_0(this.string_1);
    }

    internal override void vmethod_2(Stream A_0, string A_1)
    {
        int num = 5;
        if ((((this.string_1 == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䩦٨൪୬ٮተᙲᅴᡶ᩸๺ၼ᩾ꮄ麗力ﶔﲘ辠킢춤슦첨\udfaa", 5)) || (this.string_1 == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈♊㹌扎㑐⭒㙔㉖㕘畚⹜㝞Ѡ٢ᅤ䥦Ѩ੪๬ᵮṰ㙲᭴ᙶ᭸᝺᡼᭾꾀늂랄", num))) || (this.string_1 == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䩦٨൪୬ٮተᙲᅴᡶ᩸๺ၼ᩾ꮄ麗力ﶔﲘ辠힢삤쪦\ud9a8\uc7aa첬\udbae\ud4b0", num))) || (this.string_1 == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈♊㹌扎㑐⭒㙔㉖㕘畚⥜㩞ౠ።।٦ᵨ๪䍬ɮၰၲݴᡶ㱸ᕺᱼᵾꦆ뢈릊", num)))
        {
            Class627.smethod_8(this.stream_0, A_0);
        }
        else
        {
            this.stream_0.Position = 0L;
            Class567.smethod_8(this.stream_0, A_0);
        }
    }
}

