using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Reflection;

internal class Class17 : WordAttrCollection
{
    private Borders borders_0;
    private Section section_0;

    internal Class17(Document A_0) : base(A_0)
    {
    }

    internal Class17(Section A_0) : this(A_0.Document)
    {
        this.method_158(A_0);
    }

    internal float method_100()
    {
        return (float) base.method_32(0x8e8);
    }

    internal void method_101(float A_0)
    {
        this.SetAttr(0x8e8, A_0);
    }

    internal float method_102()
    {
        return (float) base.method_32(0x8f2);
    }

    internal void method_103(float A_0)
    {
        this.SetAttr(0x8f2, A_0);
    }

    internal float method_104()
    {
        return (float) base.method_32(0x8fc);
    }

    internal void method_105(float A_0)
    {
        this.SetAttr(0x8fc, A_0);
    }

    internal float method_106()
    {
        return (float) base.method_32(0x906);
    }

    internal void method_107(float A_0)
    {
        this.SetAttr(0x906, A_0);
    }

    internal float method_108()
    {
        return (float) base.method_32(0x908);
    }

    internal void method_109(float A_0)
    {
        this.SetAttr(0x908, A_0);
    }

    internal float method_110()
    {
        return (float) base.method_32(0x910);
    }

    internal void method_111(float A_0)
    {
        this.SetAttr(0x910, A_0);
    }

    internal float method_112()
    {
        return (float) base.method_32(0x91a);
    }

    internal void method_113(float A_0)
    {
        this.SetAttr(0x91a, A_0);
    }

    internal PageAlignment method_114()
    {
        return (PageAlignment) base.method_32(0x924);
    }

    internal void method_115(PageAlignment A_0)
    {
        this.SetAttr(0x924, A_0);
    }

    internal int method_116()
    {
        return (int) base.method_32(0x92e);
    }

    internal void method_117(int A_0)
    {
        this.SetAttr(0x92e, A_0);
    }

    internal bool method_118()
    {
        return (bool) base.method_32(0x938);
    }

    internal void method_119(bool A_0)
    {
        this.SetAttr(0x938, A_0);
    }

    internal int method_120()
    {
        return (int) base.method_32(0x942);
    }

    internal void method_121(int A_0)
    {
        this.SetAttr(0x942, A_0);
    }

    internal ColumnCollection method_122()
    {
        return (ColumnCollection) base.method_32(0x94c);
    }

    internal void method_123(ColumnCollection A_0)
    {
        this.SetAttr(0x94c, A_0);
    }

    internal bool method_124()
    {
        return (bool) base.method_32(0x956);
    }

    internal void method_125(bool A_0)
    {
        this.SetAttr(0x956, A_0);
    }

    internal float method_126()
    {
        return (float) base.method_32(0x960);
    }

    internal void method_127(float A_0)
    {
        this.SetAttr(0x960, A_0);
    }

    internal bool method_128()
    {
        return (bool) base.method_32(0x96a);
    }

    internal void method_129(bool A_0)
    {
        this.SetAttr(0x96a, A_0);
    }

    internal int method_130()
    {
        return (int) base.method_32(0x974);
    }

    internal void method_131(int A_0)
    {
        this.SetAttr(0x974, A_0);
    }

    internal GridPitchType method_132()
    {
        return (GridPitchType) base.method_32(0x97e);
    }

    internal void method_133(GridPitchType A_0)
    {
        this.SetAttr(0x97e, A_0);
    }

    internal TextDirection method_134()
    {
        return (TextDirection) base.method_32(0x988);
    }

    internal void method_135(TextDirection A_0)
    {
        this.SetAttr(0x988, A_0);
    }

    internal bool method_136()
    {
        return (bool) base.method_32(0x992);
    }

    internal void method_137(bool A_0)
    {
        this.SetAttr(0x992, A_0);
    }

    internal FootEndnoteOptions method_138()
    {
        return (FootEndnoteOptions) base.method_32(0x7b2);
    }

    internal FootEndnoteOptions method_139()
    {
        return (FootEndnoteOptions) base.method_32(0x7bc);
    }

    internal FootnotePosition method_140()
    {
        return this.method_139().Position;
    }

