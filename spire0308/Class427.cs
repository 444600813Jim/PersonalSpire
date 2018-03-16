using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.IO;

internal class Class427
{
    private BinaryReader binaryReader_0;
    private BinaryWriter binaryWriter_0;
    internal static bool bool_0;
    private readonly Class1107 class1107_0 = new Class1107();
    private readonly Class1150 class1150_0 = new Class1150();
    private readonly Class140 class140_0;
    private readonly Class141 class141_0;
    private readonly Class143 class143_0;
    private readonly Class52 class52_0;
    private Dictionary<string, int> dictionary_0;
    private const int int_0 = 10;
    private const int int_1 = 0x12;
    private readonly StyleCollection styleCollection_0;

    internal Class427(Class52 A_0, Class812 A_1, StyleCollection A_2)
    {
        this.class52_0 = A_0;
        this.styleCollection_0 = A_2;
        this.class141_0 = new Class141(null, A_1);
        this.class140_0 = new Class140(this.class52_0, A_1);
        this.class143_0 = new Class143(null, A_1, NFibEnum.Word2003);
    }

    internal void method_0(BinaryReader A_0, Class703 A_1, Dictionary<string, int> A_2)
    {
        this.dictionary_0 = A_2;
        if (A_1.class597_0.class1111_1.int_1 != 0)
        {
            this.binaryReader_0 = A_0;
            A_0.BaseStream.Position = A_1.class597_0.class1111_1.int_0;
            int num6 = A_0.ReadUInt16();
            long position = A_0.BaseStream.Position;
            int num7 = A_0.ReadUInt16();
            int num8 = A_0.ReadUInt16();
            A_0.ReadUInt16();
            int num3 = A_0.ReadUInt16();
            if (A_0.ReadUInt16() == 15)
            {
                int num = A_0.ReadUInt16();
                long num2 = A_0.BaseStream.Position;
                this.styleCollection_0.Document.DefCharFormat = (this.styleCollection_0.Document.DefCharFormat == null) ? new CharacterFormat(this.styleCollection_0.Document) : this.styleCollection_0.Document.DefCharFormat;
                CharacterFormat defCharFormat = this.styleCollection_0.Document.DefCharFormat;
                if ((num >= 3) && defCharFormat.IsDefault)
                {
                    defCharFormat.FontNameAscii = this.class52_0.method_9(A_0.ReadInt16());
                    defCharFormat.FontNameFarEast = this.class52_0.method_9(A_0.ReadInt16());
                    defCharFormat.FontNameNonFarEast = this.class52_0.method_9(A_0.ReadInt16());
                }
                long num4 = position + num6;
                if ((A_0.BaseStream.Position < num4) && (num > 3))
                {
                    defCharFormat.FontNameBidi = this.class52_0.method_9(A_0.ReadInt16());
                }
                while ((A_0.BaseStream.Position - num2) < (num * 2))
                {
                    A_0.ReadInt16();
                }
                if (A_0.BaseStream.Position < num4)
                {
                    if (num3 <= 0x9c)
                    {
                        this.styleCollection_0.LatentStyles.method_15();
                    }
                    this.method_4(num3);
                }
                else
                {
                    this.styleCollection_0.LatentStyles.method_16();
                }
                A_0.BaseStream.Position = num4;
                this.method_6(A_1, num7, num8);
                this.method_1(this.styleCollection_0.Document);
                this.method_2();
                if (num3 <= 0x9c)
                {
                    this.method_3();
                }
            }
        }
    }

