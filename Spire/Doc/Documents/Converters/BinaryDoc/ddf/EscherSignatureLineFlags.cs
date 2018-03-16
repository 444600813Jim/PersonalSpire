namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherSignatureLineFlags
    {
        IsSignatureLine = 1,
        SigSetupAllowComments = 4,
        SigSetupShowSignDate = 8,
        SigSetupSignInstSet = 2,
        UseIsSignatureLine = 0x10000,
        UseSigSetupAllowComments = 0x40000,
        UseSigSetupShowSignDate = 0x80000,
        UseSigSetupSignInstSet = 0x20000
    }
}

