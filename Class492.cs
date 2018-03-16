using Spire.Doc;
using System;
using System.IO;

internal class Class492
{
    private const int int_0 = 0x20;

    private Class492()
    {
    }

    internal static string smethod_0(Class827 A_0, Stream A_1)
    {
        int num = 0x12;
        byte[] sourceArray = A_0.method_0();
        if (sourceArray == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("帷唹刻䨽п⍁ぃ❅", num));
        }
        byte[] destinationArray = new byte[Math.Min(sourceArray.Length, 0x20)];
        Array.Copy(sourceArray, destinationArray, destinationArray.Length);
        Guid guid = Class493.smethod_0(new object[] { sourceArray });
        smethod_2(destinationArray, guid);
        A_1.Write(destinationArray, 0, destinationArray.Length);
        A_1.Write(sourceArray, destinationArray.Length, A_0.method_0().Length - destinationArray.Length);
        return guid.ToString(BookmarkStart.b("稷", num)).ToUpper();
    }

    internal static void smethod_1(byte[] A_0, string A_1)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("倵圷吹䠻稽ℿ㙁╃", num));
        }
        Guid guid = new Guid(A_1);
        smethod_2(A_0, guid);
    }

    private static void smethod_2(byte[] A_0, Guid A_1)
    {
        int num = 0;
        byte[] buffer = smethod_3(A_1);
        for (int i = 0; i < 2; i++)
        {
            for (int j = buffer.Length - 1; j >= 0; j--)
            {
                if (num >= A_0.Length)
                {
                    break;
                }
                A_0[num++] = (byte) (A_0[num++] ^ buffer[j]);
            }
        }
    }

    private static byte[] smethod_3(Guid A_0)
    {
        byte[] array = A_0.ToByteArray();
        Array.Reverse(array, 0, 4);
        Array.Reverse(array, 4, 2);
        Array.Reverse(array, 6, 2);
        return array;
    }
}

