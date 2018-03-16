namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;

    public class CharacterFormat : WordAttrCollection
    {
        private bool bool_2;
        internal bool bool_3;
        internal bool bool_4;
        private bool bool_5;
        internal const byte byte_3 = 0x81;
        internal const byte byte_4 = 0x80;
        private CharacterFormat characterFormat_0;
        private Class327 class327_0;
        protected const float DEF_FONTSIZE = 10f;
        private System.Drawing.Font font_0;
        internal const int int_8 = 780;
        private long long_3;
        protected string m_charStyleName;
        private System.Drawing.FontStyle? nullable_0;
        internal const short short_0 = 0;
        internal const short short_1 = 160;
        internal const short short_10 = 310;
        internal const short short_11 = 770;
        internal const short short_12 = 9;
        internal const short short_13 = 210;
        internal const short short_14 = 300;
        internal const short short_15 = 200;
        internal const short short_16 = 150;
        internal const short short_17 = 0x3f;
        internal const short short_18 = 100;
        internal const short short_19 = 170;
        internal const short short_2 = 2;
        internal const short short_20 = 180;
        internal const short short_21 = 130;
        internal const short short_22 = 120;
        internal const short short_23 = 110;
        internal const short short_24 = 370;
        internal const short short_25 = 0x109;
        internal const short short_26 = 250;
        internal const short short_27 = 260;
        internal const short short_28 = 270;
        internal const short short_29 = 350;
        internal const short short_3 = 190;
        internal const short short_30 = 20;
        internal const short short_31 = 360;
        internal const short short_32 = 230;
        internal const short short_33 = 0xeb;
        internal const short short_34 = 240;
        internal const short short_35 = 90;
        internal const short short_36 = 400;
        internal const short short_37 = 380;
        internal const short short_38 = 390;
        internal const short short_39 = 0x4b;
        internal const short short_4 = 60;
        internal const short short_40 = 0x4c;
        internal const short short_41 = 0x4d;
        internal const short short_42 = 340;
        internal const short short_43 = 440;
        internal const short short_44 = 6;
        internal const short short_45 = 0x51;
        internal const short short_46 = 0x84;
        internal const short short_47 = 0x6d;
        internal const short short_48 = 0x37;
        internal const short short_49 = 0x6f;
        internal const short short_5 = 70;
        internal const short short_50 = 0x10c;
        internal const short short_51 = 0x41;
        internal const short short_52 = 0x40;
        internal const short short_53 = 0x42;
        internal const short short_54 = 0x52;
        internal const short short_55 = 0x53;
        internal const short short_56 = 0x54;
        internal const short short_57 = 0x55;
        internal const short short_58 = 0x56;
        internal const short short_59 = 0x57;
        internal const short short_6 = 80;
        internal const short short_60 = 0x58;
        internal const short short_61 = 0x59;
        internal const short short_62 = 0x14c;
        internal const short short_63 = 0x65;
        internal const short short_64 = 0x66;
        internal const short short_65 = 0x67;
        internal const short short_66 = 0x68;
        internal const short short_67 = 0x69;
        internal const short short_68 = 0x6a;
        internal const short short_69 = 480;
        internal const short short_7 = 140;
        internal const short short_70 = 0x6c;
        internal const short short_71 = 0x36;
        internal const short short_72 = 0x79;
        internal const short short_73 = 0x7a;
        internal const short short_74 = 0x7b;
        internal const short short_75 = 0x7c;
        internal const short short_76 = 530;
        internal const short short_77 = 550;
        internal const short short_78 = 540;
        internal const short short_79 = 560;
        internal const short short_8 = 450;
        internal const short short_80 = 330;
        internal const short short_81 = 290;
        internal const short short_82 = 50;
        internal const short short_83 = 0x14d;
        internal const short short_84 = 0x14e;
        internal const short short_9 = 220;
        internal const string string_3 = "Times New Roman";
        private string string_4;
        private string string_5;

        internal CharacterFormat()
        {
        }

        public CharacterFormat(IDocument doc) : base(doc)
        {
        }

        internal override void AcceptChanges()
        {
            base[0x68] = false;
            base[0x67] = false;
            base[0x69] = false;
            base.AcceptChanges();
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
            if ((base.Document.bool_5 && (base.Document != baseFormat.Document)) && !baseFormat.Document.ImportStyles)
            {
                List<int> list = new List<int>(new int[] { 
                    0x6d, 0x10c, 60, 70, 80, 300, 100, 170, 180, 130, 120, 110, 0x109, 250, 260, 400, 
                    90, 0x6a
                 });
                foreach (int num in list)
                {
                    if (this.HasValue(num))
                    {
                        dictionary.Add(num, this.method_62((short) num));
                    }
                }
                list.Clear();
            }
            base.ApplyBase(baseFormat);
            using (Dictionary<int, bool>.Enumerator enumerator = dictionary.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<int, bool> current = enumerator.Current;
                }
            }
            dictionary.Clear();
            bool flag1 = base.Document.bool_3;
            this.method_75();
        }

        internal override void ApplyProperty()
        {
            int num = 0x12;
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(CharacterFormat);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                if (info.FieldType.Name == BookmarkStart.b("焷吹䠻༽瘿", num))
                {
                    int propertyKey = (short) info.GetValue(info.FieldType);
                    if (this.HasValue(propertyKey))
                    {
                        this.method_52(propertyKey);
                    }
                }
            }
        }

        internal override void Close()
        {
            base.Close();
            if (this.characterFormat_0 != null)
            {
                this.characterFormat_0.Close();
                this.characterFormat_0 = null;
            }
            if (this.font_0 != null)
            {
                this.font_0.Dispose();
                this.font_0 = null;
            }
        }

        protected override void CreateFormatLayoutInfo()
        {
            base.interface45_0 = new Class560(this);
        }

        protected override FormatBase GetDefComposite(int key)
        {
            int num = key;
            if (num == 360)
            {
                return base.GetDefComposite(360, new Spire.Doc.Formatting.Border(this, 360));
            }
            if (num != 370)
            {
                return null;
            }
            return base.GetDefComposite(370, new Class16(this, 370));
        }

        protected override object GetDefValue(int key)
        {
            int num = 2;
            if (((base.m_doc.DefCharFormat != null) && (base.m_doc.DefCharFormat != this)) && base.m_doc.DefCharFormat.HasKey(key))
            {
                return base.m_doc.DefCharFormat[key];
            }
            int num2 = key;
            if (num2 > 200)
            {
                if (num2 <= 290)
                {
                    if (num2 <= 240)
                    {
                        if (num2 > 220)
                        {
                            switch (num2)
                            {
                                case 230:
                                    goto Label_039F;

                                case 0xeb:
                                    if (!string.IsNullOrEmpty(base.m_doc.StandardFarEastFont))
                                    {
                                        return base.m_doc.StandardFarEastFont;
                                    }
                                    if (!string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_2()))
                                    {
                                        return base.m_doc.DefaultFontNameTable.method_2();
                                    }
                                    return BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num);

                                case 240:
                                    if (!string.IsNullOrEmpty(base.m_doc.StandardNonFarEastFont))
                                    {
                                        return base.m_doc.StandardNonFarEastFont;
                                    }
                                    if (!string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_4()))
                                    {
                                        return base.m_doc.DefaultFontNameTable.method_4();
                                    }
                                    return BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num);
                            }
                        }
                        else
                        {
                            switch (num2)
                            {
                                case 210:
                                    return Spire.Doc.Documents.SubSuperScript.None;

                                case 220:
                                    return 0f;
                            }
                        }
                    }
                    else
                    {
                        switch (num2)
                        {
                            case 250:
                            case 260:
                            case 0x10c:
                            case 0x109:
                                goto Label_0573;

                            case 270:
                                if (string.IsNullOrEmpty(base.m_doc.StandardBidiFont))
                                {
                                    if (!string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_6()))
                                    {
                                        return base.m_doc.DefaultFontNameTable.method_6();
                                    }
                                    return BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num);
                                }
                                return base.m_doc.StandardBidiFont;

                            case 290:
                                return (short) 100;
                        }
                    }
                }
                else if (num2 <= 380)
                {
                    switch (num2)
                    {
                        case 340:
                            goto Label_050C;

                        case 350:
                            goto Label_0501;

                        case 380:
                            goto Label_0538;

                        case 330:
                            return true;

                        case 0x14c:
                            goto Label_0568;

                        case 0x14d:
                            return string.Empty;

                        case 300:
                            goto Label_0573;
                    }
                }
                else
                {
                    if (num2 <= 400)
                    {
                        if (num2 == 390)
                        {
                            goto Label_0538;
                        }
                        if (num2 != 400)
                        {
                            goto Label_055B;
                        }
                        goto Label_0531;
                    }
                    switch (num2)
                    {
                        case 440:
                            goto Label_0573;

                        case 450:
                            goto Label_0568;

                        case 480:
                            return 0x7fffffff;
                    }
                }
                goto Label_055B;
            }
            if (num2 > 0x51)
            {
                switch (num2)
                {
                    case 130:
                    case 0x84:
                    case 100:
                    case 0x6a:
                    case 0x6d:
                    case 110:
                    case 120:
                    case 90:
                    case 170:
                    case 180:
                        goto Label_0573;

                    case 140:
                        return Spire.Doc.Documents.UnderlineStyle.None;

                    case 150:
                    case 200:
                        return 0f;

                    case 0x67:
                    case 0x68:
                    case 0x69:
                    case 0x6c:
                        goto Label_0531;

                    case 0x6f:
                        return 0;

                    case 0x79:
                        return LigatureType.None;

                    case 0x7a:
                        return Spire.Doc.Documents.NumberFormType.Default;

                    case 0x7b:
                        return Spire.Doc.Documents.NumberSpaceType.Default;

                    case 0x7c:
                        return Spire.Doc.Documents.StylisticSetType.Default;

                    case 160:
                        goto Label_0568;

                    case 190:
                        goto Label_0501;
                }
                goto Label_055B;
            }
            if (num2 > 20)
            {
                switch (num2)
                {
                    case 0x2d:
                        return LineBreakClear.None;

                    case 50:
                        return 10;

                    case 0x36:
                    case 0x3f:
                        goto Label_0531;

                    case 0x37:
                        return (byte) 0;

                    case 60:
                    case 70:
                    case 80:
                        goto Label_0573;

                    case 0x40:
                    case 0x41:
                    case 0x42:
                        return (byte) 0;

                    case 0x4b:
                    case 0x4c:
                    case 0x4d:
                        goto Label_050C;

                    case 0x51:
                        return Spire.Doc.TextureStyle.TextureNone;
                }
                goto Label_055B;
            }
            if (num2 <= 6)
            {
                switch (num2)
                {
                    case 0:
                        return new System.Drawing.Font(BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num), 10f);

                    case 2:
                        goto Label_039F;

                    case 6:
                        goto Label_00A4;
                }
                goto Label_055B;
            }
            if (num2 == 9)
            {
                return Color.White;
            }
            if (num2 != 20)
            {
                goto Label_055B;
            }
        Label_00A4:
            return Color.White;
        Label_039F:
            if (!string.IsNullOrEmpty(base.m_doc.StandardAsciiFont))
            {
                return base.m_doc.StandardAsciiFont;
            }
            if (!string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_0()))
            {
                return base.m_doc.DefaultFontNameTable.method_0();
            }
            return BookmarkStart.b("簧䌩䄫䬭䌯ሱ稳匵伷ᨹ渻儽ⴿ⍁⩃", num);
        Label_0501:
            return 10f;
        Label_050C:
            return (short) 0x7fff;
        Label_0531:
            return false;
        Label_0538:
            return (short) 0x409;
        Label_055B:
            return null;
        Label_0568:
            return Color.Empty;
        Label_0573:
            return Class650.class650_0;
        }

        internal override int GetFullKey(int key)
        {
            int num = key;
            switch (num)
            {
                case 6:
                    return this.Shading.GetFullKey(2);

                case 9:
                    return this.Shading.GetFullKey(3);
            }
            if (num != 0x51)
            {
                return base.GetFullKey(key);
            }
            return this.Shading.GetFullKey(1);
        }

        protected override int GetSprmOption(int propertyKey)
        {
            int num = propertyKey;
            if (num > 0xeb)
            {
                if (num > 0x14c)
                {
                    switch (num)
                    {
                        case 360:
                            return 0x6865;

                        case 380:
                            return 0x486d;

                        case 390:
                            return 0x486e;

                        case 340:
                            return 0x485f;

                        case 350:
                            return 0x4a61;

                        case 400:
                            return 0x286f;

                        case 440:
                            return 0x875;

                        case 450:
                            return 0x6877;

                        case 480:
                            return 0x6887;

                        case 770:
                            return 0x2a34;
                    }
                }
                else if (num <= 0x109)
                {
                    if (num > 250)
                    {
                        if (num == 260)
                        {
                            return 0x85d;
                        }
                        if (num == 0x109)
                        {
                            return 0x85a;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 240:
                                return 0x4a51;

                            case 250:
                                return 0x85c;
                        }
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x10c:
                            return 0x882;

                        case 270:
                            return 0x4a5e;

                        case 290:
                            return 0x4852;

                        case 330:
                            return 0x868;

                        case 0x14c:
                            goto Label_0375;

                        case 310:
                            return 0x2859;

                        case 300:
                            goto Label_0381;
                    }
                }
            }
            else
            {
                if (num > 150)
                {
                    if (num > 190)
                    {
                        if (num > 210)
                        {
                            switch (num)
                            {
                                case 220:
                                    return 0x484b;

                                case 230:
                                    goto Label_029A;

                                case 0xeb:
                                    return 0x4a50;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 200:
                                    return 0x4845;

                                case 210:
                                    return 0x2a48;
                            }
                        }
                        goto Label_041F;
                    }
                    if (num > 170)
                    {
                        if (num == 180)
                        {
                            goto Label_0248;
                        }
                        if (num == 190)
                        {
                            return 0x4a43;
                        }
                        goto Label_041F;
                    }
                    if (num == 160)
                    {
                        return 0x2a42;
                    }
                    if (num != 170)
                    {
                        goto Label_041F;
                    }
                    goto Label_0221;
                }
                if (num <= 20)
                {
                    if (num > 6)
                    {
                        if (num == 9)
                        {
                            goto Label_0169;
                        }
                        if (num == 20)
                        {
                            return 0x2a0c;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 2:
                                goto Label_029A;

                            case 6:
                                goto Label_0169;
                        }
                    }
                }
                else if (num > 120)
                {
                    switch (num)
                    {
                        case 130:
                            goto Label_01F0;

                        case 0x84:
                            return 0x876;

                        case 140:
                            return 0x2a3e;

                        case 150:
                            return 0x8840;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x37:
                        case 0x6d:
                            return 0x802;

                        case 60:
                        case 0x40:
                            return 0x835;

                        case 0x41:
                        case 70:
                            return 0x836;

                        case 0x42:
                            goto Label_01F0;

                        case 0x4b:
                            return 0x4873;

                        case 0x4c:
                            return 0x4874;

                        case 0x4d:
                            return 0x4a41;

                        case 80:
                        case 0x55:
                            return 0x837;

                        case 0x51:
                            goto Label_0169;

                        case 0x52:
                            goto Label_0248;

                        case 0x53:
                            goto Label_0221;

                        case 0x54:
                        case 100:
                            return 0x839;

                        case 0x56:
                        case 110:
                            return 0x83a;

                        case 0x57:
                            goto Label_0381;

                        case 0x58:
                        case 120:
                            return 0x83b;

                        case 0x59:
                            return 0x6870;

                        case 90:
                            return 0x838;

                        case 0x65:
                        case 0x66:
                            goto Label_0375;

                        case 0x67:
                            return 0x801;

                        case 0x68:
                            return 0x800;

                        case 0x69:
                            return 0xca57;

                        case 0x6c:
                            return 0x4888;

                        case 0x6f:
                            return 0x6a03;
                    }
                }
            }
            goto Label_041F;
        Label_0169:
            return 0x4866;
        Label_01F0:
            return 0x83c;
        Label_0221:
            return 0x858;
        Label_0248:
            return 0x854;
        Label_029A:
            return 0x4a4f;
        Label_0375:
            return 0xca71;
        Label_0381:
            return 0x2a53;
        Label_041F:
            return 0x7fffffff;
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasValue(propertyKey);
        }

        protected internal void ImportContainer(FormatBase format)
        {
            base.ImportContainer(format);
        }

        protected override void ImportMembers(FormatBase format)
        {
            base.ImportMembers(format);
            CharacterFormat format2 = format as CharacterFormat;
            if (format2 != null)
            {
                base.method_21(format2);
                string charStyleName = format2.CharStyleName;
                if (charStyleName != null)
                {
                    Document document = base.Document;
                    if (!(document.Styles.FindByName(charStyleName, StyleType.CharacterStyle) is Class11))
                    {
                        IStyle style = format2.Document.Styles.FindByName(charStyleName, StyleType.CharacterStyle);
                        if (style != null)
                        {
                            document.Styles.Add(style.Clone());
                        }
                    }
                    this.m_charStyleName = charStyleName;
                }
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("夬䨮䤰䜲ᠴ唶嘸䤺夼娾㍀", 7), this.Border);
        }

        private bool method_49()
        {
            bool flag = false;
            OwnerHolder ownerBase = base.OwnerBase;
            if ((ownerBase != null) && (ownerBase.OwnerBase is Paragraph))
            {
                Paragraph paragraph = ownerBase.OwnerBase as Paragraph;
                int index = paragraph.Items.IndexOf(ownerBase as IDocumentObject);
                if ((index < (paragraph.Items.Count - 1)) && (paragraph.Items[index + 1] is Break))
                {
                    Break @break = paragraph.Items[index + 1] as Break;
                    flag = @break.BreakType == BreakType.LineBreak;
                }
            }
            return flag;
        }

        private void method_50()
        {
            if (base.PropertiesHash.ContainsKey(560))
            {
                base.PropertiesHash.Remove(560);
            }
            if (base.PropertiesHash.ContainsKey(540))
            {
                base.PropertiesHash.Remove(540);
            }
            if (base.PropertiesHash.ContainsKey(550))
            {
                base.PropertiesHash.Remove(550);
            }
            if (base.PropertiesHash.ContainsKey(530))
            {
                base.PropertiesHash.Remove(530);
            }
        }

        private void method_51()
        {
            OwnerHolder ownerBase = base.OwnerBase;
            if ((ownerBase != null) && (ownerBase.OwnerBase is Paragraph))
            {
                Paragraph paragraph = ownerBase.OwnerBase as Paragraph;
                int index = paragraph.Items.IndexOf(ownerBase as IDocumentObject) + 1;
                paragraph.Items.Insert(index, new Break(paragraph.Document, BreakType.LineBreak));
            }
        }

        internal object method_52(int A_0)
        {
            return base[A_0];
        }

        internal bool method_53(short A_0)
        {
            bool flag = this.method_62(A_0);
            if ((this.characterFormat_0 != null) && this.characterFormat_0.method_53(A_0))
            {
                return !flag;
            }
            return flag;
        }

        private void method_54(int A_0, object A_1)
        {
            base[A_0] = A_1;
            this.OnStateChange(this);
            this.bool_5 = true;
        }

        internal void method_55(Color A_0)
        {
            this.method_54(160, A_0);
        }

        private void method_56(int A_0, bool A_1)
        {
            this.method_54(A_0, Class650.smethod_0(A_1));
        }

        private void method_57(int A_0)
        {
            if (!base.HasKey(A_0) || !base.IsPropertyUpdated(A_0))
            {
                base.SetPropUpdateFlag(A_0);
            }
        }

        internal void method_58(int A_0)
        {
            if (this.method_59(A_0))
            {
                if (base.HasKey(A_0) || base.IsPropertyUpdated(A_0))
                {
                }
            }
            else
            {
                this.method_57(A_0);
            }
        }

        private bool method_59(int A_0)
        {
            switch (A_0)
            {
                case 80:
                case 90:
                case 60:
                case 70:
                case 0x6a:
                case 0x6d:
                case 110:
                case 100:
                case 120:
                case 130:
                case 250:
                case 260:
                case 170:
                case 180:
                case 0x109:
                case 0x10c:
                case 300:
                case 400:
                    return true;
            }
            return false;
        }

        private bool method_60()
        {
            if (base.Document == null)
            {
                return false;
            }
            return true;
        }

        internal byte method_61(short A_0)
        {
            Class650 class2 = null;
            if (base.PropertiesHash.ContainsKey(A_0))
            {
                class2 = base.PropertiesHash[A_0] as Class650;
            }
            if (class2 != null)
            {
                return (byte) class2.method_0();
            }
            return 0xff;
        }

        internal bool method_62(short A_0)
        {
            byte num = this.method_61(A_0);
            if ((num == 0x81) && (base.BaseFormat != null))
            {
                return !this.method_64(this.m_charStyleName, base.BaseFormat as CharacterFormat, A_0);
            }
            if ((num == 0x80) && (base.BaseFormat != null))
            {
                return this.method_64(this.m_charStyleName, base.BaseFormat as CharacterFormat, A_0);
            }
            return (((num == 0x81) && (base.BaseFormat == null)) || ((num == 1) || (((num == 0xff) && (base.BaseFormat != null)) && this.method_64(this.m_charStyleName, base.BaseFormat as CharacterFormat, A_0))));
        }

        private byte method_63(CharacterFormat A_0, short A_1)
        {
            byte num = 0;
            if ((A_0 != null) && A_0.HasValue(A_1))
            {
                num = A_0.method_62(A_1) ? ((byte) 1) : ((byte) 0);
            }
            return num;
        }

        private bool method_64(string A_0, CharacterFormat A_1, short A_2)
        {
            byte num = 0;
            if (A_0 != null)
            {
                Class11 class2 = base.Document.Styles.FindByName(A_0, StyleType.CharacterStyle) as Class11;
                if (class2 != null)
                {
                    switch (this.method_63(class2.CharacterFormat, A_2))
                    {
                        case 0x81:
                        case 1:
                            return true;
                    }
                }
            }
            num = this.method_63(A_1, A_2);
            if (num != 0x81)
            {
                return (num == 1);
            }
            return true;
        }

        private CharacterFormat method_65(CharacterFormat A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            if (A_0.CharStyleName != null)
            {
                Class11 class2 = base.Document.Styles.FindByName(A_0.CharStyleName, StyleType.CharacterStyle) as Class11;
                if (class2 != null)
                {
                    return class2.CharacterFormat;
                }
            }
            return (A_0.BaseFormat as CharacterFormat);
        }

        internal void method_66()
        {
            if (!base.Document.bool_3 && !this.bool_4)
            {
                if (this.bool_3)
                {
                    this.bool_3 = false;
                }
                this.bool_4 = true;
            }
        }

        internal bool method_67(short A_0)
        {
            if (!this.HasValue(A_0))
            {
                return false;
            }
            if ((base[A_0] as Class650).method_0() < 0x80)
            {
                return false;
            }
            return true;
        }

        private Class11 method_68()
        {
            Class11 class2 = null;
            if ((!string.IsNullOrEmpty(this.m_charStyleName) && (base.Document != null)) && (base.Document.Styles != null))
            {
                class2 = base.Document.Styles.FindByName(this.m_charStyleName, StyleType.CharacterStyle) as Class11;
            }
            return class2;
        }

        internal string method_69(short A_0)
        {
            if (base.HasKey(A_0))
            {
                return (string) base[A_0];
            }
            return this.FontNameAscii;
        }

        private short method_70(short A_0)
        {
            if (!this.HasValue(A_0))
            {
                CharacterFormat format = ((this.CharStyle == null) || !this.CharStyle.CharacterFormat.HasValue(A_0)) ? (base.BaseFormat as CharacterFormat) : this.CharStyle.CharacterFormat;
                if (format != null)
                {
                    short num2 = A_0;
                    if (num2 != 380)
                    {
                        if ((num2 == 390) && format.HasValue(390))
                        {
                            short num = (short) format.method_52(390);
                            base[A_0] = num;
                        }
                    }
                    else if (format.HasValue(380))
                    {
                        base[A_0] = format.method_52(380);
                    }
                }
            }
            if (this.HasValue(A_0) && base.HasKey(A_0))
            {
                return (short) base[A_0];
            }
            return (short) this.method_52(A_0);
        }

        internal void method_71(CharacterFormat A_0)
        {
            if (base.m_doc.DefCharFormat != null)
            {
                foreach (KeyValuePair<int, object> pair in base.m_doc.DefCharFormat.PropertiesHash)
                {
                    if ((pair.Key != 360) && !A_0.method_72(pair.Key))
                    {
                        base.PropertiesHash.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        internal bool method_72(int A_0)
        {
            return ((this.HasValue(A_0) || ((this.CharStyle != null) && this.CharStyle.CharacterFormat.HasValue(A_0))) || ((base.BaseFormat != null) && (base.BaseFormat as CharacterFormat).method_72(A_0)));
        }

        internal void method_73(CharacterFormat A_0)
        {
            base.method_25(A_0);
            this.method_74(A_0);
        }

        internal void method_74(CharacterFormat A_0)
        {
            if (string.IsNullOrEmpty(this.m_charStyleName))
            {
                this.m_charStyleName = A_0.m_charStyleName;
            }
            if (string.IsNullOrEmpty(this.string_5))
            {
                this.string_5 = A_0.string_5;
            }
            if (this.characterFormat_0 == null)
            {
                this.characterFormat_0 = A_0.characterFormat_0;
            }
            if (this.class327_0 == null)
            {
                this.class327_0 = A_0.class327_0;
            }
        }

        private void method_75()
        {
            string str = this.HasValue(230) ? this.method_69(230) : null;
            if (!string.IsNullOrEmpty(str))
            {
                System.Drawing.FontStyle regular = System.Drawing.FontStyle.Regular;
                if (this.HasValue(60) && this.Bold)
                {
                    regular |= System.Drawing.FontStyle.Bold;
                }
                if (this.HasValue(70) && this.Italic)
                {
                    regular |= System.Drawing.FontStyle.Italic;
                }
                if (this.HasValue(140) && (this.UnderlineStyle != Spire.Doc.Documents.UnderlineStyle.None))
                {
                    regular |= System.Drawing.FontStyle.Underline;
                }
                if (this.HasValue(80) && this.IsStrikeout)
                {
                    regular |= System.Drawing.FontStyle.Strikeout;
                }
                System.Drawing.Font item = Class58.smethod_1(str, 11f, regular);
                if (!base.m_doc.UsedFontNames.Contains(item))
                {
                    base.m_doc.UsedFontNames.Add(item);
                }
            }
        }

        private void method_76(IXDLSAttributeWriter A_0, int A_1, string A_2)
        {
            this.GetSprmOption(A_1);
        }

        internal void method_77(CharacterFormat A_0)
        {
            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            if (this.Bidi)
            {
                dictionary.Add(0x109, true);
            }
            if (this.Bold)
            {
                dictionary.Add(60, true);
            }
            if (this.BoldBidi)
            {
                dictionary.Add(250, true);
            }
            if (this.ComplexScript)
            {
                dictionary.Add(0x10c, true);
            }
            if (this.Hidden)
            {
                dictionary.Add(130, true);
            }
            if (this.Italic)
            {
                dictionary.Add(70, true);
            }
            if (this.ItalicBidi)
            {
                dictionary.Add(260, true);
            }
            if (this.SubSuperScript != Spire.Doc.Documents.SubSuperScript.None)
            {
                dictionary.Add(210, this.SubSuperScript);
            }
            if (this.UnderlineStyle != Spire.Doc.Documents.UnderlineStyle.None)
            {
                dictionary.Add(140, this.UnderlineStyle);
            }
            dictionary.Add(380, this.LocaleIdASCII);
            dictionary.Add(390, this.LocaleIdFarEast);
            this.CharStyleName = null;
            this.ImportContainer(A_0);
            base.method_21(A_0);
            this.ApplyBase(A_0.BaseFormat);
            this.method_78(dictionary);
            dictionary.Clear();
        }

        private void method_78(Dictionary<int, object> A_0)
        {
            foreach (KeyValuePair<int, object> pair in A_0)
            {
                int key = pair.Key;
                if (key <= 210)
                {
                    if (key <= 70)
                    {
                        if (key == 60)
                        {
                            if (this.Bold != ((bool) pair.Value))
                            {
                                this.Bold = (bool) pair.Value;
                            }
                        }
                        else if ((key == 70) && (this.Italic != ((bool) pair.Value)))
                        {
                            this.Italic = (bool) pair.Value;
                        }
                    }
                    else
                    {
                        switch (key)
                        {
                            case 130:
                            {
                                if (this.Hidden != ((bool) pair.Value))
                                {
                                    this.Hidden = (bool) pair.Value;
                                }
                                continue;
                            }
                            case 140:
                            {
                                if (this.UnderlineStyle != ((Spire.Doc.Documents.UnderlineStyle) pair.Value))
                                {
                                    this.UnderlineStyle = (Spire.Doc.Documents.UnderlineStyle) pair.Value;
                                }
                                continue;
                            }
                        }
                        if ((key == 210) && (this.SubSuperScript != ((Spire.Doc.Documents.SubSuperScript) pair.Value)))
                        {
                            this.SubSuperScript = (Spire.Doc.Documents.SubSuperScript) pair.Value;
                        }
                    }
                }
                else if (key <= 0x109)
                {
                    switch (key)
                    {
                        case 250:
                        {
                            if (this.BoldBidi != ((bool) pair.Value))
                            {
                                this.BoldBidi = (bool) pair.Value;
                            }
                            continue;
                        }
                        case 260:
                        {
                            if (this.ItalicBidi != ((bool) pair.Value))
                            {
                                this.ItalicBidi = (bool) pair.Value;
                            }
                            continue;
                        }
                    }
                    if ((key == 0x109) && (this.Bidi != ((bool) pair.Value)))
                    {
                        this.Bidi = (bool) pair.Value;
                    }
                }
                else
                {
                    switch (key)
                    {
                        case 0x10c:
                        {
                            if (this.ComplexScript != ((bool) pair.Value))
                            {
                                this.ComplexScript = (bool) pair.Value;
                            }
                            continue;
                        }
                        case 380:
                        {
                            if (this.LocaleIdASCII != ((short) pair.Value))
                            {
                                this.LocaleIdASCII = (short) pair.Value;
                            }
                            continue;
                        }
                    }
                    if ((key == 390) && (this.LocaleIdFarEast != ((short) pair.Value)))
                    {
                        this.LocaleIdFarEast = (short) pair.Value;
                    }
                }
            }
        }

        internal void method_79(CharacterFormat A_0)
        {
            CharacterFormat format = new CharacterFormat(A_0.Document);
            format.ImportContainer(this);
            format.method_21(this);
            format.ApplyBase(A_0);
            format.CharStyleName = null;
            this.method_80(format);
            this.ImportContainer(format);
            base.method_21(format);
            format.Close();
        }

        private void method_80(CharacterFormat A_0)
        {
            if (A_0.AllCaps != this.AllCaps)
            {
                A_0.AllCaps = this.AllCaps;
            }
            if (A_0.Bidi != this.Bidi)
            {
                A_0.Bidi = this.Bidi;
            }
            if (A_0.Bold != this.Bold)
            {
                A_0.Bold = this.Bold;
            }
            if (A_0.BoldBidi != this.BoldBidi)
            {
                A_0.BoldBidi = this.BoldBidi;
            }
            if (A_0.CharacterSpacing != this.CharacterSpacing)
            {
                A_0.CharacterSpacing = this.CharacterSpacing;
            }
            if (A_0.ComplexScript != this.ComplexScript)
            {
                A_0.ComplexScript = this.ComplexScript;
            }
            if (A_0.DoubleStrike != this.DoubleStrike)
            {
                A_0.DoubleStrike = this.DoubleStrike;
            }
            if (A_0.Emboss != this.Emboss)
            {
                A_0.Emboss = this.Emboss;
            }
            if (A_0.Engrave != this.Engrave)
            {
                A_0.Engrave = this.Engrave;
            }
            if (A_0.FieldVanish != this.FieldVanish)
            {
                A_0.FieldVanish = this.FieldVanish;
            }
            if (A_0.FieldVanishComplex != this.FieldVanishComplex)
            {
                A_0.FieldVanishComplex = this.FieldVanishComplex;
            }
            if (A_0.FontName != this.FontName)
            {
                A_0.FontName = this.FontName;
            }
            if (A_0.FontNameAscii != this.FontNameAscii)
            {
                A_0.FontNameAscii = this.FontNameAscii;
            }
            if (A_0.FontNameBidi != this.FontNameBidi)
            {
                A_0.FontNameBidi = this.FontNameBidi;
            }
            if (A_0.FontNameFarEast != this.FontNameFarEast)
            {
                A_0.FontNameFarEast = this.FontNameFarEast;
            }
            if (A_0.FontNameNonFarEast != this.FontNameNonFarEast)
            {
                A_0.FontNameNonFarEast = this.FontNameNonFarEast;
            }
            if (A_0.FontSize != this.FontSize)
            {
                A_0.FontSize = this.FontSize;
            }
            if (A_0.FontSizeBidi != this.FontSizeBidi)
            {
                A_0.FontSizeBidi = this.FontSizeBidi;
            }
            if (A_0.ForeColor != this.ForeColor)
            {
                A_0.ForeColor = this.ForeColor;
            }
            if (A_0.Hidden != this.Hidden)
            {
                A_0.Hidden = this.Hidden;
            }
            if (A_0.HighlightColor != this.HighlightColor)
            {
                A_0.HighlightColor = this.HighlightColor;
            }
            if (A_0.IdctHint != this.IdctHint)
            {
                A_0.IdctHint = this.IdctHint;
            }
            if (A_0.Italic != this.Italic)
            {
                A_0.Italic = this.Italic;
            }
            if (A_0.ItalicBidi != this.ItalicBidi)
            {
                A_0.ItalicBidi = this.ItalicBidi;
            }
            if (A_0.Lid != this.Lid)
            {
                A_0.Lid = this.Lid;
            }
            if (A_0.LocaleIdBi != this.LocaleIdBi)
            {
                A_0.LocaleIdBi = this.LocaleIdBi;
            }
            if (A_0.LigaturesType != this.LigaturesType)
            {
                A_0.LigaturesType = this.LigaturesType;
            }
            if (A_0.LineBreak != this.LineBreak)
            {
                A_0.LineBreak = this.LineBreak;
            }
            if (A_0.LocaleIdASCII != this.LocaleIdASCII)
            {
                A_0.LocaleIdASCII = this.LocaleIdASCII;
            }
            if (A_0.LocaleIdFarEast != this.LocaleIdFarEast)
            {
                A_0.LocaleIdFarEast = this.LocaleIdFarEast;
            }
            if (A_0.IsNoProof != this.IsNoProof)
            {
                A_0.IsNoProof = this.IsNoProof;
            }
            if (A_0.NumberFormType != this.NumberFormType)
            {
                A_0.NumberFormType = this.NumberFormType;
            }
            if (A_0.NumberSpaceType != this.NumberSpaceType)
            {
                A_0.NumberSpaceType = this.NumberSpaceType;
            }
            if (A_0.IsOutLine != this.IsOutLine)
            {
                A_0.IsOutLine = this.IsOutLine;
            }
            if (A_0.PicLocation != this.PicLocation)
            {
                A_0.PicLocation = this.PicLocation;
            }
            if (A_0.Position != this.Position)
            {
                A_0.Position = this.Position;
            }
            if (A_0.RgLid3 != this.RgLid3)
            {
                A_0.RgLid3 = this.RgLid3;
            }
            if (A_0.RgLid3_2 != this.RgLid3_2)
            {
                A_0.RgLid3_2 = this.RgLid3_2;
            }
            if (A_0.IsShadow != this.IsShadow)
            {
                A_0.IsShadow = this.IsShadow;
            }
            if (A_0.IsSmallCaps != this.IsSmallCaps)
            {
                A_0.IsSmallCaps = this.IsSmallCaps;
            }
            if (A_0.IsSpecial != this.IsSpecial)
            {
                A_0.IsSpecial = this.IsSpecial;
            }
            if (A_0.IsStrikeout != this.IsStrikeout)
            {
                A_0.IsStrikeout = this.IsStrikeout;
            }
            if (A_0.StylisticSetType != this.StylisticSetType)
            {
                A_0.StylisticSetType = this.StylisticSetType;
            }
            if (A_0.SubSuperScript != this.SubSuperScript)
            {
                A_0.SubSuperScript = this.SubSuperScript;
            }
            if (A_0.TextBackgroundColor != this.TextBackgroundColor)
            {
                A_0.TextBackgroundColor = this.TextBackgroundColor;
            }
            if (A_0.TextColor != this.TextColor)
            {
                A_0.method_55(this.TextColor);
            }
            if (A_0.TextureStyle != this.TextureStyle)
            {
                A_0.TextureStyle = this.TextureStyle;
            }
            if (A_0.UnderlineStyle != this.UnderlineStyle)
            {
                A_0.UnderlineStyle = this.UnderlineStyle;
            }
            if (A_0.AllowContextualAlternates != this.AllowContextualAlternates)
            {
                A_0.AllowContextualAlternates = this.AllowContextualAlternates;
            }
            if (A_0.TextScale != this.TextScale)
            {
                A_0.TextScale = this.TextScale;
            }
            if (A_0.SnapToGrid != this.SnapToGrid)
            {
                A_0.SnapToGrid = this.SnapToGrid;
            }
            this.Border.method_56(A_0.Border);
        }

        protected override void OnChange(FormatBase format, int propKey)
        {
            if (!this.bool_2 && ((base.OwnerBase == null) || !base.OwnerBase.Document.bool_3))
            {
                if ((((propKey == 2) || (propKey == 230)) || ((propKey == 190) || (propKey == 60))) || (((propKey == 70) || (propKey == 140)) || ((propKey == 80) || (propKey == 300))))
                {
                    this.bool_5 = true;
                }
                if (((base.OwnerBase != null) && (base.OwnerBase is Field)) && ((base.OwnerBase as Field).Range.Count > 0))
                {
                    foreach (object obj2 in (base.OwnerBase as Field).Range)
                    {
                        if (obj2 is ParagraphBase)
                        {
                            (obj2 as ParagraphBase).CharacterFormat.method_22(format, propKey);
                        }
                    }
                }
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 12;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷琹崻匽┿", 12)))
            {
                base[2] = reader.ReadString(BookmarkStart.b("琱嬳堵䰷琹崻匽┿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷琹崻匽┿Aⵃ≅ⅇ", num)))
            {
                base[270] = reader.ReadString(BookmarkStart.b("琱嬳堵䰷琹崻匽┿Aⵃ≅ⅇ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷琹崻匽┿́㝃╅ⅇ⍉", num)))
            {
                base[230] = reader.ReadString(BookmarkStart.b("琱嬳堵䰷琹崻匽┿́㝃╅ⅇ⍉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷琹崻匽┿с╃㑅േ⭉㽋㩍", num)))
            {
                base[0xeb] = reader.ReadString(BookmarkStart.b("琱嬳堵䰷琹崻匽┿с╃㑅േ⭉㽋㩍", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷琹崻匽┿ు⭃⡅็⭉㹋୍ㅏ⅑⁓", num)))
            {
                base[240] = reader.ReadString(BookmarkStart.b("琱嬳堵䰷琹崻匽┿ు⭃⡅็⭉㹋୍ㅏ⅑⁓", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("焱尳圵䨷椹䠻䜽ⰿ❁੃❅╇⽉", num)))
            {
                this.m_charStyleName = reader.ReadString(BookmarkStart.b("焱尳圵䨷椹䠻䜽ⰿ❁੃❅╇⽉", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("朱娳刵崷䠹倻圽⸿❁", num)))
            {
                this.UnderlineStyle = (Spire.Doc.Documents.UnderlineStyle) reader.ReadEnum(BookmarkStart.b("朱娳刵崷䠹倻圽⸿❁", num), typeof(Spire.Doc.Documents.UnderlineStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("昱儳丵䰷礹医刽⼿ぁ", num)))
            {
                this.method_55(reader.ReadColor(BookmarkStart.b("昱儳丵䰷礹医刽⼿ぁ", num)));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷椹唻䐽┿", num)))
            {
                this.FontSize = reader.ReadFloat(BookmarkStart.b("琱嬳堵䰷椹唻䐽┿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀱嬳娵尷", num)))
            {
                this.Bold = reader.ReadBoolean(BookmarkStart.b("瀱嬳娵尷", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䀳圵吷匹弻", num)))
            {
                this.Italic = reader.ReadBoolean(BookmarkStart.b("笱䀳圵吷匹弻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("愱䀳䐵儷儹夻", num)))
            {
                this.IsStrikeout = reader.ReadBoolean(BookmarkStart.b("愱䀳䐵儷儹夻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瘱嬳䌵娷嘹夻洽㐿ぁⵃⵅⵇ", num)))
            {
                this.DoubleStrike = reader.ReadBoolean(BookmarkStart.b("瘱嬳䌵娷嘹夻洽㐿ぁⵃⵅⵇ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縱崳堵崷椹䰻弽⌿⭁⩃ⅅ", num)))
            {
                this.CharacterSpacing = reader.ReadFloat(BookmarkStart.b("縱崳堵崷椹䰻弽⌿⭁⩃ⅅ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("戱嬳䔵儷丹唻儽⸿", num)))
            {
                this.Position = reader.ReadFloat(BookmarkStart.b("戱嬳䔵儷丹唻儽⸿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("愱䄳吵欷伹䰻嬽㈿ᅁ❃㑅ⅇ㩉㡋", num)))
            {
                this.SubSuperScript = (Spire.Doc.Documents.SubSuperScript) reader.ReadEnum(BookmarkStart.b("愱䄳吵欷伹䰻嬽㈿ᅁ❃㑅ⅇ㩉㡋", num), typeof(Spire.Doc.Documents.SubSuperScript));
            }
            if (reader.HasAttribute(BookmarkStart.b("昱儳丵䰷砹崻崽⬿╁㙃⥅㵇⑉⡋്㽏㹑㭓⑕", num)))
            {
                this.TextBackgroundColor = reader.ReadColor(BookmarkStart.b("昱儳丵䰷砹崻崽⬿╁㙃⥅㵇⑉⡋്㽏㹑㭓⑕", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縱崳堵崷砹主嬽ℿ⥁", num)))
            {
                this.LineBreak = reader.ReadBoolean(BookmarkStart.b("縱崳堵崷砹主嬽ℿ⥁", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䜳攵倷嬹堻儽㜿", num)))
            {
                this.IsShadow = reader.ReadBoolean(BookmarkStart.b("笱䜳攵倷嬹堻儽㜿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("眱夳吵圷䤹伻", num)))
            {
                this.Emboss = reader.ReadBoolean(BookmarkStart.b("眱夳吵圷䤹伻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("眱娳儵䨷嬹䨻嬽", num)))
            {
                this.Engrave = reader.ReadBoolean(BookmarkStart.b("眱娳儵䨷嬹䨻嬽", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稱崳刵尷弹刻", num)))
            {
                this.Hidden = reader.ReadBoolean(BookmarkStart.b("稱崳刵尷弹刻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("猱堳娵笷嬹䰻䴽", num)))
            {
                this.AllCaps = reader.ReadBoolean(BookmarkStart.b("猱堳娵笷嬹䰻䴽", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䜳攵唷嬹倻刽̿⍁㑃㕅", num)))
            {
                this.IsSmallCaps = reader.ReadBoolean(BookmarkStart.b("笱䜳攵唷嬹倻刽̿⍁㑃㕅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䜳琵儷帹唻", num)))
            {
                this.Bidi = reader.ReadBoolean(BookmarkStart.b("笱䜳琵儷帹唻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("瀱嬳娵尷砹唻娽⤿", num)))
            {
                this.BoldBidi = reader.ReadBoolean(BookmarkStart.b("瀱嬳娵尷砹唻娽⤿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䀳圵吷匹弻簽⤿♁ⵃ", num)))
            {
                this.ItalicBidi = reader.ReadBoolean(BookmarkStart.b("笱䀳圵吷匹弻簽⤿♁ⵃ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳堵䰷椹唻䐽┿Aⵃ≅ⅇ", num)))
            {
                this.FontSizeBidi = reader.ReadFloat(BookmarkStart.b("琱嬳堵䰷椹唻䐽┿Aⵃ≅ⅇ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("稱崳儵倷嘹唻夽⠿㙁݃⥅⑇╉㹋", num)))
            {
                this.HighlightColor = reader.ReadColor(BookmarkStart.b("稱崳儵倷嘹唻夽⠿㙁݃⥅⑇╉㹋", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱倳唵䰷爹唻倽㐿", num)))
            {
                this.IdctHint = reader.ReadBoolean(BookmarkStart.b("笱倳唵䰷爹唻倽㐿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怱匳稵儷帹఻", num)))
            {
                this.LocaleIdASCII = reader.ReadShort(BookmarkStart.b("怱匳稵儷帹఻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怱匳稵儷帹഻", num)))
            {
                this.LocaleIdFarEast = reader.ReadShort(BookmarkStart.b("怱匳稵儷帹഻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怱匳稵儷帹༻", num)))
            {
                this.RgLid3 = reader.ReadShort(BookmarkStart.b("怱匳稵儷帹༻", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("怱匳稵儷帹༻愽爿", num)))
            {
                this.RgLid3_2 = reader.ReadShort(BookmarkStart.b("怱匳稵儷帹༻愽爿", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縱崳刵", num)))
            {
                this.Lid = reader.ReadShort(BookmarkStart.b("縱崳刵", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縱崳刵稷匹", num)))
            {
                this.LocaleIdBi = reader.ReadShort(BookmarkStart.b("縱崳刵稷匹", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䜳砵圷樹主儽⼿⑁", num)))
            {
                this.IsNoProof = reader.ReadBoolean(BookmarkStart.b("笱䜳砵圷樹主儽⼿⑁", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笱䜳愵崷堹琻圽␿♁⅃⡅", num)))
            {
                this.IsWebHidden = reader.ReadBoolean(BookmarkStart.b("笱䜳愵崷堹琻圽␿♁⅃⡅", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("琱嬳䐵崷礹医刽⼿ぁ", num)))
            {
                this.ForeColor = reader.ReadColor(BookmarkStart.b("琱嬳䐵崷礹医刽⼿ぁ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("昱儳丵䰷伹主嬽", num)))
            {
                this.TextureStyle = (Spire.Doc.TextureStyle) reader.ReadEnum(BookmarkStart.b("昱儳丵䰷伹主嬽", num), typeof(Spire.Doc.TextureStyle));
            }
            if (reader.HasAttribute(BookmarkStart.b("紱䄳䈵吷匹刻嬽", num)))
            {
                this.IsOutLine = reader.ReadBoolean(BookmarkStart.b("紱䄳䈵吷匹刻嬽", num));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("嬱娳䈵崷䠹刻弽ⰿ潁⁃❅㱇⭉", 12))
            {
                byte[] buffer = reader.ReadChildBinaryElement();
                Class140 class2 = new Class140(base.Document, base.Document.FontInfoList, null);
                class2.method_62(buffer, this, null, null);
                class2 = null;
                flag = true;
            }
            return flag;
        }

        internal override void Remove(int propKey)
        {
            base.Remove(propKey);
        }

        internal override void RemoveChanges()
        {
            this.method_66();
            base.RemoveChanges();
        }

        internal override void SetAttr(int propKey, object value)
        {
            this.method_54(propKey, value);
        }

        internal static void smethod_5(CharacterFormat A_0, CharacterFormat A_1)
        {
            if ((A_0 != null) && (A_1 != null))
            {
                if (A_0.HasValue(190))
                {
                    A_1.FontSize = A_0.FontSize;
                }
                if (A_0.HasValue(160))
                {
                    A_1.method_55(A_0.TextColor);
                }
                if (A_0.HasValue(2))
                {
                    A_1.FontName = A_0.FontName;
                }
                if (A_0.HasValue(60))
                {
                    A_1.Bold = A_0.Bold;
                }
                if (A_0.HasValue(70))
                {
                    A_1.Italic = A_0.Italic;
                }
                if (A_0.HasValue(140))
                {
                    A_1.UnderlineStyle = A_0.UnderlineStyle;
                }
                if (A_0.HasValue(20))
                {
                    A_1.HighlightColor = A_0.HighlightColor;
                }
                if (A_0.HasValue(100))
                {
                    A_1.IsShadow = A_0.IsShadow;
                }
                if (A_0.HasValue(150))
                {
                    A_1.CharacterSpacing = A_0.CharacterSpacing;
                }
                if (A_0.HasValue(200))
                {
                    A_1.Position = A_0.Position;
                }
                if (A_0.HasValue(300))
                {
                    A_1.DoubleStrike = A_0.DoubleStrike;
                }
                if (A_0.HasValue(170))
                {
                    A_1.Emboss = A_0.Emboss;
                }
                if (A_0.HasValue(180))
                {
                    A_1.Engrave = A_0.Engrave;
                }
                if (A_0.HasValue(210))
                {
                    A_1.SubSuperScript = A_0.SubSuperScript;
                }
                if (A_0.HasValue(9))
                {
                    A_1.TextBackgroundColor = A_0.TextBackgroundColor;
                }
                if (A_0.HasValue(120))
                {
                    A_1.AllCaps = A_0.AllCaps;
                }
                if (A_0.Bidi)
                {
                    A_1.Bidi = true;
                    A_1.FontNameBidi = A_0.FontNameBidi;
                    A_1.FontSizeBidi = A_0.FontSizeBidi;
                    A_1.BoldBidi = A_0.BoldBidi;
                }
                if (A_0.HasValue(0x6d))
                {
                    A_1.FieldVanish = A_0.FieldVanish;
                }
                if (A_0.HasValue(130))
                {
                    A_1.Hidden = A_0.Hidden;
                }
                if (A_0.HasValue(110))
                {
                    A_1.IsSmallCaps = A_0.IsSmallCaps;
                }
                if (A_0.HasValue(290))
                {
                    A_1.TextScale = A_0.TextScale;
                }
                if (A_0.HasValue(330))
                {
                    A_1.SnapToGrid = A_0.SnapToGrid;
                }
                if (A_0.HasValue(400))
                {
                    A_1.FontTypeHint = A_0.FontTypeHint;
                }
                if (A_0.HasValue(380))
                {
                    A_1.LocaleIdASCII = A_0.LocaleIdASCII;
                }
                if (A_0.HasValue(390))
                {
                    A_1.LocaleIdFarEast = A_0.LocaleIdFarEast;
                }
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 2;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(2))
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䈫娭縯匱夳匵", num), this.FontName);
            }
            if (base.HasKey(270))
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䈫娭縯匱夳匵稷匹堻圽", num), this.FontNameBidi);
            }
            if (base.HasKey(0xeb))
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䈫娭縯匱夳匵縷嬹主笽ℿㅁぃ", num), this.FontNameFarEast);
            }
            if (base.HasKey(240))
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䈫娭縯匱夳匵瘷唹刻砽ℿぁŃ❅㭇㹉", num), this.FontNameNonFarEast);
            }
            if (base.HasKey(230))
            {
                writer.WriteValue(BookmarkStart.b("渧䔩䈫娭縯匱夳匵礷䤹弻圽⤿", num), this.FontNameAscii);
            }
            if (this.m_charStyleName != null)
            {
                writer.WriteValue(BookmarkStart.b("欧䈩䴫尭振䘱䴳娵崷琹崻匽┿", num), this.m_charStyleName);
            }
            if (this.method_60())
            {
                if (this.LineBreak)
                {
                    writer.WriteValue(BookmarkStart.b("搧䌩䈫䬭爯䀱儳圵匷", num), this.LineBreak);
                }
                if (!this.TextColor.IsEmpty)
                {
                    writer.WriteValue(BookmarkStart.b("簧伩含娭猯崱堳夵䨷", num), this.TextColor);
                }
                if (this.HasValue(190))
                {
                    writer.WriteValue(BookmarkStart.b("渧䔩䈫娭振嬱丳匵", num), this.FontSize);
                }
                if (this.HasValue(60))
                {
                    writer.WriteValue(BookmarkStart.b("樧䔩䀫䨭", num), this.Bold);
                }
                if (this.HasValue(70))
                {
                    writer.WriteValue(BookmarkStart.b("愧帩䴫䈭夯儱", num), this.Italic);
                }
                if (this.HasValue(80))
                {
                    writer.WriteValue(BookmarkStart.b("笧帩師䜭嬯圱", num), this.IsStrikeout);
                }
                if (this.HasValue(300))
                {
                    writer.WriteValue(BookmarkStart.b("氧䔩夫䰭尯圱朳䈵䨷匹圻嬽", num), this.DoubleStrike);
                }
                if (this.HasValue(140))
                {
                    writer.WriteValue(BookmarkStart.b("紧䐩䠫䬭䈯帱崳堵崷", num), (int) this.UnderlineStyle);
                }
                if (this.HasValue(210))
                {
                    writer.WriteValue(BookmarkStart.b("笧弩丫紭䔯䈱儳䐵欷夹主圽〿㙁", num), this.SubSuperScript);
                }
                if (this.HasValue(150))
                {
                    writer.WriteValue(BookmarkStart.b("搧䌩䈫䬭振䈱唳唵儷吹嬻", num), this.CharacterSpacing);
                }
                if (this.HasValue(200))
                {
                    writer.WriteValue(BookmarkStart.b("砧䔩弫䜭䐯嬱嬳堵", num), this.Position);
                }
                if (this.HasValue(9))
                {
                    writer.WriteValue(BookmarkStart.b("簧伩含娭爯匱圳崵強䠹医䬽⸿♁݃⥅⑇╉㹋", num), this.TextBackgroundColor);
                }
                if (this.HasValue(100))
                {
                    writer.WriteValue(BookmarkStart.b("愧天缫䘭儯嘱嬳䄵", num), this.IsShadow);
                }
                if (this.HasValue(170))
                {
                    writer.WriteValue(BookmarkStart.b("洧䜩丫䄭䌯䄱", num), this.Emboss);
                }
                if (this.HasValue(180))
                {
                    writer.WriteValue(BookmarkStart.b("洧䐩䬫尭儯䐱儳", num), this.Engrave);
                }
                if (this.HasValue(130))
                {
                    writer.WriteValue(BookmarkStart.b("性䌩䠫䨭唯就", num), this.Hidden);
                }
                if (this.HasValue(120))
                {
                    writer.WriteValue(BookmarkStart.b("椧䘩䀫洭儯䈱䜳", num), this.AllCaps);
                }
                if (this.HasValue(110))
                {
                    writer.WriteValue(BookmarkStart.b("愧天缫䌭儯帱堳电夷䨹伻", num), this.IsSmallCaps);
                }
                if (this.HasValue(0x109))
                {
                    writer.WriteValue(BookmarkStart.b("愧天渫䜭启嬱", num), this.Bidi);
                }
                if (this.HasValue(250))
                {
                    writer.WriteValue(BookmarkStart.b("樧䔩䀫䨭爯嬱倳張", num), this.BoldBidi);
                }
                if (this.HasValue(260))
                {
                    writer.WriteValue(BookmarkStart.b("愧帩䴫䈭夯儱瘳張尷匹", num), this.ItalicBidi);
                }
                if (this.HasValue(350))
                {
                    writer.WriteValue(BookmarkStart.b("渧䔩䈫娭振嬱丳匵稷匹堻圽", num), this.FontSizeBidi);
                }
                if (this.HasValue(20))
                {
                    writer.WriteValue(BookmarkStart.b("性䌩䬫䘭尯嬱匳帵䰷礹医刽⼿ぁ", num), this.HighlightColor);
                }
                if (this.HasValue(400))
                {
                    writer.WriteValue(BookmarkStart.b("愧丩伫娭砯嬱娳䈵", num), this.IdctHint);
                }
                if (this.HasValue(380))
                {
                    writer.WriteValue(BookmarkStart.b("稧䴩怫䜭启ȱ", num), 380);
                }
                if (this.HasValue(390))
                {
                    writer.WriteValue(BookmarkStart.b("稧䴩怫䜭启̱", num), 390);
                }
                if (this.HasValue(0x4b))
                {
                    writer.WriteValue(BookmarkStart.b("稧䴩怫䜭启ı", num), (int) this.RgLid3);
                }
                if (this.HasValue(0x4c))
                {
                    writer.WriteValue(BookmarkStart.b("稧䴩怫䜭启ı欳е", num), (int) this.RgLid3_2);
                }
                if (this.HasValue(0x4d))
                {
                    writer.WriteValue(BookmarkStart.b("搧䌩䠫", num), (int) this.Lid);
                }
                if (this.HasValue(340))
                {
                    writer.WriteValue(BookmarkStart.b("搧䌩䠫氭夯", num), (int) this.LocaleIdBi);
                }
                if (this.HasValue(440))
                {
                    writer.WriteValue(BookmarkStart.b("愧天戫䄭怯䀱嬳夵帷", num), this.IsNoProof);
                }
                if (this.HasValue(0x84))
                {
                    writer.WriteValue(BookmarkStart.b("愧天笫䬭刯稱崳刵尷弹刻", num), this.IsWebHidden);
                }
                if (this.HasValue(6))
                {
                    writer.WriteValue(BookmarkStart.b("渧䔩師䬭猯崱堳夵䨷", num), this.ForeColor);
                }
                if (this.HasValue(0x51))
                {
                    writer.WriteValue(BookmarkStart.b("簧伩含娭䔯䀱儳", num), this.TextureStyle);
                }
                if (this.HasValue(90))
                {
                    writer.WriteValue(BookmarkStart.b("朧弩堫䈭夯就儳", num), this.IsOutLine);
                }
                if (this.HasValue(0x41))
                {
                    this.method_76(writer, 0x41, BookmarkStart.b("愧帩䴫䈭夯儱眳夵唷䨹倻嬽㠿", num));
                }
                if (this.HasValue(0x58))
                {
                    this.method_76(writer, 0x58, BookmarkStart.b("椧䘩䀫洭儯䈱䜳电圷圹䰻刽┿㩁", num));
                }
                if (this.HasValue(0x53))
                {
                    this.method_76(writer, 0x53, BookmarkStart.b("洧䜩丫䄭䌯䄱眳夵唷䨹倻嬽㠿", num));
                }
                if (this.HasValue(0x52))
                {
                    this.method_76(writer, 0x52, BookmarkStart.b("洧䐩䬫尭儯䐱儳电圷圹䰻刽┿㩁", num));
                }
                if (this.HasValue(0x54))
                {
                    this.method_76(writer, 0x54, BookmarkStart.b("笧䈩䴫䨭弯䔱眳夵唷䨹倻嬽㠿", num));
                }
                if (this.HasValue(0x40))
                {
                    this.method_76(writer, 0x40, BookmarkStart.b("樧䔩䀫䨭猯崱夳䘵吷弹䐻", num));
                }
                if (this.HasValue(0x42))
                {
                    this.method_76(writer, 0x42, BookmarkStart.b("性䌩䠫䨭唯就眳夵唷䨹倻嬽㠿", num));
                }
                if (this.HasValue(0x57))
                {
                    this.method_76(writer, 0x57, BookmarkStart.b("氧礩堫尭夯失儳电圷圹䰻刽┿㩁", num));
                }
                if (this.HasValue(0x56))
                {
                    this.method_76(writer, 0x56, BookmarkStart.b("笧䜩䴫䈭尯焱唳䘵䬷礹医匽〿⹁⅃㹅", num));
                }
                if (this.HasValue(0x55))
                {
                    this.method_76(writer, 0x55, BookmarkStart.b("笧帩師䜭嬯圱眳夵唷䨹倻嬽㠿", num));
                }
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 15;
            base.WriteXmlContent(writer);
            if (!this.IsDefault)
            {
                Class140 class2 = new Class140(base.Document, base.Document.FontInfoList, null);
                byte[] buffer = class2.method_65(this, null, false);
                class2 = null;
                writer.WriteChildBinaryElement(BookmarkStart.b("尴夶䴸帺似儾⁀⽂桄⍆⡈㽊ⱌ", num), buffer);
            }
        }

        public bool AllCaps
        {
            get
            {
                return this.method_53(120);
            }
            set
            {
                this.method_56(120, value);
            }
        }

        public bool AllowContextualAlternates
        {
            get
            {
                return (bool) this.method_52(0x36);
            }
            set
            {
                this.method_54(0x36, value);
            }
        }

        internal string AnnotationAuthor
        {
            get
            {
                return (string) this.method_52(0x14d);
            }
            set
            {
                this.method_54(0x14d, value);
            }
        }

        internal string AsciiTheme
        {
            get
            {
                if (this.HasValue(530))
                {
                    return (string) base[530];
                }
                return string.Empty;
            }
            set
            {
                base[530] = value;
                base.SetPropUpdateFlag(530);
            }
        }

        public bool Bidi
        {
            get
            {
                return this.method_53(0x109);
            }
            set
            {
                this.method_56(0x109, value);
            }
        }

        public bool Bold
        {
            get
            {
                return this.method_53(60);
            }
            set
            {
                this.method_56(60, value);
            }
        }

        public bool BoldBidi
        {
            get
            {
                return this.method_53(250);
            }
            set
            {
                this.method_56(250, value);
            }
        }

        public Spire.Doc.Formatting.Border Border
        {
            get
            {
                return (this.method_52(360) as Spire.Doc.Formatting.Border);
            }
        }

        public float CharacterSpacing
        {
            get
            {
                return (float) this.method_52(150);
            }
            set
            {
                this.method_54(150, value);
            }
        }

        internal Class11 CharStyle
        {
            get
            {
                return this.method_68();
            }
        }

        internal string CharStyleName
        {
            get
            {
                return this.m_charStyleName;
            }
            set
            {
                this.m_charStyleName = value;
                this.IsDefault = false;
                this.OnStateChange(this);
            }
        }

        internal bool ComplexScript
        {
            get
            {
                return this.method_53(0x10c);
            }
            set
            {
                this.method_56(0x10c, value);
            }
        }

        internal string CsTheme
        {
            get
            {
                if (this.HasValue(560))
                {
                    return (string) base[560];
                }
                return string.Empty;
            }
            set
            {
                base[560] = value;
                base.SetPropUpdateFlag(560);
            }
        }

        public bool DoubleStrike
        {
            get
            {
                return this.method_53(300);
            }
            set
            {
                this.method_56(300, value);
            }
        }

        internal string EastAsiaTheme
        {
            get
            {
                if (this.HasValue(550))
                {
                    return (string) base[550];
                }
                return string.Empty;
            }
            set
            {
                base[550] = value;
                base.SetPropUpdateFlag(550);
            }
        }

        public bool Emboss
        {
            get
            {
                return this.method_53(170);
            }
            set
            {
                this.method_56(170, value);
            }
        }

        internal Emphasis EmphasisVal
        {
            get
            {
                return (Emphasis) this.method_52(770);
            }
            set
            {
                this.method_54(770, value);
            }
        }

        public bool Engrave
        {
            get
            {
                return this.method_53(180);
            }
            set
            {
                this.method_56(180, value);
            }
        }

        internal Class340 FarEastLayout
        {
            get
            {
                return (Class340) this.method_52(780);
            }
            set
            {
                this.method_54(780, value);
            }
        }

        internal bool FieldVanish
        {
            get
            {
                return this.method_53(0x6d);
            }
            set
            {
                this.method_56(0x6d, value);
            }
        }

        internal byte FieldVanishComplex
        {
            get
            {
                return (byte) this.method_52(0x37);
            }
            set
            {
                this.method_54(0x37, value);
            }
        }

        public System.Drawing.Font Font
        {
            get
            {
                string fontName = this.FontName;
                float fontSize = this.FontSize;
                System.Drawing.FontStyle fontStyle = this.FontStyle;
                if (((this.font_0 == null) || this.bool_5) || ((this.font_0 != null) && ((!this.font_0.Name.Equals(fontName) || (this.font_0.Size != fontSize)) || (this.font_0.Style != fontStyle))))
                {
                    fontSize = (fontSize <= 0f) ? 0.5f : fontSize;
                    this.font_0 = Class58.smethod_1(fontName, fontSize, fontStyle);
                    this.bool_5 = false;
                }
                return this.font_0;
            }
            set
            {
                this.FontName = value.Name;
                this.FontSize = value.SizeInPoints;
                this.Bold = value.Bold;
                this.Italic = value.Italic;
                this.IsStrikeout = value.Strikeout;
                this.UnderlineStyle = value.Underline ? Spire.Doc.Documents.UnderlineStyle.Single : Spire.Doc.Documents.UnderlineStyle.None;
                this.font_0 = value;
            }
        }

        public string FontName
        {
            get
            {
                return this.method_69(2);
            }
            set
            {
                base[2] = value;
                this.FontNameAscii = value;
                this.FontNameBidi = value;
                this.FontNameFarEast = value;
                this.FontNameNonFarEast = value;
                this.method_50();
                this.method_66();
                base.SetPropUpdateFlag(2);
                this.method_75();
            }
        }

        public string FontNameAscii
        {
            get
            {
                string str = (string) base[230];
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                if ((base.m_doc != null) && !string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_0()))
                {
                    return base.m_doc.DefaultFontNameTable.method_0();
                }
                return (string) base[2];
            }
            set
            {
                base[230] = value;
                base.SetPropUpdateFlag(230);
            }
        }

        public string FontNameBidi
        {
            get
            {
                string str = (string) base[270];
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                if ((base.m_doc != null) && !string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_6()))
                {
                    return base.m_doc.DefaultFontNameTable.method_6();
                }
                return (string) base[2];
            }
            set
            {
                base[270] = value;
                this.method_66();
                base.SetPropUpdateFlag(270);
            }
        }

        public string FontNameFarEast
        {
            get
            {
                string str = (string) base[0xeb];
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                if ((base.m_doc != null) && !string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_2()))
                {
                    return base.m_doc.DefaultFontNameTable.method_2();
                }
                return (string) base[2];
            }
            set
            {
                base[0xeb] = value;
                base.SetPropUpdateFlag(0xeb);
            }
        }

        public string FontNameNonFarEast
        {
            get
            {
                string str = (string) base[240];
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                if ((base.m_doc != null) && !string.IsNullOrEmpty(base.m_doc.DefaultFontNameTable.method_4()))
                {
                    return base.m_doc.DefaultFontNameTable.method_4();
                }
                return (string) base[2];
            }
            set
            {
                base[240] = value;
                base.SetPropUpdateFlag(240);
            }
        }

        public float FontSize
        {
            get
            {
                return (float) this.method_52(190);
            }
            set
            {
                this.method_54(190, value);
            }
        }

        public float FontSizeBidi
        {
            get
            {
                return (float) this.method_52(350);
            }
            set
            {
                this.method_54(350, value);
            }
        }

        internal System.Drawing.FontStyle FontStyle
        {
            get
            {
                System.Drawing.FontStyle regular = System.Drawing.FontStyle.Regular;
                if (this.Bold)
                {
                    regular |= System.Drawing.FontStyle.Bold;
                }
                if (this.Italic)
                {
                    regular |= System.Drawing.FontStyle.Italic;
                }
                if (this.UnderlineStyle != Spire.Doc.Documents.UnderlineStyle.None)
                {
                    regular |= System.Drawing.FontStyle.Underline;
                }
                if (!this.IsStrikeout && !this.DoubleStrike)
                {
                    return regular;
                }
                return (regular | System.Drawing.FontStyle.Strikeout);
            }
        }

        internal System.Drawing.FontStyle FontStyleEx
        {
            get
            {
                if (!this.nullable_0.HasValue)
                {
                    this.nullable_0 = new System.Drawing.FontStyle?(this.FontStyle);
                }
                return this.nullable_0.Value;
            }
        }

        public Spire.Doc.Documents.FontTypeHint FontTypeHint
        {
            get
            {
                if (base.HasKey(400))
                {
                    return (Spire.Doc.Documents.FontTypeHint) Enum.ToObject(typeof(Spire.Doc.Documents.FontTypeHint), this.method_52(400));
                }
                return Spire.Doc.Documents.FontTypeHint.Default;
            }
            set
            {
                this.method_54(400, Convert.ToByte(value));
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

        internal string HAnsiTheme
        {
            get
            {
                if (this.HasValue(540))
                {
                    return (string) base[540];
                }
                return string.Empty;
            }
            set
            {
                base[540] = value;
                base.SetPropUpdateFlag(540);
            }
        }

        public bool Hidden
        {
            get
            {
                return this.method_53(130);
            }
            set
            {
                this.method_56(130, value);
            }
        }

        public Color HighlightColor
        {
            get
            {
                return (Color) this.method_52(20);
            }
            set
            {
                this.method_54(20, value);
            }
        }

        internal bool IdctHint
        {
            get
            {
                return (this.FontTypeHint != Spire.Doc.Documents.FontTypeHint.Default);
            }
            set
            {
                this.FontTypeHint = value ? Spire.Doc.Documents.FontTypeHint.EastAsia : Spire.Doc.Documents.FontTypeHint.Default;
            }
        }

        internal bool IsChangedFormat
        {
            get
            {
                return (bool) this.method_52(0x69);
            }
            set
            {
                if (value)
                {
                    this.method_54(0x69, value);
                }
            }
        }

        internal bool IsDeleteRevision
        {
            get
            {
                return (bool) this.method_52(0x68);
            }
            set
            {
                this.method_54(0x68, value);
            }
        }

        internal bool IsInsertRevision
        {
            get
            {
                return (bool) this.method_52(0x67);
            }
            set
            {
                this.method_54(0x67, value);
            }
        }

        internal bool IsNoProof
        {
            get
            {
                return this.method_53(440);
            }
            set
            {
                this.method_56(440, value);
            }
        }

        public bool IsOutLine
        {
            get
            {
                return this.method_53(90);
            }
            set
            {
                this.method_56(90, value);
            }
        }

        public bool IsShadow
        {
            get
            {
                return this.method_53(100);
            }
            set
            {
                this.method_56(100, value);
            }
        }

        public bool IsSmallCaps
        {
            get
            {
                return this.method_53(110);
            }
            set
            {
                this.method_56(110, value);
            }
        }

        internal bool IsSpecial
        {
            get
            {
                return this.method_53(0x6a);
            }
            set
            {
                this.method_56(0x6a, value);
            }
        }

        public bool IsStrikeout
        {
            get
            {
                return this.method_53(80);
            }
            set
            {
                this.method_56(80, value);
            }
        }

        internal int Istd
        {
            get
            {
                return (int) this.method_52(50);
            }
            set
            {
                this.method_54(50, value);
            }
        }

        internal bool IsWebHidden
        {
            get
            {
                return this.method_53(0x84);
            }
            set
            {
                this.method_56(0x84, value);
            }
        }

        public bool Italic
        {
            get
            {
                return this.method_53(70);
            }
            set
            {
                this.method_56(70, value);
            }
        }

        public bool ItalicBidi
        {
            get
            {
                return this.method_53(260);
            }
            set
            {
                this.method_56(260, value);
            }
        }

        internal float Kerning
        {
            get
            {
                return (float) this.method_52(220);
            }
            set
            {
                this.method_54(220, value);
            }
        }

        internal short Lid
        {
            get
            {
                return (short) this.method_52(0x4d);
            }
            set
            {
                this.method_54(0x4d, value);
            }
        }

        public LigatureType LigaturesType
        {
            get
            {
                return (LigatureType) this.method_52(0x79);
            }
            set
            {
                this.method_54(0x79, value);
            }
        }

        internal bool LineBreak
        {
            get
            {
                return this.method_49();
            }
            set
            {
                this.method_51();
            }
        }

        internal bool ListHasPicture
        {
            get
            {
                return (bool) this.method_52(0x6c);
            }
            set
            {
                this.method_54(0x6c, value);
            }
        }

        internal int ListPictureIndex
        {
            get
            {
                return (int) this.method_52(480);
            }
            set
            {
                this.method_54(480, value);
            }
        }

        public short LocaleIdASCII
        {
            get
            {
                return this.method_70(380);
            }
            set
            {
                this.method_54(380, value);
            }
        }

        internal short LocaleIdBi
        {
            get
            {
                return (short) this.method_52(340);
            }
            set
            {
                this.method_54(340, value);
            }
        }

        public short LocaleIdFarEast
        {
            get
            {
                return this.method_70(390);
            }
            set
            {
                this.method_54(390, value);
            }
        }

        internal string NewCharStyleName
        {
            get
            {
                return this.string_5;
            }
            set
            {
                this.string_5 = value;
            }
        }

        public Spire.Doc.Documents.NumberFormType NumberFormType
        {
            get
            {
                return (Spire.Doc.Documents.NumberFormType) this.method_52(0x7a);
            }
            set
            {
                this.method_54(0x7a, value);
            }
        }

        public Spire.Doc.Documents.NumberSpaceType NumberSpaceType
        {
            get
            {
                return (Spire.Doc.Documents.NumberSpaceType) this.method_52(0x7b);
            }
            set
            {
                this.method_54(0x7b, value);
            }
        }

        internal int PicLocation
        {
            get
            {
                return (int) this.method_52(0x6f);
            }
            set
            {
                this.method_54(0x6f, value);
            }
        }

        public float Position
        {
            get
            {
                return (float) this.method_52(200);
            }
            set
            {
                this.method_54(200, value);
            }
        }

        internal short RgLid3
        {
            get
            {
                return (short) this.method_52(0x4b);
            }
            set
            {
                this.method_54(0x4b, value);
            }
        }

        internal short RgLid3_2
        {
            get
            {
                return (short) this.method_52(0x4c);
            }
            set
            {
                this.method_54(0x4c, value);
            }
        }

        internal Class16 Shading
        {
            get
            {
                return (Class16) this.method_52(370);
            }
        }

        internal bool SnapToGrid
        {
            get
            {
                return this.method_53(330);
            }
            set
            {
                this.method_56(330, value);
            }
        }

        public Spire.Doc.Documents.StylisticSetType StylisticSetType
        {
            get
            {
                return (Spire.Doc.Documents.StylisticSetType) this.method_52(0x7c);
            }
            set
            {
                this.method_54(0x7c, value);
            }
        }

        public Spire.Doc.Documents.SubSuperScript SubSuperScript
        {
            get
            {
                return (Spire.Doc.Documents.SubSuperScript) this.method_52(210);
            }
            set
            {
                this.method_54(210, value);
            }
        }

        internal CharacterFormat TableStyleCharacterFormat
        {
            get
            {
                return this.characterFormat_0;
            }
            set
            {
                this.characterFormat_0 = value;
            }
        }

        public Color TextBackgroundColor
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

        public Color TextColor
        {
            get
            {
                return (Color) this.method_52(160);
            }
            set
            {
                this.method_55(value);
                this.class327_0 = null;
            }
        }

        internal Spire.Doc.TextEffect TextEffect
        {
            get
            {
                return (Spire.Doc.TextEffect) this.method_52(310);
            }
            set
            {
                this.method_54(310, value);
            }
        }

        public short TextScale
        {
            get
            {
                return (short) this.method_52(290);
            }
            set
            {
                this.method_54(290, value);
            }
        }

        internal float TextScaleEx
        {
            get
            {
                return (((float) this.TextScale) / 100f);
            }
        }

        internal Class327 TextThemeColor
        {
            get
            {
                if (this.class327_0 == null)
                {
                    this.class327_0 = new Class327(base.m_doc);
                }
                return this.class327_0;
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

        internal Color UnderlineColor
        {
            get
            {
                return (Color) this.method_52(450);
            }
            set
            {
                this.method_54(450, value);
            }
        }

        public Spire.Doc.Documents.UnderlineStyle UnderlineStyle
        {
            get
            {
                return (Spire.Doc.Documents.UnderlineStyle) this.method_52(140);
            }
            set
            {
                if (value.ToString().Length > 3)
                {
                    this.method_54(140, value);
                }
            }
        }
    }
}

