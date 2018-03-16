namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;

    public abstract class WordAttrCollection : AttrCollection
    {
        private bool bool_1;
        private byte[] byte_2;
        private float float_0;
        private float[] float_1;
        private const int int_7 = 0x270f;
        private long[] long_2;

        internal WordAttrCollection()
        {
        }

        public WordAttrCollection(IDocument doc) : base(doc)
        {
        }

        public WordAttrCollection(FormatBase parent, int baseKey) : base(parent, baseKey)
        {
        }

        public WordAttrCollection(IDocument doc, DocumentObject owner) : base(doc, owner)
        {
        }

        internal virtual void AcceptFormatRevision()
        {
            this.AcceptFormatRevision(null);
        }

        internal virtual void AcceptFormatRevision(WordAttrCollection attr)
        {
            this.AcceptFormatRevisionCore(-1, null);
        }

        protected void AcceptFormatRevisionCore(int istdKey, int[] keysToPreserve)
        {
            Class580 formatRevision = this.FormatRevision;
            if (formatRevision != null)
            {
                WordAttrCollection attrs = formatRevision.method_4();
                if (((istdKey >= 0) && (attrs.method_31(istdKey) != null)) && (keysToPreserve != null))
                {
                    object[] objArray = new object[keysToPreserve.Length];
                    for (int j = 0; j < keysToPreserve.Length; j++)
                    {
                        objArray[j] = base.method_31(keysToPreserve[j]);
                    }
                    this.ClearAttrs();
                    for (int k = 0; k < keysToPreserve.Length; k++)
                    {
                        if (objArray[k] != null)
                        {
                            this.SetAttr(keysToPreserve[k], objArray[k]);
                        }
                    }
                }
                for (int i = 0; i < attrs.Count; i++)
                {
                    this.SetAttr(attrs.method_18(i), attrs.method_19(i));
                }
            }
            this.Remove(0x271a);
        }

        protected void AcceptFormatRevisionCore(FormatBase format, int[] keysToPreserve, WordAttrCollection attr)
        {
            if (attr != null)
            {
                if ((format != null) && (keysToPreserve != null))
                {
                    object[] objArray = new object[keysToPreserve.Length];
                    for (int j = 0; j < keysToPreserve.Length; j++)
                    {
                        objArray[j] = base.method_31(keysToPreserve[j]);
                    }
                    attr.ClearAttrs();
                    for (int k = 0; k < keysToPreserve.Length; k++)
                    {
                        if (objArray[k] != null)
                        {
                            this.SetAttr(keysToPreserve[k], objArray[k]);
                        }
                    }
                }
                for (int i = 0; i < base.Count; i++)
                {
                    attr.SetAttr(base.method_18(i), base.method_19(i));
                }
            }
        }

        private void method_46()
        {
        }

        internal void method_47()
        {
            this.Remove(0x271a);
        }

        internal void method_48(WordAttrCollection A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                int propKey = A_0.method_18(i);
                this.SetAttr(propKey, A_0[propKey]);
            }
        }

        internal Class579 DeleteRevision
        {
            get
            {
                return (Class579) base.method_31(12);
            }
            set
            {
                this.SetAttr(12, value);
            }
        }

        internal Class580 FormatRevision
        {
            get
            {
                return (Class580) base.method_31(0x271a);
            }
            set
            {
                this.SetAttr(0x271a, value);
            }
        }

        internal bool HasDeleteRevision
        {
            get
            {
                return (this.DeleteRevision != null);
            }
        }

        internal bool HasFormatRevision
        {
            get
            {
                Class580 formatRevision = this.FormatRevision;
                return ((formatRevision != null) && (formatRevision.method_4().Count > 0));
            }
        }

        internal bool HasInsertRevision
        {
            get
            {
                return (this.InsertRevision != null);
            }
        }

        internal bool HasRevisions
        {
            get
            {
                if (!this.HasFormatRevision && !this.HasInsertRevision)
                {
                    return this.HasDeleteRevision;
                }
                return true;
            }
        }

        internal Class579 InsertRevision
        {
            get
            {
                return (Class579) base.method_31(14);
            }
            set
            {
                this.SetAttr(14, value);
            }
        }

        internal WordAttrCollection SysDirectAttrs
        {
            get
            {
                if (!base.HasKey(0x270f))
                {
                    return this;
                }
                return (WordAttrCollection) base.method_31(0x270f);
            }
            set
            {
                this.SetAttr(0x270f, value);
            }
        }
    }
}

