namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Core.Biff_Records;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Xml;

    public abstract class Style : DocumentSerializable, IStyle, Interface46, IRunAttrSource
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_10;
        private bool bool_2;
        private bool bool_3;
        private bool bool_4;
        private bool bool_5;
        private bool bool_6;
        internal bool bool_7;
        internal bool bool_8;
        internal bool bool_9;
        protected const int DEF_USER_STYLE_ID = 0xffe;
        private Dictionary<string, string> dictionary_0;
        private Dictionary<string, int> dictionary_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private int int_8;
        protected IStyle m_baseStyle;
        protected Spire.Doc.Formatting.CharacterFormat m_chFormat;
        protected bool m_isCustom;
        protected bool m_isPrimaryStyle;
        protected bool m_isSemiHidden;
        protected string m_linkStyle;
        protected string m_nextStyle;
        protected ParagraphFormat m_ParaPr;
        protected byte[] m_tapx;
        protected bool m_unhideWhenUsed;
        private string string_3;
        private string string_4;
        private StyleCollection styleCollection_0;
        private Spire.Doc.Documents.StyleIdentifier styleIdentifier_0;
        private Spire.Doc.Documents.StyleType styleType_0;
        internal WordStyleType wordStyleType_0;

        protected Style(Document doc) : base(doc, doc)
        {
            this.int_2 = 0xffe;
            this.string_4 = string.Empty;
            this.styleIdentifier_0 = Spire.Doc.Documents.StyleIdentifier.Nil;
            this.m_chFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            this.m_chFormat.method_0(this);
            this.string_3 = BookmarkStart.b("稨弪听䌮吰", 3) + doc.Styles.Count;
        }

        public void ApplyBaseStyle(BuiltinStyle bStyle)
        {
            IStyle style = base.m_doc.AddStyle(bStyle);
            if (style != null)
            {
                this.ApplyBaseStyle(style.Name);
            }
        }

        internal virtual void ApplyBaseStyle(IStyle bStyle)
        {
            int num = 0x12;
            if (bStyle == null)
            {
                throw new ArgumentException(BookmarkStart.b("瘷唹᰻䴽㔿⅁ⱃ晅⩇⭉㽋⭍灏⅑⁓⽕㑗㽙籛癝䁟䁡", num) + bStyle + BookmarkStart.b("ᨷᨹᔻḽ⤿ⱁ摃≅❇⥉㥋⍍㕏㱑⁓", num));
            }
            this.m_baseStyle = bStyle;
            this.CharacterFormat.ApplyBase(((Style) this.BaseStyle).CharacterFormat);
        }

        public virtual void ApplyBaseStyle(string styleName)
        {
            int num = 7;
            this.m_baseStyle = base.m_doc.Styles.FindByName(styleName, this.StyleType);
            if (this.m_baseStyle == null)
            {
                this.m_baseStyle = base.m_doc.Styles.FindByName(styleName);
            }
            if (this.m_baseStyle == null)
            {
                throw new ArgumentException(BookmarkStart.b("挬䀮ᄰ䀲䀴吶儸ᬺ弼帾㉀♂敄㑆㵈㉊⅌⩎煐筒畔畖", num) + styleName + BookmarkStart.b("༬༮ᠰጲ尴夶ᤸ强刼尾㑀⹂⁄⥆㵈", num));
            }
            this.CharacterFormat.ApplyBase(((Style) this.BaseStyle).CharacterFormat);
        }

        public abstract IStyle Clone();
        protected override object CloneImpl()
        {
            Style style = (Style) base.CloneImpl();
            style.m_chFormat = new Spire.Doc.Formatting.CharacterFormat(base.Document);
            style.m_chFormat.ImportContainer(this.CharacterFormat);
            style.m_chFormat.method_21(this.CharacterFormat);
            style.styleIdentifier_0 = this.StyleIdentifier;
            return style;
        }

        internal override void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
            if (this.m_baseStyle != null)
            {
                if (doc.Styles.FindByName(this.m_baseStyle.Name, this.StyleType) == null)
                {
                    doc.Styles.Add(this.m_baseStyle.Clone());
                    string key = this.method_19(this.m_baseStyle.Name);
                    if ((base.Document.StyleNameIds.ContainsValue(this.m_baseStyle.Name) && !doc.StyleNameIds.ContainsValue(this.m_baseStyle.Name)) && !doc.StyleNameIds.ContainsKey(key))
                    {
                        doc.StyleNameIds.Add(key, this.m_baseStyle.Name);
                    }
                    if (doc.CurClonedSection != null)
                    {
                        Dictionary<string, string> dictionary2 = (this.m_baseStyle.StyleType == Spire.Doc.Documents.StyleType.CharacterStyle) ? doc.Styles.OldCharStylesHolder : doc.Styles.OldParaStylesHolder;
                        if (dictionary2.ContainsKey(this.m_baseStyle.StyleId))
                        {
                            dictionary2.Add(this.m_baseStyle.StyleId, this.m_baseStyle.Name);
                        }
                    }
                    if (!doc.Styles.EmbedDocumentCloneStyleName.ContainsKey(this.m_baseStyle.StyleId))
                    {
                        doc.Styles.EmbedDocumentCloneStyleName.Add(this.m_baseStyle.StyleId, this.m_baseStyle.Name);
                    }
                }
                else if (doc.CurClonedSection != null)
                {
                    Dictionary<string, string> dictionary = (this.m_baseStyle.StyleType == Spire.Doc.Documents.StyleType.CharacterStyle) ? doc.Styles.OldCharStylesHolder : doc.Styles.OldParaStylesHolder;
                    if (dictionary.ContainsKey(this.m_baseStyle.StyleId))
                    {
                        (this.m_baseStyle as Style).method_7(dictionary[this.m_baseStyle.StyleId]);
                    }
                    else if ((doc.Styles.FindByName(this.m_baseStyle.Name, this.StyleType) != null) && !doc.ImportStyles)
                    {
                        this.m_baseStyle = doc.Styles.FindByName(this.m_baseStyle.Name, this.StyleType);
                    }
                    else
                    {
                        this.m_baseStyle = this.method_16(this.m_baseStyle, doc);
                    }
                }
                this.CharacterFormat.ApplyBase(((Style) this.BaseStyle).CharacterFormat);
            }
        }

        protected virtual IStyle CloneStyleTo(Document doc)
        {
            return this.Clone();
        }

        internal virtual void Close()
        {
            if (this.m_chFormat != null)
            {
                this.m_chFormat.Close();
                this.m_chFormat = null;
            }
            this.m_tapx = null;
            this.dictionary_0 = null;
            this.dictionary_1 = null;
        }

        public static Style CreateBuiltinStyle(BuiltinStyle bStyle, Document doc)
        {
            Style style = new ParagraphStyle(doc, bStyle);
            BuiltinStyleLoader.smethod_0(style, bStyle);
            if ((style.Name == BookmarkStart.b("木䐪弬䈮倰弲", 3)) && (style.StyleType == Spire.Doc.Documents.StyleType.ParagraphStyle))
            {
                (style as ParagraphStyle).CharacterFormat.LocaleIdASCII = 0x409;
                style.method_6();
            }
            return style;
        }

        public static IStyle CreateBuiltinStyle(BuiltinStyle bStyle, Spire.Doc.Documents.StyleType type, Document doc)
        {
            IStyle style = null;
            switch (type)
            {
                case Spire.Doc.Documents.StyleType.ParagraphStyle:
                    style = new ParagraphStyle(doc, bStyle);
                    break;

                case Spire.Doc.Documents.StyleType.CharacterStyle:
                    style = new Class11(doc);
                    break;

                case Spire.Doc.Documents.StyleType.ListStyle:
                    style = new ListStyle(doc);
                    break;
            }
            BuiltinStyleLoader.smethod_0(style, bStyle);
            return style;
        }

        protected override void InitXDLSHolder()
        {
            base.XDLSHolder.EnableID = true;
            base.XDLSHolder.AddRefElement(BookmarkStart.b("嬸娺丼娾", 0x13), this.m_baseStyle);
            base.XDLSHolder.AddElement(BookmarkStart.b("娸区尼䴾⁀⁂ㅄ≆㭈晊⭌⁎⍐㹒㑔⍖", 0x13), this.m_chFormat);
        }

        internal void method_10(StyleCollection A_0)
        {
            this.styleCollection_0 = A_0;
        }

        internal void method_11(Spire.Doc.Documents.StyleType A_0)
        {
            this.styleType_0 = A_0;
        }

        internal void method_12(int A_0)
        {
            this.method_13(A_0, false);
        }

        internal void method_13(int A_0, bool A_1)
        {
            if (A_1)
            {
                this.styleCollection_0.method_25(this, this.StyleDocId, A_0);
            }
            this.int_2 = this.int_3 = A_0;
            this.method_17();
            switch (this.StyleType)
            {
            }
        }

        internal void method_14(Spire.Doc.Documents.StyleIdentifier A_0)
        {
            this.method_15(A_0, false);
        }

        internal void method_15(Spire.Doc.Documents.StyleIdentifier A_0, bool A_1)
        {
            if (A_1)
            {
                this.styleCollection_0.method_24(this, this.StyleIdentifier, A_0);
            }
            this.styleIdentifier_0 = A_0;
        }

        internal IStyle method_16(IStyle A_0, Document A_1)
        {
            int num = 0;
            IStyle style = null;
            if (A_0 != null)
            {
                string str4;
                style = A_0.Clone();
                string newValue = Guid.NewGuid().ToString();
                string name = (style as Style).Name;
                string styleId = (style as Style).StyleId;
                if (smethod_0(name, out str4))
                {
                    name = name.Replace(str4, newValue);
                    if ((style as Style).HasStyleId)
                    {
                        if (smethod_0(name, out str4))
                        {
                            styleId = styleId.Replace(str4, newValue);
                        }
                        else
                        {
                            styleId = styleId + BookmarkStart.b("礥", num) + newValue;
                        }
                    }
                }
                else
                {
                    name = name + BookmarkStart.b("礥", num) + newValue;
                    if ((style as Style).HasStyleId)
                    {
                        styleId = styleId + BookmarkStart.b("礥", num) + newValue;
                    }
                }
                (style as Style).method_7(name);
                if ((style as Style).HasStyleId)
                {
                    (style as Style).method_5(styleId);
                }
                (style as Style).StyleDocId = 0xffe;
                (style as Style).styleIdentifier_0 = Spire.Doc.Documents.StyleIdentifier.User;
                if (style.Name.Length > 0x3f)
                {
                    (style as Style).method_7(style.Name.Substring(0, 0x3f));
                }
                if (((A_1 != base.Document) && (style is ParagraphStyle)) && ((style as ParagraphStyle).ListFormat.method_6(1) && ((style as ParagraphStyle).ListFormat.ListType != ListType.NoList)))
                {
                    ListFormat listFormat = (style as ParagraphStyle).ListFormat;
                    if ((A_1.CurClonedSection != null) && A_1.Styles.OldListStyleHolder.ContainsKey((A_0 as ParagraphStyle).ListFormat.CurrentListStyle.Name))
                    {
                        listFormat.ApplyStyle(A_1.Styles.OldListStyleHolder[(A_0 as ParagraphStyle).ListFormat.CurrentListStyle.Name]);
                        if (A_0.StyleId == listFormat.CurrentListLevel.ParaStyleName)
                        {
                            listFormat.CurrentListLevel.ParaStyleName = style.StyleId;
                        }
                    }
                    else
                    {
                        ListStyle style2 = listFormat.CurrentListStyle.Clone() as ListStyle;
                        A_1.ListStyles.Add(style2);
                        listFormat.ApplyStyle(style2.Name);
                        if (A_0.StyleId == listFormat.CurrentListLevel.ParaStyleName)
                        {
                            listFormat.CurrentListLevel.ParaStyleName = style.StyleId;
                        }
                        if (A_1.CurClonedSection != null)
                        {
                            A_1.Styles.OldListStyleHolder.Add((A_0 as ParagraphStyle).ListFormat.CurrentListStyle.Name, style2.Name);
                        }
                    }
                    if (!string.IsNullOrEmpty(listFormat.LFOStyleName))
                    {
                        Class12 class2 = base.Document.ListOverrides.method_35(listFormat.LFOStyleName);
                        if (class2 != null)
                        {
                            A_1.ListOverrides.method_34((Class12) class2.Clone());
                        }
                    }
                }
                if (A_1.CurClonedSection != null)
                {
                    if ((A_0.StyleType == Spire.Doc.Documents.StyleType.ParagraphStyle) && !A_1.Styles.OldParaStylesHolder.ContainsKey(A_0.StyleId))
                    {
                        A_1.Styles.OldParaStylesHolder.Add(A_0.StyleId, style.Name);
                    }
                    else if ((A_0.StyleType == Spire.Doc.Documents.StyleType.CharacterStyle) && !A_1.Styles.OldCharStylesHolder.ContainsKey(A_0.StyleId))
                    {
                        A_1.Styles.OldCharStylesHolder.Add(A_0.StyleId, style.Name);
                    }
                }
                if (!A_1.Styles.EmbedDocumentCloneStyleName.ContainsKey(A_0.StyleId))
                {
                    A_1.Styles.EmbedDocumentCloneStyleName.Add(A_0.StyleId, style.Name);
                }
                A_1.Styles.Add(style);
            }
            return style;
        }

        private void method_17()
        {
            if (this.int_4 == this.int_3)
            {
                this.int_4 = 0xfff;
            }
            if (this.int_7 == this.int_3)
            {
                this.int_7 = 0xfff;
            }
        }

        internal void method_18(Document A_0)
        {
            IStyle style = this.CloneStyleTo(A_0);
            if (A_0.Styles.FindByName(style.Name, style.StyleType) == null)
            {
                A_0.Styles.Add(style);
                string key = this.method_19(style.Name);
                if ((base.Document.StyleNameIds.ContainsValue(style.Name) && !A_0.StyleNameIds.ContainsValue(style.Name)) && !A_0.StyleNameIds.ContainsKey(key))
                {
                    A_0.StyleNameIds.Add(key, style.Name);
                }
            }
            if (A_0.CurClonedSection != null)
            {
                if ((this.StyleType == Spire.Doc.Documents.StyleType.CharacterStyle) && !A_0.Styles.OldCharStylesHolder.ContainsKey(this.StyleId))
                {
                    A_0.Styles.OldCharStylesHolder.Add(this.StyleId, this.Name);
                }
                else if ((this.StyleType == Spire.Doc.Documents.StyleType.ParagraphStyle) && !A_0.Styles.OldParaStylesHolder.ContainsKey(this.StyleId))
                {
                    A_0.Styles.OldParaStylesHolder.Add(this.StyleId, this.Name);
                }
            }
            if (!A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(this.StyleId))
            {
                A_0.Styles.EmbedDocumentCloneStyleName.Add(this.StyleId, this.Name);
            }
        }

        private string method_19(string A_0)
        {
            string str = "";
            using (Dictionary<string, string>.Enumerator enumerator = base.Document.StyleNameIds.GetEnumerator())
            {
                KeyValuePair<string, string> current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.Value == A_0)
                    {
                        goto Label_003C;
                    }
                }
                return str;
            Label_003C:
                str = current.Key;
            }
            return str;
        }

        internal IStyle method_20(Document A_0, IStyle A_1)
        {
            if (this.StyleType == A_1.StyleType)
            {
                string name = string.Empty;
                if ((A_1.StyleType == Spire.Doc.Documents.StyleType.CharacterStyle) && A_0.Styles.OldCharStylesHolder.ContainsKey(A_1.StyleId))
                {
                    name = A_0.Styles.OldCharStylesHolder[A_1.StyleId];
                }
                else if (A_0.Styles.OldParaStylesHolder.ContainsKey(A_1.StyleId))
                {
                    name = A_0.Styles.OldParaStylesHolder[A_1.StyleId];
                }
                else if (A_0.Styles.EmbedDocumentCloneStyleName.ContainsKey(A_1.StyleId))
                {
                    name = A_0.Styles.EmbedDocumentCloneStyleName[A_1.StyleId];
                }
                if ((name != null) && (name.Length > 0))
                {
                    IStyle style = A_0.Styles.FindByName(name, A_1.StyleType);
                    if (style != null)
                    {
                        return style;
                    }
                }
                else
                {
                    return this.method_16(this, A_0);
                }
            }
            return this;
        }

        internal void method_21()
        {
            this.dictionary_0 = new Dictionary<string, string>();
            this.dictionary_0.Add(BookmarkStart.b("弰尲䜴娶堸场", 11), BookmarkStart.b("缰尲䜴娶堸场", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ灀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ灀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ獀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ獀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ牀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ牀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ畀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ畀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ瑀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ瑀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ着", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ着", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ癀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ癀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ祀", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ祀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶倸唺娼Ἶ础", 11), BookmarkStart.b("礰嘲吴匶倸唺娼Ἶ础", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ఼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ఼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ༼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ༼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ฼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ฼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ़", 11), BookmarkStart.b("砰崲儴制䄸ᬺ़", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ࠼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ࠼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ଼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ଼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ਼", 11), BookmarkStart.b("砰崲儴制䄸ᬺ਼", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺԼ", 11), BookmarkStart.b("砰崲儴制䄸ᬺԼ", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺм", 11), BookmarkStart.b("砰崲儴制䄸ᬺм", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶࠸", 11), BookmarkStart.b("攰簲瘴᜶࠸", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶ସ", 11), BookmarkStart.b("攰簲瘴᜶ସ", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶ਸ", 11), BookmarkStart.b("攰簲瘴᜶ਸ", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶സ", 11), BookmarkStart.b("攰簲瘴᜶സ", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶స", 11), BookmarkStart.b("攰簲瘴᜶స", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶༸", 11), BookmarkStart.b("攰簲瘴᜶༸", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶ุ", 11), BookmarkStart.b("攰簲瘴᜶ุ", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶ĸ", 11), BookmarkStart.b("攰簲瘴᜶ĸ", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲嘴᜶8", 11), BookmarkStart.b("攰簲瘴᜶8", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲䜴娶堸场ᴼ嘾⽀❂⁄⥆㵈", 11), BookmarkStart.b("缰尲䜴娶堸场ᴼ瘾⽀❂⁄⥆㵈", 11));
            this.dictionary_0.Add(BookmarkStart.b("地尲娴䌶圸吺䤼娾慀㝂⁄㽆㵈", 11), BookmarkStart.b("眰尲娴䌶圸吺䤼娾慀ᝂ⁄㽆㵈", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲場娶尸唺䤼Ἶ㕀♂㵄㍆", 11), BookmarkStart.b("爰尲場娶尸唺䤼Ἶᕀ♂㵄㍆", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰嘲吴匶尸䤺", 11), BookmarkStart.b("礰嘲吴匶尸䤺", 11));
            this.dictionary_0.Add(BookmarkStart.b("地尲娴䌶尸䤺", 11), BookmarkStart.b("眰尲娴䌶尸䤺", 11));
            this.dictionary_0.Add(BookmarkStart.b("堰崲儴制䄸ᬺ唼娾⁀❂ⱄ⥆⹈", 11), BookmarkStart.b("砰崲儴制䄸ᬺ甼娾⁀❂ⱄ⥆⹈", 11));
            this.dictionary_0.Add(BookmarkStart.b("到刲䔴䌶倸吺匼", 11), BookmarkStart.b("爰刲䔴䌶倸吺匼", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ刼夾慀╂ⱄ⁆㱈㥊⡌㱎", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ刼夾慀Ղⱄ⁆㱈㥊⡌㱎", 11));
            this.dictionary_0.Add(BookmarkStart.b("地尲娴䌶圸吺䤼娾慀ㅂ⁄ⅆⱈ㥊⡌ⅎ㉐㙒", 11), BookmarkStart.b("眰尲娴䌶圸吺䤼娾慀ᅂ⁄ⅆⱈ㥊⡌ⅎ㉐㙒", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲場娶尸唺䤼Ἶ㍀♂⍄≆㭈⹊⍌ⱎ㑐", 11), BookmarkStart.b("爰尲場娶尸唺䤼Ἶፀ♂⍄≆㭈⹊⍌ⱎ㑐", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲嬴制ᤸ唺䠼刾⍀♂㝄", 11), BookmarkStart.b("細娲嬴制ᤸ町䠼刾⍀♂㝄", 11));
            this.dictionary_0.Add(BookmarkStart.b("䄰刲刴制ᤸ唺䠼刾⍀♂㝄", 11), BookmarkStart.b("愰刲刴制ᤸ町䠼刾⍀♂㝄", 11));
            this.dictionary_0.Add(BookmarkStart.b("吰崲儴夶嘸伺堼Ἶ㍀♂⍄≆㭈⹊⍌ⱎ㑐", 11), BookmarkStart.b("琰崲儴夶嘸伺堼Ἶፀ♂⍄≆㭈⹊⍌ⱎ㑐", 11));
            this.dictionary_0.Add(BookmarkStart.b("吰崲儴夶嘸伺堼Ἶ㕀♂㵄㍆", 11), BookmarkStart.b("琰崲儴夶嘸伺堼Ἶᕀ♂㵄㍆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ刼夾慀≂い㍆ⅈ⑊㽌♎═㩒ご⑖", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ刼夾慀ɂい㍆ⅈ⑊㽌♎═㩒ご⑖", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰刲嘴䔶嘸", 11), BookmarkStart.b("簰刲嘴䔶嘸ᬺ椼娾㥀㝂", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰尲吴᜶儸帺尼嬾⡀ⵂ≄", 11), BookmarkStart.b("攰簲琴᜶焸帺尼嬾⡀ⵂ≄", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶", 11), BookmarkStart.b("細娲䘴䌶", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ夺䠼匾ⵀ♂ㅄ", 11), BookmarkStart.b("細娲䘴䌶ᤸ示䠼匾ⵀ♂ㅄ", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ唺䠼刾⍀♂㝄", 11), BookmarkStart.b("細娲䘴䌶ᤸ町䠼刾⍀♂㝄", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸऺ", 11), BookmarkStart.b("細娲䘴䌶ᤸऺ", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ࠺", 11), BookmarkStart.b("細娲䘴䌶ᤸ࠺", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ༺", 11), BookmarkStart.b("細娲䘴䌶ᤸ༺", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸฺ", 11), BookmarkStart.b("細娲䘴䌶ᤸฺ", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ夺䠼匾ⵀ♂ㅄ杆筈", 11), BookmarkStart.b("細娲䘴䌶ᤸ示䠼匾ⵀ♂ㅄ杆筈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ夺䠼匾ⵀ♂ㅄ杆穈", 11), BookmarkStart.b("細娲䘴䌶ᤸ示䠼匾ⵀ♂ㅄ杆穈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ夺䠼匾ⵀ♂ㅄ杆絈", 11), BookmarkStart.b("細娲䘴䌶ᤸ示䠼匾ⵀ♂ㅄ杆絈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ夺䠼匾ⵀ♂ㅄ杆籈", 11), BookmarkStart.b("細娲䘴䌶ᤸ示䠼匾ⵀ♂ㅄ杆籈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ唺䠼刾⍀♂㝄杆筈", 11), BookmarkStart.b("細娲䘴䌶ᤸ町䠼刾⍀♂㝄杆筈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ唺䠼刾⍀♂㝄杆穈", 11), BookmarkStart.b("細娲䘴䌶ᤸ町䠼刾⍀♂㝄杆穈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ唺䠼刾⍀♂㝄杆絈", 11), BookmarkStart.b("細娲䘴䌶ᤸ町䠼刾⍀♂㝄杆絈", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ唺䠼刾⍀♂㝄杆籈", 11), BookmarkStart.b("細娲䘴䌶ᤸ町䠼刾⍀♂㝄杆籈", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰娲䄴嬶尸", 11), BookmarkStart.b("攰娲䄴嬶尸", 11));
            this.dictionary_0.Add(BookmarkStart.b("到弲娴䐶倸唺娼", 11), BookmarkStart.b("爰弲娴䐶倸唺娼", 11));
            this.dictionary_0.Add(BookmarkStart.b("䈰娲刴夶堸伺䠼䴾⑀", 11), BookmarkStart.b("戰娲刴夶堸伺䠼䴾⑀", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰嘲匴嘶䰸场䤼Ἶㅀ≂㝄♆⹈㥊ⱌ㽎㥐獒㍔㡖㝘⽚", 11), BookmarkStart.b("田嘲匴嘶䰸场䤼Ἶᅀ≂㝄♆⹈㥊ⱌ㽎㥐獒ፔ㡖㝘⽚", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂ⱄ⥆ⵈ⹊⍌㭎", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂ౄ⥆ⵈ⹊⍌㭎", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ堺刼儾㕀⩂⭄㉆ⱈ", 11), BookmarkStart.b("細娲䘴䌶ᤸ砺刼儾㕀⩂⭄㉆ⱈ", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ堺刼儾㕀⩂⭄㉆ⱈ歊罌", 11), BookmarkStart.b("細娲䘴䌶ᤸ砺刼儾㕀⩂⭄㉆ⱈ歊罌", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ堺刼儾㕀⩂⭄㉆ⱈ歊繌", 11), BookmarkStart.b("細娲䘴䌶ᤸ砺刼儾㕀⩂⭄㉆ⱈ歊繌", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ堺刼儾㕀⩂⭄㉆ⱈ歊祌", 11), BookmarkStart.b("細娲䘴䌶ᤸ砺刼儾㕀⩂⭄㉆ⱈ歊祌", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲䘴䌶ᤸ堺刼儾㕀⩂⭄㉆ⱈ歊硌", 11), BookmarkStart.b("細娲䘴䌶ᤸ砺刼儾㕀⩂⭄㉆ⱈ歊硌", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲䘴䐶堸尺堼Ἶ⥀♂⑄⍆ⱈ㥊", 11), BookmarkStart.b("簰嘲䘴䐶堸尺堼Ἶी♂⑄⍆ⱈ㥊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䈰䘲圴䌶倸伺儼娾", 11), BookmarkStart.b("戰䘲圴䌶倸伺儼娾", 11));
            this.dictionary_0.Add(BookmarkStart.b("䈰刲头䈶䴸娺䤼嘾⹀ⵂ", 11), BookmarkStart.b("戰刲头䈶䴸娺䤼嘾⹀ⵂ", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䄴制", 11), BookmarkStart.b("田刲䄴制", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂⍄⹆㭈㡊㥌潎㡐㵒ㅔ㉖㝘⽚", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂̈́⹆㭈㡊㥌潎ᡐ㵒ㅔ㉖㝘⽚", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂⍄⹆㭈㡊㥌潎㡐㵒ㅔ㉖㝘⽚絜浞", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂̈́⹆㭈㡊㥌潎ᡐ㵒ㅔ㉖㝘⽚絜浞", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲䄴制ᤸ区堼帾╀⩂⭄⁆", 11), BookmarkStart.b("缰尲䄴制ᤸ猺堼帾╀⩂⭄⁆", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂睄", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂睄", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂癄", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂癄", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂ⱄ⥆ⵈ⹊⍌㭎煐慒", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂ౄ⥆ⵈ⹊⍌㭎煐慒", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰尲儴丶ᤸ伺堼䜾㕀捂ⱄ⥆ⵈ⹊⍌㭎煐恒", 11), BookmarkStart.b("猰尲儴丶ᤸ漺堼䜾㕀捂ౄ⥆ⵈ⹊⍌㭎煐恒", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰弲娴吶券ᬺ䤼娾㥀㝂", 11), BookmarkStart.b("猰弲娴吶券ᬺ椼娾㥀㝂", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䨲䔴制䬸场吼儾⩀", 11), BookmarkStart.b("礰䨲䔴制䬸场吼儾⩀", 11));
            this.dictionary_0.Add(BookmarkStart.b("地尲头嬶嘸䰺堼嬾⥀㩂㕄≆㭈❊⑌ⅎ㩐", 11), BookmarkStart.b("眰尲头嬶嘸䰺堼嬾ी㩂㕄≆㭈❊⑌ⅎ㩐", 11));
            this.dictionary_0.Add(BookmarkStart.b("䈰䜲䜴堶圸尺", 11), BookmarkStart.b("戰䜲䜴堶圸尺", 11));
            this.dictionary_0.Add(BookmarkStart.b("吰帲䔴弶堸䠺吼䰾", 11), BookmarkStart.b("琰帲䔴弶堸䠺吼䰾", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰尲嘴䈶吸帺匼䬾慀⹂⑄㝆", 11), BookmarkStart.b("田尲嘴䈶吸帺匼䬾慀โ⑄㝆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䄰弲吴帶圸ᬺ䤼娾㥀㝂", 11), BookmarkStart.b("愰弲吴帶圸ᬺ椼娾㥀㝂", 11));
            this.dictionary_0.Add(BookmarkStart.b("吰Ḳ場嘶倸场ᴼ䰾⡀⑂⭄♆㵈㹊㽌⩎", 11), BookmarkStart.b("琰Ḳ場嘶倸场ᴼ氾⡀⑂⭄♆㵈㹊㽌⩎", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲䜴娶堸场ᴼ᜾㙀♂❄湆", 11), BookmarkStart.b("缰尲䜴娶堸场ᴼ᜾ᙀ♂❄湆", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ娺帼䴾⹀ⵂ㱄⩆", 11), BookmarkStart.b("礰朲破笶ᤸ稺帼䴾⹀ⵂ㱄⩆", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ娺夼嬾㍀♂㙄㑆", 11), BookmarkStart.b("礰朲破笶ᤸ稺夼嬾㍀♂㙄㑆", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ堺吼䬾⑀", 11), BookmarkStart.b("礰朲破笶ᤸ砺吼䬾⑀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ堺刼嬾⑀", 11), BookmarkStart.b("礰朲破笶ᤸ砺刼嬾⑀", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ强堼夾⡀ⵂⱄ㍆⁈⑊⍌", 11), BookmarkStart.b("礰朲破笶ᤸ缺堼夾⡀ⵂⱄ㍆⁈⑊⍌", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ债堼䘾⍀ⱂ⑄㕆ⵈ", 11), BookmarkStart.b("礰朲破笶ᤸ瀺堼䘾⍀ⱂ⑄㕆ⵈ", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ䬺似娾❀ⱂ㝄⩆⡈㽊㥌⩎㕐", 11), BookmarkStart.b("礰朲破笶ᤸ欺似娾❀ⱂ㝄⩆⡈㽊㥌⩎㕐", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ䠺尼刾ㅀ⽂⁄", 11), BookmarkStart.b("礰朲破笶ᤸ栺尼刾ㅀ⽂⁄", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ伺䐼伾⑀㑂㝄⹆㵈⹊㽌", 11), BookmarkStart.b("礰朲破笶ᤸ漺䐼伾⑀㑂㝄⹆㵈⹊㽌", 11));
            this.dictionary_0.Add(BookmarkStart.b("夰䜲場嬶ᤸ䴺尼䴾⡀≂❄⭆ⱈ", 11), BookmarkStart.b("礰朲破笶ᤸ洺尼䴾⡀≂❄⭆ⱈ", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲場娶尸唺䤼Ἶ㉀㙂❄ⵆⱈ⡊㥌", 11), BookmarkStart.b("爰尲場娶尸唺䤼Ἶቀ㙂❄ⵆⱈ⡊㥌", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲ᔴ嬶倸䠺䤼", 11), BookmarkStart.b("缰尲ᔴ笶倸䠺䤼", 11));
            this.dictionary_0.Add(BookmarkStart.b("匰刲头嬶嘸吺匼Ἶ㕀♂㵄㍆", 11), BookmarkStart.b("猰刲头嬶嘸吺匼Ἶᕀ♂㵄㍆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䐰䀲倴䔶", 11), BookmarkStart.b("搰䀲倴䔶", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲䘴䌶䀸场堼", 11), BookmarkStart.b("缰尲昴䌶䀸场堼", 11));
            this.dictionary_0.Add(BookmarkStart.b("弰尲䜴娶堸场ᴼ䬾⁀⅂⥄≆", 11), BookmarkStart.b("缰尲䜴娶堸场ᴼ款⁀⅂⥄≆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈", 11), BookmarkStart.b("ᄰ缲尴倶儸伺ᴼ氾⥀≂⅄⹆❈ⱊ", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ丼圾⁀❂ⱄ⥆⹈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("細娲刴弶䴸ᬺ渼圾⁀❂ⱄ⥆⹈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒摔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒摔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒杔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒杔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒晔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒晔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒慔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒慔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒恔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒恔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ儼嘾㉀㝂敄♆⩈⡊⡌ⅎ═獒捔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ焼嘾㉀㝂敄ن⩈⡊⡌ⅎ═獒捔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒摔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂敄ن⩈⡊⡌ⅎ═獒摔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒杔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂敄ن⩈⡊⡌ⅎ═獒杔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒晔", 11), BookmarkStart.b("ᄰ缲尴倶儸伺ᴼ砾㍀⩂⅄杆ࡈ⡊⹌⩎㽐❒畔摖", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒慔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂敄ن⩈⡊⡌ⅎ═獒慔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒恔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂敄ن⩈⡊⡌ⅎ═獒恔", 11));
            this.dictionary_0.Add(BookmarkStart.b("崰娲刴弶䴸ᬺ娼䴾⡀❂敄♆⩈⡊⡌ⅎ═獒捔", 11), BookmarkStart.b("細娲刴弶䴸ᬺ稼䴾⡀❂敄ن⩈⡊⡌ⅎ═獒捔", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞偠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞偠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞占", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞占", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞剠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞剠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞啠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞啠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞呠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞呠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌繎煐㉒㙔㑖㱘㕚⥜罞坠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌繎煐ቒ㙔㑖㱘㕚⥜罞坠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞偠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞偠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞占", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞占", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞剠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞剠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞啠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞啠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞呠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞呠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ䰾⥀≂⅄⹆❈ⱊ浌絎煐㉒㙔㑖㱘㕚⥜罞坠", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ氾⥀≂⅄⹆❈ⱊ浌絎煐ቒ㙔㑖㱘㕚⥜罞坠", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆硈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆硈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ匾⡀あㅄ杆筈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ猾⡀あㅄ杆筈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆硈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆硈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆筈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆筈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖汘", 11));
            this.dictionary_0.Add(BookmarkStart.b("尰嘲儴帶䰸嘺ᴼ堾㍀⩂⅄杆穈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("簰嘲儴帶䰸嘺ᴼ砾㍀⩂⅄杆穈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐扒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐扒", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐慒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐慒", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐恒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐恒", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐杒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐杒", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐晒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐晒", 11));
            this.dictionary_0.Add(BookmarkStart.b("唰刲䜴尶ᤸ场吼䰾㕀捂⑄⑆⩈⹊⍌㭎煐敒", 11), BookmarkStart.b("田刲䜴尶ᤸ眺吼䰾㕀捂ф⑆⩈⹊⍌㭎煐敒", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞偠", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞偠", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞占", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞占", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞剠", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞剠", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞啠", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞啠", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞呠", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞呠", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀あⵄ♆ⵈ≊⍌⡎煐㉒㙔㑖㱘㕚⥜罞坠", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀၂ⵄ♆ⵈ≊⍌⡎煐ቒ㙔㑖㱘㕚⥜罞坠", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⽂ⱄ㑆㵈歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀གⱄ㑆㵈歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘橚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘橚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘楚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘楚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘桚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘桚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘潚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘潚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘湚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘湚", 11));
            this.dictionary_0.Add(BookmarkStart.b("到尲头堶䬸崺䠼匾慀⑂㝄⹆ⵈ歊ⱌⱎ㉐㙒㭔⍖祘浚", 11), BookmarkStart.b("爰尲头堶䬸崺䠼匾慀т㝄⹆ⵈ歊ౌⱎ㉐㙒㭔⍖祘浚", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ฼嬾慀♂⍄ⅆⱈ⡊㥌㱎煐扒", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ฼笾慀♂⍄ⅆⱈ⡊㥌㱎煐扒", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ฼嬾慀♂⍄ⅆⱈ⡊㥌㱎煐慒", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ฼笾慀♂⍄ⅆⱈ⡊㥌㱎煐慒", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ฼嬾慀♂⍄ⅆⱈ⡊㥌㱎煐恒", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ฼笾慀♂⍄ⅆⱈ⡊㥌㱎煐恒", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼匾⁀あ㙄⹆⩈歊籌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼匾⁀あ㙄⹆⩈歊籌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼匾⁀あ㙄⹆⩈歊罌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼匾⁀あ㙄⹆⩈歊罌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼匾⁀あ㙄⹆⩈歊繌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼匾⁀あ㙄⹆⩈歊繌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼匾⁀あ㙄⹆⩈歊祌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼匾⁀あ㙄⹆⩈歊祌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀⱂ㝄ⅆ㱈❊浌繎", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀⱂ㝄ⅆ㱈❊浌繎", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀⱂ㝄ⅆ㱈❊浌絎", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀⱂ㝄ⅆ㱈❊浌絎", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀⱂ㝄ⅆ㱈❊浌籎", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀⱂ㝄ⅆ㱈❊浌籎", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀ㙂⡄⥆㩈歊籌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀ㙂⡄⥆㩈歊籌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀ㙂⡄⥆㩈歊罌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀ㙂⡄⥆㩈歊罌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀ㙂⡄⥆㩈歊繌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀ㙂⡄⥆㩈歊繌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀ㙂⡄⥆㩈歊祌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀ㙂⡄⥆㩈歊祌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾ⵀ㙂⡄⥆㩈歊硌", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾ⵀ㙂⡄⥆㩈歊硌", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ帼倾⽀㝂⁄⩆㥈⑊㽌⹎⍐⩒", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ縼倾⽀㝂⁄⩆㥈⑊㽌⹎⍐⩒", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ堼匾⑀⑂⑄⥆㵈", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ砼匾⑀⑂⑄⥆㵈", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄癆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄癆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄畆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄畆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄瑆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄瑆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄獆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄獆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄牆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄牆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄煆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄煆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄灆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄灆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ娼䴾⡀❂敄罆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ稼䴾⡀❂敄罆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄癆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄癆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄畆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄畆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄瑆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄瑆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄獆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄獆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄牆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄牆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄煆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄煆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄灆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄灆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ儼嘾㉀㝂敄罆", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ焼嘾㉀㝂敄罆", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ䴼䴾⹀╂⁄㑆㩈≊≌ⅎぐ㽒", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ洼䴾⹀╂⁄㑆㩈≊≌ⅎぐ㽒", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ丼嘾ⱀ㍂⥄≆楈穊", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ渼嘾ⱀ㍂⥄≆楈穊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ丼嘾ⱀ㍂⥄≆楈祊", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ渼嘾ⱀ㍂⥄≆楈祊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ丼嘾ⱀ㍂⥄≆楈硊", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ渼嘾ⱀ㍂⥄≆楈硊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ丼䨾⍀㝂⥄≆楈穊", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ渼䨾⍀㝂⥄≆楈穊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ丼䨾⍀㝂⥄≆楈祊", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ渼䨾⍀㝂⥄≆楈祊", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ䤼圾⑀⹂⁄", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ椼圾⑀⹂⁄", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ䨼娾⍀捂瑄", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ樼娾⍀捂瑄", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ䨼娾⍀捂睄", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ樼娾⍀捂睄", 11));
            this.dictionary_0.Add(BookmarkStart.b("䔰刲圴嬶尸ᬺ䨼娾⍀捂癄", 11), BookmarkStart.b("攰刲圴嬶尸ᬺ樼娾⍀捂癄", 11));
        }

        private void method_22()
        {
            this.dictionary_1 = new Dictionary<string, int>();
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧堩䄫伭尯", 0), 0);
            this.dictionary_1.Add(BookmarkStart.b("䈥䴧䰩䴫嬭尯䘱䐳圵䨷嬹嬻䰽ℿ㉁ⱃ⁅❇⑉㡋", 0), 0x41);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧天尫伭匯嬱娳儵", 0), 0x9d);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱Գ", 0), 1);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱س", 0), 2);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱ܳ", 0), 3);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱3", 0), 4);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱ĳ", 0), 5);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱ȳ", 0), 6);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱̳", 0), 7);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱ళ", 0), 8);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䜭帯唱ള", 0), 9);
            this.dictionary_1.Add(BookmarkStart.b("別䄧帩䀫䬭", 0), 0x3e);
            this.dictionary_1.Add(BookmarkStart.b("唥崧䠩堫䜭䐯帱儳", 0), 0x4a);
            this.dictionary_1.Add(BookmarkStart.b("唥崧䠩堫䈭唯圱夳䘵倷嬹伻圽㌿", 0), 260);
            this.dictionary_1.Add(BookmarkStart.b("䌥䔧娩䐫伭䌯嬱䜳", 0), 0x58);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧帩䤫䀭䌯圱儳嬵䠷刹崻䴽⤿ㅁ", 0), 0x105);
            this.dictionary_1.Add(BookmarkStart.b("唥尧堩䌫䀭圯", 0), 0x57);
            this.dictionary_1.Add(BookmarkStart.b("圥崧䔩堫䬭", 0), 180);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧帩䤫䀭䌯圱䔳䌵圷丹夻", 0), 0xb5);
            this.dictionary_1.Add(BookmarkStart.b("唥崧䠩堫䈭唯䀱儳倵崷䠹夻倽⌿❁", 0), 0x106);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧帩䤫䀭䌯圱䘳匵帷弹主嬽⸿⅁⅃", 0), 0x107);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧䔩䜫娭夯䘱堳匵", 0), 0x108);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫席儯䀱唳儵䨷嬹䰻嘽", 0), 0xb3);
            this.dictionary_1.Add(BookmarkStart.b("䔥䤧娩堫䜭弯就", 0), 0x22);
            this.dictionary_1.Add(BookmarkStart.b("䐥䄧䠩䀫䜭弯唱䘳圵䠷刹䔻", 0), 0x109);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᴫ", 0), 0x13);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ḫ", 0), 20);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩Ἣ", 0), 0x15);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᠫ", 0), 0x16);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᤫ", 0), 0x17);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᨫ", 0), 0x18);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᬫ", 0), 0x19);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᐫ", 0), 0x1a);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩ᔫ", 0), 0x1b);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䤩䐫䬭儯嘱崳堵強", 0), 0x10a);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵", 0), 0x9a);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻", 0), 0x9e);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇等", 0), 0xac);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇硉", 0), 190);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇祉", 0), 0xcc);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇繉", 0), 0xda);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇罉", 0), 0xe8);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭䌯娱唳刵儷吹嬻弽⌿⅁⅃⡅㱇籉", 0), 0xf6);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵", 0), 0x9f);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁畃", 0), 0xad);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁癃", 0), 0xbf);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁睃", 0), 0xcd);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁灃", 0), 0xdb);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁煃", 0), 0xe9);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭尯嬱䜳䈵夷夹弻嬽⸿㙁牃", 0), 0xf7);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵", 0), 160);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁畃", 0), 0xae);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁癃", 0), 0xc0);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁睃", 0), 0xce);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁灃", 0), 220);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁煃", 0), 0xea);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䴩䐫娭圯䀱崳刵夷夹弻嬽⸿㙁牃", 0), 0xf8);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿", 0), 0xa1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋罍", 0), 0xaf);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋籍", 0), 0xc1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋絍", 0), 0xcf);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋積", 0), 0xdd);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋筍", 0), 0xeb);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽焿⍁❃╅ⵇ⑉㡋硍", 0), 0xf9);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿", 0), 0xa2);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋罍", 0), 0xb0);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋籍", 0), 0xc2);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋絍", 0), 0xd0);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋積", 0), 0xde);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋筍", 0), 0xec);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯䄱尳圵尷匹刻夽爿⍁❃╅ⵇ⑉㡋硍", 0), 250);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ", 0), 0xa3);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅祇", 0), 0xb1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅穇", 0), 0xc3);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅筇", 0), 0xd1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅籇", 0), 0xdf);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅絇", 0), 0xed);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷ହ崻崽⌿❁⩃㉅繇", 0), 0xfb);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹", 0), 0xa4);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅祇", 0), 0xb6);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅穇", 0), 0xc4);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅筇", 0), 210);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅籇", 0), 0xe0);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅絇", 0), 0xee);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯帱崳䔵䰷࠹崻崽⌿❁⩃㉅繇", 0), 0xfc);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ", 0), 0xa5);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅祇", 0), 0xb7);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅穇", 0), 0xc5);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅筇", 0), 0xd3);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅籇", 0), 0xe1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅絇", 0), 0xef);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ହ崻崽⌿❁⩃㉅繇", 0), 0xfd);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹", 0), 0xa6);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅祇", 0), 0xb8);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅穇", 0), 0xc6);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅筇", 0), 0xd4);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅籇", 0), 0xe2);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅絇", 0), 240);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷࠹崻崽⌿❁⩃㉅繇", 0), 0xfe);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह", 0), 0xa7);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅祇", 0), 0xb9);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅穇", 0), 0xc7);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅筇", 0), 0xd5);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅籇", 0), 0xe3);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅絇", 0), 0xf1);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧丩䔫嬭崯唱䘳張尷ह崻崽⌿❁⩃㉅繇", 0), 0xff);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳", 0), 0xa8);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿獁", 0), 0xba);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿灁", 0), 200);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿煁", 0), 0xd6);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿癁", 0), 0xe4);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿睁", 0), 0xf2);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧堩䜫䈭夯䄱䀳圵嬷夹夻倽㐿瑁", 0), 0x100);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁", 0), 0xa9);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍慏牑", 0), 0xbb);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍扏", 0), 0xc9);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍捏牑", 0), 0xd7);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍摏", 0), 0xe5);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍敏", 0), 0xf3);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳䔵倷嬹堻圽⸿╁╃╅⭇⽉≋㩍晏", 0), 0x101);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻", 0), 170);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇等", 0), 0xbc);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇硉", 0), 0xca);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇祉", 0), 0xd8);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇繉", 0), 230);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇罉", 0), 0xf4);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳娵儷䤹䠻弽⌿⅁⅃⡅㱇籉", 0), 0x102);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻", 0), 0xab);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇等", 0), 0xbd);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇硉", 0), 0xcb);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇祉", 0), 0xd9);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇繉", 0), 0xe7);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇罉", 0), 0xf5);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䘩䌫尭嘯䜱堳儵䨷匹堻弽⌿⅁⅃⡅㱇籉", 0), 0x103);
            this.dictionary_1.Add(BookmarkStart.b("䐥䤧䘩䀫䄭弯就䀳匵䀷丹", 0), 0x99);
            this.dictionary_1.Add(BookmarkStart.b("䐥䐧䔩伫䔭䐯圱䰳䈵", 0), 0x54);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳", 0), 0x42);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳е", 0), 80);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳Ե", 0), 0x51);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳倵儷䠹伻䨽⤿ⱁ⁃⍅♇㹉", 0), 0x4d);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳倵儷䠹伻䨽⤿ⱁ⁃⍅♇㹉繋", 0), 0x4e);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳張嘷帹夻倽㐿", 0), 0x43);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳張嘷帹夻倽㐿灁", 0), 0x52);
            this.dictionary_1.Add(BookmarkStart.b("䐥䜧丩唫娭唯䨱䀳張嘷帹夻倽㐿煁", 0), 0x53);
            this.dictionary_1.Add(BookmarkStart.b("䔥䐧䔩弫䜭帯唱", 0), 0x3f);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䜩䄫䬭帯䘱䘳匵帷弹主嬽⸿⅁⅃", 0), 0x27);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䜩䄫䬭帯䘱䜳䌵娷倹夻崽㐿", 0), 0x6a);
            this.dictionary_1.Add(BookmarkStart.b("䔥䜧䜩䄫䬭帯䘱䀳匵䀷丹", 0), 30);
            this.dictionary_1.Add(BookmarkStart.b("䈥䤧帩䤫", 0), 0x4c);
            this.dictionary_1.Add(BookmarkStart.b("䈥䜧䤩夫䌭唯就䀳嬵夷䨹", 0), 0x59);
            this.dictionary_1.Add(BookmarkStart.b("䌥ԧ䜩䴫䜭尯䄱崳儵嘷嬹䠻䬽㈿❁", 0), 0x5b);
            this.dictionary_1.Add(BookmarkStart.b("䌥䘧丩䈫䄭䐯圱䘳匵帷弹主嬽⸿⅁⅃", 0), 0x2a);
            this.dictionary_1.Add(BookmarkStart.b("䌥䘧丩䈫䄭䐯圱䀳匵䀷丹", 0), 0x2b);
            this.dictionary_1.Add(BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳圵尷帹主嬽㌿ㅁ", 0), 0x24);
            this.dictionary_1.Add(BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳䐵崷丹䤻䰽⸿", 0), 0x25);
            this.dictionary_1.Add(BookmarkStart.b("䀥䜧䘩䀫䄭䜯圱倳帵䄷䨹夻䰽ⰿ⭁⩃ⵅ", 0), 0x56);
            this.dictionary_1.Add(BookmarkStart.b("䀥䜧䔩堫䬭䈯", 0), 0x20);
            this.dictionary_1.Add(BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳䐵崷尹夻䰽┿ⱁ❃⍅", 0), 0x26);
            this.dictionary_1.Add(BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳䈵崷䈹䠻", 0), 0x1d);
            this.dictionary_1.Add(BookmarkStart.b("严䴧䬩䠫䬭䈯", 0), 0x1f);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫伭匯䀱嬳堵䄷圹", 0), 0x5f);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫伭启嘱䘳匵䬷䤹", 0), 0x60);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫䴭夯䘱儳", 0), 0x61);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫䴭弯嘱儳", 0), 0x62);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫䨭唯吱崳堵儷丹唻儽⸿", 0), 0x63);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫䔭唯䬱嘳夵夷䠹堻", 0), 100);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫席䈯圱刳夵䨷圹崻䨽㐿❁⁃", 0), 0x65);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫崭儯弱䐳娵崷", 0), 0x66);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫娭䤯䈱儳䄵䨷匹䠻嬽㈿", 0), 0x67);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫堭儯䀱崳圵娷嘹夻", 0), 0x68);
            this.dictionary_1.Add(BookmarkStart.b("严儧娩䤫尭尯嬱娳崵", 0), 0x55);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭į", 0), 10);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭ȯ", 0), 11);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭̯", 0), 12);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭Я", 0), 13);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭ԯ", 0), 14);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭د", 0), 15);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭ܯ", 0), 0x10);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭࠯", 0), 0x11);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭य", 0), 0x12);
            this.dictionary_1.Add(BookmarkStart.b("伥䘧丩䤫嘭堯圱唳刵儷吹嬻", 0), 0x21);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧䐩䤫䀭䔯弱嘳匵䨷", 0), 40);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫", 0), 0x2f);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫ᰭ", 0), 50);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫ᴭ", 0), 0x33);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫ᨭ", 0), 0x34);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫ᬭ", 0), 0x35);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䰭䔯帱堳匵䰷", 0), 0x30);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䰭䔯帱堳匵䰷࠹", 0), 0x36);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䰭䔯帱堳匵䰷ह", 0), 0x37);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䰭䔯帱堳匵䰷ู", 0), 0x38);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䰭䔯帱堳匵䰷༹", 0), 0x39);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䴭弯就䀳張嘷伹夻", 0), 0x44);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䴭弯就䀳張嘷伹夻ఽ", 0), 0x45);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䴭弯就䀳張嘷伹夻ഽ", 0), 70);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䴭弯就䀳張嘷伹夻਽", 0), 0x47);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䴭弯就䀳張嘷伹夻ଽ", 0), 0x48);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䀭䔯弱嘳匵䨷", 0), 0x31);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䀭䔯弱嘳匵䨷࠹", 0), 0x3a);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䀭䔯弱嘳匵䨷ह", 0), 0x3b);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䀭䔯弱嘳匵䨷ู", 0), 60);
            this.dictionary_1.Add(BookmarkStart.b("䨥䄧天堫䀭䔯弱嘳匵䨷༹", 0), 0x3d);
            this.dictionary_1.Add(BookmarkStart.b("䬥䤧䤩師䄭䐯圱䰳䈵", 0), 0x2d);
            this.dictionary_1.Add(BookmarkStart.b("䬥䴧天弫伭圯圱尳匵夷帹夻䰽", 0), 0x49);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧䘩䔫崭䐯", 0), 0x6b);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧堩䄫伭尯ᨱ䌳匵娷ጹ", 0), 0x5e);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧堩䄫伭尯嬱娳刵崷吹䠻", 0), 0x1c);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧帩䤫䘭唯匱倳張嘷崹", 0), 0x4f);
            this.dictionary_1.Add(BookmarkStart.b("嘥䤧䴩䤫䀭䔯弱嘳匵䨷", 0), 0x29);
            this.dictionary_1.Add(BookmarkStart.b("嘥䐧䬩伫䬭堯崱堳刵崷䠹䠻嬽㠿㙁", 0), 0x9c);
            this.dictionary_1.Add(BookmarkStart.b("嘥䐧䬩䔫䀭䐯圱䰳䈵", 0), 90);
            this.dictionary_1.Add(BookmarkStart.b("唥䤧䘩夫娭儯䘱崳夵嘷", 0), 0x4b);
            this.dictionary_1.Add(BookmarkStart.b("唥䄧䴩䈫伭䐯䜱䘳匵", 0), 0x40);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭̯嘱儳倵帷弹弻䨽㌿獁", 0), 0x8e);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭̯嘱儳倵帷弹弻䨽㌿灁", 0), 0x8f);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭̯嘱儳倵帷弹弻䨽㌿煁", 0), 0x90);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯帱唳䔵䬷匹弻༽", 0), 0x72);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯帱唳䔵䬷匹弻ఽ", 0), 0x73);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯帱唳䔵䬷匹弻ഽ", 0), 0x74);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯帱唳䔵䬷匹弻਽", 0), 0x75);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳夵䨷尹䤻刽焿", 0), 0x76);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳夵䨷尹䤻刽爿", 0), 0x77);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳夵䨷尹䤻刽猿", 0), 120);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳䌵唷吹伻༽", 0), 0x79);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳䌵唷吹伻ఽ", 0), 0x7a);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳䌵唷吹伻ഽ", 0), 0x7b);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳䌵唷吹伻਽", 0), 0x7c);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱堳䌵唷吹伻ଽ", 0), 0x7d);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭匯崱娳䈵崷圹䰻儽㈿⍁㙃㽅", 0), 0x91);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭唯帱儳儵夷吹䠻", 0), 0x92);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵ष", 0), 0x7e);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵਷", 0), 0x7f);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵ଷ", 0), 0x80);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵ష", 0), 0x81);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵ഷ", 0), 130);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵ื", 0), 0x83);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵༷", 0), 0x84);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭圯䀱崳刵7", 0), 0x85);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵ष", 0), 0x86);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵਷", 0), 0x87);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵ଷ", 0), 0x88);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵ష", 0), 0x89);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵ഷ", 0), 0x8a);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵ื", 0), 0x8b);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵༷", 0), 140);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭尯嬱䜳䈵7", 0), 0x8d);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭帯崱䘳嬵夷嘹", 0), 0x69);
            this.dictionary_1.Add(BookmarkStart.b("䠥䜧堩䄫伭尯䘱唳吵吷弹", 0), 0x69);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭弯吱唳䌵䰷刹医䰽⤿㙁ⵃ⍅㭇", 0), 0x2c);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭弯吱刳張強伹主嬽㌿", 0), 0x23);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䀯䀱嬳倵崷䤹伻圽⼿ⱁ╃⩅", 0), 0x93);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䌯嬱夳䘵吷弹഻", 0), 0x6f);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䌯嬱夳䘵吷弹฻", 0), 0x70);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䌯嬱夳䘵吷弹༻", 0), 0x71);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䌯䜱嘳䈵吷弹഻", 0), 0x94);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䌯䜱嘳䈵吷弹฻", 0), 0x95);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䐯娱儳嬵崷", 0), 0x9b);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䜯圱嘳ܵ", 0), 150);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䜯圱嘳е", 0), 0x97);
            this.dictionary_1.Add(BookmarkStart.b("別䤧䠩䀫䬭䜯圱嘳Ե", 0), 0x98);
            this.dictionary_1.Add(BookmarkStart.b("別䜧䬩䐫䬭儯嘱崳堵強", 0), 0x2e);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫娭弯䈱嬳倵帷唹主匽", 0), 0x5c);
            this.dictionary_1.Add(BookmarkStart.b("严尧䜩䀫䰭弯䘱䀳夵唷唹娻堽⼿ぁ⥃", 0), 0x5d);
            this.dictionary_1.Add(BookmarkStart.b("吥䴧尩䔫崭夯崱娳", 0), 0xb2);
            this.dictionary_1.Add(BookmarkStart.b("䤥崧帩䀫䜭帯圱堳張䬷丹഻", 0), 0x6c);
            this.dictionary_1.Add(BookmarkStart.b("䤥崧帩䀫䜭帯圱堳張䬷丹฻", 0), 0x6d);
            this.dictionary_1.Add(BookmarkStart.b("䤥崧帩䀫䜭帯圱堳張䬷丹༻", 0), 110);
        }

        internal void method_6()
        {
            ParagraphStyle style = this as ParagraphStyle;
            style.CharacterFormat.BaseFormat = null;
            style.ParagraphFormat.BaseFormat = null;
            style.m_baseStyle = null;
        }

        internal void method_7(string A_0)
        {
            int num = 6;
            if ((A_0 == null) || (A_0.Length == 0))
            {
                throw new ArgumentNullException(BookmarkStart.b("缫娭䤯帱儳ᘵ瘷嬹儻嬽怿ㅁⱃ⥅㵇♉⡋湍㹏㵑⁓癕㩗㽙籛そᕟ๡ࡣ䙥ݧᡩ䱫୭ᵯɱsཱུ", num));
            }
            this.string_3 = A_0;
        }

        internal void method_8(string A_0)
        {
            this.method_9(A_0, false);
        }

        internal void method_9(string A_0, bool A_1)
        {
            if (A_1)
            {
                this.styleCollection_0.method_23(this, this.string_3, A_0);
            }
            this.string_3 = A_0;
        }

        public static BuiltinStyle NameToBuiltIn(string styleName)
        {
            string str = styleName.Trim();
            BuiltinStyle user = BuiltinStyle.User;
            int length = BuiltinStyleLoader.string_2.Length;
            for (int i = 0; i < length; i++)
            {
                if (BuiltinStyleLoader.string_2[i] == str)
                {
                    return (BuiltinStyle) i;
                }
            }
            return user;
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            this.string_3 = reader.ReadString(BookmarkStart.b("缰刲場制", 11));
            this.int_2 = this.int_3 = reader.ReadInt(BookmarkStart.b("戰䜲䰴嬶尸爺夼", 11));
        }

        protected override void RestoreReference(string name, int index)
        {
            if (index > -1)
            {
                this.m_baseStyle = base.Document.Styles[index];
            }
        }

        internal static bool smethod_0(string A_0, out string A_1)
        {
            int num = 15;
            A_1 = string.Empty;
            char[] separator = new char[] { '-' };
            if (A_0.Contains(BookmarkStart.b("樴", 15)) && A_0.Contains(BookmarkStart.b("ᠴ", num)))
            {
                int startIndex = A_0.LastIndexOf(BookmarkStart.b("樴", num)) + 1;
                if (A_0.Length > startIndex)
                {
                    A_1 = A_0.Substring(startIndex);
                }
                string[] strArray = A_1.Split(separator);
                if ((((strArray.Length == 5) && ((A_1.Length - 4) == 0x20)) && ((strArray[0].Length == 8) && (strArray[1].Length == 4))) && (((strArray[2].Length == 4) && (strArray[3].Length == 4)) && (strArray[4].Length == 12)))
                {
                    return true;
                }
            }
            return false;
        }

        internal static IStyle smethod_1(Spire.Doc.Documents.StyleType A_0, Document A_1)
        {
            switch (A_0)
            {
                case Spire.Doc.Documents.StyleType.ParagraphStyle:
                    return new ParagraphStyle(A_1);

                case Spire.Doc.Documents.StyleType.CharacterStyle:
                    return new Class11(A_1);

                case Spire.Doc.Documents.StyleType.TableStyle:
                    return new Class13(A_1);

                case Spire.Doc.Documents.StyleType.ListStyle:
                    return new ListStyle(A_1);
            }
            return null;
        }

        internal static Style smethod_2(Spire.Doc.Documents.StyleType A_0, int A_1, Spire.Doc.Documents.StyleIdentifier A_2, string A_3, Document A_4)
        {
            Style style = (Style) smethod_1(A_0, A_4);
            style.int_3 = style.int_2 = A_1;
            style.styleIdentifier_0 = A_2;
            style.string_3 = A_3;
            style.int_5 = A_1;
            return style;
        }

        internal static IStyle smethod_3(DefaultTableStyle A_0, Document A_1)
        {
            IStyle style = new Class13(A_1);
            BuiltinStyleLoader.smethod_3(style, A_0);
            return style;
        }

        internal static string smethod_4(BuiltinStyle A_0)
        {
            return BuiltinStyleLoader.string_2[(int) A_0];
        }

        internal static string smethod_5(DefaultTableStyle A_0)
        {
            return BuiltinStyleLoader.string_3[(int) A_0];
        }

        internal static bool smethod_6(BuiltinStyle A_0)
        {
            return BuiltinStyleLoader.smethod_2(A_0);
        }

        void Interface46.ClearParaAttrs()
        {
            this.ParaPr.ClearAttrs();
        }

        object Interface46.FetchInheritedParaAttr(int key)
        {
            return this.ParaPr.method_33(key);
        }

        object Interface46.FetchParaAttr(int key)
        {
            return this.ParaPr.method_32(key);
        }

        object Interface46.GetDirectParaAttr(int key)
        {
            return this.ParaPr.method_31(key);
        }

        void Interface46.GetDirectParaAttrByIndex(int index, out int key, out object value)
        {
            key = this.ParaPr.method_18(index);
            value = this.ParaPr.method_19(index);
        }

        void Interface46.RemoveParaAttr(int key)
        {
            this.ParaPr.Remove(key);
        }

        void Interface46.SetParaAttr(int key, object value)
        {
            this.ParaPr.SetAttr(key, value);
        }

        void IRunAttrSource.ClearRunAttrs()
        {
            this.RunPr.ClearAttrs();
        }

        object IRunAttrSource.FetchInheritedRunAttr(int key)
        {
            return this.RunPr.method_33(key);
        }

        object IRunAttrSource.GetDirectRunAttr(int key)
        {
            return this.RunPr.method_31(key);
        }

        void IRunAttrSource.GetDirectRunAttrByIndex(int index, out int key, out object value)
        {
            key = this.RunPr.method_18(index);
            value = this.RunPr.method_19(index);
        }

        void IRunAttrSource.SetRunAttr(int key, object value)
        {
            this.RunPr.SetAttr(key, value);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            writer.WriteValue(BookmarkStart.b("怭儯弱儳", 8), this.Name);
            writer.WriteValue(BookmarkStart.b("紭䐯䬱堳匵焷帹", 8), this.int_2);
            writer.WriteValue(BookmarkStart.b("娭䤯䈱儳", 8), this.StyleType);
        }

        internal bool AutomaticallyUpdate
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        internal int BasedOnIstd
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
                this.method_17();
            }
        }

        internal IStyle BaseStyle
        {
            get
            {
                return this.m_baseStyle;
            }
        }

        internal bool BuiltIn
        {
            get
            {
                return (this.styleIdentifier_0 != Spire.Doc.Documents.StyleIdentifier.User);
            }
        }

        internal Dictionary<string, int> BuiltinStyleIds
        {
            get
            {
                if (this.dictionary_1 == null)
                {
                    this.method_22();
                }
                return this.dictionary_1;
            }
        }

        internal Dictionary<string, string> BuiltinStyles
        {
            get
            {
                if (this.dictionary_0 == null)
                {
                    this.method_21();
                }
                return this.dictionary_0;
            }
        }

        public Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.m_chFormat;
            }
        }

        public BuiltinStyle DefaultStyleType
        {
            get
            {
                return NameToBuiltIn(this.Name);
            }
        }

        internal bool HasStyleId
        {
            get
            {
                return !string.IsNullOrEmpty(this.string_4);
            }
        }

        internal bool Hidden
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        int Interface46.DirectParaAttrsCount
        {
            get
            {
                return this.ParaPr.Count;
            }
        }

        public bool IsCustomStyle
        {
            get
            {
                return this.m_isCustom;
            }
            set
            {
                this.m_isCustom = value;
            }
        }

        internal bool IsPrimaryStyle
        {
            get
            {
                return this.m_isPrimaryStyle;
            }
            set
            {
                this.m_isPrimaryStyle = value;
            }
        }

        internal bool IsSemiHidden
        {
            get
            {
                return this.m_isSemiHidden;
            }
            set
            {
                this.m_isSemiHidden = value;
            }
        }

        internal int Istd
        {
            get
            {
                return this.int_3;
            }
        }

        internal bool LidsSet
        {
            get
            {
                return this.bool_10;
            }
            set
            {
                this.bool_10 = value;
            }
        }

        internal int LinkedIstd
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
                this.method_17();
            }
        }

        internal string LinkStyle
        {
            get
            {
                return this.m_linkStyle;
            }
            set
            {
                this.m_linkStyle = value;
            }
        }

        internal bool Locked
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
            }
        }

        public string Name
        {
            get
            {
                return this.string_3;
            }
            set
            {
                int num = 4;
                if ((value == null) || ((value.Length == 0) && !base.Document.bool_3))
                {
                    throw new ArgumentNullException(BookmarkStart.b("搩䴫䌭唯", num));
                }
                if (((this.StyleType == Spire.Doc.Documents.StyleType.ParagraphStyle) && (value == BookmarkStart.b("搩䌫尭崯匱堳", num))) && !base.Document.bool_7)
                {
                    base.Document.Styles.InnerList.Remove(this.m_baseStyle);
                    this.method_6();
                    base.Document.bool_7 = true;
                }
                if (((!base.Document.bool_3 && !base.Document.bool_4) && (!base.Document.bool_5 && (base.Document != null))) && (base.Document.Styles.FindByName(value, this.StyleType) != null))
                {
                    throw new ArgumentException(BookmarkStart.b("搩䴫䌭唯ሱ嬳倵ᠷ䤹䠻䜽ⰿ❁摃≅㵇㩉⁋❍㍏㍑⁓㍕癗", num));
                }
                string key = value.Replace(BookmarkStart.b("਩", num), string.Empty).ToLower();
                string str = (!string.IsNullOrEmpty(this.string_4) ? this.string_4 : key).ToLower();
                if (!this.BuiltinStyleIds.ContainsKey(str) && !this.BuiltinStyleIds.ContainsKey(key))
                {
                    this.StyleDocId = 0xffe;
                    if (this.styleIdentifier_0 == Spire.Doc.Documents.StyleIdentifier.Nil)
                    {
                        this.styleIdentifier_0 = Spire.Doc.Documents.StyleIdentifier.User;
                    }
                }
                else
                {
                    this.StyleDocId = this.BuiltinStyleIds.ContainsKey(str) ? this.BuiltinStyleIds[str] : this.BuiltinStyleIds[key];
                    if (this.styleIdentifier_0 == Spire.Doc.Documents.StyleIdentifier.Nil)
                    {
                        this.styleIdentifier_0 = (Spire.Doc.Documents.StyleIdentifier) this.StyleDocId;
                    }
                }
                this.string_3 = value;
            }
        }

        internal int NextIstd
        {
            get
            {
                return this.int_5;
            }
            set
            {
                this.int_5 = value;
            }
        }

        internal string NextStyle
        {
            get
            {
                if (this.m_nextStyle == null)
                {
                    return null;
                }
                if (base.Document.DetectedFormatType == FileFormat.Doc)
                {
                    if (base.Document.Styles.FindByName(this.m_nextStyle) != null)
                    {
                        return this.m_nextStyle;
                    }
                    return this.Name;
                }
                if (base.Document.StyleNameIds.ContainsKey(this.m_nextStyle))
                {
                    return base.Document.StyleNameIds[this.m_nextStyle];
                }
                return this.Name;
            }
            set
            {
                this.m_nextStyle = value;
            }
        }

        internal virtual ParagraphFormat ParaPr
        {
            get
            {
                return this.m_ParaPr;
            }
        }

        internal bool Personal
        {
            get
            {
                return this.bool_5;
            }
            set
            {
                this.bool_5 = value;
            }
        }

        internal bool PersonalCompose
        {
            get
            {
                return this.bool_3;
            }
            set
            {
                this.bool_3 = value;
            }
        }

        internal bool PersonalReply
        {
            get
            {
                return this.bool_4;
            }
            set
            {
                this.bool_4 = value;
            }
        }

        internal bool QuickFormat
        {
            get
            {
                return this.bool_6;
            }
            set
            {
                this.bool_6 = value;
            }
        }

        internal int Rsid
        {
            get
            {
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
            }
        }

        internal virtual Spire.Doc.Formatting.CharacterFormat RunPr
        {
            get
            {
                return this.m_chFormat;
            }
        }

        int IRunAttrSource.DirectRunAttrsCount
        {
            get
            {
                return this.RunPr.Count;
            }
        }

        internal int StyleDocId
        {
            get
            {
                return this.int_2;
            }
            set
            {
                this.int_3 = this.int_2 = value;
            }
        }

        public string StyleId
        {
            get
            {
                int num = 5;
                if (!string.IsNullOrEmpty(this.string_4))
                {
                    return this.string_4;
                }
                if (!string.IsNullOrEmpty(this.string_3))
                {
                    return this.string_3.Replace(BookmarkStart.b("ପ", num), string.Empty);
                }
                return this.string_3;
            }
            internal set
            {
                this.string_4 = value;
            }
        }

        internal Spire.Doc.Documents.StyleIdentifier StyleIdentifier
        {
            get
            {
                if (this.styleIdentifier_0 == Spire.Doc.Documents.StyleIdentifier.Nil)
                {
                    this.styleIdentifier_0 = (Spire.Doc.Documents.StyleIdentifier) this.StyleDocId;
                }
                return this.styleIdentifier_0;
            }
        }

        internal StyleCollection Styles
        {
            get
            {
                return this.styleCollection_0;
            }
        }

        public abstract Spire.Doc.Documents.StyleType StyleType { get; }

        internal byte[] TableStyleData
        {
            get
            {
                return this.m_tapx;
            }
            set
            {
                this.m_tapx = value;
            }
        }

        internal WordStyleType TypeCode
        {
            get
            {
                return this.wordStyleType_0;
            }
            set
            {
                if ((this.StyleType == Spire.Doc.Documents.StyleType.ParagraphStyle) && (value != WordStyleType.ParagraphStyle))
                {
                    this.method_6();
                }
                this.wordStyleType_0 = value;
            }
        }

        internal int UIPriority
        {
            get
            {
                return this.int_8;
            }
            set
            {
                this.int_8 = value;
            }
        }

        internal bool UnhideWhenUsed
        {
            get
            {
                return this.m_unhideWhenUsed;
            }
            set
            {
                this.m_unhideWhenUsed = value;
            }
        }

        public class BuiltinStyleLoader
        {
            private byte[] byte_0;
            private float float_0;
            private const int int_0 = 10;
            private long[] long_0;
            private long[] long_1;
            [ThreadStatic]
            private static Stream stream_0 = null;
            private const string string_0 = "Spire.Doc.Resources";
            private const string string_1 = "builtin-styles";
            internal static readonly string[] string_2 = new string[] { 
                BookmarkStart.b("稳夵䨷圹崻刽", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁畃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁癃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁睃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁灃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁煃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁牃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁獃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁籃", 14), BookmarkStart.b("簳匵夷帹唻倽✿扁絃", 14), BookmarkStart.b("紳堵尷弹䐻ḽ焿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ爿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ猿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ琿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ甿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ瘿", 14), 
                BookmarkStart.b("紳堵尷弹䐻ḽ眿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ砿", 14), BookmarkStart.b("紳堵尷弹䐻ḽ礿", 14), BookmarkStart.b("怳礵笷ᨹ഻", 14), BookmarkStart.b("怳礵笷ᨹ฻", 14), BookmarkStart.b("怳礵笷ᨹ༻", 14), BookmarkStart.b("怳礵笷ᨹ࠻", 14), BookmarkStart.b("怳礵笷ᨹऻ", 14), BookmarkStart.b("怳礵笷ᨹ਻", 14), BookmarkStart.b("怳礵笷ᨹ଻", 14), BookmarkStart.b("怳礵笷ᨹл", 14), BookmarkStart.b("怳礵笷ᨹԻ", 14), BookmarkStart.b("稳夵䨷圹崻刽怿ୁ⩃≅ⵇ⑉㡋", 14), BookmarkStart.b("爳夵圷丹刻儽㐿❁摃ቅⵇ㉉㡋", 14), BookmarkStart.b("眳夵唷圹夻倽㐿扁၃⍅ぇ㹉", 14), BookmarkStart.b("簳匵夷帹夻䰽", 14), 
                BookmarkStart.b("爳夵圷丹夻䰽", 14), BookmarkStart.b("紳堵尷弹䐻ḽ࠿❁╃≅ⅇ⑉⭋", 14), BookmarkStart.b("眳圵䠷丹唻儽⸿", 14), BookmarkStart.b("怳圵娷嘹夻ḽ⼿⑁摃Eⅇⵉ㥋㱍㕏⅑", 14), BookmarkStart.b("爳夵圷丹刻儽㐿❁摃ᑅⵇⱉ⥋㱍㕏㱑㝓㍕", 14), BookmarkStart.b("眳夵唷圹夻倽㐿扁ᙃ⍅⹇⽉㹋⭍㹏ㅑㅓ", 14), BookmarkStart.b("砳張嘷弹᰻瀽㔿⽁♃⍅㩇", 14), BookmarkStart.b("搳圵強弹᰻瀽㔿⽁♃⍅㩇", 14), BookmarkStart.b("焳堵尷吹医䨽┿扁ᙃ⍅⹇⽉㹋⭍㹏ㅑㅓ", 14), BookmarkStart.b("焳堵尷吹医䨽┿扁၃⍅ぇ㹉", 14), BookmarkStart.b("怳圵娷嘹夻ḽ⼿⑁摃݅㵇㹉⑋⅍≏㭑⁓㽕㵗⥙", 14), BookmarkStart.b("礳圵嬷䠹医ḽᐿ❁㱃㉅", 14), BookmarkStart.b("怳礵礷ᨹ琻嬽ℿ♁ⵃ⡅⽇", 14), BookmarkStart.b("砳張䬷丹", 14), BookmarkStart.b("砳張䬷丹᰻簽㔿⹁⡃⍅㱇", 14), BookmarkStart.b("砳張䬷丹᰻瀽㔿⽁♃⍅㩇", 14), 
                BookmarkStart.b("砳張䬷丹᰻ఽ", 14), BookmarkStart.b("砳張䬷丹᰻ഽ", 14), BookmarkStart.b("砳張䬷丹᰻਽", 14), BookmarkStart.b("砳張䬷丹᰻ଽ", 14), BookmarkStart.b("砳張䬷丹᰻簽㔿⹁⡃⍅㱇橉繋", 14), BookmarkStart.b("砳張䬷丹᰻簽㔿⹁⡃⍅㱇橉罋", 14), BookmarkStart.b("砳張䬷丹᰻簽㔿⹁⡃⍅㱇橉硋", 14), BookmarkStart.b("砳張䬷丹᰻簽㔿⹁⡃⍅㱇橉祋", 14), BookmarkStart.b("砳張䬷丹᰻瀽㔿⽁♃⍅㩇橉繋", 14), BookmarkStart.b("砳張䬷丹᰻瀽㔿⽁♃⍅㩇橉罋", 14), BookmarkStart.b("砳張䬷丹᰻瀽㔿⽁♃⍅㩇橉硋", 14), BookmarkStart.b("砳張䬷丹᰻瀽㔿⽁♃⍅㩇橉祋", 14), BookmarkStart.b("怳張䰷嘹夻", 14), BookmarkStart.b("眳娵圷䤹唻倽✿", 14), BookmarkStart.b("朳張強吹崻䨽㔿ぁ⅃", 14), BookmarkStart.b("瀳匵帷嬹䤻刽㐿扁ᑃ❅㩇⭉⭋㱍ㅏ≑㱓癕ṗ㕙㉛⩝", 14), 
                BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅Ň⑉⡋⭍㹏♑", 14), BookmarkStart.b("砳張䬷丹᰻紽⼿ⱁぃ⽅♇㽉⥋", 14), BookmarkStart.b("砳張䬷丹᰻紽⼿ⱁぃ⽅♇㽉⥋湍扏", 14), BookmarkStart.b("砳張䬷丹᰻紽⼿ⱁぃ⽅♇㽉⥋湍捏", 14), BookmarkStart.b("砳張䬷丹᰻紽⼿ⱁぃ⽅♇㽉⥋湍摏", 14), BookmarkStart.b("砳張䬷丹᰻紽⼿ⱁぃ⽅♇㽉⥋湍敏", 14), BookmarkStart.b("礳匵䬷䤹崻夽┿扁ృ⍅⥇⹉⥋㱍", 14), BookmarkStart.b("朳䌵娷丹唻䨽ⰿ❁", 14), BookmarkStart.b("朳圵吷伹䠻弽㐿⭁⭃⡅", 14), BookmarkStart.b("瀳圵䰷弹", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅็⍉㹋㵍⑏牑ᵓ㡕㱗㽙㉛⩝", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅็⍉㹋㵍⑏牑ᵓ㡕㱗㽙㉛⩝䁟偡", 14), BookmarkStart.b("稳夵䰷弹᰻瘽┿⍁⁃⽅♇ⵉ", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅穇", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅筇", 14), 
                BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅Ň⑉⡋⭍㹏♑瑓摕", 14), BookmarkStart.b("瘳夵尷䌹᰻樽┿㩁ぃ晅Ň⑉⡋⭍㹏♑瑓敕", 14), BookmarkStart.b("瘳娵圷夹圻ḽᐿ❁㱃㉅", 14), BookmarkStart.b("簳伵䠷弹主刽⤿ⱁ⽃", 14), BookmarkStart.b("爳夵吷嘹医䤽┿♁ృ㽅㡇⽉㹋≍㥏㱑㽓", 14), BookmarkStart.b("朳䈵䨷唹刻夽", 14), BookmarkStart.b("焳嬵䠷刹崻䴽⤿ㅁ", 14), BookmarkStart.b("瀳夵嬷伹儻嬽⸿㙁摃୅⥇㩉", 14), BookmarkStart.b("搳娵夷匹刻ḽᐿ❁㱃㉅", 14), BookmarkStart.b("焳ᬵ唷嬹唻刽怿ᅁⵃⅅ♇⭉㡋㭍≏㝑", 14), BookmarkStart.b("稳夵䨷圹崻刽怿橁ፃ⍅⩇捉", 14), BookmarkStart.b("簳戵男瘹᰻缽⌿ぁ⭃⡅ㅇ❉", 14), BookmarkStart.b("簳戵男瘹᰻缽␿♁㙃⍅㭇㥉", 14), BookmarkStart.b("簳戵男瘹᰻紽⤿㙁⅃", 14), BookmarkStart.b("簳戵男瘹᰻紽⼿♁⅃", 14), BookmarkStart.b("簳戵男瘹᰻稽┿⑁ⵃ⡅ⅇ㹉╋⅍㹏", 14), 
                BookmarkStart.b("簳戵男瘹᰻甽┿㭁♃⥅⥇㡉⡋", 14), BookmarkStart.b("簳戵男瘹᰻渽㈿❁≃⥅㩇❉ⵋ㩍⑏㝑こ", 14), BookmarkStart.b("簳戵男瘹᰻洽ℿ⽁㑃⩅ⵇ", 14), BookmarkStart.b("簳戵男瘹᰻樽㤿㉁⅃ㅅ㩇⍉㡋⭍≏", 14), BookmarkStart.b("簳戵男瘹᰻栽ℿぁⵃ❅⩇♉⥋", 14), BookmarkStart.b("眳夵唷圹夻倽㐿扁ᝃ㍅⩇⁉⥋ⵍ⑏", 14), BookmarkStart.b("稳夵ᠷ瘹唻䴽㐿", 14), BookmarkStart.b("瘳圵吷嘹医儽⸿扁၃⍅ぇ㹉", 14), BookmarkStart.b("愳䔵崷䠹", 14), BookmarkStart.b("稳夵欷丹䔻刽┿", 14)
             };
            internal static readonly string[] string_3 = new string[] { 
                BookmarkStart.b("稳夵䨷圹崻刽怿ᙁ╃⑅⑇⽉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("砳張強刹䠻ḽጿ⩁╃≅ⅇ⑉⭋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕楗", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕橗", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕歗", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕汗", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕浗", 14), BookmarkStart.b("砳張強刹䠻ḽి⭁㝃㉅桇୉⽋ⵍ㕏㱑⁓癕湗", 14), 
                BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕楗", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕橗", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕歗", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕汗", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕浗", 14), BookmarkStart.b("砳張強刹䠻ḽܿぁⵃ≅桇୉⽋ⵍ㕏㱑⁓癕湗", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡啣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡噣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡坣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡偣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡兣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏捑瑓᝕㭗㥙㥛そᑟ䉡剣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡啣", 14), 
                BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡噣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡坣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡偣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡兣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿ᅁⱃ❅ⱇ⍉≋⥍灏恑瑓᝕㭗㥙㥛そᑟ䉡剣", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉絋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), 
                BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿แⵃ㕅㱇橉繋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉絋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), 
                BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉繋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙楛", 14), BookmarkStart.b("礳匵尷匹䤻匽怿Ձ㙃⽅ⱇ橉罋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓杕", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓摕", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓敕", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓払", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓捕", 14), BookmarkStart.b("瀳圵䨷儹᰻爽⤿ㅁぃ晅े⥉⽋⭍㹏♑瑓恕", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑", 14), 
                BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡啣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡噣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡坣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡偣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡兣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃ᕅ⁇⭉⡋❍㹏㕑瑓᝕㭗㥙㥛そᑟ䉡剣", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃੅ⅇ㥉㡋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛潝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛汝", 14), 
                BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛浝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛橝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛歝", 14), BookmarkStart.b("眳夵吷唹主堽㔿⹁摃Ņ㩇⍉⡋湍ᅏㅑ㝓㍕㙗⹙籛桝", 14), BookmarkStart.b("怳圵娷嘹夻ḽ猿ف摃⍅⹇ⱉ⥋ⵍ⑏⅑瑓杕", 14), BookmarkStart.b("怳圵娷嘹夻ḽ猿ف摃⍅⹇ⱉ⥋ⵍ⑏⅑瑓摕", 14), BookmarkStart.b("怳圵娷嘹夻ḽ猿ف摃⍅⹇ⱉ⥋ⵍ⑏⅑瑓敕", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿⹁╃㕅㭇⍉⽋湍慏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿⹁╃㕅㭇⍉⽋湍扏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿⹁╃㕅㭇⍉⽋湍捏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿⹁╃㕅㭇⍉⽋湍摏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃⥅㩇ⱉ㥋≍灏捑", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃⥅㩇ⱉ㥋≍灏恑", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃⥅㩇ⱉ㥋≍灏慑", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃㍅╇⑉㽋湍慏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃㍅╇⑉㽋湍扏", 14), 
                BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃㍅╇⑉㽋湍捏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃㍅╇⑉㽋湍摏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⡃㍅╇⑉㽋湍敏", 14), BookmarkStart.b("怳圵娷嘹夻ḽ̿ⵁ⩃㉅ⵇ❉㱋⅍≏㍑♓⽕", 14), BookmarkStart.b("怳圵娷嘹夻ḽԿ⹁⅃ⅅ⥇⑉㡋", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇等", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇硉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇祉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇繉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇罉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇籉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇絉", 14), BookmarkStart.b("怳圵娷嘹夻ḽܿぁⵃ≅桇牉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇等", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇硉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇祉", 14), 
                BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇繉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇罉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇籉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇絉", 14), BookmarkStart.b("怳圵娷嘹夻ḽి⭁㝃㉅桇牉", 14), BookmarkStart.b("怳圵娷嘹夻ḽဿぁ⭃⁅ⵇ㥉㽋❍㽏㱑㕓㩕", 14), BookmarkStart.b("怳圵娷嘹夻ḽጿ⭁⥃㙅⑇⽉汋罍", 14), BookmarkStart.b("怳圵娷嘹夻ḽጿ⭁⥃㙅⑇⽉汋籍", 14), BookmarkStart.b("怳圵娷嘹夻ḽጿ⭁⥃㙅⑇⽉汋絍", 14), BookmarkStart.b("怳圵娷嘹夻ḽጿ㝁♃㉅⑇⽉汋罍", 14), BookmarkStart.b("怳圵娷嘹夻ḽጿ㝁♃㉅⑇⽉汋籍", 14), BookmarkStart.b("怳圵娷嘹夻ḽᐿ⩁⅃⭅ⵇ", 14), BookmarkStart.b("怳圵娷嘹夻ḽ᜿❁♃晅祇", 14), BookmarkStart.b("怳圵娷嘹夻ḽ᜿❁♃晅穇", 14), BookmarkStart.b("怳圵娷嘹夻ḽ᜿❁♃晅筇", 14)
             };

            internal static void smethod_0(IStyle A_0, BuiltinStyle A_1)
            {
                int num = 9;
                smethod_1();
                stream_0.Position = 0L;
                XmlReader reader = new XmlTextReader(stream_0);
                while (reader.Name != BookmarkStart.b("䴮䐰娲头䌶倸唺ြ䰾㕀㩂⥄≆㩈", num))
                {
                    reader.Read();
                }
                reader.Read();
                string str = Style.smethod_4(A_1);
                while (!reader.EOF)
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.GetAttribute(BookmarkStart.b("愮倰帲倴", num)) == str)
                        {
                            new XDLSReader(reader).ReadChildElement(A_0);
                            return;
                        }
                        reader.Skip();
                    }
                    else
                    {
                        reader.Read();
                    }
                }
            }

            private static void smethod_1()
            {
                int num = 15;
                if (stream_0 == null)
                {
                    if (stream_0 == null)
                    {
                        Assembly executingAssembly = Assembly.GetExecutingAssembly();
                        executingAssembly.GetManifestResourceNames();
                        stream_0 = executingAssembly.GetManifestResourceStream(BookmarkStart.b("昴䜶倸䤺堼ᄾՀⱂ♄楆ᭈ⹊㹌⁎⑐⅒㙔㉖⩘畚㽜⩞ࡠརᅤ๦ݨ䙪Ṭ᭮ࡰὲၴѶ坸ͺၼ፾", num));
                    }
                    if (stream_0 == null)
                    {
                        throw new Exception(BookmarkStart.b("朴制䨸吺䠼䴾≀♂敄ⅆ⁈❊⡌潎㍐♒㱔㭖ⵘ㉚㍜牞በᝢᱤ୦౨ᡪ䍬ᝮᱰὲ啴᥶ᙸེ嵼᥾ꞈ", num));
                    }
                }
            }

            private static void smethod_10(IStyle A_0, Color A_1)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_23().BeforeSpacing = 0f;
                class2.method_23().AfterSpacing = 0f;
                class2.method_23().LineSpacing = 12f;
                class2.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.LineWidth = 2.25f;
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 2.25f;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class2.method_24().method_61(A_1);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_23().BeforeSpacing = 0f;
                class3.method_23().AfterSpacing = 0f;
                class3.method_23().LineSpacing = 12f;
                class3.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Double;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 2.25f;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Bottom.LineWidth = 2.25f;
                class4.method_24().method_66().Bottom.Space = 0f;
                class4.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(A_1);
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(A_1);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(Color.FromArgb(0xff, 0xd8, 0xd8, 0xd8));
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(Color.FromArgb(0xff, 0xd8, 0xd8, 0xd8));
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class8.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Top.LineWidth = 2.25f;
                class8.method_24().method_66().Top.Space = 0f;
                class8.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Bottom.LineWidth = 2.25f;
                class8.method_24().method_66().Bottom.Space = 0f;
                class8.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class8.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class8.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class8.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                Class10 class9 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class9.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class9.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class9.method_24().method_66().Top.LineWidth = 2.25f;
                class9.method_24().method_66().Top.Space = 0f;
                class9.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class9.method_24().method_66().Bottom.LineWidth = 2.25f;
                class9.method_24().method_66().Bottom.Space = 0f;
                class9.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class9.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class9.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class9.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
            }

            private static void smethod_11(IStyle A_0, Color A_1, Color A_2)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.Black);
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 1f;
                class2.method_24().method_66().Bottom.Color = A_1;
                class2.method_24().method_66().Bottom.Space = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0x1f, 0x49, 0x7d));
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 1f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = A_1;
                class3.method_24().method_66().Bottom.Space = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Top.LineWidth = 1f;
                class5.method_24().method_66().Top.Color = A_1;
                class5.method_24().method_66().Top.Space = 0f;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Bottom.LineWidth = 1f;
                class5.method_24().method_66().Bottom.Color = A_1;
                class5.method_24().method_66().Bottom.Space = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_2);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(A_2);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_12(IStyle A_0, Color A_1, Color A_2)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.Black);
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.FontSize = 12f;
                class2.CharacterFormat.FontSizeBidi = 12f;
                class2.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 3f;
                class2.method_24().method_66().Bottom.Color = A_1;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 1f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.LineWidth = 1f;
                class4.method_24().method_66().Right.Color = A_1;
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.LineWidth = 1f;
                class5.method_24().method_66().Left.Color = A_1;
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(A_2);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class7.method_24().method_61(A_2);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class8.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class8.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class8.method_24().method_65(TextureStyle.TextureNone);
                (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell).method_24().method_66().Top.BorderType = BorderStyle.Cleared;
            }

            private static void smethod_13(IStyle A_0, Color A_1, Color A_2, Color A_3)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_2);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 2.25f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(A_3);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_14(IStyle A_0, Color A_1, Color A_2, Color A_3, Color A_4, Color A_5)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.Black);
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_2);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.Black);
                class2.method_24().method_61(A_3);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.Black);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.Black);
                class4.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = false;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = false;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.method_55(Color.Black);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(A_4);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_5);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Horizontal.LineWidth = 0.75f;
                class7.method_24().method_66().Horizontal.Color = A_1;
                class7.method_24().method_66().Horizontal.Space = 0f;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Vertical.LineWidth = 0.75f;
                class7.method_24().method_66().Vertical.Color = A_1;
                class7.method_24().method_66().Vertical.Space = 0f;
                class7.method_24().method_61(A_5);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class8.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class8.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class8.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_15(IStyle A_0, Color A_1, Color A_2, Color A_3)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_1);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = false;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = false;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.LineWidth = 1f;
                class2.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 3f;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Left.LineWidth = 1f;
                class2.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Left.Space = 0f;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Right.LineWidth = 1f;
                class2.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Right.Space = 0f;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Vertical.LineWidth = 1f;
                class2.method_24().method_66().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Vertical.Space = 0f;
                class2.method_24().method_61(A_2);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.Italic = false;
                smethod_63(class3.CharacterFormat, 70, class3.CharacterFormat.Italic);
                class3.CharacterFormat.ItalicBidi = false;
                smethod_63(class3.CharacterFormat, 260, class3.CharacterFormat.ItalicBidi);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 3f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Left.LineWidth = 1f;
                class3.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Left.Space = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.LineWidth = 1f;
                class3.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Vertical.LineWidth = 1f;
                class3.method_24().method_66().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Vertical.Space = 0f;
                class3.method_24().method_61(A_2);
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.Italic = false;
                smethod_63(class4.CharacterFormat, 70, class4.CharacterFormat.Italic);
                class4.CharacterFormat.ItalicBidi = false;
                smethod_63(class4.CharacterFormat, 260, class4.CharacterFormat.ItalicBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Left.LineWidth = 1f;
                class4.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class4.method_24().method_66().Left.Space = 0f;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.LineWidth = 3f;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(A_2);
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.Italic = false;
                smethod_63(class5.CharacterFormat, 70, class5.CharacterFormat.Italic);
                class5.CharacterFormat.ItalicBidi = false;
                smethod_63(class5.CharacterFormat, 260, class5.CharacterFormat.ItalicBidi);
                class5.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.LineWidth = 3f;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(A_2);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Top.LineWidth = 1f;
                class6.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class6.method_24().method_66().Top.Space = 0f;
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Bottom.LineWidth = 1f;
                class6.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class6.method_24().method_66().Bottom.Space = 0f;
                class6.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Left.LineWidth = 1f;
                class6.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class6.method_24().method_66().Left.Space = 0f;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Right.LineWidth = 1f;
                class6.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class6.method_24().method_66().Right.Space = 0f;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Top.LineWidth = 1f;
                class7.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Top.Space = 0f;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Bottom.LineWidth = 1f;
                class7.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Bottom.Space = 0f;
                class7.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Left.LineWidth = 1f;
                class7.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Left.Space = 0f;
                class7.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Right.LineWidth = 1f;
                class7.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Right.Space = 0f;
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Horizontal.LineWidth = 1f;
                class7.method_24().method_66().Horizontal.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Horizontal.Space = 0f;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Vertical.LineWidth = 1f;
                class7.method_24().method_66().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Vertical.Space = 0f;
                class7.method_24().method_61(A_3);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_16(IStyle A_0, Color A_1, Color A_2, Color A_3)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_1);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 2.25f;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class2.method_24().method_61(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 2.25f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class3.method_24().method_61(A_2);
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.LineWidth = 2.25f;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(A_3);
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.LineWidth = 2.25f;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(A_3);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class7.method_24().method_61(A_3);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_17(IStyle A_0, Color A_1, Color A_2, Color A_3, Color A_4, Color A_5, Color A_6)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 3f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_2;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_2;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_2;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_3);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 3f;
                class2.method_24().method_66().Bottom.Color = A_1;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_61(A_4);
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class4.method_24().method_66().Horizontal.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Horizontal.LineWidth = 0.5f;
                class4.method_24().method_66().Horizontal.Color = A_4;
                class4.method_24().method_66().Horizontal.Space = 0f;
                class4.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class4.method_24().method_61(A_4);
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class5.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class5.method_24().method_61(A_4);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_5);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(A_6);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                if (A_0.Name != BookmarkStart.b("琶嘸场刼䴾❀㙂⥄杆ᩈ⍊ⱌ⭎㡐㵒㉔睖ᡘ㡚㹜㩞འᝢ䕤呦", 0x11))
                {
                    (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                    (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                }
            }

            private static void smethod_18(IStyle A_0, Color A_1, Color A_2, Color A_3, Color A_4)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_1);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_61(A_2);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(A_2);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Top.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(A_4);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_19(IStyle A_0, Color A_1, Color A_2, Color A_3, Color A_4)
            {
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(A_1);
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_61(A_2);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                class3.method_24().method_61(A_2);
                class3.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureNone);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_61(A_3);
                class4.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class4.method_24().method_65(TextureStyle.TextureNone);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_61(A_3);
                class5.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class5.method_24().method_65(TextureStyle.TextureNone);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_4);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_61(A_4);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            internal static bool smethod_2(BuiltinStyle A_0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (A_0.ToString() == ((DefaultListStyle) i).ToString())
                    {
                        return true;
                    }
                }
                return false;
            }

            private static void smethod_20(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureSolid);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0x80, 0, 0x80));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 0.75f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Left.LineWidth = 0.75f;
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.None;
                class7.method_24().method_66().Bottom.Color = Color.Black;
                class7.method_24().method_66().Bottom.Space = 0f;
                class7.method_24().method_66().Bottom.LineWidth = 0f;
                class7.method_24().method_66().Left.BorderType = BorderStyle.None;
                class7.method_24().method_66().Left.Color = Color.Black;
                class7.method_24().method_66().Left.Space = 0f;
                class7.method_24().method_66().Left.LineWidth = 0f;
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.None;
                class6.method_24().method_66().Bottom.Color = Color.Black;
                class6.method_24().method_66().Bottom.Space = 0f;
                class6.method_24().method_66().Bottom.LineWidth = 0f;
                class6.method_24().method_66().Right.BorderType = BorderStyle.None;
                class6.method_24().method_66().Right.Color = Color.Black;
                class6.method_24().method_66().Right.Space = 0f;
                class6.method_24().method_66().Right.LineWidth = 0f;
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class9 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowLastCell);
                class9.method_24().method_66().Top.BorderType = BorderStyle.None;
                class9.method_24().method_66().Top.Color = Color.Black;
                class9.method_24().method_66().Top.Space = 0f;
                class9.method_24().method_66().Top.LineWidth = 0f;
                class9.method_24().method_66().Left.BorderType = BorderStyle.None;
                class9.method_24().method_66().Left.Color = Color.Black;
                class9.method_24().method_66().Left.Space = 0f;
                class9.method_24().method_66().Left.LineWidth = 0f;
                class9.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalDown.Color = Color.Black;
                class9.method_24().method_66().DiagonalDown.Space = 0f;
                class9.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class9.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalUp.Color = Color.Black;
                class9.method_24().method_66().DiagonalUp.Space = 0f;
                class9.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class8.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class8.method_24().method_66().Top.BorderType = BorderStyle.None;
                class8.method_24().method_66().Top.Color = Color.Black;
                class8.method_24().method_66().Top.Space = 0f;
                class8.method_24().method_66().Top.LineWidth = 0f;
                class8.method_24().method_66().Right.BorderType = BorderStyle.None;
                class8.method_24().method_66().Right.Color = Color.Black;
                class8.method_24().method_66().Right.Space = 0f;
                class8.method_24().method_66().Right.LineWidth = 0f;
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_21(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureSolid);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.method_24().method_66().Top.BorderType = BorderStyle.None;
                class3.method_24().method_66().Top.Color = Color.Black;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.None;
                class3.method_24().method_66().Bottom.Color = Color.Black;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Bottom.LineWidth = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Right.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 0.75f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class5.method_24().method_66().Top.Space = 0f;
                class5.method_24().method_66().Top.LineWidth = 0.75f;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class5.method_24().method_66().Bottom.Space = 0f;
                class5.method_24().method_66().Bottom.LineWidth = 0.75f;
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_22(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.method_24().method_66().Top.BorderType = BorderStyle.None;
                class3.method_24().method_66().Top.Color = Color.Black;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.None;
                class3.method_24().method_66().Bottom.Color = Color.Black;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Bottom.LineWidth = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Right.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 0.75f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class5.CharacterFormat.method_55(Color.Empty);
                class5.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class5.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class6.method_24().method_65(TextureStyle.Texture50Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class7.method_24().method_66().Top.Space = 0f;
                class7.method_24().method_66().Top.LineWidth = 0.75f;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                class7.method_24().method_66().Bottom.Space = 0f;
                class7.method_24().method_66().Bottom.LineWidth = 0.75f;
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class8.CharacterFormat.Bold = true;
                smethod_63(class8.CharacterFormat, 60, class8.CharacterFormat.Bold);
                class8.CharacterFormat.BoldBidi = true;
                smethod_63(class8.CharacterFormat, 250, class8.CharacterFormat.BoldBidi);
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_23(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 0.75f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.Italic = false;
                smethod_63(class5.CharacterFormat, 70, class5.CharacterFormat.Italic);
                class5.CharacterFormat.ItalicBidi = false;
                smethod_63(class5.CharacterFormat, 260, class5.CharacterFormat.ItalicBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_24(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0x80, 0, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class4.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0x80, 0, 0x80));
                class6.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class7.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_25(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureSolid);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_26(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_65(TextureStyle.Texture50Percent);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Bottom.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class3.method_24().method_65(TextureStyle.Texture50Percent);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class6.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_27(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureSolid);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.Italic = true;
                smethod_63(class3.CharacterFormat, 70, class3.CharacterFormat.Italic);
                class3.CharacterFormat.ItalicBidi = true;
                smethod_63(class3.CharacterFormat, 260, class3.CharacterFormat.ItalicBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class3.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.Italic = false;
                smethod_63(class5.CharacterFormat, 70, class5.CharacterFormat.Italic);
                class5.CharacterFormat.ItalicBidi = false;
                smethod_63(class5.CharacterFormat, 260, class5.CharacterFormat.ItalicBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_28(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.Texture20Percent);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0x80, 0, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.Italic = true;
                smethod_63(class3.CharacterFormat, 70, class3.CharacterFormat.Italic);
                class3.CharacterFormat.ItalicBidi = true;
                smethod_63(class3.CharacterFormat, 260, class3.CharacterFormat.ItalicBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class4.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.CharacterFormat.Italic = false;
                smethod_63(class5.CharacterFormat, 70, class5.CharacterFormat.Italic);
                class5.CharacterFormat.ItalicBidi = false;
                smethod_63(class5.CharacterFormat, 260, class5.CharacterFormat.ItalicBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_29(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.Texture25Percent);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Left.LineWidth = 4.5f;
                class3.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Left.Space = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.LineWidth = 0.75f;
                class3.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                class3.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_65(TextureStyle.TextureSolid);
            }

            internal static void smethod_3(IStyle A_0, DefaultTableStyle A_1)
            {
                A_0.Name = Style.smethod_5(A_1);
                switch (A_1)
                {
                    case DefaultTableStyle.TableNormal:
                        smethod_4(A_0);
                        return;

                    case DefaultTableStyle.TableGrid:
                        smethod_5(A_0);
                        return;

                    case DefaultTableStyle.LightShading:
                        smethod_6(A_0, Color.Black, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                        return;

                    case DefaultTableStyle.LightShadingAccent1:
                        smethod_6(A_0, Color.FromArgb(0xff, 0x36, 0x5f, 0x91), Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee));
                        return;

                    case DefaultTableStyle.LightShadingAccent2:
                        smethod_6(A_0, Color.FromArgb(0xff, 0x94, 0x36, 0x34), Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210));
                        return;

                    case DefaultTableStyle.LightShadingAccent3:
                        smethod_6(A_0, Color.FromArgb(0xff, 0x76, 0x92, 60), Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5));
                        return;

                    case DefaultTableStyle.LightShadingAccent4:
                        smethod_6(A_0, Color.FromArgb(0xff, 0x5f, 0x49, 0x7a), Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8));
                        return;

                    case DefaultTableStyle.LightShadingAccent5:
                        smethod_6(A_0, Color.FromArgb(0xff, 0x31, 0x84, 0x9b), Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1));
                        return;

                    case DefaultTableStyle.LightShadingAccent6:
                        smethod_6(A_0, Color.FromArgb(0xff, 0xe3, 0x6c, 10), Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0));
                        return;

                    case DefaultTableStyle.LightList:
                        smethod_7(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.Black);
                        return;

                    case DefaultTableStyle.LightListAccent1:
                        smethod_7(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0x4f, 0x81, 0xbd));
                        return;

                    case DefaultTableStyle.LightListAccent2:
                        smethod_7(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xc0, 80, 0x4d));
                        return;

                    case DefaultTableStyle.LightListAccent3:
                        smethod_7(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 0x9b, 0xbb, 0x59));
                        return;

                    case DefaultTableStyle.LightListAccent4:
                        smethod_7(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0x80, 100, 0xa2));
                        return;

                    case DefaultTableStyle.LightListAccent5:
                        smethod_7(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 0x4b, 0xac, 0xc6));
                        return;

                    case DefaultTableStyle.LightListAccent6:
                        smethod_7(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xf7, 150, 70));
                        return;

                    case DefaultTableStyle.LightGrid:
                        smethod_8(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                        return;

                    case DefaultTableStyle.LightGridAccent1:
                        smethod_8(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee));
                        return;

                    case DefaultTableStyle.LightGridAccent2:
                        smethod_8(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210));
                        return;

                    case DefaultTableStyle.LightGridAccent3:
                        smethod_8(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5));
                        return;

                    case DefaultTableStyle.LightGridAccent4:
                        smethod_8(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8));
                        return;

                    case DefaultTableStyle.LightGridAccent5:
                        smethod_8(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1));
                        return;

                    case DefaultTableStyle.LightGridAccent6:
                        smethod_8(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0));
                        return;

                    case DefaultTableStyle.MediumShading1:
                        smethod_9(A_0, Color.FromArgb(0xff, 0x40, 0x40, 0x40), Color.Black, Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                        return;

                    case DefaultTableStyle.MediumShading1Accent1:
                        smethod_9(A_0, Color.FromArgb(0xff, 0x7b, 160, 0xcd), Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee));
                        return;

                    case DefaultTableStyle.MediumShading1Accent2:
                        smethod_9(A_0, Color.FromArgb(0xff, 0xcf, 0x7b, 0x79), Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210));
                        return;

                    case DefaultTableStyle.MediumShading1Accent3:
                        smethod_9(A_0, Color.FromArgb(0xff, 0xb3, 0xcc, 130), Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5));
                        return;

                    case DefaultTableStyle.MediumShading1Accent4:
                        smethod_9(A_0, Color.FromArgb(0xff, 0x9f, 0x8a, 0xb9), Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8));
                        return;

                    case DefaultTableStyle.MediumShading1Accent5:
                        smethod_9(A_0, Color.FromArgb(0xff, 120, 0xc0, 0xd4), Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1));
                        return;

                    case DefaultTableStyle.MediumShading1Accent6:
                        smethod_9(A_0, Color.FromArgb(0xff, 0xf9, 0xb0, 0x74), Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0));
                        return;

                    case DefaultTableStyle.MediumShading2:
                        smethod_10(A_0, Color.Black);
                        return;

                    case DefaultTableStyle.MediumShading2Accent1:
                        smethod_10(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd));
                        return;

                    case DefaultTableStyle.MediumShading2Accent2:
                        smethod_10(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d));
                        return;

                    case DefaultTableStyle.MediumShading2Accent3:
                        smethod_10(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59));
                        return;

                    case DefaultTableStyle.MediumShading2Accent4:
                        smethod_10(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2));
                        return;

                    case DefaultTableStyle.MediumShading2Accent5:
                        smethod_10(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6));
                        return;

                    case DefaultTableStyle.MediumShading2Accent6:
                        smethod_10(A_0, Color.FromArgb(0xff, 0xf7, 150, 70));
                        return;

                    case DefaultTableStyle.MediumList1:
                        smethod_11(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                        return;

                    case DefaultTableStyle.MediumList1Accent1:
                        smethod_11(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee));
                        return;

                    case DefaultTableStyle.MediumList1Accent2:
                        smethod_11(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210));
                        return;

                    case DefaultTableStyle.MediumList1Accent3:
                        smethod_11(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5));
                        return;

                    case DefaultTableStyle.MediumList1Accent4:
                        smethod_11(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8));
                        return;

                    case DefaultTableStyle.MediumList1Accent5:
                        smethod_11(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1));
                        return;

                    case DefaultTableStyle.MediumList1Accent6:
                        smethod_11(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0));
                        return;

                    case DefaultTableStyle.MediumList2:
                        smethod_12(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                        return;

                    case DefaultTableStyle.MediumList2Accent1:
                        smethod_12(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee));
                        return;

                    case DefaultTableStyle.MediumList2Accent2:
                        smethod_12(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210));
                        return;

                    case DefaultTableStyle.MediumList2Accent3:
                        smethod_12(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5));
                        return;

                    case DefaultTableStyle.MediumList2Accent4:
                        smethod_12(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8));
                        return;

                    case DefaultTableStyle.MediumList2Accent5:
                        smethod_12(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1));
                        return;

                    case DefaultTableStyle.MediumList2Accent6:
                        smethod_12(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0));
                        return;

                    case DefaultTableStyle.MediumGrid1:
                        smethod_13(A_0, Color.FromArgb(0xff, 0x40, 0x40, 0x40), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0), Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent1:
                        smethod_13(A_0, Color.FromArgb(0xff, 0x7b, 160, 0xcd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee), Color.FromArgb(0xff, 0xa7, 0xbf, 0xde));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent2:
                        smethod_13(A_0, Color.FromArgb(0xff, 0xcf, 0x7b, 0x79), Color.FromArgb(0xff, 0xef, 0xd3, 210), Color.FromArgb(0xff, 0xdf, 0xa7, 0xa6));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent3:
                        smethod_13(A_0, Color.FromArgb(0xff, 0xb3, 0xcc, 130), Color.FromArgb(0xff, 230, 0xee, 0xd5), Color.FromArgb(0xff, 0xcd, 0xdd, 0xac));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent4:
                        smethod_13(A_0, Color.FromArgb(0xff, 0x9f, 0x8a, 0xb9), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8), Color.FromArgb(0xff, 0xbf, 0xb1, 0xd0));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent5:
                        smethod_13(A_0, Color.FromArgb(0xff, 120, 0xc0, 0xd4), Color.FromArgb(0xff, 210, 0xea, 0xf1), Color.FromArgb(0xff, 0xa5, 0xd5, 0xe2));
                        return;

                    case DefaultTableStyle.MediumGrid1Accent6:
                        smethod_13(A_0, Color.FromArgb(0xff, 0xf9, 0xb0, 0x74), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0), Color.FromArgb(0xff, 0xfb, 0xca, 0xa2));
                        return;

                    case DefaultTableStyle.MediumGrid2:
                        smethod_14(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0), Color.FromArgb(0xff, 230, 230, 230), Color.FromArgb(0xff, 0xcc, 0xcc, 0xcc), Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent1:
                        smethod_14(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee), Color.FromArgb(0xff, 0xed, 0xf2, 0xf8), Color.FromArgb(0xff, 0xdb, 0xe5, 0xf1), Color.FromArgb(0xff, 0xa7, 0xbf, 0xde));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent2:
                        smethod_14(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xef, 0xd3, 210), Color.FromArgb(0xff, 0xf8, 0xed, 0xed), Color.FromArgb(0xff, 0xf2, 0xdb, 0xdb), Color.FromArgb(0xff, 0xdf, 0xa7, 0xa6));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent3:
                        smethod_14(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 230, 0xee, 0xd5), Color.FromArgb(0xff, 0xf5, 0xf8, 0xee), Color.FromArgb(0xff, 0xea, 0xf1, 0xdd), Color.FromArgb(0xff, 0xcd, 0xdd, 0xac));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent4:
                        smethod_14(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8), Color.FromArgb(0xff, 0xf2, 0xef, 0xf6), Color.FromArgb(0xff, 0xe5, 0xdf, 0xec), Color.FromArgb(0xff, 0xbf, 0xb1, 0xd0));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent5:
                        smethod_14(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 210, 0xea, 0xf1), Color.FromArgb(0xff, 0xed, 0xf6, 0xf9), Color.FromArgb(0xff, 0xda, 0xee, 0xf3), Color.FromArgb(0xff, 0xa5, 0xd5, 0xe2));
                        return;

                    case DefaultTableStyle.MediumGrid2Accent6:
                        smethod_14(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0), Color.FromArgb(0xff, 0xfe, 0xf4, 0xec), Color.FromArgb(0xff, 0xfd, 0xe9, 0xd9), Color.FromArgb(0xff, 0xfb, 0xca, 0xa2));
                        return;

                    case DefaultTableStyle.MediumGrid3:
                        smethod_15(A_0, Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0), Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent1:
                        smethod_15(A_0, Color.FromArgb(0xff, 0xd3, 0xdf, 0xee), Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xa7, 0xbf, 0xde));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent2:
                        smethod_15(A_0, Color.FromArgb(0xff, 0xef, 0xd3, 210), Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xdf, 0xa7, 0xa6));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent3:
                        smethod_15(A_0, Color.FromArgb(0xff, 230, 0xee, 0xd5), Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 0xcd, 0xdd, 0xac));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent4:
                        smethod_15(A_0, Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8), Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xbf, 0xb1, 0xd0));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent5:
                        smethod_15(A_0, Color.FromArgb(0xff, 210, 0xea, 0xf1), Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 0xa5, 0xd5, 0xe2));
                        return;

                    case DefaultTableStyle.MediumGrid3Accent6:
                        smethod_15(A_0, Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0), Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfb, 0xca, 0xa2));
                        return;

                    case DefaultTableStyle.DarkList:
                        smethod_16(A_0, Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0, 0, 0));
                        return;

                    case DefaultTableStyle.DarkListAccent1:
                        smethod_16(A_0, Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0x24, 0x3f, 0x60), Color.FromArgb(0xff, 0x36, 0x5f, 0x91));
                        return;

                    case DefaultTableStyle.DarkListAccent2:
                        smethod_16(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0x62, 0x24, 0x23), Color.FromArgb(0xff, 0x94, 0x36, 0x34));
                        return;

                    case DefaultTableStyle.DarkListAccent3:
                        smethod_16(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 0x4e, 0x61, 40), Color.FromArgb(0xff, 0x76, 0x92, 60));
                        return;

                    case DefaultTableStyle.DarkListAccent4:
                        smethod_16(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0x3f, 0x31, 0x51), Color.FromArgb(0xff, 0x5f, 0x49, 0x7a));
                        return;

                    case DefaultTableStyle.DarkListAccent5:
                        smethod_16(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 0x20, 0x58, 0x67), Color.FromArgb(0xff, 0x31, 0x84, 0x9b));
                        return;

                    case DefaultTableStyle.DarkListAccent6:
                        smethod_16(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0x97, 0x47, 6), Color.FromArgb(0xff, 0xe3, 0x6c, 10));
                        return;

                    case DefaultTableStyle.ColorfulShading:
                        smethod_17(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 230, 230, 230), Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0x99, 0x99, 0x99), Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent1:
                        smethod_17(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0x4f, 0x81, 0xbd), Color.FromArgb(0xff, 0xed, 0xf2, 0xf8), Color.FromArgb(0xff, 0x2c, 0x4c, 0x74), Color.FromArgb(0xff, 0xb8, 0xcc, 0xe4), Color.FromArgb(0xff, 0xa7, 0xbf, 0xde));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent2:
                        smethod_17(A_0, Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xc0, 80, 0x4d), Color.FromArgb(0xff, 0xf8, 0xed, 0xed), Color.FromArgb(0xff, 0x77, 0x2c, 0x2a), Color.FromArgb(0xff, 0xe5, 0xb8, 0xb7), Color.FromArgb(0xff, 0xdf, 0xa7, 0xa6));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent3:
                        smethod_17(A_0, Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 0xf5, 0xf8, 0xee), Color.FromArgb(0xff, 0x5e, 0x75, 0x30), Color.FromArgb(0xff, 0xd6, 0xe3, 0xbc), Color.FromArgb(0xff, 0xcd, 0xdd, 0xac));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent4:
                        smethod_17(A_0, Color.FromArgb(0xff, 0x9b, 0xbb, 0x59), Color.FromArgb(0xff, 0x80, 100, 0xa2), Color.FromArgb(0xff, 0xf2, 0xef, 0xf6), Color.FromArgb(0xff, 0x4c, 0x3b, 0x62), Color.FromArgb(0xff, 0xcc, 0xc0, 0xd9), Color.FromArgb(0xff, 0xbf, 0xb1, 0xd0));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent5:
                        smethod_17(A_0, Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 0xed, 0xf6, 0xf9), Color.FromArgb(0xff, 0x27, 0x6a, 0x7c), Color.FromArgb(0xff, 0xb6, 0xdd, 0xe8), Color.FromArgb(0xff, 0xa5, 0xd5, 0xe2));
                        return;

                    case DefaultTableStyle.ColorfulShadingAccent6:
                        smethod_17(A_0, Color.FromArgb(0xff, 0x4b, 0xac, 0xc6), Color.FromArgb(0xff, 0xf7, 150, 70), Color.FromArgb(0xff, 0xfe, 0xf4, 0xec), Color.FromArgb(0xff, 0xb6, 0x56, 8), Color.FromArgb(0xff, 0xfb, 0xd4, 180), Color.FromArgb(0xff, 0xfb, 0xca, 0xa2));
                        return;

                    case DefaultTableStyle.ColorfulList:
                        smethod_18(A_0, Color.FromArgb(0xff, 230, 230, 230), Color.FromArgb(0xff, 0x9e, 0x3a, 0x38), Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0), Color.FromArgb(0xff, 0xcc, 0xcc, 0xcc));
                        return;

                    case DefaultTableStyle.ColorfulListAccent1:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xed, 0xf2, 0xf8), Color.FromArgb(0xff, 0x9e, 0x3a, 0x38), Color.FromArgb(0xff, 0xd3, 0xdf, 0xee), Color.FromArgb(0xff, 0xdb, 0xe5, 0xf1));
                        return;

                    case DefaultTableStyle.ColorfulListAccent2:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xf8, 0xed, 0xed), Color.FromArgb(0xff, 0x9e, 0x3a, 0x38), Color.FromArgb(0xff, 0xef, 0xd3, 210), Color.FromArgb(0xff, 0xf2, 0xdb, 0xdb));
                        return;

                    case DefaultTableStyle.ColorfulListAccent3:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xf5, 0xf8, 0xee), Color.FromArgb(0xff, 0x66, 0x4e, 130), Color.FromArgb(0xff, 230, 0xee, 0xd5), Color.FromArgb(0xff, 0xea, 0xf1, 0xdd));
                        return;

                    case DefaultTableStyle.ColorfulListAccent4:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xf2, 0xef, 0xf6), Color.FromArgb(0xff, 0x7e, 0x9c, 0x40), Color.FromArgb(0xff, 0xdf, 0xd8, 0xe8), Color.FromArgb(0xff, 0xe5, 0xdf, 0xec));
                        return;

                    case DefaultTableStyle.ColorfulListAccent5:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xed, 0xf6, 0xf9), Color.FromArgb(0xff, 0xf2, 0x73, 10), Color.FromArgb(0xff, 210, 0xea, 0xf1), Color.FromArgb(0xff, 0xda, 0xee, 0xf3));
                        return;

                    case DefaultTableStyle.ColorfulListAccent6:
                        smethod_18(A_0, Color.FromArgb(0xff, 0xfe, 0xf4, 0xec), Color.FromArgb(0xff, 0x34, 0x8d, 0xa5), Color.FromArgb(0xff, 0xfd, 0xe4, 0xd0), Color.FromArgb(0xff, 0xfd, 0xe9, 0xd9));
                        return;

                    case DefaultTableStyle.ColorfulGrid:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xcc, 0xcc, 0xcc), Color.FromArgb(0xff, 0x99, 0x99, 0x99), Color.FromArgb(0xff, 0, 0, 0), Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent1:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xdb, 0xe5, 0xf1), Color.FromArgb(0xff, 0xb8, 0xcc, 0xe4), Color.FromArgb(0xff, 0x36, 0x5f, 0x91), Color.FromArgb(0xff, 0xa7, 0xbf, 0xde));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent2:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xf2, 0xdb, 0xdb), Color.FromArgb(0xff, 0xe5, 0xb8, 0xb7), Color.FromArgb(0xff, 0x94, 0x36, 0x34), Color.FromArgb(0xff, 0xdf, 0xa7, 0xa6));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent3:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xea, 0xf1, 0xdd), Color.FromArgb(0xff, 0xd6, 0xe3, 0xbc), Color.FromArgb(0xff, 0x76, 0x92, 60), Color.FromArgb(0xff, 0xcd, 0xdd, 0xac));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent4:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xe5, 0xdf, 0xec), Color.FromArgb(0xff, 0xcc, 0xc0, 0xd9), Color.FromArgb(0xff, 0x5f, 0x49, 0x7a), Color.FromArgb(0xff, 0xbf, 0xb1, 0xd0));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent5:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xda, 0xee, 0xf3), Color.FromArgb(0xff, 0xb6, 0xdd, 0xe8), Color.FromArgb(0xff, 0x31, 0x84, 0x9b), Color.FromArgb(0xff, 0xa5, 0xd5, 0xe2));
                        return;

                    case DefaultTableStyle.ColorfulGridAccent6:
                        smethod_19(A_0, Color.FromArgb(0xff, 0xfd, 0xe9, 0xd9), Color.FromArgb(0xff, 0xfb, 0xd4, 180), Color.FromArgb(0xff, 0xe3, 0x6c, 10), Color.FromArgb(0xff, 0xfb, 0xca, 0xa2));
                        return;

                    case DefaultTableStyle.Table3Deffects1:
                        smethod_20(A_0);
                        return;

                    case DefaultTableStyle.Table3Deffects2:
                        smethod_21(A_0);
                        return;

                    case DefaultTableStyle.Table3Deffects3:
                        smethod_22(A_0);
                        return;

                    case DefaultTableStyle.TableClassic1:
                        smethod_23(A_0);
                        return;

                    case DefaultTableStyle.TableClassic2:
                        smethod_24(A_0);
                        return;

                    case DefaultTableStyle.TableClassic3:
                        smethod_25(A_0);
                        return;

                    case DefaultTableStyle.TableClassic4:
                        smethod_26(A_0);
                        return;

                    case DefaultTableStyle.TableColorful1:
                        smethod_27(A_0);
                        return;

                    case DefaultTableStyle.TableColorful2:
                        smethod_28(A_0);
                        return;

                    case DefaultTableStyle.TableColorful3:
                        smethod_29(A_0);
                        return;

                    case DefaultTableStyle.TableColumns1:
                        smethod_30(A_0);
                        return;

                    case DefaultTableStyle.TableColumns2:
                        smethod_31(A_0);
                        return;

                    case DefaultTableStyle.TableColumns3:
                        smethod_32(A_0);
                        return;

                    case DefaultTableStyle.TableColumns4:
                        smethod_33(A_0);
                        return;

                    case DefaultTableStyle.TableColumns5:
                        smethod_34(A_0);
                        return;

                    case DefaultTableStyle.TableContemporary:
                        smethod_35(A_0);
                        return;

                    case DefaultTableStyle.TableElegant:
                        smethod_36(A_0);
                        return;

                    case DefaultTableStyle.TableGrid1:
                        smethod_37(A_0);
                        return;

                    case DefaultTableStyle.TableGrid2:
                        smethod_38(A_0);
                        return;

                    case DefaultTableStyle.TableGrid3:
                        smethod_39(A_0);
                        return;

                    case DefaultTableStyle.TableGrid4:
                        smethod_40(A_0);
                        return;

                    case DefaultTableStyle.TableGrid5:
                        smethod_41(A_0);
                        return;

                    case DefaultTableStyle.TableGrid6:
                        smethod_42(A_0);
                        return;

                    case DefaultTableStyle.TableGrid7:
                        smethod_43(A_0);
                        return;

                    case DefaultTableStyle.TableGrid8:
                        smethod_44(A_0);
                        return;

                    case DefaultTableStyle.TableList1:
                        smethod_45(A_0);
                        return;

                    case DefaultTableStyle.TableList2:
                        smethod_46(A_0);
                        return;

                    case DefaultTableStyle.TableList3:
                        smethod_47(A_0);
                        return;

                    case DefaultTableStyle.TableList4:
                        smethod_48(A_0);
                        return;

                    case DefaultTableStyle.TableList5:
                        smethod_49(A_0);
                        return;

                    case DefaultTableStyle.TableList6:
                        smethod_50(A_0);
                        return;

                    case DefaultTableStyle.TableList7:
                        smethod_51(A_0);
                        return;

                    case DefaultTableStyle.TableList8:
                        smethod_52(A_0);
                        return;

                    case DefaultTableStyle.TableProfessional:
                        smethod_53(A_0);
                        return;

                    case DefaultTableStyle.TableSimple1:
                        smethod_54(A_0);
                        return;

                    case DefaultTableStyle.TableSimple2:
                        smethod_55(A_0);
                        return;

                    case DefaultTableStyle.TableSimple3:
                        smethod_56(A_0);
                        return;

                    case DefaultTableStyle.TableSubtle1:
                        smethod_57(A_0);
                        return;

                    case DefaultTableStyle.TableSubtle2:
                        smethod_58(A_0);
                        return;

                    case DefaultTableStyle.TableTheme:
                        smethod_59(A_0);
                        return;

                    case DefaultTableStyle.TableWeb1:
                        smethod_60(A_0);
                        return;

                    case DefaultTableStyle.TableWeb2:
                        smethod_61(A_0);
                        return;

                    case DefaultTableStyle.TableWeb3:
                        smethod_62(A_0);
                        return;
                }
            }

            private static void smethod_30(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.Bold = true;
                smethod_63((A_0 as Class13).CharacterFormat, 60, (A_0 as Class13).CharacterFormat.Bold);
                (A_0 as Class13).CharacterFormat.BoldBidi = true;
                smethod_63((A_0 as Class13).CharacterFormat, 250, (A_0 as Class13).CharacterFormat.BoldBidi);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = false;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = false;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Double;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = false;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = false;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = false;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = false;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = false;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = false;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class6.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding);
                class7.CharacterFormat.method_55(Color.Empty);
                class7.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class7.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class7.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class8.CharacterFormat.Bold = true;
                smethod_63(class8.CharacterFormat, 60, class8.CharacterFormat.Bold);
                class8.CharacterFormat.BoldBidi = true;
                smethod_63(class8.CharacterFormat, 250, class8.CharacterFormat.BoldBidi);
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class9 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class9.CharacterFormat.Bold = true;
                smethod_63(class9.CharacterFormat, 60, class9.CharacterFormat.Bold);
                class9.CharacterFormat.BoldBidi = true;
                smethod_63(class9.CharacterFormat, 250, class9.CharacterFormat.BoldBidi);
                class9.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalDown.Color = Color.Black;
                class9.method_24().method_66().DiagonalDown.Space = 0f;
                class9.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class9.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalUp.Color = Color.Black;
                class9.method_24().method_66().DiagonalUp.Space = 0f;
                class9.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_31(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.Bold = true;
                smethod_63((A_0 as Class13).CharacterFormat, 60, (A_0 as Class13).CharacterFormat.Bold);
                (A_0 as Class13).CharacterFormat.BoldBidi = true;
                smethod_63((A_0 as Class13).CharacterFormat, 250, (A_0 as Class13).CharacterFormat.BoldBidi);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = false;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = false;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = false;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = false;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = false;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = false;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class6.method_24().method_65(TextureStyle.Texture30Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding);
                class7.CharacterFormat.method_55(Color.Empty);
                class7.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class7.method_24().method_63(Color.FromArgb(0xff, 0, 0xff, 0));
                class7.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class8.CharacterFormat.Bold = true;
                smethod_63(class8.CharacterFormat, 60, class8.CharacterFormat.Bold);
                class8.CharacterFormat.BoldBidi = true;
                smethod_63(class8.CharacterFormat, 250, class8.CharacterFormat.BoldBidi);
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class9 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class9.CharacterFormat.Bold = true;
                smethod_63(class9.CharacterFormat, 60, class9.CharacterFormat.Bold);
                class9.CharacterFormat.BoldBidi = true;
                smethod_63(class9.CharacterFormat, 250, class9.CharacterFormat.BoldBidi);
                class9.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalDown.Color = Color.Black;
                class9.method_24().method_66().DiagonalDown.Space = 0f;
                class9.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class9.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class9.method_24().method_66().DiagonalUp.Color = Color.Black;
                class9.method_24().method_66().DiagonalUp.Space = 0f;
                class9.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_32(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.Bold = true;
                smethod_63((A_0 as Class13).CharacterFormat, 60, (A_0 as Class13).CharacterFormat.Bold);
                (A_0 as Class13).CharacterFormat.BoldBidi = true;
                smethod_63((A_0 as Class13).CharacterFormat, 250, (A_0 as Class13).CharacterFormat.BoldBidi);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = false;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = false;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = false;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = false;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = false;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = false;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class6.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding);
                class7.CharacterFormat.method_55(Color.Empty);
                class7.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class7.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class7.method_24().method_65(TextureStyle.Texture10Percent);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class8.CharacterFormat.Bold = true;
                smethod_63(class8.CharacterFormat, 60, class8.CharacterFormat.Bold);
                class8.CharacterFormat.BoldBidi = true;
                smethod_63(class8.CharacterFormat, 250, class8.CharacterFormat.BoldBidi);
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_33(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class5.CharacterFormat.method_55(Color.Empty);
                class5.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                class5.method_24().method_65(TextureStyle.Texture50Percent);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class6.method_24().method_65(TextureStyle.Texture10Percent);
            }

            private static void smethod_34(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class6.method_24().method_65(TextureStyle.TextureSolid);
                (A_0 as Class13).method_26(ConditionalFormattingCode.EvenColumnBanding).CharacterFormat.method_55(Color.Empty);
            }

            private static void smethod_35(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 2.25f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0xff, 0xff, 0xff);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_65(TextureStyle.Texture20Percent);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class3.method_24().method_65(TextureStyle.Texture5Percent);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class4.CharacterFormat.method_55(Color.Empty);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_65(TextureStyle.Texture20Percent);
            }

            private static void smethod_36(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Double;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Double;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Double;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Double;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.AllCaps = true;
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_37(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class3.CharacterFormat.Italic = true;
                smethod_63(class3.CharacterFormat, 70, class3.CharacterFormat.Italic);
                class3.CharacterFormat.ItalicBidi = true;
                smethod_63(class3.CharacterFormat, 260, class3.CharacterFormat.ItalicBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_38(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_39(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class2.method_24().method_65(TextureStyle.Texture30Percent);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_4(IStyle A_0)
            {
                (A_0 as Style).IsSemiHidden = true;
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
            }

            private static void smethod_40(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class2.method_24().method_65(TextureStyle.Texture30Percent);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class3.method_24().method_65(TextureStyle.Texture30Percent);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.Empty);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_41(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.Single;
                class5.method_24().method_66().DiagonalDown.Color = Color.FromArgb(0xff, 0, 0, 0);
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0.75f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_42(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.Single;
                class5.method_24().method_66().DiagonalDown.Color = Color.FromArgb(0xff, 0, 0, 0);
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0.75f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_43(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).CharacterFormat.Bold = true;
                smethod_63((A_0 as Class13).CharacterFormat, 60, (A_0 as Class13).CharacterFormat.Bold);
                (A_0 as Class13).CharacterFormat.BoldBidi = true;
                smethod_63((A_0 as Class13).CharacterFormat, 250, (A_0 as Class13).CharacterFormat.BoldBidi);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = false;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = false;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = false;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = false;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = false;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = false;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = false;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = false;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowFirstCell);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.Single;
                class6.method_24().method_66().DiagonalDown.Color = Color.FromArgb(0xff, 0, 0, 0);
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0.75f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_44(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.CharacterFormat.method_55(Color.Empty);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_45(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0x80, 0, 0));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class4.CharacterFormat.method_55(Color.Empty);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class4.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class5.CharacterFormat.method_55(Color.Empty);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_46(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(2L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0x80, 0x80, 0x80);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0, 0x80, 0));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0x80, 0x80));
                class2.method_24().method_65(TextureStyle.Texture75Percent);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class4.CharacterFormat.method_55(Color.Empty);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0xff, 0));
                class4.method_24().method_65(TextureStyle.Texture20Percent);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class5.CharacterFormat.method_55(Color.Empty);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_47(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class4.CharacterFormat.Italic = true;
                smethod_63(class4.CharacterFormat, 70, class4.CharacterFormat.Italic);
                class4.CharacterFormat.ItalicBidi = true;
                smethod_63(class4.CharacterFormat, 260, class4.CharacterFormat.ItalicBidi);
                class4.CharacterFormat.method_55(Color.FromArgb(0xff, 0, 0, 0x80));
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_48(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0x80, 0x80, 0x80));
                class2.method_24().method_65(TextureStyle.TextureSolid);
            }

            private static void smethod_49(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_5(IStyle A_0)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
            }

            private static void smethod_50(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0xff, 0, 0, 0));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.Texture50Percent);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Right.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class4.method_24().method_65(TextureStyle.Texture25Percent);
            }

            private static void smethod_51(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class6.method_24().method_65(TextureStyle.Texture20Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class7.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class7.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class7.method_24().method_65(TextureStyle.Texture25Percent);
            }

            private static void smethod_52(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.Italic = true;
                smethod_63(class2.CharacterFormat, 70, class2.CharacterFormat.Italic);
                class2.CharacterFormat.ItalicBidi = true;
                smethod_63(class2.CharacterFormat, 260, class2.CharacterFormat.ItalicBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class6.CharacterFormat.method_55(Color.Empty);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0xff, 0xff, 0));
                class6.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class7.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class7.method_24().method_63(Color.FromArgb(0xff, 0xff, 0, 0));
                class7.method_24().method_65(TextureStyle.Texture50Percent);
            }

            private static void smethod_53(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
            }

            private static void smethod_54(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 0.75f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0x80, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_55(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.CharacterFormat.method_55(Color.Empty);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 1.5f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Left.LineWidth = 0.75f;
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().Left.BorderType = BorderStyle.None;
                class6.method_24().method_66().Left.Color = Color.Black;
                class6.method_24().method_66().Left.Space = 0f;
                class6.method_24().method_66().Left.LineWidth = 0f;
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class7.CharacterFormat.Bold = true;
                smethod_63(class7.CharacterFormat, 60, class7.CharacterFormat.Bold);
                class7.CharacterFormat.BoldBidi = true;
                smethod_63(class7.CharacterFormat, 250, class7.CharacterFormat.BoldBidi);
                class7.method_24().method_66().Top.BorderType = BorderStyle.None;
                class7.method_24().method_66().Top.Color = Color.Black;
                class7.method_24().method_66().Top.Space = 0f;
                class7.method_24().method_66().Top.LineWidth = 0f;
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_56(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class2.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_63(Color.FromArgb(0xff, 0, 0, 0));
                class2.method_24().method_65(TextureStyle.TextureSolid);
            }

            private static void smethod_57(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Top.LineWidth = 0.75f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class3.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class3.method_24().method_63(Color.FromArgb(0xff, 0x80, 0, 0x80));
                class3.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 1.5f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Left.LineWidth = 1.5f;
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class6.method_24().method_66().Bottom.Space = 0f;
                class6.method_24().method_66().Bottom.LineWidth = 0.75f;
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class6.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class6.method_24().method_63(Color.FromArgb(0xff, 0x80, 0x80, 0));
                class6.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class7.CharacterFormat.Bold = true;
                smethod_63(class7.CharacterFormat, 60, class7.CharacterFormat.Bold);
                class7.CharacterFormat.BoldBidi = true;
                smethod_63(class7.CharacterFormat, 250, class7.CharacterFormat.BoldBidi);
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class8.CharacterFormat.Bold = true;
                smethod_63(class8.CharacterFormat, 60, class8.CharacterFormat.Bold);
                class8.CharacterFormat.BoldBidi = true;
                smethod_63(class8.CharacterFormat, 250, class8.CharacterFormat.BoldBidi);
                class8.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalDown.Color = Color.Black;
                class8.method_24().method_66().DiagonalDown.Space = 0f;
                class8.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class8.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class8.method_24().method_66().DiagonalUp.Color = Color.Black;
                class8.method_24().method_66().DiagonalUp.Space = 0f;
                class8.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_58(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.Color = Color.FromArgb(0xff, 0, 0, 0);
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Bottom.LineWidth = 1.5f;
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.Color = Color.FromArgb(0xff, 0, 0, 0);
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Top.LineWidth = 1.5f;
                class3.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalDown.Color = Color.Black;
                class3.method_24().method_66().DiagonalDown.Space = 0f;
                class3.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class3.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class3.method_24().method_66().DiagonalUp.Color = Color.Black;
                class3.method_24().method_66().DiagonalUp.Space = 0f;
                class3.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class4.method_24().method_66().Right.Color = Color.FromArgb(0xff, 0, 0, 0);
                class4.method_24().method_66().Right.Space = 0f;
                class4.method_24().method_66().Right.LineWidth = 1.5f;
                class4.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalDown.Color = Color.Black;
                class4.method_24().method_66().DiagonalDown.Space = 0f;
                class4.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class4.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class4.method_24().method_66().DiagonalUp.Color = Color.Black;
                class4.method_24().method_66().DiagonalUp.Space = 0f;
                class4.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class4.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class4.method_24().method_63(Color.FromArgb(0xff, 0, 0x80, 0));
                class4.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.Color = Color.FromArgb(0xff, 0, 0, 0);
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Left.LineWidth = 1.5f;
                class5.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalDown.Color = Color.Black;
                class5.method_24().method_66().DiagonalDown.Space = 0f;
                class5.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class5.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class5.method_24().method_66().DiagonalUp.Color = Color.Black;
                class5.method_24().method_66().DiagonalUp.Space = 0f;
                class5.method_24().method_66().DiagonalUp.LineWidth = 0f;
                class5.method_24().method_61(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class5.method_24().method_63(Color.FromArgb(0xff, 0x80, 0x80, 0));
                class5.method_24().method_65(TextureStyle.Texture25Percent);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRowLastCell);
                class6.CharacterFormat.Bold = true;
                smethod_63(class6.CharacterFormat, 60, class6.CharacterFormat.Bold);
                class6.CharacterFormat.BoldBidi = true;
                smethod_63(class6.CharacterFormat, 250, class6.CharacterFormat.BoldBidi);
                class6.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalDown.Color = Color.Black;
                class6.method_24().method_66().DiagonalDown.Space = 0f;
                class6.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class6.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class6.method_24().method_66().DiagonalUp.Color = Color.Black;
                class6.method_24().method_66().DiagonalUp.Space = 0f;
                class6.method_24().method_66().DiagonalUp.LineWidth = 0f;
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRowFirstCell);
                class7.CharacterFormat.Bold = true;
                smethod_63(class7.CharacterFormat, 60, class7.CharacterFormat.Bold);
                class7.CharacterFormat.BoldBidi = true;
                smethod_63(class7.CharacterFormat, 250, class7.CharacterFormat.BoldBidi);
                class7.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalDown.Color = Color.Black;
                class7.method_24().method_66().DiagonalDown.Space = 0f;
                class7.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class7.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class7.method_24().method_66().DiagonalUp.Color = Color.Black;
                class7.method_24().method_66().DiagonalUp.Space = 0f;
                class7.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_59(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.5f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
            }

            private static void smethod_6(IStyle A_0, Color A_1, Color A_2, Color A_3)
            {
                (A_0 as Class13).CharacterFormat.method_55(A_1);
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_2;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_2;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_23().BeforeSpacing = 0f;
                class2.method_23().AfterSpacing = 0f;
                class2.method_23().LineSpacing = 12f;
                class2.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.LineWidth = 1f;
                class2.method_24().method_66().Top.Color = A_2;
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 1f;
                class2.method_24().method_66().Bottom.Color = A_2;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_23().BeforeSpacing = 0f;
                class3.method_23().AfterSpacing = 0f;
                class3.method_23().LineSpacing = 12f;
                class3.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Top.LineWidth = 1f;
                class3.method_24().method_66().Top.Color = A_2;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = A_2;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class6.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Left.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Right.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class7.method_24().method_61(A_3);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
            }

            private static void smethod_60(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_75(1f);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                (A_0 as Class13).Interface8.imethod_2().method_72(1f);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_61(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_75(1f);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Inset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                (A_0 as Class13).Interface8.imethod_2().method_72(1f);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_62(IStyle A_0)
            {
                (A_0 as Style).UnhideWhenUsed = true;
                (A_0 as Class13).Interface8.imethod_3().method_75(1f);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 3f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 3f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 3f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 3f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Outset;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 0.75f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = Color.Black;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                (A_0 as Class13).Interface8.imethod_1().method_61(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                (A_0 as Class13).Interface8.imethod_1().method_65(TextureStyle.TextureNone);
                (A_0 as Class13).Interface8.imethod_2().method_72(1f);
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.CharacterFormat.method_55(Color.Empty);
                class2.method_24().method_66().DiagonalDown.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalDown.Color = Color.Black;
                class2.method_24().method_66().DiagonalDown.Space = 0f;
                class2.method_24().method_66().DiagonalDown.LineWidth = 0f;
                class2.method_24().method_66().DiagonalUp.BorderType = BorderStyle.None;
                class2.method_24().method_66().DiagonalUp.Color = Color.Black;
                class2.method_24().method_66().DiagonalUp.Space = 0f;
                class2.method_24().method_66().DiagonalUp.LineWidth = 0f;
            }

            private static void smethod_63(FormatBase A_0, short A_1, bool A_2)
            {
                byte num = A_2 ? ((byte) 0x81) : ((byte) 0x80);
                if (num != 0)
                {
                    A_0.method_10(A_1, num);
                }
            }

            private static void smethod_7(IStyle A_0, Color A_1, Color A_2)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_23().BeforeSpacing = 0f;
                class2.method_23().AfterSpacing = 0f;
                class2.method_23().LineSpacing = 12f;
                class2.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_61(A_2);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_23().BeforeSpacing = 0f;
                class3.method_23().AfterSpacing = 0f;
                class3.method_23().LineSpacing = 12f;
                class3.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Double;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = A_1;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Left.LineWidth = 1f;
                class3.method_24().method_66().Left.Color = A_1;
                class3.method_24().method_66().Left.Space = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.LineWidth = 1f;
                class3.method_24().method_66().Right.Color = A_1;
                class3.method_24().method_66().Right.Space = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Top.LineWidth = 1f;
                class6.method_24().method_66().Top.Color = A_1;
                class6.method_24().method_66().Top.Space = 0f;
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Bottom.LineWidth = 1f;
                class6.method_24().method_66().Bottom.Color = A_1;
                class6.method_24().method_66().Bottom.Space = 0f;
                class6.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Left.LineWidth = 1f;
                class6.method_24().method_66().Left.Color = A_1;
                class6.method_24().method_66().Left.Space = 0f;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Right.LineWidth = 1f;
                class6.method_24().method_66().Right.Color = A_1;
                class6.method_24().method_66().Right.Space = 0f;
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Top.LineWidth = 1f;
                class7.method_24().method_66().Top.Color = A_1;
                class7.method_24().method_66().Top.Space = 0f;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Bottom.LineWidth = 1f;
                class7.method_24().method_66().Bottom.Color = A_1;
                class7.method_24().method_66().Bottom.Space = 0f;
                class7.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Left.LineWidth = 1f;
                class7.method_24().method_66().Left.Color = A_1;
                class7.method_24().method_66().Left.Space = 0f;
                class7.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Right.LineWidth = 1f;
                class7.method_24().method_66().Right.Color = A_1;
                class7.method_24().method_66().Right.Space = 0f;
            }

            private static void smethod_8(IStyle A_0, Color A_1, Color A_2)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Vertical.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_23().BeforeSpacing = 0f;
                class2.method_23().AfterSpacing = 0f;
                class2.method_23().LineSpacing = 12f;
                class2.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.LineWidth = 1f;
                class2.method_24().method_66().Top.Color = A_1;
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 2.25f;
                class2.method_24().method_66().Bottom.Color = A_1;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Left.LineWidth = 1f;
                class2.method_24().method_66().Left.Color = A_1;
                class2.method_24().method_66().Left.Space = 0f;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Right.LineWidth = 1f;
                class2.method_24().method_66().Right.Color = A_1;
                class2.method_24().method_66().Right.Space = 0f;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Vertical.LineWidth = 1f;
                class2.method_24().method_66().Vertical.Color = A_1;
                class2.method_24().method_66().Vertical.Space = 0f;
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_23().BeforeSpacing = 0f;
                class3.method_23().AfterSpacing = 0f;
                class3.method_23().LineSpacing = 12f;
                class3.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Double;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = A_1;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Left.LineWidth = 1f;
                class3.method_24().method_66().Left.Color = A_1;
                class3.method_24().method_66().Left.Space = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.LineWidth = 1f;
                class3.method_24().method_66().Right.Color = A_1;
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Vertical.LineWidth = 1f;
                class3.method_24().method_66().Vertical.Color = A_1;
                class3.method_24().method_66().Vertical.Space = 0f;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                class5.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Top.LineWidth = 1f;
                class5.method_24().method_66().Top.Color = A_1;
                class5.method_24().method_66().Top.Space = 0f;
                class5.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Bottom.LineWidth = 1f;
                class5.method_24().method_66().Bottom.Color = A_1;
                class5.method_24().method_66().Bottom.Space = 0f;
                class5.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Left.LineWidth = 1f;
                class5.method_24().method_66().Left.Color = A_1;
                class5.method_24().method_66().Left.Space = 0f;
                class5.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class5.method_24().method_66().Right.LineWidth = 1f;
                class5.method_24().method_66().Right.Color = A_1;
                class5.method_24().method_66().Right.Space = 0f;
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Top.LineWidth = 1f;
                class6.method_24().method_66().Top.Color = A_1;
                class6.method_24().method_66().Top.Space = 0f;
                class6.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Bottom.LineWidth = 1f;
                class6.method_24().method_66().Bottom.Color = A_1;
                class6.method_24().method_66().Bottom.Space = 0f;
                class6.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Left.LineWidth = 1f;
                class6.method_24().method_66().Left.Color = A_1;
                class6.method_24().method_66().Left.Space = 0f;
                class6.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class6.method_24().method_66().Right.LineWidth = 1f;
                class6.method_24().method_66().Right.Color = A_1;
                class6.method_24().method_66().Right.Space = 0f;
                class6.method_24().method_61(A_2);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Top.LineWidth = 1f;
                class7.method_24().method_66().Top.Color = A_1;
                class7.method_24().method_66().Top.Space = 0f;
                class7.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Bottom.LineWidth = 1f;
                class7.method_24().method_66().Bottom.Color = A_1;
                class7.method_24().method_66().Bottom.Space = 0f;
                class7.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Left.LineWidth = 1f;
                class7.method_24().method_66().Left.Color = A_1;
                class7.method_24().method_66().Left.Space = 0f;
                class7.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Right.LineWidth = 1f;
                class7.method_24().method_66().Right.Color = A_1;
                class7.method_24().method_66().Right.Space = 0f;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class7.method_24().method_66().Vertical.LineWidth = 1f;
                class7.method_24().method_66().Vertical.Color = A_1;
                class7.method_24().method_66().Vertical.Space = 0f;
                class7.method_24().method_61(A_2);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class8.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Top.LineWidth = 1f;
                class8.method_24().method_66().Top.Color = A_1;
                class8.method_24().method_66().Top.Space = 0f;
                class8.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Bottom.LineWidth = 1f;
                class8.method_24().method_66().Bottom.Color = A_1;
                class8.method_24().method_66().Bottom.Space = 0f;
                class8.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Left.LineWidth = 1f;
                class8.method_24().method_66().Left.Color = A_1;
                class8.method_24().method_66().Left.Space = 0f;
                class8.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Right.LineWidth = 1f;
                class8.method_24().method_66().Right.Color = A_1;
                class8.method_24().method_66().Right.Space = 0f;
                class8.method_24().method_66().Vertical.BorderType = BorderStyle.Single;
                class8.method_24().method_66().Vertical.LineWidth = 1f;
                class8.method_24().method_66().Vertical.Color = A_1;
                class8.method_24().method_66().Vertical.Space = 0f;
            }

            private static void smethod_9(IStyle A_0, Color A_1, Color A_2, Color A_3)
            {
                (A_0 as Class13).imethod_0().AfterSpacing = 0f;
                (A_0 as Class13).imethod_0().LineSpacing = 12f;
                (A_0 as Class13).imethod_0().LineSpacingRule = LineSpacingRule.Multiple;
                (A_0 as Class13).Interface8.imethod_3().method_83(1L);
                (A_0 as Class13).Interface8.imethod_3().method_81(1L);
                (A_0 as Class13).Interface8.imethod_3().method_77(0f);
                (A_0 as Class13).Interface8.imethod_3().method_73().Top = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Bottom = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Left = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_73().Right = 5.4f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Top.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Bottom.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Left.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Right.Space = 0f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.BorderType = BorderStyle.Single;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.LineWidth = 1f;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Color = A_1;
                (A_0 as Class13).Interface8.imethod_3().method_72().Horizontal.Space = 0f;
                Class10 class2 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstRow);
                class2.method_23().BeforeSpacing = 0f;
                class2.method_23().AfterSpacing = 0f;
                class2.method_23().LineSpacing = 12f;
                class2.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class2.CharacterFormat.Bold = true;
                smethod_63(class2.CharacterFormat, 60, class2.CharacterFormat.Bold);
                class2.CharacterFormat.BoldBidi = true;
                smethod_63(class2.CharacterFormat, 250, class2.CharacterFormat.BoldBidi);
                class2.CharacterFormat.method_55(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                class2.method_24().method_66().Top.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Top.LineWidth = 1f;
                class2.method_24().method_66().Top.Color = A_1;
                class2.method_24().method_66().Top.Space = 0f;
                class2.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Bottom.LineWidth = 1f;
                class2.method_24().method_66().Bottom.Color = A_1;
                class2.method_24().method_66().Bottom.Space = 0f;
                class2.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Left.LineWidth = 1f;
                class2.method_24().method_66().Left.Color = A_1;
                class2.method_24().method_66().Left.Space = 0f;
                class2.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class2.method_24().method_66().Right.LineWidth = 1f;
                class2.method_24().method_66().Right.Color = A_1;
                class2.method_24().method_66().Right.Space = 0f;
                class2.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class2.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class2.method_24().method_61(A_2);
                class2.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class2.method_24().method_65(TextureStyle.TextureNone);
                Class10 class3 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastRow);
                class3.method_23().BeforeSpacing = 0f;
                class3.method_23().AfterSpacing = 0f;
                class3.method_23().LineSpacing = 12f;
                class3.method_23().LineSpacingRule = LineSpacingRule.Multiple;
                class3.CharacterFormat.Bold = true;
                smethod_63(class3.CharacterFormat, 60, class3.CharacterFormat.Bold);
                class3.CharacterFormat.BoldBidi = true;
                smethod_63(class3.CharacterFormat, 250, class3.CharacterFormat.BoldBidi);
                class3.method_24().method_66().Top.BorderType = BorderStyle.Double;
                class3.method_24().method_66().Top.LineWidth = 0.75f;
                class3.method_24().method_66().Top.Color = A_1;
                class3.method_24().method_66().Top.Space = 0f;
                class3.method_24().method_66().Bottom.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Bottom.LineWidth = 1f;
                class3.method_24().method_66().Bottom.Color = A_1;
                class3.method_24().method_66().Bottom.Space = 0f;
                class3.method_24().method_66().Left.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Left.LineWidth = 1f;
                class3.method_24().method_66().Left.Color = A_1;
                class3.method_24().method_66().Left.Space = 0f;
                class3.method_24().method_66().Right.BorderType = BorderStyle.Single;
                class3.method_24().method_66().Right.LineWidth = 1f;
                class3.method_24().method_66().Right.Color = A_1;
                class3.method_24().method_66().Right.Space = 0f;
                class3.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class3.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                Class10 class4 = (A_0 as Class13).method_26(ConditionalFormattingCode.FirstColumn);
                class4.CharacterFormat.Bold = true;
                smethod_63(class4.CharacterFormat, 60, class4.CharacterFormat.Bold);
                class4.CharacterFormat.BoldBidi = true;
                smethod_63(class4.CharacterFormat, 250, class4.CharacterFormat.BoldBidi);
                Class10 class5 = (A_0 as Class13).method_26(ConditionalFormattingCode.LastColumn);
                class5.CharacterFormat.Bold = true;
                smethod_63(class5.CharacterFormat, 60, class5.CharacterFormat.Bold);
                class5.CharacterFormat.BoldBidi = true;
                smethod_63(class5.CharacterFormat, 250, class5.CharacterFormat.BoldBidi);
                Class10 class6 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddColumnBanding);
                class6.method_24().method_61(A_3);
                class6.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class6.method_24().method_65(TextureStyle.TextureNone);
                Class10 class7 = (A_0 as Class13).method_26(ConditionalFormattingCode.OddRowBanding);
                class7.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class7.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
                class7.method_24().method_61(A_3);
                class7.method_24().method_63(Color.FromArgb(0, 0xff, 0xff, 0xff));
                class7.method_24().method_65(TextureStyle.TextureNone);
                Class10 class8 = (A_0 as Class13).method_26(ConditionalFormattingCode.EvenRowBanding);
                class8.method_24().method_66().Horizontal.BorderType = BorderStyle.Cleared;
                class8.method_24().method_66().Vertical.BorderType = BorderStyle.Cleared;
            }
        }
    }
}

