namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using Spire.Doc.Formatting;
    using System;

    public class StructureDocumentTagCell : TableCell, IStructureDocument
    {
        private bool bool_7;
        private bool bool_8;
        private byte[] byte_4;
        private CharacterFormat characterFormat_1;
        private Document document_0;
        private Spire.Doc.Documents.SDTProperties sdtproperties_0;
        private TableRow tableRow_0;

        public StructureDocumentTagCell(TableRow ownerRow) : base(ownerRow.Document)
        {
            this.tableRow_0 = ownerRow;
            this.document_0 = ownerRow.Document;
            this.sdtproperties_0 = new Spire.Doc.Documents.SDTProperties(this);
            this.characterFormat_1 = new CharacterFormat(this.document_0);
            this.tableRow_0.Cells.Add(this);
        }

        internal override bool Accept(Class420 visitor)
        {
            return base.method_9(visitor);
        }

        internal override VisitorAction AcceptEnd(Class420 visitor)
        {
            return visitor.vmethod_47(this);
        }

        internal override VisitorAction AcceptStart(Class420 visitor)
        {
            return visitor.vmethod_46(this);
        }

        protected override object CloneImpl()
        {
            StructureDocumentTagCell cell = (StructureDocumentTagCell) base.CloneImpl();
            cell.sdtproperties_0 = this.SDTProperties.method_9();
            cell.sdtproperties_0.method_7(cell);
            return cell;
        }

        internal void method_63()
        {
            base.method_62();
            if (this.characterFormat_1 != null)
            {
                this.characterFormat_1.Close();
            }
        }

        internal StructureDocumentTagCell method_64()
        {
            return (StructureDocumentTagCell) this.CloneImpl();
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

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.StructureDocumentTagCell;
            }
        }

        public Spire.Doc.Documents.SDTProperties SDTProperties
        {
            get
            {
                return this.sdtproperties_0;
            }
        }
    }
}

