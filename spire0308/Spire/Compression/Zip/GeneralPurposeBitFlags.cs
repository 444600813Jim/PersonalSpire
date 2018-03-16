namespace Spire.Compression.Zip
{
    using System;

    [Flags]
    internal enum GeneralPurposeBitFlags : short
    {
        SizeAfterData = 8,
        Unicode = 0x800
    }
}

