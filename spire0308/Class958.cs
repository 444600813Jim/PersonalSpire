using Spire.Doc;
using System;
using System.Collections;
using System.Drawing;
using System.IO;

internal class Class958 : IDisposable
{
    protected ArrayList arrayList_0;
    protected Bitmap bitmap_0;
    protected bool bool_0;
    protected bool bool_1;
    protected bool bool_2;
    protected bool bool_3;
    protected byte[] byte_0 = new byte[0x100];
    protected byte[] byte_1;
    protected byte[] byte_2;
    protected byte[] byte_3;
    protected Image image_0;
    protected Image image_1;
    public static readonly int int_0 = 0;
    public static readonly int int_1 = 1;
    protected int[] int_10;
    protected int[] int_11;
    protected int int_12;
    protected int int_13;
    protected int int_14;
    protected int int_15;
    protected int int_16;
    protected int int_17;
    protected int int_18;
    protected int int_19;
    public static readonly int int_2 = 2;
    protected int int_20;
    protected int int_21;
    protected int int_22;
    protected int int_23;
    protected int int_24;
    protected int int_25;
    protected int int_26;
    protected static readonly int int_3 = 0x1000;
    protected int int_4;
    protected int int_5;
    protected int int_6;
    protected int int_7;
    protected int int_8 = 1;
    protected int[] int_9;
    protected Rectangle rectangle_0;
    protected short[] short_0;
    protected Stream stream_0;

    public int method_0(int A_0)
    {
        this.int_24 = -1;
        if ((A_0 >= 0) && (A_0 < this.int_26))
        {
            this.int_24 = ((Class959) this.arrayList_0[A_0]).int_0;
        }
        return this.int_24;
    }

    public int method_1()
    {
        return this.int_26;
    }

    public int method_10(string A_0)
    {
        this.int_4 = int_0;
        try
        {
            A_0 = A_0.Trim().ToLower();
            this.int_4 = this.method_9(new FileInfo(A_0).OpenRead());
        }
        catch (IOException)
        {
            this.int_4 = int_2;
        }
        return this.int_4;
    }

    protected void method_11()
    {
        int num = -1;
        int num2 = this.int_19 * this.int_20;
        if ((this.byte_3 == null) || (this.byte_3.Length < num2))
        {
            this.byte_3 = new byte[num2];
        }
        if (this.short_0 == null)
        {
            this.short_0 = new short[int_3];
        }
        if (this.byte_1 == null)
        {
            this.byte_1 = new byte[int_3];
        }
        if (this.byte_2 == null)
        {
            this.byte_2 = new byte[int_3 + 1];
        }
        int num6 = this.method_16();
        int num9 = ((int) 1) << num6;
        int num18 = num9 + 1;
        int index = num9 + 2;
        int num11 = num;
        int num7 = num6 + 1;
        int num8 = (((int) 1) << num7) - 1;
        int num4 = 0;
        while (num4 < num9)
        {
            this.short_0[num4] = 0;
            this.byte_1[num4] = (byte) num4;
            num4++;
        }
        int num13 = 0;
        int num12 = 0;
        int num3 = 0;
        int num15 = 0;
        int num16 = 0;
        int num17 = 0;
        int num19 = 0;
        int num5 = 0;
        while (num5 < num2)
        {
            if (num3 == 0)
            {
                if (num17 < num7)
                {
                    if (num16 == 0)
                    {
                        num16 = this.method_17();
                        if (num16 <= 0)
                        {
                            break;
                        }
                        num13 = 0;
                    }
                    num19 += (this.byte_0[num13] & 0xff) << num17;
                    num17 += 8;
                    num13++;
                    num16--;
                    continue;
                }
                num4 = num19 & num8;
                num19 = num19 >> num7;
                num17 -= num7;
                if ((num4 > index) || (num4 == num18))
                {
                    break;
                }
                if (num4 == num9)
                {
                    num7 = num6 + 1;
                    num8 = (((int) 1) << num7) - 1;
                    index = num9 + 2;
                    num11 = num;
                    continue;
                }
                if (num11 == num)
                {
                    this.byte_2[num3++] = this.byte_1[num4];
                    num11 = num4;
                    num15 = num4;
                    continue;
                }
                int num14 = num4;
                if (num4 == index)
                {
                    this.byte_2[num3++] = (byte) num15;
                    num4 = num11;
                }
                while (num4 > num9)
                {
                    this.byte_2[num3++] = this.byte_1[num4];
                    num4 = this.short_0[num4];
                }
                num15 = this.byte_1[num4] & 0xff;
                if (index >= int_3)
                {
                    break;
                }
                this.byte_2[num3++] = (byte) num15;
                this.short_0[index] = (short) num11;
                this.byte_1[index] = (byte) num15;
                index++;
                if (((index & num8) == 0) && (index < int_3))
                {
                    num7++;
                    num8 += index;
                }
                num11 = num14;
            }
            num3--;
            this.byte_3[num12++] = this.byte_2[num3];
            num5++;
        }
        for (num5 = num12; num5 < num2; num5++)
        {
            this.byte_3[num5] = 0;
        }
    }

