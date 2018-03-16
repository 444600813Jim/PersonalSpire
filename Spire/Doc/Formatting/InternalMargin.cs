namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Fields;
    using System;

    public class InternalMargin
    {
        internal const float float_0 = 7.2f;
        private float[] float_1;
        internal const float float_2 = 3.6f;
        private int[] int_0;
        private string string_0;
        private TextBox textBox_0;

        public InternalMargin(TextBox textbox)
        {
            this.textBox_0 = textbox;
        }

        public float All
        {
            set
            {
                int num = 2;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("椧䘩䀫", num), BookmarkStart.b("愧䐩堫䬭䈯就唳娵ᠷ圹崻䰽✿⭁⩃晅╇㽉㽋㩍灏けㅓ癕し㍙㭛㙝՟ၡ䑣ብg୩ɫ乭䁯", num));
                }
                this.textBox_0.SetShapeAttr(0x81, (int) (value * 12700f));
                this.textBox_0.SetShapeAttr(130, (int) (value * 12700f));
                this.textBox_0.SetShapeAttr(0x83, (int) (value * 12700f));
                this.textBox_0.SetShapeAttr(0x84, (int) (value * 12700f));
            }
        }

        public float Bottom
        {
            get
            {
                return (((float) ((int) this.textBox_0.GetShapeAttribute(0x84))) / 12700f);
            }
            set
            {
                int num = 9;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("洮帰䜲䄴堶吸", num), BookmarkStart.b("昮弰䜲倴䔶圸娺儼Ἶ⍀ⱂㅄ㍆♈♊浌≎ぐ⅒㉔㹖㝘筚ぜ⩞በᝢ䕤զ౨䭪լٮᙰ᭲ၴն奸ེᕼṾꎂ떄", num));
                }
                this.textBox_0.SetShapeAttr(0x84, (int) (value * 12700f));
            }
        }

        public float Left
        {
            get
            {
                return (((float) ((int) this.textBox_0.GetShapeAttribute(0x81))) / 12700f);
            }
            set
            {
                int num = 15;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("礴制弸伺", num), BookmarkStart.b("簴夶䴸帺似儾⁀⽂敄⭆ⱈⵊ㥌潎㱐㉒❔ざじ㕚絜㉞ᑠၢᅤ䝦୨๪䵬ݮᡰᑲᵴቶ୸孺ॼ᝾ꖄ랆", num));
                }
                this.textBox_0.SetShapeAttr(0x81, (int) (value * 12700f));
            }
        }

        public float Right
        {
            get
            {
                return (((float) ((int) this.textBox_0.GetShapeAttribute(0x83))) / 12700f);
            }
            set
            {
                int num = 5;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("礪䐬䠮夰䜲", num), BookmarkStart.b("截䌬嬮吰䄲嬴嘶唸ᬺ似嘾♀⭂ㅄ杆⑈⩊㽌⡎㡐㵒畔㩖ⱘ⡚⥜罞͠٢䕤སh౪լ੮Ͱ卲Ŵὶᡸᕺ嵼佾", num));
                }
                this.textBox_0.SetShapeAttr(0x83, (int) (value * 12700f));
            }
        }

        public float Top
        {
            get
            {
                return (((float) ((int) this.textBox_0.GetShapeAttribute(130))) / 12700f);
            }
            set
            {
                int num = 10;
                if (value < 0f)
                {
                    throw new ArgumentOutOfRangeException(BookmarkStart.b("搯崱䐳", num), BookmarkStart.b("礯就䀳匵䨷吹崻刽怿㙁⭃㙅桇❉ⵋ㱍㝏㭑㩓癕㕗⽙⽛⩝䁟aţ䙥gͩ୫٭ᕯq味ɵၷ᭹ቻ幽끿", num));
                }
                this.textBox_0.SetShapeAttr(130, (int) (value * 12700f));
            }
        }
    }
}

