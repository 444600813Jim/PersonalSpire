namespace Spire.Doc
{
    using System;

    public class Hyphenation
    {
        private byte byte_0;
        private Document document_0;
        private float[] float_0;

        internal Hyphenation(Document A_0)
        {
            this.document_0 = A_0;
        }

        public bool AutoHyphenation
        {
            get
            {
                return this.document_0.Settings.bool_27;
            }
            set
            {
                this.document_0.Settings.bool_27 = value;
            }
        }

        public int ConsecutiveHyphensLimit
        {
            get
            {
                return this.document_0.Settings.int_15;
            }
            set
            {
                int num = 0;
                if ((value < 0) || (value > 0x7fff))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("攥䜧䐩弫䬭匯䜱䀳張丷弹᰻嘽㤿㉁ⱃ⍅♇㥉汋≍㥏㽑㵓≕硗㝙⥛ⵝᑟ䉡٣ͥ䡧ࡩ५ᩭݯ᝱ᅳᡵ塷䩹屻ώꒃ떅몇붉몋릍뺏", num));
                }
                this.document_0.Settings.int_15 = value;
            }
        }

        public bool HyphenateCaps
        {
            get
            {
                return this.document_0.Settings.bool_28;
            }
            set
            {
                this.document_0.Settings.bool_28 = value;
            }
        }

        public float HyphenationZone
        {
            get
            {
                return (((float) this.document_0.Settings.int_16) / 20f);
            }
            set
            {
                int num = 0x12;
                if ((value < 0.05) || (value > 1584f))
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("瀷䌹䰻嘽┿ⱁ╃㉅ⅇ╉≋湍⩏㵑㩓㍕硗㝙⥛ⵝᑟ䉡٣ͥ䡧ࡩ५ᩭݯ᝱ᅳᡵ塷䩹剻乽땿ꊁꢇ낏ꎑꆓ꺕겗몙躟", num));
                }
                this.document_0.Settings.int_16 = (int) Math.Round((double) (value * 20f));
            }
        }
    }
}

