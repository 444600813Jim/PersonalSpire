using Spire.Doc;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Fields.Caculation;
using System;
using System.IO;

internal class Class659
{
    private const int int_0 = 500;
    private const int int_1 = 0x220;
    private const int int_2 = 0x252;
    private const int int_3 = 0x268;
    private const int int_4 = 0x2a2;
    private const int int_5 = 0x65;
    private const int int_6 = 0x33;

    private Class659()
    {
    }

    internal static void smethod_0(BinaryReader A_0, Class1111 A_1, Document A_2)
    {
        Class907 settings = A_2.Settings;
        int num = A_1.int_0;
        int num2 = A_1.int_1;
        A_0.BaseStream.Seek((long) num, SeekOrigin.Begin);
        int num3 = A_0.ReadUInt16();
        settings.bool_37 = (num3 & 1) != 0;
        settings.bool_67 = (num3 & 2) != 0;
        A_2.FootnoteOptions.method_54((FootnotePosition) ((num3 & 0x60) >> 5));
        num3 = A_0.ReadUInt16();
        A_2.FootnoteOptions.method_55(((FootnoteRestartRule) num3) & (FootnoteRestartRule.RestartPage | FootnoteRestartRule.RestartSection));
        A_2.FootnoteOptions.method_56((num3 & 0xfffc) >> 2);
        num3 = A_0.ReadUInt16();
        settings.bool_28 = (num3 & 0x800) == 0;
        settings.bool_27 = (num3 & 0x1000) != 0;
        settings.bool_16 = (num3 & 0x4000) != 0;
        settings.bool_21 = (num3 & 0x8000) != 0;
        num3 = A_0.ReadUInt16();
        settings.bool_63 = (num3 & 4) != 0;
        settings.bool_64 = (num3 & 8) != 0;
        settings.bool_34 = (num3 & 0x10) != 0;
        settings.bool_11 = (num3 & 0x20) != 0;
        settings.bool_35 = (num3 & 0x200) != 0;
        settings.bool_0 = (num3 & 0x400) != 0;
        settings.method_2((num3 & 0x800) != 0);
        settings.bool_65 = (num3 & 0x1000) != 0;
        settings.bool_36 = (num3 & 0x4000) != 0;
        settings.bool_7 = (num3 & 0x8000) != 0;
        num3 = A_0.ReadUInt16();
        settings.float_0 = A_0.ReadUInt16();
        A_0.ReadUInt16();
        settings.int_16 = A_0.ReadUInt16();
        settings.int_15 = A_0.ReadUInt16();
        A_0.ReadUInt16();
        A_0.ReadUInt32();
        A_0.ReadUInt32();
        A_0.ReadUInt32();
        A_0.ReadInt16();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt16();
        A_0.ReadInt32();
        num3 = A_0.ReadUInt16();
        A_2.EndnoteOptions.RestartRule = ((FootnoteRestartRule) num3) & (FootnoteRestartRule.RestartPage | FootnoteRestartRule.RestartSection);
        A_2.EndnoteOptions.StartNumber = (num3 & 0xfffc) >> 2;
        num3 = A_0.ReadUInt16();
        A_2.EndnoteOptions.method_54(((FootnotePosition) num3) & FootnotePosition.PrintAsEndOfDocument);
        settings.bool_6 = (num3 & 0x400) != 0;
        settings.bool_10 = (num3 & 0x800) != 0;
        settings.bool_41 = (num3 & 0x1000) == 0;
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt16();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_2.LegacyHash = (uint) A_0.ReadInt32();
        num3 = A_0.ReadUInt16();
        A_2.ViewSetup.DocumentViewType = ((DocumentViewType) num3) & ((DocumentViewType) 7);
        int num4 = (num3 & 0xff8) >> 3;
        if (num4 > 0)
        {
            A_2.ViewSetup.ZoomPercent = num4;
        }
        A_2.ViewSetup.ZoomType = (ZoomType) ((num3 & 0x3000) >> 12);
        settings.bool_15 = (num3 & 0x8000) != 0;
        smethod_6(settings, num2);
        Class908 class3 = settings.method_5();
        if (num2 >= 500)
        {
            smethod_2(A_0.ReadInt32(), class3);
            settings.autoFormatDocumentType_0 = (AutoFormatDocumentType) A_0.ReadUInt16();
            num3 = A_0.ReadUInt16();
            settings.bool_42 = (num3 & 1) != 0;
            settings.characterSpacing_0 = (CharacterSpacing) ((num3 & 6) >> 1);
            settings.bool_44 = (num3 & 0x18) != 0;
            settings.bool_43 = (num3 & 0x20) != 0;
            int num5 = A_0.ReadInt16();
            int num6 = A_0.ReadInt16();
            int num7 = (num3 & 0x380) >> 7;
            settings.localeIDs_0 = Class813.smethod_23(num7);
            char[] chArray = Class813.smethod_15(A_0, true, 0x65);
            char[] chArray2 = Class813.smethod_15(A_0, true, 0x33);
            settings.string_2 = new string(chArray, 0, Math.Min(num5, 0x65));
            settings.string_1 = new string(chArray2, 0, Math.Min(num6, 0x33));
            settings.int_23 = A_0.ReadInt16();
            settings.int_24 = A_0.ReadInt16();
            settings.int_19 = A_0.ReadInt16();
            settings.int_20 = A_0.ReadInt16();
            num3 = A_0.ReadUInt16();
            settings.int_22 = num3 & 0x7f;
            settings.bool_68 = (num3 & 0x80) != 0;
            settings.int_21 = (num3 & 0x7f00) >> 8;
            settings.bool_40 = (num3 & 0x8000) != 0;
            num3 = A_0.ReadUInt16();
            settings.int_28 = (num3 & 30) >> 1;
            if ((num3 & 0x20) != 0)
            {
                settings.proofState_1 = ((num3 & 0x40) != 0) ? ProofState.Clean : ProofState.Dirty;
            }
            else
            {
                settings.proofState_1 = ProofState.None;
            }
            settings.bool_9 = (num3 & 0x80) != 0;
            settings.bool_69 = (num3 & 0x100) != 0;
            settings.bool_66 = (num3 & 0x200) != 0;
            settings.bool_12 = (num3 & 0x800) != 0;
            settings.bool_13 = (num3 & 0x1000) == 0;
            settings.bool_14 = (num3 & 0x2000) == 0;
            num3 = A_0.ReadUInt16();
            settings.bool_70 = (num3 & 1) != 0;
            settings.bool_71 = (num3 & 2) != 0;
            A_0.ReadBytes(12);
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_2.VbaDocumentEvents = (VbaDocumentEvents) A_0.ReadInt32();
            num3 = A_0.ReadInt32();
            A_0.ReadBytes(30);
            A_0.ReadUInt32();
            A_0.ReadUInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadUInt32();
            A_2.FootnoteOptions.method_53((FootnoteNumberFormat) A_0.ReadInt16());
            A_2.EndnoteOptions.method_53((FootnoteNumberFormat) A_0.ReadInt16());
            A_0.ReadUInt16();
            A_0.ReadUInt16();
        }
        if (num2 >= 0x220)
        {
            A_0.ReadUInt16();
            settings.int_30 = A_0.ReadUInt16();
            num3 = A_0.ReadInt32();
            settings.bool_29 = (num3 & 2) != 0;
            if ((num3 & 0x10000000) != 0)
            {
                settings.bool_48 = (num3 & 0x200) == 0;
                settings.bool_46 = (num3 & 0x400) != 0;
                settings.bool_47 = (num3 & 0x800) != 0;
                settings.screenSize_1 = (ScreenSize) ((num3 & 0xf000) >> 12);
                settings.bool_50 = (num3 & 0x10000) == 0;
                settings.bool_51 = (num3 & 0x20000) == 0;
                settings.int_25 = (num3 & 0xffc0000) >> 0x12;
            }
            smethod_2(A_0.ReadInt32(), class3);
            num3 = A_0.ReadInt32();
            class3.method_68((num3 & 1) != 0);
            class3.method_70((num3 & 2) != 0);
            class3.method_72((num3 & 4) != 0);
            class3.method_74((num3 & 8) != 0);
            class3.method_76((num3 & 0x10) != 0);
            class3.method_78((num3 & 0x20) != 0);
            class3.method_80((num3 & 0x40) != 0);
            class3.method_82((num3 & 0x80) != 0);
            class3.method_84((num3 & 0x100) != 0);
            class3.method_86((num3 & 0x200) != 0);
            if (num2 >= 0x252)
            {
                class3.method_88((num3 & 0x400) != 0);
                class3.method_90((num3 & 0x800) != 0);
                class3.method_92((num3 & 0x1000) != 0);
                class3.method_94((num3 & 0x2000) != 0);
                class3.method_96((num3 & 0x4000) != 0);
                class3.method_98((num3 & 0x8000) != 0);
            }
            if (num2 >= 0x268)
            {
                class3.method_100((num3 & 0x10000) != 0);
                class3.method_102((num3 & 0x20000) != 0);
            }
            if (num2 >= 0x2a2)
            {
                class3.method_104((num3 & 0x40000) != 0);
                class3.method_106((num3 & 0x80000) != 0);
                class3.method_108((num3 & 0x100000) != 0);
                class3.method_110((num3 & 0x200000) != 0);
                class3.method_112((num3 & 0x400000) != 0);
                class3.method_114((num3 & 0x800000) != 0);
                class3.method_116((num3 & 0x1000000) != 0);
                class3.method_118((num3 & 0x2000000) != 0);
                class3.method_120((num3 & 0x4000000) != 0);
                class3.method_122((num3 & 0x8000000) != 0);
                class3.method_124((num3 & 0x10000000) != 0);
                class3.method_126((num3 & 0x20000000) != 0);
                class3.method_128((num3 & 0x40000000) != 0);
                class3.method_130((num3 & 0x80000000L) != 0L);
            }
            num3 = A_0.ReadInt32();
            if (num2 >= 0x2a2)
            {
                class3.method_132((num3 & 1) != 0);
            }
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            num3 = A_0.ReadInt32();
            A_2.ViewSetup.DoNotDisplayPageBoundaries = (num3 & 0x20000) != 0;
            settings.bool_3 = (num3 & 0x800000) != 0;
            if ((num3 & 0x8000000) != 0)
            {
                settings.bool_52 = (num3 & 0x10000000) != 0;
                settings.bool_53 = (num3 & 0x20000000) != 0;
                settings.bool_58 = (num3 & 0x40000000) == 0;
                settings.bool_60 = (num3 & 0x80000000L) != 0L;
            }
        }
        if (num2 >= 0x252)
        {
            A_0.ReadInt32();
            num3 = A_0.ReadUInt16();
            settings.bool_8 = (num3 & 1) != 0;
            settings.bool_61 = (num3 & 8) == 0;
            settings.bool_62 = (num3 & 0x10) != 0;
            settings.bool_39 = (num3 & 0x40) != 0;
            settings.bool_38 = (num3 & 0x80) != 0;
            settings.bool_19 = (num3 & 0x800) != 0;
            settings.bool_22 = (num3 & 0x1000) != 0;
            settings.bool_23 = (num3 & 0x2000) != 0;
            settings.bool_24 = (num3 & 0x4000) != 0;
            settings.bool_25 = (num3 & 0x8000) != 0;
            settings.int_31 = A_0.ReadUInt16();
            A_0.ReadUInt16();
            settings.int_32 = A_0.ReadUInt16();
            settings.int_18 = A_0.ReadUInt16();
            settings.int_27 = A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            settings.int_26 = A_0.ReadInt32();
        }
        if (num2 >= 0x268)
        {
            num3 = A_0.ReadInt32();
            settings.bool_33 = (num3 & 1) != 0;
            bool flag2 = (num3 & 2) != 0;
            settings.bool_2 = (num3 & 4) != 0;
            settings.bool_54 = (num3 & 8) != 0;
            settings.bool_59 = (num3 & 0x10) != 0;
            bool flag = (num3 & 0x20) != 0;
            settings.bool_1 = flag2 && flag;
            settings.bool_56 = (num3 & 0x80) != 0;
            settings.bool_57 = (num3 & 0x100) != 0;
            settings.bool_18 = (num3 & 0x800) != 0;
            settings.bool_17 = (num3 & 0x1000) != 0;
            num3 = A_0.ReadUInt16();
            settings.bool_30 = (num3 & 1) != 0;
            settings.bool_26 = (num3 & 2) != 0;
            settings.bool_31 = (num3 & 4) != 0;
            settings.bool_32 = (num3 & 8) != 0;
            settings.int_17 = (num3 & 0x70) >> 4;
            A_2.ViewSetup.DisplayBackgroundShape = (num3 & 0x80) != 0;
            A_0.ReadUInt16();
            A_0.ReadUInt16();
            A_0.ReadInt32();
            A_0.ReadUInt16();
            A_0.ReadUInt16();
            A_0.ReadInt32();
        }
        if (num2 >= 0x2a2)
        {
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            A_0.ReadInt32();
            smethod_1(A_0, A_2);
        }
        long position = A_0.BaseStream.Position;
    }

