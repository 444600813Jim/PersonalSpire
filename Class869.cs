using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;

internal class Class869
{
    private BinaryReader binaryReader_0;
    private Class342 class342_0;
    private Class460 class460_0;
    private Class703 class703_0;

    internal void method_0(BinaryReader A_0, Class703 A_1, Class342 A_2, Class460 A_3)
    {
        this.binaryReader_0 = A_0;
        this.class703_0 = A_1;
        this.class342_0 = A_2;
        this.class460_0 = A_3;
        if (this.class703_0.class929_0.class1111_18.int_1 > 0)
        {
            this.method_1(this.class703_0.class929_0.class1111_18);
        }
        else if (this.class703_0.class597_0.class1111_44.int_1 > 0)
        {
            this.method_1(this.class703_0.class597_0.class1111_44);
        }
        this.method_2();
    }

    private void method_1(Class1111 A_0)
    {
        int num = A_0.int_0;
        int num2 = A_0.int_1;
        if (num2 != 0)
        {
            this.binaryReader_0.BaseStream.Position = num;
            int num3 = num + num2;
            int num4 = this.binaryReader_0.ReadInt16();
            bool flag = (num4 & 2) != 0;
            bool flag2 = (num4 & 4) != 0;
            this.class460_0.method_28((MailMergeMainDocumentType) ((num4 & 120) >> 3));
            this.class460_0.method_18((num4 & 0x400) == 0);
            this.class460_0.method_16((MailMergeDestination) ((num4 & 0xe000) >> 13));
            int index = this.binaryReader_0.ReadByte();
            int num6 = this.binaryReader_0.ReadByte();
            this.class460_0.method_4(this.binaryReader_0.ReadInt32());
            Class1058[] classArray = new Class1058[] { new Class1058(this.binaryReader_0), new Class1058(this.binaryReader_0) };
            if (flag)
            {
                Class1058 class2 = classArray[num6];
                this.class460_0.method_14(class2.mailMergeDataType_0);
                this.class460_0.method_12(this.class342_0.method_5(class2.int_0));
                this.class460_0.method_22(class2.bool_0);
                if (this.class460_0.method_13() == MailMergeDataType.TextFile)
                {
                    this.class460_0.method_36(class2.mailMergeLegacySeparator_0);
                    this.class460_0.method_38(class2.mailMergeLegacySeparator_1);
                }
            }
            if (flag2)
            {
                Class1058 class3 = classArray[index];
                this.class460_0.method_20(this.class342_0.method_5(class3.int_0));
                if (this.class460_0.method_13() == MailMergeDataType.TextFile)
                {
                    this.class460_0.method_40(class3.mailMergeLegacySeparator_0);
                    this.class460_0.method_42(class3.mailMergeLegacySeparator_1);
                }
            }
            int num7 = this.binaryReader_0.ReadInt16();
            this.class460_0.method_34((num7 & 1) != 0);
            this.class460_0.method_8((MailMergeCheckErrors) (((num7 & 6) >> 1) + 1));
            bool flag3 = (num7 & 0x10) != 0;
            bool flag4 = (num7 & 0x80) != 0;
            this.class460_0.method_24(!flag3 && !flag4);
            int num8 = this.binaryReader_0.ReadInt16();
            int num9 = this.binaryReader_0.ReadInt16();
            this.class460_0.method_32(Class813.smethod_5(this.binaryReader_0, num9));
            if (num8 != 0)
            {
                StringCollection strings = new StringCollection();
                int num10 = num3 - ((int) this.binaryReader_0.BaseStream.Position);
                Class343.smethod_2(this.binaryReader_0, (int) this.binaryReader_0.BaseStream.Position, num10, strings);
                this.class460_0.method_10(strings[0]);
                string text1 = strings[1];
                this.class460_0.method_26(strings[2]);
                this.class460_0.method_6(strings[3]);
            }
            if (this.binaryReader_0.BaseStream.Position < num3)
            {
                int num11 = this.binaryReader_0.ReadInt32();
                this.class460_0.method_28((MailMergeMainDocumentType) num11);
            }
        }
    }

    private void method_2()
    {
        if (this.class703_0.class929_0.class1111_19.int_1 != 0)
        {
            this.binaryReader_0.BaseStream.Position = this.class703_0.class929_0.class1111_19.int_0;
            int num = this.class703_0.class929_0.class1111_19.int_0 + this.class703_0.class929_0.class1111_19.int_1;
            while (this.binaryReader_0.BaseStream.Position < num)
            {
                this.method_3();
            }
        }
    }

