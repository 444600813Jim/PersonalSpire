using Microsoft.Win32;
using Spire.Doc;
using Spire.Doc.Documents.Converters;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;

internal class Class1040
{
    private static readonly CultureInfo cultureInfo_0 = Thread.CurrentThread.CurrentCulture;
    private static readonly CultureInfo cultureInfo_1 = new CultureInfo(BookmarkStart.b("䨮弰Ḳ嬴䴶", 9));

    private Class1040()
    {
    }

    public static Stream smethod_0(string A_0)
    {
        int num = 7;
        Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream(A_0);
        if (manifestResourceStream == null)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("測丮弰崲娴䌶ᤸ崺吼儾╀捂㝄≆㩈⑊㡌㵎㉐㙒畔灖≘歚⁜硞你", num), A_0));
        }
        return manifestResourceStream;
    }

    public static Stream smethod_1(string A_0)
    {
        if (!Class736.smethod_5(A_0))
        {
            return File.OpenRead(A_0);
        }
        WebResponse response = WebRequest.Create(A_0).GetResponse();
        MemoryStream stream = new MemoryStream();
        using (Stream stream2 = response.GetResponseStream())
        {
            Class567.smethod_8(stream2, stream);
        }
        stream.Position = 0L;
        return stream;
    }

    public static void smethod_10(string A_0)
    {
        CultureInfo info = new CultureInfo(A_0);
        Thread.CurrentThread.CurrentCulture = info;
        Thread.CurrentThread.CurrentUICulture = info;
    }

    public static void smethod_11(string A_0, CultureInfoType A_1)
    {
        CultureInfo info = new CultureInfo(A_0);
        switch (A_1)
        {
            case CultureInfoType.CurrentCulture:
                Thread.CurrentThread.CurrentCulture = info;
                return;

            case CultureInfoType.CurrentUICulture:
                Thread.CurrentThread.CurrentUICulture = info;
                return;
        }
    }

    public static string smethod_12()
    {
        return Thread.CurrentThread.CurrentUICulture.Name;
    }

    public static string smethod_13()
    {
        return Thread.CurrentThread.CurrentCulture.Name;
    }

    public static void smethod_14()
    {
        Thread.CurrentThread.CurrentCulture = cultureInfo_1;
        Thread.CurrentThread.CurrentUICulture = cultureInfo_1;
    }

    public static void smethod_15()
    {
        Thread.CurrentThread.CurrentCulture = cultureInfo_0;
        Thread.CurrentThread.CurrentUICulture = cultureInfo_0;
    }

    public static Platform smethod_2()
    {
        switch (Environment.OSVersion.Platform)
        {
            case PlatformID.Win32NT:
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.WinCE:
                return Platform.Windows;
        }
        int platform = (int) Environment.OSVersion.Platform;
        if (((platform != 4) && (platform != 6)) && (platform != 0x80))
        {
            return Platform.MacOS;
        }
        return Platform.Unix;
    }

    public static bool smethod_3()
    {
        return (smethod_2() == Platform.Unix);
    }

    public static bool smethod_4()
    {
        OperatingSystem oSVersion = Environment.OSVersion;
        Version version = oSVersion.Version;
        if (oSVersion.Platform == PlatformID.Win32NT)
        {
            if (version.Major == 6)
            {
                return (version.Minor > 0);
            }
            if (version.Major > 6)
            {
                return true;
            }
        }
        return false;
    }

    public static void smethod_5(IDictionary A_0)
    {
        int num = 6;
        try
        {
            string str = smethod_6();
            if (Class567.smethod_16(str))
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(BookmarkStart.b("缫愭瘯昱挳眵樷缹总猽⤿⅁㙃⥅㭇╉⩋㩍౏Ց㵓㡕㱗㕙⭛ⵝ䁟ⱡっ㩥⭧Ὡṫᱭᕯᱱs⁵ᵷࡹཻ᝽\ud883\uc085ﶍ", num), false))
                {
                    if (key != null)
                    {
                        foreach (string str2 in key.GetValueNames())
                        {
                            try
                            {
                                string path = (string) key.GetValue(str2);
                                if (!Path.IsPathRooted(path))
                                {
                                    path = Path.Combine(str, path);
                                }
                                A_0[path] = path;
                            }
                            catch (ArgumentException)
                            {
                            }
                        }
                    }
                }
            }
        }
        catch (Exception)
        {
        }
    }

    public static string smethod_6()
    {
        int num = 0x12;
        try
        {
            return Path.Combine(Environment.GetEnvironmentVariable(BookmarkStart.b("漷猹爻稽ि၁", num)), BookmarkStart.b("縷唹刻䨽㌿", num));
        }
        catch (SecurityException)
        {
            return string.Empty;
        }
    }

    public static string[] smethod_7()
    {
        return new string[] { smethod_8(), BookmarkStart.b(".䐰䀲䜴ᠶ䨸区尼䴾⑀求⍄⡆❈㽊㹌", 9), BookmarkStart.b(".䐰䀲䜴ᠶ唸吺帼帾ⵀ求㙄⽆⡈㥊⡌恎㝐㱒㭔⍖⩘", 9), BookmarkStart.b(".䐰䀲䜴ᠶ愸਺఼派着求⥄⹆⭈摊ᕌ繎恐籒㍔㡖㝘⽚⹜", 9) };
    }

    private static string smethod_8()
    {
        int num = 0;
        string environmentVariable = Environment.GetEnvironmentVariable(BookmarkStart.b("匥嬧伩師-堯崱夳匵", 0));
        if (!Class567.smethod_16(environmentVariable))
        {
            return "";
        }
        return Path.Combine(environmentVariable, BookmarkStart.b("ࠥ丧䔩䈫娭䌯", num));
    }

    public static int smethod_9()
    {
        return Environment.TickCount;
    }
}