    internal void method_141(FootnotePosition A_0)
    {
        this.method_139().Position = A_0;
    }

    internal FootnoteRestartRule method_142()
    {
        return this.method_139().RestartRule;
    }

    internal void method_143(FootnoteRestartRule A_0)
    {
        this.method_139().RestartRule = A_0;
    }

    internal FootnoteNumberFormat method_144()
    {
        return this.method_139().NumberFormat;
    }

    internal void method_145(FootnoteNumberFormat A_0)
    {
        this.method_139().NumberFormat = A_0;
    }

    internal int method_146()
    {
        return this.method_139().StartNumber;
    }

    internal void method_147(int A_0)
    {
        this.method_139().StartNumber = A_0;
    }

    internal FootnotePosition method_148()
    {
        return this.method_138().Position;
    }

    internal void method_149(FootnotePosition A_0)
    {
        this.method_138().Position = A_0;
    }

    internal FootnoteRestartRule method_150()
    {
        return this.method_138().RestartRule;
    }

    internal void method_151(FootnoteRestartRule A_0)
    {
        this.method_138().RestartRule = A_0;
    }

    internal FootnoteNumberFormat method_152()
    {
        return this.method_138().NumberFormat;
    }

    internal void method_153(FootnoteNumberFormat A_0)
    {
        this.method_138().NumberFormat = A_0;
    }

    internal int method_154()
    {
        return this.method_138().StartNumber;
    }

    internal void method_155(int A_0)
    {
        this.method_138().StartNumber = A_0;
    }

    public void method_156(int A_0, object A_1)
    {
        this.SetAttr(A_0, A_1);
    }

    internal object method_157(int A_0)
    {
        return this.GetDefValue(A_0);
    }

    internal void method_158(Section A_0)
    {
        this.section_0 = A_0;
    }

    internal Borders method_49()
    {
        return (Borders) base.method_32(0x7c6);
    }

    internal MarginsF method_50()
    {
        return (MarginsF) base.method_32(0x7d0);
    }

    internal void method_51(MarginsF A_0)
    {
        this.method_50().method_49(A_0);
    }

    internal PageNumberStyle method_52()
    {
        return (PageNumberStyle) base.method_32(0x7da);
    }

    internal void method_53(PageNumberStyle A_0)
    {
        this.SetAttr(0x7da, A_0);
    }

    internal PageSeparator method_54()
    {
        return (PageSeparator) base.method_32(0x7e4);
    }

    internal void method_55(PageSeparator A_0)
    {
        this.SetAttr(0x7e4, A_0);
    }

    internal SectionBreakType method_56()
    {
        return (SectionBreakType) base.method_32(0x7ee);
    }

    internal void method_57(SectionBreakType A_0)
    {
        this.SetAttr(0x7ee, A_0);
    }

    internal bool method_58()
    {
        return (bool) base.method_32(0x7f8);
    }

    internal void method_59(bool A_0)
    {
        this.SetAttr(0x7f8, A_0);
    }

    internal bool method_60()
    {
        return (bool) base.method_32(0x802);
    }

    internal void method_61(bool A_0)
    {
        this.SetAttr(0x802, A_0);
    }

    internal bool method_62()
    {
        return (bool) base.method_32(0x80c);
    }

    internal void method_63(bool A_0)
    {
        this.SetAttr(0x80c, A_0);
    }

    internal int method_64()
    {
        return (int) base.method_32(0x816);
    }

    internal void method_65(int A_0)
    {
        this.SetAttr(0x816, A_0);
    }

    internal int method_66()
    {
        return (int) base.method_32(0x820);
    }

    internal void method_67(int A_0)
    {
        this.SetAttr(0x820, A_0);
    }

    internal bool method_68()
    {
        return (bool) base.method_32(0x834);
    }

    internal void method_69(bool A_0)
    {
        this.SetAttr(0x834, A_0);
    }

    internal LineNumberingRestartMode method_70()
    {
        return (LineNumberingRestartMode) base.method_32(0x83e);
    }

    internal void method_71(LineNumberingRestartMode A_0)
    {
        this.SetAttr(0x83e, A_0);
    }

