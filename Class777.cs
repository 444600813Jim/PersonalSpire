using System;
using System.Collections.Generic;
using System.IO;

internal class Class777
{
    private static SortedDictionary<int, ImageType> sortedDictionary_0 = smethod_0();
    internal static readonly string string_0 = ImageType.None.ToString();

    private static SortedDictionary<int, ImageType> smethod_0()
    {
        SortedDictionary<int, ImageType> dictionary = new SortedDictionary<int, ImageType>();
        dictionary.Add(0x4d42, ImageType.BMP);
        dictionary.Add(0xd8ff, ImageType.JPG);
        dictionary.Add(0x4947, ImageType.GIF);
        dictionary.Add(0x50a, ImageType.PCX);
        dictionary.Add(0x5089, ImageType.PNG);
        dictionary.Add(0x4238, ImageType.PSD);
        dictionary.Add(0xa659, ImageType.RAS);
        dictionary.Add(0xda01, ImageType.SGI);
        dictionary.Add(0x4949, ImageType.TIFF);
        return dictionary;
    }

    internal static string smethod_1(string A_0)
    {
        return smethod_2(A_0).ToString();
    }

    internal static ImageType smethod_2(string A_0)
    {
        byte[] buffer = new byte[2];
        try
        {
            using (StreamReader reader = new StreamReader(A_0))
            {
                if (reader.BaseStream.Read(buffer, 0, buffer.Length) != buffer.Length)
                {
                    return ImageType.None;
                }
            }
        }
        catch (Exception)
        {
            return ImageType.None;
        }
        return smethod_3(buffer);
    }

    internal static ImageType smethod_3(byte[] A_0)
    {
        if ((A_0 != null) && (A_0.Length >= 2))
        {
            int key = (A_0[1] << 8) + A_0[0];
            ImageType none = ImageType.None;
            if (sortedDictionary_0.TryGetValue(key, out none))
            {
                return none;
            }
        }
        return ImageType.None;
    }

    internal enum ImageType
    {
        BMP = 0x4d42,
        GIF = 0x4947,
        JPG = 0xd8ff,
        None = 0,
        PCX = 0x50a,
        PNG = 0x5089,
        PSD = 0x4238,
        RAS = 0xa659,
        SGI = 0xda01,
        TIFF = 0x4949
    }
}

