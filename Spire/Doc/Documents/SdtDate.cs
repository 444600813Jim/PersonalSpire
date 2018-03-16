namespace Spire.Doc.Documents
{
    using Spire.Doc;
    using System;
    using System.Globalization;

    public class SdtDate : SdtControlProperties
    {
        private bool bool_0;
        private byte[] byte_0;
        private Spire.Doc.Documents.CalendarType calendarType_0;
        private DateTime dateTime_0 = DateTime.MinValue;
        private float[] float_0;
        internal const int int_0 = -1;
        private int int_1 = -1;
        private SdtDateStorageFormat sdtDateStorageFormat_0 = SdtDateStorageFormat.DateTime;
        private string string_1 = "";
        private string string_2;
        private string string_3;

        internal void method_0(DateTime A_0)
        {
            this.dateTime_0 = A_0;
        }

        internal CultureInfo method_1()
        {
            int num = 0x10;
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            if (this.Lid == -1)
            {
                return invariantCulture;
            }
            string name = ((LocaleIDs) this.Lid).ToString();
            if (this.Lid == 0x40a)
            {
                int index = name.IndexOf('_');
                if (index > -1)
                {
                    name = name.Remove(index, 1).Insert(index, BookmarkStart.b("ᬵ", num));
                }
            }
            else
            {
                name = name.Replace('_', '-');
            }
            return new CultureInfo(name);
        }

        internal static string smethod_0(DateTime A_0)
        {
            return A_0.ToString(BookmarkStart.b("听嘮䠰䨲ᠴ稶琸ᘺ夼嬾ᕀୂൄ絆⑈♊睌㱎≐॒", 7), CultureInfo.InvariantCulture);
        }

        internal static DateTime smethod_1(string A_0)
        {
            return smethod_2(A_0, CultureInfo.InvariantCulture);
        }

        private static DateTime smethod_2(string A_0, IFormatProvider A_1)
        {
            DateTime time;
            if (!DateTime.TryParse(A_0, A_1, DateTimeStyles.AdjustToUniversal, out time))
            {
                return DateTime.MinValue;
            }
            return time;
        }

        public Spire.Doc.Documents.CalendarType CalendarType
        {
            get
            {
                return this.calendarType_0;
            }
            set
            {
                this.calendarType_0 = value;
            }
        }

        public string DateFormat
        {
            get
            {
                return this.string_1;
            }
            set
            {
                this.string_1 = value;
            }
        }

        public DateTime FullDate
        {
            get
            {
                return this.dateTime_0;
            }
            set
            {
                this.dateTime_0 = value;
                this.OnChange();
            }
        }

        public int Lid
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
            }
        }

        internal SdtDateStorageFormat StoreMappedDataAs
        {
            get
            {
                return this.sdtDateStorageFormat_0;
            }
            set
            {
                this.sdtDateStorageFormat_0 = value;
            }
        }

        internal override SdtType Type
        {
            get
            {
                return SdtType.DatePicker;
            }
        }
    }
}

