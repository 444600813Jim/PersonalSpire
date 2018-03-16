namespace Spire.Doc
{
    using System;

    public class Template
    {
        private bool[] bool_0;
        private byte byte_0;
        private Class513 class513_0;
        private int[] int_0;
        private int int_1;
        private long long_0;
        private string[] string_0;

        internal Template(Class513 A_0)
        {
            this.class513_0 = A_0;
        }

        public string Path
        {
            get
            {
                return this.class513_0.method_0();
            }
            set
            {
                this.class513_0.method_1(value);
            }
        }
    }
}