    private void method_1(Document A_0)
    {
        int num = 15;
        if ((((A_0.Styles != null) && (A_0.Styles.Count > 0)) && ((A_0.Styles[0].Name == BookmarkStart.b("笴堶䬸嘺尼匾", num)) && (A_0.Styles[0].StyleType == StyleType.ParagraphStyle))) && ((A_0.Styles[0] as ParagraphStyle).CharacterFormat != null))
        {
            A_0.DefaultFontNameTable.method_1((A_0.Styles[0] as ParagraphStyle).CharacterFormat.FontNameAscii);
            A_0.DefaultFontNameTable.method_3((A_0.Styles[0] as ParagraphStyle).CharacterFormat.FontNameFarEast);
            A_0.DefaultFontNameTable.method_7((A_0.Styles[0] as ParagraphStyle).CharacterFormat.FontNameBidi);
            A_0.DefaultFontNameTable.method_5((A_0.Styles[0] as ParagraphStyle).CharacterFormat.FontNameNonFarEast);
        }
    }

    private void method_10()
    {
        Class431 class2 = this.class140_0.method_64(this.styleCollection_0.Document.DefCharFormat, this.class1107_0, false);
        this.binaryWriter_0.Write(class2.method_2().Length);
        this.binaryWriter_0.Write(class2.method_2());
        Class430 class3 = this.class141_0.method_62(this.styleCollection_0.DefaultParaPr, this.class1150_0);
        this.binaryWriter_0.Write(class3.method_2().Length);
        this.binaryWriter_0.Write(class3.method_2());
    }

    private void method_11(int A_0)
    {
        int num = 0;
        for (int i = 0; i < this.styleCollection_0.Count; i++)
        {
            Style style = this.styleCollection_0[i] as Style;
            while (num < style.StyleDocId)
            {
                this.binaryWriter_0.Write((ushort) 0);
                num++;
            }
            this.method_17(style);
            num++;
        }
        while (num < A_0)
        {
            this.binaryWriter_0.Write((ushort) 0);
            num++;
        }
    }

    private bool method_12(int A_0, int A_1, bool A_2)
    {
        int num = 5;
        int num2 = this.binaryReader_0.ReadUInt16();
        if (num2 != 0)
        {
            int position = (int) this.binaryReader_0.BaseStream.Position;
            Style style = this.method_14(A_0);
            if (style == null)
            {
                return false;
            }
            if (A_1 > 10)
            {
                this.method_15(style);
            }
            this.binaryReader_0.BaseStream.Position = position + A_1;
            smethod_1(this.binaryReader_0.BaseStream, position);
            string[] sourceArray = Class813.smethod_1(this.binaryReader_0, A_2, true).Split(new char[] { ',' });
            style.method_8(sourceArray[0]);
            if ((this.binaryReader_0.BaseStream.Position - position) < num2)
            {
                this.method_16(style, position);
                smethod_1(this.binaryReader_0.BaseStream, position);
                int num4 = position + num2;
                int num5 = num4 - ((int) this.binaryReader_0.BaseStream.Position);
                if (num5 > 0)
                {
                    Stream baseStream = this.binaryReader_0.BaseStream;
                    baseStream.Position += num5;
                }
                smethod_1(this.binaryReader_0.BaseStream, position);
            }
            string[] destinationArray = new string[sourceArray.Length - 1];
            Array.Copy(sourceArray, 1, destinationArray, 0, destinationArray.Length);
            if ((style.StyleIdentifier == StyleIdentifier.Normal) && (style.BasedOnIstd != 0xfff))
            {
                style.BasedOnIstd = 0xfff;
            }
            if ((style.Name == BookmarkStart.b("䡁ꩉ", num)) || (style.StyleIdentifier == StyleIdentifier.Normal))
            {
                style.Name = BookmarkStart.b("攪䈬崮尰刲头", num);
                style.method_5(BookmarkStart.b("攪䈬崮尰刲头", num));
            }
            this.method_13(style);
            this.dictionary_0.Add(style.Name, style.StyleDocId);
            if (this.styleCollection_0.method_9(style.StyleId) == null)
            {
                this.styleCollection_0.Document.StyleNameIds.Add(style.StyleId, style.Name);
                this.styleCollection_0.method_7(style, destinationArray);
            }
        }
        return true;
    }

