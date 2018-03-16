using Spire.Doc;
using Spire.Doc.Fields.Caculation;
using System;

internal class Class80
{
    private bool bool_0 = true;
    private bool bool_1;
    private bool bool_2;
    internal const int int_0 = 0x5a0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7 = 0x5a0;
    private MathBreakOnBinary mathBreakOnBinary_0;
    private MathBreakOnBinarySubtraction mathBreakOnBinarySubtraction_0;
    private MathJustification mathJustification_0 = MathJustification.CenterGroup;
    private MathLimitLocation mathLimitLocation_0;
    private MathLimitLocation mathLimitLocation_1 = MathLimitLocation.UnderOver;
    private string string_0 = "";

    internal Class80 method_0()
    {
        return (Class80) base.MemberwiseClone();
    }

    internal bool method_1()
    {
        if (((((this.mathBreakOnBinary_0 == MathBreakOnBinary.Before) && (this.mathBreakOnBinarySubtraction_0 == MathBreakOnBinarySubtraction.MinusMinus)) && ((this.mathJustification_0 == MathJustification.CenterGroup) && this.bool_0)) && (((this.mathLimitLocation_0 == MathLimitLocation.SubscriptSuperscript) && (this.int_1 == 0)) && ((this.int_2 == 0) && (this.int_3 == 0)))) && ((((this.int_4 == 0) && !(this.string_0 != "")) && ((this.mathLimitLocation_1 == MathLimitLocation.UnderOver) && (this.int_5 == 0))) && (((this.int_6 == 0) && !this.bool_1) && (this.int_7 == 0x5a0))))
        {
            return this.bool_2;
        }
        return true;
    }

    internal int method_10()
    {
        return this.int_1;
    }

    internal void method_11(int A_0)
    {
        this.int_1 = A_0;
    }

    internal int method_12()
    {
        return this.int_2;
    }

    internal void method_13(int A_0)
    {
        this.int_2 = A_0;
    }

    internal MathLimitLocation method_14()
    {
        return this.mathLimitLocation_0;
    }

    internal void method_15(MathLimitLocation A_0)
    {
        int num = 7;
        if (A_0 == MathLimitLocation.Undefined)
        {
            throw new ArgumentException(BookmarkStart.b("礬䜮堰䀲ᔴ制圸为值Ἶ㝀≂⥄㉆ⱈ歊⑌㱎煐㵒㩔⍖祘㩚ㅜ㍞๠ᑢdͦ䝨", num));
        }
        this.mathLimitLocation_0 = A_0;
    }

    internal int method_16()
    {
        return this.int_3;
    }

    internal void method_17(int A_0)
    {
        this.int_3 = A_0;
    }

    internal int method_18()
    {
        return this.int_4;
    }

    internal void method_19(int A_0)
    {
        this.int_4 = A_0;
    }

    internal MathBreakOnBinary method_2()
    {
        return this.mathBreakOnBinary_0;
    }

    internal string method_20()
    {
        return this.string_0;
    }

    internal void method_21(string A_0)
    {
        if (Class567.smethod_16(A_0))
        {
            this.string_0 = A_0;
        }
    }

    internal MathLimitLocation method_22()
    {
        return this.mathLimitLocation_1;
    }

    internal void method_23(MathLimitLocation A_0)
    {
        int num = 0;
        if (A_0 == MathLimitLocation.Undefined)
        {
            throw new ArgumentException(BookmarkStart.b("爥䀧䌩弫อ唯就䄳嬵ᠷ䰹崻刽㔿❁摃⽅㭇橉≋⅍⑏牑㕓㩕㑗㕙⭛㭝џ䱡", num));
        }
        this.mathLimitLocation_1 = A_0;
    }

    internal int method_24()
    {
        return this.int_5;
    }

    internal void method_25(int A_0)
    {
        this.int_5 = A_0;
    }

    internal int method_26()
    {
        return this.int_6;
    }

    internal void method_27(int A_0)
    {
        this.int_6 = A_0;
    }

    internal bool method_28()
    {
        return this.bool_1;
    }

    internal void method_29(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal void method_3(MathBreakOnBinary A_0)
    {
        this.mathBreakOnBinary_0 = A_0;
    }

    internal int method_30()
    {
        return this.int_7;
    }

    internal void method_31(int A_0)
    {
        this.int_7 = A_0;
    }

    internal bool method_32()
    {
        return this.bool_2;
    }

    internal void method_33(bool A_0)
    {
        this.bool_2 = A_0;
    }

    internal MathBreakOnBinarySubtraction method_4()
    {
        return this.mathBreakOnBinarySubtraction_0;
    }

    internal void method_5(MathBreakOnBinarySubtraction A_0)
    {
        this.mathBreakOnBinarySubtraction_0 = A_0;
    }

    internal MathJustification method_6()
    {
        return this.mathJustification_0;
    }

    internal void method_7(MathJustification A_0)
    {
        this.mathJustification_0 = A_0;
    }

    internal bool method_8()
    {
        return this.bool_0;
    }

    internal void method_9(bool A_0)
    {
        this.bool_0 = A_0;
    }
}

