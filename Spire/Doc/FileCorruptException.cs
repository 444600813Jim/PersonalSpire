namespace Spire.Doc
{
    using System;
    using System.Runtime.Serialization;

    public class FileCorruptException : Exception
    {
        private byte byte_0;
        private int int_0;
        private string string_0;
        private const string string_1 = "Document is corrupted and impossible to load";

        public FileCorruptException() : base(BookmarkStart.b("紸吺帼䨾ⱀ♂⭄㍆楈≊㹌潎㉐㱒❔╖ⱘ⭚⥜㩞ՠ䍢Ѥ०൨䭪ѬɮŰᱲٴѶၸ᥺ᅼ᩾ꆀꞆ", 0x13))
        {
        }

        public FileCorruptException(Exception innerExc) : this(BookmarkStart.b("温䌫䴭䔯弱儳堵䰷ᨹ唻䴽怿⅁⭃㑅㩇㽉㱋㩍㕏㙑瑓㝕㙗㹙籛㝝ൟቡୣᕥ᭧ͩ๫ɭᕯ剱s᥵塷ᙹ፻ώ", 4), innerExc)
        {
        }

        public FileCorruptException(string message) : base(message)
        {
        }

        public FileCorruptException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public FileCorruptException(string message, Exception innerExc) : base(message, innerExc)
        {
        }
    }
}

