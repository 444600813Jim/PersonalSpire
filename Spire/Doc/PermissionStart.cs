namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class PermissionStart : ParagraphBase, Interface2
    {
        private bool bool_7;
        internal bool bool_8;
        private byte byte_4;
        private byte byte_5;
        private Spire.Doc.Documents.DisplacedByCustomXml displacedByCustomXml_0;
        private EditingGroup editingGroup_0;
        private int int_4;
        private int int_5;
        private int[] int_6;
        private int int_7;
        private long[] long_4;
        private string[] string_10;
        private string[] string_11;
        private string string_8;
        private string string_9;

        internal PermissionStart(Document A_0) : this(A_0, "")
        {
        }

        public PermissionStart(IDocument doc, string id) : base((Document) doc)
        {
            this.string_8 = "";
            this.string_9 = "";
            this.displacedByCustomXml_0 = Spire.Doc.Documents.DisplacedByCustomXml.None;
            this.int_5 = -1;
            this.int_7 = -1;
            this.method_30(id);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_28(this));
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if (!base.DeepDetached)
            {
                base.Document.Permissions.method_6(this);
                this.bool_8 = false;
            }
            else
            {
                this.bool_8 = true;
                this.bool_7 = true;
            }
        }

        internal override void CloneCommit()
        {
            if (this.bool_8 && this.bool_7)
            {
                base.Document.Permissions.method_6(this);
                this.bool_8 = false;
                this.bool_7 = false;
            }
        }

        protected override object CloneImpl()
        {
            PermissionStart start = (PermissionStart) base.CloneImpl();
            start.bool_8 = true;
            start.bool_7 = true;
            return start;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_13(true);
            base.interface23_0.imethod_5(true);
        }

        internal override void Detach()
        {
            base.Detach();
            if (!base.DeepDetached)
            {
                PermissionCollection permissions = base.Document.Permissions;
                Permission permission = permissions.FindById(this.Id);
                if (permission != null)
                {
                    permission.method_0(null);
                    permissions.Remove(permission);
                }
            }
        }

        internal void method_30(string A_0)
        {
            this.string_8 = A_0.Replace('-', '_');
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            base.ReadXmlAttributes(reader);
        }

        SizeF Interface2.Measure(Class196 dc)
        {
            return new SizeF(0.0045f, 0f);
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("䌶䀸䬺堼", 0x11), ParagraphItemType.PermissionStart);
        }

        internal int ColumnFirst
        {
            get
            {
                return this.int_5;
            }
            set
            {
                this.int_5 = value;
            }
        }

        internal int ColumnLast
        {
            get
            {
                return this.int_7;
            }
            set
            {
                this.int_7 = value;
            }
        }

        internal Spire.Doc.Documents.DisplacedByCustomXml DisplacedByCustomXml
        {
            get
            {
                return this.displacedByCustomXml_0;
            }
            set
            {
                this.displacedByCustomXml_0 = value;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.PermissionStart;
            }
        }

        internal string Editor
        {
            get
            {
                return this.string_9;
            }
            set
            {
                this.string_9 = value;
            }
        }

        public EditingGroup EditorGroup
        {
            get
            {
                return this.editingGroup_0;
            }
            set
            {
                this.editingGroup_0 = value;
            }
        }

        internal int Flags
        {
            get
            {
                return this.int_4;
            }
            set
            {
                this.int_4 = value;
            }
        }

        public string Id
        {
            get
            {
                return this.string_8;
            }
        }
    }
}

