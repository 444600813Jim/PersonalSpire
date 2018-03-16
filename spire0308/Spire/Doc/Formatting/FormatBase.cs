namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Xml;

    public abstract class FormatBase : DocumentSerializable, Interface11
    {
        private bool bool_0;
        private byte[] byte_1;
        private FormatBase formatBase_0;
        private FormatBase formatBase_1;
        private const int int_2 = 8;
        private const int int_3 = 4;
        private const int int_4 = 0x20;
        private const int int_5 = 0x80;
        private int int_6;
        internal Interface45 interface45_0;
        private List<Stream> list_0;
        private List<XmlNode> list_1;
        protected int m_keysOffset;
        protected Dictionary<int, object> m_propertiesHash;
        protected Dictionary<int, bool> m_propsUpdateFlags;

        public FormatBase() : this(null)
        {
        }

        public FormatBase(IDocument doc) : this(doc, null)
        {
        }

        public FormatBase(FormatBase parent, int parentKey) : this(null)
        {
            int num = 2;
            if ((parent.KeysOffset + 8) > 0x20)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䜧䰩䨫崭唯䘱", num));
            }
            this.m_propertiesHash = parent.PropertiesHash;
            this.m_propsUpdateFlags = parent.PropsUpdateFlags;
            this.int_6 = parentKey;
            this.formatBase_1 = parent;
            this.m_keysOffset = parent.KeysOffset + 8;
        }

        public FormatBase(IDocument doc, DocumentObject owner) : base(doc as Document, owner)
        {
            this.bool_0 = true;
            this.m_propertiesHash = new Dictionary<int, object>();
        }

        public FormatBase(FormatBase parent, int parentKey, int parentOffset) : this(parent, parentKey)
        {
        }

        internal virtual void AcceptChanges()
        {
        }

        internal virtual void ApplyBase(FormatBase baseFormat)
        {
            this.formatBase_0 = baseFormat;
        }

        internal virtual void ApplyProperty()
        {
        }

        protected void CheckUpdateFlagsColl()
        {
            if (this.m_propsUpdateFlags == null)
            {
                this.m_propsUpdateFlags = new Dictionary<int, bool>();
            }
        }

        public void ClearFormatting()
        {
            if (this.m_propertiesHash != null)
            {
                this.m_propertiesHash.Clear();
            }
            this.method_8();
        }

        protected void ClearPropUpdateFlag(int propKey)
        {
            if (this.PropsUpdateFlags.ContainsKey(propKey))
            {
                this.PropsUpdateFlags.Remove(propKey);
            }
        }

        protected override object CloneImpl()
        {
            FormatBase base2 = base.CloneImpl() as FormatBase;
            this.method_21(base2);
            return base2;
        }

        internal virtual void Close()
        {
            if (this.m_propertiesHash != null)
            {
                this.m_propertiesHash.Clear();
                this.m_propertiesHash = null;
            }
            if (this.m_propsUpdateFlags != null)
            {
                this.m_propsUpdateFlags.Clear();
                this.m_propsUpdateFlags = null;
            }
            if (this.list_1 != null)
            {
                this.list_1.Clear();
                this.list_1 = null;
            }
            this.interface45_0 = null;
        }

        internal virtual void CopyPropertiesTo(FormatBase destFormat)
        {
            foreach (KeyValuePair<int, object> pair in this.PropertiesHash)
            {
                if (pair.Value is FormatBase)
                {
                    (pair.Value as FormatBase).CopyPropertiesTo(destFormat[pair.Key] as FormatBase);
                }
                else
                {
                    destFormat[pair.Key] = pair.Value;
                }
            }
        }

        protected FormatBase CreateEmptyCopy()
        {
            return (FormatBase) base.MemberwiseClone();
        }

        protected virtual void CreateFormatLayoutInfo()
        {
            this.interface45_0 = null;
        }

        protected internal virtual void EnsureComposites()
        {
        }

        protected void EnsureComposites(params int[] keys)
        {
            foreach (int num2 in keys)
            {
                FormatBase defComposite = this.GetDefComposite(num2);
                defComposite.EnsureComposites();
                defComposite.IsDefault = false;
            }
        }

        protected int GetBaseKey(int key)
        {
            return (key - (this.int_6 << this.m_keysOffset));
        }

        protected virtual FormatBase GetDefComposite(int key)
        {
            return null;
        }

        protected FormatBase GetDefComposite(int key, FormatBase value)
        {
            int fullKey = this.GetFullKey(key);
            this.PropertiesHash[fullKey] = value;
            if ((this.BaseFormat != null) && (this.BaseFormat.PropertiesHash != null))
            {
                FormatBase base2;
                if (this.BaseFormat.PropertiesHash.ContainsKey(fullKey))
                {
                    base2 = this.BaseFormat.PropertiesHash[fullKey] as FormatBase;
                }
                else
                {
                    base2 = this.BaseFormat[fullKey] as FormatBase;
                }
                value.ApplyBase(base2);
            }
            return value;
        }

        protected abstract object GetDefValue(int key);
        internal virtual int GetFullKey(int key)
        {
            return (key + (this.int_6 << this.m_keysOffset));
        }

        protected virtual int GetSprmOption(int propertyKey)
        {
            return 0x7fffffff;
        }

        public bool HasKey(int key)
        {
            if (this.PropertiesHash == null)
            {
                return false;
            }
            return this.PropertiesHash.ContainsKey(this.GetFullKey(key));
        }

        internal virtual bool HasValue(int propertyKey)
        {
            return (this.HasKey(propertyKey) || ((this.BaseFormat != null) && this.BaseFormat.HasValue(propertyKey)));
        }

        protected internal void ImportContainer(FormatBase format)
        {
            this.method_21(format);
            this.EnsureComposites();
            this.IsDefault = false;
            this.method_8();
            this.ImportMembers(format);
            this.method_20(format);
        }

        protected virtual void ImportMembers(FormatBase format)
        {
        }

        protected bool IsPropertyUpdated(int propertyKey)
        {
            return this.PropsUpdateFlags.ContainsKey(propertyKey);
        }

        internal void method_10(short A_0, byte A_1)
        {
            if (((A_1 >= 0) && ((A_1 <= 1) || (A_1 >= 0x80))) && (A_1 <= 0x81))
            {
                this.GetSprmOption(A_0);
            }
        }

        internal void method_11(int A_0)
        {
            int key = this.method_18(A_0);
            this.PropertiesHash.Remove(key);
        }

        internal void method_12(int A_0, int A_1)
        {
            if ((this.int_6 == 0) && (A_1 == 0))
            {
                this.int_6 = A_0;
                this.m_keysOffset = A_1 + 8;
            }
        }

        private void method_13()
        {
            this.bool_0 = false;
            if (this.formatBase_1 != null)
            {
                this.formatBase_1.IsDefault = false;
            }
        }

        internal bool method_14()
        {
            return ((this.list_1 != null) && (this.list_1.Count != 0));
        }

        private int method_15()
        {
            if (this is CharacterFormat)
            {
                return 0x4a30;
            }
            if (this is ParagraphFormat)
            {
                return 0x4600;
            }
            return 0;
        }

        private int method_16()
        {
            if (this is CharacterFormat)
            {
                return 0x2a83;
            }
            if (this is ParagraphFormat)
            {
                return 0x2664;
            }
            if (this is RowFormat)
            {
                return 0x3668;
            }
            return 0;
        }

        internal int method_17(int A_0)
        {
            int[] array = new int[this.PropertiesHash.Keys.Count];
            this.PropertiesHash.Keys.CopyTo(array, 0);
            Array.Sort<int>(array);
            return Array.IndexOf<int>(array, A_0);
        }

        internal int method_18(int A_0)
        {
            int num = 0x11;
            if ((A_0 < 0) || (A_0 >= this.PropertiesHash.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("帶圸强堼䜾", num));
            }
            ArrayList list = new ArrayList(this.PropertiesHash.Keys);
            list.Sort();
            return (int) list[A_0];
        }

        internal object method_19(int A_0)
        {
            int num = 14;
            if ((A_0 < 0) || (A_0 >= this.PropertiesHash.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("崳堵尷弹䐻", num));
            }
            int num2 = this.method_18(A_0);
            return this.PropertiesHash[num2];
        }

        private void method_20(FormatBase A_0)
        {
            if ((A_0.list_1 != null) && (A_0.list_1.Count > 0))
            {
                foreach (XmlNode node in A_0.XmlProps)
                {
                    this.XmlProps.Add(node.Clone());
                }
            }
        }

        internal void method_21(FormatBase A_0)
        {
            Dictionary<int, object> propertiesHash = A_0.PropertiesHash;
            this.m_propertiesHash = new Dictionary<int, object>(propertiesHash.Count);
            IDictionaryEnumerator enumerator = propertiesHash.GetEnumerator();
            while (enumerator.MoveNext())
            {
                this.m_propertiesHash.Add((int) enumerator.Key, enumerator.Value);
            }
        }

        internal void method_22(FormatBase A_0, int A_1)
        {
            Dictionary<int, object> propertiesHash = A_0.PropertiesHash;
            if (propertiesHash.ContainsKey(A_1))
            {
                object obj2 = propertiesHash[A_1];
                if (!this.m_propertiesHash.ContainsKey(A_1))
                {
                    this.m_propertiesHash.Add(A_1, obj2);
                }
                else
                {
                    this.m_propertiesHash[A_1] = obj2;
                }
            }
        }

        internal FormatBase method_23()
        {
            return (this.CloneImpl() as FormatBase);
        }

        internal void method_24(FormatBase A_0)
        {
            this.m_propertiesHash = A_0.PropertiesHash;
        }

        internal void method_25(FormatBase A_0)
        {
            foreach (KeyValuePair<int, object> pair in A_0.PropertiesHash)
            {
                if (!this.PropertiesHash.ContainsKey(pair.Key))
                {
                    this.PropertiesHash.Add(pair.Key, pair.Value);
                }
            }
        }

        internal void method_26(FormatBase A_0)
        {
            foreach (KeyValuePair<int, object> pair in A_0.PropertiesHash)
            {
                if ((!(pair.Value is Borders) && !(pair.Value is Border)) && (!(pair.Value is Paddings) && !(pair.Value is RowFormat.TablePositioning)))
                {
                    if (this.PropertiesHash.ContainsKey(pair.Key))
                    {
                        this.PropertiesHash[pair.Key] = pair.Value;
                    }
                    else
                    {
                        this.PropertiesHash.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        internal void method_27(FormatBase A_0)
        {
            FormatBase base2 = A_0.method_23();
            base2.BaseFormat = null;
            for (FormatBase base3 = A_0.BaseFormat; base3 != null; base3 = base3.BaseFormat)
            {
                foreach (KeyValuePair<int, object> pair in base3.PropertiesHash)
                {
                    if (((!(pair.Value is Borders) && !(pair.Value is Border)) && (!(pair.Value is Paddings) && !(pair.Value is RowFormat.TablePositioning))) && !base2.PropertiesHash.ContainsKey(pair.Key))
                    {
                        base2.PropertiesHash.Add(pair.Key, pair.Value);
                    }
                }
            }
            this.method_26(base2);
            base2 = null;
        }

        private bool method_28(int A_0)
        {
            int fullKey = this.GetFullKey(A_0);
            return ((((this is CharacterFormat) && !this.PropertiesHash.ContainsKey(fullKey)) && (((this as CharacterFormat).CharStyle != null) && ((this as CharacterFormat).CharStyle.CharacterFormat[A_0] != null))) && (this as CharacterFormat).CharStyle.CharacterFormat.HasValue(A_0));
        }

        private object method_29(int A_0)
        {
            object obj2 = this.BaseFormat[A_0];
            if ((((this is CharacterFormat) && ((this as CharacterFormat).TableStyleCharacterFormat != null)) && !(obj2 is bool)) || ((this is ParagraphFormat) && ((this as ParagraphFormat).TableStyleParagraphFormat != null)))
            {
                FormatBase baseFormat = this.BaseFormat;
                int fullKey = this.GetFullKey(A_0);
                while (!baseFormat.PropertiesHash.ContainsKey(fullKey))
                {
                    if (baseFormat.BaseFormat == null)
                    {
                        if (this is CharacterFormat)
                        {
                            return (this as CharacterFormat).TableStyleCharacterFormat[A_0];
                        }
                        return (this as ParagraphFormat).TableStyleParagraphFormat[A_0];
                    }
                    baseFormat = baseFormat.BaseFormat;
                }
            }
            if ((this is ParagraphFormat) && (((A_0 == 0x488) || (A_0 == 0x492)) || ((A_0 == 0x44) || (A_0 == 70))))
            {
                ListFormat listFormat = null;
                if ((this as ParagraphFormat).OwnerBase is Paragraph)
                {
                    listFormat = ((this as ParagraphFormat).OwnerBase as Paragraph).ListFormat;
                }
                else if ((this as ParagraphFormat).OwnerBase is ParagraphStyle)
                {
                    listFormat = ((this as ParagraphFormat).OwnerBase as ParagraphStyle).ListFormat;
                }
                if ((listFormat != null) && listFormat.IsEmptyList)
                {
                    return null;
                }
            }
            return obj2;
        }

        private void method_30(int A_0)
        {
        }

        internal object method_5(int A_0)
        {
            this.method_30(A_0);
            int fullKey = this.GetFullKey(A_0);
            object defComposite = null;
            if (!this.PropertiesHash.ContainsKey(fullKey))
            {
                defComposite = this.GetDefComposite(A_0);
            }
            else
            {
                defComposite = this.PropertiesHash[fullKey];
            }
            if (((defComposite == null) && (this.BaseFormat != null)) && (this.BaseFormat.m_propertiesHash != null))
            {
                defComposite = this.method_29(A_0);
            }
            if (this.method_28(A_0))
            {
                defComposite = (this as CharacterFormat).CharStyle.CharacterFormat[A_0];
            }
            return defComposite;
        }

        internal bool method_6(int A_0)
        {
            return this.HasKey(A_0);
        }

        internal bool method_7(int A_0)
        {
            if (this.PropertiesHash == null)
            {
                return false;
            }
            return (this.PropertiesHash.ContainsKey(A_0) && ((bool) this.PropertiesHash[A_0]));
        }

        internal void method_8()
        {
            if (this.m_propsUpdateFlags != null)
            {
                this.m_propsUpdateFlags.Clear();
            }
        }

        internal void method_9(int A_0, object A_1)
        {
            if (A_1 != null)
            {
                this.SetAttr(A_0, A_1);
            }
        }

        protected virtual void OnChange(FormatBase format, int propKey)
        {
            if (this.formatBase_1 != null)
            {
                this.ParentFormat.OnChange(format, propKey);
            }
        }

        internal virtual void Remove(int propKey)
        {
            if (this.HasKey(propKey))
            {
                this.PropertiesHash.Remove(this.GetFullKey(propKey));
            }
        }

        internal virtual void RemoveChanges()
        {
        }

        internal virtual void RemovePositioning()
        {
        }

        internal virtual void SetAttr(int propKey, object value)
        {
            this[propKey] = value;
        }

        protected void SetPropUpdateFlag(int propKey)
        {
            if (!this.PropsUpdateFlags.ContainsKey(propKey))
            {
                this.m_propsUpdateFlags.Add(propKey, true);
            }
        }

        internal FormatBase BaseFormat
        {
            get
            {
                return this.formatBase_0;
            }
            set
            {
                this.formatBase_0 = value;
            }
        }

        internal int Count
        {
            get
            {
                return this.PropertiesHash.Count;
            }
        }

        Interface45 Interface11.FormatLayoutInfo
        {
            get
            {
                if (this.interface45_0 == null)
                {
                    this.CreateFormatLayoutInfo();
                }
                return this.interface45_0;
            }
        }

        public virtual bool IsDefault
        {
            get
            {
                return this.bool_0;
            }
            internal set
            {
                if (!value)
                {
                    this.method_13();
                }
            }
        }

        internal bool IsInherited
        {
            get
            {
                return (this.formatBase_1 != null);
            }
        }

        internal object this[int A_0]
        {
            get
            {
                object defValue = this.method_5(A_0);
                if (defValue == null)
                {
                    defValue = this.GetDefValue(A_0);
                }
                return defValue;
            }
            set
            {
                int fullKey = this.GetFullKey(A_0);
                this.PropertiesHash[fullKey] = value;
                this.IsDefault = false;
                this.OnChange(this, A_0);
            }
        }

        internal int KeysOffset
        {
            get
            {
                return this.m_keysOffset;
            }
        }

        internal FormatBase ParentFormat
        {
            get
            {
                return this.formatBase_1;
            }
        }

        internal Dictionary<int, object> PropertiesHash
        {
            get
            {
                if (this.m_propertiesHash == null)
                {
                    this.m_propertiesHash = new Dictionary<int, object>();
                }
                return this.m_propertiesHash;
            }
        }

        protected Dictionary<int, bool> PropsUpdateFlags
        {
            get
            {
                if (this.m_propsUpdateFlags == null)
                {
                    this.m_propsUpdateFlags = new Dictionary<int, bool>();
                }
                return this.m_propsUpdateFlags;
            }
        }

        internal List<XmlNode> XmlProps
        {
            get
            {
                if (this.list_1 == null)
                {
                    this.list_1 = new List<XmlNode>();
                }
                return this.list_1;
            }
        }

        internal List<Stream> XmlProps2010
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<Stream>();
                }
                return this.list_0;
            }
        }
    }
}

