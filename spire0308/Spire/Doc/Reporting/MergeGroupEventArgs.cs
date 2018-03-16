namespace Spire.Doc.Reporting
{
    using Spire.Doc.Interface;
    using System;

    public class MergeGroupEventArgs : EventArgs
    {
        private byte byte_0;
        private GroupEventType groupEventType_0;
        private IDocument idocument_0;
        private IMergeField imergeField_0;
        private int int_0;
        private int int_1;
        private string string_0;
        private string string_1;

        public MergeGroupEventArgs(IDocument doc, IRowsEnumerator rowEnumerator, GroupEventType eventType)
        {
            this.idocument_0 = doc;
            this.int_0 = rowEnumerator.CurrentRowIndex;
            this.int_1 = rowEnumerator.RowsCount;
            this.string_1 = rowEnumerator.TableName;
            this.groupEventType_0 = eventType;
        }

        internal MergeGroupEventArgs(IDocument A_0, IRowsEnumerator A_1, GroupEventType A_2, IMergeField A_3) : this(A_0, A_1, A_2)
        {
            this.imergeField_0 = A_3;
        }

        public IDocument Document
        {
            get
            {
                return this.idocument_0;
            }
        }

        public GroupEventType EventType
        {
            get
            {
                return this.groupEventType_0;
            }
        }

        public string GroupName
        {
            get
            {
                return this.string_1;
            }
        }

        public IMergeField MergeField
        {
            get
            {
                return this.imergeField_0;
            }
        }

        public int RowCount
        {
            get
            {
                return this.int_1;
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
                return this.string_1;
            }
        }
    }
}