    internal int method_72()
    {
        return (int) base.method_32(0x848);
    }

    internal void method_73(int A_0)
    {
        this.SetAttr(0x848, A_0);
    }

    internal Border method_74()
    {
        return (Border) base.method_32(0x852);
    }

    internal Border method_75()
    {
        return (Border) base.method_32(0x85c);
    }

    internal Border method_76()
    {
        return (Border) base.method_32(0x866);
    }

    internal Border method_77()
    {
        return (Border) base.method_32(0x870);
    }

    internal float method_78()
    {
        return (float) base.method_32(0x87a);
    }

    internal void method_79(float A_0)
    {
        this.SetAttr(0x87a, A_0);
    }

    internal int method_80()
    {
        return (int) base.method_32(0xa50);
    }

    internal void method_81(int A_0)
    {
        this.SetAttr(0xa50, A_0);
    }

    internal int method_82()
    {
        return (int) base.method_32(0x884);
    }

    internal void method_83(int A_0)
    {
        this.SetAttr(0x884, A_0);
    }

    internal int method_84()
    {
        return (int) base.method_32(0x88e);
    }

    internal void method_85(int A_0)
    {
        this.SetAttr(0x88e, A_0);
    }

    internal int method_86()
    {
        if (this.method_60())
        {
            return (int) base.method_32(0x898);
        }
        return 0;
    }

    internal void method_87(int A_0)
    {
        this.SetAttr(0x898, A_0);
    }

    internal PageOrientation method_88()
    {
        return (PageOrientation) base.method_32(0x8a2);
    }

    internal void method_89(PageOrientation A_0)
    {
        this.SetAttr(0x8a2, A_0);
    }

    internal PageBordersApplyType method_90()
    {
        return (PageBordersApplyType) base.method_32(0x8ac);
    }

    internal void method_91(PageBordersApplyType A_0)
    {
        this.SetAttr(0x8ac, A_0);
    }

    internal bool method_92()
    {
        return (bool) base.method_32(0x8b6);
    }

    internal void method_93(bool A_0)
    {
        this.SetAttr(0x8b6, A_0);
    }

    internal PageBorderOffsetFrom method_94()
    {
        return (PageBorderOffsetFrom) base.method_32(0x8c0);
    }

    internal void method_95(PageBorderOffsetFrom A_0)
    {
        this.SetAttr(0x8c0, A_0);
    }

    internal float method_96()
    {
        return (float) base.method_32(0x8d4);
    }

    internal void method_97(float A_0)
    {
        this.SetAttr(0x8d4, A_0);
    }

    internal float method_98()
    {
        return (float) base.method_32(0x8de);
    }

    internal void method_99(float A_0)
    {
        this.SetAttr(0x8de, A_0);
    }

    void FormatBase.ApplyProperty()
    {
        if (base.m_propsUpdateFlags != null)
        {
            base.m_propsUpdateFlags.Clear();
        }
        Type type = typeof(Class1127);
        foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
        {
            int num2 = (int) info.GetValue(info.FieldType);
            base.method_32(num2);
        }
    }

