namespace Spire.CompoundFile.Doc
{
    using System;
    using System.IO;

    public class ClipboardData : ICloneable
    {
        private bool[] bool_0;
        private bool[] bool_1;
        private byte byte_0;
        public byte[] Data;
        private float float_0;
        public int Format;
        private int int_0;
        private int int_1;

        public object Clone()
        {
            ClipboardData data = (ClipboardData) base.MemberwiseClone();
            data.Data = Class665.smethod_6(this.Data);
            return data;
        }

        public void Parse(Stream stream)
        {
            byte[] buffer = new byte[4];
            int count = Class1115.smethod_1(stream, buffer);
            this.Format = Class1115.smethod_1(stream, buffer);
            this.Data = new byte[count];
            stream.Read(this.Data, 0, count);
        }

        public int Serialize(Stream stream)
        {
            int num = 0;
            int length = this.Data.Length;
            num = 0 + Class1115.smethod_4(stream, length);
            num += Class1115.smethod_4(stream, this.Format);
            stream.Write(this.Data, 0, length);
            return (num + length);
        }
    }
}

