namespace Spire.Doc
{
    using Spire.Doc.Interface;
    using System;

    public abstract class DocumentContainer : DocumentBase, Interface3
    {
        public DocumentContainer(Document doc, DocumentObject owner) : base(doc, owner)
        {
        }

        int Interface3.Count
        {
            get
            {
                return this.WidgetCollection.Count;
            }
        }

        Interface1 Interface3.this[int index]
        {
            get
            {
                return (this.WidgetCollection[index] as Interface1);
            }
        }

        protected abstract IDocumentObjectCollection WidgetCollection { get; }
    }
}

