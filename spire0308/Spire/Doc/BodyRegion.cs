namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using System;
    using System.Text.RegularExpressions;

    public abstract class BodyRegion : DocumentBase, IBodyRegion
    {
        public BodyRegion(Document doc) : base(doc, null)
        {
        }

        internal abstract void AcceptCChanges();
        internal abstract void AcceptPChanges();
        internal abstract bool CheckChangedCFormat();
        internal abstract bool CheckChangedPFormat();
        internal abstract bool CheckDeleteRev();
        internal abstract bool CheckInsertRev();
        internal abstract void Close();
        public abstract TextSelection Find(Regex pattern);
        internal abstract Class185 FindAll(Regex pattern);
        protected BodyRegion GetNextInSection(Section section)
        {
            if (section != null)
            {
                Section nextSibling = section.NextSibling as Section;
                if ((nextSibling != null) && (nextSibling.Body.Items.Count > 0))
                {
                    return nextSibling.Body.Items[0];
                }
            }
            return null;
        }

        internal abstract BodyRegion GetNextTextBodyItem();
        internal abstract bool HasTrackedChanges();
        internal abstract void MakeChanges(bool acceptChanges);
        internal Body method_21()
        {
            DocumentObject owner = base.Owner;
            if (!(owner is Body) || (owner is SDTContent))
            {
                while (owner != null)
                {
                    if ((owner is Body) && !(owner is SDTContent))
                    {
                        return (owner as Body);
                    }
                    owner = owner.Owner;
                }
                return null;
            }
            return (owner as Body);
        }

        internal abstract void RemoveCFormatChanges();
        internal abstract void RemovePFormatChanges();
        public abstract int Replace(Regex pattern, TextSelection textSelection);
        public abstract int Replace(Regex pattern, string replace);
        public abstract int Replace(Regex pattern, TextSelection textSelection, bool saveFormatting);
        public abstract int Replace(string given, string replace, bool caseSensitive, bool wholeWord);
        internal abstract void SetChangedCFormat(bool check);
        internal abstract void SetChangedPFormat(bool check);
        internal abstract void SetDeleteRev(bool check);
        internal abstract void SetInsertRev(bool check);

        internal bool IsChangedCFormat
        {
            get
            {
                return this.CheckChangedCFormat();
            }
        }

        internal bool IsChangedPFormat
        {
            get
            {
                return this.CheckChangedPFormat();
            }
        }

        public bool IsDeleteRevision
        {
            get
            {
                return this.CheckDeleteRev();
            }
        }

        public bool IsInsertRevision
        {
            get
            {
                return this.CheckInsertRev();
            }
        }

        internal BodyRegion NextTextBodyItem
        {
            get
            {
                return this.GetNextTextBodyItem();
            }
        }

        public Body OwnerTextBody
        {
            get
            {
                return (base.Owner as Body);
            }
        }
    }
}