    private void method_13(Style A_0)
    {
        int num = 0x11;
        string name = A_0.Name;
        for (int i = 0; this.dictionary_0.ContainsKey(name); i++)
        {
            name = string.Format(BookmarkStart.b("䰶स䘺戼䐾灀㹂", num), A_0.Name, i);
        }
        if (name != A_0.Name)
        {
            A_0.method_8(name);
        }
    }

    private Style method_14(int A_0)
    {
        Style style = null;
        int num = this.binaryReader_0.ReadUInt16();
        StyleIdentifier identifier = ((StyleIdentifier) num) & StyleIdentifier.Nil;
        bool flag = (num & 0x2000) != 0;
        bool flag2 = (num & 0x4000) != 0;
        num = this.binaryReader_0.ReadUInt16();
        StyleType type = ((StyleType) num) & ((StyleType) 15);
        if (type <= StyleType.ListStyle)
        {
            style = Style.smethod_2(type, A_0, identifier, null, this.styleCollection_0.Document);
            style.BasedOnIstd = (num >> 4) & 0xfff;
            style.bool_7 = flag;
            style.bool_8 = flag2;
            num = this.binaryReader_0.ReadUInt16();
            style.NextIstd = (num >> 4) & 0xfff;
            this.binaryReader_0.ReadUInt16();
            num = this.binaryReader_0.ReadUInt16();
            style.AutomaticallyUpdate = (num & 1) != 0;
            style.Hidden = (num & 2) != 0;
            style.LidsSet = (num & 12) != 0;
            style.PersonalCompose = (num & 0x10) != 0;
            style.PersonalReply = (num & 0x20) != 0;
            style.Personal = (num & 0x40) != 0;
            style.IsSemiHidden = (num & 0x100) != 0;
            style.Locked = (num & 0x200) != 0;
            style.bool_9 = (num & 0x400) != 0;
            style.UnhideWhenUsed = (num & 0x800) != 0;
            style.QuickFormat = (num & 0x1000) != 0;
        }
        return style;
    }

    private void method_15(Style A_0)
    {
        int num = this.binaryReader_0.ReadUInt16();
        A_0.LinkedIstd = num & 0xfff;
        if (A_0.LinkedIstd == 0)
        {
            A_0.LinkedIstd = 0xfff;
        }
        A_0.Rsid = this.binaryReader_0.ReadInt32();
        num = this.binaryReader_0.ReadUInt16();
        A_0.UIPriority = (num >> 4) & 0xfff;
    }

    private void method_16(Style A_0, int A_1)
    {
        Class13 class2 = (A_0.StyleType == StyleType.TableStyle) ? ((Class13) A_0) : null;
        switch (A_0.StyleType)
        {
            case StyleType.ParagraphStyle:
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_23(A_0.ParaPr);
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_24(A_0.RunPr);
                return;

            case StyleType.CharacterStyle:
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_24(A_0.RunPr);
                return;

            case StyleType.TableStyle:
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_20(class2);
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_22(class2);
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_21(class2);
                return;

            case StyleType.ListStyle:
                smethod_1(this.binaryReader_0.BaseStream, A_1);
                this.method_23(A_0.ParaPr);
                return;
        }
    }

