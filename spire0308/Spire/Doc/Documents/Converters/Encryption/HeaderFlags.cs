namespace Spire.Doc.Documents.Converters.Encryption
{
    using System;

    [Flags]
    internal enum HeaderFlags
    {
        Aes = 0x20,
        CryptoApi = 4,
        DocProps = 8,
        External = 0x10
    }
}

