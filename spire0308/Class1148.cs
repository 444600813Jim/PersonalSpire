using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Text;

internal class Class1148
{
    private BinaryWriter binaryWriter_0;
    private Class342 class342_0;
    private Class460 class460_0;
    private Class703 class703_0;
    private const int int_0 = 3;
    private const int int_1 = 0xfff3;
    private const int int_2 = 0xff;

    internal void method_0(Class460 A_0, Class703 A_1, Class342 A_2, BinaryWriter A_3)
    {
        if (!A_0.method_0())
        {
            this.class460_0 = A_0;
            this.class703_0 = A_1;
            this.class342_0 = A_2;
            this.binaryWriter_0 = A_3;
            this.class703_0.class929_0.class1111_18.int_0 = (int) this.binaryWriter_0.BaseStream.Position;
            this.class703_0.class929_0.class1111_18.int_1 = this.method_1(true);
            this.method_2();
        }
    }

    private int method_1(bool A_0)
    {
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        bool flag = Class567.smethod_16(this.class460_0.method_11());
        bool flag2 = Class567.smethod_16(this.class460_0.method_19());
        int num2 = 0;
        num2 = 1;
        num2 = 1 | (flag ? 2 : 0);
        num2 |= flag2 ? 4 : 0;
        num2 |= ((int) (this.class460_0.method_27() & 15)) << 3;
        num2 |= !this.class460_0.method_17() ? 0x400 : 0;
        num2 |= ((int) this.class460_0.method_15()) << 13;
        this.binaryWriter_0.Write((short) num2);
        this.binaryWriter_0.Write(flag2 ? ((byte) 1) : ((byte) 0));
        this.binaryWriter_0.Write((byte) 0);
        this.binaryWriter_0.Write(this.class460_0.method_3());
        Class1058 class2 = new Class1058 {
            mailMergeDataType_0 = MailMergeDataType.None,
            int_0 = 0xfff3
        };
        if (flag)
        {
            class2.mailMergeDataType_0 = this.class460_0.method_13();
            class2.int_0 = this.class342_0.method_6(3, this.class460_0.method_11());
            class2.bool_0 = this.class460_0.method_21();
            if (class2.mailMergeDataType_0 == MailMergeDataType.TextFile)
            {
                class2.mailMergeLegacySeparator_0 = this.class460_0.method_35();
                class2.mailMergeLegacySeparator_1 = this.class460_0.method_37();
            }
        }
        class2.method_0(this.binaryWriter_0);
        Class1058 class3 = new Class1058 {
            mailMergeDataType_0 = MailMergeDataType.TextFile,
            int_0 = 0xfff3
        };
        if (flag2)
        {
            class3.mailMergeDataType_0 = this.class460_0.method_13();
            class3.int_0 = this.class342_0.method_6(3, this.class460_0.method_19());
            class3.bool_0 = this.class460_0.method_21();
            if (class3.mailMergeDataType_0 == MailMergeDataType.TextFile)
            {
                class3.mailMergeLegacySeparator_0 = this.class460_0.method_39();
                class3.mailMergeLegacySeparator_1 = this.class460_0.method_41();
            }
        }
        class3.method_0(this.binaryWriter_0);
        int num3 = 0;
        num3 = 0 | (this.class460_0.method_33() ? 1 : 0);
        num3 |= ((int) (this.class460_0.method_7() - 1)) << 1;
        num3 |= !this.class460_0.method_23() ? 0x80 : 0;
        this.binaryWriter_0.Write((short) num3);
        this.binaryWriter_0.Write((short) 0x46a0);
        if (Class567.smethod_16(this.class460_0.method_31()))
        {
            string str = smethod_0(this.class460_0.method_31());
            this.binaryWriter_0.Write((short) Class813.smethod_11(str));
            Class813.smethod_8(str, this.binaryWriter_0);
        }
        else
        {
            this.binaryWriter_0.Write((short) 0);
        }
        StringCollection strings = new StringCollection();
        strings.Add(this.class460_0.method_9());
        strings.Add("");
        strings.Add(this.class460_0.method_25());
        strings.Add(this.class460_0.method_5());
        if (A_0)
        {
            strings.Add("");
        }
        Class343.smethod_4(this.binaryWriter_0, strings);
        if (A_0)
        {
            this.binaryWriter_0.Write((int) this.class460_0.method_27());
        }
        return (((int) this.binaryWriter_0.BaseStream.Position) - position);
    }

    private int method_10(int A_0)
    {
        this.binaryWriter_0.Write((short) 0);
        this.binaryWriter_0.Write((short) 4);
        this.binaryWriter_0.Write(A_0);
        this.binaryWriter_0.Write((short) 1);
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((short) 0);
        return position;
    }

    private void method_11(int A_0, int A_1)
    {
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        int num2 = position - A_1;
        this.binaryWriter_0.BaseStream.Position = A_0;
        this.binaryWriter_0.Write(num2);
        this.binaryWriter_0.BaseStream.Position = position;
    }

    private void method_12(int A_0, int A_1)
    {
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        short num2 = (short) (position - A_1);
        this.binaryWriter_0.BaseStream.Position = A_0;
        this.binaryWriter_0.Write(num2);
        this.binaryWriter_0.BaseStream.Position = position;
    }