    private void method_17(Style A_0)
    {
        int num = 11;
        if (A_0.Name.ToLower() == BookmarkStart.b("弰尲䜴娶堸场", 11))
        {
            if (this.styleCollection_0.Document.DefCharFormat != null)
            {
                A_0.CharacterFormat.method_25(this.styleCollection_0.Document.DefCharFormat);
            }
            if (this.styleCollection_0.Document.DefParaFormat != null)
            {
                A_0.ParaPr.method_25(this.styleCollection_0.Document.DefParaFormat);
            }
        }
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((ushort) 0);
        int num3 = (int) this.binaryWriter_0.BaseStream.Position;
        int num4 = this.method_18(A_0);
        smethod_1(this.binaryWriter_0.BaseStream, num3);
        Class813.smethod_2(this.styleCollection_0.method_14(A_0, true), 0x7fffffff, this.binaryWriter_0, true, true);
        this.method_19(A_0, num3);
        smethod_1(this.binaryWriter_0.BaseStream, num3);
        int num5 = (int) this.binaryWriter_0.BaseStream.Position;
        int num6 = num5 - num3;
        if (Class567.smethod_3((long) num6))
        {
            throw new InvalidOperationException(BookmarkStart.b("細嘲嬴倶䴸区ᴼ倾❀捂㙄㍆え❊⡌慎", num));
        }
        this.binaryWriter_0.BaseStream.Seek((long) position, SeekOrigin.Begin);
        this.binaryWriter_0.Write((ushort) num6);
        this.binaryWriter_0.BaseStream.Seek((long) num4, SeekOrigin.Begin);
        this.binaryWriter_0.Write((ushort) num6);
        this.binaryWriter_0.BaseStream.Seek((long) num5, SeekOrigin.Begin);
    }

    private int method_18(Style A_0)
    {
        int styleType = ((int) A_0.StyleIdentifier) | (A_0.bool_7 ? 0x2000 : 0);
        styleType |= A_0.bool_8 ? 0x4000 : 0;
        this.binaryWriter_0.Write((ushort) styleType);
        styleType = (int) A_0.StyleType;
        if (A_0.BaseStyle == null)
        {
            if ((((A_0.StyleIdentifier == StyleIdentifier.Normal) || (A_0.StyleIdentifier == StyleIdentifier.DefaultParagraphFont)) || ((A_0.StyleIdentifier == StyleIdentifier.TableNormal) || (A_0.StyleIdentifier == StyleIdentifier.NoList))) || ((A_0.StyleIdentifier == StyleIdentifier.NoSpacing) || (A_0.StyleIdentifier == StyleIdentifier.User)))
            {
                styleType |= 0xfff0;
            }
        }
        else
        {
            styleType |= this.styleCollection_0.Document.Styles.method_17(A_0.BaseStyle as Style) << 4;
        }
        this.binaryWriter_0.Write((ushort) styleType);
        styleType = smethod_2(A_0.StyleType);
        if (!string.IsNullOrEmpty(A_0.NextStyle))
        {
            styleType |= this.styleCollection_0.Document.Styles.method_16(A_0.NextStyle) << 4;
        }
        else
        {
            styleType |= A_0.StyleDocId << 4;
        }
        this.binaryWriter_0.Write((ushort) styleType);
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((ushort) 0);
        styleType = 0;
        styleType = 0 | (A_0.AutomaticallyUpdate ? 1 : 0);
        styleType |= A_0.Hidden ? 2 : 0;
        styleType |= A_0.LidsSet ? 12 : 0;
        styleType |= A_0.PersonalCompose ? 0x10 : 0;
        styleType |= A_0.PersonalReply ? 0x20 : 0;
        styleType |= A_0.Personal ? 0x40 : 0;
        styleType |= A_0.IsSemiHidden ? 0x100 : 0;
        styleType |= A_0.Locked ? 0x200 : 0;
        styleType |= A_0.bool_9 ? 0x400 : 0;
        styleType |= A_0.UnhideWhenUsed ? 0x800 : 0;
        styleType |= A_0.IsPrimaryStyle ? 0x1000 : 0;
        this.binaryWriter_0.Write((ushort) styleType);
        int num3 = 0;
        if (!string.IsNullOrEmpty(A_0.LinkStyle))
        {
            int num4 = this.styleCollection_0.Document.Styles.method_16(A_0.LinkStyle);
            num3 = (num4 == 0xfff) ? 0 : num4;
        }
        this.binaryWriter_0.Write((ushort) num3);
        this.binaryWriter_0.Write(A_0.Rsid);
        styleType = 0;
        styleType = 0 | (A_0.UIPriority << 4);
        this.binaryWriter_0.Write((ushort) styleType);
        return position;
    }

