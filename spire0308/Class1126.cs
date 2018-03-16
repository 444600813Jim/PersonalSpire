using Spire.License;
using System;
using System.ComponentModel;

internal class Class1126
{
    internal static string string_0 = string.Empty;
    internal static string string_1 = string.Empty;

    internal static LicenseType smethod_0(License A_0)
    {
        if (((A_0 == null) || (A_0.GetType() != typeof(LicenseInfo))) || ((LicenseInfo) A_0).IsUpdateRightExpired)
        {
            return LicenseType.Demo;
        }
        if (((LicenseInfo) A_0).Type != LicenseType.Runtime)
        {
            return LicenseType.Demo;
        }
        return LicenseType.Runtime;
    }
}

