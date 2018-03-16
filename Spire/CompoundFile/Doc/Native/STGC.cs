namespace Spire.CompoundFile.Doc.Native
{
    using System;

    [Flags]
    internal enum STGC
    {
        STGC_CONSOLIDATE = 8,
        STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
        STGC_DEFAULT = 0,
        STGC_ONLYIFCURRENT = 2,
        STGC_OVERWRITE = 1
    }
}

