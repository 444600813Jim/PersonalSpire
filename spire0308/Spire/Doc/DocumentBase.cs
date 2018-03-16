namespace Spire.Doc
{
    using System;

    public abstract class DocumentBase : DocumentObject, Interface1
    {
        private bool[] bool_2;
        private float float_0;
        private float[] float_1;
        internal Interface23 interface23_0;
        private string string_5;
        private string[] string_6;

        public DocumentBase(Document doc, DocumentObject owner) : base(doc, owner)
        {
        }

        protected abstract void CreateLayoutInfo();
        internal virtual void DrawImpl(Class196 dc, Class375 ltWidget)
        {
        }

        internal virtual void ResetLayoutInfo()
        {
            this.interface23_0 = null;
        }

        void Interface1.Draw(Class196 dc, Class375 ltWidget)
        {
            this.DrawImpl(dc, ltWidget);
        }

        void Interface1.DrawAfter(Class196 dc, Class375 layoutedWidget)
        {
        }

        Interface23 Interface1.LayoutInfo
        {
            get
            {
                if (this.interface23_0 == null)
                {
                    this.CreateLayoutInfo();
                }
                return this.interface23_0;
            }
        }
    }
}