    private static void smethod_1(BinaryReader A_0, Document A_1)
    {
        Class907 settings = A_1.Settings;
        int num = A_0.ReadInt32();
        settings.class80_0.method_3(((MathBreakOnBinary) num) & (MathBreakOnBinary.Repeat | MathBreakOnBinary.After));
        settings.class80_0.method_5((MathBreakOnBinarySubtraction) ((num & 12) >> 2));
        settings.class80_0.method_7((MathJustification) ((num & 0x70) >> 4));
        settings.class80_0.method_29(((num & 0x100) >> 8) != 0);
        int num2 = (num & 0x200) >> 9;
        settings.class80_0.method_15((MathLimitLocation) num2);
        int num3 = (num & 0x400) >> 10;
        settings.class80_0.method_23((MathLimitLocation) num3);
        settings.class80_0.method_33(((num & 0x800) >> 11) != 0);
        settings.class80_0.method_9(((num & 0x1000) >> 12) != 0);
        int num4 = A_0.ReadInt16();
        if (num4 < A_1.FontInfoList.method_4())
        {
            settings.class80_0.method_21(A_1.FontInfoList.method_6(num4).method_31());
        }
        settings.class80_0.method_17(A_0.ReadInt32());
        settings.class80_0.method_19(A_0.ReadInt32());
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        A_0.ReadInt32();
        settings.class80_0.method_31(A_0.ReadInt32());
    }