    private void method_19(Style A_0, int A_1)
    {
        int num = 10;
        switch (A_0.StyleType)
        {
            case StyleType.ParagraphStyle:
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                this.method_25(A_0.ParaPr);
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                this.method_26(A_0.RunPr);
                return;

            case StyleType.CharacterStyle:
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                this.method_26(A_0.RunPr);
                return;

            case StyleType.TableStyle:
            {
                Class13 class2 = (Class13) A_0;
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                this.class143_0.method_68(class2).method_4(this.binaryWriter_0);
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                new Class430(A_0.StyleDocId, this.class141_0.method_72(class2)).imethod_2(this.binaryWriter_0, false);
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                new Class431(this.class140_0.method_66(class2)).imethod_2(this.binaryWriter_0, false);
                return;
            }
            case StyleType.ListStyle:
                smethod_1(this.binaryWriter_0.BaseStream, A_1);
                this.method_25(A_0.ParaPr);
                return;
        }
        throw new InvalidOperationException(BookmarkStart.b("支就弳堵圷䴹刻ḽ㌿㙁㵃⩅ⵇ橉㡋㝍⁏㝑穓", num));
    }

    private void method_2()
    {
        int num = 0x10;
        foreach (Style style in this.styleCollection_0)
        {
            if (!(style.Name != BookmarkStart.b("砵圷䠹儻弽ⰿ", num)))
            {
                continue;
            }
            string str = string.Empty;
            if (style.BasedOnIstd == 0xfff)
            {
                goto Label_00F5;
            }
            str = string.Empty;
            using (Dictionary<string, int>.Enumerator enumerator4 = this.dictionary_0.GetEnumerator())
            {
                KeyValuePair<string, int> current;
                while (enumerator4.MoveNext())
                {
                    current = enumerator4.Current;
                    if (current.Value == style.BasedOnIstd)
                    {
                        goto Label_0096;
                    }
                }
                goto Label_00AF;
            Label_0096:
                str = current.Key;
            }
        Label_00AF:
            if (!string.IsNullOrEmpty(str))
            {
                IStyle style2 = this.styleCollection_0.FindByName(str);
                if (((style != style2) && (style != null)) && ((style2 != null) && (style2.StyleType == style.StyleType)))
                {
                    style.ApplyBaseStyle(style2.Name);
                }
            }
            goto Label_0105;
        Label_00F5:
            if (style is ParagraphStyle)
            {
                style.method_6();
            }
        Label_0105:
            if (style.NextIstd != 0xfff)
            {
                using (Dictionary<string, int>.Enumerator enumerator2 = this.dictionary_0.GetEnumerator())
                {
                    KeyValuePair<string, int> pair;
                    while (enumerator2.MoveNext())
                    {
                        pair = enumerator2.Current;
                        if (pair.Value == style.NextIstd)
                        {
                            goto Label_0147;
                        }
                    }
                    goto Label_0165;
                Label_0147:
                    style.NextStyle = pair.Key;
                }
            }
        Label_0165:
            if (style.LinkedIstd != 0xfff)
            {
                using (Dictionary<string, int>.Enumerator enumerator3 = this.dictionary_0.GetEnumerator())
                {
                    KeyValuePair<string, int> pair2;
                    while (enumerator3.MoveNext())
                    {
                        pair2 = enumerator3.Current;
                        if (pair2.Value == style.LinkedIstd)
                        {
                            goto Label_01A9;
                        }
                    }
                    continue;
                Label_01A9:
                    style.LinkStyle = pair2.Key;
                }
            }
        }
    }

    private void method_20(Class13 A_0)
    {
        this.class143_0.method_63(new Class432(this.binaryReader_0).method_2(), A_0);
    }

    private void method_21(Class13 A_0)
    {
        this.class140_0.method_63(new Class431(this.binaryReader_0, false).method_2(), A_0, this.dictionary_0);
    }

    private void method_22(Class13 A_0)
    {
        this.class141_0.method_66(new Class430(this.binaryReader_0, false).method_2(), A_0);
    }

