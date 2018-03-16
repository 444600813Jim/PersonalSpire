using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Documents.Converters.BinaryDoc.ddf;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;

internal class Class764 : Class763
{
    private bool bool_1;
    private Class1109 class1109_0;
    private Class140 class140_0;
    private Class142 class142_0;
    private Class352 class352_0;
    private readonly Class861 class861_0;
    private Dictionary<string, int> dictionary_0;
    private Dictionary<int, string> dictionary_1;
    private readonly Document document_0;
    private readonly Interface28 interface28_0;

    internal Class764(Class1132 A_0, string A_1, Document A_2) : this(A_0, A_1, A_2, new Class861())
    {
    }

    internal Class764(Class1132 A_0, string A_1, Document A_2, Class861 A_3) : base(A_0, A_1)
    {
        this.document_0 = A_2;
        this.interface28_0 = new Class482(A_2, A_3, this);
        this.class861_0 = A_3;
    }

    internal void method_28()
    {
        int num = 0x10;
        Class599.smethod_0(this.document_0.FontInfoList, base.method_5(), base.method_3(), base.method_1());
        Class812 class2 = new Class812(base.method_5(), base.method_3());
        this.class142_0 = new Class142(class2);
        this.class140_0 = new Class140(this.document_0.FontInfoList, class2);
        this.class1109_0 = new Class1109(base.method_4(), class2, base.method_5().nfibEnum_0, this);
        this.class352_0 = new Class352(this.document_0);
        this.class352_0.method_3(base.method_3(), base.method_5().class597_0.class1111_50.int_0, base.method_5().class597_0.class1111_50.int_1, base.method_1());
        if (ShapeObject.smethod_1(this.class352_0.method_12()))
        {
            this.document_0.method_27(new Background(this.document_0, this.class352_0.method_12()));
        }
        new Class427(this.document_0.FontInfoList, class2, this.document_0.Styles).method_0(base.method_3(), base.method_5(), this.method_47());
        new Class1060(this.document_0.FontInfoList, class2, this.document_0.ListStyles, this.document_0.ListOverrides).method_0(base.method_5(), base.method_3(), this.method_47(), this.method_48());
        this.document_0.Frame = Class1152.smethod_0(base.method_5(), base.method_3(), this.document_0.ListStyles);
        Class659.smethod_0(base.method_3(), base.method_5().class597_0.class1111_31, this.document_0);
        if (base.method_5().class597_0.method_6())
        {
            this.document_0.RouteSlip = new Class481(base.method_5(), base.method_3(), this.document_0.Settings.int_27);
        }
        Class342 class3 = new Class342();
        class3.method_0(base.method_3(), base.method_5().class597_0.class1111_72.int_0, base.method_5().class597_0.class1111_72.int_1);
        new Class869().method_0(base.method_3(), base.method_5(), class3, this.document_0.Settings.class460_0);
        base.method_18().method_0(class3, this.document_0.FileName);
        new Class704().method_0(base.method_0().method_0(), this.document_0.BuiltinDocumentProperties, this.document_0.CustomDocumentProperties);
        this.method_31();
        this.method_32();
        this.method_34();
        base.method_3().BaseStream.Position = base.method_5().class597_0.class1111_45.int_0;
        this.document_0.DropdownStrings = base.method_3().ReadBytes(base.method_5().class597_0.class1111_45.int_1);
        base.method_3().BaseStream.Position = base.method_5().class597_0.class1111_24.int_0;
        new Class660().method_0(base.method_3(), base.method_5().class597_0.class1111_24.int_1, this.document_0);
        Class125.smethod_0(base.method_5(), base.method_3(), this.document_0);
        this.document_0.CompObj = base.method_0().method_0().method_4(BookmarkStart.b("㜵笷唹儻丽༿⁁⹃", num));
        this.document_0.VbaMacros = base.method_0().method_0().method_6(BookmarkStart.b("笵夷夹主儽㌿", num));
        new Class1108(this).method_0();
        if (base.method_5().nfibEnum_0 <= NFibEnum.Word2000)
        {
            this.method_30();
        }
        Class871.smethod_0(base.method_0(), this.document_0.CustomXmlParts);
    }

    private void method_29(ShapeObject A_0)
    {
        if (A_0.Fill.FillType == FillType.Picture)
        {
            this.document_0.Background.Color = A_0.Fill.ColorInternal;
            this.document_0.Background.ImageBytes = A_0.Fill.ImageBytes;
            this.document_0.Background.Type = BackgroundType.Picture;
        }
        else if (A_0.Fill.FillType == FillType.Solid)
        {
            this.document_0.Background.Color = A_0.Fill.ColorInternal;
            this.document_0.Background.Type = BackgroundType.Color;
        }
    }

    private void method_30()
    {
        foreach (Section section in this.document_0.Sections)
        {
            this.document_0.Settings.footEndnoteOptions_0.method_37(section.SectPr);
        }
    }

