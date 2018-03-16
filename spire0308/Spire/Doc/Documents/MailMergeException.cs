namespace Spire.Doc.Documents
{
    using System;

    public class MailMergeException : Exception
    {
        private bool bool_0;
        private float float_0;
        private int int_0;
        private string string_0;
        private const string string_1 = "Incorrect syntax of mail merge fields";

        public MailMergeException() : base(BookmarkStart.b("礯就圳夵䨷䠹夻崽㐿扁㝃㽅♇㹉ⵋ㙍灏㵑㉓癕㕗㭙㕛㉝䁟ཡţᑥཧཀྵ䱫࡭᥯᝱ᡳት୷", 10))
        {
        }

        public MailMergeException(Exception innerExc) : this(BookmarkStart.b("縶圸堺刼䴾㍀♂♄㍆楈㡊㑌ⅎ═㉒ⵔ睖㙘㵚絜㉞`੢।䝦Ѩ๪Ὤ࡮ᑰ卲፴Ṷᱸ᝺᥼౾", 0x11), innerExc)
        {
        }

        public MailMergeException(string message) : base(message)
        {
        }

        public MailMergeException(string message, Exception innerExc) : base(message, innerExc)
        {
        }
    }
}