    void FormatBase.CopyPropertiesTo(FormatBase A_0)
    {
        Class17 class2 = A_0 as Class17;
        if (base.HasKey(0x7d0))
        {
            this.method_50().CopyPropertiesTo(class2.method_50());
        }
        if (base.HasKey(0x7da))
        {
            class2.method_53(this.method_52());
        }
        if (base.HasKey(0x7e4))
        {
            class2.method_55(this.method_54());
        }
        if (base.HasKey(0x7ee))
        {
            class2.method_57(this.method_56());
        }
        if (base.HasKey(0x7f8))
        {
            class2.method_59(this.method_58());
        }
        if (base.HasKey(0x802))
        {
            class2.method_61(this.method_60());
        }
        if (base.HasKey(0x80c))
        {
            class2.method_63(this.method_62());
        }
        if (base.HasKey(0x816))
        {
            class2.method_65(this.method_64());
        }
        if (base.HasKey(0x820))
        {
            class2.method_67(this.method_66());
        }
        if (base.HasKey(0x834))
        {
            class2.method_69(this.method_68());
        }
        if (base.HasKey(0x83e))
        {
            class2.method_71(this.method_70());
        }
        if (base.HasKey(0x848))
        {
            class2.method_73(this.method_72());
        }
        if (base.HasKey(0x87a))
        {
            class2.method_79(this.method_78());
        }
        if (base.HasKey(0xa50))
        {
            class2.method_81(this.method_80());
        }
        if (base.HasKey(0x884))
        {
            class2.method_83(this.method_82());
        }
        if (base.HasKey(0x88e))
        {
            class2.method_85(this.method_84());
        }
        if (base.HasKey(0x898))
        {
            class2.method_87(this.method_86());
        }
        if (base.HasKey(0x8a2))
        {
            class2.method_89(this.method_88());
        }
        if (base.HasKey(0x8ac))
        {
            class2.method_91(this.method_90());
        }
        if (base.HasKey(0x8b6))
        {
            class2.method_93(this.method_92());
        }
        if (base.HasKey(0x8c0))
        {
            class2.method_95(this.method_94());
        }
        if (base.HasKey(0x8d4))
        {
            class2.method_97(this.method_96());
        }
        if (base.HasKey(0x8de))
        {
            class2.method_99(this.method_98());
        }
        if (base.HasKey(0x8e8))
        {
            class2.method_101(this.method_100());
        }
        if (base.HasKey(0x8f2))
        {
            class2.method_103(this.method_102());
        }
        if (base.HasKey(0x8fc))
        {
            class2.method_105(this.method_104());
        }
        if (base.HasKey(0x906))
        {
            class2.method_107(this.method_106());
        }
        if (base.HasKey(0x908))
        {
            class2.method_109(this.method_108());
        }
        if (base.HasKey(0x910))
        {
            class2.method_111(this.method_110());
        }
        if (base.HasKey(0x91a))
        {
            class2.method_113(this.method_112());
        }
        if (base.HasKey(0x924))
        {
            class2.method_115(this.method_114());
        }
        if (base.HasKey(0x92e))
        {
            class2.method_117(this.method_116());
        }
        if (base.HasKey(0x938))
        {
            class2.method_119(this.method_118());
        }
        if (base.HasKey(0x942))
        {
            class2.method_121(this.method_120());
        }
        if (base.HasKey(0x94c))
        {
            this.method_122().method_6(class2.method_122());
        }
        if (base.HasKey(0x956))
        {
            class2.method_125(this.method_124());
        }
        if (base.HasKey(0x960))
        {
            class2.method_127(this.method_126());
        }
        if (base.HasKey(0x96a))
        {
            class2.method_129(this.method_128());
        }
        if (base.HasKey(0x974))
        {
            class2.method_131(this.method_130());
        }
        if (base.HasKey(0x97e))
        {
            class2.method_133(this.method_132());
        }
        if (base.HasKey(0x988))
        {
            class2.method_135(this.method_134());
        }
        if (base.HasKey(0x992))
        {
            class2.method_137(this.method_136());
        }
        if (base.HasKey(0x9c4))
        {
            class2.method_141(this.method_140());
        }
        if (base.HasKey(0x9ce))
        {
            class2.method_143(this.method_142());
        }
        if (base.HasKey(0x9e2))
        {
            class2.method_145(this.method_144());
        }
        if (base.HasKey(0x9d8))
        {
            class2.method_147(this.method_146());
        }
        if (base.HasKey(0xa28))
        {
            class2.method_149(this.method_148());
        }
        if (base.HasKey(0xa32))
        {
            class2.method_151(this.method_150());
        }
        if (base.HasKey(0xa46))
        {
            class2.method_153(this.method_152());
        }
        if (base.HasKey(0xa3c))
        {
            class2.method_155(this.method_154());
        }
        if (base.HasKey(0x7c6))
        {
            this.method_49().CopyPropertiesTo(class2.method_49());
        }
    }

