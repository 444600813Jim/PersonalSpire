using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
internal class Class712 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private Class711 class711_0;
    private Dictionary<int, Class713> dictionary_0;
    private float float_0;
    private int? nullable_0;
    private int? nullable_1;

    public Class712()
    {
        this.dictionary_0 = new Dictionary<int, Class713>();
        this.bool_1 = true;
        this.bool_5 = true;
        this.bool_6 = true;
        this.dictionary_0 = new Dictionary<int, Class713>();
    }

    public Class712(Class711 A_0) : this()
    {
        this.class711_0 = A_0;
    }

    public Class712(float A_0)
    {
        this.dictionary_0 = new Dictionary<int, Class713>();
        this.bool_1 = true;
        this.bool_5 = true;
        this.bool_6 = true;
        this.float_0 = A_0;
    }

    public bool method_0()
    {
        return this.bool_1;
    }

    public bool method_1()
    {
        return this.bool_5;
    }

    public bool method_10()
    {
        return this.method_36();
    }

    public bool method_11()
    {
        return this.bool_7;
    }

    public bool method_12()
    {
        return this.bool_4;
    }

    public void method_13(float A_0)
    {
        this.float_0 = A_0;
    }

    public float method_14()
    {
        return this.method_33();
    }

    public bool method_15()
    {
        return this.bool_0;
    }

    public bool method_16()
    {
        return this.bool_3;
    }

    public bool method_17()
    {
        return this.bool_2;
    }

    public Class713 method_18(int A_0)
    {
        return this.method_29(A_0);
    }

    public Class711 method_19()
    {
        return this.class711_0;
    }

    public bool method_2()
    {
        return this.bool_6;
    }

    public bool method_20(int A_0)
    {
        return this.dictionary_0.ContainsKey(A_0);
    }

    public Class712 method_21()
    {
        return new Class712(this.class711_0) { bool_5 = this.method_1(), bool_6 = this.method_2(), bool_1 = this.method_0(), bool_0 = this.method_15(), bool_2 = this.method_17(), bool_3 = this.method_16(), bool_4 = this.method_12(), bool_7 = this.method_11() };
    }

    public void method_22()
    {
        if (this.bool_0)
        {
            List<Class713> list = new List<Class713>();
            List<Class713> list2 = new List<Class713>();
            int count = this.dictionary_0.Count;
            float num5 = 0f;
            for (int i = 0; i < count; i++)
            {
                Class713 item = this.dictionary_0[i];
                if (item.method_30())
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
                foreach (Class713 class3 in list)
                {
                    num4 += (float) Math.Round((double) (class3.method_19() - class3.method_0()));
                    class3.method_1(class3.method_19());
                }
                num5 = num4 / ((float) list2.Count);
            }
            if ((list2.Count > 0) && (num5 != 0f))
            {
                int num2 = 0;
                int num3 = list2.Count;
                while (num2 < num3)
                {
                    float num7 = list2[num2].method_0() - num5;
                    if (num7 >= list2[num2].method_19())
                    {
                        list2[num2].method_1(num7);
                    }
                    else
                    {
                        num5 += num5 / ((float) (num3 - (num2 + 1)));
                    }
                    num2++;
                }
            }
            list.Clear();
            list2.Clear();
        }
    }

    public void method_23(float A_0)
    {
        float num = A_0 / this.method_14();
        foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
        {
            pair.Value.method_1(pair.Value.method_0() * num);
        }
    }

    public void method_24(float A_0)
    {
        if (this.method_10() && (!this.method_10() || (this.method_14() != 0f)))
        {
            List<Class713> list = new List<Class713>();
            int count = this.dictionary_0.Count;
            float num3 = A_0;
            for (int i = 0; i < count; i++)
            {
                Class713 item = this.dictionary_0[i];
                if (item.method_21())
                {
                    list.Add(item);
                }
                else if (item.method_0() > 0f)
                {
                    num3 -= item.method_0();
                }
                else if (item.method_19() > 0f)
                {
                    num3 -= item.method_19();
                }
                else
                {
                    num3 -= item.method_4();
                }
            }
            if (list.Count > 0)
            {
                float num4 = num3 / ((float) list.Count);
                foreach (Class713 class2 in list)
                {
                    class2.method_1(num4);
                }
            }
            list.Clear();
        }
    }

    internal void method_25(float A_0, float A_1)
    {
        foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
        {
            pair.Value.method_1(pair.Value.method_0() * A_1);
        }
    }

    internal Class721 method_26(float A_0)
    {
        return this.method_27(this.dictionary_0, A_0);
    }

    internal Class721 method_27(Dictionary<int, Class713> A_0, float A_1)
    {
        Class721 class2 = new Class721();
        Dictionary<int, Class713> dictionary = new Dictionary<int, Class713>();
        float num = 0f;
        float num2 = A_1 / ((float) A_0.Count);
        foreach (KeyValuePair<int, Class713> pair in A_0)
        {
            Class713 class3 = pair.Value;
            if (class3.method_35() <= num2)
            {
                class3.method_1(class3.method_37());
                A_1 -= class3.method_37();
            }
            else if ((A_0.Count == 1) && (class3.method_37() > num2))
            {
                class3.method_1(num2);
                class2.method_9(new ushort?((ushort) pair.Value.method_10()));
                class2.method_3(num2);
                class2.method_5(class3.method_19());
                class2.method_7(class3.method_40());
                class2.float_4 = class3.method_31();
                class2.method_11(true);
            }
            else
            {
                dictionary.Add(pair.Key, pair.Value);
                num += class3.method_19();
            }
        }
        if (dictionary.Count > 0)
        {
            if (dictionary.Count < A_0.Count)
            {
                return this.method_27(dictionary, A_1);
            }
            foreach (KeyValuePair<int, Class713> pair2 in dictionary)
            {
                Class713 class4 = pair2.Value;
                if (num != 0f)
                {
                    class4.method_1(A_1 * (class4.method_19() / num));
                }
                else
                {
                    class4.method_1(num2);
                }
            }
        }
        return class2;
    }

    public float method_28(int A_0)
    {
        return this.dictionary_0[A_0].method_0();
    }

    public Class713 method_29(int A_0)
    {
        return this.dictionary_0[A_0];
    }

    public int method_3()
    {
        return this.method_34();
    }

    public Class713 method_30(int A_0)
    {
        int num = 0;
        if (A_0 != 0)
        {
            for (int i = 0; i < this.dictionary_0.Count; i++)
            {
                num += this.dictionary_0[i].method_9();
                if (num == A_0)
                {
                    return this.dictionary_0[i];
                }
            }
        }
        return this.dictionary_0[0];
    }

    public void method_31(int A_0, Class713 A_1)
    {
        if (!this.bool_0 && A_1.method_30())
        {
            this.bool_0 = A_1.method_30();
        }
        if (this.bool_1 && (A_1.method_42() != FtsWidth.Point))
        {
            this.bool_1 = false;
        }
        if (this.bool_5 && (A_1.method_42() != FtsWidth.Auto))
        {
            this.bool_5 = false;
        }
        if (this.bool_6 && (A_1.method_42() != FtsWidth.Percentage))
        {
            this.bool_6 = false;
        }
        if (!this.bool_7 && ((A_1.method_42() == FtsWidth.Auto) || (A_1.method_42() == FtsWidth.None)))
        {
            this.bool_7 = true;
        }
        if ((A_1.method_17() == CellMerge.Continue) && !this.bool_2)
        {
            this.bool_2 = true;
        }
        if ((A_1.method_12() == CellMerge.Continue) && !this.bool_3)
        {
            this.bool_3 = true;
        }
        if (A_1.method_14() && !this.bool_4)
        {
            this.bool_4 = true;
        }
        this.dictionary_0.Add(A_0, A_1);
    }

    public void method_32(int A_0, Class713 A_1, int A_2)
    {
        A_1.method_23(true);
        A_1.method_25(true);
        A_1.method_27(A_2);
        this.dictionary_0.Add(A_0, A_1);
    }

    private float method_33()
    {
        float num = 0f;
        if (!this.method_11())
        {
            foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
            {
                num += pair.Value.method_0();
            }
        }
        return num;
    }

    private int method_34()
    {
        int num = 0;
        foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
        {
            if (pair.Value.method_0() == 0f)
            {
                num++;
            }
        }
        return num;
    }

    private int method_35()
    {
        int num = 0;
        foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
        {
            num += pair.Value.method_9();
        }
        return num;
    }

    private bool method_36()
    {
        bool flag = false;
        using (Dictionary<int, Class713>.Enumerator enumerator = this.dictionary_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                KeyValuePair<int, Class713> current = enumerator.Current;
                if (current.Value.method_21())
                {
                    goto Label_0032;
                }
            }
            return flag;
        Label_0032:
            flag = true;
        }
        return flag;
    }

    internal float method_37()
    {
        float num = 0f;
        foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
        {
            num += pair.Value.method_38();
        }
        return (float) Math.Round((double) num, 4);
    }

    public int method_4()
    {
        return this.dictionary_0.Count;
    }

    public int method_5()
    {
        return this.method_35();
    }

    public int? method_6()
    {
        return this.nullable_0;
    }

    public void method_7(int? A_0)
    {
        this.nullable_0 = A_0;
    }

    public int? method_8()
    {
        return this.nullable_1;
    }

    public void method_9(int? A_0)
    {
        this.nullable_1 = A_0;
    }

    void IDisposable.Dispose()
    {
        if (this.dictionary_0 != null)
        {
            foreach (KeyValuePair<int, Class713> pair in this.dictionary_0)
            {
                if (pair.Value != null)
                {
                    pair.Value.System.IDisposable.Dispose();
                }
            }
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
    }
}

