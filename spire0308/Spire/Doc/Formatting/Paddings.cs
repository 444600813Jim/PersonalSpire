namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class Paddings : WordAttrCollection
    {
        private bool[] bool_2;
        private bool bool_3;
        private bool bool_4;
        public const int BottomKey = 3;
        private byte[] byte_3;
        private byte[] byte_4;
        public const int LeftKey = 1;
        private long long_3;
        public const int RightKey = 4;
        private string[] string_3;
        public const int TopKey = 2;

        internal Paddings()
        {
            this.bool_3 = true;
            this.All = 0f;
        }

        internal Paddings(FormatBase A_0, int A_1) : base(A_0, A_1)
        {
            this.bool_3 = true;
        }

        internal override void ApplyProperty()
        {
            if (base.m_propsUpdateFlags != null)
            {
                base.m_propsUpdateFlags.Clear();
            }
            Type type = typeof(Paddings);
            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            {
                int num2 = (int) info.GetValue(info.FieldType);
                base.method_31(num2);
            }
        }

        protected override object GetDefValue(int key)
        {
            int num = 2;
            switch (key)
            {
                case 1:
                    return 5.4f;

                case 2:
                    return 0f;

                case 3:
                    return 0f;

                case 4:
                    return 5.4f;
            }
            throw new ArgumentException(BookmarkStart.b("䌧伩唫อ堯匱䜳ᘵ儷吹䨻弽ⰿ⭁⁃晅㹇⭉⁋㭍㕏", num));
        }

        protected override void InitXDLSHolder()
        {
            if (this.IsDefault)
            {
                base.XDLSHolder.SkipMe = true;
            }
        }

        private void method_49()
        {
            if (((this.Left == 0f) && (this.Right == 0f)) && ((this.Top == 0f) && (this.Bottom == 0f)))
            {
                this.bool_3 = true;
            }
            else
            {
                this.bool_3 = false;
            }
        }

        internal void method_50(Paddings A_0)
        {
            if (!A_0.IsDefault)
            {
                this.Left = A_0.Left;
                this.Right = A_0.Right;
                this.Top = A_0.Top;
                this.Bottom = A_0.Bottom;
            }
        }

        internal void method_51()
        {
        }

        protected override void OnChange(FormatBase format, int propertyKey)
        {
            base.OnChange(format, propertyKey);
        }

        protected override void ReadXmlAttributes(IXDLSAttributeReader reader)
        {
            int num = 9;
            base.ReadXmlAttributes(reader);
            if (reader.HasAttribute(BookmarkStart.b("挮吰唲䄴", 9)))
            {
                this.Left = reader.ReadFloat(BookmarkStart.b("挮吰唲䄴", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("紮堰吲崴䌶", num)))
            {
                this.Right = reader.ReadFloat(BookmarkStart.b("紮堰吲崴䌶", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("洮帰䜲䄴堶吸", num)))
            {
                this.Bottom = reader.ReadFloat(BookmarkStart.b("洮帰䜲䄴堶吸", num));
            }
            if (reader.HasAttribute(BookmarkStart.b("笮帰䌲", num)))
            {
                this.Top = reader.ReadFloat(BookmarkStart.b("笮帰䌲", num));
            }
        }

        protected override void WriteXmlAttributes(IXDLSAttributeWriter writer)
        {
            int num = 12;
            base.WriteXmlAttributes(writer);
            if (base.HasKey(1))
            {
                writer.WriteValue(BookmarkStart.b("縱儳倵䰷", num), this.Left);
            }
            if (base.HasKey(4))
            {
                writer.WriteValue(BookmarkStart.b("怱崳儵倷丹", num), this.Right);
            }
            if (base.HasKey(3))
            {
                writer.WriteValue(BookmarkStart.b("瀱嬳䈵䰷唹儻", num), this.Bottom);
            }
            if (base.HasKey(2))
            {
                writer.WriteValue(BookmarkStart.b("昱嬳䘵", num), this.Top);
            }
        }

        public float All
        {
            set
            {
                float num;
                float num2;
                this.Bottom = num = value;
                this.Top = num2 = num;
                this.Left = this.Right = num2;
            }
        }

        public float Bottom
        {
            get
            {
                return (float) base[3];
            }
            set
            {
                this.bool_4 = true;
                base[3] = value;
            }
        }

        internal bool IsEmpty
        {
            get
            {
                if (this.bool_4)
                {
                    return false;
                }
                this.method_49();
                return this.bool_3;
            }
        }

        public float Left
        {
            get
            {
                return (float) base[1];
            }
            set
            {
                this.bool_4 = true;
                base[1] = value;
            }
        }

        internal float PaddingHeight
        {
            get
            {
                return (this.Top + this.Bottom);
            }
        }

        internal float PaddingWidth
        {
            get
            {
                return (this.Left + this.Right);
            }
        }

        public float Right
        {
            get
            {
                return (float) base[4];
            }
            set
            {
                this.bool_4 = true;
                base[4] = value;
            }
        }

        public float Top
        {
            get
            {
                return (float) base[2];
            }
            set
            {
                this.bool_4 = true;
                base[2] = value;
            }
        }
    }
}

