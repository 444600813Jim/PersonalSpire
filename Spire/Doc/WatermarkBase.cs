namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using Spire.Layouting;
    using System;

    public class WatermarkBase : ParagraphBase
    {
        private bool bool_7;
        private bool bool_8;
        private bool bool_9;
        private byte[] byte_4;
        private float[] float_2;
        private int[] int_4;
        private int[] int_5;
        private int[] int_6;
        private long long_4;
        private WatermarkType watermarkType_0;

        internal WatermarkBase(WatermarkType A_0) : this(null, A_0)
        {
        }

        internal WatermarkBase(Document A_0, WatermarkType A_1) : base(A_0)
        {
            this.bool_7 = true;
            this.bool_8 = true;
            this.bool_9 = true;
            this.watermarkType_0 = A_1;
        }

        protected override void CreateLayoutInfo()
        {
            base.interface23_0 = new Class205(ChildrenLayoutDirection.Horizontal);
            base.interface23_0.imethod_5(true);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 6;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("笫伭䐯圱䘳嬵夷䠹圻樽㤿㉁⅃", 6)))
            {
                this.watermarkType_0 = (WatermarkType) reader.ReadEnum(BookmarkStart.b("笫伭䐯圱䘳嬵夷䠹圻樽㤿㉁⅃", num), typeof(WatermarkType));
            }
        }

        internal override void RemoveSelf()
        {
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            base.WriteXmlAttributes(writer);
            writer.WriteValue(BookmarkStart.b("笫伭䐯圱䘳嬵夷䠹圻樽㤿㉁⅃", 6), this.watermarkType_0);
        }

        public override Spire.Doc.Documents.DocumentObjectType DocumentObjectType
        {
            get
            {
                return Spire.Doc.Documents.DocumentObjectType.Undefined;
            }
        }

        public WatermarkType Type
        {
            get
            {
                return this.watermarkType_0;
            }
        }
    }
}

