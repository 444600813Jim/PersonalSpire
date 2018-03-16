namespace Spire.Compression.Zip
{
    using System;

    internal enum CompressionMethod
    {
        BZIP2 = 12,
        Defalte64 = 9,
        Deflated = 8,
        IBMTerse = 0x12,
        Imploded = 6,
        LZ77 = 0x13,
        LZMA = 14,
        PPMd = 0x62,
        PRWARE = 10,
        ReducedFactor1 = 2,
        ReducedFactor2 = 3,
        ReducedFactor3 = 4,
        ReducedFactor4 = 5,
        Shrunk = 1,
        Stored = 0,
        Tokenizing = 7
    }
}

