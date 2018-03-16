using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.Shapes;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

internal class Class1108
{
    internal static bool bool_0;
    internal const char char_0 = '(';
    private readonly Class129 class129_0;
    private readonly Class130 class130_0;
    private readonly Class130 class130_1;
    private readonly Class131 class131_0;
    private readonly Class132 class132_0;
    private readonly Class133 class133_0;
    private readonly Class134 class134_0;
    private readonly Class135 class135_0;
    private readonly Class136 class136_0;
    private readonly Class263 class263_0;
    private readonly Class764 class764_0;
    private readonly Class985 class985_0;
    internal const int int_0 = 0x19;
    private int int_1;
    private int int_2;
    private readonly Stack stack_0;
    private readonly SubDocumentType subDocumentType_0;

    internal Class1108(Class764 A_0) : this(A_0, SubDocumentType.Main)
    {
    }

    private Class1108(Class764 A_0, SubDocumentType A_1)
    {
        this.class985_0 = new Class985();
        this.class132_0 = new Class132();
        this.class136_0 = new Class136();
        this.class135_0 = new Class135();
        this.class133_0 = new Class133();
        this.class131_0 = new Class131();
        this.class134_0 = new Class134();
        this.class130_0 = new Class130();
        this.class130_1 = new Class130();
        this.class129_0 = new Class129();
        this.stack_0 = new Stack();
        this.class764_0 = A_0;
        this.subDocumentType_0 = A_1;
        this.class263_0 = new Class263(this.class764_0.method_43());
    }

    internal void method_0()
    {
        this.class764_0.method_43().imethod_0();
        this.method_3(FootnoteSeparatorType.FootnoteSeparator);
        this.method_3(FootnoteSeparatorType.FootnoteContinuation);
        this.method_3(FootnoteSeparatorType.FootnoteContinuationNotice);
        this.method_3(FootnoteSeparatorType.EndnoteSeparator);
        this.method_3(FootnoteSeparatorType.EndnoteContinuation);
        this.method_3(FootnoteSeparatorType.EndnoteContinuationNotice);
        Class17 class2 = this.class764_0.method_35(0);
        if (class2 == null)
        {
            class2 = new Class17(this.class764_0.method_42());
        }
        this.class764_0.method_43().imethod_2(class2);
        this.method_1();
        this.class764_0.method_43().imethod_4();
        this.method_4(0, this.class764_0.method_5().int_14);
        this.class764_0.method_43().imethod_5();
        this.class764_0.method_43().imethod_3();
        this.class764_0.method_43().imethod_1(this.class764_0.method_36());
    }

    private void method_1()
    {
        this.method_2(HeaderFooterType.HeaderEven);
        this.method_2(HeaderFooterType.HeaderOdd);
        this.method_2(HeaderFooterType.FooterEven);
        this.method_2(HeaderFooterType.FooterOdd);
        this.method_2(HeaderFooterType.HeaderFirstPage);
        this.method_2(HeaderFooterType.FooterFirstPage);
    }

    private void method_10(ParagraphFormat A_0)
    {
        this.class764_0.method_43().imethod_10();
        int num = this.class985_0.method_2();
        CharacterFormat format = null;
        for (int i = 0; i < this.class985_0.Count; i++)
        {
            Class537 class2 = this.class985_0.method_0(i);
            int index = 0;
            while (index < class2.method_2().Length)
            {
                Class1107 class3;
                char ch1 = class2.method_2()[index];
                int num4 = class2.method_1(index);
                int num5 = this.class764_0.method_38(num4, class2.method_3().method_0().method_1(), out format, out class3);
                if (num5 == num4)
                {
                    break;
                }
                int num6 = num5 - num4;
                if (num6 < (class2.method_7() ? 2 : 1))
                {
                    num6 = class2.method_7() ? 2 : 1;
                }
                int num7 = num6 >> ((class2.method_7() != null) ? 1 : 0);
                int num8 = class2.method_2().Length - index;
                num7 = (num7 > num8) ? num8 : num7;
                bool flag = num == num7;
                this.method_14(format, class3, class2, index, ref num7, flag);
                index += num7;
                num -= num7;
            }
        }
        this.class764_0.method_43().imethod_11(A_0, format);
    }

