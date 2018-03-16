using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;

internal class Class42 : AttrCollection
{
    private static readonly Class42 class42_0 = new Class42();
    protected FormFieldType formFieldType_0;
    internal const int int_10 = 0x8a;
    internal const int int_11 = 0xff;
    internal const int int_12 = 0x20;
    internal const int int_7 = 20;
    internal const int int_8 = 0xff;
    internal const int int_9 = 0x40;

    static Class42()
    {
        class42_0.SetAttr(0x5208, false);
        class42_0.SetAttr(0x5212, false);
        class42_0.SetAttr(0x521c, false);
        class42_0.SetAttr(0x5226, 20);
        class42_0.SetAttr(0x5230, true);
        class42_0.SetAttr(0x523a, 0);
        class42_0.SetAttr(0x5244, null);
        class42_0.SetAttr(0x524e, 0);
        class42_0.SetAttr(0x5258, true);
        class42_0.SetAttr(0x5262, "");
        class42_0.SetAttr(0x526c, "");
        class42_0.SetAttr(0x5276, "");
        class42_0.SetAttr(0x5278, false);
        class42_0.SetAttr(0x5280, "");
        class42_0.SetAttr(0x528a, "");
        class42_0.SetAttr(0x528c, false);
        class42_0.SetAttr(0x5294, "");
        class42_0.SetAttr(0x529e, "");
        class42_0.SetAttr(0x52a8, 0);
        class42_0.SetAttr(0x52b2, TextFormFieldType.RegularText);
    }

    internal string method_46()
    {
        return (string) base.method_32(0x5280);
    }

    internal void method_47(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("儦䠨䜪堬䨮", 1));
        this.SetAttr(0x5280, smethod_5(A_0, 20));
    }

    internal bool method_48()
    {
        return (bool) base.method_32(0x5258);
    }

    internal void method_49(bool A_0)
    {
        this.SetAttr(0x5258, A_0);
    }

    internal bool method_50()
    {
        return (bool) base.method_32(0x5208);
    }

    internal void method_51(bool A_0)
    {
        this.SetAttr(0x5208, A_0);
    }

    internal string method_52()
    {
        return (string) base.method_32(0x5262);
    }

    internal void method_53(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("倥䤧䘩夫䬭", 0));
        this.SetAttr(0x5262, smethod_5(A_0, 0x20));
    }

    internal string method_54()
    {
        return (string) base.method_32(0x526c);
    }

    internal void method_55(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䈳圵吷伹夻", 14));
        this.SetAttr(0x526c, smethod_5(A_0, 0x20));
    }

    internal bool method_56()
    {
        return (bool) base.method_32(0x5278);
    }

    internal void method_57(bool A_0)
    {
        this.SetAttr(0x5278, A_0);
    }

    internal string method_58()
    {
        return (string) base.method_32(0x5276);
    }

    internal void method_59(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("堭儯帱䄳匵", 8));
        this.SetAttr(0x5276, smethod_5(A_0, 0xff));
    }

    internal bool method_60()
    {
        return (bool) base.method_32(0x528c);
    }

    internal void method_61(bool A_0)
    {
        this.SetAttr(0x528c, A_0);
    }

    internal string method_62()
    {
        return (string) base.method_32(0x528a);
    }

    internal void method_63(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("䜰刲头䈶尸", 11));
        this.SetAttr(0x528a, smethod_5(A_0, 0x8a));
    }

    internal int method_64()
    {
        return (int) base.method_32(0x52a8);
    }

    internal void method_65(int A_0)
    {
        this.SetAttr(0x52a8, A_0);
    }

    internal TextFormFieldType method_66()
    {
        return (TextFormFieldType) base.method_32(0x52b2);
    }

    internal void method_67(TextFormFieldType A_0)
    {
        this.SetAttr(0x52b2, A_0);
    }

    internal string method_68()
    {
        return (string) base.method_32(0x5294);
    }

    internal void method_69(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("儦䠨䜪堬䨮", 1));
        this.SetAttr(0x5294, smethod_5(A_0, 0xff));
    }

    internal string method_70()
    {
        return (string) base.method_32(0x529e);
    }

    internal void method_71(string A_0)
    {
        Class567.smethod_20(A_0, BookmarkStart.b("央倰弲䀴制", 9));
        this.SetAttr(0x529e, smethod_5(A_0, 0x40));
    }

    internal bool method_72()
    {
        return (bool) base.method_32(0x5230);
    }

    internal void method_73(bool A_0)
    {
        this.SetAttr(0x5230, A_0);
    }

    internal int method_74()
    {
        return (int) base.method_32(0x5226);
    }

    internal void method_75(int A_0)
    {
        this.SetAttr(0x5226, A_0);
    }

    internal bool method_76()
    {
        return (bool) base.method_32(0x521c);
    }

    internal void method_77(bool A_0)
    {
        this.SetAttr(0x521c, A_0);
    }

    internal bool method_78()
    {
        return (bool) base.method_32(0x5212);
    }

    internal void method_79(bool A_0)
    {
        this.SetAttr(0x5212, A_0);
    }

    internal bool method_80()
    {
        return base.method_6(0x5212);
    }

    internal int method_81()
    {
        return (int) base.method_32(0x523a);
    }

    internal void method_82(int A_0)
    {
        this.SetAttr(0x523a, A_0);
    }

    internal int method_83()
    {
        return (int) base.method_32(0x524e);
    }

    internal void method_84(int A_0)
    {
        this.SetAttr(0x524e, A_0);
    }

    internal bool method_85()
    {
        return base.method_6(0x524e);
    }

    internal DropDownCollection method_86()
    {
        DropDownCollection downs = (DropDownCollection) base.method_32(0x5244);
        if (downs == null)
        {
            downs = new DropDownCollection(new Document());
            this.SetAttr(0x5244, downs);
        }
        return downs;
    }

    internal FormFieldType method_87()
    {
        return this.formFieldType_0;
    }

    internal void method_88(FormFieldType A_0)
    {
        this.formFieldType_0 = A_0;
    }

    private static string smethod_5(string A_0, int A_1)
    {
        if (A_0.Length > A_1)
        {
            return A_0.Substring(0, A_1);
        }
        return A_0;
    }

    object FormatBase.GetDefValue(int A_0)
    {
        int num = A_0;
        if (num <= 0x5258)
        {
            if (num <= 0x5226)
            {
                if (num > 0x5212)
                {
                    if (num == 0x521c)
                    {
                        goto Label_0113;
                    }
                    if (num == 0x5226)
                    {
                        return 20;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x5208:
                        case 0x5212:
                            goto Label_0113;
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0x5230:
                    case 0x5258:
                        return true;

                    case 0x523a:
                    case 0x524e:
                        return 0;

                    case 0x5244:
                        return null;
                }
            }
        }
        else if (num <= 0x5280)
        {
            switch (num)
            {
                case 0x5276:
                case 0x5280:
                case 0x5262:
                case 0x526c:
                    goto Label_0142;

                case 0x5278:
                    goto Label_0113;
            }
        }
        else if (num > 0x5294)
        {
            switch (num)
            {
                case 0x529e:
                    goto Label_0142;

                case 0x52a8:
                    return 0;

                case 0x52b2:
                    return TextFormFieldType.RegularText;
            }
        }
        else
        {
            switch (num)
            {
                case 0x528a:
                case 0x5294:
                    goto Label_0142;

                case 0x528c:
                    goto Label_0113;
            }
        }
        return null;
    Label_0113:
        return false;
    Label_0142:
        return string.Empty;
    }
}