    protected bool method_12()
    {
        return (this.int_4 != int_0);
    }

    private void method_13(bool A_0)
    {
        this.int_9 = null;
        this.int_10 = null;
        this.int_11 = null;
        this.byte_0 = null;
        this.short_0 = null;
        this.byte_1 = null;
        this.byte_2 = null;
        this.byte_3 = null;
        if (this.stream_0 != null)
        {
            this.stream_0.Dispose();
            this.stream_0 = null;
        }
        if (A_0)
        {
            if (this.image_0 != null)
            {
                this.image_0.Dispose();
                this.image_0 = null;
            }
            if (this.bitmap_0 != null)
            {
                this.bitmap_0.Dispose();
                this.bitmap_0 = null;
            }
            if (this.image_1 != null)
            {
                this.image_1.Dispose();
                this.image_1 = null;
            }
        }
    }

    public void method_14()
    {
        this.method_13(false);
    }

    protected void method_15()
    {
        this.int_4 = int_0;
        this.int_26 = 0;
        this.arrayList_0 = new ArrayList();
        this.int_9 = null;
        this.int_10 = null;
    }

    protected int method_16()
    {
        int num = 0;
        try
        {
            num = this.stream_0.ReadByte();
        }
        catch (IOException)
        {
            this.int_4 = int_1;
        }
        return num;
    }

    protected int method_17()
    {
        this.int_21 = this.method_16();
        int offset = 0;
        if (this.int_21 <= 0)
        {
            return offset;
        }
        try
        {
            int num2 = 0;
            while (offset < this.int_21)
            {
                num2 = this.stream_0.Read(this.byte_0, offset, this.int_21 - offset);
                if (num2 == -1)
                {
                    goto Label_004D;
                }
                offset += num2;
            }
        }
        catch (IOException)
        {
        }
    Label_004D:
        if (offset < this.int_21)
        {
            this.int_4 = int_1;
        }
        return offset;
    }

    protected int[] method_18(int A_0)
    {
        int num = 3 * A_0;
        int[] numArray = null;
        byte[] buffer = new byte[num];
        int num2 = 0;
        try
        {
            num2 = this.stream_0.Read(buffer, 0, buffer.Length);
        }
        catch (IOException)
        {
        }
        if (num2 < num)
        {
            this.int_4 = int_1;
            return numArray;
        }
        numArray = new int[0x100];
        int num3 = 0;
        int num4 = 0;
        while (num3 < A_0)
        {
            int num5 = buffer[num4++] & 0xff;
            int num6 = buffer[num4++] & 0xff;
            int num7 = buffer[num4++] & 0xff;
            numArray[num3++] = ((((int) 0xff000000L) | (num5 << 0x10)) | (num6 << 8)) | num7;
        }
        return numArray;
    }

    protected void method_19()
    {
        int num = 0x10;
        bool flag = false;
        while (!flag)
        {
            if (this.method_12())
            {
                break;
            }
            int num3 = this.method_16();
            if (num3 <= 0x21)
            {
                if (num3 != 0)
                {
                    if (num3 != 0x21)
                    {
                        goto Label_00CB;
                    }
                    int num5 = this.method_16();
                    if (num5 == 0xf9)
                    {
                        this.method_20();
                    }
                    else if (num5 != 0xff)
                    {
                        this.method_27();
                    }
                    else
                    {
                        this.method_17();
                        string str = "";
                        for (int i = 0; i < 11; i++)
                        {
                            str = str + ((char) this.byte_0[i]);
                        }
                        if (str.Equals(BookmarkStart.b("砵紷渹漻紽ĿቁŃ瑅晇穉", num)))
                        {
                            this.method_24();
                        }
                        else
                        {
                            this.method_27();
                        }
                    }
                }
                continue;
            }
            if (num3 == 0x2c)
            {
                goto Label_00DC;
            }
            if (num3 == 0x3b)
            {
                goto Label_00D8;
            }
        Label_00CB:
            this.int_4 = int_1;
            continue;
        Label_00D8:
            flag = true;
            continue;
        Label_00DC:
            this.method_22();
        }
    }