    private int method_11(ref string A_0, Class1107 A_1)
    {
        int length = A_0.Length;
        if (A_0.Length > 1)
        {
            int num2 = -1;
            if (((A_0.Length >= 10) && (A_1.int_1 != 0)) && A_1.bool_0)
            {
                A_0 = string.Empty;
                return length;
            }
            if ((A_0.Length > 10) && this.method_12(A_0))
            {
                return length;
            }
            A_0 = A_0.Trim(new char[1]);
            num2 = A_0.IndexOfAny(Class818.char_20);
            if (num2 > -1)
            {
                if (num2 == 0)
                {
                    num2 = 1;
                }
                A_0 = A_0.Substring(0, num2);
                int num3 = this.method_13(A_0);
                if (num3 <= -1)
                {
                    return num2;
                }
                if (num3 == 0)
                {
                    num3 = 1;
                }
                A_0 = A_0.Substring(0, num3);
                return num3;
            }
            num2 = this.method_13(A_0);
            if (num2 > -1)
            {
                if (num2 == 0)
                {
                    num2 = 1;
                }
                A_0 = A_0.Substring(0, num2);
                return num2;
            }
            if ((A_0.Length > 1) && (A_0[0] == '('))
            {
                num2 = 1;
                A_0 = A_0.Substring(0, 1);
                return 1;
            }
        }
        return length;
    }

    private bool method_12(string A_0)
    {
        bool flag = false;
        if (A_0[0] == '\0')
        {
            flag = true;
            for (int i = 1; i < (A_0.Length - 1); i++)
            {
                if (A_0[i] != A_0[i + 1])
                {
                    return false;
                }
            }
        }
        return flag;
    }