    FormatBase FormatBase.GetDefComposite(int A_0)
    {
        switch (A_0)
        {
            case 0x7b2:
                return base.GetDefComposite(0x7b2, new FootEndnoteOptions(this, 0x7b2, false));

            case 0x7bc:
                return base.GetDefComposite(0x7bc, new FootEndnoteOptions(this, 0x7bc, true));

            case 0x7c6:
                return base.GetDefComposite(0x7c6, new Borders(this, 0x7c6));

            case 0x7d0:
                return base.GetDefComposite(0x7d0, new MarginsF(this, 0x7d0));
        }
        return base.GetDefComposite(A_0);
    }

    object FormatBase.GetDefValue(int A_0)
    {
        int num = 12;
        int num2 = A_0;
        if (num2 <= 0x8c0)
        {
            if (num2 > 0x834)
            {
                if (num2 > 0x87a)
                {
                    if (num2 > 0x898)
                    {
                        if (num2 > 0x8ac)
                        {
                            if (num2 == 0x8b6)
                            {
                                return true;
                            }
                            if (num2 == 0x8c0)
                            {
                                return PageBorderOffsetFrom.Text;
                            }
                        }
                        else
                        {
                            switch (num2)
                            {
                                case 0x8a2:
                                    return PageOrientation.Portrait;

                                case 0x8ac:
                                    return PageBordersApplyType.AllPages;
                            }
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x884:
                                return 1;

                            case 0x88e:
                                return 0;

                            case 0x898:
                                return 0;
                        }
                    }
                }
                else if (num2 > 0x852)
                {
                    if (num2 > 0x866)
                    {
                        if (num2 == 0x870)
                        {
                            return this.method_49().Right;
                        }
                        if (num2 == 0x87a)
                        {
                            return 0f;
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x85c:
                                return this.method_49().Left;

                            case 0x866:
                                return this.method_49().Bottom;
                        }
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x83e:
                            return LineNumberingRestartMode.RestartPage;

                        case 0x848:
                            return 0;

                        case 0x852:
                            return this.method_49().Top;
                    }
                }
            }
            else if (num2 <= 0x7ee)
            {
                if (num2 > 0x7c6)
                {
                    if (num2 > 0x7da)
                    {
                        if (num2 == 0x7e4)
                        {
                            return PageSeparator.Hyphen;
                        }
                        if (num2 == 0x7ee)
                        {
                            return SectionBreakType.NewPage;
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x7d0:
                                this.method_50().method_49(new MarginsF(50f, 20f, 50f, 20f));
                                return this.method_50();

                            case 0x7da:
                                return PageNumberStyle.Arabic;
                        }
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x7b2:
                            return this.GetDefComposite(0x7b2);

                        case 0x7bc:
                            return this.GetDefComposite(0x7bc);

                        case 0x7c6:
                            return base.GetDefComposite(0x7c6, new Borders(this, 0x7c6));
                    }
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x7f8:
                    case 0x802:
                    case 0x80c:
                    case 0x834:
                        goto Label_04B5;

                    case 0x82a:
                        return 0;

                    case 0x816:
                        return 0;

                    case 0x820:
                        return 0;
                }
            }
        }
        else if (num2 <= 0x956)
        {
            if (num2 <= 0x910)
            {
                if (num2 > 0x8e8)
                {
                    if (num2 > 0x8fc)
                    {
                        if (num2 == 0x906)
                        {
                            return this.method_50().Bottom;
                        }
                        if (num2 == 0x910)
                        {
                            return 36f;
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 0x8f2:
                                return this.method_50().Right;

                            case 0x8fc:
                                return this.method_50().Top;
                        }
                    }
                }
                else
                {
                    switch (num2)
                    {
                        case 0x8d4:
                            return 595.35f;

                        case 0x8de:
                            return 841.95f;

                        case 0x8e8:
                            return this.method_50().Left;
                    }
                }
            }
            else
            {
                switch (num2)
                {
                    case 0x91a:
                        return 36f;

                    case 0x924:
                        return PageAlignment.Top;

                    case 0x92e:
                        return 1;

                    case 0x94c:
                        if (!base.HasKey(0x94c))
                        {
                            ColumnCollection columns = new ColumnCollection(this.section_0);
                            this.SetAttr(0x94c, columns);
                        }
                        return base.method_31(0x94c);

                    case 0x956:
                        goto Label_04B5;

                    case 0x938:
                        return true;

                    case 0x942:
                        return 720;
                }
            }
        }
        else if (num2 > 0x9c4)
        {
            switch (num2)
            {
                case 0x9e2:
                    return this.method_139().NumberFormat;

                case 0xa28:
                    return this.method_138().Position;

                case 0x9ce:
                    return this.method_139().RestartRule;

                case 0x9d8:
                    return this.method_139().StartNumber;

                case 0xa32:
                    return this.method_138().RestartRule;

                case 0xa3c:
                    return this.method_138().StartNumber;

                case 0xa46:
                    return this.method_138().NumberFormat;

                case 0xa50:
                    return 0;
            }
        }
        else
        {
            switch (num2)
            {
                case 0x960:
                    return 0f;

                case 0x96a:
                case 0x992:
                    goto Label_04B5;

                case 0x974:
                    return 0;

                case 0x9c4:
                    return this.method_139().Position;

                case 0x97e:
                    return 0;

                case 0x988:
                    return TextDirection.TopToBottom;
            }
        }
        throw new NotImplementedException(string.Format(BookmarkStart.b("愱儳唵䰷樹主ḽ㬿牁㥃晅⍇⽉㕋㵍灏㱑㭓癕ㅗ㝙ⱛ㉝՟ཡţࡥᱧ୩ᡫݭὯᱱ婳噵", num), A_0));
    Label_04B5:
        return false;
    }

