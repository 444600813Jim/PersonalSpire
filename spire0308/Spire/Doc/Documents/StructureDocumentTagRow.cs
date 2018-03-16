namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Formatting;
    using System;

    public class StructureDocumentTagRow : TableRow, IStructureDocument
    {
        private bool[] bool_12;
        private CellCollection cellCollection_1;
        private CharacterFormat characterFormat_1;
        private Class180 class180_0;
        private Document document_0;
        private float float_2;
        private int[] int_3;
        private int[] int_4;
        private Spire.Doc.Documents.SDTProperties sdtproperties_0;
        private string string_7;
        private Table table_0;

        internal StructureDocumentTagRow(StructureDocumentTagRow A_0) : this(A_0.OwnerTable, A_0.Document)
        {
            A_0.ChildObjects.Add(this);
        }

        public StructureDocumentTagRow(Table ownerTable) : this(ownerTable, ownerTable.Document)
        {
            ownerTable.Rows.Add(this);
        }

        internal StructureDocumentTagRow(Table A_0, Document A_1) : base(A_1)
        {
            this.table_0 = A_0;
            this.document_0 = A_1;
            this.sdtproperties_0 = new Spire.Doc.Documents.SDTProperties(this);
            this.characterFormat_1 = new CharacterFormat(this.document_0);
            this.cellCollection_1 = new CellCollection(this);
            this.class180_0 = new Class180(this.cellCollection_1);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_49(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_48(this);
        }

        protected override object CloneImpl()
        {
            StructureDocumentTagRow row = (StructureDocumentTagRow) base.CloneImpl();
            row.sdtproperties_0 = this.SDTProperties.method_9();
            row.sdtproperties_0.method_7(row);
            row.cellCollection_1 = new CellCollection(row);
            this.ChildObjects.method_12(row.cellCollection_1);
            row.class180_0 = new Class180(row.cellCollection_1);
            row.characterFormat_1 = new CharacterFormat(base.Document);
            row.characterFormat_1.ImportContainer(this.BreakCharacterFormat);
            row.characterFormat_1.method_21(this.BreakCharacterFormat);
            row.characterFormat_1.method_0(row);
            return row;
        }

        internal void method_41()
        {
            base.method_36();
            if (this.characterFormat_1 != null)
            {
                this.characterFormat_1.Close();
            }
            if ((this.cellCollection_1 != null) && (this.cellCollection_1.Count > 0))
            {
                int count = this.cellCollection_1.Count;
                TableCell cell = null;
                for (int i = 0; i < count; i++)
                {
                    cell = this.cellCollection_1[i];
                    cell.method_62();
                    cell = null;
                }
                this.cellCollection_1.Clear();
                this.cellCollection_1 = null;
            }
        }

        internal StructureDocumentTagRow method_42()
        {
            return (StructureDocumentTagRow) this.CloneImpl();
        }

        public void UpdateDataBinding()
        {
            this.SDTProperties.method_0(base.Document.CustomXmlParts);
        }

        public CharacterFormat BreakCharacterFormat
        {
            get
            {
                return this.characterFormat_1;
            }
        }

        public override CellCollection Cells
        {
            get
            {
                if (this.SdtRows.Count > 0)
                {
                    return this.SdtRows.method_13(0).Cells;
                }
                return this.cellCollection_1;
            }
            set
            {
                this.cellCollection_1 = value;
            }
        }

        public override DocumentObjectCollection ChildObjects
        {
            get
            {
                return this.cellCollection_1;
            }
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.StructureDocumentTagRow;
            }
        }

        internal override Table OwnerTable
        {
            get
            {
                return this.table_0;
            }
        }

        public Spire.Doc.Documents.SDTProperties SDTProperties
        {
            get
            {
                return this.sdtproperties_0;
            }
        }

        internal Class180 SdtRows
        {
            get
            {
                return this.class180_0;
            }
        }
    }
}

