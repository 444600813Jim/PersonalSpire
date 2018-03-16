using Spire.Doc;
using System;

internal sealed class Class1001
{
    private const int int_0 = 0x5a0;
    private const int int_1 = 0;
    internal const int int_10 = 9;
    internal const int int_11 = 5;
    internal const int int_12 = 15;
    internal static readonly int[] int_13 = new int[] { 
        0x60, 7, 0x100, 0, 8, 80, 0, 8, 0x10, 0x54, 8, 0x73, 0x52, 7, 0x1f, 0, 
        8, 0x70, 0, 8, 0x30, 0, 9, 0xc0, 80, 7, 10, 0, 8, 0x60, 0, 8, 
        0x20, 0, 9, 160, 0, 8, 0, 0, 8, 0x80, 0, 8, 0x40, 0, 9, 0xe0, 
        80, 7, 6, 0, 8, 0x58, 0, 8, 0x18, 0, 9, 0x90, 0x53, 7, 0x3b, 0, 
        8, 120, 0, 8, 0x38, 0, 9, 0xd0, 0x51, 7, 0x11, 0, 8, 0x68, 0, 8, 
        40, 0, 9, 0xb0, 0, 8, 8, 0, 8, 0x88, 0, 8, 0x48, 0, 9, 240, 
        80, 7, 4, 0, 8, 0x54, 0, 8, 20, 0x55, 8, 0xe3, 0x53, 7, 0x2b, 0, 
        8, 0x74, 0, 8, 0x34, 0, 9, 200, 0x51, 7, 13, 0, 8, 100, 0, 8, 
        0x24, 0, 9, 0xa8, 0, 8, 4, 0, 8, 0x84, 0, 8, 0x44, 0, 9, 0xe8, 
        80, 7, 8, 0, 8, 0x5c, 0, 8, 0x1c, 0, 9, 0x98, 0x54, 7, 0x53, 0, 
        8, 0x7c, 0, 8, 60, 0, 9, 0xd8, 0x52, 7, 0x17, 0, 8, 0x6c, 0, 8, 
        0x2c, 0, 9, 0xb8, 0, 8, 12, 0, 8, 140, 0, 8, 0x4c, 0, 9, 0xf8, 
        80, 7, 3, 0, 8, 0x52, 0, 8, 0x12, 0x55, 8, 0xa3, 0x53, 7, 0x23, 0, 
        8, 0x72, 0, 8, 50, 0, 9, 0xc4, 0x51, 7, 11, 0, 8, 0x62, 0, 8, 
        0x22, 0, 9, 0xa4, 0, 8, 2, 0, 8, 130, 0, 8, 0x42, 0, 9, 0xe4, 
        80, 7, 7, 0, 8, 90, 0, 8, 0x1a, 0, 9, 0x94, 0x54, 7, 0x43, 0, 
        8, 0x7a, 0, 8, 0x3a, 0, 9, 0xd4, 0x52, 7, 0x13, 0, 8, 0x6a, 0, 8, 
        0x2a, 0, 9, 180, 0, 8, 10, 0, 8, 0x8a, 0, 8, 0x4a, 0, 9, 0xf4, 
        80, 7, 5, 0, 8, 0x56, 0, 8, 0x16, 0xc0, 8, 0, 0x53, 7, 0x33, 0, 
        8, 0x76, 0, 8, 0x36, 0, 9, 0xcc, 0x51, 7, 15, 0, 8, 0x66, 0, 8, 
        0x26, 0, 9, 0xac, 0, 8, 6, 0, 8, 0x86, 0, 8, 70, 0, 9, 0xec, 
        80, 7, 9, 0, 8, 0x5e, 0, 8, 30, 0, 9, 0x9c, 0x54, 7, 0x63, 0, 
        8, 0x7e, 0, 8, 0x3e, 0, 9, 220, 0x52, 7, 0x1b, 0, 8, 110, 0, 8, 
        0x2e, 0, 9, 0xbc, 0, 8, 14, 0, 8, 0x8e, 0, 8, 0x4e, 0, 9, 0xfc, 
        0x60, 7, 0x100, 0, 8, 0x51, 0, 8, 0x11, 0x55, 8, 0x83, 0x52, 7, 0x1f, 0, 
        8, 0x71, 0, 8, 0x31, 0, 9, 0xc2, 80, 7, 10, 0, 8, 0x61, 0, 8, 
        0x21, 0, 9, 0xa2, 0, 8, 1, 0, 8, 0x81, 0, 8, 0x41, 0, 9, 0xe2, 
        80, 7, 6, 0, 8, 0x59, 0, 8, 0x19, 0, 9, 0x92, 0x53, 7, 0x3b, 0, 
        8, 0x79, 0, 8, 0x39, 0, 9, 210, 0x51, 7, 0x11, 0, 8, 0x69, 0, 8, 
        0x29, 0, 9, 0xb2, 0, 8, 9, 0, 8, 0x89, 0, 8, 0x49, 0, 9, 0xf2, 
        80, 7, 4, 0, 8, 0x55, 0, 8, 0x15, 80, 8, 0x102, 0x53, 7, 0x2b, 0, 
        8, 0x75, 0, 8, 0x35, 0, 9, 0xca, 0x51, 7, 13, 0, 8, 0x65, 0, 8, 
        0x25, 0, 9, 170, 0, 8, 5, 0, 8, 0x85, 0, 8, 0x45, 0, 9, 0xea, 
        80, 7, 8, 0, 8, 0x5d, 0, 8, 0x1d, 0, 9, 0x9a, 0x54, 7, 0x53, 0, 
        8, 0x7d, 0, 8, 0x3d, 0, 9, 0xda, 0x52, 7, 0x17, 0, 8, 0x6d, 0, 8, 
        0x2d, 0, 9, 0xba, 0, 8, 13, 0, 8, 0x8d, 0, 8, 0x4d, 0, 9, 250, 
        80, 7, 3, 0, 8, 0x53, 0, 8, 0x13, 0x55, 8, 0xc3, 0x53, 7, 0x23, 0, 
        8, 0x73, 0, 8, 0x33, 0, 9, 0xc6, 0x51, 7, 11, 0, 8, 0x63, 0, 8, 
        0x23, 0, 9, 0xa6, 0, 8, 3, 0, 8, 0x83, 0, 8, 0x43, 0, 9, 230, 
        80, 7, 7, 0, 8, 0x5b, 0, 8, 0x1b, 0, 9, 150, 0x54, 7, 0x43, 0, 
        8, 0x7b, 0, 8, 0x3b, 0, 9, 0xd6, 0x52, 7, 0x13, 0, 8, 0x6b, 0, 8, 
        0x2b, 0, 9, 0xb6, 0, 8, 11, 0, 8, 0x8b, 0, 8, 0x4b, 0, 9, 0xf6, 
        80, 7, 5, 0, 8, 0x57, 0, 8, 0x17, 0xc0, 8, 0, 0x53, 7, 0x33, 0, 
        8, 0x77, 0, 8, 0x37, 0, 9, 0xce, 0x51, 7, 15, 0, 8, 0x67, 0, 8, 
        0x27, 0, 9, 0xae, 0, 8, 7, 0, 8, 0x87, 0, 8, 0x47, 0, 9, 0xee, 
        80, 7, 9, 0, 8, 0x5f, 0, 8, 0x1f, 0, 9, 0x9e, 0x54, 7, 0x63, 0, 
        8, 0x7f, 0, 8, 0x3f, 0, 9, 0xde, 0x52, 7, 0x1b, 0, 8, 0x6f, 0, 8, 
        0x2f, 0, 9, 190, 0, 8, 15, 0, 8, 0x8f, 0, 8, 0x4f, 0, 9, 0xfe, 
        0x60, 7, 0x100, 0, 8, 80, 0, 8, 0x10, 0x54, 8, 0x73, 0x52, 7, 0x1f, 0, 
        8, 0x70, 0, 8, 0x30, 0, 9, 0xc1, 80, 7, 10, 0, 8, 0x60, 0, 8, 
        0x20, 0, 9, 0xa1, 0, 8, 0, 0, 8, 0x80, 0, 8, 0x40, 0, 9, 0xe1, 
        80, 7, 6, 0, 8, 0x58, 0, 8, 0x18, 0, 9, 0x91, 0x53, 7, 0x3b, 0, 
        8, 120, 0, 8, 0x38, 0, 9, 0xd1, 0x51, 7, 0x11, 0, 8, 0x68, 0, 8, 
        40, 0, 9, 0xb1, 0, 8, 8, 0, 8, 0x88, 0, 8, 0x48, 0, 9, 0xf1, 
        80, 7, 4, 0, 8, 0x54, 0, 8, 20, 0x55, 8, 0xe3, 0x53, 7, 0x2b, 0, 
        8, 0x74, 0, 8, 0x34, 0, 9, 0xc9, 0x51, 7, 13, 0, 8, 100, 0, 8, 
        0x24, 0, 9, 0xa9, 0, 8, 4, 0, 8, 0x84, 0, 8, 0x44, 0, 9, 0xe9, 
        80, 7, 8, 0, 8, 0x5c, 0, 8, 0x1c, 0, 9, 0x99, 0x54, 7, 0x53, 0, 
        8, 0x7c, 0, 8, 60, 0, 9, 0xd9, 0x52, 7, 0x17, 0, 8, 0x6c, 0, 8, 
        0x2c, 0, 9, 0xb9, 0, 8, 12, 0, 8, 140, 0, 8, 0x4c, 0, 9, 0xf9, 
        80, 7, 3, 0, 8, 0x52, 0, 8, 0x12, 0x55, 8, 0xa3, 0x53, 7, 0x23, 0, 
        8, 0x72, 0, 8, 50, 0, 9, 0xc5, 0x51, 7, 11, 0, 8, 0x62, 0, 8, 
        0x22, 0, 9, 0xa5, 0, 8, 2, 0, 8, 130, 0, 8, 0x42, 0, 9, 0xe5, 
        80, 7, 7, 0, 8, 90, 0, 8, 0x1a, 0, 9, 0x95, 0x54, 7, 0x43, 0, 
        8, 0x7a, 0, 8, 0x3a, 0, 9, 0xd5, 0x52, 7, 0x13, 0, 8, 0x6a, 0, 8, 
        0x2a, 0, 9, 0xb5, 0, 8, 10, 0, 8, 0x8a, 0, 8, 0x4a, 0, 9, 0xf5, 
        80, 7, 5, 0, 8, 0x56, 0, 8, 0x16, 0xc0, 8, 0, 0x53, 7, 0x33, 0, 
        8, 0x76, 0, 8, 0x36, 0, 9, 0xcd, 0x51, 7, 15, 0, 8, 0x66, 0, 8, 
        0x26, 0, 9, 0xad, 0, 8, 6, 0, 8, 0x86, 0, 8, 70, 0, 9, 0xed, 
        80, 7, 9, 0, 8, 0x5e, 0, 8, 30, 0, 9, 0x9d, 0x54, 7, 0x63, 0, 
        8, 0x7e, 0, 8, 0x3e, 0, 9, 0xdd, 0x52, 7, 0x1b, 0, 8, 110, 0, 8, 
        0x2e, 0, 9, 0xbd, 0, 8, 14, 0, 8, 0x8e, 0, 8, 0x4e, 0, 9, 0xfd, 
        0x60, 7, 0x100, 0, 8, 0x51, 0, 8, 0x11, 0x55, 8, 0x83, 0x52, 7, 0x1f, 0, 
        8, 0x71, 0, 8, 0x31, 0, 9, 0xc3, 80, 7, 10, 0, 8, 0x61, 0, 8, 
        0x21, 0, 9, 0xa3, 0, 8, 1, 0, 8, 0x81, 0, 8, 0x41, 0, 9, 0xe3, 
        80, 7, 6, 0, 8, 0x59, 0, 8, 0x19, 0, 9, 0x93, 0x53, 7, 0x3b, 0, 
        8, 0x79, 0, 8, 0x39, 0, 9, 0xd3, 0x51, 7, 0x11, 0, 8, 0x69, 0, 8, 
        0x29, 0, 9, 0xb3, 0, 8, 9, 0, 8, 0x89, 0, 8, 0x49, 0, 9, 0xf3, 
        80, 7, 4, 0, 8, 0x55, 0, 8, 0x15, 80, 8, 0x102, 0x53, 7, 0x2b, 0, 
        8, 0x75, 0, 8, 0x35, 0, 9, 0xcb, 0x51, 7, 13, 0, 8, 0x65, 0, 8, 
        0x25, 0, 9, 0xab, 0, 8, 5, 0, 8, 0x85, 0, 8, 0x45, 0, 9, 0xeb, 
        80, 7, 8, 0, 8, 0x5d, 0, 8, 0x1d, 0, 9, 0x9b, 0x54, 7, 0x53, 0, 
        8, 0x7d, 0, 8, 0x3d, 0, 9, 0xdb, 0x52, 7, 0x17, 0, 8, 0x6d, 0, 8, 
        0x2d, 0, 9, 0xbb, 0, 8, 13, 0, 8, 0x8d, 0, 8, 0x4d, 0, 9, 0xfb, 
        80, 7, 3, 0, 8, 0x53, 0, 8, 0x13, 0x55, 8, 0xc3, 0x53, 7, 0x23, 0, 
        8, 0x73, 0, 8, 0x33, 0, 9, 0xc7, 0x51, 7, 11, 0, 8, 0x63, 0, 8, 
        0x23, 0, 9, 0xa7, 0, 8, 3, 0, 8, 0x83, 0, 8, 0x43, 0, 9, 0xe7, 
        80, 7, 7, 0, 8, 0x5b, 0, 8, 0x1b, 0, 9, 0x97, 0x54, 7, 0x43, 0, 
        8, 0x7b, 0, 8, 0x3b, 0, 9, 0xd7, 0x52, 7, 0x13, 0, 8, 0x6b, 0, 8, 
        0x2b, 0, 9, 0xb7, 0, 8, 11, 0, 8, 0x8b, 0, 8, 0x4b, 0, 9, 0xf7, 
        80, 7, 5, 0, 8, 0x57, 0, 8, 0x17, 0xc0, 8, 0, 0x53, 7, 0x33, 0, 
        8, 0x77, 0, 8, 0x37, 0, 9, 0xcf, 0x51, 7, 15, 0, 8, 0x67, 0, 8, 
        0x27, 0, 9, 0xaf, 0, 8, 7, 0, 8, 0x87, 0, 8, 0x47, 0, 9, 0xef, 
        80, 7, 9, 0, 8, 0x5f, 0, 8, 0x1f, 0, 9, 0x9f, 0x54, 7, 0x63, 0, 
        8, 0x7f, 0, 8, 0x3f, 0, 9, 0xdf, 0x52, 7, 0x1b, 0, 8, 0x6f, 0, 8, 
        0x2f, 0, 9, 0xbf, 0, 8, 15, 0, 8, 0x8f, 0, 8, 0x4f, 0, 9, 0xff
     };
    internal static readonly int[] int_14 = new int[] { 
        80, 5, 1, 0x57, 5, 0x101, 0x53, 5, 0x11, 0x5b, 5, 0x1001, 0x51, 5, 5, 0x59, 
        5, 0x401, 0x55, 5, 0x41, 0x5d, 5, 0x4001, 80, 5, 3, 0x58, 5, 0x201, 0x54, 5, 
        0x21, 0x5c, 5, 0x2001, 0x52, 5, 9, 90, 5, 0x801, 0x56, 5, 0x81, 0xc0, 5, 0x6001, 
        80, 5, 2, 0x57, 5, 0x181, 0x53, 5, 0x19, 0x5b, 5, 0x1801, 0x51, 5, 7, 0x59, 
        5, 0x601, 0x55, 5, 0x61, 0x5d, 5, 0x6001, 80, 5, 4, 0x58, 5, 0x301, 0x54, 5, 
        0x31, 0x5c, 5, 0x3001, 0x52, 5, 13, 90, 5, 0xc01, 0x56, 5, 0xc1, 0xc0, 5, 0x6001
     };
    internal static readonly int[] int_15 = new int[] { 
        3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15, 0x11, 0x13, 0x17, 0x1b, 0x1f, 
        0x23, 0x2b, 0x33, 0x3b, 0x43, 0x53, 0x63, 0x73, 0x83, 0xa3, 0xc3, 0xe3, 0x102, 0, 0
     };
    internal static readonly int[] int_16 = new int[] { 
        0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 
        3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 0, 0x70, 0x70
     };
    internal static readonly int[] int_17 = new int[] { 
        1, 2, 3, 4, 5, 7, 9, 13, 0x11, 0x19, 0x21, 0x31, 0x41, 0x61, 0x81, 0xc1, 
        0x101, 0x181, 0x201, 0x301, 0x401, 0x601, 0x801, 0xc01, 0x1001, 0x1801, 0x2001, 0x3001, 0x4001, 0x6001
     };
    internal static readonly int[] int_18 = new int[] { 
        0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 
        7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13
     };
    internal int[] int_19;
    private const int int_2 = 1;
    internal int[] int_20;
    internal int[] int_21;
    internal int[] int_22;
    internal int[] int_23;
    internal int[] int_24;
    private const int int_3 = 2;
    private const int int_4 = -1;
    private const int int_5 = -2;
    private const int int_6 = -3;
    private const int int_7 = -4;
    private const int int_8 = -5;
    private const int int_9 = -6;

