namespace Spire.Doc.Fields.Shape
{
    using System;

    [Flags]
    internal enum OdtPersist1
    {
        DefHandler = 2,
        Icon = 0x40,
        Link = 0x10,
        Manual = 0x100,
        None = 0,
        Ocx = 0x1000,
        Ole1 = 0x80,
        RecomposeOnResize = 0x200,
        Reserved1 = 1,
        Reserved2 = 4,
        Reserved3 = 8,
        Reserved4 = 0x20,
        Reserved5 = 0x400,
        Reserved6 = 0x800,
        Reserved7 = 0x4000,
        Stream = 0x2000,
        SupportIViewObject = 0x8000
    }
}

