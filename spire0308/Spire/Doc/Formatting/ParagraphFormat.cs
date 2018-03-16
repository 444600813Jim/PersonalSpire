namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;

    public class ParagraphFormat : WordAttrCollection
    {
        private bool bool_2;
        private bool[] bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        private Class14 class14_0;
        private float[] float_2;
        private long[] long_3;
        private ParagraphFormat paragraphFormat_0;
        internal const short short_0 = 0x3fc;
        internal const short short_1 = 0x460;
        internal const short short_10 = 0x4b0;
        internal const short short_11 = 0x4c4;
        internal const short short_12 = 0x41a;
        internal const short short_13 = 0x5be;
        internal const short short_14 = 0x424;
        internal const short short_15 = 13;
        internal const short short_16 = 20;
        internal const short short_17 = 0x15;
        internal const short short_18 = 0x16;
        internal const short short_19 = 0x474;
        internal const short short_2 = 0x456;
        internal const short short_20 = 0x618;
        internal const short short_21 = 0x20;
        internal const short short_22 = 0x21;
        internal const short short_23 = 0x5b4;
        internal const short short_24 = 50;
        internal const short short_25 = 0x4f6;
        internal const short short_26 = 0x4d8;
        internal const short short_27 = 0x4e2;
        internal const short short_28 = 0x672;
        internal const short short_29 = 0x677;
        internal const short short_3 = 0x488;
        internal const short short_30 = 0x4ba;
        internal const short short_31 = 0x4ce;
        internal const short short_32 = 0x500;
        internal const short short_33 = 0x550;
        internal const short short_34 = 0x564;
        internal const short short_35 = 0x546;
        internal const short short_36 = 0x55a;
        internal const short short_37 = 0x3d;
        internal const short short_38 = 0x3e;
        internal const short short_39 = 0x3f;
        internal const short short_4 = 0x44;
        internal const short short_40 = 0x40;
        internal const short short_41 = 0x62c;
        internal const short short_42 = 0x56e;
        internal const short short_43 = 0x578;
        internal const short short_44 = 0x3fe;
        internal const short short_45 = 0x528;
        internal const short short_46 = 0x50a;
        internal const short short_47 = 0x514;
        internal const short short_48 = 0x51e;
        internal const short short_49 = 0x58c;
        internal const short short_5 = 0x47e;
        internal const short short_50 = 0x5dc;
        internal const short short_51 = 0x5d2;
        internal const short short_52 = 0x582;
        internal const short short_53 = 0x53c;
        internal const short short_54 = 0x5b;
        internal const short short_55 = 0x479;
        internal const short short_56 = 0x48d;
        internal const short short_57 = 0x497;
        internal const short short_58 = 0x483;
        internal const short short_59 = 0x5e6;
        internal const short short_6 = 0x45;
        internal const short short_60 = 0x442;
        internal const short short_61 = 0x4ec;
        internal const short short_62 = 0x5b;
        internal const short short_63 = 0x532;
        internal const short short_64 = 0x596;
        internal const short short_65 = 0x5a0;
        internal const short short_66 = 0x5aa;
        internal const short short_67 = 0x438;
        internal const short short_68 = 0x44c;
        internal const short short_69 = 0x46a;
        internal const short short_7 = 0x492;
        internal const short short_70 = 0x67c;
        internal const short short_71 = 0x4b5;
        internal const short short_72 = 0x4c9;
        internal const short short_73 = 40;
        internal const short short_74 = 0x5b5;
        internal const short short_8 = 70;
        internal const short short_9 = 0x410;

        public ParagraphFormat()
        {
        }

        public ParagraphFormat(IDocument document) : base((Document) document)
        {
        }

        internal override void AcceptChanges()
        {
            base[0x62c] = false;
            base.AcceptChanges();
        }

        internal override void AcceptFormatRevision(WordAttrCollection attr)
        {
            base.AcceptFormatRevisionCore(base.BaseFormat, new int[] { 0x465 }, attr);
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            base.ApplyBase(baseFormat);
            this.Borders.ApplyBase((baseFormat as ParagraphFormat).Borders);
            this.Frame.ApplyBase((baseFormat as ParagraphFormat).Frame);
            bool flag1 = base.Document.bool_3;
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(ParagraphFormat);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int key = (short) info.GetValue(info.FieldType);
                if (base.HasKey(key))
                {
                    this.method_49(key);
                }
            }
        }

        internal override AttrCollection Clone()
        {
            ParagraphFormat format = base.method_23() as ParagraphFormat;
            if (base.BaseFormat != null)
            {
                format.ApplyBase(base.BaseFormat);
            }
            return format;
        }

        protected internal override void EnsureComposites()
        {
            if (base.HasKey(20))
            {
                base.EnsureComposites(new int[] { 20 });
            }
            if (base.HasKey(0x5b4))
            {
                base.EnsureComposites(new int[] { 0x5b4 });
            }
        }

        protected override FormatBase GetDefComposite(int key)
        {
            int num = key;
            switch (num)
            {
                case 20:
                    return base.GetDefComposite(20, new Spire.Doc.Documents.Borders(this, 20));

                case 40:
                    return base.GetDefComposite(40, new Class14(this, 40));
            }
            if (num != 0x5b4)
            {
                return null;
            }
            return base.GetDefComposite(0x5b4, new Class16(this, 0x5b4));
        }

        protected override object GetDefValue(int key)
        {
            if (((base.m_doc != null) && (base.m_doc.paragraphFormat_0 != null)) && (base.m_doc.paragraphFormat_0 != this))
            {
                return base.m_doc.paragraphFormat_0[key];
            }
            int num = key;
            if (num <= 0x4b0)
            {
                switch (num)
                {
                    case 0x15:
                        return this.Shading.method_54();

                    case 0x16:
                    case 13:
                    case 0x3fe:
                    case 0x410:
                    case 0x41a:
                    case 0x424:
                    case 0x479:
                        goto Label_039F;

                    case 0x20:
                        return this.Shading.method_58();

                    case 0x21:
                        return this.Shading.method_62();

                    case 50:
                        return null;

                    case 0x44:
                    case 0x45:
                    case 70:
                    case 0x47e:
                    case 0x483:
                    case 0x488:
                    case 0x48d:
                    case 0x492:
                    case 0x497:
                    case 0x4b0:
                        goto Label_0217;

                    case 0x3fc:
                        return Spire.Doc.Documents.HorizontalAlignment.Left;

                    case 0x5b:
                        return 0;

                    case 0x442:
                        goto Label_036C;

                    case 0x474:
                        return new TabCollection(base.Document, this);

                    case 0x456:
                    case 0x460:
                        return 0;
                }
                goto Label_038B;
            }
            if (num > 0x55a)
            {
                if (num <= 0x5b5)
                {
                    switch (num)
                    {
                        case 0x5b4:
                            return this.Shading;

                        case 0x5b5:
                            return -2147483648;

                        case 0x582:
                            goto Label_039F;

                        case 0x578:
                            return this.Borders.Vertical;

                        case 0x564:
                            return this.Borders.Right;

                        case 0x56e:
                            return this.Borders.Horizontal;
                    }
                }
                else if (num > 0x618)
                {
                    switch (num)
                    {
                        case 0x62c:
                            goto Label_039F;

                        case 0x672:
                            return 12f;

                        case 0x677:
                            return Spire.Doc.LineSpacingRule.Multiple;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x5be:
                            goto Label_036C;

                        case 0x5e6:
                            return Spire.Doc.Documents.TextAlignment.Auto;

                        case 0x618:
                            goto Label_039F;
                    }
                }
                goto Label_038B;
            }
            if (num > 0x4e2)
            {
                if (num > 0x500)
                {
                    switch (num)
                    {
                        case 0x546:
                            return this.Borders.Top;

                        case 0x550:
                            return this.Borders.Left;

                        case 0x55a:
                            return this.Borders.Bottom;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x4ec:
                        case 0x4f6:
                            goto Label_036C;

                        case 0x500:
                            return (byte) 0xff;
                    }
                }
                goto Label_038B;
            }
            if (num > 0x4c4)
            {
                switch (num)
                {
                    case 0x4ce:
                        goto Label_039F;

                    case 0x4d8:
                    case 0x4e2:
                        goto Label_036C;
                }
                goto Label_038B;
            }
            if (num == 0x4ba)
            {
                goto Label_039F;
            }
            if (num != 0x4c4)
            {
                goto Label_038B;
            }
        Label_0217:
            return 0f;
        Label_036C:
            return true;
        Label_038B:
            return null;
        Label_039F:
            return false;
        }

        internal override int GetFullKey(int key)
        {
            int num = key;
            if (num <= 0x550)
            {
                if (num > 0x51e)
                {
                    if (num > 0x532)
                    {
                        switch (num)
                        {
                            case 0x53c:
                                return this.Frame.GetFullKey(0x12);

                            case 0x546:
                                return this.Borders.GetFullKey(2);

                            case 0x550:
                                return this.Borders.GetFullKey(1);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x528:
                                return this.Frame.GetFullKey(11);

                            case 0x532:
                                return this.Frame.GetFullKey(12);
                        }
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x20:
                            return this.Shading.GetFullKey(2);

                        case 0x21:
                            return this.Shading.GetFullKey(1);

                        case 0x15:
                            return this.Shading.GetFullKey(3);

                        case 0x50a:
                            return this.Frame.GetFullKey(8);

                        case 0x50c:
                            return this.Frame.GetFullKey(3);

                        case 0x514:
                            return this.Frame.GetFullKey(15);

                        case 0x516:
                            return this.Frame.GetFullKey(4);

                        case 0x51e:
                            return this.Frame.GetFullKey(0x11);
                    }
                }
            }
            else if (num <= 0x5a0)
            {
                if (num > 0x564)
                {
                    switch (num)
                    {
                        case 0x58c:
                            return this.Frame.GetFullKey(6);

                        case 0x596:
                            return this.Frame.GetFullKey(7);

                        case 0x5a0:
                            return this.Frame.GetFullKey(20);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x55a:
                            return this.Borders.GetFullKey(3);

                        case 0x564:
                            return this.Borders.GetFullKey(4);
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0x5aa:
                        return this.Frame.GetFullKey(0x15);

                    case 0x5c8:
                        return this.Frame.GetFullKey(14);

                    case 0x5d2:
                        return this.Frame.GetFullKey(0x10);

                    case 0x5dc:
                        return this.Frame.GetFullKey(9);

                    case 0x5f0:
                        return this.Frame.GetFullKey(5);

                    case 0x67c:
                        return this.Frame.GetFullKey(13);
                }
            }
            return base.GetFullKey(key);
        }

        protected override int GetSprmOption(int propertyKey)
        {
            int num = propertyKey;
            if (num <= 0x4ec)
            {
                if (num > 0x47e)
                {
                    if (num > 0x4b5)
                    {
                        if (num > 0x4c9)
                        {
                            if (num > 0x4d8)
                            {
                                if (num == 0x4e2)
                                {
                                    return 0x2438;
                                }
                                if (num == 0x4ec)
                                {
                                    return 0x2447;
                                }
                            }
                            else
                            {
                                switch (num)
                                {
                                    case 0x4ce:
                                        return 0x245c;

                                    case 0x4d8:
                                        return 0x2437;
                                }
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x4ba:
                                    return 0x245b;

                                case 0x4c4:
                                    return 0xa414;

                                case 0x4c9:
                                    return 0x4459;
                            }
                        }
                    }
                    else if (num > 0x48d)
                    {
                        if (num > 0x497)
                        {
                            if (num == 0x4b0)
                            {
                                return 0xa413;
                            }
                            if (num == 0x4b5)
                            {
                                return 0x4458;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x492:
                                    return 0x8411;

                                case 0x497:
                                    return 0x4457;
                            }
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x483:
                                return 0x4455;

                            case 0x488:
                                return 0x840f;

                            case 0x48d:
                                return 0x4456;
                        }
                    }
                }
                else if (num > 0x424)
                {
                    if (num > 0x44c)
                    {
                        if (num > 0x460)
                        {
                            if (num == 0x46a)
                            {
                                return 0x240c;
                            }
                            if (num == 0x47e)
                            {
                                return 0x840e;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x456:
                                    return 0x260a;

                                case 0x460:
                                    return 0x460b;
                            }
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x438:
                                return 0x2434;

                            case 0x442:
                                return 0x2435;

                            case 0x44c:
                                return 0x2436;
                        }
                    }
                }
                else if (num > 0x3fe)
                {
                    switch (num)
                    {
                        case 0x410:
                            return 0x2405;

                        case 0x41a:
                            return 0x2406;

                        case 0x424:
                            return 0x2407;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x3d:
                            return 0xc64f;

                        case 0x3e:
                            return 0xc651;

                        case 0x3f:
                            return 0xc64e;

                        case 0x40:
                            return 0xc650;

                        case 0x44:
                            return 0x845e;

                        case 0x45:
                            return 0x845d;

                        case 70:
                            return 0x8460;

                        case 0x5b:
                            return 0x2430;

                        case 0x3fc:
                            return 0x2403;

                        case 0x3fe:
                            return 0x246d;
                    }
                }
                goto Label_044C;
            }
            if (num > 0x56e)
            {
                if (num > 0x5b5)
                {
                    switch (num)
                    {
                        case 0x5be:
                            return 0x2431;

                        case 0x5d2:
                            return 0x842e;

                        case 0x5dc:
                            return 0x842f;

                        case 0x618:
                            return 0x2441;

                        case 0x672:
                        case 0x677:
                            return 0x6412;

                        case 0x67c:
                            return 0x3465;
                    }
                }
                else if (num <= 0x58c)
                {
                    switch (num)
                    {
                        case 0x578:
                            return 0x6629;

                        case 0x582:
                            return 0x242a;

                        case 0x58c:
                            goto Label_03C4;
                    }
                }
                else if (num > 0x5a0)
                {
                    if (num == 0x5aa)
                    {
                        goto Label_03E2;
                    }
                    if (num == 0x5b5)
                    {
                        return 0x6465;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x596:
                            goto Label_03C4;

                        case 0x5a0:
                            goto Label_03E2;
                    }
                }
                goto Label_044C;
            }
            if (num <= 0x528)
            {
                switch (num)
                {
                    case 0x4f6:
                        return 0x2448;

                    case 0x500:
                        return 0x2640;

                    case 0x50a:
                        return 0x8418;

                    case 0x514:
                        return 0x8419;

                    case 0x51e:
                        return 0x841a;

                    case 0x528:
                        goto Label_031E;
                }
                goto Label_044C;
            }
            if (num > 0x546)
            {
                if (num > 0x55a)
                {
                    if (num == 0x564)
                    {
                        return 0x6427;
                    }
                    if (num == 0x56e)
                    {
                        return 0x6428;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x550:
                            return 0x6425;

                        case 0x55a:
                            return 0x6426;
                    }
                }
                goto Label_044C;
            }
            switch (num)
            {
                case 0x532:
                    break;

                case 0x53c:
                    return 0x2423;

                default:
                    if (num != 0x546)
                    {
                        goto Label_044C;
                    }
                    return 0x6424;
            }
        Label_031E:
            return 0x261b;
        Label_03C4:
            return 0x442b;
        Label_03E2:
            return 0x442c;
        Label_044C:
            return 0x7fffffff;
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasValue(propertyKey);
        }

        protected override void ImportMembers(FormatBase format)
        {
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䔦䘨太䤬䨮䌰䀲", 1), this.Borders);
            base.XDLSHolder.AddElement(BookmarkStart.b("猦䠨䤪帬", 1), this.Tabs);
        }

        private object method_49(int A_0)
        {
            return base[A_0];
        }

        private void method_50(int A_0, object A_1)
        {
            base[A_0] = A_1;
        }

        internal void method_51()
        {
            base.ClearFormatting();
            this.Tabs.Clear();
        }

        internal void method_52(TabCollection A_0)
        {
            base[0x474] = A_0;
        }

        internal void method_53()
        {
            base[0x474] = new TabCollection(base.m_doc, this);
        }

        internal void method_54(ParagraphFormat A_0)
        {
            if (base.m_doc.paragraphFormat_0 != null)
            {
                foreach (KeyValuePair<int, object> pair in base.m_doc.paragraphFormat_0.PropertiesHash)
                {
                    if ((pair.Key != 20) && !A_0.method_55(pair.Key))
                    {
                        base.PropertiesHash.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        internal bool method_55(int A_0)
        {
            return (base.PropertiesHash.ContainsKey(A_0) || ((base.BaseFormat != null) && (base.BaseFormat as ParagraphFormat).method_55(A_0)));
        }

        private void method_56(FormatBase A_0, int A_1)
        {
            int num = A_1;
            if (num <= 0x58c)
            {
                if (num <= 0x51e)
                {
                    switch (num)
                    {
                        case 0x50a:
                        case 0x50c:
                        case 0x514:
                        case 0x516:
                        case 0x51e:
                            goto Label_00D4;

                        case 0x50b:
                        case 0x515:
                            return;
                    }
                    return;
                }
                if (num > 0x532)
                {
                    switch (num)
                    {
                        case 0x53c:
                        case 0x58c:
                            goto Label_00D4;
                    }
                    return;
                }
                if ((num != 0x528) && (num != 0x532))
                {
                    return;
                }
            }
            else if (num <= 0x5c8)
            {
                if (num > 0x5a0)
                {
                    switch (num)
                    {
                        case 0x5aa:
                        case 0x5c8:
                            goto Label_00D4;
                    }
                    return;
                }
                if ((num != 0x596) && (num != 0x5a0))
                {
                    return;
                }
            }
            else if (num <= 0x5dc)
            {
                if ((num != 0x5d2) && (num != 0x5dc))
                {
                    return;
                }
            }
            else if ((num != 0x5f0) && (num != 0x67c))
            {
                return;
            }
        Label_00D4:
            this.Frame.IsDefault = false;
        }

        internal bool method_57(int A_0)
        {
            return base.method_7(A_0);
        }

        internal bool method_58(int A_0)
        {
            bool flag;
            if (!(flag = this.method_57(A_0)))
            {
                FormatBase baseFormat = base.BaseFormat;
            }
            return flag;
        }

        internal bool method_59(int A_0)
        {
            bool flag;
            if (!(flag = this.HasValue(A_0)))
            {
                FormatBase baseFormat = base.BaseFormat;
            }
            return flag;
        }

        internal bool method_60()
        {
            return (base.HasKey(0x5b4) && !this.Shading.IsDefault);
        }

        internal void method_61()
        {
            this.Frame.method_129(0x53c);
            this.IsFrame = false;
            this.FrameX = 0;
            this.FrameY = 0;
            this.Frame.method_129(0x50a);
            this.Frame.method_129(0x514);
            this.FrameWidth = 0;
            this.FrameHeight = 0;
            this.Frame.method_129(0x51e);
            this.Frame.method_129(0x58c);
            this.FrameHorizontalPos = 0;
            this.FrameVerticalPos = 0;
            this.Frame.method_129(0x5dc);
            this.Frame.method_129(0x5d2);
            this.Frame.method_129(0x5b);
            if (!this.Borders.NoBorder)
            {
                this.Borders.BorderType = BorderStyle.None;
                this.Borders.Color = new Color();
                this.Borders.LineWidth = 0f;
            }
        }

        internal void method_62(ParagraphFormat A_0, ref TabCollection A_1)
        {
            if (A_0 != null)
            {
                this.method_62(A_0.BaseFormat as ParagraphFormat, ref A_1);
                if (A_0.HasKey(0x474))
                {
                    foreach (Tab tab in A_0.Tabs)
                    {
                        A_1.method_6(tab);
                    }
                }
            }
        }

        internal void method_63(ParagraphFormat A_0)
        {
            if (!this.HasValue(0x3fc) && A_0.HasValue(0x3fc))
            {
                this.HorizontalAlignment = A_0.HorizontalAlignment;
            }
            if (!this.HasValue(0x488) && A_0.HasValue(0x488))
            {
                this.LeftIndent = A_0.LeftIndent;
            }
            if (!this.HasValue(0x44) && A_0.HasValue(0x44))
            {
                this.LeftIndentBi = A_0.LeftIndentBi;
            }
            if (!this.HasValue(0x47e) && A_0.HasValue(0x47e))
            {
                this.RightIndent = A_0.RightIndent;
            }
            if (!this.HasValue(0x45) && A_0.HasValue(0x45))
            {
                this.RightIndentBi = A_0.RightIndentBi;
            }
            if (!this.HasValue(0x492) && A_0.HasValue(0x492))
            {
                this.FirstLineIndent = A_0.FirstLineIndent;
            }
            if (!this.HasValue(70) && A_0.HasValue(70))
            {
                this.FirstLineIndentBi = A_0.FirstLineIndentBi;
            }
            if (!this.HasValue(0x410) && A_0.HasValue(0x410))
            {
                this.KeepLines = A_0.KeepLines;
            }
            if (!this.HasValue(0x4b0) && A_0.HasValue(0x4b0))
            {
                this.BeforeSpacing = A_0.BeforeSpacing;
            }
            if (!this.HasValue(0x4c4) && A_0.HasValue(0x4c4))
            {
                this.AfterSpacing = A_0.AfterSpacing;
            }
            if (!this.HasValue(0x41a) && A_0.HasValue(0x41a))
            {
                this.KeepFollow = A_0.KeepFollow;
            }
            if (!this.HasValue(0x5be) && A_0.HasValue(0x5be))
            {
                this.IsWidowControl = A_0.IsWidowControl;
            }
            if (!this.HasValue(0x424) && A_0.HasValue(0x424))
            {
                this.PageBreakBefore = A_0.PageBreakBefore;
            }
            if (!this.HasValue(13) && A_0.HasValue(13))
            {
                this.PageBreakAfter = A_0.PageBreakAfter;
            }
            if (!this.HasValue(0x15) && A_0.HasValue(0x15))
            {
                this.BackColor = A_0.BackColor;
            }
            if (!this.HasValue(0x16) && A_0.HasValue(0x16))
            {
                this.IsColumnBreakAfter = A_0.IsColumnBreakAfter;
            }
            if (!this.HasValue(0x618) && A_0.HasValue(0x618))
            {
                this.IsBidi = A_0.IsBidi;
            }
            if (!this.HasValue(0x20) && A_0.HasValue(0x20))
            {
                this.ForeColor = A_0.ForeColor;
            }
            if (!this.HasValue(0x21) && A_0.HasValue(0x21))
            {
                this.TextureStyle = A_0.TextureStyle;
            }
            if (!this.HasValue(0x4f6) && A_0.HasValue(0x4f6))
            {
                this.AdjustRightIndent = A_0.AdjustRightIndent;
            }
            if (!this.HasValue(0x4ec) && A_0.HasValue(0x4ec))
            {
                this.SnapToGrid = A_0.SnapToGrid;
            }
            if (!this.HasValue(0x4d8) && A_0.HasValue(0x4d8))
            {
                this.AutoSpaceDE = A_0.AutoSpaceDE;
            }
            if (!this.HasValue(0x4e2) && A_0.HasValue(0x4e2))
            {
                this.AutoSpaceDN = A_0.AutoSpaceDN;
            }
            if (!this.HasValue(0x672) && A_0.HasValue(0x672))
            {
                this.LineSpacing = A_0.LineSpacing;
            }
            if (!this.HasValue(0x677) && A_0.HasValue(0x677))
            {
                this.LineSpacingRule = A_0.LineSpacingRule;
            }
            if (!this.HasValue(0x4ba) && A_0.HasValue(0x4ba))
            {
                this.BeforeAutoSpacing = A_0.BeforeAutoSpacing;
            }
            if (!this.HasValue(0x4ce) && A_0.HasValue(0x4ce))
            {
                this.AfterAutoSpacing = A_0.AfterAutoSpacing;
            }
            if (!this.HasValue(0x500) && A_0.HasValue(0x500))
            {
                this.OutlineLevel = A_0.OutlineLevel;
            }
            if (!this.HasValue(0x62c) && A_0.HasValue(0x62c))
            {
                this.IsChangedFormat = A_0.IsChangedFormat;
            }
            if (!this.HasValue(0x3fe) && A_0.HasValue(0x3fe))
            {
                this.IsContextualSpacing = A_0.IsContextualSpacing;
            }
            if (!this.HasValue(0x50a) && A_0.HasValue(0x50a))
            {
                this.FrameX = A_0.FrameX;
            }
            if (!this.HasValue(0x514) && A_0.HasValue(0x514))
            {
                this.FrameY = A_0.FrameY;
            }
            if (!this.HasValue(0x51e) && A_0.HasValue(0x51e))
            {
                this.FrameWidth = A_0.FrameWidth;
            }
            if (!this.HasValue(0x58c) && A_0.HasValue(0x58c))
            {
                this.FrameHeight = A_0.FrameHeight;
            }
            if (!this.HasValue(0x5dc) && A_0.HasValue(0x5dc))
            {
                this.FrameHorizontalDistanceFromText = A_0.FrameHorizontalDistanceFromText;
            }
            if (!this.HasValue(0x5d2) && A_0.HasValue(0x5d2))
            {
                this.FrameVerticalDistanceFromText = A_0.FrameVerticalDistanceFromText;
            }
            if (!this.HasValue(0x582) && A_0.HasValue(0x582))
            {
                this.SuppressAutoHyphens = A_0.SuppressAutoHyphens;
            }
            if (!this.HasValue(0x479) && A_0.HasValue(0x479))
            {
                this.MirrorIndents = A_0.MirrorIndents;
            }
            if (!this.HasValue(0x53c) && A_0.HasValue(0x53c))
            {
                this.WrapFrameAround = A_0.WrapFrameAround;
            }
            if (!this.HasValue(0x5b) && A_0.HasValue(0x5b))
            {
                this.FrameAnchorLock = A_0.FrameAnchorLock;
            }
            if (!this.HasValue(0x48d) && A_0.HasValue(0x48d))
            {
                this.LeftIndentChars = A_0.LeftIndentChars;
            }
            if (!this.HasValue(0x497) && A_0.HasValue(0x497))
            {
                this.FirstLineIndentChars = A_0.FirstLineIndentChars;
            }
            if (!this.HasValue(0x483) && A_0.HasValue(0x483))
            {
                this.RightIndentChars = A_0.RightIndentChars;
            }
            if (!this.HasValue(0x5e6) && A_0.HasValue(0x5e6))
            {
                this.TextAlignment = A_0.TextAlignment;
            }
        }

        internal void method_64(ParagraphFormat A_0)
        {
            ParagraphFormat format = new ParagraphFormat(A_0.Document);
            format.ImportContainer(this);
            format.method_21(this);
            format.ApplyBase(A_0);
            this.method_65(format);
            base.ImportContainer(format);
            base.method_21(format);
            format.Close();
        }

        private void method_65(ParagraphFormat A_0)
        {
            if (A_0.AdjustRightIndent != this.AdjustRightIndent)
            {
                A_0.AdjustRightIndent = this.AdjustRightIndent;
            }
            if (A_0.AfterSpacing != this.AfterSpacing)
            {
                A_0.AfterSpacing = this.AfterSpacing;
            }
            if (A_0.AutoSpaceDE != this.AutoSpaceDE)
            {
                A_0.AutoSpaceDE = this.AutoSpaceDE;
            }
            if (A_0.AutoSpaceDN != this.AutoSpaceDN)
            {
                A_0.AutoSpaceDN = this.AutoSpaceDN;
            }
            if (A_0.BackColor != this.BackColor)
            {
                A_0.BackColor = this.BackColor;
            }
            if (A_0.BeforeSpacing != this.BeforeSpacing)
            {
                A_0.BeforeSpacing = this.BeforeSpacing;
            }
            if (A_0.IsBidi != this.IsBidi)
            {
                A_0.IsBidi = this.IsBidi;
            }
            if (A_0.IsColumnBreakAfter != this.IsColumnBreakAfter)
            {
                A_0.IsColumnBreakAfter = this.IsColumnBreakAfter;
            }
            if (A_0.IsContextualSpacing != this.IsContextualSpacing)
            {
                A_0.IsContextualSpacing = this.IsContextualSpacing;
            }
            if (A_0.FirstLineIndent != this.FirstLineIndent)
            {
                A_0.FirstLineIndent = this.FirstLineIndent;
            }
            if (A_0.FirstLineIndentBi != this.FirstLineIndentBi)
            {
                A_0.FirstLineIndentBi = this.FirstLineIndentBi;
            }
            if (A_0.ForeColor != this.ForeColor)
            {
                A_0.ForeColor = this.ForeColor;
            }
            if (A_0.FrameHeight != this.FrameHeight)
            {
                A_0.FrameHeight = this.FrameHeight;
            }
            if (A_0.FrameHorizontalDistanceFromText != this.FrameHorizontalDistanceFromText)
            {
                A_0.FrameHorizontalDistanceFromText = this.FrameHorizontalDistanceFromText;
            }
            if (A_0.FrameHorizontalPos != this.FrameHorizontalPos)
            {
                A_0.FrameHorizontalPos = this.FrameHorizontalPos;
            }
            if (A_0.FrameVerticalDistanceFromText != this.FrameVerticalDistanceFromText)
            {
                A_0.FrameVerticalDistanceFromText = this.FrameVerticalDistanceFromText;
            }
            if (A_0.FrameVerticalPos != this.FrameVerticalPos)
            {
                A_0.FrameVerticalPos = this.FrameVerticalPos;
            }
            if (A_0.FrameWidth != this.FrameWidth)
            {
                A_0.FrameWidth = this.FrameWidth;
            }
            if (A_0.FrameX != this.FrameX)
            {
                A_0.FrameX = this.FrameX;
            }
            if (A_0.FrameY != this.FrameY)
            {
                A_0.FrameY = this.FrameY;
            }
            if (A_0.HorizontalAlignment != this.HorizontalAlignment)
            {
                A_0.HorizontalAlignment = this.HorizontalAlignment;
            }
            if (A_0.KeepLines != this.KeepLines)
            {
                A_0.KeepLines = this.KeepLines;
            }
            if (A_0.KeepFollow != this.KeepFollow)
            {
                A_0.KeepFollow = this.KeepFollow;
            }
            if (A_0.LeftIndent != this.LeftIndent)
            {
                A_0.LeftIndent = this.LeftIndent;
            }
            if (A_0.LeftIndentBi != this.LeftIndentBi)
            {
                A_0.LeftIndentBi = this.LeftIndentBi;
            }
            if (A_0.LineSpacing != this.LineSpacing)
            {
                A_0.LineSpacing = this.LineSpacing;
            }
            if (A_0.LineSpacingRule != this.LineSpacingRule)
            {
                A_0.LineSpacingRule = this.LineSpacingRule;
            }
            if (A_0.MirrorIndents != this.MirrorIndents)
            {
                A_0.MirrorIndents = this.MirrorIndents;
            }
            if (A_0.OutlineLevel != this.OutlineLevel)
            {
                A_0.OutlineLevel = this.OutlineLevel;
            }
            if (A_0.PageBreakAfter != this.PageBreakAfter)
            {
                A_0.PageBreakAfter = this.PageBreakAfter;
            }
            if (A_0.PageBreakBefore != this.PageBreakBefore)
            {
                A_0.PageBreakBefore = this.PageBreakBefore;
            }
            if (A_0.RightIndent != this.RightIndent)
            {
                A_0.RightIndent = this.RightIndent;
            }
            if (A_0.RightIndentBi != this.RightIndentBi)
            {
                A_0.RightIndentBi = this.RightIndentBi;
            }
            if (A_0.AfterAutoSpacing != this.AfterAutoSpacing)
            {
                A_0.AfterAutoSpacing = this.AfterAutoSpacing;
            }
            if (A_0.BeforeAutoSpacing != this.BeforeAutoSpacing)
            {
                A_0.BeforeAutoSpacing = this.BeforeAutoSpacing;
            }
            if (A_0.SuppressAutoHyphens != this.SuppressAutoHyphens)
            {
                A_0.SuppressAutoHyphens = this.SuppressAutoHyphens;
            }
            if (A_0.TextureStyle != this.TextureStyle)
            {
                A_0.TextureStyle = this.TextureStyle;
            }
            if (A_0.IsWidowControl != this.IsWidowControl)
            {
                A_0.IsWidowControl = this.IsWidowControl;
            }
            if (A_0.WrapFrameAround != this.WrapFrameAround)
            {
                A_0.WrapFrameAround = this.WrapFrameAround;
            }
            if (A_0.LeftIndentChars != this.LeftIndentChars)
            {
                A_0.LeftIndentChars = this.LeftIndentChars;
            }
            if (A_0.FirstLineIndentChars != this.FirstLineIndentChars)
            {
                A_0.FirstLineIndentChars = this.FirstLineIndentChars;
            }
            if (A_0.RightIndentChars != this.RightIndentChars)
            {
                A_0.RightIndentChars = this.RightIndentChars;
            }
            this.Borders.method_53(A_0.Borders);
            this.method_66(A_0);
        }

        private void method_66(ParagraphFormat A_0)
        {
            if (((base.OwnerBase is Paragraph) && ((base.OwnerBase as Paragraph).ListFormat.ListType != ListType.NoList)) && ((base.OwnerBase as Paragraph).ListFormat.CurrentListLevel != null))
            {
                int[] array = new int[A_0.PropertiesHash.Count];
                A_0.PropertiesHash.Keys.CopyTo(array, 0);
                foreach (int num in array)
                {
                    if (!base.PropertiesHash.ContainsKey(num) && (base.OwnerBase as Paragraph).ListFormat.CurrentListLevel.ParagraphFormat.method_67(num))
                    {
                        A_0.method_71(num);
                        if ((num == 0x488) && !base.PropertiesHash.ContainsKey(0x44))
                        {
                            A_0.method_71(0x44);
                        }
                        else if ((num == 0x47e) && !base.PropertiesHash.ContainsKey(0x45))
                        {
                            A_0.method_71(0x45);
                        }
                        else if ((num == 0x492) && !base.PropertiesHash.ContainsKey(70))
                        {
                            A_0.method_71(70);
                        }
                    }
                }
            }
        }

        private bool method_67(int A_0)
        {
            while (A_0 > 0xff)
            {
                A_0 = A_0 >> 8;
            }
            return this.HasValue(A_0);
        }

        internal bool method_68(ParagraphFormat A_0)
        {
            float num = this.LeftIndent + ((this.FirstLineIndent < 0f) ? this.FirstLineIndent : 0f);
            float num2 = A_0.LeftIndent + ((A_0.FirstLineIndent < 0f) ? A_0.FirstLineIndent : 0f);
            return (Math.Abs((float) (num - num2)) < 0.02);
        }

        internal bool method_69(ParagraphFormat A_0)
        {
            return (Math.Abs((float) (this.RightIndent - A_0.RightIndent)) < 0.02);
        }

        internal bool method_70(ParagraphFormat A_0)
        {
            bool isFloating = this.IsFloating;
            bool flag2 = A_0.IsFloating;
            if (isFloating || flag2)
            {
                if (isFloating != flag2)
                {
                    return false;
                }
                if (this.FrameHorizontalPos != A_0.FrameHorizontalPos)
                {
                    return false;
                }
                if (this.FrameVerticalPos != A_0.FrameVerticalPos)
                {
                    return false;
                }
                if (this.FrameX != A_0.FrameX)
                {
                    return false;
                }
                if (this.FrameY != A_0.FrameY)
                {
                    return false;
                }
                if (this.FrameHorizontalPosition != A_0.FrameHorizontalPosition)
                {
                    return false;
                }
                if (this.FrameVerticalPosition != A_0.FrameVerticalPosition)
                {
                    return false;
                }
                if (this.FrameWidth != A_0.FrameWidth)
                {
                    return false;
                }
                if (this.FrameHeight != A_0.FrameHeight)
                {
                    return false;
                }
                if (this.FrameHeightRule != A_0.FrameHeightRule)
                {
                    return false;
                }
                if (this.FrameHorizontalDistanceFromText != A_0.FrameHorizontalDistanceFromText)
                {
                    return false;
                }
                if (this.FrameVerticalDistanceFromText != A_0.FrameVerticalDistanceFromText)
                {
                    return false;
                }
                if (this.FrameWrapType != A_0.FrameWrapType)
                {
                    return false;
                }
                if (this.FrameLockAnchor != A_0.FrameLockAnchor)
                {
                    return false;
                }
                if (this.FrameTextOrientation != A_0.FrameTextOrientation)
                {
                    return false;
                }
            }
            return true;
        }

        internal void method_71(int A_0)
        {
            base.PropertiesHash.Remove(A_0);
            while (A_0 > 0xff)
            {
                A_0 = A_0 >> 8;
            }
        }

        internal void method_72(ParagraphFormat A_0, IParagraphStyle A_1)
        {
            if (A_0.HasValue(0x4c4) || ((A_1 != null) && A_1.ParagraphFormat.HasValue(0x4c4)))
            {
                base[0x4c4] = A_0.AfterSpacing;
            }
            if (A_0.HasValue(0x4b0) || ((A_1 != null) && A_1.ParagraphFormat.HasValue(0x4b0)))
            {
                base[0x4b0] = A_0.BeforeSpacing;
            }
            if (A_0.HasValue(0x672) || ((A_1 != null) && A_1.ParagraphFormat.HasValue(0x672)))
            {
                base[0x672] = A_0.LineSpacing;
            }
            if (A_0.HasValue(0x15) || ((A_1 != null) && A_1.ParagraphFormat.HasValue(0x15)))
            {
                this.BackColor = A_0.BackColor;
            }
            if (A_0.HasValue(0x677) || ((A_1 != null) && A_1.ParagraphFormat.HasValue(0x677)))
            {
                base[0x677] = A_0.LineSpacingRule;
            }
        }

        protected override void OnChange(FormatBase format, int propKey)
        {
            this.method_56(format, propKey);
            if ((!this.bool_4 && (((base.OwnerBase == null) || !base.OwnerBase.Document.bool_3) || ((base.OwnerBase.Document.DocxPackage != null) || (base.OwnerBase.Document.DetectedFormatType == FileFormat.Rtf)))) && (!(format is Border) && !(format is Spire.Doc.Documents.Borders)))
            {
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 6;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("攫崭爯嬱倳張", 6)))
            {
                this.IsBidi = reader.ReadBoolean(BookmarkStart.b("攫崭爯嬱倳張", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("搫尭焯帱崳儵嘷圹夻倽㐿", num)))
            {
                this.HorizontalAlignment = (Spire.Doc.Documents.HorizontalAlignment) reader.ReadEnum(BookmarkStart.b("搫尭焯帱崳儵嘷圹夻倽㐿", num), typeof(Spire.Doc.Documents.HorizontalAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("怫䬭嘯䘱紳堵尷弹刻䨽", num)))
            {
                this.LeftIndent = reader.ReadFloat(BookmarkStart.b("怫䬭嘯䘱紳堵尷弹刻䨽", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縫䜭圯娱䀳缵嘷帹夻倽㐿", num)))
            {
                this.RightIndent = reader.ReadFloat(BookmarkStart.b("縫䜭圯娱䀳缵嘷帹夻倽㐿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("樫䜭䈯䄱䀳稵儷吹夻眽⸿♁⅃⡅㱇", num)))
            {
                this.FirstLineIndent = reader.ReadFloat(BookmarkStart.b("樫䜭䈯䄱䀳稵儷吹夻眽⸿♁⅃⡅㱇", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("末䬭唯䈱", num)))
            {
                this.KeepLines = reader.ReadBoolean(BookmarkStart.b("末䬭唯䈱", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("渫䬭嘯崱䘳匵欷䨹崻崽⤿ⱁ⍃", num)))
            {
                this.BeforeSpacing = reader.ReadFloat(BookmarkStart.b("渫䬭嘯崱䘳匵欷䨹崻崽⤿ⱁ⍃", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("洫䠭䐯圱䘳攵䠷嬹弻圽⸿╁", num)))
            {
                this.AfterSpacing = reader.ReadFloat(BookmarkStart.b("洫䠭䐯圱䘳攵䠷嬹弻圽⸿╁", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("末䬭唯䈱爳夵吷嘹医䤽", num)))
            {
                this.KeepFollow = reader.ReadBoolean(BookmarkStart.b("末䬭唯䈱爳夵吷嘹医䤽", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("攫崭术嬱倳夵伷礹医倽㐿ぁ⭃⩅", num)))
            {
                this.IsWidowControl = reader.ReadBoolean(BookmarkStart.b("攫崭术嬱倳夵伷礹医倽㐿ぁ⭃⩅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簫伭圯圱瘳䐵崷嬹圻簽┿⑁⭃㑅ⵇ", num)))
            {
                this.PageBreakBefore = reader.ReadBoolean(BookmarkStart.b("簫伭圯圱瘳䐵崷嬹圻簽┿⑁⭃㑅ⵇ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("簫伭圯圱瘳䐵崷嬹圻缽☿㙁⅃㑅", num)))
            {
                this.PageBreakAfter = reader.ReadBoolean(BookmarkStart.b("簫伭圯圱瘳䐵崷嬹圻缽☿㙁⅃㑅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("渫伭匯失眳夵吷唹主", num)))
            {
                this.BackColor = reader.ReadColor(BookmarkStart.b("渫伭匯失眳夵吷唹主", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("攫崭猯崱堳䌵唷吹縻䰽┿⍁⽃݅⹇㹉⥋㱍", num)))
            {
                this.IsColumnBreakAfter = reader.ReadBoolean(BookmarkStart.b("攫崭猯崱堳䌵唷吹縻䰽┿⍁⽃݅⹇㹉⥋㱍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怫䜭帯圱朳䘵夷夹唻倽✿", num)))
            {
                this.LineSpacing = reader.ReadFloat(BookmarkStart.b("怫䜭帯圱朳䘵夷夹唻倽✿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怫䜭帯圱朳䘵夷夹唻倽✿၁ㅃ⩅ⵇ", num)))
            {
                this.LineSpacingRule = (Spire.Doc.LineSpacingRule) reader.ReadEnum(BookmarkStart.b("怫䜭帯圱朳䘵夷夹唻倽✿၁ㅃ⩅ⵇ", num), typeof(Spire.Doc.LineSpacingRule));
            }
            if (reader.HasAttribute(BookmarkStart.b("樫䄭䈯圱眳夵吷唹主", num)))
            {
                this.ForeColor = reader.ReadColor(BookmarkStart.b("樫䄭䈯圱眳夵吷唹主", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("砫䬭䠯䘱䄳䐵崷", num)))
            {
                this.TextureStyle = (Spire.Doc.TextureStyle) reader.ReadEnum(BookmarkStart.b("砫䬭䠯䘱䄳䐵崷", num), typeof(Spire.Doc.TextureStyle));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("張嘷丹夻䰽⸿⍁⡃歅ⱇ⭉㡋⽍", 0x10))
            {
                byte[] buffer = reader.ReadChildBinaryElement();
                Class141 class2 = new Class141(null, null);
                class2.method_65(buffer, this, null);
                class2 = null;
                flag = true;
            }
            return flag;
        }

        internal override void Remove(int key)
        {
            base.Remove(key);
        }

        internal override void SetAttr(int propKey, object value)
        {
            this.method_50(propKey, value);
        }

        public void SetFirstLineIndent(float firstLineIndent)
        {
            this.method_50(0x492, firstLineIndent);
            this.Remove(0x497);
        }

        public void SetLeftIndent(float leftIndent)
        {
            this.method_50(0x488, leftIndent);
            this.Remove(0x48d);
        }

        public void SetRightIndent(float rightIndent)
        {
            this.method_50(0x47e, rightIndent);
            this.Remove(0x483);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x13;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(13))
            {
                writer.WriteValue(BookmarkStart.b("椸娺娼娾̀ㅂ⁄♆≈੊⭌㭎㑐⅒", num), this.PageBreakAfter);
            }
            if (base.HasKey(0x16))
            {
                writer.WriteValue(BookmarkStart.b("瀸䠺縼倾ⵀ㙂⡄⥆ୈ㥊⡌⹎㩐ቒ㍔⍖㱘⥚", num), this.IsColumnBreakAfter);
            }
            if (this.HasValue(0x618))
            {
                writer.WriteValue(BookmarkStart.b("瀸䠺缼嘾╀⩂", num), this.IsBidi);
            }
            if (this.HasValue(0x3fc))
            {
                writer.WriteValue(BookmarkStart.b("焸䤺簼匾⡀⑂⭄⩆ⱈ╊㥌", num), this.HorizontalAlignment);
            }
            if (this.HasValue(0x488))
            {
                writer.WriteValue(BookmarkStart.b("甸帺嬼䬾ࡀⵂ⅄≆❈㽊", num), this.LeftIndent);
            }
            if (this.HasValue(0x47e))
            {
                writer.WriteValue(BookmarkStart.b("欸刺娼圾㕀ੂ⭄⍆ⱈ╊㥌", num), this.RightIndent);
            }
            if (this.HasValue(0x492))
            {
                writer.WriteValue(BookmarkStart.b("缸刺似䰾㕀གⱄ⥆ⱈɊ⍌⭎㑐㵒⅔", num), this.FirstLineIndent);
            }
            if (this.HasValue(0x410))
            {
                writer.WriteValue(BookmarkStart.b("爸帺堼伾", num), this.KeepLines);
            }
            if (this.HasValue(0x4b0))
            {
                writer.WriteValue(BookmarkStart.b("笸帺嬼倾㍀♂ᙄ㝆⡈⡊⑌ⅎ㙐", num), this.BeforeSpacing);
            }
            if (this.HasValue(0x4c4))
            {
                writer.WriteValue(BookmarkStart.b("砸崺䤼娾㍀၂㕄♆⩈≊⍌⡎", num), this.AfterSpacing);
            }
            if (this.HasValue(0x41a))
            {
                writer.WriteValue(BookmarkStart.b("爸帺堼伾݀ⱂ⥄⭆♈㱊", num), this.KeepFollow);
            }
            if (this.HasValue(0x5be))
            {
                writer.WriteValue(BookmarkStart.b("瀸䠺樼嘾╀ⱂ㉄ц♈╊㥌㵎㹐㽒", num), this.IsWidowControl);
            }
            if (this.HasValue(0x424))
            {
                writer.WriteValue(BookmarkStart.b("椸娺娼娾̀ㅂ⁄♆≈ॊ⡌⥎㹐⅒ご", num), this.PageBreakBefore);
            }
            if (!this.BackColor.IsEmpty)
            {
                writer.WriteValue(BookmarkStart.b("笸娺帼吾ɀⱂ⥄⡆㭈", num), this.BackColor);
            }
            if (this.HasValue(0x672))
            {
                writer.WriteValue(BookmarkStart.b("甸刺匼娾ቀ㍂⑄⑆⁈╊⩌", num), this.LineSpacing);
            }
            if (this.HasValue(0x677))
            {
                writer.WriteValue(BookmarkStart.b("甸刺匼娾ቀ㍂⑄⑆⁈╊⩌ᵎ⑐㽒ご", num), this.LineSpacingRule);
            }
            if (this.ForeColor != Color.Empty)
            {
                writer.WriteValue(BookmarkStart.b("缸吺似娾ɀⱂ⥄⡆㭈", num), this.ForeColor);
            }
            if (this.TextureStyle != Spire.Doc.TextureStyle.TextureNone)
            {
                writer.WriteValue(BookmarkStart.b("洸帺䔼䬾㑀ㅂ⁄", num), this.TextureStyle);
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 7;
            base.WriteXmlContent(writer);
            if (!this.IsDefault)
            {
                byte[] buffer = new Class141(null, null).method_63(this, null);
                writer.WriteChildBinaryElement(BookmarkStart.b("䐬䄮䔰嘲䜴夶堸场ြ嬾⁀㝂⑄", num), buffer);
            }
        }

        internal bool AdjustRightIndent
        {
            get
            {
                return (bool) this.method_49(0x4f6);
            }
            set
            {
                this.method_50(0x4f6, value);
            }
        }

        public bool AfterAutoSpacing
        {
            get
            {
                return (bool) this.method_49(0x4ce);
            }
            set
            {
                this.method_50(0x4ce, value);
            }
        }

        public float AfterSpacing
        {
            get
            {
                return (float) this.method_49(0x4c4);
            }
            set
            {
                this.method_50(0x4c4, value);
            }
        }

        internal bool AutoSpaceDE
        {
            get
            {
                return (bool) this.method_49(0x4d8);
            }
            set
            {
                this.method_50(0x4d8, value);
            }
        }

        internal bool AutoSpaceDN
        {
            get
            {
                return (bool) this.method_49(0x4e2);
            }
            set
            {
                this.method_50(0x4e2, value);
            }
        }

        public Color BackColor
        {
            get
            {
                return this.Shading.method_56();
            }
            set
            {
                this.Shading.method_57(value);
            }
        }

        public bool BeforeAutoSpacing
        {
            get
            {
                return (bool) this.method_49(0x4ba);
            }
            set
            {
                this.method_50(0x4ba, value);
            }
        }

        public float BeforeSpacing
        {
            get
            {
                return (float) this.method_49(0x4b0);
            }
            set
            {
                this.method_50(0x4b0, value);
            }
        }

        public Spire.Doc.Documents.Borders Borders
        {
            get
            {
                return (this.method_49(20) as Spire.Doc.Documents.Borders);
            }
        }

        internal int DivId
        {
            get
            {
                return (int) this.method_49(0x5b5);
            }
            set
            {
                this.method_50(0x5b5, value);
            }
        }

        internal int DropCapLinesToDrop
        {
            get
            {
                return this.Frame.method_110();
            }
            set
            {
                this.Frame.method_111(value);
            }
        }

        internal Spire.Doc.DropCapPosition DropCapPosition
        {
            get
            {
                return this.Frame.method_108();
            }
            set
            {
                this.Frame.method_109(value);
            }
        }

        public float FirstLineIndent
        {
            get
            {
                return (float) this.method_49(0x492);
            }
            set
            {
                this.method_50(0x492, value);
            }
        }

        internal float FirstLineIndentBi
        {
            get
            {
                return (float) this.method_49(70);
            }
            set
            {
                this.method_50(70, value);
            }
        }

        internal float FirstLineIndentChars
        {
            get
            {
                return (float) this.method_49(0x497);
            }
            set
            {
                this.method_50(0x497, value);
            }
        }

        internal float FirstLineIndentEx
        {
            get
            {
                if (!this.HasValue(0x497))
                {
                    return this.FirstLineIndent;
                }
                return this.FirstLineIndentChars;
            }
        }

        internal Color ForeColor
        {
            get
            {
                return this.Shading.method_60();
            }
            set
            {
                this.Shading.method_61(value);
            }
        }

        internal Class14 Frame
        {
            get
            {
                return (this.method_49(40) as Class14);
            }
        }

        internal bool FrameAnchorLock
        {
            get
            {
                return this.Frame.method_71();
            }
            set
            {
                this.Frame.method_72(value);
            }
        }

        internal short FrameHeight
        {
            get
            {
                return this.Frame.method_92();
            }
            set
            {
                this.Frame.method_93(value);
            }
        }

        internal float FrameHeightEx
        {
            get
            {
                return this.Frame.method_94();
            }
        }

        internal FrameSizeRule FrameHeightRule
        {
            get
            {
                return this.Frame.method_95();
            }
            set
            {
                this.Frame.method_96(value);
            }
        }

        internal FrameHorzAnchor FrameHorizontalAnchor
        {
            get
            {
                return (FrameHorzAnchor) this.FrameHorizontalPos;
            }
        }

        internal short FrameHorizontalDistanceFromText
        {
            get
            {
                return this.Frame.method_97();
            }
            set
            {
                this.Frame.method_98(value);
            }
        }

        internal float FrameHorizontalDistanceFromTextEx
        {
            get
            {
                return (((float) this.FrameHorizontalDistanceFromText) / 20f);
            }
        }

        internal byte FrameHorizontalPos
        {
            get
            {
                return (byte) this.Frame.method_81();
            }
            set
            {
                this.Frame.method_82((FrameHorzAnchor) value);
            }
        }

        internal HorizontalPosition FrameHorizontalPosition
        {
            get
            {
                return this.Frame.method_74();
            }
            set
            {
                this.Frame.method_75(value);
            }
        }

        internal bool FrameLockAnchor
        {
            get
            {
                return this.Frame.method_80();
            }
        }

        internal bool FrameSuppressOverlap
        {
            get
            {
                return this.Frame.method_105();
            }
            set
            {
                this.Frame.method_106(value);
            }
        }

        internal TextDirection FrameTextOrientation
        {
            get
            {
                return this.Frame.method_79();
            }
        }

        internal FrameVertAnchor FrameVerticalAnchor
        {
            get
            {
                return (FrameVertAnchor) this.FrameVerticalPos;
            }
        }

        internal short FrameVerticalDistanceFromText
        {
            get
            {
                return this.Frame.method_100();
            }
            set
            {
                this.Frame.method_101(value);
            }
        }

        internal float FrameVerticalDistanceFromTextEx
        {
            get
            {
                return (((float) this.FrameVerticalDistanceFromText) / 20f);
            }
        }

        internal byte FrameVerticalPos
        {
            get
            {
                return (byte) this.Frame.method_84();
            }
            set
            {
                this.Frame.method_85((FrameVertAnchor) value);
            }
        }

        internal VerticalPosition FrameVerticalPosition
        {
            get
            {
                return this.Frame.method_77();
            }
            set
            {
                this.Frame.method_78(value);
            }
        }

        internal short FrameWidth
        {
            get
            {
                return this.Frame.method_87();
            }
            set
            {
                this.Frame.method_88(value);
            }
        }

        internal float FrameWidthEx
        {
            get
            {
                return this.Frame.method_91();
            }
        }

        internal FrameSizeRule FrameWidthRule
        {
            get
            {
                return this.Frame.method_89();
            }
            set
            {
                this.Frame.method_90(value);
            }
        }

        internal FrameTextWrap FrameWrapType
        {
            get
            {
                return this.Frame.method_103();
            }
            set
            {
                this.Frame.method_104(value);
            }
        }

        internal short FrameX
        {
            get
            {
                return this.Frame.method_63();
            }
            set
            {
                this.Frame.method_64(value);
            }
        }

        internal short FrameXEx
        {
            get
            {
                return this.Frame.method_65();
            }
        }

        internal short FrameY
        {
            get
            {
                return this.Frame.method_68();
            }
            set
            {
                this.Frame.method_69(value);
            }
        }

        internal short FrameYEx
        {
            get
            {
                return this.Frame.method_70();
            }
        }

        internal bool HasFrameRelativeHorizontalPosition
        {
            get
            {
                return this.Frame.method_83();
            }
        }

        internal bool HasFrameRelativeVerticalPosition
        {
            get
            {
                return this.Frame.method_86();
            }
        }

        internal bool HasListReference
        {
            get
            {
                return ((base.OwnerBase is Paragraph) && (base.OwnerBase as Paragraph).ListFormat.method_6(1));
            }
        }

        public Spire.Doc.Documents.HorizontalAlignment HorizontalAlignment
        {
            get
            {
                return (Spire.Doc.Documents.HorizontalAlignment) this.method_49(0x3fc);
            }
            set
            {
                this.method_50(0x3fc, value);
            }
        }

        public bool IsBidi
        {
            get
            {
                return (bool) this.method_49(0x618);
            }
            set
            {
                this.method_50(0x618, value);
            }
        }

        internal bool IsChangedFormat
        {
            get
            {
                return (bool) this.method_49(0x62c);
            }
            set
            {
                if (value)
                {
                    this.method_50(0x62c, value);
                }
            }
        }

        public bool IsColumnBreakAfter
        {
            get
            {
                object obj2 = base[0x16];
                if (obj2 == null)
                {
                    return false;
                }
                return (bool) obj2;
            }
            set
            {
                base[0x16] = value;
            }
        }

        internal bool IsContextualSpacing
        {
            get
            {
                return (bool) this.method_49(0x3fe);
            }
            set
            {
                this.method_50(0x3fe, value);
            }
        }

        internal bool IsFloating
        {
            get
            {
                if (!this.HasFrameRelativeHorizontalPosition && !this.HasFrameRelativeVerticalPosition)
                {
                    return false;
                }
                return (this.FrameVerticalPosition != VerticalPosition.Inline);
            }
        }

        public bool IsFrame
        {
            get
            {
                return this.Frame.method_107();
            }
            internal set
            {
            }
        }

        internal int Istd
        {
            get
            {
                return (int) this.method_49(0x5b);
            }
            set
            {
                this.method_50(0x5b, value);
            }
        }

        public bool IsWidowControl
        {
            get
            {
                return (bool) this.method_49(0x5be);
            }
            set
            {
                this.method_50(0x5be, value);
            }
        }

        public bool KeepFollow
        {
            get
            {
                return (bool) this.method_49(0x41a);
            }
            set
            {
                this.method_50(0x41a, value);
            }
        }

        public bool KeepLines
        {
            get
            {
                return (bool) this.method_49(0x410);
            }
            set
            {
                this.method_50(0x410, value);
            }
        }

        public float LeftIndent
        {
            get
            {
                return (float) this.method_49(0x488);
            }
            set
            {
                this.method_50(0x488, value);
            }
        }

        internal float LeftIndentBi
        {
            get
            {
                return (float) this.method_49(0x44);
            }
            set
            {
                this.method_50(0x44, value);
            }
        }

        internal float LeftIndentChars
        {
            get
            {
                return (float) this.method_49(0x48d);
            }
            set
            {
                this.method_50(0x48d, value);
            }
        }

        public float LineSpacing
        {
            get
            {
                if (this.LineSpacingRule == Spire.Doc.LineSpacingRule.Exactly)
                {
                    return Math.Abs((float) this.method_49(0x672));
                }
                return (float) this.method_49(0x672);
            }
            set
            {
                switch (this.LineSpacingRule)
                {
                    case Spire.Doc.LineSpacingRule.AtLeast:
                    case Spire.Doc.LineSpacingRule.Multiple:
                        this.method_50(0x672, value);
                        return;

                    case Spire.Doc.LineSpacingRule.Exactly:
                        this.method_50(0x672, -value);
                        return;
                }
            }
        }

        public Spire.Doc.LineSpacingRule LineSpacingRule
        {
            get
            {
                if (((float) this.method_49(0x672)) < 0f)
                {
                    return Spire.Doc.LineSpacingRule.Exactly;
                }
                return (Spire.Doc.LineSpacingRule) this.method_49(0x677);
            }
            set
            {
                float num = (float) this.method_49(0x672);
                switch (value)
                {
                    case Spire.Doc.LineSpacingRule.AtLeast:
                    case Spire.Doc.LineSpacingRule.Multiple:
                        if (num < 0f)
                        {
                            this.method_50(0x672, Math.Abs(num));
                        }
                        break;

                    case Spire.Doc.LineSpacingRule.Exactly:
                        if (num > 0f)
                        {
                            this.method_50(0x672, -num);
                        }
                        break;
                }
                this.method_50(0x677, value);
            }
        }

        public bool MirrorIndents
        {
            get
            {
                return (bool) this.method_49(0x479);
            }
            set
            {
                this.method_50(0x479, value);
            }
        }

        public Spire.Doc.OutlineLevel OutlineLevel
        {
            get
            {
                byte num = (byte) this.method_49(0x500);
                if ((num >= 0) && (num <= 9))
                {
                    return (Spire.Doc.OutlineLevel) Enum.ToObject(typeof(Spire.Doc.OutlineLevel), num);
                }
                return Spire.Doc.OutlineLevel.Body;
            }
            set
            {
                this.method_50(0x500, (byte) value);
            }
        }

        internal int OutlineLevelEx
        {
            get
            {
                return (((int) this.OutlineLevel) + 1);
            }
        }

        public bool OverflowPunc
        {
            get
            {
                return (bool) this.method_49(0x442);
            }
            set
            {
                this.method_50(0x442, value);
            }
        }

        public bool PageBreakAfter
        {
            get
            {
                object obj2 = base[13];
                if (obj2 == null)
                {
                    return false;
                }
                return (bool) obj2;
            }
            set
            {
                base[13] = value;
            }
        }

        public bool PageBreakBefore
        {
            get
            {
                return (bool) this.method_49(0x424);
            }
            set
            {
                this.method_50(0x424, value);
            }
        }

        public float RightIndent
        {
            get
            {
                return (float) this.method_49(0x47e);
            }
            set
            {
                this.method_50(0x47e, value);
            }
        }

        internal float RightIndentBi
        {
            get
            {
                return (float) this.method_49(0x45);
            }
            set
            {
                this.method_50(0x45, value);
            }
        }

        internal float RightIndentChars
        {
            get
            {
                return (float) this.method_49(0x483);
            }
            set
            {
                this.method_50(0x483, value);
            }
        }

        internal float RightIndentEx
        {
            get
            {
                if (!this.HasValue(0x483))
                {
                    return this.RightIndent;
                }
                return this.RightIndentChars;
            }
        }

        internal Class16 Shading
        {
            get
            {
                return (Class16) this.method_49(0x5b4);
            }
        }

        internal bool SnapToGrid
        {
            get
            {
                return (bool) this.method_49(0x4ec);
            }
            set
            {
                this.method_50(0x4ec, value);
            }
        }

        internal float SpacingAfterChar
        {
            get
            {
                return (float) this.method_49(0x4c9);
            }
            set
            {
                this.method_50(0x4c9, value);
            }
        }

        internal float SpacingBeforeChar
        {
            get
            {
                return (float) this.method_49(0x4b5);
            }
            set
            {
                this.method_50(0x4b5, value);
            }
        }

        public bool SuppressAutoHyphens
        {
            get
            {
                return (bool) this.method_49(0x582);
            }
            set
            {
                this.method_50(0x582, value);
            }
        }

        internal bool SuppressLineNumbers
        {
            get
            {
                return (bool) this.method_49(0x46a);
            }
            set
            {
                this.method_50(0x46a, value);
            }
        }

        internal ParagraphFormat TableStyleParagraphFormat
        {
            get
            {
                return this.paragraphFormat_0;
            }
            set
            {
                this.paragraphFormat_0 = value;
            }
        }

        public TabCollection Tabs
        {
            get
            {
                if (!base.HasKey(0x474))
                {
                    this.method_53();
                }
                return (TabCollection) this.method_49(0x474);
            }
        }

        internal TabCollection TabsEx
        {
            get
            {
                TabCollection tabs = new TabCollection(base.Document);
                this.method_62(this, ref tabs);
                return tabs;
            }
        }

        public Spire.Doc.Documents.TextAlignment TextAlignment
        {
            get
            {
                return (Spire.Doc.Documents.TextAlignment) this.method_49(0x5e6);
            }
            set
            {
                this.method_50(0x5e6, value);
            }
        }

        internal Spire.Doc.TextureStyle TextureStyle
        {
            get
            {
                return this.Shading.method_62();
            }
            set
            {
                this.Shading.method_63(value);
            }
        }

        internal bool TopLinePunctuation
        {
            get
            {
                return (bool) this.method_49(0x44c);
            }
            set
            {
                this.method_50(0x44c, value);
            }
        }

        internal bool WordWrap
        {
            get
            {
                return (bool) this.method_49(0x438);
            }
            set
            {
                this.method_50(0x438, value);
            }
        }

        internal bool WrapFrameAround
        {
            get
            {
                if (!this.Frame.method_112())
                {
                    return (this.DropCapPosition != Spire.Doc.DropCapPosition.None);
                }
                return true;
            }
            set
            {
                this.Frame.method_113(value);
            }
        }
    }
}