    public Image method_2()
    {
        return this.method_7(0);
    }

    protected void method_20()
    {
        this.method_16();
        int num = this.method_16();
        this.int_22 = (num & 0x1c) >> 2;
        if (this.int_22 == 0)
        {
            this.int_22 = 1;
        }
        this.bool_3 = (num & 1) != 0;
        this.int_24 = this.method_25() * 10;
        this.int_25 = this.method_16();
        this.method_16();
    }

    protected void method_21()
    {
        int num = 8;
        string str = "";
        for (int i = 0; i < 6; i++)
        {
            str = str + ((char) this.method_16());
        }
        if (!str.StartsWith(BookmarkStart.b("椭礯琱", num)))
        {
            this.int_4 = int_1;
        }
        else
        {
            this.method_23();
            if (this.bool_0 && !this.method_12())
            {
                this.int_9 = this.method_18(this.int_7);
                this.int_13 = this.int_9[this.int_12];
            }
        }
    }

    protected void method_22()
    {
        this.int_17 = this.method_25();
        this.int_18 = this.method_25();
        this.int_19 = this.method_25();
        this.int_20 = this.method_25();
        int num = this.method_16();
        this.bool_1 = (num & 0x80) != 0;
        this.bool_2 = (num & 0x40) != 0;
        this.int_16 = ((int) 2) << (num & 7);
        if (this.bool_1)
        {
            this.int_10 = this.method_18(this.int_16);
            this.int_11 = this.int_10;
        }
        else
        {
            this.int_11 = this.int_9;
            if (this.int_12 == this.int_25)
            {
                this.int_13 = 0;
            }
        }
        int num2 = 0;
        if (this.bool_3)
        {
            num2 = this.int_11[this.int_25];
            this.int_11[this.int_25] = 0;
        }
        if (this.int_11 == null)
        {
            this.int_4 = int_1;
        }
        if (!this.method_12())
        {
            this.method_11();
            this.method_27();
            if (!this.method_12())
            {
                this.int_26++;
                this.bitmap_0 = new Bitmap(this.int_5, this.int_6);
                this.image_0 = this.bitmap_0;
                this.method_6();
                this.arrayList_0.Add(new Class959(this.bitmap_0, this.int_24));
                if (this.bool_3)
                {
                    this.int_11[this.int_25] = num2;
                }
                this.method_26();
            }
        }
    }

    protected void method_23()
    {
        this.int_5 = this.method_25();
        this.int_6 = this.method_25();
        int num = this.method_16();
        this.bool_0 = (num & 0x80) != 0;
        this.int_7 = ((int) 2) << (num & 7);
        this.int_12 = this.method_16();
        this.int_15 = this.method_16();
    }

    protected void method_24()
    {
        do
        {
            this.method_17();
            if (this.byte_0[0] == 1)
            {
                int num = this.byte_0[1] & 0xff;
                int num2 = this.byte_0[2] & 0xff;
                this.int_8 = (num2 << 8) | num;
            }
        }
        while ((this.int_21 > 0) && !this.method_12());
    }

    protected int method_25()
    {
        return (this.method_16() | (this.method_16() << 8));
    }

    protected void method_26()
    {
        this.int_23 = this.int_22;
        this.rectangle_0 = new Rectangle(this.int_17, this.int_18, this.int_19, this.int_20);
        this.image_1 = this.image_0;
        this.int_14 = this.int_13;
        this.int_10 = null;
    }

    protected void method_27()
    {
        do
        {
            this.method_17();
        }
        while ((this.int_21 > 0) && !this.method_12());
    }

    public int method_3()
    {
        return this.int_8;
    }

