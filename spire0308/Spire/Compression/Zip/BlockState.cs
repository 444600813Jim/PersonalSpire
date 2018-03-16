namespace Spire.Compression.Zip
{
    using System;

    internal enum BlockState
    {
        NeedMore,
        BlockDone,
        FinishStarted,
        FinishDone
    }
}

