namespace Spire.Doc.Documents
{
    using System;

    public class DLSException : Exception
    {
        private byte byte_0;
        private int int_0;
        private const string string_0 = "Exception in DLS library";

        public DLSException() : base(BookmarkStart.b("瘲䴴吶尸䬺䤼嘾⹀ⵂ敄⹆❈歊ौ͎ɐ獒㥔㹖㭘⥚㱜ⵞᡠ", 13))
        {
        }

        public DLSException(Exception innerExc) : this(BookmarkStart.b("眱䰳唵崷䨹䠻圽⼿ⱁ摃⽅♇橉ࡋɍ͏牑㡓㽕㩗⡙㵛ⱝᥟ", 12), innerExc)
        {
        }

        public DLSException(string message) : base(message)
        {
        }

        public DLSException(string message, Exception innerExc) : base(message, innerExc)
        {
        }
    }
}

