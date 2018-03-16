using System;
using System.Runtime.InteropServices;

internal class Class946
{
    public const int int_0 = 0x8004;
    public const int int_1 = 0x6801;
    public const int int_2 = 1;
    public const int int_3 = 2;
    public const int int_4 = 4;
    public const string string_0 = "Microsoft Enhanced Cryptographic Provider v1.0";

    [DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    public static extern bool CryptAcquireContext(out IntPtr A_0, string A_1, string A_2, uint A_3, uint A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptCreateHash(IntPtr A_0, int A_1, IntPtr A_2, int A_3, ref IntPtr A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptDecrypt(IntPtr A_0, IntPtr A_1, int A_2, uint A_3, byte[] A_4, ref int A_5);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptDeriveKey(IntPtr A_0, int A_1, IntPtr A_2, int A_3, ref IntPtr A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptDestroyHash(IntPtr A_0);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptDestroyKey(IntPtr A_0);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptGetHashParam(IntPtr A_0, int A_1, out int A_2, out int A_3, int A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptGetHashParam(IntPtr A_0, int A_1, byte[] A_2, ref int A_3, int A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptGetHashParam(IntPtr A_0, int A_1, out IntPtr A_2, out int A_3, int A_4);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptHashData(IntPtr A_0, byte[] A_1, int A_2, int A_3);
    [DllImport("advapi32.dll", SetLastError=true)]
    public static extern bool CryptReleaseContext(IntPtr A_0, int A_1);

    public enum HashParameters
    {
        HP_ALGID = 1,
        HP_HASHSIZE = 4,
        HP_HASHVAL = 2
    }
}

