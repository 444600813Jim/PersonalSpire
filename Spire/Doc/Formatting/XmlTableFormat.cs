namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using System;
    using System.Collections.Generic;

    public class XmlTableFormat
    {
        private byte byte_0;
        private List<Stream> list_0;
        private List<XmlNode> list_1;
        private RowFormat rowFormat_0;
        private string string_0;
        private Table table_0;

        internal XmlTableFormat(Table A_0)
        {
            this.table_0 = A_0;
        }

        internal XmlTableFormat method_0(Table A_0)
        {
            XmlTableFormat format = new XmlTableFormat(A_0);
            if (this.rowFormat_0 != null)
            {
                format.Format.ImportContainer(this.rowFormat_0);
                format.Format.LayoutType = this.rowFormat_0.LayoutType;
                if (this.rowFormat_0.Scaling != 100f)
                {
                    format.Format.Scaling = this.rowFormat_0.Scaling;
                }
            }
            format.StyleName = this.string_0;
            format.Owner.method_0(A_0.OwnerTextBody);
            format.NodeArray = this.list_1;
            format.NodeArray2010 = this.list_0;
            return format;
        }

        internal void method_1()
        {
            if (this.rowFormat_0 != null)
            {
                this.rowFormat_0.Close();
                this.rowFormat_0 = null;
            }
            if (this.list_1 != null)
            {
                this.list_1.Clear();
                this.list_1 = null;
            }
        }

        internal RowFormat Format
        {
            get
            {
                if (this.rowFormat_0 == null)
                {
                    this.rowFormat_0 = new RowFormat();
                    this.rowFormat_0.method_0(this.table_0);
                }
                return this.rowFormat_0;
            }
        }

        internal bool HasFormat
        {
            get
            {
                if (((this.rowFormat_0 == null) || this.rowFormat_0.IsDefault) && ((this.list_1 == null) || (this.list_1.Count <= 0)))
                {
                    return false;
                }
                return true;
            }
        }

        internal List<XmlNode> NodeArray
        {
            get
            {
                if (this.list_1 == null)
                {
                    this.list_1 = new List<XmlNode>();
                }
                return this.list_1;
            }
            set
            {
                this.list_1 = value;
            }
        }

        internal List<Stream> NodeArray2010
        {
            get
            {
                if (this.list_0 == null)
                {
                    this.list_0 = new List<Stream>();
                }
                return this.list_0;
            }
            set
            {
                this.list_0 = value;
            }
        }

        internal Table Owner
        {
            get
            {
                return this.table_0;
            }
        }

        internal string StyleName
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }
    }
}

