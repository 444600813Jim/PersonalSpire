using System;
using System.Collections;

internal class Class374
{
    private ArrayList arrayList_0 = new ArrayList();
    [ThreadStatic]
    private static ArrayList arrayList_1;
    [ThreadStatic]
    private static ArrayList arrayList_2;
    [ThreadStatic]
    private static ArrayList arrayList_3;
    [ThreadStatic]
    private static Class374 class374_0;
    [ThreadStatic]
    private static string string_0;

    public void method_0()
    {
        this.arrayList_0.Clear();
    }

    public static Class374 smethod_0()
    {
        if (class374_0 == null)
        {
            class374_0 = new Class374();
            arrayList_1 = new ArrayList();
            arrayList_2 = new ArrayList();
            arrayList_3 = new ArrayList();
            string_0 = string.Empty;
        }
        return class374_0;
    }
}