    private void method_3()
    {
        OpenOfficePropertyId id = (OpenOfficePropertyId) this.binaryReader_0.ReadInt16();
        int num = this.binaryReader_0.ReadInt16();
        if (num == -1)
        {
            num = this.binaryReader_0.ReadInt32();
        }
        long position = this.binaryReader_0.BaseStream.Position;
        Class1035 class2 = this.class460_0.method_29();
        switch (id)
        {
            case OpenOfficePropertyId.Udl:
                class2.method_12(this.method_8(num));
                return;

            case OpenOfficePropertyId.TableName:
                class2.method_8(this.method_8(num));
                return;

            case OpenOfficePropertyId.DataSource:
                class2.method_6(this.method_8(num));
                return;

            case OpenOfficePropertyId.DataSourceType:
                class2.method_10((OdsoDataSourceType) this.binaryReader_0.ReadInt32());
                return;

            case OpenOfficePropertyId.ColumnDelimeter:
                class2.method_2((char) ((ushort) this.binaryReader_0.ReadInt16()));
                return;

            case OpenOfficePropertyId.FirstRowContainsColumnNames:
                class2.method_4(this.binaryReader_0.ReadInt32() != 0);
                return;

            case OpenOfficePropertyId.RecipientInfo:
                this.method_4(num);
                return;

            case OpenOfficePropertyId.FieldMapInfo:
                this.method_6(num);
                return;
        }
        this.binaryReader_0.ReadBytes(num);
    }

    private void method_4(int A_0)
    {
        long position = this.binaryReader_0.BaseStream.Position;
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        int num = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadInt16();
        if (this.binaryReader_0.ReadInt16() == -1)
        {
            int num2 = this.binaryReader_0.ReadInt32();
        }
        for (int i = 0; i < num; i++)
        {
            this.method_5();
        }
    }

    private void method_5()
    {
        int num2;
        OdsoRecipientData data = new OdsoRecipientData();
    Label_0060:
        num2 = this.binaryReader_0.ReadInt16();
        int num = this.binaryReader_0.ReadInt16();
        switch (num2)
        {
            case 0:
                if ((data.Hash != 0) || (data.UniqueTag != null))
                {
                    this.class460_0.method_29().method_15().Add(data);
                }
                return;

            case 1:
                data.Active = this.method_9(num) != 0;
                goto Label_0060;

            case 2:
                data.Column = this.method_9(num);
                goto Label_0060;

            case 3:
                data.Hash = this.binaryReader_0.ReadInt32();
                goto Label_0060;

            case 4:
                data.UniqueTag = this.binaryReader_0.ReadBytes(num);
                goto Label_0060;
        }
        this.binaryReader_0.ReadBytes(num);
        goto Label_0060;
    }

    private void method_6(int A_0)
    {
        long position = this.binaryReader_0.BaseStream.Position;
        this.binaryReader_0.ReadInt16();
        this.binaryReader_0.ReadInt16();
        int num = this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadInt16();
        if (this.binaryReader_0.ReadInt16() == -1)
        {
            int num2 = this.binaryReader_0.ReadInt32();
        }
        for (int i = 0; i < num; i++)
        {
            this.method_7(i);
        }
    }

    private void method_7(int A_0)
    {
        int num4;
        int num = 6;
        Class228 class2 = new Class228();
    Label_005D:
        num4 = this.binaryReader_0.ReadInt16();
        int num2 = this.binaryReader_0.ReadInt16();
        switch (num4)
        {
            case 0:
                if (Class567.smethod_16(class2.method_10()))
                {
                    class2.method_13(OdsoFieldMappingType.Column);
                }
                this.class460_0.method_29().method_13().method_3(class2);
                return;

            case 1:
                if (this.method_9(num2) != 1)
                {
                    throw new InvalidOperationException(BookmarkStart.b("含嘭䠯", num));
                }
                goto Label_005D;

            case 2:
                class2.method_11(this.method_8(num2));
                goto Label_005D;

            case 3:
                this.method_8(num2);
                class2.method_9(Class533.smethod_11((PredefinedMergeFieldName) A_0));
                goto Label_005D;

            case 4:
                class2.method_3(this.method_9(num2));
                goto Label_005D;
        }
        this.binaryReader_0.ReadBytes(num2);
        goto Label_005D;
    }

    private string method_8(int A_0)
    {
        return Encoding.Unicode.GetString(this.binaryReader_0.ReadBytes(A_0));
    }

    private int method_9(int A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case 1:
                return this.binaryReader_0.ReadByte();

            case 2:
                return this.binaryReader_0.ReadInt16();

            case 4:
                return this.binaryReader_0.ReadInt32();
        }
        throw new InvalidOperationException(BookmarkStart.b("愳堵崷䈹䰻嬽⌿㙁⅃≅桇⍉≋㩍㕏㕑ㅓ⑕硗⥙㕛⑝՟䱡", num));
    }
}

