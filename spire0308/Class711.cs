using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

[DefaultMember("Item")]
internal class Class711 : IDisposable
{
    internal ArrayList arrayList_0 = new ArrayList();
    private bool bool_0 = true;
    private bool bool_1 = true;
    internal bool bool_10;
    private bool bool_2 = true;
    private bool bool_3;
    private bool bool_4 = true;
    private bool bool_5 = true;
    private bool bool_6 = true;
    private bool bool_7 = true;
    private bool bool_8;
    private bool bool_9;
    private Dictionary<int, float> dictionary_0 = new Dictionary<int, float>();
    private Dictionary<int, Class712> dictionary_1 = new Dictionary<int, Class712>();
    private float float_0;
    internal float float_1 = float.MaxValue;
    private LayoutType layoutType_0 = LayoutType.AutoFit;
    private List<Class714> list_0 = new List<Class714>();
    private List<Class714> list_1 = new List<Class714>();
    private ushort ushort_0;
    private ushort ushort_1;

    public Class711()
    {
        this.dictionary_1 = new Dictionary<int, Class712>();
    }

    internal List<Class714> method_0()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<Class714>();
        }
        if (((this.list_0.Count <= 0) || (this.list_0.Count < this.ushort_1)) || this.bool_10)
        {
            this.method_64();
            this.bool_10 = false;
        }
        return this.list_0;
    }

    internal ushort method_1()
    {
        return this.ushort_0;
    }

    public bool method_10()
    {
        return this.bool_1;
    }

    public bool method_11()
    {
        return this.bool_0;
    }

    public bool method_12()
    {
        return (this.bool_2 && (this.float_1 > 0f));
    }

    public bool method_13()
    {
        return this.bool_4;
    }

    public bool method_14()
    {
        return this.bool_3;
    }

    public bool method_15()
    {
        return this.bool_9;
    }

    public LayoutType method_16()
    {
        return this.layoutType_0;
    }

    public void method_17(LayoutType A_0)
    {
        this.layoutType_0 = A_0;
    }

    public bool method_18()
    {
        this.method_19();
        for (int i = 0; i < this.method_1(); i++)
        {
            if (this.method_0()[i].method_10() > this.method_20())
            {
                return true;
            }
        }
        return false;
    }

    public float method_19()
    {
        return this.method_62();
    }

    public bool method_2()
    {
        return this.bool_5;
    }

    public float method_20()
    {
        return this.float_0;
    }

    public float method_21()
    {
        return this.method_67();
    }

    public int method_22()
    {
        return this.ushort_1;
    }

    public Class712 method_23(int A_0)
    {
        return this.method_48(A_0);
    }

    public void method_24(float A_0)
    {
        if (this.method_3())
        {
            this.method_25(A_0, this, true);
        }
    }

    private float method_25(float A_0, Class711 A_1, bool A_2)
    {
        float num = 0f;
        Dictionary<int, Class721> dictionary = new Dictionary<int, Class721>();
        int num2 = 0;
        int num3 = this.method_5();
        while (num2 < num3)
        {
            Class712 class2 = A_1.dictionary_1[num2];
            Class721 class3 = class2.method_26(A_0);
            if (class3.method_14())
            {
                if (!dictionary.ContainsKey(class3.method_8().Value))
                {
                    dictionary.Add(class3.method_8().Value, class3);
                }
                else
                {
                    Class721 class4 = dictionary[class3.method_8().Value];
                    if (class4.method_2() < class3.method_2())
                    {
                        dictionary[class3.method_8().Value].method_3(class3.method_2());
                        dictionary[class3.method_8().Value].method_5(class3.method_4());
                        dictionary[class3.method_8().Value].method_7(class3.method_6());
                    }
                }
            }
            A_1.float_0 = Math.Max(A_1.float_0, class2.method_14());
            num2++;
        }
        float num6 = A_1.method_19();
        if (num6 > A_0)
        {
            List<Class714> list = new List<Class714>();
            list.AddRange(A_1.method_0());
            float num4 = A_0 / ((float) list.Count);
            float num5 = num4 / 2f;
            float num7 = num6 - A_0;
            Dictionary<int, Class721> dictionary2 = new Dictionary<int, Class721>();
            if (num7 <= num5)
            {
                dictionary2 = this.method_34(list);
            }
            else if ((num7 > num5) && (num7 <= (num5 * 3f)))
            {
                dictionary2 = this.method_35(list, num4);
            }
            else
            {
                dictionary2 = this.method_36(list, num4, true);
            }
            if ((dictionary2.Count > 0) || (dictionary.Count > 0))
            {
                List<Class721> list2 = new List<Class721>();
                if (dictionary2.Count <= 0)
                {
                    list2.AddRange(dictionary.Values);
                }
                else
                {
                    if (dictionary.Count > 0)
                    {
                        foreach (KeyValuePair<int, Class721> pair in dictionary)
                        {
                            if (!dictionary2.ContainsKey(pair.Key))
                            {
                                dictionary2.Add(pair.Key, pair.Value);
                            }
                            else
                            {
                                dictionary2[pair.Key].method_11(true);
                            }
                        }
                    }
                    list2.AddRange(dictionary2.Values);
                }
                this.method_33(list2, num7, num4);
                list2.Clear();
                list2 = null;
            }
            dictionary2.Clear();
            dictionary2 = null;
            list.Clear();
            list = null;
            A_1.method_64();
            num = A_1.method_19();
        }
        else if (!A_2)
        {
            num = A_0;
            float num11 = 0f;
            float f = 0f;
            for (int i = 0; i < A_1.method_0().Count; i++)
            {
                num11 += A_1.method_0()[i].method_8();
            }
            int num9 = 0;
            int num10 = A_1.method_1();
            while (num9 < num10)
            {
                f = (A_1.method_0()[num9].method_8() / num11) * A_0;
                f = float.IsNaN(f) ? 0f : f;
                this.method_72((ushort) A_1.method_0()[num9].method_16(), f);
                num9++;
            }
        }
        dictionary.Clear();
        dictionary = null;
        return num;
    }

    public void method_26(float A_0)
    {
        int num = 0;
        Class711 class2 = new Class711();
        Class711 class3 = new Class711();
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            KeyValuePair<int, Class712> pair2 = pair;
            Class712 class5 = pair.Value.method_21();
            Class712 class6 = pair.Value.method_21();
            int num5 = 0;
            int num6 = 0;
            for (int i = 0; i < pair2.Value.method_4(); i++)
            {
                Class713 class4 = pair.Value.method_18(i);
                if (this.method_0()[i].method_14())
                {
                    class5.method_31(num5, class4);
                    num5++;
                }
                else
                {
                    class6.method_31(num6, class4);
                    num6++;
                }
            }
            class2.method_71(num, class5);
            class3.method_71(num, class6);
            num++;
        }
        float num2 = this.method_31(A_0, AdjustType.AdjustBasedOnCellWidth, class3);
        float num7 = this.method_32(class2);
        if (Class59.smethod_5((double) (A_0 - num2), (double) num7, 1.0) < 0)
        {
            num2 = this.method_31(A_0, AdjustType.AdjustBasedOnTextWidth, class3);
        }
        if (Class59.smethod_5((double) (A_0 - num2), 0.0, 1.0) >= 0)
        {
            float num3 = this.method_25(A_0 - num2, class2, false);
            if (Class59.smethod_5((double) ((A_0 - num2) - num3), 0.0, 1.0) > 0)
            {
                this.method_31((A_0 - num2) - num3, AdjustType.AdjustBasedOnMaxCellWidth, class3);
            }
        }
    }

    public void method_27(float A_0)
    {
        float num2;
        int count = this.method_0().Count;
        if (count != this.method_22())
        {
            return;
        }
        List<Class714> list7 = new List<Class714>();
        List<Class714> list3 = new List<Class714>();
        List<Class714> list2 = new List<Class714>();
        bool flag2 = true;
        bool flag = true;
        float minValue = float.MinValue;
        float num9 = float.MinValue;
        int num30 = 0;
        int num33 = count;
        while (num30 < num33)
        {
            Class714 item = this.method_0()[num30];
            if (!item.method_29())
            {
                if (item.method_8() > item.method_10())
                {
                    list2.Add(item);
                    if (minValue == float.MinValue)
                    {
                        minValue = item.method_8();
                    }
                    if (flag2 && (Class59.smethod_4(minValue, item.method_8(), 0.05f) != 0))
                    {
                        flag2 = false;
                    }
                }
                else if (item.method_8() < item.method_10())
                {
                    list3.Add(item);
                    if (num9 == float.MinValue)
                    {
                        num9 = item.method_8();
                    }
                    if (flag && (Class59.smethod_4(num9, item.method_8(), 0.05f) != 0))
                    {
                        flag = false;
                    }
                }
                else
                {
                    list7.Add(item);
                }
            }
            num30++;
        }
        float num20 = this.method_19();
        if (num20 <= A_0)
        {
            num2 = A_0 - num20;
            if (list3.Count > 0)
            {
                list3.Sort();
                for (int i = list3.Count - 1; i >= 0; i--)
                {
                    Class714 class2 = list3[i];
                    float num3 = class2.method_10() - class2.method_8();
                    if (num3 > num2)
                    {
                        class2.method_9(class2.method_8() + num2);
                        num2 = 0f;
                        break;
                    }
                    class2.method_9(class2.method_10());
                    num2 -= num3;
                }
            }
        }
        else
        {
            float num8 = num20 - A_0;
            if (list2.Count > 0)
            {
                if (!flag2)
                {
                    list2.Sort(new Class715());
                }
                else
                {
                    list2.Sort();
                }
                List<Class714> list = new List<Class714>();
                for (int j = list2.Count - 1; j >= 0; j--)
                {
                    Class714 class7 = list2[j];
                    float num27 = 0f;
                    if (((class7.method_8() > class7.method_4()) && (class7.method_8() > class7.method_10())) && (class7.method_4() > class7.method_10()))
                    {
                        num27 = class7.method_4();
                        list.Add(class7);
                    }
                    else
                    {
                        num27 = (class7.method_10() <= 0f) ? class7.method_8() : class7.method_10();
                    }
                    float num28 = class7.method_8() - num27;
                    if (num28 > num8)
                    {
                        float num17 = num28 - num8;
                        num8 = 0f;
                        if (((j > 0) && (num17 > 1f)) && (Class59.smethod_4((float) class7.method_35(), (float) class7.method_36(), 0.005f) == 0))
                        {
                            List<Class714> list6 = new List<Class714>();
                            for (int k = j; k < list2.Count; k++)
                            {
                                Class714 class6 = list2[k];
                                if (Class59.smethod_4((float) class6.method_35(), (float) class6.method_36(), 0.005f) != 0)
                                {
                                    list6.Add(class6);
                                }
                            }
                            if (list6.Count > 0)
                            {
                                float num18 = num17 / ((float) list6.Count);
                                for (int m = 0; m < list6.Count; m++)
                                {
                                    Class714 class12 = list6[m];
                                    class12.method_9(class12.method_8() + num18);
                                }
                            }
                            else
                            {
                                class7.method_9(num27 + num17);
                            }
                            list6 = null;
                        }
                        else
                        {
                            class7.method_9(num27 + num17);
                        }
                        break;
                    }
                    class7.method_9(num27);
                    num8 -= num28;
                }
                if ((num8 > 0f) && (list.Count > 0))
                {
                    for (int n = 0; n < list.Count; n++)
                    {
                        Class714 class3 = list[n];
                        float num6 = class3.method_10();
                        float num7 = class3.method_8() - num6;
                        if (num7 > num8)
                        {
                            class3.method_9(num6 + (num7 - num8));
                            num8 = 0f;
                            break;
                        }
                        class3.method_9(num6);
                        num8 -= num7;
                    }
                }
                list.Clear();
                list = null;
                if (num8 > 0f)
                {
                    float num31 = this.method_19();
                    int num23 = 0;
                    int num24 = count;
                    while (num23 < num24)
                    {
                        Class714 class10 = this.method_0()[num23];
                        class10.method_9(class10.method_8() - (num8 * (class10.method_8() / num31)));
                        num23++;
                    }
                }
            }
            goto Label_061B;
        }
        if (num2 > 0f)
        {
            ArrayList list5 = new ArrayList();
            ArrayList list4 = new ArrayList();
            int num21 = 0;
            int num34 = count;
            while (num21 < num34)
            {
                Class714 class9 = this.method_0()[num21];
                if (!class9.method_29())
                {
                    if (class9.method_8() < class9.method_10())
                    {
                        list5.Add(class9);
                    }
                    else
                    {
                        list4.Add(class9);
                    }
                }
                num21++;
            }
            if (list5.Count > 0)
            {
                list5.Sort(new Class719());
                for (int num25 = list5.Count - 1; num25 >= 0; num25--)
                {
                    Class714 class8 = list5[num25] as Class714;
                    float num26 = class8.method_4() - class8.method_8();
                    if (num26 > num2)
                    {
                        class8.method_9(class8.method_8() + num2);
                        num2 = 0f;
                        break;
                    }
                    class8.method_9(class8.method_4());
                    num2 -= num26;
                }
            }
            if (num2 > 0f)
            {
                if (list5.Count > 0)
                {
                    float num32 = 0f;
                    int num10 = 0;
                    int num11 = list4.Count;
                    while (num10 < num11)
                    {
                        Class714 class11 = list4[num10] as Class714;
                        num32 += class11.method_8();
                        num10++;
                    }
                    int num12 = 0;
                    int num13 = list4.Count;
                    while (num12 < num13)
                    {
                        Class714 class13 = list4[num12] as Class714;
                        class13.method_9(class13.method_8() + (num2 * (class13.method_8() / num32)));
                        num12++;
                    }
                }
                else
                {
                    float num16 = this.method_19();
                    int num15 = 0;
                    int num35 = count;
                    while (num15 < num35)
                    {
                        Class714 class5 = this.method_0()[num15];
                        class5.method_9(class5.method_8() + (num2 * (class5.method_8() / num16)));
                        num15++;
                    }
                }
            }
            list5.Clear();
        }
    Label_061B:
        list7.Clear();
        list3.Clear();
        list2.Clear();
    }

    public bool method_28()
    {
        int num = 0;
        int count = this.method_0().Count;
        while (num < count)
        {
            Class714 class2 = this.method_0()[num];
            if (class2.method_22())
            {
                return true;
            }
            num++;
        }
        return false;
    }

    public void method_29()
    {
        if (this.method_28())
        {
            List<Class714> list = new List<Class714>();
            List<Class714> list2 = new List<Class714>();
            this.method_1();
            float num = 0f;
            for (int i = 0; i < this.method_0().Count; i++)
            {
                Class714 item = this.method_0()[i];
                if (item.method_22())
                {
                    list.Add(item);
                }
                else if ((item.method_8() > 0f) || (item.method_10() > 0f))
                {
                    list2.Add(item);
                }
            }
            if (list.Count > 0)
            {
                float num3 = 0f;
                foreach (Class714 class2 in list)
                {
                    num3 += (float) Math.Round((double) (class2.method_10() - class2.method_8()));
                    this.method_72((ushort) class2.method_16(), class2.method_10());
                }
                num = num3 / ((float) list2.Count);
            }
            if ((list2.Count > 0) && (num != 0f))
            {
                int num5 = 0;
                int count = list2.Count;
                while (num5 < count)
                {
                    float num6 = list2[num5].method_8() - num;
                    if (num6 >= list2[num5].method_10())
                    {
                        this.method_72((ushort) list2[num5].method_16(), num6);
                    }
                    else
                    {
                        num += num / ((float) (count - (num5 + 1)));
                    }
                    num5++;
                }
            }
            list.Clear();
            list2.Clear();
        }
    }

    public bool method_3()
    {
        return this.bool_6;
    }

    public void method_30(float A_0)
    {
        float num = A_0 / ((float) this.list_1.Count);
        for (int i = 0; i < this.list_1.Count; i++)
        {
            this.method_73((ushort) this.list_1[i].method_16(), num, true);
        }
    }

    public float method_31(float A_0, AdjustType A_1, Class711 A_2)
    {
        float num = 0f;
        float num2 = 0f;
        float num3 = 0f;
        A_2.method_19();
        switch (A_1)
        {
            case AdjustType.AdjustBasedOnCellWidth:
            {
                int num4 = 0;
                int num12 = A_2.method_1();
                while (num4 < num12)
                {
                    if (A_2.method_0()[num4].method_18() && ((A_2.method_0()[num4].method_2() < A_2.method_0()[num4].method_4()) || (A_2.method_0()[num4].method_2() < A_2.method_0()[num4].method_10())))
                    {
                        num2 = (A_2.method_0()[num4].method_4() > A_2.method_0()[num4].method_10()) ? A_2.method_0()[num4].method_4() : A_2.method_0()[num4].method_10();
                    }
                    else
                    {
                        num3 = A_2.method_0()[num4].method_2();
                        if (A_2.method_0()[num4].method_6() > num3)
                        {
                            num2 = A_2.method_0()[num4].method_4();
                        }
                        if (A_2.method_0()[num4].method_4() > num3)
                        {
                            num2 = A_2.method_0()[num4].method_10();
                        }
                        if (num3 != 0f)
                        {
                            if (A_2.method_0()[num4].method_10() > num3)
                            {
                                num2 = A_2.method_0()[num4].method_10();
                            }
                            else
                            {
                                num2 = num3;
                            }
                        }
                    }
                    this.method_72((ushort) A_2.method_0()[num4].method_16(), num2);
                    num += num2;
                    num4++;
                }
                return num;
            }
            case AdjustType.AdjustBasedOnTextWidth:
            {
                int num8 = 0;
                int num9 = A_2.method_1();
                while (num8 < num9)
                {
                    num2 = (A_2.method_0()[num8].method_4() > A_2.method_0()[num8].method_10()) ? A_2.method_0()[num8].method_4() : A_2.method_0()[num8].method_10();
                    this.method_72((ushort) A_2.method_0()[num8].method_16(), num2);
                    num += num2;
                    num8++;
                }
                return num;
            }
            case AdjustType.AdjustBasedOnMaxCellWidth:
            {
                float num6 = A_2.method_0()[0].method_20() ? A_2.method_0()[0].method_8() : A_2.method_0()[0].method_2();
                int num7 = 0;
                for (int i = 1; i < A_2.method_0().Count; i++)
                {
                    if ((A_2.method_0()[i].method_2() > num6) && !A_2.method_0()[i].method_20())
                    {
                        num6 = A_2.method_0()[i].method_2();
                        num7 = i;
                    }
                }
                this.method_73((ushort) A_2.method_0()[num7].method_16(), A_0, true);
                return num;
            }
            case AdjustType.AdjustBasedOnEmptyCol:
            {
                int num10 = 0;
                int num11 = A_2.method_1();
                while (num10 < num11)
                {
                    if ((A_2.method_0()[num10].method_4() <= A_2.method_0()[num10].method_2()) && !A_2.method_0()[num10].method_20())
                    {
                        num += A_2.method_0()[num10].method_8();
                    }
                    else
                    {
                        num2 = Math.Max(A_2.method_0()[num10].method_4(), A_2.method_0()[num10].method_10());
                        this.method_72((ushort) A_2.method_0()[num10].method_16(), num2);
                        num += num2;
                    }
                    num10++;
                }
                return num;
            }
        }
        return num;
    }

    private float method_32(Class711 A_0)
    {
        float num = 0f;
        A_0.method_19();
        for (int i = 0; i < A_0.method_5(); i++)
        {
            Class712 class2 = A_0.dictionary_1[i];
            int num3 = 0;
            int num4 = class2.method_4();
            while (num3 < num4)
            {
                if (class2.method_20(num3))
                {
                    Class714 class3 = A_0.method_0()[num3];
                    num += class3.method_12();
                }
                num3++;
            }
            if (class2.method_4() != 0)
            {
                return num;
            }
        }
        return num;
    }

    private void method_33(List<Class721> A_0, float A_1, float A_2)
    {
        if (A_0.Count > 0)
        {
            if (A_1 <= A_2)
            {
                float num6 = 0f;
                int num9 = 0;
                int count = A_0.Count;
                while (num9 < count)
                {
                    Class721 class5 = A_0[num9];
                    num6 += class5.method_2();
                    num9++;
                }
                int num5 = 0;
                int num11 = A_0.Count;
                while (num5 < num11)
                {
                    Class721 class4 = A_0[num5];
                    float num7 = class4.method_2() - (A_1 * (class4.method_2() / num6));
                    this.method_72(class4.method_8().Value, num7);
                    num5++;
                }
            }
            else
            {
                float num2 = A_1;
                A_0.Sort();
                float num3 = 0f;
                float num17 = 0f;
                int num4 = 0;
                int num18 = A_0.Count;
                while (num4 < num18)
                {
                    Class721 class3 = A_0[num4];
                    num3 = 0f;
                    if (num4 != (num18 - 1))
                    {
                        A_1 -= class3.method_2() - class3.method_4();
                        num3 = class3.method_4();
                    }
                    else
                    {
                        num3 = class3.method_2() - A_1;
                    }
                    if ((num3 - class3.float_4) <= class3.method_6())
                    {
                        num3 -= class3.float_4;
                        num17 = class3.method_6();
                        break;
                    }
                    this.method_72(class3.method_8().Value, num3);
                    num4++;
                }
                if (num3 <= num17)
                {
                    List<Class721> list = new List<Class721>();
                    float num12 = 0f;
                    float num13 = 0f;
                    int num = 0;
                    int num8 = A_0.Count;
                    while (num < num8)
                    {
                        Class721 item = A_0[num];
                        if (item.method_4() <= A_2)
                        {
                            num2 -= item.method_2() - item.method_4();
                            this.method_72(item.method_8().Value, item.method_4());
                        }
                        else
                        {
                            num12 += item.method_4();
                            num13 += item.method_2();
                            list.Add(item);
                        }
                        num++;
                    }
                    if (list.Count > 0)
                    {
                        float num14 = (num12 - (num2 - (num13 - num12))) / num12;
                        int num15 = 0;
                        int num16 = list.Count;
                        while (num15 < num16)
                        {
                            Class721 class6 = list[num15];
                            this.method_72(class6.method_8().Value, class6.method_4() * num14);
                            num15++;
                        }
                    }
                }
            }
        }
    }

    private Dictionary<int, Class721> method_34(List<Class714> A_0)
    {
        Class721 class2 = new Class721();
        int num = 0;
        int count = A_0.Count;
        while (num < count)
        {
            if (!class2.method_14() || (class2.method_2() < A_0[num].method_8()))
            {
                class2.method_9(new ushort?((ushort) A_0[num].method_16()));
                class2.method_3(A_0[num].method_8());
                class2.method_5(A_0[num].method_10());
                class2.method_7(A_0[num].method_12());
                class2.float_4 = A_0[num].method_0();
            }
            num++;
        }
        Dictionary<int, Class721> dictionary = new Dictionary<int, Class721>();
        if (class2.method_14())
        {
            dictionary.Add(class2.method_8().Value, class2);
        }
        return dictionary;
    }

    private Dictionary<int, Class721> method_35(List<Class714> A_0, float A_1)
    {
        Class721 class2 = new Class721();
        int num = 0;
        int count = A_0.Count;
        while (num < count)
        {
            if (!class2.method_14() || (class2.method_2() < A_0[num].method_8()))
            {
                class2.method_9(new ushort?((ushort) A_0[num].method_16()));
                class2.method_3(A_0[num].method_8());
                class2.method_5(A_0[num].method_10());
                class2.method_7(A_0[num].method_12());
                class2.float_4 = A_0[num].method_0();
            }
            num++;
        }
        Dictionary<int, Class721> dictionary = new Dictionary<int, Class721>();
        if (class2.method_14())
        {
            dictionary.Add(class2.method_8().Value, class2);
            int num3 = class2.method_8().Value + 1;
            int num4 = A_0.Count;
            while (num3 < num4)
            {
                if (A_0[num3].method_8() > A_1)
                {
                    class2 = new Class721();
                    class2.method_9(new ushort?((ushort) num3));
                    class2.method_3(A_0[num3].method_8());
                    class2.method_5(A_0[num3].method_10());
                    class2.method_7(A_0[num3].method_12());
                    class2.float_4 = A_0[num3].method_0();
                    dictionary.Add(class2.method_8().Value, class2);
                }
                num3++;
            }
        }
        return dictionary;
    }

    private Dictionary<int, Class721> method_36(List<Class714> A_0, float A_1, bool A_2)
    {
        if (!A_2)
        {
            return this.method_35(A_0, A_1);
        }
        Dictionary<int, Class721> dictionary = new Dictionary<int, Class721>();
        int num = 0;
        int count = A_0.Count;
        while (num < count)
        {
            if (A_0[num].method_8() > A_1)
            {
                Class721 class2 = new Class721();
                class2.method_9(new ushort?((ushort) A_0[num].method_16()));
                class2.method_3(A_0[num].method_8());
                class2.method_5(A_0[num].method_10());
                class2.method_7(A_0[num].method_12());
                class2.float_4 = A_0[num].method_0();
                dictionary.Add(class2.method_8().Value, class2);
            }
            num++;
        }
        return dictionary;
    }

    public void method_37()
    {
        if (this.method_2() && this.method_15())
        {
            this.method_38();
        }
    }

    public void method_38()
    {
        if (this.method_15())
        {
            List<Class714> list = new List<Class714>();
            List<Class714> list2 = new List<Class714>();
            int num6 = this.method_1();
            float num5 = 0f;
            for (int i = 0; i < num6; i++)
            {
                Class714 item = this.method_0()[i];
                if (item.method_22())
                {
                    list.Add(item);
                }
                else
                {
                    list2.Add(item);
                }
            }
            if (list.Count > 0)
            {
                float num4 = 0f;
                foreach (Class714 class3 in list)
                {
                    num4 += (float) Math.Round((double) (class3.method_10() - class3.method_8()));
                    this.method_72((ushort) class3.method_16(), class3.method_10());
                }
                num5 = num4 / ((float) list2.Count);
            }
            if ((list2.Count > 0) && (num5 != 0f))
            {
                int num2 = 0;
                int count = list2.Count;
                while (num2 < count)
                {
                    float num7 = list2[num2].method_8() - num5;
                    if (num7 >= list2[num2].method_10())
                    {
                        this.method_72((ushort) list2[num2].method_16(), num7);
                    }
                    else
                    {
                        num5 += num5 / ((float) (count - (num2 + 1)));
                    }
                    num2++;
                }
            }
            list.Clear();
            list2.Clear();
        }
    }

    public void method_39(bool A_0)
    {
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            pair.Value.method_22();
        }
    }

    public bool method_4()
    {
        return this.bool_7;
    }

    public void method_40(float A_0, float A_1)
    {
        int num = 0;
        int num2 = this.method_5();
        while (num < num2)
        {
            this.dictionary_1[num].method_25(A_0, A_1);
            num++;
        }
    }

    public void method_41()
    {
        int num = 0;
        int count = this.dictionary_1.Count;
        while (num < count)
        {
            Class712 class2 = this.dictionary_1[num];
            int num3 = 0;
            int num4 = class2.method_4();
            while (num3 < num4)
            {
                Class713 class3 = class2.method_18(num3);
                class3.method_39(this.method_61(num3, class3));
                num3++;
            }
            num++;
        }
    }

    private ArrayList method_42()
    {
        ArrayList list = new ArrayList();
        float num = 0f;
        list.Add(num);
        foreach (Class714 class2 in this.method_0())
        {
            float num2 = (float.IsNaN(class2.method_8()) || (class2.method_8() < 0f)) ? 1f : class2.method_8();
            num = (float) Math.Round((double) (num + num2), 2);
            list.Add(num);
        }
        list.Sort();
        return list;
    }

    private void method_43(ArrayList A_0)
    {
        for (int i = A_0.Count - 1; i > 0; i--)
        {
            if (Math.Abs((float) (((float) A_0[i]) - ((float) A_0[i - 1]))) <= 0.5f)
            {
                A_0.RemoveAt(i);
            }
        }
    }

    private ArrayList method_44()
    {
        ArrayList list = new ArrayList();
        float num = 0f;
        list.Add(num);
        List<List<Class712>> list2 = new List<List<Class712>>();
        List<Class712> item = new List<Class712>();
        int num2 = 0;
        int count = this.dictionary_1.Count;
        while (num2 < count)
        {
            if (item.Count == 0)
            {
                item.Add(this.dictionary_1[num2]);
            }
            else if ((item.Count > 0) && (this.dictionary_1[num2 - 1].method_4() == this.dictionary_1[num2].method_4()))
            {
                item.Add(this.dictionary_1[num2]);
            }
            else if ((item.Count > 0) && (this.dictionary_1[num2 - 1].method_4() != this.dictionary_1[num2].method_4()))
            {
                list2.Add(item);
                item = new List<Class712> {
                    this.dictionary_1[num2]
                };
            }
            num2++;
        }
        if (item.Count > 0)
        {
            list2.Add(item);
            item = null;
        }
        if (list2.Count > 0)
        {
            foreach (List<Class712> list4 in list2)
            {
                foreach (object obj2 in this.method_68(list4))
                {
                    if (!list.Contains(obj2))
                    {
                        list.Add(obj2);
                    }
                }
            }
        }
        list.Sort();
        return list;
    }

    private ArrayList method_45()
    {
        return this.method_69(this.dictionary_1);
    }

    internal ArrayList method_46()
    {
        ArrayList list = new ArrayList();
        float item = 0f;
        int num2 = 0;
        int count = this.dictionary_1.Count;
        while (num2 < count)
        {
            Class712 class2 = this.dictionary_1[num2];
            item = 0f;
            int num4 = 0;
            int num5 = class2.method_4();
            while (num4 < num5)
            {
                Class713 class3 = class2.method_29(num4);
                item = (float) Math.Round((double) (item + class3.method_38()), 4);
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
                num4++;
            }
            num2++;
        }
        item = 0f;
        if (!list.Contains(item))
        {
            list.Add(item);
        }
        list.Sort();
        return list;
    }

    public void method_47()
    {
        this.arrayList_0 = this.method_42();
    }

    public Class712 method_48(int A_0)
    {
        return this.dictionary_1[A_0];
    }

    public float method_49(int A_0)
    {
        this.method_19();
        float num = 0f;
        if ((this.method_0().Count > A_0) && (this.method_0().Count == this.ushort_1))
        {
            return this.method_0()[A_0].method_8();
        }
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            if (pair.Value.method_20(A_0))
            {
                Class713 class2 = pair.Value.method_29(A_0);
                if (((class2.method_12() == CellMerge.None) && (class2.method_9() == 1)) && (class2.method_17() != CellMerge.Continue))
                {
                    if ((class2.method_0() == 0f) && ((class2.method_42() == FtsWidth.Auto) || (class2.method_42() == FtsWidth.None)))
                    {
                        num = Math.Max(num, Math.Max(class2.method_4(), class2.method_19()));
                    }
                    else if (class2.method_0() == 0f)
                    {
                        num = Math.Max(num, class2.method_4());
                    }
                    else
                    {
                        num = Math.Max(num, class2.method_0());
                    }
                }
            }
        }
        return num;
    }

    public int method_5()
    {
        return this.dictionary_1.Count;
    }

    private Class714 method_50(int A_0)
    {
        Class714 class2 = new Class714();
        Class714 class3 = new Class714();
        Class714 class4 = new Class714();
        Class714 class5 = new Class714();
        bool flag = true;
        bool flag2 = false;
        bool flag3 = true;
        bool flag4 = false;
        bool? nullable = null;
        bool? nullable2 = null;
        int? nullable3 = null;
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            if (!pair.Value.method_20(A_0))
            {
                continue;
            }
            int num2 = 0;
            int num3 = 0;
            if (pair.Value.method_5() <= 0)
            {
                goto Label_00D5;
            }
            int introduced23 = pair.Value.method_5();
            if ((introduced23 == pair.Value.method_4()) || (A_0 == 0))
            {
                goto Label_00D5;
            }
            int num4 = 1;
            while (num4 <= A_0)
            {
                num3 += pair.Value.method_18(num4 - 1).method_9();
                if (num3 == A_0)
                {
                    goto Label_00CF;
                }
                num4++;
            }
            goto Label_00D8;
        Label_00CF:
            num2 = num4;
            goto Label_00D8;
        Label_00D5:
            num2 = A_0;
        Label_00D8:
            if ((num2 == A_0) || (num2 != 0))
            {
                Class713 class6 = pair.Value.method_29(num2);
                if (class6.method_15())
                {
                    flag2 = true;
                }
                if (class6.method_35() != 0f)
                {
                    flag3 = false;
                }
                if (class6.method_30())
                {
                    flag4 = true;
                }
                if (!nullable2.HasValue)
                {
                    nullable2 = new bool?(class6.method_22());
                }
                else if (nullable2.Value)
                {
                    bool? nullable4 = nullable2;
                    bool flag5 = class6.method_22();
                    if (nullable4.GetValueOrDefault() == flag5)
                    {
                        bool hasValue = nullable4.HasValue;
                    }
                }
                if (!nullable3.HasValue && (class6.method_26() > -1))
                {
                    nullable3 = new int?(class6.method_26());
                }
                else if (nullable3.HasValue)
                {
                    int num5 = class6.method_26();
                    int? nullable5 = nullable3;
                    if (num5 == nullable5.GetValueOrDefault())
                    {
                        bool flag6 = nullable5.HasValue;
                    }
                }
                if ((class6.method_42() == FtsWidth.Point) || (class6.method_42() == FtsWidth.Percentage))
                {
                    flag = false;
                }
                if (class6.method_17() != CellMerge.Continue)
                {
                    if (class6.method_9() == 1)
                    {
                        switch (class6.method_12())
                        {
                            case CellMerge.None:
                                this.method_52(class6, ref class2, ref nullable);
                                break;

                            case CellMerge.Start:
                                this.method_52(class6, ref class3, ref nullable);
                                break;

                            case CellMerge.Continue:
                                this.method_52(class6, ref class4, ref nullable);
                                break;
                        }
                    }
                    else if (class6.method_22() && (class6.method_9() < 1))
                    {
                        this.method_52(class6, ref class4, ref nullable);
                    }
                    else if ((class6.method_9() > 1) && (class6.method_12() == CellMerge.Start))
                    {
                        this.method_52(class6, ref class5, ref nullable);
                    }
                }
            }
        }
        if (class2.method_8() <= 0f)
        {
            class2.method_9(class3.method_8());
            class2.method_11(Math.Max(class2.method_10(), class3.method_10()));
            class2.method_13(Math.Max(class2.method_12(), class3.method_12()));
            class2.method_1(Math.Max(class2.method_0(), class3.method_0()));
            class2.method_3(Math.Max(class2.method_2(), class3.method_2()));
            class2.method_5(Math.Max(class2.method_4(), class3.method_4()));
            class2.method_7(Math.Max(class2.method_6(), class3.method_6()));
            if ((class2.method_16() <= 0) && (class3.method_16() > 0))
            {
                class2.method_17(class3.method_16());
            }
        }
        if (class2.method_8() <= 0f)
        {
            class2.method_9(class4.method_8());
            class2.method_11(Math.Max(class2.method_10(), class4.method_10()));
            class2.method_13(Math.Max(class2.method_12(), class4.method_12()));
            class2.method_1(Math.Max(class2.method_0(), class4.method_0()));
            class2.method_3(Math.Max(class2.method_2(), class4.method_2()));
            class2.method_5(Math.Max(class2.method_4(), class4.method_4()));
            class2.method_7(Math.Max(class2.method_6(), class4.method_6()));
            if ((class2.method_16() <= 0) && (class4.method_16() > 0))
            {
                class2.method_17(class4.method_16());
            }
        }
        if (((class2.method_8() <= 0f) && (class2.method_16() <= 0)) && (class5.method_16() > 0))
        {
            class2.method_17(class5.method_16());
        }
        int key = class2.method_16();
        if (key > -1)
        {
            if (class3.method_16() > -1)
            {
                class2.method_25(true);
                this.dictionary_0.Add(key, class3.method_10());
            }
            if (class4.method_16() > -1)
            {
                class2.method_27(true);
            }
        }
        class2.method_15(flag);
        class2.method_19(flag2);
        class2.method_21(flag3);
        class2.method_23(flag4);
        return class2;
    }

    private Class713 method_51(int A_0, int A_1)
    {
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            if (!pair.Value.method_20(A_0))
            {
                continue;
            }
            int num = 0;
            int num3 = 0;
            int introduced7 = pair.Value.method_5();
            if ((introduced7 == pair.Value.method_4()) || (A_0 == 0))
            {
                goto Label_0083;
            }
            int num2 = 1;
            while (num2 <= A_0)
            {
                num3 += pair.Value.method_18(num2 - 1).method_9();
                if (num3 == A_0)
                {
                    goto Label_007E;
                }
                num2++;
            }
            goto Label_0085;
        Label_007E:
            num = num2;
            goto Label_0085;
        Label_0083:
            num = A_0;
        Label_0085:
            if ((num == A_0) || (num != 0))
            {
                Class713 class2 = pair.Value.method_29(num);
                if (class2.method_9() == A_1)
                {
                    return class2;
                }
            }
        }
        return null;
    }

    private void method_52(Class713 A_0, ref Class714 A_1, ref bool? A_2)
    {
        if (A_0 != null)
        {
            A_1.method_17(A_0.method_10());
            if (((A_0.method_0() == 0f) && ((A_0.method_42() == FtsWidth.Auto) || (A_0.method_42() == FtsWidth.None))) && (!A_2.HasValue || (A_2.HasValue && A_2.Value)))
            {
                float num = Math.Max(A_0.method_4(), A_0.method_19());
                if (A_1.method_8() < num)
                {
                    A_1.method_9(num);
                    A_2 = 1;
                }
            }
            else if ((A_0.method_42() != FtsWidth.Point) && (A_0.method_42() != FtsWidth.Percentage))
            {
                A_1.method_9(Math.Max(A_1.method_8(), A_0.method_0()));
            }
            else
            {
                if (A_2.HasValue && (!A_2.HasValue || !A_2.Value))
                {
                    A_1.method_9(Math.Max(A_1.method_8(), A_0.method_0()));
                }
                else
                {
                    A_1.method_9(Math.Max(A_1.method_8(), A_0.method_0()));
                }
                A_2 = 0;
            }
            A_1.method_11(Math.Max(A_1.method_10(), A_0.method_19()));
            A_1.method_13(Math.Max(A_1.method_12(), A_0.method_40()));
            A_1.method_1(Math.Max(A_1.method_0(), A_0.method_31()));
            A_1.method_3(Math.Max(A_1.method_2(), A_0.method_2()));
            A_1.method_5(Math.Max(A_1.method_4(), A_0.method_4()));
            A_1.method_7(Math.Max(A_1.method_6(), A_0.method_35()));
        }
    }

    internal void method_53(float A_0)
    {
        this.method_54(A_0, true);
    }

    internal void method_54(float A_0, bool A_1)
    {
        if (this.method_55())
        {
            this.method_19();
            List<Class714> list = new List<Class714>();
            int num = 0;
            int count = this.method_0().Count;
            while (num < count)
            {
                Class714 item = this.method_0()[num];
                if (((!item.method_29() && (this.method_16() == LayoutType.AutoFit)) || (this.method_16() == LayoutType.Fixed)) && (item.method_8() < 0.3f))
                {
                    list.Add(item);
                }
                num++;
            }
            int num4 = 0;
            int num5 = list.Count;
            while (num4 < num5)
            {
                Class713 class3;
                float num3;
                float num8;
                Class714 class4 = list[num4];
                int num9 = class4.method_16();
                if (num9 > 0)
                {
                    num3 = 0f;
                    int num6 = 2;
                    for (int i = num9 - 1; i >= 0; i--)
                    {
                        num3 += this.method_0()[i].method_8();
                        class3 = this.method_51(i, num6);
                        if (class3 != null)
                        {
                            goto Label_00E1;
                        }
                        num6++;
                    }
                }
                goto Label_0122;
            Label_00E1:
                num8 = (class3.method_2() == 0f) ? (class3.method_0() - num3) : (class3.method_2() - num3);
                class4.method_9((num8 >= 0f) ? num8 : class3.method_31());
            Label_0122:
                num4++;
            }
            list.Clear();
            list = null;
        }
    }

    private bool method_55()
    {
        int num = 0;
        int count = this.method_0().Count;
        while (num < count)
        {
            Class714 class2 = this.method_0()[num];
            if ((class2.method_8() < 0.3f) && ((!class2.method_29() && (this.method_16() == LayoutType.AutoFit)) || (this.method_16() == LayoutType.Fixed)))
            {
                return true;
            }
            num++;
        }
        return false;
    }

    internal bool method_56()
    {
        int num = 0;
        int count = this.method_0().Count;
        while (num < count)
        {
            Class714 class2 = this.method_0()[num];
            if ((class2.method_20() || class2.method_26()) || class2.method_24())
            {
                return true;
            }
            num++;
        }
        return false;
    }

    private int method_57()
    {
        int num = 0;
        int num2 = 0;
        int count = this.dictionary_1.Count;
        while (num2 < count)
        {
            num = Math.Max(num, this.dictionary_1[num2].method_5());
            num2++;
        }
        return num;
    }

    private bool method_58()
    {
        int num = 0;
        int count = this.dictionary_1.Count;
        while (num < count)
        {
            Class712 class2 = this.dictionary_1[num];
            if (class2.method_15())
            {
                return true;
            }
            num++;
        }
        return false;
    }

    public void method_59()
    {
        if (this.bool_0 && !this.bool_1)
        {
            ArrayList list = this.method_42();
            int count = list.Count;
            if (count > this.method_1())
            {
                int num5 = 0;
                int num6 = this.dictionary_1.Count;
                while (num5 < num6)
                {
                    Class712 class2 = this.dictionary_1[num5];
                    int num7 = 0;
                    int num3 = 0;
                    int num4 = class2.method_4();
                    while (num3 < num4)
                    {
                        Class713 class3 = class2.method_29(num3);
                        int num8 = num3 + num7;
                        int num = num8;
                        float num10 = (float) list[num8];
                        while (num < count)
                        {
                            if (Math.Round((double) (((float) list[num]) - num10), 2) == Math.Round((double) class3.method_0(), 2))
                            {
                                break;
                            }
                            num++;
                        }
                        int num9 = num - num8;
                        if (num9 > 1)
                        {
                            class3.method_8(num9);
                            num7 += num9 - 1;
                        }
                        num3++;
                    }
                    num5++;
                }
            }
        }
    }

    public bool method_6()
    {
        return this.bool_8;
    }

    public float method_60(int A_0, Class713 A_1)
    {
        ArrayList list = this.method_42();
        int count = list.Count;
        if ((A_0 + A_1.method_6()) < count)
        {
            return (((float) list[A_0 + A_1.method_6()]) - ((float) list[A_0]));
        }
        return A_1.method_0();
    }

    public float method_61(int A_0, Class713 A_1)
    {
        ArrayList list = this.method_46();
        int count = list.Count;
        if ((A_0 + A_1.method_9()) < count)
        {
            return (float) Math.Round((double) (((float) list[A_0 + A_1.method_9()]) - ((float) list[A_0])), 4);
        }
        return A_1.method_38();
    }

    private float method_62()
    {
        float num = 0f;
        foreach (Class714 class2 in this.method_0())
        {
            num += class2.method_8();
        }
        return num;
    }

    internal float method_63()
    {
        float num = 0f;
        foreach (Class714 class2 in this.method_0())
        {
            num += class2.method_10();
        }
        return num;
    }

    private void method_64()
    {
        this.list_0.Clear();
        this.list_1.Clear();
        this.dictionary_0.Clear();
        for (int i = 0; i < this.method_1(); i++)
        {
            Class714 item = this.method_50(i);
            this.list_0.Add(item);
            if (item.method_20())
            {
                this.list_1.Add(item);
            }
        }
        if (this.dictionary_0.Count > 0)
        {
            foreach (KeyValuePair<int, float> pair in this.dictionary_0)
            {
                int key = pair.Key;
                float num6 = pair.Value;
                List<Class714> list = new List<Class714>();
                int num3 = key + 1;
                int count = this.list_0.Count;
                while (num3 < count)
                {
                    Class714 class4 = this.list_0[num3];
                    if (!class4.method_20())
                    {
                        if (class4.method_24() || (!class4.method_26() && !class4.method_24()))
                        {
                            break;
                        }
                        list.Add(class4);
                    }
                    num3++;
                }
                if (list.Count > 0)
                {
                    Class714 class5 = this.method_66(this.list_0, key);
                    if (class5 != null)
                    {
                        float num9 = 0f;
                        float num7 = 0f;
                        this.method_65(list, out num9, out num7);
                        if ((Class59.smethod_4(num6, num9 + class5.method_8(), 0.01f) == 1) || (Class59.smethod_4(num6, num7 + class5.method_10(), 0.01f) == 1))
                        {
                            float num8 = num6 - (class5.method_10() + num7);
                            if (num8 > 0f)
                            {
                                float num2 = num8 / ((float) (list.Count + 1));
                                class5.method_11(class5.method_10() + num2);
                                foreach (Class714 class3 in list)
                                {
                                    class3.method_11(class3.method_10() + num2);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_65(List<Class714> A_0, out float A_1, out float A_2)
    {
        A_1 = 0f;
        A_2 = 0f;
        if ((A_0 != null) && (A_0.Count > 0))
        {
            foreach (Class714 class2 in A_0)
            {
                A_1 += class2.method_8();
                A_2 += class2.method_10();
            }
        }
    }

    private Class714 method_66(List<Class714> A_0, int A_1)
    {
        Class714 class3;
        if ((A_0 == null) || (A_1 < 0))
        {
            return null;
        }
        using (List<Class714>.Enumerator enumerator = A_0.GetEnumerator())
        {
            Class714 current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.method_16() == A_1)
                {
                    goto Label_002F;
                }
            }
            return null;
        Label_002F:
            class3 = current;
        }
        return class3;
    }

    public float method_67()
    {
        float num = 0f;
        foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
        {
            float num2 = 0f;
            for (int i = 0; i < pair.Value.method_4(); i++)
            {
                num2 += pair.Value.method_18(i).method_0();
            }
            num = Math.Max(num, num2);
        }
        return num;
    }

    private ArrayList method_68(List<Class712> A_0)
    {
        ArrayList list = new ArrayList();
        float num = 0f;
        list.Add(num);
        Class712 class2 = A_0[0];
        int num2 = 0;
        int num3 = class2.method_4();
        while (num2 < num3)
        {
            float num4 = class2.method_18(num2).method_0();
            int num5 = 0;
            int count = A_0.Count;
            while (num5 < count)
            {
                num4 = Math.Max(num4, A_0[num5].method_18(num2).method_0());
                num5++;
            }
            num = (float) Math.Round((double) (num + num4), 2);
            if (!list.Contains(num))
            {
                list.Add(num);
            }
            num2++;
        }
        list.Sort();
        return list;
    }

    private ArrayList method_69(Dictionary<int, Class712> A_0)
    {
        List<Class712> list = new List<Class712>();
        foreach (KeyValuePair<int, Class712> pair in A_0)
        {
            list.Add(pair.Value);
        }
        ArrayList list2 = this.method_68(list);
        list.Clear();
        return list2;
    }

    public bool method_7()
    {
        for (int i = 0; i < this.method_0().Count; i++)
        {
            if (!this.method_0()[i].method_29() && this.method_0()[i].method_14())
            {
                return true;
            }
        }
        return false;
    }

    public void method_70(Class712 A_0, Dictionary<int, Class712> A_1)
    {
        int num = 0;
        int num2 = 0;
        int num3 = A_0.method_4();
        while (num2 < num3)
        {
            Class713 class3;
            Class713 class2 = A_0.method_18(num2);
            if (class2.method_9() > 0)
            {
                num += class2.method_9();
                if (class2.method_17() == CellMerge.Continue)
                {
                    for (int i = A_1.Count - 1; i >= 0; i--)
                    {
                        class3 = A_1[i].method_30(num);
                        if (class3.method_17() != CellMerge.Continue)
                        {
                            goto Label_0070;
                        }
                    }
                }
            }
            goto Label_0120;
        Label_0070:
            if ((class3.method_42() == FtsWidth.Percentage) && (class2.method_42() != FtsWidth.Percentage))
            {
                class2.method_39(class3.method_38());
                class2.method_32(class3.method_31());
                class2.method_43(class3.method_42());
                class2.method_41(class3.method_40());
            }
            else
            {
                class2.method_1(class3.method_0());
                class2.method_5(class3.method_4());
                class2.method_20(class3.method_19());
                class2.method_32(class3.method_31());
                class2.method_8(class3.method_9());
                class2.method_43(class3.method_42());
                class2.method_41(class3.method_40());
            }
        Label_0120:
            num2++;
        }
    }

    public void method_71(int A_0, Class712 A_1)
    {
        if (A_1.method_17())
        {
            this.method_70(A_1, this.dictionary_1);
        }
        if ((this.float_0 > 0f) && this.bool_0)
        {
            this.bool_0 = this.float_0 == A_1.method_14();
        }
        if (((this.float_0 == 0f) && (A_1.method_14() == 0f)) && (!this.bool_3 || this.bool_3))
        {
            this.bool_3 = true;
        }
        else
        {
            this.bool_3 = false;
        }
        this.float_0 = Math.Max(this.float_0, A_1.method_14());
        if ((this.method_1() > 0) && this.bool_1)
        {
            this.bool_1 = this.method_1() == A_1.method_4();
        }
        this.ushort_0 = (ushort) Math.Max(this.method_1(), A_1.method_4());
        if (!this.bool_9 && A_1.method_15())
        {
            this.bool_9 = true;
        }
        if ((this.bool_4 && (this.ushort_1 > 0)) && (this.ushort_1 != A_1.method_5()))
        {
            this.bool_4 = false;
        }
        this.ushort_1 = (ushort) Math.Max(this.ushort_1, A_1.method_5());
        float num = A_1.method_37();
        if (this.float_1 == float.MaxValue)
        {
            this.float_1 = num;
        }
        if ((this.float_1 != num) && (num != 1f))
        {
            this.bool_2 = false;
        }
        if (this.bool_5 && !A_1.method_0())
        {
            this.bool_5 = false;
        }
        if (this.bool_6 && !A_1.method_1())
        {
            this.bool_6 = false;
        }
        if (this.bool_7 && !A_1.method_2())
        {
            this.bool_7 = false;
        }
        if (!this.bool_8 && A_1.method_11())
        {
            this.bool_8 = true;
        }
        this.dictionary_1.Add(A_0, A_1);
    }

    private void method_72(ushort A_0, float A_1)
    {
        this.method_73(A_0, A_1, false);
    }

    private void method_73(ushort A_0, float A_1, bool A_2)
    {
        int num = 0;
        int count = this.dictionary_1.Count;
        while (num < count)
        {
            Class712 class2 = this.dictionary_1[num];
            if (!A_2)
            {
                if (A_0 < class2.method_4())
                {
                    class2.method_18(A_0).method_1(A_1);
                }
            }
            else if (A_0 < class2.method_4())
            {
                Class713 class1 = class2.method_18(A_0);
                class1.method_1(class1.method_0() + A_1);
            }
            num++;
        }
    }

    public bool method_8()
    {
        for (int i = 0; i < this.method_0().Count; i++)
        {
            if (!this.method_0()[i].method_29() && this.method_0()[i].method_20())
            {
                return true;
            }
        }
        return false;
    }

    public ArrayList method_9()
    {
        return this.method_42();
    }

    void IDisposable.Dispose()
    {
        if (this.dictionary_1 != null)
        {
            foreach (KeyValuePair<int, Class712> pair in this.dictionary_1)
            {
                if (pair.Value != null)
                {
                    pair.Value.System.IDisposable.Dispose();
                }
            }
            this.dictionary_1.Clear();
            this.dictionary_1 = null;
        }
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.arrayList_0 != null)
        {
            this.arrayList_0.Clear();
            this.arrayList_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
    }
}

