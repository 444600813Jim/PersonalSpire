using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class907
{
    internal ArrayList arrayList_0 = new ArrayList();
    internal AutoFormatDocumentType autoFormatDocumentType_0;
    internal bool bool_0;
    internal bool bool_1;
    internal bool bool_10;
    internal bool bool_11;
    internal bool bool_12;
    internal bool bool_13;
    internal bool bool_14;
    internal bool bool_15;
    internal bool bool_16;
    internal bool bool_17;
    internal bool bool_18;
    internal bool bool_19;
    internal bool bool_2;
    internal bool bool_20 = true;
    internal bool bool_21;
    internal bool bool_22 = true;
    internal bool bool_23 = true;
    internal bool bool_24 = true;
    internal bool bool_25 = true;
    internal bool bool_26 = true;
    internal bool bool_27;
    internal bool bool_28;
    internal bool bool_29;
    internal bool bool_3;
    internal bool bool_30;
    internal bool bool_31;
    internal bool bool_32;
    internal bool bool_33;
    internal bool bool_34;
    internal bool bool_35;
    internal bool bool_36;
    internal bool bool_37;
    internal bool bool_38;
    internal bool bool_39;
    internal bool bool_4;
    internal bool bool_40 = true;
    internal bool bool_41;
    internal bool bool_42 = true;
    internal bool bool_43;
    internal bool bool_44;
    internal bool bool_45;
    internal bool bool_46;
    internal bool bool_47;
    internal bool bool_48;
    internal bool bool_49;
    internal bool bool_5;
    internal bool bool_50;
    internal bool bool_51;
    internal bool bool_52 = true;
    internal bool bool_53;
    internal bool bool_54;
    internal bool bool_55;
    internal bool bool_56;
    internal bool bool_57;
    internal bool bool_58;
    internal bool bool_59;
    internal bool bool_6;
    internal bool bool_60;
    internal bool bool_61;
    internal bool bool_62;
    internal bool bool_63;
    internal bool bool_64;
    internal bool bool_65;
    internal bool bool_66;
    internal bool bool_67 = true;
    internal bool bool_68;
    internal bool bool_69;
    internal bool bool_7;
    internal bool bool_70;
    internal bool bool_71;
    internal bool bool_8 = true;
    internal bool bool_9;
    private byte byte_0 = 11;
    internal CharacterSpacing characterSpacing_0;
    internal Class1079 class1079_0 = new Class1079();
    internal Class460 class460_0 = new Class460();
    internal Class514 class514_0 = new Class514();
    internal Class80 class80_0 = new Class80();
    private Class908 class908_0;
    internal Class957 class957_0 = new Class957();
    private Dictionary<string, string> dictionary_0;
    private Document document_0;
    internal float float_0 = 720f;
    internal FootEndnoteOptions footEndnoteOptions_0;
    private const int int_0 = 0;
    internal const int int_1 = 0;
    internal const int int_10 = 180;
    internal const int int_11 = 1;
    internal const int int_12 = 1;
    internal const int int_13 = 0x708;
    internal const int int_14 = 0x5a0;
    internal int int_15;
    internal int int_16 = 360;
    internal int int_17;
    internal int int_18;
    internal int int_19 = 180;
    internal const int int_2 = 1;
    internal int int_20 = 180;
    internal int int_21 = 1;
    internal int int_22 = 1;
    internal int int_23 = 0x708;
    internal int int_24 = 0x5a0;
    internal int int_25 = 0x60;
    internal int int_26;
    internal int int_27;
    internal int int_28 = 9;
    internal int int_29;
    internal const int int_3 = 2;
    internal int int_30;
    internal int int_31 = 0xfff;
    internal int int_32 = 0x5024;
    internal const int int_4 = 3;
    internal const int int_5 = 4;
    internal const int int_6 = 720;
    internal const int int_7 = 360;
    internal const int int_8 = 0x60;
    internal const int int_9 = 180;
    internal LocaleIDs localeIDs_0;
    internal ProofState proofState_0;
    internal ProofState proofState_1;
    internal const ScreenSize screenSize_0 = ScreenSize.Size800x600;
    internal ScreenSize screenSize_1 = ScreenSize.Size800x600;
    internal string string_0 = string.Empty;
    internal string string_1;
    internal string string_2;
    internal string string_3;
    internal string string_4;
    internal StylePaneSortMethod stylePaneSortMethod_0 = StylePaneSortMethod.Default;
    internal uint uint_0;
    internal ViewSetup viewSetup_0;

    internal Class907(Document A_0)
    {
        this.document_0 = A_0;
        this.footEndnoteOptions_0 = new FootEndnoteOptions(this.document_0, true);
        this.viewSetup_0 = new ViewSetup(this.document_0);
    }

    internal bool method_0()
    {
        if ((this.bool_15 && !this.bool_11) && (!this.bool_39 && !this.bool_38))
        {
            return this.bool_43;
        }
        return true;
    }

    internal bool method_1()
    {
        if ((!this.bool_22 && !this.bool_23) && (!this.bool_24 && !this.bool_25))
        {
            return this.bool_26;
        }
        return true;
    }

    internal bool method_10()
    {
        if (!this.bool_34 && !this.bool_35)
        {
            return this.bool_36;
        }
        return true;
    }

    internal void method_11(bool A_0)
    {
        switch (this.method_8())
        {
            case ProtectionType.NoProtection:
                this.bool_34 = false;
                this.bool_36 = false;
                this.bool_35 = false;
                return;

            case ProtectionType.AllowOnlyRevisions:
                this.bool_35 = A_0;
                return;

            case ProtectionType.AllowOnlyComments:
            case ProtectionType.AllowOnlyReading:
                this.bool_34 = A_0;
                return;

            case ProtectionType.AllowOnlyFormFields:
                this.bool_36 = A_0;
                return;
        }
    }

    internal Class907 method_12()
    {
        Class907 class2 = (Class907) base.MemberwiseClone();
        class2.class1079_0 = this.class1079_0.method_0();
        class2.class460_0 = this.class460_0.method_2();
        class2.footEndnoteOptions_0 = (FootEndnoteOptions) this.footEndnoteOptions_0.method_23();
        class2.viewSetup_0 = this.viewSetup_0.method_5(this.document_0);
        class2.class957_0 = new Class957(this.class957_0.method_0());
        class2.class514_0 = this.class514_0.method_6();
        class2.class80_0 = this.class80_0.method_0();
        class2.arrayList_0 = new ArrayList();
        foreach (string str in this.arrayList_0)
        {
            class2.arrayList_0.Add(str);
        }
        return class2;
    }

    internal void method_13(ProtectionType A_0, string A_1)
    {
        this.method_9(A_0);
        if (A_0 != ProtectionType.NoProtection)
        {
            this.method_11(true);
        }
        if (string.IsNullOrEmpty(A_1))
        {
            this.uint_0 = 0;
        }
        else if (A_0 != ProtectionType.NoProtection)
        {
            this.uint_0 = Class943.smethod_0(A_1);
        }
    }

    internal void method_2(bool A_0)
    {
        this.bool_22 = A_0;
        this.bool_23 = A_0;
        this.bool_24 = A_0;
        this.bool_25 = A_0;
        this.bool_26 = A_0;
    }

    internal byte method_3()
    {
        return this.byte_0;
    }

    internal void method_4(byte A_0)
    {
        this.byte_0 = A_0;
    }

    internal Class908 method_5()
    {
        if (this.class908_0 == null)
        {
            this.class908_0 = new Class908();
        }
        return this.class908_0;
    }

    internal void method_6(Class908 A_0)
    {
        this.class908_0 = A_0;
    }

    internal Dictionary<string, string> method_7()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, string>();
        }
        return this.dictionary_0;
    }

    internal ProtectionType method_8()
    {
        if (this.int_17 != 7)
        {
            if (this.int_17 == 2)
            {
                return ProtectionType.AllowOnlyFormFields;
            }
            if (this.bool_33 && (this.int_17 == 3))
            {
                return ProtectionType.AllowOnlyReading;
            }
            if (this.int_17 == 1)
            {
                return ProtectionType.AllowOnlyComments;
            }
            if (this.int_17 == 0)
            {
                return ProtectionType.AllowOnlyRevisions;
            }
        }
        return ProtectionType.NoProtection;
    }

    internal void method_9(ProtectionType A_0)
    {
        int num = 11;
        this.bool_32 = false;
        this.int_17 = 3;
        switch (A_0)
        {
            case ProtectionType.NoProtection:
                this.bool_33 = false;
                this.bool_32 = false;
                this.int_17 = 3;
                this.method_11(false);
                break;

            case ProtectionType.AllowOnlyRevisions:
                this.bool_32 = true;
                this.int_17 = 0;
                break;

            case ProtectionType.AllowOnlyComments:
                this.bool_32 = true;
                this.int_17 = 1;
                break;

            case ProtectionType.AllowOnlyFormFields:
                this.bool_32 = true;
                this.int_17 = 2;
                break;

            case ProtectionType.AllowOnlyReading:
                this.bool_33 = true;
                this.bool_32 = true;
                this.int_17 = 3;
                break;

            default:
                throw new ArgumentException(BookmarkStart.b("搰崲帴夶嘸䰺匼Ἶㅀㅂ⩄㍆ⱈ⡊㥌♎㹐㵒畔⑖⥘㹚㹜㙞ݠ੢dͦ䝨", num));
        }
        if ((this.method_8() != ProtectionType.NoProtection) && (this.uint_0 == 0))
        {
            this.uint_0 = 0;
        }
    }
}