    private void method_31()
    {
        if (base.method_5().class868_0.class1111_4.int_1 != 0)
        {
            base.method_3().BaseStream.Position = base.method_5().class868_0.class1111_4.int_0;
            byte[] bytes = base.method_3().ReadBytes(base.method_5().class868_0.class1111_4.int_1);
            this.document_0.Settings.string_4 = Encoding.Unicode.GetString(bytes);
        }
    }

    private void method_32()
    {
        if (base.method_5().class597_0.class1111_32.int_1 != 0)
        {
            StringCollection strings = new StringCollection();
            Class343.smethod_1(base.method_3(), base.method_5().class597_0.class1111_32, strings);
            this.document_0.Settings.string_0 = this.method_33(strings, TableAssociatedString.AssocDot);
            if (base.method_5().bool_7)
            {
                string password = this.method_33(strings, TableAssociatedString.WriteProtectionPassword);
                this.document_0.Protect(ProtectionType.NoProtection, password);
            }
        }
    }

    private string method_33(StringCollection A_0, TableAssociatedString A_1)
    {
        int num = (int) A_1;
        if ((num >= 0) && (num <= (A_0.Count - 1)))
        {
            return A_0[num];
        }
        return "";
    }

    private void method_34()
    {
        if (base.method_5().class597_0.class1111_91.int_1 != 0)
        {
            StringCollection strings = new StringCollection();
            Class343.smethod_1(base.method_3(), base.method_5().class597_0.class1111_91, strings);
            this.document_0.Settings.int_29 = strings.Count;
        }
    }

    internal Class17 method_35(int A_0)
    {
        int num = base.method_13().method_12(A_0);
        if (num < 0)
        {
            return null;
        }
        Class596 class4 = base.method_13().method_25(num);
        Class17 class3 = new Class17(this.method_42());
        if (class4.class429_0 != null)
        {
            this.class142_0.method_62(class4.class429_0.method_2(), class3);
        }
        int num2 = base.method_13().method_16(num + 1);
        int num3 = base.method_6().method_1(num2 - 1);
        if (num3 != -1)
        {
            Class602 class2 = base.method_6().method_4(num3);
            this.class142_0.method_62(class2.method_1().method_2(), class3);
        }
        return class3;
    }

    internal bool method_36()
    {
        return ((base.method_13().method_4() > 0) && (base.method_13().method_25(base.method_13().method_4() - 1).short_1 == 1));
    }

    internal Struct24 method_37(int A_0, Class428 A_1)
    {
        int num = base.method_14().method_11(A_0);
        this.class1109_0.method_0(base.method_14().method_25(num), A_1.method_2(), this.document_0);
        return new Struct24(this.class1109_0.method_1(), this.class1109_0.method_2(), this.class1109_0.method_3());
    }

    internal int method_38(int A_0, Class428 A_1, out CharacterFormat A_2, out Class1107 A_3)
    {
        int num = base.method_15().method_11(A_0);
        Class431 class2 = base.method_15().method_25(num);
        A_2 = new CharacterFormat(this.document_0);
        A_3 = new Class1107();
        this.class140_0.method_62(class2.method_2(), A_2, A_3, this.method_47());
        this.class140_0.method_62(A_1.method_2(), A_2, A_3, this.method_47());
        return base.method_15().method_16(num + 1);
    }

    internal ShapeBase method_39(int A_0, EscherDrawingType A_1)
    {
        ShapeBase base2 = this.class352_0.method_0(A_0, A_1);
        this.class352_0.method_1(A_0, A_1);
        return base2;
    }

    internal ShapeObject method_40(int A_0)
    {
        return Class931.smethod_0(this.class352_0, base.method_4(), A_0);
    }

    internal Class454 method_41(int A_0)
    {
        Class454 class3;
        Class1089 class2 = base.method_0().method_0().method_6(BookmarkStart.b("挫䰭娯圱圳䈵样唹医刽", 6));
        if (class2 == null)
        {
            return null;
        }
        using (IDictionaryEnumerator enumerator = class2.GetEnumerator())
        {
            DictionaryEntry current;
            while (enumerator.MoveNext())
            {
                current = (DictionaryEntry) enumerator.Current;
                string key = (string) current.Key;
                int num = Class1041.smethod_18(key.TrimStart(new char[] { '_' }));
                if ((num != -2147483648) && (A_0 == num))
                {
                    goto Label_0081;
                }
            }
            return null;
        Label_0081:
            class3 = new Class454(A_0, (Class1089) current.Value);
        }
        return class3;
    }

    internal Document method_42()
    {
        return this.document_0;
    }

    internal Interface28 method_43()
    {
        return this.interface28_0;
    }

    internal bool method_44()
    {
        return this.bool_1;
    }

    internal void method_45(bool A_0)
    {
        this.bool_1 = A_0;
    }

    internal Class352 method_46()
    {
        return this.class352_0;
    }

    internal Dictionary<string, int> method_47()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, int>();
        }
        return this.dictionary_0;
    }

    internal Dictionary<int, string> method_48()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<int, string>();
        }
        return this.dictionary_1;
    }
}