    private int[] method_4(Bitmap A_0)
    {
        int[] numArray = new int[(3 * this.image_0.Width) * this.image_0.Height];
        int index = 0;
        for (int i = 0; i < this.image_0.Height; i++)
        {
            for (int j = 0; j < this.image_0.Width; j++)
            {
                Color pixel = A_0.GetPixel(j, i);
                numArray[index] = pixel.R;
                index++;
                numArray[index] = pixel.G;
                index++;
                numArray[index] = pixel.B;
                index++;
            }
        }
        return numArray;
    }

    private void method_5(int[] A_0)
    {
        int num = 0;
        for (int i = 0; i < this.image_0.Height; i++)
        {
            for (int j = 0; j < this.image_0.Width; j++)
            {
                Color color = Color.FromArgb(A_0[num++]);
                this.bitmap_0.SetPixel(j, i, color);
            }
        }
    }

    protected void method_6()
    {
        int[] destinationArray = this.method_4(this.bitmap_0);
        if (this.int_23 > 0)
        {
            if (this.int_23 == 3)
            {
                int num8 = this.int_26 - 2;
                if (num8 > 0)
                {
                    this.image_1 = this.method_7(num8 - 1);
                }
                else
                {
                    this.image_1 = null;
                }
            }
            if (this.image_1 != null)
            {
                Array.Copy(this.method_4(new Bitmap(this.image_1)), 0, destinationArray, 0, this.int_5 * this.int_6);
                if (this.int_23 == 2)
                {
                    Graphics graphics = Graphics.FromImage(this.image_0);
                    Color empty = Color.Empty;
                    if (this.bool_3)
                    {
                        empty = Color.FromArgb(0, 0, 0, 0);
                    }
                    else
                    {
                        empty = Color.FromArgb(this.int_14);
                    }
                    Brush brush = new SolidBrush(empty);
                    graphics.FillRectangle(brush, this.rectangle_0);
                    brush.Dispose();
                    graphics.Dispose();
                }
            }
        }
        int num12 = 1;
        int num4 = 8;
        int num3 = 0;
        for (int i = 0; i < this.int_20; i++)
        {
            int num5 = i;
            if (this.bool_2)
            {
                if (num3 >= this.int_20)
                {
                    num12++;
                    switch (num12)
                    {
                        case 2:
                            num3 = 4;
                            break;

                        case 3:
                            num3 = 2;
                            num4 = 4;
                            break;

                        case 4:
                            num3 = 1;
                            num4 = 2;
                            break;
                    }
                }
                num5 = num3;
                num3 += num4;
            }
            num5 += this.int_18;
            if (num5 < this.int_6)
            {
                int num = num5 * this.int_5;
                int index = num + this.int_17;
                int num2 = index + this.int_19;
                if ((num + this.int_5) < num2)
                {
                    num2 = num + this.int_5;
                }
                int num9 = i * this.int_19;
                while (index < num2)
                {
                    int num10 = this.byte_3[num9++] & 0xff;
                    int num11 = this.int_11[num10];
                    if (num11 != 0)
                    {
                        destinationArray[index] = num11;
                    }
                    index++;
                }
            }
        }
        this.method_5(destinationArray);
    }

    public Image method_7(int A_0)
    {
        Image image = null;
        if ((A_0 >= 0) && (A_0 < this.int_26))
        {
            image = ((Class959) this.arrayList_0[A_0]).image_0;
        }
        return image;
    }

    public Size method_8()
    {
        return new Size(this.int_5, this.int_6);
    }

    public int method_9(Stream A_0)
    {
        this.method_15();
        if (A_0 != null)
        {
            this.stream_0 = A_0;
            this.method_21();
            if (!this.method_12())
            {
                this.method_19();
                if (this.int_26 < 0)
                {
                    this.int_4 = int_1;
                }
            }
            A_0.Close();
        }
        else
        {
            this.int_4 = int_2;
        }
        return this.int_4;
    }

    void IDisposable.Dispose()
    {
        this.method_13(true);
    }

    public class Class959
    {
        private byte byte_0;
        public Image image_0;
        public int int_0;
        private long[] long_0;
        private string[] string_0;

        public Class959(Image A_0, int A_1)
        {
            this.image_0 = A_0;
            this.int_0 = A_1;
        }
    }
}