    private static void smethod_2(int A_0, Class908 A_1)
    {
        A_1.method_4((A_0 & 1) != 0);
        A_1.method_6((A_0 & 2) != 0);
        A_1.method_8((A_0 & 4) != 0);
        A_1.method_10((A_0 & 8) != 0);
        A_1.method_12((A_0 & 0x10) != 0);
        A_1.method_14((A_0 & 0x20) != 0);
        A_1.method_16((A_0 & 0x40) != 0);
        A_1.method_18((A_0 & 0x80) != 0);
        A_1.method_20((A_0 & 0x100) != 0);
        A_1.method_22((A_0 & 0x200) != 0);
        A_1.method_24((A_0 & 0x400) != 0);
        A_1.method_26((A_0 & 0x800) != 0);
        A_1.method_28((A_0 & 0x1000) == 0);
        A_1.method_30((A_0 & 0x2000) == 0);
        A_1.method_32((A_0 & 0x4000) == 0);
        A_1.method_34((A_0 & 0x8000) == 0);
        A_1.method_36((A_0 & 0x10000) != 0);
        A_1.method_38((A_0 & 0x20000) != 0);
        A_1.method_40((A_0 & 0x40000) != 0);
        A_1.method_42((A_0 & 0x80000) != 0);
        A_1.method_44((A_0 & 0x100000) == 0);
        A_1.method_46((A_0 & 0x200000) != 0);
        A_1.method_48((A_0 & 0x400000) != 0);
        A_1.method_50((A_0 & 0x800000) != 0);
        A_1.method_52((A_0 & 0x1000000) != 0);
        A_1.method_54((A_0 & 0x2000000) != 0);
        A_1.method_56((A_0 & 0x4000000) != 0);
        A_1.method_58((A_0 & 0x8000000) != 0);
        A_1.method_60((A_0 & 0x10000000) != 0);
        A_1.method_62((A_0 & 0x20000000) != 0);
        A_1.method_64((A_0 & 0x40000000) != 0);
        A_1.method_66((A_0 & 0x80000000L) != 0L);
    }

