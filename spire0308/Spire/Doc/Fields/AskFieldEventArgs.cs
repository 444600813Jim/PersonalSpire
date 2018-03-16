namespace Spire.Doc.Fields
{
    using Spire.Doc;
    using System;

    public class AskFieldEventArgs : IFieldsEventArgs
    {
        private bool bool_0;
        private bool bool_1;
        private Spire.Doc.Fields.Field field_0;
        private float[] float_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;

        internal AskFieldEventArgs(Spire.Doc.Fields.Field A_0)
        {
            int num4 = 12;
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
            this.string_3 = string.Empty;
            this.field_0 = A_0;
            string str = A_0.method_137(A_0.method_177()).Replace(BookmarkStart.b("渱嬳", 12), string.Empty).Replace(BookmarkStart.b("渱笳", 12), string.Empty);
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Contains(BookmarkStart.b("渱倳", num4)))
                {
                    int index = str.IndexOf(BookmarkStart.b("渱倳", num4));
                    if ((index + 2) < str.Length)
                    {
                        this.string_0 = str.Substring(index + 2).Trim(new char[] { ' ' }).Replace(BookmarkStart.b("ေ", num4), string.Empty);
                    }
                    str = str.Substring(0, index);
                }
                string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray.Length > 2)
                {
                    this.string_3 = strArray[1];
                    int num2 = 2;
                    int length = strArray.Length;
                    while (num2 < length)
                    {
                        this.string_1 = this.string_1 + strArray[num2];
                        if (num2 < (length - 1))
                        {
                            this.string_1 = this.string_1 + BookmarkStart.b("ሱ", num4);
                        }
                        num2++;
                    }
                }
            }
        }

        public string BookmarkName
        {
            get
            {
                return this.string_3;
            }
        }

        public bool Cancel
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        public string DefaultResponse
        {
            get
            {
                return this.string_0;
            }
        }

        public Spire.Doc.Fields.Field Field
        {
            get
            {
                return this.field_0;
            }
        }

        public string PromptText
        {
            get
            {
                return this.string_1;
            }
        }

        public string ResponseText
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        internal string ResponseTextEx
        {
            get
            {
                if (string.IsNullOrEmpty(this.string_2))
                {
                    return this.string_0;
                }
                return this.string_2;
            }
        }
    }
}

