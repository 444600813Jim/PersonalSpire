using Spire.Doc;
using System;

internal class Class460
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private Class1035 class1035_0 = new Class1035();
    private int int_0 = 1;
    private MailMergeCheckErrors mailMergeCheckErrors_0 = MailMergeCheckErrors.PauseOnError;
    private MailMergeDataType mailMergeDataType_0 = MailMergeDataType.None;
    private MailMergeDestination mailMergeDestination_0;
    private MailMergeLegacySeparator mailMergeLegacySeparator_0 = MailMergeLegacySeparator.Tab;
    private MailMergeLegacySeparator mailMergeLegacySeparator_1 = MailMergeLegacySeparator.Enter;
    private MailMergeLegacySeparator mailMergeLegacySeparator_2 = MailMergeLegacySeparator.Tab;
    private MailMergeLegacySeparator mailMergeLegacySeparator_3 = MailMergeLegacySeparator.Enter;
    private MailMergeMainDocumentType mailMergeMainDocumentType_0;
    private string string_0 = "";
    private string string_1 = "";
    private string string_2 = "";
    private string string_3 = "";
    private string string_4 = "";
    private string string_5 = "";

    internal bool method_0()
    {
        if (this.method_27() != MailMergeMainDocumentType.NotAMergeDocument)
        {
            return (this.method_13() == MailMergeDataType.None);
        }
        return true;
    }

    public void method_1()
    {
        this.method_28(MailMergeMainDocumentType.NotAMergeDocument);
        this.method_14(MailMergeDataType.None);
    }

    public void method_10(string A_0)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䜰刲头䈶尸", num));
        }
        this.string_1 = A_0;
    }

    public string method_11()
    {
        return this.string_2;
    }

    public void method_12(string A_0)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀵夷嘹䤻嬽", num));
        }
        this.string_2 = A_0;
    }

    public MailMergeDataType method_13()
    {
        return this.mailMergeDataType_0;
    }

    public void method_14(MailMergeDataType A_0)
    {
        this.mailMergeDataType_0 = A_0;
    }

    public MailMergeDestination method_15()
    {
        return this.mailMergeDestination_0;
    }

    public void method_16(MailMergeDestination A_0)
    {
        this.mailMergeDestination_0 = A_0;
    }

    public bool method_17()
    {
        return this.bool_0;
    }

    public void method_18(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public string method_19()
    {
        return this.string_3;
    }

    public Class460 method_2()
    {
        Class460 class2 = (Class460) base.MemberwiseClone();
        class2.class1035_0 = this.class1035_0.method_0();
        return class2;
    }

    public void method_20(string A_0)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐱唳娵䴷弹", num));
        }
        this.string_3 = A_0;
    }

    public bool method_21()
    {
        return this.bool_1;
    }

    public void method_22(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public bool method_23()
    {
        return this.bool_2;
    }

    public void method_24(bool A_0)
    {
        this.bool_2 = A_0;
    }

    public string method_25()
    {
        return this.string_4;
    }

    public void method_26(string A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("央倰弲䀴制", num));
        }
        this.string_4 = A_0;
    }

    public MailMergeMainDocumentType method_27()
    {
        return this.mailMergeMainDocumentType_0;
    }

    public void method_28(MailMergeMainDocumentType A_0)
    {
        this.mailMergeMainDocumentType_0 = A_0;
    }

    public Class1035 method_29()
    {
        return this.class1035_0;
    }

    public int method_3()
    {
        return this.int_0;
    }

    public void method_30(Class1035 A_0)
    {
        int num = 8;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堭儯帱䄳匵", num));
        }
        this.class1035_0 = A_0;
    }

    public string method_31()
    {
        return this.string_5;
    }

    public void method_32(string A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("央倰弲䀴制", num));
        }
        this.string_5 = A_0;
    }

    public bool method_33()
    {
        return this.bool_3;
    }

    public void method_34(bool A_0)
    {
        this.bool_3 = A_0;
    }

    internal MailMergeLegacySeparator method_35()
    {
        return this.mailMergeLegacySeparator_0;
    }

    internal void method_36(MailMergeLegacySeparator A_0)
    {
        this.mailMergeLegacySeparator_0 = A_0;
    }

    internal MailMergeLegacySeparator method_37()
    {
        return this.mailMergeLegacySeparator_1;
    }

    internal void method_38(MailMergeLegacySeparator A_0)
    {
        this.mailMergeLegacySeparator_1 = A_0;
    }

    internal MailMergeLegacySeparator method_39()
    {
        return this.mailMergeLegacySeparator_2;
    }

    public void method_4(int A_0)
    {
        this.int_0 = A_0;
    }

    internal void method_40(MailMergeLegacySeparator A_0)
    {
        this.mailMergeLegacySeparator_2 = A_0;
    }

    internal MailMergeLegacySeparator method_41()
    {
        return this.mailMergeLegacySeparator_3;
    }

    internal void method_42(MailMergeLegacySeparator A_0)
    {
        this.mailMergeLegacySeparator_3 = A_0;
    }

    public string method_5()
    {
        return this.string_0;
    }

    public void method_6(string A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("央倰弲䀴制", num));
        }
        this.string_0 = A_0;
    }

    public MailMergeCheckErrors method_7()
    {
        return this.mailMergeCheckErrors_0;
    }

    public void method_8(MailMergeCheckErrors A_0)
    {
        this.mailMergeCheckErrors_0 = A_0;
    }

    public string method_9()
    {
        return this.string_1;
    }
}