    int FormatBase.GetFullKey(int A_0)
    {
        int num = A_0;
        if (num <= 0x908)
        {
            if (num <= 0x870)
            {
                if (num > 0x85c)
                {
                    if (num == 0x866)
                    {
                        return this.method_49().GetFullKey(3);
                    }
                    if (num == 0x870)
                    {
                        return this.method_49().GetFullKey(4);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x852:
                            return this.method_49().GetFullKey(2);

                        case 0x85c:
                            return this.method_49().GetFullKey(1);
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0x8e8:
                        return this.method_50().GetFullKey(1);

                    case 0x8f2:
                        return this.method_50().GetFullKey(2);

                    case 0x906:
                        return this.method_50().GetFullKey(4);

                    case 0x908:
                        return this.method_50().GetFullKey(5);

                    case 0x8fc:
                        return this.method_50().GetFullKey(3);
                }
            }
        }
        else
        {
            switch (num)
            {
                case 0x9d8:
                    return this.method_139().GetFullKey(4);

                case 0x9e2:
                    return this.method_139().GetFullKey(1);

                case 0x9c4:
                    return this.method_139().GetFullKey(2);

                case 0x9ce:
                    return this.method_139().GetFullKey(3);

                case 0xa28:
                    return this.method_138().GetFullKey(2);

                case 0xa32:
                    return this.method_138().GetFullKey(3);

                case 0xa3c:
                    return this.method_138().GetFullKey(4);

                case 0xa46:
                    return this.method_138().GetFullKey(1);
            }
        }
        return base.GetFullKey(A_0);
    }

    void FormatBase.OnChange(FormatBase A_0, int A_1)
    {
        int num = A_1;
        if (num > 0x9ce)
        {
            if (num > 0xa28)
            {
                if (((num != 0xa32) && (num != 0xa3c)) && (num != 0xa46))
                {
                    return;
                }
            }
            else
            {
                switch (num)
                {
                    case 0x9d8:
                    case 0x9e2:
                        goto Label_0082;
                }
                if (num != 0xa28)
                {
                    return;
                }
            }
            this.method_138().IsDefault = false;
            return;
        }
        if (num <= 0x8fc)
        {
            if (((num != 0x8e8) && (num != 0x8f2)) && (num != 0x8fc))
            {
                return;
            }
        }
        else
        {
            switch (num)
            {
                case 0x906:
                case 0x908:
                    goto Label_0054;

                case 0x907:
                    return;

                case 0x9c4:
                case 0x9ce:
                    goto Label_0082;
            }
            return;
        }
    Label_0054:
        this.method_50().IsDefault = false;
        return;
    Label_0082:
        this.method_139().IsDefault = false;
    }
}

