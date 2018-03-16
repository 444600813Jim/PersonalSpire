namespace Spire.Doc.Documents.Converters.BinaryDoc.ddf
{
    using System;

    [Flags]
    internal enum EscherGroupShapeFlags : uint
    {
        AllowOverlap = 0x200,
        BehindDocument = 0x20,
        EditedWrap = 0x40,
        Hidden = 2,
        HorizRule = 0x800,
        IsBullet = 0x4000,
        IsButton = 8,
        LayoutInCell = 0x8000,
        NoshadeHR = 0x1000,
        OnDblClickNotify = 0x10,
        OneD = 4,
        Print = 1,
        ReallyHidden = 0x100,
        ScriptAnchor = 0x80,
        StandardHR = 0x2000,
        UseAllowOverlap = 0x2000000,
        UseBehindDocument = 0x200000,
        UseEditedWrap = 0x400000,
        UseHidden = 0x20000,
        UseHorizRule = 0x8000000,
        UseIsBullet = 0x40000000,
        UseIsButton = 0x80000,
        UseLayoutInCell = 0x80000000,
        UseNoshadeHR = 0x10000000,
        UseOnDblClickNotify = 0x100000,
        UseOneD = 0x40000,
        UsePrint = 0x10000,
        UserDrawn = 0x400,
        UseReallyHidden = 0x1000000,
        UseScriptAnchor = 0x800000,
        UseStandardHR = 0x20000000,
        UseUserDrawn = 0x4000000
    }
}

