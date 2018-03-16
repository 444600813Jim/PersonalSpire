namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;
    using System.Drawing;

    public class PermissionEnd : ParagraphBase, Interface2
    {
        private bool bool_7;
        internal bool bool_8;
        private Spire.Doc.Documents.DisplacedByCustomXml displacedByCustomXml_0;
        private EditingGroup editingGroup_0;
        private float float_2;
        private int int_4;
        private int int_5;
        private int int_6;
        private string string_8;
        private string string_9;

        internal PermissionEnd(Document A_0) : this(A_0, "")
        {
        }

        public PermissionEnd(IDocument document, string id) : base((Document) document)
        {
            this.string_8 = "";
            this.string_9 = "";
            this.displacedByCustomXml_0 = Spire.Doc.Documents.DisplacedByCustomXml.None;
            this.int_5 = -1;
            this.int_6 = -1;
            this.method_30(id);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_12(visitor.vmethod_27(this));
        }

        internal override void Attach(Paragraph owner, int itemPos)
        {
            base.Attach(owner, itemPos);
            if (!base.DeepDetached)
            {
                base.Document.Permissions.method_7(this);
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
                base.Document.Permissions.method_7(this);
                this.bool_8 = false;
            }
        }

        protected override object CloneImpl()
        {
            PermissionEnd end = (PermissionEnd) base.CloneImpl();
            end.bool_8 = true;
            end.bool_7 = true;
            return end;
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
                Permission permission = base.Document.Permissions.FindById(this.Id);
                if ((permission != null) && !this.bool_7)
                {
                    permission.method_1(null);
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
            writer.WriteValue(BookmarkStart.b("娭䤯䈱儳", 8), ParagraphItemType.PermissionEnd);
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
                return this.int_6;
            }
            set
            {
                this.int_6 = value;
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
                return Spire.Doc.Documents.DocumentObjectType.PermissionEnd;
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

        public string Id
        {
            get
            {
                return this.string_8;
            }
        }
    }
}

