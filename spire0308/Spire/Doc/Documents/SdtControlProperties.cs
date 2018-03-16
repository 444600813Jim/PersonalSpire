namespace Spire.Doc.Documents
{
    using System;

    public abstract class SdtControlProperties
    {
        private long long_0;
        internal SDTProperties sdtproperties_0;
        private string[] string_0;

        protected SdtControlProperties()
        {
        }

        internal virtual SdtControlProperties Clone()
        {
            return (SdtControlProperties) base.MemberwiseClone();
        }

        internal virtual void OnChange()
        {
            if (this.sdtproperties_0 != null)
            {
                this.sdtproperties_0.method_8();
            }
        }

        internal SDTProperties Owner
        {
            get
            {
                return this.sdtproperties_0;
            }
            set
            {
                this.sdtproperties_0 = value;
            }
        }

        internal abstract SdtType Type { get; }
    }
}

