namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.Converters;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public class RowFormat : WordAttrCollection
    {
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        [CompilerGenerated]
        private bool bool_6;
        private float float_2;
        private float float_3;
        internal const int int_10 = 3;
        internal const int int_11 = 0x11a8;
        internal const int int_12 = 6;
        internal const int int_13 = 0x10c2;
        internal const int int_14 = 0x10f4;
        internal const int int_15 = 0x66;
        internal const int int_16 = 0x67;
        internal const int int_17 = 0x111c;
        internal const int int_18 = 0xfaa;
        internal const int int_19 = 0x1108;
        internal const int int_20 = 0x6b;
        internal const int int_21 = 0x6c;
        internal const int int_22 = 0x10ea;
        internal const int int_23 = 0x6f;
        internal const int int_24 = 110;
        internal const int int_25 = 0x77;
        internal const int int_26 = 120;
        internal const int int_27 = 0x1090;
        internal const int int_28 = 0x100e;
        internal const int int_29 = 0xfc8;
        internal const int int_30 = 0x119e;
        internal const int int_31 = 0x1194;
        internal const int int_32 = 0xfa5;
        internal const int int_33 = 0x102c;
        internal const int int_34 = 0x1086;
        internal const int int_35 = 0x109a;
        internal const int int_36 = 0x10a4;
        internal const int int_37 = 0x13f0;
        internal const int int_38 = 0x107c;
        internal const int int_39 = 0x10b8;
        internal const int int_40 = 0x13f1;
        internal const int int_41 = 0x7a;
        internal const int int_42 = 0x7b;
        internal const int int_43 = 0x13f2;
        internal const int int_8 = 1;
        internal const int int_9 = 0x1018;
        private WidthType widthType_0;

        public RowFormat()
        {
            this.float_2 = 100f;
            this.bool_5 = true;
        }

        internal RowFormat(IDocument A_0) : base(A_0)
        {
            this.float_2 = 100f;
            this.bool_5 = true;
        }

        internal override void AcceptChanges()
        {
            base.AcceptChanges();
        }

        internal override void ApplyBase(FormatBase baseFormat)
        {
            base.ApplyBase(baseFormat);
            this.Borders.ApplyBase((baseFormat as RowFormat).Borders);
            this.Paddings.ApplyBase((baseFormat as RowFormat).Paddings);
            this.Positioning.ApplyBase((baseFormat as RowFormat).Positioning);
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(RowFormat);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int key = (int) info.GetValue(info.FieldType);
                if (base.PropertiesHash.ContainsKey(key) || this.HasValue(key))
                {
                    this.method_55(key);
                }
            }
        }

        internal override void Close()
        {
            base.Close();
        }

        protected internal override void EnsureComposites()
        {
            if (base.HasKey(1))
            {
                base.EnsureComposites(new int[] { 1 });
            }
            if (base.HasKey(3))
            {
                base.EnsureComposites(new int[] { 3 });
            }
            if (base.HasKey(120))
            {
                base.EnsureComposites(new int[] { 120 });
            }
            if (base.HasKey(0x10ea))
            {
                base.EnsureComposites(new int[] { 0x10ea });
            }
            if (base.HasKey(0x1086))
            {
                base.EnsureComposites(new int[] { 0x1086 });
            }
            if (base.HasKey(0x109a))
            {
                base.EnsureComposites(new int[] { 0x109a });
            }
            if (base.HasKey(0x10a4))
            {
                base.EnsureComposites(new int[] { 0x10a4 });
            }
        }

        protected override FormatBase GetDefComposite(int key)
        {
            switch (key)
            {
                case 1:
                    return base.GetDefComposite(1, new Spire.Doc.Documents.Borders(this, 1));

                case 3:
                    return base.GetDefComposite(3, new Spire.Doc.Formatting.Paddings(this, 3));

                case 120:
                    return base.GetDefComposite(120, new TablePositioning(this, 120));

                case 0x1086:
                    return base.GetDefComposite(0x1086, new Class15(this, 0x1086));

                case 0x109a:
                    return base.GetDefComposite(0x109a, new Class15(this, 0x109a));

                case 0x10a4:
                    return base.GetDefComposite(0x10a4, new Class15(this, 0x10a4));

                case 0x10ea:
                    return base.GetDefComposite(0x10ea, new Class16(this, 0x10ea));
            }
            return null;
        }

        protected override object GetDefValue(int key)
        {
            int num = key;
            if (num <= 0x1072)
            {
                if (num > 0xfd2)
                {
                    if (num > 0x1004)
                    {
                        if (num > 0x1018)
                        {
                            switch (num)
                            {
                                case 0x102c:
                                    if ((base.Document == null) || ((base.Document.DetectedFormatType == FileFormat.Doc) && (base.Document.DetectedFormatType == FileFormat.WordML)))
                                    {
                                        return TableStyleOptions.Default2003;
                                    }
                                    return TableStyleOptions.Default;

                                case 0x104a:
                                    return 0;

                                case 0x1072:
                                    return 0;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x100e:
                                    return TableRowHeightType.AtLeast;

                                case 0x1018:
                                    return 0f;
                            }
                        }
                    }
                    else if (num > 0xfe6)
                    {
                        switch (num)
                        {
                            case 0xff0:
                                return this.Borders.Right;

                            case 0xffa:
                                return this.Borders.Horizontal;

                            case 0x1004:
                                return this.Borders.Vertical;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xfdc:
                                return this.Borders.Left;

                            case 0xfe6:
                                return this.Borders.Bottom;
                        }
                    }
                }
                else if (num > 0x7b)
                {
                    if (num > 0xfaa)
                    {
                        switch (num)
                        {
                            case 0xfb4:
                                return 5.4f;

                            case 0xfc8:
                                goto Label_049F;

                            case 0xfd2:
                                return this.Borders.Top;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xfa5:
                                return 11;

                            case 0xfaa:
                                return RowAlignment.Left;
                        }
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x6c:
                            return this.Shading.method_54();

                        case 110:
                            return this.Shading.method_62();

                        case 0x6f:
                            return this.Shading.method_58();

                        case 0x77:
                            return false;

                        case 0x7b:
                            return -2147483648;

                        case 0x3b:
                            return (short) 0;

                        case 60:
                            return (short) 0;

                        case 0x3d:
                        case 0x3e:
                        case 0x41:
                        case 0x42:
                            return 0f;

                        case 0x3f:
                            return HorizontalRelation.Column;

                        case 0x40:
                            return VerticalRelation.Margin;

                        case 0x43:
                        case 0x44:
                            return 9f;

                        case 0x45:
                            return true;

                        case 0x66:
                            return 0f;

                        case 0x67:
                            goto Label_043B;
                    }
                }
            }
            else if (num <= 0x10d6)
            {
                if (num > 0x10a4)
                {
                    if (num > 0x10b8)
                    {
                        switch (num)
                        {
                            case 0x10c2:
                                return -1f;

                            case 0x10cc:
                                return 0f;

                            case 0x10d6:
                                return 0f;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x10ae:
                                return 0;

                            case 0x10b8:
                                return 0;
                        }
                    }
                }
                else if (num > 0x1086)
                {
                    switch (num)
                    {
                        case 0x1090:
                            return Spire.Doc.LayoutType.AutoFit;

                        case 0x109a:
                            return base.GetDefComposite(0x109a, new Class15(this, 0x109a));

                        case 0x10a4:
                            return base.GetDefComposite(0x10a4, new Class15(this, 0x10a4));
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x107c:
                            return 0;

                        case 0x1086:
                            return base.GetDefComposite(0x1086, new Class15(this, 0x1086));
                    }
                }
            }
            else if (num <= 0x1108)
            {
                if (num > 0x10ea)
                {
                    switch (num)
                    {
                        case 0x10f4:
                            return 0f;

                        case 0x10fe:
                            return true;

                        case 0x1108:
                            return true;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x10e0:
                            return 5.4f;

                        case 0x10ea:
                            return this.Shading;
                    }
                }
            }
            else if (num > 0x1194)
            {
                switch (num)
                {
                    case 0x13ec:
                        return null;

                    case 0x13ee:
                        return 0;

                    case 0x13ef:
                        return new ArrayList();

                    case 0x13f0:
                    case 0x13f1:
                        return 0;

                    case 0x13f2:
                        return new int[1];

                    case 0x11a8:
                        goto Label_049F;

                    case 0x119e:
                        goto Label_04A6;
                }
            }
            else
            {
                switch (num)
                {
                    case 0x111c:
                        goto Label_043B;

                    case 0x1130:
                        return 0;

                    case 0x1194:
                        goto Label_04A6;
                }
            }
            throw new NotImplementedException();
        Label_043B:
            return false;
        Label_049F:
            return false;
        Label_04A6:
            return 1L;
        }

        internal override int GetFullKey(int key)
        {
            int num = key;
            if (num <= 0x104a)
            {
                if (num > 0xfe6)
                {
                    if (num > 0x1004)
                    {
                        switch (num)
                        {
                            case 0x1036:
                                return this.Positioning.GetFullKey(0x3f);

                            case 0x1040:
                                return this.Positioning.GetFullKey(0x40);

                            case 0x104a:
                                return this.Positioning.GetFullKey(0x3d);
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xff0:
                                return this.Borders.GetFullKey(4);

                            case 0xffa:
                                return this.Borders.GetFullKey(6);

                            case 0x1004:
                                return this.Borders.GetFullKey(5);
                        }
                    }
                }
                else if (num > 0xfb4)
                {
                    switch (num)
                    {
                        case 0xfd2:
                            return this.Borders.GetFullKey(2);

                        case 0xfdc:
                            return this.Borders.GetFullKey(1);

                        case 0xfe6:
                            return this.Borders.GetFullKey(3);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x6c:
                            return this.Shading.GetFullKey(3);

                        case 110:
                            return this.Shading.GetFullKey(1);

                        case 0x6f:
                            return this.Shading.GetFullKey(2);

                        case 0xfb4:
                            return this.Paddings.GetFullKey(1);
                    }
                }
            }
            else if (num <= 0x107c)
            {
                if (num > 0x105e)
                {
                    switch (num)
                    {
                        case 0x1068:
                            return this.Positioning.GetFullKey(60);

                        case 0x1072:
                            return this.Positioning.GetFullKey(0x43);

                        case 0x107c:
                            return this.Positioning.GetFullKey(0x41);
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x1054:
                            return this.Positioning.GetFullKey(0x3b);

                        case 0x105e:
                            return this.Positioning.GetFullKey(0x3e);
                    }
                }
            }
            else
            {
                switch (num)
                {
                    case 0x10ae:
                        return this.Positioning.GetFullKey(0x44);

                    case 0x10b8:
                        return this.Positioning.GetFullKey(0x42);

                    case 0x10cc:
                        return this.Paddings.GetFullKey(2);

                    case 0x10d6:
                        return this.Paddings.GetFullKey(3);

                    case 0x10e0:
                        return this.Paddings.GetFullKey(4);

                    case 0x10fe:
                        return this.Positioning.GetFullKey(0x45);
                }
            }
            return base.GetFullKey(key);
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasValue(propertyKey);
        }

        protected override void ImportMembers(FormatBase format)
        {
            base.ImportMembers(format);
            RowFormat format2 = format as RowFormat;
            if (format2 != null)
            {
                base.method_21(format2);
                this.EnsureComposites();
                this.IsDefault = false;
                this.float_2 = format2.Scaling;
                this.GridBefore = format2.GridBefore;
                this.GridAfter = format2.GridAfter;
                this.GridBeforeWidth.method_52(format2.GridBeforeWidth.method_51());
                this.GridBeforeWidth.method_50(format2.GridBeforeWidth.method_49());
                this.GridAfterWidth.method_52(format2.GridAfterWidth.method_51());
                this.GridAfterWidth.method_50(format2.GridAfterWidth.method_49());
            }
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.AddElement(BookmarkStart.b("䠩䌫尭启圱䘳䔵", 4), this.Borders);
            base.XDLSHolder.AddElement(BookmarkStart.b("稩䴫䨭启嬱娳儵䬷", 4), this.Paddings);
        }

        internal bool method_49(RowFormat A_0)
        {
            bool isFloating = this.IsFloating;
            bool flag2 = A_0.IsFloating;
            if (isFloating || flag2)
            {
                if (isFloating != flag2)
                {
                    return false;
                }
                if (this.AllowOverlap != A_0.AllowOverlap)
                {
                    return false;
                }
                if (this.RelativeHorizontalPosition != A_0.RelativeHorizontalPosition)
                {
                    return false;
                }
                if (this.RelativeVerticalPosition != A_0.RelativeVerticalPosition)
                {
                    return false;
                }
                if (Class59.smethod_4(this.FrameLeft, A_0.FrameLeft, 0.0001f) != 0)
                {
                    return false;
                }
                if (Class59.smethod_4(this.FrameTop, A_0.FrameTop, 0.0001f) != 0)
                {
                    return false;
                }
                if (this.HorizontalAlignment != A_0.HorizontalAlignment)
                {
                    return false;
                }
                if (this.VerticalAlignment != A_0.VerticalAlignment)
                {
                    return false;
                }
                if (this.FrameDistanceFromLeft != A_0.FrameDistanceFromLeft)
                {
                    return false;
                }
                if (this.FrameDistanceFromTop != A_0.FrameDistanceFromTop)
                {
                    return false;
                }
                if (this.FrameDistanceFromRight != A_0.FrameDistanceFromRight)
                {
                    return false;
                }
                if (this.FrameDistanceFromBottom != A_0.FrameDistanceFromBottom)
                {
                    return false;
                }
            }
            return true;
        }

        internal RowFormat method_50()
        {
            RowFormat format = new RowFormat();
            format.method_26(this);
            return format;
        }

        internal object method_51(int A_0)
        {
            return base[A_0];
        }

        internal void method_52(int A_0, object A_1)
        {
            base[A_0] = A_1;
        }

        internal void method_53(bool A_0)
        {
            this.bool_5 = true;
            this.method_52(0x77, A_0);
        }

        internal void method_54()
        {
            this.Borders.ClearAttrs();
            this.Remove(1);
        }

        internal void method_55(int A_0)
        {
            base.IsPropertyUpdated(A_0);
        }

        internal void method_56(int A_0)
        {
        }

        internal bool method_57()
        {
            return false;
        }

        private short method_58()
        {
            return -32768;
        }

        private bool method_59()
        {
            return false;
        }

        private void method_60()
        {
        }

        internal void method_61(FormatBase A_0)
        {
            base.ApplyBase(A_0);
        }

        private void method_62(FormatBase A_0, int A_1)
        {
            int num = A_1;
            if (num <= 0x1068)
            {
                if (num > 0x1040)
                {
                    if (num > 0x1054)
                    {
                        switch (num)
                        {
                            case 0x105e:
                            case 0x1068:
                                goto Label_00BA;
                        }
                        return;
                    }
                    if ((num != 0x104a) && (num != 0x1054))
                    {
                        return;
                    }
                }
                else
                {
                    if (num == 0xfb4)
                    {
                        goto Label_00C7;
                    }
                    if ((num != 0x1036) && (num != 0x1040))
                    {
                        return;
                    }
                }
            }
            else if (num <= 0x10b8)
            {
                if (num > 0x107c)
                {
                    switch (num)
                    {
                        case 0x10ae:
                        case 0x10b8:
                            goto Label_00BA;
                    }
                    return;
                }
                if ((num != 0x1072) && (num != 0x107c))
                {
                    return;
                }
            }
            else
            {
                if (num <= 0x10d6)
                {
                    if ((num != 0x10cc) && (num != 0x10d6))
                    {
                        return;
                    }
                    goto Label_00C7;
                }
                if (num == 0x10e0)
                {
                    goto Label_00C7;
                }
                if (num != 0x10fe)
                {
                    return;
                }
            }
        Label_00BA:
            this.Positioning.IsDefault = false;
            return;
        Label_00C7:
            this.Paddings.IsDefault = false;
        }

        private void method_63(int A_0, object A_1)
        {
            TableRow ownerRow = this.OwnerRow;
            if (((ownerRow != null) && (ownerRow.Cells != null)) && (ownerRow.Cells.Count != 0))
            {
                switch (A_0)
                {
                    case 1:
                        if (A_1 is Spire.Doc.TextureStyle)
                        {
                            Spire.Doc.TextureStyle style = (Spire.Doc.TextureStyle) A_1;
                            foreach (TableCell cell in ownerRow.Cells)
                            {
                                if (!cell.CellFormat.HasKey(cell.CellFormat.Shading.GetFullKey(1)))
                                {
                                    cell.CellFormat.TextureStyle = style;
                                }
                            }
                        }
                        return;

                    case 2:
                        return;

                    case 3:
                        if (A_1 is Color)
                        {
                            Color color = (Color) A_1;
                            foreach (TableCell cell2 in ownerRow.Cells)
                            {
                                if (!cell2.CellFormat.HasKey(cell2.CellFormat.Shading.GetFullKey(3)))
                                {
                                    cell2.CellFormat.BackColor = color;
                                }
                            }
                        }
                        return;
                }
            }
        }

        internal void method_64()
        {
            if (!this.Paddings.HasKey(1))
            {
                this.Paddings.Left = 5.4f;
            }
            if (!this.Paddings.HasKey(4))
            {
                this.Paddings.Right = 5.4f;
            }
        }

        protected override void OnChange(FormatBase format, int propKey)
        {
            this.method_62(format, propKey);
            if (!this.bool_3 && ((base.OwnerBase == null) || !base.OwnerBase.Document.bool_3))
            {
                if (((base.OwnerBase != null) && (base.OwnerBase is Table)) && this.bool_5)
                {
                    (base.OwnerBase as Table).method_81(format, propKey);
                }
                else if (((base.OwnerBase != null) && (base.OwnerBase is TableRow)) && this.bool_5)
                {
                    (base.OwnerBase as TableRow).method_33(format, propKey);
                }
            }
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 0x11;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("琶尸场儼氾ㅀ≂♄⹆❈ⱊ", 0x11)))
            {
                this.CellSpacingEx = reader.ReadFloat(BookmarkStart.b("琶尸场儼氾ㅀ≂♄⹆❈ⱊ", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笶尸崺䤼瀾❀╂㙄≆㵈", num)))
            {
                this.LeftIndent = reader.ReadFloat(BookmarkStart.b("笶尸崺䤼瀾❀╂㙄≆㵈", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("缶砸场吼堾⽀⹂⁄⥆㵈", num)))
            {
                this.HorizontalAlignment = (RowAlignment) reader.ReadEnum(BookmarkStart.b("缶砸场吼堾⽀⹂⁄⥆㵈", num), typeof(RowAlignment));
            }
            if (reader.HasAttribute(BookmarkStart.b("縶䨸稺䠼䬾⹀ᅂ⁄㑆⁈ㅊ⡌⭎", num)))
            {
                this.IsAutoResized = reader.ReadBoolean(BookmarkStart.b("縶䨸稺䠼䬾⹀ᅂ⁄㑆⁈ㅊ⡌⭎", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("縶䨸示似娾⁀⡂ф⑆㭈⑊㹌㱎Ő㉒㉔㉖⩘", num)))
            {
                this.IsBreakAcrossPages = reader.ReadBoolean(BookmarkStart.b("縶䨸示似娾⁀⡂ф⑆㭈⑊㹌㱎Ő㉒㉔㉖⩘", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("甶倸强吼款⁀⅂⥄≆", num)))
            {
                this.Bidi = reader.ReadBoolean(BookmarkStart.b("甶倸强吼款⁀⅂⥄≆", num));
            }
        }

        protected override bool ReadXmlContent(IXDLSContentReader reader)
        {
            bool flag = base.ReadXmlContent(reader);
            if (reader.TagName == BookmarkStart.b("䀨䔪夬䨮䌰崲吴嬶ᐸ强尼䬾⁀", 3))
            {
                reader.ReadChildBinaryElement();
                flag = true;
            }
            return flag;
        }

        internal override void Remove(int key)
        {
            base.Remove(key);
        }

        internal override void RemovePositioning()
        {
        }

        internal override void SetAttr(int propKey, object value)
        {
            this.method_52(propKey, value);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x10;
            base.WriteXmlAttributes(writer);
            if (this.CellSpacingEx != -1f)
            {
                writer.WriteValue(BookmarkStart.b("电崷嘹倻洽〿⍁❃⽅♇ⵉ", num), this.CellSpacingEx);
            }
            if (this.LeftIndent != 0f)
            {
                writer.WriteValue(BookmarkStart.b("稵崷尹䠻焽☿⑁㝃⍅㱇", num), this.LeftIndent);
            }
            if (this.HorizontalAlignment != RowAlignment.Left)
            {
                writer.WriteValue(BookmarkStart.b("縵礷嘹唻夽⸿⽁⅃⡅㱇", num), this.HorizontalAlignment);
            }
            if (this.IsAutoResized)
            {
                writer.WriteValue(BookmarkStart.b("缵䬷笹䤻䨽⼿၁⅃㕅ⅇぉ⥋⩍", num), this.IsAutoResized);
            }
            if (this.IsBreakAcrossPages)
            {
                writer.WriteValue(BookmarkStart.b("缵䬷砹主嬽ℿ⥁Ճ╅㩇╉㽋㵍O㍑㍓㍕⭗", num), this.IsBreakAcrossPages);
            }
            if (this.Bidi)
            {
                writer.WriteValue(BookmarkStart.b("琵儷帹唻樽ℿ⁁⡃⍅", num), this.Bidi);
            }
        }

        protected override void WriteXmlContent(IXDLSContentWriter writer)
        {
            base.WriteXmlContent(writer);
        }

        internal bool AllowOverlap
        {
            get
            {
                return (bool) base.method_32(0x10fe);
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
                this.bool_5 = true;
                this.Shading.method_57(value);
                this.OnChange(this, 3);
            }
        }

        public bool Bidi
        {
            get
            {
                return (bool) this.method_51(0x111c);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0x111c, value);
            }
        }

        public Spire.Doc.Documents.Borders Borders
        {
            get
            {
                return (this.method_51(1) as Spire.Doc.Documents.Borders);
            }
        }

        internal bool CancelOnChange
        {
            get
            {
                return this.bool_3;
            }
        }

        public float CellSpacing
        {
            get
            {
                return (this.CellSpacingEx * 2f);
            }
            set
            {
                this.CellSpacingEx = value / 2f;
            }
        }

        internal float CellSpacingEx
        {
            get
            {
                this.bool_5 = false;
                return (float) this.method_51(0x10c2);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0x10c2, value);
            }
        }

        internal Class732 CellsPr
        {
            get
            {
                return (Class732) base.method_31(0x13ec);
            }
        }

        internal int[] CellXList
        {
            get
            {
                return (int[]) this.method_51(0x13f2);
            }
            set
            {
                this.method_52(0x13f2, value);
            }
        }

        internal int DivId
        {
            get
            {
                return (int) this.method_51(0x7b);
            }
            set
            {
                this.method_52(0x7b, value);
            }
        }

        internal float FrameDistanceFromBottom
        {
            get
            {
                return this.Positioning.DistanceFromBottom;
            }
        }

        internal float FrameDistanceFromLeft
        {
            get
            {
                return this.Positioning.DistanceFromLeft;
            }
        }

        internal float FrameDistanceFromRight
        {
            get
            {
                return this.Positioning.DistanceFromRight;
            }
        }

        internal float FrameDistanceFromTop
        {
            get
            {
                return this.Positioning.DistanceFromTop;
            }
        }

        internal float FrameLeft
        {
            get
            {
                return this.Positioning.HorizPositionEx;
            }
            set
            {
                this.Positioning.HorizPositionEx = value;
            }
        }

        internal float FrameTop
        {
            get
            {
                return this.Positioning.VertPositionEx;
            }
            set
            {
                this.Positioning.VertPositionEx = value;
            }
        }

        internal int GridAfter
        {
            get
            {
                return (int) this.method_51(0x13f1);
            }
            set
            {
                this.method_52(0x13f1, value);
            }
        }

        internal Class15 GridAfterWidth
        {
            get
            {
                return (Class15) this.method_51(0x10a4);
            }
            set
            {
                this.GridAfterWidth.method_50(value.method_49());
                this.GridAfterWidth.method_52(value.method_51());
            }
        }

        internal int GridBefore
        {
            get
            {
                return (int) this.method_51(0x13f0);
            }
            set
            {
                this.method_52(0x13f0, value);
            }
        }

        internal Class15 GridBeforeWidth
        {
            get
            {
                return (Class15) this.method_51(0x109a);
            }
            set
            {
                this.GridBeforeWidth.method_50(value.method_49());
                this.GridBeforeWidth.method_52(value.method_51());
            }
        }

        internal bool HasCellSpacing
        {
            [CompilerGenerated]
            get
            {
                return this.bool_6;
            }
            [CompilerGenerated]
            set
            {
                this.bool_6 = value;
            }
        }

        internal bool HasFrameLeft
        {
            get
            {
                return base.method_6(0x104a);
            }
        }

        internal bool HasFrameTop
        {
            get
            {
                return base.method_6(0x105e);
            }
        }

        internal bool HasNondefaultHorizontalAlignment
        {
            get
            {
                return (base.method_6(0x1054) && (this.HorizontalAlignment != RowAlignment.Left));
            }
        }

        internal bool HasNondefaultRelativeHorizontalPosition
        {
            get
            {
                return (base.method_6(0x1036) && (this.RelativeHorizontalPosition != HorizontalRelation.Column));
            }
        }

        internal bool HasNondefaultRelativeVerticalPosition
        {
            get
            {
                return (base.method_6(0x1040) && (this.RelativeVerticalPosition != VerticalRelation.Paragraph));
            }
        }

        internal bool HasNondefaultVerticalAlignment
        {
            get
            {
                return (base.method_6(0x1068) && (this.VerticalAlignment != VerticalPosition.Top));
            }
        }

        internal float Height
        {
            get
            {
                return (float) this.method_51(0x1018);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0x1018, value);
            }
        }

        internal TableRowHeightType HeightType
        {
            get
            {
                if (this.Height >= 0f)
                {
                    return (TableRowHeightType) this.method_51(0x100e);
                }
                return TableRowHeightType.Exactly;
            }
            set
            {
                if (this.HeightType != value)
                {
                    this.method_52(0x100e, value);
                }
            }
        }

        internal bool Hidden
        {
            get
            {
                return (bool) this.method_51(0x11a8);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0x11a8, value);
            }
        }

        public RowAlignment HorizontalAlignment
        {
            get
            {
                return (RowAlignment) this.method_51(0xfaa);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0xfaa, value);
            }
        }

        public bool IsAutoResized
        {
            get
            {
                if (base.OwnerBase is Table)
                {
                    Table ownerBase = base.OwnerBase as Table;
                    return (ownerBase.PreferredTableWidth.method_51() == FtsWidth.Auto);
                }
                return (bool) this.method_51(0x67);
            }
            set
            {
                if (base.OwnerBase is Table)
                {
                    Table ownerBase = base.OwnerBase as Table;
                    if (value)
                    {
                        ownerBase.PreferredTableWidth.method_52(FtsWidth.Auto);
                        ownerBase.PreferredTableWidth.method_50(0f);
                        this.float_2 = 0f;
                    }
                    else if (ownerBase.PreferredTableWidth.method_51() == FtsWidth.Auto)
                    {
                        ownerBase.PreferredTableWidth.method_52(FtsWidth.None);
                        ownerBase.PreferredTableWidth.method_50(0f);
                    }
                }
                this.bool_5 = true;
                this.method_52(0x67, value);
            }
        }

        public bool IsBreakAcrossPages
        {
            get
            {
                return (bool) this.method_51(0x1108);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0x1108, value);
            }
        }

        internal bool IsChangedFormat
        {
            get
            {
                return this.method_59();
            }
            set
            {
                if (value)
                {
                    this.method_60();
                }
            }
        }

        internal bool IsFloating
        {
            get
            {
                if (((!this.HasNondefaultRelativeHorizontalPosition && !this.HasNondefaultRelativeVerticalPosition) && (!this.HasNondefaultHorizontalAlignment && !this.HasNondefaultVerticalAlignment)) && !this.HasFrameLeft)
                {
                    return this.HasFrameTop;
                }
                return true;
            }
        }

        internal bool IsHeader
        {
            get
            {
                return (bool) this.method_51(0xfc8);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0xfc8, value);
            }
        }

        internal int Istd
        {
            get
            {
                return (int) this.method_51(0xfa5);
            }
            set
            {
                this.bool_5 = true;
                this.method_52(0xfa5, value);
            }
        }

        public Spire.Doc.LayoutType LayoutType
        {
            get
            {
                return (Spire.Doc.LayoutType) this.method_51(0x1090);
            }
            set
            {
                if (value == Spire.Doc.LayoutType.Fixed)
                {
                    this.IsAutoResized = false;
                }
                this.bool_5 = true;
                this.method_52(0x1090, value);
            }
        }

        public float LeftIndent
        {
            get
            {
                return this.RowIndent;
            }
            set
            {
                this.RowIndent = value;
            }
        }

        internal int LeftIndent97
        {
            get
            {
                return (int) this.method_51(0x13ee);
            }
            set
            {
                this.method_52(0x13ee, value);
            }
        }

        internal TableRow OwnerRow
        {
            get
            {
                return (base.OwnerBase as TableRow);
            }
        }

        public Spire.Doc.Formatting.Paddings Paddings
        {
            get
            {
                return (this.method_51(3) as Spire.Doc.Formatting.Paddings);
            }
        }

        public TablePositioning Positioning
        {
            get
            {
                return (this.method_51(120) as TablePositioning);
            }
        }

        internal Class15 PreferredWidth
        {
            get
            {
                return this.TablePreferredWidthInfo;
            }
            set
            {
                this.TablePreferredWidthInfo = value;
            }
        }

        internal HorizontalRelation RelativeHorizontalPosition
        {
            get
            {
                return this.Positioning.HorizRelationTo;
            }
            set
            {
                this.Positioning.HorizRelationTo = value;
            }
        }

        internal VerticalRelation RelativeVerticalPosition
        {
            get
            {
                return this.Positioning.VertRelationTo;
            }
            set
            {
                this.Positioning.VertRelationTo = value;
            }
        }

        internal RowFormat RevisedPr
        {
            get
            {
                if (!base.HasFormatRevision)
                {
                    return this;
                }
                return (RowFormat) base.FormatRevision.method_4();
            }
        }

        internal float RowIndent
        {
            get
            {
                if ((!base.HasKey(0x10f4) && base.HasKey(0x13ee)) || (base.HasKey(0x13ee) && (Class59.smethod_4((float) base[0x10f4], (float) ((int) base[0x13ee]), 0.001f) != 0)))
                {
                    base[0x10f4] = ((float) this.LeftIndent97) / 20f;
                }
                return (float) base[0x10f4];
            }
            set
            {
                base[0x10f4] = value;
            }
        }

        internal float Scaling
        {
            get
            {
                if (!(base.OwnerBase is Table))
                {
                    return this.float_2;
                }
                Table ownerBase = base.OwnerBase as Table;
                if (ownerBase.PreferredTableWidth.method_51() == FtsWidth.Percentage)
                {
                    return ownerBase.PreferredTableWidth.method_49();
                }
                return 100f;
            }
            set
            {
                this.float_2 = value;
                if (value != 0f)
                {
                    this.IsAutoResized = false;
                }
                if (base.OwnerBase is Table)
                {
                    Table ownerBase = base.OwnerBase as Table;
                    ownerBase.PreferredTableWidth.method_52(FtsWidth.Percentage);
                    ownerBase.PreferredTableWidth.method_50((float) ((short) value));
                }
            }
        }

        internal Class16 Shading
        {
            get
            {
                return (Class16) this.method_51(0x10ea);
            }
        }

        internal TableStyleOptions TableOption
        {
            get
            {
                return (TableStyleOptions) this.method_51(0x102c);
            }
            set
            {
                this.method_52(0x102c, value);
            }
        }

        internal Class15 TablePreferredWidthInfo
        {
            get
            {
                return (Class15) this.method_51(0x1086);
            }
            set
            {
                this.TablePreferredWidthInfo.method_50(value.method_49());
                this.TablePreferredWidthInfo.method_52(value.method_51());
            }
        }

        internal float TableWidth
        {
            get
            {
                return this.float_3;
            }
            set
            {
                this.float_3 = value;
            }
        }

        internal WidthType TableWidthType
        {
            get
            {
                return this.widthType_0;
            }
            set
            {
                this.widthType_0 = value;
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
                this.bool_5 = true;
                this.Shading.method_63(value);
                this.OnChange(this, 1);
            }
        }

        internal VerticalPosition VerticalAlignment
        {
            get
            {
                return this.Positioning.VertPositionAbs;
            }
        }

        public bool WrapTextAround
        {
            get
            {
                if (base.PropertiesHash.ContainsKey(0x77))
                {
                    return (bool) this.method_51(0x77);
                }
                bool flag5 = false;
                bool flag7 = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3d)) ? !(this.Positioning.HorizPositionEx == 0f) : false;
                bool flag = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3b)) ? ((this.Positioning.HorizPositionAbs != HorizontalPosition.Left) && (this.Positioning.HorizPositionAbs != HorizontalPosition.None)) : false;
                bool flag6 = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3e)) ? !(this.Positioning.VertPositionEx == 0f) : false;
                bool flag3 = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(60)) ? (this.Positioning.VertPositionAbs != VerticalPosition.None) : false;
                bool flag4 = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3f)) ? ((((this.Positioning.HorizRelationTo == HorizontalRelation.Column) && !flag7) && (!flag && !flag6)) && !flag3) : true;
                bool flag2 = this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x40)) ? (((((this.Positioning.VertRelationTo == VerticalRelation.Margin) || (this.Positioning.VertRelationTo == VerticalRelation.Page)) && (!flag7 && !flag)) && !flag6) && !flag3) : true;
                if (((this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3f)) || this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x40))) || ((!flag7 && !flag) && (!flag6 && !flag3))) && (flag4 && flag2))
                {
                    return flag5;
                }
                return true;
            }
            set
            {
                this.method_52(0x77, value);
                if (this.Positioning.PropertiesHash.ContainsKey(this.Positioning.GetFullKey(0x3b)) && (this.Positioning.HorizPositionAbs != HorizontalPosition.Left))
                {
                    if (this.Positioning.HorizPositionAbs == HorizontalPosition.Right)
                    {
                        this.HorizontalAlignment = RowAlignment.Right;
                    }
                    else if (this.Positioning.HorizPositionAbs == HorizontalPosition.Center)
                    {
                        this.HorizontalAlignment = RowAlignment.Center;
                    }
                }
            }
        }

        public class TablePositioning : AttrCollection
        {
            private byte byte_2;
            private byte[] byte_3;
            private byte byte_4;
            internal const float float_0 = 9f;
            internal const int int_10 = 0x3d;
            internal const int int_11 = 0x3e;
            internal const int int_12 = 0x3f;
            internal const int int_13 = 0x40;
            internal const int int_14 = 0x41;
            internal const int int_15 = 0x42;
            internal const int int_16 = 0x43;
            internal const int int_17 = 0x44;
            internal const int int_18 = 0x45;
            internal const int int_7 = 0x3b;
            internal const int int_8 = 60;
            private int int_9;
            private long long_2;
            internal RowFormat rowFormat_0;

            internal TablePositioning(RowFormat A_0)
            {
                this.rowFormat_0 = A_0;
            }

            internal TablePositioning(FormatBase A_0, int A_1) : base(A_0, A_1)
            {
                this.rowFormat_0 = (RowFormat) A_0;
            }

            internal override void ApplyProperty()
            {
                if (base.m_propsUpdateFlags != null)
                {
                    base.m_propsUpdateFlags.Clear();
                }
                Type type = typeof(RowFormat.TablePositioning);
                foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
                {
                    int num2 = (int) info.GetValue(info.FieldType);
                    this.rowFormat_0.method_55(num2);
                }
            }

            protected override object GetDefValue(int key)
            {
                return this.rowFormat_0.GetDefValue(key);
            }

            internal override bool HasValue(int propertyKey)
            {
                return base.HasValue(propertyKey);
            }

            internal object method_46(int A_0)
            {
                if (this.rowFormat_0.method_6(this.GetFullKey(A_0)))
                {
                    return this.rowFormat_0.method_51(this.GetFullKey(A_0));
                }
                return base[A_0];
            }

            private void method_47(int A_0, object A_1)
            {
                this.rowFormat_0.method_52(this.GetFullKey(A_0), A_1);
            }

            internal override void SetAttr(int propKey, object value)
            {
                this.method_47(propKey, value);
            }

            public float DistanceFromBottom
            {
                get
                {
                    return (float) this.method_46(0x42);
                }
                set
                {
                    this.method_47(0x42, value);
                }
            }

            public float DistanceFromLeft
            {
                get
                {
                    return (float) this.method_46(0x43);
                }
                set
                {
                    this.method_47(0x43, value);
                }
            }

            public float DistanceFromRight
            {
                get
                {
                    return (float) this.method_46(0x44);
                }
                set
                {
                    this.method_47(0x44, value);
                }
            }

            public float DistanceFromTop
            {
                get
                {
                    return (float) this.method_46(0x41);
                }
                set
                {
                    this.method_47(0x41, value);
                }
            }

            public float HorizPosition
            {
                get
                {
                    return ((((float) this.method_46(0x3d)) - 1f) / 20f);
                }
                set
                {
                    this.method_47(0x3d, (value * 20f) + 1f);
                }
            }

            public HorizontalPosition HorizPositionAbs
            {
                get
                {
                    return (HorizontalPosition) ((short) this.method_46(0x3b));
                }
                set
                {
                    this.method_47(0x3b, (short) value);
                }
            }

            internal float HorizPositionEx
            {
                get
                {
                    return (((float) this.method_46(0x3d)) / 20f);
                }
                set
                {
                    this.method_47(0x3d, value * 20f);
                }
            }

            public HorizontalRelation HorizRelationTo
            {
                get
                {
                    return (HorizontalRelation) this.method_46(0x3f);
                }
                set
                {
                    this.method_47(0x3f, value);
                }
            }

            internal bool TableOverlap
            {
                get
                {
                    return (bool) this.method_46(0x45);
                }
                set
                {
                    this.method_47(0x45, value);
                }
            }

            public float VertPosition
            {
                get
                {
                    return ((((float) this.method_46(0x3e)) - 1f) / 20f);
                }
                set
                {
                    this.method_47(0x3e, (value * 20f) + 1f);
                }
            }

            public VerticalPosition VertPositionAbs
            {
                get
                {
                    return (VerticalPosition) ((short) this.method_46(60));
                }
                set
                {
                    this.method_47(60, (short) value);
                }
            }

            internal float VertPositionEx
            {
                get
                {
                    return (((float) this.method_46(0x3e)) / 20f);
                }
                set
                {
                    this.method_47(0x3e, value * 20f);
                }
            }

            public VerticalRelation VertRelationTo
            {
                get
                {
                    return (VerticalRelation) this.method_46(0x40);
                }
                set
                {
                    this.method_47(0x40, value);
                }
            }
        }
    }
}