    internal static int smethod_3(Document A_0, BinaryWriter A_1)
    {
        int num = 14;
        Class907 settings = A_0.Settings;
        int position = (int) A_1.BaseStream.Position;
        int num3 = 0;
        num3 = 0 | (settings.bool_37 ? 1 : 0);
        num3 |= settings.bool_67 ? 2 : 0;
        num3 |= (settings.class460_0.method_27() != MailMergeMainDocumentType.NotAMergeDocument) ? 4 : 0;
        num3 |= ((int) A_0.FootnoteOptions.Position) << 5;
        A_1.Write((ushort) num3);
        num3 = 0;
        num3 = (int) (FootnoteRestartRule.DoNotRestart | A_0.FootnoteOptions.RestartRule);
        num3 |= A_0.FootnoteOptions.StartNumber << 2;
        A_1.Write((ushort) num3);
        num3 = 0;
        num3 = 0xf1;
        num3 = 0xf1 | (!settings.bool_28 ? 0x800 : 0);
        num3 |= settings.bool_27 ? 0x1000 : 0;
        num3 |= settings.bool_16 ? 0x4000 : 0;
        num3 |= settings.bool_21 ? 0x8000 : 0;
        A_1.Write((ushort) num3);
        num3 = 0;
        num3 = 0x80;
        num3 = 0x80 | (settings.bool_63 ? 4 : 0);
        num3 |= settings.bool_64 ? 8 : 0;
        num3 |= settings.bool_34 ? 0x10 : 0;
        num3 |= settings.bool_11 ? 0x20 : 0;
        num3 |= settings.bool_36 ? 0x200 : 0;
        num3 |= settings.bool_0 ? 0x400 : 0;
        num3 |= settings.method_1() ? 0x800 : 0;
        num3 |= settings.bool_65 ? 0x1000 : 0;
        num3 |= settings.bool_35 ? 0x4000 : 0;
        num3 |= settings.bool_7 ? 0x8000 : 0;
        A_1.Write((ushort) num3);
        Class908 class3 = settings.method_5();
        num3 = smethod_5(class3);
        A_1.Write((ushort) num3);
        A_1.Write((ushort) settings.float_0);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) settings.int_16);
        A_1.Write((ushort) settings.int_15);
        A_1.Write((ushort) 0);
        Class353.smethod_4(A_0.BuiltinDocumentProperties.CreateDate, A_1);
        Class353.smethod_4(A_0.BuiltinDocumentProperties.LastSaveDate, A_1);
        Class353.smethod_4(A_0.BuiltinDocumentProperties.LastPrinted, A_1);
        if (!string.IsNullOrEmpty(A_0.BuiltinDocumentProperties.RevisionNumber))
        {
            A_1.Write(short.Parse(A_0.BuiltinDocumentProperties.RevisionNumber));
        }
        else
        {
            A_1.Write((short) 1);
        }
        A_1.Write(int.Parse(A_0.BuiltinDocumentProperties.TotalEditingTime.Minutes.ToString()));
        A_1.Write(A_0.BuiltinDocumentProperties.WordCount);
        A_1.Write(A_0.BuiltinDocumentProperties.CharCount);
        A_1.Write((short) 1);
        A_1.Write(A_0.BuiltinDocumentProperties.ParagraphCount);
        num3 = 0;
        num3 = (int) (FootnoteRestartRule.DoNotRestart | A_0.EndnoteOptions.RestartRule);
        num3 |= A_0.EndnoteOptions.StartNumber << 2;
        A_1.Write((ushort) num3);
        num3 = 0;
        num3 = (int) (FootnotePosition.PrintAsEndOfSection | A_0.EndnoteOptions.Position);
        num3 |= settings.bool_6 ? 0x400 : 0;
        num3 |= settings.bool_10 ? 0x800 : 0;
        num3 |= !settings.bool_41 ? 0x1000 : 0;
        A_1.Write((ushort) num3);
        A_1.Write(1);
        A_1.Write(0);
        A_1.Write(0);
        A_1.Write((short) 1);
        A_1.Write(1);
        A_1.Write(1);
        A_1.Write((int) A_0.LegacyHash);
        num3 = 0;
        num3 = (int) (DocumentViewType.None | A_0.ViewSetup.DocumentViewType);
        num3 |= A_0.ViewSetup.ZoomPercent << 3;
        num3 |= ((int) A_0.ViewSetup.ZoomType) << 12;
        num3 |= settings.bool_15 ? 0x8000 : 0;
        A_1.Write((ushort) num3);
        num3 = smethod_5(class3);
        A_1.Write((uint) num3);
        A_1.Write((ushort) settings.autoFormatDocumentType_0);
        num3 = 0;
        num3 = 0 | (settings.bool_42 ? 1 : 0);
        num3 |= ((int) settings.characterSpacing_0) << 1;
        num3 |= settings.bool_44 ? 8 : 0;
        num3 |= settings.bool_43 ? 0x20 : 0;
        int num5 = Class813.smethod_24(settings.localeIDs_0);
        num3 |= num5 << 7;
        A_1.Write((ushort) num3);
        char[] destination = new char[0x65];
        int count = 0;
        if (settings.string_2 != null)
        {
            count = Math.Min(0x65, settings.string_2.Length);
            settings.string_2.CopyTo(0, destination, 0, count);
        }
        char[] chArray2 = new char[0x33];
        int num7 = 0;
        if (settings.string_1 != null)
        {
            num7 = Math.Min(0x33, settings.string_1.Length);
            settings.string_1.CopyTo(0, chArray2, 0, num7);
        }
        A_1.Write((short) count);
        A_1.Write((short) num7);
        A_1.Write(destination);
        A_1.Write(chArray2);
        A_1.Write((short) settings.int_23);
        A_1.Write((short) settings.int_24);
        A_1.Write((short) settings.int_19);
        A_1.Write((short) settings.int_20);
        num3 = 0;
        num3 = 0 | settings.int_22;
        num3 |= settings.bool_68 ? 0x80 : 0;
        num3 |= settings.int_21 << 8;
        num3 |= settings.bool_40 ? 0x8000 : 0;
        A_1.Write((ushort) num3);
        num3 = 0;
        num3 = 0 | (settings.int_28 << 1);
        num3 |= (settings.proofState_1 != ProofState.None) ? 0x20 : 0;
        num3 |= (settings.proofState_1 == ProofState.Clean) ? 0x40 : 0;
        num3 |= settings.bool_9 ? 0x80 : 0;
        num3 |= settings.bool_69 ? 0x100 : 0;
        num3 |= settings.bool_66 ? 0x200 : 0;
        num3 |= 0x400;
        num3 |= settings.bool_12 ? 0x800 : 0;
        num3 |= !settings.bool_13 ? 0x1000 : 0;
        num3 |= !settings.bool_14 ? 0x2000 : 0;
        A_1.Write((ushort) num3);
        num3 = 0;
        A_1.Write((ushort) 0);
        A_1.Write((ushort) 0x10);
        A_1.Write((ushort) 0x19);
        A_1.Write(100);
        A_1.Write(0x19);
        A_1.Write(0);
        A_1.Write(0);
        A_1.Write((int) A_0.VbaDocumentEvents);
        A_1.Write(0);
        A_1.Write(new byte[30]);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write(0);
        A_1.Write(0);
        A_1.Write(0);
        A_1.Write((short) A_0.FootnoteOptions.NumberFormat);
        A_1.Write((short) A_0.EndnoteOptions.NumberFormat);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) settings.int_30);
        num3 = 0;
        num3 = 0 | (settings.bool_29 ? 2 : 0);
        num3 |= !settings.bool_48 ? 0x200 : 0;
        num3 |= settings.bool_46 ? 0x400 : 0;
        num3 |= settings.bool_47 ? 0x800 : 0;
        num3 |= ((int) settings.screenSize_1) << 12;
        num3 |= !settings.bool_50 ? 0x10000 : 0;
        num3 |= !settings.bool_51 ? 0x20000 : 0;
        num3 |= settings.int_25 << 0x12;
        num3 |= 0x10000000;
        A_1.Write(num3);
        num3 = smethod_5(class3);
        A_1.Write((uint) num3);
        num3 = 0;
        num3 = 0 | (class3.method_67() ? 1 : 0);
        num3 |= class3.method_69() ? 2 : 0;
        num3 |= class3.method_71() ? 4 : 0;
        num3 |= class3.method_73() ? 8 : 0;
        num3 |= class3.method_75() ? 0x10 : 0;
        num3 |= class3.method_77() ? 0x20 : 0;
        num3 |= class3.method_79() ? 0x40 : 0;
        num3 |= class3.method_81() ? 0x80 : 0;
        num3 |= class3.method_83() ? 0x100 : 0;
        num3 |= class3.method_85() ? 0x200 : 0;
        num3 |= class3.method_87() ? 0x400 : 0;
        num3 |= class3.method_89() ? 0x800 : 0;
        num3 |= class3.method_91() ? 0x1000 : 0;
        num3 |= class3.method_93() ? 0x2000 : 0;
        num3 |= class3.method_95() ? 0x4000 : 0;
        num3 |= class3.method_97() ? 0x8000 : 0;
        num3 |= class3.method_99() ? 0x10000 : 0;
        num3 |= class3.method_101() ? 0x20000 : 0;
        num3 |= class3.method_103() ? 0x40000 : 0;
        num3 |= class3.method_105() ? 0x80000 : 0;
        num3 |= class3.method_107() ? 0x100000 : 0;
        num3 |= class3.method_109() ? 0x200000 : 0;
        num3 |= class3.method_111() ? 0x400000 : 0;
        num3 |= class3.method_113() ? 0x800000 : 0;
        num3 |= class3.method_115() ? 0x1000000 : 0;
        num3 |= class3.method_117() ? 0x2000000 : 0;
        num3 |= class3.method_119() ? 0x4000000 : 0;
        num3 |= class3.method_121() ? 0x8000000 : 0;
        num3 |= class3.method_123() ? 0x10000000 : 0;
        num3 |= class3.method_125() ? 0x20000000 : 0;
        num3 |= class3.method_127() ? 0x40000000 : 0;
        num3 |= class3.method_129() ? -2147483648 : 0;
        A_1.Write((uint) num3);
        num3 = 0;
        num3 = 0 | (class3.method_131() ? 1 : 0);
        A_1.Write((uint) num3);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        num3 = 0;
        num3 = 0 | (A_0.ViewSetup.DoNotDisplayPageBoundaries ? 0x20000 : 0);
        num3 |= settings.bool_3 ? 0x800000 : 0;
        num3 |= 0x8000000;
        num3 |= settings.bool_52 ? 0x10000000 : 0;
        num3 |= settings.bool_53 ? 0x20000000 : 0;
        num3 |= !settings.bool_58 ? 0x40000000 : 0;
        num3 |= settings.bool_60 ? -2147483648 : 0;
        A_1.Write((uint) num3);
        A_1.Write((uint) 0);
        num3 = 0;
        num3 = 0 | (settings.bool_8 ? 1 : 0);
        num3 |= !settings.bool_61 ? 8 : 0;
        num3 |= settings.bool_62 ? 0x10 : 0;
        num3 |= settings.bool_39 ? 0x40 : 0;
        num3 |= settings.bool_38 ? 0x80 : 0;
        num3 |= settings.bool_19 ? 0x800 : 0;
        num3 |= settings.bool_22 ? 0x1000 : 0;
        num3 |= settings.bool_23 ? 0x2000 : 0;
        num3 |= settings.bool_24 ? 0x4000 : 0;
        num3 |= settings.bool_25 ? 0x8000 : 0;
        A_1.Write((ushort) num3);
        A_1.Write((ushort) settings.int_31);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) settings.int_32);
        A_1.Write((ushort) settings.int_18);
        A_1.Write((uint) settings.int_27);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) settings.int_26);
        num3 = 0;
        num3 = 0 | ((A_0.ProtectionType == ProtectionType.AllowOnlyReading) ? 1 : 0);
        num3 |= settings.bool_1 ? 2 : 0;
        num3 |= settings.bool_2 ? 4 : 0;
        num3 |= settings.bool_54 ? 8 : 0;
        num3 |= settings.bool_59 ? 0x10 : 0;
        num3 |= settings.bool_56 ? 0x80 : 0;
        num3 |= settings.bool_57 ? 0x100 : 0;
        num3 |= settings.bool_18 ? 0x800 : 0;
        num3 |= settings.bool_17 ? 0x1000 : 0;
        A_1.Write((uint) num3);
        num3 = 0;
        num3 = 0 | (settings.bool_30 ? 1 : 0);
        num3 |= settings.bool_26 ? 2 : 0;
        num3 |= settings.bool_31 ? 4 : 0;
        num3 |= settings.bool_32 ? 8 : 0;
        switch (A_0.ProtectionType)
        {
            case ProtectionType.NoProtection:
                num3 |= settings.bool_32 ? 0x70 : 0x30;
                break;

            case ProtectionType.AllowOnlyRevisions:
                break;

            case ProtectionType.AllowOnlyComments:
                num3 |= 0x10;
                break;

            case ProtectionType.AllowOnlyFormFields:
                num3 |= 0x20;
                break;

            case ProtectionType.AllowOnlyReading:
                num3 |= 0x30;
                break;

            default:
                throw new InvalidOperationException(BookmarkStart.b("愳堵匷吹医䤽⸿扁⁃⥅⭇㽉⅋⭍㹏♑瑓♕⩗㕙⡛㭝͟ᙡൣ॥٧䩩ᡫ᝭o᝱婳", num));
        }
        num3 |= A_0.ViewSetup.DisplayBackgroundShape ? 0x80 : 0;
        A_1.Write((ushort) num3);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) 0);
        A_1.Write((uint) 0);
        A_1.Write((ushort) 0);
        A_1.Write((ushort) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        A_1.Write((uint) 0);
        smethod_4(A_1, A_0);
        return (((int) A_1.BaseStream.Position) - position);
    }

    private static void smethod_4(BinaryWriter A_0, Document A_1)
    {
        Class907 settings = A_1.Settings;
        int num = 0;
        num = (int) (MathBreakOnBinary.Before | settings.class80_0.method_2());
        int num2 = (int) settings.class80_0.method_4();
        num |= num2 << 2;
        int num3 = (int) settings.class80_0.method_6();
        num |= num3 << 4;
        num |= settings.class80_0.method_28() ? 0x100 : 0;
        int num4 = (int) settings.class80_0.method_14();
        num |= num4 << 9;
        int num5 = (int) settings.class80_0.method_22();
        num |= num5 << 10;
        num |= settings.class80_0.method_32() ? 0x800 : 0;
        num |= settings.class80_0.method_8() ? 0x1000 : 0;
        A_0.Write((uint) num);
        A_0.Write((ushort) A_1.FontInfoList.method_8(settings.class80_0.method_20()));
        A_0.Write((uint) settings.class80_0.method_16());
        A_0.Write((uint) settings.class80_0.method_18());
        A_0.Write((uint) 0);
        A_0.Write((uint) 0);
        A_0.Write((uint) 0);
        A_0.Write((uint) 0);
        A_0.Write((uint) settings.class80_0.method_30());
    }

    private static int smethod_5(Class908 A_0)
    {
        int num = 0;
        num = 0 | (A_0.method_3() ? 1 : 0);
        num |= A_0.method_5() ? 2 : 0;
        num |= A_0.method_7() ? 4 : 0;
        num |= A_0.method_9() ? 8 : 0;
        num |= A_0.method_11() ? 0x10 : 0;
        num |= A_0.method_13() ? 0x20 : 0;
        num |= A_0.method_15() ? 0x40 : 0;
        num |= A_0.method_17() ? 0x80 : 0;
        num |= A_0.method_19() ? 0x100 : 0;
        num |= A_0.method_21() ? 0x200 : 0;
        num |= A_0.method_23() ? 0x400 : 0;
        num |= A_0.method_25() ? 0x800 : 0;
        num |= !A_0.method_27() ? 0x1000 : 0;
        num |= !A_0.method_29() ? 0x2000 : 0;
        num |= !A_0.method_31() ? 0x4000 : 0;
        num |= !A_0.method_33() ? 0x8000 : 0;
        num |= A_0.method_35() ? 0x10000 : 0;
        num |= A_0.method_37() ? 0x20000 : 0;
        num |= A_0.method_39() ? 0x40000 : 0;
        num |= A_0.method_41() ? 0x80000 : 0;
        num |= !A_0.method_43() ? 0x100000 : 0;
        num |= A_0.method_45() ? 0x200000 : 0;
        num |= A_0.method_47() ? 0x400000 : 0;
        num |= A_0.method_49() ? 0x800000 : 0;
        num |= A_0.method_51() ? 0x1000000 : 0;
        num |= A_0.method_53() ? 0x2000000 : 0;
        num |= A_0.method_55() ? 0x4000000 : 0;
        num |= A_0.method_57() ? 0x8000000 : 0;
        num |= A_0.method_59() ? 0x10000000 : 0;
        num |= A_0.method_61() ? 0x20000000 : 0;
        num |= A_0.method_63() ? 0x40000000 : 0;
        return (num | (A_0.method_65() ? -2147483648 : 0));
    }

    private static void smethod_6(Class907 A_0, int A_1)
    {
        if (A_1 >= 0x2a2)
        {
            A_0.method_6(A_0.method_5().method_145());
        }
        else if (A_1 >= 0x268)
        {
            A_0.method_6(A_0.method_5().method_144());
        }
        else if (A_1 >= 0x252)
        {
            A_0.method_6(A_0.method_5().method_143());
        }
        else if (A_1 >= 0x220)
        {
            A_0.method_6(A_0.method_5().method_142());
        }
        else
        {
            A_0.method_6(A_0.method_5().method_141());
        }
        A_0.method_5().method_138(true);
    }
}

