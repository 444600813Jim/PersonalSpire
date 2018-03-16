using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

internal class Class346
{
    private const int int_0 = 0x10;

    private Class346()
    {
    }

    internal static DigitalSignature smethod_0(BinaryReader A_0, byte[] A_1)
    {
        bool flag;
        int num = 12;
        DigitalSignature signature = new DigitalSignature(DigitalSignatureType.CryptoApi);
        try
        {
            int num2 = A_0.ReadInt32();
            int num3 = A_0.ReadInt32();
            smethod_1(A_0);
            uint num4 = A_0.ReadUInt32();
            uint num5 = A_0.ReadUInt32();
            long fileTime = num4;
            fileTime = fileTime << 0x20;
            fileTime |= num5;
            signature.method_0(DateTime.FromFileTimeUtc(fileTime));
            A_0.ReadInt32();
            int count = A_0.ReadInt32();
            int num8 = A_0.ReadInt32();
            A_0.ReadInt32();
            int num9 = A_0.ReadInt32();
            int num10 = A_0.ReadInt32();
            A_0.ReadInt32();
            Class813.smethod_5(A_0, (num2 + 1) * 2);
            Class813.smethod_5(A_0, (num3 + 1) * 2);
            byte[] array = A_0.ReadBytes(count);
            byte[] rawData = A_0.ReadBytes(num8);
            A_0.ReadBytes(num9);
            A_0.ReadBytes(num10);
            if (num8 == 0)
            {
                throw new InvalidOperationException(BookmarkStart.b("瘱崳儵儷丹崻刽怿ㅁⵃⅅ♇⭉㡋㭍≏㝑穓", num));
            }
            X509Certificate2 certificate = new X509Certificate2(rawData);
            signature.method_3(certificate);
            RSAParameters parameters = ((RSACryptoServiceProvider) certificate.PublicKey.Key).ExportParameters(false);
            Array.Reverse(array);
            byte[] buffer3 = Class1078.smethod_0(array);
            Rsa rsa = new Rsa(parameters.Modulus, parameters.Exponent);
            byte[] sourceArray = Class1078.smethod_1(Class1078.smethod_2(rsa, buffer3), rsa.Modulus.method_0() >> 3);
            byte[] destinationArray = new byte[0x10];
            Array.Copy(sourceArray, sourceArray.Length - 0x10, destinationArray, 0, 0x10);
            MD5 md = new MD5();
            md.Update(A_1, A_1.Length);
            md.Update(BitConverter.GetBytes(num5), 4);
            md.Update(BitConverter.GetBytes(num4), 4);
            md.FinalUpdate();
            flag = Class85.smethod_1(destinationArray, md.Digest);
        }
        catch (Exception)
        {
            flag = false;
        }
        signature.method_2(flag);
        return signature;
    }

    private static DateTime smethod_1(BinaryReader A_0)
    {
        long fileTime = A_0.ReadUInt32();
        fileTime = fileTime << 0x20;
        fileTime |= A_0.ReadUInt32();
        return DateTime.FromFileTimeUtc(fileTime);
    }
}

