namespace Spire.Doc
{
    using System;

    public class PasswordErrorException : Exception
    {
        public PasswordErrorException(string message) : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}