    private void method_23(ParagraphFormat A_0)
    {
        Class430 class2 = new Class430(this.binaryReader_0, false);
        this.class141_0.method_64(class2, A_0, this.class1150_0);
    }

    private void method_24(CharacterFormat A_0)
    {
        this.class140_0.method_62(new Class431(this.binaryReader_0, false).method_2(), A_0, this.class1107_0, this.dictionary_0);
    }

    private void method_25(ParagraphFormat A_0)
    {
        this.class141_0.method_62(A_0, this.class1150_0).imethod_2(this.binaryWriter_0, false);
    }

    private void method_26(CharacterFormat A_0)
    {
        this.class140_0.method_64(smethod_0(A_0), this.class1107_0, false).imethod_2(this.binaryWriter_0, false);
    }

    private void method_3()
    {
        Class547 latentStyles = this.styleCollection_0.LatentStyles;
        foreach (Style style in this.styleCollection_0)
        {
            if (style.StyleIdentifier != StyleIdentifier.DefaultParagraphFont)
            {
                Class66 class3 = latentStyles.method_14().method_3(style.StyleIdentifier);
                if (class3 != null)
                {
                    style.Locked = class3.method_3();
                    style.QuickFormat = class3.method_5();
                    style.UIPriority = class3.method_9();
                    if (class3.method_11())
                    {
                        style.IsSemiHidden = false;
                        style.UnhideWhenUsed = false;
                        class3.method_8(false);
                        class3.method_12(false);
                    }
                }
            }
        }
    }

    private void method_4(int A_0)
    {
        this.binaryReader_0.ReadUInt16();
        Class547 latentStyles = this.styleCollection_0.LatentStyles;
        for (int i = 0; i < A_0; i++)
        {
            int num2 = this.binaryReader_0.ReadInt32();
            bool flag = (num2 & 1) != 0;
            bool flag2 = (num2 & 2) != 0;
            bool flag3 = (num2 & 4) != 0;
            bool flag4 = (num2 & 8) != 0;
            int num3 = (num2 >> 4) & 0xfff;
            Class66 class3 = new Class66((StyleIdentifier) i, flag, flag4, flag2, num3, flag3);
            if (!latentStyles.method_1(class3))
            {
                latentStyles.method_14().method_1(class3);
            }
        }
    }

    private void method_5()
    {
        int count = this.binaryReader_0.ReadInt32();
        byte[] buffer = this.binaryReader_0.ReadBytes(count);
        this.class140_0.method_62(buffer, this.styleCollection_0.Document.DefCharFormat, this.class1107_0, this.dictionary_0);
        int num2 = this.binaryReader_0.ReadInt32();
        byte[] buffer2 = this.binaryReader_0.ReadBytes(num2);
        ParagraphFormat format = new ParagraphFormat(this.styleCollection_0.Document);
        this.class141_0.method_65(buffer2, format, this.class1150_0);
    }

    private void method_6(Class703 A_0, int A_1, int A_2)
    {
        bool flag = A_0.ushort_2 != 0;
        int num = A_0.class597_0.class1111_1.int_0 + A_0.class597_0.class1111_1.int_1;
        for (int i = 0; i < A_1; i++)
        {
            if (this.binaryReader_0.BaseStream.Position >= num)
            {
                return;
            }
            if (!this.method_12(i, A_2, flag))
            {
                return;
            }
        }
    }

    internal int method_7(BinaryWriter A_0)
    {
        this.binaryWriter_0 = A_0;
        int num = this.styleCollection_0.method_15();
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((ushort) 0);
        int num3 = (int) this.binaryWriter_0.BaseStream.Position;
        this.method_8(num, 0x10b);
        this.method_9(0x10b);
        int num4 = (int) this.binaryWriter_0.BaseStream.Position;
        int num5 = num4 - num3;
        this.binaryWriter_0.BaseStream.Position = position;
        this.binaryWriter_0.Write((ushort) num5);
        this.binaryWriter_0.BaseStream.Position = num4;
        this.method_11(num);
        return (((int) this.binaryWriter_0.BaseStream.Position) - position);
    }

