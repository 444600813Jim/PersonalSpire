using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

internal class Class1060
{
    private BinaryReader binaryReader_0;
    private BinaryWriter binaryWriter_0;
    internal static bool bool_0;
    private readonly Class140 class140_0;
    private readonly Class141 class141_0;
    private readonly Class48 class48_0;
    private Class703 class703_0;
    private Dictionary<int, string> dictionary_0;
    private Dictionary<string, int> dictionary_1;
    private Dictionary<string, int> dictionary_2;
    private int int_0 = 2;
    private readonly ListStyleCollection listStyleCollection_0;

    internal Class1060(Class52 A_0, Class812 A_1, ListStyleCollection A_2, Class48 A_3)
    {
        this.listStyleCollection_0 = A_2;
        this.int_0 = this.listStyleCollection_0.Count;
        this.class48_0 = A_3;
        this.class141_0 = new Class141(null, A_1);
        this.class140_0 = new Class140(A_0, A_1);
    }

    internal void method_0(Class703 A_0, BinaryReader A_1, Dictionary<string, int> A_2, Dictionary<int, string> A_3)
    {
        this.dictionary_2 = A_2;
        this.dictionary_0 = A_3;
        this.class703_0 = A_0;
        this.binaryReader_0 = A_1;
        this.method_3();
        this.method_16();
        this.method_24();
        this.method_1();
    }

    private void method_1()
    {
        int num = 6;
        foreach (Style style in this.listStyleCollection_0.Document.Styles)
        {
            if ((style is ParagraphStyle) && style.ParaPr.method_6(0x460))
            {
                int key = (int) style.ParaPr.method_31(0x460);
                if (key == 0)
                {
                    (style as ParagraphStyle).ListFormat.IsEmptyList = true;
                }
                else
                {
                    byte num2 = 0;
                    if (style.ParaPr.method_6(0x456))
                    {
                        num2 = (byte) style.ParaPr.method_31(0x456);
                    }
                    string name = string.Empty;
                    if (this.listStyleCollection_0.ListStyleNames.ContainsKey(key.ToString()))
                    {
                        name = this.listStyleCollection_0.ListStyleNames[key.ToString()];
                    }
                    if (this.listStyleCollection_0.FindByName(name) != null)
                    {
                        (style as ParagraphStyle).ListFormat.ApplyStyle(name);
                    }
                    if ((this.dictionary_0 != null) && this.dictionary_0.ContainsKey(key))
                    {
                        (style as ParagraphStyle).ListFormat.LFOStyleName = this.dictionary_0[key];
                    }
                    (style as ParagraphStyle).ListFormat.ListLevelNumber = num2;
                    if ((style as ParagraphStyle).ListFormat.CurrentListLevel != null)
                    {
                        (style as ParagraphStyle).ListFormat.CurrentListLevel.ParaStyleName = style.StyleId.Replace(BookmarkStart.b("ఫ", num), string.Empty);
                    }
                }
            }
        }
    }

    private void method_10(ListStyle A_0)
    {
        for (int i = 0; i < A_0.Levels.Count; i++)
        {
            this.method_13(A_0.Levels[i], i);
        }
    }

