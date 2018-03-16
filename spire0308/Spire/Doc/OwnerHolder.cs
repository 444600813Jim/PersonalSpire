namespace Spire.Doc
{
    using System;

    public abstract class OwnerHolder
    {
        private int int_0;
        private long long_0;
        private long long_1;
        protected Spire.Doc.Document m_doc;
        private OwnerHolder ownerHolder_0;
        private string string_0;

        public OwnerHolder()
        {
        }

        public OwnerHolder(Spire.Doc.Document doc) : this(doc, null)
        {
        }

        public OwnerHolder(Spire.Doc.Document doc, OwnerHolder owner)
        {
            this.m_doc = doc;
            this.ownerHolder_0 = owner;
        }

        internal void method_0(OwnerHolder A_0)
        {
            this.ownerHolder_0 = A_0;
            if (A_0 != null)
            {
                this.m_doc = A_0.Document;
            }
        }

        internal HeaderFooter method_1()
        {
            OwnerHolder ownerBase = this.OwnerBase;
            while (ownerBase != null)
            {
                if (ownerBase is HeaderFooter)
                {
                    break;
                }
                ownerBase = ownerBase.OwnerBase;
            }
            return (ownerBase as HeaderFooter);
        }

        internal Section method_2()
        {
            OwnerHolder ownerBase = this.OwnerBase;
            while (ownerBase != null)
            {
                if (ownerBase is Section)
                {
                    break;
                }
                ownerBase = ownerBase.OwnerBase;
            }
            return (ownerBase as Section);
        }

        internal void method_3(Spire.Doc.Document A_0, OwnerHolder A_1)
        {
            this.ownerHolder_0 = A_1;
            if (A_1 == null)
            {
                this.m_doc = A_0;
            }
            else
            {
                this.m_doc = A_1.Document;
            }
        }

        internal virtual void OnStateChange(object sender)
        {
            if (this.ownerHolder_0 != null)
            {
                this.ownerHolder_0.OnStateChange(sender);
            }
        }

        public Spire.Doc.Document Document
        {
            get
            {
                if (this.ownerHolder_0 == null)
                {
                    return this.m_doc;
                }
                return this.ownerHolder_0.Document;
            }
        }

        internal OwnerHolder OwnerBase
        {
            get
            {
                return this.ownerHolder_0;
            }
        }
    }
}