    private int method_0(int[] A_0, int A_1, int A_2, int A_3, int[] A_4, int[] A_5, int[] A_6, int[] A_7, int[] A_8, int[] A_9, int[] A_10)
    {
        int index = 0;
        int num2 = A_2;
        do
        {
            this.int_19[A_0[A_1 + index]]++;
            index++;
            num2--;
        }
        while (num2 != 0);
        if (this.int_19[0] == A_2)
        {
            A_6[0] = -1;
            A_7[0] = 0;
            return 0;
        }
        int num14 = A_7[0];
        int num6 = 1;
        while (num6 <= 15)
        {
            if (this.int_19[num6] != 0)
            {
                break;
            }
            num6++;
        }
        int num7 = num6;
        if (num14 < num6)
        {
            num14 = num6;
        }
        num2 = 15;
        while (num2 != 0)
        {
            if (this.int_19[num2] != 0)
            {
                break;
            }
            num2--;
        }
        int num8 = num2;
        if (num14 > num2)
        {
            num14 = num2;
        }
        A_7[0] = num14;
        int num5 = ((int) 1) << num6;
        while (num6 < num2)
        {
            num5 -= this.int_19[num6];
            if (num5 < 0)
            {
                return -3;
            }
            num6++;
            num5 = num5 << 1;
        }
        num5 -= this.int_19[num2];
        if (num5 < 0)
        {
            return -3;
        }
        this.int_19[num2] += num5;
        num6 = 0;
        this.int_24[1] = 0;
        index = 1;
        int num4 = 2;
        while (--num2 != 0)
        {
            this.int_24[num4] = num6 += this.int_19[index];
            num4++;
            index++;
        }
        num2 = 0;
        index = 0;
        while (true)
        {
            num6 = A_0[A_1 + index];
            if (num6 != 0)
            {
                A_10[this.int_24[num6]++] = num2;
            }
            index++;
            if (++num2 >= A_2)
            {
                A_2 = this.int_24[num8];
                num2 = 0;
                this.int_24[0] = 0;
                index = 0;
                int num11 = -1;
                int num13 = -num14;
                this.int_22[0] = 0;
                int num9 = 0;
                int num12 = 0;
                while (num7 <= num8)
                {
                    int num3;
                    int num15 = this.int_19[num7];
                    goto Label_03FF;
                Label_01B9:
                    num11++;
                    num13 += num14;
                    num12 = num8 - num13;
                    num12 = (num12 > num14) ? num14 : num12;
                    if ((num3 = ((int) 1) << (num6 = num7 - num13)) > (num15 + 1))
                    {
                        num3 -= num15 + 1;
                        num4 = num7;
                        if (num6 < num12)
                        {
                            while (++num6 < num12)
                            {
                                if ((num3 = num3 << 1) <= this.int_19[++num4])
                                {
                                    break;
                                }
                                num3 -= this.int_19[num4];
                            }
                        }
                    }
                    num12 = ((int) 1) << num6;
                    if ((A_9[0] + num12) > 0x5a0)
                    {
                        return -3;
                    }
                    this.int_22[num11] = num9 = A_9[0];
                    A_9[0] += num12;
                    if (num11 != 0)
                    {
                        this.int_24[num11] = num2;
                        this.int_21[0] = (sbyte) num6;
                        this.int_21[1] = (sbyte) num14;
                        num6 = Class604.smethod_0(num2, num13 - num14);
                        this.int_21[2] = (num9 - this.int_22[num11 - 1]) - num6;
                        Array.Copy(this.int_21, 0, A_8, (this.int_22[num11 - 1] + num6) * 3, 3);
                    }
                    else
                    {
                        A_6[0] = num9;
                    }
                Label_02DC:
                    if (num7 > (num13 + num14))
                    {
                        goto Label_01B9;
                    }
                    this.int_21[1] = (sbyte) (num7 - num13);
                    if (index >= A_2)
                    {
                        this.int_21[0] = 0xc0;
                    }
                    else if (A_10[index] < A_3)
                    {
                        this.int_21[0] = (A_10[index] < 0x100) ? ((sbyte) 0) : ((sbyte) 0x60);
                        this.int_21[2] = A_10[index++];
                    }
                    else
                    {
                        this.int_21[0] = (sbyte) ((A_5[A_10[index] - A_3] + 0x10) + 0x40);
                        this.int_21[2] = A_4[A_10[index++] - A_3];
                    }
                    num3 = ((int) 1) << (num7 - num13);
                    num6 = Class604.smethod_0(num2, num13);
                    while (num6 < num12)
                    {
                        Array.Copy(this.int_21, 0, A_8, (num9 + num6) * 3, 3);
                        num6 += num3;
                    }
                    num6 = ((int) 1) << (num7 - 1);
                    while ((num2 & num6) != 0)
                    {
                        num2 ^= num6;
                        num6 = Class604.smethod_0(num6, 1);
                    }
                    num2 ^= num6;
                    for (int i = (((int) 1) << num13) - 1; (num2 & i) != this.int_24[num11]; i = (((int) 1) << num13) - 1)
                    {
                        num11--;
                        num13 -= num14;
                    }
                Label_03FF:
                    if (num15-- != 0)
                    {
                        goto Label_02DC;
                    }
                    num7++;
                }
                if ((num5 != 0) && (num8 != 1))
                {
                    return -5;
                }
                return 0;
            }
        }
    }