    private bool method_11(ListLevel A_0)
    {
        bool flag2;
        int num = 7;
        A_0.method_10(this.binaryReader_0.ReadInt32());
        A_0.PatternType = (ListPatternType) this.binaryReader_0.ReadByte();
        int num2 = this.binaryReader_0.ReadByte();
        A_0.NumberAlignment = ((ListNumberAlignment) num2) & (ListNumberAlignment.Right | ListNumberAlignment.Center);
        A_0.IsLegalStyleNumbering = (num2 & 4) != 0;
        bool flag = (num2 & 8) != 0;
        A_0.bool_8 = (num2 & 0x10) != 0;
        A_0.bool_9 = (num2 & 0x20) != 0;
        A_0.Word6Legacy = (num2 & 0x40) != 0;
        A_0.bool_7 = (num2 & 0x80) != 0;
        this.binaryReader_0.ReadBytes(9);
        A_0.FollowCharacter = (FollowCharacterType) this.binaryReader_0.ReadByte();
        A_0.LegacySpace = this.binaryReader_0.ReadInt32();
        A_0.LegacyIndent = this.binaryReader_0.ReadInt32();
        int num3 = this.binaryReader_0.ReadByte();
        int num4 = this.binaryReader_0.ReadByte();
        int num5 = this.binaryReader_0.ReadByte() - 1;
        this.binaryReader_0.ReadByte();
        if (flag && (num5 == 0))
        {
            A_0.NoRestartByHigher = true;
        }
        this.class141_0.method_65(new Class428(this.binaryReader_0, num4).method_2(), A_0.ParagraphFormat, null);
        if ((this.class703_0.nfibEnum_0 == NFibEnum.Word97BiDi) && !A_0.ParagraphFormat.method_6(0x618))
        {
            A_0.ParagraphFormat.IsBidi = true;
            Class646.smethod_1(A_0.ParagraphFormat);
            A_0.ParagraphFormat.Remove(0x618);
        }
        else
        {
            Class646.smethod_1(A_0.ParagraphFormat);
        }
        this.class140_0.method_62(new Class428(this.binaryReader_0, num3).method_2(), A_0.CharacterFormat, null, this.dictionary_2);
        uint num7 = this.binaryReader_0.ReadUInt16();
        Stream baseStream = this.binaryReader_0.BaseStream;
        baseStream.Position -= 2L;
        if (flag2 = Class567.smethod_46(this.binaryReader_0, (int) num7))
        {
            string str = Class813.smethod_1(this.binaryReader_0, true, false);
            if ((ListLevel.smethod_1(str) && (str != null)) && ((str.Length <= 30) && (str.IndexOf(0xffff) < 0)))
            {
                for (int i = 0; i < 9; i++)
                {
                    str = str.Replace(((char) i).ToString(), string.Format(BookmarkStart.b("ࠬ吮İ串", num), i + 1));
                }
                if (A_0.PatternType == ListPatternType.Bullet)
                {
                    A_0.BulletCharacter = str;
                }
                else
                {
                    A_0.LevelText = str;
                    string str3 = BookmarkStart.b("ࠬ", num) + ((A_0.LevelNumber + 1)).ToString();
                    int index = str.IndexOf(str3);
                    if (index != -1)
                    {
                        A_0.NumberPrefix = str.Substring(0, index);
                        A_0.NumberPrefix = this.method_12(A_0.NumberPrefix);
                        int startIndex = index + 2;
                        A_0.NumberSufix = str.Substring(startIndex, str.Length - startIndex);
                    }
                    else
                    {
                        A_0.NoPlaceholder = true;
                        if (!string.IsNullOrEmpty(str))
                        {
                            A_0.NumberPrefix = str;
                        }
                        else
                        {
                            A_0.NumberPrefix = (string) (A_0.NumberSufix = null);
                        }
                        A_0.NoLevelText = true;
                    }
                }
            }
        }
        smethod_0(A_0);
        return flag2;
    }

    private string method_12(string A_0)
    {
        int num = 4;
        if ((A_0 != null) && !(A_0 == string.Empty))
        {
            string str = A_0;
            return str.Replace(BookmarkStart.b("༩ᴫ", num), BookmarkStart.b("⨩", num)).Replace(BookmarkStart.b("༩ḫ", num), BookmarkStart.b("⬩", num)).Replace(BookmarkStart.b("༩Ἣ", num), BookmarkStart.b("⠩", num)).Replace(BookmarkStart.b("༩ᠫ", num), BookmarkStart.b("⤩", num)).Replace(BookmarkStart.b("༩ᤫ", num), BookmarkStart.b("⸩", num)).Replace(BookmarkStart.b("༩ᨫ", num), BookmarkStart.b("⼩", num)).Replace(BookmarkStart.b("༩ᬫ", num), BookmarkStart.b("Ⱙ", num)).Replace(BookmarkStart.b("༩ᐫ", num), BookmarkStart.b("⴩", num)).Replace(BookmarkStart.b("༩ᔫ", num), BookmarkStart.b("∩", num));
        }
        return A_0;
    }

