namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class TextBoxItemCollection : DocumentObjectCollection, ITextBoxItemCollection
    {
        private byte[] byte_1;
        private int int_2;
        private string string_1;
        private string string_2;
        private static readonly Type[] type_0 = new Type[] { typeof(TextBox) };

        public TextBoxItemCollection(IDocument doc) : base((Document) doc, (Document) doc)
        {
        }

        public int Add(ITextBox textBox)
        {
            return base.InnerList.Add(textBox);
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return base.Document.CreateParagraphItem(ParagraphItemType.TextBox);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("䈵崷䈹䠻尽⼿㩁⅃㕅", 0x10);
        }

        public ITextBox this[int index]
        {
            get
            {
                return (ITextBox) base.InnerList[index];
            }
        }

        protected override Type[] TypesOfElement
        {
            get
            {
                return type_0;
            }
        }
    }
}