    internal int method_1(int[] A_0, int[] A_1, int[] A_2, int[] A_3, Class1068 A_4)
    {
        int num = 14;
        this.method_3(0x13);
        this.int_20[0] = 0;
        int num2 = this.method_0(A_0, 0, 0x13, 0x13, null, null, A_2, A_1, A_3, this.int_20, this.int_23);
        if (num2 == -3)
        {
            A_4.string_0 = BookmarkStart.b("嬳䀵崷䠹伻䬽∿ㅁ❃㑅ⅇ⡉⥋⩍灏㙑ⵓ㡕㥗㝙㕛㵝䁟aൣብ䡧٩५mᝯٱᱳյ塷๹๻᭽", num);
            return num2;
        }
        if ((num2 != -5) && (A_1[0] != 0))
        {
            return num2;
        }
        A_4.string_0 = BookmarkStart.b("崳堵嬷唹儻丽ⰿ❁ぃ⍅桇⹉㕋⁍ㅏ㽑㵓㕕硗㡙㕛⩝䁟๡ţࡥཧṩѫᵭ偯ٱٳ፵ᵷ", num);
        return -3;
    }

    internal int method_2(int A_0, int A_1, int[] A_2, int[] A_3, int[] A_4, int[] A_5, int[] A_6, int[] A_7, Class1068 A_8)
    {
        int num = 11;
        this.method_3(0x120);
        this.int_20[0] = 0;
        int num2 = this.method_0(A_2, 0, A_0, 0x101, int_15, int_16, A_5, A_3, A_7, this.int_20, this.int_23);
        if ((num2 == 0) && (A_3[0] != 0))
        {
            this.method_3(0x120);
            num2 = this.method_0(A_2, A_0, A_1, 0, int_17, int_18, A_6, A_4, A_7, this.int_20, this.int_23);
            if ((num2 == 0) && ((A_4[0] != 0) || (A_0 <= 0x101)))
            {
                return 0;
            }
            switch (num2)
            {
                case -3:
                    A_8.string_0 = BookmarkStart.b("帰䔲倴䔶䨸为弼䰾≀ㅂⱄ╆ⱈ⽊浌⭎㡐⁒⅔㙖㝘㡚㡜罞ᕠᅢdɦ", num);
                    return num2;

                case -5:
                    A_8.string_0 = BookmarkStart.b("堰崲嘴堶吸䬺儼娾㕀♂敄⍆⁈㡊㥌⹎㽐げご睖ⵘ⥚㡜㩞", num);
                    return -3;
            }
            if (num2 != -4)
            {
                A_8.string_0 = BookmarkStart.b("吰帲䔴䌶䀸ᬺ夼嘾㉀㝂⑄⥆⩈⹊浌㭎⍐㙒ご睖⹘㉚⥜㝞䅠རd०๨Ὢլᱮ", num);
                num2 = -3;
            }
            return num2;
        }
        if (num2 == -3)
        {
            A_8.string_0 = BookmarkStart.b("帰䔲倴䔶䨸为弼䰾≀ㅂⱄ╆ⱈ⽊浌⍎㡐❒ご╖㡘㝚牜㍞Ѡൢɤ፦Ũ䭪ᥬᵮᑰᙲ", num);
            return num2;
        }
        if (num2 != -4)
        {
            A_8.string_0 = BookmarkStart.b("堰崲嘴堶吸䬺儼娾㕀♂敄⭆⁈㽊⡌㵎ぐ㽒穔㭖㱘㕚㩜⭞ॠ䍢ᅤᕦ౨๪", num);
            num2 = -3;
        }
        return num2;
    }

    private void method_3(int A_0)
    {
        if (this.int_20 == null)
        {
            this.int_20 = new int[1];
            this.int_23 = new int[A_0];
            this.int_19 = new int[0x10];
            this.int_21 = new int[3];
            this.int_22 = new int[15];
            this.int_24 = new int[0x10];
        }
        if (this.int_23.Length < A_0)
        {
            this.int_23 = new int[A_0];
        }
        for (int i = 0; i < A_0; i++)
        {
            this.int_23[i] = 0;
        }
        for (int j = 0; j < 0x10; j++)
        {
            this.int_19[j] = 0;
        }
        for (int k = 0; k < 3; k++)
        {
            this.int_21[k] = 0;
        }
        Array.Copy(this.int_19, 0, this.int_22, 0, 15);
        Array.Copy(this.int_19, 0, this.int_24, 0, 0x10);
    }

    internal static int smethod_0(int[] A_0, int[] A_1, int[][] A_2, int[][] A_3, Class1068 A_4)
    {
        A_0[0] = 9;
        A_1[0] = 5;
        A_2[0] = int_13;
        A_3[0] = int_14;
        return 0;
    }
}