    private int method_13(string A_0)
    {
        int num3;
        if (string.IsNullOrEmpty(A_0) || (A_0.Length <= 0))
        {
            return -1;
        }
        int num = 0;
        CharacterCategory ascii = CharacterCategory.Ascii;
        using (IEnumerator enumerator = new Class1087(A_0).System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int current = (int) enumerator.Current;
                if ((current < 0x10000) || (current > 0x10ffff))
                {
                    if (num == 0)
                    {
                        ascii = Class57.smethod_7(current);
                    }
                    if ((num > 0) && (Class57.smethod_7(current) != ascii))
                    {
                        goto Label_006E;
                    }
                    num++;
                }
            }
            return -1;
        Label_006E:
            num3 = num - 1;
        }
        return num3;
    }

    private void method_14(CharacterFormat A_0, Class1107 A_1, Class537 A_2, int A_3, ref int A_4, bool A_5)
    {
        if ((!A_1.bool_0 && (A_4 == 1)) && (A_2.method_2()[A_3] == '\x0015'))
        {
            A_1.bool_0 = true;
        }
        int num2 = A_3;
        int num = A_3;
        int num3 = A_3 + A_4;
        int num6 = A_4;
        bool flag = false;
        int num5 = A_2.method_0(num) - num;
        while (num < num3)
        {
            int num4 = num + num5;
            if ((this.class130_0.method_1() == num4) || (this.class130_1.method_1() == num4))
            {
                flag = true;
            }
            char ch = A_2.method_2()[num];
            if (((((ch != '\b') && !A_1.bool_0) && ((this.class132_0.method_1() != num4) && (this.class136_0.method_1() != num4))) && (((this.class135_0.method_1() != num4) && (this.class133_0.method_1() != num4)) && ((this.class131_0.method_1() != num4) && (this.class134_0.method_1() != num4)))) && ((this.class129_0.method_1() != num4) && !flag))
            {
                if (A_5 || (ch.ToString().IndexOfAny(Class818.char_20) <= -1))
                {
                    goto Label_0290;
                }
                if (num == num2)
                {
                    num++;
                }
                A_4 = num - num2;
                break;
            }
            CharacterFormat format = (CharacterFormat) A_0.Clone();
            if (!A_1.bool_0 && (num > num2))
            {
                this.method_15(format, A_1, A_2, num2, num - num2);
                num2 = num;
            }
            this.class132_0.method_2(num4);
            if (this.class135_0.method_1() == this.class136_0.method_1())
            {
                this.class136_0.method_2(num4);
                this.class135_0.method_2(num4);
                this.class133_0.method_2(num4);
            }
            else
            {
                this.class135_0.method_2(num4);
                this.class133_0.method_2(num4);
                this.class136_0.method_2(num4);
            }
            this.class131_0.method_2(num4);
            this.class134_0.method_2(num4);
            this.class129_0.method_2(num4);
            if (flag)
            {
                FootnoteType type;
                flag = false;
                if (this.class130_0.method_1() == num4)
                {
                    this.class130_0.method_2(num4);
                }
                else
                {
                    this.class130_1.method_2(num4);
                }
                Class762 class2 = this.method_25(num4, out type);
                if ((class2 != null) && this.method_26(class2, type, A_2, num, num3, A_1, format))
                {
                    num2 = num3;
                }
            }
            else if ((A_1.bool_0 && ((A_4 == 1) || (Array.IndexOf<char>(Class818.char_22, ch) > -1))) || (ch == '\b'))
            {
                if (((A_4 > 1) && (num > num2)) && (Array.IndexOf<char>(Class818.char_22, ch) > -1))
                {
                    this.method_15(format, A_1, A_2, num2, num - num2);
                }
                this.method_17(ch, num4, format, A_1);
                num2 = num + 1;
            }
        Label_0290:
            num++;
        }
        if (A_5)
        {
            num--;
        }
        if (num > num2)
        {
            this.method_15(A_0, A_1, A_2, num2, num - num2);
            A_4 = (A_4 < num6) ? (num - A_3) : A_4;
        }
    }

    private void method_15(CharacterFormat A_0, Class1107 A_1, Class537 A_2, int A_3, int A_4)
    {
        if (A_4 != 0)
        {
            string str = new string(A_2.method_2(), A_3, A_4);
            if ((A_4 != 1) || (str[0] != '\x0001'))
            {
                int startIndex = 0;
                string str2 = str;
                do
                {
                    startIndex += this.method_11(ref str, A_1);
                    this.method_16(str, A_0);
                    str = str2.Substring(startIndex);
                }
                while (!string.IsNullOrEmpty(str));
            }
        }
    }

    private void method_16(string A_0, CharacterFormat A_1)
    {
        int num = A_0.IndexOfAny(Class818.char_21);
        if (num <= -1)
        {
            this.class764_0.method_43().imethod_12(A_0, A_1);
        }
        else
        {
            int startIndex = 0;
            while (num != startIndex)
            {
                char ch;
                string str = A_0.Substring(startIndex, num - startIndex);
                this.class764_0.method_43().imethod_12(str, A_1);
                char ch2 = A_0[num];
                this.class764_0.method_43().imethod_12(ch2.ToString(), A_1);
            Label_0055:
                startIndex = num + 1;
                num = A_0.IndexOfAny(Class818.char_21, startIndex);
                if (num > -1)
                {
                    continue;
                }
                if (A_0.Length > startIndex)
                {
                    this.class764_0.method_43().imethod_12(A_0.Substring(startIndex, A_0.Length - startIndex), A_1);
                }
                return;
            Label_006C:
                ch = A_0[startIndex];
                this.class764_0.method_43().imethod_12(ch.ToString(), A_1);
                goto Label_0055;
            }
            goto Label_006C;
        }
    }

    private void method_17(char A_0, int A_1, CharacterFormat A_2, Class1107 A_3)
    {
        int num = this.class764_0.method_5().method_6(A_1);
        switch (A_0)
        {
            case '\x0001':
                if (A_3.bool_1)
                {
                    this.method_18(A_2, A_3.int_1);
                    return;
                }
                if (A_3.bool_3)
                {
                    this.method_19(A_2, A_3.int_1);
                    return;
                }
                this.method_20(A_2, A_3.int_1);
                return;

            case '\x0005':
                if (this.subDocumentType_0 == SubDocumentType.Main)
                {
                    this.method_27(num, A_2);
                    return;
                }
                this.class764_0.method_43().imethod_13(A_0, A_2);
                return;

            case '\b':
                this.method_23(num, A_2);
                return;

            case '\x0013':
            {
                Class766 class5 = this.class764_0.method_7().method_0(this.subDocumentType_0, num);
                if (class5 == null)
                {
                    class5 = new Class766(0x13, 0);
                }
                this.class764_0.method_43().imethod_15(A_2, class5.method_2());
                return;
            }
            case '\x0014':
            {
                Class454 class3 = null;
                if (A_3.bool_2 && A_3.bool_3)
                {
                    class3 = this.class764_0.method_41(A_3.int_1);
                }
                this.class764_0.method_43().imethod_16(A_2, class3);
                return;
            }
            case '\x0015':
            {
                bool flag = false;
                bool flag2 = false;
                Class766 class6 = this.class764_0.method_7().method_0(this.subDocumentType_0, num);
                if (class6 != null)
                {
                    flag = class6.method_13();
                    flag2 = class6.method_9();
                }
                this.class764_0.method_43().imethod_17(A_2, flag2, flag);
                return;
            }
            case '(':
                if (A_2.HasKey(400))
                {
                    A_2.Remove(400);
                }
                if (A_3.bool_0)
                {
                    this.class764_0.method_43().imethod_40(A_3, A_2);
                    return;
                }
                this.method_16(A_3.char_0.ToString(), A_2);
                return;

            case '<':
            {
                Class487 class7 = this.class764_0.method_17().method_5(this.int_2++);
                if (class7 != null)
                {
                    Class9 class2 = new Class9(this.class764_0.method_42(), class7.method_0());
                    class2.method_23(class7.method_1());
                    class2.method_27(class7.method_3());
                    class2.method_25(class7.method_2());
                    using (IEnumerator enumerator = class7.method_4().System.Collections.IEnumerable.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            Class901 current = (Class901) enumerator.Current;
                            class2.method_28().method_3(current);
                        }
                    }
                    this.class764_0.method_43().imethod_36(class2);
                    this.stack_0.Push(class2);
                }
                return;
            }
            case '>':
                if (this.stack_0.Count > 0)
                {
                    this.stack_0.Pop();
                    this.class764_0.method_43().imethod_37();
                    return;
                }
                return;
        }
        this.class764_0.method_43().imethod_13(A_0, A_2);
    }

    private void method_18(CharacterFormat A_0, int A_1)
    {
        switch (this.class764_0.method_43().imethod_39())
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
            {
                this.class764_0.method_4().BaseStream.Position = A_1;
                Class42 class2 = smethod_0(this.class764_0.method_4());
                this.class764_0.method_43().imethod_14(class2, A_0);
                break;
            }
        }
    }

    private void method_19(CharacterFormat A_0, int A_1)
    {
        Class454 class2 = this.class764_0.method_41(A_1);
        if (class2 != null)
        {
            ShapeObject obj2 = new ShapeObject(this.class764_0.method_42());
            obj2.SetShapeType(ShapeType.OleObject);
            obj2.CharacterFormat.method_25(A_0);
            obj2.TextWrappingStyle = TextWrappingStyle.Inline;
            MemoryStream input = class2.method_7();
            if (input != null)
            {
                byte[] buffer = new byte[(int) (input.Length - 8L)];
                input.Position = 0L;
                BinaryReader reader2 = new BinaryReader(input);
                reader2.ReadUInt16();
                int num5 = reader2.ReadUInt16();
                int num6 = reader2.ReadUInt16();
                reader2.ReadUInt16();
                input.Read(buffer, 0, buffer.Length);
                obj2.ImageData.method_87(Class409.smethod_29(buffer, Class1044.smethod_1((int) ((((double) num5) / 2540.0) * 1963.0), (int) ((((double) num6) / 2540.0) * 1963.0), 1963.0, 1963.0)));
                obj2.SetShapeAttribute(0x1006, obj2.ImageData.ImageBytes);
            }
            MemoryStream stream = class2.method_8();
            if (stream != null)
            {
                BinaryReader reader = new BinaryReader(stream);
                stream.Position = 12L;
                reader.ReadUInt16();
                reader.ReadUInt16();
                reader.ReadUInt16();
                reader.ReadUInt16();
                int num = reader.ReadInt32();
                int num2 = reader.ReadInt32();
                stream.Position = 0x2cL;
                int num3 = reader.ReadInt32();
                int num4 = reader.ReadInt32();
                reader.ReadInt32();
                reader.ReadInt32();
                reader.ReadInt32();
                reader.ReadInt32();
                obj2.method_37((Class969.smethod_32(num) * num3) / 1000.0);
                obj2.method_39((Class969.smethod_32(num2) * num4) / 1000.0);
            }
            this.class764_0.method_43().imethod_18(obj2);
        }
    }

    private void method_2(HeaderFooterType A_0)
    {
        Class760 class2 = this.class764_0.method_8().method_25(this.int_1, A_0);
        if ((class2 != null) && (class2.method_6() > 0))
        {
            Class1108 class3 = new Class1108(this.class764_0, SubDocumentType.Header);
            this.class764_0.method_43().imethod_6(A_0);
            class3.method_4(class2.method_2(), class2.method_6());
            this.class764_0.method_43().imethod_7();
        }
    }

    private void method_20(CharacterFormat A_0, int A_1)
    {
        this.class764_0.method_4().BaseStream.Position = A_1;
        Class262 class2 = new Class262(this.class764_0.method_4());
        if (class2.int_3 == 0x44)
        {
            switch (class2.picfType_0)
            {
                case PicfType.InlineEscher:
                {
                    int num2 = class2.int_2 - class2.int_3;
                    this.method_21(class2, A_0, num2);
                    return;
                }
                case ((PicfType) 0x65):
                    return;

                case PicfType.IncludePicture:
                {
                    string str = Class813.smethod_1(this.class764_0.method_4(), false, false);
                    int num3 = ((class2.int_2 - class2.int_3) - str.Length) - 1;
                    this.method_21(class2, A_0, num3);
                    return;
                }
                case PicfType.Metafile1:
                {
                    int count = class2.int_2 - class2.int_3;
                    byte[] buffer = this.class764_0.method_4().ReadBytes(count);
                    ShapeObject obj2 = new ShapeObject(this.class764_0.method_42(), ShapeType.Image) {
                        TextWrappingStyle = TextWrappingStyle.Inline
                    };
                    if (buffer.Length > 0)
                    {
                        obj2.ImageData.method_87(buffer);
                        obj2.SetShapeAttribute(0x1006, obj2.ImageData.ImageBytes);
                    }
                    obj2.CharacterFormat.method_25(A_0);
                    class2.method_2(obj2);
                    this.class764_0.method_43().imethod_18(obj2);
                    return;
                }
            }
        }
    }

    private void method_21(Class262 A_0, CharacterFormat A_1, int A_2)
    {
        ShapeObject obj2 = this.class764_0.method_40(A_2);
        if (((obj2 != null) && !smethod_2(obj2, A_0)) && A_0.method_3())
        {
            obj2.CharacterFormat.method_73(A_1);
            A_0.method_2(obj2);
            this.method_22(obj2);
            this.class764_0.method_43().imethod_18(obj2);
        }
    }

    private void method_22(ShapeBase A_0)
    {
        if (this.class764_0.method_44())
        {
            A_0.IsPictureBullet = true;
        }
        else if (A_0.IsPictureBullet)
        {
            A_0.IsPictureBullet = false;
        }
    }

    private void method_23(int A_0, CharacterFormat A_1)
    {
        Class347 class3 = this.class764_0.method_19(this.subDocumentType_0).method_4(A_0);
        if (class3 != null)
        {
            ShapeBase base2 = this.class764_0.method_39(class3.int_1, Class813.smethod_22(this.subDocumentType_0));
            if (base2 != null)
            {
                bool flag = this.class764_0.method_5().nfibEnum_0 > NFibEnum.Word97;
                class3.method_0(base2, flag);
                base2.CharacterFormat.method_25(A_1);
                if (!base2.IsGroup)
                {
                    this.method_22(base2);
                }
                this.class764_0.method_43().imethod_18(base2);
                this.method_24(base2);
            }
        }
    }

    private void method_24(ShapeBase A_0)
    {
        if (A_0.IsGroup)
        {
            ShapeGroup group = (ShapeGroup) A_0;
            for (int i = 0; i < group.ChildObjects.Count; i++)
            {
                this.method_24(group.ChildObjects[i] as ShapeBase);
            }
        }
        else
        {
            Class761 class3 = this.class764_0.method_19(this.subDocumentType_0).method_6(A_0.Id);
            if ((class3 != null) && (class3.method_6() > 0))
            {
                ShapeObject obj2 = (ShapeObject) A_0;
                if (obj2.ShapeType != ShapeType.OleObject)
                {
                    obj2.IsTextbox = true;
                }
                this.class764_0.method_43().imethod_19(obj2);
                new Class1108(this.class764_0, Class813.smethod_21(this.subDocumentType_0)).method_4(class3.method_2(), class3.method_6());
                this.class764_0.method_43().imethod_20(obj2);
            }
        }
    }

    private Class762 method_25(int A_0, out FootnoteType A_1)
    {
        Class762 class2 = null;
        A_1 = FootnoteType.Footnote;
        if (this.subDocumentType_0 == SubDocumentType.Main)
        {
            int num = this.class764_0.method_5().method_6(A_0);
            class2 = this.class764_0.method_10().method_1(num);
            if (class2 == null)
            {
                A_1 = FootnoteType.Endnote;
                class2 = this.class764_0.method_11().method_1(num);
            }
        }
        return class2;
    }

    private bool method_26(Class762 A_0, FootnoteType A_1, Class537 A_2, int A_3, int A_4, Class1107 A_5, CharacterFormat A_6)
    {
        int num = 0;
        A_0.bool_0 = A_2.method_2()[A_3] == '\x0002';
        if (A_0.bool_0 && !A_5.bool_0)
        {
            return false;
        }
        string str = null;
        if (!A_0.bool_0)
        {
            str = new string(A_2.method_2(), A_3, A_4 - A_3);
            if ((A_5.bool_0 && (A_5.char_0 != '\0')) && (str == BookmarkStart.b("ล", num)))
            {
                if (A_5.string_0 != null)
                {
                    A_6.FontName = A_5.string_0;
                }
                str = new string(new char[] { Class742.smethod_2(A_5.char_0) });
            }
        }
        this.class764_0.method_43().imethod_23(A_1, A_0.bool_0, str, A_6);
        new Class1108(this.class764_0, Class700.smethod_0(A_1)).method_4(A_0.method_2(), A_0.method_6());
        this.class764_0.method_43().imethod_24();
        return true;
    }

    private void method_27(int A_0, CharacterFormat A_1)
    {
        Class1065 class2 = this.class764_0.method_12();
        int num = class2.method_9().method_12(A_0);
        if (num >= 0)
        {
            Class872 class3 = class2.method_9().method_25(num);
            string str = class2.method_3(class3.int_3);
            this.class764_0.method_43().imethod_25(class3.int_4, class3.string_0, str, class3.dateTime_0, A_1);
            Class1108 class4 = new Class1108(this.class764_0, SubDocumentType.Comment);
            int num2 = class2.method_10().method_16(num);
            int num3 = class2.method_10().method_16(num + 1);
            class4.method_4(num2, num3 - num2);
            this.class764_0.method_43().imethod_26();
        }
    }

    private void method_3(FootnoteSeparatorType A_0)
    {
        Class760 class2 = this.class764_0.method_8().method_26(A_0);
        if ((class2 != null) && (class2.method_6() > 0))
        {
            Class1108 class3 = new Class1108(this.class764_0, SubDocumentType.Header);
            this.class764_0.method_43().imethod_8(A_0);
            class3.method_4(class2.method_2(), class2.method_6());
            this.class764_0.method_43().imethod_9();
        }
    }

    private void method_4(int A_0, int A_1)
    {
        int num = this.class764_0.method_5().method_7(this.subDocumentType_0, A_0);
        this.method_5(num);
        int num2 = this.class764_0.method_6().method_1(num);
        if (num2 != -1)
        {
            int num4 = num - this.class764_0.method_6().method_4(num2).method_0().method_2();
            int num3 = A_1;
            while (num3 > 0)
            {
                if (num2 >= this.class764_0.method_6().method_5())
                {
                    break;
                }
                Class602 class2 = this.class764_0.method_6().method_4(num2);
                int num5 = class2.int_0;
                int count = class2.method_0().method_6();
                if (num4 > 0)
                {
                    num5 += num4 * (class2.bool_0 ? 2 : 1);
                    count -= num4;
                }
                this.class764_0.method_1().BaseStream.Position = num5;
                count = (count > num3) ? num3 : count;
                BinaryReader reader = class2.bool_0 ? this.class764_0.method_1() : this.class764_0.method_2();
                Class537 class3 = new Class537(reader.ReadChars(count), new Class870(class2, num4), num5);
                this.method_6(class3);
                num3 -= count;
                num2++;
                num4 = 0;
            }
            if (this.class985_0.Count > 0)
            {
                Struct24 struct2 = new Struct24(new ParagraphFormat(), new Class1150(), new RowFormat(this.class764_0.method_42()));
                this.method_9(this.class985_0.method_0(0), 0, struct2);
            }
        }
    }

    private void method_5(int A_0)
    {
        Class996 class2 = this.class764_0.method_9();
        this.class132_0.method_0(this.class764_0, class2.method_13(), A_0);
        this.class136_0.method_0(this.class764_0, class2.method_14(), A_0);
        Class168 class3 = this.class764_0.method_16();
        this.class135_0.method_0(this.class764_0, class3.method_21(), A_0);
        this.class133_0.method_0(this.class764_0, class3.method_22(), A_0);
        Class1065 class4 = this.class764_0.method_12();
        this.class131_0.method_0(this.class764_0, class4.method_11(), A_0);
        this.class134_0.method_0(this.class764_0, class4.method_12(), A_0);
        Class700 class5 = this.class764_0.method_10();
        Class700 class6 = this.class764_0.method_11();
        this.class130_0.method_0(this.class764_0, class5.method_6(), A_0);
        this.class130_1.method_0(this.class764_0, class6.method_6(), A_0);
        this.class129_0.method_0(this.class764_0, this.class764_0.method_18().method_6(), A_0);
    }

    private void method_6(Class537 A_0)
    {
        int num = 0;
        for (int i = 0; i < A_0.method_2().Length; i++)
        {
            switch (A_0.method_2()[i])
            {
                case '\f':
                    if ((this.subDocumentType_0 != SubDocumentType.Footnote) && (this.subDocumentType_0 != SubDocumentType.Endnote))
                    {
                        Class17 class2 = this.class764_0.method_35(A_0.method_0(i + 1));
                        if (class2 != null)
                        {
                            Struct24 struct3 = this.method_8(A_0, num, i);
                            num = i + 1;
                            if (struct3.class1150_0.int_0 == 0)
                            {
                                this.method_9(A_0, i, struct3);
                                if (this.class263_0.method_0() == ElementPostion.None)
                                {
                                    this.class764_0.method_43().imethod_5();
                                    this.class764_0.method_43().imethod_3();
                                    this.int_1++;
                                    this.class764_0.method_43().imethod_2(class2);
                                    this.method_1();
                                    this.class764_0.method_43().imethod_4();
                                }
                            }
                        }
                    }
                    break;

                case '\r':
                case '\a':
                    if (this.method_7(A_0, i))
                    {
                        Struct24 struct2 = this.method_8(A_0, num, i);
                        num = i + 1;
                        this.method_9(A_0, i, struct2);
                    }
                    break;
            }
        }
        if (num < A_0.method_2().Length)
        {
            this.class985_0.Add(new Class537(A_0, num, A_0.method_2().Length));
        }
    }

    private bool method_7(Class537 A_0, int A_1)
    {
        int num = A_0.method_1(A_1 + 1);
        return (this.class764_0.method_14().method_13(num) >= 0);
    }

    private Struct24 method_8(Class537 A_0, int A_1, int A_2)
    {
        this.class985_0.Add(new Class537(A_0, A_1, A_2 + 1));
        return this.class764_0.method_37(A_0.method_1(A_2), this.class985_0.method_3());
    }

    private void method_9(Class537 A_0, int A_1, Struct24 A_2)
    {
        this.class263_0.method_2(A_2.class1150_0);
        if (A_2.class1150_0.method_1())
        {
            int num = A_0.method_0(A_1);
            this.class132_0.method_2(num);
            this.class136_0.method_2(num);
        }
        else
        {
            this.method_10(A_2.paragraphFormat_0);
        }
        this.class263_0.method_3(A_2.class1150_0, A_2.rowFormat_0, this.class985_0.method_1().method_8());
        this.class985_0.Clear();
    }

    internal static Class42 smethod_0(BinaryReader A_0)
    {
        Class42 class2 = new Class42();
        long position = A_0.BaseStream.Position;
        Class262 class3 = new Class262(A_0);
        if (class3.int_2 != class3.int_3)
        {
            smethod_1(A_0, class2);
            A_0.BaseStream.Position = position + class3.int_2;
        }
        return class2;
    }

    private static void smethod_1(BinaryReader A_0, Class42 A_1)
    {
        bool flag;
        int num = 0x13;
        if (!(flag = A_0.ReadUInt32() == uint.MaxValue))
        {
            A_0.BaseStream.Seek(-4L, SeekOrigin.Current);
        }
        int num6 = A_0.ReadUInt16();
        FormFieldType type = ((FormFieldType) num6) & (FormFieldType.DropDown | FormFieldType.CheckBox);
        A_1.method_88(type);
        int num5 = (num6 & 0x7c) >> 2;
        switch (type)
        {
            case FormFieldType.DropDown:
                if (num5 != 0x19)
                {
                    A_1.method_84(num5);
                }
                break;
        }
        A_1.method_57((num6 & 0x80) != 0);
        A_1.method_61((num6 & 0x100) != 0);
        A_1.method_49((num6 & 0x200) == 0);
        A_1.method_73((num6 & 0x400) == 0);
        A_1.method_67((TextFormFieldType) ((num6 & 0x3800) >> 11));
        A_1.method_51((num6 & 0x4000) != 0);
        bool flag2 = (num6 & 0x8000) != 0;
        A_1.method_65(A_0.ReadUInt16());
        A_1.method_75(A_0.ReadUInt16());
        if (!flag)
        {
            A_0.ReadUInt16();
        }
        A_1.method_47(Class813.smethod_1(A_0, flag, true));
        switch (type)
        {
            case FormFieldType.TextInput:
            {
                string str = Class813.smethod_1(A_0, flag, true);
                if (num5 != 0x19)
                {
                    A_1.method_69(str);
                }
                break;
            }
            case FormFieldType.CheckBox:
                A_1.method_77(A_0.ReadUInt16() != 0);
                if (num5 == 0x19)
                {
                    A_1.method_79(A_1.method_76());
                    break;
                }
                A_1.method_79(num5 != 0);
                break;

            case FormFieldType.DropDown:
                A_1.method_82(A_0.ReadUInt16());
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("永唺嘼儾⹀㑂⭄杆⽈⑊㽌≎煐㕒㱔㉖㕘㽚絜⭞ᡠ።d䥦", num));
        }
        A_1.method_71(Class813.smethod_1(A_0, flag, true));
        A_1.method_59(Class813.smethod_1(A_0, flag, true));
        A_1.method_63(Class813.smethod_1(A_0, flag, true));
        A_1.method_53(Class813.smethod_1(A_0, flag, true));
        A_1.method_55(Class813.smethod_1(A_0, flag, true));
        if ((type == FormFieldType.DropDown) && flag2)
        {
            int num3;
            A_0.ReadInt16();
            if (!flag)
            {
                num3 = A_0.ReadInt16();
                A_0.ReadInt16();
                A_0.ReadInt16();
                A_0.ReadInt16();
                A_0.ReadBytes(num3 * 2);
            }
            else
            {
                num3 = A_0.ReadInt32();
            }
            if (num3 <= 0x19)
            {
                for (int i = 0; i < num3; i++)
                {
                    A_1.method_86().Add(Class813.smethod_1(A_0, flag, false));
                }
            }
        }
    }

    private static bool smethod_2(ShapeObject A_0, Class262 A_1)
    {
        if (!A_0.IsImage)
        {
            return false;
        }
        if (A_0.ImageData.HasImage)
        {
            return false;
        }
        if ((A_1.picfSubType_0 != PicfSubType.InlineShape) && (A_1.picfSubType_0 != PicfSubType.InlineImage0))
        {
            return false;
        }
        return true;
    }
}