    private void method_13(int A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            this.binaryWriter_0.Write((short) A_0);
            A_1 = smethod_0(A_1);
            byte[] bytes = Encoding.Unicode.GetBytes(A_1);
            this.binaryWriter_0.Write((short) bytes.Length);
            this.binaryWriter_0.Write(bytes);
        }
    }

    private void method_14(int A_0, int A_1)
    {
        this.binaryWriter_0.Write((short) A_0);
        this.binaryWriter_0.Write((short) 4);
        this.binaryWriter_0.Write(A_1);
    }

    private void method_15(int A_0, short A_1)
    {
        this.binaryWriter_0.Write((short) A_0);
        this.binaryWriter_0.Write((short) 2);
        this.binaryWriter_0.Write(A_1);
    }

    private void method_16(int A_0, byte A_1)
    {
        this.binaryWriter_0.Write((short) A_0);
        this.binaryWriter_0.Write((short) 1);
        this.binaryWriter_0.Write(A_1);
    }

    private void method_17(int A_0, byte[] A_1)
    {
        this.binaryWriter_0.Write((short) A_0);
        this.binaryWriter_0.Write((short) A_1.Length);
        this.binaryWriter_0.Write(A_1);
    }

    private void method_18()
    {
        this.binaryWriter_0.Write((short) 0);
        this.binaryWriter_0.Write((short) 0);
    }

    private void method_2()
    {
        this.class703_0.class929_0.class1111_19.int_0 = (int) this.binaryWriter_0.BaseStream.Position;
        Class1035 class2 = this.class460_0.method_29();
        this.method_13(0, class2.method_11());
        this.method_13(1, class2.method_7());
        this.method_13(2, class2.method_5());
        this.method_14(0x10, (int) class2.method_9());
        this.method_15(0x11, (short) class2.method_1());
        this.method_14(0x12, class2.method_3() ? 1 : 0);
        this.method_3();
        this.method_5();
        this.class703_0.class929_0.class1111_19.int_1 = ((int) this.binaryWriter_0.BaseStream.Position) - this.class703_0.class929_0.class1111_19.int_0;
    }

    private void method_3()
    {
        OdsoRecipientDataCollection datas = this.class460_0.method_29().method_15();
        if (datas.Count != 0)
        {
            int num = this.method_7(OpenOfficePropertyId.RecipientInfo);
            int position = (int) this.binaryWriter_0.BaseStream.Position;
            int num3 = this.method_9(datas.Count);
            int num4 = (int) this.binaryWriter_0.BaseStream.Position;
            foreach (OdsoRecipientData data in datas)
            {
                this.method_4(data);
            }
            this.method_11(num, position);
            this.method_11(num3, num4);
        }
    }

    private void method_4(OdsoRecipientData A_0)
    {
        if (!A_0.Active)
        {
            this.method_16(1, 0);
        }
        this.method_14(2, A_0.Column);
        if (A_0.Hash != 0)
        {
            this.method_14(3, A_0.Hash);
        }
        if (A_0.UniqueTag != null)
        {
            this.method_17(4, A_0.UniqueTag);
        }
        this.method_18();
    }

    private void method_5()
    {
        Class1034 class2 = this.class460_0.method_29().method_13();
        if (class2.method_0() != 0)
        {
            int num = this.method_8(OpenOfficePropertyId.FieldMapInfo);
            int position = (int) this.binaryWriter_0.BaseStream.Position;
            int num3 = this.method_10(class2.method_0());
            int num4 = (int) this.binaryWriter_0.BaseStream.Position;
            using (IEnumerator enumerator = class2.System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class228 current = (Class228) enumerator.Current;
                    this.method_6(current);
                }
            }
            this.method_12(num, position);
            this.method_12(num3, num4);
        }
    }

    private void method_6(Class228 A_0)
    {
        switch (A_0.method_12())
        {
            case OdsoFieldMappingType.Column:
                this.method_14(1, 1);
                this.method_13(2, A_0.method_10());
                this.method_13(3, A_0.method_8());
                this.method_14(4, A_0.method_1());
                this.method_18();
                return;
        }
        this.method_18();
    }

    private int method_7(OpenOfficePropertyId A_0)
    {
        this.binaryWriter_0.Write((short) A_0);
        this.binaryWriter_0.Write((short) (-1));
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write(0);
        return position;
    }

    private int method_8(OpenOfficePropertyId A_0)
    {
        this.binaryWriter_0.Write((short) A_0);
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((short) 0);
        return position;
    }

    private int method_9(int A_0)
    {
        this.binaryWriter_0.Write((short) 0);
        this.binaryWriter_0.Write((short) 4);
        this.binaryWriter_0.Write(A_0);
        this.binaryWriter_0.Write((short) 1);
        this.binaryWriter_0.Write((short) (-1));
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write(0);
        return position;
    }

    private static string smethod_0(string A_0)
    {
        if (A_0.Length <= 0xff)
        {
            return A_0;
        }
        return A_0.Substring(0, 0xff);
    }
}

