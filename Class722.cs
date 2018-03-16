using Spire.Doc;
using Spire.Doc.Fields.Shape.Ps.Wrapping;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

[DefaultMember("Item")]
internal class Class722
{
    private readonly ArrayList arrayList_0;

    internal Class722() : this(new PointF[0])
    {
    }

    internal Class722(RectangleF A_0) : this(tfArray)
    {
        PointF[] tfArray = new PointF[] { new PointF(A_0.Left, A_0.Top), new PointF(A_0.Right, A_0.Top), new PointF(A_0.Right, A_0.Bottom), new PointF(A_0.Left, A_0.Bottom) };
    }

    internal Class722(PointF[] A_0)
    {
        int num2 = 3;
        if (A_0 == null)
        {
            throw new NullReferenceException(BookmarkStart.b("夨䐪䐬䄮䔰䀲", num2));
        }
        this.arrayList_0 = new ArrayList(A_0.Length);
        for (int i = 0; i < A_0.Length; i++)
        {
            Class886 class2 = new Class886(A_0[i]);
            this.method_5(class2);
        }
    }

    internal Class722(PointF[] A_0, bool A_1) : this(A_0)
    {
        this.method_0(A_1);
    }

    internal void method_0(bool A_0)
    {
        if (this.method_22() != A_0)
        {
            this.arrayList_0.Reverse();
        }
    }

    internal void method_1(ArrayList A_0, bool A_1)
    {
        if (A_1)
        {
            this.method_2((PointF[]) A_0.ToArray(typeof(PointF)));
        }
        else
        {
            this.arrayList_0.AddRange(A_0);
        }
    }

    internal int method_10(int A_0)
    {
        return (A_0 % this.method_19());
    }

    internal PointF[] method_11()
    {
        PointF[] tfArray = new PointF[this.arrayList_0.Count];
        for (int i = 0; i < this.arrayList_0.Count; i++)
        {
            PointF tf = ((Class886) this.arrayList_0[i]).method_2();
            tfArray[i] = new PointF(tf.X, tf.Y);
        }
        return tfArray;
    }

    internal Point[] method_12()
    {
        PointF[] tfArray = this.method_11();
        Point[] pointArray = new Point[tfArray.Length];
        for (int i = 0; i < tfArray.Length; i++)
        {
            pointArray[i] = spr⤋.ᜀ(tfArray[i]);
        }
        return pointArray;
    }

    internal void method_13(spr➂ A_0)
    {
        if (!spr➂.ᜁ(A_0, null) && !A_0.ᜈ())
        {
            foreach (Class886 class2 in this.arrayList_0)
            {
                class2.method_3(A_0.ᜀ(class2.method_2()));
            }
        }
    }

    internal void method_14(float A_0, float A_1)
    {
        this.method_13(new spr➂(A_0, 0f, 0f, A_1, 0f, 0f));
    }

    internal bool method_15(PointF A_0)
    {
        return smethod_0(this.method_11(), A_0);
    }

    internal void method_16()
    {
        foreach (Class886 class2 in this.arrayList_0)
        {
            class2.method_1(VertexType.Simple);
        }
    }