    private void method_8(int A_0, int A_1)
    {
        int num = 8;
        this.binaryWriter_0.Write((ushort) A_0);
        this.binaryWriter_0.Write((ushort) 0x12);
        this.binaryWriter_0.Write((ushort) 1);
        this.binaryWriter_0.Write((ushort) A_1);
        this.binaryWriter_0.Write((ushort) 15);
        this.binaryWriter_0.Write((ushort) 7);
        CharacterFormat defCharFormat = this.styleCollection_0.Document.DefCharFormat;
        if (defCharFormat == null)
        {
            Style style = this.styleCollection_0.FindByName(BookmarkStart.b("怭弯䀱夳圵吷", num));
            if (style == null)
            {
                defCharFormat = new CharacterFormat(this.styleCollection_0.Document);
            }
            else
            {
                defCharFormat = style.CharacterFormat;
            }
        }
        if (defCharFormat != null)
        {
            this.binaryWriter_0.Write((ushort) this.class52_0.method_8(defCharFormat.FontNameAscii));
            this.binaryWriter_0.Write((ushort) this.class52_0.method_8(defCharFormat.FontNameFarEast));
            this.binaryWriter_0.Write((ushort) this.class52_0.method_8(defCharFormat.FontNameNonFarEast));
            this.binaryWriter_0.Write((ushort) this.class52_0.method_8(defCharFormat.FontNameBidi));
            this.binaryWriter_0.Write((ushort) 0);
            this.binaryWriter_0.Write((ushort) 0);
            this.binaryWriter_0.Write((ushort) 0);
        }
        else
        {
            for (int i = 0; i < 7; i++)
            {
                this.binaryWriter_0.Write((ushort) 0);
            }
        }
    }

    private void method_9(int A_0)
    {
        this.binaryWriter_0.Write((ushort) 4);
        Class547 latentStyles = this.styleCollection_0.LatentStyles;
        int num = 0;
        num = 0 | (latentStyles.method_2() ? 1 : 0);
        num |= latentStyles.method_6() ? 2 : 0;
        num |= latentStyles.method_10() ? 4 : 0;
        num |= latentStyles.method_4() ? 8 : 0;
        num |= latentStyles.method_8() << 4;
        for (int i = 0; i < A_0; i++)
        {
            int num3 = 0;
            Class66 class3 = latentStyles.method_14().method_3((StyleIdentifier) i);
            if (class3 != null)
            {
                num3 |= class3.method_3() ? 1 : 0;
                num3 |= class3.method_7() ? 2 : 0;
                num3 |= class3.method_11() ? 4 : 0;
                num3 |= class3.method_5() ? 8 : 0;
                num3 |= class3.method_9() << 4;
            }
            else
            {
                num3 = num;
            }
            this.binaryWriter_0.Write(num3);
        }
    }

    private static CharacterFormat smethod_0(CharacterFormat A_0)
    {
        CharacterFormat format = (CharacterFormat) A_0.Clone();
        format.Remove(50);
        return format;
    }

    internal static void smethod_1(Stream A_0, int A_1)
    {
        int num = ((int) A_0.Position) - A_1;
        if (Class567.smethod_3((long) num))
        {
            int num2 = ((int) A_0.Position) + 1;
            if (A_0.Length < num2)
            {
                A_0.SetLength((long) num2);
            }
            A_0.Position = num2;
        }
    }

    private static int smethod_2(StyleType A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case StyleType.ParagraphStyle:
                return 2;

            case StyleType.CharacterStyle:
                return 1;

            case StyleType.TableStyle:
                return 3;

            case StyleType.ListStyle:
                return 1;
        }
        throw new InvalidOperationException(BookmarkStart.b("昲嬴尶圸吺䨼儾慀あㅄ㹆╈⹊浌㭎⡐⍒ご祖", num));
    }
}

