using Spire.Doc;
using System;
using System.Collections;

internal class Class292
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private static readonly Hashtable hashtable_4 = new Hashtable();
    private static readonly Hashtable hashtable_5 = new Hashtable();
    private static readonly Hashtable hashtable_6 = new Hashtable();
    private static readonly Hashtable hashtable_7 = new Hashtable();
    private const int int_0 = 0;
    private const int int_1 = 2;
    private const int int_2 = -1;
    private const int int_3 = -1;

    static Class292()
    {
        Class791.smethod_0(new object[] { 0, RelativeHorizontalPosition.Column, 1, RelativeHorizontalPosition.Margin, 2, RelativeHorizontalPosition.Page }, hashtable_0, hashtable_1);
        Class791.smethod_0(new object[] { 0, RelativeVerticalPosition.Margin, 2, RelativeVerticalPosition.Paragraph, 1, RelativeVerticalPosition.Page }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { -1, ShapeHorizontalAlignment.None, 0, ShapeHorizontalAlignment.Left, -4, ShapeHorizontalAlignment.Center, -8, ShapeHorizontalAlignment.Right, -12, ShapeHorizontalAlignment.Inside, -16, ShapeHorizontalAlignment.Outside }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { -1, ShapeVerticalAlignment.None, 0, ShapeVerticalAlignment.Inline, -4, ShapeVerticalAlignment.Top, -8, ShapeVerticalAlignment.Center, -12, ShapeVerticalAlignment.Bottom, -16, ShapeVerticalAlignment.Inside, -20, ShapeVerticalAlignment.Outside }, hashtable_6, hashtable_7);
    }

    private Class292()
    {
    }

    internal static RelativeHorizontalPosition smethod_0(int A_0)
    {
        return (RelativeHorizontalPosition) Class791.smethod_3(hashtable_0, A_0, RelativeHorizontalPosition.Column);
    }

    internal static int smethod_1(RelativeHorizontalPosition A_0)
    {
        return (int) Class791.smethod_3(hashtable_1, A_0, 0);
    }

    internal static RelativeVerticalPosition smethod_2(int A_0)
    {
        return (RelativeVerticalPosition) Class791.smethod_3(hashtable_2, A_0, RelativeVerticalPosition.Margin);
    }

    internal static int smethod_3(RelativeVerticalPosition A_0)
    {
        return (int) Class791.smethod_3(hashtable_3, A_0, 2);
    }

    internal static object smethod_4(int A_0)
    {
        return Class791.smethod_6(hashtable_4, A_0);
    }

    internal static int smethod_5(ShapeHorizontalAlignment A_0)
    {
        return (int) Class791.smethod_3(hashtable_5, A_0, -1);
    }

    internal static object smethod_6(int A_0)
    {
        return Class791.smethod_6(hashtable_6, A_0);
    }

    internal static int smethod_7(ShapeVerticalAlignment A_0)
    {
        return (int) Class791.smethod_3(hashtable_7, A_0, -1);
    }
}

