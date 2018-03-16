using Spire.Doc;
using System;
using System.Drawing;
using System.IO;

internal class Class328
{
    protected bool bool_0;
    protected bool[] bool_1 = new bool[0x100];
    protected bool bool_2;
    protected bool bool_3 = true;
    protected bool bool_4;
    protected byte[] byte_0;
    protected byte[] byte_1;
    protected byte[] byte_2;
    protected Color color_0 = Color.Empty;
    protected FileStream fileStream_0;
    protected Image image_0;
    protected int int_0;
    protected int int_1;
    protected int int_2;
    protected int int_3 = -1;
    protected int int_4;
    protected int int_5;
    protected int int_6 = 7;
    protected int int_7 = -1;
    protected int int_8 = 10;

    public void method_0(int A_0)
    {
        this.int_4 = (int) Math.Round((double) (((float) A_0) / 10f));
    }

    public void method_1(int A_0)
    {
        if (A_0 >= 0)
        {
            this.int_7 = A_0;
        }
    }

    public bool method_10(string A_0)
    {
        bool flag = true;
        try
        {
            this.fileStream_0 = new FileStream(A_0, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            flag = this.method_9(this.fileStream_0);
            this.bool_2 = true;
        }
        catch (IOException)
        {
            flag = false;
        }
        return (this.bool_0 = flag);
    }

    protected void method_11()
    {
        int length = this.byte_0.Length;
        int num2 = length / 3;
        this.byte_1 = new byte[num2];
        Class391 class2 = new Class391(this.byte_0, length, this.int_8);
        this.byte_2 = class2.method_4();
        int num3 = 0;
        for (int i = 0; i < num2; i++)
        {
            int index = class2.method_3(this.byte_0[num3++] & 0xff, this.byte_0[num3++] & 0xff, this.byte_0[num3++] & 0xff);
            this.bool_1[index] = true;
            this.byte_1[i] = (byte) index;
        }
        this.byte_0 = null;
        this.int_5 = 8;
        this.int_6 = 7;
        if (this.color_0 != Color.Empty)
        {
            this.int_2 = this.method_12(this.color_0);
        }
    }

    protected int method_12(Color A_0)
    {
        if (this.byte_2 == null)
        {
            return -1;
        }
        int r = A_0.R;
        int g = A_0.G;
        int b = A_0.B;
        int num4 = 0;
        int num2 = 0x1000000;
        int length = this.byte_2.Length;
        for (int i = 0; i < length; i++)
        {
            int num10 = r - (this.byte_2[i++] & 0xff);
            int num11 = g - (this.byte_2[i++] & 0xff);
            int num12 = b - (this.byte_2[i] & 0xff);
            int num = ((num10 * num10) + (num11 * num11)) + (num12 * num12);
            int index = i / 3;
            if (this.bool_1[index] && (num < num2))
            {
                num2 = num;
                num4 = index;
            }
        }
        return num4;
    }

    protected void method_13()
    {
        int width = this.image_0.Width;
        int height = this.image_0.Height;
        if ((width != this.int_0) || (height != this.int_1))
        {
            Image image = new Bitmap(this.int_0, this.int_1);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(this.image_0, 0, 0);
            this.image_0 = image;
            graphics.Dispose();
        }
        this.byte_0 = new byte[(3 * this.image_0.Width) * this.image_0.Height];
        int index = 0;
        Bitmap bitmap = new Bitmap(this.image_0);
        for (int i = 0; i < this.image_0.Height; i++)
        {
            for (int j = 0; j < this.image_0.Width; j++)
            {
                Color pixel = bitmap.GetPixel(j, i);
                this.byte_0[index] = pixel.R;
                index++;
                this.byte_0[index] = pixel.G;
                index++;
                this.byte_0[index] = pixel.B;
                index++;
            }
        }
    }

    protected void method_14()
    {
        int num;
        int num2;
        this.fileStream_0.WriteByte(0x21);
        this.fileStream_0.WriteByte(0xf9);
        this.fileStream_0.WriteByte(4);
        if (this.color_0 == Color.Empty)
        {
            num = 0;
            num2 = 0;
        }
        else
        {
            num = 1;
            num2 = 2;
        }
        if (this.int_7 >= 0)
        {
            num2 = this.int_7 & 7;
        }
        num2 = num2 << 2;
        this.fileStream_0.WriteByte(Convert.ToByte((int) (num2 | num)));
        this.method_20(this.int_4);
        this.fileStream_0.WriteByte(Convert.ToByte(this.int_2));
        this.fileStream_0.WriteByte(0);
    }

    protected void method_15()
    {
        this.fileStream_0.WriteByte(0x2c);
        this.method_20(0);
        this.method_20(0);
        this.method_20(this.int_0);
        this.method_20(this.int_1);
        if (this.bool_3)
        {
            this.fileStream_0.WriteByte(0);
        }
        else
        {
            this.fileStream_0.WriteByte(Convert.ToByte((int) (0x80 | this.int_6)));
        }
    }

    protected void method_16()
    {
        this.method_20(this.int_0);
        this.method_20(this.int_1);
        this.fileStream_0.WriteByte(Convert.ToByte((int) (240 | this.int_6)));
        this.fileStream_0.WriteByte(0);
        this.fileStream_0.WriteByte(0);
    }

    protected void method_17()
    {
        this.fileStream_0.WriteByte(0x21);
        this.fileStream_0.WriteByte(0xff);
        this.fileStream_0.WriteByte(11);
        this.method_21(BookmarkStart.b("眸縺椼氾ɀɂᕄɆ筈敊経", 0x13));
        this.fileStream_0.WriteByte(3);
        this.fileStream_0.WriteByte(1);
        this.method_20(this.int_3);
        this.fileStream_0.WriteByte(0);
    }

    protected void method_18()
    {
        this.fileStream_0.Write(this.byte_2, 0, this.byte_2.Length);
        int num = 0x300 - this.byte_2.Length;
        for (int i = 0; i < num; i++)
        {
            this.fileStream_0.WriteByte(0);
        }
    }

    protected void method_19()
    {
        new Class392(this.int_0, this.int_1, this.byte_1, this.int_5).method_4(this.fileStream_0);
    }

    public void method_2(int A_0)
    {
        if (A_0 >= 0)
        {
            this.int_3 = A_0;
        }
    }

    protected void method_20(int A_0)
    {
        this.fileStream_0.WriteByte(Convert.ToByte((int) (A_0 & 0xff)));
        this.fileStream_0.WriteByte(Convert.ToByte((int) ((A_0 >> 8) & 0xff)));
    }

    protected void method_21(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        for (int i = 0; i < chArray.Length; i++)
        {
            this.fileStream_0.WriteByte((byte) chArray[i]);
        }
    }

    public void method_3(Color A_0)
    {
        this.color_0 = A_0;
    }

    public bool method_4(Image A_0)
    {
        if ((A_0 == null) || !this.bool_0)
        {
            return false;
        }
        bool flag = true;
        try
        {
            if (!this.bool_4)
            {
                this.method_8(A_0.Width, A_0.Height);
            }
            this.image_0 = A_0;
            this.method_13();
            this.method_11();
            if (this.bool_3)
            {
                this.method_16();
                this.method_18();
                if (this.int_3 >= 0)
                {
                    this.method_17();
                }
            }
            this.method_14();
            this.method_15();
            if (!this.bool_3)
            {
                this.method_18();
            }
            this.method_19();
            this.bool_3 = false;
        }
        catch (IOException)
        {
            flag = false;
        }
        return flag;
    }

    public bool method_5()
    {
        if (!this.bool_0)
        {
            return false;
        }
        bool flag = true;
        this.bool_0 = false;
        try
        {
            this.fileStream_0.WriteByte(0x3b);
            this.fileStream_0.Flush();
            if (this.bool_2)
            {
                this.fileStream_0.Close();
            }
        }
        catch (IOException)
        {
            flag = false;
        }
        this.int_2 = 0;
        this.fileStream_0 = null;
        this.image_0 = null;
        this.byte_0 = null;
        this.byte_1 = null;
        this.byte_2 = null;
        this.bool_2 = false;
        this.bool_3 = true;
        return flag;
    }

    public void method_6(float A_0)
    {
        if (A_0 != 0f)
        {
            this.int_4 = (int) Math.Round((double) (100f / A_0));
        }
    }

    public void method_7(int A_0)
    {
        if (A_0 < 1)
        {
            A_0 = 1;
        }
        this.int_8 = A_0;
    }

    public void method_8(int A_0, int A_1)
    {
        if (!this.bool_0 || this.bool_3)
        {
            this.int_0 = A_0;
            this.int_1 = A_1;
            if (this.int_0 < 1)
            {
                this.int_0 = 320;
            }
            if (this.int_1 < 1)
            {
                this.int_1 = 240;
            }
            this.bool_4 = true;
        }
    }

    public bool method_9(FileStream A_0)
    {
        int num = 10;
        if (A_0 == null)
        {
            return false;
        }
        bool flag = true;
        this.bool_2 = false;
        this.fileStream_0 = A_0;
        try
        {
            this.method_21(BookmarkStart.b("眯笱爳ีķ嬹", num));
        }
        catch (IOException)
        {
            flag = false;
        }
        return (this.bool_0 = flag);
    }
}

