namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class FormFieldCollection : CollectionEx
    {
        private Dictionary<string, FormField> dictionary_0;
        private int[] int_2;
        private long long_4;

        internal FormFieldCollection(Body A_0) : base(A_0.Document, A_0)
        {
            this.dictionary_0 = new Dictionary<string, FormField>();
            this.method_8(A_0);
        }

        public bool ContainsName(string itemName)
        {
            return this.dictionary_0.ContainsKey(itemName);
        }

        private void method_10(Table A_0)
        {
            foreach (TableRow row in A_0.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    this.method_8(cell);
                }
            }
        }

        private FormField method_11(string A_0)
        {
            if (this.dictionary_0.ContainsKey(A_0))
            {
                return this.dictionary_0[A_0];
            }
            return null;
        }

        internal void method_5(string A_0, string A_1)
        {
            FormField field = this.dictionary_0[A_0];
            this.dictionary_0.Remove(A_0);
            this.dictionary_0.Add(A_1, field);
            TableCell ownerBase = base.OwnerBase as TableCell;
            if (((ownerBase != null) && (ownerBase.OwnerRow != null)) && (ownerBase.OwnerRow.OwnerTable != null))
            {
                Body ownerTextBody = ownerBase.OwnerRow.OwnerTable.OwnerTextBody;
                if ((ownerTextBody != null) && ownerTextBody.IsFormFieldsCreated)
                {
                    ownerTextBody.FormFields.method_5(A_0, A_1);
                }
            }
        }

        internal void method_6(FormField A_0)
        {
            base.InnerList.Add(A_0);
            if (((A_0.Name != null) && (A_0.Name != string.Empty)) && !this.dictionary_0.ContainsKey(A_0.Name))
            {
                this.dictionary_0.Add(A_0.Name, A_0);
            }
        }

        internal void method_7(FormField A_0)
        {
            base.InnerList.Remove(A_0);
            if (((A_0.Name != null) && (A_0.Name != string.Empty)) && this.dictionary_0.ContainsKey(A_0.Name))
            {
                this.dictionary_0.Remove(A_0.Name);
                Bookmark bookmark = base.m_doc.Bookmarks.FindByName(A_0.Name);
                if (bookmark != null)
                {
                    base.m_doc.Bookmarks.Remove(bookmark);
                }
            }
        }

        private void method_8(Body A_0)
        {
            foreach (BodyRegion region in A_0.ChildObjects)
            {
                switch (region.DocumentObjectType)
                {
                    case DocumentObjectType.Paragraph:
                        this.method_9((Paragraph) region);
                        break;

                    case DocumentObjectType.Table:
                        this.method_10((Table) region);
                        break;
                }
            }
        }

        private void method_9(Paragraph A_0)
        {
            foreach (ParagraphBase base2 in A_0.Items)
            {
                if (((base2.DocumentObjectType == DocumentObjectType.TextFormField) || (base2.DocumentObjectType == DocumentObjectType.CheckBox)) || (base2.DocumentObjectType == DocumentObjectType.DropDownFormField))
                {
                    this.method_6((FormField) base2);
                }
                switch (base2.DocumentObjectType)
                {
                    case DocumentObjectType.Comment:
                        this.method_8((base2 as Comment).Body);
                        break;

                    case DocumentObjectType.Footnote:
                        this.method_8((base2 as Footnote).TextBody);
                        break;

                    case DocumentObjectType.TextBox:
                        this.method_8((base2 as TextBox).Body);
                        break;
                }
            }
        }

        internal Dictionary<string, FormField> FormFieldDictonary
        {
            get
            {
                return this.dictionary_0;
            }
        }

        public FormField this[int index]
        {
            get
            {
                return (FormField) base.InnerList[index];
            }
        }

        public FormField this[string formFieldName]
        {
            get
            {
                return this.method_11(formFieldName);
            }
        }
    }
}

