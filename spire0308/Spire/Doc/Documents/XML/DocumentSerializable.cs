namespace Spire.Doc.Documents.XML
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;

    public abstract class DocumentSerializable : OwnerHolder, IDocumentSerializable
    {
        private byte[] byte_0;
        private int[] int_1;
        private string string_1;
        private string string_2;
        private Spire.Doc.Documents.XML.XDLSHolder xdlsholder_0;

        protected DocumentSerializable(Document doc, DocumentObject entity) : base(doc, entity)
        {
        }

        protected virtual object CloneImpl()
        {
            DocumentSerializable serializable = (DocumentSerializable) base.MemberwiseClone();
            serializable.xdlsholder_0 = null;
            serializable.method_0(null);
            return serializable;
        }

        internal virtual void CloneRelationsTo(Document doc, OwnerHolder nextOwner)
        {
        }

        protected virtual void InitXDLSHolder()
        {
        }

        internal object method_4()
        {
            return this.CloneImpl();
        }

        protected virtual void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 6;
            if (reader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("師䬭儯嘱儳䐵", num));
            }
        }

        protected virtual bool ReadXmlContent(IXDLSContentReader reader)
        {
            int num = 3;
            if (reader == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("嬨个䰬䬮吰䄲", num));
            }
            return false;
        }

        protected virtual void RestoreReference(string name, int index)
        {
        }

        void IDocumentSerializable.ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            this.ReadXmlAttributes(reader);
        }

        bool IDocumentSerializable.ReadXmlContent(IXDLSContentReader reader)
        {
            if (!this.XDLSHolder.ReadHolder(reader))
            {
                return this.ReadXmlContent(reader);
            }
            return true;
        }

        void IDocumentSerializable.RestoreReference(string name, int value)
        {
            this.RestoreReference(name, value);
        }

        void IDocumentSerializable.WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            this.WriteXmlAttributes(writer);
        }

        void IDocumentSerializable.WriteXmlContent(IXDLSContentWriter writer)
        {
            this.XDLSHolder.WriteHolder(writer);
            this.WriteXmlContent(writer);
        }

        protected virtual void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 0x12;
            if (writer == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("伷䠹唻䨽┿ぁ", num));
            }
        }

        protected virtual void WriteXmlContent(IXDLSContentWriter writer)
        {
            int num = 0x10;
            if (writer == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䄵䨷匹䠻嬽㈿", num));
            }
        }

        Spire.Doc.Documents.XML.XDLSHolder IDocumentSerializable.XDLSHolder
        {
            get
            {
                if (this.xdlsholder_0 == null)
                {
                    this.xdlsholder_0 = new Spire.Doc.Documents.XML.XDLSHolder();
                }
                if (this.xdlsholder_0.Cleared)
                {
                    this.xdlsholder_0.Cleared = false;
                    this.InitXDLSHolder();
                }
                return this.xdlsholder_0;
            }
        }

        protected Spire.Doc.Documents.XML.XDLSHolder XDLSHolder
        {
            get
            {
                return ((IDocumentSerializable) this).XDLSHolder;
            }
        }
    }
}

