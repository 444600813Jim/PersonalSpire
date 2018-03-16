namespace Spire.CompoundFile.Doc.Native
{
    using System;

    [CLSCompliant(false)]
    internal enum PID : uint
    {
        PID_BEHAVIOR = 0x80000003,
        PID_CODEPAGE = 1,
        PID_DICTIONARY = 0,
        PID_FIRST_NAME_DEFAULT = 0xfff,
        PID_FIRST_USABLE = 2,
        PID_ILLEGAL = 0xffffffff,
        PID_LOCALE = 0x80000000,
        PID_MAX_READONLY = 0xbfffffff,
        PID_MIN_READONLY = 0x80000000,
        PID_MODIFY_TIME = 0x80000001,
        PID_SECURITY = 0x80000002
    }
}