    internal bool method_17(VertexType A_0)
    {
        bool flag;
        using (IEnumerator enumerator = this.arrayList_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Class886 current = (Class886) enumerator.Current;
                if (current.method_0() != A_0)
                {
                    goto Label_0030;
                }
            }
            return true;
        Label_0030:
            flag = false;
        }
        return flag;
    }

    internal Class722 method_18()
    {
        return new Class722(this.method_11());
    }

    internal int method_19()
    {
        return this.arrayList_0.Count;
    }

    internal void method_2(PointF[] A_0)
    {
        Class886[] c = new Class886[A_0.Length];
        for (int i = 0; i < A_0.Length; i++)
        {
            c[i] = new Class886(A_0[i]);
        }
        this.arrayList_0.AddRange(c);
    }

    internal Class886 method_20(int A_0)
    {
        int num = 0x12;
        if ((0 > A_0) || (A_0 >= this.method_19()))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儷吹堻嬽㠿", num));
        }
        return (Class886) this.arrayList_0[A_0];
    }

    internal void method_21(int A_0, Class886 A_1)
    {
        int num = 8;
        if ((0 > A_0) || (A_0 >= this.method_19()))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䜭帯嘱儳丵", num));
        }
        this.arrayList_0[A_0] = A_1;
    }

    internal bool method_22()
    {
        return spr⃸.ᜀ(this.method_11());
    }

    internal int method_23()
    {
        int num = 0;
        float maxValue = float.MaxValue;
        float y = float.MaxValue;
        for (int i = 0; i < this.method_19(); i++)
        {
            PointF tf = this.method_20(i).method_2();
            if ((tf.X < maxValue) || ((tf.X == maxValue) && (tf.Y < y)))
            {
                maxValue = tf.X;
                y = tf.Y;
                num = i;
            }
        }
        return num;
    }

    internal int method_24()
    {
        int num = 0;
        float minValue = float.MinValue;
        for (int i = 0; i < this.method_19(); i++)
        {
            PointF tf = this.method_20(i).method_2();
            if (tf.X > minValue)
            {
                minValue = tf.X;
                num = i;
            }
        }
        return num;
    }

    internal int method_25()
    {
        int num = 0;
        float maxValue = float.MaxValue;
        for (int i = 0; i < this.method_19(); i++)
        {
            PointF tf = this.method_20(i).method_2();
            if (tf.Y < maxValue)
            {
                maxValue = tf.Y;
                num = i;
            }
        }
        return num;
    }

    internal int method_26()
    {
        int num = 0;
        float minValue = float.MinValue;
        for (int i = 0; i < this.method_19(); i++)
        {
            PointF tf = this.method_20(i).method_2();
            if (tf.Y > minValue)
            {
                minValue = tf.Y;
                num = i;
            }
        }
        return num;
    }

    internal void method_3(int A_0, ArrayList A_1)
    {
        this.arrayList_0.InsertRange(A_0, A_1);
    }

    internal void method_4(PointF A_0)
    {
        this.method_5(new Class886(A_0));
    }

    internal void method_5(Class886 A_0)
    {
        this.arrayList_0.Add(A_0);
    }

    internal void method_6(int A_0, Class886 A_1)
    {
        int num = 5;
        if ((0 > A_0) || (A_0 >= this.method_19()))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("䈪䌬䬮吰䬲", num));
        }
        this.arrayList_0.Insert(A_0, A_1);
    }

    internal void method_7(int A_0)
    {
        int num = 10;
        if ((0 > A_0) || (A_0 >= this.method_19()))
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("夯就倳匵䀷", num));
        }
        this.arrayList_0.RemoveAt(A_0);
    }

    internal int method_8(Class886 A_0)
    {
        return this.arrayList_0.IndexOf(A_0);
    }

    internal ArrayList method_9(int A_0)
    {
        ArrayList list = new ArrayList(this.method_19());
        for (int i = 0; i < this.method_19(); i++)
        {
            list.Add(this.method_20(this.method_10(A_0 + i)));
        }
        return list;
    }

    internal static bool smethod_0(PointF[] A_0, PointF A_1)
    {
        bool flag = false;
        if (A_0.Length < 3)
        {
            return false;
        }
        PointF tf2 = new PointF(A_0[A_0.Length - 1].X, A_0[A_0.Length - 1].Y);
        for (int i = 0; i < A_0.Length; i++)
        {
            PointF tf3;
            PointF tf4;
            PointF tf = new PointF(A_0[i].X, A_0[i].Y);
            if (tf.X > tf2.X)
            {
                tf3 = tf2;
                tf4 = tf;
            }
            else
            {
                tf3 = tf;
                tf4 = tf2;
            }
            if (((tf.X < A_1.X) == (A_1.X <= tf2.X)) && (((A_1.Y - tf3.Y) * (tf4.X - tf3.X)) < ((tf4.Y - tf3.Y) * (A_1.X - tf3.X))))
            {
                flag = !flag;
            }
            tf2 = tf;
        }
        return flag;
    }
}

