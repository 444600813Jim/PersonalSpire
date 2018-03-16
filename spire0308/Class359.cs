using Spire.CompoundFile.Doc.Native;
using System;
using System.Runtime.InteropServices;

[CLSCompliant(false)]
internal sealed class Class359
{
    private Class359()
    {
    }

    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int CreateILockBytesOnHGlobal(IntPtr A_0, bool A_1, out Interface65 A_2);
    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern IntPtr GlobalAlloc(GlobalAllocFlags A_0, int A_1);
    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern IntPtr GlobalFree(IntPtr A_0);
    [DllImport("kernel32.dll", SetLastError=true)]
    public static extern IntPtr GlobalReAlloc(IntPtr A_0, int A_1, GlobalAllocFlags A_2);
    public static int smethod_0(Interface40 A_0, uint A_1, out Interface44 A_2)
    {
        if (IntPtr.Size == 8)
        {
            return StgCreatePropSetStg(A_0, A_1, out A_2);
        }
        return StgCreatePropSetStg_1(A_0, A_1, out A_2);
    }

    public static int smethod_1(Interface40 A_0, uint A_1, out Interface44 A_2)
    {
        if (IntPtr.Size == 8)
        {
            return StgCreatePropSetStg(A_0, A_1, out A_2);
        }
        return StgCreatePropSetStg_1(A_0, A_1, out A_2);
    }

    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int StgCreateDocfile([MarshalAs(UnmanagedType.LPWStr)] string A_0, STGM A_1, uint A_2, out Interface40 A_3);
    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int StgCreateDocfileOnILockBytes(Interface65 A_0, STGM A_1, int A_2, out Interface40 A_3);
    [DllImport("ole32.dll", SetLastError=true)]
    private static extern int StgCreatePropSetStg(Interface40 A_0, uint A_1, out Interface44 A_2);
    [DllImport("iprop.dll", EntryPoint="StgCreatePropSetStg", SetLastError=true)]
    private static extern int StgCreatePropSetStg_1(Interface40 A_0, uint A_1, out Interface44 A_2);
    [DllImport("ole32.dll")]
    internal static extern int StgCreateStorageEx([MarshalAs(UnmanagedType.LPWStr)] string A_0, STGM A_1, STGFMT A_2, int A_3, IntPtr A_4, IntPtr A_5, [In] ref Guid A_6, out Interface40 A_7);
    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int StgOpenStorage([MarshalAs(UnmanagedType.LPWStr)] string A_0, IntPtr A_1, STGM A_2, IntPtr A_3, uint A_4, out Interface40 A_5);
    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int StgOpenStorageEx([MarshalAs(UnmanagedType.LPWStr)] string A_0, STGM A_1, STGFMT A_2, uint A_3, IntPtr A_4, IntPtr A_5, ref Guid A_6, out Interface40 A_7);
    [DllImport("ole32.dll", SetLastError=true)]
    public static extern int StgOpenStorageOnILockBytes(Interface65 A_0, Interface40 A_1, STGM A_2, int A_3, int A_4, out Interface40 A_5);

    [Flags]
    internal enum GlobalAllocFlags
    {
        GMEM_FIXED = 0,
        GMEM_MOVEABLE = 2,
        GMEM_NODISCARD = 0x20,
        GMEM_ZEROINIT = 0x40
    }
}

