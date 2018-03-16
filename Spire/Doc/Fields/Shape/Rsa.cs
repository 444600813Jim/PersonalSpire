namespace Spire.Doc.Fields.Shape
{
    using System;

    public class Rsa
    {
        internal Class897 class897_0;
        internal Class897 class897_1;
        private int int_0;
        private long long_0;

        public Rsa(byte[] modulusBytes, byte[] exponentBytes)
        {
            this.class897_0 = new Class897(modulusBytes);
            this.class897_1 = new Class897(exponentBytes);
        }

        public byte[] Encrypt(byte[] inputBytes)
        {
            if ((inputBytes != null) && (inputBytes.Length >= 1))
            {
                Class897 class2 = new Class897(inputBytes);
                Class897 class3 = class2.method_15(this.class897_1, this.class897_0);
                byte[] buffer = class3.method_7();
                class2.method_12();
                class3.method_12();
                return buffer;
            }
            return new byte[0];
        }

        internal Class897 Exponent
        {
            get
            {
                return this.class897_1;
            }
        }

        internal Class897 Modulus
        {
            get
            {
                return this.class897_0;
            }
        }
    }
}