    private void method_13(ListLevel A_0, int A_1)
    {
        string bulletCharacter;
        this.binaryWriter_0.Write(A_0.StartAt);
        this.binaryWriter_0.Write((byte) A_0.PatternType);
        int num = 0;
        num = 0 | ((byte) A_0.NumberAlignment);
        num |= A_0.IsLegalStyleNumbering ? 4 : 0;
        num |= A_0.NoRestartByHigher ? 8 : 0;
        num |= A_0.bool_8 ? 0x10 : 0;
        num |= A_0.bool_9 ? 0x20 : 0;
        num |= A_0.Word6Legacy ? 0x40 : 0;
        num |= A_0.bool_7 ? 0x80 : 0;
        this.binaryWriter_0.Write((byte) num);
        if (A_0.PatternType == ListPatternType.Bullet)
        {
            bulletCharacter = A_0.BulletCharacter;
        }
        else
        {
            string str2 = string.Empty;
            if ((A_0.NumberPrefix != null) && (A_0.NumberPrefix.Length > 0))
            {
                str2 = this.method_14(A_0.NumberPrefix);
            }
            bulletCharacter = str2;
            if (!A_0.NoLevelText && (A_0.NumberSufix != null))
            {
                bulletCharacter = bulletCharacter + Convert.ToChar(A_1).ToString() + A_0.NumberSufix;
            }
            else if (A_0.PatternType == ListPatternType.None)
            {
                bulletCharacter = A_0.LevelText;
            }
        }
        bulletCharacter = this.method_12(bulletCharacter);
        byte[] buffer = smethod_2(bulletCharacter);
        this.binaryWriter_0.Write(buffer);
        this.binaryWriter_0.Write((byte) A_0.FollowCharacter);
        this.binaryWriter_0.Write(A_0.LegacySpace);
        this.binaryWriter_0.Write(A_0.LegacyIndent);
        smethod_1(A_0);
        Class431 class2 = this.class140_0.method_64(A_0.CharacterFormat, null, false);
        this.binaryWriter_0.Write((byte) class2.method_2().Length);
        Class430 class3 = this.class141_0.method_62(A_0.ParagraphFormat, null);
        this.binaryWriter_0.Write((byte) class3.method_2().Length);
        this.binaryWriter_0.Write((short) 0);
        this.binaryWriter_0.Write(class3.method_2());
        this.binaryWriter_0.Write(class2.method_2());
        Class813.smethod_2(bulletCharacter, 0x7fffffff, this.binaryWriter_0, true, false);
    }

    private string method_14(string A_0)
    {
        string str = A_0;
        return str.Replace(BookmarkStart.b("㄰", 11), BookmarkStart.b("ᐰȲ", 11)).Replace(BookmarkStart.b("〰", 11), BookmarkStart.b("ᐰĲ", 11)).Replace(BookmarkStart.b("㌰", 11), BookmarkStart.b("ᐰ2", 11)).Replace(BookmarkStart.b("㈰", 11), BookmarkStart.b("ᐰܲ", 11)).Replace(BookmarkStart.b("㔰", 11), BookmarkStart.b("ᐰز", 11)).Replace(BookmarkStart.b("㐰", 11), BookmarkStart.b("ᐰԲ", 11)).Replace(BookmarkStart.b("㜰", 11), BookmarkStart.b("ᐰв", 11)).Replace(BookmarkStart.b("㘰", 11), BookmarkStart.b("ᐰଲ", 11)).Replace(BookmarkStart.b("㤰", 11), BookmarkStart.b("ᐰਲ", 11));
    }

