using System;
using System.IO;

internal class Class144
{
    internal static bool bool_0;

    internal static void smethod_0(BinaryReader A_0, int A_1, int A_2, Interface16 A_3, string A_4)
    {
        if (A_1 != 0)
        {
            int num = (A_1 - 4) / (4 + A_2);
            smethod_1(A_0, num, A_3);
        }
    }

    internal static void smethod_1(BinaryReader A_0, int A_1, Interface16 A_2)
    {
        int num = A_1 + 1;
        int[] numArray = new int[num];
        for (int i = 0; i < num; i++)
        {
            numArray[i] = A_0.ReadInt32();
        }
        for (int j = 0; j < A_1; j++)
        {
            A_2.imethod_0(A_0, numArray[j], numArray[j + 1]);
        }
    }
}

