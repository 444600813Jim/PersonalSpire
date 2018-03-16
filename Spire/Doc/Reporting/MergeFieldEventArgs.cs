namespace Spire.Doc.Reporting
{
    using Spire.Doc.Formatting;
    using Spire.Doc.Interface;
    using System;

    public class MergeFieldEventArgs : EventArgs
    {
        private bool bool_0;
        private byte[] byte_0;
        private byte[] byte_1;
        private byte byte_2;
        private float[] float_0;
        private IDocument idocument_0;
        private IMergeField imergeField_0;
        private int int_0;
        private long[] long_0;
        private object object_0;
        private string string_0;

        public MergeFieldEventArgs(IDocument doc, string tableName, int rowIndex, IMergeField field, object value)
        {
            this.idocument_0 = doc;
            this.imergeField_0 = field;
            this.object_0 = value;
            this.int_0 = rowIndex;
            this.string_0 = tableName;
            this.bool_0 = false;
        }

        public Spire.Doc.Formatting.CharacterFormat CharacterFormat
        {
            get
            {
                return this.imergeField_0.CharacterFormat;
            }
        }

        public IMergeField CurrentMergeField
        {
            get
            {
                return this.imergeField_0;
            }
        }

        public IDocument Document
        {
            get
            {
                return this.idocument_0;
            }
        }

        public string FieldName
        {
            get
            {
                return this.imergeField_0.FieldName;
            }
        }

        public object FieldValue
        {
            get
            {
                return this.object_0;
            }
        }

        public bool IsKeepTextFormat
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        public int RowIndex
        {
            get
            {
                return this.int_0;
            }
        }

        public string TableName
        {
            get
            {
                return this.string_0;
            }
        }

        public string Text
        {
            get
            {
                if (this.FieldValue == null)
                {
                    return "";
                }
                return this.FieldValue.ToString();
            }
            set
            {
                this.object_0 = value;
            }
        }
    }
}