    private char method_15(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return '\0';

            case 2:
                return '\x0001';

            case 3:
                return '\x0002';

            case 4:
                return '\x0003';

            case 5:
                return '\x0004';

            case 6:
                return '\x0005';

            case 7:
                return '\x0006';

            case 8:
                return '\a';
        }
        return '\b';
    }

    private void method_16()
    {
        if (this.class703_0.class597_0.class1111_74.int_1 != 0)
        {
            this.binaryReader_0.BaseStream.Seek((long) this.class703_0.class597_0.class1111_74.int_0, SeekOrigin.Begin);
            int num2 = this.binaryReader_0.ReadInt32();
            List<Class12> list = new List<Class12>();
            for (int i = 0; i < num2; i++)
            {
                Class12 item = this.method_18();
                list.Add(item);
                string key = ((this.listStyleCollection_0.ListStyleNames.Count - 2) + 1).ToString();
                if (item.method_26() > 0)
                {
                    this.class48_0.method_34(item);
                    this.dictionary_0.Add(i + 1, item.Name);
                    this.listStyleCollection_0.ListStyleNames.Add(key, this.listStyleCollection_0[this.dictionary_1[item.method_24().ToString()] + 1].Name);
                    item.method_25(this.listStyleCollection_0.ListStyleNames.Count);
                }
                else if ((this.dictionary_1 != null) && this.dictionary_1.ContainsKey(item.method_24().ToString()))
                {
                    this.listStyleCollection_0.ListStyleNames.Add(key, this.listStyleCollection_0[this.dictionary_1[item.method_24().ToString()] + 1].Name);
                }
            }
            for (int j = 0; j < list.Count; j++)
            {
                this.method_20(list[j]);
            }
        }
    }

    private int method_17()
    {
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        if (this.listStyleCollection_0.ilist_1 == null)
        {
            return 0;
        }
        this.binaryWriter_0.Write(this.listStyleCollection_0.ilist_1.Count);
        int num3 = 0;
        foreach (KeyValuePair<int, int> pair in this.listStyleCollection_0.dictionary_3)
        {
            this.binaryWriter_0.Write((int) (pair.Value + 1));
            this.method_19(this.listStyleCollection_0.ilist_1[num3]);
            num3++;
        }
        for (int i = 0; i < this.listStyleCollection_0.ilist_1.Count; i++)
        {
            this.method_21(this.listStyleCollection_0.ilist_1[i]);
        }
        return (((int) this.binaryWriter_0.BaseStream.Position) - position);
    }

    private Class12 method_18()
    {
        int num = this.binaryReader_0.ReadInt32();
        Class12 class2 = new Class12(this.listStyleCollection_0.Document, num) {
            Name = BookmarkStart.b("樥丧䔩缫娭䤯帱儳椵", 0) + Guid.NewGuid().ToString()
        };
        this.binaryReader_0.ReadInt32();
        this.binaryReader_0.ReadInt32();
        int num2 = Math.Min(this.binaryReader_0.ReadByte(), 9);
        class2.method_27(num2);
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadByte();
        return class2;
    }

    private void method_19(Class12 A_0)
    {
        this.binaryWriter_0.Write(0);
        this.binaryWriter_0.Write(0);
        this.binaryWriter_0.Write((byte) A_0.method_23().Count);
        this.binaryWriter_0.Write((byte) 0);
        this.binaryWriter_0.Write((short) 0);
    }

    internal void method_2(Class703 A_0, BinaryWriter A_1)
    {
        this.class703_0 = A_0;
        this.binaryWriter_0 = A_1;
        this.class703_0.class597_0.class1111_73.int_0 = (int) this.binaryWriter_0.BaseStream.Position;
        this.class703_0.class597_0.class1111_73.int_1 = this.method_4();
        this.class703_0.class597_0.class1111_74.int_0 = (int) this.binaryWriter_0.BaseStream.Position;
        this.class703_0.class597_0.class1111_74.int_1 = this.method_17();
        this.class703_0.class597_0.class1111_90.int_0 = (int) this.binaryWriter_0.BaseStream.Position;
        this.class703_0.class597_0.class1111_90.int_1 = this.method_25();
    }

    private void method_20(Class12 A_0)
    {
        this.binaryReader_0.ReadInt32();
        for (int i = 0; i < A_0.method_26(); i++)
        {
            this.method_22(A_0);
        }
    }

    private void method_21(Class12 A_0)
    {
        this.binaryWriter_0.Write(uint.MaxValue);
        foreach (OverrideLevelFormat format in A_0.method_23())
        {
            this.method_23(format);
        }
    }

    private void method_22(Class12 A_0)
    {
        int num = this.binaryReader_0.ReadInt32();
        int num2 = this.binaryReader_0.ReadByte();
        int num3 = num2 & 15;
        OverrideLevelFormat format = new OverrideLevelFormat(this.listStyleCollection_0.Document);
        A_0.method_23().method_9(num3, format);
        format.OverrideListLevel = new ListLevel(this.listStyleCollection_0.Document);
        format.OverrideListLevel.method_0(format);
        format.StartAt = num;
        format.OverrideStartAtValue = (num2 & 0x10) != 0;
        format.OverrideFormatting = (num2 & 0x20) != 0;
        format.int_7 = this.binaryReader_0.ReadInt16();
        format.int_8 = this.binaryReader_0.ReadByte();
        if (format.OverrideFormatting)
        {
            this.method_11(format.OverrideListLevel);
        }
    }

    private void method_23(OverrideLevelFormat A_0)
    {
        this.binaryWriter_0.Write(A_0.StartAt);
        int num = 0;
        num = 0 | A_0.OverrideListLevel.LevelNumber;
        num |= A_0.OverrideStartAtValue ? 0x10 : 0;
        num |= A_0.OverrideFormatting ? 0x20 : 0;
        this.binaryWriter_0.Write((byte) num);
        this.binaryWriter_0.Write((short) A_0.int_7);
        this.binaryWriter_0.Write((byte) A_0.int_8);
        if (A_0.OverrideFormatting)
        {
            this.method_13(A_0.OverrideListLevel, A_0.OverrideListLevel.LevelNumber);
        }
    }

    private void method_24()
    {
        StringCollection strings = new StringCollection();
        Class343.smethod_1(this.binaryReader_0, this.class703_0.class597_0.class1111_90, strings);
        Math.Min(strings.Count, this.listStyleCollection_0.Count);
    }

    private int method_25()
    {
        StringCollection strings = new StringCollection();
        for (int i = 0; i < this.listStyleCollection_0.Count; i++)
        {
            strings.Add(this.listStyleCollection_0[i].Name);
        }
        return Class343.smethod_4(this.binaryWriter_0, strings);
    }

    private void method_26(string A_0, params object[] A_1)
    {
    }

    private void method_3()
    {
        if (this.class703_0.class597_0.class1111_73.int_1 != 0)
        {
            this.binaryReader_0.BaseStream.Position = this.class703_0.class597_0.class1111_73.int_0;
            int num2 = this.binaryReader_0.ReadInt16();
            for (int i = 0; i < num2; i++)
            {
                this.listStyleCollection_0.Add(this.method_5());
            }
            if (this.dictionary_1 == null)
            {
                this.dictionary_1 = new Dictionary<string, int>();
            }
            for (int j = 0; j < num2; j++)
            {
                ListStyle style = this.listStyleCollection_0[this.int_0 + j];
                if (!this.method_9(style))
                {
                    return;
                }
                this.method_6(style);
                this.dictionary_1.Add(style.ListDefId.ToString(), j + 1);
            }
        }
    }

    private int method_4()
    {
        if (((this.listStyleCollection_0.Count == 0) || (this.listStyleCollection_0.ilist_0 == null)) || (this.listStyleCollection_0.ilist_0.Count == 0))
        {
            return 0;
        }
        int position = (int) this.binaryWriter_0.BaseStream.Position;
        this.binaryWriter_0.Write((short) this.listStyleCollection_0.ilist_0.Count);
        for (int i = 0; i < this.listStyleCollection_0.ilist_0.Count; i++)
        {
            this.binaryWriter_0.Write((int) (i + 1));
            this.method_8(this.listStyleCollection_0.ilist_0[i]);
        }
        int num4 = ((int) this.binaryWriter_0.BaseStream.Position) - position;
        for (int j = 0; j < this.listStyleCollection_0.ilist_0.Count; j++)
        {
            this.method_10(this.listStyleCollection_0.ilist_0[j]);
        }
        return num4;
    }

    private ListStyle method_5()
    {
        ListLevelsType singleLevel;
        int num = this.binaryReader_0.ReadInt32();
        int num2 = this.binaryReader_0.ReadInt32();
        int[] numArray = new int[9];
        bool flag = true;
        for (int i = 0; i < 9; i++)
        {
            numArray[i] = this.binaryReader_0.ReadInt16();
            if (numArray[i] != 0)
            {
                flag = false;
            }
        }
        if (flag)
        {
            for (int m = 0; m < 9; m++)
            {
                numArray[m] = 0xfff;
            }
        }
        int num8 = this.binaryReader_0.ReadByte();
        this.binaryReader_0.ReadByte();
        if ((num8 & 1) != 0)
        {
            singleLevel = ListLevelsType.SingleLevel;
        }
        else if ((num8 & 0x10) != 0)
        {
            singleLevel = ListLevelsType.HybridMultiLevel;
        }
        else
        {
            singleLevel = ListLevelsType.MultiLevel;
        }
        ListStyle style = new ListStyle(this.listStyleCollection_0.Document, num, singleLevel, num2);
        int num5 = this.method_7(singleLevel);
        for (int j = 0; j < num5; j++)
        {
            style.Levels.method_5(new ListLevel(this.listStyleCollection_0.Document));
        }
        for (int k = 0; k < style.Levels.Count; k++)
        {
            using (Dictionary<string, int>.Enumerator enumerator = this.dictionary_2.GetEnumerator())
            {
                KeyValuePair<string, int> current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.Value == numArray[k])
                    {
                        goto Label_0120;
                    }
                }
                continue;
            Label_0120:
                style.Levels[k].ParaStyleName = current.Key;
            }
        }
        return style;
    }

    private void method_6(ListStyle A_0)
    {
        int num = 12;
        if (A_0.Levels != null)
        {
            A_0.ListType = ListType.Bulleted;
            using (IEnumerator enumerator = A_0.Levels.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ListLevel current = (ListLevel) enumerator.Current;
                    if (current.PatternType != ListPatternType.Bullet)
                    {
                        goto Label_0046;
                    }
                }
                goto Label_0060;
            Label_0046:
                A_0.ListType = ListType.Numbered;
            }
        }
    Label_0060:
        if (A_0.ListType == ListType.Numbered)
        {
            A_0.Name = BookmarkStart.b("簱䄳嬵娷弹主嬽␿ᵁ", num) + Guid.NewGuid().ToString();
        }
        else
        {
            A_0.Name = BookmarkStart.b("瀱䄳娵吷弹䠻嬽␿ᵁ", num) + Guid.NewGuid().ToString();
        }
        A_0.IsSimple = (A_0.Levels != null) && (A_0.Levels.Count == 1);
    }

    private int method_7(ListLevelsType A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case ListLevelsType.SingleLevel:
                return 1;

            case ListLevelsType.MultiLevel:
            case ListLevelsType.HybridMultiLevel:
                return 9;
        }
        throw new InvalidOperationException(BookmarkStart.b("爦䜨䀪䌬䀮䘰崲ᔴ嬶倸䠺䤼Ἶ㕀㩂㕄≆杈", num));
    }

    private void method_8(ListStyle A_0)
    {
        int num = 0x11;
        this.binaryWriter_0.Write(A_0.TemplateCode);
        for (int i = 0; i < 9; i++)
        {
            int num4 = 0xfff;
            string str = (i < A_0.Levels.Count) ? A_0.Levels[i].ParaStyleName : string.Empty;
            if (!string.IsNullOrEmpty(str))
            {
                num4 = A_0.Document.Styles.method_16(str);
            }
            this.binaryWriter_0.Write((short) num4);
        }
        int num3 = 0;
        switch (A_0.ListLevelsType)
        {
            case ListLevelsType.SingleLevel:
                num3 |= 1;
                break;

            case ListLevelsType.MultiLevel:
                if (!A_0.IsSimple)
                {
                    if (A_0.IsHybrid)
                    {
                        num3 |= 0x10;
                    }
                    else if (A_0.Levels.Count == 1)
                    {
                        num3 |= 1;
                    }
                    break;
                }
                num3 |= 1;
                break;

            case ListLevelsType.HybridMultiLevel:
                num3 |= 0x10;
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("戶圸债匼倾㙀ⵂ敄⭆⁈㡊㥌潎═⩒╔㉖睘", num));
        }
        this.binaryWriter_0.Write((ushort) num3);
    }

    private bool method_9(ListStyle A_0)
    {
        for (int i = 0; i < A_0.Levels.Count; i++)
        {
            if (!this.method_11(A_0.Levels[i]))
            {
                return false;
            }
        }
        return true;
    }

    private static void smethod_0(ListLevel A_0)
    {
        object obj2 = A_0.CharacterFormat.method_31(490);
        object obj3 = A_0.CharacterFormat.method_31(480);
        if ((obj2 != null) && (obj3 != null))
        {
            PictureBulletFlags flags = (PictureBulletFlags) obj2;
            if ((flags & PictureBulletFlags.Active) != PictureBulletFlags.None)
            {
                A_0.PicBulletId = (short) ((int) obj3);
            }
        }
        A_0.CharacterFormat.Remove(490);
        A_0.CharacterFormat.Remove(480);
    }

    private static void smethod_1(ListLevel A_0)
    {
        CharacterFormat characterFormat = A_0.CharacterFormat;
        if (A_0.HasPictureBullet)
        {
            characterFormat.SetAttr(480, A_0.CharacterFormat.ListPictureIndex);
            characterFormat.SetAttr(490, PictureBulletFlags.Active);
        }
        else
        {
            characterFormat.SetAttr(480, 0);
            characterFormat.SetAttr(490, PictureBulletFlags.None);
        }
    }

    private static byte[] smethod_2(string A_0)
    {
        byte[] buffer = new byte[9];
        int index = 0;
        if (A_0 != null)
        {
            for (int i = 0; i < A_0.Length; i++)
            {
                if (ListLevel.smethod_0(A_0[i]))
                {
                    buffer[index] = (byte) (i + 1);
                    index++;
                    if (index >= buffer.Length)
                    {
                        return buffer;
                    }
                }
            }
        }
        return buffer;
    }
}

